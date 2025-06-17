using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class ValidateGooglePlayPurchaseResult : PlayFabResultCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<PlayFab.ClientModels.PurchaseReceiptFulfillment> Fulfillments;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ValidateGooglePlayPurchaseResult()
        {
        
        }
    
    }

}
