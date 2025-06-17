using UnityEngine;

namespace Game.TheGame.Data
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class RewardDataV2
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Game.TheGame.Data.RewardItem> modRewardList;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Game.TheGame.Data.RewardItem> currencyRewardList;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<Game.TheGame.Data.RewardItem>> animatronicRewardTable;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Game.TheGame.Data.RewardItem> cpuRewardList;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public RewardDataV2()
        {
        
        }
    
    }

}
