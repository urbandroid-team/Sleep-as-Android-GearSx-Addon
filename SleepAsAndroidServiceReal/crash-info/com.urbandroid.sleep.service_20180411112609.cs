S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.2.7
Build-Number: R732XXU2FRC1
Build-Date: 2018.03.02 17:21:30

Crash Information
Process Name: sleepasandroidnativeservice
PID: 26068
Date: 2018-04-11 11:26:09+0200
Executable File Path: /opt/usr/apps/com.urbandroid.sleep/bin/sleepasandroidnativeservice
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x2340

Register Information
r0   = 0x430bdef0, r1   = 0x430a14a5
r2   = 0x00000000, r3   = 0x430a14a0
r4   = 0x00002340, r5   = 0x00000000
r6   = 0x00000000, r7   = 0xbebfeeb0
r8   = 0x000078f6, r9   = 0x000078f6
r10  = 0x430acec8, fp   = 0x00000000
ip   = 0x00000000, sp   = 0xbebfedf8
lr   = 0x2e302e31, pc   = 0x4005e244
cpsr = 0x60000030

Memory Information
MemTotal:   490112 KB
MemFree:     10432 KB
Buffers:     13684 KB
Cached:     115912 KB
VmPeak:      60288 KB
VmSize:      60284 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        8916 KB
VmRSS:        8916 KB
VmData:      11256 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       19584 KB
VmPTE:          32 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 26068 TID = 26068
26068 26093 

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
4319a000 43aaf000 rw-p [stack:26093]
bebdf000 bec00000 rw-p [stack]
End of Maps Information

