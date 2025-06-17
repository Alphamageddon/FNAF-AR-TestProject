using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class GetPaymentTokenResult : PlayFabResultCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string OrderId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ProviderToken;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetPaymentTokenResult()
        {
        
        }
    
    }

}
