#ifndef __SLEEP_SAP_H__
#define __SLEEP_SAP_H__

#include <app.h>
#include <glib.h>
#include <Elementary.h>
#include <system_settings.h>
#include <efl_extension.h>
#include <dlog.h>

typedef  void (*data_received_cb)(unsigned int payload_length, void *buffer);

void     initialize_sap(data_received_cb data_received);
void	 terminate_sap();
gboolean find_peers();
gboolean request_service_connection(void);
gboolean terminate_service_connection(void);
gboolean send_data(char *message);

#endif
