#include "sleep_sap.h"

#include "common.h"

#include <glib.h>
#include <sap.h>
#include <app_common.h>

#define SLEEP_PROFILE_ID "/system/sleepassamsung"
#define SLEEP_CHANNELID 1750

static bool tracking_started_from_watch = false;

// Version of application on phone (of the addon).
int addon_version = -1;

gboolean get_tracking_started_from_watch() {
	return tracking_started_from_watch;
}
void set_tracking_started_from_watch(gboolean value) {
	tracking_started_from_watch = value;
}


struct priv {
	sap_agent_h agent;
	sap_socket_h socket;
	sap_peer_agent_h peer_agent;
};

static gboolean agent_created = FALSE;

static data_received_cb data_received_callback;

static struct priv priv_data = { 0 };

void on_peer_agent_updated(sap_peer_agent_h peer_agent,
			   sap_peer_agent_status_e peer_status,
			   sap_peer_agent_found_result_e result,
			   void *user_data) {
	switch (result) {
	case SAP_PEER_AGENT_FOUND_RESULT_DEVICE_NOT_CONNECTED:
		dlog_print(DLOG_INFO, TAG, "device is not connected");
		break;

	case SAP_PEER_AGENT_FOUND_RESULT_FOUND:
		if (peer_status == SAP_PEER_AGENT_STATUS_AVAILABLE) {
			priv_data.peer_agent = peer_agent;
			dlog_print(DLOG_INFO, TAG, "Find Peer Success!!");
			request_service_connection();
		} else {
			dlog_print(DLOG_INFO, TAG, "peer agent removed");
			sap_peer_agent_destroy(peer_agent);
		}
		break;

	case SAP_PEER_AGENT_FOUND_RESULT_SERVICE_NOT_FOUND:
		dlog_print(DLOG_INFO, TAG, "service not found");
		break;

	case SAP_PEER_AGENT_FOUND_RESULT_TIMEDOUT:
		dlog_print(DLOG_INFO, TAG, "peer agent find timed out");
		break;

	case SAP_PEER_AGENT_FOUND_RESULT_INTERNAL_ERROR:
		dlog_print(DLOG_INFO, TAG, "peer agent find search failed");
		break;
	}
}


static void on_service_connection_terminated(sap_peer_agent_h peer_agent,
					     sap_socket_h socket,
					     sap_service_connection_terminated_reason_e result,
					     void *user_data) {
	switch (result) {
	case SAP_CONNECTION_TERMINATED_REASON_PEER_DISCONNECTED:
		dlog_print(DLOG_INFO, TAG, "disconnected because peer lost");
		//update_ui("Peer Disconnected");
		break;

	case SAP_CONNECTION_TERMINATED_REASON_DEVICE_DETACHED:
		dlog_print(DLOG_INFO, TAG, "disconnected because device is detached");
		//update_ui("Disconnected Device Detached");
		break;

	case SAP_CONNECTION_TERMINATED_REASON_UNKNOWN:
		dlog_print(DLOG_INFO, TAG, "disconnected because of unknown reason");
		//update_ui("Disconnected Unknown Reason");
		break;
	}

	sap_socket_destroy(priv_data.socket);
	priv_data.socket = NULL;

	dlog_print(DLOG_INFO, TAG, "status:%d", result);
}


static void on_data_recieved(sap_socket_h socket,
			     unsigned short int channel_id,
			     unsigned int payload_length,
			     void *buffer,
			     void *user_data) {
	// dlog_print(DLOG_INFO, TAG, "received data: %s, len:%d", buffer, payload_length);
	data_received_callback(payload_length, buffer);
	// update_ui(buffer);
}



