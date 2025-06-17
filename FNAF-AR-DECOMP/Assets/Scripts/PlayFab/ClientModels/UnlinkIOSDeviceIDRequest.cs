using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class UnlinkIOSDeviceIDRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string DeviceId;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnlinkIOSDeviceIDRequest()
        {
        
        }
    
    }

}
