using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class LoginWithFacebookRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string AccessToken;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<bool> CreateAccount;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string EncryptedRequest;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.ClientModels.GetPlayerCombinedInfoRequestParams InfoRequestParameters;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string PlayerSecret;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string TitleId;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LoginWithFacebookRequest()
        {
        
        }
    
    }

}
