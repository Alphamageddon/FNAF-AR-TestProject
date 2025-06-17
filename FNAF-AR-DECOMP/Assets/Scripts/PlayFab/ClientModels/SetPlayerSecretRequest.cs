using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class SetPlayerSecretRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string EncryptedRequest;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string PlayerSecret;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SetPlayerSecretRequest()
        {
        
        }
    
    }

}
