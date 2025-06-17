using UnityEngine;

namespace Game.MapMode
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class LocationServiceGovernor : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject _mapDisplayParent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _locationServiceEnabled;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TheGame.GameDisplayData.DisplayType _displayType;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _isDialogShowing;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.Permissions.IQueryPermissionsAdapter _adapter;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _shouldListenForCaptureFocus;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _isMapMode;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool shouldWaitForReturn;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _masterEvents;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void DisplayBlockingDialog()
        {
            GetInterfaceAsync(callback:  new System.Action<Game.Localization.ILocalization>(object:  this, method:  System.Void Game.MapMode.LocationServiceGovernor::<DisplayBlockingDialog>b__9_0(Game.Localization.ILocalization localization)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDisplayChange(TheGame.GameDisplayData gameDisplayData)
        {
            if(gameDisplayData.currentDisplay != 0)
            {
                    return;
            }
            
            this._isMapMode = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnClick()
        {
            this._isDialogShowing = false;
            this._mapDisplayParent.SetActive(value:  false);
            var val_2 = 0;
            val_2 = val_2 + 1;
            this._adapter.OpenLocationSettings();
            this._shouldListenForCaptureFocus = true;
            this.shouldWaitForReturn = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Awake()
        {
            Master.MasterDomain val_1 = Master.MasterDomain.GetDomain();
            this._masterEvents = val_1.eventExposer;
            Master.Permissions.AndroidQueryPermissionsAdapter val_2 = new Master.Permissions.AndroidQueryPermissionsAdapter();
            this._adapter = val_2;
            var val_5 = 0;
            val_5 = val_5 + 1;
            val_2.Setup(masterEvents:  this._masterEvents);
            this._masterEvents.add_GameDisplayChange(value:  new System.Action<TheGame.GameDisplayData>(object:  this, method:  System.Void Game.MapMode.LocationServiceGovernor::OnDisplayChange(TheGame.GameDisplayData gameDisplayData)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnDestroy()
        {
            this._masterEvents = 0;
            this._adapter = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            if(this.shouldWaitForReturn != false)
            {
                    return;
            }
            
            if(this._isMapMode == false)
            {
                    return;
            }
            
            if(UnityEngine.Input.location.isEnabledByUser == true)
            {
                    return;
            }
            
            if(this._isDialogShowing == true)
            {
                    return;
            }
            
            this._isDialogShowing = true;
            this.DisplayBlockingDialog();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnApplicationFocus(bool isFocus)
        {
            if((this._shouldListenForCaptureFocus != false) && (isFocus != false))
            {
                    this._mapDisplayParent.SetActive(value:  true);
                this._shouldListenForCaptureFocus = false;
            }
            
            this.shouldWaitForReturn = false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LocationServiceGovernor()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void <DisplayBlockingDialog>b__9_0(Game.Localization.ILocalization localization)
        {
            var val_9 = 0;
            val_9 = val_9 + 1;
            string val_2 = localization.GetLocalizedString(localizedStringId:  "ui_location_permission_required_final_title", originalString:  "Location Services Disabled");
            var val_10 = 0;
            val_10 = val_10 + 1;
            string val_4 = localization.GetLocalizedString(localizedStringId:  "ui_location_permission_required_final_body", originalString:  "Please enable location services!");
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
            
            .positiveButtonText = localization.GetLocalizedString(localizedStringId:  "ui_permissions_required_settings_instructions_btn_settings", originalString:  "Open Settings");
            .positiveButtonAction = new System.Action(object:  this, method:  System.Void Game.MapMode.LocationServiceGovernor::OnClick());
            this._masterEvents.GenericDialogRequest(genericDialogData:  val_7);
        }
    
    }

}
