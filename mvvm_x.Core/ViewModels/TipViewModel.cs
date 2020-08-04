using mvvm_x.Core.Services;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System.Threading.Tasks;

namespace mvvm_x.Core.ViewModels
{
    public class TipViewModel : MvxViewModel
    {
        readonly ICalculationService _calculationService;
        readonly IMvxNavigationService _navigationService;

        public TipViewModel(ICalculationService calculationService, IMvxNavigationService navigationService)
        {
            _calculationService = calculationService;
            _navigationService = navigationService;
            ViewSummaryCommand = new MvxAsyncCommand(async () => await _navigationService.Navigate<TipSummaryViewModel, TipSummaryNavigationParameters>(new TipSummaryNavigationParameters { SubTotal = SubTotal }));
        }

        public IMvxAsyncCommand ViewSummaryCommand { get; set; }

        public override async Task Initialize()
        {
            await base.Initialize();

            _subTotal = 100;
            _generosity = 10;

            Recalculate();
        }

        private double _subTotal;
        public double SubTotal
        {
            get => _subTotal;
            set
            {
                _subTotal = value;
                RaisePropertyChanged(() => SubTotal);

                Recalculate();
            }
        }

        private int _generosity;
        public int Generosity
        {
            get => _generosity;
            set
            {
                _generosity = value;
                RaisePropertyChanged(() => Generosity);

                Recalculate();
            }
        }

        private double _tip;
        public double Tip
        {
            get => _tip;
            set
            {
                _tip = value;
                RaisePropertyChanged(() => Tip);
            }
        }

        private void Recalculate()
        {
            Tip = _calculationService.TipAmount(SubTotal, Generosity);
        }
    }
}
