namespace stolichnaya.Core
{
    using Loymax.Core;
    using Loymax.Core.Modules;
    using Loymax.Core.Services.Interfaces;
    using Loymax.Core.Settings.Client;
    using Loymax.Module.Offers.ViewModels;
    using Loymax.Module.Profile.ViewModels;
    using MvvmCross;
    using System;

     public class CoreApp : App 
     {
        private static ICurrentUserContext UserContext => Mvx.IoCProvider.GetSingleton<ICurrentUserContext>();

        public override Type MainViewModelType
        {
            get
            {
                if (UserContext.CurrentUser.IsAuth && UserContext.CurrentUser.IfExistCards)
                    return typeof(ProfileCardViewModel);
                return typeof(OffersViewModel);
            }
        }

         protected override IClientEnvironmentSettings CreateClientSettings()
         {
             return new ClientEnvironmentSettings(typeof(CoreApp).Assembly,
 #if DEBUG
                 BuildEnvironmentType.Development

 #elif ADHOC
                 BuildEnvironmentType.Staging
 #else
                 BuildEnvironmentType.Production
 #endif
             );
         }

         public override void LoadModules(ILxModuleManager moduleManager)
         {
             base.LoadModules(moduleManager);
             moduleManager.EnsurePluginLoaded<Loymax.Module.Merchants.MerchantsModule>();
             moduleManager.EnsurePluginLoaded<Loymax.Module.ShoppingList.ShoppingListModule>();
             moduleManager.EnsurePluginLoaded<Loymax.Module.Notifications.NotificationsModule>();
             moduleManager.EnsurePluginLoaded<Loymax.Module.PurchaseHistory.PurchaseHistoryModule>();
             moduleManager.EnsurePluginLoaded<Loymax.Module.SignIn.SignInModule>();
             moduleManager.EnsurePluginLoaded<Loymax.Module.SignUp.SignUpModule>();
             moduleManager.EnsurePluginLoaded<Loymax.Module.ResetPassword.ResetPasswordModule>();
             moduleManager.EnsurePluginLoaded<Loymax.Module.Offers.OffersModule>();
             moduleManager.EnsurePluginLoaded<Loymax.Module.Profile.ProfileModule>();
             moduleManager.EnsurePluginLoaded<Loymax.Module.SupportService.SupportServiceModule>();

         }
     }
 } 
   /* using Loymax.Core.Services.Interfaces;
    using Loymax.Core.ViewModels.Locators;
    using Loymax.Module.Offers.ViewModels;
    using Loymax.Module.Profile.ViewModels;
    using Loymax.Module.PurchaseHistory.ViewModels;
    using MvvmCross;
    using MvvmCross.IoC;
    using stolichnaya.Core.ViewModels;

    public class CoreApp : App
    {
        /* public override Type MainViewModelType => typeof(Loymax.Module.Profile.ViewModels.ProfileCardViewModel); */


       /* protected override ICurrentUserContext UserContext => Mvx.IoCProvider.GetSingleton<ICurrentUserContext>();

        public override Type MainViewModelType
        {
            get 
            {
                if (UserContext.CurrentUser.IsAuth && UserContext.CurrentUser.IfExistCards)
                    return typeof(ProfileAttachCardViewModel);
                return typeof(ProfileCardViewModel);
            } 
    }

    public override void LoadModules(ILxModuleManager moduleManager)
    {
        base.LoadModules(moduleManager);
        moduleManager.EnsurePluginLoaded<Loymax.Module.Merchants.MerchantsModule>();
        moduleManager.EnsurePluginLoaded<Loymax.Module.ShoppingList.ShoppingListModule>();
        moduleManager.EnsurePluginLoaded<Loymax.Module.Notifications.NotificationsModule>();
        moduleManager.EnsurePluginLoaded<Loymax.Module.PurchaseHistory.PurchaseHistoryModule>();
        moduleManager.EnsurePluginLoaded<Loymax.Module.SignIn.SignInModule>();
        moduleManager.EnsurePluginLoaded<Loymax.Module.SignUp.SignUpModule>();
        moduleManager.EnsurePluginLoaded<Loymax.Module.ResetPassword.ResetPasswordModule>();
        moduleManager.EnsurePluginLoaded<Loymax.Module.Offers.OffersModule>();
        moduleManager.EnsurePluginLoaded<Loymax.Module.Profile.ProfileModule>();
        moduleManager.EnsurePluginLoaded<Loymax.Module.SupportService.SupportServiceModule>();

    }
}
}*/