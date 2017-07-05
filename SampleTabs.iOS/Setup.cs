using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Platform;
using MvvmCross.iOS.Views.Presenters;
using SampleTabs.iOS.Helpers;
using UIKit;

namespace SampleTabs.iOS
{
    public class Setup : MvxIosSetup
    {
        public Setup(MvxApplicationDelegate applicationDelegate, UIWindow window) : base(applicationDelegate, window)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new Core.App();
        }

        protected override IMvxIosViewPresenter CreatePresenter()
        {
            return new CustomMvxIosViewPresenter(ApplicationDelegate, Window);
        }
    }
}