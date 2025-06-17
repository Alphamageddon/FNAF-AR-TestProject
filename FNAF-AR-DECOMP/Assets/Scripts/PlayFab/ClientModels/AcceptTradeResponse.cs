using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class AcceptTradeResponse : PlayFabResultCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.ClientModels.TradeInfo Trade;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AcceptTradeResponse()
        {
        
        }
    
    }

}
