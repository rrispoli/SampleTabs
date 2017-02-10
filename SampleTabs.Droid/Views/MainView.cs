using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Support.Design.Widget;
using Android.Support.V4.View;
using Android.Support.V7.Widget;
using MvvmCross.Droid.Support.V4;
using MvvmCross.Droid.Support.V7.AppCompat;
using SampleTabs.Core.ViewModels;
using SampleTabs.Droid.Views.Fragments;
using System.Collections.Generic;

namespace SampleTabs.Droid.Views
{
    [Activity(ScreenOrientation = ScreenOrientation.Portrait)]
    public class MainView : MvxCachingFragmentCompatActivity<MainViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.page_main);

            var toolbar = FindViewById<Toolbar>(Resource.Id.main_toolbar);
            SetSupportActionBar(toolbar);
            SupportActionBar.SetDisplayHomeAsUpEnabled(false);
            SupportActionBar.Title = "SampleTabs";

            var viewPager = FindViewById<ViewPager>(Resource.Id.main_view_pager);
            var fragments = new List<MvxCachingFragmentStatePagerAdapter.FragmentInfo>();

            foreach (var myViewModel in ViewModel.MyViewModels)
                fragments.Add(new MvxCachingFragmentStatePagerAdapter.FragmentInfo(myViewModel.Name, typeof(ChildFragment), myViewModel));

            viewPager.Adapter = new MvxCachingFragmentStatePagerAdapter(this, SupportFragmentManager, fragments);

            //If you want to start at specific tab
            //viewPager.SetCurrentItem(ViewModel.CurrentPage, false);

            var tabLayout = FindViewById<TabLayout>(Resource.Id.main_tablayout);
            tabLayout.SetupWithViewPager(viewPager);
        }
    }
}