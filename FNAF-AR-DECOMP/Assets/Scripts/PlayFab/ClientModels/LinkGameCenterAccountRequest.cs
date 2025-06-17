using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class LinkGameCenterAccountRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<bool> ForceLink;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string GameCenterId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string PublicKeyUrl;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Salt;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Signature;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Timestamp;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LinkGameCenterAccountRequest()
        {
        
        }
    
    }

}
