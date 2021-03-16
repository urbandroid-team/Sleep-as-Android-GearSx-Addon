#include <sensor.h>
#include <efl_extension.h>
#include <dlog.h>
#include <device/power.h>
#include <app_alarm.h>
#include "logging.h"
#include "sleepasandroidnativeservice.h"


#include "sleep_util.h"
#include "sleep_sap.h"

// Sampling frequency.. how often do we try to send data, if needed.
#define SAMPLING_TIME_SEC 10
#define MAX_BUFFER_LENGTH 2880

//#define ACC_SAMPLING_PERIOD_MS 1000
#define REPEATING_ALARM_PERIOD_SEC 600

static int acc_sampling_period_ms = 100;

bool repeating_alarm_debug = true; // Repeating to try with alarm_schedule_after_delay. Set to false to test with non-repeating alarm_schedule_once_after_delay

static sensor_listener_h listener;
static sensor_h sensor;
static int acc_max_batch_count;
static int acc_max_batch_latency_ms = 0;
int acc_alarm_id;

static int batch_size = 1;

bool paused = false;

static float lastX, lastY, lastZ;
// Counter of total accel values received.
static long values_total = 0;

typedef struct motion_data {
	float min_sum;
	float max_sum;
	float avg_sum;
	float new_acti_max;
} motion_data_s;

// Motion data to be send.
static motion_data_s motion_buffer[MAX_BUFFER_LENGTH];
// How many elements we have in the motion buffer.
static int motion_buffer_pointer = 0;

static float current_min_sum = 10000;
static float current_max_sum = 0;
static float current_total_sum = 0;
static int current_sum_count = 0;
//static int current_sum_max_count = SAMPLING_TIME_SEC * 1000 / ACC_SAMPLING_PERIOD_MS;
static int current_sum_max_count = 0;
static float current_new_acti_max = 0;

static gboolean is_acc_sensor_batching() {
	return (acc_max_batch_count > 0);
}

static char* compose_data_message(motion_data_s buffer[], int buffer_pointer) {
	logf_to_file_with_ts("Acc: compose_data_message");

	Eina_Strbuf *strbuf = eina_strbuf_new();
	if (addon_version >= 1462) {
		eina_strbuf_append_printf(strbuf, "%s", "NEW_ACTI_DATA");
	} else {
		eina_strbuf_append_printf(strbuf, "%s", "DATA");
	}
	for (int i = 0; i < buffer_pointer; i++) {
		if (i > 0) {
			eina_strbuf_append_printf(strbuf, ",");
		}
		if (addon_version >= 1462) {
			eina_strbuf_append_printf(strbuf, "%.3f,0,0,%.3f", buffer[i].max_sum, buffer[i].new_acti_max);
		} else {
			eina_strbuf_append_printf(strbuf, "%.3f,%.3f,%.3f", buffer[i].max_sum, buffer[i].min_sum, buffer[i].avg_sum);
		}
	}

	char *txt = eina_strbuf_string_steal(strbuf);
	eina_strbuf_free(strbuf);

	return txt;
}

static void push_aggregate_to_batch() {
	logf_to_file_with_ts("Acc: push_aggregate_to_batch, current_sum_count: %d", current_sum_count);

	motion_buffer[motion_buffer_pointer].min_sum = current_min_sum;
	motion_buffer[motion_buffer_pointer].max_sum = current_max_sum;
	motion_buffer[motion_buffer_pointer].new_acti_max = current_new_acti_max;
	if (current_sum_count > 0) {
		motion_buffer[motion_buffer_pointer].avg_sum = current_total_sum / current_sum_count;
	} else {
		motion_buffer[motion_buffer_pointer].avg_sum = 0;
	}

	motion_buffer_pointer = imin(motion_buffer_pointer+1, MAX_BUFFER_LENGTH - 1);

	current_min_sum = 10000;
	current_max_sum = 0;
	current_total_sum = 0;
	current_sum_count = 0;
	current_new_acti_max = 0;
}

static void send_batch() {
	logf_to_file_with_ts("Acc: send_batch, motion_buffer_pointer: %d", motion_buffer_pointer);

	char* txt = compose_data_message(motion_buffer, motion_buffer_pointer);

	if (send_data(txt) == SEND_DATA_SUCCESS) {
		motion_buffer_pointer = 0;
	} else if (send_data(txt) == SEND_DATA_BUFFER_FULL) {
		// go back a few values and lower the buffer to hopefully be able to send it over to Sleep in the next send_motion_cb
		motion_buffer_pointer = imax(0, motion_buffer_pointer - 10);
	}

	free(txt);
}

