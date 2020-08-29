using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace MvxXFModalNavigation.Core.ViewModels
{
    public class ScreenBViewModel : MvxViewModel
    {
        public ScreenBViewModel(IMvxNavigationService navigationService)
        {
            NavigateToScreenCCommand = new MvxCommand(() => navigationService.Navigate<ScreenCViewModel>());
        }

        public IMvxCommand NavigateToScreenCCommand { get; }
    }
}
