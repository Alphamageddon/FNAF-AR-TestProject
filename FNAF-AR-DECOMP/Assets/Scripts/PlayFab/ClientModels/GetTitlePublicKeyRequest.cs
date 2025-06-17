using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class GetTitlePublicKeyRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string TitleId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string TitleSharedSecret;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetTitlePublicKeyRequest()
        {
        
        }
    
    }

}
