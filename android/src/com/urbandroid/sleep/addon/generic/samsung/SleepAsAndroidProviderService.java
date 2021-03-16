package com.urbandroid.sleep.addon.generic.samsung;

import android.app.AlarmManager;
import android.app.Notification;
import android.app.NotificationManager;
import android.app.PendingIntent;
import android.content.BroadcastReceiver;
import android.content.Context;
import android.content.Intent;
import android.os.Binder;
import android.os.Build;
import android.os.Handler;
import android.os.IBinder;
import androidx.core.app.NotificationCompat;
import com.samsung.android.sdk.SsdkUnsupportedException;
import com.samsung.android.sdk.accessory.SA;
import com.samsung.android.sdk.accessory.SAAgent;
import com.samsung.android.sdk.accessory.SAPeerAgent;
import com.samsung.android.sdk.accessory.SASocket;
import com.urbandroid.common.logging.Logger;
import com.urbandroid.common.version.ApplicationVersionExtractor;
import com.urbandroid.common.version.ApplicationVersionInfo;

import java.io.IOException;
import java.util.HashMap;
import java.util.Map;
import java.util.concurrent.BlockingQueue;
import java.util.concurrent.LinkedBlockingQueue;
import java.util.concurrent.TimeUnit;

import static com.urbandroid.sleep.addon.generic.samsung.Notifications.NOTIFICATION_CHANNEL_ID_TRACKING;

public class SleepAsAndroidProviderService extends SAAgent {
    // From watch
    public final static String NEW_DATA_ACTION_NAME = "com.urbandroid.sleep.watch.DATA_UPDATE";
    public final static String NEW_HR_DATA_ACTION_NAME = "com.urbandroid.sleep.watch.HR_DATA_UPDATE";
    private final static String PAUSE_ACTION_NAME = "com.urbandroid.sleep.watch.PAUSE_FROM_WATCH";
    private final static String RESUME_ACTION_NAME = "com.urbandroid.sleep.watch.RESUME_FROM_WATCH";
    private final static String SNOOZE_ACTION_NAME = "com.urbandroid.sleep.watch.SNOOZE_FROM_WATCH";
    private final static String DISMISS_ACTION_NAME = "com.urbandroid.sleep.watch.DISMISS_FROM_WATCH";
    private final static String STARTED_ON_WATCH_NAME = "com.urbandroid.sleep.watch.STARTED_ON_WATCH";

    // From phone
    public final static String START_COMMAND = "com.urbandroid.sleep.samsung.INTERNAL_START_COMMAND";
    public final static String STOP_COMMAND = "com.urbandroid.sleep.samsung.INTERNAL_STOP_COMMAND";
    public final static String PAUSE_COMMAND = "com.urbandroid.sleep.samsung.INTERNAL_PAUSE_COMMAND";
    public final static String SET_BATCH_SIZE_COMMAND = "com.urbandroid.sleep.samsung.INTERNAL_SET_BATCH_SIZE_COMMAND";
    public final static String SET_ALARM_COMMAND = "com.urbandroid.sleep.samsung.INTERNAL_SET_ALARM_COMMAND";
    public final static String START_ALARM_COMMAND = "com.urbandroid.sleep.samsung.INTERNAL_START_ALARM_COMMAND";
    public final static String STOP_ALARM_COMMAND = "com.urbandroid.sleep.samsung.INTERNAL_STOP_ALARM_COMMAND";
    public final static String HINT_COMMAND = "com.urbandroid.sleep.samsung.HINT_COMMAND";
    public final static String CHECK_CONNECTED_COMMAND = "com.urbandroid.sleep.samsung.CHECK_CONNECTED_COMMAND";

    private final static String INTERNAL_LAST_ACTIVITY_CHECK = "internatl-LAST_ACTIVITY_CHECK";
    final static String ACTION_STOP_SELF = "com.urbandroid.sleep.addon.samsung.STOP_SELF";
    final static String STOP_SLEEP_TRACK_ACTION = "com.urbandroid.sleep.alarmclock.STOP_SLEEP_TRACK";

