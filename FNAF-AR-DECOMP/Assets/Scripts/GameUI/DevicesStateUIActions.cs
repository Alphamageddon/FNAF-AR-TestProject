using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class DevicesStateUIActions : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.DialogHandler_Devices dialogHandler_devices;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.MasterDomain _masterDomain;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowConfirmationDialog(string deviceId)
        {
            this.dialogHandler_devices.ShowConfirmDialog(deviceId:  deviceId);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ActivateDevice(string id)
        {
            this._masterDomain.serverDomain.deviceRequester.ActivateDevice(deviceConfigId:  id);
            this._masterDomain.devicesDomain.AllPlayerDevices.ActivateDevice(id:  id);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Awake()
        {
            this._masterDomain = Master.MasterDomain.GetDomain();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DevicesStateUIActions()
        {
        
        }
    
    }

}
