using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class PurchaseItemRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string CatalogVersion;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string CharacterId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ItemId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Price;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string StoreId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string VirtualCurrency;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PurchaseItemRequest()
        {
        
        }
    
    }

}
