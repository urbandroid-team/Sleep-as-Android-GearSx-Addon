S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.2.7
Build-Number: R732XXU2FRC1
Build-Date: 2018.03.02 17:21:30

Crash Information
Process Name: sleepasandroidnativeservice
PID: 23994
Date: 2018-04-11 11:10:46+0200
Executable File Path: /opt/usr/apps/com.urbandroid.sleep/bin/sleepasandroidnativeservice
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x9864

Register Information
r0   = 0x43a00da0, r1   = 0x43a02ed5
r2   = 0x00000000, r3   = 0x43a02ed0
r4   = 0x00009864, r5   = 0x00000000
r6   = 0x00000000, r7   = 0xbef73eb0
r8   = 0x00006899, r9   = 0x00006899
r10  = 0x430acec8, fp   = 0x00000000
ip   = 0x00000000, sp   = 0xbef73df8
lr   = 0x2e302e31, pc   = 0x4005e244
cpsr = 0x60000030

Memory Information
MemTotal:   490112 KB
MemFree:     20912 KB
Buffers:      8756 KB
Cached:     117560 KB
VmPeak:      61328 KB
VmSize:      61324 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        9104 KB
VmRSS:        9104 KB
VmData:      12296 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       19584 KB
VmPTE:          32 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 23994 TID = 23994
23994 24001 

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
4319a000 43a00000 rw-p [stack:24001]
bef54000 bef75000 rw-p [stack]
End of Maps Information

