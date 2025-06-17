using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class TradeInfo : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<string> AcceptedInventoryInstanceIds;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string AcceptedPlayerId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<string> AllowedPlayerIds;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<System.DateTime> CancelledAt;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<System.DateTime> FilledAt;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<System.DateTime> InvalidatedAt;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<string> OfferedCatalogItemIds;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<string> OfferedInventoryInstanceIds;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string OfferingPlayerId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<System.DateTime> OpenedAt;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<string> RequestedCatalogItemIds;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<PlayFab.ClientModels.TradeStatus> Status;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string TradeId;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TradeInfo()
        {
        
        }
    
    }

}
