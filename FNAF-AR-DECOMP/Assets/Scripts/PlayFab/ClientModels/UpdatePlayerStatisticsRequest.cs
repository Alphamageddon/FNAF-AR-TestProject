using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class UpdatePlayerStatisticsRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<PlayFab.ClientModels.StatisticUpdate> Statistics;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UpdatePlayerStatisticsRequest()
        {
        
        }
    
    }

}
