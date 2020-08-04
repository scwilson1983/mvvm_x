using Android.App;
using Android.OS;
using MvvmCross.Forms.Platforms.Android.Views;
using MvvmCross.Forms.Platforms.Android.Core;
using mvvm_x.Forms.UI;
using mvvm_x.Core;
using Android.Content.PM;

namespace mvvm_x.Forms.Droid
{
    [Activity(
       Label = "mvvm_x.Forms.Droid",
       Theme = "@style/MyTheme",
       MainLauncher = true,
       ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation,
       LaunchMode = LaunchMode.SingleTask)]
    public class MainActivity : MvxFormsAppCompatActivity<MvxFormsAndroidSetup<App, FormsApp>, App, FormsApp>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;
            base.OnCreate(savedInstanceState);
        }
    }
}