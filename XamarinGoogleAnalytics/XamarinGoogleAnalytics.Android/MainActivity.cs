using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Plugin.GoogleAnalytics;

namespace XamarinGoogleAnalytics.Droid
{
    [Activity(Label = "XamarinGoogleAnalytics", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            GoogleAnalytics.Current.Config.TrackingId = "UA-xxxxxxx";
            GoogleAnalytics.Current.Config.AppId = "XamarinGoogleAnalytics";
            GoogleAnalytics.Current.Config.AppName = "Googleアナリティクスサンプル";
            GoogleAnalytics.Current.Config.AppVersion = "1.0.0";
            GoogleAnalytics.Current.InitTracker();

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
        }
    }
}