    public static final String TAG = "SleepAsSamsung";

    public static final int SLEEP_AS_SAMSUNG_CHANNEL_ID = 1750;

    // If we ever receive batch with data length not divisible by 3 we know we are running against old version of client
    // -> Do not divide and take first value only.
    private static boolean runningInCompatibilityMode = false;

    HashMap<Integer, SleepAsSamsungProviderConnection> mConnectionsMap = null;

    public static Map<String, SAPeerAgent> connectedAgents = new HashMap<String, SAPeerAgent>();

    private final IBinder mBinder = new LocalBinder();

    // This is set when we receive a command from watch and we need to connect. We getAggregate it on reply from findPeerAgents().
    // It is used to keep state across 2 independent async calls..
    private boolean connectRequested = false;

    // We schedule stop if we believe communication with the watch is over to prevent the service to get stuck
    // this includes stop track or alarm form sleep or when the watch disconnects, and it is canceled if another command from watch or sleep arrives
    private StopScheduler stopScheduler;

    // Stop was initiated by user from Sleep or from the watch - we do not want any further starts from the watch in this case
    private static volatile boolean pendingStop = false;

    private static volatile boolean doHrMonitoring = false;

    private BroadcastReceiver refreshReceiver = null;

    private Thread commandThread;

    private AppState appState = null;

    public class LocalBinder extends Binder {
        public SleepAsAndroidProviderService getService() {
            return SleepAsAndroidProviderService.this;
        }
    }

    public SleepAsAndroidProviderService() {
        super(TAG, SleepAsSamsungProviderConnection.class);
    }

    public class SleepAsSamsungProviderConnection extends SASocket {
        private int mConnectionId;

        public SleepAsSamsungProviderConnection() {
            super(SleepAsSamsungProviderConnection.class.getName());
        }

        @Override
        public void onError(int channelId, String errorString, int error) {
            Logger.logSevere("Connection is not alive ERROR: " + errorString + "  "
                    + error);
        }

