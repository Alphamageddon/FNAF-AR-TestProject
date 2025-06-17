using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class GetUserInventoryResult : PlayFabResultCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<PlayFab.ClientModels.ItemInstance> Inventory;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, int> VirtualCurrency;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, PlayFab.ClientModels.VirtualCurrencyRechargeTime> VirtualCurrencyRechargeTimes;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetUserInventoryResult()
        {
        
        }
    
    }

}
