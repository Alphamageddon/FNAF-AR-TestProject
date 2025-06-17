using UnityEngine;

namespace Game.SeasonalEvents
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SeasonalEventMechanics
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<string> SequentialRewardsIds;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<string> StoreSaleIds;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<string> StoreSkinIds;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<string> StoreId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<string> SeasonalAssetGroups;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SeasonalEventMechanics()
        {
            this.SequentialRewardsIds = new System.Collections.Generic.List<System.String>();
            this.StoreSaleIds = new System.Collections.Generic.List<System.String>();
            this.StoreSkinIds = new System.Collections.Generic.List<System.String>();
            this.StoreId = new System.Collections.Generic.List<System.String>();
            this.SeasonalAssetGroups = new System.Collections.Generic.List<System.String>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Clear()
        {
            this.SequentialRewardsIds.Clear();
            this.StoreSaleIds.Clear();
            this.StoreSkinIds.Clear();
            this.StoreId.Clear();
            this.SeasonalAssetGroups.Clear();
        }
    
    }

}
