using UnityEngine;

namespace PlayFab.MultiplayerModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class MatchmakingPlayer : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.MultiplayerModels.MatchmakingPlayerAttributes Attributes;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.MultiplayerModels.EntityKey Entity;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MatchmakingPlayer()
        {
        
        }
    
    }

}
