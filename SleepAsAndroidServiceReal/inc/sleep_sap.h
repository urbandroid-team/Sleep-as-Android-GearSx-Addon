#ifndef __SLEEP_SAP_H__
#define __SLEEP_SAP_H__

#include <app.h>
#include <glib.h>
#include <Elementary.h>
#include <system_settings.h>
#include <efl_extension.h>
#include <dlog.h>
#include <common.h>

typedef  void (*data_received_cb)(unsigned int payload_length, void *buffer);
typedef enum send_data_result {
	SEND_DATA_SUCCESS,
	SEND_DATA_BUFFER_FULL,
	SEND_DATA_ERROR
} send_data_result;

int addon_version;

void     initialize_sap(data_received_cb data_received);
void	 terminate_sap();
gboolean find_peers();
gboolean request_service_connection(void);
gboolean terminate_service_connection(void);
enum send_data_result send_data(char *message);
gboolean get_tracking_started_from_watch();
void 	 set_tracking_started_from_watch(gboolean value);

#endif
