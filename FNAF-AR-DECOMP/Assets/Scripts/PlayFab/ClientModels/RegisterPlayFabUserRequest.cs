using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class RegisterPlayFabUserRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string DisplayName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Email;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string EncryptedRequest;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.ClientModels.GetPlayerCombinedInfoRequestParams InfoRequestParameters;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Password;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string PlayerSecret;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<bool> RequireBothUsernameAndEmail;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string TitleId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Username;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public RegisterPlayFabUserRequest()
        {
        
        }
    
    }

}
