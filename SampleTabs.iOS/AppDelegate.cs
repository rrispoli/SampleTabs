using Foundation;
using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Platform;
using MvvmCross.Platform;
using UIKit;

namespace SampleTabs.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : MvxApplicationDelegate
    {
        private UIWindow window;

        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            this.window = new UIWindow(UIScreen.MainScreen.Bounds);

            Setup setup = new Setup(this, this.window);
            setup.Initialize();

            IMvxAppStart startup = Mvx.Resolve<IMvxAppStart>();
            startup.Start();

            this.window.MakeKeyAndVisible();

            ApplyStyle();

            return true;
        }

        private void ApplyStyle()
        {
            //UINavigationBar
            UINavigationBar.Appearance.BarTintColor = UIColor.FromRGB(244, 67, 54);
            UINavigationBar.Appearance.TintColor = UIColor.White;
            var navigationBarTextAttributes = UINavigationBar.Appearance.GetTitleTextAttributes();
            navigationBarTextAttributes.TextColor = UIColor.White;
            UINavigationBar.Appearance.SetTitleTextAttributes(navigationBarTextAttributes);

            //UITabBar
            UITabBar.Appearance.BarTintColor = UIColor.FromRGB(244, 67, 54);
            UITabBar.Appearance.TintColor = UIColor.White;
            UITabBar.Appearance.SelectedImageTintColor = UIColor.White;

            //UILabel
            UILabel.Appearance.TextColor = UIColor.FromRGB(244, 67, 54);
        }

    }
}