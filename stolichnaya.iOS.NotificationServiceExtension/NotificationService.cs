namespace stolichnaya.iOS.NotificationServiceExtension
{
    using System;
    using Foundation;
    using PushNotification.Service.iOS;

    [Register("NotificationService")]
    public class NotificationService : BaseNotificationService
    {
        protected override string IosSharedContainerId => "group.ru.excitesakh.appstolichnyy";
        
        protected NotificationService(IntPtr handle) 
            : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
    }
}