static void on_service_connection_created(sap_peer_agent_h peer_agent,
					  sap_socket_h socket,
					  sap_service_connection_result_e result,
					  void *user_data) {
	switch (result) {
	case SAP_CONNECTION_SUCCESS:
		dlog_print(DLOG_INFO, TAG, "peer agent connection is successful, pa :%u", peer_agent);
		sap_peer_agent_set_service_connection_terminated_cb(priv_data.peer_agent,
								    on_service_connection_terminated,
								    NULL);

		sap_socket_set_data_received_cb(socket, on_data_recieved, peer_agent);

		char **version;
		int ret = app_get_version(&version);

		priv_data.socket = socket;

		char *outstr[24];
		sprintf(&outstr, "Version %s",&version[0]);
		send_data(outstr);
		free(&version[0]);

		if (tracking_started_from_watch == true) {
           	dlog_print(DLOG_INFO, TAG, "App control started from WATCH - sending STARTING delayed");
			send_data("STARTING");
			tracking_started_from_watch = false;
		}
		// update_ui("Connection Established");
		break;

	case SAP_CONNECTION_ALREADY_EXIST:
		dlog_print(DLOG_INFO, TAG, "connection is already exist");
		priv_data.socket = socket;
		// update_ui("Connection already exist");
		break;

	case SAP_CONNECTION_FAILURE_DEVICE_UNREACHABLE:
		dlog_print(DLOG_INFO, TAG, "device is not unreachable");
		// update_ui("Device Not Reachable");
		break;

	case SAP_CONNECTION_FAILURE_INVALID_PEERAGENT:
		dlog_print(DLOG_INFO, TAG, "invalid peer agent");
		// update_ui("Invalid Peer Agent");
		break;

	case SAP_CONNECTION_FAILURE_NETWORK:
		dlog_print(DLOG_INFO, TAG, "network failure");
		// update_ui("Network Failure");
		break;

	case SAP_CONNECTION_FAILURE_PEERAGENT_NO_RESPONSE:
		dlog_print(DLOG_INFO, TAG, "peer agent is no response");
		// update_ui("PEERAGENT_NO_RESPONSE");
		break;

	case SAP_CONNECTION_FAILURE_PEERAGENT_REJECTED:
		dlog_print(DLOG_INFO, TAG, "peer agent is rejected");
		// update_ui("PEERAGENT_REJECTED");
		break;

	case SAP_CONNECTION_FAILURE_UNKNOWN:
		dlog_print(DLOG_INFO, TAG, "unknown error");
		// update_ui("UNKNOWN_ERROR");
		break;
	}
}

static gboolean _create_service_connection(gpointer user_data)
{
	struct priv *priv = NULL;
	sap_result_e result = SAP_RESULT_FAILURE;

	priv = (struct priv *)user_data;
	result = sap_agent_request_service_connection(priv->agent,
						      priv->peer_agent,
						      on_service_connection_created,
						      NULL);

	if (result == SAP_RESULT_SUCCESS) {
		dlog_print(DLOG_DEBUG, TAG, "req service conn call succeeded");
	} else {
		// update_ui("Connection Establishment Failed");
		dlog_print(DLOG_ERROR, TAG, "req service conn call is failed (%d)", result);
	}

	return FALSE;
}

gboolean request_service_connection(void)
{
	g_idle_add(_create_service_connection, &priv_data);

	dlog_print(DLOG_DEBUG, TAG, "request_service_connection call over");
	return TRUE;
}

static gboolean _terminate_service_connection(gpointer user_data)
{
	struct priv *priv = NULL;
	sap_result_e result = SAP_RESULT_FAILURE;

	priv = (struct priv *)user_data;

	if (priv->socket) {
		result = sap_peer_agent_terminate_service_connection(priv->peer_agent);
	} else {
		// update_ui("No service Connection");
		return FALSE;
	}

	if (result == SAP_RESULT_SUCCESS) {
		// update_ui("Connection Terminated");
		dlog_print(DLOG_DEBUG, TAG, "req service conn call succeeded");
	} else {
		// update_ui("Connection Termination Failed");
		dlog_print(DLOG_ERROR, TAG, "req service conn call is failed (%d)", result);
	}

	return FALSE;
}

gboolean terminate_service_connection(void) {
	g_idle_add(_terminate_service_connection, &priv_data);
	return TRUE;
}

static void on_service_connection_requested(sap_peer_agent_h peer_agent,
					    sap_socket_h socket,
					    sap_service_connection_result_e result,
					    void *user_data) {
	dlog_print(DLOG_DEBUG, TAG, "service connection requested");
	priv_data.socket = socket;
	priv_data.peer_agent = peer_agent;

	sap_peer_agent_set_service_connection_terminated_cb
		(priv_data.peer_agent, on_service_connection_terminated, user_data);

	sap_socket_set_data_received_cb(socket, on_data_recieved, peer_agent);

	sap_peer_agent_accept_service_connection(peer_agent);
}

static gboolean _find_peer_agent(gpointer user_data) {
	struct priv *priv = NULL;
	sap_result_e result = SAP_RESULT_FAILURE;

	priv = (struct priv *)user_data;

	result = sap_agent_find_peer_agent(priv->agent, on_peer_agent_updated, NULL);

	if (result == SAP_RESULT_SUCCESS) {
		dlog_print(DLOG_DEBUG, TAG, "find peer call succeeded");
	} else {
		dlog_print(DLOG_ERROR, TAG, "findsap_peer_agent_s is failed (%d)", result);
	}

	dlog_print(DLOG_DEBUG, TAG, "find peer call is over");

	return FALSE;
}

gboolean find_peers() {
	g_idle_add(_find_peer_agent, &priv_data);
	dlog_print(DLOG_DEBUG, TAG, "find peer called");
	return TRUE;

}

enum send_data_result send_data(char *message) {
	if (!priv_data.socket) {
		return SEND_DATA_ERROR;
	}

	int sap_result;
	sap_result = sap_socket_send_data(priv_data.socket, SLEEP_CHANNELID, strlen(message), message);
	dlog_print(DLOG_INFO, TAG, "Sending data %s", message);

