S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.2.7
Build-Number: R732XXU2FRC1
Build-Date: 2018.03.02 17:21:30

Crash Information
Process Name: sleepasandroidnativeservice
PID: 25760
Date: 2018-04-11 11:23:56+0200
Executable File Path: /opt/usr/apps/com.urbandroid.sleep/bin/sleepasandroidnativeservice
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0xdc0d

Register Information
r0   = 0x430b6f80, r1   = 0x430c9a35
r2   = 0x00000000, r3   = 0x430c9a30
r4   = 0x0000dc0d, r5   = 0x00000000
r6   = 0x00000000, r7   = 0xbec6aeb0
r8   = 0x00004fec, r9   = 0x00004fec
r10  = 0x430acec8, fp   = 0x00000000
ip   = 0x00000000, sp   = 0xbec6adf8
lr   = 0x2e302e31, pc   = 0x4005e244
cpsr = 0x60000030

Memory Information
MemTotal:   490112 KB
MemFree:     12508 KB
Buffers:     13052 KB
Cached:     115032 KB
VmPeak:      61328 KB
VmSize:      61324 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        8948 KB
VmRSS:        8948 KB
VmData:      12296 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       19584 KB
VmPTE:          32 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 25760 TID = 25760
25760 25793 

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
4319a000 43a00000 rw-p [stack:25793]
bec4b000 bec6c000 rw-p [stack]
End of Maps Information

