using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class StartPurchaseRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string CatalogVersion;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<PlayFab.ClientModels.ItemPurchaseRequest> Items;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string StoreId;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public StartPurchaseRequest()
        {
        
        }
    
    }

}
