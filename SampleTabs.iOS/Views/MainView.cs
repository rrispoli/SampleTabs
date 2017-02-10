using System.Collections.Generic;
using MvvmCross.iOS.Views;
using UIKit;
using SampleTabs.Core.ViewModels;
using MvvmCross.Core.ViewModels;

namespace SampleTabs.iOS.Views
{
    public class MainView : MvxTabBarViewController<MainViewModel>
    {
        private bool _constructed;

        public MainView()
        {
            _constructed = true;

            // need this additional call to ViewDidLoad because UIkit creates the view before the C# hierarchy has been constructed
            ViewDidLoad();
        }

        public override void ViewDidLoad()
        {
            if (!_constructed)
                return;

            base.ViewDidLoad();

            Title = "SampleTabs";
            EdgesForExtendedLayout = UIRectEdge.None;
            View.BackgroundColor = UIColor.White;

            var viewControllers = new List<UIViewController>();
            for (int i = 0; i < ViewModel.MyViewModels.Count; i++)
                viewControllers.Add(CreateTabFor(i, ViewModel.MyViewModels[i].Name, null, ViewModel.MyViewModels[i]));

            ViewControllers = viewControllers.ToArray();
            CustomizableViewControllers = new UIViewController[] { };

            //If you want to start at specific tab
            //SelectedViewController = ViewControllers[ViewModel.CurrentPage];
        }

        private UIViewController CreateTabFor(int index, string title, string imageName, IMvxViewModel viewModel)
        {
            //If you know only the viewmodel type, you need to instantiate it
            //var request = new MvxViewModelRequest(viewModelType, null, null, null);
            //var viewModel = Mvx.Resolve<IMvxViewModelLoader>().LoadViewModel(request, null);

            var controller = new UINavigationController();
            var screen = this.CreateViewControllerFor(viewModel) as UIViewController;
            screen.Title = title;

            //screen.TabBarItem = new UITabBarItem(title, UIImage.FromBundle(imageName), index);

            //Just for example, use the previous line
            screen.TabBarItem = new UITabBarItem(UITabBarSystemItem.Search, index);

            controller.PushViewController(screen, true);
            return controller;
        }
    }
}