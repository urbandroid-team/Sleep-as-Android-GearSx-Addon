S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.2.7
Build-Number: R732XXU2FRC1
Build-Date: 2018.03.02 17:21:30

Crash Information
Process Name: sleepasandroidnativeservice
PID: 4610
Date: 2018-04-11 14:45:33+0200
Executable File Path: /opt/usr/apps/com.urbandroid.sleep/bin/sleepasandroidnativeservice
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x73726552

Register Information
r0   = 0x73726556, r1   = 0x00000001
r2   = 0x000000ec, r3   = 0x00000000
r4   = 0x430bd210, r5   = 0x430c4dd8
r6   = 0x0000bed9, r7   = 0xbec51eb0
r8   = 0x00005510, r9   = 0x00005510
r10  = 0x430acec8, fp   = 0x00000000
ip   = 0x40014adc, sp   = 0xbec51da0
lr   = 0x400021a7, pc   = 0x4043d56c
cpsr = 0x20000010

Memory Information
MemTotal:   491132 KB
MemFree:     10420 KB
Buffers:     24816 KB
Cached:     147704 KB
VmPeak:      60288 KB
VmSize:      60284 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        8828 KB
VmRSS:        8828 KB
VmData:      11256 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       19584 KB
VmPTE:          32 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 4610 TID = 4610
4610 4650 

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
40823000 4082b000 rw-p [heap]
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
4319a000 43aaf000 rw-p [stack:4650]
bec32000 bec53000 rw-p [stack]
End of Maps Information

