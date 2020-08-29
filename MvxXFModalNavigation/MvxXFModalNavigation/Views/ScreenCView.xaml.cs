using MvvmCross.Forms.Presenters.Attributes;
using MvvmCross.Forms.Views;
using Xamarin.Forms.Xaml;

namespace MvxXFModalNavigation.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [MvxModalPresentation]
    public partial class ScreenCView : MvxContentPage
    {
        public ScreenCView()
        {
            InitializeComponent();
        }
    }
}