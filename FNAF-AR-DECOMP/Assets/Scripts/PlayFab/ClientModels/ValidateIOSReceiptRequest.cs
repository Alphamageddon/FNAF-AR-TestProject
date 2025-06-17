using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class ValidateIOSReceiptRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string CatalogVersion;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string CurrencyCode;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int PurchasePrice;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ReceiptData;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ValidateIOSReceiptRequest()
        {
        
        }
    
    }

}
