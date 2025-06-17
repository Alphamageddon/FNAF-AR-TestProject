using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class ConfirmPurchaseRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string OrderId;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ConfirmPurchaseRequest()
        {
        
        }
    
    }

}
