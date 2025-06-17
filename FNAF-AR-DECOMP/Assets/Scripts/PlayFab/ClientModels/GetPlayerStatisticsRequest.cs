using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class GetPlayerStatisticsRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<string> StatisticNames;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<PlayFab.ClientModels.StatisticNameVersion> StatisticNameVersions;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetPlayerStatisticsRequest()
        {
        
        }
    
    }

}
