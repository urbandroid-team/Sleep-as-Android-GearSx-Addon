#include "sleepasandroidnativeservice.h"

#include "common.h"
#include "sleep_sap.h"
#include "sleep_util.h"
#include "logging.h"
#include "hr.h"
#include "acc.h"

#include <device/haptic.h>
#include <device/power.h>
#include <device/callback.h>
#include <efl_extension.h>
#include <tizen.h>
#include <sensor.h>
#include <service_app.h>
#include <stdint.h>

Ecore_Timer* debug_timer = NULL;
Ecore_Timer* alarm_timer = NULL;
Ecore_Timer* hint_timer = NULL;
//Ecore_Timer* acc_batch_timer = NULL;

static bool is_tracking = false;
static bool hr_enabled = false;

static bool ui_in_background = false;

static bool hr_supported = false;

static void send_ui_command(const char* command);

static Eina_Bool debug_cb(void *data EINA_UNUSED) {
	log_to_file_with_ts("tick");
//	send_data("tick");
	return ECORE_CALLBACK_RENEW;
}

static void start_debug_timer() {
	log_to_file_with_ts("start_debug_timer");
	debug_timer = ecore_timer_add(2, debug_cb, NULL);
}

static void start_tracking() {
	log_to_file_with_ts("start_tracking");
	dlog_print(DLOG_INFO, TAG, "Starting tracking");
	if (is_tracking) {
		dlog_print(DLOG_INFO, TAG, "Duplicate start called");
		return;
	}

	setenv("LC_NUMBERS", "en_US.utf8", 1);
	elm_language_set("en_US.utf8");

	is_tracking = true;
	start_accelerometer();

	log_system_info();
}