        @Override
        public void onReceive(int channelId, byte[] data) {
            // Logger.logDebug("onReceive");

            String receivedData = new String(data);
            Logger.logInfo("Received from watch: " + receivedData);

            if (pendingStop) {
                Logger.logInfo("Ignoring command due to pending cancel.");
                return;
            }

            updateState(AppState.CONNECTED);

            if (receivedData.startsWith("DATA")) {
                Intent dataUpdateIntent = new Intent(NEW_DATA_ACTION_NAME);
                receivedData = receivedData.substring(4);
                String[] values = receivedData.split(",");
                if (values.length % 3 != 0) {
                    runningInCompatibilityMode = true;
                }

                if (runningInCompatibilityMode) {
                    // In compatibility mod, we are getting only max data.
                    float[] maxFloatValues = new float[values.length];
                    for (int i = 0; i < values.length; i++) {
                        String maxValue = values[i];
                        maxFloatValues[i] = Float.valueOf(maxValue);
                    }
                    dataUpdateIntent.putExtra("MAX_DATA", maxFloatValues);
                } else {
                    float[] maxFloatValues = new float[values.length / 3];
                    float[] minFloatValues = new float[values.length / 3];
                    float[] avgFloatValues = new float[values.length / 3];
                    for (int i = 0; i < values.length; i += 3) {
                        String maxValue = values[i];
                        String minValue = values[i + 1];
                        String avgValue = values[i + 2];
                        maxFloatValues[i / 3] = Float.valueOf(maxValue);
                        minFloatValues[i / 3] = Float.valueOf(minValue);
                        avgFloatValues[i / 3] = Float.valueOf(avgValue);
                    }
                    dataUpdateIntent.putExtra("MAX_DATA", maxFloatValues);
                    dataUpdateIntent.putExtra("MIN_DATA", minFloatValues);
                    dataUpdateIntent.putExtra("AVG_DATA", avgFloatValues);
                }

                sendBroadcastToSleep(dataUpdateIntent);

            } else if (receivedData.startsWith("NEW_ACTI_DATA")) {
                Intent dataUpdateIntent = new Intent(NEW_DATA_ACTION_NAME);
                receivedData = receivedData.substring(13);

                String[] values;
                values = DataConverter.convertToCorrectDataFormat(receivedData);

                float[] maxFloatValues = new float[values.length / 4];
                float[] newMaxFloatValues = new float[values.length / 4];
                for (int i = 0; i < values.length; i += 4) {
                    String maxValue = values[i];
                    String newMaxValue = values[i + 3];
                    maxFloatValues[i / 4] = Float.valueOf(maxValue);
                    newMaxFloatValues[i / 4] = Float.valueOf(newMaxValue);
                }
                dataUpdateIntent.putExtra("MAX_DATA", maxFloatValues);
                dataUpdateIntent.putExtra("MAX_RAW_DATA", newMaxFloatValues);

                sendBroadcastToSleep(dataUpdateIntent);
            } else if (receivedData.startsWith("HR_DATA")) {
                receivedData = receivedData.substring(7);
                String[] values = receivedData.split(",");
                float[] floatValues = new float[values.length];
                for (int i = 0; i < values.length; i++) {
                    String value = values[i];
                    floatValues[i] = Float.valueOf(value);
                }

                Intent dataUpdateIntent = new Intent(NEW_HR_DATA_ACTION_NAME);
                dataUpdateIntent.putExtra("DATA", floatValues);
                sendBroadcastToSleep(dataUpdateIntent);
            } else if (receivedData.startsWith("RLOG")) {
                String logMessage = receivedData.substring(4);
                Logger.logInfo("WatchMessage: " + logMessage);
            } else if (receivedData.equals("SNOOZE")) {
                sendBroadcastToSleep(SNOOZE_ACTION_NAME);
            } else if (receivedData.equals("DISMISS")) {
                sendBroadcastToSleep(DISMISS_ACTION_NAME);
            } else if (receivedData.equals("PAUSE")) {
                sendBroadcastToSleep(PAUSE_ACTION_NAME);
            } else if (receivedData.equals("RESUME")) {
                sendBroadcastToSleep(RESUME_ACTION_NAME);
            } else if (receivedData.equals("STOP")) {
                sendBroadcastToSleep(STOP_SLEEP_TRACK_ACTION);
                cancelRestartingIntent();
                pendingStop = true;
                stopSelf();
            } else if (receivedData.equals("STARTING")) {
                stopScheduler.cancel();
                sendBroadcastToSleep(STARTED_ON_WATCH_NAME);
            }
        }

        @Override
        protected void onServiceConnectionLost(int errorCode) {
            Logger.logSevere("onServiceConectionLost  for peer = " + mConnectionId
                    + "error code =" + errorCode);

			if (mConnectionsMap != null) {
				mConnectionsMap.remove(mConnectionId);
			}
        }
    }


        private void sendBroadcastToSleep(String action) {
        sendBroadcastToSleep(new Intent(action));
    }

    private void sendBroadcastToSleep(Intent intent) {
        intent.setPackage(MainActivity.MASTER_PACKAGE);
        sendBroadcast(intent);
    }

    @Override
    public void onCreate() {
        super.onCreate();
        GlobalInitializer.initializeIfRequired(this);

        appState = AppState.CONNECTING;
        stopScheduler = new StopScheduler();

        if (commandThread == null) {
            commandThread = new Thread(new CommandExecutionRunnable());
            commandThread.start();
        }

        Logger.logInfo("service onCreate");

        SA mAccessory = new SA();
        try {
            mAccessory.initialize(this);
        } catch (SsdkUnsupportedException e) {
            // Error Handling
        } catch (Exception e1) {
            Logger.logSevere("Cannot initialize Accessory package.");
            e1.printStackTrace();
            /*
             * Your application can not use Accessory package of Samsung
             * Mobile SDK. You application should work smoothly without using
             * this SDK, or you may want to notify user and close your app
             * gracefully (release resources, cancel Service threads, close UI
             * thread, etc.)
             */
            stopSelf();
        }


    }

