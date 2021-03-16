#include "sleepasandroidnativeuiedc.h"
#include <app_manager.h>
#include <device/display.h>
#include <device/callback.h>

typedef struct appdata {
	Evas_Object* win;
	Evas_Object* starting_layout;
	Evas_Object* tracking_layout;
	Evas_Object* alarm_layout;
	Evas_Object* conform;
} appdata_s;

static appdata_s app_data = {0, };

// Pause
static int paused_till_ts = 0;

Ecore_Timer* update_ui_timer;

static void send_service_command(const char* command);

static bool is_service_running() {
	bool running;
	if (app_manager_is_running("com.urbandroid.sleep.service", &running) == APP_MANAGER_ERROR_NONE) {
		if (running) {
			dlog_print(DLOG_INFO, LOG_TAG, "is_service_running TRUE");
			return true;
		} else {
			dlog_print(DLOG_INFO, LOG_TAG, "is_service_running FALSE");
			return false;
		}
	}
	return false;
}

static void wake_up_screen() {
	device_display_change_state(DISPLAY_STATE_NORMAL);
}

static void win_delete_request_cb(void *data, Evas_Object *obj, void *event_info) {
	ui_app_exit();
}

static void layout_back_cb(void *data, Evas_Object *obj, void *event_info) {
	appdata_s *ad = data;
	/* Let window go to hide state. */
	elm_win_lower(ad->win);
}

static void app_get_resource(const char *edj_file_in, char *edj_path_out, int edj_path_max) {
	char *res_path = app_get_resource_path();
	if (res_path) {
		snprintf(edj_path_out, edj_path_max, "%s%s", res_path, edj_file_in);
		free(res_path);
	}
}

