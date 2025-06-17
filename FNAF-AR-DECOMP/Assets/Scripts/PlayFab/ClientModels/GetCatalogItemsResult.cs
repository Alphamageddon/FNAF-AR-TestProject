using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class GetCatalogItemsResult : PlayFabResultCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<PlayFab.ClientModels.CatalogItem> Catalog;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetCatalogItemsResult()
        {
        
        }
    
    }

}