    private int ONGOING_NOTIFICATION_ID = 1238888888;

    private void startForeground() {
        Logger.logDebug("Start foreground");

        startForeground(ONGOING_NOTIFICATION_ID, buildNotification(appState.text));
    }

    private Notification buildNotification(String text) {
        Intent stopIntent = new Intent(this, SleepAsAndroidProviderService.class);
        stopIntent.setAction(ACTION_STOP_SELF);

        PendingIntent contentPi = PendingIntent.getService(this, 5468, stopIntent, 0);
        if (Build.VERSION.SDK_INT >= 26) {
            contentPi = PendingIntent.getForegroundService(this, 150, stopIntent, PendingIntent.FLAG_UPDATE_CURRENT);
        }

        NotificationCompat.Builder notificationBuilder = new NotificationCompat.Builder(this, NOTIFICATION_CHANNEL_ID_TRACKING)
                .setContentIntent(contentPi)
                .setColor(getResources().getColor(R.color.tint_dark))
                .setContentText(text)
                .addAction(R.drawable.ic_action_stop, "Stop", contentPi);

        if (Build.VERSION.SDK_INT < 24) {
            notificationBuilder.setContentTitle(getString(R.string.app_name));
        }

        notificationBuilder.setSmallIcon(R.drawable.notification_icon);

        return notificationBuilder.build();
    }

    private void updateNotification(String text) {
        Logger.logDebug("updating notification to " + text);
        NotificationManager nm = (NotificationManager) getSystemService(Context.NOTIFICATION_SERVICE);
        nm.notify(ONGOING_NOTIFICATION_ID, buildNotification(text));
    }

    private void updateState(AppState state) {
        appState = state;
        updateNotification(appState.text);
    }

