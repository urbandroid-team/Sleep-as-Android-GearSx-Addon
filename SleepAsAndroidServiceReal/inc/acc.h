#ifndef __acc_H__
#define __acc_H__

#include <dlog.h>

bool paused;

void start_accelerometer();
void stop_accelerometer();
void terminate_acc();
void set_batch_size(int size);

#endif /* __acc_H__ */
