using UnityEngine;

namespace PlayFab.MultiplayerModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class MatchmakingPlayerWithTeamAssignment : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.MultiplayerModels.MatchmakingPlayerAttributes Attributes;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.MultiplayerModels.EntityKey Entity;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string TeamId;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MatchmakingPlayerWithTeamAssignment()
        {
        
        }
    
    }

}
