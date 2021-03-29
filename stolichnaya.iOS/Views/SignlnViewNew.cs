using System;
using Loymax.Module.SignIn.iOS.Views;
using ObjCRuntime;
using UIKit;
using Loymax.Core.iOS.Presenters.Attributes;
using Loymax.Module.SignIn.ViewModels;

namespace stolichnaya.iOS.Views
{
    [SidebarPresentation]
    public class SignlnViewNew : SignInView
    {
        protected override void ConfigureViews()
        {
            base.ConfigureViews();
            NavigationItem.LeftBarButtonItem = null;
        }
        

    };
    

}
