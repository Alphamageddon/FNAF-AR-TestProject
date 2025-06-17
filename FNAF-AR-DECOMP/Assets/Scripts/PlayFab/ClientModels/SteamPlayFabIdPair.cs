using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class SteamPlayFabIdPair : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string PlayFabId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string SteamStringId;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SteamPlayFabIdPair()
        {
        
        }
    
    }

}
