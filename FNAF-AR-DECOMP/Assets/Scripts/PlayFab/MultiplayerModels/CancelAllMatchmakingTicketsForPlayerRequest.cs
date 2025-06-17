using UnityEngine;

namespace PlayFab.MultiplayerModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class CancelAllMatchmakingTicketsForPlayerRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.MultiplayerModels.EntityKey Entity;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string QueueName;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CancelAllMatchmakingTicketsForPlayerRequest()
        {
        
        }
    
    }

}
