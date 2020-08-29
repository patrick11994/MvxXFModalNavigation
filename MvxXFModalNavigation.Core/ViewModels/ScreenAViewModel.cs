using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace MvxXFModalNavigation.Core.ViewModels
{
    public class ScreenAViewModel : MvxViewModel
    {
        public ScreenAViewModel(IMvxNavigationService navigationService)
        {
            NavigateToScreenBCommand = new MvxCommand(() => navigationService.Navigate<ScreenBViewModel>());
        }

        public IMvxCommand NavigateToScreenBCommand { get; }
    }
}
