using UnityEngine;

namespace PlayFab.MultiplayerModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class JoinMatchmakingTicketRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.MultiplayerModels.MatchmakingPlayer Member;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string QueueName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string TicketId;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public JoinMatchmakingTicketRequest()
        {
        
        }
    
    }

}
