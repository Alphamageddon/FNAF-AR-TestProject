using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class DeviceDisplayData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.GameObject devicesParent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TMPro.TextMeshProUGUI devicesDisplayNum;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Master.MasterDomain masterDomain;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DeviceDisplayData(Master.MasterDomain masterDomain, UnityEngine.GameObject devicesParent, TMPro.TextMeshProUGUI devicesDisplayNum)
        {
            val_1 = new System.Object();
            this.devicesDisplayNum = devicesDisplayNum;
            this.masterDomain = masterDomain;
            this.devicesParent = val_1;
        }
    
    }

}