static void stop_tracking() {
	log_to_file_with_ts("stop_tracking");
	dlog_print(DLOG_INFO, TAG, "Stopping tracking.");
	if (!is_tracking) {
		dlog_print(DLOG_INFO, TAG, "Finishing tracking without starting it.");
		return;
	}

	is_tracking = false;

	terminate_acc();
	terminate_hr();


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
	log_to_file_with_ts("stop_ui");
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

	if (device_haptic_vibrate(haptic_handle, 1000, 50, &effect_handle) != DEVICE_ERROR_NONE) {
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

// Called from accelerometer callback, so we know when the watch is awake so we can eg. gather HR data
void watch_awake_callback() {
	dlog_print(DLOG_INFO, TAG, "Watch awake callback");
	if (hr_enabled) {
		maybe_start_hr();
	}
}

static void start_alarm(int alarm_delay) {
	device_power_request_lock(POWER_LOCK_DISPLAY, 0);
	send_ui_command("alarm_started");

	if(device_haptic_open(0, &haptic_handle) != DEVICE_ERROR_NONE) {
		dlog_print(DLOG_ERROR, TAG, "Failed to get vibrator!");
	}

	if (alarm_delay >= 0) {
		alarm_timer = ecore_timer_add(2, vibrate_one_sec, NULL);
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
	logf_to_file_with_ts("handle_data_received: %s", data);
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
		dlog_print(DLOG_INFO, TAG, "Service app trying to exit due to StopApp");
		stop_ui();
		service_app_exit();
	} else if (eina_str_has_prefix(data, "BatchSize")) {
		unsigned int num_elements = 0;
		char** split_data = eina_str_split_full(data, ";", 2, &num_elements);
		if (num_elements == 2) {
			set_batch_size(atoi(split_data[1]));
		}
		if (num_elements > 0) {
			free(split_data[0]);
		}
		free(split_data);
	} else if (eina_str_has_prefix(data, "Pause")) {
		// Pause;12345000
		unsigned int num_elements = 0;
		gint64 paused_till_ts = 0;

		char** split_data = eina_str_split_full(data, ";", 2, &num_elements);
		if (num_elements == 2) {
			paused_till_ts = atoll(split_data[1]) / 1000;  // MS to Sec
			dlog_print(DLOG_INFO, TAG, "Setting paused till: %lld (%s)", paused_till_ts, split_data[1]);

		}

		Eina_Strbuf *strbuf = eina_strbuf_new();
		eina_strbuf_append_printf(strbuf, "paused_till:%d", paused_till_ts);
		char *command = eina_strbuf_string_steal(strbuf);
		eina_strbuf_free(strbuf);
		// "paused_till:12345"
		send_ui_command(command);
		free(command);

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
	logf_to_file_with_ts("service_app_create");
	initialize_sap(handle_data_received);

//	start_debug_timer();

	return true;
}

void service_app_terminate(void *data) {
	logf_to_file_with_ts("service_app_terminate");
	dlog_print(DLOG_INFO, TAG, "Service app terminate callback");
	terminate_acc();
	terminate_sap();
	service_app_exit();
    return;
}

void service_app_control(app_control_h app_control, void *data) {
	logf_to_file_with_ts("service_app_control");
	dlog_print(DLOG_INFO, TAG, "Service app control received");
	char *caller_id = NULL;
	if (app_control_get_caller(app_control, &caller_id) == APP_CONTROL_ERROR_NONE) {
		dlog_print(DLOG_INFO, TAG, "Caller: %s", caller_id);
		free(caller_id);
	}

	char *action_value = NULL;
    if (app_control_get_extra_data(app_control, "app_action", &action_value) == APP_CONTROL_ERROR_NONE) {
    	dlog_print(DLOG_INFO, TAG, "Service app control action: %s", action_value);

    	logf_to_file_with_ts("service_app_control action: %s", action_value);

		if (action_value != NULL && strcmp(action_value, "start") == 0) {
		    if (send_data("STARTING") != SEND_DATA_SUCCESS) {
            	dlog_print(DLOG_INFO, TAG, "App control started from WATCH - cannot send STARTING");
            	set_tracking_started_from_watch(true);
		    } else {
            	dlog_print(DLOG_INFO, TAG, "App control started from WATCH - STARTING sent");
            	set_tracking_started_from_watch(false);
		    }
		} else if (action_value != NULL && strcmp(action_value, "pause") == 0) {
			send_data("PAUSE");
		} else if (action_value != NULL && strcmp(action_value, "resume") == 0) {
			send_data("RESUME");
		} else if (action_value != NULL && strcmp(action_value, "snooze") == 0) {
			send_data("SNOOZE");
		} else if (action_value != NULL && strcmp(action_value, "dismiss") == 0) {
			send_data("DISMISS");
		} else if (action_value != NULL && strcmp(action_value, "terminate") == 0) {
			send_data("STOP");
			service_app_exit();
		} else if (action_value != NULL && strcmp(action_value, "pause_start") == 0) {
			paused = true;
		} else if (action_value != NULL && strcmp(action_value, "pause_end") == 0) {
			paused = false;
		} else if (action_value != NULL && strcmp(action_value, "app_in_background") == 0) {
			ui_in_background = true;
			dlog_print(DLOG_INFO, TAG, "ui to background");
		} else if (action_value != NULL && strcmp(action_value, "app_in_foreground") == 0) {
			ui_in_background = false;
			dlog_print(DLOG_INFO, TAG, "ui to foreground");
		} else {
			dlog_print(DLOG_INFO, TAG, "Unsupported action! Doing nothing...");
			free(action_value);
		}
	} else {
		dlog_print(DLOG_ERROR, TAG, "Failed to get app control attribute");
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

static void display_change_cb(device_callback_e type, void *value, void *user_data){
	logf_to_file_with_ts("Display changed to: %d", value);
}



int main(int argc, char* argv[]) {
	dlog_print(DLOG_INFO, TAG, "starting service app");

	logf_to_file_with_ts("Start service app main()");

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

	device_add_callback(DEVICE_CALLBACK_DISPLAY_STATE, display_change_cb, NULL);

	hr_supported = check_hr_supported();

	return service_app_main(argc, argv, &event_callback, ad);
}
