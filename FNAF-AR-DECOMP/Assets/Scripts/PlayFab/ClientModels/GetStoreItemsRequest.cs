using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class GetStoreItemsRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string CatalogVersion;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string StoreId;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetStoreItemsRequest()
        {
        
        }
    
    }

}
