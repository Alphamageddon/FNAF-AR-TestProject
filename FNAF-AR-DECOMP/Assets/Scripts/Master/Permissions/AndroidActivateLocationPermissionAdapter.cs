using UnityEngine;

namespace Master.Permissions
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AndroidActivateLocationPermissionAdapter : IActivatePermissionsAdapter
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string TITLE_KEY = "ui_dialog_gps_explanation_title";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string BODY_KEY = "ui_dialog_gps_explanation_message";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string OK_KEY = "ui_dialog_gps_explanation_ok";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string GPS_TITLE = "GPS Explanation";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string GPS_BODY = "The next screen will ask for permission to use location. We use location services for in-game Map functionality.";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string GPS_OK = "OK";
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
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Execute()
        {
            if(this.ShouldShow() != false)
            {
                    this.ShowDialog();
                return;
            }
            
            var val_3 = 0;
            val_3 = val_3 + 1;
            this._activatePermissionsDelegate.CompleteTask();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ShowDialog()
        {
            Game.Localization.LocalizationDomain.Instance.Localization.GetInterfaceAsync(callback:  new System.Action<Game.Localization.ILocalization>(object:  this, method:  System.Void Master.Permissions.AndroidActivateLocationPermissionAdapter::<ShowDialog>b__11_0(Game.Localization.ILocalization localization)));
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
        private void OnYes()
        {
            UnityEngine.Android.Permission.RequestUserPermission(permission:  "android.permission.ACCESS_FINE_LOCATION");
            this._masterEvents.add_HandleApplicationFocus(value:  new System.Action<System.Boolean>(object:  this, method:  System.Void Master.Permissions.AndroidActivateLocationPermissionAdapter::OnApplicationFocus(bool isFocus)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool ShouldShow()
        {
            bool val_1 = UnityEngine.Android.Permission.HasUserAuthorizedPermission(permission:  "android.permission.ACCESS_FINE_LOCATION");
            val_1 = (~val_1) & 1;
            return (bool)val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnApplicationFocus(bool isFocus)
        {
            if(isFocus == false)
            {
                    return;
            }
            
            this._masterEvents.remove_HandleApplicationFocus(value:  new System.Action<System.Boolean>(object:  this, method:  System.Void Master.Permissions.AndroidActivateLocationPermissionAdapter::OnApplicationFocus(bool isFocus)));
            var val_3 = 0;
            val_3 = val_3 + 1;
            this._activatePermissionsDelegate.CompleteTask();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AndroidActivateLocationPermissionAdapter()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void <ShowDialog>b__11_0(Game.Localization.ILocalization localization)
        {
            GameUI.GenericDialogData val_1 = new GameUI.GenericDialogData();
            var val_9 = 0;
            val_9 = val_9 + 1;
            .title = localization.GetLocalizedString(localizedStringId:  "ui_dialog_gps_explanation_title", originalString:  "GPS Explanation");
            var val_10 = 0;
            val_10 = val_10 + 1;
            .message = localization.GetLocalizedString(localizedStringId:  "ui_dialog_gps_explanation_message", originalString:  "The next screen will ask for permission to use location. We use location services for in-game Map functionality.");
            var val_11 = 0;
            val_11 = val_11 + 1;
            .positiveButtonText = localization.GetLocalizedString(localizedStringId:  "ui_dialog_gps_explanation_ok", originalString:  "OK");
            .positiveButtonAction = new System.Action(object:  this, method:  System.Void Master.Permissions.AndroidActivateLocationPermissionAdapter::OnYes());
            this._androidDialog = val_1;
            this._masterEvents.GenericDialogRequest(genericDialogData:  val_1);
        }
    
    }

}
