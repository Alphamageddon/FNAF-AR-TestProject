using UnityEngine;

namespace Game.TheGame.Data
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class RewardData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string animatronicId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Game.TheGame.Data.RewardItem> rewardList;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Game.TheGame.Data.RewardItem> currencyList;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public RewardData()
        {
        
        }
    
    }

}
