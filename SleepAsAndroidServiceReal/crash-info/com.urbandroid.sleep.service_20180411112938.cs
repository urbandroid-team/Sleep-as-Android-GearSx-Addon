S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.2.7
Build-Number: R732XXU2FRC1
Build-Date: 2018.03.02 17:21:30

Crash Information
Process Name: sleepasandroidnativeservice
PID: 26845
Date: 2018-04-11 11:29:38+0200
Executable File Path: /opt/usr/apps/com.urbandroid.sleep/bin/sleepasandroidnativeservice
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x2e302e30

Register Information
r0   = 0x2e302e31, r1   = 0x2e302e30
r2   = 0x00000000, r3   = 0xffffffff
r4   = 0x00000000, r5   = 0xbeba08b0
r6   = 0x40003fc0, r7   = 0x2e302e31
r8   = 0x0000000d, r9   = 0x00000000
r10  = 0x40003fb2, fp   = 0xbeba08a4
ip   = 0xbeba0de4, sp   = 0xbeba0338
lr   = 0x4040be8c, pc   = 0x404410b4
cpsr = 0x60000010

Memory Information
MemTotal:   490112 KB
MemFree:      9128 KB
Buffers:     15608 KB
Cached:     112200 KB
VmPeak:      61328 KB
VmSize:      61324 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        8944 KB
VmRSS:        8944 KB
VmData:      12296 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       19584 KB
VmPTE:          32 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 26845 TID = 26845
26845 26881 

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
4319a000 43a00000 rw-p [stack:26881]
beb81000 beba2000 rw-p [stack]
End of Maps Information

