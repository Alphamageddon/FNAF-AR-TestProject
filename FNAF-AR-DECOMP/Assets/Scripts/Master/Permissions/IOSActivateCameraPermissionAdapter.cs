using UnityEngine;

namespace Master.Permissions
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class IOSActivateCameraPermissionAdapter : IActivatePermissionsAdapter
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string UI_CAMERA_PERMISSION_TITLE_KEY = "ui_camera_permission_required_title";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string UI_CAMERA_PERMISSION_MESSAGE_KEY = "ui_camera_permission_rationale_body";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string UI_CAMERA_PERMISSION_BUTTON_KEY = "ui_camera_permission_button_key";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _masterEvents;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.GenericDialogData _iosDialog;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.Startup.IActivatePermissionsDelegate _activatePermissionsDelegate;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _hasAskedYet;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(Master.Startup.IActivatePermissionsDelegate activatePermissionsDelegate, Master.EventExposer masterEvents)
        {
            this._activatePermissionsDelegate = activatePermissionsDelegate;
            this._masterEvents = masterEvents;
            Game.Localization.LocalizationDomain.Instance.Localization.GetInterfaceAsync(callback:  new System.Action<Game.Localization.ILocalization>(object:  this, method:  System.Void Master.Permissions.IOSActivateCameraPermissionAdapter::<Setup>b__7_0(Game.Localization.ILocalization localization)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Execute()
        {
            if(SharedTechAssets.Scripts.IllumixEngine.IxReceivers.IxQuerier_iOS.QueryIfCameraPermissionAskedYet() != false)
            {
                    this._masterEvents.OnReadyToActivateAR();
                var val_3 = 0;
                val_3 = val_3 + 1;
            }
            else
            {
                    this._masterEvents.GenericDialogRequest(genericDialogData:  this._iosDialog);
                return;
            }
            
            this._activatePermissionsDelegate.CompleteTask();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this._activatePermissionsDelegate = 0;
            this._masterEvents = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool ShouldShow()
        {
            bool val_1 = SharedTechAssets.Scripts.IllumixEngine.IxReceivers.IxQuerier_iOS.QueryIfCameraPermissionAskedYet();
            val_1 = (~val_1) & 1;
            return (bool)val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnYes()
        {
            this._masterEvents.add_HandleApplicationFocus(value:  new System.Action<System.Boolean>(object:  this, method:  System.Void Master.Permissions.IOSActivateCameraPermissionAdapter::MasterEventsOnHandleApplicationFocus(bool isFocus)));
            this._masterEvents.OnReadyToActivateAR();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void MasterEventsOnHandleApplicationFocus(bool isFocus)
        {
            if(isFocus == false)
            {
                    return;
            }
            
            this._masterEvents.remove_HandleApplicationFocus(value:  new System.Action<System.Boolean>(object:  this, method:  System.Void Master.Permissions.IOSActivateCameraPermissionAdapter::MasterEventsOnHandleApplicationFocus(bool isFocus)));
            var val_3 = 0;
            val_3 = val_3 + 1;
            this._activatePermissionsDelegate.CompleteTask();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public IOSActivateCameraPermissionAdapter()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void <Setup>b__7_0(Game.Localization.ILocalization localization)
        {
            var val_9 = 0;
            val_9 = val_9 + 1;
            string val_2 = localization.GetLocalizedString(localizedStringId:  "ui_camera_permission_required_title", originalString:  "Camera required");
            var val_10 = 0;
            val_10 = val_10 + 1;
            string val_4 = localization.GetLocalizedString(localizedStringId:  "ui_camera_permission_rationale_body", originalString:  "Access to the Camera is required for the Augmented Reality features of the game. If permission is not enabled, the game will not work.");
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
            .positiveButtonAction = new System.Action(object:  this, method:  System.Void Master.Permissions.IOSActivateCameraPermissionAdapter::OnYes());
            this._iosDialog = val_7;
        }
    
    }

}
