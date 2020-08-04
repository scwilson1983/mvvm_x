using mvvm_x.Core.ViewModels;
using MvvmCross.Forms.Views;
using Xamarin.Forms.Xaml;

namespace mvvm_x.Forms.UI.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TipSummaryView : MvxContentPage<TipSummaryViewModel>
    {
        public TipSummaryView()
        {
            InitializeComponent();
        }
    }
}