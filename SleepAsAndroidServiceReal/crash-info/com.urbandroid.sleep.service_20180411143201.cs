S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.2.7
Build-Number: R732XXU2FRC1
Build-Date: 2018.03.02 17:21:30

Crash Information
Process Name: sleepasandroidnativeservice
PID: 1639
Date: 2018-04-11 14:32:01+0200
Executable File Path: /opt/usr/apps/com.urbandroid.sleep/bin/sleepasandroidnativeservice
Signal: 6
      (SIGABRT)
      si_code: -6
      signal sent by tkill (sent by pid 1639, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00000667
r2   = 0x00000006, r3   = 0x00000667
r4   = 0x00000006, r5   = 0x00000002
r6   = 0x404f9bec, r7   = 0x0000010c
r8   = 0x00000038, r9   = 0x00000002
r10  = 0xbef17750, fp   = 0xbef17d68
ip   = 0x43096fe0, sp   = 0xbef17630
lr   = 0x403fb328, pc   = 0x403f7668
cpsr = 0x20000010

Memory Information
MemTotal:   491132 KB
MemFree:     28500 KB
Buffers:     17568 KB
Cached:     149508 KB
VmPeak:      61328 KB
VmSize:      61324 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        8952 KB
VmRSS:        8952 KB
VmData:      12296 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       19584 KB
VmPTE:          32 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 1639 TID = 1639
1639 1646 

Maps Information
40000000 40005000 r-xp /opt/usr/apps/com.urbandroid.sleep/bin/sleepasandroidnativeservice
40007000 4000b000 r-xp /usr/lib/libsys-assert.so
40016000 40033000 r-xp /lib/ld-2.13.so
40052000 40055000 r-xp /usr/lib/libappcore-agent.so.1.1
4005d000 4005f000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
40068000 4006c000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
40075000 4007a000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
40082000 4008e000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
40097000 40099000 r-xp /usr/lib/libdlog.so.0.0.0
400a1000 400b8000 r-xp /usr/lib/libecore.so.1.7.99
400cf000 40110000 r-xp /usr/lib/libeina.so.1.7.99
40119000 40255000 r-xp /usr/lib/libelementary.so.1.7.99
4026c000 4033c000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
4033d000 40350000 r-xp /usr/lib/libsap-client-stub-api.so.1.0.0
40359000 403c2000 r-xp /lib/libm-2.13.so
403cb000 404ef000 r-xp /lib/libc-2.13.so
404fd000 40505000 r-xp /lib/libgcc_s-4.6.so.1
40506000 40511000 r-xp /lib/libunwind.so.8.0.1
4053e000 40540000 r-xp /lib/libdl-2.13.so
40549000 40556000 r-xp /usr/lib/libaul.so.0.1.0
40560000 40574000 r-xp /lib/libpthread-2.13.so
4057f000 40588000 r-xp /usr/lib/libvconf.so.0.2.45
40590000 405b3000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
405bb000 405c1000 r-xp /usr/lib/libappsvc.so.0.1.0
405c9000 405cc000 r-xp /usr/lib/libbundle.so.0.1.22
405d4000 405d9000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
405e1000 406b4000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
406bf000 406f3000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
406fc000 40726000 r-xp /usr/lib/libsensor.so.1.9.7
4072f000 40736000 r-xp /usr/lib/libctx-shared.so.0.8.3
4073e000 40743000 r-xp /usr/lib/libctx-client.so.0.8.3
4074b000 407df000 r-xp /usr/lib/libstdc++.so.6.0.16
407f2000 407f8000 r-xp /lib/librt-2.13.so
40801000 4081a000 r-xp /usr/lib/libeet.so.1.7.99
4082b000 408f9000 r-xp /usr/lib/libevas.so.1.7.99
4091f000 40941000 r-xp /usr/lib/libecore_evas.so.1.7.99
4094a000 4094f000 r-xp /usr/lib/libecore_file.so.1.7.99
40957000 40968000 r-xp /usr/lib/libecore_input.so.1.7.99
40970000 409ce000 r-xp /usr/lib/libedje.so.1.7.99
409d8000 40a28000 r-xp /usr/lib/libecore_x.so.1.7.99
40a2a000 40a33000 r-xp /usr/lib/libedbus.so.1.7.99
40a3b000 40a65000 r-xp /usr/lib/libdbus-1.so.3.8.12
40a6e000 40a88000 r-xp /usr/lib/libecore_con.so.1.7.99
40a91000 40a99000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
40aa1000 40aa7000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
40ab0000 40ab9000 r-xp /usr/lib/libsap_client.so.0.0.0
40ac1000 40ad8000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
40ae0000 40ae5000 r-xp /usr/lib/libxdgmime.so.1.1.0
40aed000 40aee000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
40af6000 40b14000 r-xp /usr/lib/libsystemd.so.0.4.0
40b1f000 40b39000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
40b41000 40bb6000 r-xp /usr/lib/libsqlite3.so.0.8.6
40bc0000 40bc6000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
40bcf000 40bd1000 r-xp /usr/lib/libiniparser.so.0
40bda000 40ca6000 r-xp /usr/lib/libxml2.so.2.7.8
40cb4000 40cb5000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
40cbd000 40cc2000 r-xp /usr/lib/libffi.so.5.0.10
40cca000 40ccc000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
40cd4000 40cea000 r-xp /lib/libz.so.1.2.5
40cf2000 40d02000 r-xp /lib/libresolv-2.13.so
40d07000 40d11000 r-xp /usr/lib/libsensord-shared.so
40d1a000 40d29000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
40d32000 40d61000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
40d69000 40d8c000 r-xp /usr/lib/libjpeg.so.8.0.2
40da4000 40db7000 r-xp /usr/lib/libfribidi.so.0.3.1
40dc0000 40e05000 r-xp /usr/lib/libharfbuzz.so.0.10200.4
40e0e000 40e36000 r-xp /usr/lib/libfontconfig.so.1.8.0
40e37000 40e8d000 r-xp /usr/lib/libfreetype.so.6.11.3
40e99000 40eef000 r-xp /usr/lib/libpixman-1.so.0.28.2
40efc000 40fdd000 r-xp /usr/lib/libX11.so.6.3.0
40fe9000 40fee000 r-xp /usr/lib/libecore_fb.so.1.7.99
40ff7000 40ffb000 r-xp /usr/lib/libecore_ipc.so.1.7.99
41004000 41007000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
4100f000 41016000 r-xp /usr/lib/libembryo.so.1.7.99
4101e000 41035000 r-xp /usr/lib/liblua-5.1.so
4103f000 41045000 r-xp /usr/lib/libecore_imf.so.1.7.99
4104d000 4104e000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
41056000 4105d000 r-xp /usr/lib/libXcursor.so.1.0.2
41065000 41067000 r-xp /usr/lib/libXdamage.so.1.1.0
4106f000 41071000 r-xp /usr/lib/libXcomposite.so.1.0.0
4107a000 4107c000 r-xp /usr/lib/libXgesture.so.7.0.0
41084000 41087000 r-xp /usr/lib/libXfixes.so.3.1.0
4108f000 41098000 r-xp /usr/lib/libXi.so.6.1.0
410a0000 410a1000 r-xp /usr/lib/libXinerama.so.1.0.0
410aa000 410b0000 r-xp /usr/lib/libXrandr.so.2.2.0
410b8000 410be000 r-xp /usr/lib/libXrender.so.1.3.0
410c7000 410cb000 r-xp /usr/lib/libXtst.so.6.1.0
410d3000 410dd000 r-xp /usr/lib/libXext.so.6.4.0
410e6000 4112a000 r-xp /usr/lib/libcurl.so.4.3.0
41133000 41155000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
4115e000 41162000 r-xp /usr/lib/libsmack.so.1.0.0
4116c000 4116e000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
41176000 4118e000 r-xp /usr/lib/liblzma.so.5.0.3
41196000 41198000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
411a1000 411a3000 r-xp /usr/lib/journal/libjournal.so.0.1.0
411ac000 411c9000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
411d2000 411e8000 r-xp /lib/libexpat.so.1.6.0
411f2000 4120a000 r-xp /usr/lib/libpng12.so.0.50.0
41212000 41225000 r-xp /usr/lib/libxcb.so.1.1.0
4122f000 41238000 r-xp /usr/lib/libcares.so.2.1.0
41241000 4126f000 r-xp /usr/lib/libidn.so.11.5.44
41277000 412be000 r-xp /usr/lib/libssl.so.1.0.0
412ca000 4145c000 r-xp /usr/lib/libcrypto.so.1.0.0
4147d000 41484000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
4148e000 41490000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
41498000 4149f000 r-xp /usr/lib/libminizip.so.1.0.0
414a7000 414b4000 r-xp /usr/lib/libail.so.0.1.0
414bd000 41645000 r-xp /usr/lib/libicui18n.so.57.1
41655000 4175b000 r-xp /usr/lib/libicuuc.so.57.1
4300b000 43011000 r-xp /usr/lib/libproc-stat.so.0.2.96
43019000 4301a000 r-xp /usr/lib/libresponse.so.0.2.96
43022000 43024000 r-xp /usr/lib/libiri.so
4302c000 4302f000 r-xp /lib/libcap.so.2.21
43038000 4303f000 r-xp /lib/libcrypt-2.13.so
4306f000 43071000 r-xp /usr/lib/libXau.so.6.0.0
43079000 4307e000 r-xp /usr/lib/libsystem.so.0.0.0
43088000 4308b000 r-xp /lib/libattr.so.1.1.0
4319a000 43a00000 rw-p [stack:1646]
beef8000 bef19000 rw-p [stack]
End of Maps Information

Callstack Information (PID:1639)
Call Stack Count: 2
 0: gsignal + 0x3c (0x403f7668) [/lib/libc.so.6] + 0x2c668
 1: (0x1) (null)
End of Call Stack

Package Information
Package Name: com.urbandroid.sleep
Package ID : com.urbandroid.sleep
Version: 1.0.9
Package Type: rpm
App Name: sleepasandroidnativeservice
App ID: com.urbandroid.sleep.service
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
) > [_ecore_event_client_message_cb:1275] quickpanel 1 (scroll_started)
04-11 14:31:49.670+0200 W/STARTER (  735): clock-mgr.c: _on_lcd_signal_receive_cb(1297) > [_on_lcd_signal_receive_cb:1297] _on_lcd_signal_receive_cb, 1297, Post LCD off by [timeout]
04-11 14:31:49.670+0200 W/STARTER (  735): clock-mgr.c: _post_lcd_off(1190) > [_post_lcd_off:1190] LCD OFF as reserved app[(null)] alpm mode[0]
04-11 14:31:49.670+0200 W/STARTER (  735): clock-mgr.c: _post_lcd_off(1197) > [_post_lcd_off:1197] Current reserved apps status : 0
04-11 14:31:49.670+0200 W/STARTER (  735): clock-mgr.c: _post_lcd_off(1215) > [_post_lcd_off:1215] raise homescreen after 20 sec. home_visible[0]
04-11 14:31:49.670+0200 E/ALARM_MANAGER(  735): alarm-lib.c: alarmmgr_add_alarm_withcb(1178) > trigger_at_time(20), start(11-4-2018, 14:32:10), repeat(1), interval(20), type(-1073741822)
04-11 14:31:49.695+0200 E/ALARM_MANAGER(  518): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [735].
04-11 14:31:49.705+0200 W/W_INDICATOR(  736): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(615) > [_windicator_dbus_lcd_off_completed_cb:615] LCD Off completed signal is received
04-11 14:31:49.705+0200 W/W_INDICATOR(  736): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(620) > [_windicator_dbus_lcd_off_completed_cb:620] Moment bar status -> idle. (Hide Moment bar)
04-11 14:31:49.705+0200 W/W_INDICATOR(  736): windicator_moment_bar.c: windicator_moment_bar_hide_directly(548) > [windicator_moment_bar_hide_directly:548] windicator_moment_bar_hide_directly
04-11 14:31:49.705+0200 W/W_INDICATOR(  736): windicator_moment_bar.c: windicator_moment_bar_hide_directly(558) > [windicator_moment_bar_hide_directly:558] Hide Moment Bar Directly
04-11 14:31:49.730+0200 I/APP_CORE( 1632): appcore-efl.c: __do_app(453) > [APP 1632] Event: PAUSE State: RUNNING
04-11 14:31:49.730+0200 I/CAPI_APPFW_APPLICATION( 1632): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
04-11 14:31:49.730+0200 W/APP_CORE( 1632): appcore-efl.c: _capture_and_make_file(1721) > Capture : win[3600003] -> redirected win[60141a] for com.urbandroid.sleep.ui[1632]
04-11 14:31:49.735+0200 I/APP_CORE(  736): appcore-efl.c: __do_app(453) > [APP 736] Event: PAUSE State: RUNNING
04-11 14:31:49.735+0200 I/CAPI_APPFW_APPLICATION(  736): app_main.c: app_appcore_pause(202) > app_appcore_pause
04-11 14:31:49.780+0200 W/W_HOME  (  799): event_manager.c: _ecore_x_message_cb(431) > moment bar move:0
04-11 14:31:49.780+0200 E/W_INDICATOR(  736): windicator_util.c: _ecore_event_client_message_cb(1299) > [_ecore_event_client_message_cb:1299] quickpanel 0
04-11 14:31:49.785+0200 E/W_INDICATOR(  736): windicator_util.c: _ecore_event_client_message_cb(1225) > [_ecore_event_client_message_cb:1225] quickpanel is closed
04-11 14:31:49.785+0200 E/W_INDICATOR(  736): windicator_moment_bar.c: windicator_moment_bar_hide(574) > [windicator_moment_bar_hide:574] Hide Moment Bar : dynamic_layout(0x4511c608)
04-11 14:31:49.785+0200 W/W_INDICATOR(  736): windicator_battery.c: windicator_battery_vconfkey_unregister(595) > [windicator_battery_vconfkey_unregister:595] Unset battery cb
04-11 14:31:49.785+0200 W/W_INDICATOR(  736): windicator_util.c: windicator_util_back_key_ungrab(879) > [windicator_util_back_key_ungrab:879] Ref count [1].
04-11 14:31:49.820+0200 I/APP_CORE(  736): appcore-efl.c: __do_app(453) > [APP 736] Event: PAUSE State: PAUSED
04-11 14:31:49.820+0200 I/APP_CORE(  736): appcore-efl.c: __visibility_cb(949) > LCD status is off, skip the AE_RESUME event
04-11 14:31:49.835+0200 E/AUL_AMD (  524): amd_main.c: __platform_ready_handler(371) > [Info]__platform_ready_handler
04-11 14:31:49.835+0200 E/ALARM_MANAGER(  518): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 2040936989, next duetime: 1523449930
04-11 14:31:49.835+0200 E/ALARM_MANAGER(  518): alarm-manager.c: __alarm_add_to_list(496) > [alarm-server]: After add alarm_id(2040936989)
04-11 14:31:49.835+0200 E/ALARM_MANAGER(  518): alarm-manager.c: __alarm_create(1061) > [alarm-server]:alarm_context.c_due_time(1523452743), due_time(1523449930)
04-11 14:31:49.850+0200 E/ALARM_MANAGER(  518): alarm-manager.c: __display_lock_state(1884) > Lock LCD OFF is successfully done
04-11 14:31:49.855+0200 E/ALARM_MANAGER(  518): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
04-11 14:31:49.855+0200 E/ALARM_MANAGER(  518): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 11-4-2018, 12:32:10 (UTC).
04-11 14:31:49.855+0200 E/ALARM_MANAGER(  518): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
04-11 14:31:49.855+0200 E/ALARM_MANAGER(  518): alarm-manager.c: __save_module_log(1780) > The file is not ready.
04-11 14:31:49.865+0200 E/ALARM_MANAGER(  518): alarm-manager.c: __display_unlock_state(1927) > Unlock LCD OFF is successfully done
04-11 14:31:49.870+0200 E/ALARM_MANAGER(  518): alarm-manager.c: __save_module_log(1780) > The file is not ready.
04-11 14:31:49.870+0200 I/TIZEN_N_SOUND_MANAGER( 1343): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Disable end. (ret: 0x0)
04-11 14:31:49.870+0200 W/TIZEN_N_SOUND_MANAGER( 1343): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
04-11 14:31:49.870+0200 W/WAKEUP-SERVICE( 1343): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 0[0;m
04-11 14:31:49.875+0200 I/HIGEAR  ( 1343): WakeupService.cpp: WakeupServiceStop(403) > [svoice:Application:WakeupServiceStop:IN]
04-11 14:31:49.875+0200 I/MALI    ( 1632): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x43306240] swap changed from async to sync
04-11 14:31:49.885+0200 W/SHealthCommon( 1422): SystemUtil.cpp: OnDeviceStatusChanged(1007) > [1;35mlcdState:3[0;m
04-11 14:31:49.885+0200 W/SHealthServiceCommon( 1422): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(645) > [1;35m ###[0;m
04-11 14:31:51.510+0200 W/W_INDICATOR(  736): windicator_util.c: _pm_state_changed_cb(915) > [_pm_state_changed_cb:915] LCD on
04-11 14:31:51.510+0200 W/W_INDICATOR(  736): windicator_ongoing_info_shealth.c: windicator_ongoing_info_shealth_update(57) > [windicator_ongoing_info_shealth_update:57] windicator_shealth_update
04-11 14:31:51.515+0200 W/SHealthCommon(  962): SystemUtil.cpp: OnDeviceStatusChanged(1007) > [1;35mlcdState:1[0;m
04-11 14:31:51.520+0200 W/SHealthCommon( 1422): SystemUtil.cpp: OnDeviceStatusChanged(1007) > [1;35mlcdState:1[0;m
04-11 14:31:51.520+0200 W/SHealthServiceCommon( 1422): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(645) > [1;35m ###[0;m
04-11 14:31:51.555+0200 W/WATCH_CORE(  888): appcore-watch.c: __signal_lcd_status_handler(1231) > signal_lcd_status_signal: LCDOn
04-11 14:31:51.555+0200 I/WATCH_CORE(  888): appcore-watch.c: __signal_lcd_status_handler(1250) > Call the time_tick_cb
04-11 14:31:51.555+0200 I/CAPI_WATCH_APPLICATION(  888): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-11 14:31:51.555+0200 I/WATCH_CORE(  888): appcore-watch.c: __signal_lcd_status_handler(1257) > Call widget_provider_update_event
04-11 14:31:51.560+0200 W/W_HOME  (  799): dbus.c: _dbus_message_recv_cb(186) > LCD on
04-11 14:31:51.560+0200 W/W_HOME  (  799): gesture.c: _manual_render_disable_timer_set(167) > timer set
04-11 14:31:51.560+0200 W/W_HOME  (  799): gesture.c: _manual_render_disable_timer_del(157) > timer del
04-11 14:31:51.565+0200 W/W_HOME  (  799): gesture.c: _apps_status_get(128) > apps status:0
04-11 14:31:51.565+0200 W/W_HOME  (  799): gesture.c: _lcd_on_cb(303) > move_to_clock:0 clock_visible:0 info->offtime:2230
04-11 14:31:51.565+0200 W/W_HOME  (  799): gesture.c: _manual_render_schedule(209) > schedule, manual render
04-11 14:31:51.565+0200 W/W_HOME  (  799): event_manager.c: _lcd_on_cb(715) > lcd state: 1
04-11 14:31:51.565+0200 W/W_HOME  (  799): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-11 14:31:51.575+0200 W/STARTER (  735): clock-mgr.c: _on_lcd_signal_receive_cb(1258) > [_on_lcd_signal_receive_cb:1258] _on_lcd_signal_receive_cb, 1258, Pre LCD on by [unknown] after screen off time [2230]ms
04-11 14:31:51.575+0200 W/STARTER (  735): clock-mgr.c: _pre_lcd_on(1027) > [_pre_lcd_on:1027] Will LCD ON as reserved app[(null)] alpm mode[0]
04-11 14:31:51.590+0200 I/APP_CORE( 1632): appcore-efl.c: __do_app(453) > [APP 1632] Event: RESUME State: PAUSED
04-11 14:31:51.590+0200 I/CAPI_APPFW_APPLICATION( 1632): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
04-11 14:31:51.600+0200 W/W_HOME  (  799): gesture.c: _widget_updated_cb(188) > widget updated
04-11 14:31:51.600+0200 W/W_HOME  (  799): gesture.c: _manual_render_disable_timer_del(157) > timer del
04-11 14:31:51.600+0200 W/W_HOME  (  799): gesture.c: _manual_render(182) > 
04-11 14:31:51.665+0200 W/W_HOME  (  799): gesture.c: _manual_render(182) > 
04-11 14:31:51.705+0200 I/HealthDataService(  852): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_GET[0;m
04-11 14:31:51.710+0200 W/W_HOME  (  799): gesture.c: _manual_render_enable(138) > 0
04-11 14:31:51.710+0200 E/ALARM_MANAGER(  518): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [735].
04-11 14:31:51.710+0200 E/ALARM_MANAGER(  518): alarm-manager.c: __alarm_remove_from_list(575) > [alarm-server]:Remove alarm id(2040936989)
04-11 14:31:51.715+0200 I/efl-extension(  799): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
04-11 14:31:51.720+0200 W/W_INDICATOR(  736): windicator_ongoing_info_shealth.c: windicator_ongoing_info_shealth_update(78) > [windicator_ongoing_info_shealth_update:78] Result : 0
04-11 14:31:51.720+0200 W/W_INDICATOR(  736): windicator_ongoing_info_shealth.c: windicator_ongoing_info_shealth_update(99) > [windicator_ongoing_info_shealth_update:99] status : none
04-11 14:31:51.720+0200 W/W_INDICATOR(  736): windicator_ongoing_info_shealth.c: windicator_ongoing_info_shealth_update(103) > [windicator_ongoing_info_shealth_update:103] application_id: 
04-11 14:31:51.720+0200 W/W_INDICATOR(  736): windicator_ongoing_info_shealth.c: windicator_ongoing_info_shealth_update(112) > [windicator_ongoing_info_shealth_update:112] launch_operation : 
04-11 14:31:51.720+0200 W/W_INDICATOR(  736): windicator_ongoing_info_shealth.c: windicator_ongoing_info_shealth_update(118) > [windicator_ongoing_info_shealth_update:118] extra_data_key : 
04-11 14:31:51.720+0200 W/W_INDICATOR(  736): windicator_ongoing_info_shealth.c: windicator_ongoing_info_shealth_update(124) > [windicator_ongoing_info_shealth_update:124] extra_data_value : 
04-11 14:31:51.720+0200 W/W_INDICATOR(  736): windicator_ongoing_info_shealth.c: windicator_ongoing_info_shealth_update(132) > [windicator_ongoing_info_shealth_update:132] image_path : 
04-11 14:31:51.720+0200 W/W_INDICATOR(  736): windicator_ongoing_info_shealth.c: windicator_ongoing_info_shealth_update(135) > [windicator_ongoing_info_shealth_update:135] image_path_sub : 
04-11 14:31:51.720+0200 W/W_INDICATOR(  736): windicator_ongoing_info_shealth.c: windicator_ongoing_info_shealth_update(138) > [windicator_ongoing_info_shealth_update:138] message_string :  
04-11 14:31:51.720+0200 W/W_INDICATOR(  736): windicator_ongoing_info_shealth.c: windicator_ongoing_info_shealth_update(144) > [windicator_ongoing_info_shealth_update:144] [Update] SHealth status is none, so hide icon and text!
04-11 14:31:51.720+0200 W/W_INDICATOR(  736): windicator_ongoing_info.c: windicator_ongoing_info_remove(191) > [windicator_ongoing_info_remove:191] Ongoing info type[1]
04-11 14:31:51.720+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-11 14:31:51.720+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-11 14:31:51.720+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-11 14:31:51.720+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-11 14:31:51.720+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-11 14:31:51.720+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-11 14:31:51.720+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-11 14:31:51.720+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-11 14:31:51.720+0200 W/W_INDICATOR(  736): windicator_ongoing_info.c: windicator_ongoing_info_remove(191) > [windicator_ongoing_info_remove:191] Ongoing info type[2]
04-11 14:31:51.720+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-11 14:31:51.720+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-11 14:31:51.720+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-11 14:31:51.720+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-11 14:31:51.720+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-11 14:31:51.720+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-11 14:31:51.720+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-11 14:31:51.720+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-11 14:31:51.725+0200 W/W_INDICATOR(  736): windicator_quick_setting_brightness.c: windicator_quick_setting_brightness_update(94) > [windicator_quick_setting_brightness_update:94] hyun 90
04-11 14:31:51.725+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-11 14:31:51.725+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-11 14:31:51.725+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-11 14:31:51.725+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-11 14:31:51.725+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-11 14:31:51.725+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-11 14:31:51.725+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-11 14:31:51.725+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-11 14:31:51.730+0200 W/W_INDICATOR(  736): windicator_connection.c: windicator_connection_resume(2158) > [windicator_connection_resume:2158] 
04-11 14:31:51.730+0200 W/W_INDICATOR(  736): windicator_connection.c: _wifi_state_changed_cb(930) > [_wifi_state_changed_cb:930] wifi state : 2
04-11 14:31:51.730+0200 W/W_INDICATOR(  736): windicator_connection.c: _wifi_state_changed_cb(974) > [_wifi_state_changed_cb:974] ap_name : (sleep.urbandroid.org)
04-11 14:31:51.730+0200 W/W_INDICATOR(  736): windicator_connection.c: _wifi_state_changed_cb(994) > [_wifi_state_changed_cb:994] wifi strength : 4
04-11 14:31:51.730+0200 W/W_INDICATOR(  736): windicator_connection.c: _connection_icon_set(713) > [_connection_icon_set:713] type : 16 / signal : type_wifi_connected_04
04-11 14:31:51.730+0200 E/W_INDICATOR(  736): windicator_connection.c: _connection_icon_set(754) > [_connection_icon_set:754] Set Connection / show sw.icon_1 (16)(0)
04-11 14:31:51.730+0200 W/W_INDICATOR(  736): windicator_connection.c: _packet_type_changed_cb(1251) > [_packet_type_changed_cb:1251] _packet_type_changed_cb
04-11 14:31:51.730+0200 E/W_INDICATOR(  736): windicator_connection.c: _packet_type_changed_cb(1261) > [_packet_type_changed_cb:1261] WIFI MODE
04-11 14:31:51.730+0200 W/W_INDICATOR(  736): windicator_connection.c: _packet_icon_set(840) > [_packet_icon_set:840] packet : 3 / signal : packet_inout_connected
04-11 14:31:51.735+0200 I/efl-extension(  736): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
04-11 14:31:51.735+0200 W/WAKEUP-SERVICE( 1343): WakeupService.cpp: OnReceiveDisplayChanged(970) > [0;32mINFO: LCDOn receive data : 1075006220[0;m
04-11 14:31:51.745+0200 W/WAKEUP-SERVICE( 1343): WakeupService.cpp: OnReceiveDisplayChanged(971) > [0;32mINFO: WakeupServiceStart[0;m
04-11 14:31:51.745+0200 W/WAKEUP-SERVICE( 1343): WakeupService.cpp: WakeupServiceStart(367) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
04-11 14:31:51.745+0200 I/TIZEN_N_SOUND_MANAGER( 1343): sound_manager_product.c: sound_manager_svoice_set_param(1287) > [SVOICE] set param [keyword length] : 0
04-11 14:31:51.745+0200 E/ALARM_MANAGER(  518): alarm-manager.c: __display_lock_state(1884) > Lock LCD OFF is successfully done
04-11 14:31:51.750+0200 E/ALARM_MANAGER(  518): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
04-11 14:31:51.750+0200 E/ALARM_MANAGER(  518): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 11-4-2018, 13:19:03 (UTC).
04-11 14:31:51.750+0200 E/ALARM_MANAGER(  518): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
04-11 14:31:51.750+0200 E/ALARM_MANAGER(  518): alarm-manager.c: __save_module_log(1780) > The file is not ready.
04-11 14:31:51.750+0200 W/TIZEN_N_SOUND_MANAGER( 1343): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
04-11 14:31:51.755+0200 E/WAKEUP-SERVICE( 1343): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
04-11 14:31:51.760+0200 E/WAKEUP-SERVICE( 1343): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
04-11 14:31:51.760+0200 E/ALARM_MANAGER(  518): alarm-manager.c: __display_unlock_state(1927) > Unlock LCD OFF is successfully done
04-11 14:31:51.760+0200 E/ALARM_MANAGER(  518): alarm-manager.c: alarm_manager_alarm_delete(2462) > alarm_id[2040936989] is removed.
04-11 14:31:51.760+0200 E/ALARM_MANAGER(  518): alarm-manager.c: __save_module_log(1780) > The file is not ready.
04-11 14:31:51.760+0200 W/SHealthServiceCommon( 1422): EnergyExpenditureFeatureController.cpp: OnTotalEnergyExpenditureChanged(119) > [1;40;33mstart 1523397600000,000000, end 1523449911767,000000, calories 1079,740069[0;m
04-11 14:31:51.765+0200 W/STARTER (  735): clock-mgr.c: _on_lcd_signal_receive_cb(1271) > [_on_lcd_signal_receive_cb:1271] _on_lcd_signal_receive_cb, 1271, Post LCD on by [unknown]
04-11 14:31:51.765+0200 W/STARTER (  735): clock-mgr.c: _post_lcd_on(1059) > [_post_lcd_on:1059] LCD ON as reserved app[(null)] alpm mode[0]
04-11 14:31:51.770+0200 W/SHealthCommon( 1422): SHealthMessagePortConnection.cpp: SendServiceMessage(558) > [1;40;33mmessageName: energy_expenditure_updated, pendingClientInfoList.size(): 0[0;m
04-11 14:31:51.770+0200 I/TIZEN_N_SOUND_MANAGER( 1343): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Enable start
04-11 14:31:51.780+0200 I/TIZEN_N_SOUND_MANAGER( 1343): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Enable end. (ret: 0x0)
04-11 14:31:51.780+0200 W/TIZEN_N_SOUND_MANAGER( 1343): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
04-11 14:31:51.780+0200 W/WAKEUP-SERVICE( 1343): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 1[0;m
04-11 14:31:51.780+0200 I/HIGEAR  ( 1343): WakeupService.cpp: WakeupServiceStart(393) > [svoice:Application:WakeupServiceStart:IN]
04-11 14:31:51.825+0200 W/W_INDICATOR(  736): windicator_dbus.c: _windicator_dbus_lcd_changed_cb(533) > [_windicator_dbus_lcd_changed_cb:533] LCD ON signal is received
04-11 14:31:51.825+0200 W/W_INDICATOR(  736): windicator_dbus.c: _windicator_dbus_lcd_changed_cb(554) > [_windicator_dbus_lcd_changed_cb:554] 554, str=[unknown],charge : 0, connected : 0
04-11 14:31:51.825+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-11 14:31:51.825+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-11 14:31:51.825+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-11 14:31:51.825+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-11 14:31:51.825+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-11 14:31:51.825+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-11 14:31:51.825+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [starter:org.tizen.idled.ReservedApp]
04-11 14:31:51.825+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-11 14:31:51.830+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-11 14:31:51.830+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-11 14:31:51.830+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-11 14:31:51.830+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-11 14:31:51.830+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-11 14:31:51.830+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-11 14:31:51.830+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [starter:org.tizen.idled.ReservedApp]
04-11 14:31:51.830+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-11 14:31:51.830+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-11 14:31:51.830+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-11 14:31:51.830+0200 W/STARTER (  735): clock-mgr.c: __reserved_apps_message_received_cb(586) > [__reserved_apps_message_received_cb:586] appid[com.samsung.windicator]
04-11 14:31:51.830+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-11 14:31:51.830+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-11 14:31:51.830+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-11 14:31:51.830+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-11 14:31:51.830+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-11 14:31:51.830+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-11 14:31:51.830+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.windicator:org.tizen.idled.ReservedApp]
04-11 14:31:51.830+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-11 14:31:51.830+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-11 14:31:51.830+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-11 14:31:51.830+0200 W/W_INDICATOR(  736): windicator_dbus.c: _msg_reserved_app_cb(336) > [_msg_reserved_app_cb:336] Moment view is already shown or call is enabled. moment view [0]
04-11 14:31:54.745+0200 I/APP_CORE(  736): appcore-efl.c: __do_app(453) > [APP 736] Event: MEM_FLUSH State: PAUSED
04-11 14:31:58.060+0200 W/WECONN  (  505): <__on_connect_opponent:208> {
04-11 14:31:58.060+0200 W/WECONN  (  505): <__on_connect_opponent:210> connected : 1
04-11 14:31:58.060+0200 W/WECONN  (  505): <__on_connect_opponent:211> remote_address : A2:51
04-11 14:31:58.060+0200 W/WECONN  (  505): <wc_manager_get_bearer_state:996> type : 1
04-11 14:31:58.060+0200 W/WECONN  (  505): <wc_manager_on_notify_bearer_state:931> type=WC_BEARER_TYPE_BLUETOOTH, new_state=WC_BEARER_STATE_CONNECTED, previous_state=WC_BEARER_STATE_ENABLED
04-11 14:31:58.060+0200 W/WECONN  (  505): <wc_manager_get_bearer_state:996> type : 1
04-11 14:31:58.060+0200 W/WECONN  (  505): <wc_device_on_notify_bearer_connected:2595> {
04-11 14:31:58.060+0200 W/WECONN  (  505):  ### Bearer Connected [WC_BEARER_TYPE_BLUETOOTH]
04-11 14:31:58.060+0200 W/WECONN  (  505): <wc_device_on_notify_bearer_connected:2606> device=0x428ed0a8, bearer=WC_BEARER_TYPE_BLUETOOTH, master os=Android, rfcomm enabled?=1, spp connected?=0, hfp connected?=0
04-11 14:31:58.060+0200 W/WECONN  (  505): <wc_device_on_notify_bearer_connected:2649> }
04-11 14:31:58.060+0200 W/WECONN  (  505): <__is_device_matched_to:2709> le : , br_edr : A2:51, identifier : A2:51
04-11 14:31:58.060+0200 W/WECONN  (  505): <__on_connect_opponent:232> }
04-11 14:31:58.990+0200 I/WSM     (  519): WSM_I [si]
04-11 14:31:58.990+0200 I/WSM     (  519): T: LIB_VERSION_NUMBER=2.2.2.BASELINE=12577324. 
04-11 14:31:59.205+0200 I/WSM     (  519): WSM_I [sgcc]
04-11 14:31:59.370+0200 I/WSM     (  519): WSM_I [scagcr]
04-11 14:31:59.600+0200 I/WSM     (  519): WSM_I [ge]
04-11 14:31:59.615+0200 I/WSM     (  519): WSM_I [d]
04-11 14:31:59.620+0200 I/WSM     (  519): WSM_I [si]
04-11 14:31:59.620+0200 I/WSM     (  519): T: LIB_VERSION_NUMBER=2.2.2.BASELINE=12577324. 
04-11 14:32:00.340+0200 I/WSM     (  519): WSM_I [ca]
04-11 14:32:00.380+0200 I/WSM     (  519): WSM_I [ca]
04-11 14:32:00.405+0200 I/WSM     (  519): WSM_I [ca]
04-11 14:32:00.425+0200 I/WSM     (  519): WSM_I [ca]
04-11 14:32:00.455+0200 I/WSM     (  519): WSM_I [ca]
04-11 14:32:00.495+0200 I/WSM     (  519): WSM_I [ca]
04-11 14:32:00.510+0200 I/WSM     (  519): WSM_I [ca]
04-11 14:32:00.525+0200 I/WSM     (  519): WSM_I [ca]
04-11 14:32:00.545+0200 I/WSM     (  519): WSM_I [ca]
04-11 14:32:00.555+0200 I/WSM     (  519): WSM_I [ca]
04-11 14:32:00.565+0200 I/WSM     (  519): WSM_I [ca]
04-11 14:32:00.570+0200 I/WSM     (  519): WSM_I [ca]
04-11 14:32:00.580+0200 I/WSM     (  519): WSM_I [ca]
04-11 14:32:00.590+0200 I/WSM     (  519): WSM_I [ca]
04-11 14:32:00.595+0200 I/WSM     (  519): WSM_I [ca]
04-11 14:32:00.605+0200 I/WSM     (  519): WSM_I [ca]
04-11 14:32:00.615+0200 I/WSM     (  519): WSM_I [ca]
04-11 14:32:00.625+0200 I/WSM     (  519): WSM_I [ca]
04-11 14:32:00.630+0200 I/WSM     (  519): WSM_I [ca]
04-11 14:32:00.645+0200 I/WSM     (  519): WSM_I [ca]
04-11 14:32:00.655+0200 I/WSM     (  519): WSM_I [ca]
04-11 14:32:00.665+0200 I/WSM     (  519): WSM_I [ca]
04-11 14:32:00.675+0200 I/WSM     (  519): WSM_I [ca]
04-11 14:32:00.685+0200 I/WSM     (  519): WSM_I [ca]
04-11 14:32:00.695+0200 I/WSM     (  519): WSM_I [ca]
04-11 14:32:00.705+0200 W/WPROXY  ( 1024): sap.c: on_device_status(257) > ConnectivityType: 1, device_status: 1, is_sap_reset : 0
04-11 14:32:00.710+0200 E/wnoti-service( 1050): wnoti-sap-client.c: _get_connection_type_cb(3551) > connection_type : 1
04-11 14:32:00.710+0200 W/W_HOME  (  799): clock_view_indicator.c: _view_remove_by_type(267) > removed:3
04-11 14:32:00.710+0200 W/W_INDICATOR(  736): windicator_dynamic.c: _dynamic_bluetooth_state_changed_cb(1071) > [_dynamic_bluetooth_state_changed_cb:1071] isBTOn : 1
04-11 14:32:00.710+0200 W/W_INDICATOR(  736): windicator_dynamic.c: _dynamic_bluetooth_state_changed_cb(1077) > [_dynamic_bluetooth_state_changed_cb:1077] sap connected : 0
04-11 14:32:00.710+0200 W/W_HOME  (  799): clock_indicator.c: clock_indicator_pop(374) > icon:3(0) is popped from clock indicator
04-11 14:32:00.710+0200 W/W_INDICATOR(  736): windicator_dynamic.c: _dynamic_bluetooth_state_changed_cb(1083) > [_dynamic_bluetooth_state_changed_cb:1083] sap connectivity type : 1
04-11 14:32:00.710+0200 W/W_HOME  (  799): cfwd.c: cfwd_get_icon_status(362) > 
04-11 14:32:00.710+0200 W/W_HOME  (  799): ============================
04-11 14:32:00.710+0200 W/W_HOME  (  799): multi_sim_category:0
04-11 14:32:00.710+0200 W/W_HOME  (  799): multi_sim_model:0
04-11 14:32:00.710+0200 W/W_HOME  (  799): support_callforward_auto:0
04-11 14:32:00.710+0200 W/W_HOME  (  799): conn_status:1
04-11 14:32:00.710+0200 W/W_HOME  (  799): remote_call_forward_auto:0
04-11 14:32:00.710+0200 W/W_HOME  (  799): auto_call_forward_status:0
04-11 14:32:00.710+0200 W/W_HOME  (  799): support_callforward_reverse:0
04-11 14:32:00.710+0200 W/W_HOME  (  799): reverse_call_forward_auto:0
04-11 14:32:00.710+0200 W/W_HOME  (  799): fwd_type:
04-11 14:32:00.710+0200 W/W_HOME  (  799): ============================
04-11 14:32:00.710+0200 W/W_HOME  (  799): 
04-11 14:32:00.710+0200 W/W_HOME  (  799): clock_view_indicator.c: _view_call_fw_icon(136) > call fwd status:0
04-11 14:32:00.710+0200 W/W_INDICATOR(  736): windicator_dynamic.c: _dynamic_event_item_pack(870) > [_dynamic_event_item_pack:870] There is NO Headset icon, so move wifi icon to position 1
04-11 14:32:00.710+0200 E/W_INDICATOR(  736): windicator_dynamic.c: _dynamic_bluetooth_state_changed_cb(1097) > [_dynamic_bluetooth_state_changed_cb:1097] Failed to get moment view bt icon
04-11 14:32:00.710+0200 I/W_INDICATOR(  736): windicator.c: windicator_is_lo_connected(976) > [windicator_is_lo_connected:976] Connected target vendor : LGE
04-11 14:32:00.710+0200 E/EFL     (  736): <736> elm_main.c:1622 elm_object_signal_emit() safety check failed: obj == NULL
04-11 14:32:00.710+0200 E/W_HOME  (  799): retailmode.c: retailmode_enabled_get(245) > failed to get value VCONFKEY_RETAILMODE_ENABLED
04-11 14:32:00.710+0200 E/TIZEN_N_SYSTEM_SETTINGS(  736): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-11 14:32:00.710+0200 E/TIZEN_N_SYSTEM_SETTINGS(  736): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-11 14:32:00.710+0200 E/TIZEN_N_SYSTEM_SETTINGS(  736): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=4
04-11 14:32:00.710+0200 E/TIZEN_N_SYSTEM_SETTINGS(  736): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 4, key = 4, type = 0
04-11 14:32:00.710+0200 W/W_HOME  (  799): clock_event.c: _wmanager_connectivity_get(397) > network status : 0
04-11 14:32:00.710+0200 W/W_HOME  (  799): clock_event.c: _wmanager_connectivity_get(402) > sap_connected : 0
04-11 14:32:00.710+0200 W/W_HOME  (  799): clock_event.c: _wmanager_connectivity_get(408) > sap connectivity type : 1
04-11 14:32:00.710+0200 W/W_HOME  (  799): clock_event.c: _wmanager_connectivity_get(414) > network status : 2
04-11 14:32:00.720+0200 W/W_HOME  (  799): clock_event.c: _wmanager_connectivity_get(428) > scs login : 0
04-11 14:32:00.720+0200 W/W_HOME  (  799): clock_indicator.c: clock_indicator_pop_icon(395) > icon:5 is popped from clock indicator
04-11 14:32:00.745+0200 W/W_HOME  (  799): clock_indicator.c: clock_indicator_icon_push(360) > icon:5 is added to clock indicator
04-11 14:32:00.780+0200 W/W_INDICATOR(  736): windicator_scs.c: windicator_scs_update(123) > [windicator_scs_update:123] sales code : 0
04-11 14:32:00.780+0200 I/WPROXY  ( 1024): sap.c: on_peer_agent(123) > wStatusCode: 0, uwLocalAgentId: 59283
04-11 14:32:00.785+0200 W/W_INDICATOR(  736): windicator_scs.c: windicator_scs_update(131) > [windicator_scs_update:131] sap connected : 0
04-11 14:32:00.785+0200 W/W_INDICATOR(  736): windicator_scs.c: windicator_scs_update(146) > [windicator_scs_update:146] ciss_request_type : 0
04-11 14:32:00.785+0200 I/W_INDICATOR(  736): windicator_scs.c: windicator_scs_update(155) > [windicator_scs_update:155] Hide (Callforwarding requested)
04-11 14:32:00.785+0200 I/W_INDICATOR(  736): windicator.c: windicator_is_lo_connected(976) > [windicator_is_lo_connected:976] Connected target vendor : LGE
04-11 14:32:00.785+0200 W/W_INDICATOR(  736): windicator_scs.c: windicator_scs_update(195) > [windicator_scs_update:195] sap connectivity type : 1
04-11 14:32:00.785+0200 W/W_INDICATOR(  736): windicator_scs.c: windicator_scs_update(203) > [windicator_scs_update:203] network status : 2
04-11 14:32:00.785+0200 W/W_INDICATOR(  736): windicator_scs.c: windicator_scs_update(220) > [windicator_scs_update:220] scs login : 0
04-11 14:32:00.785+0200 W/W_INDICATOR(  736): windicator_scs.c: windicator_scs_update(224) > [windicator_scs_update:224] not connected
04-11 14:32:00.790+0200 E/WMS     (  521): wms_msg_broker.c: on_peer_agent(1127) > peer agent found
04-11 14:32:00.790+0200 E/WMS     (  521): wms_msg_broker.c: on_peer_agent(1132) > weconn all_connected = FALSE, Do not create connection
04-11 14:32:00.800+0200 W/WECONN  (  505): <__on_device_status_changed_cb:910> status : 1, trnasport_type : 1
04-11 14:32:00.800+0200 I/magazine-service(  975): magazine-service-connection.c: _magazine_service_connection_vconf_key_changed_cb(211) > host_connected_by_bt changed [0] -> [1]
04-11 14:32:00.805+0200 I/w-magazine-widget(  975): widget.c: _magazine_widget_noti_event_callback(968) > noti[4]
04-11 14:32:00.815+0200 I/magazine-service(  975): magazine-service-db.c: _magazine_service_db_topics_get(477) > 0 topics in the result list
04-11 14:32:00.815+0200 I/magazine-service(  975): magazine-service-retail-mode.c: magazine_service_common_retail_mode_enable(35) > vconf_get_int(RETAIL MODE) returns -1
04-11 14:32:00.820+0200 I/magazine-service(  975): magazine-service-retail-mode.c: magazine_service_common_retail_mode_enable(35) > vconf_get_int(RETAIL MODE) returns -1
04-11 14:32:00.820+0200 I/w-magazine-widget(  975): widget.c: _magazine_widget_stories_list_get(191) > [0] topics, [0] stories
04-11 14:32:00.820+0200 I/w-magazine-widget(  975): widget.c: _magazine_widget_layout_create(857) > 
04-11 14:32:00.830+0200 I/w-magazine-widget(  975): widget.c: _magazine_widget_layout_create(930) > No items
04-11 14:32:00.870+0200 I/AUL     (  505): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/weconnd, ret : 0
04-11 14:32:00.900+0200 I/AUL     (  505): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/weconnd, ret : 0
04-11 14:32:00.900+0200 E/CAPI_APPFW_APPLICATION(  505): app_error.c: app_error(64) > [app_get_id] INVALID_CONTEXT(0xfef00001) : failed to get the application ID
04-11 14:32:00.905+0200 W/MC_CONSUMER( 1100): wmc-service-consumer.c: __wmc_on_peer_agent(281) > [33m find peer agent success[0m
04-11 14:32:00.910+0200 W/MC_CONSUMER( 1100): wmc-service-consumer.c: __wmc_create_service_connection(213) > [33m call create service connection[0m
04-11 14:32:00.910+0200 W/MC_CONSUMER( 1100): wmc-service-consumer.c: __wmc_on_device_status(423) > [33m device_type : [1], status : [1][0m
04-11 14:32:00.910+0200 E/WMS     (  521): wms_msg_broker.c: on_device_status(539) > 
04-11 14:32:00.910+0200 E/WMS     (  521): ==========
04-11 14:32:00.910+0200 E/WMS     (  521): ##WMS Connected : status[1], device type[1], conn type [0x01]
04-11 14:32:00.910+0200 E/WMS     (  521): ==========
04-11 14:32:00.910+0200 E/WMS     (  521): wms_bluetooth.c: wms_bluetooth_update_host_wearable_circle_triangle_connection_status(623) > host_circle_connection[0] wearable_circle_connection[0] connection_type[1]
04-11 14:32:00.910+0200 E/WMS     (  521): wms_bluetooth.c: wms_bluetooth_update_host_wearable_circle_triangle_connection_status(626) > host-wearable-circle : not triangel connection now
04-11 14:32:00.930+0200 I/SleepAsAndroidConsumer( 1639): Find Peer Success!!
04-11 14:32:00.930+0200 D/SleepAsAndroidConsumer( 1639): request_service_connection call over
04-11 14:32:00.930+0200 I/SleepAsAndroidConsumer( 1639): connectivity type(1): bt
04-11 14:32:00.930+0200 W/WPROXY  ( 1024): sap.c: on_service_connection_confirm(151) > uwLocalAgentId: 59283, uwServiceHandle: 19206, wStatusCode: 0
04-11 14:32:00.930+0200 I/WPROXY  ( 1024): sap.c: on_service_connection_confirm(156) > service connection success.
04-11 14:32:00.930+0200 W/WPROXY  ( 1024): net-device.c: net_device_enable_if_proxy(355) > backup info : config[1], status[2]
04-11 14:32:00.935+0200 I/DOWNLOAD_PROVIDER( 1033): download-provider-client-manager.c: dp_broadcast_signal(65) > broadcast
04-11 14:32:00.935+0200 I/DOWNLOAD_PROVIDER( 1033): download-provider-network.c: __dp_network_is_companion_mode(53) > wms_connected:0, companion_mode:1
04-11 14:32:00.935+0200 I/DOWNLOAD_PROVIDER( 1033): download-provider-network.c: __dp_network_connection_type_changed_cb(174) > ETHERNET CONNECTED
04-11 14:32:00.935+0200 W/WPROXY  ( 1024): net-device.c: net_device_enable_if_proxy(380) > Successfully enabled
04-11 14:32:00.935+0200 E/WPROXY  ( 1024): net-device.c: net_device_set_reactivation_lock_status(299) > Not in reactivation lock.
04-11 14:32:00.940+0200 E/TIZEN_N_SYSTEM_SETTINGS(  736): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-11 14:32:00.940+0200 E/TIZEN_N_SYSTEM_SETTINGS(  736): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-11 14:32:00.940+0200 E/TIZEN_N_SYSTEM_SETTINGS(  736): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=4
04-11 14:32:00.940+0200 E/TIZEN_N_SYSTEM_SETTINGS(  736): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 4, key = 4, type = 0
04-11 14:32:00.950+0200 E/W_HOME  (  799): retailmode.c: retailmode_enabled_get(245) > failed to get value VCONFKEY_RETAILMODE_ENABLED
04-11 14:32:00.950+0200 W/W_HOME  (  799): clock_event.c: _wmanager_connectivity_get(397) > network status : 0
04-11 14:32:00.950+0200 W/W_HOME  (  799): clock_event.c: _wmanager_connectivity_get(402) > sap_connected : 0
04-11 14:32:00.950+0200 W/W_HOME  (  799): clock_event.c: _wmanager_connectivity_get(408) > sap connectivity type : 1
04-11 14:32:00.950+0200 W/W_HOME  (  799): clock_event.c: _wmanager_connectivity_get(414) > network status : 3
04-11 14:32:00.950+0200 W/W_HOME  (  799): clock_event.c: _wmanager_connectivity_get(428) > scs login : 0
04-11 14:32:00.950+0200 W/W_HOME  (  799): clock_indicator.c: clock_indicator_pop_icon(395) > icon:5 is popped from clock indicator
04-11 14:32:00.955+0200 W/W_HOME  (  799): clock_indicator.c: clock_indicator_icon_push(360) > icon:5 is added to clock indicator
04-11 14:32:00.955+0200 W/WECONN  (  505): <wc_manager_get_bearer_state:996> type : 5
04-11 14:32:00.955+0200 W/WECONN  (  505): <wc_manager_on_notify_bearer_state:931> type=WC_BEARER_TYPE_SAP, new_state=WC_BEARER_STATE_CONNECTED, previous_state=WC_BEARER_STATE_DISCONNECTED
04-11 14:32:00.955+0200 W/WECONN  (  505): <wc_manager_get_bearer_state:996> type : 5
04-11 14:32:00.955+0200 W/WECONN  (  505): <wc_device_on_notify_bearer_connected:2595> {
04-11 14:32:00.955+0200 W/WECONN  (  505):  ### Bearer Connected [WC_BEARER_TYPE_SAP]
04-11 14:32:00.960+0200 W/WECONN  (  505): <wc_device_on_notify_bearer_connected:2606> device=0x428ed0a8, bearer=WC_BEARER_TYPE_SAP, master os=Android, rfcomm enabled?=1, spp connected?=0, hfp connected?=0
04-11 14:32:00.960+0200 W/WECONN  (  505): <wc_device_on_notify_bearer_connected:2649> }
04-11 14:32:00.970+0200 E/CAPI_NETWORK_CONNECTION(  975): connection.c: __connection_cb_proxy_changed_cb_idle(344) > Unknown Proxy address type: IP(192.168.153.100:8080) 
04-11 14:32:00.995+0200 W/W_INDICATOR(  736): windicator_scs.c: windicator_scs_update(123) > [windicator_scs_update:123] sales code : 0
04-11 14:32:00.995+0200 I/magazine-service(  975): magazine-service-connection.c: _magazine_service_connection_type_changed_cb(131) > connection type changed [1] -> [3]
04-11 14:32:00.995+0200 W/W_INDICATOR(  736): windicator_scs.c: windicator_scs_update(131) > [windicator_scs_update:131] sap connected : 0
04-11 14:32:00.995+0200 W/W_INDICATOR(  736): windicator_scs.c: windicator_scs_update(146) > [windicator_scs_update:146] ciss_request_type : 0
04-11 14:32:00.995+0200 I/W_INDICATOR(  736): windicator_scs.c: windicator_scs_update(155) > [windicator_scs_update:155] Hide (Callforwarding requested)
04-11 14:32:00.995+0200 I/W_INDICATOR(  736): windicator.c: windicator_is_lo_connected(976) > [windicator_is_lo_connected:976] Connected target vendor : LGE
04-11 14:32:00.995+0200 W/W_INDICATOR(  736): windicator_scs.c: windicator_scs_update(195) > [windicator_scs_update:195] sap connectivity type : 1
04-11 14:32:01.000+0200 W/W_INDICATOR(  736): windicator_scs.c: windicator_scs_update(203) > [windicator_scs_update:203] network status : 3
04-11 14:32:01.000+0200 W/W_INDICATOR(  736): windicator_scs.c: windicator_scs_update(220) > [windicator_scs_update:220] scs login : 0
04-11 14:32:01.000+0200 W/W_INDICATOR(  736): windicator_scs.c: windicator_scs_update(224) > [windicator_scs_update:224] not connected
04-11 14:32:01.015+0200 I/w-magazine-widget(  975): widget.c: _magazine_widget_noti_event_callback(968) > noti[2]
04-11 14:32:01.015+0200 I/magazine-service(  975): magazine-service-db.c: _magazine_service_db_topics_get(477) > 0 topics in the result list
04-11 14:32:01.020+0200 D/SleepAsAndroidConsumer( 1639): req service conn call succeeded
04-11 14:32:01.020+0200 I/magazine-service(  975): magazine-service-retail-mode.c: magazine_service_common_retail_mode_enable(35) > vconf_get_int(RETAIL MODE) returns -1
04-11 14:32:01.025+0200 I/magazine-service(  975): magazine-service-retail-mode.c: magazine_service_common_retail_mode_enable(35) > vconf_get_int(RETAIL MODE) returns -1
04-11 14:32:01.025+0200 I/w-magazine-widget(  975): widget.c: _magazine_widget_stories_list_get(191) > [0] topics, [0] stories
04-11 14:32:01.025+0200 I/w-magazine-widget(  975): widget.c: _magazine_widget_layout_create(857) > 
04-11 14:32:01.030+0200 I/w-magazine-widget(  975): widget.c: _magazine_widget_layout_create(930) > No items
04-11 14:32:01.070+0200 W/WECONN  (  505): <__on_peer_agent_updated_cb:654> result : 0, peer_status : 1
04-11 14:32:01.070+0200 W/WECONN  (  505): <__on_peer_agent_updated_cb:669> sap device_address : A2:51
04-11 14:32:01.070+0200 W/WECONN  (  505): <__on_peer_agent_updated_cb:676> device_name : Nexus 5
04-11 14:32:01.070+0200 W/WECONN  (  505): <__on_peer_agent_updated_cb:683> trnasport_type : 1
04-11 14:32:01.070+0200 W/WECONN  (  505): <wc_manager_on_notify_connection_state:1349> { type=WC_CONNECTION_TYPE_BLUETOOTH_SPP, new_state=WC_CONNECTION_STATE_CONNECTED, remote_id=A2:51, result=0
04-11 14:32:01.070+0200 W/WECONN  (  505): <__wc_manager_on_notify_device_connected:1023> {
04-11 14:32:01.070+0200 W/WECONN  (  505): <__is_device_matched_to:2709> le : , br_edr : A2:51, identifier : A2:51
04-11 14:32:01.070+0200 W/WECONN  (  505): <__wc_manager_on_notify_device_connected:1064> create connection : 0x42916d68
04-11 14:32:01.070+0200 W/WECONN  (  505): <wc_device_on_notify_connected:2764> {
04-11 14:32:01.070+0200 W/WECONN  (  505):  ### Connected [WC_CONNECTION_TYPE_BLUETOOTH_SPP]
04-11 14:32:01.070+0200 W/WECONN  (  505): <wc_device_on_notify_connected:2778> device=0x428ed0a8, connection=WC_CONNECTION_TYPE_BLUETOOTH_SPP, master os=Android, rfcomm enabled?=1, spp connected?=0, hfp connected?=0
04-11 14:32:01.070+0200 W/WECONN  (  505): <__wc_device_notify_all_connected:524> { device=0x428ed0a8, connected=0
04-11 14:32:01.070+0200 W/WECONN  (  505): <__wc_device_notify_all_connected:539> } Not changed all connected state
04-11 14:32:01.075+0200 W/WECONN  (  505): <__wc_device_scs_disconnect:982> {
04-11 14:32:01.075+0200 W/WECONN  (  505): <__wc_device_try_to_disconnect:747> try to disconnect...{
04-11 14:32:01.075+0200 W/WECONN  (  505): <__disconnect:1242> Sap disconnect. type=10
04-11 14:32:01.075+0200 W/WECONN  (  505): <__get_sap_device_by_type:314> transport_type : 16
04-11 14:32:01.075+0200 W/WECONN  (  505): <__get_sap_device_by_type:321> Matched
04-11 14:32:01.075+0200 W/WECONN  (  505): <__disconnect:1253> transaction_id : 1, device_id : 0
04-11 14:32:01.075+0200 W/WECONN  (  505): <__wc_device_try_to_disconnect:770> }...trying to disconnect was finished
04-11 14:32:01.075+0200 W/WECONN  (  505):  ### Disconnect Request [WC_CONNECTION_TYPE_SCS]
04-11 14:32:01.075+0200 W/WECONN  (  505): <__wc_device_scs_disconnect:1002> }
04-11 14:32:01.075+0200 W/WECONN  (  505): <__wc_device_try_to_deactivate:806> bearer is WC_BEARER_TYPE_CELLULAR
04-11 14:32:01.075+0200 E/WECONN  (  505): <__wc_device_try_to_deactivate:812> ret : -125
04-11 14:32:01.075+0200 W/WECONN  (  505): <__advertise:968> advertising state{previous=0, request to=0
04-11 14:32:01.075+0200 W/WECONN  (  505): <__advertise:971> already requested to advertise = 0
04-11 14:32:01.075+0200 W/WECONN  (  505): <__wc_manager_on_notify_device_connected:1162> }
04-11 14:32:01.075+0200 W/WECONN  (  505): <wc_manager_on_notify_connection_state:1361> }
04-11 14:32:01.075+0200 W/WECONN  (  505): <wc_sap_consumer_on_notify_connected:783> type : 1
04-11 14:32:01.080+0200 W/CAPI_NETWORK_WECONN(  529): <__weconn_manager_signal_filter:364> { mark to destroy...
04-11 14:32:01.080+0200 W/CAPI_NETWORK_WECONN(  529): <__weconn_manager_signal_filter:458> service : W_SERVICE_TYPE_BT, result : 3
04-11 14:32:01.080+0200 W/CAPI_NETWORK_WECONN( 1100): <__weconn_manager_signal_filter:364> { mark to destroy...
04-11 14:32:01.080+0200 W/MC_CONSUMER( 1100): wmc-service-cotroller.c: _bt_connection_changed_cb(60) > [33m connected[1][0m
04-11 14:32:01.080+0200 W/CAPI_NETWORK_WECONN( 1100): <__weconn_manager_signal_filter:458> service : W_SERVICE_TYPE_BT, result : 3
04-11 14:32:01.080+0200 W/WECONN  (  505): <wc_manager_get_bearer_state:996> type : 2
04-11 14:32:01.080+0200 E/CAPI_NETWORK_CONNECTION(  505): libnetwork.c: _connection_check_feature_supported(1881) > Error - Feature is not supported
04-11 14:32:01.085+0200 E/WECONN  (  505): <__get_cellular_state_with_previous_and_now:224> couldn't get cellular state. result = -1073741822
04-11 14:32:01.085+0200 W/WECONN  (  505): <__on_change_connection_type:255> { type = 3, state = WC_BEARER_STATE_NONE
04-11 14:32:01.085+0200 W/WECONN  (  505): <wc_manager_get_bearer_state:996> type : 3
04-11 14:32:01.085+0200 W/WECONN  (  505): <wc_manager_get_bearer_state:996> type : 2
04-11 14:32:01.085+0200 W/WECONN  (  505): <wc_manager_on_notify_bearer_state:931> type=WC_BEARER_TYPE_CELLULAR, new_state=WC_BEARER_STATE_NONE, previous_state=WC_BEARER_STATE_NONE
04-11 14:32:01.085+0200 W/WECONN  (  505): <wc_manager_get_bearer_state:996> type : 2
04-11 14:32:01.085+0200 W/WECONN  (  505): <wc_manager_on_notify_bearer_state:933> skipped.
04-11 14:32:01.085+0200 W/WECONN  (  505): <__on_change_connection_type:263> }
04-11 14:32:01.125+0200 D/SleepAsAndroidConsumer( 1639): find peer call succeeded
04-11 14:32:01.125+0200 D/SleepAsAndroidConsumer( 1639): find peer call is over
04-11 14:32:01.130+0200 I/SleepAsAndroidConsumer( 1639): Find Peer Success!!
04-11 14:32:01.130+0200 D/SleepAsAndroidConsumer( 1639): request_service_connection call over
04-11 14:32:01.135+0200 D/SleepAsAndroidConsumer( 1639): req service conn call succeeded
04-11 14:32:01.395+0200 W/MC_CONSUMER( 1100): wmc-service-consumer.c: __wmc_on_service_connection_confirm(295) > [33m uwLocalAgentId : [31504], uwServiceHandle : [53715], wResponseCode : [0][0m
04-11 14:32:01.395+0200 W/MC_CONSUMER( 1100): wmc-service-consumer.c: __wmc_on_service_connection_confirm(335) > [33m wms not connected yet.. delay connection callback[0m
04-11 14:32:01.430+0200 I/SleepAsAndroidConsumer( 1639): peer agent connection is successful, pa :1134563440
04-11 14:32:01.500+0200 I/SleepAsAndroidConsumer( 1639): Sending data Version 1.0.9
04-11 14:32:01.900+0200 W/CRASH_MANAGER( 1703): worker.c: worker_job(1205) > 0601639736c65152344992
