using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class NintendoSwitchPlayFabIdPair : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string NintendoSwitchDeviceId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string PlayFabId;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public NintendoSwitchPlayFabIdPair()
        {
        
        }
    
    }

}
