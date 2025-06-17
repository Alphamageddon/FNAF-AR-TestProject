using UnityEngine;

namespace PlayFab.MultiplayerModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class RequestMultiplayerServerRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string BuildId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<string> InitialPlayers;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<string> PreferredRegions;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string SessionCookie;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string SessionId;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public RequestMultiplayerServerRequest()
        {
        
        }
    
    }

}
