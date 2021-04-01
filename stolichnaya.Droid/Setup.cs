namespace stolichnaya.Droid
{
    using Loymax.Core;
    using Loymax.Core.Droid;
    using Loymax.Core.Droid.Implements;
    using Loymax.Core.Modules;
    using MvvmCross.Logging;
    using stolichnaya.Core;

    public class Setup : BaseDroidSetup
    {
        protected override App CreateLxApp()
        {
            return new CoreApp();
        }

        protected override void AddPlatformModules(ILxLoaderModuleRegistry registry)
        {
            base.AddPlatformModules(registry);
            registry.Register<Loymax.Module.Merchants.Droid.MerchantsDroidModule>();
            registry.Register<Loymax.Module.ShoppingList.Droid.ShoppingListDroidModule>();
            registry.Register<Loymax.Module.Notifications.Droid.NotificationsDroidModule>();
            registry.Register<Loymax.Module.PurchaseHistory.Droid.PurchaseHistoryDroidModule>();
            registry.Register<Loymax.Module.SignIn.Droid.SignInDroidModule>();
            registry.Register<Loymax.Module.SignUp.Droid.SignUpDroidModule>();
            registry.Register<Loymax.Module.ResetPassword.Droid.ResetPasswordDroidModule>();
            registry.Register<Loymax.Module.Offers.Droid.OffersDroidModule>();
            registry.Register<Loymax.Module.Profile.Droid.ProfileDroidModule>();
            registry.Register<Loymax.Module.SupportService.Droid.SupportServiceDroidModule>();
#if !RELEASE
            registry.Register<Loymax.Module.ClientSettings.Droid.ClientSettingsDroidModule>();
#endif

        }
        protected override IMvxLogProvider CreateLogProvider()
        {
#if !RELEASE
            return new LogProvider();
#else
            return base.CreateLogProvider();
#endif
        }
    }
}