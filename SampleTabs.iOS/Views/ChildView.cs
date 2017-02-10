using MvvmCross.iOS.Views;
using SampleTabs.Core.ViewModels;
using System;
using UIKit;

namespace SampleTabs.iOS.Views
{
    public class ChildView : MvxViewController<ChildViewModel>
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            NavigationController.SetNavigationBarHidden(true, false);
            EdgesForExtendedLayout = UIRectEdge.None;
            View.BackgroundColor = UIColor.FromRGB(new Random().Next(0, 255), new Random().Next(0, 255), new Random().Next(0, 255));
        }
    }
}