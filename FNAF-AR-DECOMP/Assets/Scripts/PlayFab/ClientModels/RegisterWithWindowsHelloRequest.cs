using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class RegisterWithWindowsHelloRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string DeviceName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string EncryptedRequest;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.ClientModels.GetPlayerCombinedInfoRequestParams InfoRequestParameters;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string PlayerSecret;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string PublicKey;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string TitleId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string UserName;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public RegisterWithWindowsHelloRequest()
        {
        
        }
    
    }

}
