using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class GetLeaderboardForUsersCharactersResult : PlayFabResultCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<PlayFab.ClientModels.CharacterLeaderboardEntry> Leaderboard;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetLeaderboardForUsersCharactersResult()
        {
        
        }
    
    }

}
