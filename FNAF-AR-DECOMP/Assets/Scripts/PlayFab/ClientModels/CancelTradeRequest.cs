using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class CancelTradeRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string TradeId;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CancelTradeRequest()
        {
        
        }
    
    }

}
