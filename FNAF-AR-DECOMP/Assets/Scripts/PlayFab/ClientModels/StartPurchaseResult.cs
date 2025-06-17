using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class StartPurchaseResult : PlayFabResultCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<PlayFab.ClientModels.CartItem> Contents;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string OrderId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<PlayFab.ClientModels.PaymentOption> PaymentOptions;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, int> VirtualCurrencyBalances;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public StartPurchaseResult()
        {
        
        }
    
    }

}
