S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.2.7
Build-Number: R732XXU2FRC1
Build-Date: 2018.03.02 17:21:30

Crash Information
Process Name: sleepasandroidnativeservice
PID: 29058
Date: 2018-04-11 12:03:00+0200
Executable File Path: /opt/usr/apps/com.urbandroid.sleep/bin/sleepasandroidnativeservice
Signal: 11
      (SIGSEGV)
      si_code: 2
      invalid permissions for mapped object
      si_addr = 0x400040f3

Register Information
r0   = 0x400040f3, r1   = 0x400040f8
r2   = 0x00000031, r3   = 0x430bc928
r4   = 0x00000005, r5   = 0xbe968d40
r6   = 0x430bc928, r7   = 0x00000005
r8   = 0x00000005, r9   = 0x00005e1b
r10  = 0x430bc928, fp   = 0xbe968d34
ip   = 0x430bc92d, sp   = 0xbe9687b0
lr   = 0x40408f80, pc   = 0x4043610c
cpsr = 0x20000010

Memory Information
MemTotal:   490112 KB
MemFree:      4980 KB
Buffers:     13232 KB
Cached:     117212 KB
VmPeak:      60288 KB
VmSize:      60284 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        8824 KB
VmRSS:        8824 KB
VmData:      11256 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       19584 KB
VmPTE:          32 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 29058 TID = 29058
29058 29065 

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
4319a000 43aaf000 rw-p [stack:29065]
be949000 be96a000 rw-p [stack]
End of Maps Information

