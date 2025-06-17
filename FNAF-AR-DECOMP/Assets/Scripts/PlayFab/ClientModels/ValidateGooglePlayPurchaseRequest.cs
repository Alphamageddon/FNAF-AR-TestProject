using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class ValidateGooglePlayPurchaseRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string CatalogVersion;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string CurrencyCode;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<uint> PurchasePrice;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ReceiptJson;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Signature;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ValidateGooglePlayPurchaseRequest()
        {
        
        }
    
    }

}