Callstack Information (PID:26068)
Call Stack Count: 20
 0: app_get_version + 0x5f (0x4005e244) [/usr/lib/libcapi-appfw-app-common.so.0] + 0x1244
 1: on_service_connection_created + 0xc6 (0x40002137) [/opt/usr/apps/com.urbandroid.sleep/bin/sleepasandroidnativeservice] + 0x2137
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
17: main + 0x100 (0x40002c51) [/opt/usr/apps/com.urbandroid.sleep/bin/sleepasandroidnativeservice] + 0x2c51
18: __libc_start_main + 0x114 (0x403e285c) [/lib/libc.so.6] + 0x1785c
19: (0x40001644) [/opt/usr/apps/com.urbandroid.sleep/bin/sleepasandroidnativeservice] + 0x1644
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
control_consumer_media_changed_ind_request(199) > [33m[TID:1042]   remote mode[1],resume[1][0m
04-11 11:26:08.000+0200 W/MC_CONSUMER( 1042): wmc-service-consumer.c: wmc_service_consumer_send_data(598) > [33m {"msgId":"music-mediachanged-req","value":"true"}[0m
04-11 11:26:08.010+0200 E/W_HOME  (  843): retailmode.c: retailmode_enabled_get(245) > failed to get value VCONFKEY_RETAILMODE_ENABLED
04-11 11:26:08.010+0200 W/W_HOME  (  843): clock_event.c: _wmanager_connectivity_get(397) > network status : 0
04-11 11:26:08.010+0200 W/W_HOME  (  843): clock_event.c: _wmanager_connectivity_get(402) > sap_connected : 1
04-11 11:26:08.010+0200 W/W_HOME  (  843): clock_event.c: _wmanager_connectivity_get(408) > sap connectivity type : 1
04-11 11:26:08.010+0200 W/W_HOME  (  843): clock_event.c: _wmanager_connectivity_get(414) > network status : 3
04-11 11:26:08.010+0200 W/W_HOME  (  843): clock_event.c: _wmanager_connectivity_get(428) > scs login : 0
04-11 11:26:08.010+0200 W/W_HOME  (  843): clock_event.c: _wmanager_connectivity_get(470) > connected via bluetooth
04-11 11:26:08.010+0200 W/W_HOME  (  843): clock_view_indicator.c: _view_remove_by_type(267) > removed:4
04-11 11:26:08.010+0200 W/W_HOME  (  843): clock_indicator.c: clock_indicator_pop(374) > icon:5(0) is popped from clock indicator
04-11 11:26:08.010+0200 W/wnotib  (  843): w-notification-board-broker-main.c: _wnb_connection_state_changed_cb(379) > is_LO: 0, is_connected: 1
04-11 11:26:08.010+0200 E/wnotib  (  843): w-notification-board-noti-manager-common.c: wnb_nm_get_category_by_application_id(1201) > No category matched.
04-11 11:26:08.015+0200 W/wnotib  (  843): w-notification-board-broker-main.c: _wnb_connection_state_changed_cb(388) > No tips notification.
04-11 11:26:08.015+0200 W/W_INDICATOR(  765): windicator_dynamic.c: _dynamic_bluetooth_state_changed_cb(1071) > [_dynamic_bluetooth_state_changed_cb:1071] isBTOn : 1
04-11 11:26:08.015+0200 W/W_INDICATOR(  765): windicator_dynamic.c: _dynamic_bluetooth_state_changed_cb(1077) > [_dynamic_bluetooth_state_changed_cb:1077] sap connected : 1
04-11 11:26:08.015+0200 W/W_INDICATOR(  765): windicator_dynamic.c: _dynamic_bluetooth_state_changed_cb(1083) > [_dynamic_bluetooth_state_changed_cb:1083] sap connectivity type : 1
04-11 11:26:08.015+0200 W/W_INDICATOR(  765): windicator_dynamic.c: _dynamic_event_item_pack(870) > [_dynamic_event_item_pack:870] There is NO Headset icon, so move wifi icon to position 1
04-11 11:26:08.015+0200 E/W_INDICATOR(  765): windicator_dynamic.c: _dynamic_bluetooth_state_changed_cb(1097) > [_dynamic_bluetooth_state_changed_cb:1097] Failed to get moment view bt icon
04-11 11:26:08.015+0200 I/W_INDICATOR(  765): windicator.c: windicator_is_lo_connected(976) > [windicator_is_lo_connected:976] Connected target vendor : LGE
04-11 11:26:08.015+0200 W/W_INDICATOR(  765): windicator_dynamic.c: _dynamic_bluetooth_state_changed_cb(1131) > [_dynamic_bluetooth_state_changed_cb:1131] display connected BT icon
04-11 11:26:08.015+0200 E/EFL     (  765): <765> elm_main.c:1622 elm_object_signal_emit() safety check failed: obj == NULL
04-11 11:26:08.015+0200 E/TIZEN_N_SYSTEM_SETTINGS(  765): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-11 11:26:08.015+0200 E/TIZEN_N_SYSTEM_SETTINGS(  765): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-11 11:26:08.015+0200 E/TIZEN_N_SYSTEM_SETTINGS(  765): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=4
04-11 11:26:08.015+0200 E/TIZEN_N_SYSTEM_SETTINGS(  765): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 4, key = 4, type = 0
04-11 11:26:08.025+0200 W/MSG_CONSUMER( 1407): SapClient.cpp: _onWmsConnectionChanged(810) > [0;35mprevious_status: (1), status: (1)[0;m
04-11 11:26:08.025+0200 W/MSG_CONSUMER( 1407): SapClient.cpp: _onWmsConnectionChanged(813) > [0;35m_onWmsConnectionChanged() is ignored for same status change. prev:(1), cur:(1)[0;m
04-11 11:26:08.025+0200 W/WECONN  (  508): <__wc_feature_wms_connected_cb:453> priv->wms_connected = 1
04-11 11:26:08.030+0200 W/AUL_AMD (  514): amd_request.c: __request_handler(669) > __request_handler: 14
04-11 11:26:08.035+0200 W/AUL_AMD (  514): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 1744
04-11 11:26:08.035+0200 W/AUL_AMD (  514): amd_request.c: __request_handler(669) > __request_handler: 14
04-11 11:26:08.045+0200 W/AUL_AMD (  514): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 24111
04-11 11:26:08.050+0200 W/AUL_AMD (  514): amd_request.c: __request_handler(669) > __request_handler: 14
04-11 11:26:08.055+0200 W/AUL_AMD (  514): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 26026
04-11 11:26:08.060+0200 W/AUL_AMD (  514): amd_request.c: __request_handler(669) > __request_handler: 14
04-11 11:26:08.070+0200 W/AUL_AMD (  514): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 26029
04-11 11:26:08.070+0200 W/AUL_AMD (  514): amd_request.c: __request_handler(669) > __request_handler: 14
04-11 11:26:08.080+0200 W/AUL_AMD (  514): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 26034
04-11 11:26:08.080+0200 W/AUL_AMD (  514): amd_request.c: __request_handler(669) > __request_handler: 14
04-11 11:26:08.095+0200 W/AUL_AMD (  514): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 24121
04-11 11:26:08.095+0200 W/AUL_AMD (  514): amd_request.c: __request_handler(669) > __request_handler: 14
04-11 11:26:08.105+0200 W/AUL_AMD (  514): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 1042
04-11 11:26:08.105+0200 W/AUL_AMD (  514): amd_request.c: __request_handler(669) > __request_handler: 14
04-11 11:26:08.110+0200 I/efl-extension(26026): efl_extension.c: eext_mod_shutdown(46) > Shutdown
04-11 11:26:08.115+0200 W/AUL_AMD (  514): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 25737
04-11 11:26:08.115+0200 W/AUL_AMD (  514): amd_request.c: __request_handler(669) > __request_handler: 14
04-11 11:26:08.125+0200 W/AUL_AMD (  514): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 26040
04-11 11:26:08.125+0200 W/AUL_AMD (  514): amd_request.c: __request_handler(669) > __request_handler: 14
04-11 11:26:08.135+0200 E/wnoti-ancs( 1082): wnoti-ancs.c: wnoti_ancs_ios_connected_status(2745) > pre_connect_status : 0, bap_connected_status : 0
04-11 11:26:08.135+0200 E/WMS     (  522): wms_event_handler.c: _wms_event_handler_signal_to_systemd(1218) > 
04-11 11:26:08.135+0200 E/WMS     (  522): ==========
04-11 11:26:08.135+0200 E/WMS     (  522): ##WMS WMANAGER CONNECTED : TRUE
04-11 11:26:08.135+0200 E/WMS     (  522): ==========
04-11 11:26:08.135+0200 W/WG-CONSUMER(24121): [32m[F:SAPProxy.cpp     L:  621][_WARN]_on_wms_connected_changed, value = 1, key = memory/wms/wmanager_connected[0m
04-11 11:26:08.135+0200 W/WG-CONSUMER(24121): [34m[F:SAPProxy.cpp     L:  601][_HIGH]Device Connected. Cur type=BT|[0m
04-11 11:26:08.135+0200 W/WG-CONSUMER(24121): [34m[F:SAPProxy.cpp     L:  633][_HIGH]WMS status changed. VConf memory/wms/wmanager_connected value=1 BT=1[0m
04-11 11:26:08.135+0200 W/WG-CONSUMER(24121): [34m[F:SAPProxy.cpp     L:  637][_HIGH]WMS is connected. Try to connection. Connections=2[0m
04-11 11:26:08.140+0200 W/WG-CONSUMER(24121): [34m[F:ConnectionInfo.c L:  190][_HIGH][TX]CConnection::Connect() State:SM_STATE_ESTABLISHED[0m
04-11 11:26:08.140+0200 W/WG-CONSUMER(24121): [34m[F:SAPProxy.cpp     L:  147][_HIGH]CSAPProxy::Connect. Size=2 pConnection=0x4332bc00[0m
04-11 11:26:08.140+0200 W/WG-CONSUMER(24121): [34m[F:SAPProxy.cpp     L:  150][_HIGH]  Connection : [TX] LocalAgentID:60919 ServiceHandle:53504[0m
04-11 11:26:08.140+0200 W/WG-CONSUMER(24121): [34m[F:SAPProxy.cpp     L:  150][_HIGH]  Connection : [RX] LocalAgentID:60920 ServiceHandle:53505[0m
04-11 11:26:08.140+0200 E/WG-CONSUMER(24121): [31m[F:SAPProxy.cpp     L:  161][ERROR]Duplication connection. not inseterd[0m
04-11 11:26:08.140+0200 E/WG-CONSUMER(24121): [31m[F:SAPProxy.cpp     L:  165][ERROR]Previous pCurrent(0x43308370) is exist[0m
04-11 11:26:08.140+0200 W/WG-CONSUMER(24121): [34m[F:SAPProxy.cpp     L:  601][_HIGH]Device Connected. Cur type=BT|[0m
04-11 11:26:08.140+0200 W/WG-CONSUMER(24121): [34m[F:SAPProxy.cpp     L:  186][_HIGH]Device connected. WMS=1 BT=1 [0m
04-11 11:26:08.140+0200 W/WG-CONSUMER(24121): [34m[F:ConnectionInfo.c L:  568][_HIGH][TX]advance. CurState=SM_STATE_ESTABLISHED(8)[0m
04-11 11:26:08.140+0200 W/WG-CONSUMER(24121): [34m[F:ConnectionInfo.c L:  590][_HIGH]Already established.[0m
04-11 11:26:08.140+0200 W/WG-CONSUMER(24121): [34m[F:ConnectionInfo.c L:  190][_HIGH][RX]CConnection::Connect() State:SM_STATE_ESTABLISHED[0m
04-11 11:26:08.140+0200 W/WG-CONSUMER(24121): [34m[F:SAPProxy.cpp     L:  147][_HIGH]CSAPProxy::Connect. Size=2 pConnection=0x43308370[0m
04-11 11:26:08.140+0200 W/WG-CONSUMER(24121): [34m[F:SAPProxy.cpp     L:  150][_HIGH]  Connection : [TX] LocalAgentID:60919 ServiceHandle:53504[0m
04-11 11:26:08.140+0200 W/WG-CONSUMER(24121): [34m[F:SAPProxy.cpp     L:  150][_HIGH]  Connection : [RX] LocalAgentID:60920 ServiceHandle:53505[0m
04-11 11:26:08.140+0200 E/WG-CONSUMER(24121): [31m[F:SAPProxy.cpp     L:  161][ERROR]Duplication connection. not inseterd[0m
04-11 11:26:08.140+0200 E/WG-CONSUMER(24121): [31m[F:SAPProxy.cpp     L:  165][ERROR]Previous pCurrent(0x4332bc00) is exist[0m
04-11 11:26:08.140+0200 W/WG-CONSUMER(24121): [34m[F:SAPProxy.cpp     L:  601][_HIGH]Device Connected. Cur type=BT|[0m
04-11 11:26:08.140+0200 W/WG-CONSUMER(24121): [34m[F:SAPProxy.cpp     L:  186][_HIGH]Device connected. WMS=1 BT=1 [0m
04-11 11:26:08.140+0200 W/WG-CONSUMER(24121): [34m[F:ConnectionInfo.c L:  568][_HIGH][RX]advance. CurState=SM_STATE_ESTABLISHED(8)[0m
04-11 11:26:08.140+0200 W/WG-CONSUMER(24121): [34m[F:ConnectionInfo.c L:  590][_HIGH]Already established.[0m
04-11 11:26:08.140+0200 W/AUL_AMD (  514): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 26043
04-11 11:26:08.155+0200 E/WMS     (  522): wms_event_handler.c: handle_mgr_host_status_res(17185) > TIMESTAMP saved: 1523438762257P:?LAL>AC:K:
04-11 11:26:08.155+0200 E/WMS     (  522): wms_event_handler.c: wms_event_handler_routine(24535) > [mgr_host_status_res] handler success.
04-11 11:26:08.170+0200 W/W_INDICATOR(  765): windicator_scs.c: windicator_scs_update(123) > [windicator_scs_update:123] sales code : 0
04-11 11:26:08.170+0200 W/W_INDICATOR(  765): windicator_scs.c: windicator_scs_update(131) > [windicator_scs_update:131] sap connected : 1
04-11 11:26:08.175+0200 W/W_INDICATOR(  765): windicator_scs.c: windicator_scs_update(146) > [windicator_scs_update:146] ciss_request_type : 0
04-11 11:26:08.175+0200 I/W_INDICATOR(  765): windicator_scs.c: windicator_scs_update(155) > [windicator_scs_update:155] Hide (Callforwarding requested)
04-11 11:26:08.175+0200 I/W_INDICATOR(  765): windicator.c: windicator_is_lo_connected(976) > [windicator_is_lo_connected:976] Connected target vendor : LGE
04-11 11:26:08.175+0200 W/W_INDICATOR(  765): windicator_scs.c: windicator_scs_update(195) > [windicator_scs_update:195] sap connectivity type : 1
04-11 11:26:08.175+0200 W/W_INDICATOR(  765): windicator_scs.c: windicator_scs_update(203) > [windicator_scs_update:203] network status : 3
04-11 11:26:08.175+0200 W/W_INDICATOR(  765): windicator_scs.c: windicator_scs_update(220) > [windicator_scs_update:220] scs login : 0
04-11 11:26:08.175+0200 W/W_INDICATOR(  765): windicator_scs.c: windicator_scs_update(261) > [windicator_scs_update:261] connected via bluetooth
04-11 11:26:08.190+0200 E/weather-consumer(26043): WeatherConsumerController.cpp: Start(73) > [0;40;31mhostDeviceVendor : LGE[0;m
04-11 11:26:08.190+0200 I/magazine-service(  995): magazine-service-connection.c: _magazine_service_connection_vconf_key_changed_cb(183) > host_connected changed [1] -> [1]
04-11 11:26:08.190+0200 E/weather-consumer(26043): AppcessoryProtocol.cpp: SetSendMessageType(60) > [0;40;31mSetSendMessageType : 0[0;m
04-11 11:26:08.190+0200 E/weather-consumer(26043): AppcessoryProtocol.cpp: MakeMessageForAndroid(88) > [0;40;31mMakeMessageForAndroid[0;m
04-11 11:26:08.195+0200 E/weather-consumer(26043): AppcessoryProtocol.cpp: CreateCpListText(160) > [0;40;31mCP list supported : "Accuweather","TWC","WeatherNews","cmaweather","Kweather","WCN"[0;m
04-11 11:26:08.195+0200 E/weather-consumer(26043): AppcessoryProtocol.cpp: MakeMessageForAndroid(140) > [0;40;31mmSendMessage : {"WEATHER_REQUEST":{"FETCH_REQ":1,"SHOW_SETTING_ON_DEVICE":0,"UPDATED_BY_GEAR":0,"CP_LIST":["Accuweather","TWC","WeatherNews","cmaweather","Kweather","WCN"],"ADD_CURRENT_CITY":0},"REVISION":1,"WEATHER_ACK_SEQ": "1523438768"}[0;m
04-11 11:26:08.195+0200 E/weather-consumer(26043): SamsungAppcessoryProtocol.cpp: Start(97) > [0;40;31mg_timeout_add_seconds mRequestTimer:22[0;m
04-11 11:26:08.195+0200 W/MC_CONSUMER( 1042): wmc-service-consumer.c: wmc_service_consumer_send_data(598) > [33m {"msgId":"music-queue-req"}[0m
04-11 11:26:08.300+0200 W/WVMS_SERVER(26040): wvoice-memo-media-info.c: wvoice_memo_media_get_next_unsync(331) > [32m no unsync file[0m
04-11 11:26:08.300+0200 W/WVMS_SERVER(26040): wvms-server-controller.c: wvms_server_controller_send_file_process(193) > [32m transfer file is not existed[0m
04-11 11:26:08.360+0200 W/AUL     (26094): daemon-manager-release-agent.c: main(12) > release agent : [2:/com.samsung.samsung-pay-app-service]
04-11 11:26:08.360+0200 W/AUL_AMD (  514): amd_request.c: __request_handler(669) > __request_handler: 23
04-11 11:26:08.360+0200 W/AUL_AMD (  514): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-11 11:26:08.360+0200 W/AUL_AMD (  514): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 25090
04-11 11:26:08.360+0200 W/AUL_AMD (  514): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-11 11:26:08.385+0200 E/RESOURCED(  623): procfs.c: proc_get_oom_score_adj(178) > fopen /proc/26026/oom_score_adj failed
04-11 11:26:08.385+0200 E/RESOURCED(  623): proc-main.c: resourced_proc_status_change(1501) > Empty pid or process not exists. 26026
04-11 11:26:08.390+0200 I/AUL_AMD (  514): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 25090
04-11 11:26:08.395+0200 W/AUL     (  514): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(25090)
04-11 11:26:08.470+0200 W/MC_CONSUMER( 1042): wmc-service-consumer.c: wmc_service_consumer_send_data(598) > [33m {"msgId":"music-getattribute-req"}[0m
04-11 11:26:08.470+0200 E/WMS     (  522): wms_msg_broker.c: on_broker_buffer_send(307) > Data sending is success.
04-11 11:26:08.690+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: _music_control_consumer_control_print_msg_type(105) > [33m[TID:1042]   msg [WMC_SERVICE_WIPC_MSG_ID_CAPABILITY_FEATURE_RESPONSE][0m
04-11 11:26:08.695+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: music_control_consumer_msg_process(243) > [36m[TID:1042]   [MUSIC_PLAYER_EVENT]Device State [2] normal:0 dim:1 off:2[0m
04-11 11:26:08.695+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: music_control_consumer_media_changed_ind_request(199) > [33m[TID:1042]   remote mode[1],resume[0][0m
04-11 11:26:08.695+0200 W/MC_CONSUMER( 1042): wmc-service-consumer.c: wmc_service_consumer_send_data(598) > [33m {"msgId":"music-mediachanged-req","value":"false"}[0m
04-11 11:26:08.700+0200 E/WMS     (  522): wms_msg_broker.c: on_broker_buffer_send(307) > Data sending is success.
04-11 11:26:08.975+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: music_control_consumer_msg_process(381) > [33m[TID:1042]   distinct state = 0, max vol[15], safety_vol[0][0m
04-11 11:26:08.975+0200 W/MUSIC_PLAYER( 1042): mp-weconn.c: _wms_connection_vconf_changed_callback(93) > [33m[TID:1042]   [1][0m
04-11 11:26:08.975+0200 W/MC_CONSUMER( 1042): wmc-service-cotroller.c: _bt_connection_changed_cb(60) > [33m connected[1][0m
04-11 11:26:08.990+0200 E/PKGMGR_SERVER(26087): pkgmgr-server.c: exit_server(1620) > exit_server Start [backend_status=1, queue_status=1] 
04-11 11:26:08.990+0200 E/PKGMGR_SERVER(26087): pkgmgr-server.c: main(2296) > package manager server terminated.
04-11 11:26:09.005+0200 E/weather-consumer(26043): SAPNotificationCallback.cpp: OnDataIndication(65) > [0;40;31mOnDataIndication called. payloadLength(16113)[0;m
04-11 11:26:09.005+0200 E/weather-consumer(26043): SamsungAppcessoryProtocol.cpp: OnAppcessoryProtocolDataReceived(240) > [0;40;31mFETCH_REQUEST_TIMEOUT timer removed[0;m
04-11 11:26:09.005+0200 E/weather-consumer(26043): AppcessoryProtocol.cpp: SetSendMessageType(60) > [0;40;31mSetSendMessageType : 9999[0;m
04-11 11:26:09.005+0200 E/weather-consumer(26043): AppcessoryProtocol.cpp: SetSendMessageType(79) > [0;40;31m[Error] Wrong MessageType : 9999[0;m
04-11 11:26:09.025+0200 E/weather-common(26043): JsonUtil.cpp: GetValueFromNode(154) > [0;40;31mEntering node default case[0;m
04-11 11:26:09.030+0200 E/weather-common(26043): JsonUtil.cpp: GetValueFromNode(154) > [0;40;31mEntering node default case[0;m
04-11 11:26:09.030+0200 E/weather-common(26043): JsonUtil.cpp: GetValueFromNode(154) > [0;40;31mEntering node default case[0;m
04-11 11:26:09.030+0200 E/weather-common(26043): SAPMessageParser.cpp: ParseSettingInfo(664) > [0;40;31mcpType:TWC[0;m
04-11 11:26:09.030+0200 E/weather-common(26043): SAPMessageParser.cpp: ParseSettingInfo(765) > [0;40;31mNotificationOn:1, NotificationPopup:0, Notification time:1523428502, Temperature unit:1[0;m
04-11 11:26:09.030+0200 E/weather-common(26043): SAPMessageParser.cpp: ParseSettingInfo(766) > [0;40;31mRefresh Interval:3, UseCurrentLocationOn:1, ShowCurrentCityAgreement:1[0;m
04-11 11:26:09.030+0200 E/weather-common(26043): SAPMessageParser.cpp: ParseSettingInfo(767) > [0;40;31mAPI version, AccuWeather:9999, TWC:9999, WeatherNewsKR:2, WeatherNewsJP:3, CMAWeather:9999, WCN:2[0;m
04-11 11:26:09.035+0200 E/weather-common(26043): JsonUtil.cpp: GetValueFromNode(154) > [0;40;31mEntering node default case[0;m
04-11 11:26:09.035+0200 E/weather-common(26043): SAPMessageParser.cpp: ParseCityInfo(181) > [0;40;31mthere is no mSettingPtr. we just set the location id[0;m
04-11 11:26:09.035+0200 E/weather-common(26043): SAPMessageParser.cpp: ParseCityInfo(200) > [0;40;31mCityName:Pra, CityNameEng:Pra, IsCurrentLocation:1[0;m
04-11 11:26:09.035+0200 E/weather-common(26043): SAPMessageParser.cpp: ParseCurrentInfo(232) > [0;40;31mCurTemp:20.0, HighTemp:22.0, LowTemp:8.0, WeatherIcon:30, WeatherIconConverted:1[0;m
04-11 11:26:09.035+0200 E/weather-common(26043): PreferenceHelper.cpp: SetIsWeatherIconConvertedToCommonResource(66) > [0;40;31m[Value : 1][0;m
04-11 11:26:09.075+0200 E/weather-common(26043): SAPMessageParser.cpp: ParseCurrentInfo(248) > [0;40;31mCITY_TODAY_ICON_NUM_CONVERTED : 1[0;m
04-11 11:26:09.075+0200 E/weather-common(26043): SAPMessageParser.cpp: ParseForecastinfo(318) > [0;40;31mHighTemp:22.0, LowTemp:8.0, WeatherIcon:30, WeatherIconConverted:2[0;m
04-11 11:26:09.080+0200 E/weather-common(26043): SAPMessageParser.cpp: ParseForecastinfo(318) > [0;40;31mHighTemp:21.0, LowTemp:10.0, WeatherIcon:30, WeatherIconConverted:2[0;m
04-11 11:26:09.080+0200 E/weather-common(26043): SAPMessageParser.cpp: ParseForecastinfo(318) > [0;40;31mHighTemp:23.0, LowTemp:13.0, WeatherIcon:34, WeatherIconConverted:1[0;m
04-11 11:26:09.080+0200 E/weather-common(26043): SAPMessageParser.cpp: ParseForecastinfo(318) > [0;40;31mHighTemp:20.0, LowTemp:7.0, WeatherIcon:38, WeatherIconConverted:9[0;m
04-11 11:26:09.080+0200 E/weather-common(26043): SAPMessageParser.cpp: ParseForecastinfo(318) > [0;40;31mHighTemp:22.0, LowTemp:10.0, WeatherIcon:34, WeatherIconConverted:1[0;m
04-11 11:26:09.080+0200 E/weather-common(26043): SAPMessageParser.cpp: ParseForecastinfo(318) > [0;40;31mHighTemp:23.0, LowTemp:12.0, WeatherIcon:30, WeatherIconConverted:2[0;m
04-11 11:26:09.085+0200 E/weather-common(26043): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:20.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:30, WeatherIconConverted:1, RainForecast:0[0;m
04-11 11:26:09.090+0200 E/weather-common(26043): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:19.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:30, WeatherIconConverted:1, RainForecast:0[0;m
04-11 11:26:09.090+0200 E/weather-common(26043): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:18.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:30, WeatherIconConverted:1, RainForecast:0[0;m
04-11 11:26:09.090+0200 E/weather-common(26043): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:17.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:30, WeatherIconConverted:1, RainForecast:0[0;m
04-11 11:26:09.090+0200 E/weather-common(26043): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:16.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:29, WeatherIconConverted:1, RainForecast:1[0;m
04-11 11:26:09.120+0200 E/weather-common(26043): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:14.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:29, WeatherIconConverted:1, RainForecast:2[0;m
04-11 11:26:09.120+0200 E/weather-common(26043): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:13.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:29, WeatherIconConverted:1, RainForecast:4[0;m
04-11 11:26:09.125+0200 E/weather-common(26043): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:13.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:29, WeatherIconConverted:1, RainForecast:5[0;m
04-11 11:26:09.125+0200 E/weather-common(26043): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:12.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:29, WeatherIconConverted:1, RainForecast:6[0;m
04-11 11:26:09.125+0200 E/weather-common(26043): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:11.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:29, WeatherIconConverted:1, RainForecast:7[0;m
04-11 11:26:09.125+0200 E/weather-common(26043): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:10.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:29, WeatherIconConverted:1, RainForecast:7[0;m
04-11 11:26:09.125+0200 E/weather-common(26043): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:10.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:29, WeatherIconConverted:1, RainForecast:8[0;m
04-11 11:26:09.130+0200 E/weather-common(26043): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:9.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:27, WeatherIconConverted:2, RainForecast:14[0;m
04-11 11:26:09.130+0200 E/weather-common(26043): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:9.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:27, WeatherIconConverted:2, RainForecast:15[0;m
04-11 11:26:09.130+0200 E/weather-common(26043): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:9.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:29, WeatherIconConverted:1, RainForecast:9[0;m
04-11 11:26:09.130+0200 E/weather-common(26043): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:9.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:30, WeatherIconConverted:1, RainForecast:8[0;m
04-11 11:26:09.130+0200 E/weather-common(26043): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:11.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:30, WeatherIconConverted:1, RainForecast:7[0;m
04-11 11:26:09.135+0200 E/weather-common(26043): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:12.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:30, WeatherIconConverted:1, RainForecast:5[0;m
04-11 11:26:09.135+0200 E/weather-common(26043): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:14.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:28, WeatherIconConverted:2, RainForecast:3[0;m
04-11 11:26:09.135+0200 E/weather-common(26043): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:15.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:30, WeatherIconConverted:1, RainForecast:1[0;m
04-11 11:26:09.135+0200 E/weather-common(26043): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:17.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:30, WeatherIconConverted:1, RainForecast:0[0;m
04-11 11:26:09.135+0200 E/weather-common(26043): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:18.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:30, WeatherIconConverted:1, RainForecast:6[0;m
04-11 11:26:09.140+0200 E/weather-common(26043): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:19.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:30, WeatherIconConverted:1, RainForecast:18[0;m
04-11 11:26:09.140+0200 E/weather-common(26043): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:20.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:30, WeatherIconConverted:1, RainForecast:22[0;m
04-11 11:26:09.140+0200 E/weather-common(26043): SAPMessageParser.cpp: ParseLifeIndexInfo(573) > [0;40;31mPM10:[9999.0,9999], Humidity:-1, SunsetTime:1523382480, SunriseTime:1523333940, UV:[9999.0,9999], toDayUVIndex:9999, UVIndexText:9999[0;m
04-11 11:26:09.140+0200 E/weather-common(26043): SAPMessageParser.cpp: ParseLifeIndexInfo(586) > [0;40;31mrealfeelTemp : [0;m
04-11 11:26:09.140+0200 E/weather-common(26043): LifeIndex.h: PrintDebugInformation(427) > [0;40;31m[humidiry:-1], [pressure:9999.0], [realfeel:9999.0], [visibility:9999.0], [airDust:9999.0,9999], [airPolution:9999.0,9999,9999], [allergy:9999.0,9999,9999], [aqi:9999.0,9999], [carwash:9999.0,9999,9999], [clothing:9999.0,9999,9999], [cold:9999.0,9999,9999], [comfort:9999.0,9999,9999], [cosmetic:9999.0,9999,9999], [discomfort:9999.0,9999], [drivingDifficulty:9999.0,9999,9999],[dryClothing:9999.0,9999,9999], [drySkin:9999.0,9999], [fishing:9999.0,9999,9999], [foodPoison:9999.0,9999], [frostbite:9999.0,9999], [frozenPipes:9999.0,9999], [heat:9999.0,9999], [heatStroke:9999.0,9999], [khai:9999.0,9999], [outdoorExcercise:9999.0,9999,9999], [pm10:9999.0,9999], [pm25:9999.0,9999], [pollen:9999.0,9999], [running:9999.0,9999,9999], [skincare:9999.0,9999], [spoiledFood:9999.0,9999], [umbrella:9999.0,9999],[uv:9999.0,9999,9999][0;m
04-11 11:26:09.140+0200 E/weather-common(26043): JsonUtil.cpp: GetValueFromNode(154) > [0;40;31mEntering node default case[0;m
04-11 11:26:09.145+0200 E/weather-common(26043): SAPMessageParser.cpp: ParseCityInfo(181) > [0;40;31mthere is no mSettingPtr. we just set the location id[0;m
04-11 11:26:09.145+0200 E/weather-common(26043): SAPMessageParser.cpp: ParseCityInfo(200) > [0;40;31mCityName:Pra, CityNameEng:Pra, IsCurrentLocation:0[0;m
04-11 11:26:09.145+0200 E/weather-common(26043): SAPMessageParser.cpp: ParseCurrentInfo(232) > [0;40;31mCurTemp:21.0, HighTemp:20.0, LowTemp:8.0, WeatherIcon:30, WeatherIconConverted:1[0;m
04-11 11:26:09.145+0200 E/weather-common(26043): PreferenceHelper.cpp: SetIsWeatherIconConvertedToCommonResource(66) > [0;40;31m[Value : 1][0;m
04-11 11:26:09.145+0200 E/weather-common(26043): SAPMessageParser.cpp: ParseCurrentInfo(248) > [0;40;31mCITY_TODAY_ICON_NUM_CONVERTED : 1[0;m
04-11 11:26:09.150+0200 E/weather-common(26043): SAPMessageParser.cpp: ParseForecastinfo(318) > [0;40;31mHighTemp:20.0, LowTemp:8.0, WeatherIcon:30, WeatherIconConverted:2[0;m
04-11 11:26:09.150+0200 E/weather-common(26043): SAPMessageParser.cpp: ParseForecastinfo(318) > [0;40;31mHighTemp:20.0, LowTemp:10.0, WeatherIcon:30, WeatherIconConverted:2[0;m
04-11 11:26:09.150+0200 E/weather-common(26043): SAPMessageParser.cpp: ParseForecastinfo(318) > [0;40;31mHighTemp:22.0, LowTemp:12.0, WeatherIcon:34, WeatherIconConverted:1[0;m
04-11 11:26:09.150+0200 E/weather-common(26043): SAPMessageParser.cpp: ParseForecastinfo(318) > [0;40;31mHighTemp:20.0, LowTemp:7.0, WeatherIcon:38, WeatherIconConverted:9[0;m
04-11 11:26:09.150+0200 E/weather-common(26043): SAPMessageParser.cpp: ParseForecastinfo(318) > [0;40;31mHighTemp:21.0, LowTemp:10.0, WeatherIcon:34, WeatherIconConverted:1[0;m
04-11 11:26:09.150+0200 E/weather-common(26043): SAPMessageParser.cpp: ParseForecastinfo(318) > [0;40;31mHighTemp:22.0, LowTemp:12.0, WeatherIcon:30, WeatherIconConverted:2[0;m
04-11 11:26:09.150+0200 E/weather-common(26043): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:20.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:30, WeatherIconConverted:1, RainForecast:0[0;m
04-11 11:26:09.155+0200 E/weather-common(26043): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:19.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:30, WeatherIconConverted:1, RainForecast:0[0;m
04-11 11:26:09.155+0200 E/weather-common(26043): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:18.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:30, WeatherIconConverted:1, RainForecast:0[0;m
04-11 11:26:09.155+0200 E/weather-common(26043): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:17.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:30, WeatherIconConverted:1, RainForecast:0[0;m
04-11 11:26:09.155+0200 E/weather-common(26043): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:16.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:29, WeatherIconConverted:1, RainForecast:2[0;m
04-11 11:26:09.155+0200 E/weather-common(26043): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:15.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:29, WeatherIconConverted:1, RainForecast:2[0;m
04-11 11:26:09.155+0200 E/weather-common(26043): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:14.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:29, WeatherIconConverted:1, RainForecast:4[0;m
04-11 11:26:09.160+0200 E/weather-common(26043): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:13.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:29, WeatherIconConverted:1, RainForecast:5[0;m
04-11 11:26:09.165+0200 E/weather-common(26043): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:12.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:29, WeatherIconConverted:1, RainForecast:6[0;m
04-11 11:26:09.165+0200 E/weather-common(26043): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:12.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:29, WeatherIconConverted:1, RainForecast:8[0;m
04-11 11:26:09.165+0200 E/weather-common(26043): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:10.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:29, WeatherIconConverted:1, RainForecast:8[0;m
04-11 11:26:09.165+0200 E/weather-common(26043): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:10.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:29, WeatherIconConverted:1, RainForecast:8[0;m
04-11 11:26:09.165+0200 E/weather-common(26043): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:9.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:27, WeatherIconConverted:2, RainForecast:15[0;m
04-11 11:26:09.170+0200 E/weather-common(26043): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:9.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:27, WeatherIconConverted:2, RainForecast:15[0;m
04-11 11:26:09.170+0200 E/weather-common(26043): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:9.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:29, WeatherIconConverted:1, RainForecast:9[0;m
04-11 11:26:09.170+0200 E/weather-common(26043): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:9.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:30, WeatherIconConverted:1, RainForecast:9[0;m
04-11 11:26:09.170+0200 E/weather-common(26043): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:11.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:30, WeatherIconConverted:1, RainForecast:7[0;m
04-11 11:26:09.170+0200 E/weather-common(26043): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:12.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:30, WeatherIconConverted:1, RainForecast:5[0;m
04-11 11:26:09.170+0200 E/weather-common(26043): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:14.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:28, WeatherIconConverted:2, RainForecast:3[0;m
04-11 11:26:09.170+0200 E/weather-common(26043): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:15.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:30, WeatherIconConverted:1, RainForecast:1[0;m
04-11 11:26:09.175+0200 E/weather-common(26043): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:17.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:30, WeatherIconConverted:1, RainForecast:0[0;m
04-11 11:26:09.175+0200 E/weather-common(26043): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:18.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:30, WeatherIconConverted:1, RainForecast:6[0;m
04-11 11:26:09.175+0200 E/weather-common(26043): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:19.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:30, WeatherIconConverted:1, RainForecast:19[0;m
04-11 11:26:09.175+0200 E/weather-common(26043): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:20.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:30, WeatherIconConverted:1, RainForecast:24[0;m
04-11 11:26:09.180+0200 E/weather-common(26043): SAPMessageParser.cpp: ParseLifeIndexInfo(573) > [0;40;31mPM10:[9999.0,9999], Humidity:-1, SunsetTime:1523382480, SunriseTime:1523333940, UV:[9999.0,9999], toDayUVIndex:9999, UVIndexText:9999[0;m
04-11 11:26:09.180+0200 E/weather-common(26043): SAPMessageParser.cpp: ParseLifeIndexInfo(586) > [0;40;31mrealfeelTemp : [0;m
04-11 11:26:09.180+0200 E/weather-common(26043): LifeIndex.h: PrintDebugInformation(427) > [0;40;31m[humidiry:-1], [pressure:9999.0], [realfeel:9999.0], [visibility:9999.0], [airDust:9999.0,9999], [airPolution:9999.0,9999,9999], [allergy:9999.0,9999,9999], [aqi:9999.0,9999], [carwash:9999.0,9999,9999], [clothing:9999.0,9999,9999], [cold:9999.0,9999,9999], [comfort:9999.0,9999,9999], [cosmetic:9999.0,9999,9999], [discomfort:9999.0,9999], [drivingDifficulty:9999.0,9999,9999],[dryClothing:9999.0,9999,9999], [drySkin:9999.0,9999], [fishing:9999.0,9999,9999], [foodPoison:9999.0,9999], [frostbite:9999.0,9999], [frozenPipes:9999.0,9999], [heat:9999.0,9999], [heatStroke:9999.0,9999], [khai:9999.0,9999], [outdoorExcercise:9999.0,9999,9999], [pm10:9999.0,9999], [pm25:9999.0,9999], [pollen:9999.0,9999], [running:9999.0,9999,9999], [skincare:9999.0,9999], [spoiledFood:9999.0,9999], [umbrella:9999.0,9999],[uv:9999.0,9999,9999][0;m
04-11 11:26:09.185+0200 E/weather-consumer(26043): SamsungAppcessoryProtocol.cpp: OnAppcessoryProtocolDataReceived(274) > [0;40;31mduplicated weather infor [0;m
04-11 11:26:09.190+0200 E/weather-consumer(26043): SamsungAppcessoryProtocol.cpp: OnAppcessoryProtocolDataReceived(280) > [0;40;31mSeting DB is Updated.[0;m
04-11 11:26:09.190+0200 E/weather-consumer(26043): SamsungAppcessoryProtocol.cpp: OnAppcessoryProtocolDataReceived(283) > [0;40;31m[OnAppcessoryProtocolDataReceived(): 283] (isDuplicateData == true) [break][0;m
04-11 11:26:09.190+0200 E/weather-common(26043): SAPMessageParser.cpp: ParseAckSeq(849) > [0;40;31mWeatherAckSeq : 1523438768780[0;m
04-11 11:26:09.190+0200 E/weather-consumer(26043): SamsungAppcessoryProtocol.cpp: OnAppcessoryProtocolDataReceived(420) > [0;40;31mmReceiveWeatherAck : 1523438768780[0;m
04-11 11:26:09.190+0200 I/APP_CORE(  843): appcore-efl.c: __do_app(453) > [APP 843] Event: MEM_FLUSH State: PAUSED
04-11 11:26:09.190+0200 E/weather-consumer(26043): AppcessoryProtocol.cpp: SetSendMessageType(60) > [0;40;31mSetSendMessageType : 5[0;m
04-11 11:26:09.190+0200 E/weather-consumer(26043): AppcessoryProtocol.cpp: MakeMessageForAndroid(88) > [0;40;31mMakeMessageForAndroid[0;m
04-11 11:26:09.190+0200 E/weather-consumer(26043): AppcessoryProtocol.cpp: MakeMessageForAndroid(140) > [0;40;31mmSendMessage : { "WEATHER_ACK_SEQ": "1523438768780" }[0;m
04-11 11:26:09.250+0200 W/MC_CONSUMER( 1042): wmc-service-consumer.c: __wmc_on_data_ind(386) > [33m length : [64][{"msgId":"music-mediachanged-rsp","result":"success","reason":0}][0m
04-11 11:26:09.255+0200 W/MC_CONSUMER( 1042): wmc-service-consumer.c: __wmc_on_data_ind(386) > [33m length : [142][{"msgId":"music-mediachanged-ind","artist":"","album":"","title":"","audioId":"-1","playStatus":"false","favoriteStatus":"false","index":"-1"}][0m
04-11 11:26:09.255+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: _music_control_consumer_control_print_msg_type(105) > [33m[TID:1042]   msg [WMC_SERVICE_WIPC_MSG_ID_MEDIA_CHANGED_IND][0m
04-11 11:26:09.255+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: music_control_consumer_msg_process(243) > [36m[TID:1042]   [MUSIC_PLAYER_EVENT]Device State [2] normal:0 dim:1 off:2[0m
04-11 11:26:09.255+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: music_control_consumer_media_changed_ind_request(199) > [33m[TID:1042]   remote mode[1],resume[0][0m
04-11 11:26:09.255+0200 W/MC_CONSUMER( 1042): wmc-service-consumer.c: __wmc_on_data_ind(386) > [33m length : [44][{"msgId":"music-queuechanged-ind","count":0}][0m
04-11 11:26:09.260+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: _music_control_consumer_control_print_msg_type(105) > [33m[TID:1042]   msg [WMC_SERVICE_WIPC_MSG_ID_QUEUE_CHANGED_IND][0m
04-11 11:26:09.260+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: music_control_consumer_msg_process(243) > [36m[TID:1042]   [MUSIC_PLAYER_EVENT]Device State [2] normal:0 dim:1 off:2[0m
04-11 11:26:09.260+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: music_control_consumer_media_changed_ind_request(199) > [33m[TID:1042]   remote mode[1],resume[0][0m
04-11 11:26:09.260+0200 W/MC_CONSUMER( 1042): wmc-service-consumer.c: __wmc_on_data_ind(386) > [33m length : [81][{"msgId":"music-playstatechange-rsp","result":"success","reason":0,"playstate":2}][0m
04-11 11:26:09.265+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: _music_control_consumer_control_print_msg_type(105) > [33m[TID:1042]   msg [WMC_SERVICE_WIPC_MSG_ID_PLAY_STATE_CHANGE_RESPONSE][0m
04-11 11:26:09.265+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: music_control_consumer_msg_process(243) > [36m[TID:1042]   [MUSIC_PLAYER_EVENT]Device State [2] normal:0 dim:1 off:2[0m
04-11 11:26:09.265+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: music_control_consumer_media_changed_ind_request(199) > [33m[TID:1042]   remote mode[1],resume[0][0m
04-11 11:26:09.265+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: music_control_consumer_msg_process(393) > [33m[TID:1042]   player state = 2[0m
04-11 11:26:09.265+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-info.c: music_control_info_set_player_state(423) > [33m[TID:1042]   mode = [1], player state = [0][0m
04-11 11:26:09.265+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-media-controller.c: music_control_media_controller_set_playback_state(74) > [33m[TID:1042]   state[2], 1:playing[0m
04-11 11:26:09.265+0200 W/CAPI_MEDIA_CONTROLLER( 1042): media_controller_server.c: mc_server_set_playback_state(284) > [0m<Enter>
04-11 11:26:09.265+0200 W/CAPI_MEDIA_CONTROLLER( 1042): media_controller_server.c: mc_server_set_playback_state(290) > [0mplayback state update [2]
04-11 11:26:09.265+0200 W/CAPI_MEDIA_CONTROLLER( 1042): media_controller_server.c: mc_server_set_playback_state(295) > [0m<Leave>
04-11 11:26:09.270+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-media-controller.c: music_control_media_controller_update_playback_info(138) > [36m[TID:1042]   [MUSIC_PLAYER_EVENT]update playback info[0m
04-11 11:26:09.270+0200 W/CAPI_MEDIA_CONTROLLER( 1042): media_controller_server.c: mc_server_update_playback_info(326) > [0m<Enter>
04-11 11:26:09.270+0200 W/CAPI_MEDIA_CONTROLLER( 1042): media_controller_server.c: mc_server_update_playback_info(331) > [0mplayback info update: state [2], position [0]
04-11 11:26:09.275+0200 W/CAPI_MEDIA_CONTROLLER( 1042): media_controller_server.c: mc_server_update_playback_info(353) > [0m<Leave>
04-11 11:26:09.275+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-message.c: music_control_message_send_player_state_changed_ind(255) > [36m[TID:1042]   [MUSIC_PLAYER_EVENT][0m
04-11 11:26:09.275+0200 W/W_INDICATOR(  765): windicator_ongoing_info_music.c: _player_playback_updated_cb(134) > [_player_playback_updated_cb:134] Playback is updated. [com.samsung.w-music-player.music-control-service][2]
04-11 11:26:09.280+0200 W/MC_CONSUMER( 1042): wmc-service-consumer.c: __wmc_on_data_ind(386) > [33m length : [37][{"msgId":"music-queue-rsp","count":0}][0m
04-11 11:26:09.285+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: _music_control_consumer_control_print_msg_type(105) > [33m[TID:1042]   msg [WMC_SERVICE_WIPC_MSG_ID_QUEUE_RSP][0m
04-11 11:26:09.285+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: music_control_consumer_msg_process(243) > [36m[TID:1042]   [MUSIC_PLAYER_EVENT]Device State [2] normal:0 dim:1 off:2[0m
04-11 11:26:09.285+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: music_control_consumer_media_changed_ind_request(199) > [33m[TID:1042]   remote mode[1],resume[0][0m
04-11 11:26:09.285+0200 W/MC_CONSUMER( 1042): wmc-service-consumer.c: __wmc_on_data_ind(386) > [33m length : [129][{"msgId":"music-getattribute-rsp","result":"failure","reason":0,"repeat":"repeatoff","shuffle":"off","volume":13,"earjack":false}][0m
04-11 11:26:09.290+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: _music_control_consumer_control_print_msg_type(105) > [33m[TID:1042]   msg [WMC_SERVICE_WIPC_MSG_ID_GET_ATTRIBUTE_RESPONSE][0m
04-11 11:26:09.290+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: music_control_consumer_msg_process(243) > [36m[TID:1042]   [MUSIC_PLAYER_EVENT]Device State [2] normal:0 dim:1 off:2[0m
04-11 11:26:09.290+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: music_control_consumer_media_changed_ind_request(199) > [33m[TID:1042]   remote mode[1],resume[0][0m
04-11 11:26:09.290+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: music_control_consumer_msg_process(330) > [33m[TID:1042]   volume = 13, earjack = 0[0m
04-11 11:26:09.290+0200 W/MC_CONSUMER( 1042): wmc-service-consumer.c: __wmc_on_data_ind(386) > [33m length : [64][{"msgId":"music-mediachanged-rsp","result":"success","reason":0}][0m
04-11 11:26:09.295+0200 E/CAPI_APPFW_APP_CONTROL(26029): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : failed to retrieve the appid of the caller
04-11 11:26:09.295+0200 W/CAPI_APPFW_APP_CONTROL(26029): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-11 11:26:09.295+0200 W/CAPI_APPFW_APP_CONTROL(26029): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-11 11:26:09.295+0200 E/CAPI_APPFW_APP_CONTROL(26029): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : failed to retrieve the appid of the caller
04-11 11:26:09.395+0200 E/CONTACTS_CONSUMER(26034): ct-sap-svc-client.c: __ct_sap_svc_client_find_peer_agent(1180) > [0;31m* Critical * connectivity_type 0[0;m
04-11 11:26:09.510+0200 E/weather-consumer(26043): WeatherConsumerController.cpp: OnAppcessoryProtocolDataReceived(110) > [0;40;31mOnAppcessoryProtocolDataReceived[0;m
04-11 11:26:09.555+0200 I/SleepAsAndroidConsumer(26068): agent is initialized
04-11 11:26:09.555+0200 D/SleepAsAndroidConsumer(26068): find peer called
04-11 11:26:09.560+0200 I/SleepAsAndroidConsumer(26068): agent initialized callback is over
04-11 11:26:09.560+0200 D/SleepAsAndroidConsumer(26068): SAP >>> getRegisteredServiceAgent() >>> 0
04-11 11:26:09.575+0200 E/CONTACTS_CONSUMER(26034): ct-sap-svc-client.c: ct_sap_svc_client_mem_info(3594) > [0;31m* Critical * Total allocated space (uordblks):135728
04-11 11:26:09.575+0200 E/CONTACTS_CONSUMER(26034): [0;m
04-11 11:26:09.575+0200 W/CAPI_APPFW_APP_CONTROL(26034): app_control.c: app_control_error(136) > [app_control_get_extra_data_array] KEY_NOT_FOUND(0xffffff82)
04-11 11:26:09.575+0200 W/CAPI_APPFW_APP_CONTROL(26034): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-11 11:26:09.575+0200 W/CAPI_APPFW_APP_CONTROL(26034): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-11 11:26:09.695+0200 E/weather-consumer(26043): SAP.cpp: TerminateServiceConnection(260) > [0;40;31mServiceConnection is not exist [0][0;m
04-11 11:26:09.700+0200 E/weather-consumer(26043): WeatherConsumerController.cpp: OnAppcessoryProtocolDisconnected(141) > [0;40;31mOnAppcessoryProtocolDisconnected[0;m
04-11 11:26:09.700+0200 E/weather-consumer(26043): SAP.cpp: TerminateServiceConnection(260) > [0;40;31mServiceConnection is not exist [0][0;m
04-11 11:26:09.700+0200 E/weather-consumer(26043): WeatherConsumerController.cpp: Close(91) > [0;40;31mservice_app_exit[0;m
04-11 11:26:09.700+0200 I/CAPI_APPFW_APPLICATION(26043): service_app_main.c: service_app_exit(441) > service_app_exit
04-11 11:26:09.705+0200 D/SleepAsAndroidConsumer(26068): find peer call succeeded
04-11 11:26:09.710+0200 D/SleepAsAndroidConsumer(26068): find peer call is over
04-11 11:26:09.715+0200 I/SleepAsAndroidConsumer(26068): Find Peer Success!!
04-11 11:26:09.715+0200 D/SleepAsAndroidConsumer(26068): request_service_connection call over
04-11 11:26:09.720+0200 E/weather-consumer(26043): WeatherConsumerController.cpp: Close(88) > [0;40;31m[Close(): 88] (!mAppcessoryProtocolPtr) [return][0;m
04-11 11:26:09.725+0200 W/AUL_AMD (  514): amd_request.c: __request_handler(669) > __request_handler: 22
04-11 11:26:09.725+0200 W/AUL_AMD (  514): amd_request.c: __request_handler(999) > app status : 4
04-11 11:26:09.745+0200 D/SleepAsAndroidConsumer(26068): req service conn call succeeded
04-11 11:26:09.765+0200 W/MM_CAMCORDER(26011): mm_camcorder_internal.c: _mmcamcorder_constructor(203) >  start
04-11 11:26:09.765+0200 W/MM_CAMCORDER(26011): mm_camcorder_internal.c: _mmcamcorder_constructor(213) >  done
04-11 11:26:09.775+0200 I/efl-extension(26011): efl_extension.c: eext_mod_init(40) > Init
04-11 11:26:09.825+0200 W/CONTACTS_CONSUMER(26034): ct-sap-svc-client.c: __on_create(2490) > [0;35mis_connected_by_scs 0[0;m
04-11 11:26:09.830+0200 W/AUL_AMD (  514): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-11 11:26:09.900+0200 I/SleepAsAndroidConsumer(26068): peer agent connection is successful, pa :1124831680
04-11 11:26:09.940+0200 E/CAPI_APPFW_APPLICATION_ALARM(26029): alarm.c: convert_error_code_to_alarm(77) > [alarm_cancel] INVALID_PARAMETER(0xffffffea)
04-11 11:26:09.950+0200 E/CONTACTS_CONSUMER(26034): ct-sap-svc-client.c: ct_sap_svc_client_mem_info(3594) > [0;31m* Critical * Total allocated space (uordblks):135424
04-11 11:26:09.950+0200 E/CONTACTS_CONSUMER(26034): [0;m
04-11 11:26:09.995+0200 W/AUL     (26096): daemon-manager-release-agent.c: main(12) > release agent : [2:/com.samsung.weather-consumer]
04-11 11:26:09.995+0200 W/AUL_AMD (  514): amd_request.c: __request_handler(669) > __request_handler: 23
04-11 11:26:09.995+0200 W/AUL_AMD (  514): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-11 11:26:09.995+0200 W/AUL_AMD (  514): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 26043
04-11 11:26:09.995+0200 W/AUL_AMD (  514): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-11 11:26:10.010+0200 I/AUL_AMD (  514): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 26043
04-11 11:26:10.010+0200 W/AUL     (  514): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(26043)
04-11 11:26:10.065+0200 I/WSM     (  520): WSM_I [d1]
04-11 11:26:10.115+0200 E/CONTACTS_CONSUMER(26034): ct-sap-svc-client.c: __on_receive(1779) > [0;31m* Critical * crypt_key for encrypt version !!![0;m
04-11 11:26:10.215+0200 W/AUL     (26100): daemon-manager-release-agent.c: main(12) > release agent : [2:/com.urbandroid.sleep.service]
04-11 11:26:10.220+0200 W/AUL_AMD (  514): amd_request.c: __request_handler(669) > __request_handler: 23
04-11 11:26:10.220+0200 W/AUL_AMD (  514): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-11 11:26:10.220+0200 W/AUL_AMD (  514): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 26068
04-11 11:26:10.220+0200 W/AUL_AMD (  514): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-11 11:26:10.225+0200 W/CRASH_MANAGER(26097): worker.c: worker_job(1205) > 1126068736c65152343876
