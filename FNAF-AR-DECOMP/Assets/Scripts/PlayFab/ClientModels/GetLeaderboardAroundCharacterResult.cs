using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class GetLeaderboardAroundCharacterResult : PlayFabResultCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<PlayFab.ClientModels.CharacterLeaderboardEntry> Leaderboard;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetLeaderboardAroundCharacterResult()
        {
        
        }
    
    }

}
