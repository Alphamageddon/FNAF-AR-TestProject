using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class RefreshPSNAuthTokenRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string AuthCode;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<int> IssuerId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string RedirectUri;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public RefreshPSNAuthTokenRequest()
        {
        
        }
    
    }

}