    @Override
    public int onStartCommand(final Intent intent, int i, int i2) {
        startForeground();

        stopScheduler.cancel();

        if (intent == null || intent.getAction() == null) {
            return super.onStartCommand(intent, i, i2);
        }

        switch (intent.getAction()) {
            case ACTION_STOP_SELF: {
                cancelRestartingIntent();
                pendingStop = true;
                stopSelf();
                return START_NOT_STICKY;
            }
            case START_COMMAND:
                doHrMonitoring = intent.getBooleanExtra(SleepAsAndroidReceiver.DO_HR_MONITORING, false);
                Logger.logInfo("Start command received. HrMonitoring: " + doHrMonitoring);
                scheduleAsyncStartCommand();
                scheduleRestartingIntent();
                pendingStop = false;
                return START_STICKY;
            case STOP_COMMAND:
                Logger.logInfo("Stop command received");
                cancelRestartingIntent();
                pendingStop = true;

                scheduleAsyncCommand("StopApp", 1000, defaultStopSchedulerRunnable, defaultStopSchedulerRunnable);

                return START_STICKY;
            case PAUSE_COMMAND: {

                long param = intent.getLongExtra("TIMESTAMP", 0);
                Logger.logInfo("Pause command received " + param);
                scheduleAsyncCommand("Pause;" + param);
                return START_STICKY;
            }
            case SET_BATCH_SIZE_COMMAND: {
                long param = intent.getLongExtra("SIZE", 1);
                Logger.logInfo("Batch size command received " + param);
                scheduleAsyncCommand("BatchSize;" + param);
                return START_STICKY;
            }
            case HINT_COMMAND: {
                long param = intent.getIntExtra("REPEAT", 1);
                Logger.logInfo("Hint received " + param);
                if (param > 0) {
                    // Do hints only if we want some repeats.
                    // Temporarily disable completely as it is crashing the watch.
                    scheduleAsyncCommand("Hint;" + param);
                }
                return START_STICKY;
            }
            case SET_ALARM_COMMAND: {
                long param = intent.getLongExtra("TIMESTAMP", 0);
                Logger.logInfo("Set alarm command received " + param);
                scheduleAsyncCommand("SetAlarm;" + param);
                return START_STICKY;
            }
            case START_ALARM_COMMAND: {
                long param = intent.getIntExtra("DELAY", 0);
                Logger.logInfo("Start alarm command received " + param);
                scheduleAsyncCommand("StartAlarm;" + param);
                return START_STICKY;
            }
            case STOP_ALARM_COMMAND:
                Logger.logInfo("Stop alarm command received.");

                if (intent.getBooleanExtra("tracking", false)) {
                    scheduleAsyncCommand("StopAlarm", 10);
                } else {
                    scheduleAsyncCommand("StopAlarm", 10, defaultStopSchedulerRunnable, defaultStopSchedulerRunnable);
                }
                return START_STICKY;
            case CHECK_CONNECTED_COMMAND:
                Logger.logInfo("Check connected command received.");
                // We need to start app only if peer app is not running (i.e. we have no connection to it).
                if (mConnectionsMap != null && !mConnectionsMap.isEmpty()) {
                    updateState(AppState.CONNECTED);
                    Logger.logInfo("Connected already.");
                    Intent confirmationIntent = new Intent("com.urbandroid.sleep.watch.CONFIRM_CONNECTED");
                    confirmationIntent.setPackage(MainActivity.MASTER_PACKAGE);
                    sendBroadcast(confirmationIntent);
                } else {
                    Logger.logInfo("Initiating async connectivity check.");
                    findPeerAgents();
                }

                return START_STICKY;
        }

        return super.onStartCommand(intent, i, i2);
    }

    private Runnable defaultStopSchedulerRunnable = new Runnable() {
        @Override
        public void run() {
            stopScheduler.scheduleStop();
        }
    };

    private class StopScheduler {

        private boolean isScheduled = false;

        private Runnable stopSelfRunnable = new Runnable() {
            @Override
            public void run() {
                stopSelf();
            }
        };

        private Handler h;

        StopScheduler() {
            h = new Handler();
        }

        public void scheduleStop() {
            scheduleStop(5000);
        }

        public void scheduleStop(int timeout) {
            isScheduled = true;

            pendingStop = false;
            h.removeCallbacks(stopSelfRunnable);
            h.postDelayed(stopSelfRunnable, timeout);
            updateState(AppState.STOPPING);
        }


        void cancel() {
            if (isScheduled) {
                h.removeCallbacks(stopSelfRunnable);
                updateState(AppState.CONNECTED);
                isScheduled = false;
            }
        }

    }



    private PendingIntent createRestartIntent() {
        Intent i = new Intent(INTERNAL_LAST_ACTIVITY_CHECK);
        return PendingIntent.getBroadcast(this, 0, i, PendingIntent.FLAG_UPDATE_CURRENT);
    }


    private final BlockingQueue<TimestampedCommand> commands = new LinkedBlockingQueue<TimestampedCommand>();

    private void requestConnectionIfMissing() {
        if ((mConnectionsMap == null || mConnectionsMap.isEmpty()) && !connectRequested) {
            Logger.logInfo("Requesting connection");
            connectRequested = true;
            findPeerAgents();
        }
    }

    private void scheduleAsyncStartCommand() {
        removeCommandsFromQueue("StopApp");

        int version = new ApplicationVersionExtractor().getCurrentVersion(SleepAsAndroidProviderService.this, "com.urbandroid.sleep").getVersionCode();
        scheduleAsyncCommand("AppVersion;" + version);
        scheduleAsyncCommand("DoHr;" + doHrMonitoring);
        // Note: Compatibility with old apps requires we send exactly this string.
        scheduleAsyncCommand("StartTracking");
    }

