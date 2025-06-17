using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class TwitchPlayFabIdPair : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string PlayFabId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string TwitchId;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TwitchPlayFabIdPair()
        {
        
        }
    
    }

}
