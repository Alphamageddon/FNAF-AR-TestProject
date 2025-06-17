using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class GetCharacterLeaderboardRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string CharacterType;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<int> MaxResultsCount;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int StartPosition;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string StatisticName;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetCharacterLeaderboardRequest()
        {
        
        }
    
    }

}
