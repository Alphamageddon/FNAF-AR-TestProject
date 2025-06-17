using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class GetPurchaseRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string OrderId;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetPurchaseRequest()
        {
        
        }
    
    }

}
