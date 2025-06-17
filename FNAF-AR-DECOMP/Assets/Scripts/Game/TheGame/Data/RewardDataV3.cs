using UnityEngine;

namespace Game.TheGame.Data
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class RewardDataV3
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
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int essenceOnLoss;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public RewardDataV3()
        {
            this.modRewardList = new System.Collections.Generic.List<Game.TheGame.Data.RewardItem>();
            this.currencyRewardList = new System.Collections.Generic.List<Game.TheGame.Data.RewardItem>();
            this.animatronicRewardTable = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<Game.TheGame.Data.RewardItem>>();
            this.cpuRewardList = new System.Collections.Generic.List<Game.TheGame.Data.RewardItem>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public RewardDataV3(Game.TheGame.Data.RewardDataV3 rewardDataV3)
        {
            var val_16;
            System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<Game.TheGame.Data.RewardItem>> val_17;
            System.Collections.Generic.List<Game.TheGame.Data.RewardItem> val_1 = null;
            val_16 = 1152921525131767504;
            val_1 = new System.Collections.Generic.List<Game.TheGame.Data.RewardItem>();
            this.modRewardList = val_1;
            this.currencyRewardList = new System.Collections.Generic.List<Game.TheGame.Data.RewardItem>();
            this.animatronicRewardTable = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<Game.TheGame.Data.RewardItem>>();
            this.cpuRewardList = new System.Collections.Generic.List<Game.TheGame.Data.RewardItem>();
            int val_5 = rewardDataV3.modRewardList.Count;
            if(val_5 >= 1)
            {
                    do
            {
                this.modRewardList.Add(item:  rewardDataV3.modRewardList.Item[0]);
                val_16 = 0 + 1;
            }
            while(val_5 != val_16);
            
            }
            
            int val_7 = rewardDataV3.currencyRewardList.Count;
            if(val_7 >= 1)
            {
                    do
            {
                this.currencyRewardList.Add(item:  rewardDataV3.currencyRewardList.Item[0]);
                val_16 = 0 + 1;
            }
            while(val_7 != val_16);
            
            }
            
            int val_9 = rewardDataV3.cpuRewardList.Count;
            if(val_9 >= 1)
            {
                    do
            {
                this.cpuRewardList.Add(item:  rewardDataV3.cpuRewardList.Item[0]);
                val_16 = 0 + 1;
            }
            while(val_9 != val_16);
            
            }
            
            val_17 = rewardDataV3.animatronicRewardTable;
            Dictionary.Enumerator<TKey, TValue> val_11 = val_17.GetEnumerator();
            label_23:
            if(((-949687640) & 1) == 0)
            {
                goto label_21;
            }
            
            UnityEngine.XR.ARSubsystems.TrackableId val_12 = 0.trackableId;
            this.animatronicRewardTable.set_Item(key:  val_12.m_SubId1.System.IConvertible.ToUInt64(provider:  public System.String System.Collections.Generic.KeyValuePair<System.String, System.Collections.Generic.List<Game.TheGame.Data.RewardItem>>::get_Key()), value:  val_12.m_SubId1);
            goto label_23;
            label_21:
            this.essenceOnLoss = rewardDataV3.essenceOnLoss;
        }
    
    }

}
