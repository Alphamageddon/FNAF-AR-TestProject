using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class DeviceDisplayHandler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.DeviceDisplayData _deviceDisplayData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _lastDisplayedDeviceNumber;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DeviceDisplayHandler(GameUI.DeviceDisplayData deviceDisplayData)
        {
            this._lastDisplayedDeviceNumber = 0;
            this._deviceDisplayData = deviceDisplayData;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update()
        {
            this.UpdateDeviceNumText();
            this.UpdateDeviceParentVisibility();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateDeviceNumText()
        {
            if(this._lastDisplayedDeviceNumber == this._deviceDisplayData.masterDomain.devicesDomain.AllPlayerDevices.TotalDevicesAvailable)
            {
                    return;
            }
            
            this._deviceDisplayData.devicesDisplayNum.text = this._deviceDisplayData.masterDomain.devicesDomain.AllPlayerDevices.TotalDevicesAvailable.ToString();
            this._lastDisplayedDeviceNumber = this._deviceDisplayData.masterDomain.devicesDomain.AllPlayerDevices.TotalDevicesAvailable;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateDeviceParentVisibility()
        {
            if(this._deviceDisplayData != null)
            {
                goto label_0;
            }
            
            this._deviceDisplayData = this._deviceDisplayData;
            if(this._deviceDisplayData == null)
            {
                goto label_1;
            }
            
            label_0:
            DisplayType val_4 = 0;
            val_4 = this._deviceDisplayData.masterDomain.theGameDomain.gameDisplayChanger.IsDisplayType(displayType:  val_4);
            this._deviceDisplayData.devicesParent.SetActive(value:  val_4);
            return;
            label_1:
        }
    
    }

}
