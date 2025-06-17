using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class PaymentOption : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Currency;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public uint Price;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ProviderName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public uint StoreCredit;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PaymentOption()
        {
        
        }
    
    }

}
