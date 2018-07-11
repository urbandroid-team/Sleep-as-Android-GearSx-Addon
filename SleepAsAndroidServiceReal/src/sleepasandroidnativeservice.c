#include "sleepasandroidnativeservice.h"

#include "common.h"
#include "sleep_sap.h"

#include <device/haptic.h>
#include <device/power.h>
#include <efl_extension.h>
#include <tizen.h>
#include <sensor.h>
#include <service_app.h>
#include <stdint.h>

// Sampling frequency.. how often do we try to send data, if needed.
#define SAMPLING_TIME_SEC 10
#define MAX_BUFFER_LENGTH 100

Ecore_Timer* send_motion_timer;
Ecore_Timer* update_ui_timer;
Ecore_Timer* alarm_timer = NULL;
Ecore_Timer* hint_timer = NULL;
Ecore_Timer* hr_timer = NULL;

static bool is_tracking = false;
static bool hr_enabled = false;

// Acceleromter.
static sensor_listener_h listener;
static sensor_h sensor;

// HR.
static sensor_listener_h hr_listener;
static sensor_h hr_sensor;

static int batch_size = 1;
// Version of application on phone (of the addon).
static int addon_version = -1;

static float lastX, lastY, lastZ;
// Counter of total accel values received.
static long values_total = 0;

static float current_min_sum = 10000;
static float current_max_sum = 0;
static float current_total_sum = 0;
static int current_sum_count = 0;
static float current_new_acti_max = 0;

static gint64 paused_till = 0;

// What pause state does UI see.
static bool ui_pause_secs_remaining = 0;

static bool hr_supported = false;

typedef struct motion_data {
	float min_sum;
	float max_sum;
	float avg_sum;
	float new_acti_max;
} motion_data_s;

// Motion data to be send.
static motion_data_s motion_buffer[300];
// How many elements we have in the motion buffer.
static int motion_buffer_size = 0;

//sensor event callback implementation
static void sensor_event_callback(sensor_h sensor, sensor_event_s *event, void *user_data)
{
    sensor_type_e type;
    sensor_get_type(sensor, &type);
    if(type == SENSOR_ACCELEROMETER)
    {
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
    }
}

static void start_hr();
static void stop_hr();

static Eina_Bool restart_hrm(void *data EINA_UNUSED) {
	start_hr();
	return ECORE_CALLBACK_CANCEL;
}

float hrm_sum = 0;
int hrm_values = 0;

static void hr_sensor_event_callback(sensor_h sensor, sensor_event_s *event, void *user_data) {
	sensor_type_e type;
	sensor_get_type(sensor, &type);
	float hrm_value;

	switch (type) {
		case SENSOR_HRM:
			hrm_value = event->values[0];
			if (hrm_value != 0.0f) {
				dlog_print(DLOG_INFO, TAG, "HRM: %f" , hrm_value);
			}
			if (hrm_value > 20.0f && hrm_value < 200.0f) {
				// We got a real value.. let's sum them till we have 10 samples
				hrm_sum += hrm_value;
				hrm_values++;
				if (hrm_values >= 10) {
						// We have enough data -> Send it and let's measure again in 5 minutes.
					hr_timer = ecore_timer_add(5 * 60, restart_hrm, NULL);

					Eina_Strbuf *strbuf = eina_strbuf_new();
					eina_strbuf_append_printf(strbuf, "%s%f", "HR_DATA", hrm_sum / hrm_values);
					char *txt = eina_strbuf_string_steal(strbuf);
					eina_strbuf_free(strbuf);

					send_data(txt);
					free(txt);

					stop_hr();
					hrm_values = 0;
					hrm_sum = 0;
				}
			}
			break;
		default:
			dlog_print(DLOG_ERROR, TAG, "Not an HRM event");
	}
}

static bool check_hr_supported() {
	sensor_type_e type = SENSOR_HRM;

	bool supported;
	int error = sensor_is_supported(type, &supported);
	if (error != SENSOR_ERROR_NONE) {
		dlog_print(DLOG_ERROR, TAG, "sensor_is_supported error: %d", error);
		return false;
	}

	if(supported){
		dlog_print(DLOG_DEBUG, TAG, "HRM is %s supported", supported ? "" : " not");
	}

	return supported;
}

