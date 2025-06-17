using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class GetLeaderboardRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<int> MaxResultsCount;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.ClientModels.PlayerProfileViewConstraints ProfileConstraints;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int StartPosition;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string StatisticName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<int> Version;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetLeaderboardRequest()
        {
        
        }
    
    }

}
