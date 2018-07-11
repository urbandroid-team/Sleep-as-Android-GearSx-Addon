S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.2.7
Build-Number: R732XXU2FRC1
Build-Date: 2018.03.02 17:21:30

Crash Information
Process Name: sleepasandroidnativeservice
PID: 3374
Date: 2018-04-11 14:40:34+0200
Executable File Path: /opt/usr/apps/com.urbandroid.sleep/bin/sleepasandroidnativeservice
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x2e302e2d

Register Information
r0   = 0x2e302e31, r1   = 0x2e302e31
r2   = 0x000000ec, r3   = 0x00000000
r4   = 0x43a03420, r5   = 0x43a03768
r6   = 0x0000589d, r7   = 0xbea52eb0
r8   = 0x00008d0c, r9   = 0x00008d0c
r10  = 0x430acec8, fp   = 0x00000000
ip   = 0x40014ad4, sp   = 0xbea52da0
lr   = 0x400021a3, pc   = 0x4043d56c
cpsr = 0x20000010

Memory Information
MemTotal:   491132 KB
MemFree:     11840 KB
Buffers:     23008 KB
Cached:     152080 KB
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
PID = 3374 TID = 3374
3374 3407 

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
4319a000 43a00000 rw-p [stack:3407]
bea33000 bea54000 rw-p [stack]
End of Maps Information

