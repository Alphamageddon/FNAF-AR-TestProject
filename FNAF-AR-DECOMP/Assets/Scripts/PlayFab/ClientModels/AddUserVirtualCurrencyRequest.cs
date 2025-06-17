using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class AddUserVirtualCurrencyRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Amount;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string VirtualCurrency;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AddUserVirtualCurrencyRequest()
        {
        
        }
    
    }

}
