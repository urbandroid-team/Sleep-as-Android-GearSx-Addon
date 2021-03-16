package com.urbandroid.sleep.addon.generic.samsung;

public class TimestampedCommand {
    private final String command;
    private final long timestamp;
    private final long attemptsRemaining;
    private final Runnable postSuccess;

    private Runnable postFailed;

    public TimestampedCommand(String command, long timestamp, long attemptsRemaining, Runnable postSuccess) {
        this.command = command;
        this.timestamp = timestamp;
        this.attemptsRemaining = attemptsRemaining;
        this.postSuccess = postSuccess;
    }

    public void setPostFailed(Runnable postFailed) {
        this.postFailed = postFailed;
    }

    public TimestampedCommand(String command, long timestamp) {
        this(command, timestamp, 0, null);
    }

    public TimestampedCommand(String command) {
        this(command, System.currentTimeMillis(), 0, null);
    }

    public String getCommand() {
        return command;
    }

    public long getTimestamp() {
        return timestamp;
    }

    public long getAttemptsRemaining() { return attemptsRemaining; }

    public Runnable getPostSuccess() { return postSuccess; }

    public Runnable getPostFailed() {
        return postFailed;
    }

    public TimestampedCommand newAttempt() {
        return new TimestampedCommand(command, System.currentTimeMillis(), attemptsRemaining - 1, postSuccess);
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;
        TimestampedCommand that = (TimestampedCommand) o;
        return command.equals(that.command);
    }

    @Override
    public int hashCode() {
        return command != null ? command.hashCode() : 0;
    }

}
