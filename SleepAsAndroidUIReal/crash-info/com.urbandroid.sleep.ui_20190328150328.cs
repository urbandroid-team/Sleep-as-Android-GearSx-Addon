S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.2.7
Build-Number: R732XXU2FRC1
Build-Date: 2018.03.02 17:21:30

Crash Information
Process Name: sleepasandroidnativeuiedc
PID: 4629
Date: 2019-03-28 15:03:28+0100
Executable File Path: /opt/usr/apps/com.urbandroid.sleep/bin/sleepasandroidnativeuiedc
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0xf

Register Information
r0   = 0x0000000f, r1   = 0x417ddf30
r2   = 0x414c13a7, r3   = 0x00000000
r4   = 0x0000000f, r5   = 0x417f1b38
r6   = 0x414c13a7, r7   = 0x417e64c8
r8   = 0x0000000f, r9   = 0x00000001
r10  = 0x4004e7e8, fp   = 0x00000000
ip   = 0x40387d88, sp   = 0xbefd92f0
lr   = 0x4036f115, pc   = 0x40772c42
cpsr = 0x20000030

Memory Information
MemTotal:   491132 KB
MemFree:     17464 KB
Buffers:     25232 KB
Cached:     162272 KB
VmPeak:      63076 KB
VmSize:      63072 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       13880 KB
VmRSS:       13880 KB
VmData:       4232 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       22892 KB
VmPTE:          40 KB
VmSwap:          0 KB

Maps Information
40000000 40005000 r-xp /usr/bin/launchpad-loader
4000d000 4002a000 r-xp /lib/ld-2.13.so
40033000 40037000 r-xp /usr/lib/libsys-assert.so
40041000 40047000 r-xp /usr/lib/libappcore-efl.so.1.1
40056000 40063000 r-xp /usr/lib/libaul.so.0.1.0
4006d000 4006f000 r-xp /lib/libdl-2.13.so
40078000 4007b000 r-xp /usr/lib/libbundle.so.0.1.22
40083000 40085000 r-xp /usr/lib/libdlog.so.0.0.0
4008d000 400a1000 r-xp /lib/libpthread-2.13.so
400ac000 401e8000 r-xp /usr/lib/libelementary.so.1.7.99
401ff000 402cd000 r-xp /usr/lib/libevas.so.1.7.99
402f3000 4030a000 r-xp /usr/lib/libecore.so.1.7.99
40321000 4037f000 r-xp /usr/lib/libedje.so.1.7.99
40389000 40459000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
4045a000 40460000 r-xp /usr/lib/libprivilege-control.so.0.0.2
40468000 4046c000 r-xp /usr/lib/libsmack.so.1.0.0
40475000 4047d000 r-xp /lib/libgcc_s-4.6.so.1
4047e000 405a2000 r-xp /lib/libc-2.13.so
405b0000 405ce000 r-xp /usr/lib/libsystemd.so.0.4.0
405d8000 405e3000 r-xp /lib/libunwind.so.8.0.1
40610000 40627000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
4062f000 40659000 r-xp /usr/lib/libdbus-1.so.3.8.12
40662000 40667000 r-xp /usr/lib/libxdgmime.so.1.1.0
4066f000 40692000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
4069a000 4069b000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
406a3000 406a9000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
406b2000 4071b000 r-xp /lib/libm-2.13.so
40724000 4073d000 r-xp /usr/lib/libeet.so.1.7.99
4074e000 4078f000 r-xp /usr/lib/libeina.so.1.7.99
40798000 407ba000 r-xp /usr/lib/libecore_evas.so.1.7.99
407c3000 407c8000 r-xp /usr/lib/libecore_file.so.1.7.99
407d0000 407e1000 r-xp /usr/lib/libecore_input.so.1.7.99
407e9000 407f2000 r-xp /usr/lib/libvconf.so.0.2.45
407fa000 4084a000 r-xp /usr/lib/libecore_x.so.1.7.99
4084c000 40855000 r-xp /usr/lib/libedbus.so.1.7.99
4085d000 40877000 r-xp /usr/lib/libecore_con.so.1.7.99
40880000 40893000 r-xp /usr/lib/libfribidi.so.0.3.1
4089b000 408e0000 r-xp /usr/lib/libharfbuzz.so.0.10200.4
408e9000 40911000 r-xp /usr/lib/libfontconfig.so.1.8.0
40912000 40968000 r-xp /usr/lib/libfreetype.so.6.11.3
40974000 409ca000 r-xp /usr/lib/libpixman-1.so.0.28.2
409d7000 409dd000 r-xp /lib/librt-2.13.so
409e6000 409ed000 r-xp /usr/lib/libembryo.so.1.7.99
409f5000 40a0c000 r-xp /usr/lib/liblua-5.1.so
40a15000 40a1b000 r-xp /usr/lib/libecore_imf.so.1.7.99
40a23000 40a24000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
40a2c000 40a5b000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
40a63000 40a66000 r-xp /lib/libcap.so.2.21
40a6e000 40a86000 r-xp /usr/lib/liblzma.so.5.0.3
40a8e000 40a9e000 r-xp /lib/libresolv-2.13.so
40aa2000 40b75000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
40b80000 40bb4000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
40bbd000 40bd7000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
40bdf000 40c54000 r-xp /usr/lib/libsqlite3.so.0.8.6
40c5e000 40c60000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
40c68000 40c7e000 r-xp /lib/libz.so.1.2.5
40c86000 40ca9000 r-xp /usr/lib/libjpeg.so.8.0.2
40cc1000 40da2000 r-xp /usr/lib/libX11.so.6.3.0
40dad000 40db2000 r-xp /usr/lib/libecore_fb.so.1.7.99
40dbb000 40dbf000 r-xp /usr/lib/libecore_ipc.so.1.7.99
40dc8000 40dcb000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
40dd3000 40dda000 r-xp /usr/lib/libXcursor.so.1.0.2
40de2000 40de4000 r-xp /usr/lib/libXdamage.so.1.1.0
40dec000 40dee000 r-xp /usr/lib/libXcomposite.so.1.0.0
40df6000 40df8000 r-xp /usr/lib/libXgesture.so.7.0.0
40e00000 40e03000 r-xp /usr/lib/libXfixes.so.3.1.0
40e0b000 40e14000 r-xp /usr/lib/libXi.so.6.1.0
40e1c000 40e1d000 r-xp /usr/lib/libXinerama.so.1.0.0
40e26000 40e2c000 r-xp /usr/lib/libXrandr.so.2.2.0
40e34000 40e3a000 r-xp /usr/lib/libXrender.so.1.3.0
40e42000 40e46000 r-xp /usr/lib/libXtst.so.6.1.0
40e4e000 40e58000 r-xp /usr/lib/libXext.so.6.4.0
40e61000 40ea5000 r-xp /usr/lib/libcurl.so.4.3.0
40eae000 40ec4000 r-xp /lib/libexpat.so.1.6.0
40ece000 40ee6000 r-xp /usr/lib/libpng12.so.0.50.0
40eee000 40f0b000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
40f14000 40fa8000 r-xp /usr/lib/libstdc++.so.6.0.16
40fbb000 40fbe000 r-xp /lib/libattr.so.1.1.0
40fc6000 40fc7000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
40fcf000 40fd4000 r-xp /usr/lib/libffi.so.5.0.10
40fdd000 40fdf000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
40fe7000 410b3000 r-xp /usr/lib/libxml2.so.2.7.8
410c0000 410c2000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
410cb000 410cd000 r-xp /usr/lib/journal/libjournal.so.0.1.0
410d5000 410e8000 r-xp /usr/lib/libxcb.so.1.1.0
410f2000 410fb000 r-xp /usr/lib/libcares.so.2.1.0
41104000 41132000 r-xp /usr/lib/libidn.so.11.5.44
4113a000 41181000 r-xp /usr/lib/libssl.so.1.0.0
4118d000 4131f000 r-xp /usr/lib/libcrypto.so.1.0.0
41341000 41343000 r-xp /usr/lib/libiri.so
4134b000 41352000 r-xp /lib/libcrypt-2.13.so
41382000 41384000 r-xp /usr/lib/libXau.so.6.0.0
41491000 41495000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
4149d000 414a5000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
414a7000 414ac000 r-xp /usr/lib/libappcore-common.so.1.1
414b4000 414b6000 r-xp /usr/lib/libiniparser.so.0
414bf000 414c2000 r-xp /opt/usr/apps/com.urbandroid.sleep/bin/sleepasandroidnativeuiedc
414d5000 414d9000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
414e2000 414e4000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
414ed000 414f3000 r-xp /usr/lib/libappsvc.so.0.1.0
414fb000 4151f000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
41528000 415f7000 r-xp /usr/lib/libscim-1.0.so.8.2.3
4160d000 41617000 r-xp /lib/libnss_files-2.13.so
418b4000 418bf000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
418ca000 418eb000 r-xp /usr/lib/libefl-extension.so.0.1.0
418f3000 41905000 r-xp /usr/lib/libefl-assist.so.0.1.0
4190d000 419c5000 r-xp /usr/lib/libcairo.so.2.11200.14
419d0000 419e6000 r-xp /usr/lib/libtts.so
419ef000 41a12000 r-xp /usr/lib/libui-extension.so.0.1.0
41a1b000 41a26000 r-xp /usr/lib/libtbm.so.1.0.0
41a2e000 41a3c000 r-xp /usr/lib/libGLESv2.so.2.0
41a45000 41a46000 r-xp /usr/lib/libxcb-shm.so.0.0.0
41a4f000 41a55000 r-xp /usr/lib/libxcb-render.so.0.0.0
41a5d000 41a60000 r-xp /usr/lib/libEGL.so.1.4
41a68000 41a6d000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
41a75000 41a78000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
41a80000 41a81000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
41a8a000 41c12000 r-xp /usr/lib/libicui18n.so.57.1
41c22000 41d28000 r-xp /usr/lib/libicuuc.so.57.1
41d3e000 41d46000 r-xp /usr/lib/libdrm.so.2.4.0
41d4e000 41d50000 r-xp /usr/lib/libdri2.so.0.0.0
41d58000 41d5e000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
41d66000 41d6b000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
41d73000 41d8c000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
4362d000 4364e000 r-xp /usr/lib/libexif.so.12.3.3
43661000 43663000 r-xp /usr/lib/libttrace.so.1.1
4366b000 43670000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
43678000 4367e000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
43687000 4368f000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
43697000 436b9000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
436c2000 436c9000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
436d2000 436d4000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
436dc000 436e3000 r-xp /usr/lib/libminizip.so.1.0.0
436eb000 436f8000 r-xp /usr/lib/libail.so.0.1.0
43701000 43707000 r-xp /usr/lib/libproc-stat.so.0.2.96
4370f000 43710000 r-xp /usr/lib/libresponse.so.0.2.96
43718000 4371d000 r-xp /usr/lib/libsystem.so.0.0.0
43727000 437f1000 r-xp /usr/lib/libCOREGL.so.4.0
43b22000 43b2d000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43b36000 43b3b000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43b43000 43b5a000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
befb9000 befda000 rw-p [stack]
End of Maps Information

