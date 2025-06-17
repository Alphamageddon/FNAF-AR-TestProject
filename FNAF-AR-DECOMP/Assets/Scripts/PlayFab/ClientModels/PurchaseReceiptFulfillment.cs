using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class PurchaseReceiptFulfillment : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<PlayFab.ClientModels.ItemInstance> FulfilledItems;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string RecordedPriceSource;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string RecordedTransactionCurrency;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<uint> RecordedTransactionTotal;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PurchaseReceiptFulfillment()
        {
        
        }
    
    }

}
