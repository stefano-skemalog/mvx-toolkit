using MvvmCross.IoC;
using MvvmCross.ViewModels;

namespace MvxTemplate.Forms
{
    public class CoreApp : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
            .EndingWith("Service")
            .AsInterfaces()
            .RegisterAsLazySingleton();

            RegisterAppStart<MainPageViewModel>();
        }
    }
}