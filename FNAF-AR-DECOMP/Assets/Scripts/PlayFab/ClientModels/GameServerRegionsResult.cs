using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class GameServerRegionsResult : PlayFabResultCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<PlayFab.ClientModels.RegionInfo> Regions;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameServerRegionsResult()
        {
        
        }
    
    }

}
