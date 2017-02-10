
----------------------------------------------------------------------------------------------------
09 fev 17 00:08 Add Projects
----------------------------------------------------------------------------------------------------
SampleTabs.Core project successfully added. (template NinjaCoder.Core.zip)
SampleTabs.Droid project successfully added. (template NinjaCoder.Droid.zip)
SampleTabs.iOS project successfully added. (template NinjaCoder.iOS.zip)

----------------------------------------------------------------------------------------------------
Options
----------------------------------------------------------------------------------------------------
MvvmCross framework selected.
NUnit testing framework selected.
Moq mocking framework selected.
StartUp Project set to Droid
iOS View Type Xib selected.
Pre Release Ninja Nuget Packages selected.

MainViewModel.cs added to SampleTabs.Core project (template=MvxSampleDataViewModel.t4)
MainView.cs added to SampleTabs.iOS project (template=SampleData\Xib\View.t4)
MainView.cs added to SampleTabs.Droid project (template=SampleDataView.t4)

----------------------------------------------------------------------------------------------------
Nuget Commands
----------------------------------------------------------------------------------------------------

Install-Package MvvmCross -FileConflictAction Overwrite -ProjectName SampleTabs.Core 
Install-Package Scorchio.NinjaCoder.MvvmCross.Core –IncludePrerelease  -FileConflictAction Overwrite -ProjectName SampleTabs.Core 
Install-Package MvvmCross -FileConflictAction Overwrite -ProjectName SampleTabs.Droid 
Install-Package Scorchio.NinjaCoder.MvvmCross –IncludePrerelease  -FileConflictAction ignore -ProjectName SampleTabs.Droid 
Install-Package MvvmCross -FileConflictAction Overwrite -ProjectName SampleTabs.iOS 
Install-Package Scorchio.NinjaCoder.MvvmCross –IncludePrerelease  -FileConflictAction ignore -ProjectName SampleTabs.iOS 


----------------------------------------------------------------------------------------------------
Ninja Coder for MvvmCross and Xamarin Forms v4.2.1
----------------------------------------------------------------------------------------------------

All feedback welcome, please get in touch via twitter.

Issues Log http://github.com/asudbury/NinjaCoderForMvvmCross/issues

Thanks

@asudbury
