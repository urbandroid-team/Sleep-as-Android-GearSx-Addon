package com.urbandroid.sleep.addon.generic.samsung;

public enum AppState {
    CONNECTING("Connecting to your Samsung watch. Tap to cancel."),
    CONNECTED("Connected to your Samsung watch. Tap to cancel."),
    STOPPING("Stopping service...");

    public String text;

    AppState(String text) {
        this.text = text;
    }
}
