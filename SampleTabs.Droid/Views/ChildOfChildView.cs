using Android.App;
using Android.OS;
using Android.Support.V7.Widget;
using Android.Content.PM;
using MvvmCross.Droid.Support.V7.AppCompat;
using SampleTabs.Core.ViewModels;
using Android.Views;

namespace SampleTabs.Droid.Views
{
    [Activity(ScreenOrientation = ScreenOrientation.Portrait)]
    public class ChildOfChildView : MvxCachingFragmentCompatActivity<ChildOfChildViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.page_child_of_child);

            var toolbar = FindViewById<Toolbar>(Resource.Id.simple_toolbar);
            SetSupportActionBar(toolbar);
            SupportActionBar.SetDisplayHomeAsUpEnabled(true);
            SupportActionBar.Title = "ChildOfChild";
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Android.Resource.Id.Home:
                    this.OnBackPressed();
                    return true;
            }

            return base.OnOptionsItemSelected(item);
        }
    }
}