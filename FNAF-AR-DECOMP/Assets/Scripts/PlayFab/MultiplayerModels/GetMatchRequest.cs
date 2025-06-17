using UnityEngine;

namespace PlayFab.MultiplayerModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class GetMatchRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool EscapeObject;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string MatchId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string QueueName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool ReturnMemberAttributes;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetMatchRequest()
        {
        
        }
    
    }

}
