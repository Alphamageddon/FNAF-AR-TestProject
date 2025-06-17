using UnityEngine;

namespace Game.DailyChallenge.Data
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class DailyChallengeRewardsData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Id;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string LootTableId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Weight;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Game.DailyChallenge.Data.DailyChallengeRewardItem> Items;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DailyChallengeRewardsData(ProtoData.DAILY_CHALLENGE_REWARDS_DATA.Types.ENTRY entry)
        {
            System.Collections.Generic.List<Game.DailyChallenge.Data.DailyChallengeRewardItem> val_16;
            if(entry != null)
            {
                    this.Id = entry.Logical;
                this.LootTableId = entry.LootTableId;
            }
            else
            {
                    this.Id = 0.Logical;
                this.LootTableId = 0.LootTableId;
            }
            
            this.Weight = (int)entry.Weight;
            System.Collections.Generic.List<Game.DailyChallenge.Data.DailyChallengeRewardItem> val_6 = null;
            val_16 = val_6;
            val_6 = new System.Collections.Generic.List<Game.DailyChallenge.Data.DailyChallengeRewardItem>();
            this.Items = val_16;
            if(entry.Item1 != null)
            {
                    val_16 = this.Items;
                val_16.Add(item:  new Game.DailyChallenge.Data.DailyChallengeRewardItem(item:  entry.Item1));
            }
            
            if(entry.Item2 != null)
            {
                    val_16 = this.Items;
                val_16.Add(item:  new Game.DailyChallenge.Data.DailyChallengeRewardItem(item:  entry.Item2));
            }
            
            if(entry.Item3 == null)
            {
                    return;
            }
            
            this.Items.Add(item:  new Game.DailyChallenge.Data.DailyChallengeRewardItem(item:  entry.Item3));
        }
    
    }

}