static void start_acc_timer() {
//	logf_to_file_with_ts("Acc: start_acc_timer");

	char retstr[2];

	app_control_h app_control = NULL;
	app_control_create(&app_control);
	app_control_set_operation(app_control, APP_CONTROL_OPERATION_DEFAULT);
	app_control_add_extra_data(app_control, "app_action", "acc_timer");

	int ret;

	if (repeating_alarm_debug) {
		app_control_set_app_id(app_control, "com.urbandroid.sleep.service");
		ret = alarm_schedule_after_delay(app_control, 0, REPEATING_ALARM_PERIOD_SEC, &acc_alarm_id);
	} else {
		alarm_cancel(acc_alarm_id);
		app_control_set_app_id(app_control, "com.urbandroid.sleep.ui");
		ret = alarm_schedule_once_after_delay(app_control, acc_max_batch_latency_ms/1000, &acc_alarm_id);
	}

	switch (ret) {
		case ALARM_ERROR_NONE:
			strcpy(retstr, "0");
			break;
		case ALARM_ERROR_INVALID_PARAMETER:
			strcpy(retstr, "1");
			break;
		case ALARM_ERROR_INVALID_TIME:
			strcpy(retstr, "2");
			break;
		case ALARM_ERROR_CONNECTION_FAIL:
			strcpy(retstr, "3");
			break;
		case ALARM_ERROR_PERMISSION_DENIED:
			strcpy(retstr, "4");
			break;
		case ALARM_ERROR_NOT_PERMITTED_APP:
			strcpy(retstr, "5");
			break;
		default:
			break;
	}

	logf_to_file_with_ts("Acc: start_acc_timer, alarm scheduled, return value: %s", retstr);

//	dlog_print(DLOG_INFO, TAG, "alarm_schedule_once_after_delay ret %d %s", ret, retstr);
}

//sensor event callback implementation
static void acc_event_callback(sensor_h sensor, sensor_event_s *event, void *user_data)
{
	if (!repeating_alarm_debug) {
		start_acc_timer();
	}

	watch_awake_callback();

	sensor_type_e type;
    sensor_get_type(sensor, &type);
    if(type == SENSOR_ACCELEROMETER)    {
        float x = event->values[0];
        float y = event->values[1];
        float z = event->values[2];

    	if (values_total > 0) {
    		float sum = fabs(x - lastX) + fabs(y - lastY) + fabs(z - lastZ);
    		if (sum > current_max_sum) {
    			current_max_sum = sum;
    		}
    		if (sum < current_min_sum) {
    			current_min_sum = sum;
    		}
    		current_total_sum = current_total_sum + sum;
    		current_sum_count++;
    	}

    	current_new_acti_max = fmax(current_new_acti_max, sqrt((x * x) + (y * y) + (z * z)));

    	values_total++;

    	lastX = x;
    	lastY = y;
    	lastZ = z;

    	//dlog_print(DLOG_INFO, TAG, "accelerometer: %f, %f, %f", event->values[0], event->values[1], event->values[2]);

    	char *ts = get_sensor_event_time_human_readable(event->timestamp);
    	logf_to_file_with_ts("Acc: acc_event_callback, ts: %s ", ts);

    	if (current_sum_count >= current_sum_max_count) {
    		push_aggregate_to_batch();
    	}

    	if (motion_buffer_pointer >= batch_size) {
    		send_batch();
    	}
    }
}

void start_accelerometer() {
	logf_to_file_with_ts("Acc: start_accelerometer");
	sensor_type_e type = SENSOR_ACCELEROMETER;

	if (sensor_get_default_sensor(type, &sensor) == SENSOR_ERROR_NONE)
	{

		sensor_get_max_batch_count(sensor, &acc_max_batch_count);

		if (!is_acc_sensor_batching()) {
			device_power_request_lock(POWER_LOCK_CPU, 0);
		} else {
			// Set adaptive accelerometer sampling period based on the max_batch_count of this specific watch model
			// We have to spread sensor data over 10 minutes (minimum RTC wakeup alarm period)
			acc_sampling_period_ms = 10*60*1000 / acc_max_batch_count;
			acc_max_batch_latency_ms = acc_sampling_period_ms * acc_max_batch_count;
		}

		current_sum_max_count = SAMPLING_TIME_SEC * 1000 / acc_sampling_period_ms;

		log_sensor_error("Acc: start_accelerometer sensor_create_listener", sensor_create_listener(sensor, &listener));
		log_sensor_error("Acc: start_accelerometer sensor_listener_set_max_batch_latency", sensor_listener_set_max_batch_latency(listener, acc_max_batch_latency_ms));
		log_sensor_error("Acc: start_accelerometer sensor_listener_set_event_cb", sensor_listener_set_event_cb(listener, acc_sampling_period_ms, acc_event_callback, NULL));
		log_sensor_error("Acc: start_accelerometer sensor_listener_set_interval", sensor_listener_set_interval(listener, acc_sampling_period_ms));
		log_sensor_error("Acc: start_accelerometer sensor_listener_set_option", sensor_listener_set_option(listener, SENSOR_OPTION_ALWAYS_ON));
		log_sensor_error("Acc: start_accelerometer sensor_listener_start", sensor_listener_start(listener));
    	dlog_print(DLOG_INFO, TAG, "Sensor started");
    	start_acc_timer();
	}
}

void stop_accelerometer() {
	logf_to_file_with_ts("Acc: stop_accelerometer");
	// TODO: Add error logging.
	int err = sensor_listener_stop(listener);
	err = sensor_destroy_listener(listener);
}

void terminate_acc() {
	logf_to_file_with_ts("Acc: terminate_acc");
	stop_accelerometer();
	alarm_cancel(acc_alarm_id);

	if (!is_acc_sensor_batching()) {
		device_power_release_lock(POWER_LOCK_CPU);
	}
}

void set_batch_size(int size) {
	// Sometimes we receive a very large number (like 129), maybe because of some bluetooth error another character is appended to the end?
	if (size > 12) {
		size = 12;
	}
	batch_size = size;
	dlog_print(DLOG_INFO, TAG, "Setting batch size: %d", batch_size);
}
