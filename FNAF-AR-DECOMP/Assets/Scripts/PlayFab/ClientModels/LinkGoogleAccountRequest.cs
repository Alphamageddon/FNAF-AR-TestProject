using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class LinkGoogleAccountRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<bool> ForceLink;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ServerAuthCode;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LinkGoogleAccountRequest()
        {
        
        }
    
    }

}
