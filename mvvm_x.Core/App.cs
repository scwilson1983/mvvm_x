using mvvm_x.Core.Services;
using mvvm_x.Core.ViewModels;
using MvvmCross;
using MvvmCross.ViewModels;

namespace mvvm_x.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            Mvx.IoCProvider.RegisterType<ICalculationService, CalculationService>();

            RegisterAppStart<TipViewModel>();
        }
    }
}
