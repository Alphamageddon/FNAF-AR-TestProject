using UnityEngine;

namespace PlayFab.MultiplayerModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class GetQueueStatisticsResult : PlayFabResultCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<uint> NumberOfPlayersMatching;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.MultiplayerModels.Statistics TimeToMatchStatisticsInSeconds;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetQueueStatisticsResult()
        {
        
        }
    
    }

}
