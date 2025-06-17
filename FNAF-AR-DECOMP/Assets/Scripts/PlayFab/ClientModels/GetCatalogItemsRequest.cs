using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class GetCatalogItemsRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string CatalogVersion;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetCatalogItemsRequest()
        {
        
        }
    
    }

}
