using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class LinkAndroidDeviceIDRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string AndroidDevice;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string AndroidDeviceId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<bool> ForceLink;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string OS;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LinkAndroidDeviceIDRequest()
        {
        
        }
    
    }

}
