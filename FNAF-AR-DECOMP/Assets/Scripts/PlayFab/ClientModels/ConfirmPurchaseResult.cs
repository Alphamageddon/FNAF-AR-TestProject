using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class ConfirmPurchaseResult : PlayFabResultCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<PlayFab.ClientModels.ItemInstance> Items;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string OrderId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.DateTime PurchaseDate;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ConfirmPurchaseResult()
        {
        
        }
    
    }

}
