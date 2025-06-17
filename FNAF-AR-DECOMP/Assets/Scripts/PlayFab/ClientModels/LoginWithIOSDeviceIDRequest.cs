using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class LoginWithIOSDeviceIDRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<bool> CreateAccount;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string DeviceId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string DeviceModel;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string EncryptedRequest;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.ClientModels.GetPlayerCombinedInfoRequestParams InfoRequestParameters;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string OS;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string PlayerSecret;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string TitleId;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LoginWithIOSDeviceIDRequest()
        {
        
        }
    
    }

}
