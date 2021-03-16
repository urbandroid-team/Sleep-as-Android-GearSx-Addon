#ifndef __LOGGING_H__
#define __LOGGING_H__

#include <service_app.h>
#include <efl_extension.h>
#include <tizen.h>
#include <dlog.h>

char* get_write_filepath(char *filename);
void write_file(const char* filepath, const char* buf);
void log_to_file(char* buf);
void log_to_file_with_ts(char* buf);
void logf_to_file_with_ts( char* fmt, ...);
void log_system_info();
void log_sensor_error(char *message, int error_code);
unsigned long long get_current_timestamp_ms();
char *get_sensor_event_time_human_readable(unsigned long long event_timestamp);

#endif // LOGGING_H_