    private void removeCommandsFromQueue(String command) {
        while (commands.remove(new TimestampedCommand(command)));
    }

    private void scheduleAsyncCommand(String command) {
        scheduleAsyncCommand(command, 1);
    }

    private void scheduleAsyncCommand(String command, long attempts) {
        scheduleAsyncCommand(command, attempts, null);
    }

    private void scheduleAsyncCommand(String command, long attempts, Runnable postSuccess) {
        scheduleAsyncCommand(command, attempts, postSuccess, null);
    }

    private void scheduleAsyncCommand(String command, long attempts, Runnable postSuccess, Runnable postFailed) {
        requestConnectionIfMissing();
        try {
            TimestampedCommand tsc = new TimestampedCommand(command, System.currentTimeMillis(), attempts - 1, postSuccess);
            tsc.setPostFailed(postFailed);
            commands.put(tsc);
        } catch (InterruptedException ie) {
            Logger.logInfo("Interrupted while adding command.");
        }
    }

    @Override
    protected void onServiceConnectionRequested(SAPeerAgent peerAgent) {
        Logger.logDebug("onServiceConnectionRequested peerAgent AppName: " + peerAgent.getAppName());
        acceptServiceConnectionRequest(peerAgent);
    }

    @Override
    protected void onPeerAgentsUpdated(SAPeerAgent[] peerAgents, int result) {
        super.onPeerAgentsUpdated(peerAgents, result);

        if (peerAgents == null) {
            return;
        }

        for (SAPeerAgent peerAgent : peerAgents) {
            if (result == PEER_AGENT_FOUND || result == PEER_AGENT_AVAILABLE) {
                connectedAgents.put(peerAgent.getPeerId(), peerAgent);
            } else {
                connectedAgents.remove(peerAgent.getPeerId());
            }
        }

    }

    @Override
    protected void onFindPeerAgentsResponse(SAPeerAgent[] peerAgents, int result) {
        super.onFindPeerAgentsResponse(peerAgents, result);

        if (peerAgents == null || result == FINDPEER_DEVICE_NOT_CONNECTED) {
            // We can stopSelf as we count on Sleep to start the service again if needed, through connectivity checker
            stopScheduler.scheduleStop();
            return;
        }

        for (SAPeerAgent peerAgent : peerAgents) {

            if (result == PEER_AGENT_FOUND) {
                Logger.logInfo("Peer agent found.");
                // Check still no connection + start was requested-> Try to connect peer
                if ((mConnectionsMap == null || mConnectionsMap.isEmpty()) && connectRequested) {
                    Logger.logInfo("Requesting service connection.");
                    requestServiceConnection(peerAgent);
                }

                connectedAgents.put(peerAgent.getPeerId(), peerAgent);

                if (appState != AppState.CONNECTED) {
                    Logger.logInfo("Confirming connectivity.");
                    sendBroadcast(new Intent("com.urbandroid.sleep.watch.CONFIRM_CONNECTED")
                            .setPackage(MainActivity.MASTER_PACKAGE));

                    stopScheduler.scheduleStop(10000);
                }

            } else {
                Logger.logInfo("Peer agent not found: " + result);
                if (peerAgent != null && peerAgent.getPeerId() != null) {
                    connectedAgents.remove(peerAgent.getPeerId());
                }
            }
        }

        if (result != PEER_AGENT_FOUND) {
            stopScheduler.scheduleStop();
        }

        connectRequested = false;
    }


