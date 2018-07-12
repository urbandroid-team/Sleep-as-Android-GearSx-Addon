package com.urbandroid.sleep.addon.samsung;

import android.app.Activity;
import android.content.Intent;
import android.content.pm.PackageManager;
import android.content.res.Resources;
import android.net.Uri;
import android.os.Bundle;
import android.os.Handler;
import android.preference.PreferenceManager;
import android.text.Html;
import android.view.View;
import android.view.animation.Animation;
import android.view.animation.AnimationUtils;
import android.widget.Button;
import android.widget.CheckBox;
import android.widget.TextView;
import android.widget.Toast;
import com.urbandroid.common.logging.Logger;

import com.urbandroid.sleep.addon.generic.samsung.R;



public class MainActivity extends Activity {

    private static final String PACKAGE = "com.urbandroid.sleep";

    private boolean installed = true;

    private void showInstall(Intent installIntent, String text) {

    }

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);

        setContentView(R.layout.activity_main);

        try {
            this.getPackageManager().getApplicationInfo(PACKAGE, 0);
        } catch (PackageManager.NameNotFoundException e) {
            installed = false;
        }

        findViewById(R.id.install_gear).setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                startGearManager();
            }
        });

        findViewById(R.id.gear_fit2_more_info).setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                String url = "https://sleep.urbandroid.org/will-sleep-as-android-ever-support-gear-fit-2/";
                Intent i = new Intent(Intent.ACTION_VIEW);
                i.setData(Uri.parse(url));
                startActivity(i);
            }
        });

        findViewById(R.id.install_saa).setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                startMarket();
            }
        });

        findViewById(R.id.setup).setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                startSetup();
            }
        });

        findViewById(R.id.card_install_saa).setVisibility(!installed ? View.VISIBLE : View.GONE);

    }

    private void startSetup() {
        try {
            Intent i = new Intent();
            i.setClassName(PACKAGE, PACKAGE+".alarmclock.settings.SmartwatchSettingsActivity");
            startActivity(i);
        } catch (Exception e) {
            try {
                Intent i = new Intent();
                i.setClassName(PACKAGE, PACKAGE+".alarmclock.AlarmClock");
                startActivity(i);
            } catch (Exception ee) {
                finish();
            }
        }
    }

    private void startMarket() {
        try {
            Intent i = new Intent(Intent.ACTION_VIEW, Uri.parse("market://details?id="+PACKAGE));
            startActivity(i);
        } catch (Exception e) {
            finish();
        }
    }

    private void startGearManager() {
        try {
            Intent i = new Intent();
            i.setClassName("com.samsung.android.app.watchmanager", "com.samsung.android.app.watchmanager.setupwizard.SetupWizardWelcomeActivity");
            startActivity(i);
        } catch (Exception e) {
            finish();
        }
    }

}
