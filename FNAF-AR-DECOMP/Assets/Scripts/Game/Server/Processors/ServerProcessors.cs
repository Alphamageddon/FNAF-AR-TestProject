using UnityEngine;

namespace Game.Server.Processors
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class ServerProcessors
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Game.Server.PlayerFriendsEntry ProcessPlayerFriendsEntry(Systems.Server.ServerData entry)
        {
            string val_7;
            string val_8;
            if(entry != null)
            {
                    val_7 = entry.GetString(key:  "userId");
                val_8 = entry.GetString(key:  "displayName");
            }
            else
            {
                    val_7 = 0.GetString(key:  "userId");
                val_8 = 0.GetString(key:  "displayName");
            }
            
            Game.Server.PlayerFriendsEntry val_6 = new Game.Server.PlayerFriendsEntry();
            if(val_6 != null)
            {
                    .userId = val_7;
                .displayName = val_8;
            }
            else
            {
                    mem[16] = val_7;
                mem[24] = val_8;
            }
            
            .avatarId = entry.GetString(key:  "avatarId");
            return val_6;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static AnimatronicEntity.Data.WorkshopEntry ProcessWorkshopDataEntry(Systems.Server.ServerData entry)
        {
            string val_11;
            Status val_2 = 0;
            bool val_3 = System.Enum.TryParse<Status>(value:  entry.GetString(key:  "status"), result: out  val_2);
            System.Nullable<System.Double> val_4 = entry.GetDouble(key:  "lastCommand");
            if(entry != null)
            {
                    val_11 = entry.GetString(key:  "entityId");
            }
            else
            {
                    val_11 = 0.GetString(key:  "entityId");
            }
            
            System.Nullable<System.Int32> val_7 = entry.GetInt(key:  "wearAndTear");
            AnimatronicEntity.Data.WorkshopEntry val_10 = new AnimatronicEntity.Data.WorkshopEntry();
            if(val_10 != null)
            {
                    .lastCommand = V0.16B;
                .entityId = val_11;
                .health = ;
                .status = val_2;
            }
            else
            {
                    mem[24] = V0.16B;
                mem[16] = val_2;
                mem[32] = val_11;
                mem[40] = ;
            }
            
            .endoskeleton = Game.Server.Processors.ServerProcessors.ProcessEndoskeleton(endoskeleton:  entry.GetServerData(key:  "endoskeleton"));
            return val_10;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static Game.ItemDefinition.Data.DataDefinitions.EndoskeletonData ProcessEndoskeleton(Systems.Server.ServerData endoskeleton)
        {
            string val_7;
            var val_8;
            if(endoskeleton == null)
            {
                goto label_1;
            }
            
            val_7 = endoskeleton.GetString(key:  "cpu");
            string val_2 = endoskeleton.GetString(key:  "plushSuit");
            System.Collections.Generic.List<System.String> val_3 = endoskeleton.GetStringList(key:  "mods");
            System.Nullable<System.Int32> val_4 = endoskeleton.GetInt(key:  "essence");
            Game.ItemDefinition.Data.DataDefinitions.EndoskeletonData val_5 = null;
            val_8 = val_5;
            val_5 = new Game.ItemDefinition.Data.DataDefinitions.EndoskeletonData();
            if(val_8 == null)
            {
                goto label_2;
            }
            
            .cpu = val_7;
            .plushSuit = val_2;
            .mods = val_3;
            goto label_3;
            label_1:
            Game.ItemDefinition.Data.DataDefinitions.EndoskeletonData val_6 = null;
            val_8 = val_6;
            val_6 = new Game.ItemDefinition.Data.DataDefinitions.EndoskeletonData();
            return (Game.ItemDefinition.Data.DataDefinitions.EndoskeletonData)val_8;
            label_2:
            mem[16] = val_7;
            mem[24] = val_2;
            mem[40] = val_3;
            label_3:
            .numEssence = ;
            return (Game.ItemDefinition.Data.DataDefinitions.EndoskeletonData)val_8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Game.TheGame.Data.RewardDataV2 ProcessRewardData(Systems.Server.ServerData data)
        {
            System.Collections.Generic.List<Game.TheGame.Data.RewardItem> val_1 = Game.Server.Processors.ServerProcessors.ProcessCurrencyRewards(data:  data);
            System.Collections.Generic.List<Game.TheGame.Data.RewardItem> val_2 = Game.Server.Processors.ServerProcessors.ProcessModRewards(data:  data);
            System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<Game.TheGame.Data.RewardItem>> val_4 = Game.Server.Processors.ServerProcessors.ProcessAnimatronicRewards(data:  data);
            Game.TheGame.Data.RewardDataV2 val_5 = new Game.TheGame.Data.RewardDataV2();
            if(val_5 != null)
            {
                    .currencyRewardList = val_1;
                .animatronicRewardTable = val_4;
                .modRewardList = val_2;
            }
            else
            {
                    mem[32] = val_4;
                mem[24] = val_1;
                mem[16] = val_2;
            }
            
            .cpuRewardList = Game.Server.Processors.ServerProcessors.ProcessCPURewards(data:  data);
            return val_5;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Game.TheGame.Data.RewardDataV3 ProcessRewardDataV3(Systems.Server.ServerData data)
        {
            System.Collections.Generic.List<Game.TheGame.Data.RewardItem> val_1 = Game.Server.Processors.ServerProcessors.ProcessCurrencyRewards(data:  data);
            System.Collections.Generic.List<Game.TheGame.Data.RewardItem> val_2 = Game.Server.Processors.ServerProcessors.ProcessModRewards(data:  data);
            System.Collections.Generic.List<Game.TheGame.Data.RewardItem> val_3 = Game.Server.Processors.ServerProcessors.ProcessCPURewards(data:  data);
            System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<Game.TheGame.Data.RewardItem>> val_4 = Game.Server.Processors.ServerProcessors.ProcessAnimatronicRewards(data:  data);
            Game.TheGame.Data.RewardDataV3 val_6 = new Game.TheGame.Data.RewardDataV3();
            if(val_6 != null)
            {
                    .modRewardList = val_2;
                .currencyRewardList = val_1;
                .animatronicRewardTable = val_4;
                .cpuRewardList = val_3;
            }
            else
            {
                    mem[32] = val_4;
                mem[24] = val_1;
                mem[16] = val_2;
                mem[40] = val_3;
            }
            
            .essenceOnLoss = Game.Server.Processors.ServerProcessors.ProcessEssenceOnLossRewards(data:  data);
            return val_6;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Game.PlayerStats.Data.PlayerStatsData ProcessPlayerStats(Systems.Server.ServerData data)
        {
            System.Nullable<System.Int32> val_2 = data.GetInt(key:  "totalEssence");
            val_1.TotalRemant = ;
            return (Game.PlayerStats.Data.PlayerStatsData)Game.PlayerStats.Data.PlayerStatsData.CreateEmpty();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static System.Collections.Generic.Dictionary<string, int> ProcessPlayerGoods(System.Collections.Generic.List<Systems.Server.ServerData> data)
        {
            var val_4;
            var val_13;
            var val_14;
            System.Collections.Generic.Dictionary<System.String, System.Int32> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
            val_13 = null;
            val_13 = null;
            if(Game.Server.ServerDomain.CurrentServer != 2)
            {
                    return val_1;
            }
            
            List.Enumerator<T> val_2 = data.GetEnumerator();
            do
            {
                label_14:
                if(((-869052832) & 1) == 0)
            {
                    return val_1;
            }
            
                PlayFab.ClientModels.ItemInstance val_7 = UnityEngine.JsonUtility.FromJson<PlayFab.ClientModels.ItemInstance>(json:  val_4.emailUIDataHandler.JSON);
            }
            while((val_1.ContainsKey(key:  val_7.ItemId)) == true);
            
            if(((-869052840) & 1) == 0)
            {
                goto label_10;
            }
            
            val_14 = val_7.RemainingUses.region;
            if(val_1 != null)
            {
                goto label_13;
            }
            
            goto label_12;
            label_10:
            val_14 = 1;
            if(val_1 != null)
            {
                goto label_13;
            }
            
            label_12:
            label_13:
            val_1.Add(key:  val_7.ItemId, value:  1);
            goto label_14;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static GameUI.EmailData ProcessEmailData(Systems.Server.ServerData data)
        {
            string val_26;
            string val_27;
            string val_28;
            string val_29;
            string val_30;
            if(data != null)
            {
                    string val_1 = data.GetString(key:  "logical");
                string val_2 = data.GetString(key:  "id");
            }
            else
            {
                    string val_3 = 0.GetString(key:  "logical");
                string val_4 = 0.GetString(key:  "id");
            }
            
            string val_5 = data.GetString(key:  "to");
            string val_6 = (val_5 == null) ? "" : (val_5);
            if(data != null)
            {
                    val_26 = data.GetString(key:  "from");
            }
            else
            {
                    val_26 = 0.GetString(key:  "from");
            }
            
            System.Nullable<System.Boolean> val_9 = data.GetBoolean(key:  "read");
            if(data != null)
            {
                    val_27 = data.GetString(key:  "body");
            }
            else
            {
                    val_27 = 0.GetString(key:  "body");
            }
            
            System.Nullable<System.Int64> val_12 = data.GetNumber(key:  "date");
            System.DateTime val_13 = 0.AddMilliseconds(value:  1.15292150460685E+18);
            Game.TheGame.Data.RewardDataV3 val_15 = Game.Server.Processors.ServerProcessors.ProcessRewardDataV3(data:  data.GetServerData(key:  "rewards"));
            if(data != null)
            {
                    val_28 = data.GetString(key:  "subject");
            }
            else
            {
                    val_28 = 0.GetString(key:  "subject");
            }
            
            System.Collections.Generic.Dictionary<System.String, System.String> val_19 = Game.Server.Processors.ServerProcessors.ProcessStringDictionary(gsDictionary:  data.GetServerData(key:  "tokens"));
            if(data != null)
            {
                    val_29 = data.GetString(key:  "TemplateBundle");
                val_30 = data.GetString(key:  "TemplatePrefab");
            }
            else
            {
                    val_29 = 0.GetString(key:  "TemplateBundle");
                val_30 = 0.GetString(key:  "TemplatePrefab");
            }
            
            GameUI.EmailData val_25 = new GameUI.EmailData();
            if(val_25 != null)
            {
                    .logical = val_3;
                .recipientString = val_6;
                .fromString = val_26;
                .audioItem = 0;
                .imageItem = 0;
                .subjectString = val_28;
                .messageString = val_27;
                .id = val_4;
                .tokens = val_19;
                .isRead = false;
                .templateBundle = val_29;
                .templatePrefab = val_30;
                .receivedDateTime = val_13;
                .rewardDataV3 = val_15;
            }
            else
            {
                    mem[16] = val_3;
                mem[72] = 0;
                mem[24] = val_6;
                mem[32] = val_26;
                mem[96] = val_4;
                mem[80] = 0;
                mem[88] = 0;
                mem[48] = val_27;
                mem[56] = val_13.dateData;
                mem[64] = val_15;
                mem[40] = val_28;
                mem[104] = val_19;
                mem[112] = val_29;
                mem[120] = val_30;
            }
            
            .tags = data.GetStringList(key:  "tags");
            return val_25;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static System.Collections.Generic.Dictionary<string, string> ProcessStringDictionary(Systems.Server.ServerData gsDictionary)
        {
            var val_13;
            var val_14;
            System.Collections.Generic.Dictionary<System.String, System.String> val_1 = new System.Collections.Generic.Dictionary<System.String, System.String>();
            var val_13 = 0;
            val_13 = val_13 + 1;
            var val_14 = 0;
            val_14 = val_14 + 1;
            System.Collections.Generic.IEnumerator<T> val_6 = gsDictionary.BaseData.Keys.GetEnumerator();
            label_25:
            var val_15 = 0;
            val_15 = val_15 + 1;
            if(val_6.MoveNext() == false)
            {
                goto label_17;
            }
            
            var val_16 = 0;
            val_16 = val_16 + 1;
            T val_10 = val_6.Current;
            val_1.set_Item(key:  val_10, value:  gsDictionary.GetString(key:  val_10));
            goto label_25;
            label_17:
            val_13 = 0;
            val_14 = 66;
            if(val_6 == null)
            {
                
            }
            else
            {
                    var val_17 = 0;
                val_17 = val_17 + 1;
                val_6.Dispose();
            }
            
            if( == 66)
            {
                    return val_1;
            }
            
            if( == false)
            {
                    return val_1;
            }
            
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static System.Collections.Generic.List<Game.TheGame.Data.RewardItem> ProcessRewardList(Systems.Server.ServerData data)
        {
            System.Collections.Generic.List<Game.TheGame.Data.RewardItem> val_1 = Game.Server.Processors.ServerProcessors.ProcessCurrencyRewards(data:  data);
            System.Collections.Generic.List<Game.TheGame.Data.RewardItem> val_2 = Game.Server.Processors.ServerProcessors.ProcessModRewards(data:  data);
            System.Collections.Generic.List<Game.TheGame.Data.RewardItem> val_4 = new System.Collections.Generic.List<Game.TheGame.Data.RewardItem>();
            if(val_4 != null)
            {
                    val_4.AddRange(collection:  val_1);
                val_4.AddRange(collection:  val_2);
            }
            else
            {
                    val_4.AddRange(collection:  val_1);
                val_4.AddRange(collection:  val_2);
            }
            
            val_4.AddRange(collection:  Game.Server.Processors.ServerProcessors.ProcessCPURewards(data:  data));
            return val_4;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static System.Collections.Generic.List<Game.TheGame.Data.RewardItem> ProcessCurrencyRewards(Systems.Server.ServerData data)
        {
            var val_15;
            var val_16;
            Systems.Server.ServerData val_1 = data.GetServerData(key:  "CurrencyRewards");
            System.Collections.Generic.List<Game.TheGame.Data.RewardItem> val_2 = new System.Collections.Generic.List<Game.TheGame.Data.RewardItem>();
            var val_15 = 0;
            val_15 = val_15 + 1;
            var val_16 = 0;
            val_16 = val_16 + 1;
            System.Collections.Generic.IEnumerator<T> val_7 = val_1.BaseData.Keys.GetEnumerator();
            label_28:
            var val_17 = 0;
            val_17 = val_17 + 1;
            if(val_7.MoveNext() == false)
            {
                goto label_18;
            }
            
            var val_18 = 0;
            val_18 = val_18 + 1;
            T val_11 = val_7.Current;
            System.Nullable<System.Int32> val_12 = val_1.GetInt(key:  val_11);
            new Game.TheGame.Data.RewardItem() = new Game.TheGame.Data.RewardItem();
            if(new Game.TheGame.Data.RewardItem() != null)
            {
                    .item = val_11;
            }
            else
            {
                    mem[16] = val_11;
            }
            
            .amount = ;
            val_2.Add(item:  new Game.TheGame.Data.RewardItem());
            goto label_28;
            label_18:
            val_15 = 0;
            val_16 = 112;
            if(val_7 == null)
            {
                
            }
            else
            {
                    var val_19 = 0;
                val_19 = val_19 + 1;
                val_7.Dispose();
            }
            
            if( == 112)
            {
                    return val_2;
            }
            
            if( == false)
            {
                    return val_2;
            }
            
            return val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static System.Collections.Generic.List<Game.TheGame.Data.RewardItem> ProcessModRewards(Systems.Server.ServerData data)
        {
            var val_15;
            var val_16;
            Systems.Server.ServerData val_1 = data.GetServerData(key:  "ModRewards");
            System.Collections.Generic.List<Game.TheGame.Data.RewardItem> val_2 = new System.Collections.Generic.List<Game.TheGame.Data.RewardItem>();
            var val_15 = 0;
            val_15 = val_15 + 1;
            var val_16 = 0;
            val_16 = val_16 + 1;
            System.Collections.Generic.IEnumerator<T> val_7 = val_1.BaseData.Keys.GetEnumerator();
            label_28:
            var val_17 = 0;
            val_17 = val_17 + 1;
            if(val_7.MoveNext() == false)
            {
                goto label_18;
            }
            
            var val_18 = 0;
            val_18 = val_18 + 1;
            T val_11 = val_7.Current;
            System.Nullable<System.Int32> val_12 = val_1.GetInt(key:  val_11);
            new Game.TheGame.Data.RewardItem() = new Game.TheGame.Data.RewardItem();
            if(new Game.TheGame.Data.RewardItem() != null)
            {
                    .item = val_11;
            }
            else
            {
                    mem[16] = val_11;
            }
            
            .amount = ;
            val_2.Add(item:  new Game.TheGame.Data.RewardItem());
            goto label_28;
            label_18:
            val_15 = 0;
            val_16 = 112;
            if(val_7 == null)
            {
                
            }
            else
            {
                    var val_19 = 0;
                val_19 = val_19 + 1;
                val_7.Dispose();
            }
            
            if( == 112)
            {
                    return val_2;
            }
            
            if( == false)
            {
                    return val_2;
            }
            
            return val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static System.Collections.Generic.List<Game.TheGame.Data.RewardItem> ProcessCPURewards(Systems.Server.ServerData data)
        {
            var val_15;
            var val_16;
            Systems.Server.ServerData val_1 = data.GetServerData(key:  "CPURewards");
            System.Collections.Generic.List<Game.TheGame.Data.RewardItem> val_2 = new System.Collections.Generic.List<Game.TheGame.Data.RewardItem>();
            var val_15 = 0;
            val_15 = val_15 + 1;
            var val_16 = 0;
            val_16 = val_16 + 1;
            System.Collections.Generic.IEnumerator<T> val_7 = val_1.BaseData.Keys.GetEnumerator();
            label_28:
            var val_17 = 0;
            val_17 = val_17 + 1;
            if(val_7.MoveNext() == false)
            {
                goto label_18;
            }
            
            var val_18 = 0;
            val_18 = val_18 + 1;
            T val_11 = val_7.Current;
            System.Nullable<System.Int32> val_12 = val_1.GetInt(key:  val_11);
            new Game.TheGame.Data.RewardItem() = new Game.TheGame.Data.RewardItem();
            if(new Game.TheGame.Data.RewardItem() != null)
            {
                    .item = val_11;
            }
            else
            {
                    mem[16] = val_11;
            }
            
            .amount = ;
            val_2.Add(item:  new Game.TheGame.Data.RewardItem());
            goto label_28;
            label_18:
            val_15 = 0;
            val_16 = 112;
            if(val_7 == null)
            {
                
            }
            else
            {
                    var val_19 = 0;
                val_19 = val_19 + 1;
                val_7.Dispose();
            }
            
            if( == 112)
            {
                    return val_2;
            }
            
            if( == false)
            {
                    return val_2;
            }
            
            return val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<Game.TheGame.Data.RewardItem>> ProcessAnimatronicRewards(Systems.Server.ServerData data)
        {
            var val_15;
            var val_16;
            System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<Game.TheGame.Data.RewardItem>> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<Game.TheGame.Data.RewardItem>>();
            Systems.Server.ServerData val_2 = data.GetServerData(key:  "AnimatronicRewards");
            var val_15 = 0;
            val_15 = val_15 + 1;
            var val_16 = 0;
            val_16 = val_16 + 1;
            System.Collections.Generic.IEnumerator<T> val_7 = val_2.BaseData.Keys.GetEnumerator();
            label_26:
            var val_17 = 0;
            val_17 = val_17 + 1;
            if(val_7.MoveNext() == false)
            {
                goto label_18;
            }
            
            var val_18 = 0;
            val_18 = val_18 + 1;
            T val_11 = val_7.Current;
            val_1.Add(key:  val_11, value:  Game.Server.Processors.ServerProcessors.ProcessAnimatronicReward(data:  val_2.GetServerData(key:  val_11)));
            goto label_26;
            label_18:
            val_15 = 0;
            val_16 = 87;
            if(val_7 == null)
            {
                
            }
            else
            {
                    var val_19 = 0;
                val_19 = val_19 + 1;
                val_7.Dispose();
            }
            
            if( == 87)
            {
                    return val_1;
            }
            
            if( == false)
            {
                    return val_1;
            }
            
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static System.Collections.Generic.List<Game.TheGame.Data.RewardItem> ProcessAnimatronicReward(Systems.Server.ServerData data)
        {
            var val_14;
            var val_15;
            System.Collections.Generic.List<Game.TheGame.Data.RewardItem> val_1 = new System.Collections.Generic.List<Game.TheGame.Data.RewardItem>();
            var val_14 = 0;
            val_14 = val_14 + 1;
            var val_15 = 0;
            val_15 = val_15 + 1;
            System.Collections.Generic.IEnumerator<T> val_6 = data.BaseData.Keys.GetEnumerator();
            label_27:
            var val_16 = 0;
            val_16 = val_16 + 1;
            if(val_6.MoveNext() == false)
            {
                goto label_17;
            }
            
            var val_17 = 0;
            val_17 = val_17 + 1;
            T val_10 = val_6.Current;
            System.Nullable<System.Int32> val_11 = data.GetInt(key:  val_10);
            new Game.TheGame.Data.RewardItem() = new Game.TheGame.Data.RewardItem();
            if(new Game.TheGame.Data.RewardItem() != null)
            {
                    .amount = ;
            }
            else
            {
                    mem[24] = ;
            }
            
            .item = val_10;
            val_1.Add(item:  new Game.TheGame.Data.RewardItem());
            goto label_27;
            label_17:
            val_14 = 0;
            val_15 = 98;
            if(val_6 == null)
            {
                
            }
            else
            {
                    var val_18 = 0;
                val_18 = val_18 + 1;
                val_6.Dispose();
            }
            
            if( == 98)
            {
                    return val_1;
            }
            
            if( == false)
            {
                    return val_1;
            }
            
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static int ProcessEssenceOnLossRewards(Systems.Server.ServerData data)
        {
            var val_3;
            System.Nullable<System.Int32> val_1 = data.GetInt(key:  "EssenceOnLose");
            if(((-867463128) & 1) != 0)
            {
                    UnityEngine.XR.ARCore.ARCoreFaceRegion val_2 = val_1.HasValue.region;
                return (int)val_3;
            }
            
            val_3 = 0;
            return (int)val_3;
        }
    
    }

}
