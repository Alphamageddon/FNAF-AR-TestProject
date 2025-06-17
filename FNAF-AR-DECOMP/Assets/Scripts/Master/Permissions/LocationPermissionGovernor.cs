using UnityEngine;

namespace Master.Permissions
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class LocationPermissionGovernor : IActivatePermissionsDelegate
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _masterEvents;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.Permissions.IQueryPermissionsAdapter _queryPermissionsAdapter;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.Permissions.IActivatePermissionsAdapter _activatePermissionsAdapter;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action _success;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool listenForPause;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _shouldUpdateActivatePermissionsAdapter;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ActivatePermissions(System.Action success)
        {
            this._success = success;
            this.AttemptToActivatePermission();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void EnsurePermissions(System.Action success)
        {
            this._success = success;
            this.QueryPermissions();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void UpdateAction()
        {
            if(this._shouldUpdateActivatePermissionsAdapter == false)
            {
                    return;
            }
            
            var val_2 = 0;
            val_2 = val_2 + 1;
            this._activatePermissionsAdapter.Update();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void DisplayBlockingDialog()
        {
            Game.Localization.LocalizationDomain.Instance.Localization.GetInterfaceAsync(callback:  new System.Action<Game.Localization.ILocalization>(object:  this, method:  System.Void Master.Permissions.LocationPermissionGovernor::<DisplayBlockingDialog>b__9_0(Game.Localization.ILocalization localization)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnClick()
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            this._queryPermissionsAdapter.OpenSettings();
            this.listenForPause = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void HandleUpdateAfterPause(bool paused)
        {
            if(this.listenForPause == false)
            {
                    return;
            }
            
            if(paused == true)
            {
                    return;
            }
            
            this.listenForPause = false;
            this.QueryPermissions();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(Master.EventExposer masterEvents)
        {
            this._masterEvents = masterEvents;
            this._queryPermissionsAdapter = new Master.Permissions.AndroidQueryPermissionsAdapter();
            this._activatePermissionsAdapter = new Master.Permissions.AndroidActivateLocationPermissionAdapter();
            var val_5 = 0;
            val_5 = val_5 + 1;
            this._queryPermissionsAdapter.Setup(masterEvents:  masterEvents);
            var val_6 = 0;
            val_6 = val_6 + 1;
            this._activatePermissionsAdapter.Setup(activatePermissionsDelegate:  this, masterEvents:  masterEvents);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            if(this._queryPermissionsAdapter != null)
            {
                    var val_2 = 0;
                val_2 = val_2 + 1;
                this._queryPermissionsAdapter.Teardown();
            }
            
            this._masterEvents = 0;
            this._queryPermissionsAdapter = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void CompleteTask()
        {
            this._shouldUpdateActivatePermissionsAdapter = false;
            if(this._success == null)
            {
                    return;
            }
            
            this._success.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AttemptToActivatePermission()
        {
            this._shouldUpdateActivatePermissionsAdapter = true;
            var val_2 = 0;
            val_2 = val_2 + 1;
            this._activatePermissionsAdapter.Execute();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void QueryPermissions()
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            if(this._queryPermissionsAdapter.HasGPSPermissions() != false)
            {
                    if(this._success == null)
            {
                    return;
            }
            
                this._success.Invoke();
                return;
            }
            
            this.DisplayBlockingDialog();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LocationPermissionGovernor()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void <DisplayBlockingDialog>b__9_0(Game.Localization.ILocalization localization)
        {
            var val_9 = 0;
            val_9 = val_9 + 1;
            string val_2 = localization.GetLocalizedString(localizedStringId:  "ui_location_permission_required_final_title", originalString:  "GPS Permission Required");
            var val_10 = 0;
            val_10 = val_10 + 1;
            string val_4 = localization.GetLocalizedString(localizedStringId:  "ui_location_permission_required_final_body", originalString:  "Where are you? You cannot play without GPS permission");
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
            
            .positiveButtonText = localization.GetLocalizedString(localizedStringId:  "ui_fab_btn_label_settings", originalString:  "Open Settings");
            .positiveButtonAction = new System.Action(object:  this, method:  System.Void Master.Permissions.LocationPermissionGovernor::OnClick());
            this._masterEvents.GenericDialogRequest(genericDialogData:  val_7);
        }
    
    }

}
