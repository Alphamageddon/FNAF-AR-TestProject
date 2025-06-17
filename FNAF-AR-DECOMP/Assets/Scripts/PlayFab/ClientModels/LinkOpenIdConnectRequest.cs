using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class LinkOpenIdConnectRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ConnectionId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<bool> ForceLink;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string IdToken;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LinkOpenIdConnectRequest()
        {
        
        }
    
    }

}
