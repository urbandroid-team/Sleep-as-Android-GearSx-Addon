package com.urbandroid.sleep.addon.samsung;

import android.content.BroadcastReceiver;
import android.content.Context;
import android.content.Intent;
import android.support.v4.content.ContextCompat;

import com.urbandroid.common.error.ErrorReporter;
import com.urbandroid.common.logging.Logger;

public class SleepAsAndroidReceiver extends BroadcastReceiver {
    final static String START_WATCH_APP = "com.urbandroid.sleep.watch.START_TRACKING";
    final static String STOP_WATCH_APP = "com.urbandroid.sleep.watch.STOP_TRACKING";
    final static String SET_PAUSE = "com.urbandroid.sleep.watch.SET_PAUSE";
    final static String SET_BATCH_SIZE = "com.urbandroid.sleep.watch.SET_BATCH_SIZE";
    final static String SET_SUSPENDED = "com.urbandroid.sleep.watch.SET_SUSPENDED";
    final static String START_ALARM = "com.urbandroid.sleep.watch.START_ALARM";
    final static String STOP_ALARM = "com.urbandroid.sleep.watch.STOP_ALARM";
    final static String UPDATE_ALARM = "com.urbandroid.sleep.watch.UPDATE_ALARM";
    final static String HINT = "com.urbandroid.sleep.watch.HINT";
    final static String REPORT = "com.urbandroid.sleep.watch.REPORT";
    final static String DO_HR_MONITORING = "DO_HR_MONITORING";

    final static String CHECK_CONNECTED = "com.urbandroid.sleep.watch.CHECK_CONNECTED";

    @Override
    public void onReceive(Context context, Intent intent) {
        GlobalInitializer.initializeIfRequired(context);

        String action = intent != null ? intent.getAction() : "";
        if (action == null) {
            action = "";
        }

        if (action.equals(START_WATCH_APP)) {
            Intent serviceIntent = new Intent(context, SleepAsAndroidProviderService.class);
            serviceIntent.setAction(SleepAsAndroidProviderService.START_COMMAND);
            if (intent.getBooleanExtra(DO_HR_MONITORING, false)) {
                serviceIntent.putExtra(DO_HR_MONITORING, true);
            }
            ContextCompat.startForegroundService(context, serviceIntent);
        } else if (action.equals(STOP_WATCH_APP)) {
            Logger.logInfo("Received stop watch app.");
            Intent serviceIntent = new Intent(context, SleepAsAndroidProviderService.class);
            serviceIntent.setAction(SleepAsAndroidProviderService.STOP_COMMAND);
            ContextCompat.startForegroundService(context, serviceIntent);
        } else if (action.equals(SET_PAUSE)) {
            Intent serviceIntent = new Intent(context, SleepAsAndroidProviderService.class);
            serviceIntent.setAction(SleepAsAndroidProviderService.PAUSE_COMMAND);
            serviceIntent.putExtra("TIMESTAMP", intent.getLongExtra("TIMESTAMP", 0));
            ContextCompat.startForegroundService(context, serviceIntent);
        } else if (action.equals(SET_BATCH_SIZE)) {
            Intent serviceIntent = new Intent(context, SleepAsAndroidProviderService.class);
            serviceIntent.setAction(SleepAsAndroidProviderService.SET_BATCH_SIZE_COMMAND);
            serviceIntent.putExtra("SIZE", intent.getLongExtra("SIZE", 0));
            ContextCompat.startForegroundService(context, serviceIntent);
        } else if (action.equals(HINT)) {
            Intent serviceIntent = new Intent(context, SleepAsAndroidProviderService.class);
            serviceIntent.setAction(SleepAsAndroidProviderService.HINT_COMMAND);
            serviceIntent.putExtra("REPEAT", intent.getIntExtra("REPEAT", 0));
            ContextCompat.startForegroundService(context, serviceIntent);
        } else if (action.equals(UPDATE_ALARM)) {
            Intent serviceIntent = new Intent(context, SleepAsAndroidProviderService.class);
            serviceIntent.setAction(SleepAsAndroidProviderService.SET_ALARM_COMMAND);
            serviceIntent.putExtra("TIMESTAMP", intent.getLongExtra("TIMESTAMP", 0));
            ContextCompat.startForegroundService(context, serviceIntent);
        } else if (action.equals(START_ALARM)) {
            Intent serviceIntent = new Intent(context, SleepAsAndroidProviderService.class);
            serviceIntent.putExtra("DELAY", intent.getIntExtra("DELAY", 0));
            serviceIntent.setAction(SleepAsAndroidProviderService.START_ALARM_COMMAND);
            ContextCompat.startForegroundService(context, serviceIntent);
        } else if (action.equals(STOP_ALARM)) {
            Intent serviceIntent = new Intent(context, SleepAsAndroidProviderService.class);
            serviceIntent.setAction(SleepAsAndroidProviderService.STOP_ALARM_COMMAND);
            ContextCompat.startForegroundService(context, serviceIntent);
        } else if (action.equals(CHECK_CONNECTED)) {
            Intent serviceIntent = new Intent(context, SleepAsAndroidProviderService.class);
            serviceIntent.setAction(SleepAsAndroidProviderService.CHECK_CONNECTED_COMMAND);
            ContextCompat.startForegroundService(context, serviceIntent);
        } else if (action.equals(REPORT)) {
            Logger.logInfo("Generating on demand report");
            String comment = "No comment";
            if (intent.hasExtra("USER_COMMENT")) {
                comment = intent.getStringExtra("USER_COMMENT");
            }
            ErrorReporter.getInstance().generateOnDemandReport(null, "Manual report", comment);
        }
    }
}