static void start_accelerometer() {
	sensor_type_e type = SENSOR_ACCELEROMETER;

	if (sensor_get_default_sensor(type, &sensor) == SENSOR_ERROR_NONE)
	{
	    if (sensor_create_listener(sensor, &listener) == SENSOR_ERROR_NONE
	        && sensor_listener_set_event_cb(listener, 100, sensor_event_callback, NULL) == SENSOR_ERROR_NONE
	    	&& sensor_listener_set_option(listener, SENSOR_OPTION_ALWAYS_ON) == SENSOR_ERROR_NONE)
	    {
	        if (sensor_listener_start(listener) == SENSOR_ERROR_NONE)
	        {
	        	dlog_print(DLOG_INFO, TAG, "Sensor started");
	        }
	    }
	}
}

static void stop_accelerometer() {
	// TODO: Add error logging.
	int err = sensor_listener_stop(listener);
	err = sensor_destroy_listener(listener);
}

static void start_hr() {
	sensor_type_e type = SENSOR_HRM;

	if (sensor_get_default_sensor(type, &hr_sensor) == SENSOR_ERROR_NONE)
	{
	    if (sensor_create_listener(hr_sensor, &hr_listener) == SENSOR_ERROR_NONE
	        && sensor_listener_set_event_cb(hr_listener, 100, hr_sensor_event_callback, NULL) == SENSOR_ERROR_NONE
			&& sensor_listener_set_option(hr_listener, SENSOR_OPTION_ALWAYS_ON) == SENSOR_ERROR_NONE)
	    {
	        if (sensor_listener_start(hr_listener) == SENSOR_ERROR_NONE)
	        {
	        	dlog_print(DLOG_INFO, TAG, "HR Sensor started");
	        }
	    }
	}
}

static void stop_hr() {
	// TODO: Add error logging.
	int err = sensor_listener_stop(hr_listener);
	err = sensor_destroy_listener(hr_listener);
}

static int pause_seconds_remaining() {
	time_t now;
	time(&now);
	if (paused_till == 0 || paused_till < now) {
		return 0;
	}

	return paused_till - now;
}

static bool is_paused() {
	return pause_seconds_remaining() > 0;
}

static Eina_Bool send_motion_cb(void *data EINA_UNUSED) {
	if (motion_buffer_size >= MAX_BUFFER_LENGTH -1) {
		dlog_print(DLOG_ERROR, TAG, "Ignoring motion data, buffer full");
		return ECORE_CALLBACK_RENEW;
	}

	if (is_paused()) {
		current_min_sum = 0;
		current_max_sum = 0;
		current_total_sum = 0;
		current_new_acti_max = 0;
	}

	motion_buffer[motion_buffer_size].min_sum = current_min_sum;
	motion_buffer[motion_buffer_size].max_sum = current_max_sum;
	motion_buffer[motion_buffer_size].new_acti_max = current_new_acti_max;
	if (current_sum_count > 0) {
		motion_buffer[motion_buffer_size].avg_sum = current_total_sum / current_sum_count;
	} else {
		motion_buffer[motion_buffer_size].avg_sum = 0;
	}

	motion_buffer_size++;

	dlog_print(DLOG_INFO, TAG, "Buffer size: %d Max sum: %f", motion_buffer_size, current_max_sum);

	if (motion_buffer_size >= batch_size) {
		Eina_Strbuf *strbuf = eina_strbuf_new();
		if (addon_version >= 1462) {
			eina_strbuf_append_printf(strbuf, "%s", "NEW_ACTI_DATA");
		} else {
			eina_strbuf_append_printf(strbuf, "%s", "DATA");
		}
		for (int i = 0; i < motion_buffer_size; i++) {
			if (i > 0) {
				eina_strbuf_append_printf(strbuf, ",");
			}
			if (addon_version >= 1462) {
				eina_strbuf_append_printf(strbuf, "%f,%f,%f,%f", motion_buffer[i].max_sum, motion_buffer[i].min_sum, motion_buffer[i].avg_sum, motion_buffer[i].new_acti_max);
			} else {
				eina_strbuf_append_printf(strbuf, "%f,%f,%f", motion_buffer[i].max_sum, motion_buffer[i].min_sum, motion_buffer[i].avg_sum);
			}
		}

		char *txt = eina_strbuf_string_steal(strbuf);
		eina_strbuf_free(strbuf);

		send_data(txt);
		free(txt);

		motion_buffer_size = 0;
	}

	current_min_sum = 10000;
	current_max_sum = 0;
	current_total_sum = 0;
	current_sum_count = 0;
	current_new_acti_max = 0;

	return ECORE_CALLBACK_RENEW;
}

