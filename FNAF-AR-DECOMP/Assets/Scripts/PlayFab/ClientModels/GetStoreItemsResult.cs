using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class GetStoreItemsResult : PlayFabResultCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string CatalogVersion;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.ClientModels.StoreMarketingModel MarketingData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<PlayFab.ClientModels.SourceType> Source;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<PlayFab.ClientModels.StoreItem> Store;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string StoreId;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetStoreItemsResult()
        {
        
        }
    
    }

}
