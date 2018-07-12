package com.urbandroid.sleep.addon.samsung;

import java.lang.Runnable;
import java.lang.System;

public class TimestampedCommand {
    private final String command;
    private final long timestamp;
    private final long attempsRemaining;
    private final Runnable postSuccess;

    private Runnable postFailed;

    public TimestampedCommand(String command, long timestamp, long attempsRemaining, Runnable postSuccess) {
        this.command = command;
        this.timestamp = timestamp;
        this.attempsRemaining = attempsRemaining;
        this.postSuccess = postSuccess;
    }

    public void setPostFailed(Runnable postFailed) {
        this.postFailed = postFailed;
    }

    public TimestampedCommand(String command, long timestamp) {
        this(command, timestamp, 0, null);
    }

    public String getCommand() {
        return command;
    }

    public long getTimestamp() {
        return timestamp;
    }

    public long getAttempsRemaining() { return attempsRemaining; }

    public Runnable getPostSuccess() { return postSuccess; }

    public Runnable getPostFailed() {
        return postFailed;
    }

    public TimestampedCommand newAttempt() {
        return new TimestampedCommand(command, System.currentTimeMillis(), attempsRemaining - 1, postSuccess);
    }
}