static void send_ui_command(const char* command);

static Eina_Bool update_ui_cb(void *data EINA_UNUSED) {
	// Update pause state, if required.
	const int pause_secs_remaining = pause_seconds_remaining();
//	dlog_print(DLOG_INFO, TAG, "Pause sec: %d", pause_secs_remaining);
	if (pause_secs_remaining != ui_pause_secs_remaining) {
		ui_pause_secs_remaining = pause_secs_remaining;

		Eina_Strbuf *strbuf = eina_strbuf_new();
		eina_strbuf_append_printf(strbuf, "pause_state:%d", pause_secs_remaining);
		char *txt = eina_strbuf_string_steal(strbuf);
		eina_strbuf_free(strbuf);
		send_ui_command(txt);
		free(txt);
	}

	return ECORE_CALLBACK_RENEW;
}

static void start_tracking() {
	dlog_print(DLOG_INFO, TAG, "Starting tracking");
	if (is_tracking) {
		dlog_print(DLOG_INFO, TAG, "Duplicate start called");
		return;
	}

	setenv("LC_NUMBERS", "en_US.utf8", 1);
	elm_language_set("en_US.utf8");

	device_power_request_lock(POWER_LOCK_CPU, 0);
	is_tracking = true;
	paused_till = 0;
	start_accelerometer();
	send_motion_timer = ecore_timer_add(SAMPLING_TIME_SEC, send_motion_cb, NULL);
	update_ui_timer = ecore_timer_add(1, update_ui_cb, NULL);

	if (hr_enabled) {
		start_hr();
	}
}

static void stop_tracking() {
	dlog_print(DLOG_INFO, TAG, "Stopping tracking.");
	if (!is_tracking) {
		dlog_print(DLOG_INFO, TAG, "Finishing tracking without starting it.");
		return;
	}

	is_tracking = false;
	stop_accelerometer();
	stop_hr();
	device_power_release_lock(POWER_LOCK_CPU);
	ecore_timer_del(send_motion_timer);
	ecore_timer_del(update_ui_timer);
	if (hr_timer) {
		ecore_timer_del(hr_timer);
		hr_timer = NULL;
	}
}

static void send_ui_command(const char* command) {
    app_control_h app_control;
	if (app_control_create(&app_control) == APP_CONTROL_ERROR_NONE) {
		int res1 = 0, res2 = 0, res3 = 0;
		if (((res1 = app_control_set_app_id(app_control, "com.urbandroid.sleep.ui")) == APP_CONTROL_ERROR_NONE)
			&& ((res2 = app_control_add_extra_data(app_control, "app_action", command)) == APP_CONTROL_ERROR_NONE)
			&& ((res3 = app_control_send_launch_request(app_control, NULL, NULL)) == APP_CONTROL_ERROR_NONE)) {
			dlog_print(DLOG_INFO, TAG, "App command request sent: %s", command);
		} else {
			dlog_print(DLOG_ERROR, TAG, "App command request sending failed! Err: %d %d %d", res1, res2, res3);
		}
		if (app_control_destroy(app_control) == APP_CONTROL_ERROR_NONE) {
			dlog_print(DLOG_INFO, TAG, "App control destroyed.");
		}
	} else {
		dlog_print(DLOG_ERROR, TAG, "App control creation failed!");
	}
}

static void stop_ui() {
	dlog_print(DLOG_INFO, TAG, "Going to stop UI.");
	send_ui_command("stop");
}

static haptic_device_h haptic_handle;

static Eina_Bool vibrate_one_sec_for_hint(void *data) {
	haptic_effect_h effect_handle;
	int repeat = *((int*)data);
	dlog_print(DLOG_INFO, TAG, "Repeates for vibrate: %d.", repeat);
	if (repeat == 0) {
		// Hint looping finished
		device_haptic_close(haptic_handle);
		if (hint_timer) {
			// ecore_timer_del(hint_timer);  Do we need to delete the handle explicitly?
		}
		return ECORE_CALLBACK_CANCEL;
	}

	if (device_haptic_vibrate(haptic_handle, 1000, 100, &effect_handle) != DEVICE_ERROR_NONE) {
		dlog_print(DLOG_ERROR, TAG, "Failed to vibrate");
	}

	*((int*)data) = repeat - 1;
	return ECORE_CALLBACK_RENEW;
}

