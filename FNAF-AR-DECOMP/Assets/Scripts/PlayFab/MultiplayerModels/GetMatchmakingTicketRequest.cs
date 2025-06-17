using UnityEngine;

namespace PlayFab.MultiplayerModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class GetMatchmakingTicketRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool EscapeObject;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string QueueName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string TicketId;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetMatchmakingTicketRequest()
        {
        
        }
    
    }

}
