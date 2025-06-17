using UnityEngine;

namespace Game.Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class RewardsResponseHandler : EventResponseHandler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<Game.TheGame.Data.RewardData> OnRewardReceived;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(System.Action<Game.TheGame.Data.RewardData> callback)
        {
            this.OnRewardReceived = callback;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void TryHandleResponse(Systems.Server.ServerData data)
        {
            string val_11;
            System.Collections.Generic.List<Systems.Server.ServerData> val_12;
            System.Collections.Generic.List<Game.TheGame.Data.RewardItem> val_13;
            if(data != null)
            {
                    val_11 = data.GetString(key:  "AnimatronicId");
                val_12 = data.GetServerDataList(key:  "Rewards");
            }
            else
            {
                    val_11 = 0.GetString(key:  "AnimatronicId");
                val_12 = 0.GetServerDataList(key:  "Rewards");
            }
            
            System.Collections.Generic.List<Systems.Server.ServerData> val_5 = data.GetServerDataList(key:  "CurrencyRewards");
            if(val_12 == null)
            {
                    return;
            }
            
            if(val_11 == null)
            {
                    return;
            }
            
            if(val_5 == null)
            {
                    return;
            }
            
            Game.TheGame.Data.RewardData val_6 = new Game.TheGame.Data.RewardData();
            if(val_6 != null)
            {
                    .animatronicId = val_11;
                .rewardList = this.PopulateRewardList(dataList:  val_12);
                val_13 = this.PopulateRewardList(dataList:  val_5);
            }
            else
            {
                    mem[16] = val_11;
                mem[24] = this.PopulateRewardList(dataList:  val_12);
                val_13 = this.PopulateRewardList(dataList:  val_5);
            }
            
            .currencyList = val_13;
            this.OnRewardReceived.Invoke(obj:  val_6);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<Game.TheGame.Data.RewardItem> PopulateRewardList(System.Collections.Generic.List<Systems.Server.ServerData> dataList)
        {
            System.Collections.Generic.List<Game.TheGame.Data.RewardItem> val_1 = new System.Collections.Generic.List<Game.TheGame.Data.RewardItem>();
            int val_2 = dataList.Count;
            if(val_2 < 1)
            {
                    return val_1;
            }
            
            var val_5 = 0;
            do
            {
                Systems.Server.ServerData val_3 = dataList.Item[0];
                val_1.Add(item:  val_3.GenerateRewardItem(data:  val_3));
                val_5 = val_5 + 1;
            }
            while(val_2 != val_5);
            
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.TheGame.Data.RewardItem GenerateRewardItem(Systems.Server.ServerData data)
        {
            string val_5;
            if(data != null)
            {
                    val_5 = data.GetString(key:  "item");
            }
            else
            {
                    val_5 = 0.GetString(key:  "item");
            }
            
            System.Nullable<System.Int32> val_3 = data.GetInt(key:  "quantity");
            Game.TheGame.Data.RewardItem val_4 = new Game.TheGame.Data.RewardItem();
            if(val_4 != null)
            {
                    .item = val_5;
            }
            else
            {
                    mem[16] = val_5;
            }
            
            .amount = ;
            return val_4;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public RewardsResponseHandler()
        {
        
        }
    
    }

}