Callstack Information (PID:29058)
Call Stack Count: 4
 0: _IO_default_xsputn + 0x50 (0x4043610c) [/lib/libc.so.6] + 0x6b10c
 1: _IO_vfprintf + 0xb0 (0x40408f80) [/lib/libc.so.6] + 0x3df80
 2: vsprintf + 0x64 (0x4042b278) [/lib/libc.so.6] + 0x60278
 3: (0x400040f3) [/opt/usr/apps/com.urbandroid.sleep/bin/sleepasandroidnativeservice] + 0x40f3
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
-11 12:02:55.539+0200 W/APPS    (  843): AppsViewNecklace.cpp: __onSignalHideNextPage(7063) >  Hide next page [0->0]
04-11 12:02:55.539+0200 W/APPS    (  843): AppsViewNecklace.cpp: setBubbleColor(2479) >  [249, 249, 249, 255]
04-11 12:02:55.539+0200 W/APPS    (  843): db.c: apps_db_read_list(621) >  
04-11 12:02:55.624+0200 E/WMS     (  522): wms_msg_broker.c: on_broker_buffer_send(307) > Data sending is success.
04-11 12:02:55.664+0200 I/WSM     (  520): WSM_I [ca]
04-11 12:02:55.729+0200 W/MM_CAMCORDER(29040): mm_camcorder_internal.c: _mmcamcorder_constructor(203) >  start
04-11 12:02:55.729+0200 W/MM_CAMCORDER(29040): mm_camcorder_internal.c: _mmcamcorder_constructor(213) >  done
04-11 12:02:55.739+0200 I/efl-extension(29040): efl_extension.c: eext_mod_init(40) > Init
04-11 12:02:55.914+0200 I/AUL_PAD (29042): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
04-11 12:02:56.009+0200 E/WMS     (  522): wms_event_handler.c: wms_event_handler_routine(24519) > 
04-11 12:02:56.009+0200 E/WMS     (  522): ==========
04-11 12:02:56.009+0200 E/WMS     (  522): ##WMS RECEIVED : mgr_wearable_status_req
04-11 12:02:56.009+0200 E/WMS     (  522): ==========
04-11 12:02:56.009+0200 E/WMS     (  522): wms_event_handler.c: handle_mgr_wearable_status_req(16912) > type : sync
04-11 12:02:56.009+0200 E/WMS     (  522): wms_event_handler.c: handle_mgr_wearable_status_req(16919) > host_timestamp : 1523440975814P:?LAL>AC:K:
04-11 12:02:56.009+0200 E/WMS     (  522): wms_package_manager.c: get_package_lists(1239) > get package list function is called
04-11 12:02:56.009+0200 E/WMS     (  522): wms_package_manager.c: initialize_lists(189) > list initialize function is called
04-11 12:02:56.009+0200 E/WMS     (  522): wms_package_manager.c: initialize_lists(196) > acc_svc_app_list leng : 45
04-11 12:02:56.009+0200 E/WMS     (  522): wms_package_manager.c: initialize_lists(208) > watch_all_packages_list leng: 41
04-11 12:02:56.074+0200 E/MALI    (29042): egl_platform_x11.c: __egl_platform_initialize(127) > DDK VERSION - MALI400MP-r4p0-00rel0 / BUILD DATE - 8/Aug/2016 
04-11 12:02:56.074+0200 E/MALI    (29042): egl_platform_x11.c: __egl_platform_initialize(141) > model name : SM-R720
04-11 12:02:56.074+0200 E/MALI    (29042): [gpu-ddk] devel/graphics_drv/r4p0
04-11 12:02:56.074+0200 E/MALI    (29042): 97ae9c0655a7d384872f26978f48bd958e392c4b Fix image distortion on 3rd party applicaton "AnalogWatch"
04-11 12:02:56.074+0200 E/MALI    (29042): [coregl] devel/graphics_engine/master
04-11 12:02:56.074+0200 E/MALI    (29042): c936d4e43f19940f81bedb56d9006162dc3ae4e4 Add manifest file for coregl
04-11 12:02:56.174+0200 E/WMS     (  522): wms_package_manager.c: get_watch_app_info(803) > SAP Setting File Path: /opt/usr/apps/PkGV3tmZSh/res/wgt/res/xml/accessoryservices.xml
04-11 12:02:56.174+0200 E/WMS     (  522): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[PkGV3tmZSh], Appname[CNN]
04-11 12:02:56.229+0200 E/WMS     (  522): wms_package_manager.c: get_watch_app_info(803) > SAP Setting File Path: /opt/usr/apps/X5ICitdP7B/res/wgt/res/xml/accessoryservices.xml
04-11 12:02:56.229+0200 E/WMS     (  522): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[X5ICitdP7B], Appname[Bloomberg]
04-11 12:02:56.279+0200 E/WMS     (  522): wms_package_manager.c: get_watch_app_info(803) > SAP Setting File Path: /opt/usr/apps/bRynPVpV6u/res/wgt/xml/sapservices.xml
04-11 12:02:56.284+0200 E/WMS     (  522): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[bRynPVpV6u], Appname[ESPN]
04-11 12:02:56.309+0200 E/WMS     (  522): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.samsung.alarm], Appname[Upozornění]
04-11 12:02:56.334+0200 E/WMS     (  522): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.samsung.clocksetting], Appname[Nastavení]
04-11 12:02:56.354+0200 E/WMS     (  522): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.samsung.factory-client], Appname[factory-client]
04-11 12:02:56.379+0200 E/WMS     (  522): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.samsung.factory-client], Appname[factory-client-cpustability]
04-11 12:02:56.399+0200 E/WMS     (  522): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.samsung.factory-client], Appname[factory-client-history]
04-11 12:02:56.424+0200 E/WMS     (  522): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.samsung.factory-client], Appname[factory-client-hw]
04-11 12:02:56.444+0200 E/WMS     (  522): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.samsung.factory-client], Appname[factory-client-pretest]
04-11 12:02:56.464+0200 E/WMS     (  522): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.samsung.factory-client], Appname[factory-client-self]
04-11 12:02:56.489+0200 E/WMS     (  522): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.samsung.factory-client], Appname[factory-client-semi]
04-11 12:02:56.509+0200 E/WMS     (  522): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.samsung.factory-client], Appname[factory-client-sensorhubsleep]
04-11 12:02:56.534+0200 E/WMS     (  522): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.samsung.fmg], Appname[RemoteLock]
04-11 12:02:56.554+0200 E/WMS     (  522): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.samsung.fmm], Appname[Najít telefon]
04-11 12:02:56.574+0200 E/WMS     (  522): wms_package_manager.c: get_watch_app_info(705) > app[Galaxy Apps] metadata: notification-disable-on-gearmanager
04-11 12:02:56.579+0200 E/WMS     (  522): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.samsung.gearstore], Appname[Galaxy Apps]
04-11 12:02:56.599+0200 E/WMS     (  522): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.samsung.maps], Appname[Mapy]
04-11 12:02:56.624+0200 E/WMS     (  522): wms_package_manager.c: get_watch_app_info(705) > app[Zprávy] metadata: notification-disable-on-gearmanager
04-11 12:02:56.624+0200 E/WMS     (  522): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.samsung.message], Appname[Zprávy]
04-11 12:02:56.649+0200 E/WMS     (  522): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.samsung.samsung-pay-app], Appname[Samsung Pay]
04-11 12:02:56.669+0200 E/WMS     (  522): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.samsung.samsung-pay-guide-app], Appname[Samsung Pay]
04-11 12:02:56.694+0200 E/WMS     (  522): wms_package_manager.c: get_watch_app_info(705) > app[Samsung Health] metadata: notification-disable-on-gearmanager
04-11 12:02:56.694+0200 E/WMS     (  522): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.samsung.shealth_gear], Appname[Samsung Health]
04-11 12:02:56.719+0200 E/WMS     (  522): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.samsung.stopwatch-wc1], Appname[Stopky]
04-11 12:02:56.739+0200 E/WMS     (  522): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.samsung.svoice-n66], Appname[S Voice]
04-11 12:02:56.759+0200 E/WMS     (  522): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.samsung.timer-wc1], Appname[Časovač]
04-11 12:02:56.784+0200 E/WMS     (  522): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.samsung.voice-tos-app], Appname[TOS]
04-11 12:02:56.804+0200 E/WMS     (  522): wms_package_manager.c: get_watch_app_info(754) > Setting File Exist!: com.samsung.voicememo-c1_settings.xml
04-11 12:02:56.804+0200 E/WMS     (  522): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.samsung.voicememo-c1], Appname[Hlasová poznámka]
04-11 12:02:56.829+0200 E/WMS     (  522): wms_package_manager.c: get_watch_app_info(754) > Setting File Exist!: com.samsung.w-buddy_settings.xml
04-11 12:02:56.834+0200 E/WMS     (  522): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.samsung.w-buddy], Appname[Kamarád]
04-11 12:02:56.854+0200 E/WMS     (  522): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.samsung.w-calendar2], Appname[Kalendář]
04-11 12:02:56.879+0200 E/WMS     (  522): wms_package_manager.c: get_watch_app_info(705) > app[Kontakty] metadata: notification-disable-on-gearmanager
04-11 12:02:56.879+0200 E/WMS     (  522): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.samsung.w-contacts2], Appname[Kontakty]
04-11 12:02:56.889+0200 E/PKGMGR_SERVER(29029): pkgmgr-server.c: exit_server(1620) > exit_server Start [backend_status=0, queue_status=1] 
04-11 12:02:56.904+0200 E/WMS     (  522): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.samsung.w-dialer2], Appname[Číselník]
04-11 12:02:56.924+0200 E/WMS     (  522): wms_package_manager.c: get_watch_app_info(705) > app[Galerie] metadata: notification-disable-on-gearmanager
04-11 12:02:56.924+0200 E/WMS     (  522): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.samsung.w-gallery], Appname[Galerie]
04-11 12:02:56.949+0200 E/WMS     (  522): wms_package_manager.c: get_watch_app_info(705) > app[Telefon] metadata: notification-disable-on-gearmanager
04-11 12:02:56.949+0200 E/WMS     (  522): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.samsung.w-logs2], Appname[Telefon]
04-11 12:02:56.974+0200 E/WMS     (  522): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.samsung.w-magazine-wc1], Appname[Přehled zpráv]
04-11 12:02:56.994+0200 E/WMS     (  522): wms_package_manager.c: get_watch_app_info(705) > app[Hudební přehr.] metadata: notification-disable-on-gearmanager
04-11 12:02:56.994+0200 E/WMS     (  522): wms_package_manager.c: get_watch_app_info(754) > Setting File Exist!: com.samsung.w-music-player_settings.xml
04-11 12:02:56.994+0200 E/WMS     (  522): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.samsung.w-music-player], Appname[Hudební přehr.]
04-11 12:02:57.044+0200 E/WMS     (  522): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.samsung.w-taskmanager], Appname[Poslední aplikace]
04-11 12:02:57.079+0200 E/WMS     (  522): wms_package_manager.c: get_watch_app_info(754) > Setting File Exist!: com.samsung.weather_settings.xml
04-11 12:02:57.079+0200 E/WMS     (  522): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.samsung.weather], Appname[Počasí]
04-11 12:02:57.109+0200 E/WMS     (  522): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.samsung.windicator], Appname[Ovládání]
04-11 12:02:57.134+0200 E/WMS     (  522): wms_package_manager.c: get_watch_app_info(705) > app[Oznámení] metadata: notification-disable-on-gearmanager
04-11 12:02:57.134+0200 E/WMS     (  522): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.samsung.wnotification2], Appname[Oznámení]
04-11 12:02:57.169+0200 E/WMS     (  522): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.samsung.worldclock], Appname[Světový čas]
04-11 12:02:57.199+0200 E/WMS     (  522): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.urbandroid.sleep], Appname[Sleep]
04-11 12:02:57.239+0200 E/WMS     (  522): wms_package_manager.c: get_watch_app_info(803) > SAP Setting File Path: /opt/usr/apps/oQbQH11Tzv/res/wgt/res/xml/accessoryservices.xml
04-11 12:02:57.239+0200 E/WMS     (  522): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[oQbQH11Tzv], Appname[Running]
04-11 12:02:57.299+0200 E/WMS     (  522): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[org.tizen.tizenseckeystring], Appname[Tizen Keystring]
04-11 12:02:57.434+0200 E/CAPI_TELEPHONY(  522): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-11 12:02:57.449+0200 E/rpm-installer(29030): rpm-appcore-intf.c: main(273) > ------------------------------------------------
04-11 12:02:57.449+0200 E/rpm-installer(29030): rpm-appcore-intf.c: main(274) >  [END] installer: result=[0]
04-11 12:02:57.449+0200 E/rpm-installer(29030): rpm-appcore-intf.c: main(275) > ------------------------------------------------
04-11 12:02:57.464+0200 E/RESOURCED(  623): procfs.c: proc_get_oom_score_adj(178) > fopen /proc/29030/oom_score_adj failed
04-11 12:02:57.464+0200 E/RESOURCED(  623): proc-main.c: resourced_proc_status_change(1501) > Empty pid or process not exists. 29030
04-11 12:02:57.464+0200 E/PKGMGR_SERVER(29029): pkgmgr-server.c: sighandler(486) > child NORMAL exit [29030]
04-11 12:02:57.474+0200 W/AUL     (29057): launch.c: app_request_to_launchpad(284) > request cmd(0) to(com.urbandroid.sleep.ui)
04-11 12:02:57.479+0200 W/AUL_AMD (  514): amd_request.c: __request_handler(669) > __request_handler: 0
04-11 12:02:57.484+0200 E/AUL_AMD (  514): amd_request.c: __request_handler(742) > ret(0), standalone(0)
04-11 12:02:57.484+0200 I/capability-manager(  514): capability_manager_companion.c: check_companion_package_status(195) > app_id=[com.urbandroid.sleep.ui]
04-11 12:02:57.484+0200 I/capability-manager(  514): capability_manager_util.c: is_file_exist(120) > File /opt/usr/data/pkgmgr/capability-manager/gear_com.urbandroid.sleep.ui Exists
04-11 12:02:57.484+0200 I/capability-manager(  514): capability_manager_companion.c: check_companion_package_status(231) > app_info=[master_app_packagename=com.urbandroid.sleep.addon.generic.samsung:gear_app_version=1.0.8:master_app_auto_uninstallation=no:], len=[123]
04-11 12:02:57.484+0200 I/capability-manager(  514): capability_manager_companion.c: check_companion_package_status(242) > companion_package_name=[com.urbandroid.sleep.addon.generic.samsung], companion_package_min_version=[(null)]
04-11 12:02:57.484+0200 I/capability-manager(  514): capability_manager_util.c: is_file_exist(120) > File /opt/usr/data/pkgmgr/capability-manager/host_com.urbandroid.sleep.addon.generic.samsung Exists
04-11 12:02:57.484+0200 I/capability-manager(  514): capability_manager_companion.c: check_companion_package_status(255) > package_info=[host_package_name=com.urbandroid.sleep.addon.generic.samsung:host_package_version=26:gear_package_min_version=0.0.1:], len=[116]
04-11 12:02:57.484+0200 I/capability-manager(  514): capability_manager_companion.c: check_companion_package_status(265) > host_package_name=[com.urbandroid.sleep.addon.generic.samsung], host_package_version=[26], gear_package_min_version=[0.0.1]
04-11 12:02:57.484+0200 I/capability-manager(  514): capability_manager_companion.c: check_companion_package_status(281) > gear_app_version=[1.0.8]
04-11 12:02:57.484+0200 I/capability-manager(  514): capability_manager_companion.c: _extract_version(49) > version=[1.0.8] -> major=[1], minor=[0], macro=[8]
04-11 12:02:57.484+0200 I/capability-manager(  514): capability_manager_companion.c: _extract_version(49) > version=[0.0.1] -> major=[0], minor=[0], macro=[1]
04-11 12:02:57.484+0200 I/capability-manager(  514): capability_manager_companion.c: _compare_version(80) > new[1.0.8], old[0.0.1]
04-11 12:02:57.484+0200 I/capability-manager(  514): capability_manager_companion.c: _compare_version(83) > 1 > 0
04-11 12:02:57.484+0200 I/capability-manager(  514): capability_manager_companion.c: check_companion_package_status(295) > companion_package_auto_uninstallation=[no]
04-11 12:02:57.484+0200 I/capability-manager(  514): capability_manager_companion.c: check_companion_package_status(345) > app_id=[com.urbandroid.sleep.ui], type=[0], ret=[0]
04-11 12:02:57.499+0200 I/AUL_AMD (  514): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/launch_app, ret : 0
04-11 12:02:57.509+0200 I/AUL_AMD (  514): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /bin/bash, ret : 0
04-11 12:02:57.509+0200 E/AUL_AMD (  514): amd_launch.c: _start_app(1772) > no caller appid info, ret: -1
04-11 12:02:57.509+0200 W/AUL_AMD (  514): amd_launch.c: _start_app(1782) > caller pid : 29057
04-11 12:02:57.604+0200 E/RESOURCED(  623): procfs.c: proc_get_oom_score_adj(178) > fopen /proc/29030/oom_score_adj failed
04-11 12:02:57.604+0200 E/RESOURCED(  623): proc-main.c: resourced_proc_status_change(1501) > Empty pid or process not exists. 29030
04-11 12:02:57.609+0200 E/RESOURCED(  623): block.c: block_prelaunch_state(138) > insert data com.urbandroid.sleep, table num : 5
04-11 12:02:57.614+0200 W/AUL_AMD (  514): amd_launch.c: _start_app(2218) > pad pid(-5)
04-11 12:02:57.614+0200 W/AUL_PAD ( 1323): launchpad.c: __launchpad_main_loop(611) > Launch on type-based process-pool
04-11 12:02:57.614+0200 W/AUL_PAD ( 1323): launchpad.c: __send_result_to_caller(272) > Check app launching
04-11 12:02:57.614+0200 W/AUL_PAD (29041): launchpad_loader.c: __candidate_process_prepare_exec(259) > [candidate] before __set_access
04-11 12:02:57.619+0200 W/AUL_PAD (29041): launchpad_loader.c: __candidate_process_prepare_exec(264) > [candidate] after __set_access
04-11 12:02:57.619+0200 W/AUL_PAD (29041): launchpad_loader.c: __candidate_process_launchpad_main_loop(414) > update argument
04-11 12:02:57.619+0200 W/AUL_PAD (29041): launchpad_loader.c: main(680) > [candidate] dlopen(com.urbandroid.sleep.ui)
04-11 12:02:57.679+0200 I/efl-extension(29041): efl_extension.c: eext_mod_init(40) > Init
04-11 12:02:57.684+0200 I/UXT     (29041): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
04-11 12:02:57.684+0200 W/AUL_PAD (29041): launchpad_loader.c: main(690) > [candidate] dlsym
04-11 12:02:57.684+0200 W/AUL_PAD (29041): launchpad_loader.c: main(694) > [candidate] dl_main(com.urbandroid.sleep.ui)
04-11 12:02:57.684+0200 I/SleepAsAndroidConsumerUI(29041): Starting UI app
04-11 12:02:57.684+0200 I/CAPI_APPFW_APPLICATION(29041): app_main.c: ui_app_main(704) > app_efl_main
04-11 12:02:57.694+0200 I/CAPI_APPFW_APPLICATION(29041): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
04-11 12:02:57.714+0200 W/AUL     (  514): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(com.urbandroid.sleep.ui) pid(29041) type(uiapp) bg(0)
04-11 12:02:57.714+0200 W/AUL     (29057): launch.c: app_request_to_launchpad(298) > request cmd(0) result(29041)
04-11 12:02:57.714+0200 W/AUL_AMD (  514): amd_status.c: __socket_monitor_cb(1277) > (29041) was created
04-11 12:02:57.759+0200 W/STARTER (  764): pkg-monitor.c: _app_mgr_status_cb(400) > [_app_mgr_status_cb:400] Launch request [29041]
04-11 12:02:57.764+0200 I/SleepAsAndroidConsumerUI(29041): Going to create UI
04-11 12:02:57.869+0200 E/EFL     (29041): ecore_evas<29041> ecore_evas_extn.c:2204 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
04-11 12:02:57.959+0200 E/EFL     (29041): elementary<29041> elm_widget.c:4382 elm_widget_type_check() Passing Object: 0x41806830 in function: elm_bg_color_set, of type: 'elm_layout' when expecting type: 'elm_bg'
04-11 12:02:57.989+0200 I/SleepAsAndroidConsumerUI(29041): UI created
04-11 12:02:57.989+0200 W/AUL     (29041): launch.c: app_request_to_launchpad(284) > request cmd(0) to(com.urbandroid.sleep.service)
04-11 12:02:57.994+0200 W/AUL_AMD (  514): amd_request.c: __request_handler(669) > __request_handler: 0
04-11 12:02:57.994+0200 W/AUL_AMD (  514): amd_launch.c: _start_app(1782) > caller pid : 29041
04-11 12:02:58.009+0200 W/AUL_AMD (  514): amd_launch.c: start_process(606) > child process: 29058
04-11 12:02:58.009+0200 E/RESOURCED(  623): block.c: block_prelaunch_state(138) > insert data com.urbandroid.sleep, table num : 5
04-11 12:02:58.059+0200 W/AUL_AMD (  514): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 29058
04-11 12:02:58.059+0200 W/AUL     (  514): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(com.urbandroid.sleep.service) pid(29058) type(svcapp) bg(0)
04-11 12:02:58.064+0200 W/AUL     (29041): launch.c: app_request_to_launchpad(298) > request cmd(0) result(29058)
04-11 12:02:58.064+0200 I/SleepAsAndroidConsumerUI(29041): App command request sent: start
04-11 12:02:58.064+0200 I/SleepAsAndroidConsumerUI(29041): App control destroyed.
04-11 12:02:58.064+0200 I/APP_CORE(29041): appcore-efl.c: __do_app(453) > [APP 29041] Event: RESET State: CREATED
04-11 12:02:58.064+0200 I/CAPI_APPFW_APPLICATION(29041): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
04-11 12:02:58.064+0200 I/SleepAsAndroidConsumerUI(29041): App control received
04-11 12:02:58.064+0200 E/CAPI_APPFW_APP_CONTROL(29041): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : failed to retrieve the appid of the caller
04-11 12:02:58.064+0200 W/CAPI_APPFW_APP_CONTROL(29041): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-11 12:02:58.064+0200 E/SleepAsAndroidConsumerUI(29041): Failed to get app control attribute
04-11 12:02:58.069+0200 W/STARTER (  764): pkg-monitor.c: _app_mgr_status_cb(400) > [_app_mgr_status_cb:400] Launch request [29058]
04-11 12:02:58.134+0200 I/APP_CORE(29041): appcore-efl.c: __do_app(522) > Legacy lifecycle: 0
04-11 12:02:58.134+0200 I/APP_CORE(29041): appcore-efl.c: __do_app(524) > [APP 29041] Initial Launching, call the resume_cb
04-11 12:02:58.134+0200 I/CAPI_APPFW_APPLICATION(29041): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
04-11 12:02:58.134+0200 W/AUL_AMD (  514): amd_request.c: __request_handler(669) > __request_handler: 14
04-11 12:02:58.149+0200 W/AUL_AMD (  514): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 29058
04-11 12:02:58.149+0200 W/AUL_AMD (  514): amd_request.c: __request_handler(669) > __request_handler: 12
04-11 12:02:58.169+0200 W/APP_CORE(29041): appcore-efl.c: __show_cb(860) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:3800002
04-11 12:02:58.214+0200 I/APP_CORE(28657): appcore-efl.c: __do_app(453) > [APP 28657] Event: PAUSE State: PAUSED
04-11 12:02:58.214+0200 I/APP_CORE(28657): appcore-efl.c: __visibility_cb(949) > LCD status is off, skip the AE_RESUME event
04-11 12:02:58.219+0200 I/APP_CORE(29041): appcore-efl.c: __do_app(453) > [APP 29041] Event: RESUME State: RUNNING
04-11 12:02:58.229+0200 W/AUL     (  514): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.wifi) pid(28657) status(bg) type(uiapp)
04-11 12:02:58.229+0200 W/STARTER (  764): pkg-monitor.c: _proc_mgr_status_cb(455) > [_proc_mgr_status_cb:455] >> P[28657] goes to (4)
04-11 12:02:58.234+0200 W/STARTER (  764): pkg-monitor.c: _proc_mgr_status_cb(455) > [_proc_mgr_status_cb:455] >> P[1325] goes to (4)
04-11 12:02:58.239+0200 W/AUL     (  514): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.clocksetting) pid(1325) status(bg) type(uiapp)
04-11 12:02:58.239+0200 W/STARTER (  764): pkg-monitor.c: _proc_mgr_status_cb(455) > [_proc_mgr_status_cb:455] >> P[29041] goes to (3)
04-11 12:02:58.239+0200 W/AUL_AMD (  514): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
04-11 12:02:58.239+0200 W/AUL_AMD (  514): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
04-11 12:02:58.239+0200 W/AUL     (  514): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.urbandroid.sleep.ui) pid(29041) status(fg) type(uiapp)
04-11 12:02:58.359+0200 W/AUL_AMD (  514): amd_request.c: __request_handler(669) > __request_handler: 14
04-11 12:02:58.369+0200 W/AUL_AMD (  514): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 29058
04-11 12:02:58.394+0200 W/AUL_AMD (  514): amd_request.c: __request_handler(669) > __request_handler: 12
04-11 12:02:58.434+0200 I/SleepAsAndroidConsumer(29058): starting service app
04-11 12:02:58.434+0200 E/CAPI_APPFW_APPLICATION(29058): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-11 12:02:58.434+0200 E/CAPI_APPFW_APPLICATION(29058): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-11 12:02:58.444+0200 D/SleepAsAndroidConsumer(29058): HRM is  supported
04-11 12:02:58.449+0200 W/AUL_AMD (  514): amd_status.c: __socket_monitor_cb(1277) > (29058) was created
04-11 12:02:58.494+0200 E/WMS     (  522): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(505) > telephony : 0
04-11 12:02:58.494+0200 E/WMS     (  522): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(506) > wifi : 1
04-11 12:02:58.494+0200 E/WMS     (  522): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(510) > scs : true
04-11 12:02:58.514+0200 E/WMS     (  522): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(526) > svoice not disabled
04-11 12:02:58.514+0200 E/PKGMGR_INFO(  522): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_destroy_pkginfo(1915) > (handle == NULL) pkginfo handle is NULL
04-11 12:02:58.514+0200 E/SleepAsAndroidConsumer(29058): SUCCESSFULLY create sap agent
04-11 12:02:58.529+0200 E/WMS     (  522): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(545) > camera : 0
04-11 12:02:58.544+0200 E/WMS     (  522): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(560) > wps : 1
04-11 12:02:58.564+0200 E/WMS     (  522): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(566) > speaker : 0
04-11 12:02:58.584+0200 E/WMS     (  522): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(572) > width : 360
04-11 12:02:58.604+0200 E/WMS     (  522): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(578) > height : 360
04-11 12:02:58.629+0200 E/AUL     (  514): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
04-11 12:02:58.629+0200 E/WMS     (  522): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(584) > barometer : 1
04-11 12:02:58.639+0200 E/WMS     (  522): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(590) > magnetometer : 0
04-11 12:02:58.649+0200 E/WMS     (  522): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(596) > photometer : 1
04-11 12:02:58.664+0200 E/WMS     (  522): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(602) > heartrate : 1
04-11 12:02:58.674+0200 E/WMS     (  522): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(608) > ultraviolet : 0
04-11 12:02:58.679+0200 E/WMS     (  522): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(614) > irled : 0
04-11 12:02:58.689+0200 E/WMS     (  522): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(691) > push : 1
04-11 12:02:58.689+0200 E/WMS     (  522): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(702) > auto connection : true
04-11 12:02:58.709+0200 I/SleepAsAndroidConsumer(29058): connectivity type(1): bt
04-11 12:02:58.724+0200 E/PKGMGR_INFO(  522): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_destroy_pkginfo(1915) > (handle == NULL) pkginfo handle is NULL
04-11 12:02:58.739+0200 E/WMS     (  522): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(779) > support hfp : 0
04-11 12:02:58.739+0200 E/WMS     (  522): wms_msg_broker.c: wms_msg_broker_send(1826) > 
04-11 12:02:58.739+0200 E/WMS     (  522): ==========
04-11 12:02:58.739+0200 E/WMS     (  522): ##WMS SEND : mgr_wearable_status_res
04-11 12:02:58.739+0200 E/WMS     (  522): ==========
04-11 12:02:58.739+0200 E/WMS     (  522): wms_msg_broker.c: wms_msg_broker_send(1842) > Data size: 17073 MAX Buffer Size: 61440
04-11 12:02:58.744+0200 E/WMS     (  522): wms_msg_broker.c: wms_msg_broker_send(1826) > 
04-11 12:02:58.744+0200 E/WMS     (  522): ==========
04-11 12:02:58.744+0200 E/WMS     (  522): ##WMS SEND : mgr_host_status_req
04-11 12:02:58.744+0200 E/WMS     (  522): ==========
04-11 12:02:58.744+0200 E/WMS     (  522): wms_msg_broker.c: wms_msg_broker_send(1842) > Data size: 52 MAX Buffer Size: 61440
04-11 12:02:58.744+0200 E/WMS     (  522): wms_event_handler.c: handle_mgr_wearable_status_req(17018) > handle_mgr_wearable_status_req completed
04-11 12:02:58.744+0200 E/WMS     (  522): wms_event_handler.c: wms_event_handler_routine(24535) > [mgr_wearable_status_req] handler success.
04-11 12:02:58.814+0200 W/AUL_AMD (  514): amd_request.c: __request_handler(669) > __request_handler: 14
04-11 12:02:58.824+0200 W/AUL_AMD (  514): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 29041
04-11 12:02:58.824+0200 W/AUL_AMD (  514): amd_request.c: __request_handler(669) > __request_handler: 14
04-11 12:02:58.834+0200 W/AUL_AMD (  514): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 29041
04-11 12:02:58.834+0200 W/AUL_AMD (  514): amd_request.c: __request_handler(669) > __request_handler: 12
04-11 12:02:58.859+0200 W/AUL_AMD (  514): amd_request.c: __request_handler(669) > __request_handler: 12
04-11 12:02:58.889+0200 E/PKGMGR_SERVER(29029): pkgmgr-server.c: exit_server(1620) > exit_server Start [backend_status=1, queue_status=1] 
04-11 12:02:58.889+0200 E/PKGMGR_SERVER(29029): pkgmgr-server.c: main(2296) > package manager server terminated.
04-11 12:02:58.979+0200 E/WMS     (  522): wms_msg_broker.c: on_broker_buffer_send(307) > Data sending is success.
04-11 12:02:59.084+0200 E/WMS     (  522): wms_msg_broker.c: on_broker_buffer_send(307) > Data sending is success.
04-11 12:02:59.179+0200 E/WMS     (  522): wms_event_handler.c: wms_event_handler_routine(24519) > 
04-11 12:02:59.179+0200 E/WMS     (  522): ==========
04-11 12:02:59.179+0200 E/WMS     (  522): ##WMS RECEIVED : mgr_apps_order_req
04-11 12:02:59.179+0200 E/WMS     (  522): ==========
04-11 12:02:59.179+0200 E/WMS     (  522): wms_event_handler.c: wms_event_handler_routine(24535) > [mgr_apps_order_req] handler success.
04-11 12:02:59.179+0200 W/W_HOME  (  843): wms.c: wms_change_apps_order(72) > Backup
04-11 12:02:59.179+0200 W/APPS    (  843): db.c: apps_db_read_list(621) >  
04-11 12:02:59.274+0200 E/WMS     (  522): wms_event_handler.c: wms_event_handler_routine(24519) > 
04-11 12:02:59.274+0200 E/WMS     (  522): ==========
04-11 12:02:59.274+0200 E/WMS     (  522): ##WMS RECEIVED : mgr_gear_package_status_update_req
04-11 12:02:59.274+0200 E/WMS     (  522): ==========
04-11 12:02:59.274+0200 E/WMS     (  522): wms_event_handler.c: handle_mgr_gear_package_status_update_req(14904) > host_pkgname[com.urbandroid.sleep.addon.generic.samsung], host_pkg_ver[26], minVer[0.0.1], status[installed]
04-11 12:02:59.279+0200 W/W_HOME  (  843): wms.c: wms_change_apps_order(85) > done
04-11 12:02:59.399+0200 I/AUL_PAD (29066): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
04-11 12:02:59.449+0200 I/capability-manager(29072): capability_manager_companion.c: add_companion_package_info(112) > host_package_name=[com.urbandroid.sleep.addon.generic.samsung], host_package_version=[26], gear_package_min_version=[0.0.1]
04-11 12:02:59.449+0200 I/capability-manager(29072): capability_manager_util.c: is_file_exist(120) > File /opt/usr/data/pkgmgr/capability-manager/host_com.urbandroid.sleep.addon.generic.samsung Exists
04-11 12:02:59.449+0200 I/capability-manager(29072): capability_manager_companion.c: add_companion_package_info(132) > update package_info!
04-11 12:02:59.449+0200 I/capability-manager(29072): capability_manager_companion.c: add_companion_package_info(141) > gear_package_min_version is existed.
04-11 12:02:59.449+0200 I/capability-manager(29072): capability_manager_companion.c: add_companion_package_info(146) > package_info=[host_package_name=com.urbandroid.sleep.addon.generic.samsung:host_package_version=26:gear_package_min_version=0.0.1:]
04-11 12:02:59.449+0200 I/capability-manager(29072): capability_manager_signal.c: send_companion_package_add_signal(33) > pkg_id=[com.urbandroid.sleep.addon.generic.samsung]
04-11 12:02:59.504+0200 E/WMS     (  522): wms_msg_broker.c: wms_msg_broker_send(1826) > 
04-11 12:02:59.504+0200 E/WMS     (  522): ==========
04-11 12:02:59.504+0200 E/WMS     (  522): ##WMS SEND : mgr_gear_package_status_update_res
04-11 12:02:59.504+0200 E/WMS     (  522): ==========
04-11 12:02:59.504+0200 E/WMS     (  522): wms_msg_broker.c: wms_msg_broker_send(1842) > Data size: 86 MAX Buffer Size: 61440
04-11 12:02:59.504+0200 E/WMS     (  522): wms_event_handler.c: wms_event_handler_routine(24535) > [mgr_gear_package_status_update_req] handler success.
04-11 12:02:59.514+0200 I/SleepAsAndroidConsumer(29058): agent is initialized
04-11 12:02:59.514+0200 D/SleepAsAndroidConsumer(29058): find peer called
04-11 12:02:59.519+0200 I/SleepAsAndroidConsumer(29058): agent initialized callback is over
04-11 12:02:59.519+0200 D/SleepAsAndroidConsumer(29058): SAP >>> getRegisteredServiceAgent() >>> 0
04-11 12:02:59.529+0200 E/WMS     (  522): wms_event_handler.c: wms_event_handler_routine(24519) > 
04-11 12:02:59.529+0200 E/WMS     (  522): ==========
04-11 12:02:59.529+0200 E/WMS     (  522): ##WMS RECEIVED : mgr_master_app_deeplink_res
04-11 12:02:59.529+0200 E/WMS     (  522): ==========
04-11 12:02:59.529+0200 E/WMS     (  522): wms_event_handler.c: handle_mgr_master_app_deeplink_res(14891) > 
04-11 12:02:59.529+0200 E/WMS     (  522): wms_event_handler.c: wms_event_handler_routine(24535) > [mgr_master_app_deeplink_res] handler success.
04-11 12:02:59.599+0200 E/WMS     (  522): wms_event_handler.c: wms_event_handler_routine(24519) > 
04-11 12:02:59.599+0200 E/WMS     (  522): ==========
04-11 12:02:59.599+0200 E/WMS     (  522): ##WMS RECEIVED : mgr_gear_package_status_update_req
04-11 12:02:59.599+0200 E/WMS     (  522): ==========
04-11 12:02:59.599+0200 E/WMS     (  522): wms_event_handler.c: handle_mgr_gear_package_status_update_req(14904) > host_pkgname[com.urbandroid.sleep.addon.generic.samsung], host_pkg_ver[26], minVer[0.0.1], status[installed]
04-11 12:02:59.619+0200 D/SleepAsAndroidConsumer(29058): find peer call succeeded
04-11 12:02:59.624+0200 D/SleepAsAndroidConsumer(29058): find peer call is over
04-11 12:02:59.624+0200 I/SleepAsAndroidConsumer(29058): Find Peer Success!!
04-11 12:02:59.629+0200 I/capability-manager(29072): capability_manager_companion.c: add_companion_package_info(112) > host_package_name=[com.urbandroid.sleep.addon.generic.samsung], host_package_version=[26], gear_package_min_version=[0.0.1]
04-11 12:02:59.629+0200 I/capability-manager(29072): capability_manager_util.c: is_file_exist(120) > File /opt/usr/data/pkgmgr/capability-manager/host_com.urbandroid.sleep.addon.generic.samsung Exists
04-11 12:02:59.629+0200 I/capability-manager(29072): capability_manager_companion.c: add_companion_package_info(132) > update package_info!
04-11 12:02:59.629+0200 I/capability-manager(29072): capability_manager_companion.c: add_companion_package_info(141) > gear_package_min_version is existed.
04-11 12:02:59.629+0200 I/capability-manager(29072): capability_manager_companion.c: add_companion_package_info(146) > package_info=[host_package_name=com.urbandroid.sleep.addon.generic.samsung:host_package_version=26:gear_package_min_version=0.0.1:]
04-11 12:02:59.629+0200 I/capability-manager(29072): capability_manager_signal.c: send_companion_package_add_signal(33) > pkg_id=[com.urbandroid.sleep.addon.generic.samsung]
04-11 12:02:59.654+0200 D/SleepAsAndroidConsumer(29058): request_service_connection call over
04-11 12:02:59.654+0200 E/WMS     (  522): wms_msg_broker.c: wms_msg_broker_send(1826) > 
04-11 12:02:59.654+0200 E/WMS     (  522): ==========
04-11 12:02:59.654+0200 E/WMS     (  522): ##WMS SEND : mgr_gear_package_status_update_res
04-11 12:02:59.654+0200 E/WMS     (  522): ==========
04-11 12:02:59.659+0200 E/WMS     (  522): wms_msg_broker.c: wms_msg_broker_send(1842) > Data size: 86 MAX Buffer Size: 61440
04-11 12:02:59.659+0200 E/WMS     (  522): wms_event_handler.c: wms_event_handler_routine(24535) > [mgr_gear_package_status_update_req] handler success.
04-11 12:02:59.684+0200 D/SleepAsAndroidConsumer(29058): req service conn call succeeded
04-11 12:02:59.769+0200 E/WMS     (  522): wms_msg_broker.c: on_broker_buffer_send(307) > Data sending is success.
04-11 12:02:59.849+0200 I/WSM     (  520): WSM_I [d1]
04-11 12:02:59.869+0200 E/WMS     (  522): wms_msg_broker.c: on_broker_buffer_send(307) > Data sending is success.
04-11 12:02:59.874+0200 E/WMS     (  522): wms_msg_broker.c: wms_msg_broker_send(1826) > 
04-11 12:02:59.874+0200 E/WMS     (  522): ==========
04-11 12:02:59.874+0200 E/WMS     (  522): ##WMS SEND : mgr_apps_order_res
04-11 12:02:59.874+0200 E/WMS     (  522): ==========
04-11 12:02:59.874+0200 E/WMS     (  522): wms_msg_broker.c: wms_msg_broker_send(1842) > Data size: 2731 MAX Buffer Size: 61440
04-11 12:02:59.924+0200 I/AUL     (29040): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
04-11 12:02:59.964+0200 I/AUL     (29040): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
04-11 12:02:59.969+0200 E/AUL     (29040): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
04-11 12:02:59.969+0200 E/AUL     (29040): aul_path.c: __get_path(169) > root_path is NULL!
04-11 12:02:59.994+0200 E/WMS     (  522): wms_msg_broker.c: on_broker_buffer_send(307) > Data sending is success.
04-11 12:03:00.004+0200 I/AUL     (29040): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
04-11 12:03:00.014+0200 E/WMS     (  522): wms_event_handler.c: wms_event_handler_routine(24519) > 
04-11 12:03:00.014+0200 E/WMS     (  522): ==========
04-11 12:03:00.014+0200 E/WMS     (  522): ##WMS RECEIVED : mgr_host_status_res
04-11 12:03:00.014+0200 E/WMS     (  522): ==========
04-11 12:03:00.014+0200 E/WMS     (  522): wms_event_handler.c: handle_mgr_host_status_res(17139) > type : sync
04-11 12:03:00.014+0200 E/WMS     (  522): wms_event_handler.c: handle_mgr_host_status_res(17142) > preinstalled: true
04-11 12:03:00.014+0200 E/WMS     (  522): wms_msg_broker.c: wms_msg_broker_send(1826) > 
04-11 12:03:00.014+0200 E/WMS     (  522): ==========
04-11 12:03:00.014+0200 E/WMS     (  522): ##WMS SEND : mgr_status_exchange_done
04-11 12:03:00.014+0200 E/WMS     (  522): ==========
04-11 12:03:00.014+0200 E/WMS     (  522): wms_msg_broker.c: wms_msg_broker_send(1842) > Data size: 73 MAX Buffer Size: 61440
04-11 12:03:00.014+0200 E/WMS     (  522): wms_status_manager.c: wms_status_manager_get_device_status(879) > Host device vendor: LGE
04-11 12:03:00.029+0200 I/W_INDICATOR(  765): windicator.c: windicator_is_lo_connected(976) > [windicator_is_lo_connected:976] Connected target vendor : LGE
04-11 12:03:00.034+0200 E/wnoti-service( 1082): wnoti-sap-client.c: _get_vendor_cb(3569) > vendor : LGE, vendor_type : 1
04-11 12:03:00.044+0200 E/WMS     (  522): wms_status_manager.c: wms_status_manager_get_device_status(894) > host mcc [230], mnc [02]
04-11 12:03:00.049+0200 E/WMS     (  522): wms_xml_util.c: wms_xml_util_get_nodeset(62) > No result
04-11 12:03:00.049+0200 I/capability-manager(29072): capability_manager_util.c: is_file_exist(120) > File /opt/usr/share/wms/HostStatus.xml Exists
04-11 12:03:00.054+0200 I/capability-manager(29072): capability_manager_xml.c: capability_manager_xml_util_get_device_info(114) > capability_manager_xml_util_get_device_info() called.
04-11 12:03:00.059+0200 E/WMS     (  522): wms_xml_util.c: wms_xml_util_get_nodeset(62) > No result
04-11 12:03:00.064+0200 E/WMS     (  522): wms_status_manager.c: wms_status_manager_sync_host_status(1253) > host platform version: 6.0.1
04-11 12:03:00.064+0200 W/APPS    (  843): apps_main.c: apps_main_is_hide_message(1516) >  isHide[1]
04-11 12:03:00.064+0200 W/APPS    (  843): AppsItem.cpp: aniFocusIndex(2373) >  [Galaxy Apps:22] Focused[1], focusIdx[22]
04-11 12:03:00.064+0200 W/APPS    (  843): AppsItem.cpp: setLastIndex(1280) >  This is last index app [23:Sleep], focusIdx[22]
04-11 12:03:00.064+0200 W/APPS    (  843): AppsViewNecklace.cpp: __onSignalHideNextPage(7063) >  Hide next page [0->0]
04-11 12:03:00.064+0200 W/APPS    (  843): AppsViewNecklace.cpp: setBubbleColor(2479) >  [249, 249, 249, 255]
04-11 12:03:00.064+0200 W/wnotib  (  843): w-notification-board-broker-main.c: _wnb_wms_host_status_vendor_changed_cb(344) > vendor: LGE.
04-11 12:03:00.064+0200 I/wnotib  (  843): w-notification-board-empty-panel.c: _wnb_empty_panel_message_receive(60) > type: 15
04-11 12:03:00.069+0200 E/WG-CONSUMER(24121): [31m[F:ConnectionInfo.c L:   52][ERROR]vendor changed: db/wms/host_status/vendor:LGE[0m
04-11 12:03:00.069+0200 I/wnotib  (  843): w-notification-board-empty-panel.c: _wnb_ep_set_texts(348) > is_connected_vendor_LO: 0, is_standalone_mode: 0
04-11 12:03:00.069+0200 E/WMS     (  522): wms_status_manager.c: wms_status_manager_sync_host_status(1441) > Host telephony feature is supported - enable call app
04-11 12:03:00.079+0200 I/W_INDICATOR(  765): windicator.c: windicator_is_lo_connected(976) > [windicator_is_lo_connected:976] Connected target vendor : LGE
04-11 12:03:00.089+0200 E/TIZEN_N_SYSTEM_SETTINGS(  843): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
04-11 12:03:00.089+0200 E/TIZEN_N_SYSTEM_SETTINGS(  843): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-11 12:03:00.089+0200 E/TIZEN_N_SYSTEM_SETTINGS(  843): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
04-11 12:03:00.089+0200 E/TIZEN_N_SYSTEM_SETTINGS(  843): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
04-11 12:03:00.094+0200 E/WMS     (  522): wms_status_manager.c: wms_status_manager_sync_host_status(1493) > vendor[ LGE ], support.email.sync[ false ]
04-11 12:03:00.104+0200 E/PKGMGR  (  522): pkgmgr.c: pkgmgr_client_enable(2552) > enable pkg[com.samsung.call] start
04-11 12:03:00.149+0200 W/W_HOME  (  843): clock_view_indicator.c: _view_remove_by_type(267) > removed:3
04-11 12:03:00.149+0200 W/W_HOME  (  843): clock_indicator.c: clock_indicator_pop(374) > icon:3(0) is popped from clock indicator
04-11 12:03:00.149+0200 W/W_HOME  (  843): cfwd.c: cfwd_get_icon_status(362) > 
04-11 12:03:00.149+0200 W/W_HOME  (  843): ============================
04-11 12:03:00.149+0200 W/W_HOME  (  843): multi_sim_category:0
04-11 12:03:00.149+0200 W/W_HOME  (  843): multi_sim_model:0
04-11 12:03:00.149+0200 W/W_HOME  (  843): support_callforward_auto:0
04-11 12:03:00.149+0200 W/W_HOME  (  843): conn_status:1
04-11 12:03:00.149+0200 W/W_HOME  (  843): remote_call_forward_auto:0
04-11 12:03:00.149+0200 W/W_HOME  (  843): auto_call_forward_status:0
04-11 12:03:00.149+0200 W/W_HOME  (  843): support_callforward_reverse:0
04-11 12:03:00.149+0200 W/W_HOME  (  843): reverse_call_forward_auto:0
04-11 12:03:00.149+0200 W/W_HOME  (  843): fwd_type:
04-11 12:03:00.149+0200 W/W_HOME  (  843): ============================
04-11 12:03:00.149+0200 W/W_HOME  (  843): 
04-11 12:03:00.149+0200 W/W_HOME  (  843): clock_view_indicator.c: _view_call_fw_icon(136) > call fwd status:0
04-11 12:03:00.164+0200 I/SleepAsAndroidConsumer(29058): peer agent connection is successful, pa :1124831680
04-11 12:03:00.189+0200 I/SleepAsAndroidConsumer(29058): Sending data 1.0.8
04-11 12:03:00.269+0200 E/PKGMGR_SERVER(29079): pkgmgr-server.c: main(2242) > package manager server start
04-11 12:03:00.284+0200 I/AUL     (29040): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
04-11 12:03:00.289+0200 E/AUL     (29040): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
04-11 12:03:00.289+0200 E/AUL     (29040): aul_path.c: __get_path(169) > root_path is NULL!
04-11 12:03:00.319+0200 I/AUL     (29040): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
04-11 12:03:00.359+0200 I/AUL     (29040): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
04-11 12:03:00.359+0200 E/AUL     (29040): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
04-11 12:03:00.359+0200 E/AUL     (29040): aul_path.c: __get_path(169) > root_path is NULL!
04-11 12:03:00.379+0200 I/AUL     (29040): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
04-11 12:03:00.394+0200 E/PKGMGR  (  522): pkgmgr.c: pkgmgr_client_enable(2638) > enable pkg finish, ret=[0]
04-11 12:03:00.394+0200 E/PKGMGR  (  522): pkgmgr.c: pkgmgr_client_disable(2645) > disable pkg[com.samsung.wemail] start
04-11 12:03:00.404+0200 E/PKGMGR_SERVER(29083): pkgmgr-server.c: queue_job(1981) > ENABLE_PKG start, pkgid=[com.samsung.call]
04-11 12:03:00.424+0200 E/PKGMGR_SERVER(29084): pkgmgr-server.c: queue_job(1990) > DISABLE_PKG start, pkgid=[com.samsung.wemail]
04-11 12:03:00.424+0200 E/PKGMGR  (  522): pkgmgr.c: pkgmgr_client_disable(2731) > disable pkg finish, ret=[0]
04-11 12:03:00.439+0200 E/CAPI_TELEPHONY(  522): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-11 12:03:00.574+0200 E/PKGMGR_STATE(29083): pkg_state.c: __pkg_state_enable_pkg(339) > start enable_pkg : pkgid = com.samsung.call
04-11 12:03:00.594+0200 E/PKGMGR_STATE(29083): pkg_state.c: __make_filtered_pkgid_list(317) > pkgid[com.samsung.call] is decided not to broadcast.
04-11 12:03:00.594+0200 E/PKGMGR_STATE(29083): pkg_state.c: __pkg_state_enable_pkg(350) > nothing to broadcast.
04-11 12:03:00.609+0200 E/PKGMGR_SERVER(29079): pkgmgr-server.c: sighandler(486) > child NORMAL exit [29083]
04-11 12:03:00.619+0200 I/AUL     (29040): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
04-11 12:03:00.619+0200 E/AUL     (29040): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
04-11 12:03:00.619+0200 E/AUL     (29040): aul_path.c: __get_path(169) > root_path is NULL!
04-11 12:03:00.634+0200 I/AUL     (29040): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
04-11 12:03:00.649+0200 I/AUL     (29040): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
04-11 12:03:00.649+0200 E/AUL     (29040): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
04-11 12:03:00.649+0200 E/AUL     (29040): aul_path.c: __get_path(169) > root_path is NULL!
04-11 12:03:00.664+0200 I/AUL     (29040): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
04-11 12:03:00.679+0200 I/AUL     (29040): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
04-11 12:03:00.679+0200 E/AUL     (29040): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
04-11 12:03:00.679+0200 E/AUL     (29040): aul_path.c: __get_path(169) > root_path is NULL!
04-11 12:03:00.694+0200 I/AUL     (29040): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
04-11 12:03:00.699+0200 E/PKGMGR_STATE(29084): pkg_state.c: __pkg_state_disable_pkg(420) > start disable_pkg : pkgid = com.samsung.wemail
04-11 12:03:00.714+0200 I/AUL     (29040): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
04-11 12:03:00.714+0200 E/AUL     (29040): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
04-11 12:03:00.714+0200 E/AUL     (29040): aul_path.c: __get_path(169) > root_path is NULL!
04-11 12:03:00.729+0200 I/AUL     (29040): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
04-11 12:03:00.744+0200 E/PKGMGR_STATE(29084): pkg_state.c: __make_filtered_pkgid_list(317) > pkgid[com.samsung.wemail] is decided not to broadcast.
04-11 12:03:00.744+0200 E/PKGMGR_STATE(29084): pkg_state.c: __pkg_state_disable_pkg(431) > nothing to broadcast.
04-11 12:03:00.744+0200 I/AUL     (29040): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
04-11 12:03:00.749+0200 E/AUL     (29040): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
04-11 12:03:00.749+0200 E/AUL     (29040): aul_path.c: __get_path(169) > root_path is NULL!
04-11 12:03:00.774+0200 E/PKGMGR_SERVER(29079): pkgmgr-server.c: sighandler(486) > child NORMAL exit [29084]
04-11 12:03:00.784+0200 I/UXT     (29040): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
04-11 12:03:01.094+0200 W/CRASH_MANAGER(29086): worker.c: worker_job(1205) > 1129058736c65152344098
