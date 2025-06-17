using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class ValidateAmazonReceiptRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string CatalogVersion;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string CurrencyCode;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int PurchasePrice;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ReceiptId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string UserId;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ValidateAmazonReceiptRequest()
        {
        
        }
    
    }

}
