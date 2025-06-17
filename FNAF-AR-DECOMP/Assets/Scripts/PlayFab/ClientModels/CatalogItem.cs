using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class CatalogItem : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.ClientModels.CatalogItemBundleInfo Bundle;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool CanBecomeCharacter;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string CatalogVersion;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.ClientModels.CatalogItemConsumableInfo Consumable;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.ClientModels.CatalogItemContainerInfo Container;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string CustomData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Description;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string DisplayName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int InitialLimitedEditionCount;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsLimitedEdition;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsStackable;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsTradable;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ItemClass;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ItemId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ItemImageUrl;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, uint> RealCurrencyPrices;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<string> Tags;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, uint> VirtualCurrencyPrices;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CatalogItem()
        {
        
        }
    
    }

}
