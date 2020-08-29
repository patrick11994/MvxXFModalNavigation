
using Foundation;
using MvvmCross.Forms.Platforms.Ios.Core;

namespace MvxXFModalNavigation.iOS
{

    [Register("AppDelegate")]
    public partial class AppDelegate : MvxFormsApplicationDelegate<MvxFormsIosSetup<Core.App, App>, Core.App, App>
    {
    }
}
