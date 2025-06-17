using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class OpenTradeRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<string> AllowedPlayerIds;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<string> OfferedInventoryInstanceIds;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<string> RequestedCatalogItemIds;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public OpenTradeRequest()
        {
        
        }
    
    }

}
