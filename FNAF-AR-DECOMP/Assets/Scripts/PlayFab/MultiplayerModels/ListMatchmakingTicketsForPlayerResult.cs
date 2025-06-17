using UnityEngine;

namespace PlayFab.MultiplayerModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class ListMatchmakingTicketsForPlayerResult : PlayFabResultCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<string> TicketIds;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ListMatchmakingTicketsForPlayerResult()
        {
        
        }
    
    }

}
