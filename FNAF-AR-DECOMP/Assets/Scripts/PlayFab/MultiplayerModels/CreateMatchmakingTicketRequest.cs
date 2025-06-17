using UnityEngine;

namespace PlayFab.MultiplayerModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class CreateMatchmakingTicketRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.MultiplayerModels.MatchmakingPlayer Creator;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int GiveUpAfterSeconds;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<PlayFab.MultiplayerModels.EntityKey> MembersToMatchWith;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string QueueName;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CreateMatchmakingTicketRequest()
        {
        
        }
    
    }

}
