using UnityEngine;

namespace PlayFab.MultiplayerModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class CreateServerMatchmakingTicketRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int GiveUpAfterSeconds;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<PlayFab.MultiplayerModels.MatchmakingPlayer> Members;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string QueueName;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CreateServerMatchmakingTicketRequest()
        {
        
        }
    
    }

}
