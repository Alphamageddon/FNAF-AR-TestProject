using UnityEngine;

namespace PlayFab.MultiplayerModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class GetMultiplayerServerDetailsRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string BuildId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Region;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string SessionId;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetMultiplayerServerDetailsRequest()
        {
        
        }
    
    }

}
