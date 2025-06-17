using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class UnlinkAndroidDeviceIDRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string AndroidDeviceId;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnlinkAndroidDeviceIDRequest()
        {
        
        }
    
    }

}
