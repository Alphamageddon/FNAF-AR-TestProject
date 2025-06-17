using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class UserTwitchInfo : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string TwitchId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string TwitchUserName;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UserTwitchInfo()
        {
        
        }
    
    }

}
