using Acr.UserDialogs;
using MvvmCross.Platform;
using MvvmCross.Platform.IoC;
using PaymillWrapper;

namespace SimplePaymentApp.Core
{
    public class App : MvvmCross.Core.ViewModels.MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterNavigationServiceAppStart<ViewModels.PaymentViewModel>();

            Mvx.RegisterSingleton<IUserDialogs>(() => UserDialogs.Instance);

        //   PaymillContext paymillContext = new PaymillContext("2718c669834a4d41ac31a8dcef22fe0c");
        }
    }
}
