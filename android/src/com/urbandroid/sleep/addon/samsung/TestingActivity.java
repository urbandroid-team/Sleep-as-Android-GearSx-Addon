package com.urbandroid.sleep.addon.samsung;

import android.app.Activity;
import android.content.BroadcastReceiver;
import android.content.Context;
import android.content.Intent;
import android.content.IntentFilter;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

import java.util.Arrays;
import java.util.Random;

import com.urbandroid.sleep.addon.generic.samsung.R;

/**
 * This activity exists only for testing purposes. It can be used to simulate command coming from sleep as android and as
 * well to simulate data coming from watch.
 *
 * This should NOT exist in production release of the add-on.
 */
public class TestingActivity extends Activity {
    private TextView lastReceivedValue;
    private TextView sendingStatus;

    private Runnable sendDataRunnable = null;

    private Random random = new Random();

    private BroadcastReceiver receiver;

    private boolean paused = false;
    private int batchSize = 1;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);

        GlobalInitializer.initializeIfRequired(this);
        setContentView(R.layout.testing_activity);

        Button startTracking = (Button) findViewById(R.id.start_tracking_on_watch);
        startTracking.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                sendBroadcast(new Intent(SleepAsAndroidReceiver.START_WATCH_APP));
            }
        });
        Button stopTracking = (Button) findViewById(R.id.stop_tracking_on_watch);
        stopTracking.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                sendBroadcast(new Intent(SleepAsAndroidReceiver.STOP_WATCH_APP));
            }
        });
        final Button pauseResumeTracking = (Button) findViewById(R.id.pause_resume_tracking_on_watch);
        pauseResumeTracking.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if (paused) {
                    Intent pauseIntent = new Intent(SleepAsAndroidReceiver.SET_PAUSE);
                    pauseIntent.putExtra("LONG_ARG", 0);
                    sendBroadcast(pauseIntent);
                    paused = false;
                    pauseResumeTracking.setText("Pause");
                } else {
                    Intent pauseIntent = new Intent(SleepAsAndroidReceiver.SET_PAUSE);
                    pauseIntent.putExtra("LONG_ARG", System.currentTimeMillis() + 30 * 1000);
                    sendBroadcast(pauseIntent);
                    paused = true;
                    pauseResumeTracking.setText("Resume");
                }
            }
        });
        final Button switchBatchSize = (Button) findViewById(R.id.switch_batch_size);
        switchBatchSize.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if (batchSize == 1) {
                    Intent intent = new Intent(SleepAsAndroidReceiver.SET_BATCH_SIZE);
                    intent.putExtra("LONG_ARG", 6l);
                    sendBroadcast(intent);
                    batchSize = 6;
                } else {
                    Intent intent = new Intent(SleepAsAndroidReceiver.SET_BATCH_SIZE);
                    intent.putExtra("LONG_ARG", 1l);
                    sendBroadcast(intent);
                    batchSize = 1;
                }
            }
        });

        lastReceivedValue = (TextView) findViewById(R.id.received_values);

        final Button startSendingData = (Button) findViewById(R.id.start_sending_data);
        startSendingData.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                sendDataRunnable = new Runnable() {
                    @Override
                    public void run() {
                        if (sendDataRunnable == null) {
                            return;
                        }

                        Intent dataUpdateIntent = new Intent(SleepAsAndroidProviderService.NEW_DATA_ACTION_NAME);
                        dataUpdateIntent.putExtra("DATA", new float[] { random.nextFloat(), random.nextFloat() });
                        sendBroadcast(dataUpdateIntent);
                        startSendingData.postDelayed(sendDataRunnable, 10 * 1000);
                    }
                };
                sendingStatus.setText("Sending");
                startSendingData.postDelayed(sendDataRunnable, 10 * 1000);
            }
        });
        Button stopSendingData = (Button) findViewById(R.id.stop_sending_data);
        stopSendingData.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                sendDataRunnable = null;
                sendingStatus.setText("Not sending");
            }
        });
        sendingStatus = (TextView) findViewById(R.id.sending_status);

        receiver = new BroadcastReceiver() {
            @Override
            public void onReceive(Context context, Intent intent) {
                if (intent.getAction().equals(SleepAsAndroidProviderService.NEW_DATA_ACTION_NAME)) {
                    lastReceivedValue.setText(Arrays.toString(intent.getFloatArrayExtra("DATA")));
                } else if (intent.getAction().equals(SleepAsAndroidReceiver.START_WATCH_APP)) {
                    lastReceivedValue.setText("Start app");
                } else if (intent.getAction().equals(SleepAsAndroidReceiver.STOP_WATCH_APP)) {
                    lastReceivedValue.setText("Stop app");
                    sendDataRunnable = null;
                    sendingStatus.setText("Not sending");
                }

            }
        };

        IntentFilter filter = new IntentFilter(SleepAsAndroidProviderService.NEW_DATA_ACTION_NAME);
        filter.addAction(SleepAsAndroidReceiver.START_WATCH_APP);
        filter.addAction(SleepAsAndroidReceiver.STOP_WATCH_APP);
        registerReceiver(receiver, filter);
    }

    @Override
    protected void onDestroy() {
        super.onDestroy();

        if (receiver != null) {
            unregisterReceiver(receiver);
        }
    }
}
