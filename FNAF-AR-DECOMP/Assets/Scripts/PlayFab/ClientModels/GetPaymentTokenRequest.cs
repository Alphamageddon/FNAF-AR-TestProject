using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class GetPaymentTokenRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string TokenProvider;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetPaymentTokenRequest()
        {
        
        }
    
    }

}
