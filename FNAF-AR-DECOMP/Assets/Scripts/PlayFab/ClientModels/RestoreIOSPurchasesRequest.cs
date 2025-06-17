using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class RestoreIOSPurchasesRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string CatalogVersion;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ReceiptData;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public RestoreIOSPurchasesRequest()
        {
        
        }
    
    }

}