Callstack Information (PID:23994)
Call Stack Count: 20
 0: app_get_version + 0x5f (0x4005e244) [/usr/lib/libcapi-appfw-app-common.so.0] + 0x1244
 1: on_service_connection_created + 0xc6 (0x40002167) [/opt/usr/apps/com.urbandroid.sleep/bin/sleepasandroidnativeservice] + 0x2167
 2: sap_wrapper_service_connection_confirm_cb + 0x5c (0x40349839) [/usr/lib/libsap-client-stub-api.so.1] + 0xc839
 3: (0x40343405) [/usr/lib/libsap-client-stub-api.so.1] + 0x6405
 4: (0x40ab365f) [/usr/lib/libsap_client.so.0] + 0x365f
 5: g_simple_async_result_complete + 0x68 (0x4062dbed) [/usr/lib/libgio-2.0.so.0] + 0x4cbed
 6: (0x406649b1) [/usr/lib/libgio-2.0.so.0] + 0x839b1
 7: g_simple_async_result_complete + 0x68 (0x4062dbed) [/usr/lib/libgio-2.0.so.0] + 0x4cbed
 8: (0x4062dca1) [/usr/lib/libgio-2.0.so.0] + 0x4cca1
 9: (0x4029ffcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
10: g_main_context_dispatch + 0xbc (0x402a17a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
11: (0x400b1ca7) [/usr/lib/libecore.so.1] + 0x10ca7
12: (0x400acb4f) [/usr/lib/libecore.so.1] + 0xbb4f
13: (0x400ad5a7) [/usr/lib/libecore.so.1] + 0xc5a7
14: ecore_main_loop_begin + 0x30 (0x400ad879) [/usr/lib/libecore.so.1] + 0xc879
15: appcore_agent_main + 0x56 (0x40053183) [/usr/lib/libappcore-agent.so.1] + 0x1183
16: service_app_main + 0x54 (0x400537fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
17: main + 0x100 (0x40002c79) [/opt/usr/apps/com.urbandroid.sleep/bin/sleepasandroidnativeservice] + 0x2c79
18: __libc_start_main + 0x114 (0x403e285c) [/lib/libc.so.6] + 0x1785c
19: (0x40001674) [/opt/usr/apps/com.urbandroid.sleep/bin/sleepasandroidnativeservice] + 0x1674
End of Call Stack

Package Information
Package Name: com.urbandroid.sleep
Package ID : com.urbandroid.sleep
Version: 1.0.8
Package Type: rpm
App Name: sleepasandroidnativeservice
App ID: com.urbandroid.sleep.service
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
RVICE_TYPE_SAP, result : 1
04-11 11:10:42.737+0200 W/CAPI_NETWORK_WECONN( 1042): <__weconn_manager_signal_filter:364> { mark to destroy...
04-11 11:10:42.737+0200 W/CAPI_NETWORK_WECONN( 1042): <__weconn_manager_signal_filter:458> service : W_SERVICE_TYPE_SAP, result : 1
04-11 11:10:42.742+0200 W/SNL_W   (23637): <d2d_connect_close_thread:446> d2d_connect_close_thread() - end
04-11 11:10:42.742+0200 W/SNL_W   (23637): <d2d_connect_close_thread:455> d2d_connect_close_thread() - end
04-11 11:10:42.757+0200 W/CAPI_NETWORK_WECONN(  528): <__weconn_manager_signal_filter:364> { mark to destroy...
04-11 11:10:42.757+0200 W/CAPI_NETWORK_WECONN(  528): <__weconn_manager_signal_filter:458> service : W_SERVICE_TYPE_SAP, result : 1
04-11 11:10:42.772+0200 W/CALL_CONSUMER( 1744): CallSAPInterface.c: on_service_connection_confirm(508) > CONNECTION_SUCCESS
04-11 11:10:42.782+0200 W/WECONN  (  508): <__wc_feature_wms_connected_cb:453> priv->wms_connected = 1
04-11 11:10:42.787+0200 W/WECONN  (  508): <__wc_device_on_wms_connected_cb:406> {
04-11 11:10:42.787+0200 W/WECONN  (  508): <__wc_device_on_wms_connected_cb:421> wms connected=0, vendor=1
04-11 11:10:42.787+0200 W/WECONN  (  508): <__wc_device_on_wms_connected_cb:469> }
04-11 11:10:42.787+0200 W/WECONN  (  508): <__wc_device_all_connected_cb:557> 
04-11 11:10:42.787+0200 W/WECONN  (  508): <__wc_device_notify_all_connected:524> { device=0x428ed310, connected=1
04-11 11:10:42.792+0200 W/WECONN  (  508): <__wc_device_notify_all_connected:552> }
04-11 11:10:42.797+0200 E/ALARM_MANAGER( 1193): alarm-lib.c: alarmmgr_add_alarm_withcb(1178) > trigger_at_time(30), start(11-4-2018, 11:11:13), repeat(0), interval(0), type(-1073741824)
04-11 11:10:42.832+0200 E/WMS     (  522): wms_msg_broker.c: weconn_status_changed_cb(660) > 
04-11 11:10:42.832+0200 E/WMS     (  522): ==========
04-11 11:10:42.832+0200 E/WMS     (  522): ##WMS WECONN sent all connected
04-11 11:10:42.832+0200 E/WMS     (  522): ==========
04-11 11:10:42.842+0200 W/MC_CONSUMER( 1042): wmc-service-consumer.c: __wmc_on_service_connection_confirm(295) > [33m uwLocalAgentId : [60921], uwServiceHandle : [41954], wResponseCode : [0][0m
04-11 11:10:42.842+0200 W/MC_CONSUMER( 1042): wmc-service-consumer.c: __wmc_on_service_connection_confirm(335) > [33m wms not connected yet.. delay connection callback[0m
04-11 11:10:42.852+0200 E/ALARM_MANAGER(  519): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [1193].
04-11 11:10:42.882+0200 E/ALARM_MANAGER(  519): alarm-manager-schedule.c: __alarm_next_duetime_once(174) > Final due_time = 1523437873, Wed Apr 11 11:11:13 2018
04-11 11:10:42.882+0200 E/ALARM_MANAGER(  519): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 1883612130, next duetime: 1523437873
04-11 11:10:42.882+0200 E/ALARM_MANAGER(  519): alarm-manager.c: __alarm_add_to_list(496) > [alarm-server]: After add alarm_id(1883612130)
04-11 11:10:42.887+0200 E/ALARM_MANAGER(  519): alarm-manager.c: __alarm_create(1061) > [alarm-server]:alarm_context.c_due_time(1523437844), due_time(1523437873)
04-11 11:10:42.912+0200 E/ALARM_MANAGER(  519): alarm-manager.c: __display_lock_state(1884) > Lock LCD OFF is successfully done
04-11 11:10:42.912+0200 E/ALARM_MANAGER(  519): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
04-11 11:10:42.912+0200 E/ALARM_MANAGER(  519): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 11-4-2018, 09:10:44 (UTC).
04-11 11:10:42.912+0200 E/ALARM_MANAGER(  519): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
04-11 11:10:42.932+0200 W/SNL     (23637): Scone_Log.cpp: dump(2973) > SNL :: p_removeKey(c756020f9ca79075bcb8)(w3zf8m10dj)
04-11 11:10:42.932+0200 W/SNL     (23637): Scone_Log.cpp: dump(2973) > SNL :: p_gkc(1)
04-11 11:10:42.932+0200 W/SNL     (23637): Scone_Log.cpp: dump(2973) > SNL :: p_pm_r_group() - res(0)
04-11 11:10:42.932+0200 W/SNL     (23637): Scone_Log.cpp: dump(2973) > SNL :: p_wp - lt instance( w3zf8m10dj ), i_s( 0 )
04-11 11:10:42.932+0200 W/SNL     (23637): Scone_Log.cpp: dump(2973) > SNL :: p_removeAllKey (0)
04-11 11:10:42.947+0200 W/SNL     (23637): Scone_Log.cpp: dump(2973) > SNL :: tm_stop
04-11 11:10:42.947+0200 W/SNL     (23637): Scone_Log.cpp: dump(2973) > SNL :: tm_stop - tm_exchange_d2d_key thread join end ( 1138482000 )( 0 )
04-11 11:10:42.947+0200 W/SNL     (23637): Scone_Log.cpp: dump(2973) > SNL :: stc - tm_terminate
04-11 11:10:42.947+0200 W/SNL     (23637): Scone_Log.cpp: dump(2973) > SNL :: c_c_s_l - begin
04-11 11:10:42.947+0200 W/SNL     (23637): Scone_Log.cpp: dump(2973) > SNL :: c_c_s_l - end
04-11 11:10:42.952+0200 W/SNL     (23637): Scone_Log.cpp: dump(2973) > SNL :: terminate - Res( 0 )
04-11 11:10:42.952+0200 W/SNL     (23637): Scone_Log.cpp: dump(2973) > SNL :: terminate - ac-fin
04-11 11:10:42.952+0200 W/SNL_W   (23637): <sec_terminateCore_ex_w:260> sec_terminateCore_ex_w () - end 
04-11 11:10:42.952+0200 W/SCSD    (23637): util_dbus.c:util_dbus_set_login_status:314> set login_status: 0
04-11 11:10:42.982+0200 E/TIZEN_N_SYSTEM_SETTINGS(  765): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-11 11:10:42.982+0200 E/TIZEN_N_SYSTEM_SETTINGS(  765): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-11 11:10:42.982+0200 E/TIZEN_N_SYSTEM_SETTINGS(  765): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=4
04-11 11:10:42.982+0200 E/TIZEN_N_SYSTEM_SETTINGS(  765): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 4, key = 4, type = 0
04-11 11:10:42.987+0200 E/W_HOME  (  843): retailmode.c: retailmode_enabled_get(245) > failed to get value VCONFKEY_RETAILMODE_ENABLED
04-11 11:10:42.987+0200 W/W_HOME  (  843): clock_event.c: _wmanager_connectivity_get(397) > network status : 0
04-11 11:10:42.987+0200 W/W_HOME  (  843): clock_event.c: _wmanager_connectivity_get(402) > sap_connected : 0
04-11 11:10:42.987+0200 W/W_HOME  (  843): clock_event.c: _wmanager_connectivity_get(408) > sap connectivity type : 1
04-11 11:10:42.987+0200 W/W_HOME  (  843): clock_event.c: _wmanager_connectivity_get(414) > network status : 2
04-11 11:10:42.987+0200 W/W_HOME  (  843): clock_event.c: _wmanager_connectivity_get(428) > scs login : 0
04-11 11:10:42.987+0200 W/W_HOME  (  843): clock_indicator.c: clock_indicator_pop_icon(395) > icon:5 is popped from clock indicator
04-11 11:10:42.987+0200 W/W_HOME  (  843): clock_indicator.c: clock_indicator_icon_push(360) > icon:5 is added to clock indicator
04-11 11:10:42.997+0200 E/ALARM_MANAGER(  519): alarm-manager.c: __display_unlock_state(1927) > Unlock LCD OFF is successfully done
04-11 11:10:43.027+0200 W/W_INDICATOR(  765): windicator_scs.c: windicator_scs_update(123) > [windicator_scs_update:123] sales code : 0
04-11 11:10:43.032+0200 W/W_INDICATOR(  765): windicator_scs.c: windicator_scs_update(131) > [windicator_scs_update:131] sap connected : 0
04-11 11:10:43.032+0200 W/W_INDICATOR(  765): windicator_scs.c: windicator_scs_update(146) > [windicator_scs_update:146] ciss_request_type : 0
04-11 11:10:43.032+0200 I/W_INDICATOR(  765): windicator_scs.c: windicator_scs_update(155) > [windicator_scs_update:155] Hide (Callforwarding requested)
04-11 11:10:43.032+0200 I/W_INDICATOR(  765): windicator.c: windicator_is_lo_connected(976) > [windicator_is_lo_connected:976] Connected target vendor : LGE
04-11 11:10:43.032+0200 W/W_INDICATOR(  765): windicator_scs.c: windicator_scs_update(195) > [windicator_scs_update:195] sap connectivity type : 1
04-11 11:10:43.032+0200 W/W_INDICATOR(  765): windicator_scs.c: windicator_scs_update(203) > [windicator_scs_update:203] network status : 2
04-11 11:10:43.032+0200 W/W_INDICATOR(  765): windicator_scs.c: windicator_scs_update(220) > [windicator_scs_update:220] scs login : 0
04-11 11:10:43.032+0200 W/W_INDICATOR(  765): windicator_scs.c: windicator_scs_update(224) > [windicator_scs_update:224] not connected
04-11 11:10:43.072+0200 W/LOCATION(  956): location-common-util.c: location_is_onboard_gps_use_only(146) > onboard-gps-use-only mode: [0]
04-11 11:10:43.072+0200 I/LOCATION(  956): location.c: __get_location_setting_value_from_method(202) > Remote is [Connected]. Method[0] is [On]
04-11 11:10:43.072+0200 I/LOCATION(  956): location.c: __location_setting_cb(302) > Callback >> Location method(0) setting value is changed. [0] -> [1]
04-11 11:10:43.072+0200 E/weather-common(  956): Location.cpp: LocationSettingChangedCb(115) > [0;40;31mLocationSettingChangedCb enable:1[0;m
04-11 11:10:43.122+0200 I/CAPI_NETWORK_CONNECTION(23637): connection.c: connection_create(453) > New handle created[0x40f283c0]
04-11 11:10:43.122+0200 E/CAPI_NETWORK_CONNECTION(23637): libnetwork.c: _connection_check_feature_supported(1881) > Error - Feature is not supported
04-11 11:10:43.122+0200 E/SCSD    (23637): util_network.c:__init_connection:67> connection_get_default_cellular_service_profile : -1073741822
04-11 11:10:43.122+0200 I/SCSD    (23637): mainloop quit
04-11 11:10:43.122+0200 W/SNL     (23637): Scone_Log.cpp: dump(2973) > SNL :: sc_dis connid( 5 ), way( 16)
04-11 11:10:43.122+0200 W/SNL     (23637): Scone_Log.cpp: dump(2973) > SNL :: sc_dis .
04-11 11:10:43.147+0200 E/WMS     (  522): wms_msg_broker.c: on_peer_agent(1127) > peer agent found
04-11 11:10:43.147+0200 E/WMS     (  522): wms_msg_broker.c: on_peer_agent(1143) > Bearer type : 1, mIsServiceConnected : 0
04-11 11:10:43.147+0200 E/WMS     (  522): wms_msg_broker.c: on_peer_agent(1166) > call create service connection
04-11 11:10:43.277+0200 W/WECONN  (  508): <__wc_sap_service_connection_requested_cb:694> result : 0
04-11 11:10:43.277+0200 W/WECONN  (  508): <__wc_sap_service_connection_requested_cb:707> device_address : A2:51
04-11 11:10:43.277+0200 W/WECONN  (  508): <__wc_sap_service_connection_requested_cb:710> connected br edr address : A2:51
04-11 11:10:43.277+0200 W/WECONN  (  508): <__wc_sap_service_connection_requested_cb:717> trnasport_type : 1
04-11 11:10:43.357+0200 I/capability-manager(24060): capability_manager_util.c: is_file_exist(120) > File /opt/usr/share/wms/HostStatus.xml Exists
04-11 11:10:43.362+0200 I/capability-manager(24060): capability_manager_xml.c: capability_manager_xml_util_get_device_info(114) > capability_manager_xml_util_get_device_info() called.
04-11 11:10:43.437+0200 W/WPROXY  ( 1050): sap.c: on_service_connection_confirm(151) > uwLocalAgentId: 18137, uwServiceHandle: 4422, wStatusCode: 0
04-11 11:10:43.437+0200 I/WPROXY  ( 1050): sap.c: on_service_connection_confirm(156) > service connection success.
04-11 11:10:43.442+0200 W/WPROXY  ( 1050): net-device.c: net_device_enable_if_proxy(355) > backup info : config[1], status[2]
04-11 11:10:43.452+0200 E/W_HOME  (  843): retailmode.c: retailmode_enabled_get(245) > failed to get value VCONFKEY_RETAILMODE_ENABLED
04-11 11:10:43.452+0200 W/W_HOME  (  843): clock_event.c: _wmanager_connectivity_get(397) > network status : 0
04-11 11:10:43.457+0200 W/W_HOME  (  843): clock_event.c: _wmanager_connectivity_get(402) > sap_connected : 0
04-11 11:10:43.457+0200 W/W_HOME  (  843): clock_event.c: _wmanager_connectivity_get(408) > sap connectivity type : 1
04-11 11:10:43.457+0200 W/W_HOME  (  843): clock_event.c: _wmanager_connectivity_get(414) > network status : 3
04-11 11:10:43.457+0200 W/W_HOME  (  843): clock_event.c: _wmanager_connectivity_get(428) > scs login : 0
04-11 11:10:43.457+0200 W/W_HOME  (  843): clock_indicator.c: clock_indicator_pop_icon(395) > icon:5 is popped from clock indicator
04-11 11:10:43.462+0200 E/TIZEN_N_SYSTEM_SETTINGS(  765): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-11 11:10:43.462+0200 E/TIZEN_N_SYSTEM_SETTINGS(  765): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-11 11:10:43.462+0200 E/TIZEN_N_SYSTEM_SETTINGS(  765): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=4
04-11 11:10:43.462+0200 E/TIZEN_N_SYSTEM_SETTINGS(  765): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 4, key = 4, type = 0
04-11 11:10:43.472+0200 W/WPROXY  ( 1050): net-device.c: net_device_enable_if_proxy(380) > Successfully enabled
04-11 11:10:43.472+0200 E/WPROXY  ( 1050): net-device.c: net_device_set_reactivation_lock_status(299) > Not in reactivation lock.
04-11 11:10:43.472+0200 W/W_HOME  (  843): clock_indicator.c: clock_indicator_icon_push(360) > icon:5 is added to clock indicator
04-11 11:10:43.492+0200 W/W_INDICATOR(  765): windicator_scs.c: windicator_scs_update(123) > [windicator_scs_update:123] sales code : 0
04-11 11:10:43.492+0200 W/W_INDICATOR(  765): windicator_scs.c: windicator_scs_update(131) > [windicator_scs_update:131] sap connected : 0
04-11 11:10:43.497+0200 W/W_INDICATOR(  765): windicator_scs.c: windicator_scs_update(146) > [windicator_scs_update:146] ciss_request_type : 0
04-11 11:10:43.497+0200 I/W_INDICATOR(  765): windicator_scs.c: windicator_scs_update(155) > [windicator_scs_update:155] Hide (Callforwarding requested)
04-11 11:10:43.497+0200 I/W_INDICATOR(  765): windicator.c: windicator_is_lo_connected(976) > [windicator_is_lo_connected:976] Connected target vendor : LGE
04-11 11:10:43.497+0200 W/W_INDICATOR(  765): windicator_scs.c: windicator_scs_update(195) > [windicator_scs_update:195] sap connectivity type : 1
04-11 11:10:43.497+0200 W/W_INDICATOR(  765): windicator_scs.c: windicator_scs_update(203) > [windicator_scs_update:203] network status : 3
04-11 11:10:43.497+0200 W/W_INDICATOR(  765): windicator_scs.c: windicator_scs_update(220) > [windicator_scs_update:220] scs login : 0
04-11 11:10:43.497+0200 W/W_INDICATOR(  765): windicator_scs.c: windicator_scs_update(224) > [windicator_scs_update:224] not connected
04-11 11:10:43.507+0200 W/CALL_CONSUMER( 1744): CallCapability.c: __get_capability(53) > key = [vendor], value = [LGE]
04-11 11:10:43.522+0200 E/CAPI_NETWORK_CONNECTION(  995): connection.c: __connection_cb_proxy_changed_cb_idle(344) > Unknown Proxy address type: IP(192.168.153.100:8080) 
04-11 11:10:43.522+0200 I/magazine-service(  995): magazine-service-connection.c: _magazine_service_connection_type_changed_cb(131) > connection type changed [1] -> [3]
04-11 11:10:43.527+0200 I/w-magazine-widget(  995): widget.c: _magazine_widget_noti_event_callback(968) > noti[2]
04-11 11:10:43.532+0200 I/magazine-service(  995): magazine-service-db.c: _magazine_service_db_topics_get(477) > 0 topics in the result list
04-11 11:10:43.537+0200 I/magazine-service(  995): magazine-service-retail-mode.c: magazine_service_common_retail_mode_enable(35) > vconf_get_int(RETAIL MODE) returns -1
04-11 11:10:43.537+0200 I/magazine-service(  995): magazine-service-retail-mode.c: magazine_service_common_retail_mode_enable(35) > vconf_get_int(RETAIL MODE) returns -1
04-11 11:10:43.537+0200 I/w-magazine-widget(  995): widget.c: _magazine_widget_stories_list_get(191) > [0] topics, [0] stories
04-11 11:10:43.537+0200 I/w-magazine-widget(  995): widget.c: _magazine_widget_layout_create(857) > 
04-11 11:10:43.542+0200 I/w-magazine-widget(  995): widget.c: _magazine_widget_layout_create(930) > No items
04-11 11:10:43.557+0200 W/WECONN  (  508): <wc_manager_get_bearer_state:996> type : 2
04-11 11:10:43.557+0200 E/CAPI_NETWORK_CONNECTION(  508): libnetwork.c: _connection_check_feature_supported(1881) > Error - Feature is not supported
04-11 11:10:43.557+0200 E/WECONN  (  508): <__get_cellular_state_with_previous_and_now:224> couldn't get cellular state. result = -1073741822
04-11 11:10:43.557+0200 W/WECONN  (  508): <__on_change_connection_type:255> { type = 3, state = WC_BEARER_STATE_NONE
04-11 11:10:43.557+0200 W/WECONN  (  508): <wc_manager_get_bearer_state:996> type : 3
04-11 11:10:43.557+0200 W/WECONN  (  508): <wc_manager_get_bearer_state:996> type : 2
04-11 11:10:43.557+0200 W/WECONN  (  508): <wc_manager_on_notify_bearer_state:931> type=WC_BEARER_TYPE_CELLULAR, new_state=WC_BEARER_STATE_NONE, previous_state=WC_BEARER_STATE_NONE
04-11 11:10:43.557+0200 W/WECONN  (  508): <wc_manager_get_bearer_state:996> type : 2
04-11 11:10:43.557+0200 W/WECONN  (  508): <wc_manager_on_notify_bearer_state:933> skipped.
04-11 11:10:43.557+0200 W/WECONN  (  508): <__on_change_connection_type:263> }
04-11 11:10:43.612+0200 W/CALL_CONSUMER( 1744): CallSAPInterface.c: call_sap_send_consumer_event(1667) > request ID: 0x200c
04-11 11:10:43.652+0200 E/WMS     (  522): wms_msg_broker.c: on_service_connection_confirm(1261) > Bearer type : 1, uwServiceHandle : 4422
04-11 11:10:43.652+0200 E/WMS     (  522): wms_msg_broker.c: on_service_connection_confirm(1276) > service connection success
04-11 11:10:43.657+0200 E/ALARM_MANAGER( 1193): alarm-lib.c: alarmmgr_add_alarm_withcb(1178) > trigger_at_time(20), start(11-4-2018, 11:11:04), repeat(0), interval(0), type(-1073741824)
04-11 11:10:43.687+0200 E/ALARM_MANAGER(  519): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [1193].
04-11 11:10:43.722+0200 E/ALARM_MANAGER(  519): alarm-manager-schedule.c: __alarm_next_duetime_once(174) > Final due_time = 1523437864, Wed Apr 11 11:11:04 2018
04-11 11:10:43.727+0200 E/ALARM_MANAGER(  519): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 502468934, next duetime: 1523437864
04-11 11:10:43.727+0200 E/ALARM_MANAGER(  519): alarm-manager.c: __alarm_add_to_list(496) > [alarm-server]: After add alarm_id(502468934)
04-11 11:10:43.727+0200 E/ALARM_MANAGER(  519): alarm-manager.c: __alarm_create(1061) > [alarm-server]:alarm_context.c_due_time(1523437844), due_time(1523437864)
04-11 11:10:43.767+0200 E/ALARM_MANAGER(  519): alarm-manager.c: __display_lock_state(1884) > Lock LCD OFF is successfully done
04-11 11:10:43.767+0200 E/ALARM_MANAGER(  519): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
04-11 11:10:43.767+0200 E/ALARM_MANAGER(  519): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 11-4-2018, 09:10:44 (UTC).
04-11 11:10:43.767+0200 E/ALARM_MANAGER(  519): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
04-11 11:10:43.772+0200 E/ALARM_MANAGER(  519): alarm-manager.c: __display_unlock_state(1927) > Unlock LCD OFF is successfully done
04-11 11:10:43.857+0200 W/CALL_CONSUMER( 1744): CallSAPInterface.c: call_sap_is_retailmode_enabled(2422) > vconf_get_int(VCONFKEY_RETAILMODE_ENABLED) failed
04-11 11:10:43.857+0200 W/CALL_CONSUMER( 1744): CallSAPInterface.c: call_sap_is_bt_connected(2392) > bt is connected..
04-11 11:10:43.857+0200 W/CALL_CONSUMER( 1744): CallSAPInterface.c: call_sap_get_pending_clear_misssed_call_noti(2453) > call_sap_get_pending_clear_misssed_call_noti(0)
04-11 11:10:43.877+0200 E/WMS     (  522): wms_event_handler.c: wms_event_handler_routine(24519) > 
04-11 11:10:43.877+0200 E/WMS     (  522): ==========
04-11 11:10:43.877+0200 E/WMS     (  522): ##WMS RECEIVED : mgr_watch_info_req
04-11 11:10:43.877+0200 E/WMS     (  522): ==========
04-11 11:10:43.877+0200 E/WMS     (  522): wms_event_handler.c: handle_mgr_watch_info_req(16209) > Model Name : Gear S2 (F0A0)
04-11 11:10:43.877+0200 E/WMS     (  522): wms_event_handler.c: handle_mgr_watch_info_req(16213) > hmVer : 2.2.03.18031441N
04-11 11:10:43.877+0200 E/WMS     (  522): wms_event_handler.c: handle_mgr_watch_info_req(16228) > is_passed : true
04-11 11:10:43.877+0200 E/WMS     (  522): wms_event_handler.c: handle_mgr_watch_info_req(16231) > EULA passed device!!
04-11 11:10:43.877+0200 E/WMS     (  522): wms_event_handler.c: handle_mgr_watch_info_req(16244) > locale : cs_CZ
04-11 11:10:43.877+0200 E/WMS     (  522): wms_event_handler.c: handle_mgr_watch_info_req(16264) > converted locale(cs_CZ)
04-11 11:10:43.877+0200 E/WMS     (  522): wms_event_handler.c: handle_mgr_watch_info_req(16273) > current Language: cs_CZ, current Region: cs_CZ
04-11 11:10:43.877+0200 E/WMS     (  522): wms_msg_broker.c: wms_msg_broker_get_wf_resource_path(403) > resource path : /usr/share/watchface-resource/resource_PJB.zip
04-11 11:10:43.932+0200 E/ALARM_MANAGER( 1193): alarm-lib.c: alarmmgr_add_alarm_withcb(1178) > trigger_at_time(20), start(11-4-2018, 11:11:04), repeat(0), interval(0), type(-1073741824)
04-11 11:10:43.967+0200 E/ALARM_MANAGER(  519): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [1193].
04-11 11:10:43.997+0200 E/ALARM_MANAGER(  519): alarm-manager-schedule.c: __alarm_next_duetime_once(174) > Final due_time = 1523437864, Wed Apr 11 11:11:04 2018
04-11 11:10:43.997+0200 E/ALARM_MANAGER(  519): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 502468935, next duetime: 1523437864
04-11 11:10:43.997+0200 E/ALARM_MANAGER(  519): alarm-manager.c: __alarm_add_to_list(496) > [alarm-server]: After add alarm_id(502468935)
04-11 11:10:44.002+0200 E/ALARM_MANAGER(  519): alarm-manager.c: __alarm_create(1061) > [alarm-server]:alarm_context.c_due_time(1523437844), due_time(1523437864)
04-11 11:10:44.012+0200 E/ALARM_MANAGER(  519): alarm-manager.c: __display_lock_state(1884) > Lock LCD OFF is successfully done
04-11 11:10:44.012+0200 E/ALARM_MANAGER(  519): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
04-11 11:10:44.012+0200 E/ALARM_MANAGER(  519): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 11-4-2018, 09:10:44 (UTC).
04-11 11:10:44.012+0200 E/ALARM_MANAGER(  519): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
04-11 11:10:44.017+0200 E/ALARM_MANAGER(  519): alarm-manager.c: __display_unlock_state(1927) > Unlock LCD OFF is successfully done
04-11 11:10:44.027+0200 E/ALARM_MANAGER(  519): alarm-manager.c: __alarm_handler_idle(1486) > Lock the display not to enter LCD OFF
04-11 11:10:44.032+0200 W/WECONN  (  508): <__wc_sap_socket_data_received_cb:579> channel_id : 222, payload_length : 24
04-11 11:10:44.052+0200 E/ALARM_MANAGER(  519): alarm-manager.c: __display_lock_state(1884) > Lock LCD OFF is successfully done
04-11 11:10:44.072+0200 W/WECONN  (  508): <__on_recv_p2p_data_cb:485> [P2P][2][1]
04-11 11:10:44.082+0200 W/AUL     (  519): app_signal.c: aul_update_freezer_status(456) > aul_update_freezer_status pid(764) type(wakeup)
04-11 11:10:44.087+0200 E/ALARM_MANAGER(  519): alarm-manager.c: __alarm_expired(1447) > alarm_id[1978635444] is expired.
04-11 11:10:44.087+0200 E/ALARM_MANAGER(  519): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 1978635444, next duetime: 1523437864
04-11 11:10:44.087+0200 E/ALARM_MANAGER(  519): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
04-11 11:10:44.087+0200 E/ALARM_MANAGER(  519): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 11-4-2018, 09:11:04 (UTC).
04-11 11:10:44.087+0200 E/ALARM_MANAGER(  519): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
04-11 11:10:44.087+0200 E/ALARM_MANAGER(  519): alarm-manager.c: __alarm_handler_idle(1512) > Unlock the display from LCD OFF
04-11 11:10:44.107+0200 E/CALENDAR(22860): CalendarDBManager.cpp: __isLDUBinary(157) > [0;31m* Critical * vconf_get_int is faled.[0;m
04-11 11:10:44.117+0200 E/CALENDAR(22860): CalendarDBManager.cpp: __isIFABinary(181) > [0;31m* Critical * this is not IFA binary![0;m
04-11 11:10:44.132+0200 E/RESOURCED(  623): freezer-process.c: freezer_process_pid_set(150) > Cant find process info for 764
04-11 11:10:44.137+0200 E/ALARM_MANAGER(  764): alarm-lib.c: __handle_expiry_method_call(152) > [alarm-lib] : Alarm expired for [ALARM.astarter] : Alarm id [1978635444]
04-11 11:10:44.137+0200 W/STARTER (  764): clock-mgr.c: __starter_clock_mgr_homescreen_alarm_cb(968) > [__starter_clock_mgr_homescreen_alarm_cb:968] homescreen alarm timer expired [1978635444]
04-11 11:10:44.142+0200 E/ALARM_MANAGER(  519): alarm-manager.c: __display_unlock_state(1927) > Unlock LCD OFF is successfully done
04-11 11:10:44.157+0200 E/WMS     (  522): wms_event_handler.c: handle_mgr_watch_info_req(16431) > rl_status[0], ese_status[0], contact_cnt[0], standalone_mode[0], sync_flag[0]
04-11 11:10:44.157+0200 E/WMS     (  522): wms_msg_broker.c: wms_msg_broker_send(1826) > 
04-11 11:10:44.157+0200 E/WMS     (  522): ==========
04-11 11:10:44.157+0200 E/WMS     (  522): ##WMS SEND : mgr_watch_info_res
04-11 11:10:44.157+0200 E/WMS     (  522): ==========
04-11 11:10:44.157+0200 E/WMS     (  522): wms_msg_broker.c: wms_msg_broker_send(1842) > Data size: 627 MAX Buffer Size: 61440
04-11 11:10:44.157+0200 E/WMS     (  522): wms_event_handler.c: wms_event_handler_routine(24535) > [mgr_watch_info_req] handler success.
04-11 11:10:44.177+0200 E/LIVE_CALENDAR(  965): widget.c: widget_instance_update_time(336) > widget_instance_update_time:[0x43714480] Updated time is Tue Apr 10 11:06:06 2018
04-11 11:10:44.177+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE(  965): preference.c: _preference_check_retry_err(507) > key(lockTimezone), check retry err: -21/(2/No such file or directory).
04-11 11:10:44.182+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE(  965): preference.c: _preference_get_key(1101) > _preference_get_key(lockTimezone) step(-17825744) failed(2 / No such file or directory)
04-11 11:10:44.182+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE(  965): preference.c: preference_get_string(1258) > preference_get_string(965) : lockTimezone error
04-11 11:10:44.187+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE(  965): preference.c: _preference_check_retry_err(507) > key(lockTimezone), check retry err: -21/(2/No such file or directory).
04-11 11:10:44.187+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE(  965): preference.c: _preference_get_key(1101) > _preference_get_key(lockTimezone) step(-17825744) failed(2 / No such file or directory)
04-11 11:10:44.187+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE(  965): preference.c: preference_get_string(1258) > preference_get_string(965) : lockTimezone error
04-11 11:10:44.197+0200 I/AUL     (  508): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/weconnd, ret : 0
04-11 11:10:44.212+0200 I/AUL     (  508): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/weconnd, ret : 0
04-11 11:10:44.212+0200 E/CAPI_APPFW_APPLICATION(  508): app_error.c: app_error(64) > [app_get_id] INVALID_CONTEXT(0xfef00001) : failed to get the application ID
04-11 11:10:44.237+0200 W/AUL     (  764): launch.c: app_request_to_launchpad(284) > request cmd(0) to(com.samsung.w-home)
04-11 11:10:44.237+0200 W/AUL_AMD (  514): amd_request.c: __request_handler(669) > __request_handler: 0
04-11 11:10:44.242+0200 W/AUL_AMD (  514): amd_launch.c: _start_app(1782) > caller pid : 764
04-11 11:10:44.247+0200 W/AUL     (  514): app_signal.c: aul_send_app_resume_request_signal(567) > aul_send_app_resume_request_signal app(com.samsung.w-home) pid(843) type(uiapp) bg(0)
04-11 11:10:44.247+0200 W/AUL_AMD (  514): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 843
04-11 11:10:44.247+0200 I/APP_CORE(  843): appcore-efl.c: __do_app(453) > [APP 843] Event: RESET State: PAUSED
04-11 11:10:44.247+0200 W/AUL_AMD (  514): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(843), cmd(0)
04-11 11:10:44.247+0200 I/CAPI_APPFW_APPLICATION(  843): app_main.c: app_appcore_reset(245) > app_appcore_reset
04-11 11:10:44.247+0200 W/CAPI_APPFW_APP_CONTROL(  843): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-11 11:10:44.252+0200 E/W_HOME  (  843): retailmode.c: retailmode_enabled_get(245) > failed to get value VCONFKEY_RETAILMODE_ENABLED
04-11 11:10:44.252+0200 W/W_HOME  (  843): main.c: _app_control_progress(1606) > Service value : show_clock
04-11 11:10:44.252+0200 W/W_HOME  (  843): main.c: _app_control_progress(1623) > Show clock operation
04-11 11:10:44.252+0200 E/W_HOME  (  843): retailmode.c: retailmode_enabled_get(245) > failed to get value VCONFKEY_RETAILMODE_ENABLED
04-11 11:10:44.252+0200 W/W_HOME  (  843): gesture.c: _clock_show(242) > clock show
04-11 11:10:44.252+0200 W/W_HOME  (  843): gesture.c: _clock_show(257) > home raise
04-11 11:10:44.252+0200 E/W_HOME  (  843): gesture.c: gesture_win_aux_set(402) > wm.policy.win.do.not.use.deiconify.approve:-1
04-11 11:10:44.252+0200 W/W_HOME  (  843): dbus_util.c: home_dbus_home_raise_signal_send(298) > Sending HOME RAISE signal, result:0
04-11 11:10:44.252+0200 W/W_HOME  (  843): gesture.c: _clock_show(260) > home raise done
04-11 11:10:44.252+0200 W/W_HOME  (  843): gesture.c: _clock_show(267) > show clock
04-11 11:10:44.252+0200 W/W_HOME  (  843): index.c: index_hide(338) > hide VI:0 visibility:0 vi:(nil)
04-11 11:10:44.252+0200 W/W_HOME  (  843): gesture.c: _manual_render(182) > 
04-11 11:10:44.257+0200 W/AUL     (  764): launch.c: app_request_to_launchpad(298) > request cmd(0) result(843)
04-11 11:10:44.272+0200 I/APP_CORE(  843): appcore-efl.c: __do_app(529) > Legacy lifecycle: 1
04-11 11:10:44.292+0200 E/ALARM_MANAGER(  519): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [764].
04-11 11:10:44.292+0200 E/ALARM_MANAGER(  519): alarm-manager.c: __alarm_remove_from_list(575) > [alarm-server]:Remove alarm id(1978635444)
04-11 11:10:44.302+0200 W/W_HOME  (  843): event_manager.c: _ecore_x_message_cb(421) > state: 1 -> 0
04-11 11:10:44.302+0200 W/W_HOME  (  843): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-11 11:10:44.302+0200 W/W_HOME  (  843): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:0(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-11 11:10:44.302+0200 W/W_HOME  (  843): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:0(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-11 11:10:44.302+0200 W/W_INDICATOR(  765): windicator.c: _home_screen_clock_visibility_changed_cb(1023) > [_home_screen_clock_visibility_changed_cb:1023] Clock visibility : 0
04-11 11:10:44.302+0200 W/W_INDICATOR(  765): windicator_battery.c: windicator_battery_vconfkey_unregister(595) > [windicator_battery_vconfkey_unregister:595] Unset battery cb
04-11 11:10:44.307+0200 W/W_HOME  (  843): main.c: _ecore_x_message_cb(1029) > main_info.is_win_on_top: 1
04-11 11:10:44.327+0200 E/wnotibp ( 1324): w-notification-board-action.c: wnb_action_is_drawer_hidden(5192) > [NULL==g_wnb_action_data] msg Drawer not initialized.
04-11 11:10:44.327+0200 W/wnotibp ( 1324): wnotiboard-popup-control.c: _ctrl_home_raise_cb(164) > [0, 2, 1]
04-11 11:10:44.327+0200 W/W_INDICATOR(  765): windicator_moment_bar.c: windicator_moment_bar_hide_directly(548) > [windicator_moment_bar_hide_directly:548] windicator_moment_bar_hide_directly
04-11 11:10:44.337+0200 W/AUL_AMD (  514): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
04-11 11:10:44.337+0200 W/AUL_AMD (  514): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
04-11 11:10:44.337+0200 W/AUL     (  514): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(843) status(fg) type(uiapp)
04-11 11:10:44.352+0200 W/W_HOME  (  843): event_manager.c: _window_visibility_cb(460) > Window [0x2E00003] is now visible(0)
04-11 11:10:44.352+0200 W/W_HOME  (  843): event_manager.c: _window_visibility_cb(470) > state: 0 -> 1
04-11 11:10:44.352+0200 W/W_HOME  (  843): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-11 11:10:44.352+0200 W/W_HOME  (  843): event_manager.c: _state_control(176) > control:6, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-11 11:10:44.352+0200 W/W_HOME  (  843): main.c: _window_visibility_cb(996) > Window [0x2E00003] is now visible(0)
04-11 11:10:44.357+0200 I/APP_CORE(  843): appcore-efl.c: __visibility_cb(937) > LCD status is off, skip the AE_RESUME event
04-11 11:10:44.357+0200 I/wnotib  (  843): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(746) > fully_obscured: 0
04-11 11:10:44.357+0200 E/wnotib  (  843): w-notification-board-action.c: wnb_action_is_drawer_hidden(5192) > [NULL==g_wnb_action_data] msg Drawer not initialized.
04-11 11:10:44.357+0200 W/wnotib  (  843): w-notification-board-noti-manager.c: wnb_nm_do_postponed_job(974) > No postponed work with is_for_VI: 0, postponed_for_VI: 0.
04-11 11:10:44.357+0200 I/APP_CORE(23964): appcore-efl.c: __do_app(453) > [APP 23964] Event: PAUSE State: PAUSED
04-11 11:10:44.372+0200 E/ALARM_MANAGER(  519): alarm-manager.c: __display_lock_state(1884) > Lock LCD OFF is successfully done
04-11 11:10:44.377+0200 E/ALARM_MANAGER(  519): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
04-11 11:10:44.377+0200 E/ALARM_MANAGER(  519): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 11-4-2018, 09:11:04 (UTC).
04-11 11:10:44.377+0200 E/ALARM_MANAGER(  519): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
04-11 11:10:44.382+0200 W/AUL     (  514): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.urbandroid.sleep.ui) pid(23964) status(bg) type(uiapp)
04-11 11:10:44.387+0200 W/APP_CORE(23964): appcore-efl.c: _capture_and_make_file(1721) > Capture : win[3600002] -> redirected win[602303] for com.urbandroid.sleep.ui[23964]
04-11 11:10:44.387+0200 W/CALL_CONSUMER( 1744): CallSAPInterface.c: call_sap_provider_data_available_on_channel_cb(2185) > response ID: 0x1007
04-11 11:10:44.392+0200 W/CALL_CONSUMER( 1744): CallSAPInterface.c: _call_sap_receive_provider_events_general_cmd(1828) > general_cmd : REQ_EMERGENCY_NUMBER
04-11 11:10:44.392+0200 W/CALL_CONSUMER( 1744): CallSAPInterface.c: _call_sap_receive_provider_events_general_cmd(1829) > general_cmd_extra : 
04-11 11:10:44.392+0200 I/CALL_CONSUMER( 1744): CallSAPInterface.c: _call_sap_receive_provider_events_general_cmd(1873) > id: 3, value: 
04-11 11:10:44.402+0200 I/MALI    (  843): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x43ed92b0] swap changed from async to sync
04-11 11:10:44.492+0200 E/ALARM_MANAGER(  519): alarm-manager.c: __display_unlock_state(1927) > Unlock LCD OFF is successfully done
04-11 11:10:44.492+0200 E/ALARM_MANAGER(  519): alarm-manager.c: alarm_manager_alarm_delete(2462) > alarm_id[1978635444] is removed.
04-11 11:10:44.502+0200 W/STARTER (  764): pkg-monitor.c: _app_mgr_status_cb(421) > [_app_mgr_status_cb:421] Resume request [843]
04-11 11:10:44.517+0200 W/STARTER (  764): pkg-monitor.c: _proc_mgr_status_cb(455) > [_proc_mgr_status_cb:455] >> P[843] goes to (3)
04-11 11:10:44.517+0200 E/STARTER (  764): pkg-monitor.c: _proc_mgr_status_cb(457) > [_proc_mgr_status_cb:457] >>>>H(pid 843)'s state(3)
04-11 11:10:44.517+0200 W/STARTER (  764): pkg-monitor.c: _proc_mgr_status_cb(455) > [_proc_mgr_status_cb:455] >> P[23964] goes to (4)
04-11 11:10:44.517+0200 E/ALARM_MANAGER(  519): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [1193].
04-11 11:10:44.517+0200 E/ALARM_MANAGER(  519): alarm-manager.c: __alarm_remove_from_list(575) > [alarm-server]:Remove alarm id(1883612130)
04-11 11:10:44.547+0200 E/ALARM_MANAGER(  519): alarm-manager.c: __display_lock_state(1884) > Lock LCD OFF is successfully done
04-11 11:10:44.547+0200 E/ALARM_MANAGER(  519): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
04-11 11:10:44.547+0200 E/ALARM_MANAGER(  519): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 11-4-2018, 09:11:04 (UTC).
04-11 11:10:44.547+0200 E/ALARM_MANAGER(  519): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
04-11 11:10:44.552+0200 E/WMS     (  522): wms_msg_broker.c: on_broker_buffer_send(307) > Data sending is success.
04-11 11:10:44.562+0200 E/ALARM_MANAGER(  519): alarm-manager.c: __display_unlock_state(1927) > Unlock LCD OFF is successfully done
04-11 11:10:44.562+0200 E/ALARM_MANAGER(  519): alarm-manager.c: alarm_manager_alarm_delete(2462) > alarm_id[1883612130] is removed.
04-11 11:10:44.562+0200 E/WMS     (  522): wms_event_handler.c: wms_event_handler_routine(24519) > 
04-11 11:10:44.562+0200 E/WMS     (  522): ==========
04-11 11:10:44.562+0200 E/WMS     (  522): ##WMS RECEIVED : mgr_ns_primary_contactlist_req
04-11 11:10:44.562+0200 E/WMS     (  522): ==========
04-11 11:10:44.562+0200 E/CAPI_APPFW_APP_CONTROL(  522): app_control.c: app_control_error(131) > [app_control_add_extra_data_array] INVALID_PARAMETER(0xffffffea) : invalid array
04-11 11:10:44.562+0200 E/CAPI_APPFW_APP_CONTROL(  522): app_control.c: app_control_error(131) > [app_control_add_extra_data_array] INVALID_PARAMETER(0xffffffea) : invalid array
04-11 11:10:44.562+0200 W/AUL     (  522): launch.c: app_request_to_launchpad(284) > request cmd(0) to(com.samsung.emergency-message.setting)
04-11 11:10:44.567+0200 W/AUL_AMD (  514): amd_request.c: __request_handler(669) > __request_handler: 0
04-11 11:10:44.572+0200 I/LOCATION(  956): location.c: __get_location_setting_value_from_method(202) > Remote is [Disconnected]. Method[0] is [Off]
04-11 11:10:44.572+0200 I/LOCATION(  956): location.c: __location_setting_cb(302) > Callback >> Location method(0) setting value is changed. [1] -> [0]
04-11 11:10:44.572+0200 E/weather-common(  956): Location.cpp: LocationSettingChangedCb(115) > [0;40;31mLocationSettingChangedCb enable:0[0;m
04-11 11:10:44.577+0200 E/ALARM_MANAGER(  519): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [1193].
04-11 11:10:44.577+0200 E/ALARM_MANAGER(  519): alarm-manager.c: __alarm_remove_from_list(575) > [alarm-server]:Remove alarm id(502468934)
04-11 11:10:44.582+0200 W/AUL_AMD (  514): amd_launch.c: _start_app(1782) > caller pid : 522
04-11 11:10:44.582+0200 I/AUL_AMD (  514): amd_launch.c: __check_app_control_privilege(1693) > Skip the privilege check in case of preloaded apps
04-11 11:10:44.597+0200 W/AUL_AMD (  514): amd_launch.c: start_process(606) > child process: 24069
04-11 11:10:44.597+0200 E/ALARM_MANAGER(  519): alarm-manager.c: __display_lock_state(1884) > Lock LCD OFF is successfully done
04-11 11:10:44.597+0200 E/ALARM_MANAGER(  519): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
04-11 11:10:44.597+0200 E/ALARM_MANAGER(  519): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 11-4-2018, 09:11:04 (UTC).
04-11 11:10:44.597+0200 E/ALARM_MANAGER(  519): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
04-11 11:10:44.612+0200 E/ALARM_MANAGER(  519): alarm-manager.c: __display_unlock_state(1927) > Unlock LCD OFF is successfully done
04-11 11:10:44.612+0200 E/ALARM_MANAGER(  519): alarm-manager.c: alarm_manager_alarm_delete(2462) > alarm_id[502468934] is removed.
04-11 11:10:44.647+0200 W/AUL_AMD (  514): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 24069
04-11 11:10:44.647+0200 W/AUL     (  514): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(com.samsung.emergency-message.setting) pid(24069) type(svcapp) bg(0)
04-11 11:10:44.652+0200 W/AUL     (  522): launch.c: app_request_to_launchpad(298) > request cmd(0) result(24069)
04-11 11:10:44.652+0200 E/CAPI_APPFW_APP_CONTROL(  522): app_control.c: app_control_error(131) > [app_control_add_extra_data_array] INVALID_PARAMETER(0xffffffea) : invalid array
04-11 11:10:44.652+0200 E/CAPI_APPFW_APP_CONTROL(  522): app_control.c: app_control_error(131) > [app_control_add_extra_data_array] INVALID_PARAMETER(0xffffffea) : invalid array
04-11 11:10:44.652+0200 W/AUL     (  522): launch.c: app_request_to_launchpad(284) > request cmd(0) to(com.samsung.w-contacts2.consumer)
04-11 11:10:44.652+0200 W/AUL_AMD (  514): amd_request.c: __request_handler(669) > __request_handler: 0
04-11 11:10:44.672+0200 W/AUL_AMD (  514): amd_launch.c: _start_app(1782) > caller pid : 522
04-11 11:10:44.672+0200 I/AUL_AMD (  514): amd_launch.c: __check_app_control_privilege(1693) > Skip the privilege check in case of preloaded apps
04-11 11:10:44.687+0200 W/AUL_AMD (  514): amd_launch.c: start_process(606) > child process: 24072
04-11 11:10:44.707+0200 W/STARTER (  764): pkg-monitor.c: _app_mgr_status_cb(400) > [_app_mgr_status_cb:400] Launch request [24069]
04-11 11:10:44.737+0200 W/AUL_AMD (  514): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 24072
04-11 11:10:44.737+0200 W/AUL     (  514): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(com.samsung.w-contacts2.consumer) pid(24072) type(svcapp) bg(0)
04-11 11:10:44.742+0200 W/AUL     (  522): launch.c: app_request_to_launchpad(298) > request cmd(0) result(24072)
04-11 11:10:44.742+0200 E/WMS     (  522): wms_msg_broker.c: wms_msg_broker_send(1826) > 
04-11 11:10:44.742+0200 E/WMS     (  522): ==========
04-11 11:10:44.742+0200 E/WMS     (  522): ##WMS SEND : mgr_ns_primary_contactlist_res
04-11 11:10:44.742+0200 E/WMS     (  522): ==========
04-11 11:10:44.742+0200 E/WMS     (  522): wms_msg_broker.c: wms_msg_broker_send(1842) > Data size: 82 MAX Buffer Size: 61440
04-11 11:10:44.742+0200 E/WMS     (  522): wms_event_handler.c: wms_event_handler_routine(24535) > [mgr_ns_primary_contactlist_req] handler success.
04-11 11:10:44.757+0200 W/AUL_AMD (  514): amd_request.c: __request_handler(669) > __request_handler: 14
04-11 11:10:44.767+0200 W/AUL_AMD (  514): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 24069
04-11 11:10:44.772+0200 W/AUL_AMD (  514): amd_request.c: __request_handler(669) > __request_handler: 12
04-11 11:10:44.782+0200 W/STARTER (  764): pkg-monitor.c: _app_mgr_status_cb(400) > [_app_mgr_status_cb:400] Launch request [24072]
04-11 11:10:44.827+0200 W/AUL_AMD (  514): amd_request.c: __request_handler(669) > __request_handler: 14
04-11 11:10:44.832+0200 W/AUL_AMD (  514): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 24072
04-11 11:10:44.837+0200 W/AUL_AMD (  514): amd_request.c: __request_handler(669) > __request_handler: 12
04-11 11:10:44.842+0200 W/AUL_AMD (  514): amd_request.c: __request_handler(669) > __request_handler: 14
04-11 11:10:44.852+0200 W/AUL_AMD (  514): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 24069
04-11 11:10:44.852+0200 W/AUL_AMD (  514): amd_request.c: __request_handler(669) > __request_handler: 12
04-11 11:10:44.882+0200 W/AUL_AMD (  514): amd_request.c: __request_handler(669) > __request_handler: 14
04-11 11:10:44.892+0200 W/AUL_AMD (  514): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 24072
04-11 11:10:44.892+0200 W/AUL_AMD (  514): amd_request.c: __request_handler(669) > __request_handler: 12
04-11 11:10:44.952+0200 E/ALARM_MANAGER(  519): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [1193].
04-11 11:10:44.952+0200 E/ALARM_MANAGER(  519): alarm-manager.c: __alarm_remove_from_list(575) > [alarm-server]:Remove alarm id(502468935)
04-11 11:10:44.982+0200 W/AUL_AMD (  514): amd_status.c: __socket_monitor_cb(1277) > (24072) was created
04-11 11:10:44.982+0200 W/CAPI_APPFW_APP_CONTROL(24072): app_control.c: app_control_error(136) > [app_control_get_extra_data_array] KEY_NOT_FOUND(0xffffff82)
04-11 11:10:44.992+0200 W/CAPI_APPFW_APP_CONTROL(24072): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-11 11:10:44.992+0200 W/CAPI_APPFW_APP_CONTROL(24072): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-11 11:10:44.992+0200 I/efl-extension(24069): efl_extension.c: eext_mod_init(40) > Init
04-11 11:10:45.017+0200 W/AUL_AMD (  514): amd_status.c: __socket_monitor_cb(1277) > (24069) was created
04-11 11:10:45.017+0200 W/CAPI_APPFW_APP_CONTROL(24069): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-11 11:10:45.017+0200 W/EMG_MSG_SETTING(24069): emg-msg-setting.c: data_store(46) > [0;35mno value for [emg_contact_list] err [-126][0;m
04-11 11:10:45.022+0200 W/CAPI_APPFW_APP_CONTROL(24069): app_control.c: app_control_error(136) > [app_control_get_extra_data_array] KEY_NOT_FOUND(0xffffff82)
04-11 11:10:45.022+0200 W/EMG_MSG_SETTING(24069): emg-msg-setting.c: data_store(59) > [0;35mno value for [emg_contact_number_list] err [-126][0;m
04-11 11:10:45.022+0200 W/CAPI_APPFW_APP_CONTROL(24069): app_control.c: app_control_error(136) > [app_control_get_extra_data_array] KEY_NOT_FOUND(0xffffff82)
04-11 11:10:45.022+0200 W/EMG_MSG_SETTING(24069): emg-msg-setting.c: data_store(72) > [0;35mno value for [emg_contact_name_list] err [-126][0;m
04-11 11:10:45.022+0200 W/CAPI_APPFW_APP_CONTROL(24069): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-11 11:10:45.022+0200 W/EMG_MSG_SETTING(24069): emg-msg-setting.c: data_store(82) > [0;35mno value for [emg_silent_call] err [-126][0;m
04-11 11:10:45.022+0200 W/CAPI_APPFW_APP_CONTROL(24069): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-11 11:10:45.022+0200 W/EMG_MSG_SETTING(24069): emg-msg-setting.c: data_store(92) > [0;35mno value for [emg_silent_call_number] err [-126][0;m
04-11 11:10:45.022+0200 W/CAPI_APPFW_APP_CONTROL(24069): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-11 11:10:45.022+0200 W/EMG_MSG_SETTING(24069): emg-msg-setting.c: data_store(102) > [0;35mno value for [emg_silent_call_appid] err [-126][0;m
04-11 11:10:45.022+0200 W/CAPI_APPFW_APP_CONTROL(24069): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-11 11:10:45.022+0200 W/EMG_MSG_SETTING(24069): emg-msg-setting.c: data_store(112) > [0;35mno value for [emg_delay_timer] err [-126][0;m
04-11 11:10:45.027+0200 E/ALARM_MANAGER(  519): alarm-manager.c: __display_lock_state(1884) > Lock LCD OFF is successfully done
04-11 11:10:45.027+0200 E/ALARM_MANAGER(  519): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
04-11 11:10:45.027+0200 E/ALARM_MANAGER(  519): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 11-4-2018, 10:07:59 (UTC).
04-11 11:10:45.027+0200 E/ALARM_MANAGER(  519): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
04-11 11:10:45.052+0200 E/ALARM_MANAGER(  519): alarm-manager.c: __display_unlock_state(1927) > Unlock LCD OFF is successfully done
04-11 11:10:45.052+0200 E/ALARM_MANAGER(  519): alarm-manager.c: alarm_manager_alarm_delete(2462) > alarm_id[502468935] is removed.
04-11 11:10:45.062+0200 E/WMS     (  522): wms_msg_broker.c: on_broker_buffer_send(307) > Data sending is success.
04-11 11:10:45.137+0200 E/WMS     (  522): wms_event_handler.c: wms_event_handler_routine(24519) > 
04-11 11:10:45.137+0200 E/WMS     (  522): ==========
04-11 11:10:45.137+0200 E/WMS     (  522): ##WMS RECEIVED : mgr_noti_markedapp_status
04-11 11:10:45.137+0200 E/WMS     (  522): ==========
04-11 11:10:45.137+0200 E/WMS     (  522): wms_event_handler.c: handle_mgr_noti_markedapp_status(20130) > app_label : call
04-11 11:10:45.137+0200 E/WMS     (  522): wms_event_handler.c: wms_event_handler_routine(24535) > [mgr_noti_markedapp_status] handler success.
04-11 11:10:45.267+0200 E/WMS     (  522): wms_event_handler.c: wms_event_handler_routine(24519) > 
04-11 11:10:45.267+0200 E/WMS     (  522): ==========
04-11 11:10:45.267+0200 E/WMS     (  522): ##WMS RECEIVED : mgr_noti_markedapp_status
04-11 11:10:45.267+0200 E/WMS     (  522): ==========
04-11 11:10:45.267+0200 E/WMS     (  522): wms_event_handler.c: handle_mgr_noti_markedapp_status(20130) > app_label : call
04-11 11:10:45.267+0200 E/WMS     (  522): wms_event_handler.c: wms_event_handler_routine(24535) > [mgr_noti_markedapp_status] handler success.
04-11 11:10:46.502+0200 I/SleepAsAndroidConsumer(23994): peer agent connection is successful, pa :1134568840
04-11 11:10:46.852+0200 W/CRASH_MANAGER(24085): worker.c: worker_job(1205) > 1123994736c65152343784
