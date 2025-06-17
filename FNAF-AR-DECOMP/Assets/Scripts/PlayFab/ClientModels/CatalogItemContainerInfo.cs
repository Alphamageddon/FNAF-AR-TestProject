using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class CatalogItemContainerInfo : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<string> ItemContents;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string KeyItemId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<string> ResultTableContents;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, uint> VirtualCurrencyContents;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CatalogItemContainerInfo()
        {
        
        }
    
    }

}
