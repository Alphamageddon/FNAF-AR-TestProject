using UnityEngine;

namespace Master.Permissions
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AndroidActivateCameraPermissionAdapter : IActivatePermissionsAdapter
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string UI_CAMERA_PERMISSION_TITLE_KEY = "ui_camera_permission_title_key";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string UI_CAMERA_PERMISSION_MESSAGE_KEY = "ui_camera_permission_message_key";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string UI_CAMERA_PERMISSION_BUTTON_KEY = "ui_camera_permission_button_key";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _masterEvents;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.GenericDialogData _androidDialog;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.Startup.IActivatePermissionsDelegate _activatePermissionsDelegate;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(Master.Startup.IActivatePermissionsDelegate activatePermissionsDelegate, Master.EventExposer masterEvents)
        {
            this._activatePermissionsDelegate = activatePermissionsDelegate;
            this._masterEvents = masterEvents;
            Game.Localization.LocalizationDomain.Instance.Localization.GetInterfaceAsync(callback:  new System.Action<Game.Localization.ILocalization>(object:  this, method:  System.Void Master.Permissions.AndroidActivateCameraPermissionAdapter::<Setup>b__6_0(Game.Localization.ILocalization localization)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Execute()
        {
            if(this.ShouldShow() != false)
            {
                    this._masterEvents.GenericDialogRequest(genericDialogData:  this._androidDialog);
                return;
            }
            
            var val_3 = 0;
            val_3 = val_3 + 1;
            this._activatePermissionsDelegate.CompleteTask();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this._androidDialog = 0;
            this._activatePermissionsDelegate = 0;
            this._masterEvents = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool ShouldShow()
        {
            bool val_1 = UnityEngine.Android.Permission.HasUserAuthorizedPermission(permission:  "android.permission.CAMERA");
            val_1 = (~val_1) & 1;
            return (bool)val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnYes()
        {
            UnityEngine.Android.Permission.RequestUserPermission(permission:  "android.permission.CAMERA");
            this._masterEvents.add_HandleApplicationFocus(value:  new System.Action<System.Boolean>(object:  this, method:  System.Void Master.Permissions.AndroidActivateCameraPermissionAdapter::OnApplicationFocus(bool isFocus)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnApplicationFocus(bool isFocus)
        {
            if(isFocus == false)
            {
                    return;
            }
            
            this._masterEvents.remove_HandleApplicationFocus(value:  new System.Action<System.Boolean>(object:  this, method:  System.Void Master.Permissions.AndroidActivateCameraPermissionAdapter::OnApplicationFocus(bool isFocus)));
            var val_3 = 0;
            val_3 = val_3 + 1;
            this._activatePermissionsDelegate.CompleteTask();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AndroidActivateCameraPermissionAdapter()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void <Setup>b__6_0(Game.Localization.ILocalization localization)
        {
            var val_9 = 0;
            val_9 = val_9 + 1;
            string val_2 = localization.GetLocalizedString(localizedStringId:  "ui_camera_permission_title_key", originalString:  "Camera Explanation");
            var val_10 = 0;
            val_10 = val_10 + 1;
            string val_4 = localization.GetLocalizedString(localizedStringId:  "ui_camera_permission_message_key", originalString:  "The next screen will ask for permission to use the camera. We need this to run Google Play Services for AR (ARCore), which is provided by Google LLC and governed by the <link=\"https://policies.google.com/privacy\"><color=blue>Google Privacy Policy</color></link>.");
            var val_11 = 0;
            val_11 = val_11 + 1;
            GameUI.GenericDialogData val_7 = new GameUI.GenericDialogData();
            if(val_7 != null)
            {
                    .title = val_2;
                .message = val_4;
            }
            else
            {
                    mem[16] = val_2;
                mem[24] = val_4;
            }
            
            .positiveButtonText = localization.GetLocalizedString(localizedStringId:  "ui_camera_permission_button_key", originalString:  "OK");
            .positiveButtonAction = new System.Action(object:  this, method:  System.Void Master.Permissions.AndroidActivateCameraPermissionAdapter::OnYes());
            this._androidDialog = val_7;
        }
    
    }

}
