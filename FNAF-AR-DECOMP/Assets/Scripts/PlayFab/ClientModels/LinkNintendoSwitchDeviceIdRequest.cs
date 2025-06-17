using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class LinkNintendoSwitchDeviceIdRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<bool> ForceLink;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string NintendoSwitchDeviceId;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LinkNintendoSwitchDeviceIdRequest()
        {
        
        }
    
    }

}
