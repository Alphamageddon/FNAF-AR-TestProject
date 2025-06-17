using UnityEngine;

namespace GetSocialSdk.Core
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal class NotificationListenerProxy : JavaInterfaceProxy
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly GetSocialSdk.Core.NotificationListener _onNotification;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public NotificationListenerProxy(GetSocialSdk.Core.NotificationListener listener)
        {
            this._onNotification = listener;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool onNotificationReceived(UnityEngine.AndroidJavaObject ajo, bool wasClicked)
        {
            object val_1 = 34290;
            if(this._onNotification == null)
            {
                    return false;
            }
            
            val_1 = new System.Object();
            GetSocialSdk.Core.Notification val_2 = val_1.ParseFromAJO(ajo:  ajo);
            wasClicked = wasClicked;
            return this._onNotification.Invoke(notification:  val_1, wasClicked:  wasClicked);
        }
    
    }

}
