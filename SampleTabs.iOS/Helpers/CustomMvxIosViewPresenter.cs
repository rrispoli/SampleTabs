using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Views;
using MvvmCross.iOS.Views.Presenters;
using MvvmCross.iOS.Views.Presenters.Attributes;
using UIKit;

namespace SampleTabs.iOS.Helpers
{
	//CustomMvxIosViewPresenter to present IMvxTabBarViewController as MvxNavigationController just if it WrapInNavigationController
    public class CustomMvxIosViewPresenter : MvxIosViewPresenter
    {
        public CustomMvxIosViewPresenter(IUIApplicationDelegate applicationDelegate, UIWindow window) : base(applicationDelegate, window)
        {
        }

		protected override void ShowRootViewController(UIViewController viewController, MvxRootPresentationAttribute attribute, MvxViewModelRequest request)
		{
            // check if viewController is a TabBarController and just if WrapInNavigationController in FALSE
            if (viewController is IMvxTabBarViewController tabBarController && attribute.WrapInNavigationController == false)
			{
				TabBarViewController = tabBarController;
				SetWindowRootViewController(viewController);

				CloseMasterNavigationController();
				CloseModalNavigationController();
				CloseSplitViewController();

				return;
			}

			// check if viewController is a SplitViewController
			if (viewController is IMvxSplitViewController splitController)
			{
				SplitViewController = splitController;
				SetWindowRootViewController(viewController);

				CloseMasterNavigationController();
				CloseModalNavigationController();
				CloseTabBarViewController();

				return;
			}

			// check if viewController is trying to initialize a navigation stack
			if (attribute.WrapInNavigationController)
			{
				viewController = CreateNavigationController(viewController);
				MasterNavigationController = viewController as MvxNavigationController;
				SetWindowRootViewController(viewController);

				CloseModalNavigationController();
				CloseTabBarViewController();
				CloseSplitViewController();

				return;
			}

			// last scenario: display the plain viewController as root
			SetWindowRootViewController(viewController);
		}
    }
}