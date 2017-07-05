using MvvmCross.iOS.Views;
using SampleTabs.Core.ViewModels;
using System;
using UIKit;
using MvvmCross.Binding.BindingContext;
using CoreGraphics;

namespace SampleTabs.iOS.Views
{
    public class ChildView : MvxViewController<ChildViewModel>
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            EdgesForExtendedLayout = UIRectEdge.None;
            //View.BackgroundColor = UIColor.FromRGB(new Random().Next(0, 255), new Random().Next(0, 255), new Random().Next(0, 255));
            View.BackgroundColor = UIColor.DarkGray;

            var button = new UIButton(new CGRect(200, 200, 80, 40));
            button.SetTitle("GO", UIControlState.Normal);
            Add(button);

            var set = this.CreateBindingSet<ChildView, ChildViewModel>();
            set.Bind(button).To(vm => vm.GoToChildCommand);
            set.Apply();
        }
    }
}