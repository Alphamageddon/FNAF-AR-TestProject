using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class PayForPurchaseRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Currency;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string OrderId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ProviderName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ProviderTransactionId;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PayForPurchaseRequest()
        {
        
        }
    
    }

}
