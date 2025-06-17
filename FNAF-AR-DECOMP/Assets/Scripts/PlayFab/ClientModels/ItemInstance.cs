using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class ItemInstance : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Annotation;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<string> BundleContents;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string BundleParent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string CatalogVersion;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, string> CustomData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string DisplayName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<System.DateTime> Expiration;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ItemClass;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ItemId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ItemInstanceId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<System.DateTime> PurchaseDate;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<int> RemainingUses;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string UnitCurrency;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public uint UnitPrice;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<int> UsesIncrementedBy;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ItemInstance()
        {
        
        }
    
    }

}
