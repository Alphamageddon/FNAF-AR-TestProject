using UnityEngine;

namespace GetSocialSdk.Ui
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class NotificationClickListenerProxy : JavaInterfaceProxy
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly GetSocialSdk.Ui.NotificationCenterViewBuilder.NotificationClickListener _notificationClickListener;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public NotificationClickListenerProxy(GetSocialSdk.Ui.NotificationCenterViewBuilder.NotificationClickListener notificationClickListener)
        {
            this._notificationClickListener = notificationClickListener;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool onNotificationClicked(UnityEngine.AndroidJavaObject notificationAJO)
        {
            UnityEngine.Debug.Log(message:  ">>>>>>> XXXX");
            GetSocialSdk.Core.Notification val_1 = new GetSocialSdk.Core.Notification();
            GetSocialSdk.Core.Notification val_2 = val_1.ParseFromAJO(ajo:  notificationAJO);
            if(this._notificationClickListener == null)
            {
                    return (bool)this._notificationClickListener;
            }
            
            return this._notificationClickListener.Invoke(notification:  val_1);
        }
    
    }

}
