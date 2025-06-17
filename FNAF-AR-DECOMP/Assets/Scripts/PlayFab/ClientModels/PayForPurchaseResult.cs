using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class PayForPurchaseResult : PlayFabResultCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public uint CreditApplied;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string OrderId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ProviderData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ProviderToken;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string PurchaseConfirmationPageURL;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string PurchaseCurrency;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public uint PurchasePrice;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<PlayFab.ClientModels.TransactionStatus> Status;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, int> VCAmount;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, int> VirtualCurrency;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PayForPurchaseResult()
        {
        
        }
    
    }

}
