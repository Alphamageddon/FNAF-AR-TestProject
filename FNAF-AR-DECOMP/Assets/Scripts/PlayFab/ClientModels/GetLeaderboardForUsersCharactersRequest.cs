using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class GetLeaderboardForUsersCharactersRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int MaxResultsCount;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string StatisticName;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetLeaderboardForUsersCharactersRequest()
        {
        
        }
    
    }

}
