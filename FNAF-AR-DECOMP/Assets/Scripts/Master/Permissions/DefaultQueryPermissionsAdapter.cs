using UnityEngine;

namespace Master.Permissions
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class DefaultQueryPermissionsAdapter : IQueryPermissionsAdapter
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _masterEvents;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(Master.EventExposer masterEvents)
        {
            this._masterEvents = masterEvents;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this._masterEvents = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool HasCameraPermissions()
        {
            return true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool HasGPSPermissions()
        {
            return true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OpenSettings()
        {
            GameUI.GenericDialogData val_1 = new GameUI.GenericDialogData();
            if(val_1 != null)
            {
                    .title = "Open your Settings";
                .message = "Please navigate to your device\'s application settings page and ensure that both camera permissions and location services are enabled for this game.";
            }
            else
            {
                    mem[16] = "Open your Settings";
                mem[24] = "Please navigate to your device\'s application settings page and ensure that both camera permissions and location services are enabled for this game.";
            }
            
            .positiveButtonText = "Exit Game";
            new System.Action() = new System.Action(object:  this, method:  typeof(Master.Permissions.DefaultQueryPermissionsAdapter).__il2cppRuntimeField_1D0);
            .positiveButtonAction = new System.Action();
            this._masterEvents.GenericDialogRequest(genericDialogData:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OpenLocationSettings()
        {
            this.OpenSettings();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Close()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DefaultQueryPermissionsAdapter()
        {
        
        }
    
    }

}
