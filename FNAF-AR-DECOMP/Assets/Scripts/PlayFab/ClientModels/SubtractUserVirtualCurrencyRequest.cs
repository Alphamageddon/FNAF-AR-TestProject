using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class SubtractUserVirtualCurrencyRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Amount;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string VirtualCurrency;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SubtractUserVirtualCurrencyRequest()
        {
        
        }
    
    }

}
