using Foundation;
using UIKit;
using Plugin.GoogleAnalytics;

namespace XamarinGoogleAnalytics.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            GoogleAnalytics.Current.Config.TrackingId = "UA-xxxxxxx";
            GoogleAnalytics.Current.Config.AppId = "XamarinGoogleAnalytics";
            GoogleAnalytics.Current.Config.AppName = "Googleアナリティクスサンプル";
            GoogleAnalytics.Current.Config.AppVersion = "1.0.0";
            GoogleAnalytics.Current.InitTracker();

            global::Xamarin.Forms.Forms.Init();
            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
    }
}
