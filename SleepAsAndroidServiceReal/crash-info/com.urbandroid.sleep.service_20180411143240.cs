S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.2.7
Build-Number: R732XXU2FRC1
Build-Date: 2018.03.02 17:21:30

Crash Information
Process Name: sleepasandroidnativeservice
PID: 1967
Date: 2018-04-11 14:32:40+0200
Executable File Path: /opt/usr/apps/com.urbandroid.sleep/bin/sleepasandroidnativeservice
Signal: 6
      (SIGABRT)
      si_code: -6
      signal sent by tkill (sent by pid 1967, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x000007af
r2   = 0x00000006, r3   = 0x000007af
r4   = 0x00000006, r5   = 0x00000002
r6   = 0x404f9bec, r7   = 0x0000010c
r8   = 0x00000038, r9   = 0x00000002
r10  = 0xbef45750, fp   = 0xbef45d68
ip   = 0x43096fe0, sp   = 0xbef45630
lr   = 0x403fb328, pc   = 0x403f7668
cpsr = 0x20000010

Memory Information
MemTotal:   491132 KB
MemFree:      4208 KB
Buffers:     19596 KB
Cached:     157464 KB
VmPeak:      61328 KB
VmSize:      61324 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        8780 KB
VmRSS:        8780 KB
VmData:      12296 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       19584 KB
VmPTE:          32 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 1967 TID = 1967
1967 1983 

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
4319a000 43a00000 rw-p [stack:1983]
bef26000 bef47000 rw-p [stack]
End of Maps Information

Callstack Information (PID:1967)
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
) > failed to get value VCONFKEY_RETAILMODE_ENABLED
04-11 14:32:38.785+0200 W/W_HOME  (  799): clock_event.c: _wmanager_connectivity_get(397) > network status : 0
04-11 14:32:38.785+0200 W/W_HOME  (  799): clock_event.c: _wmanager_connectivity_get(402) > sap_connected : 1
04-11 14:32:38.785+0200 W/W_HOME  (  799): clock_event.c: _wmanager_connectivity_get(408) > sap connectivity type : 1
04-11 14:32:38.785+0200 W/W_HOME  (  799): clock_event.c: _wmanager_connectivity_get(414) > network status : 3
04-11 14:32:38.785+0200 W/W_HOME  (  799): clock_event.c: _wmanager_connectivity_get(428) > scs login : 0
04-11 14:32:38.785+0200 W/W_HOME  (  799): clock_event.c: _wmanager_connectivity_get(470) > connected via bluetooth
04-11 14:32:38.785+0200 W/W_HOME  (  799): clock_view_indicator.c: _view_remove_by_type(267) > removed:4
04-11 14:32:38.785+0200 W/W_HOME  (  799): clock_indicator.c: clock_indicator_pop(374) > icon:5(0) is popped from clock indicator
04-11 14:32:38.785+0200 W/wnotib  (  799): w-notification-board-broker-main.c: _wnb_connection_state_changed_cb(379) > is_LO: 0, is_connected: 1
04-11 14:32:38.785+0200 E/wnotib  (  799): w-notification-board-noti-manager-common.c: wnb_nm_get_category_by_application_id(1201) > No category matched.
04-11 14:32:38.785+0200 W/wnotib  (  799): w-notification-board-broker-main.c: _wnb_connection_state_changed_cb(388) > No tips notification.
04-11 14:32:38.785+0200 W/W_INDICATOR(  736): windicator_dynamic.c: _dynamic_bluetooth_state_changed_cb(1071) > [_dynamic_bluetooth_state_changed_cb:1071] isBTOn : 1
04-11 14:32:38.785+0200 W/W_INDICATOR(  736): windicator_dynamic.c: _dynamic_bluetooth_state_changed_cb(1077) > [_dynamic_bluetooth_state_changed_cb:1077] sap connected : 1
04-11 14:32:38.790+0200 W/W_INDICATOR(  736): windicator_dynamic.c: _dynamic_bluetooth_state_changed_cb(1083) > [_dynamic_bluetooth_state_changed_cb:1083] sap connectivity type : 1
04-11 14:32:38.790+0200 W/W_INDICATOR(  736): windicator_dynamic.c: _dynamic_event_item_pack(870) > [_dynamic_event_item_pack:870] There is NO Headset icon, so move wifi icon to position 1
04-11 14:32:38.790+0200 E/W_INDICATOR(  736): windicator_dynamic.c: _dynamic_bluetooth_state_changed_cb(1097) > [_dynamic_bluetooth_state_changed_cb:1097] Failed to get moment view bt icon
04-11 14:32:38.790+0200 I/W_INDICATOR(  736): windicator.c: windicator_is_lo_connected(976) > [windicator_is_lo_connected:976] Connected target vendor : LGE
04-11 14:32:38.790+0200 W/W_INDICATOR(  736): windicator_dynamic.c: _dynamic_bluetooth_state_changed_cb(1131) > [_dynamic_bluetooth_state_changed_cb:1131] display connected BT icon
04-11 14:32:38.790+0200 E/EFL     (  736): <736> elm_main.c:1622 elm_object_signal_emit() safety check failed: obj == NULL
04-11 14:32:38.790+0200 E/TIZEN_N_SYSTEM_SETTINGS(  736): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-11 14:32:38.790+0200 E/TIZEN_N_SYSTEM_SETTINGS(  736): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-11 14:32:38.790+0200 E/TIZEN_N_SYSTEM_SETTINGS(  736): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=4
04-11 14:32:38.790+0200 E/TIZEN_N_SYSTEM_SETTINGS(  736): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 4, key = 4, type = 0
04-11 14:32:38.790+0200 W/WECONN  (  505): <__wc_feature_wms_connected_cb:453> priv->wms_connected = 1
04-11 14:32:38.795+0200 E/WMS     (  521): wms_event_handler.c: _wms_event_handler_signal_to_systemd(1218) > 
04-11 14:32:38.795+0200 E/WMS     (  521): ==========
04-11 14:32:38.795+0200 E/WMS     (  521): ##WMS WMANAGER CONNECTED : TRUE
04-11 14:32:38.795+0200 E/WMS     (  521): ==========
04-11 14:32:38.795+0200 W/AUL_AMD (  524): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 1731
04-11 14:32:38.795+0200 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 14
04-11 14:32:38.810+0200 W/AUL_AMD (  524): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 1734
04-11 14:32:38.810+0200 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 14
04-11 14:32:38.810+0200 E/WMS     (  521): wms_event_handler.c: handle_mgr_host_status_res(17185) > TIMESTAMP saved: 1523449952943P:?LAL>AC:K:
04-11 14:32:38.810+0200 E/WMS     (  521): wms_event_handler.c: wms_event_handler_routine(24535) > [mgr_host_status_res] handler success.
04-11 14:32:38.820+0200 W/AUL_AMD (  524): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
04-11 14:32:38.820+0200 W/AUL     (  519): launch.c: app_request_to_launchpad(284) > request cmd(26) to(com.samsung.samsung-pay-app-service)
04-11 14:32:38.825+0200 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 26
04-11 14:32:38.825+0200 W/AUL     (  519): launch.c: app_request_to_launchpad(298) > request cmd(26) result(0)
04-11 14:32:38.840+0200 I/AUL_AMD (  524): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/sapd, ret : 0
04-11 14:32:38.855+0200 I/AUL_AMD (  524): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/sapd, ret : 0
04-11 14:32:38.855+0200 E/AUL_AMD (  524): amd_launch.c: _start_app(1772) > no caller appid info, ret: -1
04-11 14:32:38.855+0200 W/AUL_AMD (  524): amd_launch.c: _start_app(1782) > caller pid : 519
04-11 14:32:38.865+0200 W/W_INDICATOR(  736): windicator_scs.c: windicator_scs_update(123) > [windicator_scs_update:123] sales code : 0
04-11 14:32:38.865+0200 W/W_INDICATOR(  736): windicator_scs.c: windicator_scs_update(131) > [windicator_scs_update:131] sap connected : 1
04-11 14:32:38.870+0200 W/W_INDICATOR(  736): windicator_scs.c: windicator_scs_update(146) > [windicator_scs_update:146] ciss_request_type : 0
04-11 14:32:38.870+0200 I/W_INDICATOR(  736): windicator_scs.c: windicator_scs_update(155) > [windicator_scs_update:155] Hide (Callforwarding requested)
04-11 14:32:38.870+0200 I/W_INDICATOR(  736): windicator.c: windicator_is_lo_connected(976) > [windicator_is_lo_connected:976] Connected target vendor : LGE
04-11 14:32:38.870+0200 W/W_INDICATOR(  736): windicator_scs.c: windicator_scs_update(195) > [windicator_scs_update:195] sap connectivity type : 1
04-11 14:32:38.870+0200 W/W_INDICATOR(  736): windicator_scs.c: windicator_scs_update(203) > [windicator_scs_update:203] network status : 3
04-11 14:32:38.870+0200 W/W_INDICATOR(  736): windicator_scs.c: windicator_scs_update(220) > [windicator_scs_update:220] scs login : 0
04-11 14:32:38.870+0200 W/W_INDICATOR(  736): windicator_scs.c: windicator_scs_update(261) > [windicator_scs_update:261] connected via bluetooth
04-11 14:32:38.870+0200 E/CONTACTS_CONSUMER( 1725): ct-sap-svc-main.c: __service_check_vendor_init(138) > [0;31m* Critical * ios_connected:0[0;m
04-11 14:32:38.870+0200 E/CONTACTS_CONSUMER( 1725): ct-sap-svc-client.c: ct_sap_svc_client_init(4449) > [0;31m* Critical * contacts_db_add_changed_cb() Failed(-22)[0;m
04-11 14:32:38.885+0200 W/WG-CONSUMER( 1751): [32m[F:SAPProxy.cpp     L:  621][_WARN]_on_wms_connected_changed, value = 1, key = memory/wms/wmanager_connected[0m
04-11 14:32:38.885+0200 W/AUL_AMD (  524): amd_launch.c: start_process(606) > child process: 1999
04-11 14:32:38.890+0200 W/MSG_CONSUMER( 1487): SapClient.cpp: _onWmsConnectionChanged(810) > [0;35mprevious_status: (1), status: (1)[0;m
04-11 14:32:38.895+0200 W/MSG_CONSUMER( 1487): SapClient.cpp: _onWmsConnectionChanged(813) > [0;35m_onWmsConnectionChanged() is ignored for same status change. prev:(1), cur:(1)[0;m
04-11 14:32:38.895+0200 W/WG-CONSUMER( 1751): [34m[F:SAPProxy.cpp     L:  601][_HIGH]Device Connected. Cur type=BT|[0m
04-11 14:32:38.900+0200 E/weather-consumer( 1922): WeatherConsumerController.cpp: Start(73) > [0;40;31mhostDeviceVendor : LGE[0;m
04-11 14:32:38.900+0200 W/WG-CONSUMER( 1751): [34m[F:SAPProxy.cpp     L:  633][_HIGH]WMS status changed. VConf memory/wms/wmanager_connected value=1 BT=1[0m
04-11 14:32:38.900+0200 W/WG-CONSUMER( 1751): [34m[F:SAPProxy.cpp     L:  637][_HIGH]WMS is connected. Try to connection. Connections=2[0m
04-11 14:32:38.905+0200 E/weather-consumer( 1922): SamsungAppcessoryProtocol.cpp: ~SamsungAppcessoryProtocol(61) > [0;40;31mFETCH_REQUEST_TIMEOUT timer removed[0;m
04-11 14:32:38.905+0200 W/WG-CONSUMER( 1751): [34m[F:ConnectionInfo.c L:  190][_HIGH][TX]CConnection::Connect() State:SM_STATE_ESTABLISHED[0m
04-11 14:32:38.905+0200 W/WG-CONSUMER( 1751): [34m[F:SAPProxy.cpp     L:  147][_HIGH]CSAPProxy::Connect. Size=2 pConnection=0x4332bc00[0m
04-11 14:32:38.905+0200 W/WG-CONSUMER( 1751): [34m[F:SAPProxy.cpp     L:  150][_HIGH]  Connection : [TX] LocalAgentID:34360 ServiceHandle:11431[0m
04-11 14:32:38.905+0200 E/weather-consumer( 1922): AppcessoryProtocol.cpp: SetSendMessageType(60) > [0;40;31mSetSendMessageType : 0[0;m
04-11 14:32:38.905+0200 W/WG-CONSUMER( 1751): [34m[F:SAPProxy.cpp     L:  150][_HIGH]  Connection : [RX] LocalAgentID:34361 ServiceHandle:60295[0m
04-11 14:32:38.905+0200 E/WG-CONSUMER( 1751): [31m[F:SAPProxy.cpp     L:  161][ERROR]Duplication connection. not inseterd[0m
04-11 14:32:38.905+0200 E/weather-consumer( 1922): AppcessoryProtocol.cpp: MakeMessageForAndroid(88) > [0;40;31mMakeMessageForAndroid[0;m
04-11 14:32:38.905+0200 E/WG-CONSUMER( 1751): [31m[F:SAPProxy.cpp     L:  165][ERROR]Previous pCurrent(0x43308370) is exist[0m
04-11 14:32:38.910+0200 W/WG-CONSUMER( 1751): [34m[F:SAPProxy.cpp     L:  601][_HIGH]Device Connected. Cur type=BT|[0m
04-11 14:32:38.910+0200 E/weather-consumer( 1922): AppcessoryProtocol.cpp: CreateCpListText(160) > [0;40;31mCP list supported : "Accuweather","TWC","WeatherNews","cmaweather","Kweather","WCN"[0;m
04-11 14:32:38.910+0200 E/weather-consumer( 1922): AppcessoryProtocol.cpp: MakeMessageForAndroid(140) > [0;40;31mmSendMessage : {"WEATHER_REQUEST":{"FETCH_REQ":1,"SHOW_SETTING_ON_DEVICE":0,"UPDATED_BY_GEAR":0,"CP_LIST":["Accuweather","TWC","WeatherNews","cmaweather","Kweather","WCN"],"ADD_CURRENT_CITY":0},"REVISION":1,"WEATHER_ACK_SEQ": "1523449958"}[0;m
04-11 14:32:38.915+0200 E/weather-consumer( 1922): SamsungAppcessoryProtocol.cpp: Start(97) > [0;40;31mg_timeout_add_seconds mRequestTimer:17[0;m
04-11 14:32:38.915+0200 W/WG-CONSUMER( 1751): [34m[F:SAPProxy.cpp     L:  186][_HIGH]Device connected. WMS=1 BT=1 [0m
04-11 14:32:38.915+0200 W/WG-CONSUMER( 1751): [34m[F:ConnectionInfo.c L:  568][_HIGH][TX]advance. CurState=SM_STATE_ESTABLISHED(8)[0m
04-11 14:32:38.915+0200 W/WG-CONSUMER( 1751): [34m[F:ConnectionInfo.c L:  590][_HIGH]Already established.[0m
04-11 14:32:38.915+0200 W/WG-CONSUMER( 1751): [34m[F:ConnectionInfo.c L:  190][_HIGH][RX]CConnection::Connect() State:SM_STATE_ESTABLISHED[0m
04-11 14:32:38.915+0200 W/WG-CONSUMER( 1751): [34m[F:SAPProxy.cpp     L:  147][_HIGH]CSAPProxy::Connect. Size=2 pConnection=0x43308370[0m
04-11 14:32:38.915+0200 W/WG-CONSUMER( 1751): [34m[F:SAPProxy.cpp     L:  150][_HIGH]  Connection : [TX] LocalAgentID:34360 ServiceHandle:11431[0m
04-11 14:32:38.915+0200 W/WG-CONSUMER( 1751): [34m[F:SAPProxy.cpp     L:  150][_HIGH]  Connection : [RX] LocalAgentID:34361 ServiceHandle:60295[0m
04-11 14:32:38.915+0200 E/WG-CONSUMER( 1751): [31m[F:SAPProxy.cpp     L:  161][ERROR]Duplication connection. not inseterd[0m
04-11 14:32:38.920+0200 E/WG-CONSUMER( 1751): [31m[F:SAPProxy.cpp     L:  165][ERROR]Previous pCurrent(0x4332bc00) is exist[0m
04-11 14:32:38.925+0200 W/WG-CONSUMER( 1751): [34m[F:SAPProxy.cpp     L:  601][_HIGH]Device Connected. Cur type=BT|[0m
04-11 14:32:38.935+0200 W/WG-CONSUMER( 1751): [34m[F:SAPProxy.cpp     L:  186][_HIGH]Device connected. WMS=1 BT=1 [0m
04-11 14:32:38.935+0200 W/WG-CONSUMER( 1751): [34m[F:ConnectionInfo.c L:  568][_HIGH][RX]advance. CurState=SM_STATE_ESTABLISHED(8)[0m
04-11 14:32:38.935+0200 W/AUL_AMD (  524): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 1999
04-11 14:32:38.935+0200 W/AUL     (  524): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(com.samsung.samsung-pay-app-service) pid(1999) type(svcapp) bg(0)
04-11 14:32:38.940+0200 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 14
04-11 14:32:38.950+0200 W/AUL_AMD (  524): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
04-11 14:32:38.950+0200 W/AUL     (  519): launch.c: app_request_to_launchpad(284) > request cmd(26) to(com.samsung.w-calendar2-consumer)
04-11 14:32:38.950+0200 W/AUL     (  519): launch.c: app_request_to_launchpad(298) > request cmd(26) result(0)
04-11 14:32:38.950+0200 E/RESOURCED(  608): block.c: block_prelaunch_state(138) > insert data com.samsung.samsung-pay-app, table num : 4
04-11 14:32:38.955+0200 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 26
04-11 14:32:38.960+0200 W/STARTER (  735): pkg-monitor.c: _app_mgr_status_cb(400) > [_app_mgr_status_cb:400] Launch request [1999]
04-11 14:32:38.970+0200 I/AUL_AMD (  524): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/sapd, ret : 0
04-11 14:32:38.985+0200 I/AUL_AMD (  524): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/sapd, ret : 0
04-11 14:32:38.985+0200 E/AUL_AMD (  524): amd_launch.c: _start_app(1772) > no caller appid info, ret: -1
04-11 14:32:38.985+0200 W/AUL_AMD (  524): amd_launch.c: _start_app(1782) > caller pid : 519
04-11 14:32:39.000+0200 W/AUL_AMD (  524): amd_launch.c: start_process(606) > child process: 2004
04-11 14:32:39.005+0200 W/WG-CONSUMER( 1751): [34m[F:ConnectionInfo.c L:  590][_HIGH]Already established.[0m
04-11 14:32:39.055+0200 W/AUL_AMD (  524): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 2004
04-11 14:32:39.055+0200 W/AUL     (  524): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(com.samsung.w-calendar2-consumer) pid(2004) type(svcapp) bg(0)
04-11 14:32:39.055+0200 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 14
04-11 14:32:39.065+0200 W/AUL_AMD (  524): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 1725
04-11 14:32:39.065+0200 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 14
04-11 14:32:39.080+0200 W/AUL_AMD (  524): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 1999
04-11 14:32:39.080+0200 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 14
04-11 14:32:39.090+0200 W/AUL_AMD (  524): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 1751
04-11 14:32:39.090+0200 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 12
04-11 14:32:39.095+0200 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 14
04-11 14:32:39.105+0200 W/AUL_AMD (  524): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 1100
04-11 14:32:39.105+0200 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 14
04-11 14:32:39.120+0200 W/AUL_AMD (  524): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 1755
04-11 14:32:39.120+0200 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 14
04-11 14:32:39.130+0200 W/AUL_AMD (  524): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 1758
04-11 14:32:39.135+0200 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 14
04-11 14:32:39.145+0200 W/AUL_AMD (  524): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 1922
04-11 14:32:39.165+0200 W/STARTER (  735): pkg-monitor.c: _app_mgr_status_cb(400) > [_app_mgr_status_cb:400] Launch request [2004]
04-11 14:32:39.180+0200 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 14
04-11 14:32:39.190+0200 W/AUL_AMD (  524): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 2004
04-11 14:32:39.190+0200 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 12
04-11 14:32:39.230+0200 E/WMS     (  521): wms_msg_broker.c: on_broker_buffer_send(307) > Data sending is success.
04-11 14:32:39.325+0200 E/WMS     (  521): wms_msg_broker.c: on_broker_buffer_send(307) > Data sending is success.
04-11 14:32:39.385+0200 E/CONTACTS_CONSUMER( 1725): ct-sap-svc-client.c: __ct_sap_svc_client_push_queue(400) > [0;31m* Critical * samsung_log_manager_insert - err:0 feature : CC01 extra: CONTACTS_FILE_RECEIVED[0;m
04-11 14:32:39.390+0200 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 14
04-11 14:32:39.405+0200 W/AUL_AMD (  524): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 1999
04-11 14:32:39.405+0200 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 12
04-11 14:32:39.410+0200 D/SleepAsAndroidConsumer( 1967): find peer call succeeded
04-11 14:32:39.410+0200 D/SleepAsAndroidConsumer( 1967): find peer call is over
04-11 14:32:39.435+0200 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 14
04-11 14:32:39.445+0200 W/AUL_AMD (  524): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 2004
04-11 14:32:39.445+0200 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 12
04-11 14:32:39.475+0200 W/MC_CONSUMER( 1100): wmc-service-consumer.c: wmc_service_consumer_send_data(613) > [33m recover service connection[0m
04-11 14:32:39.490+0200 E/CONTACTS_CONSUMER( 1725): ct-sap-svc-client.c: __ct_sap_svc_client_push_queue(395) > [0;31m* Critical * samsung_log_manager_insert - err:0 feature : CC01 extra: LOGS_FILE_RECEIVED[0;m
04-11 14:32:39.505+0200 E/CONTACTS_CONSUMER( 1725): ct-sap-svc-client.c: __ct_sap_svc_client_intialize_sap_connection(418) > [0;31m* Critical * consumer is alreay initialized[0;m
04-11 14:32:39.540+0200 W/MUSIC_PLAYER( 1100): mp-weconn.c: mp_weconn_is_bt_and_wms_connected(44) > [33m[TID:1100]   W_SERVICE_TYPE_BT[3][0m
04-11 14:32:39.545+0200 E/CONTACTS_CONSUMER( 1725): ct-sap-svc-client.c: __ct_sap_svc_decrypt_data(683) > [0;31m* Critical * EVP_CipherInit_ex - err:1[0;m
04-11 14:32:39.560+0200 E/CONTACTS_CONSUMER( 1725): ct-sap-svc-client.c: ct_sap_svc_client_mem_info(3594) > [0;31m* Critical * Total allocated space (uordblks):230312
04-11 14:32:39.560+0200 E/CONTACTS_CONSUMER( 1725): [0;m
04-11 14:32:39.570+0200 W/MUSIC_PLAYER( 1100): mp-weconn.c: mp_weconn_is_bt_and_wms_connected(56) > [33m[TID:1100]   bt[3], wms[1][0m
04-11 14:32:39.575+0200 I/SleepAsAndroidConsumer( 1967): Find Peer Success!!
04-11 14:32:39.595+0200 D/SleepAsAndroidConsumer( 1967): request_service_connection call over
04-11 14:32:39.605+0200 D/SleepAsAndroidConsumer( 1967): req service conn call succeeded
04-11 14:32:39.630+0200 W/CONTACTS_CONSUMER( 1725): ct-sap-svc-parser-logs.c: __ct_sap_svc_parser_logs_parse_json_array(481) > [0;35m[PARSER] parser_db_operation_e = 0[0;m
04-11 14:32:39.630+0200 W/CONTACTS_CONSUMER( 1725): ct-sap-svc-parser-logs.c: __ct_sap_svc_parser_logs_parse_json_array(482) > [0;35m[PARSER] single_contact_info array_count = 1[0;m
04-11 14:32:39.720+0200 W/CONTACTS_CONSUMER( 1725): ct-sap-svc-parser-logs.c: __ct_sap_svc_parser_logs_parse_json_array(580) > [0;35moperation completed.(inserted:1, updated:0, deleted:0, result:0)[0;m
04-11 14:32:39.720+0200 E/CONTACTS_CONSUMER( 1725): ct-sap-svc-parser-logs.c: __ct_sap_svc_parser_logs_parse_json_array(584) > [0;31m* Critical * samsung_log_manager_insert - err:0 feature : CC02 extra: LOGS_OPERATION_0[0;m
04-11 14:32:39.730+0200 W/CONTACTS_CONSUMER( 1725): ct-sap-svc-client.c: __ct_sap_svc_client_sync_deleted_logs(1248) > [0;35mnothing to upload[0;m
04-11 14:32:39.730+0200 W/CONTACTS_CONSUMER( 1725): ct-sap-svc-client.c: __ct_sap_svc_client_set_logs_sync_status(1220) > [0;35mlogs_sync_status on reconnection: (2) -> (3)[0;m
04-11 14:32:39.730+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1725): preference.c: _preference_check_retry_err(507) > key(calllog-markasread-pending), check retry err: -21/(2/No such file or directory).
04-11 14:32:39.730+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1725): preference.c: _preference_get_key(1101) > _preference_get_key(calllog-markasread-pending) step(-17825744) failed(2 / No such file or directory)
04-11 14:32:39.735+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1725): preference.c: preference_get_boolean(1173) > preference_get_boolean(1725) : calllog-markasread-pending error
04-11 14:32:39.735+0200 W/CONTACTS_CONSUMER( 1725): ct-sap-svc-client.c: __ct_sap_svc_client_sync_noti_clear_on_host(325) > [0;35msynced already.[0;m
04-11 14:32:39.735+0200 E/CONTACTS_CONSUMER( 1725): ct-sap-svc-client.c: __ct_sap_svc_client_read_file(888) > [0;31m* Critical * __ct_sap_svc_client_pop_queue - file_name : SALogsJSONFile1523449957744_REQUEST.zip[0;m
04-11 14:32:39.735+0200 E/CONTACTS_CONSUMER( 1725): ct-sap-svc-client.c: __ct_sap_svc_client_read_file(889) > [0;31m* Critical * Contacts Queue : remained 1[0;m
04-11 14:32:39.735+0200 E/CONTACTS_CONSUMER( 1725): ct-sap-svc-client.c: __ct_sap_svc_client_read_file(890) > [0;31m* Critical * Logs Queue : remained 0[0;m
04-11 14:32:39.760+0200 I/SleepAsAndroidConsumer( 1967): peer agent connection is successful, pa :1124782488
04-11 14:32:39.800+0200 I/SleepAsAndroidConsumer( 1967): Sending data Version 1.0.9
04-11 14:32:39.805+0200 W/MC_CONSUMER( 1100): wmc-service-consumer.c: __wmc_find_peer_agent(195) > [33m findPeerAgent[0][0m
04-11 14:32:39.805+0200 E/MC_CONSUMER( 1100): wmc-service-cotroller.c: wmc_service_controller_set_media_changed_request(321) > [31m wmc_service_consumer_send_data failed : [-4]!!![0m
04-11 14:32:39.805+0200 W/MUSIC_CONTROL_SERVICE( 1100): music-control-consumer-control.c: music_control_consumer_media_changed_ind_request(224) > [31m[TID:1100]   wmc_service_controller_set_media_changed_request() .. [0][0m
04-11 14:32:39.805+0200 W/MC_CONSUMER( 1100): wmc-service-consumer.c: wmc_service_consumer_send_data(589) > [33m Unable to send data [1][0m
04-11 14:32:39.850+0200 E/CONTACTS_CONSUMER( 1725): ct-sap-svc-client.c: __ct_sap_svc_client_find_peer_agent(1180) > [0;31m* Critical * connectivity_type 1[0;m
04-11 14:32:39.870+0200 W/MUSIC_PLAYER( 1100): mp-weconn.c: mp_weconn_is_bt_and_wms_connected(44) > [33m[TID:1100]   W_SERVICE_TYPE_BT[3][0m
04-11 14:32:39.875+0200 W/MUSIC_PLAYER( 1100): mp-weconn.c: mp_weconn_is_bt_and_wms_connected(56) > [33m[TID:1100]   bt[3], wms[1][0m
04-11 14:32:39.875+0200 W/MC_CONSUMER( 1100): wmc-service-consumer.c: __wmc_find_peer_agent(180) > [33m Already finding peer[0m
04-11 14:32:39.875+0200 E/MC_CONSUMER( 1100): wmc-service-cotroller.c: wmc_service_controller_queue_request(800) > [31m wmc_service_consumer_send_data failed : [-4]!!![0m
04-11 14:32:39.875+0200 W/MC_CONSUMER( 1100): wmc-service-consumer.c: wmc_service_consumer_send_data(589) > [33m Unable to send data [1][0m
04-11 14:32:39.885+0200 W/MUSIC_PLAYER( 1100): mp-weconn.c: mp_weconn_is_bt_and_wms_connected(44) > [33m[TID:1100]   W_SERVICE_TYPE_BT[3][0m
04-11 14:32:39.885+0200 W/MUSIC_PLAYER( 1100): mp-weconn.c: mp_weconn_is_bt_and_wms_connected(56) > [33m[TID:1100]   bt[3], wms[1][0m
04-11 14:32:39.885+0200 W/MC_CONSUMER( 1100): wmc-service-consumer.c: __wmc_find_peer_agent(180) > [33m Already finding peer[0m
04-11 14:32:39.885+0200 E/MC_CONSUMER( 1100): wmc-service-cotroller.c: wmc_service_controller_get_attribute_request(200) > [31m wmc_service_consumer_send_data failed : [-4]!!![0m
04-11 14:32:39.885+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-11 14:32:39.885+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-11 14:32:39.885+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-11 14:32:39.885+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-11 14:32:39.885+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-11 14:32:39.885+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-11 14:32:39.885+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.widget:music-control-service-message-port]
04-11 14:32:39.885+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-11 14:32:39.890+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-11 14:32:39.890+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-11 14:32:39.890+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-11 14:32:39.890+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-11 14:32:39.895+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-11 14:32:39.895+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-11 14:32:39.895+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.widget:music-control-service-message-port]
04-11 14:32:39.895+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-11 14:32:39.895+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-11 14:32:39.895+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-11 14:32:39.895+0200 W/MC_CONSUMER( 1100): wmc-service-consumer.c: wmc_service_consumer_send_data(589) > [33m Unable to send data [1][0m
04-11 14:32:39.905+0200 E/weather-consumer( 1922): SamsungAppcessoryProtocol.cpp: FetchRequestTimeoutCb(74) > [0;40;31mwe wait a second but send message type still remained as MESSAGE_FET_REQUEST. so we need fetch request[0;m
04-11 14:32:39.905+0200 E/weather-agent( 1764): AgentMain.cpp: TerminateService(97) > [0;40;31mTerminateService[0;m
04-11 14:32:39.910+0200 I/CAPI_APPFW_APPLICATION( 1764): service_app_main.c: service_app_exit(441) > service_app_exit
04-11 14:32:39.910+0200 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 22
04-11 14:32:39.910+0200 E/weather-agent( 1764): AgentMain.cpp: AppTerminate(283) > [0;40;31mAppTerminate[0;m
04-11 14:32:39.910+0200 W/AUL_AMD (  524): amd_request.c: __request_handler(999) > app status : 4
04-11 14:32:39.975+0200 E/PKGMGR_SERVER( 1991): pkgmgr-server.c: exit_server(1620) > exit_server Start [backend_status=1, queue_status=1] 
04-11 14:32:39.975+0200 E/PKGMGR_SERVER( 1991): pkgmgr-server.c: main(2296) > package manager server terminated.
04-11 14:32:39.990+0200 W/LIVE_MUSIC_PLAYER(  990): dbox-mp-main.c: _widget_mp_instance_update(2237) > [36m[TID:990]   [MUSIC_PLAYER_EVENT]update_type = [32][0m
04-11 14:32:39.990+0200 W/LIVE_MUSIC_PLAYER(  990): dbox-mp-main.c: _widget_mp_main_update_control_button_disabled_state(182) > [33m[TID:990]   mode[1] disalbe state [0][0m
04-11 14:32:40.040+0200 W/MUSIC_PLAYER( 1100): mp-weconn.c: mp_weconn_is_bt_and_wms_connected(44) > [33m[TID:1100]   W_SERVICE_TYPE_BT[3][0m
04-11 14:32:40.040+0200 W/MUSIC_PLAYER( 1100): mp-weconn.c: mp_weconn_is_bt_and_wms_connected(56) > [33m[TID:1100]   bt[3], wms[1][0m
04-11 14:32:40.040+0200 W/MC_CONSUMER( 1100): wmc-service-consumer.c: __wmc_find_peer_agent(180) > [33m Already finding peer[0m
04-11 14:32:40.040+0200 W/MUSIC_PLAYER( 1100): mp-weconn.c: _wms_connection_vconf_changed_callback(93) > [33m[TID:1100]   [1][0m
04-11 14:32:40.045+0200 W/MC_CONSUMER( 1100): wmc-service-cotroller.c: _bt_connection_changed_cb(60) > [33m connected[1][0m
04-11 14:32:40.090+0200 E/weather-agent( 1764): AgentMain.cpp: AppTerminate(287) > [0;40;31mdevice_power_release_lock success[0;m
04-11 14:32:40.125+0200 E/CONTACTS_CONSUMER( 1725): ct-sap-svc-client.c: __ct_sap_svc_delete_file(547) > [0;31m* Critical * unlink() Failed(-1)[0;m
04-11 14:32:40.125+0200 E/CONTACTS_CONSUMER( 1725): ct-sap-svc-client.c: __ct_sap_svc_client_read_file(900) > [0;31m* Critical * No file or No directory /opt/usr/apps/com.samsung.w-contacts2/shared/data/SALogsJSONFile1523449957744_REQUEST.dat[0;m
04-11 14:32:40.125+0200 E/CONTACTS_CONSUMER( 1725): ct-sap-svc-client.c: __ct_sap_svc_client_read_file(888) > [0;31m* Critical * __ct_sap_svc_client_pop_queue - file_name : SAContactJSONFile1523442978453.zip[0;m
04-11 14:32:40.125+0200 E/CONTACTS_CONSUMER( 1725): ct-sap-svc-client.c: __ct_sap_svc_client_read_file(889) > [0;31m* Critical * Contacts Queue : remained 0[0;m
04-11 14:32:40.125+0200 E/CONTACTS_CONSUMER( 1725): ct-sap-svc-client.c: __ct_sap_svc_client_read_file(890) > [0;31m* Critical * Logs Queue : remained 0[0;m
04-11 14:32:40.205+0200 I/efl-extension( 2004): efl_extension.c: eext_mod_init(40) > Init
04-11 14:32:40.220+0200 E/CONTACTS_CONSUMER( 1725): ct-sap-svc-client.c: __ct_sap_svc_decrypt_data(683) > [0;31m* Critical * EVP_CipherInit_ex - err:1[0;m
04-11 14:32:40.225+0200 E/CONTACTS_CONSUMER( 1725): ct-sap-svc-client.c: __ct_sap_svc_client_log_db_noti_changed_cb_for_notification_update(1273) > [0;31m* Critical * current log_sync_status : 2 (SYNC_NONE: 0, SYNC_SUCCESS:2, SYNC_SHOWN:3)[0;m
04-11 14:32:40.230+0200 W/AUL_AMD (  524): amd_status.c: __socket_monitor_cb(1277) > (2004) was created
04-11 14:32:40.240+0200 W/SHealthCommon( 1422): CpuLock.cpp: CheckAndReset(178) > [1;40;33mRELEASE POWER LOCK CPU[0;m
04-11 14:32:40.245+0200 W/MC_CONSUMER( 1100): wmc-service-consumer.c: __wmc_on_peer_agent(281) > [33m find peer agent success[0m
04-11 14:32:40.245+0200 W/MC_CONSUMER( 1100): wmc-service-consumer.c: __wmc_create_service_connection(213) > [33m call create service connection[0m
04-11 14:32:40.260+0200 E/CONTACTS_CONSUMER( 1725): ct-sap-svc-parser-contacts.c: __ct_sap_svc_parser_get_contacts_record_hash_table(2120) > [0;31m* Critical * __hash_table_contacts is EMPTY[0;m
04-11 14:32:40.280+0200 E/CONTACTS_CONSUMER( 1725): ct-sap-svc-parser-contacts.c: __ct_sap_svc_parser_hash_table_lookup(560) > [0;31m* Critical * g_hash_table_insert - contact_id 1208[0;m
04-11 14:32:40.295+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1725): preference.c: _preference_check_retry_err(507) > key(remained_contact_ids), check retry err: -21/(2/No such file or directory).
04-11 14:32:40.300+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1725): preference.c: _preference_get_key(1101) > _preference_get_key(remained_contact_ids) step(-17825744) failed(2 / No such file or directory)
04-11 14:32:40.305+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1725): preference.c: preference_get_string(1258) > preference_get_string(1725) : remained_contact_ids error
04-11 14:32:40.310+0200 E/CONTACTS_CONSUMER( 1725): ct-sap-svc-parser-contacts.c: __ct_sap_svc_parser_parse_contact_object(1573) > [0;31m* Critical * samsung_log_manager_insert - err:0 feature : CC02 extra: CONTACTS_OPERATION_1[0;m
04-11 14:32:40.310+0200 E/CONTACTS_CONSUMER( 1725): ct-sap-svc-parser-contacts.c: __ct_sap_svc_parser_insert_records(1667) > [0;31m* Critical * list_insert is NULL[0;m
04-11 14:32:40.335+0200 E/CONTACTS_CONSUMER( 1725): ct-sap-svc-client.c: __on_ft_send_file(2706) > [0;31m* Critical * call receiveFile(), file receive accept: SAContactJSONFile1523449946934.zip[0;m
04-11 14:32:40.390+0200 E/CAPI_APPFW_APP_CONTROL( 1764): app_control.c: app_control_error(138) > [app_control_destroy] INVALID_PARAMETER(0xffffffea)
04-11 14:32:40.390+0200 E/weather-agent( 1764): AgentMain.cpp: ~AgentMain(77) > [0;40;31mapp_control_destroy failed[0;m
04-11 14:32:40.430+0200 W/CONTACTS_CONSUMER( 1725): ct-sap-svc-client.c: __on_create(2490) > [0;35mis_connected_by_scs 0[0;m
04-11 14:32:40.430+0200 E/CONTACTS_CONSUMER( 1725): ct-sap-svc-client.c: ct_sap_svc_client_mem_info(3594) > [0;31m* Critical * Total allocated space (uordblks):242736
04-11 14:32:40.430+0200 E/CONTACTS_CONSUMER( 1725): [0;m
04-11 14:32:40.485+0200 E/weather-consumer( 1922): SAPNotificationCallback.cpp: OnDataIndication(65) > [0;40;31mOnDataIndication called. payloadLength(30)[0;m
04-11 14:32:40.485+0200 E/weather-consumer( 1922): AppcessoryProtocol.cpp: SetSendMessageType(60) > [0;40;31mSetSendMessageType : 9999[0;m
04-11 14:32:40.485+0200 E/weather-consumer( 1922): AppcessoryProtocol.cpp: SetSendMessageType(79) > [0;40;31m[Error] Wrong MessageType : 9999[0;m
04-11 14:32:40.490+0200 W/SHealthCommon( 1422): TimelineSessionStorage.cpp: OnTriggered(1290) > [1;40;33mlocalStartTime: 1523404800000,000000[0;m
04-11 14:32:40.500+0200 E/weather-common( 1922): JsonUtil.cpp: GetObjectFromNode(95) > [0;40;31m[GetObjectFromNode(): 95] (node == NULL) [return][0;m
04-11 14:32:40.505+0200 E/weather-common( 1922): SAPMessageParser.cpp: ParseSettingInfo(825) > [0;40;31msettingNode is NULL[0;m
04-11 14:32:40.505+0200 E/weather-common( 1922): JsonUtil.cpp: GetArrayFromNode(103) > [0;40;31m[GetArrayFromNode(): 103] (node == NULL) [return][0;m
04-11 14:32:40.505+0200 E/weather-common( 1922): JsonUtil.cpp: GetArrayLength(119) > [0;40;31m[GetArrayLength(): 119] (array == NULL) [return][0;m
04-11 14:32:40.505+0200 E/weather-common( 1922): SAPMessageParser.cpp: ParseWeatherInfo(800) > [0;40;31mweatherNode is NULL[0;m
04-11 14:32:40.505+0200 E/weather-consumer( 1922): SamsungAppcessoryProtocol.cpp: OnAppcessoryProtocolDataReceived(265) > [0;40;31m[OnAppcessoryProtocolDataReceived(): 265] (!sapMessageParser->ParseWeatherInfo()) [break][0;m
04-11 14:32:40.510+0200 E/weather-common( 1922): SAPMessageParser.cpp: ParseAckSeq(849) > [0;40;31mWeatherAckSeq : 1523449958[0;m
04-11 14:32:40.510+0200 W/MC_CONSUMER( 1100): wmc-service-consumer.c: __wmc_on_service_connection_confirm(295) > [33m uwLocalAgentId : [31504], uwServiceHandle : [17553], wResponseCode : [0][0m
04-11 14:32:40.510+0200 W/MUSIC_CONTROL_SERVICE( 1100): music-control-consumer-control.c: _music_control_consumer_control_print_msg_type(105) > [33m[TID:1100]   msg [WMC_SERVICE_WIPC_MSG_ID_CONNECTION_CHANGED][0m
04-11 14:32:40.510+0200 W/MUSIC_CONTROL_SERVICE( 1100): music-control-consumer-control.c: music_control_consumer_msg_process(243) > [36m[TID:1100]   [MUSIC_PLAYER_EVENT]Device State [2] normal:0 dim:1 off:2[0m
04-11 14:32:40.510+0200 W/MUSIC_CONTROL_SERVICE( 1100): music-control-consumer-control.c: music_control_consumer_msg_process(343) > [33m[TID:1100]   connection state = 1[0m
04-11 14:32:40.510+0200 E/weather-consumer( 1922): SamsungAppcessoryProtocol.cpp: OnAppcessoryProtocolDataReceived(420) > [0;40;31mmReceiveWeatherAck : 1523449958[0;m
04-11 14:32:40.510+0200 W/MUSIC_CONTROL_SERVICE( 1100): music-control-consumer-control.c: music_control_consumer_media_changed_ind_request(199) > [33m[TID:1100]   remote mode[1],resume[1][0m
04-11 14:32:40.510+0200 W/MC_CONSUMER( 1100): wmc-service-consumer.c: wmc_service_consumer_send_data(598) > [33m {"msgId":"music-mediachanged-req","value":"true"}[0m
04-11 14:32:40.510+0200 E/weather-consumer( 1922): SamsungAppcessoryProtocol.cpp: OnAppcessoryProtocolDataReceived(462) > [0;40;31mJust Receive AckData.[0;m
04-11 14:32:40.510+0200 E/weather-consumer( 1922): SamsungAppcessoryProtocol.cpp: OnAppcessoryProtocolDataReceived(465) > [0;40;31mWait until receive the data...[0;m
04-11 14:32:40.510+0200 E/weather-consumer( 1922): WeatherConsumerController.cpp: OnAppcessoryProtocolDataReceived(110) > [0;40;31mOnAppcessoryProtocolDataReceived[0;m
04-11 14:32:40.610+0200 E/CONTACTS_CONSUMER( 1725): ct-sap-svc-client.c: __on_ft_receive_complete(3103) > [0;31m* Critical * called __on_ft_receive_complete(), file receive completed: SAContactJSONFile1523449946934.zip.tmp[0;m
04-11 14:32:40.615+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-11 14:32:40.615+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-11 14:32:40.615+0200 E/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: HandleReceivedMessage(588) > Connection closed
04-11 14:32:40.615+0200 E/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: HandleReceivedMessage(610) > All connections of client(1764) are closed. delete client info
04-11 14:32:40.615+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnIpcClientDisconnected(178) > MessagePort Ipc disconnected
04-11 14:32:40.615+0200 E/MESSAGE_PORT(  484): MessagePortStub.cpp: OnIpcClientDisconnected(181) > Unregister - client =  1764
04-11 14:32:40.615+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: UnregisterMessagePortByDiscon(273) > _MessagePortService::UnregisterMessagePortByDiscon
04-11 14:32:40.615+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
04-11 14:32:40.615+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
04-11 14:32:40.615+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
04-11 14:32:40.615+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
04-11 14:32:40.615+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
04-11 14:32:40.615+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
04-11 14:32:40.615+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
04-11 14:32:40.615+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
04-11 14:32:40.615+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
04-11 14:32:40.615+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
04-11 14:32:40.615+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
04-11 14:32:40.615+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
04-11 14:32:40.615+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
04-11 14:32:40.615+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
04-11 14:32:40.615+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
04-11 14:32:40.615+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
04-11 14:32:40.615+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
04-11 14:32:40.615+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
04-11 14:32:40.615+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
04-11 14:32:40.615+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
04-11 14:32:40.615+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
04-11 14:32:40.615+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
04-11 14:32:40.615+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
04-11 14:32:40.615+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
04-11 14:32:40.615+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
04-11 14:32:40.615+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
04-11 14:32:40.615+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
04-11 14:32:40.615+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
04-11 14:32:40.630+0200 E/CONTACTS_CONSUMER( 1725): ct-sap-svc-client.c: __ct_sap_svc_client_push_queue(400) > [0;31m* Critical * samsung_log_manager_insert - err:0 feature : CC01 extra: CONTACTS_FILE_RECEIVED[0;m
04-11 14:32:40.645+0200 W/AUL     ( 2012): daemon-manager-release-agent.c: main(12) > release agent : [2:/com.samsung.weather-agent]
04-11 14:32:40.645+0200 E/CONTACTS_CONSUMER( 1725): ct-sap-svc-client.c: __ct_sap_svc_client_read_file(1024) > [0;31m* Critical * [PERFORMANCE] __ct_sap_svc_client_read_file end[0;m
04-11 14:32:40.645+0200 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 23
04-11 14:32:40.650+0200 W/AUL_AMD (  524): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-11 14:32:40.650+0200 W/AUL_AMD (  524): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 1764
04-11 14:32:40.650+0200 W/AUL_AMD (  524): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-11 14:32:40.655+0200 I/AUL_AMD (  524): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 1764
04-11 14:32:40.655+0200 W/AUL     (  524): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(1764)
04-11 14:32:40.725+0200 W/MC_CONSUMER( 1100): wmc-service-consumer.c: wmc_service_consumer_send_data(598) > [33m {"msgId":"music-queue-req"}[0m
04-11 14:32:40.830+0200 E/CONTACTS_CONSUMER( 1725): ct-sap-svc-client.c: __ct_sap_svc_client_read_file(888) > [0;31m* Critical * __ct_sap_svc_client_pop_queue - file_name : SAContactJSONFile1523449946934.zip[0;m
04-11 14:32:40.830+0200 E/CONTACTS_CONSUMER( 1725): ct-sap-svc-client.c: __ct_sap_svc_client_read_file(889) > [0;31m* Critical * Contacts Queue : remained 0[0;m
04-11 14:32:40.830+0200 E/CONTACTS_CONSUMER( 1725): ct-sap-svc-client.c: __ct_sap_svc_client_read_file(890) > [0;31m* Critical * Logs Queue : remained 0[0;m
04-11 14:32:40.840+0200 W/SHealthCommon( 1422): SHealthMessagePortConnection.cpp: SendServiceMessage(558) > [1;40;33mmessageName: timeline_session_updated, pendingClientInfoList.size(): 0[0;m
04-11 14:32:40.860+0200 W/CAPI_APPFW_APP_CONTROL( 2004): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-11 14:32:40.890+0200 W/MC_CONSUMER( 1100): wmc-service-consumer.c: wmc_service_consumer_send_data(598) > [33m {"msgId":"music-getattribute-req"}[0m
04-11 14:32:40.915+0200 W/CAPI_APPFW_APP_CONTROL( 2004): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-11 14:32:40.915+0200 E/CAPI_APPFW_APP_CONTROL( 2004): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : failed to retrieve the appid of the caller
04-11 14:32:40.940+0200 W/SHealthCommon( 1422): SHealthMessagePortConnection.cpp: SendServiceMessage(558) > [1;40;33mmessageName: timeline_summary_updated, pendingClientInfoList.size(): 0[0;m
04-11 14:32:40.960+0200 W/SHealthServiceCommon( 1422): EnergyExpenditureFeatureController.cpp: OnTotalEnergyExpenditureChanged(119) > [1;40;33mstart 1523397600000,000000, end 1523449960963,000000, calories 1080,807479[0;m
04-11 14:32:40.960+0200 W/SHealthCommon( 1422): SHealthMessagePortConnection.cpp: SendServiceMessage(558) > [1;40;33mmessageName: energy_expenditure_updated, pendingClientInfoList.size(): 0[0;m
04-11 14:32:41.025+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-11 14:32:41.025+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-11 14:32:41.025+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-11 14:32:41.025+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-11 14:32:41.025+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-11 14:32:41.025+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-11 14:32:41.025+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.widget:music-control-service-message-port]
04-11 14:32:41.025+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-11 14:32:41.025+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-11 14:32:41.025+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-11 14:32:41.025+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-11 14:32:41.030+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-11 14:32:41.030+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-11 14:32:41.030+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-11 14:32:41.030+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.widget:music-control-service-message-port]
04-11 14:32:41.030+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-11 14:32:41.030+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-11 14:32:41.030+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-11 14:32:41.030+0200 W/MC_CONSUMER( 1100): wmc-service-consumer.c: wmc_service_consumer_send_data(598) > [33m {"msgId":"capability-feature-ind","distinct-state":"true"}[0m
04-11 14:32:41.095+0200 W/LIVE_MUSIC_PLAYER(  990): dbox-mp-main.c: _widget_mp_instance_update(2237) > [36m[TID:990]   [MUSIC_PLAYER_EVENT]update_type = [32][0m
04-11 14:32:41.095+0200 W/LIVE_MUSIC_PLAYER(  990): dbox-mp-main.c: _widget_mp_main_update_control_button_disabled_state(182) > [33m[TID:990]   mode[1] disalbe state [0][0m
04-11 14:32:41.140+0200 W/MC_CONSUMER( 1100): wmc-service-consumer.c: wmc_service_consumer_send_data(598) > [33m {"msgId":"music-mediachanged-req","value":"true"}[0m
04-11 14:32:41.280+0200 W/MC_CONSUMER( 1100): wmc-service-consumer.c: wmc_service_consumer_send_data(598) > [33m {"msgId":"music-queue-req"}[0m
04-11 14:32:41.295+0200 E/CONTACTS_CONSUMER( 1725): ct-sap-svc-client.c: __ct_sap_svc_unzip(610) > [0;31m* Critical * unzip fail (10)[0;m
04-11 14:32:41.300+0200 E/CONTACTS_CONSUMER( 1725): ct-sap-svc-client.c: __ct_sap_svc_decrypt_data(683) > [0;31m* Critical * EVP_CipherInit_ex - err:1[0;m
04-11 14:32:41.325+0200 E/CONTACTS_CONSUMER( 1725): ct-sap-svc-parser-contacts.c: __ct_sap_svc_parser_get_contacts_record_hash_table(2120) > [0;31m* Critical * __hash_table_contacts is EMPTY[0;m
04-11 14:32:41.345+0200 E/CONTACTS_CONSUMER( 1725): ct-sap-svc-parser-contacts.c: __ct_sap_svc_parser_hash_table_lookup(560) > [0;31m* Critical * g_hash_table_insert - contact_id 1208[0;m
04-11 14:32:41.345+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1725): preference.c: _preference_check_retry_err(507) > key(remained_contact_ids), check retry err: -21/(2/No such file or directory).
04-11 14:32:41.345+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1725): preference.c: _preference_get_key(1101) > _preference_get_key(remained_contact_ids) step(-17825744) failed(2 / No such file or directory)
04-11 14:32:41.350+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1725): preference.c: preference_get_string(1258) > preference_get_string(1725) : remained_contact_ids error
04-11 14:32:41.420+0200 E/CONTACTS_CONSUMER( 1725): ct-sap-svc-parser-contacts.c: __ct_sap_svc_parser_parse_contact_object(1573) > [0;31m* Critical * samsung_log_manager_insert - err:0 feature : CC02 extra: CONTACTS_OPERATION_1[0;m
04-11 14:32:41.420+0200 E/CONTACTS_CONSUMER( 1725): ct-sap-svc-parser-contacts.c: __ct_sap_svc_parser_insert_records(1667) > [0;31m* Critical * list_insert is NULL[0;m
04-11 14:32:41.495+0200 W/MC_CONSUMER( 1100): wmc-service-consumer.c: wmc_service_consumer_send_data(598) > [33m {"msgId":"music-getattribute-req"}[0m
04-11 14:32:41.605+0200 W/CRASH_MANAGER( 1703): worker.c: worker_job(1205) > 0601967736c65152344996
