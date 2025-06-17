using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class GetPlayerStatisticVersionsResult : PlayFabResultCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<PlayFab.ClientModels.PlayerStatisticVersion> StatisticVersions;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetPlayerStatisticVersionsResult()
        {
        
        }
    
    }

}
