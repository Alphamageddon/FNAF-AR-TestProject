using UnityEngine;

namespace Game.DailyChallenge.Data
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class DailyChallengeRewardItem
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Type;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string SubType;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Quantity;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string IconRef;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string LocRef;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DailyChallengeRewardItem(ProtoData.DAILY_CHALLENGE_REWARDS_DATA.Types.ENTRY.Types.ITEM item)
        {
            var val_10;
            var val_11;
            if(item != null)
            {
                    string val_1 = item.RewardType;
            }
            else
            {
                    val_10 = 0;
            }
            
            this.Type = (val_10 == 0) ? "" : (val_10);
            if(item != null)
            {
                    string val_3 = item.RewardSubtype;
                this.SubType = (val_3 == null) ? "" : (val_3);
                this.Quantity = (int)item.Quantity;
                string val_6 = item.IconRef;
                this.IconRef = (val_6 == null) ? "" : (val_6);
                string val_8 = item.LocRef;
            }
            else
            {
                    val_11 = 0;
                this.Quantity = 0;
                this.SubType = "";
                this.IconRef = "";
            }
            
            this.LocRef = (val_11 == 0) ? "" : (val_11);
        }
    
    }

}
