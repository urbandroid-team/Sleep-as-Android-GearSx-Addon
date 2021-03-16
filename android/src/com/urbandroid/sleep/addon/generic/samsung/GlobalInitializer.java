package com.urbandroid.sleep.addon.generic.samsung;

import android.content.Context;
import android.os.Handler;
import com.urbandroid.common.error.DefaultConfigurationBuilder;
import com.urbandroid.common.error.ErrorReporter;
import com.urbandroid.common.error.ErrorReporterConfiguration;
import com.urbandroid.common.logging.Logger;

public class GlobalInitializer {
    private static boolean isInitialized = false;

    public synchronized static void initializeIfRequired(Context context) {
        if (isInitialized) {
            return;
        }

        isInitialized = true;

        Logger.initialize(context, "SleepAsAndroid-Samsung-AddOn", 2000, Logger.DEBUG_LEVEL, Logger.DEBUG_LEVEL);

        ErrorReporterConfiguration configuration =
                new DefaultConfigurationBuilder.Builder(context, new Handler(), "SleepAsSamsung", new String[] {"urbandroid.info@gmail.com"}).
                        withLockupDatection(false).build();

        ErrorReporter.initialize(context, configuration);

        Notifications.createChannels(context);

        Logger.logInfo("Global initialization done");
    }
}
