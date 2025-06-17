using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class DeviceInfoRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, object> Info;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DeviceInfoRequest()
        {
        
        }
    
    }

}