static Eina_Bool vibrate_one_sec(void *data) {
	haptic_effect_h effect_handle;
	if (device_haptic_vibrate(haptic_handle, 1000, 100, &effect_handle) != DEVICE_ERROR_NONE) {
		dlog_print(DLOG_ERROR, TAG, "Failed to vibrate");
	}

	return ECORE_CALLBACK_RENEW;
}

static void start_alarm(int alarm_delay) {
        device_power_request_lock(POWER_LOCK_DISPLAY, 0);
	send_ui_command("alarm_started");

	if(device_haptic_open(0, &haptic_handle) != DEVICE_ERROR_NONE) {
		dlog_print(DLOG_ERROR, TAG, "Failed to get vibrator!");
	}

	alarm_timer = ecore_timer_add(2, vibrate_one_sec, NULL);
	if (alarm_delay > 0) {
		ecore_timer_delay(alarm_timer, alarm_delay / 1000);
	}
}

static void stop_alarm() {
	send_ui_command("alarm_finished");
	if (alarm_timer) {
		ecore_timer_del(alarm_timer);
	}

	device_haptic_close(haptic_handle);

	device_power_release_lock(POWER_LOCK_DISPLAY);

	// If not tracking, we close the app after alarm is done.
	if (!is_tracking) {
		stop_ui();
		service_app_exit();
	}
}

static int hint_repeats = 0;
static void hint(int repeat) {
	if(device_haptic_open(0, &haptic_handle) != DEVICE_ERROR_NONE) {
		dlog_print(DLOG_ERROR, TAG, "Failed to get vibrator!");
	}

	hint_repeats = repeat;
	dlog_print(DLOG_DEBUG, TAG, "Going to vibrate one sec for hint");
	hint_timer = ecore_timer_add(2, vibrate_one_sec_for_hint, &hint_repeats);
}

static void handle_data_received(unsigned int payload_length, void *buffer) {
	const char* data = (const char*)buffer;
	dlog_print(DLOG_INFO, TAG, "Received command %s", data);
	if (eina_str_has_prefix(data, "StartTracking")) {
		start_tracking();
		send_ui_command("tracking_started");
	} else if (eina_str_has_prefix(data, "AppVersion")) {
		unsigned int num_elements = 0;
		char** split_data = eina_str_split_full(data, ";", 2, &num_elements);
		if (num_elements == 2) {
			addon_version = atoi(split_data[1]);
			dlog_print(DLOG_INFO, TAG, "App version: %d", addon_version);
		}
		if (num_elements > 0) {
			free(split_data[0]);
		}
		free(split_data);
	} else if (eina_str_has_prefix(data, "DoHr")) {
		unsigned int num_elements = 0;
		char** split_data = eina_str_split_full(data, ";", 2, &num_elements);
		hr_enabled = false;
		if (num_elements == 2) {
			hr_enabled = eina_str_has_prefix(split_data[1], "true");
		}
		dlog_print(DLOG_INFO, TAG, "Hr enabled: %d", hr_enabled);
		if (num_elements > 0) {
			free(split_data[0]);
		}
		free(split_data);
	} else if (eina_str_has_prefix(data, "StopApp")) {
		stop_tracking();
		stop_ui();
		service_app_exit();
	} else if (eina_str_has_prefix(data, "BatchSize")) {
		unsigned int num_elements = 0;
		char** split_data = eina_str_split_full(data, ";", 2, &num_elements);
		if (num_elements == 2) {
			batch_size = atoi(split_data[1]);
			dlog_print(DLOG_INFO, TAG, "Setting batch size: %d", batch_size);
		}
		if (num_elements > 0) {
			free(split_data[0]);
		}
		free(split_data);
	} else if (eina_str_has_prefix(data, "Pause")) {
		unsigned int num_elements = 0;
		char** split_data = eina_str_split_full(data, ";", 2, &num_elements);
		if (num_elements == 2) {
			paused_till = atoll(split_data[1]) / 1000;  // MS to Sec
			dlog_print(DLOG_INFO, TAG, "Setting paused till: %lld (%s)", paused_till, split_data[1]);
		}
		if (num_elements > 0) {
			free(split_data[0]);
		}
		free(split_data);
	} else if (eina_str_has_prefix(data, "StartAlarm")) {
		unsigned int num_elements = 0;
		char** split_data = eina_str_split_full(data, ";", 2, &num_elements);
		if (num_elements == 2) {
			int alarm_delay = atoi(split_data[1]);
			dlog_print(DLOG_INFO, TAG, "Starting alarm with delay %d", alarm_delay);
			start_alarm(alarm_delay);
		}
		if (num_elements > 0) {
			free(split_data[0]);
		}
		free(split_data);
	} else if (eina_str_has_prefix(data, "StopAlarm")) {
		stop_alarm();
	} else if (eina_str_has_prefix(data, "Hint")) {
		unsigned int num_elements = 0;
		char** split_data = eina_str_split_full(data, ";", 2, &num_elements);
		int repeat = 1;
		if (num_elements == 2) {
			repeat = atoi(split_data[1]);
			dlog_print(DLOG_INFO, TAG, "Hint: %d", repeat);
		}
		if (num_elements > 0) {
			free(split_data[0]);
		}
		free(split_data);

		hint(repeat);
	}
}

