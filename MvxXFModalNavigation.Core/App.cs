using MvvmCross.IoC;
using MvvmCross.ViewModels;
using MvxXFModalNavigation.Core.ViewModels;

namespace MvxXFModalNavigation.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<HomeViewModel>();
        }
    }
}
