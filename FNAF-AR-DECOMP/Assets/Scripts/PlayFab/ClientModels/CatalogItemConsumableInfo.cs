using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class CatalogItemConsumableInfo : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<uint> UsageCount;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<uint> UsagePeriod;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string UsagePeriodGroup;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CatalogItemConsumableInfo()
        {
        
        }
    
    }

}
