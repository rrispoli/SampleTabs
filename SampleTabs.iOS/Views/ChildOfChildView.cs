using UIKit;
using MvvmCross.iOS.Views;
using SampleTabs.Core.ViewModels;

namespace SampleTabs.iOS.Views
{
    public class ChildOfChildView : MvxViewController<ChildOfChildViewModel>
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            Title = "ChildOfChild";
            EdgesForExtendedLayout = UIRectEdge.None;
            View.BackgroundColor = UIColor.Red;
        }
    }
}