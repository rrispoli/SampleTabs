using Android.App;
using Android.Content.PM;
using MvvmCross.Droid.Views;

namespace SampleTabs.Droid
{
    [Activity(Label = "SampleTabs", MainLauncher = true, Icon = "@drawable/Icon", ClearTaskOnLaunch = true, NoHistory = true, Theme = "@style/SampleTabsTheme.SplashScreen", ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashScreen : MvxSplashScreenActivity
    {
        public SplashScreen() : base(Resource.Layout.page_splash_screen)
        {
        }
    }
}