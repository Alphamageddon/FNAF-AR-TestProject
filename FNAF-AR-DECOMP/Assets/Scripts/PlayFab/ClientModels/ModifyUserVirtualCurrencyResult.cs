using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class ModifyUserVirtualCurrencyResult : PlayFabResultCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Balance;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int BalanceChange;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string PlayFabId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string VirtualCurrency;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ModifyUserVirtualCurrencyResult()
        {
        
        }
    
    }

}
