using UnityEngine;

namespace GetSocialSdk.Ui
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class NotificationActionButtonClickListenerProxy : JavaInterfaceProxy
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly GetSocialSdk.Ui.NotificationCenterViewBuilder.ActionButtonClickListener _actionButtonClickListener;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public NotificationActionButtonClickListenerProxy(GetSocialSdk.Ui.NotificationCenterViewBuilder.ActionButtonClickListener actionButtonClickListener)
        {
            this._actionButtonClickListener = actionButtonClickListener;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool onActionButtonClicked(UnityEngine.AndroidJavaObject notificationAJO, UnityEngine.AndroidJavaObject actionButtonAJO)
        {
            UnityEngine.Debug.Log(message:  ">>>>>>> XXXX");
            GetSocialSdk.Core.Notification val_1 = new GetSocialSdk.Core.Notification();
            GetSocialSdk.Core.Notification val_2 = val_1.ParseFromAJO(ajo:  notificationAJO);
            if(this._actionButtonClickListener == null)
            {
                    return false;
            }
            
            return this._actionButtonClickListener.Invoke(notification:  val_1, actionButton:  new GetSocialSdk.Core.ActionButton().ParseFromAJO(ajo:  actionButtonAJO));
        }
    
    }

}
