S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.2.7
Build-Number: R732XXU2FRC1
Build-Date: 2018.03.02 17:21:30

Crash Information
Process Name: sleepasandroidnativeservice
PID: 26326
Date: 2018-04-11 11:27:11+0200
Executable File Path: /opt/usr/apps/com.urbandroid.sleep/bin/sleepasandroidnativeservice
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x1404

Register Information
r0   = 0x43a1e8d0, r1   = 0x43a1692d
r2   = 0x00000000, r3   = 0x43a16928
r4   = 0x00001404, r5   = 0x00000000
r6   = 0x00000000, r7   = 0xbef21eb0
r8   = 0x00008c28, r9   = 0x00008c28
r10  = 0x430acec8, fp   = 0x00000000
ip   = 0x00000000, sp   = 0xbef21df8
lr   = 0x2e302e31, pc   = 0x4005e244
cpsr = 0x60000030

Memory Information
MemTotal:   490112 KB
MemFree:      6020 KB
Buffers:     14296 KB
Cached:     115696 KB
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
PID = 26326 TID = 26326
26326 26336 

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
4319a000 43a00000 rw-p [stack:26336]
bef02000 bef23000 rw-p [stack]
End of Maps Information

Callstack Information (PID:26326)
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
.810+0200 E/WMS     (  522): ==========
04-11 11:27:08.810+0200 E/WMS     (  522): ##WMS RECEIVED : mgr_apps_order_req
04-11 11:27:08.810+0200 E/WMS     (  522): ==========
04-11 11:27:08.810+0200 E/WMS     (  522): wms_event_handler.c: wms_event_handler_routine(24535) > [mgr_apps_order_req] handler success.
04-11 11:27:08.815+0200 W/W_HOME  (  843): wms.c: wms_change_apps_order(72) > Backup
04-11 11:27:08.815+0200 W/APPS    (  843): db.c: apps_db_read_list(621) >  
04-11 11:27:08.865+0200 E/WMS     (  522): wms_event_handler.c: wms_event_handler_routine(24519) > 
04-11 11:27:08.865+0200 E/WMS     (  522): ==========
04-11 11:27:08.865+0200 E/WMS     (  522): ##WMS RECEIVED : mgr_gear_package_status_update_req
04-11 11:27:08.865+0200 E/WMS     (  522): ==========
04-11 11:27:08.865+0200 E/WMS     (  522): wms_event_handler.c: handle_mgr_gear_package_status_update_req(14904) > host_pkgname[com.urbandroid.sleep.addon.generic.samsung], host_pkg_ver[26], minVer[0.0.1], status[installed]
04-11 11:27:08.880+0200 W/W_HOME  (  843): wms.c: wms_change_apps_order(85) > done
04-11 11:27:08.955+0200 I/SleepAsAndroidConsumer(26326): connectivity type(1): bt
04-11 11:27:09.015+0200 W/AUL_AMD (  514): amd_status.c: __socket_monitor_cb(1277) > (26309) was created
04-11 11:27:09.065+0200 I/capability-manager(26339): capability_manager_companion.c: add_companion_package_info(112) > host_package_name=[com.urbandroid.sleep.addon.generic.samsung], host_package_version=[26], gear_package_min_version=[0.0.1]
04-11 11:27:09.065+0200 I/capability-manager(26339): capability_manager_util.c: is_file_exist(120) > File /opt/usr/data/pkgmgr/capability-manager/host_com.urbandroid.sleep.addon.generic.samsung Exists
04-11 11:27:09.065+0200 I/capability-manager(26339): capability_manager_companion.c: add_companion_package_info(132) > update package_info!
04-11 11:27:09.065+0200 I/capability-manager(26339): capability_manager_companion.c: add_companion_package_info(141) > gear_package_min_version is existed.
04-11 11:27:09.065+0200 I/capability-manager(26339): capability_manager_companion.c: add_companion_package_info(146) > package_info=[host_package_name=com.urbandroid.sleep.addon.generic.samsung:host_package_version=26:gear_package_min_version=0.0.1:]
04-11 11:27:09.065+0200 I/capability-manager(26339): capability_manager_signal.c: send_companion_package_add_signal(33) > pkg_id=[com.urbandroid.sleep.addon.generic.samsung]
04-11 11:27:09.115+0200 W/WVMS_SERVER(26304): wvms-server.c: main(107) > [32m service start[0m
04-11 11:27:09.160+0200 W/AUL_AMD (  514): amd_status.c: __socket_monitor_cb(1277) > (26304) was created
04-11 11:27:09.160+0200 E/WMS     (  522): wms_msg_broker.c: wms_msg_broker_send(1826) > 
04-11 11:27:09.160+0200 E/WMS     (  522): ==========
04-11 11:27:09.160+0200 E/WMS     (  522): ##WMS SEND : mgr_gear_package_status_update_res
04-11 11:27:09.160+0200 E/WMS     (  522): ==========
04-11 11:27:09.160+0200 E/WMS     (  522): wms_msg_broker.c: wms_msg_broker_send(1842) > Data size: 86 MAX Buffer Size: 61440
04-11 11:27:09.160+0200 E/WMS     (  522): wms_event_handler.c: wms_event_handler_routine(24535) > [mgr_gear_package_status_update_req] handler success.
04-11 11:27:09.180+0200 W/WVMS_SERVER(26304): wvms-server.c: _service_app_create(33) > [32m [0m
04-11 11:27:09.180+0200 W/WVMS_SERVER(26304): wvms-server.c: _service_app_control(54) > [32m [0m
04-11 11:27:09.190+0200 E/WMS     (  522): wms_event_handler.c: wms_event_handler_routine(24519) > 
04-11 11:27:09.190+0200 E/WMS     (  522): ==========
04-11 11:27:09.190+0200 E/WMS     (  522): ##WMS RECEIVED : mgr_master_app_deeplink_res
04-11 11:27:09.190+0200 E/WMS     (  522): ==========
04-11 11:27:09.190+0200 E/WMS     (  522): wms_event_handler.c: handle_mgr_master_app_deeplink_res(14891) > 
04-11 11:27:09.190+0200 E/WMS     (  522): wms_event_handler.c: wms_event_handler_routine(24535) > [mgr_master_app_deeplink_res] handler success.
04-11 11:27:09.220+0200 E/WMS     (  522): wms_event_handler.c: wms_event_handler_routine(24519) > 
04-11 11:27:09.220+0200 E/WMS     (  522): ==========
04-11 11:27:09.220+0200 E/WMS     (  522): ##WMS RECEIVED : mgr_gear_package_status_update_req
04-11 11:27:09.220+0200 E/WMS     (  522): ==========
04-11 11:27:09.220+0200 E/WMS     (  522): wms_event_handler.c: handle_mgr_gear_package_status_update_req(14904) > host_pkgname[com.urbandroid.sleep.addon.generic.samsung], host_pkg_ver[26], minVer[0.0.1], status[installed]
04-11 11:27:09.250+0200 I/capability-manager(26339): capability_manager_companion.c: add_companion_package_info(112) > host_package_name=[com.urbandroid.sleep.addon.generic.samsung], host_package_version=[26], gear_package_min_version=[0.0.1]
04-11 11:27:09.250+0200 I/capability-manager(26339): capability_manager_util.c: is_file_exist(120) > File /opt/usr/data/pkgmgr/capability-manager/host_com.urbandroid.sleep.addon.generic.samsung Exists
04-11 11:27:09.250+0200 I/capability-manager(26339): capability_manager_companion.c: add_companion_package_info(132) > update package_info!
04-11 11:27:09.250+0200 I/capability-manager(26339): capability_manager_companion.c: add_companion_package_info(141) > gear_package_min_version is existed.
04-11 11:27:09.250+0200 I/capability-manager(26339): capability_manager_companion.c: add_companion_package_info(146) > package_info=[host_package_name=com.urbandroid.sleep.addon.generic.samsung:host_package_version=26:gear_package_min_version=0.0.1:]
04-11 11:27:09.250+0200 I/capability-manager(26339): capability_manager_signal.c: send_companion_package_add_signal(33) > pkg_id=[com.urbandroid.sleep.addon.generic.samsung]
04-11 11:27:09.260+0200 E/WMS     (  522): wms_msg_broker.c: wms_msg_broker_send(1826) > 
04-11 11:27:09.260+0200 E/WMS     (  522): ==========
04-11 11:27:09.260+0200 E/WMS     (  522): ##WMS SEND : mgr_gear_package_status_update_res
04-11 11:27:09.260+0200 E/WMS     (  522): ==========
04-11 11:27:09.260+0200 E/WMS     (  522): wms_msg_broker.c: wms_msg_broker_send(1842) > Data size: 86 MAX Buffer Size: 61440
04-11 11:27:09.260+0200 E/WMS     (  522): wms_event_handler.c: wms_event_handler_routine(24535) > [mgr_gear_package_status_update_req] handler success.
04-11 11:27:09.310+0200 E/weather-common(26309): WeatherDBController.cpp: Init(53) > [0;40;31m[Init(): 53] (FileHelper::GetInstance()->IsExists(GetWeatherDBFilePath()) == true) [return][0;m
04-11 11:27:09.335+0200 E/weather-common(26309): SettingDBController.cpp: Init(84) > [0;40;31m[Init(): 84] (FileHelper::GetInstance()->IsExists(GetSettingDBFilePath()) == true) [return][0;m
04-11 11:27:09.335+0200 E/weather-common(26309): ShareTargetDBController.cpp: Init(43) > [0;40;31m[Init(): 43] (FileHelper::GetInstance()->IsExists(GetShareTargetDataDBFilePath()) == true) [return][0;m
04-11 11:27:09.380+0200 E/WMS     (  522): wms_msg_broker.c: on_broker_buffer_send(307) > Data sending is success.
04-11 11:27:09.455+0200 I/WSM     (  520): WSM_I [d1]
04-11 11:27:09.480+0200 E/WMS     (  522): wms_msg_broker.c: on_broker_buffer_send(307) > Data sending is success.
04-11 11:27:09.490+0200 E/WMS     (  522): wms_msg_broker.c: wms_msg_broker_send(1826) > 
04-11 11:27:09.490+0200 E/WMS     (  522): ==========
04-11 11:27:09.490+0200 E/WMS     (  522): ##WMS SEND : mgr_apps_order_res
04-11 11:27:09.490+0200 E/WMS     (  522): ==========
04-11 11:27:09.490+0200 E/WMS     (  522): wms_msg_broker.c: wms_msg_broker_send(1842) > Data size: 2731 MAX Buffer Size: 61440
04-11 11:27:09.630+0200 I/efl-extension(26296): efl_extension.c: eext_mod_init(40) > Init
04-11 11:27:09.650+0200 E/WMS     (  522): wms_msg_broker.c: on_broker_buffer_send(307) > Data sending is success.
04-11 11:27:09.665+0200 E/WMS     (  522): wms_event_handler.c: wms_event_handler_routine(24519) > 
04-11 11:27:09.665+0200 E/WMS     (  522): ==========
04-11 11:27:09.665+0200 E/WMS     (  522): ##WMS RECEIVED : mgr_host_status_res
04-11 11:27:09.665+0200 E/WMS     (  522): ==========
04-11 11:27:09.665+0200 E/WMS     (  522): wms_event_handler.c: handle_mgr_host_status_res(17139) > type : sync
04-11 11:27:09.665+0200 E/WMS     (  522): wms_event_handler.c: handle_mgr_host_status_res(17142) > preinstalled: true
04-11 11:27:09.665+0200 E/WMS     (  522): wms_msg_broker.c: wms_msg_broker_send(1826) > 
04-11 11:27:09.665+0200 E/WMS     (  522): ==========
04-11 11:27:09.665+0200 E/WMS     (  522): ##WMS SEND : mgr_status_exchange_done
04-11 11:27:09.665+0200 E/WMS     (  522): ==========
04-11 11:27:09.665+0200 E/WMS     (  522): wms_msg_broker.c: wms_msg_broker_send(1842) > Data size: 73 MAX Buffer Size: 61440
04-11 11:27:09.670+0200 E/WMS     (  522): wms_status_manager.c: wms_status_manager_get_device_status(879) > Host device vendor: LGE
04-11 11:27:09.680+0200 E/wnoti-service( 1082): wnoti-sap-client.c: _get_vendor_cb(3569) > vendor : LGE, vendor_type : 1
04-11 11:27:09.680+0200 I/W_INDICATOR(  765): windicator.c: windicator_is_lo_connected(976) > [windicator_is_lo_connected:976] Connected target vendor : LGE
04-11 11:27:09.685+0200 E/WG-CONSUMER(24121): [31m[F:ConnectionInfo.c L:   52][ERROR]vendor changed: db/wms/host_status/vendor:LGE[0m
04-11 11:27:09.690+0200 E/weather-common(26309): CPType.cpp: Renew(90) > [0;40;31mCPType is renewed : 5[0;m
04-11 11:27:09.705+0200 E/WMS     (  522): wms_status_manager.c: wms_status_manager_get_device_status(894) > host mcc [230], mnc [02]
04-11 11:27:09.705+0200 E/WMS     (  522): wms_xml_util.c: wms_xml_util_get_nodeset(62) > No result
04-11 11:27:09.710+0200 E/WMS     (  522): wms_xml_util.c: wms_xml_util_get_nodeset(62) > No result
04-11 11:27:09.715+0200 E/weather-common(26309): CPType.cpp: Renew(90) > [0;40;31mCPType is renewed : 5[0;m
04-11 11:27:09.720+0200 E/WMS     (  522): wms_status_manager.c: wms_status_manager_sync_host_status(1253) > host platform version: 6.0.1
04-11 11:27:09.725+0200 E/WMS     (  522): wms_status_manager.c: wms_status_manager_sync_host_status(1441) > Host telephony feature is supported - enable call app
04-11 11:27:09.735+0200 I/W_INDICATOR(  765): windicator.c: windicator_is_lo_connected(976) > [windicator_is_lo_connected:976] Connected target vendor : LGE
04-11 11:27:09.750+0200 E/WMS     (  522): wms_status_manager.c: wms_status_manager_sync_host_status(1493) > vendor[ LGE ], support.email.sync[ false ]
04-11 11:27:09.755+0200 I/capability-manager(26339): capability_manager_util.c: is_file_exist(120) > File /opt/usr/share/wms/HostStatus.xml Exists
04-11 11:27:09.755+0200 I/capability-manager(26339): capability_manager_xml.c: capability_manager_xml_util_get_device_info(114) > capability_manager_xml_util_get_device_info() called.
04-11 11:27:09.755+0200 E/PKGMGR  (  522): pkgmgr.c: pkgmgr_client_enable(2552) > enable pkg[com.samsung.call] start
04-11 11:27:09.765+0200 W/APPS    (  843): apps_main.c: apps_main_is_hide_message(1516) >  isHide[1]
04-11 11:27:09.765+0200 W/APPS    (  843): AppsItem.cpp: aniFocusIndex(2373) >  [Galaxy Apps:22] Focused[1], focusIdx[22]
04-11 11:27:09.765+0200 W/APPS    (  843): AppsItem.cpp: setLastIndex(1280) >  This is last index app [23:Sleep], focusIdx[22]
04-11 11:27:09.765+0200 W/APPS    (  843): AppsViewNecklace.cpp: __onSignalHideNextPage(7063) >  Hide next page [0->0]
04-11 11:27:09.765+0200 W/APPS    (  843): AppsViewNecklace.cpp: setBubbleColor(2479) >  [249, 249, 249, 255]
04-11 11:27:09.765+0200 W/wnotib  (  843): w-notification-board-broker-main.c: _wnb_wms_host_status_vendor_changed_cb(344) > vendor: LGE.
04-11 11:27:09.765+0200 I/wnotib  (  843): w-notification-board-empty-panel.c: _wnb_empty_panel_message_receive(60) > type: 15
04-11 11:27:09.775+0200 I/wnotib  (  843): w-notification-board-empty-panel.c: _wnb_ep_set_texts(348) > is_connected_vendor_LO: 0, is_standalone_mode: 0
04-11 11:27:09.785+0200 E/TIZEN_N_SYSTEM_SETTINGS(  843): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
04-11 11:27:09.785+0200 E/TIZEN_N_SYSTEM_SETTINGS(  843): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-11 11:27:09.785+0200 E/TIZEN_N_SYSTEM_SETTINGS(  843): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
04-11 11:27:09.785+0200 E/TIZEN_N_SYSTEM_SETTINGS(  843): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
04-11 11:27:09.805+0200 W/AUL_AMD (  514): amd_status.c: __socket_monitor_cb(1277) > (26296) was created
04-11 11:27:09.820+0200 E/weather-common(26309): DataManager.cpp: LoadData(326) > [0;40;31mnewCpTypeStr : TWC[0;m
04-11 11:27:09.830+0200 W/W_HOME  (  843): clock_view_indicator.c: _view_remove_by_type(267) > removed:3
04-11 11:27:09.830+0200 W/W_HOME  (  843): clock_indicator.c: clock_indicator_pop(374) > icon:3(0) is popped from clock indicator
04-11 11:27:09.830+0200 W/W_HOME  (  843): cfwd.c: cfwd_get_icon_status(362) > 
04-11 11:27:09.830+0200 W/W_HOME  (  843): ============================
04-11 11:27:09.830+0200 W/W_HOME  (  843): multi_sim_category:0
04-11 11:27:09.830+0200 W/W_HOME  (  843): multi_sim_model:0
04-11 11:27:09.830+0200 W/W_HOME  (  843): support_callforward_auto:0
04-11 11:27:09.830+0200 W/W_HOME  (  843): conn_status:1
04-11 11:27:09.830+0200 W/W_HOME  (  843): remote_call_forward_auto:0
04-11 11:27:09.830+0200 W/W_HOME  (  843): auto_call_forward_status:0
04-11 11:27:09.830+0200 W/W_HOME  (  843): support_callforward_reverse:0
04-11 11:27:09.830+0200 W/W_HOME  (  843): reverse_call_forward_auto:0
04-11 11:27:09.830+0200 W/W_HOME  (  843): fwd_type:
04-11 11:27:09.830+0200 W/W_HOME  (  843): ============================
04-11 11:27:09.830+0200 W/W_HOME  (  843): 
04-11 11:27:09.830+0200 W/W_HOME  (  843): clock_view_indicator.c: _view_call_fw_icon(136) > call fwd status:0
04-11 11:27:09.855+0200 E/weather-common(26309): DataManager.cpp: LoadData(329) > [0;40;31mweather data loaded[0;m
04-11 11:27:09.875+0200 E/weather-common(26309): DemoBinaryManager.cpp: ManipulateDemoData(48) > [0;40;31mDemoBinaryManager::ManipulateDemoData[0;m
04-11 11:27:09.875+0200 E/weather-common(26309): VconfUtil.cpp: RemoveVconfEventListener(224) > [0;40;31mFailed vconf_ignore_key_changed [key : db/retailmode/enabled, ret : -1][0;m
04-11 11:27:09.875+0200 E/weather-common(26309): RetailManager.cpp: Monitoring(84) > [0;40;31mRetailManager::Monitoring[0;m
04-11 11:27:09.875+0200 E/weather-common(26309): VconfUtil.cpp: GetVconfIntValue(164) > [0;40;31mFailed vconf_get_int [ret : -1, key : db/retailmode/enabled, value : -1][0;m
04-11 11:27:09.875+0200 E/weather-common(26309): VconfUtil.cpp: AddVconfEventListener(214) > [0;40;31mFailed vconf_notify_key_changed [key : db/retailmode/enabled, ret : -1][0;m
04-11 11:27:09.880+0200 E/weather-common(26309): VconfUtil.cpp: AddVconfEventListener(214) > [0;40;31mFailed vconf_notify_key_changed [key : db/retailmode/res_path, ret : -1][0;m
04-11 11:27:09.915+0200 E/weather-common(26309): SystemInfoHelper.cpp: IsShowcaseBinary(77) > [0;40;31misShowcase:0[0;m
04-11 11:27:09.935+0200 E/PKGMGR_SERVER(26345): pkgmgr-server.c: main(2242) > package manager server start
04-11 11:27:09.965+0200 E/weather-common(26309): DemoBinaryManager.cpp: ManipulateDemoData(54) > [0;40;31m[ManipulateDemoData(): 54] (SystemInfoHelper::GetInstance()->IsShowcaseBinary() == false) [return][0;m
04-11 11:27:10.045+0200 E/PKGMGR_SERVER(26347): pkgmgr-server.c: queue_job(1981) > ENABLE_PKG start, pkgid=[com.samsung.call]
04-11 11:27:10.050+0200 E/PKGMGR  (  522): pkgmgr.c: pkgmgr_client_enable(2638) > enable pkg finish, ret=[0]
04-11 11:27:10.050+0200 E/PKGMGR  (  522): pkgmgr.c: pkgmgr_client_disable(2645) > disable pkg[com.samsung.wemail] start
04-11 11:27:10.075+0200 E/PKGMGR  (  522): pkgmgr.c: pkgmgr_client_disable(2731) > disable pkg finish, ret=[0]
04-11 11:27:10.085+0200 E/CAPI_TELEPHONY(  522): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-11 11:27:10.085+0200 E/PKGMGR_SERVER(26348): pkgmgr-server.c: queue_job(1990) > DISABLE_PKG start, pkgid=[com.samsung.wemail]
04-11 11:27:10.165+0200 E/PKGMGR_STATE(26347): pkg_state.c: __pkg_state_enable_pkg(339) > start enable_pkg : pkgid = com.samsung.call
04-11 11:27:10.180+0200 E/PKGMGR_STATE(26347): pkg_state.c: __make_filtered_pkgid_list(317) > pkgid[com.samsung.call] is decided not to broadcast.
04-11 11:27:10.180+0200 E/PKGMGR_STATE(26347): pkg_state.c: __pkg_state_enable_pkg(350) > nothing to broadcast.
04-11 11:27:10.190+0200 E/PKGMGR_SERVER(26345): pkgmgr-server.c: sighandler(486) > child NORMAL exit [26347]
04-11 11:27:10.275+0200 E/PKGMGR_STATE(26348): pkg_state.c: __pkg_state_disable_pkg(420) > start disable_pkg : pkgid = com.samsung.wemail
04-11 11:27:10.300+0200 E/PKGMGR_STATE(26348): pkg_state.c: __make_filtered_pkgid_list(317) > pkgid[com.samsung.wemail] is decided not to broadcast.
04-11 11:27:10.305+0200 E/PKGMGR_STATE(26348): pkg_state.c: __pkg_state_disable_pkg(431) > nothing to broadcast.
04-11 11:27:10.315+0200 E/PKGMGR_SERVER(26345): pkgmgr-server.c: sighandler(486) > child NORMAL exit [26348]
04-11 11:27:10.330+0200 I/efl-extension(26281): efl_extension.c: eext_mod_init(40) > Init
04-11 11:27:10.490+0200 W/WVMS_SERVER(26304): wvms-server.c: _service_app_control(64) >  sap is connected
04-11 11:27:10.495+0200 I/CAPI_CONTENT_MEDIA_CONTENT(26304): media_content.c: media_content_connect(870) > [32m[26304]ref count : 0
04-11 11:27:10.520+0200 I/CAPI_CONTENT_MEDIA_CONTENT(26304): media_content.c: media_content_connect(902) > [32m[26304]ref count changed to: 1
04-11 11:27:10.530+0200 I/SleepAsAndroidConsumer(26326): agent is initialized
04-11 11:27:10.530+0200 D/SleepAsAndroidConsumer(26326): find peer called
04-11 11:27:10.530+0200 I/SleepAsAndroidConsumer(26326): agent initialized callback is over
04-11 11:27:10.530+0200 D/SleepAsAndroidConsumer(26326): SAP >>> getRegisteredServiceAgent() >>> 0
04-11 11:27:10.725+0200 E/WMS     (  522): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(505) > telephony : 0
04-11 11:27:10.725+0200 E/WMS     (  522): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(506) > wifi : 1
04-11 11:27:10.725+0200 E/WMS     (  522): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(510) > scs : true
04-11 11:27:10.735+0200 E/WMS     (  522): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(526) > svoice not disabled
04-11 11:27:10.735+0200 E/PKGMGR_INFO(  522): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_destroy_pkginfo(1915) > (handle == NULL) pkginfo handle is NULL
04-11 11:27:10.740+0200 D/SleepAsAndroidConsumer(26326): find peer call succeeded
04-11 11:27:10.745+0200 D/SleepAsAndroidConsumer(26326): find peer call is over
04-11 11:27:10.745+0200 E/WMS     (  522): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(545) > camera : 0
04-11 11:27:10.760+0200 E/WMS     (  522): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(560) > wps : 1
04-11 11:27:10.765+0200 E/WMS     (  522): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(566) > speaker : 0
04-11 11:27:10.775+0200 E/WMS     (  522): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(572) > width : 360
04-11 11:27:10.785+0200 E/WMS     (  522): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(578) > height : 360
04-11 11:27:10.795+0200 E/WMS     (  522): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(584) > barometer : 1
04-11 11:27:10.810+0200 E/WMS     (  522): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(590) > magnetometer : 0
04-11 11:27:10.820+0200 E/WMS     (  522): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(596) > photometer : 1
04-11 11:27:10.830+0200 E/WMS     (  522): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(602) > heartrate : 1
04-11 11:27:10.840+0200 E/WMS     (  522): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(608) > ultraviolet : 0
04-11 11:27:10.850+0200 E/WMS     (  522): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(614) > irled : 0
04-11 11:27:10.860+0200 I/SleepAsAndroidConsumer(26326): Find Peer Success!!
04-11 11:27:10.865+0200 E/WMS     (  522): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(691) > push : 1
04-11 11:27:10.865+0200 D/SleepAsAndroidConsumer(26326): request_service_connection call over
04-11 11:27:10.865+0200 E/WMS     (  522): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(702) > auto connection : true
04-11 11:27:10.895+0200 E/PKGMGR_INFO(  522): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_destroy_pkginfo(1915) > (handle == NULL) pkginfo handle is NULL
04-11 11:27:10.905+0200 D/SleepAsAndroidConsumer(26326): req service conn call succeeded
04-11 11:27:10.905+0200 E/WMS     (  522): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(779) > support hfp : 0
04-11 11:27:10.915+0200 E/WMS     (  522): wms_msg_broker.c: wms_msg_broker_send(1826) > 
04-11 11:27:10.915+0200 E/WMS     (  522): ==========
04-11 11:27:10.915+0200 E/WMS     (  522): ##WMS SEND : mgr_wearable_status_res
04-11 11:27:10.915+0200 E/WMS     (  522): ==========
04-11 11:27:10.915+0200 E/WMS     (  522): wms_msg_broker.c: wms_msg_broker_send(1842) > Data size: 17073 MAX Buffer Size: 61440
04-11 11:27:10.915+0200 E/WMS     (  522): wms_event_handler.c: handle_mgr_host_status_res(17174) > need full check 0
04-11 11:27:10.915+0200 E/WMS     (  522): wms_event_handler.c: handle_mgr_host_status_res(17176) > isFirstConnect[0], is_full_sync[0]
04-11 11:27:10.915+0200 E/WMS     (  522): wms_event_handler.c: _wms_event_handler_signal_to_systemd(1216) > wmanager_connected value is already true. but rewrite.
04-11 11:27:10.920+0200 W/WPROXY  ( 1050): net-device.c: __connection_changed_cb(163) > WMS:[1], SAP:[0x1], BAP:[0]
04-11 11:27:10.920+0200 W/WPROXY  ( 1050): net-device.c: __connection_changed_cb(166) > [Ignore] Any connection status is not changed.
04-11 11:27:10.920+0200 W/MC_CONSUMER( 1042): wmc-service-consumer.c: _wms_connection_changed_callback(458) > [33m WMS Connected[3][0m
04-11 11:27:10.920+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: _music_control_consumer_control_print_msg_type(105) > [33m[TID:1042]   msg [WMC_SERVICE_WIPC_MSG_ID_CONNECTION_CHANGED][0m
04-11 11:27:10.920+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: music_control_consumer_msg_process(243) > [36m[TID:1042]   [MUSIC_PLAYER_EVENT]Device State [2] normal:0 dim:1 off:2[0m
04-11 11:27:10.920+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: music_control_consumer_msg_process(343) > [33m[TID:1042]   connection state = 1[0m
04-11 11:27:10.920+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: music_control_consumer_media_changed_ind_request(199) > [33m[TID:1042]   remote mode[1],resume[1][0m
04-11 11:27:10.920+0200 W/MC_CONSUMER( 1042): wmc-service-consumer.c: wmc_service_consumer_send_data(598) > [33m {"msgId":"music-mediachanged-req","value":"true"}[0m
04-11 11:27:10.925+0200 W/AUL_AMD (  514): amd_request.c: __request_handler(669) > __request_handler: 14
04-11 11:27:10.925+0200 W/W_INDICATOR(  765): windicator_dynamic.c: _dynamic_bluetooth_state_changed_cb(1071) > [_dynamic_bluetooth_state_changed_cb:1071] isBTOn : 1
04-11 11:27:10.925+0200 W/W_INDICATOR(  765): windicator_dynamic.c: _dynamic_bluetooth_state_changed_cb(1077) > [_dynamic_bluetooth_state_changed_cb:1077] sap connected : 1
04-11 11:27:10.925+0200 W/W_INDICATOR(  765): windicator_dynamic.c: _dynamic_bluetooth_state_changed_cb(1083) > [_dynamic_bluetooth_state_changed_cb:1083] sap connectivity type : 1
04-11 11:27:10.925+0200 W/W_INDICATOR(  765): windicator_dynamic.c: _dynamic_event_item_pack(870) > [_dynamic_event_item_pack:870] There is NO Headset icon, so move wifi icon to position 1
04-11 11:27:10.925+0200 E/W_INDICATOR(  765): windicator_dynamic.c: _dynamic_bluetooth_state_changed_cb(1097) > [_dynamic_bluetooth_state_changed_cb:1097] Failed to get moment view bt icon
04-11 11:27:10.925+0200 I/W_INDICATOR(  765): windicator.c: windicator_is_lo_connected(976) > [windicator_is_lo_connected:976] Connected target vendor : LGE
04-11 11:27:10.925+0200 W/W_INDICATOR(  765): windicator_dynamic.c: _dynamic_bluetooth_state_changed_cb(1131) > [_dynamic_bluetooth_state_changed_cb:1131] display connected BT icon
04-11 11:27:10.925+0200 E/EFL     (  765): <765> elm_main.c:1622 elm_object_signal_emit() safety check failed: obj == NULL
04-11 11:27:10.925+0200 E/TIZEN_N_SYSTEM_SETTINGS(  765): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-11 11:27:10.925+0200 E/TIZEN_N_SYSTEM_SETTINGS(  765): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-11 11:27:10.925+0200 E/TIZEN_N_SYSTEM_SETTINGS(  765): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=4
04-11 11:27:10.925+0200 E/TIZEN_N_SYSTEM_SETTINGS(  765): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 4, key = 4, type = 0
04-11 11:27:10.930+0200 E/W_HOME  (  843): retailmode.c: retailmode_enabled_get(245) > failed to get value VCONFKEY_RETAILMODE_ENABLED
04-11 11:27:10.930+0200 W/W_HOME  (  843): clock_event.c: _wmanager_connectivity_get(397) > network status : 0
04-11 11:27:10.930+0200 W/W_HOME  (  843): clock_event.c: _wmanager_connectivity_get(402) > sap_connected : 1
04-11 11:27:10.930+0200 W/W_HOME  (  843): clock_event.c: _wmanager_connectivity_get(408) > sap connectivity type : 1
04-11 11:27:10.930+0200 W/W_HOME  (  843): clock_event.c: _wmanager_connectivity_get(414) > network status : 3
04-11 11:27:10.930+0200 W/W_HOME  (  843): clock_event.c: _wmanager_connectivity_get(428) > scs login : 0
04-11 11:27:10.930+0200 W/W_HOME  (  843): clock_event.c: _wmanager_connectivity_get(470) > connected via bluetooth
04-11 11:27:10.930+0200 W/W_HOME  (  843): clock_view_indicator.c: _view_remove_by_type(267) > removed:4
04-11 11:27:10.930+0200 W/W_HOME  (  843): clock_indicator.c: clock_indicator_pop(374) > icon:5(0) is popped from clock indicator
04-11 11:27:10.930+0200 W/wnotib  (  843): w-notification-board-broker-main.c: _wnb_connection_state_changed_cb(379) > is_LO: 0, is_connected: 1
04-11 11:27:10.930+0200 E/wnotib  (  843): w-notification-board-noti-manager-common.c: wnb_nm_get_category_by_application_id(1201) > No category matched.
04-11 11:27:10.930+0200 W/wnotib  (  843): w-notification-board-broker-main.c: _wnb_connection_state_changed_cb(388) > No tips notification.
04-11 11:27:10.930+0200 W/AUL_AMD (  514): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 1744
04-11 11:27:10.935+0200 W/AUL_AMD (  514): amd_request.c: __request_handler(669) > __request_handler: 14
04-11 11:27:10.945+0200 W/AUL_AMD (  514): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 24111
04-11 11:27:10.945+0200 W/AUL_AMD (  514): amd_request.c: __request_handler(669) > __request_handler: 14
04-11 11:27:10.955+0200 W/AUL_AMD (  514): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 26293
04-11 11:27:10.955+0200 W/AUL_AMD (  514): amd_request.c: __request_handler(669) > __request_handler: 14
04-11 11:27:10.965+0200 W/AUL_AMD (  514): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 26296
04-11 11:27:10.965+0200 W/AUL_AMD (  514): amd_request.c: __request_handler(669) > __request_handler: 14
04-11 11:27:10.975+0200 W/CAPI_APPFW_APP_CONTROL(26296): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-11 11:27:10.975+0200 W/CAPI_APPFW_APP_CONTROL(26296): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-11 11:27:10.975+0200 E/CAPI_APPFW_APP_CONTROL(26296): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : failed to retrieve the appid of the caller
04-11 11:27:10.975+0200 W/AUL_AMD (  514): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 26034
04-11 11:27:10.975+0200 W/AUL_AMD (  514): amd_request.c: __request_handler(669) > __request_handler: 14
04-11 11:27:10.990+0200 W/AUL_AMD (  514): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 24121
04-11 11:27:10.990+0200 W/AUL_AMD (  514): amd_request.c: __request_handler(669) > __request_handler: 14
04-11 11:27:10.995+0200 W/W_INDICATOR(  765): windicator_scs.c: windicator_scs_update(123) > [windicator_scs_update:123] sales code : 0
04-11 11:27:10.995+0200 W/W_INDICATOR(  765): windicator_scs.c: windicator_scs_update(131) > [windicator_scs_update:131] sap connected : 1
04-11 11:27:10.995+0200 W/W_INDICATOR(  765): windicator_scs.c: windicator_scs_update(146) > [windicator_scs_update:146] ciss_request_type : 0
04-11 11:27:10.995+0200 I/W_INDICATOR(  765): windicator_scs.c: windicator_scs_update(155) > [windicator_scs_update:155] Hide (Callforwarding requested)
04-11 11:27:10.995+0200 I/W_INDICATOR(  765): windicator.c: windicator_is_lo_connected(976) > [windicator_is_lo_connected:976] Connected target vendor : LGE
04-11 11:27:10.995+0200 W/W_INDICATOR(  765): windicator_scs.c: windicator_scs_update(195) > [windicator_scs_update:195] sap connectivity type : 1
04-11 11:27:10.995+0200 W/W_INDICATOR(  765): windicator_scs.c: windicator_scs_update(203) > [windicator_scs_update:203] network status : 3
04-11 11:27:10.995+0200 W/W_INDICATOR(  765): windicator_scs.c: windicator_scs_update(220) > [windicator_scs_update:220] scs login : 0
04-11 11:27:10.995+0200 W/W_INDICATOR(  765): windicator_scs.c: windicator_scs_update(261) > [windicator_scs_update:261] connected via bluetooth
04-11 11:27:11.000+0200 W/AUL_AMD (  514): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 1042
04-11 11:27:11.000+0200 W/AUL_AMD (  514): amd_request.c: __request_handler(669) > __request_handler: 14
04-11 11:27:11.010+0200 W/AUL_AMD (  514): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 25737
04-11 11:27:11.010+0200 W/AUL_AMD (  514): amd_request.c: __request_handler(669) > __request_handler: 14
04-11 11:27:11.025+0200 W/AUL_AMD (  514): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 26304
04-11 11:27:11.025+0200 W/AUL_AMD (  514): amd_request.c: __request_handler(669) > __request_handler: 14
04-11 11:27:11.040+0200 E/WMS     (  522): wms_event_handler.c: _wms_event_handler_signal_to_systemd(1218) > 
04-11 11:27:11.040+0200 E/WMS     (  522): ==========
04-11 11:27:11.040+0200 E/WMS     (  522): ##WMS WMANAGER CONNECTED : TRUE
04-11 11:27:11.040+0200 E/WMS     (  522): ==========
04-11 11:27:11.040+0200 W/WECONN  (  508): <__wc_feature_wms_connected_cb:453> priv->wms_connected = 1
04-11 11:27:11.045+0200 W/AUL_AMD (  514): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 26309
04-11 11:27:11.045+0200 E/wnoti-ancs( 1082): wnoti-ancs.c: wnoti_ancs_ios_connected_status(2745) > pre_connect_status : 0, bap_connected_status : 0
04-11 11:27:11.050+0200 E/WMS     (  522): wms_event_handler.c: handle_mgr_host_status_res(17185) > TIMESTAMP saved: 1523438825267P:?LAL>AC:K:
04-11 11:27:11.050+0200 E/WMS     (  522): wms_event_handler.c: wms_event_handler_routine(24535) > [mgr_host_status_res] handler success.
04-11 11:27:11.070+0200 W/MSG_CONSUMER( 1407): SapClient.cpp: _onWmsConnectionChanged(810) > [0;35mprevious_status: (1), status: (1)[0;m
04-11 11:27:11.070+0200 I/magazine-service(  995): magazine-service-connection.c: _magazine_service_connection_vconf_key_changed_cb(183) > host_connected changed [1] -> [1]
04-11 11:27:11.070+0200 W/WG-CONSUMER(24121): [32m[F:SAPProxy.cpp     L:  621][_WARN]_on_wms_connected_changed, value = 1, key = memory/wms/wmanager_connected[0m
04-11 11:27:11.070+0200 W/WG-CONSUMER(24121): [34m[F:SAPProxy.cpp     L:  601][_HIGH]Device Connected. Cur type=BT|[0m
04-11 11:27:11.070+0200 W/WG-CONSUMER(24121): [34m[F:SAPProxy.cpp     L:  633][_HIGH]WMS status changed. VConf memory/wms/wmanager_connected value=1 BT=1[0m
04-11 11:27:11.070+0200 W/WG-CONSUMER(24121): [34m[F:SAPProxy.cpp     L:  637][_HIGH]WMS is connected. Try to connection. Connections=2[0m
04-11 11:27:11.070+0200 W/WG-CONSUMER(24121): [34m[F:ConnectionInfo.c L:  190][_HIGH][TX]CConnection::Connect() State:SM_STATE_REGISTER_AGENT[0m
04-11 11:27:11.070+0200 W/WG-CONSUMER(24121): [34m[F:SAPProxy.cpp     L:  147][_HIGH]CSAPProxy::Connect. Size=2 pConnection=0x4332bc00[0m
04-11 11:27:11.070+0200 W/WG-CONSUMER(24121): [34m[F:SAPProxy.cpp     L:  150][_HIGH]  Connection : [TX] LocalAgentID:60919 ServiceHandle:0[0m
04-11 11:27:11.070+0200 W/WG-CONSUMER(24121): [34m[F:SAPProxy.cpp     L:  150][_HIGH]  Connection : [RX] LocalAgentID:60920 ServiceHandle:0[0m
04-11 11:27:11.070+0200 W/MSG_CONSUMER( 1407): SapClient.cpp: _onWmsConnectionChanged(813) > [0;35m_onWmsConnectionChanged() is ignored for same status change. prev:(1), cur:(1)[0;m
04-11 11:27:11.070+0200 E/WG-CONSUMER(24121): [31m[F:SAPProxy.cpp     L:  161][ERROR]Duplication connection. not inseterd[0m
04-11 11:27:11.075+0200 E/WG-CONSUMER(24121): [31m[F:SAPProxy.cpp     L:  165][ERROR]Previous pCurrent(0x43308370) is exist[0m
04-11 11:27:11.075+0200 W/WG-CONSUMER(24121): [34m[F:SAPProxy.cpp     L:  601][_HIGH]Device Connected. Cur type=BT|[0m
04-11 11:27:11.075+0200 W/WG-CONSUMER(24121): [34m[F:SAPProxy.cpp     L:  186][_HIGH]Device connected. WMS=1 BT=1 [0m
04-11 11:27:11.075+0200 W/WG-CONSUMER(24121): [34m[F:ConnectionInfo.c L:  568][_HIGH][TX]advance. CurState=SM_STATE_REGISTER_AGENT(4)[0m
04-11 11:27:11.075+0200 W/WG-CONSUMER(24121): [34m[F:ConnectionInfo.c L:  603][_HIGH][TX]State changed: SM_STATE_REGISTER_AGENT->SM_STATE_FINDING_PEER[0m
04-11 11:27:11.150+0200 W/MC_CONSUMER( 1042): wmc-service-consumer.c: wmc_service_consumer_send_data(598) > [33m {"msgId":"music-queue-req"}[0m
04-11 11:27:11.170+0200 E/CONTACTS_CONSUMER(26034): ct-sap-svc-main.c: __service_check_vendor_init(138) > [0;31m* Critical * ios_connected:0[0;m
04-11 11:27:11.180+0200 E/CONTACTS_CONSUMER(26034): ct-sap-svc-client.c: ct_sap_svc_client_init(4449) > [0;31m* Critical * contacts_db_add_changed_cb() Failed(-22)[0;m
04-11 11:27:11.185+0200 E/CONTACTS_CONSUMER(26034): ct-sap-svc-client.c: __ct_sap_svc_client_intialize_sap_connection(418) > [0;31m* Critical * consumer is alreay initialized[0;m
04-11 11:27:11.190+0200 E/CONTACTS_CONSUMER(26034): ct-sap-svc-client.c: ct_sap_svc_client_mem_info(3594) > [0;31m* Critical * Total allocated space (uordblks):198488
04-11 11:27:11.190+0200 E/CONTACTS_CONSUMER(26034): [0;m
04-11 11:27:11.270+0200 E/weather-common(26309): CPType.cpp: Renew(90) > [0;40;31mCPType is renewed : 5[0;m
04-11 11:27:11.270+0200 E/weather-common(26309): DataManager.cpp: LoadData(326) > [0;40;31mnewCpTypeStr : TWC[0;m
04-11 11:27:11.305+0200 E/weather-common(26309): DataManager.cpp: LoadData(329) > [0;40;31mweather data loaded[0;m
04-11 11:27:11.305+0200 E/CAPI_APPFW_APP_CONTROL(26309): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : failed to retrieve the appid of the caller
04-11 11:27:11.305+0200 E/weather-consumer(26309): ConsumerMain.cpp: GetAppIDFromAppControl(215) > [0;40;31mAppControl ID : (null)[0;m
04-11 11:27:11.305+0200 E/weather-consumer(26309): ConsumerMain.cpp: GetAppIDFromAppControl(218) > [0;40;31mFAILED: service_get_caller(APPID) [-22][0;m
04-11 11:27:11.305+0200 W/CAPI_APPFW_APP_CONTROL(26309): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-11 11:27:11.305+0200 E/weather-consumer(26309): ConsumerMain.cpp: GetMessageFromAppControl(241) > [0;40;31mAppControl msg : (null)[0;m
04-11 11:27:11.305+0200 E/weather-consumer(26309): ConsumerMain.cpp: GetMessageFromAppControl(244) > [0;40;31mFAILED: app_control_get_extra_data(MESSAGE) [-126][0;m
04-11 11:27:11.305+0200 E/weather-consumer(26309): ConsumerMain.cpp: GetMessageTypeByParsing(300) > [0;40;31mNot found message[0;m
04-11 11:27:11.305+0200 E/weather-consumer(26309): ConsumerMain.cpp: SetSelfKillTimer(122) > [0;40;31mAgentMain::SetSelfKillTimer start[0;m
04-11 11:27:11.305+0200 E/weather-consumer(26309): WeatherConsumerController.cpp: Start(73) > [0;40;31mhostDeviceVendor : LGE[0;m
04-11 11:27:11.310+0200 E/weather-consumer(26309): AppcessoryProtocol.cpp: SetSendMessageType(60) > [0;40;31mSetSendMessageType : 0[0;m
04-11 11:27:11.310+0200 E/weather-consumer(26309): AppcessoryProtocol.cpp: MakeMessageForAndroid(88) > [0;40;31mMakeMessageForAndroid[0;m
04-11 11:27:11.310+0200 E/weather-consumer(26309): AppcessoryProtocol.cpp: CreateCpListText(160) > [0;40;31mCP list supported : "Accuweather","TWC","WeatherNews","cmaweather","Kweather","WCN"[0;m
04-11 11:27:11.310+0200 E/weather-consumer(26309): AppcessoryProtocol.cpp: MakeMessageForAndroid(140) > [0;40;31mmSendMessage : {"WEATHER_REQUEST":{"FETCH_REQ":1,"SHOW_SETTING_ON_DEVICE":0,"UPDATED_BY_GEAR":0,"CP_LIST":["Accuweather","TWC","WeatherNews","cmaweather","Kweather","WCN"],"ADD_CURRENT_CITY":0},"REVISION":1,"WEATHER_ACK_SEQ": "1523438831"}[0;m
04-11 11:27:11.310+0200 E/weather-consumer(26309): SAP.cpp: InitializeSAPConnection(142) > [0;40;31mSAP::InitializeSAPConnection[0;m
04-11 11:27:11.355+0200 E/WMS     (  522): wms_msg_broker.c: on_broker_buffer_send(307) > Data sending is success.
04-11 11:27:11.355+0200 I/UXT     (26281): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
04-11 11:27:11.360+0200 W/MC_CONSUMER( 1042): wmc-service-consumer.c: wmc_service_consumer_send_data(598) > [33m {"msgId":"music-getattribute-req"}[0m
04-11 11:27:11.370+0200 I/SleepAsAndroidConsumer(26326): peer agent connection is successful, pa :1134573960
04-11 11:27:11.410+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE(26296): preference.c: _preference_check_retry_err(507) > key(lockTimezone), check retry err: -21/(2/No such file or directory).
04-11 11:27:11.430+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE(26296): preference.c: _preference_get_key(1101) > _preference_get_key(lockTimezone) step(-17825744) failed(2 / No such file or directory)
04-11 11:27:11.430+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE(26296): preference.c: preference_get_string(1258) > preference_get_string(26296) : lockTimezone error
04-11 11:27:11.470+0200 E/CALENDAR-CONSUMER(26296): CalendarSapAgent.cpp: __isLDUBinary(1130) > [0;31m* Critical * vconf_get_int is faled.[0;m
04-11 11:27:11.585+0200 E/WMS     (  522): wms_msg_broker.c: on_broker_buffer_send(307) > Data sending is success.
04-11 11:27:11.650+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: _music_control_consumer_control_print_msg_type(105) > [33m[TID:1042]   msg [WMC_SERVICE_WIPC_MSG_ID_CAPABILITY_FEATURE_RESPONSE][0m
04-11 11:27:11.650+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: music_control_consumer_msg_process(243) > [36m[TID:1042]   [MUSIC_PLAYER_EVENT]Device State [2] normal:0 dim:1 off:2[0m
04-11 11:27:11.650+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: music_control_consumer_media_changed_ind_request(199) > [33m[TID:1042]   remote mode[1],resume[0][0m
04-11 11:27:11.650+0200 W/MC_CONSUMER( 1042): wmc-service-consumer.c: wmc_service_consumer_send_data(598) > [33m {"msgId":"music-mediachanged-req","value":"false"}[0m
04-11 11:27:11.785+0200 W/WG-CONSUMER(24121): [34m[F:ConnectionInfo.c L:  418][_HIGH][TX]Finding Peer Agent. AgentID=60919[0m
04-11 11:27:11.985+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: music_control_consumer_msg_process(381) > [33m[TID:1042]   distinct state = 0, max vol[15], safety_vol[0][0m
04-11 11:27:11.990+0200 W/MUSIC_PLAYER( 1042): mp-weconn.c: _wms_connection_vconf_changed_callback(93) > [33m[TID:1042]   [1][0m
04-11 11:27:11.990+0200 W/MC_CONSUMER( 1042): wmc-service-cotroller.c: _bt_connection_changed_cb(60) > [33m connected[1][0m
04-11 11:27:11.995+0200 E/PKGMGR_SERVER(26345): pkgmgr-server.c: exit_server(1620) > exit_server Start [backend_status=1, queue_status=1] 
04-11 11:27:11.995+0200 E/PKGMGR_SERVER(26345): pkgmgr-server.c: main(2296) > package manager server terminated.
04-11 11:27:12.020+0200 W/MC_CONSUMER( 1042): wmc-service-consumer.c: __wmc_on_data_ind(386) > [33m length : [64][{"msgId":"music-mediachanged-rsp","result":"success","reason":0}][0m
04-11 11:27:12.020+0200 W/MC_CONSUMER( 1042): wmc-service-consumer.c: __wmc_on_data_ind(386) > [33m length : [142][{"msgId":"music-mediachanged-ind","artist":"","album":"","title":"","audioId":"-1","playStatus":"false","favoriteStatus":"false","index":"-1"}][0m
04-11 11:27:12.025+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: _music_control_consumer_control_print_msg_type(105) > [33m[TID:1042]   msg [WMC_SERVICE_WIPC_MSG_ID_MEDIA_CHANGED_IND][0m
04-11 11:27:12.030+0200 W/WG-CONSUMER(24121): [34m[F:ConnectionInfo.c L:  190][_HIGH][RX]CConnection::Connect() State:SM_STATE_REGISTER_AGENT[0m
04-11 11:27:12.035+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: music_control_consumer_msg_process(243) > [36m[TID:1042]   [MUSIC_PLAYER_EVENT]Device State [2] normal:0 dim:1 off:2[0m
04-11 11:27:12.035+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: music_control_consumer_media_changed_ind_request(199) > [33m[TID:1042]   remote mode[1],resume[0][0m
04-11 11:27:12.035+0200 W/MC_CONSUMER( 1042): wmc-service-consumer.c: __wmc_on_data_ind(386) > [33m length : [44][{"msgId":"music-queuechanged-ind","count":0}][0m
04-11 11:27:12.040+0200 W/WG-CONSUMER(24121): [34m[F:SAPProxy.cpp     L:  147][_HIGH]CSAPProxy::Connect. Size=2 pConnection=0x43308370[0m
04-11 11:27:12.040+0200 W/WG-CONSUMER(24121): [34m[F:SAPProxy.cpp     L:  150][_HIGH]  Connection : [TX] LocalAgentID:60919 ServiceHandle:0[0m
04-11 11:27:12.040+0200 W/WG-CONSUMER(24121): [34m[F:SAPProxy.cpp     L:  150][_HIGH]  Connection : [RX] LocalAgentID:60920 ServiceHandle:0[0m
04-11 11:27:12.040+0200 E/WG-CONSUMER(24121): [31m[F:SAPProxy.cpp     L:  161][ERROR]Duplication connection. not inseterd[0m
04-11 11:27:12.040+0200 E/WG-CONSUMER(24121): [31m[F:SAPProxy.cpp     L:  165][ERROR]Previous pCurrent(0x4332bc00) is exist[0m
04-11 11:27:12.060+0200 W/WG-CONSUMER(24121): [34m[F:SAPProxy.cpp     L:  601][_HIGH]Device Connected. Cur type=BT|[0m
04-11 11:27:12.060+0200 W/WG-CONSUMER(24121): [34m[F:SAPProxy.cpp     L:  186][_HIGH]Device connected. WMS=1 BT=1 [0m
04-11 11:27:12.060+0200 W/WG-CONSUMER(24121): [34m[F:ConnectionInfo.c L:  568][_HIGH][RX]advance. CurState=SM_STATE_REGISTER_AGENT(4)[0m
04-11 11:27:12.060+0200 W/WG-CONSUMER(24121): [34m[F:ConnectionInfo.c L:  603][_HIGH][RX]State changed: SM_STATE_REGISTER_AGENT->SM_STATE_FINDING_PEER[0m
04-11 11:27:12.065+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: _music_control_consumer_control_print_msg_type(105) > [33m[TID:1042]   msg [WMC_SERVICE_WIPC_MSG_ID_QUEUE_CHANGED_IND][0m
04-11 11:27:12.075+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: music_control_consumer_msg_process(243) > [36m[TID:1042]   [MUSIC_PLAYER_EVENT]Device State [2] normal:0 dim:1 off:2[0m
04-11 11:27:12.075+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: music_control_consumer_media_changed_ind_request(199) > [33m[TID:1042]   remote mode[1],resume[0][0m
04-11 11:27:12.075+0200 W/MC_CONSUMER( 1042): wmc-service-consumer.c: __wmc_on_data_ind(386) > [33m length : [81][{"msgId":"music-playstatechange-rsp","result":"success","reason":0,"playstate":2}][0m
04-11 11:27:12.095+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: _music_control_consumer_control_print_msg_type(105) > [33m[TID:1042]   msg [WMC_SERVICE_WIPC_MSG_ID_PLAY_STATE_CHANGE_RESPONSE][0m
04-11 11:27:12.095+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: music_control_consumer_msg_process(243) > [36m[TID:1042]   [MUSIC_PLAYER_EVENT]Device State [2] normal:0 dim:1 off:2[0m
04-11 11:27:12.095+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: music_control_consumer_media_changed_ind_request(199) > [33m[TID:1042]   remote mode[1],resume[0][0m
04-11 11:27:12.095+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: music_control_consumer_msg_process(393) > [33m[TID:1042]   player state = 2[0m
04-11 11:27:12.095+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-info.c: music_control_info_set_player_state(423) > [33m[TID:1042]   mode = [1], player state = [0][0m
04-11 11:27:12.095+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-media-controller.c: music_control_media_controller_set_playback_state(74) > [33m[TID:1042]   state[2], 1:playing[0m
04-11 11:27:12.095+0200 W/CAPI_MEDIA_CONTROLLER( 1042): media_controller_server.c: mc_server_set_playback_state(284) > [0m<Enter>
04-11 11:27:12.095+0200 W/CAPI_MEDIA_CONTROLLER( 1042): media_controller_server.c: mc_server_set_playback_state(290) > [0mplayback state update [2]
04-11 11:27:12.095+0200 W/CAPI_MEDIA_CONTROLLER( 1042): media_controller_server.c: mc_server_set_playback_state(295) > [0m<Leave>
04-11 11:27:12.095+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-media-controller.c: music_control_media_controller_update_playback_info(138) > [36m[TID:1042]   [MUSIC_PLAYER_EVENT]update playback info[0m
04-11 11:27:12.095+0200 W/CAPI_MEDIA_CONTROLLER( 1042): media_controller_server.c: mc_server_update_playback_info(326) > [0m<Enter>
04-11 11:27:12.095+0200 W/CAPI_MEDIA_CONTROLLER( 1042): media_controller_server.c: mc_server_update_playback_info(331) > [0mplayback info update: state [2], position [0]
04-11 11:27:12.110+0200 W/CAPI_MEDIA_CONTROLLER( 1042): media_controller_server.c: mc_server_update_playback_info(353) > [0m<Leave>
04-11 11:27:12.110+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-message.c: music_control_message_send_player_state_changed_ind(255) > [36m[TID:1042]   [MUSIC_PLAYER_EVENT][0m
04-11 11:27:12.125+0200 W/MC_CONSUMER( 1042): wmc-service-consumer.c: __wmc_on_data_ind(386) > [33m length : [37][{"msgId":"music-queue-rsp","count":0}][0m
04-11 11:27:12.135+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: _music_control_consumer_control_print_msg_type(105) > [33m[TID:1042]   msg [WMC_SERVICE_WIPC_MSG_ID_QUEUE_RSP][0m
04-11 11:27:12.135+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: music_control_consumer_msg_process(243) > [36m[TID:1042]   [MUSIC_PLAYER_EVENT]Device State [2] normal:0 dim:1 off:2[0m
04-11 11:27:12.135+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: music_control_consumer_media_changed_ind_request(199) > [33m[TID:1042]   remote mode[1],resume[0][0m
04-11 11:27:12.135+0200 W/MC_CONSUMER( 1042): wmc-service-consumer.c: __wmc_on_data_ind(386) > [33m length : [129][{"msgId":"music-getattribute-rsp","result":"failure","reason":0,"repeat":"repeatoff","shuffle":"off","volume":13,"earjack":false}][0m
04-11 11:27:12.135+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: _music_control_consumer_control_print_msg_type(105) > [33m[TID:1042]   msg [WMC_SERVICE_WIPC_MSG_ID_GET_ATTRIBUTE_RESPONSE][0m
04-11 11:27:12.135+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: music_control_consumer_msg_process(243) > [36m[TID:1042]   [MUSIC_PLAYER_EVENT]Device State [2] normal:0 dim:1 off:2[0m
04-11 11:27:12.135+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: music_control_consumer_media_changed_ind_request(199) > [33m[TID:1042]   remote mode[1],resume[0][0m
04-11 11:27:12.135+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: music_control_consumer_msg_process(330) > [33m[TID:1042]   volume = 13, earjack = 0[0m
04-11 11:27:12.215+0200 I/efl-extension(26293): efl_extension.c: eext_mod_init(40) > Init
04-11 11:27:12.250+0200 W/W_INDICATOR(  765): windicator_ongoing_info_music.c: _player_playback_updated_cb(134) > [_player_playback_updated_cb:134] Playback is updated. [com.samsung.w-music-player.music-control-service][2]
04-11 11:27:12.255+0200 W/MC_CONSUMER( 1042): wmc-service-consumer.c: __wmc_on_data_ind(386) > [33m length : [64][{"msgId":"music-mediachanged-rsp","result":"success","reason":0}][0m
04-11 11:27:12.280+0200 E/CONTACTS_CONSUMER(26034): ct-sap-svc-client.c: __ct_sap_svc_client_find_peer_agent(1180) > [0;31m* Critical * connectivity_type 1[0;m
04-11 11:27:12.385+0200 E/weather-consumer(26309): SAP.cpp: CreateService(126) > [0;40;31mSAP::CreateService[0;m
04-11 11:27:12.405+0200 W/SSPAY_UI_SVC(26293): sspay_ui_svc_main.c: main(292) > [36mmain start[0m
04-11 11:27:12.450+0200 W/CRASH_MANAGER(26351): worker.c: worker_job(1205) > 1126326736c65152343883
