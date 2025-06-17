using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class UserSettings : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool GatherDeviceInfo;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool GatherFocusInfo;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool NeedsAttribution;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UserSettings()
        {
        
        }
    
    }

}