    @Override
    protected void onServiceConnectionResponse(SAPeerAgent peerAgent, SASocket thisConnection, int result) {
        if (result == CONNECTION_SUCCESS) {
            if (thisConnection != null) {
                SleepAsSamsungProviderConnection myConnection = (SleepAsSamsungProviderConnection) thisConnection;

                if (mConnectionsMap == null) {
                    mConnectionsMap = new HashMap<Integer, SleepAsSamsungProviderConnection>();
                }

                myConnection.mConnectionId = (int) (System.currentTimeMillis() & 255);

                Logger.logDebug("onServiceConnection connectionID = " + myConnection.mConnectionId);

                mConnectionsMap.put(myConnection.mConnectionId, myConnection);

                ApplicationVersionInfo versionInfo = new ApplicationVersionExtractor().getCurrentVersion(SleepAsAndroidProviderService.this, "com.urbandroid.sleep");
                if (versionInfo.getVersionCode() < 862) {
                    scheduleAsyncCommand("OLD_OR_MISSING");
                }

            } else {
                Logger.logSevere("SASocket object is null");
            }
        } else if (result == CONNECTION_ALREADY_EXIST) {
            Logger.logSevere("onServiceConnectionResponse, CONNECTION_ALREADY_EXIST");
        } else {
            Logger.logSevere("onServiceConnectionResponse result error =" + result);
//            TODO should we not do something like cancel/schedule cancel the addon here?
        }
    }

    @Override
    public IBinder onBind(Intent arg0) {
        return mBinder;
    }

    @Override
    public void onDestroy() {
        super.onDestroy();

        if (commandThread != null) {
            commandThread.interrupt();
            commandThread = null;
        }

        if (refreshReceiver != null) {
            unregisterReceiver(refreshReceiver);
            refreshReceiver = null;
        }

        cancelRestartingIntent();
        Logger.logInfo("Service onDestroy");
    }

    private void cancelRestartingIntent() {
        AlarmManager alarms = (AlarmManager) getApplicationContext().getSystemService(Context.ALARM_SERVICE);
        alarms.cancel(createRestartIntent());
    }

    private void scheduleRestartingIntent() {
        AlarmManager alarms = (AlarmManager) getApplicationContext().getSystemService(Context.ALARM_SERVICE);
        alarms.setRepeating(AlarmManager.RTC_WAKEUP, System.currentTimeMillis(), 5 * 1000, createRestartIntent());

    }
    private class CommandExecutionRunnable implements Runnable {
        final long MAX_COMMAND_AGE_MS = 10000;

        @Override
        public void run() {
            while (!Thread.interrupted()) {
                try {
                    // TODO: Protect on connection lock.
                    if (mConnectionsMap == null || mConnectionsMap.isEmpty()) {
                        Thread.sleep(1000);
                        continue;
                    }

                    TimestampedCommand command = commands.poll(5000, TimeUnit.MILLISECONDS);
                    if (command == null) {
                        continue;
                    }

                    if (command.getTimestamp() < System.currentTimeMillis() - MAX_COMMAND_AGE_MS) {
                        Logger.logInfo("Command timed out [" + command.getCommand() + "]");
                        if (command.getAttemptsRemaining() > 0) {
                            Logger.logInfo("Will retry timed out command");
                            commands.add(command.newAttempt());
                        }
                        continue;
                    }

                    for (final SleepAsSamsungProviderConnection connection : new HashMap<Integer, SleepAsSamsungProviderConnection>(mConnectionsMap).values()) {
                        try {
                            Logger.logInfo("Sending command: " + command.getCommand());
                            connection.send(SLEEP_AS_SAMSUNG_CHANNEL_ID, command.getCommand().getBytes());
                            if (command.getPostSuccess() != null) {
                                command.getPostSuccess().run();
                            }
                        } catch (IOException e) {
                            if (command.getAttemptsRemaining() > 0) {
                                Logger.logInfo("Will retry failed command");
                                commands.add(command.newAttempt());
                            } else {
                                if (command.getPostFailed() != null) {
                                    command.getPostFailed().run();
                                }
                            }
                            Logger.logSevere("Command failed [" + command.getCommand() + "]", e);
                        }
                    }
                } catch (InterruptedException ie) {
                    Logger.logInfo("Interrupted command execution thread.");
                    return;
                }
            }
        }
    }

}