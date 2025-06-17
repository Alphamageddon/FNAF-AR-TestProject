using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class AcceptTradeRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<string> AcceptedInventoryInstanceIds;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string OfferingPlayerId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string TradeId;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AcceptTradeRequest()
        {
        
        }
    
    }

}
