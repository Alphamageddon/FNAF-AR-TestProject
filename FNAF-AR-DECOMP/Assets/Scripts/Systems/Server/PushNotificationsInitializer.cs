using UnityEngine;

namespace Systems.Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PushNotificationsInitializer
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string PUSH_NOTIFICATION_PERMISSION_ASKED = "PushNotificationPermissionAsked";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string DIALOG_TITLE = "ui_pushNotificationRationale_dialog_title";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string DIALOG_TEXT = "ui_pushNotificationRationale_dialog_text";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string DIALOG_OK = "ui_pushNotificationRationale_dialog_ok";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Server.Requester.RegisterForPushNotificationsRequester _requester;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(Game.Server.Requester.RegisterForPushNotificationsRequester requester)
        {
            this._requester = requester;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RegisterForPushNotifications()
        {
            this._requester.RegisterForPushNotifications();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowPushRationaleDialogBeforeEnable()
        {
            Game.Localization.LocalizationDomain val_1 = Game.Localization.LocalizationDomain.Instance;
            var val_11 = 0;
            val_11 = val_11 + 1;
            .title = val_1.ILocalization.GetLocalizedString(localizedStringId:  "ui_pushNotificationRationale_dialog_title", originalString:  "ui_pushNotificationRationale_dialog_title");
            var val_12 = 0;
            val_12 = val_12 + 1;
            .message = val_1.ILocalization.GetLocalizedString(localizedStringId:  "ui_pushNotificationRationale_dialog_text", originalString:  "ui_pushNotificationRationale_dialog_text");
            var val_13 = 0;
            val_13 = val_13 + 1;
            .positiveButtonText = val_1.ILocalization.GetLocalizedString(localizedStringId:  "ui_pushNotificationRationale_dialog_ok", originalString:  "ui_pushNotificationRationale_dialog_ok");
            .positiveButtonAction = new System.Action(object:  this, method:  System.Void Systems.Server.PushNotificationsInitializer::OnYes());
            Master.MasterDomain val_10 = Master.MasterDomain.GetDomain();
            val_10.eventExposer.GenericDialogRequest(genericDialogData:  new GameUI.GenericDialogData());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update()
        {
            if(this._requester == null)
            {
                    return;
            }
            
            this._requester.Update();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnYes()
        {
            UnityEngine.PlayerPrefs.SetInt(key:  "PushNotificationPermissionAsked", value:  (UnityEngine.PlayerPrefs.GetInt(key:  "PushNotificationPermissionAsked", defaultValue:  0)) + 1);
            this.RegisterForPushNotifications();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PushNotificationsInitializer()
        {
        
        }
    
    }

}
