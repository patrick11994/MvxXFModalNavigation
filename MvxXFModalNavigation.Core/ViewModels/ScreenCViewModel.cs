using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace MvxXFModalNavigation.Core.ViewModels
{
    public class ScreenCViewModel : MvxViewModel
    {
        public ScreenCViewModel(IMvxNavigationService navigationService)
        {
            NavigateToScreenDCommand = new MvxCommand(() => navigationService.Navigate<ScreenDViewModel>());
        }

        public IMvxCommand NavigateToScreenDCommand { get; }
    }
}