bool service_app_create(void *data) {
	initialize_sap(handle_data_received);

    return true;
}



void service_app_terminate(void *data) {
	terminate_sap();
    return;
}

void service_app_control(app_control_h app_control, void *data) {
	dlog_print(DLOG_INFO, LOG_TAG, "Service app control received");
	char *caller_id = NULL;
	if (app_control_get_caller(app_control, &caller_id) == APP_CONTROL_ERROR_NONE) {
		dlog_print(DLOG_INFO, LOG_TAG, "Caller: %s", caller_id);
		free(caller_id);
	}

	char *action_value = NULL;
    if (app_control_get_extra_data(app_control, "app_action", &action_value) == APP_CONTROL_ERROR_NONE) {
    	dlog_print(DLOG_INFO, LOG_TAG, "App control action: %s", action_value);
		if (action_value != NULL && strcmp(action_value, "pause") == 0) {
			send_data("PAUSE");
		} else if (action_value != NULL && strcmp(action_value, "resume") == 0) {
			send_data("RESUME");
		} else if (action_value != NULL && strcmp(action_value, "snooze") == 0) {
			send_data("SNOOZE");
		} else if (action_value != NULL && strcmp(action_value, "dismiss") == 0) {
			send_data("DISMISS");
		} else {
			dlog_print(DLOG_INFO, LOG_TAG, "Unsupported action! Doing nothing...");
			free(action_value);
		}
	} else {
		dlog_print(DLOG_ERROR, LOG_TAG, "Failed to get app control attribute");
	}
}

static void service_app_lang_changed(app_event_info_h event_info, void *user_data) {
	/*APP_EVENT_LANGUAGE_CHANGED*/
	return;
}

static void service_app_region_changed(app_event_info_h event_info, void *user_data) {
	/*APP_EVENT_REGION_FORMAT_CHANGED*/
}

static void service_app_low_battery(app_event_info_h event_info, void *user_data) {
	/*APP_EVENT_LOW_BATTERY*/
}

static void service_app_low_memory(app_event_info_h event_info, void *user_data) {
	/*APP_EVENT_LOW_MEMORY*/
}

int main(int argc, char* argv[]) {
	dlog_print(DLOG_INFO, TAG, "starting service app");

    char ad[50] = {0,};
	service_app_lifecycle_callback_s event_callback;
	app_event_handler_h handlers[5] = {NULL, };

	event_callback.create = service_app_create;
	event_callback.terminate = service_app_terminate;
	event_callback.app_control = service_app_control;

	service_app_add_event_handler(&handlers[APP_EVENT_LOW_BATTERY], APP_EVENT_LOW_BATTERY, service_app_low_battery, &ad);
	service_app_add_event_handler(&handlers[APP_EVENT_LOW_MEMORY], APP_EVENT_LOW_MEMORY, service_app_low_memory, &ad);
	service_app_add_event_handler(&handlers[APP_EVENT_LANGUAGE_CHANGED], APP_EVENT_LANGUAGE_CHANGED, service_app_lang_changed, &ad);
	service_app_add_event_handler(&handlers[APP_EVENT_REGION_FORMAT_CHANGED], APP_EVENT_REGION_FORMAT_CHANGED, service_app_region_changed, &ad);

	hr_supported = check_hr_supported();

	return service_app_main(argc, argv, &event_callback, ad);
}
