package com.urbandroid.sleep.addon.generic.samsung;

import android.app.NotificationChannel;
import android.app.NotificationManager;
import android.content.Context;
import android.os.Build;

import com.urbandroid.sleep.addon.generic.samsung.R;

public class Notifications {

    final static String NOTIFICATION_CHANNEL_ID_TRACKING = "samsungTrackingChannel";
    final static String NOTIFICATION_CHANNEL_ID_WARNING = "samsungWarningChannel";

    public static void createChannels(Context context) {
        if (Build.VERSION.SDK_INT >= 26) {

            NotificationManager notificationManager = (NotificationManager) context.getSystemService(Context.NOTIFICATION_SERVICE);

            CharSequence trackingChannelTitle = context.getResources().getString(R.string.running);
            NotificationChannel trackingNotificationChannel = new NotificationChannel(NOTIFICATION_CHANNEL_ID_TRACKING, trackingChannelTitle, NotificationManager.IMPORTANCE_MIN);
            notificationManager.createNotificationChannel(trackingNotificationChannel);

            CharSequence warningChannelTitle = context.getResources().getString(R.string.running);
            NotificationChannel warningNotificationChannel = new NotificationChannel(NOTIFICATION_CHANNEL_ID_WARNING, warningChannelTitle, NotificationManager.IMPORTANCE_DEFAULT);
            notificationManager.createNotificationChannel(warningNotificationChannel);
        }
    }
}
