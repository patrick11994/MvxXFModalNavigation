using MvvmCross.Forms.Platforms.Uap.Core;
using MvvmCross.Forms.Platforms.Uap.Views;

namespace MvxXFModalNavigation.UWP
{

    public sealed partial class App : UWPApplication
    {

    }

    public abstract class UWPApplication : MvxWindowsApplication<MvxFormsWindowsSetup<MvxXFModalNavigation.Core.App, MvxXFModalNavigation.App>, MvxXFModalNavigation.Core.App, MvxXFModalNavigation.App, MainPage>
    {
    }
}