Callstack Information (PID:4629)
Call Stack Count: 1
 0: eina_stringshare_add + 0x5 (0x40772c42) [/usr/lib/libeina.so.1] + 0x24c42
End of Call Stack

Package Information
Package Name: com.urbandroid.sleep
Package ID : com.urbandroid.sleep
Version: 1.0.12
Package Type: rpm
App Name: Sleep
App ID: com.urbandroid.sleep.ui
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
: menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/sapd, ret : 0
03-28 15:03:25.351+0100 I/AUL_AMD (  520): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/sapd, ret : 0
03-28 15:03:25.351+0100 E/AUL_AMD (  520): amd_launch.c: _start_app(1772) > no caller appid info, ret: -1
03-28 15:03:25.351+0100 W/AUL_AMD (  520): amd_launch.c: _start_app(1782) > caller pid : 518
03-28 15:03:25.371+0100 W/AUL_AMD (  520): amd_launch.c: start_process(606) > child process: 4645
03-28 15:03:25.376+0100 W/W_INDICATOR(  736): windicator_scs.c: windicator_scs_update(123) > [windicator_scs_update:123] sales code : 0
03-28 15:03:25.376+0100 W/W_INDICATOR(  736): windicator_scs.c: windicator_scs_update(131) > [windicator_scs_update:131] sap connected : 1
03-28 15:03:25.376+0100 W/W_INDICATOR(  736): windicator_scs.c: windicator_scs_update(146) > [windicator_scs_update:146] ciss_request_type : 0
03-28 15:03:25.376+0100 I/W_INDICATOR(  736): windicator_scs.c: windicator_scs_update(155) > [windicator_scs_update:155] Hide (Callforwarding requested)
03-28 15:03:25.376+0100 I/W_INDICATOR(  736): windicator.c: windicator_is_lo_connected(976) > [windicator_is_lo_connected:976] Connected target vendor : HMD Global
03-28 15:03:25.376+0100 W/W_INDICATOR(  736): windicator_scs.c: windicator_scs_update(195) > [windicator_scs_update:195] sap connectivity type : 1
03-28 15:03:25.376+0100 W/W_INDICATOR(  736): windicator_scs.c: windicator_scs_update(203) > [windicator_scs_update:203] network status : 3
03-28 15:03:25.376+0100 W/W_INDICATOR(  736): windicator_scs.c: windicator_scs_update(220) > [windicator_scs_update:220] scs login : 0
03-28 15:03:25.376+0100 W/W_INDICATOR(  736): windicator_scs.c: windicator_scs_update(261) > [windicator_scs_update:261] connected via bluetooth
03-28 15:03:25.406+0100 I/magazine-service(  973): magazine-service-connection.c: _magazine_service_connection_vconf_key_changed_cb(183) > host_connected changed [1] -> [1]
03-28 15:03:25.421+0100 W/AUL_AMD (  520): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 4645
03-28 15:03:25.421+0100 W/AUL     (  520): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(com.samsung.w-calendar2-consumer) pid(4645) type(svcapp) bg(0)
03-28 15:03:25.421+0100 W/AUL_AMD (  520): amd_request.c: __request_handler(669) > __request_handler: 14
03-28 15:03:25.431+0100 W/AUL_AMD (  520): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
03-28 15:03:25.431+0100 W/AUL_AMD (  520): amd_request.c: __request_handler(669) > __request_handler: 14
03-28 15:03:25.436+0100 W/AUL     (  518): launch.c: app_request_to_launchpad(284) > request cmd(26) to(com.samsung.w-contacts2.consumer)
03-28 15:03:25.436+0100 W/AUL     (  518): launch.c: app_request_to_launchpad(298) > request cmd(26) result(0)
03-28 15:03:25.441+0100 W/AUL_AMD (  520): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 4641
03-28 15:03:25.441+0100 W/AUL_AMD (  520): amd_request.c: __request_handler(669) > __request_handler: 26
03-28 15:03:25.456+0100 I/AUL_AMD (  520): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/sapd, ret : 0
03-28 15:03:25.461+0100 W/STARTER (  733): pkg-monitor.c: _app_mgr_status_cb(400) > [_app_mgr_status_cb:400] Launch request [4645]
03-28 15:03:25.466+0100 I/AUL_AMD (  520): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/sapd, ret : 0
03-28 15:03:25.466+0100 E/AUL_AMD (  520): amd_launch.c: _start_app(1772) > no caller appid info, ret: -1
03-28 15:03:25.466+0100 W/AUL_AMD (  520): amd_launch.c: _start_app(1782) > caller pid : 518
03-28 15:03:25.481+0100 W/AUL_AMD (  520): amd_launch.c: start_process(606) > child process: 4648
03-28 15:03:25.511+0100 W/MSG_CONSUMER( 1403): SapClient.cpp: _onWmsConnectionChanged(810) > [0;35mprevious_status: (1), status: (1)[0;m
03-28 15:03:25.511+0100 W/MSG_CONSUMER( 1403): SapClient.cpp: _onWmsConnectionChanged(813) > [0;35m_onWmsConnectionChanged() is ignored for same status change. prev:(1), cur:(1)[0;m
03-28 15:03:25.531+0100 W/AUL_AMD (  520): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 4648
03-28 15:03:25.531+0100 W/AUL     (  520): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(com.samsung.w-contacts2.consumer) pid(4648) type(svcapp) bg(0)
03-28 15:03:25.531+0100 W/AUL_AMD (  520): amd_request.c: __request_handler(669) > __request_handler: 14
03-28 15:03:25.536+0100 W/STARTER (  733): pkg-monitor.c: _app_mgr_status_cb(400) > [_app_mgr_status_cb:400] Launch request [4648]
03-28 15:03:25.541+0100 W/AUL_AMD (  520): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 1378
03-28 15:03:25.541+0100 W/AUL_AMD (  520): amd_request.c: __request_handler(669) > __request_handler: 12
03-28 15:03:25.546+0100 W/AUL_AMD (  520): amd_request.c: __request_handler(669) > __request_handler: 14
03-28 15:03:25.551+0100 W/AUL_AMD (  520): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 1024
03-28 15:03:25.556+0100 W/AUL_AMD (  520): amd_request.c: __request_handler(669) > __request_handler: 14
03-28 15:03:25.561+0100 W/AUL_AMD (  520): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
03-28 15:03:25.561+0100 W/AUL     (  518): launch.c: app_request_to_launchpad(284) > request cmd(26) to(com.samsung.w-music-transfer.consumer)
03-28 15:03:25.561+0100 W/AUL     (  518): launch.c: app_request_to_launchpad(298) > request cmd(26) result(0)
03-28 15:03:25.561+0100 W/AUL_AMD (  520): amd_request.c: __request_handler(669) > __request_handler: 26
03-28 15:03:25.576+0100 I/AUL_AMD (  520): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/sapd, ret : 0
03-28 15:03:25.586+0100 I/AUL_AMD (  520): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/sapd, ret : 0
03-28 15:03:25.586+0100 E/AUL_AMD (  520): amd_launch.c: _start_app(1772) > no caller appid info, ret: -1
03-28 15:03:25.586+0100 W/AUL_AMD (  520): amd_launch.c: _start_app(1782) > caller pid : 518
03-28 15:03:25.601+0100 W/AUL_AMD (  520): amd_launch.c: start_process(606) > child process: 4652
03-28 15:03:25.651+0100 W/AUL_AMD (  520): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 4652
03-28 15:03:25.651+0100 W/AUL     (  520): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(com.samsung.w-music-transfer.consumer) pid(4652) type(svcapp) bg(0)
03-28 15:03:25.651+0100 W/AUL_AMD (  520): amd_request.c: __request_handler(669) > __request_handler: 14
03-28 15:03:25.656+0100 W/STARTER (  733): pkg-monitor.c: _app_mgr_status_cb(400) > [_app_mgr_status_cb:400] Launch request [4652]
03-28 15:03:25.661+0100 W/AUL_AMD (  520): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
03-28 15:03:25.661+0100 W/AUL_AMD (  520): amd_request.c: __request_handler(669) > __request_handler: 14
03-28 15:03:25.666+0100 W/AUL     (  518): launch.c: app_request_to_launchpad(284) > request cmd(26) to(com.samsung.w-voicerecorder.consumer)
03-28 15:03:25.666+0100 W/AUL     (  518): launch.c: app_request_to_launchpad(298) > request cmd(26) result(0)
03-28 15:03:25.671+0100 W/AUL_AMD (  520): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 4645
03-28 15:03:25.676+0100 W/AUL_AMD (  520): amd_request.c: __request_handler(669) > __request_handler: 26
03-28 15:03:25.686+0100 I/AUL_AMD (  520): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/sapd, ret : 0
03-28 15:03:25.701+0100 I/AUL_AMD (  520): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/sapd, ret : 0
03-28 15:03:25.701+0100 E/AUL_AMD (  520): amd_launch.c: _start_app(1772) > no caller appid info, ret: -1
03-28 15:03:25.701+0100 W/AUL_AMD (  520): amd_launch.c: _start_app(1782) > caller pid : 518
03-28 15:03:25.711+0100 W/AUL_AMD (  520): amd_launch.c: start_process(606) > child process: 4655
03-28 15:03:25.711+0100 E/RESOURCED(  649): block.c: block_prelaunch_state(138) > insert data com.samsung.voicememo-c1, table num : 4
03-28 15:03:25.751+0100 I/efl-extension( 4630): efl_extension.c: eext_mod_init(40) > Init
03-28 15:03:25.761+0100 W/AUL_AMD (  520): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 4655
03-28 15:03:25.761+0100 W/AUL     (  520): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(com.samsung.w-voicerecorder.consumer) pid(4655) type(svcapp) bg(0)
03-28 15:03:25.761+0100 W/AUL_AMD (  520): amd_request.c: __request_handler(669) > __request_handler: 14
03-28 15:03:25.771+0100 W/AUL_AMD (  520): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
03-28 15:03:25.771+0100 W/AUL_AMD (  520): amd_request.c: __request_handler(669) > __request_handler: 12
03-28 15:03:25.776+0100 W/STARTER (  733): pkg-monitor.c: _app_mgr_status_cb(400) > [_app_mgr_status_cb:400] Launch request [4655]
03-28 15:03:25.776+0100 W/AUL     (  518): launch.c: app_request_to_launchpad(284) > request cmd(26) to(com.samsung.weather-consumer)
03-28 15:03:25.776+0100 W/AUL     (  518): launch.c: app_request_to_launchpad(298) > request cmd(26) result(0)
03-28 15:03:25.781+0100 W/AUL_AMD (  520): amd_request.c: __request_handler(669) > __request_handler: 26
03-28 15:03:25.796+0100 I/AUL_AMD (  520): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/sapd, ret : 0
03-28 15:03:25.811+0100 I/AUL_AMD (  520): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/sapd, ret : 0
03-28 15:03:25.811+0100 E/AUL_AMD (  520): amd_launch.c: _start_app(1772) > no caller appid info, ret: -1
03-28 15:03:25.811+0100 W/AUL_AMD (  520): amd_launch.c: _start_app(1782) > caller pid : 518
03-28 15:03:25.821+0100 W/AUL_AMD (  520): amd_launch.c: start_process(606) > child process: 4660
03-28 15:03:25.871+0100 W/AUL_AMD (  520): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 4660
03-28 15:03:25.871+0100 W/AUL     (  520): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(com.samsung.weather-consumer) pid(4660) type(svcapp) bg(0)
03-28 15:03:25.876+0100 W/AUL_AMD (  520): amd_request.c: __request_handler(669) > __request_handler: 14
03-28 15:03:25.881+0100 W/AUL_AMD (  520): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 4648
03-28 15:03:25.896+0100 W/AUL_AMD (  520): amd_request.c: __request_handler(669) > __request_handler: 12
03-28 15:03:25.906+0100 W/STARTER (  733): pkg-monitor.c: _app_mgr_status_cb(400) > [_app_mgr_status_cb:400] Launch request [4660]
03-28 15:03:25.921+0100 W/AUL_AMD (  520): amd_request.c: __request_handler(669) > __request_handler: 14
03-28 15:03:25.926+0100 W/AUL_AMD (  520): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 4652
03-28 15:03:25.931+0100 W/AUL_AMD (  520): amd_request.c: __request_handler(669) > __request_handler: 12
03-28 15:03:25.946+0100 W/AUL_AMD (  520): amd_request.c: __request_handler(669) > __request_handler: 14
03-28 15:03:25.956+0100 W/AUL_AMD (  520): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 4655
03-28 15:03:25.956+0100 W/AUL_AMD (  520): amd_request.c: __request_handler(669) > __request_handler: 12
03-28 15:03:25.971+0100 W/AUL_AMD (  520): amd_request.c: __request_handler(669) > __request_handler: 14
03-28 15:03:25.981+0100 W/AUL_AMD (  520): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 4660
03-28 15:03:25.981+0100 W/AUL_AMD (  520): amd_request.c: __request_handler(669) > __request_handler: 12
03-28 15:03:26.001+0100 W/MC_CONSUMER( 1024): wmc-service-consumer.c: wmc_service_consumer_send_data(598) > [33m {"msgId":"music-queue-req"}[0m
03-28 15:03:26.006+0100 E/WMS     (  519): wms_msg_broker.c: on_broker_buffer_send(307) > Data sending is success.
03-28 15:03:26.056+0100 W/WG-CONSUMER( 1378): [34m[F:ConnectionInfo.c L:  418][_HIGH][TX]Finding Peer Agent. AgentID=9994[0m
03-28 15:03:26.056+0100 W/WG-CONSUMER( 1378): [34m[F:ConnectionInfo.c L:  190][_HIGH][RX]CConnection::Connect() State:SM_STATE_ESTABLISHED[0m
03-28 15:03:26.056+0100 W/WG-CONSUMER( 1378): [34m[F:SAPProxy.cpp     L:  147][_HIGH]CSAPProxy::Connect. Size=2 pConnection=0x43308080[0m
03-28 15:03:26.056+0100 W/WG-CONSUMER( 1378): [34m[F:SAPProxy.cpp     L:  150][_HIGH]  Connection : [TX] LocalAgentID:9994 ServiceHandle:0[0m
03-28 15:03:26.056+0100 W/WG-CONSUMER( 1378): [34m[F:SAPProxy.cpp     L:  150][_HIGH]  Connection : [RX] LocalAgentID:9995 ServiceHandle:64663[0m
03-28 15:03:26.056+0100 E/WG-CONSUMER( 1378): [31m[F:SAPProxy.cpp     L:  161][ERROR]Duplication connection. not inseterd[0m
03-28 15:03:26.056+0100 E/WG-CONSUMER( 1378): [31m[F:SAPProxy.cpp     L:  165][ERROR]Previous pCurrent(0x4332bc00) is exist[0m
03-28 15:03:26.076+0100 W/WG-CONSUMER( 1378): [34m[F:SAPProxy.cpp     L:  601][_HIGH]Device Connected. Cur type=BT|[0m
03-28 15:03:26.076+0100 W/WG-CONSUMER( 1378): [34m[F:SAPProxy.cpp     L:  186][_HIGH]Device connected. WMS=1 BT=1 [0m
03-28 15:03:26.076+0100 W/WG-CONSUMER( 1378): [34m[F:ConnectionInfo.c L:  568][_HIGH][RX]advance. CurState=SM_STATE_ESTABLISHED(8)[0m
03-28 15:03:26.076+0100 W/WG-CONSUMER( 1378): [34m[F:ConnectionInfo.c L:  590][_HIGH]Already established.[0m
03-28 15:03:26.076+0100 W/WG-CONSUMER( 1378): [32m[F:SAPProxy.cpp     L:  830][_WARN]OnPeerAgent:Found Peer. LocalAgentID[9994], pPeerAgent[0x43335fb8], wStatusCode=PEER_AGENT_FOUND[0m
03-28 15:03:26.076+0100 W/WG-CONSUMER( 1378): [32m[F:ConnectionInfo.c L:  945][_WARN][TX]FoundPeer. LocalAgentID[9994], pPeerAgent[0x43335fb8], wStatusCode=PEER_AGENT_FOUND[0m
03-28 15:03:26.076+0100 W/WG-CONSUMER( 1378): [34m[F:PeerList.cpp     L:  255][_HIGH][TX]Add CPeerAgent(0xbecb00e4) into PeerList. Count=0[0m
03-28 15:03:26.076+0100 W/WG-CONSUMER( 1378): [34m[F:PeerList.cpp     L:  100][_HIGH][TX]***** Dump Peer - "Added" *****[0m
03-28 15:03:26.076+0100 W/WG-CONSUMER( 1378): [34m[F:PeerList.cpp     L:  103][_HIGH][TX]This=0x43c00770 PeerAgent(0x43c00774) bSet(1)[0m
03-28 15:03:26.076+0100 W/WG-CONSUMER( 1378): [34m[F:PeerList.cpp     L:  104][_HIGH][TX]  DeviceID=1 PeerAgentID=61250 ServiceHandle=0[0m
03-28 15:03:26.076+0100 W/WG-CONSUMER( 1378): [34m[F:PeerList.cpp     L:  106][_HIGH][TX]  DeviceName=* MAC=* ALE=HostManager ASPID=* Version=2.1[0m
03-28 15:03:26.076+0100 W/WG-CONSUMER( 1378): [34m[F:PeerList.cpp     L:  107][_HIGH][TX]  ConnectType(1) : BT[0m
03-28 15:03:26.076+0100 W/WG-CONSUMER( 1378): [34m[F:PeerList.cpp     L:  111][_HIGH][TX]***********************************[0m
03-28 15:03:26.076+0100 W/WG-CONSUMER( 1378): [34m[F:ConnectionInfo.c L:  977][_HIGH][TX]Add timer for next Peer for 0.5s[0m
03-28 15:03:26.076+0100 W/WG-CONSUMER( 1378): [34m[F:ConnectionInfo.c L:  603][_HIGH][TX]State changed: SM_STATE_FINDING_PEER->SM_STATE_FOUND_PEER[0m
03-28 15:03:26.076+0100 W/WG-CONSUMER( 1378): [34m[F:ConnectionInfo.c L:  568][_HIGH][TX]advance. CurState=SM_STATE_FOUND_PEER(6)[0m
03-28 15:03:26.076+0100 W/WG-CONSUMER( 1378): [34m[F:ConnectionInfo.c L:  603][_HIGH][TX]State changed: SM_STATE_FOUND_PEER->SM_STATE_REQUEST_SERVICE[0m
03-28 15:03:26.076+0100 W/WG-CONSUMER( 1378): [34m[F:ConnectionInfo.c L:  438][_HIGH][TX]Connect to BT Peer[0m
03-28 15:03:26.076+0100 W/WG-CONSUMER( 1378): [34m[F:PeerList.cpp     L:  100][_HIGH][TX]***** Dump Peer - "BestPeer" *****[0m
03-28 15:03:26.076+0100 W/WG-CONSUMER( 1378): [34m[F:PeerList.cpp     L:  103][_HIGH][TX]This=0x43c00770 PeerAgent(0x43c00774) bSet(1)[0m
03-28 15:03:26.076+0100 W/WG-CONSUMER( 1378): [34m[F:PeerList.cpp     L:  104][_HIGH][TX]  DeviceID=1 PeerAgentID=61250 ServiceHandle=0[0m
03-28 15:03:26.076+0100 W/WG-CONSUMER( 1378): [34m[F:PeerList.cpp     L:  106][_HIGH][TX]  DeviceName=* MAC=* ALE=HostManager ASPID=* Version=2.1[0m
03-28 15:03:26.076+0100 W/WG-CONSUMER( 1378): [34m[F:PeerList.cpp     L:  107][_HIGH][TX]  ConnectType(1) : BT[0m
03-28 15:03:26.076+0100 W/WG-CONSUMER( 1378): [34m[F:PeerList.cpp     L:  111][_HIGH][TX]***********************************[0m
03-28 15:03:26.076+0100 W/WG-CONSUMER( 1378): [34m[F:ConnectionInfo.c L:  461][_HIGH][TX]CreateServiceConnection. for LocalAgentID=9994 to Peer(0x43c00770)[0m
03-28 15:03:26.326+0100 W/MC_CONSUMER( 1024): wmc-service-consumer.c: wmc_service_consumer_send_data(598) > [33m {"msgId":"music-getattribute-req"}[0m
03-28 15:03:26.346+0100 E/WMS     (  519): wms_msg_broker.c: on_broker_buffer_send(307) > Data sending is success.
03-28 15:03:26.366+0100 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_log_package(4750) > package [_________] callback : [INSTALL, COMPLETED]
03-28 15:03:26.366+0100 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(7086) > package install complete
03-28 15:03:26.366+0100 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_package_install_event(5040) > 
03-28 15:03:26.366+0100 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(2046) > Found in install_req_list?[0], index[-1]
03-28 15:03:26.366+0100 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_package_install_event(5066) > triggered from Gear itself.
03-28 15:03:26.486+0100 W/MUSIC_CONTROL_SERVICE( 1024): music-control-consumer-control.c: _music_control_consumer_control_print_msg_type(105) > [33m[TID:1024]   msg [WMC_SERVICE_WIPC_MSG_ID_CAPABILITY_FEATURE_RESPONSE][0m
03-28 15:03:26.486+0100 W/MUSIC_CONTROL_SERVICE( 1024): music-control-consumer-control.c: music_control_consumer_msg_process(243) > [36m[TID:1024]   [MUSIC_PLAYER_EVENT]Device State [2] normal:0 dim:1 off:2[0m
03-28 15:03:26.486+0100 W/MUSIC_CONTROL_SERVICE( 1024): music-control-consumer-control.c: music_control_consumer_media_changed_ind_request(199) > [33m[TID:1024]   remote mode[1],resume[0][0m
03-28 15:03:26.486+0100 W/MC_CONSUMER( 1024): wmc-service-consumer.c: wmc_service_consumer_send_data(598) > [33m {"msgId":"music-mediachanged-req","value":"false"}[0m
03-28 15:03:26.491+0100 E/WMS     (  519): wms_msg_broker.c: wms_msg_broker_send(1826) > 
03-28 15:03:26.491+0100 E/WMS     (  519): ==========
03-28 15:03:26.491+0100 E/WMS     (  519): ##WMS SEND : mgr_wapps_install_res
03-28 15:03:26.491+0100 E/WMS     (  519): ==========
03-28 15:03:26.491+0100 E/WMS     (  519): wms_msg_broker.c: wms_msg_broker_send(1842) > Data size: 10875 MAX Buffer Size: 61440
03-28 15:03:26.536+0100 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_pkgmgrinfo_meta_data(2060) > metadata_key(playstore): master_app_playstore_deeplink, value: market://details?id=com.urbandroid.sleep.addon.generic.samsung
03-28 15:03:26.536+0100 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_send_mgr_wapps_install_res(2845) > Fail to get store_package_name
03-28 15:03:26.536+0100 E/WMS     (  519): wms_event_handler.c: wms_event_handler_send_master_app_deeplink(9075) > urls- master_app_playstore_deeplink: market://details?id=com.urbandroid.sleep.addon.generic.samsung
03-28 15:03:26.536+0100 E/WMS     (  519): wms_msg_broker.c: wms_msg_broker_send(1826) > 
03-28 15:03:26.536+0100 E/WMS     (  519): ==========
03-28 15:03:26.536+0100 E/WMS     (  519): ##WMS SEND : mgr_master_app_deeplink_req
03-28 15:03:26.536+0100 E/WMS     (  519): ==========
03-28 15:03:26.536+0100 E/WMS     (  519): wms_msg_broker.c: wms_msg_broker_send(1842) > Data size: 307 MAX Buffer Size: 61440
03-28 15:03:26.536+0100 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_send_mgr_wapps_install_res(2892) > send_install_response completed : END
03-28 15:03:26.621+0100 W/MUSIC_CONTROL_SERVICE( 1024): music-control-consumer-control.c: music_control_consumer_msg_process(381) > [33m[TID:1024]   distinct state = 0, max vol[15], safety_vol[0][0m
03-28 15:03:26.626+0100 W/MUSIC_PLAYER( 1024): mp-weconn.c: _wms_connection_vconf_changed_callback(93) > [33m[TID:1024]   [1][0m
03-28 15:03:26.626+0100 W/MC_CONSUMER( 1024): wmc-service-cotroller.c: _bt_connection_changed_cb(60) > [33m connected[1][0m
03-28 15:03:26.641+0100 W/MC_CONSUMER( 1024): wmc-service-consumer.c: __wmc_on_data_ind(386) > [33m length : [122][{"appId":"com.spotify.music","msgId":"music-playstatechange-rsp","result":"success","reason":0,"playstate":1,"position":0}][0m
03-28 15:03:26.641+0100 W/MUSIC_CONTROL_SERVICE( 1024): music-control-consumer-control.c: _music_control_consumer_control_print_msg_type(105) > [33m[TID:1024]   msg [WMC_SERVICE_WIPC_MSG_ID_PLAY_STATE_CHANGE_RESPONSE][0m
03-28 15:03:26.641+0100 W/MUSIC_CONTROL_SERVICE( 1024): music-control-consumer-control.c: music_control_consumer_msg_process(243) > [36m[TID:1024]   [MUSIC_PLAYER_EVENT]Device State [2] normal:0 dim:1 off:2[0m
03-28 15:03:26.641+0100 W/MUSIC_CONTROL_SERVICE( 1024): music-control-consumer-control.c: music_control_consumer_media_changed_ind_request(199) > [33m[TID:1024]   remote mode[1],resume[0][0m
03-28 15:03:26.641+0100 W/MUSIC_CONTROL_SERVICE( 1024): music-control-consumer-control.c: music_control_consumer_msg_process(393) > [33m[TID:1024]   player state = 0[0m
03-28 15:03:26.641+0100 W/MUSIC_CONTROL_SERVICE( 1024): music-control-info.c: music_control_info_set_player_state(423) > [33m[TID:1024]   mode = [1], player state = [2][0m
03-28 15:03:26.641+0100 W/MUSIC_CONTROL_SERVICE( 1024): music-control-media-controller.c: music_control_media_controller_set_playback_state(74) > [33m[TID:1024]   state[2], 1:playing[0m
03-28 15:03:26.641+0100 W/CAPI_MEDIA_CONTROLLER( 1024): media_controller_server.c: mc_server_set_playback_state(284) > [0m<Enter>
03-28 15:03:26.641+0100 W/CAPI_MEDIA_CONTROLLER( 1024): media_controller_server.c: mc_server_set_playback_state(290) > [0mplayback state update [2]
03-28 15:03:26.641+0100 W/CAPI_MEDIA_CONTROLLER( 1024): media_controller_server.c: mc_server_set_playback_state(295) > [0m<Leave>
03-28 15:03:26.646+0100 W/MUSIC_CONTROL_SERVICE( 1024): music-control-media-controller.c: music_control_media_controller_update_playback_info(138) > [36m[TID:1024]   [MUSIC_PLAYER_EVENT]update playback info[0m
03-28 15:03:26.646+0100 W/CAPI_MEDIA_CONTROLLER( 1024): media_controller_server.c: mc_server_update_playback_info(326) > [0m<Enter>
03-28 15:03:26.646+0100 W/CAPI_MEDIA_CONTROLLER( 1024): media_controller_server.c: mc_server_update_playback_info(331) > [0mplayback info update: state [2], position [0]
03-28 15:03:26.656+0100 W/CAPI_MEDIA_CONTROLLER( 1024): media_controller_server.c: mc_server_update_playback_info(353) > [0m<Leave>
03-28 15:03:26.666+0100 W/MUSIC_CONTROL_SERVICE( 1024): music-control-message.c: music_control_message_send_player_state_changed_ind(255) > [36m[TID:1024]   [MUSIC_PLAYER_EVENT][0m
03-28 15:03:26.666+0100 W/W_INDICATOR(  736): windicator_ongoing_info_music.c: _player_playback_updated_cb(134) > [_player_playback_updated_cb:134] Playback is updated. [com.samsung.w-music-player.music-control-service][2]
03-28 15:03:26.666+0100 W/MC_CONSUMER( 1024): wmc-service-consumer.c: __wmc_on_data_ind(386) > [33m length : [118][{"appId":"com.spotify.music","msgId":"music-mediachanged-ind","result":"success","reason":0,"index":"-1","duration":0}][0m
03-28 15:03:26.666+0100 W/MUSIC_CONTROL_SERVICE( 1024): music-control-consumer-control.c: _music_control_consumer_control_print_msg_type(105) > [33m[TID:1024]   msg [WMC_SERVICE_WIPC_MSG_ID_MEDIA_CHANGED_IND][0m
03-28 15:03:26.666+0100 W/MUSIC_CONTROL_SERVICE( 1024): music-control-consumer-control.c: music_control_consumer_msg_process(243) > [36m[TID:1024]   [MUSIC_PLAYER_EVENT]Device State [2] normal:0 dim:1 off:2[0m
03-28 15:03:26.666+0100 W/MUSIC_CONTROL_SERVICE( 1024): music-control-consumer-control.c: music_control_consumer_media_changed_ind_request(199) > [33m[TID:1024]   remote mode[1],resume[0][0m
03-28 15:03:26.666+0100 W/MC_CONSUMER( 1024): wmc-service-consumer.c: __wmc_on_data_ind(386) > [33m length : [132][{"appId":"com.spotify.music","msgId":"music-queuechanged-ind","result":"success","reason":0,"appName":"Spotify","count":0,"list":[]}-][0m
03-28 15:03:26.666+0100 W/MC_CONSUMER( 1024): wmc-service-cotroller.c: _write_queue_list_data(567) > [33m same queue data![0m
03-28 15:03:26.666+0100 W/MC_CONSUMER( 1024): wmc-service-consumer.c: __wmc_on_data_ind(386) > [33m length : [132][{"appId":"com.spotify.music","msgId":"music-queuechanged-ind","result":"success","reason":0,"appName":"Spotify","count":0,"list":[]}-][0m
03-28 15:03:26.666+0100 W/MC_CONSUMER( 1024): wmc-service-cotroller.c: _write_queue_list_data(567) > [33m same queue data![0m
03-28 15:03:26.726+0100 W/MC_CONSUMER( 1024): wmc-service-consumer.c: __wmc_on_data_ind(386) > [33m length : [128][{"msgId":"music-getattribute-rsp","result":"success","reason":0,"repeat":"repeatoff","shuffle":"off","volume":0,"earjack":false}][0m
03-28 15:03:26.726+0100 W/MUSIC_CONTROL_SERVICE( 1024): music-control-consumer-control.c: _music_control_consumer_control_print_msg_type(105) > [33m[TID:1024]   msg [WMC_SERVICE_WIPC_MSG_ID_GET_ATTRIBUTE_RESPONSE][0m
03-28 15:03:26.726+0100 W/MUSIC_CONTROL_SERVICE( 1024): music-control-consumer-control.c: music_control_consumer_msg_process(243) > [36m[TID:1024]   [MUSIC_PLAYER_EVENT]Device State [2] normal:0 dim:1 off:2[0m
03-28 15:03:26.726+0100 W/MUSIC_CONTROL_SERVICE( 1024): music-control-consumer-control.c: music_control_consumer_media_changed_ind_request(199) > [33m[TID:1024]   remote mode[1],resume[0][0m
03-28 15:03:26.726+0100 W/MUSIC_CONTROL_SERVICE( 1024): music-control-consumer-control.c: music_control_consumer_msg_process(330) > [33m[TID:1024]   volume = 0, earjack = 0[0m
03-28 15:03:26.751+0100 E/WMS     (  519): wms_msg_broker.c: on_broker_buffer_send(307) > Data sending is success.
03-28 15:03:26.821+0100 E/PKGMGR_SERVER( 4616): pkgmgr-server.c: exit_server(1620) > exit_server Start [backend_status=0, queue_status=0] 
03-28 15:03:26.846+0100 W/AUL_AMD (  520): amd_request.c: __request_handler(669) > __request_handler: 14
03-28 15:03:26.846+0100 E/WMS     (  519): wms_msg_broker.c: on_broker_buffer_send(307) > Data sending is success.
03-28 15:03:26.851+0100 W/AUL_AMD (  520): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 4641
03-28 15:03:26.871+0100 W/WG-CONSUMER( 1378): [32m[F:SAPProxy.cpp     L: 1059][_WARN][Phone->Gear] Connection Confirmed. wResponseCode : [0], uwLocalAgentId : [9994] uwServiceHandle : [42576] PeerAgent(0x43c01220)[0m
03-28 15:03:26.871+0100 W/WG-CONSUMER( 1378): [34m[F:ConnectionInfo.c L: 1128][_HIGH][TX]connection established. AgentID(9994) ServiceHandle=42576 SM_STATE_REQUEST_SERVICE bUsingWFD=0[0m
03-28 15:03:26.871+0100 W/WG-CONSUMER( 1378): [34m[F:ConnectionInfo.c L: 1147][_HIGH][TX] ConnectionType is BT. Update ServiceHandle. (0->42576)[0m
03-28 15:03:26.871+0100 W/WG-CONSUMER( 1378): [34m[F:ConnectionInfo.c L: 1151][_HIGH][TX]Connection Established. ServiceID=42576[0m
03-28 15:03:26.871+0100 W/WG-CONSUMER( 1378): [34m[F:ConnectionInfo.c L:  603][_HIGH][TX]State changed: SM_STATE_REQUEST_SERVICE->SM_STATE_ESTABLISHED[0m
03-28 15:03:26.871+0100 W/WG-CONSUMER( 1378): [32m[F:TransferCtrl.cpp L:  222][_WARN][TX]CTransferCtrl::OnEstablished[0m
03-28 15:03:26.871+0100 W/WG-CONSUMER( 1378): [34m[F:UserNotification L:  389][_HIGH][Transfer->User] sendNotification *[0m
03-28 15:03:26.876+0100 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
03-28 15:03:26.876+0100 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
03-28 15:03:26.876+0100 I/MESSAGE_PORT(  481): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
03-28 15:03:26.876+0100 I/MESSAGE_PORT(  481): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
03-28 15:03:26.876+0100 I/MESSAGE_PORT(  481): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
03-28 15:03:26.876+0100 I/MESSAGE_PORT(  481): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
03-28 15:03:26.876+0100 I/MESSAGE_PORT(  481): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-gallery:com.samsung.w-gallery]
03-28 15:03:26.876+0100 E/MESSAGE_PORT(  481): MessagePortService.cpp: CheckRemotePort(235) > _MessagePortService::CheckRemotePort() Failed: MESSAGEPORT_ERROR_MESSAGEPORT_NOT_FOUND
03-28 15:03:26.876+0100 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
03-28 15:03:26.876+0100 E/MESSAGE_PORT( 1378): MessagePortProxy.cpp: CheckRemotePort(379) > The remote message port (com.samsung.w-gallery) is not found.
03-28 15:03:26.876+0100 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
03-28 15:03:26.876+0100 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
03-28 15:03:26.876+0100 I/MESSAGE_PORT(  481): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
03-28 15:03:26.876+0100 I/MESSAGE_PORT(  481): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
03-28 15:03:26.876+0100 I/MESSAGE_PORT(  481): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
03-28 15:03:26.876+0100 I/MESSAGE_PORT(  481): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
03-28 15:03:26.876+0100 I/MESSAGE_PORT(  481): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-gallery.appcontrol:com.samsung.w-gallery]
03-28 15:03:26.876+0100 E/MESSAGE_PORT(  481): MessagePortService.cpp: CheckRemotePort(235) > _MessagePortService::CheckRemotePort() Failed: MESSAGEPORT_ERROR_MESSAGEPORT_NOT_FOUND
03-28 15:03:26.876+0100 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
03-28 15:03:26.876+0100 E/MESSAGE_PORT( 1378): MessagePortProxy.cpp: CheckRemotePort(379) > The remote message port (com.samsung.w-gallery) is not found.
03-28 15:03:26.876+0100 W/WG-CONSUMER( 1378): [32m[F:TransferCtrl.cpp L:  159][_WARN]Command queue is empty[0m
03-28 15:03:26.876+0100 W/WG-CONSUMER( 1378): [34m[F:ConnectionInfo.c L:  620][_HIGH][TX]CConnection(0x4332bc00) Caller=Connection::Established(1162)[0m
03-28 15:03:26.876+0100 W/WG-CONSUMER( 1378): [34m[F:ConnectionInfo.c L:  621][_HIGH]  SM_STATE_ESTABLISHED LocalAgentID=9994 ServiceHandle=42576[0m
03-28 15:03:26.876+0100 W/WG-CONSUMER( 1378): [34m[F:ConnectionInfo.c L:  622][_HIGH]  FTSTATE_INIT PeerCount=1 bUsingWFD=0 RetryTimer=0 nPeerTimer=0[0m
03-28 15:03:26.876+0100 W/WG-CONSUMER( 1378): [34m[F:PeerList.cpp     L:  119][_HIGH]    CPeerAgent=0x43c00770 PeerAgent(0x43c00774) bSet(1)[0m
03-28 15:03:26.876+0100 W/WG-CONSUMER( 1378): [34m[F:PeerList.cpp     L:  120][_HIGH]    DeviceID=1 PeerAgentID=61250 ServiceHandle=42576[0m
03-28 15:03:26.876+0100 W/WG-CONSUMER( 1378): [34m[F:PeerList.cpp     L:  122][_HIGH]    DeviceName=* MAC=* ALE=HostManager ASPID=* Version=2.1[0m
03-28 15:03:26.876+0100 W/WG-CONSUMER( 1378): [34m[F:PeerList.cpp     L:  123][_HIGH]    ConnectType(1) : BT[0m
03-28 15:03:26.946+0100 W/AUL_AMD (  520): amd_request.c: __request_handler(669) > __request_handler: 12
03-28 15:03:27.061+0100 E/WMS     (  519): wms_event_handler.c: wms_event_handler_routine(24519) > 
03-28 15:03:27.061+0100 E/WMS     (  519): ==========
03-28 15:03:27.061+0100 E/WMS     (  519): ##WMS RECEIVED : mgr_wearable_status_req
03-28 15:03:27.061+0100 E/WMS     (  519): ==========
03-28 15:03:27.061+0100 E/WMS     (  519): wms_event_handler.c: handle_mgr_wearable_status_req(16912) > type : sync
03-28 15:03:27.061+0100 E/WMS     (  519): wms_event_handler.c: handle_mgr_wearable_status_req(16919) > host_timestamp : 1553781807924P:?LAL>AC:K:
03-28 15:03:27.061+0100 E/WMS     (  519): wms_package_manager.c: get_package_lists(1239) > get package list function is called
03-28 15:03:27.061+0100 E/WMS     (  519): wms_package_manager.c: initialize_lists(189) > list initialize function is called
03-28 15:03:27.066+0100 E/WMS     (  519): wms_package_manager.c: initialize_lists(196) > acc_svc_app_list leng : 46
03-28 15:03:27.066+0100 E/WMS     (  519): wms_package_manager.c: initialize_lists(208) > watch_all_packages_list leng: 42
03-28 15:03:27.156+0100 E/WMS     (  519): wms_package_manager.c: get_watch_app_info(803) > SAP Setting File Path: /opt/usr/apps/PkGV3tmZSh/res/wgt/res/xml/accessoryservices.xml
03-28 15:03:27.171+0100 E/WMS     (  519): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[PkGV3tmZSh], Appname[CNN]
03-28 15:03:27.191+0100 E/WMS     (  519): wms_package_manager.c: get_watch_app_info(803) > SAP Setting File Path: /opt/usr/apps/X5ICitdP7B/res/wgt/res/xml/accessoryservices.xml
03-28 15:03:27.196+0100 E/WMS     (  519): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[X5ICitdP7B], Appname[Bloomberg]
03-28 15:03:27.216+0100 E/WMS     (  519): wms_package_manager.c: get_watch_app_info(803) > SAP Setting File Path: /opt/usr/apps/bRynPVpV6u/res/wgt/xml/sapservices.xml
03-28 15:03:27.216+0100 E/WMS     (  519): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[bRynPVpV6u], Appname[ESPN]
03-28 15:03:27.236+0100 E/WMS     (  519): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.samsung.alarm], Appname[Alarm]
03-28 15:03:27.256+0100 E/WMS     (  519): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.samsung.clocksetting], Appname[Settings]
03-28 15:03:27.291+0100 E/WMS     (  519): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.samsung.factory-client], Appname[factory-client]
03-28 15:03:27.336+0100 E/WMS     (  519): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.samsung.factory-client], Appname[factory-client-cpustability]
03-28 15:03:27.356+0100 E/WMS     (  519): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.samsung.factory-client], Appname[factory-client-history]
03-28 15:03:27.386+0100 E/WMS     (  519): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.samsung.factory-client], Appname[factory-client-hw]
03-28 15:03:27.411+0100 E/WMS     (  519): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.samsung.factory-client], Appname[factory-client-pretest]
03-28 15:03:27.436+0100 E/WMS     (  519): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.samsung.factory-client], Appname[factory-client-self]
03-28 15:03:27.461+0100 E/WMS     (  519): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.samsung.factory-client], Appname[factory-client-semi]
03-28 15:03:27.486+0100 E/WMS     (  519): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.samsung.factory-client], Appname[factory-client-sensorhubsleep]
03-28 15:03:27.511+0100 E/WMS     (  519): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.samsung.fmg], Appname[RemoteLock]
03-28 15:03:27.536+0100 E/WMS     (  519): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.samsung.fmm], Appname[Find My Phone]
03-28 15:03:27.566+0100 E/WMS     (  519): wms_package_manager.c: get_watch_app_info(705) > app[Galaxy Apps] metadata: notification-disable-on-gearmanager
03-28 15:03:27.566+0100 E/WMS     (  519): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.samsung.gearstore], Appname[Galaxy Apps]
03-28 15:03:27.591+0100 E/WMS     (  519): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.samsung.maps], Appname[Maps]
03-28 15:03:27.611+0100 E/WMS     (  519): wms_package_manager.c: get_watch_app_info(705) > app[Messages] metadata: notification-disable-on-gearmanager
03-28 15:03:27.616+0100 E/WMS     (  519): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.samsung.message], Appname[Messages]
03-28 15:03:27.646+0100 E/WMS     (  519): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.samsung.samsung-pay-app], Appname[Samsung Pay]
03-28 15:03:27.671+0100 E/WMS     (  519): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.samsung.samsung-pay-guide-app], Appname[Samsung Pay]
03-28 15:03:27.721+0100 E/WMS     (  519): wms_package_manager.c: get_watch_app_info(705) > app[Samsung Health] metadata: notification-disable-on-gearmanager
03-28 15:03:27.726+0100 E/WMS     (  519): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.samsung.shealth_gear], Appname[Samsung Health]
03-28 15:03:27.746+0100 E/WMS     (  519): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.samsung.stopwatch-wc1], Appname[Stopwatch]
03-28 15:03:27.771+0100 E/WMS     (  519): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.samsung.svoice-n66], Appname[S Voice]
03-28 15:03:27.806+0100 E/WMS     (  519): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.samsung.timer-wc1], Appname[Timer]
03-28 15:03:27.931+0100 E/WMS     (  519): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.samsung.voice-tos-app], Appname[TOS]
03-28 15:03:27.981+0100 E/WMS     (  519): wms_package_manager.c: get_watch_app_info(754) > Setting File Exist!: com.samsung.voicememo-c1_settings.xml
03-28 15:03:27.986+0100 E/WMS     (  519): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.samsung.voicememo-c1], Appname[Voice Memo]
03-28 15:03:28.016+0100 E/WMS     (  519): wms_package_manager.c: get_watch_app_info(754) > Setting File Exist!: com.samsung.w-buddy_settings.xml
03-28 15:03:28.016+0100 E/WMS     (  519): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.samsung.w-buddy], Appname[Buddy]
03-28 15:03:28.036+0100 E/WMS     (  519): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.samsung.w-calendar2], Appname[Calendar]
03-28 15:03:28.061+0100 E/WMS     (  519): wms_package_manager.c: get_watch_app_info(705) > app[Contacts] metadata: notification-disable-on-gearmanager
03-28 15:03:28.061+0100 E/WMS     (  519): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.samsung.w-contacts2], Appname[Contacts]
03-28 15:03:28.086+0100 E/WMS     (  519): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.samsung.w-dialer2], Appname[Dialer]
03-28 15:03:28.111+0100 E/WMS     (  519): wms_package_manager.c: get_watch_app_info(705) > app[Gallery] metadata: notification-disable-on-gearmanager
03-28 15:03:28.111+0100 E/WMS     (  519): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.samsung.w-gallery], Appname[Gallery]
03-28 15:03:28.131+0100 E/WMS     (  519): wms_package_manager.c: get_watch_app_info(705) > app[Phone] metadata: notification-disable-on-gearmanager
03-28 15:03:28.136+0100 E/WMS     (  519): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.samsung.w-logs2], Appname[Phone]
03-28 15:03:28.156+0100 E/WMS     (  519): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.samsung.w-magazine-wc1], Appname[News Briefing]
03-28 15:03:28.186+0100 E/WMS     (  519): wms_package_manager.c: get_watch_app_info(705) > app[Music Player] metadata: notification-disable-on-gearmanager
03-28 15:03:28.191+0100 E/WMS     (  519): wms_package_manager.c: get_watch_app_info(754) > Setting File Exist!: com.samsung.w-music-player_settings.xml
03-28 15:03:28.191+0100 E/WMS     (  519): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.samsung.w-music-player], Appname[Music Player]
03-28 15:03:28.226+0100 E/WMS     (  519): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.samsung.w-taskmanager], Appname[Recent apps]
03-28 15:03:28.281+0100 E/WMS     (  519): wms_package_manager.c: get_watch_app_info(754) > Setting File Exist!: com.samsung.weather_settings.xml
03-28 15:03:28.281+0100 E/WMS     (  519): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.samsung.weather], Appname[Weather]
03-28 15:03:28.316+0100 E/WMS     (  519): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.samsung.windicator], Appname[Controls]
03-28 15:03:28.366+0100 E/WMS     (  519): wms_package_manager.c: get_watch_app_info(705) > app[Notifications] metadata: notification-disable-on-gearmanager
03-28 15:03:28.371+0100 E/WMS     (  519): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.samsung.wnotification2], Appname[Notifications]
03-28 15:03:28.431+0100 E/WMS     (  519): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.samsung.worldclock], Appname[World Clock]
03-28 15:03:28.461+0100 E/WMS     (  519): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.urbandroid.sleep], Appname[Sleep]
03-28 15:03:28.491+0100 W/AUL     ( 4674): launch.c: app_request_to_launchpad(284) > request cmd(0) to(com.urbandroid.sleep.ui)
03-28 15:03:28.491+0100 E/WMS     (  519): wms_package_manager.c: get_watch_app_info(803) > SAP Setting File Path: /opt/usr/apps/oQbQH11Tzv/res/wgt/res/xml/accessoryservices.xml
03-28 15:03:28.496+0100 E/WMS     (  519): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[oQbQH11Tzv], Appname[Running]
03-28 15:03:28.511+0100 W/AUL_AMD (  520): amd_request.c: __request_handler(669) > __request_handler: 0
03-28 15:03:28.511+0100 E/AUL_AMD (  520): amd_request.c: __request_handler(742) > ret(0), standalone(0)
03-28 15:03:28.511+0100 I/capability-manager(  520): capability_manager_companion.c: check_companion_package_status(195) > app_id=[com.urbandroid.sleep.ui]
03-28 15:03:28.511+0100 I/capability-manager(  520): capability_manager_util.c: is_file_exist(120) > File /opt/usr/data/pkgmgr/capability-manager/gear_com.urbandroid.sleep.ui Exists
03-28 15:03:28.511+0100 I/capability-manager(  520): capability_manager_companion.c: check_companion_package_status(231) > app_info=[master_app_packagename=com.urbandroid.sleep.addon.generic.samsung:gear_app_version=1.0.12:master_app_auto_uninstallation=no:], len=[124]
03-28 15:03:28.511+0100 I/capability-manager(  520): capability_manager_companion.c: check_companion_package_status(242) > companion_package_name=[com.urbandroid.sleep.addon.generic.samsung], companion_package_min_version=[(null)]
03-28 15:03:28.511+0100 I/capability-manager(  520): capability_manager_util.c: is_file_exist(120) > File /opt/usr/data/pkgmgr/capability-manager/host_com.urbandroid.sleep.addon.generic.samsung Exists
03-28 15:03:28.511+0100 I/capability-manager(  520): capability_manager_companion.c: check_companion_package_status(255) > package_info=[host_package_name=com.urbandroid.sleep.addon.generic.samsung:host_package_version=38:gear_package_min_version=0.0.1:], len=[116]
03-28 15:03:28.511+0100 I/capability-manager(  520): capability_manager_companion.c: check_companion_package_status(265) > host_package_name=[com.urbandroid.sleep.addon.generic.samsung], host_package_version=[38], gear_package_min_version=[0.0.1]
03-28 15:03:28.511+0100 I/capability-manager(  520): capability_manager_companion.c: check_companion_package_status(281) > gear_app_version=[1.0.12]
03-28 15:03:28.511+0100 I/capability-manager(  520): capability_manager_companion.c: _extract_version(49) > version=[1.0.12] -> major=[1], minor=[0], macro=[12]
03-28 15:03:28.511+0100 I/capability-manager(  520): capability_manager_companion.c: _extract_version(49) > version=[0.0.1] -> major=[0], minor=[0], macro=[1]
03-28 15:03:28.511+0100 I/capability-manager(  520): capability_manager_companion.c: _compare_version(80) > new[1.0.12], old[0.0.1]
03-28 15:03:28.511+0100 I/capability-manager(  520): capability_manager_companion.c: _compare_version(83) > 1 > 0
03-28 15:03:28.511+0100 I/capability-manager(  520): capability_manager_companion.c: check_companion_package_status(295) > companion_package_auto_uninstallation=[no]
03-28 15:03:28.511+0100 I/capability-manager(  520): capability_manager_companion.c: check_companion_package_status(345) > app_id=[com.urbandroid.sleep.ui], type=[0], ret=[0]
03-28 15:03:28.526+0100 I/AUL_AMD (  520): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/launch_app, ret : 0
03-28 15:03:28.536+0100 I/AUL_AMD (  520): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /bin/bash, ret : 0
03-28 15:03:28.536+0100 E/AUL_AMD (  520): amd_launch.c: _start_app(1772) > no caller appid info, ret: -1
03-28 15:03:28.536+0100 W/AUL_AMD (  520): amd_launch.c: _start_app(1782) > caller pid : 4674
03-28 15:03:28.551+0100 E/RESOURCED(  649): block.c: block_prelaunch_state(138) > insert data com.urbandroid.sleep, table num : 4
03-28 15:03:28.551+0100 W/AUL_AMD (  520): amd_launch.c: _start_app(2218) > pad pid(-5)
03-28 15:03:28.551+0100 W/AUL_PAD ( 1234): launchpad.c: __launchpad_main_loop(611) > Launch on type-based process-pool
03-28 15:03:28.551+0100 W/AUL_PAD ( 1234): launchpad.c: __send_result_to_caller(272) > Check app launching
03-28 15:03:28.556+0100 W/AUL_PAD ( 4629): launchpad_loader.c: __candidate_process_prepare_exec(259) > [candidate] before __set_access
03-28 15:03:28.556+0100 W/AUL_PAD ( 4629): launchpad_loader.c: __candidate_process_prepare_exec(264) > [candidate] after __set_access
03-28 15:03:28.556+0100 W/AUL_PAD ( 4629): launchpad_loader.c: __candidate_process_launchpad_main_loop(414) > update argument
03-28 15:03:28.556+0100 W/AUL_PAD ( 4629): launchpad_loader.c: main(680) > [candidate] dlopen(com.urbandroid.sleep.ui)
03-28 15:03:28.576+0100 E/WMS     (  519): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[org.tizen.tizenseckeystring], Appname[Tizen Keystring]
03-28 15:03:28.611+0100 I/efl-extension( 4629): efl_extension.c: eext_mod_init(40) > Init
03-28 15:03:28.616+0100 I/UXT     ( 4629): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
03-28 15:03:28.621+0100 W/AUL_PAD ( 4629): launchpad_loader.c: main(690) > [candidate] dlsym
03-28 15:03:28.621+0100 W/AUL_PAD ( 4629): launchpad_loader.c: main(694) > [candidate] dl_main(com.urbandroid.sleep.ui)
03-28 15:03:28.621+0100 I/SleepAsAndroidConsumerUI( 4629): Starting UI app
03-28 15:03:28.621+0100 I/CAPI_APPFW_APPLICATION( 4629): app_main.c: ui_app_main(704) > app_efl_main
03-28 15:03:28.626+0100 I/CAPI_APPFW_APPLICATION( 4629): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
03-28 15:03:28.651+0100 W/AUL     (  520): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(com.urbandroid.sleep.ui) pid(4629) type(uiapp) bg(0)
03-28 15:03:28.656+0100 W/AUL     ( 4674): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4629)
03-28 15:03:28.656+0100 W/AUL_AMD (  520): amd_status.c: __socket_monitor_cb(1277) > (4629) was created
03-28 15:03:28.676+0100 I/SleepAsAndroidConsumerUI( 4629): Going to create UI
03-28 15:03:28.686+0100 W/STARTER (  733): pkg-monitor.c: _app_mgr_status_cb(400) > [_app_mgr_status_cb:400] Launch request [4629]
03-28 15:03:28.696+0100 E/WMS     (  519): wms_package_manager.c: get_watch_app_info(754) > Setting File Exist!: v8Zs36XM0L_settings.xml
03-28 15:03:28.696+0100 E/WMS     (  519): wms_package_manager.c: get_watch_app_info(803) > SAP Setting File Path: /opt/usr/apps/v8Zs36XM0L/res/wgt//res/xml/accessoryservices.xml
03-28 15:03:28.716+0100 E/WMS     (  519): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[v8Zs36XM0L], Appname[Gear Feed]
03-28 15:03:28.776+0100 E/EFL     ( 4629): ecore_evas<4629> ecore_evas_extn.c:2204 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
03-28 15:03:28.811+0100 E/PKGMGR_SERVER( 4616): pkgmgr-server.c: exit_server(1620) > exit_server Start [backend_status=0, queue_status=0] 
03-28 15:03:28.886+0100 E/rpm-installer( 4617): rpm-appcore-intf.c: main(273) > ------------------------------------------------
03-28 15:03:28.886+0100 E/rpm-installer( 4617): rpm-appcore-intf.c: main(274) >  [END] installer: result=[0]
03-28 15:03:28.886+0100 E/rpm-installer( 4617): rpm-appcore-intf.c: main(275) > ------------------------------------------------
03-28 15:03:28.941+0100 E/PKGMGR_SERVER( 4616): pkgmgr-server.c: sighandler(486) > child NORMAL exit [4617]
03-28 15:03:28.941+0100 E/PKGMGR_SERVER( 4675): pkgmgr-server.c: queue_job(1990) > DISABLE_PKG start, pkgid=[com.samsung.wemail]
03-28 15:03:29.061+0100 E/CAPI_TELEPHONY(  519): telephony_common.c: telephony_init(358) > telephony feature is disabled
03-28 15:03:29.246+0100 E/PKGMGR_STATE( 4675): pkg_state.c: __pkg_state_disable_pkg(420) > start disable_pkg : pkgid = com.samsung.wemail
03-28 15:03:29.256+0100 W/CRASH_MANAGER( 4676): worker.c: worker_job(1205) > 1104629736c65155378180
