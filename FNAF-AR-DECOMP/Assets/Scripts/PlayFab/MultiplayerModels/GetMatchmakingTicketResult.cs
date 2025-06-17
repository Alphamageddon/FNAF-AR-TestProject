using UnityEngine;

namespace PlayFab.MultiplayerModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class GetMatchmakingTicketResult : PlayFabResultCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<PlayFab.MultiplayerModels.CancellationReason> CancellationReason;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string CancellationReasonString;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.DateTime Created;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.MultiplayerModels.EntityKey Creator;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int GiveUpAfterSeconds;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string MatchId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<PlayFab.MultiplayerModels.MatchmakingPlayer> Members;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<PlayFab.MultiplayerModels.EntityKey> MembersToMatchWith;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string QueueName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Status;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string TicketId;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetMatchmakingTicketResult()
        {
        
        }
    
    }

}
