#include <sensor.h>
#include <tizen.h>
#include <efl_extension.h>
#include <dlog.h>
#include "sleep_sap.h"
#include "logging.h"

char *HRTAG = "SleepAsAndroidHR";

//Ecore_Timer* hr_timer = NULL;

unsigned long long last_hr_ts = 0;
bool can_send = true;
bool sensor_running = false;

float hrm_sum = 0;
int hrm_values = 0;

static sensor_listener_h hr_listener;
static sensor_h hr_sensor;

static void hr_sensor_event_callback(sensor_h sensor, sensor_event_s *event, void *user_data);
void start_hr();

void maybe_start_hr() {
	unsigned long long current_ts = get_current_timestamp_ms();
	logf_to_file_with_ts("Maybe_start_hr: %llu, last_hr_ts: %llu, diff: %llu", current_ts, last_hr_ts, current_ts - last_hr_ts);

	if (hrm_values == 0 && current_ts > last_hr_ts + 2*60*1000) {
		logf_to_file_with_ts("Maybe_start_hr start_hr: %llu", current_ts);
		last_hr_ts = current_ts;
		start_hr();
	}
}

void start_hr() {
	can_send = true;

	if (sensor_running) { return; }

	sensor_type_e type = SENSOR_HRM;

	if (sensor_get_default_sensor(type, &hr_sensor) == SENSOR_ERROR_NONE)
	{
	    if (sensor_create_listener(hr_sensor, &hr_listener) == SENSOR_ERROR_NONE
	        && sensor_listener_set_event_cb(hr_listener, 100, hr_sensor_event_callback, NULL) == SENSOR_ERROR_NONE
			&& sensor_listener_set_option(hr_listener, SENSOR_OPTION_ALWAYS_ON) == SENSOR_ERROR_NONE)
	    {
	        if (sensor_listener_start(hr_listener) == SENSOR_ERROR_NONE)
	        {
	        	sensor_running = true;
	        	log_to_file_with_ts("HR Sensor started");
	        }
	    }
	}
}

void stop_hr() {
	if (!sensor_running) { return; }

	sensor_running = false;
	log_to_file_with_ts("HR Sensor stop");
	int err1 = sensor_listener_stop(hr_listener);
	int err2 = sensor_listener_unset_event_cb(hr_listener);
	int err3 = sensor_destroy_listener(hr_listener);
	logf_to_file_with_ts("HR Sensor stop errors: %d %d %d", err1, err2, err3);
}

//static Eina_Bool restart_hrm(void *data EINA_UNUSED) {
//	start_hr();
//	return ECORE_CALLBACK_CANCEL;
//}

static void hr_sensor_event_callback(sensor_h sensor, sensor_event_s *event, void *user_data) {
	if (!can_send) {
		return;
	}

	sensor_type_e type;
	sensor_get_type(sensor, &type);
	float hrm_value;

	switch (type) {
		case SENSOR_HRM:
			hrm_value = event->values[0];

			if (hrm_value != 0.0f) {
				//dlog_print(DLOG_INFO, TAG, "HRM: %f" , hrm_value);
			}

			char *ts = get_sensor_event_time_human_readable(event->timestamp);
			logf_to_file_with_ts("Hr: hr_sensor_event_callback, ts: %s, value: %f, values: %d", ts, hrm_value, hrm_values);

			if (hrm_value == 0.0f) {
//				logf_to_file_with_ts("Hr: Stop HR due to 0 value.");
//				stop_hr(); // == wait for the next hr gathering window
				return;
			}

			if (hrm_value > 20.0f && hrm_value < 200.0f) {
				// We got a real value.. let's sum them till we have 10 samples
				hrm_sum += hrm_value;
				hrm_values++;
				if (hrm_values >= 10 && can_send) {
					can_send = false;
						// We have enough data -> Send it and let's measure again in 5 minutes.
					//hr_timer = ecore_timer_add(5 * 60, restart_hrm, NULL);

					Eina_Strbuf *strbuf = eina_strbuf_new();
					eina_strbuf_append_printf(strbuf, "%s%f", "HR_DATA", hrm_sum / hrm_values);
					char *txt = eina_strbuf_string_steal(strbuf);
					eina_strbuf_free(strbuf);

					send_data(txt);
					free(txt);

					logf_to_file_with_ts("Hr: Stop HR due to full buffer.");
					stop_hr();
					hrm_values = 0;
					hrm_sum = 0;

					can_send = true;
				}
			}
			break;
		default:
			dlog_print(DLOG_ERROR, HRTAG, "Not an HRM event");
	}
}

bool check_hr_supported() {
	sensor_type_e type = SENSOR_HRM;

	bool supported;
	int error = sensor_is_supported(type, &supported);
	if (error != SENSOR_ERROR_NONE) {
		dlog_print(DLOG_ERROR, HRTAG, "sensor_is_supported error: %d", error);
		return false;
	}

	if(supported){
		dlog_print(DLOG_DEBUG, HRTAG, "HRM is %s supported", supported ? "" : " not");
	}

	return supported;
}

void terminate_hr() {
	stop_hr();
//	if (hr_timer) {
//		ecore_timer_del(hr_timer);
//		hr_timer = NULL;
//	}
}