Callstack Information (PID:25760)
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
17: main + 0x100 (0x40002c81) [/opt/usr/apps/com.urbandroid.sleep/bin/sleepasandroidnativeservice] + 0x2c81
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
roxy.cpp     L:  186][_HIGH]Device connected. WMS=1 BT=1 [0m
04-11 11:23:53.715+0200 W/WG-CONSUMER(24121): [34m[F:ConnectionInfo.c L:  568][_HIGH][TX]advance. CurState=SM_STATE_ESTABLISHED(8)[0m
04-11 11:23:53.715+0200 W/WG-CONSUMER(24121): [34m[F:ConnectionInfo.c L:  590][_HIGH]Already established.[0m
04-11 11:23:53.715+0200 W/WG-CONSUMER(24121): [34m[F:ConnectionInfo.c L:  190][_HIGH][RX]CConnection::Connect() State:SM_STATE_ESTABLISHED[0m
04-11 11:23:53.720+0200 W/WG-CONSUMER(24121): [34m[F:SAPProxy.cpp     L:  147][_HIGH]CSAPProxy::Connect. Size=2 pConnection=0x43308370[0m
04-11 11:23:53.720+0200 W/WG-CONSUMER(24121): [34m[F:SAPProxy.cpp     L:  150][_HIGH]  Connection : [TX] LocalAgentID:60919 ServiceHandle:17688[0m
04-11 11:23:53.720+0200 W/WG-CONSUMER(24121): [34m[F:SAPProxy.cpp     L:  150][_HIGH]  Connection : [RX] LocalAgentID:60920 ServiceHandle:17689[0m
04-11 11:23:53.720+0200 E/WG-CONSUMER(24121): [31m[F:SAPProxy.cpp     L:  161][ERROR]Duplication connection. not inseterd[0m
04-11 11:23:53.720+0200 E/WG-CONSUMER(24121): [31m[F:SAPProxy.cpp     L:  165][ERROR]Previous pCurrent(0x4332bc00) is exist[0m
04-11 11:23:53.720+0200 W/WG-CONSUMER(24121): [34m[F:SAPProxy.cpp     L:  601][_HIGH]Device Connected. Cur type=BT|[0m
04-11 11:23:53.720+0200 W/WG-CONSUMER(24121): [34m[F:SAPProxy.cpp     L:  186][_HIGH]Device connected. WMS=1 BT=1 [0m
04-11 11:23:53.720+0200 W/WG-CONSUMER(24121): [34m[F:ConnectionInfo.c L:  568][_HIGH][RX]advance. CurState=SM_STATE_ESTABLISHED(8)[0m
04-11 11:23:53.720+0200 W/WG-CONSUMER(24121): [34m[F:ConnectionInfo.c L:  590][_HIGH]Already established.[0m
04-11 11:23:53.720+0200 I/magazine-service(  995): magazine-service-connection.c: _magazine_service_connection_vconf_key_changed_cb(183) > host_connected changed [1] -> [1]
04-11 11:23:53.730+0200 W/MSG_CONSUMER( 1407): SapClient.cpp: _onWmsConnectionChanged(810) > [0;35mprevious_status: (1), status: (1)[0;m
04-11 11:23:53.730+0200 W/MSG_CONSUMER( 1407): SapClient.cpp: _onWmsConnectionChanged(813) > [0;35m_onWmsConnectionChanged() is ignored for same status change. prev:(1), cur:(1)[0;m
04-11 11:23:53.760+0200 E/weather-consumer(25749): AppcessoryProtocol.cpp: SetSendMessageType(79) > [0;40;31m[Error] Wrong MessageType : 9999[0;m
04-11 11:23:53.775+0200 W/MC_CONSUMER( 1042): wmc-service-consumer.c: wmc_service_consumer_send_data(598) > [33m {"msgId":"music-queue-req"}[0m
04-11 11:23:53.795+0200 W/WVMS_SERVER(25742): wvms-server-consumer.c: wvoice_memo_register_consumer(471) >  init complete
04-11 11:23:53.800+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnConnectionRequest(411) > _MessagePortIpcServer::OnConnectionRequest
04-11 11:23:53.800+0200 E/SSPAY_UI_SVC(25723): sspay_ui_svc_main.c: _service_create(100) > [31mNOT ALLOWED Country!!!!!!!!!!!!!!!!![0m
04-11 11:23:53.820+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcClientConnected(172) > MessagePort Ipc connected
04-11 11:23:53.830+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnConnectionRequest(411) > _MessagePortIpcServer::OnConnectionRequest
04-11 11:23:53.835+0200 W/SSPAY_UI_SVC(25723): sspay_ui_svc.c: sspay_ui_svc_terminate(1712) > [36mterminate sspay-ui-svc with cpu lock during 5 sec[0m
04-11 11:23:53.840+0200 E/weather-common(25749): JsonUtil.cpp: GetValueFromNode(154) > [0;40;31mEntering node default case[0;m
04-11 11:23:53.855+0200 E/weather-common(25749): JsonUtil.cpp: GetValueFromNode(154) > [0;40;31mEntering node default case[0;m
04-11 11:23:53.860+0200 E/weather-common(25749): JsonUtil.cpp: GetValueFromNode(154) > [0;40;31mEntering node default case[0;m
04-11 11:23:53.860+0200 E/weather-common(25749): SAPMessageParser.cpp: ParseSettingInfo(664) > [0;40;31mcpType:TWC[0;m
04-11 11:23:53.860+0200 E/weather-common(25749): SAPMessageParser.cpp: ParseSettingInfo(765) > [0;40;31mNotificationOn:1, NotificationPopup:0, Notification time:1523428502, Temperature unit:1[0;m
04-11 11:23:53.865+0200 E/weather-common(25749): SAPMessageParser.cpp: ParseSettingInfo(766) > [0;40;31mRefresh Interval:3, UseCurrentLocationOn:1, ShowCurrentCityAgreement:1[0;m
04-11 11:23:53.865+0200 E/weather-common(25749): SAPMessageParser.cpp: ParseSettingInfo(767) > [0;40;31mAPI version, AccuWeather:9999, TWC:9999, WeatherNewsKR:2, WeatherNewsJP:3, CMAWeather:9999, WCN:2[0;m
04-11 11:23:53.870+0200 E/weather-common(25749): JsonUtil.cpp: GetValueFromNode(154) > [0;40;31mEntering node default case[0;m
04-11 11:23:53.875+0200 E/weather-common(25749): SAPMessageParser.cpp: ParseCityInfo(181) > [0;40;31mthere is no mSettingPtr. we just set the location id[0;m
04-11 11:23:53.880+0200 E/weather-common(25749): SAPMessageParser.cpp: ParseCityInfo(200) > [0;40;31mCityName:Pra, CityNameEng:Pra, IsCurrentLocation:1[0;m
04-11 11:23:53.890+0200 E/weather-common(25749): SAPMessageParser.cpp: ParseCurrentInfo(232) > [0;40;31mCurTemp:20.0, HighTemp:22.0, LowTemp:8.0, WeatherIcon:30, WeatherIconConverted:1[0;m
04-11 11:23:53.905+0200 E/weather-common(25749): PreferenceHelper.cpp: SetIsWeatherIconConvertedToCommonResource(66) > [0;40;31m[Value : 1][0;m
04-11 11:23:53.940+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-11 11:23:53.940+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-11 11:23:53.940+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-11 11:23:53.940+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnRegisterMessagePort(91) > _MessagePortStub::OnRegisterMessagePort.
04-11 11:23:53.940+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: RegisterMessagePort(83) > _MessagePortService::RegisterMessagePort
04-11 11:23:53.940+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-11 11:23:53.940+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: RegisterMessagePort(95) > Register a message port: [com.samsung.w-voicerecorder.consumer:com.samsung.voice_memo_c1_server], client = 25742
04-11 11:23:53.940+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-11 11:23:53.945+0200 W/WVMS_SERVER(25742): wvms-server-ipc.c: wvms_server_ipc_init(53) >  port id : [1]
04-11 11:23:53.980+0200 E/weather-common(25749): SAPMessageParser.cpp: ParseCurrentInfo(248) > [0;40;31mCITY_TODAY_ICON_NUM_CONVERTED : 1[0;m
04-11 11:23:53.980+0200 E/weather-common(25749): SAPMessageParser.cpp: ParseForecastinfo(318) > [0;40;31mHighTemp:22.0, LowTemp:8.0, WeatherIcon:30, WeatherIconConverted:2[0;m
04-11 11:23:53.980+0200 E/weather-common(25749): SAPMessageParser.cpp: ParseForecastinfo(318) > [0;40;31mHighTemp:21.0, LowTemp:10.0, WeatherIcon:30, WeatherIconConverted:2[0;m
04-11 11:23:53.985+0200 E/weather-common(25749): SAPMessageParser.cpp: ParseForecastinfo(318) > [0;40;31mHighTemp:23.0, LowTemp:13.0, WeatherIcon:34, WeatherIconConverted:1[0;m
04-11 11:23:53.985+0200 E/weather-common(25749): SAPMessageParser.cpp: ParseForecastinfo(318) > [0;40;31mHighTemp:20.0, LowTemp:7.0, WeatherIcon:38, WeatherIconConverted:9[0;m
04-11 11:23:53.985+0200 E/weather-common(25749): SAPMessageParser.cpp: ParseForecastinfo(318) > [0;40;31mHighTemp:22.0, LowTemp:10.0, WeatherIcon:34, WeatherIconConverted:1[0;m
04-11 11:23:53.985+0200 E/weather-common(25749): SAPMessageParser.cpp: ParseForecastinfo(318) > [0;40;31mHighTemp:23.0, LowTemp:12.0, WeatherIcon:30, WeatherIconConverted:2[0;m
04-11 11:23:53.990+0200 E/weather-common(25749): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:20.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:30, WeatherIconConverted:1, RainForecast:0[0;m
04-11 11:23:53.990+0200 E/weather-common(25749): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:19.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:30, WeatherIconConverted:1, RainForecast:0[0;m
04-11 11:23:53.995+0200 E/weather-common(25749): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:18.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:30, WeatherIconConverted:1, RainForecast:0[0;m
04-11 11:23:53.995+0200 E/weather-common(25749): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:17.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:30, WeatherIconConverted:1, RainForecast:0[0;m
04-11 11:23:53.995+0200 E/weather-common(25749): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:16.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:29, WeatherIconConverted:1, RainForecast:1[0;m
04-11 11:23:54.000+0200 E/weather-common(25749): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:14.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:29, WeatherIconConverted:1, RainForecast:2[0;m
04-11 11:23:54.000+0200 E/weather-common(25749): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:13.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:29, WeatherIconConverted:1, RainForecast:4[0;m
04-11 11:23:54.005+0200 E/weather-common(25749): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:13.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:29, WeatherIconConverted:1, RainForecast:5[0;m
04-11 11:23:54.005+0200 E/weather-common(25749): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:12.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:29, WeatherIconConverted:1, RainForecast:6[0;m
04-11 11:23:54.005+0200 E/weather-common(25749): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:11.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:29, WeatherIconConverted:1, RainForecast:7[0;m
04-11 11:23:54.005+0200 E/weather-common(25749): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:10.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:29, WeatherIconConverted:1, RainForecast:7[0;m
04-11 11:23:54.010+0200 E/weather-common(25749): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:10.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:29, WeatherIconConverted:1, RainForecast:8[0;m
04-11 11:23:54.020+0200 E/weather-common(25749): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:9.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:27, WeatherIconConverted:2, RainForecast:14[0;m
04-11 11:23:54.025+0200 E/WMS     (  522): wms_msg_broker.c: on_broker_buffer_send(307) > Data sending is success.
04-11 11:23:54.025+0200 E/weather-common(25749): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:9.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:27, WeatherIconConverted:2, RainForecast:15[0;m
04-11 11:23:54.025+0200 E/weather-common(25749): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:9.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:29, WeatherIconConverted:1, RainForecast:9[0;m
04-11 11:23:54.030+0200 E/weather-common(25749): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:9.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:30, WeatherIconConverted:1, RainForecast:8[0;m
04-11 11:23:54.030+0200 E/weather-common(25749): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:11.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:30, WeatherIconConverted:1, RainForecast:7[0;m
04-11 11:23:54.030+0200 E/weather-common(25749): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:12.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:30, WeatherIconConverted:1, RainForecast:5[0;m
04-11 11:23:54.035+0200 E/weather-common(25749): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:14.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:28, WeatherIconConverted:2, RainForecast:3[0;m
04-11 11:23:54.060+0200 W/MC_CONSUMER( 1042): wmc-service-consumer.c: wmc_service_consumer_send_data(598) > [33m {"msgId":"music-getattribute-req"}[0m
04-11 11:23:54.085+0200 E/weather-common(25749): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:15.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:30, WeatherIconConverted:1, RainForecast:1[0;m
04-11 11:23:54.090+0200 E/weather-common(25749): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:17.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:30, WeatherIconConverted:1, RainForecast:0[0;m
04-11 11:23:54.090+0200 E/weather-common(25749): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:18.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:30, WeatherIconConverted:1, RainForecast:6[0;m
04-11 11:23:54.095+0200 E/weather-common(25749): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:19.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:30, WeatherIconConverted:1, RainForecast:18[0;m
04-11 11:23:54.100+0200 E/weather-common(25749): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:20.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:30, WeatherIconConverted:1, RainForecast:22[0;m
04-11 11:23:54.115+0200 E/weather-common(25749): SAPMessageParser.cpp: ParseLifeIndexInfo(573) > [0;40;31mPM10:[9999.0,9999], Humidity:-1, SunsetTime:1523382480, SunriseTime:1523333940, UV:[9999.0,9999], toDayUVIndex:9999, UVIndexText:9999[0;m
04-11 11:23:54.120+0200 E/weather-common(25749): SAPMessageParser.cpp: ParseLifeIndexInfo(586) > [0;40;31mrealfeelTemp : [0;m
04-11 11:23:54.120+0200 E/weather-common(25749): LifeIndex.h: PrintDebugInformation(427) > [0;40;31m[humidiry:-1], [pressure:9999.0], [realfeel:9999.0], [visibility:9999.0], [airDust:9999.0,9999], [airPolution:9999.0,9999,9999], [allergy:9999.0,9999,9999], [aqi:9999.0,9999], [carwash:9999.0,9999,9999], [clothing:9999.0,9999,9999], [cold:9999.0,9999,9999], [comfort:9999.0,9999,9999], [cosmetic:9999.0,9999,9999], [discomfort:9999.0,9999], [drivingDifficulty:9999.0,9999,9999],[dryClothing:9999.0,9999,9999], [drySkin:9999.0,9999], [fishing:9999.0,9999,9999], [foodPoison:9999.0,9999], [frostbite:9999.0,9999], [frozenPipes:9999.0,9999], [heat:9999.0,9999], [heatStroke:9999.0,9999], [khai:9999.0,9999], [outdoorExcercise:9999.0,9999,9999], [pm10:9999.0,9999], [pm25:9999.0,9999], [pollen:9999.0,9999], [running:9999.0,9999,9999], [skincare:9999.0,9999], [spoiledFood:9999.0,9999], [umbrella:9999.0,9999],[uv:9999.0,9999,9999][0;m
04-11 11:23:54.130+0200 E/weather-common(25749): JsonUtil.cpp: GetValueFromNode(154) > [0;40;31mEntering node default case[0;m
04-11 11:23:54.130+0200 E/weather-common(25749): SAPMessageParser.cpp: ParseCityInfo(181) > [0;40;31mthere is no mSettingPtr. we just set the location id[0;m
04-11 11:23:54.130+0200 E/weather-common(25749): SAPMessageParser.cpp: ParseCityInfo(200) > [0;40;31mCityName:Pra, CityNameEng:Pra, IsCurrentLocation:0[0;m
04-11 11:23:54.130+0200 E/weather-common(25749): SAPMessageParser.cpp: ParseCurrentInfo(232) > [0;40;31mCurTemp:21.0, HighTemp:20.0, LowTemp:8.0, WeatherIcon:30, WeatherIconConverted:1[0;m
04-11 11:23:54.130+0200 E/weather-common(25749): PreferenceHelper.cpp: SetIsWeatherIconConvertedToCommonResource(66) > [0;40;31m[Value : 1][0;m
04-11 11:23:54.140+0200 E/weather-common(25749): SAPMessageParser.cpp: ParseCurrentInfo(248) > [0;40;31mCITY_TODAY_ICON_NUM_CONVERTED : 1[0;m
04-11 11:23:54.150+0200 E/weather-common(25749): SAPMessageParser.cpp: ParseForecastinfo(318) > [0;40;31mHighTemp:20.0, LowTemp:8.0, WeatherIcon:30, WeatherIconConverted:2[0;m
04-11 11:23:54.150+0200 E/weather-common(25749): SAPMessageParser.cpp: ParseForecastinfo(318) > [0;40;31mHighTemp:20.0, LowTemp:10.0, WeatherIcon:30, WeatherIconConverted:2[0;m
04-11 11:23:54.155+0200 E/weather-common(25749): SAPMessageParser.cpp: ParseForecastinfo(318) > [0;40;31mHighTemp:22.0, LowTemp:12.0, WeatherIcon:34, WeatherIconConverted:1[0;m
04-11 11:23:54.155+0200 E/weather-common(25749): SAPMessageParser.cpp: ParseForecastinfo(318) > [0;40;31mHighTemp:20.0, LowTemp:7.0, WeatherIcon:38, WeatherIconConverted:9[0;m
04-11 11:23:54.155+0200 E/weather-common(25749): SAPMessageParser.cpp: ParseForecastinfo(318) > [0;40;31mHighTemp:21.0, LowTemp:10.0, WeatherIcon:34, WeatherIconConverted:1[0;m
04-11 11:23:54.160+0200 E/weather-common(25749): SAPMessageParser.cpp: ParseForecastinfo(318) > [0;40;31mHighTemp:22.0, LowTemp:12.0, WeatherIcon:30, WeatherIconConverted:2[0;m
04-11 11:23:54.160+0200 E/weather-common(25749): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:20.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:30, WeatherIconConverted:1, RainForecast:0[0;m
04-11 11:23:54.165+0200 E/weather-common(25749): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:19.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:30, WeatherIconConverted:1, RainForecast:0[0;m
04-11 11:23:54.165+0200 E/weather-common(25749): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:18.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:30, WeatherIconConverted:1, RainForecast:0[0;m
04-11 11:23:54.175+0200 E/weather-common(25749): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:17.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:30, WeatherIconConverted:1, RainForecast:0[0;m
04-11 11:23:54.175+0200 E/weather-common(25749): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:16.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:29, WeatherIconConverted:1, RainForecast:2[0;m
04-11 11:23:54.175+0200 E/weather-common(25749): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:15.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:29, WeatherIconConverted:1, RainForecast:2[0;m
04-11 11:23:54.185+0200 E/weather-common(25749): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:14.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:29, WeatherIconConverted:1, RainForecast:4[0;m
04-11 11:23:54.185+0200 E/weather-common(25749): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:13.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:29, WeatherIconConverted:1, RainForecast:5[0;m
04-11 11:23:54.190+0200 E/weather-common(25749): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:12.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:29, WeatherIconConverted:1, RainForecast:6[0;m
04-11 11:23:54.190+0200 E/weather-common(25749): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:12.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:29, WeatherIconConverted:1, RainForecast:8[0;m
04-11 11:23:54.195+0200 E/weather-common(25749): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:10.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:29, WeatherIconConverted:1, RainForecast:8[0;m
04-11 11:23:54.200+0200 E/weather-common(25749): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:10.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:29, WeatherIconConverted:1, RainForecast:8[0;m
04-11 11:23:54.200+0200 E/weather-common(25749): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:9.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:27, WeatherIconConverted:2, RainForecast:15[0;m
04-11 11:23:54.205+0200 E/weather-common(25749): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:9.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:27, WeatherIconConverted:2, RainForecast:15[0;m
04-11 11:23:54.205+0200 E/weather-common(25749): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:9.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:29, WeatherIconConverted:1, RainForecast:9[0;m
04-11 11:23:54.205+0200 E/weather-common(25749): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:9.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:30, WeatherIconConverted:1, RainForecast:9[0;m
04-11 11:23:54.205+0200 E/weather-common(25749): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:11.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:30, WeatherIconConverted:1, RainForecast:7[0;m
04-11 11:23:54.210+0200 E/weather-common(25749): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:12.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:30, WeatherIconConverted:1, RainForecast:5[0;m
04-11 11:23:54.215+0200 E/weather-common(25749): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:14.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:28, WeatherIconConverted:2, RainForecast:3[0;m
04-11 11:23:54.215+0200 E/weather-common(25749): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:15.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:30, WeatherIconConverted:1, RainForecast:1[0;m
04-11 11:23:54.215+0200 E/weather-common(25749): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:17.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:30, WeatherIconConverted:1, RainForecast:0[0;m
04-11 11:23:54.225+0200 E/weather-common(25749): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:18.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:30, WeatherIconConverted:1, RainForecast:6[0;m
04-11 11:23:54.225+0200 E/weather-common(25749): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:19.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:30, WeatherIconConverted:1, RainForecast:19[0;m
04-11 11:23:54.235+0200 E/weather-common(25749): SAPMessageParser.cpp: ParseHourlyInfo(418) > [0;40;31mCurTemp:20.0, HighTemp:0.0, LowTemp:0.0, WeatherIcon:30, WeatherIconConverted:1, RainForecast:24[0;m
04-11 11:23:54.245+0200 E/weather-common(25749): SAPMessageParser.cpp: ParseLifeIndexInfo(573) > [0;40;31mPM10:[9999.0,9999], Humidity:-1, SunsetTime:1523382480, SunriseTime:1523333940, UV:[9999.0,9999], toDayUVIndex:9999, UVIndexText:9999[0;m
04-11 11:23:54.250+0200 E/weather-common(25749): SAPMessageParser.cpp: ParseLifeIndexInfo(586) > [0;40;31mrealfeelTemp : [0;m
04-11 11:23:54.250+0200 E/weather-common(25749): LifeIndex.h: PrintDebugInformation(427) > [0;40;31m[humidiry:-1], [pressure:9999.0], [realfeel:9999.0], [visibility:9999.0], [airDust:9999.0,9999], [airPolution:9999.0,9999,9999], [allergy:9999.0,9999,9999], [aqi:9999.0,9999], [carwash:9999.0,9999,9999], [clothing:9999.0,9999,9999], [cold:9999.0,9999,9999], [comfort:9999.0,9999,9999], [cosmetic:9999.0,9999,9999], [discomfort:9999.0,9999], [drivingDifficulty:9999.0,9999,9999],[dryClothing:9999.0,9999,9999], [drySkin:9999.0,9999], [fishing:9999.0,9999,9999], [foodPoison:9999.0,9999], [frostbite:9999.0,9999], [frozenPipes:9999.0,9999], [heat:9999.0,9999], [heatStroke:9999.0,9999], [khai:9999.0,9999], [outdoorExcercise:9999.0,9999,9999], [pm10:9999.0,9999], [pm25:9999.0,9999], [pollen:9999.0,9999], [running:9999.0,9999,9999], [skincare:9999.0,9999], [spoiledFood:9999.0,9999], [umbrella:9999.0,9999],[uv:9999.0,9999,9999][0;m
04-11 11:23:54.255+0200 E/WMS     (  522): wms_msg_broker.c: on_broker_buffer_send(307) > Data sending is success.
04-11 11:23:54.265+0200 E/weather-consumer(25749): SamsungAppcessoryProtocol.cpp: OnAppcessoryProtocolDataReceived(274) > [0;40;31mduplicated weather infor [0;m
04-11 11:23:54.280+0200 E/weather-consumer(25749): SamsungAppcessoryProtocol.cpp: OnAppcessoryProtocolDataReceived(280) > [0;40;31mSeting DB is Updated.[0;m
04-11 11:23:54.285+0200 E/weather-consumer(25749): SamsungAppcessoryProtocol.cpp: OnAppcessoryProtocolDataReceived(283) > [0;40;31m[OnAppcessoryProtocolDataReceived(): 283] (isDuplicateData == true) [break][0;m
04-11 11:23:54.285+0200 E/weather-common(25749): SAPMessageParser.cpp: ParseAckSeq(849) > [0;40;31mWeatherAckSeq : 1523438633676[0;m
04-11 11:23:54.285+0200 E/weather-consumer(25749): SamsungAppcessoryProtocol.cpp: OnAppcessoryProtocolDataReceived(420) > [0;40;31mmReceiveWeatherAck : 1523438633676[0;m
04-11 11:23:54.285+0200 E/weather-consumer(25749): AppcessoryProtocol.cpp: SetSendMessageType(60) > [0;40;31mSetSendMessageType : 5[0;m
04-11 11:23:54.285+0200 E/weather-consumer(25749): AppcessoryProtocol.cpp: MakeMessageForAndroid(88) > [0;40;31mMakeMessageForAndroid[0;m
04-11 11:23:54.290+0200 E/weather-consumer(25749): AppcessoryProtocol.cpp: MakeMessageForAndroid(140) > [0;40;31mmSendMessage : { "WEATHER_ACK_SEQ": "1523438633676" }[0;m
04-11 11:23:54.310+0200 I/efl-extension(25776): efl_extension.c: eext_mod_init(40) > Init
04-11 11:23:54.415+0200 I/UXT     (25776): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
04-11 11:23:54.465+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: _music_control_consumer_control_print_msg_type(105) > [33m[TID:1042]   msg [WMC_SERVICE_WIPC_MSG_ID_CAPABILITY_FEATURE_RESPONSE][0m
04-11 11:23:54.470+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: music_control_consumer_msg_process(243) > [36m[TID:1042]   [MUSIC_PLAYER_EVENT]Device State [2] normal:0 dim:1 off:2[0m
04-11 11:23:54.470+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: music_control_consumer_media_changed_ind_request(199) > [33m[TID:1042]   remote mode[1],resume[0][0m
04-11 11:23:54.470+0200 W/MC_CONSUMER( 1042): wmc-service-consumer.c: wmc_service_consumer_send_data(598) > [33m {"msgId":"music-mediachanged-req","value":"false"}[0m
04-11 11:23:54.740+0200 I/AUL_PAD (25776): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
04-11 11:23:54.770+0200 E/MALI    (25776): egl_platform_x11.c: __egl_platform_initialize(127) > DDK VERSION - MALI400MP-r4p0-00rel0 / BUILD DATE - 8/Aug/2016 
04-11 11:23:54.770+0200 E/MALI    (25776): egl_platform_x11.c: __egl_platform_initialize(141) > model name : SM-R720
04-11 11:23:54.770+0200 E/MALI    (25776): [gpu-ddk] devel/graphics_drv/r4p0
04-11 11:23:54.770+0200 E/MALI    (25776): 97ae9c0655a7d384872f26978f48bd958e392c4b Fix image distortion on 3rd party applicaton "AnalogWatch"
04-11 11:23:54.770+0200 E/MALI    (25776): [coregl] devel/graphics_engine/master
04-11 11:23:54.770+0200 E/MALI    (25776): c936d4e43f19940f81bedb56d9006162dc3ae4e4 Add manifest file for coregl
04-11 11:23:54.770+0200 E/MALI    (25776): CHK!\
04-11 11:23:54.990+0200 E/PKGMGR_SERVER(25788): pkgmgr-server.c: exit_server(1620) > exit_server Start [backend_status=1, queue_status=1] 
04-11 11:23:54.990+0200 E/PKGMGR_SERVER(25788): pkgmgr-server.c: main(2296) > package manager server terminated.
04-11 11:23:55.140+0200 E/AUL_PAD ( 1323): launchpad.c: main(892) > Refused candidate process connection
04-11 11:23:55.145+0200 I/efl-extension(25776): efl_extension.c: eext_mod_shutdown(46) > Shutdown
04-11 11:23:55.160+0200 I/MALI    (25776): egl_platform_x11.c: __egl_platform_terminate(324) > [EGL-X11] ################################################
04-11 11:23:55.160+0200 I/MALI    (25776): egl_platform_x11.c: __egl_platform_terminate(325) > [EGL-X11] PID=25776   close drm_fd=23 
04-11 11:23:55.160+0200 I/MALI    (25776): egl_platform_x11.c: __egl_platform_terminate(326) > [EGL-X11] ################################################
04-11 11:23:55.190+0200 E/CONTACTS_CONSUMER(25731): ct-sap-svc-client.c: __ct_sap_svc_client_find_peer_agent(1180) > [0;31m* Critical * connectivity_type 0[0;m
04-11 11:23:55.230+0200 I/SleepAsAndroidConsumer(25760): connectivity type(1): bt
04-11 11:23:55.235+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: music_control_consumer_msg_process(381) > [33m[TID:1042]   distinct state = 0, max vol[15], safety_vol[0][0m
04-11 11:23:55.235+0200 W/AUL_PAD ( 1323): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 25776 pgid = 25776
04-11 11:23:55.235+0200 W/AUL_PAD ( 1323): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 1 ssi_status = 255
04-11 11:23:55.240+0200 W/MUSIC_PLAYER( 1042): mp-weconn.c: _wms_connection_vconf_changed_callback(93) > [33m[TID:1042]   [1][0m
04-11 11:23:55.240+0200 W/MC_CONSUMER( 1042): wmc-service-cotroller.c: _bt_connection_changed_cb(60) > [33m connected[1][0m
04-11 11:23:55.330+0200 W/MC_CONSUMER( 1042): wmc-service-consumer.c: __wmc_on_data_ind(386) > [33m length : [64][{"msgId":"music-mediachanged-rsp","result":"success","reason":0}][0m
04-11 11:23:55.335+0200 W/MC_CONSUMER( 1042): wmc-service-consumer.c: __wmc_on_data_ind(386) > [33m length : [142][{"msgId":"music-mediachanged-ind","artist":"","album":"","title":"","audioId":"-1","playStatus":"false","favoriteStatus":"false","index":"-1"}][0m
04-11 11:23:55.335+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: _music_control_consumer_control_print_msg_type(105) > [33m[TID:1042]   msg [WMC_SERVICE_WIPC_MSG_ID_MEDIA_CHANGED_IND][0m
04-11 11:23:55.335+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: music_control_consumer_msg_process(243) > [36m[TID:1042]   [MUSIC_PLAYER_EVENT]Device State [2] normal:0 dim:1 off:2[0m
04-11 11:23:55.335+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: music_control_consumer_media_changed_ind_request(199) > [33m[TID:1042]   remote mode[1],resume[0][0m
04-11 11:23:55.340+0200 W/MC_CONSUMER( 1042): wmc-service-consumer.c: __wmc_on_data_ind(386) > [33m length : [44][{"msgId":"music-queuechanged-ind","count":0}][0m
04-11 11:23:55.340+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: _music_control_consumer_control_print_msg_type(105) > [33m[TID:1042]   msg [WMC_SERVICE_WIPC_MSG_ID_QUEUE_CHANGED_IND][0m
04-11 11:23:55.345+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: music_control_consumer_msg_process(243) > [36m[TID:1042]   [MUSIC_PLAYER_EVENT]Device State [2] normal:0 dim:1 off:2[0m
04-11 11:23:55.345+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: music_control_consumer_media_changed_ind_request(199) > [33m[TID:1042]   remote mode[1],resume[0][0m
04-11 11:23:55.345+0200 W/MC_CONSUMER( 1042): wmc-service-consumer.c: __wmc_on_data_ind(386) > [33m length : [81][{"msgId":"music-playstatechange-rsp","result":"success","reason":0,"playstate":2}][0m
04-11 11:23:55.350+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: _music_control_consumer_control_print_msg_type(105) > [33m[TID:1042]   msg [WMC_SERVICE_WIPC_MSG_ID_PLAY_STATE_CHANGE_RESPONSE][0m
04-11 11:23:55.350+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: music_control_consumer_msg_process(243) > [36m[TID:1042]   [MUSIC_PLAYER_EVENT]Device State [2] normal:0 dim:1 off:2[0m
04-11 11:23:55.350+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: music_control_consumer_media_changed_ind_request(199) > [33m[TID:1042]   remote mode[1],resume[0][0m
04-11 11:23:55.350+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: music_control_consumer_msg_process(393) > [33m[TID:1042]   player state = 2[0m
04-11 11:23:55.350+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-info.c: music_control_info_set_player_state(423) > [33m[TID:1042]   mode = [1], player state = [0][0m
04-11 11:23:55.350+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-media-controller.c: music_control_media_controller_set_playback_state(74) > [33m[TID:1042]   state[2], 1:playing[0m
04-11 11:23:55.350+0200 W/CAPI_MEDIA_CONTROLLER( 1042): media_controller_server.c: mc_server_set_playback_state(284) > [0m<Enter>
04-11 11:23:55.350+0200 W/CAPI_MEDIA_CONTROLLER( 1042): media_controller_server.c: mc_server_set_playback_state(290) > [0mplayback state update [2]
04-11 11:23:55.350+0200 W/CAPI_MEDIA_CONTROLLER( 1042): media_controller_server.c: mc_server_set_playback_state(295) > [0m<Leave>
04-11 11:23:55.350+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-media-controller.c: music_control_media_controller_update_playback_info(138) > [36m[TID:1042]   [MUSIC_PLAYER_EVENT]update playback info[0m
04-11 11:23:55.350+0200 W/CAPI_MEDIA_CONTROLLER( 1042): media_controller_server.c: mc_server_update_playback_info(326) > [0m<Enter>
04-11 11:23:55.350+0200 W/CAPI_MEDIA_CONTROLLER( 1042): media_controller_server.c: mc_server_update_playback_info(331) > [0mplayback info update: state [2], position [0]
04-11 11:23:55.365+0200 W/CAPI_MEDIA_CONTROLLER( 1042): media_controller_server.c: mc_server_update_playback_info(353) > [0m<Leave>
04-11 11:23:55.365+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-message.c: music_control_message_send_player_state_changed_ind(255) > [36m[TID:1042]   [MUSIC_PLAYER_EVENT][0m
04-11 11:23:55.370+0200 W/MC_CONSUMER( 1042): wmc-service-consumer.c: __wmc_on_data_ind(386) > [33m length : [37][{"msgId":"music-queue-rsp","count":0}][0m
04-11 11:23:55.375+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: _music_control_consumer_control_print_msg_type(105) > [33m[TID:1042]   msg [WMC_SERVICE_WIPC_MSG_ID_QUEUE_RSP][0m
04-11 11:23:55.375+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: music_control_consumer_msg_process(243) > [36m[TID:1042]   [MUSIC_PLAYER_EVENT]Device State [2] normal:0 dim:1 off:2[0m
04-11 11:23:55.380+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: music_control_consumer_media_changed_ind_request(199) > [33m[TID:1042]   remote mode[1],resume[0][0m
04-11 11:23:55.380+0200 W/MC_CONSUMER( 1042): wmc-service-consumer.c: __wmc_on_data_ind(386) > [33m length : [129][{"msgId":"music-getattribute-rsp","result":"failure","reason":0,"repeat":"repeatoff","shuffle":"off","volume":13,"earjack":false}][0m
04-11 11:23:55.380+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: _music_control_consumer_control_print_msg_type(105) > [33m[TID:1042]   msg [WMC_SERVICE_WIPC_MSG_ID_GET_ATTRIBUTE_RESPONSE][0m
04-11 11:23:55.385+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: music_control_consumer_msg_process(243) > [36m[TID:1042]   [MUSIC_PLAYER_EVENT]Device State [2] normal:0 dim:1 off:2[0m
04-11 11:23:55.385+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: music_control_consumer_media_changed_ind_request(199) > [33m[TID:1042]   remote mode[1],resume[0][0m
04-11 11:23:55.385+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: music_control_consumer_msg_process(330) > [33m[TID:1042]   volume = 13, earjack = 0[0m
04-11 11:23:55.420+0200 W/W_INDICATOR(  765): windicator_ongoing_info_music.c: _player_playback_updated_cb(134) > [_player_playback_updated_cb:134] Playback is updated. [com.samsung.w-music-player.music-control-service][2]
04-11 11:23:55.430+0200 E/weather-consumer(25749): WeatherConsumerController.cpp: OnAppcessoryProtocolDataReceived(110) > [0;40;31mOnAppcessoryProtocolDataReceived[0;m
04-11 11:23:55.435+0200 W/MC_CONSUMER( 1042): wmc-service-consumer.c: __wmc_on_data_ind(386) > [33m length : [64][{"msgId":"music-mediachanged-rsp","result":"success","reason":0}][0m
04-11 11:23:55.440+0200 E/weather-consumer(25749): WeatherConsumerController.cpp: Start(73) > [0;40;31mhostDeviceVendor : LGE[0;m
04-11 11:23:55.445+0200 E/weather-consumer(25749): AppcessoryProtocol.cpp: SetSendMessageType(60) > [0;40;31mSetSendMessageType : 0[0;m
04-11 11:23:55.445+0200 E/weather-consumer(25749): AppcessoryProtocol.cpp: MakeMessageForAndroid(88) > [0;40;31mMakeMessageForAndroid[0;m
04-11 11:23:55.445+0200 E/weather-consumer(25749): AppcessoryProtocol.cpp: CreateCpListText(160) > [0;40;31mCP list supported : "Accuweather","TWC","WeatherNews","cmaweather","Kweather","WCN"[0;m
04-11 11:23:55.445+0200 E/weather-consumer(25749): AppcessoryProtocol.cpp: MakeMessageForAndroid(140) > [0;40;31mmSendMessage : {"WEATHER_REQUEST":{"FETCH_REQ":1,"SHOW_SETTING_ON_DEVICE":0,"UPDATED_BY_GEAR":0,"CP_LIST":["Accuweather","TWC","WeatherNews","cmaweather","Kweather","WCN"],"ADD_CURRENT_CITY":0},"REVISION":1,"WEATHER_ACK_SEQ": "1523438635"}[0;m
04-11 11:23:55.445+0200 E/weather-consumer(25749): SamsungAppcessoryProtocol.cpp: Start(97) > [0;40;31mg_timeout_add_seconds mRequestTimer:27[0;m
04-11 11:23:55.460+0200 E/CAPI_APPFW_APPLICATION_ALARM(25726): alarm.c: convert_error_code_to_alarm(77) > [alarm_cancel] INVALID_PARAMETER(0xffffffea)
04-11 11:23:55.475+0200 W/AUL_PAD ( 1323): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
04-11 11:23:55.480+0200 I/AUL_AMD (  514): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 25776
04-11 11:23:55.480+0200 W/AUL     (  514): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(25776)
04-11 11:23:55.520+0200 I/CAPI_APPFW_APPLICATION(25723): service_app_main.c: service_app_exit(441) > service_app_exit
04-11 11:23:55.525+0200 E/CAPI_APPFW_APPLICATION(25723): service_app_error.c: service_app_error(63) > [_service_app_create] INVALID_CONTEXT(0xfef00001) : service_app_create_cb() returns false
04-11 11:23:55.525+0200 W/AUL_AMD (  514): amd_request.c: __request_handler(669) > __request_handler: 22
04-11 11:23:55.525+0200 W/AUL_AMD (  514): amd_request.c: __request_handler(999) > app status : 4
04-11 11:23:55.525+0200 W/SSPAY_UI_SVC(25723): sspay_ui_svc_main.c: _service_terminate(129) > [36m_service_terminate start[0m
04-11 11:23:55.525+0200 W/SSPAY_UI_SVC(25723): sspay_ui_svc_main.c: _service_terminate(135) > [36m_service_terminate end[0m
04-11 11:23:55.630+0200 E/CONTACTS_CONSUMER(25731): ct-sap-svc-client.c: ct_sap_svc_client_mem_info(3594) > [0;31m* Critical * Total allocated space (uordblks):140088
04-11 11:23:55.630+0200 E/CONTACTS_CONSUMER(25731): [0;m
04-11 11:23:55.640+0200 E/weather-consumer(25749): SAP.cpp: TerminateServiceConnection(260) > [0;40;31mServiceConnection is not exist [0][0;m
04-11 11:23:55.640+0200 W/WVMS_SERVER(25742): wvms-server-consumer.c: wvoice_memo_on_peer_agent(258) >  wStatusCode : [0]
04-11 11:23:55.640+0200 W/WVMS_SERVER(25742): wvms-server-consumer.c: wvoice_memo_on_peer_agent(274) >  call create service connection
04-11 11:23:55.640+0200 E/weather-consumer(25749): WeatherConsumerController.cpp: OnAppcessoryProtocolDisconnected(141) > [0;40;31mOnAppcessoryProtocolDisconnected[0;m
04-11 11:23:55.640+0200 E/weather-consumer(25749): SAP.cpp: TerminateServiceConnection(260) > [0;40;31mServiceConnection is not exist [0][0;m
04-11 11:23:55.640+0200 E/weather-consumer(25749): WeatherConsumerController.cpp: Close(91) > [0;40;31mservice_app_exit[0;m
04-11 11:23:55.640+0200 I/CAPI_APPFW_APPLICATION(25749): service_app_main.c: service_app_exit(441) > service_app_exit
04-11 11:23:55.645+0200 W/WVMS_SERVER(25742): wvms-server-consumer.c: wvoice_memo_on_peer_agent(258) >  wStatusCode : [0]
04-11 11:23:55.645+0200 E/weather-consumer(25749): WeatherConsumerController.cpp: Close(88) > [0;40;31m[Close(): 88] (!mAppcessoryProtocolPtr) [return][0;m
04-11 11:23:55.645+0200 W/AUL_AMD (  514): amd_request.c: __request_handler(669) > __request_handler: 22
04-11 11:23:55.645+0200 W/AUL_AMD (  514): amd_request.c: __request_handler(999) > app status : 4
04-11 11:23:55.650+0200 W/CAPI_APPFW_APP_CONTROL(25731): app_control.c: app_control_error(136) > [app_control_get_extra_data_array] KEY_NOT_FOUND(0xffffff82)
04-11 11:23:55.650+0200 W/WVMS_SERVER(25742): wvms-server-consumer.c: wvoice_memo_on_peer_agent(274) >  call create service connection
04-11 11:23:55.655+0200 W/CAPI_APPFW_APP_CONTROL(25731): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-11 11:23:55.655+0200 W/CAPI_APPFW_APP_CONTROL(25731): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-11 11:23:55.665+0200 I/efl-extension(25723): efl_extension.c: eext_mod_shutdown(46) > Shutdown
04-11 11:23:55.770+0200 W/WVMS_SERVER(25742): wvms-server-consumer.c: wvoice_memo_on_service_connection_confirm(280) >  wResponseCode : [7]!!!
04-11 11:23:55.845+0200 W/AUL     (25800): daemon-manager-release-agent.c: main(12) > release agent : [2:/com.samsung.samsung-pay-app-service]
04-11 11:23:55.845+0200 W/AUL_AMD (  514): amd_request.c: __request_handler(669) > __request_handler: 23
04-11 11:23:55.845+0200 W/AUL_AMD (  514): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-11 11:23:55.850+0200 W/AUL_AMD (  514): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 24788
04-11 11:23:55.850+0200 W/AUL_AMD (  514): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-11 11:23:55.860+0200 W/MUSIC_TRANSFER(25737): mt-consumer.c: __mt_consumer_on_service_agent_confirm(291) > [33m[TID:25737]   wStatusCode : [0], uwLocalAgentId : [60922][0m
04-11 11:23:55.865+0200 E/RESOURCED(  623): procfs.c: proc_get_oom_score_adj(178) > fopen /proc/25723/oom_score_adj failed
04-11 11:23:55.865+0200 E/RESOURCED(  623): proc-main.c: resourced_proc_status_change(1501) > Empty pid or process not exists. 25723
04-11 11:23:55.870+0200 I/AUL_AMD (  514): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 24788
04-11 11:23:55.870+0200 W/AUL     (  514): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(24788)
04-11 11:23:55.950+0200 W/AUL     (25801): daemon-manager-release-agent.c: main(12) > release agent : [2:/com.samsung.weather-consumer]
04-11 11:23:55.950+0200 W/AUL_AMD (  514): amd_request.c: __request_handler(669) > __request_handler: 23
04-11 11:23:55.950+0200 W/AUL_AMD (  514): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-11 11:23:55.950+0200 W/AUL_AMD (  514): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 25749
04-11 11:23:55.950+0200 W/AUL_AMD (  514): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-11 11:23:55.990+0200 I/AUL_AMD (  514): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 25749
04-11 11:23:55.990+0200 W/AUL     (  514): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(25749)
04-11 11:23:56.030+0200 I/CAPI_CONTENT_MEDIA_CONTENT(25737): media_content.c: media_content_connect(870) > [32m[25737]ref count : 1
04-11 11:23:56.040+0200 I/CAPI_CONTENT_MEDIA_CONTENT(25737): media_content.c: media_content_connect(902) > [32m[25737]ref count changed to: 2
04-11 11:23:56.045+0200 W/MUSIC_TRANSFER(25737): mt-service.c: _service_app_control(120) > [33m[TID:25737]   [0m
04-11 11:23:56.050+0200 W/CAPI_APPFW_APP_CONTROL(25737): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-11 11:23:56.050+0200 W/MUSIC_TRANSFER(25737): mt-consumer.c: __mt_consumer_on_peer_agent(417) > [33m[TID:25737]   uwLocalAgentId : [60922], pPeerAgent : [0x43505028], wStatusCode : [0][0m
04-11 11:23:56.050+0200 W/MUSIC_TRANSFER(25737): mt-consumer.c: mt_consumer_connect_peer(568) > [36m[TID:25737]   [MUSIC_PLAYER_EVENT]create service connection[0m
04-11 11:23:56.080+0200 W/CONTACTS_CONSUMER(25731): ct-sap-svc-client.c: __on_create(2490) > [0;35mis_connected_by_scs 0[0;m
04-11 11:23:56.120+0200 W/WVMS_SERVER(25742): wvms-server-consumer.c: wvoice_memo_on_service_connection_confirm(280) >  wResponseCode : [0]!!!
04-11 11:23:56.120+0200 W/WVMS_SERVER(25742): wvms-server-consumer.c: wvoice_memo_on_service_connection_confirm(294) > [32m service connection success[0m
04-11 11:23:56.125+0200 W/MM_CAMCORDER(25712): mm_camcorder_internal.c: _mmcamcorder_constructor(203) >  start
04-11 11:23:56.125+0200 W/MM_CAMCORDER(25712): mm_camcorder_internal.c: _mmcamcorder_constructor(213) >  done
04-11 11:23:56.135+0200 I/efl-extension(25712): efl_extension.c: eext_mod_init(40) > Init
04-11 11:23:56.280+0200 I/SleepAsAndroidConsumer(25760): agent is initialized
04-11 11:23:56.280+0200 D/SleepAsAndroidConsumer(25760): find peer called
04-11 11:23:56.280+0200 I/SleepAsAndroidConsumer(25760): agent initialized callback is over
04-11 11:23:56.280+0200 D/SleepAsAndroidConsumer(25760): SAP >>> getRegisteredServiceAgent() >>> 0
04-11 11:23:56.370+0200 D/SleepAsAndroidConsumer(25760): find peer call succeeded
04-11 11:23:56.370+0200 D/SleepAsAndroidConsumer(25760): find peer call is over
04-11 11:23:56.375+0200 I/SleepAsAndroidConsumer(25760): Find Peer Success!!
04-11 11:23:56.375+0200 D/SleepAsAndroidConsumer(25760): request_service_connection call over
04-11 11:23:56.375+0200 D/SleepAsAndroidConsumer(25760): req service conn call succeeded
04-11 11:23:56.380+0200 W/MUSIC_TRANSFER(25737): mt-consumer.c: __mt_consumer_on_service_connection_confirm(387) > [33m[TID:25737]   uwLocalAgentId : [60922], uwServiceHandle : [20460], wResponseCode : [0][0m
04-11 11:23:56.380+0200 W/MUSIC_TRANSFER(25737): mt-controller.c: _connection_changed_cb(225) > [36m[TID:25737]   [MUSIC_PLAYER_EVENT]connected[1], from_peer[0][0m
04-11 11:23:56.380+0200 W/MUSIC_TRANSFER(25737): mt-consumer.c: mt_consumer_send_data(624) > [36m[TID:25737]   [MUSIC_PLAYER_EVENT]pStr : { "msgId" : "capability-feature-ind", "features" : [ { "id" : "musictransfer/playlistSend", "version" : 1 }, { "id" : "musictra[0m
04-11 11:23:56.385+0200 E/CONTACTS_CONSUMER(25731): ct-sap-svc-client.c: ct_sap_svc_client_mem_info(3594) > [0;31m* Critical * Total allocated space (uordblks):138768
04-11 11:23:56.385+0200 E/CONTACTS_CONSUMER(25731): [0;m
04-11 11:23:56.450+0200 W/WVMS_SERVER(25742): wvms-server-consumer.c: wvms_server_consumer_send_msg(560) >  send data success
04-11 11:23:56.550+0200 I/WSM     (  520): WSM_I [d1]
04-11 11:23:56.600+0200 I/SleepAsAndroidConsumer(25760): peer agent connection is successful, pa :1124896680
04-11 11:23:56.605+0200 E/CONTACTS_CONSUMER(25731): ct-sap-svc-client.c: __on_receive(1779) > [0;31m* Critical * crypt_key for encrypt version !!![0;m
04-11 11:23:56.625+0200 W/MUSIC_TRANSFER(25737): mt-consumer.c: __mt_consumer_on_data_indication(336) > [36m[TID:25737]   [MUSIC_PLAYER_EVENT]uwPayloadLength : [45], pvBuffer : [{"msgId":"musictransfer-available-space-req"}][0m
04-11 11:23:56.625+0200 W/MUSIC_TRANSFER(25737): mt-consumer.c: mt_consumer_send_data(624) > [36m[TID:25737]   [MUSIC_PLAYER_EVENT]pStr : { "msgId" : "musictransfer-available-space-rsp", "freeSpace" : "1906470912" }[0m
04-11 11:23:56.695+0200 W/WVMS_SERVER(25742): wvoice-memo-media-info.c: wvoice_memo_media_get_next_unsync(331) > [32m no unsync file[0m
04-11 11:23:56.695+0200 W/WVMS_SERVER(25742): wvms-server-controller.c: wvms_server_controller_send_file_process(193) > [32m transfer file is not existed[0m
04-11 11:23:56.845+0200 E/CONTACTS_CONSUMER(25731): ct-sap-svc-client.c: ct_sap_svc_client_mem_info(3594) > [0;31m* Critical * Total allocated space (uordblks):143504
04-11 11:23:56.845+0200 E/CONTACTS_CONSUMER(25731): [0;m
04-11 11:23:56.850+0200 E/CONTACTS_CONSUMER(25731): ct-sap-svc-parser-contacts.c: ct_sap_svc_parser_contacts_get_feature_info(3669) > [0;31m* Critical * ##FEATURE##:  supportLog(0)[0;m
04-11 11:23:56.850+0200 W/MUSIC_TRANSFER(25737): mt-consumer.c: __mt_consumer_on_data_indication(336) > [36m[TID:25737]   [MUSIC_PLAYER_EVENT]uwPayloadLength : [50], pvBuffer : [{"msgId":"musictransfer-setting-ind","auto":"off"}][0m
04-11 11:23:56.850+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-11 11:23:56.850+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-11 11:23:56.850+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-11 11:23:56.855+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-11 11:23:56.855+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-11 11:23:56.855+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-11 11:23:56.855+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.message.consumer:com.samsung.message.consumer]
04-11 11:23:56.855+0200 E/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(347) > _MessagePortService::SendMessage: Failed :MESSAGEPORT_ERROR_MESSAGEPORT_NOT_FOUND
04-11 11:23:56.855+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-11 11:23:56.855+0200 E/MESSAGE_PORT(25731): MessagePortProxy.cpp: SendMessageInternal(533) > The remote message port is not found.
04-11 11:23:56.855+0200 E/CONTACTS_CONSUMER(25731): ct-sap-svc-client.c: ct_sap_svc_client_mem_info(3594) > [0;31m* Critical * Total allocated space (uordblks):149392
04-11 11:23:56.855+0200 E/CONTACTS_CONSUMER(25731): [0;m
04-11 11:23:56.855+0200 W/MUSIC_TRANSFER(25737): mt-controller.c: _process_setting_change(705) > [36m[TID:25737]   [MUSIC_PLAYER_EVENT]AutoTransfer setting[off][0m
04-11 11:23:56.855+0200 W/MUSIC_TRANSFER(25737): mt-controller.c: mt_msg_process(984) > [33m[TID:25737]   no remain job[0m
04-11 11:23:56.855+0200 W/MUSIC_TRANSFER(25737): mt-consumer.c: mt_consumer_disconnect_peer(586) > [36m[TID:25737]   [MUSIC_PLAYER_EVENT][0m
04-11 11:23:57.135+0200 W/MUSIC_TRANSFER(25737): mt-consumer.c: __mt_consumer_on_termination_indication(372) > [33m[TID:25737]   uwServiceHandle : [20460], wStatusCode : [999][0m
04-11 11:23:57.135+0200 W/MUSIC_TRANSFER(25737): mt-controller.c: _connection_changed_cb(225) > [36m[TID:25737]   [MUSIC_PLAYER_EVENT]connected[0], from_peer[1][0m
04-11 11:23:57.135+0200 W/MUSIC_TRANSFER(25737): mt-auto-transfer.c: mt_auto_transfer_clear(897) > [36m[TID:25737]   [MUSIC_PLAYER_EVENT][0m
04-11 11:23:57.135+0200 W/MUSIC_TRANSFER(25737): mt-auto-transfer.c: mt_auto_transfer_clear(900) > [33m[TID:25737]   in progress = 0, success = 0[0m
04-11 11:23:57.180+0200 W/CRASH_MANAGER(25802): worker.c: worker_job(1205) > 1125760736c65152343863
