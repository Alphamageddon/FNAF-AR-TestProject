using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class LoginWithSteamRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<bool> CreateAccount;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string EncryptedRequest;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.ClientModels.GetPlayerCombinedInfoRequestParams InfoRequestParameters;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string PlayerSecret;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string SteamTicket;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string TitleId;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LoginWithSteamRequest()
        {
        
        }
    
    }

}
