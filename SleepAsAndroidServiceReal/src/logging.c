#include <service_app.h>
#include <efl_extension.h>
#include <tizen.h>
#include <dlog.h>
#include <system_info.h>
#include <sensor.h>
#include "sleep_sap.h"

char *T = "SleepAsAndroidLogging";

bool logging_to_file = false;

char* get_write_filepath(char *filename)
{
    char write_filepath[1000] = {0,};
    char *resource_path = app_get_shared_data_path(); // get the application shared data directory path
    if(resource_path)
    {
        snprintf(write_filepath,1000,"%s%s",resource_path,filename);
        free(resource_path);
    }

    return write_filepath;
}

void write_file(const char* filepath, const char* buf)
{
    FILE *fp;
    fp = fopen(filepath,"a");
    fputs(buf,fp);
    fclose(fp);
}

void log_to_file(char* buf)
{
    char *filepath;
    filepath=get_write_filepath("log.txt");
    // Get the log: sdb pull /opt/usr/home/owner/apps_rw/com.urbandroid.sleep/shared/data/log.txt ~/log.txt

    dlog_print(DLOG_INFO, T, "Logged to file: %s", buf);

    if (logging_to_file) {
        write_file(filepath,buf);
    }
}

void log_to_file_with_ts(char* loggedMsgBuf) {
	struct timespec spec;
	clock_gettime(CLOCK_REALTIME, &spec);

//	unsigned long long current_time_ms_ts = spec.tv_sec * 1000LL + spec.tv_nsec / 1000000LL;

	time_t nowtime;
	struct tm *nowtm;
	nowtime = spec.tv_sec;
	nowtm = localtime(&nowtime);
	char tmbuf[64], humanReadableTimeBuf[64];
	strftime(tmbuf, sizeof tmbuf, "%Y-%m-%d %H:%M:%S", nowtm);
	snprintf(humanReadableTimeBuf, sizeof humanReadableTimeBuf, "%s.%06ld", tmbuf, spec.tv_nsec);


	char newbuf[160];
	snprintf(newbuf, 160, "%s: %s \n", humanReadableTimeBuf, loggedMsgBuf);

	log_to_file(newbuf);
}

void logf_to_file_with_ts( char* fmt, ...)
{
    char buf[300];     // this should really be sized appropriately
                       // possibly in response to a call to vsnprintf()
    va_list vl;
    va_start(vl, fmt);

    vsnprintf( buf, sizeof( buf), fmt, vl);

    va_end( vl);

    log_to_file_with_ts( buf);
}

void log_system_info() {
	// Log watch model info
    char *model_name;
    int ret;

    ret = system_info_get_platform_string("http://tizen.org/system/model_name", &model_name);
    if (ret != SYSTEM_INFO_ERROR_NONE) {
        /* Error handling */
        return;
    }

    // Log accelerometer info
	sensor_type_e s_type = SENSOR_ACCELEROMETER;
	sensor_h sensor_temp;
	int max_batch_count_temp = 0;
	if (sensor_get_default_sensor(s_type, &sensor_temp) == SENSOR_ERROR_NONE) {
		sensor_get_max_batch_count(sensor_temp, &max_batch_count_temp);
	}

	char buf[60];
	snprintf(buf, sizeof buf, "Watch model: %s, max batch count: %d", model_name, max_batch_count_temp);
	dlog_print(DLOG_INFO, T, buf);
	send_data(buf);

//	free(model_name); free(buf); free(sensor_temp);
}

void log_sensor_error(char *message, int error_code) {
	if (error_code != SENSOR_ERROR_NONE) {
		logf_to_file_with_ts("Sensor error: %s, error_code: %d", message, error_code);
	}
}

unsigned long long get_current_timestamp_ms() {
	struct timespec spec;
	clock_gettime(CLOCK_REALTIME, &spec);

	unsigned long long current_time_ms_ts = spec.tv_sec * 1000LL + spec.tv_nsec / 1000000LL;
	return current_time_ms_ts;
}

char *get_sensor_event_time_human_readable(unsigned long long event_timestamp) {
	struct timespec spec;
	clock_gettime(CLOCK_REALTIME, &spec);
	unsigned long long current_time_ms = spec.tv_sec * 1000LL + spec.tv_nsec / 1000000LL;
	clock_gettime(CLOCK_MONOTONIC, &spec);
	unsigned long long monotonic_time_ms = spec.tv_sec * 1000LL + spec.tv_nsec / 1000000LL;
	unsigned long long event_time_ms = current_time_ms - monotonic_time_ms + event_timestamp / 1000LL;

	char buf[80];
	snprintf(buf, sizeof buf, "%llu", event_time_ms);
//	struct tm ts;
//	char buf[80];
//
//	ts = *localtime(&event_time_ms);
//
//	strftime(buf, sizeof buf, "%Y-%m-%d %H:%M:%S", &ts);
//	snprintf(humanReadableTimeBuf, sizeof humanReadableTimeBuf, "%s.%06ld", tmbuf, spec.tv_nsec);


//	char newbuf[160];
//	snprintf(newbuf, 160, "%s: %s \n", humanReadableTimeBuf, loggedMsgBuf);
	return buf;
}


//void convert_ts_to_human() {
//	time_t rawtime = 1262304000;
//    struct tm  ts;
//    char       buf[80];
//
//    // Format time, "ddd yyyy-mm-dd hh:mm:ss zzz"
//    ts = *localtime(&rawtime);
//    strftime(buf, sizeof(buf), "%a %Y-%m-%d %H:%M:%S %Z", &ts);
//    printf("%s\n", buf);
//    return 0;
//}
