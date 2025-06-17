using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class CartItem : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Description;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string DisplayName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ItemClass;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ItemId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ItemInstanceId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, uint> RealCurrencyPrices;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, uint> VCAmount;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, uint> VirtualCurrencyPrices;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CartItem()
        {
        
        }
    
    }

}
