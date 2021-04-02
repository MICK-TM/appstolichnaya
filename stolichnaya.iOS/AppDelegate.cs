namespace stolichnaya.iOS
{
    using Foundation;
    using JASidePanel.Navigation.iOS;
    using Loymax.Core.iOS;
    using UIKit;

    [Register(nameof(AppDelegate))]
    public class AppDelegate : BaseAppDelegate
    {
        public override BaseIosSetup MvxIosSetup()
        {
            return new Setup(this, new JASidebarViewPresenter(this, this.Window));
        }

        public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
        {
#if !DEBUG
            Firebase.Core.App.Configure();
#endif
            return base.FinishedLaunching(application, launchOptions);
        }
    }
}