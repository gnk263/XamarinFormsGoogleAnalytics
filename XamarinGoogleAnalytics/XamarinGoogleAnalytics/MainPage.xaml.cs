using Plugin.GoogleAnalytics;
using System;

using Xamarin.Forms;

namespace XamarinGoogleAnalytics
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            GoogleAnalytics.Current.Tracker.SendView("MaiinPage");
            GoogleAnalytics.Current.Tracker.SendEvent("Category", "Action", "Label", 0);

            DisplayAlert("Info", "情報を送信しました。", "OK");
        }
    }
}
