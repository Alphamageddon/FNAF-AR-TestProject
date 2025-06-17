using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class GetPurchaseResult : PlayFabResultCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string OrderId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string PaymentProvider;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.DateTime PurchaseDate;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string TransactionId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string TransactionStatus;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetPurchaseResult()
        {
        
        }
    
    }

}
