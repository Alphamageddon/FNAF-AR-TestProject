using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class LinkIOSDeviceIDRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string DeviceId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string DeviceModel;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<bool> ForceLink;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string OS;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LinkIOSDeviceIDRequest()
        {
        
        }
    
    }

}
