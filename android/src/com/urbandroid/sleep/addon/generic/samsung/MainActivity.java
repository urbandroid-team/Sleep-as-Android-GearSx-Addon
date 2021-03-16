package com.urbandroid.sleep.addon.generic.samsung;

import android.app.Activity;
import android.content.Intent;
import android.content.pm.PackageManager;
import android.net.Uri;
import android.os.Bundle;
import android.view.View;

import com.urbandroid.sleep.addon.generic.samsung.R;



public class MainActivity extends Activity {

    public static final String MASTER_PACKAGE = "com.urbandroid.sleep";

    private boolean installed = true;

    private void showInstall(Intent installIntent, String text) {

    }

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);

        setContentView(R.layout.activity_main);

        try {
            this.getPackageManager().getApplicationInfo(MASTER_PACKAGE, 0);
        } catch (PackageManager.NameNotFoundException e) {
            installed = false;
        }

        findViewById(R.id.install_gear).setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                startGearManager();
//                String url = "samsungapps://ProductDetail/com.urbandroid.sleep";
//                Intent i = new Intent(Intent.ACTION_VIEW);
//                i.setData(Uri.parse(url));
//                startActivity(i);
            }
        });

        findViewById(R.id.supported_wearables_more_info).setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                String url = "https://sleep.urbandroid.org/documentation/integration/wearable/#supported-devices";
                Intent i = new Intent(Intent.ACTION_VIEW);
                i.setData(Uri.parse(url));
                startActivity(i);
            }
        });

        findViewById(R.id.install_gearfit2).setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                String url = "https://sleep.urbandroid.org/sleep-%E2%9D%A4-gear-fit-2/#how-to-install";
//                String url = "samsungapps://ProductDetail/com.urbandroid.sleep.gearfit";
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
            i.setClassName(MASTER_PACKAGE, MASTER_PACKAGE +".alarmclock.settings.SmartwatchSettingsActivity");
            startActivity(i);
        } catch (Exception e) {
            try {
                Intent i = new Intent();
                i.setClassName(MASTER_PACKAGE, MASTER_PACKAGE +".alarmclock.AlarmClock");
                startActivity(i);
            } catch (Exception ee) {
                finish();
            }
        }
    }

    private void startMarket() {
        try {
            Intent i = new Intent(Intent.ACTION_VIEW, Uri.parse("market://details?id="+ MASTER_PACKAGE));
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
