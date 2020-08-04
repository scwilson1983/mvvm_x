using MvvmCross.ViewModels;

namespace mvvm_x.Core.ViewModels
{
    public class TipSummaryViewModel : MvxViewModel<TipSummaryNavigationParameters>
    {
        double _subTotal;
        public double SubTotal 
        {
            get => _subTotal;
            set
            {
                _subTotal = value;
                RaisePropertyChanged(() => SubTotal);
            }
        }

        public override void Prepare(TipSummaryNavigationParameters parameter)
        {
            SubTotal = parameter.SubTotal;
        }
    }

    public class TipSummaryNavigationParameters
    {
        public double SubTotal { get; set; }
    }
}