Callstack Information (PID:3374)
Call Stack Count: 1
 0: cfree + 0x2c (0x4043d56c) [/lib/libc.so.6] + 0x7256c
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
gentID:34361 ServiceHandle:0[0m
04-11 14:40:32.210+0200 E/WG-CONSUMER( 1751): [31m[F:SAPProxy.cpp     L:  161][ERROR]Duplication connection. not inseterd[0m
04-11 14:40:32.210+0200 E/WG-CONSUMER( 1751): [31m[F:SAPProxy.cpp     L:  165][ERROR]Previous pCurrent(0x4332bc00) is exist[0m
04-11 14:40:32.210+0200 W/WG-CONSUMER( 1751): [34m[F:SAPProxy.cpp     L:  601][_HIGH]Device Connected. Cur type=BT|[0m
04-11 14:40:32.210+0200 W/WG-CONSUMER( 1751): [34m[F:SAPProxy.cpp     L:  186][_HIGH]Device connected. WMS=1 BT=1 [0m
04-11 14:40:32.210+0200 W/WG-CONSUMER( 1751): [34m[F:ConnectionInfo.c L:  568][_HIGH][RX]advance. CurState=SM_STATE_REGISTER_AGENT(4)[0m
04-11 14:40:32.210+0200 W/WG-CONSUMER( 1751): [34m[F:ConnectionInfo.c L:  603][_HIGH][RX]State changed: SM_STATE_REGISTER_AGENT->SM_STATE_FINDING_PEER[0m
04-11 14:40:32.210+0200 W/WVMS_SERVER( 3361): wvms-server-consumer.c: wvoice_memo_register_service_agent_confirm(242) >  Register service agent success
04-11 14:40:32.270+0200 D/SleepAsAndroidConsumer( 3374): HRM is  supported
04-11 14:40:32.270+0200 W/AUL_AMD (  524): amd_status.c: __socket_monitor_cb(1277) > (3374) was created
04-11 14:40:32.450+0200 E/CONTACTS_CONSUMER( 3121): ct-sap-svc-client.c: __ct_sap_svc_client_find_peer_agent(1180) > [0;31m* Critical * connectivity_type 1[0;m
04-11 14:40:32.450+0200 W/WG-CONSUMER( 1751): [34m[F:ConnectionInfo.c L:  418][_HIGH][RX]Finding Peer Agent. AgentID=34361[0m
04-11 14:40:32.515+0200 W/WVMS_SERVER( 3361): wvms-server-consumer.c: __wvoice_memo_find_peer_agent(229) > [32m Call find peer success[0m
04-11 14:40:32.515+0200 W/WVMS_SERVER( 3361): wvms-server-consumer.c: wvoice_memo_register_consumer(471) >  init complete
04-11 14:40:32.550+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: OnConnectionRequest(411) > _MessagePortIpcServer::OnConnectionRequest
04-11 14:40:32.565+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnIpcClientConnected(172) > MessagePort Ipc connected
04-11 14:40:32.570+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: OnConnectionRequest(411) > _MessagePortIpcServer::OnConnectionRequest
04-11 14:40:32.585+0200 E/weather-consumer( 3366): WeatherConsumerController.cpp: Start(73) > [0;40;31mhostDeviceVendor : LGE[0;m
04-11 14:40:32.590+0200 E/weather-consumer( 3366): AppcessoryProtocol.cpp: SetSendMessageType(60) > [0;40;31mSetSendMessageType : 0[0;m
04-11 14:40:32.590+0200 E/weather-consumer( 3366): AppcessoryProtocol.cpp: MakeMessageForAndroid(88) > [0;40;31mMakeMessageForAndroid[0;m
04-11 14:40:32.590+0200 E/weather-consumer( 3366): AppcessoryProtocol.cpp: CreateCpListText(160) > [0;40;31mCP list supported : "Accuweather","TWC","WeatherNews","cmaweather","Kweather","WCN"[0;m
04-11 14:40:32.590+0200 E/weather-consumer( 3366): AppcessoryProtocol.cpp: MakeMessageForAndroid(140) > [0;40;31mmSendMessage : {"WEATHER_REQUEST":{"FETCH_REQ":1,"SHOW_SETTING_ON_DEVICE":0,"UPDATED_BY_GEAR":0,"CP_LIST":["Accuweather","TWC","WeatherNews","cmaweather","Kweather","WCN"],"ADD_CURRENT_CITY":0},"REVISION":1,"WEATHER_ACK_SEQ": "1523450432"}[0;m
04-11 14:40:32.590+0200 E/weather-consumer( 3366): SAP.cpp: InitializeSAPConnection(142) > [0;40;31mSAP::InitializeSAPConnection[0;m
04-11 14:40:32.595+0200 E/weather-consumer( 3366): SAP.cpp: CreateService(126) > [0;40;31mSAP::CreateService[0;m
04-11 14:40:32.635+0200 E/weather-consumer( 3366): SAPNotificationCallback.cpp: OnRegisterServiceAgentConfirm(35) > [0;40;31mAlready Registered uwLocalAgentId, 31507 : 31507[0;m
04-11 14:40:32.660+0200 E/SleepAsAndroidConsumer( 3374): SUCCESSFULLY create sap agent
04-11 14:40:32.720+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-11 14:40:32.720+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-11 14:40:32.720+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-11 14:40:32.720+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnRegisterMessagePort(91) > _MessagePortStub::OnRegisterMessagePort.
04-11 14:40:32.720+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: RegisterMessagePort(83) > _MessagePortService::RegisterMessagePort
04-11 14:40:32.720+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-11 14:40:32.720+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: RegisterMessagePort(95) > Register a message port: [com.samsung.w-voicerecorder.consumer:com.samsung.voice_memo_c1_server], client = 3361
04-11 14:40:32.720+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-11 14:40:32.720+0200 W/WVMS_SERVER( 3361): wvms-server-ipc.c: wvms_server_ipc_init(53) >  port id : [1]
04-11 14:40:32.745+0200 E/AUL_PAD ( 1393): launchpad.c: main(892) > Refused candidate process connection
04-11 14:40:32.760+0200 I/efl-extension( 3379): efl_extension.c: eext_mod_shutdown(46) > Shutdown
04-11 14:40:32.790+0200 E/weather-consumer( 3366): WeatherConsumerController.cpp: OnAppcessoryProtocolConnected(134) > [0;40;31mOnAppcessoryProtocolConnected[0;m
04-11 14:40:32.795+0200 W/CONTACTS_CONSUMER( 3121): ct-sap-svc-client.c: __on_create(2490) > [0;35mis_connected_by_scs 0[0;m
04-11 14:40:32.795+0200 E/CONTACTS_CONSUMER( 3121): ct-sap-svc-client.c: ct_sap_svc_client_mem_info(3594) > [0;31m* Critical * Total allocated space (uordblks):200672
04-11 14:40:32.795+0200 E/CONTACTS_CONSUMER( 3121): [0;m
04-11 14:40:32.795+0200 I/MALI    ( 3379): egl_platform_x11.c: __egl_platform_terminate(324) > [EGL-X11] ################################################
04-11 14:40:32.805+0200 I/MALI    ( 3379): egl_platform_x11.c: __egl_platform_terminate(325) > [EGL-X11] PID=3379   close drm_fd=22 
04-11 14:40:32.805+0200 I/MALI    ( 3379): egl_platform_x11.c: __egl_platform_terminate(326) > [EGL-X11] ################################################
04-11 14:40:32.855+0200 I/efl-extension( 3352): efl_extension.c: eext_mod_init(40) > Init
04-11 14:40:32.860+0200 E/CAPI_APPFW_APP_CONTROL( 3355): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : failed to retrieve the appid of the caller
04-11 14:40:32.860+0200 W/CAPI_APPFW_APP_CONTROL( 3355): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-11 14:40:32.860+0200 W/CAPI_APPFW_APP_CONTROL( 3355): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-11 14:40:32.860+0200 E/CAPI_APPFW_APP_CONTROL( 3355): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : failed to retrieve the appid of the caller
04-11 14:40:32.875+0200 W/AUL_PAD ( 1393): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 3379 pgid = 3379
04-11 14:40:32.875+0200 W/AUL_PAD ( 1393): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 1 ssi_status = 255
04-11 14:40:32.910+0200 W/SSPAY_UI_SVC( 3352): sspay_ui_svc_main.c: main(292) > [36mmain start[0m
04-11 14:40:32.920+0200 W/AUL_AMD (  524): amd_status.c: __socket_monitor_cb(1277) > (3352) was created
04-11 14:40:32.920+0200 W/SSPAY_UI_SVC( 3352): sspay_ui_svc_main.c: _service_create(93) > [36m_service_create start[0m
04-11 14:40:32.925+0200 W/SSPAY_UI_SVC( 3352): sspay_ui_svc_utils.c: sspay_ui_svc_util_get_CountryISO_with_CSC(2281) > [36mCountryISO [DE][0m
04-11 14:40:32.925+0200 E/SSPAY_UI_SVC( 3352): sspay_ui_svc_app_management.c: sspay_ui_svc_am_is_retailmode_enabled(92) > [31m(ret != VCONF_OK) [0m
04-11 14:40:32.925+0200 E/SSPAY_UI_SVC( 3352): sspay_ui_svc_main.c: _service_create(100) > [31mNOT ALLOWED Country!!!!!!!!!!!!!!!!![0m
04-11 14:40:32.925+0200 W/SSPAY_UI_SVC( 3352): sspay_ui_svc.c: sspay_ui_svc_terminate(1712) > [36mterminate sspay-ui-svc with cpu lock during 5 sec[0m
04-11 14:40:32.955+0200 W/AUL_PAD ( 1393): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
04-11 14:40:32.960+0200 I/AUL_AMD (  524): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 3379
04-11 14:40:32.960+0200 W/AUL     (  524): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(3379)
04-11 14:40:32.975+0200 E/PKGMGR_SERVER( 3396): pkgmgr-server.c: exit_server(1620) > exit_server Start [backend_status=1, queue_status=1] 
04-11 14:40:32.975+0200 E/PKGMGR_SERVER( 3396): pkgmgr-server.c: main(2296) > package manager server terminated.
04-11 14:40:32.995+0200 W/WG-CONSUMER( 1751): [32m[F:SAPProxy.cpp     L:  830][_WARN]OnPeerAgent:Found Peer. LocalAgentID[34360], pPeerAgent[0x43344788], wStatusCode=PEER_AGENT_FOUND[0m
04-11 14:40:32.995+0200 W/WG-CONSUMER( 1751): [32m[F:ConnectionInfo.c L:  945][_WARN][TX]FoundPeer. LocalAgentID[34360], pPeerAgent[0x43344788], wStatusCode=PEER_AGENT_FOUND[0m
04-11 14:40:32.995+0200 W/WG-CONSUMER( 1751): [34m[F:PeerList.cpp     L:  255][_HIGH][TX]Add CPeerAgent(0xbea350e4) into PeerList. Count=0[0m
04-11 14:40:32.995+0200 W/WG-CONSUMER( 1751): [34m[F:PeerList.cpp     L:  100][_HIGH][TX]***** Dump Peer - "Added" *****[0m
04-11 14:40:32.995+0200 W/WG-CONSUMER( 1751): [34m[F:PeerList.cpp     L:  103][_HIGH][TX]This=0x43335080 PeerAgent(0x43335084) bSet(1)[0m
04-11 14:40:32.995+0200 W/WG-CONSUMER( 1751): [34m[F:PeerList.cpp     L:  104][_HIGH][TX]  DeviceID=2 PeerAgentID=51287 ServiceHandle=0[0m
04-11 14:40:32.995+0200 W/WG-CONSUMER( 1751): [34m[F:PeerList.cpp     L:  106][_HIGH][TX]  DeviceName=* MAC=* ALE=HostManager ASPID=* Version=2.1[0m
04-11 14:40:32.995+0200 W/WG-CONSUMER( 1751): [34m[F:PeerList.cpp     L:  107][_HIGH][TX]  ConnectType(1) : BT[0m
04-11 14:40:32.995+0200 W/WG-CONSUMER( 1751): [34m[F:PeerList.cpp     L:  111][_HIGH][TX]***********************************[0m
04-11 14:40:32.995+0200 W/WG-CONSUMER( 1751): [34m[F:ConnectionInfo.c L:  977][_HIGH][TX]Add timer for next Peer for 0.5s[0m
04-11 14:40:32.995+0200 W/WG-CONSUMER( 1751): [32m[F:SAPProxy.cpp     L:  830][_WARN]OnPeerAgent:Found Peer. LocalAgentID[34361], pPeerAgent[0x43348840], wStatusCode=PEER_AGENT_FOUND[0m
04-11 14:40:32.995+0200 W/WG-CONSUMER( 1751): [32m[F:ConnectionInfo.c L:  945][_WARN][RX]FoundPeer. LocalAgentID[34361], pPeerAgent[0x43348840], wStatusCode=PEER_AGENT_FOUND[0m
04-11 14:40:32.995+0200 W/WG-CONSUMER( 1751): [34m[F:PeerList.cpp     L:  255][_HIGH][RX]Add CPeerAgent(0xbea350e4) into PeerList. Count=0[0m
04-11 14:40:32.995+0200 W/WG-CONSUMER( 1751): [34m[F:PeerList.cpp     L:  100][_HIGH][RX]***** Dump Peer - "Added" *****[0m
04-11 14:40:33.000+0200 W/WG-CONSUMER( 1751): [34m[F:PeerList.cpp     L:  103][_HIGH][RX]This=0x43336b70 PeerAgent(0x43336b74) bSet(1)[0m
04-11 14:40:33.000+0200 W/WG-CONSUMER( 1751): [34m[F:PeerList.cpp     L:  104][_HIGH][RX]  DeviceID=2 PeerAgentID=10712 ServiceHandle=0[0m
04-11 14:40:33.000+0200 W/WG-CONSUMER( 1751): [34m[F:PeerList.cpp     L:  106][_HIGH][RX]  DeviceName=* MAC=* ALE=HostManager ASPID=* Version=3.0[0m
04-11 14:40:33.000+0200 W/WG-CONSUMER( 1751): [34m[F:PeerList.cpp     L:  107][_HIGH][RX]  ConnectType(1) : BT[0m
04-11 14:40:33.000+0200 W/WG-CONSUMER( 1751): [34m[F:PeerList.cpp     L:  111][_HIGH][RX]***********************************[0m
04-11 14:40:33.000+0200 W/WG-CONSUMER( 1751): [34m[F:ConnectionInfo.c L:  977][_HIGH][RX]Add timer for next Peer for 0.5s[0m
04-11 14:40:33.000+0200 W/WG-CONSUMER( 1751): [34m[F:ConnectionInfo.c L:  603][_HIGH][TX]State changed: SM_STATE_FINDING_PEER->SM_STATE_FOUND_PEER[0m
04-11 14:40:33.000+0200 W/WG-CONSUMER( 1751): [34m[F:ConnectionInfo.c L:  568][_HIGH][TX]advance. CurState=SM_STATE_FOUND_PEER(6)[0m
04-11 14:40:33.000+0200 W/WG-CONSUMER( 1751): [34m[F:ConnectionInfo.c L:  603][_HIGH][TX]State changed: SM_STATE_FOUND_PEER->SM_STATE_REQUEST_SERVICE[0m
04-11 14:40:33.000+0200 W/WG-CONSUMER( 1751): [34m[F:ConnectionInfo.c L:  438][_HIGH][TX]Connect to BT Peer[0m
04-11 14:40:33.000+0200 W/WG-CONSUMER( 1751): [34m[F:PeerList.cpp     L:  100][_HIGH][TX]***** Dump Peer - "BestPeer" *****[0m
04-11 14:40:33.000+0200 W/WG-CONSUMER( 1751): [34m[F:PeerList.cpp     L:  103][_HIGH][TX]This=0x43335080 PeerAgent(0x43335084) bSet(1)[0m
04-11 14:40:33.000+0200 W/WG-CONSUMER( 1751): [34m[F:PeerList.cpp     L:  104][_HIGH][TX]  DeviceID=2 PeerAgentID=51287 ServiceHandle=0[0m
04-11 14:40:33.000+0200 W/WG-CONSUMER( 1751): [34m[F:PeerList.cpp     L:  106][_HIGH][TX]  DeviceName=* MAC=* ALE=HostManager ASPID=* Version=2.1[0m
04-11 14:40:33.000+0200 W/WG-CONSUMER( 1751): [34m[F:PeerList.cpp     L:  107][_HIGH][TX]  ConnectType(1) : BT[0m
04-11 14:40:33.005+0200 W/WG-CONSUMER( 1751): [34m[F:PeerList.cpp     L:  111][_HIGH][TX]***********************************[0m
04-11 14:40:33.005+0200 W/WG-CONSUMER( 1751): [34m[F:ConnectionInfo.c L:  461][_HIGH][TX]CreateServiceConnection. for LocalAgentID=34360 to Peer(0x43335080)[0m
04-11 14:40:33.005+0200 W/WG-CONSUMER( 1751): [34m[F:ConnectionInfo.c L:  603][_HIGH][RX]State changed: SM_STATE_FINDING_PEER->SM_STATE_FOUND_PEER[0m
04-11 14:40:33.005+0200 W/WG-CONSUMER( 1751): [34m[F:ConnectionInfo.c L:  568][_HIGH][RX]advance. CurState=SM_STATE_FOUND_PEER(6)[0m
04-11 14:40:33.005+0200 W/WG-CONSUMER( 1751): [34m[F:ConnectionInfo.c L:  603][_HIGH][RX]State changed: SM_STATE_FOUND_PEER->SM_STATE_REQUEST_SERVICE[0m
04-11 14:40:33.005+0200 W/WG-CONSUMER( 1751): [34m[F:ConnectionInfo.c L:  438][_HIGH][RX]Connect to BT Peer[0m
04-11 14:40:33.005+0200 W/WG-CONSUMER( 1751): [34m[F:PeerList.cpp     L:  100][_HIGH][RX]***** Dump Peer - "BestPeer" *****[0m
04-11 14:40:33.005+0200 W/WG-CONSUMER( 1751): [34m[F:PeerList.cpp     L:  103][_HIGH][RX]This=0x43336b70 PeerAgent(0x43336b74) bSet(1)[0m
04-11 14:40:33.005+0200 W/WG-CONSUMER( 1751): [34m[F:PeerList.cpp     L:  104][_HIGH][RX]  DeviceID=2 PeerAgentID=10712 ServiceHandle=0[0m
04-11 14:40:33.005+0200 W/WG-CONSUMER( 1751): [34m[F:PeerList.cpp     L:  106][_HIGH][RX]  DeviceName=* MAC=* ALE=HostManager ASPID=* Version=3.0[0m
04-11 14:40:33.010+0200 W/WG-CONSUMER( 1751): [34m[F:PeerList.cpp     L:  107][_HIGH][RX]  ConnectType(1) : BT[0m
04-11 14:40:33.010+0200 W/WG-CONSUMER( 1751): [34m[F:PeerList.cpp     L:  111][_HIGH][RX]***********************************[0m
04-11 14:40:33.010+0200 W/WG-CONSUMER( 1751): [34m[F:ConnectionInfo.c L:  461][_HIGH][RX]CreateServiceConnection. for LocalAgentID=34361 to Peer(0x43336b70)[0m
04-11 14:40:33.210+0200 W/W_INDICATOR(  736): windicator_util.c: _pm_state_changed_cb(915) > [_pm_state_changed_cb:915] LCD on
04-11 14:40:33.210+0200 W/W_INDICATOR(  736): windicator_ongoing_info_shealth.c: windicator_ongoing_info_shealth_update(57) > [windicator_ongoing_info_shealth_update:57] windicator_shealth_update
04-11 14:40:33.210+0200 W/SHealthCommon(  962): SystemUtil.cpp: OnDeviceStatusChanged(1007) > [1;35mlcdState:1[0;m
04-11 14:40:33.220+0200 W/SHealthCommon( 1422): SystemUtil.cpp: OnDeviceStatusChanged(1007) > [1;35mlcdState:1[0;m
04-11 14:40:33.220+0200 W/SHealthServiceCommon( 1422): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(645) > [1;35m ###[0;m
04-11 14:40:33.230+0200 W/SHealthServiceCommon( 1422): EnergyExpenditureFeatureController.cpp: OnTotalEnergyExpenditureChanged(119) > [1;40;33mstart 1523397600000,000000, end 1523450433232,000000, calories 1088,665759[0;m
04-11 14:40:33.230+0200 W/SHealthCommon( 1422): SHealthMessagePortConnection.cpp: SendServiceMessage(558) > [1;40;33mmessageName: energy_expenditure_updated, pendingClientInfoList.size(): 0[0;m
04-11 14:40:33.280+0200 W/WATCH_CORE(  888): appcore-watch.c: __signal_lcd_status_handler(1231) > signal_lcd_status_signal: LCDOn
04-11 14:40:33.280+0200 I/WATCH_CORE(  888): appcore-watch.c: __signal_lcd_status_handler(1250) > Call the time_tick_cb
04-11 14:40:33.285+0200 I/CAPI_WATCH_APPLICATION(  888): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-11 14:40:33.285+0200 I/WATCH_CORE(  888): appcore-watch.c: __signal_lcd_status_handler(1257) > Call widget_provider_update_event
04-11 14:40:33.285+0200 W/W_HOME  (  799): dbus.c: _dbus_message_recv_cb(186) > LCD on
04-11 14:40:33.285+0200 W/W_HOME  (  799): gesture.c: _manual_render_disable_timer_set(167) > timer set
04-11 14:40:33.285+0200 W/W_HOME  (  799): gesture.c: _manual_render_disable_timer_del(157) > timer del
04-11 14:40:33.285+0200 W/W_HOME  (  799): gesture.c: _apps_status_get(128) > apps status:0
04-11 14:40:33.285+0200 W/W_HOME  (  799): gesture.c: _lcd_on_cb(303) > move_to_clock:0 clock_visible:0 info->offtime:9693
04-11 14:40:33.285+0200 W/W_HOME  (  799): gesture.c: _manual_render_schedule(209) > schedule, manual render
04-11 14:40:33.285+0200 W/W_HOME  (  799): event_manager.c: _lcd_on_cb(715) > lcd state: 1
04-11 14:40:33.285+0200 W/W_HOME  (  799): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-11 14:40:33.290+0200 W/W_HOME  (  799): gesture.c: _widget_updated_cb(188) > widget updated
04-11 14:40:33.290+0200 W/W_HOME  (  799): gesture.c: _manual_render_disable_timer_del(157) > timer del
04-11 14:40:33.290+0200 W/W_HOME  (  799): gesture.c: _manual_render(182) > 
04-11 14:40:33.300+0200 W/STARTER (  735): clock-mgr.c: _on_lcd_signal_receive_cb(1258) > [_on_lcd_signal_receive_cb:1258] _on_lcd_signal_receive_cb, 1258, Pre LCD on by [unknown] after screen off time [9693]ms
04-11 14:40:33.300+0200 W/STARTER (  735): clock-mgr.c: _pre_lcd_on(1027) > [_pre_lcd_on:1027] Will LCD ON as reserved app[(null)] alpm mode[0]
04-11 14:40:33.315+0200 I/APP_CORE( 3335): appcore-efl.c: __do_app(453) > [APP 3335] Event: RESUME State: RUNNING
04-11 14:40:33.335+0200 I/HealthDataService(  852): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_GET[0;m
04-11 14:40:33.370+0200 W/WAKEUP-SERVICE( 1343): WakeupService.cpp: OnReceiveDisplayChanged(970) > [0;32mINFO: LCDOn receive data : 1075006220[0;m
04-11 14:40:33.380+0200 W/WAKEUP-SERVICE( 1343): WakeupService.cpp: OnReceiveDisplayChanged(971) > [0;32mINFO: WakeupServiceStart[0;m
04-11 14:40:33.380+0200 W/WAKEUP-SERVICE( 1343): WakeupService.cpp: WakeupServiceStart(367) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
04-11 14:40:33.380+0200 W/STARTER (  735): clock-mgr.c: _on_lcd_signal_receive_cb(1271) > [_on_lcd_signal_receive_cb:1271] _on_lcd_signal_receive_cb, 1271, Post LCD on by [unknown]
04-11 14:40:33.380+0200 W/STARTER (  735): clock-mgr.c: _post_lcd_on(1059) > [_post_lcd_on:1059] LCD ON as reserved app[(null)] alpm mode[0]
04-11 14:40:33.380+0200 I/TIZEN_N_SOUND_MANAGER( 1343): sound_manager_product.c: sound_manager_svoice_set_param(1287) > [SVOICE] set param [keyword length] : 0
04-11 14:40:33.390+0200 I/MALI    (  799): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x43ed9330] swap changed from sync to async
04-11 14:40:33.400+0200 W/TIZEN_N_SOUND_MANAGER( 1343): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
04-11 14:40:33.405+0200 W/W_INDICATOR(  736): windicator_ongoing_info_shealth.c: windicator_ongoing_info_shealth_update(78) > [windicator_ongoing_info_shealth_update:78] Result : 0
04-11 14:40:33.405+0200 W/W_INDICATOR(  736): windicator_ongoing_info_shealth.c: windicator_ongoing_info_shealth_update(99) > [windicator_ongoing_info_shealth_update:99] status : none
04-11 14:40:33.405+0200 W/W_INDICATOR(  736): windicator_ongoing_info_shealth.c: windicator_ongoing_info_shealth_update(103) > [windicator_ongoing_info_shealth_update:103] application_id: 
04-11 14:40:33.405+0200 W/W_INDICATOR(  736): windicator_ongoing_info_shealth.c: windicator_ongoing_info_shealth_update(112) > [windicator_ongoing_info_shealth_update:112] launch_operation : 
04-11 14:40:33.405+0200 W/W_INDICATOR(  736): windicator_ongoing_info_shealth.c: windicator_ongoing_info_shealth_update(118) > [windicator_ongoing_info_shealth_update:118] extra_data_key : 
04-11 14:40:33.405+0200 W/W_INDICATOR(  736): windicator_ongoing_info_shealth.c: windicator_ongoing_info_shealth_update(124) > [windicator_ongoing_info_shealth_update:124] extra_data_value : 
04-11 14:40:33.405+0200 W/W_INDICATOR(  736): windicator_ongoing_info_shealth.c: windicator_ongoing_info_shealth_update(132) > [windicator_ongoing_info_shealth_update:132] image_path : 
04-11 14:40:33.405+0200 W/W_INDICATOR(  736): windicator_ongoing_info_shealth.c: windicator_ongoing_info_shealth_update(135) > [windicator_ongoing_info_shealth_update:135] image_path_sub : 
04-11 14:40:33.405+0200 W/W_INDICATOR(  736): windicator_ongoing_info_shealth.c: windicator_ongoing_info_shealth_update(138) > [windicator_ongoing_info_shealth_update:138] message_string :  
04-11 14:40:33.405+0200 W/W_INDICATOR(  736): windicator_ongoing_info_shealth.c: windicator_ongoing_info_shealth_update(144) > [windicator_ongoing_info_shealth_update:144] [Update] SHealth status is none, so hide icon and text!
04-11 14:40:33.405+0200 W/W_INDICATOR(  736): windicator_ongoing_info.c: windicator_ongoing_info_remove(191) > [windicator_ongoing_info_remove:191] Ongoing info type[1]
04-11 14:40:33.410+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-11 14:40:33.410+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-11 14:40:33.410+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-11 14:40:33.410+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-11 14:40:33.410+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-11 14:40:33.410+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-11 14:40:33.410+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-11 14:40:33.410+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-11 14:40:33.410+0200 W/W_INDICATOR(  736): windicator_ongoing_info.c: windicator_ongoing_info_remove(191) > [windicator_ongoing_info_remove:191] Ongoing info type[2]
04-11 14:40:33.410+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-11 14:40:33.410+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-11 14:40:33.410+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-11 14:40:33.410+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-11 14:40:33.410+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-11 14:40:33.410+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-11 14:40:33.410+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-11 14:40:33.410+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-11 14:40:33.410+0200 W/W_INDICATOR(  736): windicator_quick_setting_brightness.c: windicator_quick_setting_brightness_update(94) > [windicator_quick_setting_brightness_update:94] hyun 90
04-11 14:40:33.410+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-11 14:40:33.410+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-11 14:40:33.410+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-11 14:40:33.410+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-11 14:40:33.410+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-11 14:40:33.410+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-11 14:40:33.410+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-11 14:40:33.410+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-11 14:40:33.415+0200 W/W_INDICATOR(  736): windicator_connection.c: windicator_connection_resume(2158) > [windicator_connection_resume:2158] 
04-11 14:40:33.415+0200 W/W_INDICATOR(  736): windicator_connection.c: _wifi_state_changed_cb(930) > [_wifi_state_changed_cb:930] wifi state : 2
04-11 14:40:33.415+0200 W/W_INDICATOR(  736): windicator_connection.c: _wifi_state_changed_cb(974) > [_wifi_state_changed_cb:974] ap_name : (sleep.urbandroid.org)
04-11 14:40:33.415+0200 W/W_INDICATOR(  736): windicator_connection.c: _wifi_state_changed_cb(994) > [_wifi_state_changed_cb:994] wifi strength : 4
04-11 14:40:33.415+0200 W/W_INDICATOR(  736): windicator_connection.c: _connection_icon_set(713) > [_connection_icon_set:713] type : 16 / signal : type_wifi_connected_04
04-11 14:40:33.415+0200 E/W_INDICATOR(  736): windicator_connection.c: _connection_icon_set(754) > [_connection_icon_set:754] Set Connection / show sw.icon_1 (16)(0)
04-11 14:40:33.415+0200 W/W_INDICATOR(  736): windicator_connection.c: _packet_type_changed_cb(1251) > [_packet_type_changed_cb:1251] _packet_type_changed_cb
04-11 14:40:33.415+0200 E/W_INDICATOR(  736): windicator_connection.c: _packet_type_changed_cb(1261) > [_packet_type_changed_cb:1261] WIFI MODE
04-11 14:40:33.415+0200 W/W_INDICATOR(  736): windicator_connection.c: _packet_icon_set(840) > [_packet_icon_set:840] packet : 3 / signal : packet_inout_connected
04-11 14:40:33.430+0200 W/W_HOME  (  799): gesture.c: _manual_render(182) > 
04-11 14:40:33.465+0200 W/W_HOME  (  799): gesture.c: _manual_render_enable(138) > 0
04-11 14:40:33.475+0200 W/W_INDICATOR(  736): windicator_dbus.c: _windicator_dbus_lcd_changed_cb(533) > [_windicator_dbus_lcd_changed_cb:533] LCD ON signal is received
04-11 14:40:33.475+0200 W/W_INDICATOR(  736): windicator_dbus.c: _windicator_dbus_lcd_changed_cb(554) > [_windicator_dbus_lcd_changed_cb:554] 554, str=[unknown],charge : 0, connected : 0
04-11 14:40:33.475+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-11 14:40:33.475+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-11 14:40:33.475+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-11 14:40:33.475+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-11 14:40:33.475+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-11 14:40:33.475+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-11 14:40:33.475+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [starter:org.tizen.idled.ReservedApp]
04-11 14:40:33.475+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-11 14:40:33.480+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-11 14:40:33.480+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-11 14:40:33.480+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-11 14:40:33.480+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-11 14:40:33.480+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-11 14:40:33.480+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-11 14:40:33.480+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [starter:org.tizen.idled.ReservedApp]
04-11 14:40:33.480+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-11 14:40:33.480+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-11 14:40:33.480+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-11 14:40:33.480+0200 W/STARTER (  735): clock-mgr.c: __reserved_apps_message_received_cb(586) > [__reserved_apps_message_received_cb:586] appid[com.samsung.windicator]
04-11 14:40:33.480+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-11 14:40:33.480+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-11 14:40:33.480+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-11 14:40:33.480+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-11 14:40:33.480+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-11 14:40:33.480+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-11 14:40:33.480+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.windicator:org.tizen.idled.ReservedApp]
04-11 14:40:33.480+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-11 14:40:33.480+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-11 14:40:33.480+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-11 14:40:33.480+0200 W/W_INDICATOR(  736): windicator_dbus.c: _msg_reserved_app_cb(336) > [_msg_reserved_app_cb:336] Moment view is already shown or call is enabled. moment view [0]
04-11 14:40:33.485+0200 W/WG-CONSUMER( 1751): [32m[F:SAPProxy.cpp     L: 1059][_WARN][Phone->Gear] Connection Confirmed. wResponseCode : [0], uwLocalAgentId : [34360] uwServiceHandle : [7940] PeerAgent(0x43324990)[0m
04-11 14:40:33.485+0200 W/WG-CONSUMER( 1751): [34m[F:ConnectionInfo.c L: 1128][_HIGH][TX]connection established. AgentID(34360) ServiceHandle=7940 SM_STATE_REQUEST_SERVICE bUsingWFD=0[0m
04-11 14:40:33.485+0200 W/WG-CONSUMER( 1751): [34m[F:ConnectionInfo.c L: 1147][_HIGH][TX] ConnectionType is BT. Update ServiceHandle. (0->7940)[0m
04-11 14:40:33.485+0200 W/WG-CONSUMER( 1751): [34m[F:ConnectionInfo.c L: 1151][_HIGH][TX]Connection Established. ServiceID=7940[0m
04-11 14:40:33.485+0200 W/WG-CONSUMER( 1751): [34m[F:ConnectionInfo.c L:  603][_HIGH][TX]State changed: SM_STATE_REQUEST_SERVICE->SM_STATE_ESTABLISHED[0m
04-11 14:40:33.490+0200 W/WG-CONSUMER( 1751): [32m[F:TransferCtrl.cpp L:  222][_WARN][TX]CTransferCtrl::OnEstablished[0m
04-11 14:40:33.490+0200 W/WG-CONSUMER( 1751): [34m[F:UserNotification L:  389][_HIGH][Transfer->User] sendNotification *[0m
04-11 14:40:33.490+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-11 14:40:33.490+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-11 14:40:33.490+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-11 14:40:33.490+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-11 14:40:33.490+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-11 14:40:33.490+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-11 14:40:33.490+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-gallery:com.samsung.w-gallery]
04-11 14:40:33.490+0200 E/MESSAGE_PORT(  484): MessagePortService.cpp: CheckRemotePort(235) > _MessagePortService::CheckRemotePort() Failed: MESSAGEPORT_ERROR_MESSAGEPORT_NOT_FOUND
04-11 14:40:33.490+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-11 14:40:33.490+0200 E/MESSAGE_PORT( 1751): MessagePortProxy.cpp: CheckRemotePort(379) > The remote message port (com.samsung.w-gallery) is not found.
04-11 14:40:33.490+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-11 14:40:33.490+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-11 14:40:33.490+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-11 14:40:33.490+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-11 14:40:33.490+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-11 14:40:33.490+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-11 14:40:33.490+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-gallery.appcontrol:com.samsung.w-gallery]
04-11 14:40:33.490+0200 E/MESSAGE_PORT(  484): MessagePortService.cpp: CheckRemotePort(235) > _MessagePortService::CheckRemotePort() Failed: MESSAGEPORT_ERROR_MESSAGEPORT_NOT_FOUND
04-11 14:40:33.490+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-11 14:40:33.490+0200 E/MESSAGE_PORT( 1751): MessagePortProxy.cpp: CheckRemotePort(379) > The remote message port (com.samsung.w-gallery) is not found.
04-11 14:40:33.490+0200 W/WG-CONSUMER( 1751): [32m[F:TransferCtrl.cpp L:  159][_WARN]Command queue is empty[0m
04-11 14:40:33.490+0200 W/WG-CONSUMER( 1751): [34m[F:ConnectionInfo.c L:  620][_HIGH][TX]CConnection(0x4332bc00) Caller=Connection::Established(1162)[0m
04-11 14:40:33.490+0200 W/WG-CONSUMER( 1751): [34m[F:ConnectionInfo.c L:  621][_HIGH]  SM_STATE_ESTABLISHED LocalAgentID=34360 ServiceHandle=7940[0m
04-11 14:40:33.490+0200 W/WG-CONSUMER( 1751): [34m[F:ConnectionInfo.c L:  622][_HIGH]  FTSTATE_INIT PeerCount=1 bUsingWFD=0 RetryTimer=0 nPeerTimer=0[0m
04-11 14:40:33.490+0200 W/WG-CONSUMER( 1751): [34m[F:PeerList.cpp     L:  119][_HIGH]    CPeerAgent=0x43335080 PeerAgent(0x43335084) bSet(1)[0m
04-11 14:40:33.490+0200 W/WG-CONSUMER( 1751): [34m[F:PeerList.cpp     L:  120][_HIGH]    DeviceID=2 PeerAgentID=51287 ServiceHandle=7940[0m
04-11 14:40:33.490+0200 W/WG-CONSUMER( 1751): [34m[F:PeerList.cpp     L:  122][_HIGH]    DeviceName=* MAC=* ALE=HostManager ASPID=* Version=2.1[0m
04-11 14:40:33.490+0200 W/WG-CONSUMER( 1751): [34m[F:PeerList.cpp     L:  123][_HIGH]    ConnectType(1) : BT[0m
04-11 14:40:33.490+0200 E/WAKEUP-SERVICE( 1343): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
04-11 14:40:33.490+0200 E/WAKEUP-SERVICE( 1343): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
04-11 14:40:33.490+0200 I/TIZEN_N_SOUND_MANAGER( 1343): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Enable start
04-11 14:40:33.540+0200 W/WVMS_SERVER( 3361): wvms-server-consumer.c: wvoice_memo_on_peer_agent(258) >  wStatusCode : [0]
04-11 14:40:33.540+0200 W/WVMS_SERVER( 3361): wvms-server-consumer.c: wvoice_memo_on_peer_agent(274) >  call create service connection
04-11 14:40:33.540+0200 W/WVMS_SERVER( 3361): wvms-server-consumer.c: wvoice_memo_on_peer_agent(258) >  wStatusCode : [0]
04-11 14:40:33.540+0200 I/TIZEN_N_SOUND_MANAGER( 1343): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Enable end. (ret: 0x0)
04-11 14:40:33.540+0200 W/TIZEN_N_SOUND_MANAGER( 1343): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
04-11 14:40:33.540+0200 W/WAKEUP-SERVICE( 1343): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 1[0;m
04-11 14:40:33.540+0200 I/HIGEAR  ( 1343): WakeupService.cpp: WakeupServiceStart(393) > [svoice:Application:WakeupServiceStart:IN]
04-11 14:40:33.585+0200 I/CAPI_APPFW_APPLICATION( 3352): service_app_main.c: service_app_exit(441) > service_app_exit
04-11 14:40:33.595+0200 E/CAPI_APPFW_APPLICATION( 3352): service_app_error.c: service_app_error(63) > [_service_app_create] INVALID_CONTEXT(0xfef00001) : service_app_create_cb() returns false
04-11 14:40:33.600+0200 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 22
04-11 14:40:33.600+0200 W/AUL_AMD (  524): amd_request.c: __request_handler(999) > app status : 4
04-11 14:40:33.675+0200 W/WG-CONSUMER( 1751): [32m[F:SAPProxy.cpp     L: 1059][_WARN][Phone->Gear] Connection Confirmed. wResponseCode : [0], uwLocalAgentId : [34361] uwServiceHandle : [7941] PeerAgent(0x43324990)[0m
04-11 14:40:33.680+0200 W/WG-CONSUMER( 1751): [34m[F:ConnectionInfo.c L: 1128][_HIGH][RX]connection established. AgentID(34361) ServiceHandle=7941 SM_STATE_REQUEST_SERVICE bUsingWFD=0[0m
04-11 14:40:33.680+0200 W/WG-CONSUMER( 1751): [34m[F:ConnectionInfo.c L: 1147][_HIGH][RX] ConnectionType is BT. Update ServiceHandle. (0->7941)[0m
04-11 14:40:33.680+0200 W/WG-CONSUMER( 1751): [34m[F:ConnectionInfo.c L: 1151][_HIGH][RX]Connection Established. ServiceID=7941[0m
04-11 14:40:33.680+0200 W/WG-CONSUMER( 1751): [34m[F:ConnectionInfo.c L:  603][_HIGH][RX]State changed: SM_STATE_REQUEST_SERVICE->SM_STATE_ESTABLISHED[0m
04-11 14:40:33.680+0200 W/WG-CONSUMER( 1751): [32m[F:ReceiverCtrl.cpp L:  529][_WARN][RX]Connection is established[0m
04-11 14:40:33.680+0200 W/WG-CONSUMER( 1751): [34m[F:AutoTransfer.cpp L:  114][_HIGH]AutoSync : Gear is not charging[0m
04-11 14:40:33.680+0200 W/WG-CONSUMER( 1751): [34m[F:consumer-app.cpp L:  378][_HIGH]CGalleryConsumer::ResetTimer[0m
04-11 14:40:33.685+0200 W/WG-CONSUMER( 1751): [34m[F:ConnectionInfo.c L:  620][_HIGH][RX]CConnection(0x43308370) Caller=Connection::Established(1162)[0m
04-11 14:40:33.685+0200 W/WG-CONSUMER( 1751): [34m[F:ConnectionInfo.c L:  621][_HIGH]  SM_STATE_ESTABLISHED LocalAgentID=34361 ServiceHandle=7941[0m
04-11 14:40:33.685+0200 W/WG-CONSUMER( 1751): [34m[F:ConnectionInfo.c L:  622][_HIGH]  FTSTATE_INIT PeerCount=1 bUsingWFD=0 RetryTimer=0 nPeerTimer=0[0m
04-11 14:40:33.685+0200 W/WG-CONSUMER( 1751): [34m[F:PeerList.cpp     L:  119][_HIGH]    CPeerAgent=0x43336b70 PeerAgent(0x43336b74) bSet(1)[0m
04-11 14:40:33.685+0200 W/WG-CONSUMER( 1751): [34m[F:PeerList.cpp     L:  120][_HIGH]    DeviceID=2 PeerAgentID=10712 ServiceHandle=7941[0m
04-11 14:40:33.685+0200 W/WG-CONSUMER( 1751): [34m[F:PeerList.cpp     L:  122][_HIGH]    DeviceName=* MAC=* ALE=HostManager ASPID=* Version=3.0[0m
04-11 14:40:33.685+0200 W/WG-CONSUMER( 1751): [34m[F:PeerList.cpp     L:  123][_HIGH]    ConnectType(1) : BT[0m
04-11 14:40:33.715+0200 W/WVMS_SERVER( 3361): wvms-server-consumer.c: wvoice_memo_on_peer_agent(274) >  call create service connection
04-11 14:40:33.720+0200 W/SSPAY_UI_SVC( 3352): sspay_ui_svc_main.c: _service_terminate(129) > [36m_service_terminate start[0m
04-11 14:40:33.720+0200 W/SSPAY_UI_SVC( 3352): sspay_ui_svc_main.c: _service_terminate(135) > [36m_service_terminate end[0m
04-11 14:40:33.775+0200 I/SleepAsAndroidConsumer( 3374): connectivity type(1): bt
04-11 14:40:33.780+0200 W/WVMS_SERVER( 3361): wvms-server-consumer.c: wvoice_memo_on_service_connection_confirm(280) >  wResponseCode : [7]!!!
04-11 14:40:33.835+0200 I/efl-extension( 3352): efl_extension.c: eext_mod_shutdown(46) > Shutdown
04-11 14:40:33.905+0200 E/weather-consumer( 3366): SamsungAppcessoryProtocol.cpp: FetchRequestTimeoutCb(74) > [0;40;31mwe wait a second but send message type still remained as MESSAGE_FET_REQUEST. so we need fetch request[0;m
04-11 14:40:33.910+0200 W/MM_CAMCORDER( 3334): mm_camcorder_internal.c: _mmcamcorder_constructor(203) >  start
04-11 14:40:33.910+0200 W/MM_CAMCORDER( 3334): mm_camcorder_internal.c: _mmcamcorder_constructor(213) >  done
04-11 14:40:33.920+0200 I/efl-extension( 3334): efl_extension.c: eext_mod_init(40) > Init
04-11 14:40:33.995+0200 W/AUL     ( 3411): daemon-manager-release-agent.c: main(12) > release agent : [2:/com.samsung.samsung-pay-app-service]
04-11 14:40:34.000+0200 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 23
04-11 14:40:34.000+0200 W/AUL_AMD (  524): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-11 14:40:34.000+0200 W/AUL_AMD (  524): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 3352
04-11 14:40:34.000+0200 W/AUL_AMD (  524): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-11 14:40:34.005+0200 E/RESOURCED(  608): procfs.c: proc_get_oom_score_adj(178) > fopen /proc/3352/oom_score_adj failed
04-11 14:40:34.005+0200 E/RESOURCED(  608): proc-main.c: resourced_proc_status_change(1501) > Empty pid or process not exists. 3352
04-11 14:40:34.010+0200 I/AUL_AMD (  524): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 3352
04-11 14:40:34.010+0200 W/AUL     (  524): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(3352)
04-11 14:40:34.035+0200 W/WVMS_SERVER( 3361): wvms-server-consumer.c: wvoice_memo_on_service_connection_confirm(280) >  wResponseCode : [0]!!!
04-11 14:40:34.040+0200 W/WVMS_SERVER( 3361): wvms-server-consumer.c: wvoice_memo_on_service_connection_confirm(294) > [32m service connection success[0m
04-11 14:40:34.120+0200 E/CAPI_APPFW_APPLICATION_ALARM( 3355): alarm.c: convert_error_code_to_alarm(77) > [alarm_cancel] INVALID_PARAMETER(0xffffffea)
04-11 14:40:34.175+0200 I/SleepAsAndroidConsumer( 3374): agent is initialized
04-11 14:40:34.175+0200 D/SleepAsAndroidConsumer( 3374): find peer called
04-11 14:40:34.175+0200 I/SleepAsAndroidConsumer( 3374): agent initialized callback is over
04-11 14:40:34.175+0200 D/SleepAsAndroidConsumer( 3374): SAP >>> getRegisteredServiceAgent() >>> 0
04-11 14:40:34.255+0200 W/SHealthCommon( 1422): CpuLock.cpp: CheckAndReset(168) > [1;40;33mREQUEST POWER LOCK CPU [4990][0;m
04-11 14:40:34.265+0200 E/weather-consumer( 3366): SAPNotificationCallback.cpp: OnDataIndication(65) > [0;40;31mOnDataIndication called. payloadLength(30)[0;m
04-11 14:40:34.270+0200 E/weather-consumer( 3366): AppcessoryProtocol.cpp: SetSendMessageType(60) > [0;40;31mSetSendMessageType : 9999[0;m
04-11 14:40:34.270+0200 W/WVMS_SERVER( 3361): wvms-server-consumer.c: wvms_server_consumer_send_msg(560) >  send data success
04-11 14:40:34.275+0200 E/weather-consumer( 3366): AppcessoryProtocol.cpp: SetSendMessageType(79) > [0;40;31m[Error] Wrong MessageType : 9999[0;m
04-11 14:40:34.275+0200 D/SleepAsAndroidConsumer( 3374): find peer call succeeded
04-11 14:40:34.285+0200 W/SHealthServiceCommon( 1422): InactiveTimeSensorProxy.cpp: SOnContextInactiveStatusChanged(166) > [1;35mInactive Time Callback[0;m
04-11 14:40:34.285+0200 D/SleepAsAndroidConsumer( 3374): find peer call is over
04-11 14:40:34.290+0200 I/SleepAsAndroidConsumer( 3374): Find Peer Success!!
04-11 14:40:34.290+0200 D/SleepAsAndroidConsumer( 3374): request_service_connection call over
04-11 14:40:34.290+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1422): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
04-11 14:40:34.290+0200 E/weather-common( 3366): JsonUtil.cpp: GetObjectFromNode(95) > [0;40;31m[GetObjectFromNode(): 95] (node == NULL) [return][0;m
04-11 14:40:34.290+0200 D/SleepAsAndroidConsumer( 3374): req service conn call succeeded
04-11 14:40:34.290+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1422): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
04-11 14:40:34.295+0200 E/weather-common( 3366): SAPMessageParser.cpp: ParseSettingInfo(825) > [0;40;31msettingNode is NULL[0;m
04-11 14:40:34.295+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1422): preference.c: preference_get_double(1214) > preference_get_double(1422) : pedometer_inactive_period error
04-11 14:40:34.295+0200 E/weather-common( 3366): JsonUtil.cpp: GetArrayFromNode(103) > [0;40;31m[GetArrayFromNode(): 103] (node == NULL) [return][0;m
04-11 14:40:34.295+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1422): preference.c: _preference_check_retry_err(507) > key(inactive_test_mode_on), check retry err: -21/(2/No such file or directory).
04-11 14:40:34.295+0200 E/weather-common( 3366): JsonUtil.cpp: GetArrayLength(119) > [0;40;31m[GetArrayLength(): 119] (array == NULL) [return][0;m
04-11 14:40:34.295+0200 E/weather-common( 3366): SAPMessageParser.cpp: ParseWeatherInfo(800) > [0;40;31mweatherNode is NULL[0;m
04-11 14:40:34.295+0200 E/weather-consumer( 3366): SamsungAppcessoryProtocol.cpp: OnAppcessoryProtocolDataReceived(265) > [0;40;31m[OnAppcessoryProtocolDataReceived(): 265] (!sapMessageParser->ParseWeatherInfo()) [break][0;m
04-11 14:40:34.295+0200 E/weather-common( 3366): SAPMessageParser.cpp: ParseAckSeq(849) > [0;40;31mWeatherAckSeq : 1523450432[0;m
04-11 14:40:34.295+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1422): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_test_mode_on) step(-17825744) failed(2 / No such file or directory)
04-11 14:40:34.300+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1422): preference.c: preference_get_boolean(1173) > preference_get_boolean(1422) : inactive_test_mode_on error
04-11 14:40:34.300+0200 W/SHealthServiceCommon( 1422): InactiveTimeSensorProxy.cpp: SOnContextInactiveStatusChanged(208) > [1;40;33minactive state change : => PEDOMETER_INACTIVE_STATE_10MIN_PRECAUTION[0;m
04-11 14:40:34.300+0200 E/weather-consumer( 3366): SamsungAppcessoryProtocol.cpp: OnAppcessoryProtocolDataReceived(420) > [0;40;31mmReceiveWeatherAck : 1523450432[0;m
04-11 14:40:34.300+0200 E/weather-consumer( 3366): SamsungAppcessoryProtocol.cpp: OnAppcessoryProtocolDataReceived(462) > [0;40;31mJust Receive AckData.[0;m
04-11 14:40:34.300+0200 E/weather-consumer( 3366): SamsungAppcessoryProtocol.cpp: OnAppcessoryProtocolDataReceived(465) > [0;40;31mWait until receive the data...[0;m
04-11 14:40:34.300+0200 E/weather-consumer( 3366): WeatherConsumerController.cpp: OnAppcessoryProtocolDataReceived(110) > [0;40;31mOnAppcessoryProtocolDataReceived[0;m
04-11 14:40:34.330+0200 I/HealthDataService(  852): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
04-11 14:40:34.330+0200 W/HealthDataService(  852): HealthShareDBHelper.cpp: SetShareInfo(218) > [1;40;33mCategory:shealth_inactive_info|BiUnMj8iNys4Oip+JTIzHCAHJBEGLTx8NjsJBDUcEFEhMBARLwM2MyQfLAgDNCwLLj4/CSAvPCQ0LxERDVZ2GCoUMwQ3Mgd5MzwJOi4GKC0FNiAYJgM4NC82GigKKAIDNCwIFQspDhgKAzcFDAQ0LyEeKQk4MStiOAEGWSMMElsKEz0wOQsrEg89NBkqDyg8KCx/SA==[0;m
04-11 14:40:34.360+0200 I/HealthData( 1422): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(371) > [1;35mServer said: OK {}[0;m
04-11 14:40:34.360+0200 W/SHealthCommon( 1422): CpuLock.cpp: CheckAndReset(178) > [1;40;33mRELEASE POWER LOCK CPU[0;m
04-11 14:40:34.370+0200 W/SHealthCommon( 1422): CpuLock.cpp: CheckAndReset(178) > [1;40;33mRELEASE POWER LOCK CPU[0;m
04-11 14:40:34.435+0200 I/SleepAsAndroidConsumer( 3374): peer agent connection is successful, pa :1134573416
04-11 14:40:34.525+0200 I/SleepAsAndroidConsumer( 3374): Sending data Version 1.0.9
04-11 14:40:34.650+0200 W/WVMS_SERVER( 3361): wvoice-memo-media-info.c: wvoice_memo_media_get_next_unsync(331) > [32m no unsync file[0m
04-11 14:40:34.650+0200 W/WVMS_SERVER( 3361): wvms-server-controller.c: wvms_server_controller_send_file_process(193) > [32m transfer file is not existed[0m
04-11 14:40:34.850+0200 W/CRASH_MANAGER( 3412): worker.c: worker_job(1205) > 1103374736c65152345043
