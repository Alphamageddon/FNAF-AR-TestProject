using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class ValidateWindowsReceiptRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string CatalogVersion;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string CurrencyCode;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public uint PurchasePrice;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Receipt;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ValidateWindowsReceiptRequest()
        {
        
        }
    
    }

}