static Evas_Object* create_layout(appdata_s *ad, const char* layout_name) {
	char edj_path[PATH_MAX] = {0, };

	app_get_resource(EDJ_FILE, edj_path, (int)PATH_MAX);
	Evas_Object* layout = elm_layout_add(ad->win);
	elm_layout_file_set(layout, edj_path, layout_name);
	evas_object_size_hint_weight_set(layout, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	eext_object_event_callback_add(layout, EEXT_CALLBACK_BACK, layout_back_cb, ad);

	return layout;
}

void _pause_cb(void *data, Evas_Object *o, const char *emission, const char *source) {
	dlog_print(DLOG_INFO, LOG_TAG, "Pause clicked");
	send_service_command("pause");
}

void _resume_cb(void *data, Evas_Object *o, const char *emission, const char *source) {
	dlog_print(DLOG_INFO, LOG_TAG, "Resume clicked");
	send_service_command("resume");
}

void _snooze_cb(void *data, Evas_Object *o, const char *emission, const char *source) {
	dlog_print(DLOG_INFO, LOG_TAG, "Snooze clicked");
	send_service_command("snooze");
}

void _dismiss_cb(void *data, Evas_Object *o, const char *emission, const char *source) {
	dlog_print(DLOG_INFO, LOG_TAG, "Dismiss clicked");
	send_service_command("dismiss");
}

static int pause_seconds_remaining() {
	time_t now;
	time(&now);
	if (paused_till_ts == 0 || paused_till_ts < now)
	{
		return 0;
	}
	return paused_till_ts - now;
}

static void update_time(appdata_s *ad) {
	time_t raw_time;
	struct tm* time_info;

	time(&raw_time);
	time_info = localtime(&raw_time);

	char time[11];

	sprintf(time,"%02i:%02i", time_info->tm_hour, time_info->tm_min);

	edje_object_part_text_set(elm_layout_edje_get(ad->tracking_layout), "text_tracking_time", time);
	edje_object_part_text_set(elm_layout_edje_get(ad->alarm_layout), "text_alarm_time", time);
}

static void update_pause_time(appdata_s *ad) {

	dlog_print(DLOG_INFO, LOG_TAG, "Pause state: %d", pause_seconds_remaining());
	if (pause_seconds_remaining() > 0) {
		int minutes = pause_seconds_remaining() / 60;
		// int seconds = pause_secs_remaining % 60;
		char txt[100];
		snprintf(txt, 100, "Paused (%d min)", minutes);
		elm_object_part_text_set(app_data.tracking_layout, "text_tracking", txt);
	} else {
        elm_object_part_text_set(app_data.tracking_layout, "text_tracking", "Tracking");
	}
}

static void create_base_gui(appdata_s *ad) {
	dlog_print(DLOG_INFO, LOG_TAG, "Going to create UI");
	/* Window */
	ad->win = elm_win_util_standard_add(PACKAGE, PACKAGE);
	elm_win_conformant_set(ad->win, EINA_TRUE);
	elm_win_autodel_set(ad->win, EINA_TRUE);

	if (elm_win_wm_rotation_supported_get(ad->win)) {
		int rots[4] = { 0, 90, 180, 270 };
		elm_win_wm_rotation_available_rotations_set(ad->win, (const int *)(&rots), 4);
	}

	evas_object_smart_callback_add(ad->win, "delete,request", win_delete_request_cb, NULL);

	/* Conformant */
	ad->conform = elm_conformant_add(ad->win);
	elm_win_indicator_mode_set(ad->win, ELM_WIN_INDICATOR_SHOW);
	elm_win_indicator_opacity_set(ad->win, ELM_WIN_INDICATOR_OPAQUE);
	evas_object_size_hint_weight_set(ad->conform, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	elm_win_resize_object_add(ad->win, ad->conform);
	evas_object_show(ad->conform);

	/* Base Layout */
	ad->starting_layout = create_layout(ad, GRP_MAIN);
	ad->tracking_layout = create_layout(ad, "tracking");
	update_time(ad);

	ad->alarm_layout = create_layout(ad, "alarm");

	elm_layout_signal_callback_add(ad->tracking_layout, "clicked", "pause", _pause_cb, NULL);
	elm_layout_signal_callback_add(ad->tracking_layout, "clicked", "resume", _resume_cb, NULL);

	elm_layout_signal_callback_add(ad->alarm_layout, "clicked", "snooze", _snooze_cb, NULL);
	elm_layout_signal_callback_add(ad->alarm_layout, "clicked", "dismiss", _dismiss_cb, NULL);

	elm_bg_color_set(ad->tracking_layout, 64, 127, 256);

	/* Show window after base gui is set up */
	elm_object_content_set(ad->conform, ad->starting_layout);
	evas_object_show(ad->win);

	dlog_print(DLOG_INFO, LOG_TAG, "UI created ");
}

static void switch_to_layout(Evas_Object* layout) {
	Evas_Object* current_layout = elm_object_content_get(app_data.conform);
	if (current_layout != NULL && current_layout != layout) {
		elm_object_content_unset(app_data.conform);
		evas_object_hide(current_layout);
	}

	if (current_layout != layout) {
		elm_object_content_set(app_data.conform, layout);
		evas_object_show(app_data.win);
	}
}

static bool is_paused() {
	return pause_seconds_remaining() > 0;
}

static Eina_Bool update_ui_cb(void *data EINA_UNUSED) {
	update_time(&app_data);
	update_pause_time(&app_data);

	return ECORE_CALLBACK_RENEW;
}

static void set_ui_update_timer(bool enable) {
	if (enable) {
		update_ui_timer = ecore_timer_add(60, update_ui_cb, NULL);
	} else {
		ecore_timer_del(update_ui_timer);
	}
}

static void app_pause(void *data) {
	/* Take necessary actions when application becomes invisible. */
	send_service_command("app_in_background");
	set_ui_update_timer(false);
}

static void app_resume(void *data) {
	/* Take necessary actions when application becomes visible. */
	send_service_command("app_in_foreground");
	update_time(&app_data);
	set_ui_update_timer(true);
}

static void app_terminate(void *data) {
	/* Release all resources. */
	send_service_command("terminate");
}

static void ui_app_lang_changed(app_event_info_h event_info, void *user_data) {
	/*APP_EVENT_LANGUAGE_CHANGED*/
	char *locale = NULL;
	system_settings_get_value_string(SYSTEM_SETTINGS_KEY_LOCALE_LANGUAGE, &locale);
	elm_language_set(locale);
	free(locale);
	return;
}

static void ui_app_orient_changed(app_event_info_h event_info, void *user_data) {
	/*APP_EVENT_DEVICE_ORIENTATION_CHANGED*/
	return;
}

static void ui_app_region_changed(app_event_info_h event_info, void *user_data) {
	/*APP_EVENT_REGION_FORMAT_CHANGED*/
}

static void ui_app_low_battery(app_event_info_h event_info, void *user_data) {
	/*APP_EVENT_LOW_BATTERY*/
}

static void ui_app_low_memory(app_event_info_h event_info, void *user_data) {
	/*APP_EVENT_LOW_MEMORY*/
}

static void send_service_command(const char* command) {
    app_control_h app_control;
	if (app_control_create(&app_control) == APP_CONTROL_ERROR_NONE) {
		int res1 = 0, res2 = 0, res3 = 0;
		if (((res1 = app_control_set_app_id(app_control, "com.urbandroid.sleep.service")) == APP_CONTROL_ERROR_NONE)
			&& ((res2 = app_control_add_extra_data(app_control, "app_action", command)) == APP_CONTROL_ERROR_NONE)
			&& ((res3 = app_control_send_launch_request(app_control, NULL, NULL)) == APP_CONTROL_ERROR_NONE)) {
			dlog_print(DLOG_INFO, LOG_TAG, "App command request sent: %s", command);
		} else {
			dlog_print(DLOG_ERROR, LOG_TAG, "App command request sending failed! Err: %d %d %d", res1, res2, res3);
		}
		if (app_control_destroy(app_control) == APP_CONTROL_ERROR_NONE) {
			dlog_print(DLOG_INFO, LOG_TAG, "App control destroyed.");
		}
	} else {
		dlog_print(DLOG_ERROR, LOG_TAG, "App control creation failed!");
	}
}

static void launch_service() {
	dlog_print(DLOG_INFO, LOG_TAG, "launch_service from UI");
	send_service_command("start");
}

static void app_control(app_control_h app_control, void *data) {
	dlog_print(DLOG_INFO, LOG_TAG, "App control received");
	char *caller_id = NULL;
	if (app_control_get_caller(app_control, &caller_id) == APP_CONTROL_ERROR_NONE) {
		dlog_print(DLOG_INFO, LOG_TAG, "Caller: %s", caller_id);
		free(caller_id);
	}

	char *action_value = NULL;
    if (app_control_get_extra_data(app_control, "app_action", &action_value) == APP_CONTROL_ERROR_NONE) {
    	dlog_print(DLOG_INFO, LOG_TAG, "App control action: %s", action_value);

		if (action_value != NULL && strcmp(action_value, "stop") == 0) {
			dlog_print(DLOG_INFO, LOG_TAG, "Stopping UI!");
			free(action_value);
			ui_app_exit();
			return;
		} else if (action_value != NULL && strcmp(action_value, "tracking_started") == 0) {
			switch_to_layout(app_data.tracking_layout);
		} else if (action_value != NULL && eina_str_has_prefix(action_value, "paused_till")) {
			// getting "paused_till:12345"
			unsigned int num_elements = 0;
			char** split_data = eina_str_split_full(action_value, ":", 2, &num_elements);
			if (num_elements == 2) {
				paused_till_ts = atoi(split_data[1]);
			}
			if (num_elements > 0) {
				free(split_data[0]);
			}
			free(split_data);
			dlog_print(DLOG_INFO, LOG_TAG, "Pause state: %d", paused_till_ts);

            update_pause_time(&app_data);


		} else if (action_value != NULL && strcmp(action_value, "alarm_started") == 0) {
			switch_to_layout(app_data.alarm_layout);
			update_time(&app_data);
			wake_up_screen();
		} else if (action_value != NULL && strcmp(action_value, "alarm_finished") == 0) {
			switch_to_layout(app_data.tracking_layout);
		} else {
			dlog_print(DLOG_INFO, LOG_TAG, "Unsupported action! Doing nothing...");
			send_service_command(action_value);
			free(action_value);
		}
	} else {
		dlog_print(DLOG_ERROR, LOG_TAG, "Failed to get app control attribute");
		launch_service();
	}
}

static bool app_create(void *data) {
	/* Hook to take necessary actions before main event loop starts
	   Initialize UI resources and application's data
	   If this function returns true, the main loop of application starts
	   If this function returns false, the application is terminated */
	appdata_s *ad = data;

	create_base_gui(ad);
	return true;
}

int main(int argc, char *argv[]) {
	dlog_print(DLOG_INFO, LOG_TAG, "Starting UI app");
	int ret = 0;

	ui_app_lifecycle_callback_s event_callback = {0,};
	app_event_handler_h handlers[5] = {NULL, };

	event_callback.create = app_create;
	event_callback.terminate = app_terminate;
	event_callback.pause = app_pause;
	event_callback.resume = app_resume;
	event_callback.app_control = app_control;



	ui_app_add_event_handler(&handlers[APP_EVENT_LOW_BATTERY], APP_EVENT_LOW_BATTERY, ui_app_low_battery, &app_data);
	ui_app_add_event_handler(&handlers[APP_EVENT_LOW_MEMORY], APP_EVENT_LOW_MEMORY, ui_app_low_memory, &app_data);
	ui_app_add_event_handler(&handlers[APP_EVENT_DEVICE_ORIENTATION_CHANGED], APP_EVENT_DEVICE_ORIENTATION_CHANGED, ui_app_orient_changed, &app_data);
	ui_app_add_event_handler(&handlers[APP_EVENT_LANGUAGE_CHANGED], APP_EVENT_LANGUAGE_CHANGED, ui_app_lang_changed, &app_data);
	ui_app_add_event_handler(&handlers[APP_EVENT_REGION_FORMAT_CHANGED], APP_EVENT_REGION_FORMAT_CHANGED, ui_app_region_changed, &app_data);
	ui_app_remove_event_handler(handlers[APP_EVENT_LOW_MEMORY]);



	ret = ui_app_main(argc, argv, &event_callback, &app_data);
	if (ret != APP_ERROR_NONE) {
		dlog_print(DLOG_ERROR, LOG_TAG, "ui_app_main() is failed. err = %d", ret);
	}

	return ret;
}
