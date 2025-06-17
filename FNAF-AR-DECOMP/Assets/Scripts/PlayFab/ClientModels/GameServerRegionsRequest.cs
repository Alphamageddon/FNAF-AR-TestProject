using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class GameServerRegionsRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string BuildVersion;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string TitleId;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameServerRegionsRequest()
        {
        
        }
    
    }

}