Callstack Information (PID:4610)
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
nection_vconf_key_changed_cb(183) > host_connected changed [1] -> [1]
04-11 14:45:26.605+0200 W/MSG_CONSUMER( 1487): SapClient.cpp: _onWmsConnectionChanged(810) > [0;35mprevious_status: (1), status: (1)[0;m
04-11 14:45:26.605+0200 W/MSG_CONSUMER( 1487): SapClient.cpp: _onWmsConnectionChanged(813) > [0;35m_onWmsConnectionChanged() is ignored for same status change. prev:(1), cur:(1)[0;m
04-11 14:45:26.610+0200 W/AUL_AMD (  524): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 4630
04-11 14:45:26.615+0200 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 14
04-11 14:45:26.615+0200 W/MC_CONSUMER( 1100): wmc-service-consumer.c: wmc_service_consumer_send_data(598) > [33m {"msgId":"music-queue-req"}[0m
04-11 14:45:26.625+0200 W/AUL_AMD (  524): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 4584
04-11 14:45:26.625+0200 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 12
04-11 14:45:26.630+0200 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 14
04-11 14:45:26.640+0200 W/AUL_AMD (  524): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 4588
04-11 14:45:26.700+0200 E/WMS     (  521): wms_msg_broker.c: on_broker_buffer_send(307) > Data sending is success.
04-11 14:45:26.780+0200 E/WMS     (  521): wms_msg_broker.c: on_broker_buffer_send(307) > Data sending is success.
04-11 14:45:26.950+0200 W/MC_CONSUMER( 1100): wmc-service-consumer.c: wmc_service_consumer_send_data(598) > [33m {"msgId":"music-getattribute-req"}[0m
04-11 14:45:27.055+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-11 14:45:27.055+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-11 14:45:27.055+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-11 14:45:27.055+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-11 14:45:27.055+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-11 14:45:27.055+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-11 14:45:27.055+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.widget:music-control-service-message-port]
04-11 14:45:27.055+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-11 14:45:27.055+0200 W/WG-CONSUMER( 1751): [32m[F:SAPProxy.cpp     L: 1059][_WARN][Phone->Gear] Connection Confirmed. wResponseCode : [0], uwLocalAgentId : [34361] uwServiceHandle : [36320] PeerAgent(0x43345d30)[0m
04-11 14:45:27.060+0200 W/WG-CONSUMER( 1751): [34m[F:ConnectionInfo.c L: 1128][_HIGH][RX]connection established. AgentID(34361) ServiceHandle=36320 SM_STATE_REQUEST_SERVICE bUsingWFD=0[0m
04-11 14:45:27.060+0200 W/WG-CONSUMER( 1751): [34m[F:ConnectionInfo.c L: 1147][_HIGH][RX] ConnectionType is BT. Update ServiceHandle. (0->36320)[0m
04-11 14:45:27.060+0200 W/WG-CONSUMER( 1751): [34m[F:ConnectionInfo.c L: 1151][_HIGH][RX]Connection Established. ServiceID=36320[0m
04-11 14:45:27.060+0200 W/WG-CONSUMER( 1751): [34m[F:ConnectionInfo.c L:  603][_HIGH][RX]State changed: SM_STATE_REQUEST_SERVICE->SM_STATE_ESTABLISHED[0m
04-11 14:45:27.060+0200 W/WG-CONSUMER( 1751): [32m[F:ReceiverCtrl.cpp L:  529][_WARN][RX]Connection is established[0m
04-11 14:45:27.060+0200 W/WG-CONSUMER( 1751): [34m[F:AutoTransfer.cpp L:  114][_HIGH]AutoSync : Gear is not charging[0m
04-11 14:45:27.060+0200 W/WG-CONSUMER( 1751): [34m[F:consumer-app.cpp L:  378][_HIGH]CGalleryConsumer::ResetTimer[0m
04-11 14:45:27.060+0200 W/WG-CONSUMER( 1751): [34m[F:ConnectionInfo.c L:  620][_HIGH][RX]CConnection(0x43308370) Caller=Connection::Established(1162)[0m
04-11 14:45:27.060+0200 W/WG-CONSUMER( 1751): [34m[F:ConnectionInfo.c L:  621][_HIGH]  SM_STATE_ESTABLISHED LocalAgentID=34361 ServiceHandle=36320[0m
04-11 14:45:27.060+0200 W/WG-CONSUMER( 1751): [34m[F:ConnectionInfo.c L:  622][_HIGH]  FTSTATE_INIT PeerCount=1 bUsingWFD=0 RetryTimer=0 nPeerTimer=0[0m
04-11 14:45:27.060+0200 W/WG-CONSUMER( 1751): [34m[F:PeerList.cpp     L:  119][_HIGH]    CPeerAgent=0x43344758 PeerAgent(0x4334475c) bSet(1)[0m
04-11 14:45:27.065+0200 W/WG-CONSUMER( 1751): [34m[F:PeerList.cpp     L:  120][_HIGH]    DeviceID=2 PeerAgentID=10712 ServiceHandle=36320[0m
04-11 14:45:27.065+0200 W/WG-CONSUMER( 1751): [34m[F:PeerList.cpp     L:  122][_HIGH]    DeviceName=* MAC=* ALE=HostManager ASPID=* Version=3.0[0m
04-11 14:45:27.065+0200 W/WG-CONSUMER( 1751): [34m[F:PeerList.cpp     L:  123][_HIGH]    ConnectType(1) : BT[0m
04-11 14:45:27.075+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-11 14:45:27.075+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-11 14:45:27.075+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-11 14:45:27.075+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-11 14:45:27.075+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-11 14:45:27.075+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-11 14:45:27.075+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.widget:music-control-service-message-port]
04-11 14:45:27.075+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-11 14:45:27.075+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-11 14:45:27.075+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-11 14:45:27.100+0200 W/MC_CONSUMER( 1100): wmc-service-consumer.c: wmc_service_consumer_send_data(598) > [33m {"msgId":"capability-feature-ind","distinct-state":"true"}[0m
04-11 14:45:27.100+0200 W/LIVE_MUSIC_PLAYER(  990): dbox-mp-main.c: _widget_mp_instance_update(2237) > [36m[TID:990]   [MUSIC_PLAYER_EVENT]update_type = [32][0m
04-11 14:45:27.100+0200 W/LIVE_MUSIC_PLAYER(  990): dbox-mp-main.c: _widget_mp_main_update_control_button_disabled_state(182) > [33m[TID:990]   mode[1] disalbe state [0][0m
04-11 14:45:27.175+0200 E/WG-CONSUMER( 1751): [31m[F:ConnectionInfo.c L:   52][ERROR]vendor changed: db/wms/host_status/vendor:LGE[0m
04-11 14:45:27.175+0200 W/WG-CONSUMER( 1751): [32m[F:SAPProxy.cpp     L:  621][_WARN]_on_wms_connected_changed, value = 1, key = memory/wms/wmanager_connected[0m
04-11 14:45:27.175+0200 W/WG-CONSUMER( 1751): [34m[F:SAPProxy.cpp     L:  601][_HIGH]Device Connected. Cur type=BT|[0m
04-11 14:45:27.175+0200 W/WG-CONSUMER( 1751): [34m[F:SAPProxy.cpp     L:  633][_HIGH]WMS status changed. VConf memory/wms/wmanager_connected value=1 BT=1[0m
04-11 14:45:27.175+0200 W/WG-CONSUMER( 1751): [34m[F:SAPProxy.cpp     L:  637][_HIGH]WMS is connected. Try to connection. Connections=2[0m
04-11 14:45:27.175+0200 W/WG-CONSUMER( 1751): [34m[F:ConnectionInfo.c L:  190][_HIGH][TX]CConnection::Connect() State:SM_STATE_ESTABLISHED[0m
04-11 14:45:27.175+0200 W/WG-CONSUMER( 1751): [34m[F:SAPProxy.cpp     L:  147][_HIGH]CSAPProxy::Connect. Size=2 pConnection=0x4332bc00[0m
04-11 14:45:27.175+0200 W/WG-CONSUMER( 1751): [34m[F:SAPProxy.cpp     L:  150][_HIGH]  Connection : [TX] LocalAgentID:34360 ServiceHandle:16558[0m
04-11 14:45:27.175+0200 W/WG-CONSUMER( 1751): [34m[F:SAPProxy.cpp     L:  150][_HIGH]  Connection : [RX] LocalAgentID:34361 ServiceHandle:36320[0m
04-11 14:45:27.175+0200 E/WG-CONSUMER( 1751): [31m[F:SAPProxy.cpp     L:  161][ERROR]Duplication connection. not inseterd[0m
04-11 14:45:27.175+0200 E/WG-CONSUMER( 1751): [31m[F:SAPProxy.cpp     L:  165][ERROR]Previous pCurrent(0x43308370) is exist[0m
04-11 14:45:27.180+0200 W/WG-CONSUMER( 1751): [34m[F:SAPProxy.cpp     L:  601][_HIGH]Device Connected. Cur type=BT|[0m
04-11 14:45:27.180+0200 W/WG-CONSUMER( 1751): [34m[F:SAPProxy.cpp     L:  186][_HIGH]Device connected. WMS=1 BT=1 [0m
04-11 14:45:27.180+0200 W/WG-CONSUMER( 1751): [34m[F:ConnectionInfo.c L:  568][_HIGH][TX]advance. CurState=SM_STATE_ESTABLISHED(8)[0m
04-11 14:45:27.180+0200 W/WG-CONSUMER( 1751): [34m[F:ConnectionInfo.c L:  590][_HIGH]Already established.[0m
04-11 14:45:27.180+0200 W/WG-CONSUMER( 1751): [34m[F:ConnectionInfo.c L:  190][_HIGH][RX]CConnection::Connect() State:SM_STATE_ESTABLISHED[0m
04-11 14:45:27.180+0200 W/WG-CONSUMER( 1751): [34m[F:SAPProxy.cpp     L:  147][_HIGH]CSAPProxy::Connect. Size=2 pConnection=0x43308370[0m
04-11 14:45:27.180+0200 W/WG-CONSUMER( 1751): [34m[F:SAPProxy.cpp     L:  150][_HIGH]  Connection : [TX] LocalAgentID:34360 ServiceHandle:16558[0m
04-11 14:45:27.180+0200 W/WG-CONSUMER( 1751): [34m[F:SAPProxy.cpp     L:  150][_HIGH]  Connection : [RX] LocalAgentID:34361 ServiceHandle:36320[0m
04-11 14:45:27.180+0200 E/WG-CONSUMER( 1751): [31m[F:SAPProxy.cpp     L:  161][ERROR]Duplication connection. not inseterd[0m
04-11 14:45:27.180+0200 E/WG-CONSUMER( 1751): [31m[F:SAPProxy.cpp     L:  165][ERROR]Previous pCurrent(0x4332bc00) is exist[0m
04-11 14:45:27.180+0200 W/WG-CONSUMER( 1751): [34m[F:SAPProxy.cpp     L:  601][_HIGH]Device Connected. Cur type=BT|[0m
04-11 14:45:27.180+0200 W/WG-CONSUMER( 1751): [34m[F:SAPProxy.cpp     L:  186][_HIGH]Device connected. WMS=1 BT=1 [0m
04-11 14:45:27.180+0200 W/WG-CONSUMER( 1751): [34m[F:ConnectionInfo.c L:  568][_HIGH][RX]advance. CurState=SM_STATE_ESTABLISHED(8)[0m
04-11 14:45:27.180+0200 W/WG-CONSUMER( 1751): [34m[F:ConnectionInfo.c L:  590][_HIGH]Already established.[0m
04-11 14:45:27.220+0200 W/MC_CONSUMER( 1100): wmc-service-consumer.c: wmc_service_consumer_send_data(598) > [33m {"msgId":"music-mediachanged-req","value":"true"}[0m
04-11 14:45:27.320+0200 W/MC_CONSUMER( 1100): wmc-service-consumer.c: wmc_service_consumer_send_data(598) > [33m {"msgId":"music-queue-req"}[0m
04-11 14:45:27.400+0200 W/MC_CONSUMER( 1100): wmc-service-consumer.c: wmc_service_consumer_send_data(598) > [33m {"msgId":"music-getattribute-req"}[0m
04-11 14:45:27.485+0200 W/MC_CONSUMER( 1100): wmc-service-consumer.c: wmc_service_consumer_send_data(598) > [33m {"msgId":"capability-feature-ind","distinct-state":"true"}[0m
04-11 14:45:27.585+0200 W/MC_CONSUMER( 1100): wmc-service-consumer.c: _wms_connection_changed_callback(458) > [33m WMS Connected[3][0m
04-11 14:45:27.590+0200 W/MUSIC_CONTROL_SERVICE( 1100): music-control-consumer-control.c: _music_control_consumer_control_print_msg_type(105) > [33m[TID:1100]   msg [WMC_SERVICE_WIPC_MSG_ID_CONNECTION_CHANGED][0m
04-11 14:45:27.590+0200 W/MUSIC_CONTROL_SERVICE( 1100): music-control-consumer-control.c: music_control_consumer_msg_process(243) > [36m[TID:1100]   [MUSIC_PLAYER_EVENT]Device State [2] normal:0 dim:1 off:2[0m
04-11 14:45:27.590+0200 W/MUSIC_CONTROL_SERVICE( 1100): music-control-consumer-control.c: music_control_consumer_msg_process(343) > [33m[TID:1100]   connection state = 1[0m
04-11 14:45:27.590+0200 W/MUSIC_CONTROL_SERVICE( 1100): music-control-consumer-control.c: music_control_consumer_media_changed_ind_request(199) > [33m[TID:1100]   remote mode[1],resume[1][0m
04-11 14:45:27.590+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-11 14:45:27.590+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-11 14:45:27.590+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-11 14:45:27.590+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-11 14:45:27.590+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-11 14:45:27.590+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-11 14:45:27.590+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.widget:music-control-service-message-port]
04-11 14:45:27.590+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-11 14:45:27.595+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-11 14:45:27.595+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-11 14:45:27.595+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-11 14:45:27.595+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-11 14:45:27.595+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-11 14:45:27.595+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-11 14:45:27.595+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.widget:music-control-service-message-port]
04-11 14:45:27.595+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-11 14:45:27.595+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-11 14:45:27.595+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-11 14:45:27.605+0200 W/MC_CONSUMER( 1100): wmc-service-consumer.c: wmc_service_consumer_send_data(598) > [33m {"msgId":"capability-feature-ind","distinct-state":"true"}[0m
04-11 14:45:27.625+0200 W/LIVE_MUSIC_PLAYER(  990): dbox-mp-main.c: _widget_mp_instance_update(2237) > [36m[TID:990]   [MUSIC_PLAYER_EVENT]update_type = [32][0m
04-11 14:45:27.625+0200 W/LIVE_MUSIC_PLAYER(  990): dbox-mp-main.c: _widget_mp_main_update_control_button_disabled_state(182) > [33m[TID:990]   mode[1] disalbe state [0][0m
04-11 14:45:27.715+0200 W/MUSIC_PLAYER( 1100): mp-weconn.c: _wms_connection_vconf_changed_callback(93) > [33m[TID:1100]   [1][0m
04-11 14:45:27.720+0200 W/MC_CONSUMER( 1100): wmc-service-cotroller.c: _bt_connection_changed_cb(60) > [33m connected[1][0m
04-11 14:45:27.755+0200 W/AUL_AMD (  524): amd_status.c: __socket_monitor_cb(1277) > (4630) was created
04-11 14:45:27.760+0200 E/CONTACTS_CONSUMER( 4630): ct-sap-svc-main.c: __service_check_vendor_init(138) > [0;31m* Critical * ios_connected:0[0;m
04-11 14:45:27.805+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: OnConnectionRequest(411) > _MessagePortIpcServer::OnConnectionRequest
04-11 14:45:27.820+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnIpcClientConnected(172) > MessagePort Ipc connected
04-11 14:45:27.820+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: OnConnectionRequest(411) > _MessagePortIpcServer::OnConnectionRequest
04-11 14:45:27.840+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-11 14:45:27.840+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-11 14:45:27.840+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-11 14:45:27.840+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnRegisterMessagePort(91) > _MessagePortStub::OnRegisterMessagePort.
04-11 14:45:27.840+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: RegisterMessagePort(83) > _MessagePortService::RegisterMessagePort
04-11 14:45:27.840+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-11 14:45:27.840+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: RegisterMessagePort(95) > Register a message port: [com.samsung.w-contacts2.consumer:w-contacts2-consumer], client = 4630
04-11 14:45:27.840+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-11 14:45:27.975+0200 E/PKGMGR_SERVER( 4626): pkgmgr-server.c: exit_server(1620) > exit_server Start [backend_status=1, queue_status=1] 
04-11 14:45:27.975+0200 E/PKGMGR_SERVER( 4626): pkgmgr-server.c: main(2296) > package manager server terminated.
04-11 14:45:28.150+0200 E/CONTACTS_CONSUMER( 4630): ct-sap-svc-client.c: __ct_sap_svc_client_find_peer_agent(1180) > [0;31m* Critical * connectivity_type 0[0;m
04-11 14:45:28.245+0200 E/CONTACTS_CONSUMER( 4630): ct-sap-svc-client.c: ct_sap_svc_client_mem_info(3594) > [0;31m* Critical * Total allocated space (uordblks):135448
04-11 14:45:28.245+0200 E/CONTACTS_CONSUMER( 4630): [0;m
04-11 14:45:28.245+0200 W/CAPI_APPFW_APP_CONTROL( 4630): app_control.c: app_control_error(136) > [app_control_get_extra_data_array] KEY_NOT_FOUND(0xffffff82)
04-11 14:45:28.250+0200 W/CAPI_APPFW_APP_CONTROL( 4630): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-11 14:45:28.250+0200 W/CAPI_APPFW_APP_CONTROL( 4630): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-11 14:45:28.340+0200 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 14
04-11 14:45:28.350+0200 W/AUL_AMD (  524): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 4584
04-11 14:45:28.355+0200 W/WVMS_SERVER( 4584): wvms-server.c: main(107) > [32m service start[0m
04-11 14:45:28.375+0200 W/AUL_AMD (  524): amd_status.c: __socket_monitor_cb(1277) > (4584) was created
04-11 14:45:28.385+0200 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 12
04-11 14:45:28.395+0200 W/AUL_AMD (  524): amd_status.c: __socket_monitor_cb(1277) > (4588) was created
04-11 14:45:28.430+0200 W/CONTACTS_CONSUMER( 4630): ct-sap-svc-client.c: __on_create(2490) > [0;35mis_connected_by_scs 0[0;m
04-11 14:45:28.475+0200 W/WVMS_SERVER( 4584): wvms-server.c: _service_app_create(33) > [32m [0m
04-11 14:45:28.530+0200 W/WVMS_SERVER( 4584): wvms-server.c: _service_app_control(54) > [32m [0m
04-11 14:45:28.620+0200 E/CONTACTS_CONSUMER( 4630): ct-sap-svc-client.c: ct_sap_svc_client_mem_info(3594) > [0;31m* Critical * Total allocated space (uordblks):135960
04-11 14:45:28.620+0200 E/CONTACTS_CONSUMER( 4630): [0;m
04-11 14:45:28.650+0200 I/WSM     (  519): WSM_I [d1]
04-11 14:45:28.755+0200 E/CONTACTS_CONSUMER( 4630): ct-sap-svc-client.c: __on_receive(1779) > [0;31m* Critical * crypt_key for encrypt version !!![0;m
04-11 14:45:28.765+0200 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 14
04-11 14:45:28.775+0200 W/AUL_AMD (  524): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 4588
04-11 14:45:28.825+0200 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 12
04-11 14:45:29.045+0200 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 14
04-11 14:45:29.055+0200 W/AUL_AMD (  524): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 4603
04-11 14:45:29.070+0200 W/WVMS_SERVER( 4584): wvms-server.c: _service_app_control(64) >  sap is connected
04-11 14:45:29.075+0200 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 12
04-11 14:45:29.145+0200 I/CAPI_CONTENT_MEDIA_CONTENT( 4584): media_content.c: media_content_connect(870) > [32m[4584]ref count : 0
04-11 14:45:29.155+0200 I/AUL_PAD ( 4571): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
04-11 14:45:29.160+0200 I/CAPI_CONTENT_MEDIA_CONTENT( 4584): media_content.c: media_content_connect(902) > [32m[4584]ref count changed to: 1
04-11 14:45:29.175+0200 E/weather-common( 4588): WeatherDBController.cpp: Init(53) > [0;40;31m[Init(): 53] (FileHelper::GetInstance()->IsExists(GetWeatherDBFilePath()) == true) [return][0;m
04-11 14:45:29.180+0200 E/weather-common( 4588): SettingDBController.cpp: Init(84) > [0;40;31m[Init(): 84] (FileHelper::GetInstance()->IsExists(GetSettingDBFilePath()) == true) [return][0;m
04-11 14:45:29.180+0200 E/weather-common( 4588): ShareTargetDBController.cpp: Init(43) > [0;40;31m[Init(): 43] (FileHelper::GetInstance()->IsExists(GetShareTargetDataDBFilePath()) == true) [return][0;m
04-11 14:45:29.365+0200 E/CONTACTS_CONSUMER( 4630): ct-sap-svc-client.c: ct_sap_svc_client_mem_info(3594) > [0;31m* Critical * Total allocated space (uordblks):139280
04-11 14:45:29.365+0200 E/CONTACTS_CONSUMER( 4630): [0;m
04-11 14:45:29.395+0200 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 14
04-11 14:45:29.400+0200 W/AUL_AMD (  524): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 4610
04-11 14:45:29.470+0200 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 12
04-11 14:45:29.470+0200 E/CONTACTS_CONSUMER( 4630): ct-sap-svc-parser-contacts.c: ct_sap_svc_parser_contacts_get_feature_info(3669) > [0;31m* Critical * ##FEATURE##:  supportLog(0)[0;m
04-11 14:45:29.470+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-11 14:45:29.470+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-11 14:45:29.470+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-11 14:45:29.470+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-11 14:45:29.470+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-11 14:45:29.470+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-11 14:45:29.470+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.message.consumer:com.samsung.message.consumer]
04-11 14:45:29.470+0200 E/MESSAGE_PORT(  484): MessagePortService.cpp: SendMessage(347) > _MessagePortService::SendMessage: Failed :MESSAGEPORT_ERROR_MESSAGEPORT_NOT_FOUND
04-11 14:45:29.470+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-11 14:45:29.480+0200 E/MESSAGE_PORT( 4630): MessagePortProxy.cpp: SendMessageInternal(533) > The remote message port is not found.
04-11 14:45:29.480+0200 E/CONTACTS_CONSUMER( 4630): ct-sap-svc-client.c: ct_sap_svc_client_mem_info(3594) > [0;31m* Critical * Total allocated space (uordblks):145824
04-11 14:45:29.480+0200 E/CONTACTS_CONSUMER( 4630): [0;m
04-11 14:45:29.760+0200 W/CONTACTS_CONSUMER( 4630): ct-sap-svc-client.c: __ct_sap_svc_client_set_logs_sync_status(1220) > [0;35mlogs_sync_status on reconnection: (3) -> (1)[0;m
04-11 14:45:29.760+0200 E/CONTACTS_CONSUMER( 4630): ct-sap-svc-client.c: ct_sap_svc_client_mem_info(3594) > [0;31m* Critical * Total allocated space (uordblks):145824
04-11 14:45:29.760+0200 E/CONTACTS_CONSUMER( 4630): [0;m
04-11 14:45:29.805+0200 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 14
04-11 14:45:29.820+0200 W/AUL_AMD (  524): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 4630
04-11 14:45:29.860+0200 W/CONTACTS_CONSUMER( 4630): ct-sap-svc-composer-logs.c: __mark_as_read(666) > [0;35m0 logs has been marked as read[0;m
04-11 14:45:29.865+0200 W/CONTACTS_CONSUMER( 4630): ct-sap-svc-composer-logs.c: ct_sap_svc_composer_logs_reset_notification(566) > [0;35mmissed: 0 / total_missed: 47[0;m
04-11 14:45:29.900+0200 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 12
04-11 14:45:29.910+0200 W/WVMS_SERVER( 4584): wvms-server-consumer.c: wvoice_memo_register_service_agent_confirm(242) >  Register service agent success
04-11 14:45:30.055+0200 W/WVMS_SERVER( 4584): wvms-server-consumer.c: __wvoice_memo_find_peer_agent(229) > [32m Call find peer success[0m
04-11 14:45:30.080+0200 E/weather-common( 4588): CPType.cpp: Renew(90) > [0;40;31mCPType is renewed : 5[0;m
04-11 14:45:30.080+0200 W/WVMS_SERVER( 4584): wvms-server-consumer.c: wvoice_memo_register_consumer(471) >  init complete
04-11 14:45:30.085+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: OnConnectionRequest(411) > _MessagePortIpcServer::OnConnectionRequest
04-11 14:45:30.100+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnIpcClientConnected(172) > MessagePort Ipc connected
04-11 14:45:30.100+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: OnConnectionRequest(411) > _MessagePortIpcServer::OnConnectionRequest
04-11 14:45:30.105+0200 E/weather-common( 4588): CPType.cpp: Renew(90) > [0;40;31mCPType is renewed : 5[0;m
04-11 14:45:30.105+0200 E/weather-common( 4588): DataManager.cpp: LoadData(326) > [0;40;31mnewCpTypeStr : TWC[0;m
04-11 14:45:30.165+0200 E/weather-common( 4588): DataManager.cpp: LoadData(329) > [0;40;31mweather data loaded[0;m
04-11 14:45:30.170+0200 E/weather-common( 4588): DemoBinaryManager.cpp: ManipulateDemoData(48) > [0;40;31mDemoBinaryManager::ManipulateDemoData[0;m
04-11 14:45:30.200+0200 E/weather-common( 4588): VconfUtil.cpp: RemoveVconfEventListener(224) > [0;40;31mFailed vconf_ignore_key_changed [key : db/retailmode/enabled, ret : -1][0;m
04-11 14:45:30.200+0200 E/wnoti-service( 1050): wnoti-server-mgr-stub.c: __wnoti_remove_notification_cards_stub(527) > [ERROR] Read Card, No application panel app_id = com.samsung.w-logs2, panel_id = missed_call
04-11 14:45:30.200+0200 E/wnoti-service( 1050): wnoti-db-utility.c: unlock_pm(616) > >> unlock_pm status : 0
04-11 14:45:30.205+0200 E/weather-common( 4588): RetailManager.cpp: Monitoring(84) > [0;40;31mRetailManager::Monitoring[0;m
04-11 14:45:30.240+0200 W/CONTACTS_CONSUMER( 4630): ct-sap-svc-composer-logs.c: ct_sap_svc_composer_logs_clear_notification_by_host(704) > [0;35m0 logs updated[0;m
04-11 14:45:30.245+0200 E/weather-common( 4588): VconfUtil.cpp: GetVconfIntValue(164) > [0;40;31mFailed vconf_get_int [ret : -1, key : db/retailmode/enabled, value : -1][0;m
04-11 14:45:30.265+0200 E/weather-common( 4588): VconfUtil.cpp: AddVconfEventListener(214) > [0;40;31mFailed vconf_notify_key_changed [key : db/retailmode/enabled, ret : -1][0;m
04-11 14:45:30.265+0200 E/weather-common( 4588): VconfUtil.cpp: AddVconfEventListener(214) > [0;40;31mFailed vconf_notify_key_changed [key : db/retailmode/res_path, ret : -1][0;m
04-11 14:45:30.290+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-11 14:45:30.290+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-11 14:45:30.290+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-11 14:45:30.290+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnRegisterMessagePort(91) > _MessagePortStub::OnRegisterMessagePort.
04-11 14:45:30.290+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: RegisterMessagePort(83) > _MessagePortService::RegisterMessagePort
04-11 14:45:30.290+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-11 14:45:30.290+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: RegisterMessagePort(95) > Register a message port: [com.samsung.w-voicerecorder.consumer:com.samsung.voice_memo_c1_server], client = 4584
04-11 14:45:30.290+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-11 14:45:30.295+0200 E/CONTACTS_CONSUMER( 4630): ct-sap-svc-client.c: ct_sap_svc_client_mem_info(3594) > [0;31m* Critical * Total allocated space (uordblks):147496
04-11 14:45:30.295+0200 E/CONTACTS_CONSUMER( 4630): [0;m
04-11 14:45:30.320+0200 E/weather-common( 4588): SystemInfoHelper.cpp: IsShowcaseBinary(77) > [0;40;31misShowcase:0[0;m
04-11 14:45:30.335+0200 W/WVMS_SERVER( 4584): wvms-server-ipc.c: wvms_server_ipc_init(53) >  port id : [1]
04-11 14:45:30.360+0200 I/SleepAsAndroidConsumer( 4610): starting service app
04-11 14:45:30.385+0200 E/weather-common( 4588): DemoBinaryManager.cpp: ManipulateDemoData(54) > [0;40;31m[ManipulateDemoData(): 54] (SystemInfoHelper::GetInstance()->IsShowcaseBinary() == false) [return][0;m
04-11 14:45:30.405+0200 W/WVMS_SERVER( 4584): wvms-server-consumer.c: wvoice_memo_on_peer_agent(258) >  wStatusCode : [0]
04-11 14:45:30.410+0200 E/CAPI_APPFW_APPLICATION( 4610): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-11 14:45:30.410+0200 W/WVMS_SERVER( 4584): wvms-server-consumer.c: wvoice_memo_on_peer_agent(274) >  call create service connection
04-11 14:45:30.410+0200 W/CONTACTS_CONSUMER( 4630): ct-sap-svc-composer-logs.c: __log_get_from_db(274) > [0;35mget 500 records(err:0)[0;m
04-11 14:45:30.455+0200 E/CAPI_APPFW_APPLICATION( 4610): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-11 14:45:30.460+0200 I/efl-extension( 4580): efl_extension.c: eext_mod_init(40) > Init
04-11 14:45:30.465+0200 D/SleepAsAndroidConsumer( 4610): HRM is  supported
04-11 14:45:30.470+0200 W/AUL_AMD (  524): amd_status.c: __socket_monitor_cb(1277) > (4610) was created
04-11 14:45:30.480+0200 W/CONTACTS_CONSUMER( 4630): ct-sap-svc-client.c: __ct_sap_svc_client_sync_deleted_logs(1248) > [0;35mnothing to upload[0;m
04-11 14:45:30.480+0200 W/CONTACTS_CONSUMER( 4630): ct-sap-svc-client.c: __ct_sap_svc_client_set_logs_sync_status(1220) > [0;35mlogs_sync_status on reconnection: (1) -> (3)[0;m
04-11 14:45:30.480+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 4630): preference.c: _preference_check_retry_err(507) > key(calllog-markasread-pending), check retry err: -21/(2/No such file or directory).
04-11 14:45:30.480+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 4630): preference.c: _preference_get_key(1101) > _preference_get_key(calllog-markasread-pending) step(-17825744) failed(2 / No such file or directory)
04-11 14:45:30.480+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 4630): preference.c: preference_get_boolean(1173) > preference_get_boolean(4630) : calllog-markasread-pending error
04-11 14:45:30.480+0200 W/CONTACTS_CONSUMER( 4630): ct-sap-svc-client.c: __ct_sap_svc_client_sync_noti_clear_on_host(325) > [0;35msynced already.[0;m
04-11 14:45:30.485+0200 E/CONTACTS_CONSUMER( 4630): ct-sap-svc-client.c: ct_sap_svc_client_mem_info(3594) > [0;31m* Critical * Total allocated space (uordblks):201536
04-11 14:45:30.485+0200 E/CONTACTS_CONSUMER( 4630): [0;m
04-11 14:45:30.520+0200 W/AUL_AMD (  524): amd_status.c: __socket_monitor_cb(1277) > (4580) was created
04-11 14:45:30.590+0200 W/WVMS_SERVER( 4584): wvms-server-consumer.c: wvoice_memo_on_service_connection_confirm(280) >  wResponseCode : [0]!!!
04-11 14:45:30.595+0200 W/WVMS_SERVER( 4584): wvms-server-consumer.c: wvoice_memo_on_service_connection_confirm(294) > [32m service connection success[0m
04-11 14:45:30.695+0200 W/WVMS_SERVER( 4584): wvms-server-consumer.c: wvms_server_consumer_send_msg(560) >  send data success
04-11 14:45:30.815+0200 I/efl-extension( 4572): efl_extension.c: eext_mod_init(40) > Init
04-11 14:45:30.885+0200 E/weather-common( 4588): CPType.cpp: Renew(90) > [0;40;31mCPType is renewed : 5[0;m
04-11 14:45:30.885+0200 E/weather-common( 4588): DataManager.cpp: LoadData(326) > [0;40;31mnewCpTypeStr : TWC[0;m
04-11 14:45:30.900+0200 E/weather-common( 4588): DataManager.cpp: LoadData(329) > [0;40;31mweather data loaded[0;m
04-11 14:45:30.935+0200 E/CAPI_APPFW_APP_CONTROL( 4588): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : failed to retrieve the appid of the caller
04-11 14:45:30.935+0200 E/weather-consumer( 4588): ConsumerMain.cpp: GetAppIDFromAppControl(215) > [0;40;31mAppControl ID : (null)[0;m
04-11 14:45:30.935+0200 E/weather-consumer( 4588): ConsumerMain.cpp: GetAppIDFromAppControl(218) > [0;40;31mFAILED: service_get_caller(APPID) [-22][0;m
04-11 14:45:30.935+0200 W/CAPI_APPFW_APP_CONTROL( 4588): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-11 14:45:30.940+0200 E/weather-consumer( 4588): ConsumerMain.cpp: GetMessageFromAppControl(241) > [0;40;31mAppControl msg : (null)[0;m
04-11 14:45:30.940+0200 E/weather-consumer( 4588): ConsumerMain.cpp: GetMessageFromAppControl(244) > [0;40;31mFAILED: app_control_get_extra_data(MESSAGE) [-126][0;m
04-11 14:45:30.940+0200 E/weather-consumer( 4588): ConsumerMain.cpp: GetMessageTypeByParsing(300) > [0;40;31mNot found message[0;m
04-11 14:45:30.940+0200 E/weather-consumer( 4588): ConsumerMain.cpp: SetSelfKillTimer(122) > [0;40;31mAgentMain::SetSelfKillTimer start[0;m
04-11 14:45:30.945+0200 E/weather-consumer( 4588): WeatherConsumerController.cpp: Start(73) > [0;40;31mhostDeviceVendor : LGE[0;m
04-11 14:45:30.955+0200 E/weather-consumer( 4588): AppcessoryProtocol.cpp: SetSendMessageType(60) > [0;40;31mSetSendMessageType : 0[0;m
04-11 14:45:30.960+0200 E/weather-consumer( 4588): AppcessoryProtocol.cpp: MakeMessageForAndroid(88) > [0;40;31mMakeMessageForAndroid[0;m
04-11 14:45:30.960+0200 E/weather-consumer( 4588): AppcessoryProtocol.cpp: CreateCpListText(160) > [0;40;31mCP list supported : "Accuweather","TWC","WeatherNews","cmaweather","Kweather","WCN"[0;m
04-11 14:45:30.965+0200 E/weather-consumer( 4588): AppcessoryProtocol.cpp: MakeMessageForAndroid(140) > [0;40;31mmSendMessage : {"WEATHER_REQUEST":{"FETCH_REQ":1,"SHOW_SETTING_ON_DEVICE":0,"UPDATED_BY_GEAR":0,"CP_LIST":["Accuweather","TWC","WeatherNews","cmaweather","Kweather","WCN"],"ADD_CURRENT_CITY":0},"REVISION":1,"WEATHER_ACK_SEQ": "1523450730"}[0;m
04-11 14:45:30.965+0200 E/weather-consumer( 4588): SAP.cpp: InitializeSAPConnection(142) > [0;40;31mSAP::InitializeSAPConnection[0;m
04-11 14:45:31.090+0200 W/CAPI_APPFW_APP_CONTROL( 4580): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-11 14:45:31.175+0200 W/CAPI_APPFW_APP_CONTROL( 4580): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-11 14:45:31.175+0200 E/CAPI_APPFW_APP_CONTROL( 4580): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : failed to retrieve the appid of the caller
04-11 14:45:31.290+0200 E/weather-consumer( 4588): SAP.cpp: CreateService(126) > [0;40;31mSAP::CreateService[0;m
04-11 14:45:31.360+0200 E/SleepAsAndroidConsumer( 4610): SUCCESSFULLY create sap agent
04-11 14:45:31.455+0200 I/UXT     ( 4572): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
04-11 14:45:31.480+0200 I/WSM     (  519): WSM_I [d1]
04-11 14:45:31.525+0200 W/WVMS_SERVER( 4584): wvoice-memo-media-info.c: wvoice_memo_media_get_next_unsync(331) > [32m no unsync file[0m
04-11 14:45:31.525+0200 W/WVMS_SERVER( 4584): wvms-server-controller.c: wvms_server_controller_send_file_process(193) > [32m transfer file is not existed[0m
04-11 14:45:31.570+0200 E/CONTACTS_CONSUMER( 4630): ct-sap-svc-parser-contacts.c: ct_sap_svc_parser_contacts_get_buddylist(3694) > [0;31m* Critical * json_object_has_member(rawContacts) is failed[0;m
04-11 14:45:31.575+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 4580): preference.c: _preference_check_retry_err(507) > key(lockTimezone), check retry err: -21/(2/No such file or directory).
04-11 14:45:31.575+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 4580): preference.c: _preference_get_key(1101) > _preference_get_key(lockTimezone) step(-17825744) failed(2 / No such file or directory)
04-11 14:45:31.575+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 4580): preference.c: preference_get_string(1258) > preference_get_string(4580) : lockTimezone error
04-11 14:45:31.625+0200 E/CONTACTS_CONSUMER( 4630): ct-sap-svc-parser-contacts.c: __ct_sap_svc_parser_free_foreach_data(2056) > [0;31m* Critical * foreach_data is NULL[0;m
04-11 14:45:31.625+0200 E/CONTACTS_CONSUMER( 4630): ct-sap-svc-parser-contacts.c: __ct_sap_svc_parser_free_contacts_record_hash_table_for_buddy(2208) > [0;31m* Critical * (NULL == __hash_table_contacts_for_buddy)[0;m
04-11 14:45:31.635+0200 E/CONTACTS_CONSUMER( 4630): ct-sap-svc-client.c: ct_sap_svc_client_mem_info(3594) > [0;31m* Critical * Total allocated space (uordblks):199080
04-11 14:45:31.635+0200 E/CONTACTS_CONSUMER( 4630): [0;m
04-11 14:45:31.635+0200 I/AUL_PAD ( 4572): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
04-11 14:45:31.650+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-11 14:45:31.650+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-11 14:45:31.650+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-11 14:45:31.650+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-11 14:45:31.650+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-11 14:45:31.650+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-11 14:45:31.650+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-buddy:w-buddy]
04-11 14:45:31.650+0200 E/MESSAGE_PORT(  484): MessagePortService.cpp: SendMessage(347) > _MessagePortService::SendMessage: Failed :MESSAGEPORT_ERROR_MESSAGEPORT_NOT_FOUND
04-11 14:45:31.650+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-11 14:45:31.650+0200 E/MESSAGE_PORT( 4630): MessagePortProxy.cpp: SendMessageInternal(533) > The remote message port is not found.
04-11 14:45:31.660+0200 E/CALENDAR-CONSUMER( 4580): CalendarSapAgent.cpp: __isLDUBinary(1130) > [0;31m* Critical * vconf_get_int is faled.[0;m
04-11 14:45:31.815+0200 E/MALI    ( 4572): egl_platform_x11.c: __egl_platform_initialize(127) > DDK VERSION - MALI400MP-r4p0-00rel0 / BUILD DATE - 8/Aug/2016 
04-11 14:45:31.815+0200 E/MALI    ( 4572): egl_platform_x11.c: __egl_platform_initialize(141) > model name : SM-R720
04-11 14:45:31.815+0200 E/MALI    ( 4572): [gpu-ddk] devel/graphics_drv/r4p0
04-11 14:45:31.815+0200 E/MALI    ( 4572): 97ae9c0655a7d384872f26978f48bd958e392c4b Fix image distortion on 3rd party applicaton "AnalogWatch"
04-11 14:45:31.815+0200 E/MALI    ( 4572): [coregl] devel/graphics_engine/master
04-11 14:45:31.815+0200 E/MALI    ( 4572): c936d4e43f19940f81bedb56d9006162dc3ae4e4 Add manifest file for coregl
04-11 14:45:31.815+0200 E/MALI    ( 4572): K
04-11 14:45:31.825+0200 I/efl-extension( 4576): efl_extension.c: eext_mod_init(40) > Init
04-11 14:45:31.890+0200 W/SSPAY_UI_SVC( 4576): sspay_ui_svc_main.c: main(292) > [36mmain start[0m
04-11 14:45:31.925+0200 E/weather-consumer( 4588): WeatherConsumerController.cpp: OnAppcessoryProtocolConnected(134) > [0;40;31mOnAppcessoryProtocolConnected[0;m
04-11 14:45:31.940+0200 W/AUL_AMD (  524): amd_status.c: __socket_monitor_cb(1277) > (4576) was created
04-11 14:45:31.940+0200 W/SSPAY_UI_SVC( 4576): sspay_ui_svc_main.c: _service_create(93) > [36m_service_create start[0m
04-11 14:45:31.945+0200 W/SSPAY_UI_SVC( 4576): sspay_ui_svc_utils.c: sspay_ui_svc_util_get_CountryISO_with_CSC(2281) > [36mCountryISO [DE][0m
04-11 14:45:31.970+0200 E/SSPAY_UI_SVC( 4576): sspay_ui_svc_app_management.c: sspay_ui_svc_am_is_retailmode_enabled(92) > [31m(ret != VCONF_OK) [0m
04-11 14:45:31.975+0200 E/SSPAY_UI_SVC( 4576): sspay_ui_svc_main.c: _service_create(100) > [31mNOT ALLOWED Country!!!!!!!!!!!!!!!!![0m
04-11 14:45:31.975+0200 W/SSPAY_UI_SVC( 4576): sspay_ui_svc.c: sspay_ui_svc_terminate(1712) > [36mterminate sspay-ui-svc with cpu lock during 5 sec[0m
04-11 14:45:32.070+0200 I/SleepAsAndroidConsumer( 4610): connectivity type(1): bt
04-11 14:45:32.155+0200 I/efl-extension( 4643): efl_extension.c: eext_mod_init(40) > Init
04-11 14:45:32.270+0200 I/UXT     ( 4643): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
04-11 14:45:32.275+0200 I/CAPI_APPFW_APPLICATION( 4576): service_app_main.c: service_app_exit(441) > service_app_exit
04-11 14:45:32.275+0200 E/CAPI_APPFW_APPLICATION( 4576): service_app_error.c: service_app_error(63) > [_service_app_create] INVALID_CONTEXT(0xfef00001) : service_app_create_cb() returns false
04-11 14:45:32.275+0200 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 22
04-11 14:45:32.275+0200 W/AUL_AMD (  524): amd_request.c: __request_handler(999) > app status : 4
04-11 14:45:32.280+0200 W/SSPAY_UI_SVC( 4576): sspay_ui_svc_main.c: _service_terminate(129) > [36m_service_terminate start[0m
04-11 14:45:32.280+0200 W/SSPAY_UI_SVC( 4576): sspay_ui_svc_main.c: _service_terminate(135) > [36m_service_terminate end[0m
04-11 14:45:32.395+0200 I/efl-extension( 4576): efl_extension.c: eext_mod_shutdown(46) > Shutdown
04-11 14:45:32.480+0200 I/SleepAsAndroidConsumer( 4610): agent is initialized
04-11 14:45:32.480+0200 D/SleepAsAndroidConsumer( 4610): find peer called
04-11 14:45:32.480+0200 I/SleepAsAndroidConsumer( 4610): agent initialized callback is over
04-11 14:45:32.480+0200 D/SleepAsAndroidConsumer( 4610): SAP >>> getRegisteredServiceAgent() >>> 0
04-11 14:45:32.500+0200 E/CAPI_APPFW_APP_CONTROL( 4580): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : failed to retrieve the appid of the caller
04-11 14:45:32.500+0200 W/CAPI_APPFW_APP_CONTROL( 4580): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-11 14:45:32.500+0200 W/CAPI_APPFW_APP_CONTROL( 4580): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-11 14:45:32.500+0200 E/CAPI_APPFW_APP_CONTROL( 4580): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : failed to retrieve the appid of the caller
04-11 14:45:32.575+0200 W/AUL     ( 4656): daemon-manager-release-agent.c: main(12) > release agent : [2:/com.samsung.samsung-pay-app-service]
04-11 14:45:32.575+0200 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 23
04-11 14:45:32.575+0200 W/AUL_AMD (  524): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-11 14:45:32.575+0200 W/AUL_AMD (  524): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 4576
04-11 14:45:32.575+0200 W/AUL_AMD (  524): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-11 14:45:32.595+0200 E/RESOURCED(  608): procfs.c: proc_get_oom_score_adj(178) > fopen /proc/4576/oom_score_adj failed
04-11 14:45:32.595+0200 E/RESOURCED(  608): proc-main.c: resourced_proc_status_change(1501) > Empty pid or process not exists. 4576
04-11 14:45:32.595+0200 I/AUL_AMD (  524): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 4576
04-11 14:45:32.600+0200 W/AUL     (  524): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(4576)
04-11 14:45:32.640+0200 I/AUL_PAD ( 4643): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
04-11 14:45:32.710+0200 E/MALI    ( 4643): egl_platform_x11.c: __egl_platform_initialize(127) > DDK VERSION - MALI400MP-r4p0-00rel0 / BUILD DATE - 8/Aug/2016 
04-11 14:45:32.710+0200 E/MALI    ( 4643): egl_platform_x11.c: __egl_platform_initialize(141) > model name : SM-R720
04-11 14:45:32.710+0200 E/MALI    ( 4643): [gpu-ddk] devel/graphics_drv/r4p0
04-11 14:45:32.710+0200 E/MALI    ( 4643): 97ae9c0655a7d384872f26978f48bd958e392c4b Fix image distortion on 3rd party applicaton "AnalogWatch"
04-11 14:45:32.710+0200 E/MALI    ( 4643): [coregl] devel/graphics_engine/master
04-11 14:45:32.710+0200 E/MALI    ( 4643): c936d4e43f19940f81bedb56d9006162dc3ae4e4 Add manifest file for coregl
04-11 14:45:32.735+0200 D/SleepAsAndroidConsumer( 4610): find peer call succeeded
04-11 14:45:32.735+0200 D/SleepAsAndroidConsumer( 4610): find peer call is over
04-11 14:45:32.735+0200 I/SleepAsAndroidConsumer( 4610): Find Peer Success!!
04-11 14:45:32.735+0200 D/SleepAsAndroidConsumer( 4610): request_service_connection call over
04-11 14:45:32.740+0200 D/SleepAsAndroidConsumer( 4610): req service conn call succeeded
04-11 14:45:32.925+0200 E/weather-consumer( 4588): SamsungAppcessoryProtocol.cpp: FetchRequestTimeoutCb(74) > [0;40;31mwe wait a second but send message type still remained as MESSAGE_FET_REQUEST. so we need fetch request[0;m
04-11 14:45:32.990+0200 E/AUL_PAD ( 1393): launchpad.c: main(892) > Refused candidate process connection
04-11 14:45:32.990+0200 E/AUL     ( 4643): process_pool.c: __connect_to_launchpad(148) > send error
04-11 14:45:33.005+0200 I/efl-extension( 4643): efl_extension.c: eext_mod_shutdown(46) > Shutdown
04-11 14:45:33.035+0200 I/MALI    ( 4643): egl_platform_x11.c: __egl_platform_terminate(324) > [EGL-X11] ################################################
04-11 14:45:33.035+0200 I/SleepAsAndroidConsumer( 4610): peer agent connection is successful, pa :1124879832
04-11 14:45:33.040+0200 I/MALI    ( 4643): egl_platform_x11.c: __egl_platform_terminate(325) > [EGL-X11] PID=4643   close drm_fd=23 
04-11 14:45:33.040+0200 I/MALI    ( 4643): egl_platform_x11.c: __egl_platform_terminate(326) > [EGL-X11] ################################################
04-11 14:45:33.070+0200 I/SleepAsAndroidConsumer( 4610): Sending data Version 1.0.9
04-11 14:45:33.075+0200 E/CAPI_APPFW_APPLICATION_ALARM( 4580): alarm.c: convert_error_code_to_alarm(77) > [alarm_cancel] INVALID_PARAMETER(0xffffffea)
04-11 14:45:33.150+0200 W/AUL_PAD ( 1393): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 4643 pgid = 4643
04-11 14:45:33.150+0200 W/AUL_PAD ( 1393): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 1 ssi_status = 255
04-11 14:45:33.225+0200 W/AUL_PAD ( 1393): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
04-11 14:45:33.250+0200 E/weather-consumer( 4588): SAPNotificationCallback.cpp: OnDataIndication(65) > [0;40;31mOnDataIndication called. payloadLength(30)[0;m
04-11 14:45:33.250+0200 E/weather-consumer( 4588): AppcessoryProtocol.cpp: SetSendMessageType(60) > [0;40;31mSetSendMessageType : 9999[0;m
04-11 14:45:33.255+0200 E/weather-consumer( 4588): AppcessoryProtocol.cpp: SetSendMessageType(79) > [0;40;31m[Error] Wrong MessageType : 9999[0;m
04-11 14:45:33.255+0200 E/weather-common( 4588): JsonUtil.cpp: GetObjectFromNode(95) > [0;40;31m[GetObjectFromNode(): 95] (node == NULL) [return][0;m
04-11 14:45:33.255+0200 E/weather-common( 4588): SAPMessageParser.cpp: ParseSettingInfo(825) > [0;40;31msettingNode is NULL[0;m
04-11 14:45:33.255+0200 E/weather-common( 4588): JsonUtil.cpp: GetArrayFromNode(103) > [0;40;31m[GetArrayFromNode(): 103] (node == NULL) [return][0;m
04-11 14:45:33.255+0200 I/AUL_AMD (  524): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 4643
04-11 14:45:33.255+0200 E/weather-common( 4588): JsonUtil.cpp: GetArrayLength(119) > [0;40;31m[GetArrayLength(): 119] (array == NULL) [return][0;m
04-11 14:45:33.255+0200 W/AUL     (  524): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(4643)
04-11 14:45:33.255+0200 E/weather-common( 4588): SAPMessageParser.cpp: ParseWeatherInfo(800) > [0;40;31mweatherNode is NULL[0;m
04-11 14:45:33.260+0200 E/weather-consumer( 4588): SamsungAppcessoryProtocol.cpp: OnAppcessoryProtocolDataReceived(265) > [0;40;31m[OnAppcessoryProtocolDataReceived(): 265] (!sapMessageParser->ParseWeatherInfo()) [break][0;m
04-11 14:45:33.260+0200 E/weather-common( 4588): SAPMessageParser.cpp: ParseAckSeq(849) > [0;40;31mWeatherAckSeq : 1523450730[0;m
04-11 14:45:33.260+0200 E/weather-consumer( 4588): SamsungAppcessoryProtocol.cpp: OnAppcessoryProtocolDataReceived(420) > [0;40;31mmReceiveWeatherAck : 1523450730[0;m
04-11 14:45:33.265+0200 E/weather-consumer( 4588): SamsungAppcessoryProtocol.cpp: OnAppcessoryProtocolDataReceived(462) > [0;40;31mJust Receive AckData.[0;m
04-11 14:45:33.265+0200 E/weather-consumer( 4588): SamsungAppcessoryProtocol.cpp: OnAppcessoryProtocolDataReceived(465) > [0;40;31mWait until receive the data...[0;m
04-11 14:45:33.265+0200 E/weather-consumer( 4588): WeatherConsumerController.cpp: OnAppcessoryProtocolDataReceived(110) > [0;40;31mOnAppcessoryProtocolDataReceived[0;m
04-11 14:45:33.525+0200 W/CRASH_MANAGER( 4659): worker.c: worker_job(1205) > 1104610736c65152345073