	switch (sap_result) {
		case SAP_SOCKET_RESULT_SUCCESS:
			return SEND_DATA_SUCCESS;
		case SAP_SOCKET_RESULT_BUFFER_FULL:
			return SEND_DATA_BUFFER_FULL;
		default:
			return SEND_DATA_ERROR;
	}


}

static void on_agent_initialized(sap_agent_h agent,
				 sap_agent_initialized_result_e result,
				 void *user_data) {
	switch (result) {
	case SAP_AGENT_INITIALIZED_RESULT_SUCCESS:
		dlog_print(DLOG_INFO, TAG, "agent is initialized");

		sap_agent_set_service_connection_requested_cb(agent,
 							      on_service_connection_requested,
							      NULL);

		priv_data.agent = agent;
		agent_created = TRUE;
		find_peers();
		break;

	case SAP_AGENT_INITIALIZED_RESULT_DUPLICATED:
		dlog_print(DLOG_INFO, TAG, "duplicate registration");
		break;

	case SAP_AGENT_INITIALIZED_RESULT_INVALID_ARGUMENTS:
		dlog_print(DLOG_INFO, TAG, "invalid arguments");
		break;

	case SAP_AGENT_INITIALIZED_RESULT_INTERNAL_ERROR:
		dlog_print(DLOG_INFO, TAG, "internal sap error");
		break;

	default:
		dlog_print(DLOG_INFO, TAG, "unknown status (%d)", result);
		break;
	}

	dlog_print(DLOG_INFO, TAG, "agent initialized callback is over");

}

static void on_device_status_changed_empty(sap_device_status_e status, sap_transport_type_e transport_type,
				     void *user_data) {

}

static void on_device_status_changed(sap_device_status_e status, sap_transport_type_e transport_type,
				     void *user_data) {
	switch (transport_type) {
	case SAP_TRANSPORT_TYPE_BT:
		dlog_print(DLOG_INFO, TAG, "connectivity type(%d): bt", transport_type);
		break;

	case SAP_TRANSPORT_TYPE_BLE:
		dlog_print(DLOG_INFO, TAG, "connectivity type(%d): ble", transport_type);
		break;

	case SAP_TRANSPORT_TYPE_TCP:
		dlog_print(DLOG_INFO, TAG, "connectivity type(%d): tcp/ip", transport_type);
		break;

	case SAP_TRANSPORT_TYPE_USB:
		dlog_print(DLOG_INFO, TAG, "connectivity type(%d): usb", transport_type);
		break;

	case SAP_TRANSPORT_TYPE_MOBILE:
		dlog_print(DLOG_INFO, TAG, "connectivity type(%d): mobile", transport_type);
		break;

	default:
		dlog_print(DLOG_INFO, TAG, "unknown connectivity type (%d)", transport_type);
		break;
	}

	switch (status) {
	case SAP_DEVICE_STATUS_DETACHED:

		if (priv_data.peer_agent) {
			sap_socket_destroy(priv_data.socket);
			priv_data.socket = NULL;
			sap_peer_agent_destroy(priv_data.peer_agent);
			priv_data.peer_agent = NULL;
		}
		break;

	case SAP_DEVICE_STATUS_ATTACHED:
		if (agent_created) {
			g_idle_add(_find_peer_agent, &priv_data);
		}
		break;

	default:
		dlog_print(DLOG_INFO, TAG, "unknown status (%d)", status);
		break;
	}

}



gboolean agent_initialize() {
	int result = 0;

	do {
		result = sap_agent_initialize(priv_data.agent, SLEEP_PROFILE_ID, SAP_AGENT_ROLE_CONSUMER,
					      on_agent_initialized, NULL);
		dlog_print(DLOG_DEBUG, TAG, "SAP >>> getRegisteredServiceAgent() >>> %d", result);
	} while (result != SAP_RESULT_SUCCESS);

	return TRUE;
}

void terminate_sap() {
	sap_set_device_status_changed_cb(on_device_status_changed_empty, NULL);
	sap_agent_destroy(priv_data.agent);

   	dlog_print(DLOG_INFO, TAG, "App control started from WATCH RESET on TERMINATE");

	tracking_started_from_watch = false;
}

void initialize_sap(data_received_cb data_received) {

   	dlog_print(DLOG_INFO, TAG, "App control started from WATCH RESET on INIT");

    tracking_started_from_watch = false;

	data_received_callback = data_received;
	sap_agent_h agent = NULL;

	sap_agent_create(&agent);

	if (agent == NULL) {
		dlog_print(DLOG_INFO, TAG, "ERROR in creating agent");
	} else {
		dlog_print(DLOG_ERROR, TAG, "SUCCESSFULLY create sap agent");
	}

	priv_data.agent = agent;

	sap_set_device_status_changed_cb(on_device_status_changed, NULL);

	agent_initialize();
}
