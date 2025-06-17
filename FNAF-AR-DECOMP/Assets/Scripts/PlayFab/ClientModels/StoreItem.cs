using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class StoreItem : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public object CustomData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<uint> DisplayPosition;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ItemId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, uint> RealCurrencyPrices;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, uint> VirtualCurrencyPrices;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public StoreItem()
        {
        
        }
    
    }

}
