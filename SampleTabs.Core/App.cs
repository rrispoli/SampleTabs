using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.IoC;
using SampleTabs.Core.ViewModels;

namespace SampleTabs.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            this.CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            this.RegisterAppStart<MainViewModel>();
        }
    }
}