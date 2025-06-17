using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class CatalogItemBundleInfo : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<string> BundledItems;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<string> BundledResultTables;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, uint> BundledVirtualCurrencies;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CatalogItemBundleInfo()
        {
        
        }
    
    }

}