Callstack Information (PID:26845)
Call Stack Count: 1
 0: strlen + 0x4 (0x404410b4) [/lib/libc.so.6] + 0x760b4
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
NAGER CONNECTED : TRUE
04-11 11:29:34.100+0200 E/WMS     (  522): ==========
04-11 11:29:34.115+0200 I/AUL_AMD (  514): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/sapd, ret : 0
04-11 11:29:34.125+0200 I/AUL_AMD (  514): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/sapd, ret : 0
04-11 11:29:34.125+0200 E/AUL_AMD (  514): amd_launch.c: _start_app(1772) > no caller appid info, ret: -1
04-11 11:29:34.125+0200 W/AUL_AMD (  514): amd_launch.c: _start_app(1782) > caller pid : 520
04-11 11:29:34.140+0200 W/AUL_AMD (  514): amd_launch.c: start_process(606) > child process: 26863
04-11 11:29:34.160+0200 E/WMS     (  522): wms_event_handler.c: handle_mgr_host_status_res(17185) > TIMESTAMP saved: 1523438968072P:?LAL>AC:K:
04-11 11:29:34.160+0200 E/WMS     (  522): wms_event_handler.c: wms_event_handler_routine(24535) > [mgr_host_status_res] handler success.
04-11 11:29:34.190+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcClientConnected(172) > MessagePort Ipc connected
04-11 11:29:34.195+0200 W/AUL_AMD (  514): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 26863
04-11 11:29:34.195+0200 W/AUL     (  514): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(com.samsung.w-contacts2.consumer) pid(26863) type(svcapp) bg(0)
04-11 11:29:34.195+0200 W/AUL_AMD (  514): amd_request.c: __request_handler(669) > __request_handler: 14
04-11 11:29:34.205+0200 W/AUL_AMD (  514): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 24121
04-11 11:29:34.205+0200 W/AUL_AMD (  514): amd_request.c: __request_handler(669) > __request_handler: 14
04-11 11:29:34.215+0200 W/AUL_AMD (  514): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 1042
04-11 11:29:34.215+0200 W/AUL_AMD (  514): amd_request.c: __request_handler(669) > __request_handler: 14
04-11 11:29:34.225+0200 W/AUL_AMD (  514): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 26813
04-11 11:29:34.230+0200 W/AUL_AMD (  514): amd_request.c: __request_handler(669) > __request_handler: 14
04-11 11:29:34.240+0200 W/AUL_AMD (  514): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 26818
04-11 11:29:34.240+0200 W/AUL_AMD (  514): amd_request.c: __request_handler(669) > __request_handler: 14
04-11 11:29:34.250+0200 W/AUL_AMD (  514): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 26824
04-11 11:29:34.260+0200 W/STARTER (  764): pkg-monitor.c: _app_mgr_status_cb(400) > [_app_mgr_status_cb:400] Launch request [26863]
04-11 11:29:34.265+0200 W/W_INDICATOR(  765): windicator_scs.c: windicator_scs_update(123) > [windicator_scs_update:123] sales code : 0
04-11 11:29:34.270+0200 W/W_INDICATOR(  765): windicator_scs.c: windicator_scs_update(131) > [windicator_scs_update:131] sap connected : 1
04-11 11:29:34.270+0200 W/W_INDICATOR(  765): windicator_scs.c: windicator_scs_update(146) > [windicator_scs_update:146] ciss_request_type : 0
04-11 11:29:34.270+0200 I/W_INDICATOR(  765): windicator_scs.c: windicator_scs_update(155) > [windicator_scs_update:155] Hide (Callforwarding requested)
04-11 11:29:34.270+0200 I/W_INDICATOR(  765): windicator.c: windicator_is_lo_connected(976) > [windicator_is_lo_connected:976] Connected target vendor : LGE
04-11 11:29:34.270+0200 W/WG-CONSUMER(24121): [32m[F:SAPProxy.cpp     L:  621][_WARN]_on_wms_connected_changed, value = 1, key = memory/wms/wmanager_connected[0m
04-11 11:29:34.270+0200 W/W_INDICATOR(  765): windicator_scs.c: windicator_scs_update(195) > [windicator_scs_update:195] sap connectivity type : 1
04-11 11:29:34.270+0200 W/W_INDICATOR(  765): windicator_scs.c: windicator_scs_update(203) > [windicator_scs_update:203] network status : 3
04-11 11:29:34.270+0200 W/W_INDICATOR(  765): windicator_scs.c: windicator_scs_update(220) > [windicator_scs_update:220] scs login : 0
04-11 11:29:34.270+0200 W/W_INDICATOR(  765): windicator_scs.c: windicator_scs_update(261) > [windicator_scs_update:261] connected via bluetooth
04-11 11:29:34.270+0200 W/WG-CONSUMER(24121): [34m[F:SAPProxy.cpp     L:  601][_HIGH]Device Connected. Cur type=BT|[0m
04-11 11:29:34.275+0200 W/WG-CONSUMER(24121): [34m[F:SAPProxy.cpp     L:  633][_HIGH]WMS status changed. VConf memory/wms/wmanager_connected value=1 BT=1[0m
04-11 11:29:34.275+0200 W/WG-CONSUMER(24121): [34m[F:SAPProxy.cpp     L:  637][_HIGH]WMS is connected. Try to connection. Connections=2[0m
04-11 11:29:34.275+0200 W/WG-CONSUMER(24121): [34m[F:ConnectionInfo.c L:  190][_HIGH][TX]CConnection::Connect() State:SM_STATE_ESTABLISHED[0m
04-11 11:29:34.275+0200 W/WG-CONSUMER(24121): [34m[F:SAPProxy.cpp     L:  147][_HIGH]CSAPProxy::Connect. Size=2 pConnection=0x4332bc00[0m
04-11 11:29:34.275+0200 W/WG-CONSUMER(24121): [34m[F:SAPProxy.cpp     L:  150][_HIGH]  Connection : [TX] LocalAgentID:60919 ServiceHandle:37262[0m
04-11 11:29:34.275+0200 W/WG-CONSUMER(24121): [34m[F:SAPProxy.cpp     L:  150][_HIGH]  Connection : [RX] LocalAgentID:60920 ServiceHandle:0[0m
04-11 11:29:34.275+0200 E/WG-CONSUMER(24121): [31m[F:SAPProxy.cpp     L:  161][ERROR]Duplication connection. not inseterd[0m
04-11 11:29:34.275+0200 I/magazine-service(  995): magazine-service-connection.c: _magazine_service_connection_vconf_key_changed_cb(183) > host_connected changed [1] -> [1]
04-11 11:29:34.275+0200 E/WG-CONSUMER(24121): [31m[F:SAPProxy.cpp     L:  165][ERROR]Previous pCurrent(0x43308370) is exist[0m
04-11 11:29:34.275+0200 W/WG-CONSUMER(24121): [34m[F:SAPProxy.cpp     L:  601][_HIGH]Device Connected. Cur type=BT|[0m
04-11 11:29:34.280+0200 W/WG-CONSUMER(24121): [34m[F:SAPProxy.cpp     L:  186][_HIGH]Device connected. WMS=1 BT=1 [0m
04-11 11:29:34.280+0200 W/WG-CONSUMER(24121): [34m[F:ConnectionInfo.c L:  568][_HIGH][TX]advance. CurState=SM_STATE_ESTABLISHED(8)[0m
04-11 11:29:34.280+0200 W/WG-CONSUMER(24121): [34m[F:ConnectionInfo.c L:  590][_HIGH]Already established.[0m
04-11 11:29:34.280+0200 W/WG-CONSUMER(24121): [34m[F:ConnectionInfo.c L:  190][_HIGH][RX]CConnection::Connect() State:SM_STATE_REGISTER_AGENT[0m
04-11 11:29:34.280+0200 W/WG-CONSUMER(24121): [34m[F:SAPProxy.cpp     L:  147][_HIGH]CSAPProxy::Connect. Size=2 pConnection=0x43308370[0m
04-11 11:29:34.280+0200 W/WG-CONSUMER(24121): [34m[F:SAPProxy.cpp     L:  150][_HIGH]  Connection : [TX] LocalAgentID:60919 ServiceHandle:37262[0m
04-11 11:29:34.285+0200 W/WG-CONSUMER(24121): [34m[F:SAPProxy.cpp     L:  150][_HIGH]  Connection : [RX] LocalAgentID:60920 ServiceHandle:0[0m
04-11 11:29:34.285+0200 E/WG-CONSUMER(24121): [31m[F:SAPProxy.cpp     L:  161][ERROR]Duplication connection. not inseterd[0m
04-11 11:29:34.285+0200 E/WG-CONSUMER(24121): [31m[F:SAPProxy.cpp     L:  165][ERROR]Previous pCurrent(0x4332bc00) is exist[0m
04-11 11:29:34.285+0200 W/WG-CONSUMER(24121): [34m[F:SAPProxy.cpp     L:  601][_HIGH]Device Connected. Cur type=BT|[0m
04-11 11:29:34.285+0200 W/WG-CONSUMER(24121): [34m[F:SAPProxy.cpp     L:  186][_HIGH]Device connected. WMS=1 BT=1 [0m
04-11 11:29:34.285+0200 W/WG-CONSUMER(24121): [34m[F:ConnectionInfo.c L:  568][_HIGH][RX]advance. CurState=SM_STATE_REGISTER_AGENT(4)[0m
04-11 11:29:34.285+0200 W/WG-CONSUMER(24121): [34m[F:ConnectionInfo.c L:  603][_HIGH][RX]State changed: SM_STATE_REGISTER_AGENT->SM_STATE_FINDING_PEER[0m
04-11 11:29:34.330+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnConnectionRequest(411) > _MessagePortIpcServer::OnConnectionRequest
04-11 11:29:34.345+0200 E/weather-common(26824): DemoBinaryManager.cpp: ManipulateDemoData(48) > [0;40;31mDemoBinaryManager::ManipulateDemoData[0;m
04-11 11:29:34.370+0200 W/MC_CONSUMER( 1042): wmc-service-consumer.c: wmc_service_consumer_send_data(598) > [33m {"msgId":"music-queue-req"}[0m
04-11 11:29:34.375+0200 E/WMS     (  522): wms_msg_broker.c: on_broker_buffer_send(307) > Data sending is success.
04-11 11:29:34.380+0200 W/AUL_AMD (  514): amd_request.c: __request_handler(669) > __request_handler: 14
04-11 11:29:34.390+0200 W/AUL_AMD (  514): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 26863
04-11 11:29:34.395+0200 W/AUL_AMD (  514): amd_request.c: __request_handler(669) > __request_handler: 12
04-11 11:29:34.430+0200 W/AUL_AMD (  514): amd_request.c: __request_handler(669) > __request_handler: 14
04-11 11:29:34.435+0200 W/AUL_AMD (  514): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 26863
04-11 11:29:34.440+0200 W/AUL_AMD (  514): amd_request.c: __request_handler(669) > __request_handler: 12
04-11 11:29:34.445+0200 E/weather-common(26824): VconfUtil.cpp: RemoveVconfEventListener(224) > [0;40;31mFailed vconf_ignore_key_changed [key : db/retailmode/enabled, ret : -1][0;m
04-11 11:29:34.455+0200 E/weather-common(26824): RetailManager.cpp: Monitoring(84) > [0;40;31mRetailManager::Monitoring[0;m
04-11 11:29:34.465+0200 E/weather-common(26824): VconfUtil.cpp: GetVconfIntValue(164) > [0;40;31mFailed vconf_get_int [ret : -1, key : db/retailmode/enabled, value : -1][0;m
04-11 11:29:34.470+0200 I/AUL_PAD (26851): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
04-11 11:29:34.480+0200 E/weather-common(26824): VconfUtil.cpp: AddVconfEventListener(214) > [0;40;31mFailed vconf_notify_key_changed [key : db/retailmode/enabled, ret : -1][0;m
04-11 11:29:34.540+0200 E/weather-common(26824): VconfUtil.cpp: AddVconfEventListener(214) > [0;40;31mFailed vconf_notify_key_changed [key : db/retailmode/res_path, ret : -1][0;m
04-11 11:29:34.550+0200 W/MC_CONSUMER( 1042): wmc-service-consumer.c: wmc_service_consumer_send_data(598) > [33m {"msgId":"music-getattribute-req"}[0m
04-11 11:29:34.630+0200 E/weather-common(26824): SystemInfoHelper.cpp: IsShowcaseBinary(77) > [0;40;31misShowcase:0[0;m
04-11 11:29:34.630+0200 E/WMS     (  522): wms_msg_broker.c: on_broker_buffer_send(307) > Data sending is success.
04-11 11:29:34.640+0200 W/CAPI_APPFW_APP_CONTROL(26808): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-11 11:29:34.640+0200 W/CAPI_APPFW_APP_CONTROL(26808): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-11 11:29:34.645+0200 E/CAPI_APPFW_APP_CONTROL(26808): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : failed to retrieve the appid of the caller
04-11 11:29:34.645+0200 E/weather-common(26824): DemoBinaryManager.cpp: ManipulateDemoData(54) > [0;40;31m[ManipulateDemoData(): 54] (SystemInfoHelper::GetInstance()->IsShowcaseBinary() == false) [return][0;m
04-11 11:29:34.680+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-11 11:29:34.680+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-11 11:29:34.680+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-11 11:29:34.680+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnRegisterMessagePort(91) > _MessagePortStub::OnRegisterMessagePort.
04-11 11:29:34.680+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: RegisterMessagePort(83) > _MessagePortService::RegisterMessagePort
04-11 11:29:34.680+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-11 11:29:34.680+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: RegisterMessagePort(95) > Register a message port: [com.samsung.w-voicerecorder.consumer:com.samsung.voice_memo_c1_server], client = 26818
04-11 11:29:34.680+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-11 11:29:34.685+0200 I/SleepAsAndroidConsumer(26845): starting service app
04-11 11:29:34.720+0200 W/WVMS_SERVER(26818): wvms-server-ipc.c: wvms_server_ipc_init(53) >  port id : [1]
04-11 11:29:34.720+0200 E/MALI    (26851): egl_platform_x11.c: __egl_platform_initialize(127) > DDK VERSION - MALI400MP-r4p0-00rel0 / BUILD DATE - 8/Aug/2016 
04-11 11:29:34.775+0200 E/MALI    (26851): egl_platform_x11.c: __egl_platform_initialize(141) > model name : SM-R720
04-11 11:29:34.775+0200 E/MALI    (26851): [gpu-ddk] devel/graphics_drv/r4p0
04-11 11:29:34.775+0200 E/MALI    (26851): 97ae9c0655a7d384872f26978f48bd958e392c4b Fix image distortion on 3rd party applicaton "AnalogWatch"
04-11 11:29:34.775+0200 E/MALI    (26851): [coregl] devel/graphics_engine/master
04-11 11:29:34.775+0200 E/MALI    (26851): c936d4e43f19940f81bedb56d9006162dc3ae4e4 Add manifest file for coregl
04-11 11:29:34.775+0200 E/MALI    (26851): CHK!\
04-11 11:29:34.800+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: _music_control_consumer_control_print_msg_type(105) > [33m[TID:1042]   msg [WMC_SERVICE_WIPC_MSG_ID_CAPABILITY_FEATURE_RESPONSE][0m
04-11 11:29:34.800+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: music_control_consumer_msg_process(243) > [36m[TID:1042]   [MUSIC_PLAYER_EVENT]Device State [2] normal:0 dim:1 off:2[0m
04-11 11:29:34.800+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: music_control_consumer_media_changed_ind_request(199) > [33m[TID:1042]   remote mode[1],resume[0][0m
04-11 11:29:34.800+0200 W/MC_CONSUMER( 1042): wmc-service-consumer.c: wmc_service_consumer_send_data(598) > [33m {"msgId":"music-mediachanged-req","value":"false"}[0m
04-11 11:29:34.990+0200 E/PKGMGR_SERVER(26860): pkgmgr-server.c: exit_server(1620) > exit_server Start [backend_status=1, queue_status=1] 
04-11 11:29:34.990+0200 E/PKGMGR_SERVER(26860): pkgmgr-server.c: main(2296) > package manager server terminated.
04-11 11:29:35.080+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: music_control_consumer_msg_process(381) > [33m[TID:1042]   distinct state = 0, max vol[15], safety_vol[0][0m
04-11 11:29:35.085+0200 W/MUSIC_PLAYER( 1042): mp-weconn.c: _wms_connection_vconf_changed_callback(93) > [33m[TID:1042]   [1][0m
04-11 11:29:35.085+0200 W/MC_CONSUMER( 1042): wmc-service-cotroller.c: _bt_connection_changed_cb(60) > [33m connected[1][0m
04-11 11:29:35.105+0200 E/CAPI_APPFW_APPLICATION(26845): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-11 11:29:35.105+0200 I/AUL_PAD (26796): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
04-11 11:29:35.110+0200 E/CAPI_APPFW_APPLICATION(26845): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-11 11:29:35.145+0200 W/MC_CONSUMER( 1042): wmc-service-consumer.c: __wmc_on_data_ind(386) > [33m length : [64][{"msgId":"music-mediachanged-rsp","result":"success","reason":0}][0m
04-11 11:29:35.145+0200 W/MC_CONSUMER( 1042): wmc-service-consumer.c: __wmc_on_data_ind(386) > [33m length : [142][{"msgId":"music-mediachanged-ind","artist":"","album":"","title":"","audioId":"-1","playStatus":"false","favoriteStatus":"false","index":"-1"}][0m
04-11 11:29:35.145+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: _music_control_consumer_control_print_msg_type(105) > [33m[TID:1042]   msg [WMC_SERVICE_WIPC_MSG_ID_MEDIA_CHANGED_IND][0m
04-11 11:29:35.150+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: music_control_consumer_msg_process(243) > [36m[TID:1042]   [MUSIC_PLAYER_EVENT]Device State [2] normal:0 dim:1 off:2[0m
04-11 11:29:35.150+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: music_control_consumer_media_changed_ind_request(199) > [33m[TID:1042]   remote mode[1],resume[0][0m
04-11 11:29:35.150+0200 W/MC_CONSUMER( 1042): wmc-service-consumer.c: __wmc_on_data_ind(386) > [33m length : [44][{"msgId":"music-queuechanged-ind","count":0}][0m
04-11 11:29:35.155+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: _music_control_consumer_control_print_msg_type(105) > [33m[TID:1042]   msg [WMC_SERVICE_WIPC_MSG_ID_QUEUE_CHANGED_IND][0m
04-11 11:29:35.155+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: music_control_consumer_msg_process(243) > [36m[TID:1042]   [MUSIC_PLAYER_EVENT]Device State [2] normal:0 dim:1 off:2[0m
04-11 11:29:35.155+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: music_control_consumer_media_changed_ind_request(199) > [33m[TID:1042]   remote mode[1],resume[0][0m
04-11 11:29:35.160+0200 W/MC_CONSUMER( 1042): wmc-service-consumer.c: __wmc_on_data_ind(386) > [33m length : [81][{"msgId":"music-playstatechange-rsp","result":"success","reason":0,"playstate":2}][0m
04-11 11:29:35.160+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: _music_control_consumer_control_print_msg_type(105) > [33m[TID:1042]   msg [WMC_SERVICE_WIPC_MSG_ID_PLAY_STATE_CHANGE_RESPONSE][0m
04-11 11:29:35.160+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: music_control_consumer_msg_process(243) > [36m[TID:1042]   [MUSIC_PLAYER_EVENT]Device State [2] normal:0 dim:1 off:2[0m
04-11 11:29:35.160+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: music_control_consumer_media_changed_ind_request(199) > [33m[TID:1042]   remote mode[1],resume[0][0m
04-11 11:29:35.160+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: music_control_consumer_msg_process(393) > [33m[TID:1042]   player state = 2[0m
04-11 11:29:35.160+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-info.c: music_control_info_set_player_state(423) > [33m[TID:1042]   mode = [1], player state = [0][0m
04-11 11:29:35.160+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-media-controller.c: music_control_media_controller_set_playback_state(74) > [33m[TID:1042]   state[2], 1:playing[0m
04-11 11:29:35.160+0200 W/CAPI_MEDIA_CONTROLLER( 1042): media_controller_server.c: mc_server_set_playback_state(284) > [0m<Enter>
04-11 11:29:35.160+0200 W/CAPI_MEDIA_CONTROLLER( 1042): media_controller_server.c: mc_server_set_playback_state(290) > [0mplayback state update [2]
04-11 11:29:35.160+0200 W/CAPI_MEDIA_CONTROLLER( 1042): media_controller_server.c: mc_server_set_playback_state(295) > [0m<Leave>
04-11 11:29:35.165+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-media-controller.c: music_control_media_controller_update_playback_info(138) > [36m[TID:1042]   [MUSIC_PLAYER_EVENT]update playback info[0m
04-11 11:29:35.165+0200 W/CAPI_MEDIA_CONTROLLER( 1042): media_controller_server.c: mc_server_update_playback_info(326) > [0m<Enter>
04-11 11:29:35.165+0200 W/CAPI_MEDIA_CONTROLLER( 1042): media_controller_server.c: mc_server_update_playback_info(331) > [0mplayback info update: state [2], position [0]
04-11 11:29:35.170+0200 W/CAPI_MEDIA_CONTROLLER( 1042): media_controller_server.c: mc_server_update_playback_info(353) > [0m<Leave>
04-11 11:29:35.170+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-message.c: music_control_message_send_player_state_changed_ind(255) > [36m[TID:1042]   [MUSIC_PLAYER_EVENT][0m
04-11 11:29:35.170+0200 W/MC_CONSUMER( 1042): wmc-service-consumer.c: __wmc_on_data_ind(386) > [33m length : [37][{"msgId":"music-queue-rsp","count":0}][0m
04-11 11:29:35.170+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: _music_control_consumer_control_print_msg_type(105) > [33m[TID:1042]   msg [WMC_SERVICE_WIPC_MSG_ID_QUEUE_RSP][0m
04-11 11:29:35.170+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: music_control_consumer_msg_process(243) > [36m[TID:1042]   [MUSIC_PLAYER_EVENT]Device State [2] normal:0 dim:1 off:2[0m
04-11 11:29:35.175+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: music_control_consumer_media_changed_ind_request(199) > [33m[TID:1042]   remote mode[1],resume[0][0m
04-11 11:29:35.175+0200 W/MC_CONSUMER( 1042): wmc-service-consumer.c: __wmc_on_data_ind(386) > [33m length : [129][{"msgId":"music-getattribute-rsp","result":"failure","reason":0,"repeat":"repeatoff","shuffle":"off","volume":13,"earjack":false}][0m
04-11 11:29:35.175+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: _music_control_consumer_control_print_msg_type(105) > [33m[TID:1042]   msg [WMC_SERVICE_WIPC_MSG_ID_GET_ATTRIBUTE_RESPONSE][0m
04-11 11:29:35.175+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: music_control_consumer_msg_process(243) > [36m[TID:1042]   [MUSIC_PLAYER_EVENT]Device State [2] normal:0 dim:1 off:2[0m
04-11 11:29:35.175+0200 W/W_INDICATOR(  765): windicator_ongoing_info_music.c: _player_playback_updated_cb(134) > [_player_playback_updated_cb:134] Playback is updated. [com.samsung.w-music-player.music-control-service][2]
04-11 11:29:35.175+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: music_control_consumer_media_changed_ind_request(199) > [33m[TID:1042]   remote mode[1],resume[0][0m
04-11 11:29:35.175+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: music_control_consumer_msg_process(330) > [33m[TID:1042]   volume = 13, earjack = 0[0m
04-11 11:29:35.180+0200 W/MC_CONSUMER( 1042): wmc-service-consumer.c: __wmc_on_data_ind(386) > [33m length : [64][{"msgId":"music-mediachanged-rsp","result":"success","reason":0}][0m
04-11 11:29:35.190+0200 D/SleepAsAndroidConsumer(26845): HRM is  supported
04-11 11:29:35.210+0200 W/AUL_AMD (  514): amd_status.c: __socket_monitor_cb(1277) > (26845) was created
04-11 11:29:35.220+0200 W/WG-CONSUMER(24121): [34m[F:ConnectionInfo.c L:  418][_HIGH][RX]Finding Peer Agent. AgentID=60920[0m
04-11 11:29:35.290+0200 W/WG-CONSUMER(24121): [32m[F:SAPProxy.cpp     L:  830][_WARN]OnPeerAgent:Found Peer. LocalAgentID[60920], pPeerAgent[0x43345938], wStatusCode=PEER_AGENT_FOUND[0m
04-11 11:29:35.295+0200 E/MALI    (26796): egl_platform_x11.c: __egl_platform_initialize(127) > DDK VERSION - MALI400MP-r4p0-00rel0 / BUILD DATE - 8/Aug/2016 
04-11 11:29:35.315+0200 E/MALI    (26796): egl_platform_x11.c: __egl_platform_initialize(141) > model name : SM-R720
04-11 11:29:35.315+0200 E/MALI    (26796): [gpu-ddk] devel/graphics_drv/r4p0
04-11 11:29:35.315+0200 E/MALI    (26796): 97ae9c0655a7d384872f26978f48bd958e392c4b Fix image distortion on 3rd party applicaton "AnalogWatch"
04-11 11:29:35.315+0200 E/MALI    (26796): [coregl] devel/graphics_engine/master
04-11 11:29:35.315+0200 E/MALI    (26796): c936d4e43f19940f81bedb56d9006162dc3ae4e4 Add manifest file for coregl
04-11 11:29:35.315+0200 E/MALI    (26796): CHK!\
04-11 11:29:35.320+0200 W/WG-CONSUMER(24121): [32m[F:ConnectionInfo.c L:  945][_WARN][RX]FoundPeer. LocalAgentID[60920], pPeerAgent[0x43345938], wStatusCode=PEER_AGENT_FOUND[0m
04-11 11:29:35.320+0200 W/WG-CONSUMER(24121): [34m[F:PeerList.cpp     L:  255][_HIGH][RX]Add CPeerAgent(0xbea360e4) into PeerList. Count=0[0m
04-11 11:29:35.320+0200 W/WG-CONSUMER(24121): [34m[F:PeerList.cpp     L:  100][_HIGH][RX]***** Dump Peer - "Added" *****[0m
04-11 11:29:35.320+0200 W/WG-CONSUMER(24121): [34m[F:PeerList.cpp     L:  103][_HIGH][RX]This=0x43345998 PeerAgent(0x4334599c) bSet(1)[0m
04-11 11:29:35.320+0200 W/WG-CONSUMER(24121): [34m[F:PeerList.cpp     L:  104][_HIGH][RX]  DeviceID=7 PeerAgentID=59051 ServiceHandle=0[0m
04-11 11:29:35.320+0200 W/WG-CONSUMER(24121): [34m[F:PeerList.cpp     L:  106][_HIGH][RX]  DeviceName=* MAC=* ALE=HostManager ASPID=* Version=3.0[0m
04-11 11:29:35.320+0200 W/WG-CONSUMER(24121): [34m[F:PeerList.cpp     L:  107][_HIGH][RX]  ConnectType(1) : BT[0m
04-11 11:29:35.320+0200 W/WG-CONSUMER(24121): [34m[F:PeerList.cpp     L:  111][_HIGH][RX]***********************************[0m
04-11 11:29:35.320+0200 W/WG-CONSUMER(24121): [34m[F:ConnectionInfo.c L:  977][_HIGH][RX]Add timer for next Peer for 0.5s[0m
04-11 11:29:35.320+0200 W/WG-CONSUMER(24121): [34m[F:ConnectionInfo.c L:  603][_HIGH][RX]State changed: SM_STATE_FINDING_PEER->SM_STATE_FOUND_PEER[0m
04-11 11:29:35.320+0200 W/WG-CONSUMER(24121): [34m[F:ConnectionInfo.c L:  568][_HIGH][RX]advance. CurState=SM_STATE_FOUND_PEER(6)[0m
04-11 11:29:35.320+0200 W/WG-CONSUMER(24121): [34m[F:ConnectionInfo.c L:  603][_HIGH][RX]State changed: SM_STATE_FOUND_PEER->SM_STATE_REQUEST_SERVICE[0m
04-11 11:29:35.320+0200 W/WG-CONSUMER(24121): [34m[F:ConnectionInfo.c L:  438][_HIGH][RX]Connect to BT Peer[0m
04-11 11:29:35.320+0200 W/WG-CONSUMER(24121): [34m[F:PeerList.cpp     L:  100][_HIGH][RX]***** Dump Peer - "BestPeer" *****[0m
04-11 11:29:35.320+0200 W/WG-CONSUMER(24121): [34m[F:PeerList.cpp     L:  103][_HIGH][RX]This=0x43345998 PeerAgent(0x4334599c) bSet(1)[0m
04-11 11:29:35.320+0200 W/WG-CONSUMER(24121): [34m[F:PeerList.cpp     L:  104][_HIGH][RX]  DeviceID=7 PeerAgentID=59051 ServiceHandle=0[0m
04-11 11:29:35.320+0200 W/WG-CONSUMER(24121): [34m[F:PeerList.cpp     L:  106][_HIGH][RX]  DeviceName=* MAC=* ALE=HostManager ASPID=* Version=3.0[0m
04-11 11:29:35.320+0200 W/WG-CONSUMER(24121): [34m[F:PeerList.cpp     L:  107][_HIGH][RX]  ConnectType(1) : BT[0m
04-11 11:29:35.320+0200 W/WG-CONSUMER(24121): [34m[F:PeerList.cpp     L:  111][_HIGH][RX]***********************************[0m
04-11 11:29:35.320+0200 W/WG-CONSUMER(24121): [34m[F:ConnectionInfo.c L:  461][_HIGH][RX]CreateServiceConnection. for LocalAgentID=60920 to Peer(0x43345998)[0m
04-11 11:29:35.365+0200 W/WVMS_SERVER(26818): wvms-server-consumer.c: wvoice_memo_on_peer_agent(258) >  wStatusCode : [0]
04-11 11:29:35.365+0200 W/WVMS_SERVER(26818): wvms-server-consumer.c: wvoice_memo_on_peer_agent(274) >  call create service connection
04-11 11:29:35.400+0200 W/WG-CONSUMER(24121): [32m[F:SAPProxy.cpp     L: 1059][_WARN][Phone->Gear] Connection Confirmed. wResponseCode : [0], uwLocalAgentId : [60920] uwServiceHandle : [15431] PeerAgent(0x433387c0)[0m
04-11 11:29:35.400+0200 W/WG-CONSUMER(24121): [34m[F:ConnectionInfo.c L: 1128][_HIGH][RX]connection established. AgentID(60920) ServiceHandle=15431 SM_STATE_REQUEST_SERVICE bUsingWFD=0[0m
04-11 11:29:35.400+0200 W/WG-CONSUMER(24121): [34m[F:ConnectionInfo.c L: 1147][_HIGH][RX] ConnectionType is BT. Update ServiceHandle. (0->15431)[0m
04-11 11:29:35.400+0200 W/WG-CONSUMER(24121): [34m[F:ConnectionInfo.c L: 1151][_HIGH][RX]Connection Established. ServiceID=15431[0m
04-11 11:29:35.400+0200 W/WG-CONSUMER(24121): [34m[F:ConnectionInfo.c L:  603][_HIGH][RX]State changed: SM_STATE_REQUEST_SERVICE->SM_STATE_ESTABLISHED[0m
04-11 11:29:35.400+0200 W/WG-CONSUMER(24121): [32m[F:ReceiverCtrl.cpp L:  529][_WARN][RX]Connection is established[0m
04-11 11:29:35.400+0200 W/WG-CONSUMER(24121): [34m[F:AutoTransfer.cpp L:  114][_HIGH]AutoSync : Gear is not charging[0m
04-11 11:29:35.400+0200 W/WG-CONSUMER(24121): [34m[F:consumer-app.cpp L:  378][_HIGH]CGalleryConsumer::ResetTimer[0m
04-11 11:29:35.400+0200 W/WG-CONSUMER(24121): [34m[F:ConnectionInfo.c L:  620][_HIGH][RX]CConnection(0x43308370) Caller=Connection::Established(1162)[0m
04-11 11:29:35.400+0200 W/WG-CONSUMER(24121): [34m[F:ConnectionInfo.c L:  621][_HIGH]  SM_STATE_ESTABLISHED LocalAgentID=60920 ServiceHandle=15431[0m
04-11 11:29:35.400+0200 W/WG-CONSUMER(24121): [34m[F:ConnectionInfo.c L:  622][_HIGH]  FTSTATE_INIT PeerCount=1 bUsingWFD=0 RetryTimer=0 nPeerTimer=0[0m
04-11 11:29:35.400+0200 W/WG-CONSUMER(24121): [34m[F:PeerList.cpp     L:  119][_HIGH]    CPeerAgent=0x43345998 PeerAgent(0x4334599c) bSet(1)[0m
04-11 11:29:35.400+0200 W/WG-CONSUMER(24121): [34m[F:PeerList.cpp     L:  120][_HIGH]    DeviceID=7 PeerAgentID=59051 ServiceHandle=15431[0m
04-11 11:29:35.400+0200 W/WG-CONSUMER(24121): [34m[F:PeerList.cpp     L:  122][_HIGH]    DeviceName=* MAC=* ALE=HostManager ASPID=* Version=3.0[0m
04-11 11:29:35.400+0200 W/WG-CONSUMER(24121): [34m[F:PeerList.cpp     L:  123][_HIGH]    ConnectType(1) : BT[0m
04-11 11:29:35.455+0200 W/WVMS_SERVER(26818): wvms-server-consumer.c: wvoice_memo_on_peer_agent(258) >  wStatusCode : [0]
04-11 11:29:35.455+0200 W/WVMS_SERVER(26818): wvms-server-consumer.c: wvoice_memo_on_peer_agent(274) >  call create service connection
04-11 11:29:35.470+0200 W/WVMS_SERVER(26818): wvms-server-consumer.c: wvoice_memo_on_service_connection_confirm(280) >  wResponseCode : [7]!!!
04-11 11:29:35.540+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE(26808): preference.c: _preference_check_retry_err(507) > key(lockTimezone), check retry err: -21/(2/No such file or directory).
04-11 11:29:35.545+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE(26808): preference.c: _preference_get_key(1101) > _preference_get_key(lockTimezone) step(-17825744) failed(2 / No such file or directory)
04-11 11:29:35.545+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE(26808): preference.c: preference_get_string(1258) > preference_get_string(26808) : lockTimezone error
04-11 11:29:35.580+0200 W/WVMS_SERVER(26818): wvms-server-consumer.c: wvoice_memo_on_service_connection_confirm(280) >  wResponseCode : [0]!!!
04-11 11:29:35.580+0200 W/WVMS_SERVER(26818): wvms-server-consumer.c: wvoice_memo_on_service_connection_confirm(294) > [32m service connection success[0m
04-11 11:29:35.680+0200 W/WVMS_SERVER(26818): wvms-server-consumer.c: wvms_server_consumer_send_msg(560) >  send data success
04-11 11:29:35.710+0200 E/CALENDAR-CONSUMER(26808): CalendarSapAgent.cpp: __isLDUBinary(1130) > [0;31m* Critical * vconf_get_int is faled.[0;m
04-11 11:29:35.780+0200 W/MUSIC_TRANSFER(26813): mt-service.c: main(146) > [33m[TID:26813]   service start[0m
04-11 11:29:35.805+0200 W/AUL_AMD (  514): amd_status.c: __socket_monitor_cb(1277) > (26813) was created
04-11 11:29:35.805+0200 W/MUSIC_TRANSFER(26813): mt-service.c: _service_app_create(65) > [33m[TID:26813]   [0m
04-11 11:29:35.830+0200 E/weather-common(26824): CPType.cpp: Renew(90) > [0;40;31mCPType is renewed : 5[0;m
04-11 11:29:35.830+0200 E/weather-common(26824): DataManager.cpp: LoadData(326) > [0;40;31mnewCpTypeStr : TWC[0;m
04-11 11:29:35.835+0200 E/weather-common(26824): DataManager.cpp: LoadData(329) > [0;40;31mweather data loaded[0;m
04-11 11:29:35.855+0200 E/CAPI_APPFW_APP_CONTROL(26824): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : failed to retrieve the appid of the caller
04-11 11:29:35.855+0200 E/weather-consumer(26824): ConsumerMain.cpp: GetAppIDFromAppControl(215) > [0;40;31mAppControl ID : (null)[0;m
04-11 11:29:35.855+0200 E/weather-consumer(26824): ConsumerMain.cpp: GetAppIDFromAppControl(218) > [0;40;31mFAILED: service_get_caller(APPID) [-22][0;m
04-11 11:29:35.855+0200 W/CAPI_APPFW_APP_CONTROL(26824): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-11 11:29:35.855+0200 E/weather-consumer(26824): ConsumerMain.cpp: GetMessageFromAppControl(241) > [0;40;31mAppControl msg : (null)[0;m
04-11 11:29:35.855+0200 E/weather-consumer(26824): ConsumerMain.cpp: GetMessageFromAppControl(244) > [0;40;31mFAILED: app_control_get_extra_data(MESSAGE) [-126][0;m
04-11 11:29:35.855+0200 E/weather-consumer(26824): ConsumerMain.cpp: GetMessageTypeByParsing(300) > [0;40;31mNot found message[0;m
04-11 11:29:35.860+0200 E/weather-consumer(26824): ConsumerMain.cpp: SetSelfKillTimer(122) > [0;40;31mAgentMain::SetSelfKillTimer start[0;m
04-11 11:29:35.860+0200 E/weather-consumer(26824): WeatherConsumerController.cpp: Start(73) > [0;40;31mhostDeviceVendor : LGE[0;m
04-11 11:29:35.865+0200 E/weather-consumer(26824): AppcessoryProtocol.cpp: SetSendMessageType(60) > [0;40;31mSetSendMessageType : 0[0;m
04-11 11:29:35.865+0200 E/weather-consumer(26824): AppcessoryProtocol.cpp: MakeMessageForAndroid(88) > [0;40;31mMakeMessageForAndroid[0;m
04-11 11:29:35.865+0200 E/weather-consumer(26824): AppcessoryProtocol.cpp: CreateCpListText(160) > [0;40;31mCP list supported : "Accuweather","TWC","WeatherNews","cmaweather","Kweather","WCN"[0;m
04-11 11:29:35.870+0200 E/weather-consumer(26824): AppcessoryProtocol.cpp: MakeMessageForAndroid(140) > [0;40;31mmSendMessage : {"WEATHER_REQUEST":{"FETCH_REQ":1,"SHOW_SETTING_ON_DEVICE":0,"UPDATED_BY_GEAR":0,"CP_LIST":["Accuweather","TWC","WeatherNews","cmaweather","Kweather","WCN"],"ADD_CURRENT_CITY":0},"REVISION":1,"WEATHER_ACK_SEQ": "1523438975"}[0;m
04-11 11:29:35.870+0200 E/weather-consumer(26824): SAP.cpp: InitializeSAPConnection(142) > [0;40;31mSAP::InitializeSAPConnection[0;m
04-11 11:29:35.970+0200 E/AUL_PAD ( 1323): launchpad.c: main(892) > Refused candidate process connection
04-11 11:29:35.980+0200 E/SleepAsAndroidConsumer(26845): SUCCESSFULLY create sap agent
04-11 11:29:35.980+0200 I/efl-extension(26851): efl_extension.c: eext_mod_shutdown(46) > Shutdown
04-11 11:29:36.030+0200 E/weather-consumer(26824): SAP.cpp: CreateService(126) > [0;40;31mSAP::CreateService[0;m
04-11 11:29:36.105+0200 I/MALI    (26851): egl_platform_x11.c: __egl_platform_terminate(324) > [EGL-X11] ################################################
04-11 11:29:36.105+0200 I/MALI    (26851): egl_platform_x11.c: __egl_platform_terminate(325) > [EGL-X11] PID=26851   close drm_fd=23 
04-11 11:29:36.105+0200 I/MALI    (26851): egl_platform_x11.c: __egl_platform_terminate(326) > [EGL-X11] ################################################
04-11 11:29:36.150+0200 W/CAPI_NETWORK_WECONN(26813): <__weconn_check_handle_validity:76> connection handle=0, hash=(nil)
04-11 11:29:36.165+0200 W/AUL_AMD (  514): amd_status.c: __socket_monitor_cb(1277) > (26863) was created
04-11 11:29:36.185+0200 W/AUL_PAD ( 1323): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 26851 pgid = 26851
04-11 11:29:36.185+0200 W/AUL_PAD ( 1323): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 1 ssi_status = 255
04-11 11:29:36.195+0200 E/CONTACTS_CONSUMER(26863): ct-sap-svc-main.c: __service_check_vendor_init(138) > [0;31m* Critical * ios_connected:0[0;m
04-11 11:29:36.250+0200 W/WVMS_SERVER(26818): wvoice-memo-media-info.c: wvoice_memo_media_get_next_unsync(331) > [32m no unsync file[0m
04-11 11:29:36.270+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnConnectionRequest(411) > _MessagePortIpcServer::OnConnectionRequest
04-11 11:29:36.290+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcClientConnected(172) > MessagePort Ipc connected
04-11 11:29:36.290+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnConnectionRequest(411) > _MessagePortIpcServer::OnConnectionRequest
04-11 11:29:36.290+0200 W/WVMS_SERVER(26818): wvms-server-controller.c: wvms_server_controller_send_file_process(193) > [32m transfer file is not existed[0m
04-11 11:29:36.320+0200 W/AUL_PAD ( 1323): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
04-11 11:29:36.330+0200 I/AUL_AMD (  514): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 26851
04-11 11:29:36.330+0200 W/AUL     (  514): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(26851)
04-11 11:29:36.340+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-11 11:29:36.340+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-11 11:29:36.340+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-11 11:29:36.340+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnRegisterMessagePort(91) > _MessagePortStub::OnRegisterMessagePort.
04-11 11:29:36.340+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: RegisterMessagePort(83) > _MessagePortService::RegisterMessagePort
04-11 11:29:36.340+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-11 11:29:36.340+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: RegisterMessagePort(95) > Register a message port: [com.samsung.w-contacts2.consumer:w-contacts2-consumer], client = 26863
04-11 11:29:36.340+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-11 11:29:36.450+0200 I/efl-extension(26805): efl_extension.c: eext_mod_init(40) > Init
04-11 11:29:36.500+0200 W/SSPAY_UI_SVC(26805): sspay_ui_svc_main.c: main(292) > [36mmain start[0m
04-11 11:29:36.510+0200 W/AUL_AMD (  514): amd_status.c: __socket_monitor_cb(1277) > (26805) was created
04-11 11:29:36.510+0200 W/SSPAY_UI_SVC(26805): sspay_ui_svc_main.c: _service_create(93) > [36m_service_create start[0m
04-11 11:29:36.515+0200 W/SSPAY_UI_SVC(26805): sspay_ui_svc_utils.c: sspay_ui_svc_util_get_CountryISO_with_CSC(2281) > [36mCountryISO [DE][0m
04-11 11:29:36.515+0200 E/SSPAY_UI_SVC(26805): sspay_ui_svc_app_management.c: sspay_ui_svc_am_is_retailmode_enabled(92) > [31m(ret != VCONF_OK) [0m
04-11 11:29:36.515+0200 E/SSPAY_UI_SVC(26805): sspay_ui_svc_main.c: _service_create(100) > [31mNOT ALLOWED Country!!!!!!!!!!!!!!!!![0m
04-11 11:29:36.515+0200 W/SSPAY_UI_SVC(26805): sspay_ui_svc.c: sspay_ui_svc_terminate(1712) > [36mterminate sspay-ui-svc with cpu lock during 5 sec[0m
04-11 11:29:36.615+0200 E/CAPI_APPFW_APP_CONTROL(26808): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : failed to retrieve the appid of the caller
04-11 11:29:36.615+0200 W/CAPI_APPFW_APP_CONTROL(26808): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-11 11:29:36.615+0200 W/CAPI_APPFW_APP_CONTROL(26808): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-11 11:29:36.615+0200 E/CAPI_APPFW_APP_CONTROL(26808): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : failed to retrieve the appid of the caller
04-11 11:29:36.690+0200 E/weather-consumer(26824): WeatherConsumerController.cpp: OnAppcessoryProtocolConnected(134) > [0;40;31mOnAppcessoryProtocolConnected[0;m
04-11 11:29:36.695+0200 I/CAPI_CONTENT_MEDIA_CONTENT(26813): media_content.c: media_content_connect(870) > [32m[26813]ref count : 0
04-11 11:29:36.710+0200 I/CAPI_CONTENT_MEDIA_CONTENT(26813): media_content.c: media_content_connect(902) > [32m[26813]ref count changed to: 1
04-11 11:29:36.865+0200 W/MUSIC_TRANSFER(26813): mt-auto-transfer.c: mt_auto_transfer_init(564) > [33m[TID:26813]   charging status[0], capacity[58][0m
04-11 11:29:37.045+0200 I/SleepAsAndroidConsumer(26845): connectivity type(1): bt
04-11 11:29:37.055+0200 W/MM_CAMCORDER(26794): mm_camcorder_internal.c: _mmcamcorder_constructor(203) >  start
04-11 11:29:37.055+0200 W/MM_CAMCORDER(26794): mm_camcorder_internal.c: _mmcamcorder_constructor(213) >  done
04-11 11:29:37.065+0200 I/efl-extension(26794): efl_extension.c: eext_mod_init(40) > Init
04-11 11:29:37.150+0200 I/CAPI_APPFW_APPLICATION(26805): service_app_main.c: service_app_exit(441) > service_app_exit
04-11 11:29:37.210+0200 E/CAPI_APPFW_APPLICATION(26805): service_app_error.c: service_app_error(63) > [_service_app_create] INVALID_CONTEXT(0xfef00001) : service_app_create_cb() returns false
04-11 11:29:37.210+0200 W/AUL_AMD (  514): amd_request.c: __request_handler(669) > __request_handler: 22
04-11 11:29:37.210+0200 W/AUL_AMD (  514): amd_request.c: __request_handler(999) > app status : 4
04-11 11:29:37.210+0200 W/SSPAY_UI_SVC(26805): sspay_ui_svc_main.c: _service_terminate(129) > [36m_service_terminate start[0m
04-11 11:29:37.215+0200 W/SSPAY_UI_SVC(26805): sspay_ui_svc_main.c: _service_terminate(135) > [36m_service_terminate end[0m
04-11 11:29:37.335+0200 W/MUSIC_TRANSFER(26813): mt-consumer.c: __mt_consumer_on_service_agent_confirm(291) > [33m[TID:26813]   wStatusCode : [0], uwLocalAgentId : [60922][0m
04-11 11:29:37.340+0200 I/efl-extension(26805): efl_extension.c: eext_mod_shutdown(46) > Shutdown
04-11 11:29:37.400+0200 E/CAPI_APPFW_APPLICATION_ALARM(26808): alarm.c: convert_error_code_to_alarm(77) > [alarm_cancel] INVALID_PARAMETER(0xffffffea)
04-11 11:29:37.440+0200 E/CONTACTS_CONSUMER(26863): ct-sap-svc-client.c: __ct_sap_svc_client_find_peer_agent(1180) > [0;31m* Critical * connectivity_type 0[0;m
04-11 11:29:37.445+0200 I/CAPI_CONTENT_MEDIA_CONTENT(26813): media_content.c: media_content_connect(870) > [32m[26813]ref count : 1
04-11 11:29:37.450+0200 I/CAPI_CONTENT_MEDIA_CONTENT(26813): media_content.c: media_content_connect(902) > [32m[26813]ref count changed to: 2
04-11 11:29:37.455+0200 W/MUSIC_TRANSFER(26813): mt-service.c: _service_app_control(120) > [33m[TID:26813]   [0m
04-11 11:29:37.455+0200 W/CAPI_APPFW_APP_CONTROL(26813): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-11 11:29:37.455+0200 W/MUSIC_TRANSFER(26813): mt-consumer.c: __mt_consumer_on_peer_agent(417) > [33m[TID:26813]   uwLocalAgentId : [60922], pPeerAgent : [0x4353bae0], wStatusCode : [0][0m
04-11 11:29:37.455+0200 W/MUSIC_TRANSFER(26813): mt-consumer.c: mt_consumer_connect_peer(568) > [36m[TID:26813]   [MUSIC_PLAYER_EVENT]create service connection[0m
04-11 11:29:37.490+0200 W/AUL     (26886): daemon-manager-release-agent.c: main(12) > release agent : [2:/com.samsung.samsung-pay-app-service]
04-11 11:29:37.490+0200 W/AUL_AMD (  514): amd_request.c: __request_handler(669) > __request_handler: 23
04-11 11:29:37.490+0200 W/AUL_AMD (  514): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-11 11:29:37.490+0200 W/AUL_AMD (  514): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 26293
04-11 11:29:37.490+0200 W/AUL_AMD (  514): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-11 11:29:37.580+0200 I/AUL_AMD (  514): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 26293
04-11 11:29:37.580+0200 W/AUL     (  514): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(26293)
04-11 11:29:37.585+0200 E/RESOURCED(  623): procfs.c: proc_get_oom_score_adj(178) > fopen /proc/26805/oom_score_adj failed
04-11 11:29:37.585+0200 E/RESOURCED(  623): proc-main.c: resourced_proc_status_change(1501) > Empty pid or process not exists. 26805
04-11 11:29:37.655+0200 W/MUSIC_TRANSFER(26813): mt-consumer.c: __mt_consumer_on_service_connection_confirm(387) > [33m[TID:26813]   uwLocalAgentId : [60922], uwServiceHandle : [18193], wResponseCode : [0][0m
04-11 11:29:37.655+0200 W/MUSIC_TRANSFER(26813): mt-controller.c: _connection_changed_cb(225) > [36m[TID:26813]   [MUSIC_PLAYER_EVENT]connected[1], from_peer[0][0m
04-11 11:29:37.660+0200 W/MUSIC_TRANSFER(26813): mt-consumer.c: mt_consumer_send_data(624) > [36m[TID:26813]   [MUSIC_PLAYER_EVENT]pStr : { "msgId" : "capability-feature-ind", "features" : [ { "id" : "musictransfer/playlistSend", "version" : 1 }, { "id" : "musictra[0m
04-11 11:29:37.660+0200 E/CONTACTS_CONSUMER(26863): ct-sap-svc-client.c: ct_sap_svc_client_mem_info(3594) > [0;31m* Critical * Total allocated space (uordblks):138792
04-11 11:29:37.660+0200 E/CONTACTS_CONSUMER(26863): [0;m
04-11 11:29:37.740+0200 W/CAPI_APPFW_APP_CONTROL(26863): app_control.c: app_control_error(136) > [app_control_get_extra_data_array] KEY_NOT_FOUND(0xffffff82)
04-11 11:29:37.750+0200 I/SleepAsAndroidConsumer(26845): agent is initialized
04-11 11:29:37.750+0200 D/SleepAsAndroidConsumer(26845): find peer called
04-11 11:29:37.750+0200 I/SleepAsAndroidConsumer(26845): agent initialized callback is over
04-11 11:29:37.750+0200 D/SleepAsAndroidConsumer(26845): SAP >>> getRegisteredServiceAgent() >>> 0
04-11 11:29:37.795+0200 W/CAPI_APPFW_APP_CONTROL(26863): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-11 11:29:37.795+0200 W/CAPI_APPFW_APP_CONTROL(26863): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-11 11:29:37.875+0200 D/SleepAsAndroidConsumer(26845): find peer call succeeded
04-11 11:29:37.880+0200 D/SleepAsAndroidConsumer(26845): find peer call is over
04-11 11:29:37.885+0200 I/SleepAsAndroidConsumer(26845): Find Peer Success!!
04-11 11:29:37.885+0200 D/SleepAsAndroidConsumer(26845): request_service_connection call over
04-11 11:29:37.885+0200 D/SleepAsAndroidConsumer(26845): req service conn call succeeded
04-11 11:29:37.925+0200 E/weather-consumer(26824): SamsungAppcessoryProtocol.cpp: FetchRequestTimeoutCb(74) > [0;40;31mwe wait a second but send message type still remained as MESSAGE_FET_REQUEST. so we need fetch request[0;m
04-11 11:29:38.075+0200 W/CONTACTS_CONSUMER(26863): ct-sap-svc-client.c: __on_create(2490) > [0;35mis_connected_by_scs 0[0;m
04-11 11:29:38.160+0200 I/SleepAsAndroidConsumer(26845): peer agent connection is successful, pa :1134560776
04-11 11:29:38.205+0200 W/MUSIC_TRANSFER(26813): mt-consumer.c: __mt_consumer_on_data_indication(336) > [36m[TID:26813]   [MUSIC_PLAYER_EVENT]uwPayloadLength : [45], pvBuffer : [{"msgId":"musictransfer-available-space-req"}][0m
04-11 11:29:38.205+0200 W/MUSIC_TRANSFER(26813): mt-consumer.c: mt_consumer_send_data(624) > [36m[TID:26813]   [MUSIC_PLAYER_EVENT]pStr : { "msgId" : "musictransfer-available-space-rsp", "freeSpace" : "1906376704" }[0m
04-11 11:29:38.240+0200 E/CONTACTS_CONSUMER(26863): ct-sap-svc-client.c: ct_sap_svc_client_mem_info(3594) > [0;31m* Critical * Total allocated space (uordblks):134376
04-11 11:29:38.240+0200 E/CONTACTS_CONSUMER(26863): [0;m
04-11 11:29:38.265+0200 I/SleepAsAndroidConsumer(26845): Sending data 1.0.8
04-11 11:29:38.295+0200 I/WSM     (  520): WSM_I [d1]
04-11 11:29:38.360+0200 E/CONTACTS_CONSUMER(26863): ct-sap-svc-client.c: __on_receive(1779) > [0;31m* Critical * crypt_key for encrypt version !!![0;m
04-11 11:29:38.380+0200 E/weather-consumer(26824): SAPNotificationCallback.cpp: OnDataIndication(65) > [0;40;31mOnDataIndication called. payloadLength(30)[0;m
04-11 11:29:38.380+0200 E/weather-consumer(26824): AppcessoryProtocol.cpp: SetSendMessageType(60) > [0;40;31mSetSendMessageType : 9999[0;m
04-11 11:29:38.380+0200 E/weather-consumer(26824): AppcessoryProtocol.cpp: SetSendMessageType(79) > [0;40;31m[Error] Wrong MessageType : 9999[0;m
04-11 11:29:38.390+0200 E/weather-common(26824): JsonUtil.cpp: GetObjectFromNode(95) > [0;40;31m[GetObjectFromNode(): 95] (node == NULL) [return][0;m
04-11 11:29:38.390+0200 E/weather-common(26824): SAPMessageParser.cpp: ParseSettingInfo(825) > [0;40;31msettingNode is NULL[0;m
04-11 11:29:38.390+0200 E/weather-common(26824): JsonUtil.cpp: GetArrayFromNode(103) > [0;40;31m[GetArrayFromNode(): 103] (node == NULL) [return][0;m
04-11 11:29:38.390+0200 E/weather-common(26824): JsonUtil.cpp: GetArrayLength(119) > [0;40;31m[GetArrayLength(): 119] (array == NULL) [return][0;m
04-11 11:29:38.390+0200 E/weather-common(26824): SAPMessageParser.cpp: ParseWeatherInfo(800) > [0;40;31mweatherNode is NULL[0;m
04-11 11:29:38.390+0200 E/weather-consumer(26824): SamsungAppcessoryProtocol.cpp: OnAppcessoryProtocolDataReceived(265) > [0;40;31m[OnAppcessoryProtocolDataReceived(): 265] (!sapMessageParser->ParseWeatherInfo()) [break][0;m
04-11 11:29:38.390+0200 E/weather-common(26824): SAPMessageParser.cpp: ParseAckSeq(849) > [0;40;31mWeatherAckSeq : 1523438975[0;m
04-11 11:29:38.390+0200 E/weather-consumer(26824): SamsungAppcessoryProtocol.cpp: OnAppcessoryProtocolDataReceived(420) > [0;40;31mmReceiveWeatherAck : 1523438975[0;m
04-11 11:29:38.390+0200 E/weather-consumer(26824): SamsungAppcessoryProtocol.cpp: OnAppcessoryProtocolDataReceived(462) > [0;40;31mJust Receive AckData.[0;m
04-11 11:29:38.390+0200 E/weather-consumer(26824): SamsungAppcessoryProtocol.cpp: OnAppcessoryProtocolDataReceived(465) > [0;40;31mWait until receive the data...[0;m
04-11 11:29:38.390+0200 E/weather-consumer(26824): WeatherConsumerController.cpp: OnAppcessoryProtocolDataReceived(110) > [0;40;31mOnAppcessoryProtocolDataReceived[0;m
04-11 11:29:38.470+0200 W/MUSIC_TRANSFER(26813): mt-consumer.c: __mt_consumer_on_data_indication(336) > [36m[TID:26813]   [MUSIC_PLAYER_EVENT]uwPayloadLength : [50], pvBuffer : [{"msgId":"musictransfer-setting-ind","auto":"off"}][0m
04-11 11:29:38.470+0200 W/MUSIC_TRANSFER(26813): mt-controller.c: _process_setting_change(705) > [36m[TID:26813]   [MUSIC_PLAYER_EVENT]AutoTransfer setting[off][0m
04-11 11:29:38.470+0200 W/MUSIC_TRANSFER(26813): mt-controller.c: mt_msg_process(984) > [33m[TID:26813]   no remain job[0m
04-11 11:29:38.470+0200 W/MUSIC_TRANSFER(26813): mt-consumer.c: mt_consumer_disconnect_peer(586) > [36m[TID:26813]   [MUSIC_PLAYER_EVENT][0m
04-11 11:29:38.595+0200 W/MUSIC_TRANSFER(26813): mt-consumer.c: __mt_consumer_on_termination_indication(372) > [33m[TID:26813]   uwServiceHandle : [18193], wStatusCode : [999][0m
04-11 11:29:38.595+0200 W/MUSIC_TRANSFER(26813): mt-controller.c: _connection_changed_cb(225) > [36m[TID:26813]   [MUSIC_PLAYER_EVENT]connected[0], from_peer[1][0m
04-11 11:29:38.600+0200 W/MUSIC_TRANSFER(26813): mt-auto-transfer.c: mt_auto_transfer_clear(897) > [36m[TID:26813]   [MUSIC_PLAYER_EVENT][0m
04-11 11:29:38.600+0200 W/MUSIC_TRANSFER(26813): mt-auto-transfer.c: mt_auto_transfer_clear(900) > [33m[TID:26813]   in progress = 0, success = 0[0m
04-11 11:29:38.745+0200 W/CRASH_MANAGER(26887): worker.c: worker_job(1205) > 1126845736c65152343897
