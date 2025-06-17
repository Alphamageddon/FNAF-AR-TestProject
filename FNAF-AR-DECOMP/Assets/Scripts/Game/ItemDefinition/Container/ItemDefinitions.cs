using UnityEngine;

namespace Game.ItemDefinition.Container
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ItemDefinitions
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _purchasedSlots;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Collections.Generic.Dictionary<string, Game.ItemDefinition.Data.DataDefinitions.ModData> _modDictionary;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Collections.Generic.Dictionary<string, Game.ItemDefinition.Data.DataDefinitions.CPUData> _cpuDictionary;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Collections.Generic.Dictionary<string, Game.ItemDefinition.Data.DataDefinitions.AttackProfile> _attackProfileDictionary;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Collections.Generic.Dictionary<string, Game.ItemDefinition.Data.DataDefinitions.PlushSuitData> _plushSuitDictionary;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Collections.Generic.Dictionary<string, Game.ItemDefinition.Data.DataDefinitions.DeviceData> _deviceDictionary;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Collections.Generic.Dictionary<Game.ItemDefinition.Container.RewardCategory, Game.ItemDefinition.Container.RewardsData> _rewardDictionary;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Collections.Generic.List<Game.ItemDefinition.Data.DataDefinitions.WearAndTearData> _wearAndTearData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Collections.Generic.List<Game.ItemDefinition.Data.DataDefinitions.EssenceData> _essenceData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Collections.Generic.List<Game.ItemDefinition.Container.ProgressionData> _progressionDataList;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Collections.Generic.List<int> _modUnlockStreak;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Collections.Generic.List<int> _slotUnlockStreak;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Collections.Generic.List<Game.ItemDefinition.Container.RemnantDebuffEntry> _remnantDebuffLookup;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<Game.ItemDefinition.Container.SequentialRewardsData>> _sequentialRewardsData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Collections.Generic.Dictionary<string, ProtoData.SEASONAL_DATA.Types.ENTRY.Types.MECHANICS> _seasonalData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Collections.Generic.List<Game.ItemDefinition.Data.DataDefinitions.InboxData> _inboxDatas;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Collections.Generic.List<Game.ItemDefinition.Data.DataDefinitions.AlertInboxData> _alertInboxDatas;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly Game.ItemDefinition.Data.DataDefinitions.WearAndTearData NullWearAndTear;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly Game.ItemDefinition.Data.DataDefinitions.AttackProfile NullConfig;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, Game.ItemDefinition.Data.DataDefinitions.PlushSuitData> PlushSuitDictionary { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, Game.ItemDefinition.Data.DataDefinitions.CPUData> CpuDictionary { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, Game.ItemDefinition.Data.DataDefinitions.PlushSuitData> get_PlushSuitDictionary()
        {
            return (System.Collections.Generic.Dictionary<System.String, Game.ItemDefinition.Data.DataDefinitions.PlushSuitData>)this._plushSuitDictionary;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, Game.ItemDefinition.Data.DataDefinitions.CPUData> get_CpuDictionary()
        {
            return (System.Collections.Generic.Dictionary<System.String, Game.ItemDefinition.Data.DataDefinitions.CPUData>)this._cpuDictionary;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void LoadInboxData(ProtoData.INBOX_DATA data)
        {
            var val_10;
            var val_11;
            var val_13;
            this._inboxDatas.Clear();
            System.Collections.Generic.IEnumerator<T> val_2 = data.Entries.GetEnumerator();
            label_16:
            var val_10 = 0;
            val_10 = val_10 + 1;
            if(val_2.MoveNext() == false)
            {
                goto label_9;
            }
            
            var val_11 = 0;
            val_11 = val_11 + 1;
            new Game.ItemDefinition.Data.DataDefinitions.InboxData() = new Game.ItemDefinition.Data.DataDefinitions.InboxData(entry:  val_2.Current);
            this._inboxDatas.Add(item:  new Game.ItemDefinition.Data.DataDefinitions.InboxData());
            goto label_16;
            label_9:
            val_10 = 0;
            val_11 = 69;
            if(val_2 == null)
            {
                
            }
            else
            {
                    var val_12 = 0;
                val_12 = val_12 + 1;
                val_2.Dispose();
            }
            
            val_13 = null;
            val_13 = null;
            if((ItemDefinitions.<>c.<>9__21_0) == null)
            {
                goto label_33;
            }
            
            label_38:
            this._inboxDatas.Sort(comparison:  ItemDefinitions.<>c.<>9__21_0);
            return;
            label_33:
            ItemDefinitions.<>c.<>9__21_0 = new System.Comparison<Game.ItemDefinition.Data.DataDefinitions.InboxData>(object:  ItemDefinitions.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 ItemDefinitions.<>c::<LoadInboxData>b__21_0(Game.ItemDefinition.Data.DataDefinitions.InboxData a, Game.ItemDefinition.Data.DataDefinitions.InboxData b));
            if(this._inboxDatas != null)
            {
                goto label_38;
            }
            
            goto label_38;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.ItemDefinition.Data.DataDefinitions.InboxData GetInboxData(string logical)
        {
            .logical = logical;
            if(this._inboxDatas != null)
            {
                    return this._inboxDatas.Find(match:  new System.Predicate<Game.ItemDefinition.Data.DataDefinitions.InboxData>(object:  new ItemDefinitions.<>c__DisplayClass22_0(), method:  System.Boolean ItemDefinitions.<>c__DisplayClass22_0::<GetInboxData>b__0(Game.ItemDefinition.Data.DataDefinitions.InboxData data)));
            }
            
            return this._inboxDatas.Find(match:  new System.Predicate<Game.ItemDefinition.Data.DataDefinitions.InboxData>(object:  new ItemDefinitions.<>c__DisplayClass22_0(), method:  System.Boolean ItemDefinitions.<>c__DisplayClass22_0::<GetInboxData>b__0(Game.ItemDefinition.Data.DataDefinitions.InboxData data)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<string> GetInboxFolderIds()
        {
            var val_5;
            var val_6;
            System.Collections.Generic.List<System.String> val_1 = new System.Collections.Generic.List<System.String>();
            List.Enumerator<T> val_2 = this._inboxDatas.GetEnumerator();
            label_5:
            if(((-803370168) & 1) == 0)
            {
                goto label_2;
            }
            
            GameUI.EmailUIDataHandler val_3 = 0.emailUIDataHandler;
            val_1.Add(item:  val_3._masterDomain);
            goto label_5;
            label_2:
            val_5 = 0;
            val_6 = 1;
            long val_4 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525278313288});
            if(( & 1) != 0)
            {
                    return val_1;
            }
            
            if( == 0)
            {
                    return val_1;
            }
            
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void LoadAlertData(ProtoData.ALERT_DATA alertData)
        {
            this.ParseOutInboxData(alertData:  alertData);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string PredictEmailFolder(GameUI.EmailData emailData)
        {
            string val_4;
            .emailData = emailData;
            if((this._alertInboxDatas.Find(match:  new System.Predicate<Game.ItemDefinition.Data.DataDefinitions.AlertInboxData>(object:  new ItemDefinitions.<>c__DisplayClass25_0(), method:  System.Boolean ItemDefinitions.<>c__DisplayClass25_0::<PredictEmailFolder>b__0(Game.ItemDefinition.Data.DataDefinitions.AlertInboxData x)))) == null)
            {
                    return val_4;
            }
            
            val_4 = val_3.folderDestination;
            return val_4;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ParseOutInboxData(ProtoData.ALERT_DATA alertData)
        {
            var val_22;
            var val_23;
            var val_24;
            var val_27;
            var val_28;
            val_22 = 1152921504685174784;
            val_23 = 1152921505267707904;
            val_24 = alertData.Entries.GetEnumerator();
            label_20:
            var val_24 = 0;
            val_24 = val_24 + 1;
            if(val_24.MoveNext() == false)
            {
                goto label_8;
            }
            
            var val_25 = 0;
            val_25 = val_25 + 1;
            T val_6 = val_24.Current;
            if(val_6.Channel != 1)
            {
                goto label_20;
            }
            
            new Game.ItemDefinition.Data.DataDefinitions.AlertInboxData() = new System.Object();
            .eventBody = val_6.EventBody;
            .folderDestination = val_6.InboxFolderDestination;
            this._alertInboxDatas.Add(item:  new Game.ItemDefinition.Data.DataDefinitions.AlertInboxData());
            goto label_20;
            label_8:
            val_27 = 0;
            val_28 = 90;
            if(val_24 == null)
            {
                
            }
            else
            {
                    var val_26 = 0;
                val_26 = val_26 + 1;
                val_24.Dispose();
            }
            
            if( == 90)
            {
                    return;
            }
            
            if( == false)
            {
                    return;
            }
            
            val_24 = ???;
            val_28 = ???;
            val_22 = ???;
            val_23 = ???;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void LoadModsFromServer(ProtoData.MODS_DATA data)
        {
            var val_18;
            var val_19;
            var val_22;
            var val_23;
            this._modDictionary.Clear();
            val_18 = 1152921504689487872;
            val_19 = data.Entries.GetEnumerator();
            label_17:
            var val_20 = 0;
            val_20 = val_20 + 1;
            if(val_19.MoveNext() == false)
            {
                goto label_9;
            }
            
            var val_21 = 0;
            val_21 = val_21 + 1;
            new Game.ItemDefinition.Data.DataDefinitions.ModData() = new Game.ItemDefinition.Data.DataDefinitions.ModData(entry:  val_19.Current);
            this._modDictionary.Add(key:  (Game.ItemDefinition.Data.DataDefinitions.ModData)[1152921525279001136].Id, value:  new Game.ItemDefinition.Data.DataDefinitions.ModData());
            goto label_17;
            label_9:
            val_22 = 0;
            val_23 = 75;
            if(val_19 == null)
            {
                
            }
            else
            {
                    var val_22 = 0;
                val_22 = val_22 + 1;
                val_19.Dispose();
            }
            
            if( == 75)
            {
                    return;
            }
            
            if( == false)
            {
                    return;
            }
            
            val_19 = ???;
            val_23 = ???;
            val_18 = ???;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.ItemDefinition.Data.DataDefinitions.ModData GetModById(string id)
        {
            var val_3;
            if((this._modDictionary.ContainsKey(key:  id)) != false)
            {
                    Game.ItemDefinition.Data.DataDefinitions.ModData val_2 = this._modDictionary.Item[id];
                return (Game.ItemDefinition.Data.DataDefinitions.ModData)val_3;
            }
            
            val_3 = 0;
            return (Game.ItemDefinition.Data.DataDefinitions.ModData)val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void LoadCPUsFromServer(ProtoData.CPU_DATA data)
        {
            var val_18;
            var val_19;
            var val_22;
            var val_23;
            this._cpuDictionary.Clear();
            val_18 = 1152921504689487872;
            val_19 = data.Entries.GetEnumerator();
            label_17:
            var val_20 = 0;
            val_20 = val_20 + 1;
            if(val_19.MoveNext() == false)
            {
                goto label_9;
            }
            
            var val_21 = 0;
            val_21 = val_21 + 1;
            new Game.ItemDefinition.Data.DataDefinitions.CPUData() = new Game.ItemDefinition.Data.DataDefinitions.CPUData(data:  val_19.Current);
            this._cpuDictionary.Add(key:  (Game.ItemDefinition.Data.DataDefinitions.CPUData)[1152921525279324560].Id, value:  new Game.ItemDefinition.Data.DataDefinitions.CPUData());
            goto label_17;
            label_9:
            val_22 = 0;
            val_23 = 75;
            if(val_19 == null)
            {
                
            }
            else
            {
                    var val_22 = 0;
                val_22 = val_22 + 1;
                val_19.Dispose();
            }
            
            if( == 75)
            {
                    return;
            }
            
            if( == false)
            {
                    return;
            }
            
            val_19 = ???;
            val_23 = ???;
            val_18 = ???;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.ItemDefinition.Data.DataDefinitions.CPUData GetCPUById(string id)
        {
            var val_3;
            if((this._cpuDictionary.ContainsKey(key:  id)) != false)
            {
                    Game.ItemDefinition.Data.DataDefinitions.CPUData val_2 = this._cpuDictionary.Item[id];
                return (Game.ItemDefinition.Data.DataDefinitions.CPUData)val_3;
            }
            
            val_3 = 0;
            return (Game.ItemDefinition.Data.DataDefinitions.CPUData)val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void LoadPlushSuitsFromServer(ProtoData.PLUSHSUIT_DATA data)
        {
            var val_18;
            var val_19;
            var val_22;
            var val_23;
            this._plushSuitDictionary.Clear();
            val_18 = 1152921504689487872;
            val_19 = data.Entries.GetEnumerator();
            label_17:
            var val_20 = 0;
            val_20 = val_20 + 1;
            if(val_19.MoveNext() == false)
            {
                goto label_9;
            }
            
            var val_21 = 0;
            val_21 = val_21 + 1;
            new Game.ItemDefinition.Data.DataDefinitions.PlushSuitData() = new Game.ItemDefinition.Data.DataDefinitions.PlushSuitData(data:  val_19.Current);
            this._plushSuitDictionary.Add(key:  (Game.ItemDefinition.Data.DataDefinitions.PlushSuitData)[1152921525279647984].Id, value:  new Game.ItemDefinition.Data.DataDefinitions.PlushSuitData());
            goto label_17;
            label_9:
            val_22 = 0;
            val_23 = 75;
            if(val_19 == null)
            {
                
            }
            else
            {
                    var val_22 = 0;
                val_22 = val_22 + 1;
                val_19.Dispose();
            }
            
            if( == 75)
            {
                    return;
            }
            
            if( == false)
            {
                    return;
            }
            
            val_19 = ???;
            val_23 = ???;
            val_18 = ???;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.ItemDefinition.Data.DataDefinitions.PlushSuitData GetPlushSuitById(string id)
        {
            var val_3;
            if((this._plushSuitDictionary.ContainsKey(key:  id)) != false)
            {
                    Game.ItemDefinition.Data.DataDefinitions.PlushSuitData val_2 = this._plushSuitDictionary.Item[id];
                return (Game.ItemDefinition.Data.DataDefinitions.PlushSuitData)val_3;
            }
            
            val_3 = 0;
            return (Game.ItemDefinition.Data.DataDefinitions.PlushSuitData)val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void LoadDevicesFromServer(ProtoData.DEVICES_DATA data)
        {
            var val_18;
            var val_19;
            var val_22;
            var val_23;
            val_18 = 1152921504689487872;
            val_19 = data.Entries.GetEnumerator();
            label_16:
            var val_20 = 0;
            val_20 = val_20 + 1;
            if(val_19.MoveNext() == false)
            {
                goto label_8;
            }
            
            var val_21 = 0;
            val_21 = val_21 + 1;
            new Game.ItemDefinition.Data.DataDefinitions.DeviceData() = new Game.ItemDefinition.Data.DataDefinitions.DeviceData(data:  val_19.Current);
            this._deviceDictionary.Add(key:  (Game.ItemDefinition.Data.DataDefinitions.DeviceData)[1152921525279962192].Id, value:  new Game.ItemDefinition.Data.DataDefinitions.DeviceData());
            goto label_16;
            label_8:
            val_22 = 0;
            val_23 = 64;
            if(val_19 == null)
            {
                
            }
            else
            {
                    var val_22 = 0;
                val_22 = val_22 + 1;
                val_19.Dispose();
            }
            
            if( == 64)
            {
                    return;
            }
            
            if( == false)
            {
                    return;
            }
            
            val_19 = ???;
            val_23 = ???;
            val_18 = ???;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.ItemDefinition.Data.DataDefinitions.DeviceData GetDeviceById(string id)
        {
            var val_3;
            if((this._deviceDictionary.ContainsKey(key:  id)) != false)
            {
                    Game.ItemDefinition.Data.DataDefinitions.DeviceData val_2 = this._deviceDictionary.Item[id];
                return (Game.ItemDefinition.Data.DataDefinitions.DeviceData)val_3;
            }
            
            val_3 = 0;
            return (Game.ItemDefinition.Data.DataDefinitions.DeviceData)val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Game.ItemDefinition.Data.DataDefinitions.DeviceData> GetAllDevices()
        {
            var val_5;
            var val_6;
            System.Collections.Generic.List<Game.ItemDefinition.Data.DataDefinitions.DeviceData> val_1 = new System.Collections.Generic.List<Game.ItemDefinition.Data.DataDefinitions.DeviceData>();
            Dictionary.Enumerator<TKey, TValue> val_2 = this._deviceDictionary.GetEnumerator();
            label_4:
            if(((-801476840) & 1) == 0)
            {
                goto label_2;
            }
            
            UnityEngine.XR.ARSubsystems.TrackableId val_3 = 0.trackableId;
            val_1.Add(item:  val_3.m_SubId1);
            goto label_4;
            label_2:
            val_5 = 0;
            val_6 = 1;
            long val_4 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525280206616});
            if(( & 1) != 0)
            {
                    return val_1;
            }
            
            if( == 0)
            {
                    return val_1;
            }
            
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void LoadWearAndTearDataFromServer(ProtoData.WEARANDTEAR_DATA data)
        {
            var val_10;
            var val_11;
            var val_13;
            System.Collections.Generic.IEnumerator<T> val_2 = data.Entries.GetEnumerator();
            label_15:
            var val_10 = 0;
            val_10 = val_10 + 1;
            if(val_2.MoveNext() == false)
            {
                goto label_8;
            }
            
            var val_11 = 0;
            val_11 = val_11 + 1;
            new Game.ItemDefinition.Data.DataDefinitions.WearAndTearData() = new Game.ItemDefinition.Data.DataDefinitions.WearAndTearData(entry:  val_2.Current);
            this._wearAndTearData.Add(item:  new Game.ItemDefinition.Data.DataDefinitions.WearAndTearData());
            goto label_15;
            label_8:
            val_10 = 0;
            val_11 = 58;
            if(val_2 == null)
            {
                
            }
            else
            {
                    var val_12 = 0;
                val_12 = val_12 + 1;
                val_2.Dispose();
            }
            
            val_13 = null;
            val_13 = null;
            if((ItemDefinitions.<>c.<>9__37_0) == null)
            {
                goto label_32;
            }
            
            label_37:
            this._wearAndTearData.Sort(comparison:  ItemDefinitions.<>c.<>9__37_0);
            return;
            label_32:
            ItemDefinitions.<>c.<>9__37_0 = new System.Comparison<Game.ItemDefinition.Data.DataDefinitions.WearAndTearData>(object:  ItemDefinitions.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 ItemDefinitions.<>c::<LoadWearAndTearDataFromServer>b__37_0(Game.ItemDefinition.Data.DataDefinitions.WearAndTearData a, Game.ItemDefinition.Data.DataDefinitions.WearAndTearData b));
            if(this._wearAndTearData != null)
            {
                goto label_37;
            }
            
            goto label_37;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.ItemDefinition.Data.DataDefinitions.WearAndTearData GetWearAndTearData(int index)
        {
            int val_7;
            System.Collections.Generic.List<Game.ItemDefinition.Data.DataDefinitions.WearAndTearData> val_8;
            Game.ItemDefinition.Data.DataDefinitions.WearAndTearData val_9;
            var val_10;
            val_7 = index;
            val_8 = this._wearAndTearData;
            if(val_8.Count == 0)
            {
                goto label_2;
            }
            
            if((val_7 & 2147483648) != 0)
            {
                goto label_3;
            }
            
            val_8 = this._wearAndTearData;
            if(val_8.Count > val_7)
            {
                goto label_5;
            }
            
            label_3:
            val_8 = this._wearAndTearData.Count;
            val_7 = UnityEngine.Mathf.Clamp(value:  val_7, min:  0, max:  val_8 - 1);
            label_5:
            Game.ItemDefinition.Data.DataDefinitions.WearAndTearData val_6 = this._wearAndTearData.Item[val_7];
            return val_9;
            label_2:
            val_7 = 1152921505267175424;
            val_10 = null;
            val_10 = null;
            val_9 = Game.ItemDefinition.Container.ItemDefinitions.NullWearAndTear;
            return val_9;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void LoadEssenceDataFromServer(ProtoData.ESSENCE_DATA data)
        {
            var val_7;
            int val_2 = data.Entries.Count;
            if(val_2 >= 1)
            {
                    var val_7 = 0;
                do
            {
                this._essenceData.Add(item:  new Game.ItemDefinition.Data.DataDefinitions.EssenceData(data:  data.Entries.Item[0]));
                val_7 = val_7 + 1;
            }
            while(val_2 != val_7);
            
            }
            
            val_7 = null;
            val_7 = null;
            if((ItemDefinitions.<>c.<>9__39_0) == null)
            {
                goto label_10;
            }
            
            label_15:
            this._essenceData.Sort(comparison:  ItemDefinitions.<>c.<>9__39_0);
            return;
            label_10:
            ItemDefinitions.<>c.<>9__39_0 = new System.Comparison<Game.ItemDefinition.Data.DataDefinitions.EssenceData>(object:  ItemDefinitions.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 ItemDefinitions.<>c::<LoadEssenceDataFromServer>b__39_0(Game.ItemDefinition.Data.DataDefinitions.EssenceData a, Game.ItemDefinition.Data.DataDefinitions.EssenceData b));
            if(this._essenceData != null)
            {
                goto label_15;
            }
            
            goto label_15;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.ItemDefinition.Data.DataDefinitions.EssenceData GetEssenceDataForAmount(int amount)
        {
            System.Collections.Generic.List<Game.ItemDefinition.Data.DataDefinitions.EssenceData> val_3 = this._essenceData;
            val_3 = val_3.Count - 1;
            do
            {
                if((val_3 & 2147483648) != 0)
            {
                    return this._essenceData.Item[0];
            }
            
                val_3 = val_3 - 1;
            }
            while(val_2.Essence >= amount);
            
            return (Game.ItemDefinition.Data.DataDefinitions.EssenceData)this._essenceData.Item[val_3];
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void LoadAttackDataFromServer(ProtoData.ATTACK_DATA data)
        {
            var val_24;
            var val_25;
            var val_26;
            var val_27;
            var val_30;
            val_25 = data;
            if(val_25 == null)
            {
                    return;
            }
            
            val_26 = 1152921504685174784;
            val_27 = 1152921525280984192;
            val_25 = val_25.Entries.GetEnumerator();
            label_19:
            var val_26 = 0;
            val_26 = val_26 + 1;
            if(val_25.MoveNext() == false)
            {
                goto label_8;
            }
            
            var val_27 = 0;
            val_27 = val_27 + 1;
            T val_6 = val_25.Current;
            if(((val_6 == 0) || ((System.String.IsNullOrWhiteSpace(value:  val_6.Logical)) == true)) || ((this._attackProfileDictionary.ContainsKey(key:  val_6.Logical)) == true))
            {
                goto label_19;
            }
            
            new Game.ItemDefinition.Data.DataDefinitions.AttackProfile() = new Game.ItemDefinition.Data.DataDefinitions.AttackProfile(rawSettings:  val_6);
            this._attackProfileDictionary.Add(key:  val_6.Logical, value:  new Game.ItemDefinition.Data.DataDefinitions.AttackProfile());
            goto label_19;
            label_8:
            val_30 = 0;
            val_24 = 103;
            if(val_25 == null)
            {
                
            }
            else
            {
                    var val_28 = 0;
                val_28 = val_28 + 1;
                val_25.Dispose();
            }
            
            if( == 103)
            {
                    return;
            }
            
            if( == false)
            {
                    return;
            }
            
            val_25 = ???;
            val_24 = ???;
            val_26 = ???;
            val_27 = ???;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.ItemDefinition.Data.DataDefinitions.AttackProfile GetAttackProfile(string profileId)
        {
            string val_3;
            Game.ItemDefinition.Data.DataDefinitions.AttackProfile val_4;
            var val_5;
            val_3 = profileId;
            if((this._attackProfileDictionary.ContainsKey(key:  val_3)) != false)
            {
                    Game.ItemDefinition.Data.DataDefinitions.AttackProfile val_2 = this._attackProfileDictionary.Item[val_3];
                return val_4;
            }
            
            val_3 = 1152921505267175424;
            val_5 = null;
            val_5 = null;
            val_4 = Game.ItemDefinition.Container.ItemDefinitions.NullConfig;
            return val_4;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void LoadProgressionDataFromServer(ProtoData.PROGRESSION_DATA progressionData)
        {
            var val_21;
            var val_22;
            var val_23;
            var val_26;
            var val_27;
            this._progressionDataList.Clear();
            val_21 = 1152921504689487872;
            val_22 = 1152921525281328096;
            val_23 = progressionData.Entries.GetEnumerator();
            label_21:
            var val_23 = 0;
            val_23 = val_23 + 1;
            if(val_23.MoveNext() == false)
            {
                goto label_9;
            }
            
            var val_24 = 0;
            val_24 = val_24 + 1;
            new Game.ItemDefinition.Container.ProgressionData() = new Game.ItemDefinition.Container.ProgressionData(entry:  val_23.Current);
            this._progressionDataList.Add(item:  new Game.ItemDefinition.Container.ProgressionData());
            if((System.String.op_Equality(a:  (Game.ItemDefinition.Container.ProgressionData)[1152921525281426160].ModSlotUnlock, b:  "Yes")) != false)
            {
                    this._modUnlockStreak.Add(item:  (Game.ItemDefinition.Container.ProgressionData)[1152921525281426160].MaxStreak);
            }
            
            if((System.String.op_Equality(a:  (Game.ItemDefinition.Container.ProgressionData)[1152921525281426160].EndoskeletonUnlock, b:  "Yes")) == false)
            {
                goto label_21;
            }
            
            this._slotUnlockStreak.Add(item:  (Game.ItemDefinition.Container.ProgressionData)[1152921525281426160].MaxStreak);
            goto label_21;
            label_9:
            val_26 = 0;
            val_27 = 139;
            if(val_23 == null)
            {
                
            }
            else
            {
                    var val_25 = 0;
                val_25 = val_25 + 1;
                val_23.Dispose();
            }
            
            if( == 139)
            {
                    return;
            }
            
            if( == false)
            {
                    return;
            }
            
            val_23 = ???;
            val_27 = ???;
            val_21 = ???;
            val_22 = ???;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.ItemDefinition.Container.ProgressionData GetProgressionDataForMaxStreak(int maxStreak)
        {
            var val_4;
            if(this._progressionDataList != null)
            {
                    if(this._progressionDataList.Count > maxStreak)
            {
                    val_4 = this._progressionDataList.Item[maxStreak];
                return (Game.ItemDefinition.Container.ProgressionData)val_4;
            }
            
            }
            
            Game.ItemDefinition.Container.ProgressionData val_3 = null;
            val_4 = val_3;
            val_3 = new Game.ItemDefinition.Container.ProgressionData(entry:  0);
            return (Game.ItemDefinition.Container.ProgressionData)val_4;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int GetNumModSlotsUnlocked(int bestStreak)
        {
            var val_3;
            var val_6;
            var val_7;
            var val_8;
            List.Enumerator<T> val_1 = this._modUnlockStreak.GetEnumerator();
            val_6 = 0;
            goto label_2;
            label_4:
            if(val_3.region > bestStreak)
            {
                goto label_3;
            }
            
            val_6 = 1;
            label_2:
            if(((-800005680) & 1) != 0)
            {
                goto label_4;
            }
            
            label_3:
            val_7 = 0;
            val_8 = 1;
            long val_5 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525281677776});
            if(( & 1) != 0)
            {
                    return (int)val_6;
            }
            
            if( == 0)
            {
                    return (int)val_6;
            }
            
            return (int)val_6;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int GetNumWorkshopSlotsUnlocked(int bestStreak)
        {
            var val_3;
            var val_6;
            var val_7;
            var val_8;
            List.Enumerator<T> val_1 = this._slotUnlockStreak.GetEnumerator();
            val_6 = 0;
            goto label_2;
            label_4:
            if(val_3.region > bestStreak)
            {
                goto label_3;
            }
            
            val_6 = 1;
            label_2:
            if(((-799877296) & 1) != 0)
            {
                goto label_4;
            }
            
            label_3:
            val_7 = 0;
            val_8 = 1;
            long val_5 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525281806160});
            if(( & 1) != 0)
            {
                    return (int)val_6;
            }
            
            if( == 0)
            {
                    return (int)val_6;
            }
            
            return (int)val_6;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<int> GetStreaksForSlots()
        {
            return (System.Collections.Generic.List<System.Int32>)this._slotUnlockStreak;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<int> GetStreaksForMods()
        {
            return (System.Collections.Generic.List<System.Int32>)this._modUnlockStreak;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void LoadRewardDataFromServer(ProtoData.CONFIG_DATA.Types.ENTRY configDataEntry)
        {
            .rewardIconName = configDataEntry.ArtAssets.UI.EssenceRewardIconName;
            this._rewardDictionary.Add(key:  0, value:  new Game.ItemDefinition.Container.RewardsData());
            .rewardIconName = configDataEntry.ArtAssets.UI.PartsRewardIconName;
            this._rewardDictionary.Add(key:  1, value:  new Game.ItemDefinition.Container.RewardsData());
            .rewardIconName = configDataEntry.ArtAssets.UI.FazCoinsRewardIconName;
            this._rewardDictionary.Add(key:  5, value:  new Game.ItemDefinition.Container.RewardsData());
            .rewardIconName = configDataEntry.ArtAssets.UI.EndoskeletonSlotRewardIconName;
            this._rewardDictionary.Add(key:  6, value:  new Game.ItemDefinition.Container.RewardsData());
            .rewardIconName = configDataEntry.ArtAssets.UI.ModSlotRewardIconName;
            this._rewardDictionary.Add(key:  7, value:  new Game.ItemDefinition.Container.RewardsData());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.ItemDefinition.Container.RewardsData GetRewardsDataByCategory(Game.ItemDefinition.Container.RewardCategory rewardCategory)
        {
            var val_3;
            if((this._rewardDictionary.ContainsKey(key:  rewardCategory)) != false)
            {
                    Game.ItemDefinition.Container.RewardsData val_2 = this._rewardDictionary.Item[rewardCategory];
                return (Game.ItemDefinition.Container.RewardsData)val_3;
            }
            
            val_3 = 0;
            return (Game.ItemDefinition.Container.RewardsData)val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void LoadSequentialRewardsDataFromServer(ProtoData.SEQUENTIAL_REWARDS_DATA data)
        {
            var val_33;
            var val_34;
            var val_36;
            this._sequentialRewardsData.Clear();
            System.Collections.Generic.IEnumerator<T> val_2 = data.Entries.GetEnumerator();
            label_35:
            var val_33 = 0;
            val_33 = val_33 + 1;
            if(val_2.MoveNext() == false)
            {
                goto label_9;
            }
            
            var val_34 = 0;
            val_34 = val_34 + 1;
            T val_6 = val_2.Current;
            if((this._sequentialRewardsData.ContainsKey(key:  val_6.Season)) != true)
            {
                    System.Collections.Generic.List<Game.ItemDefinition.Container.SequentialRewardsData> val_10 = new System.Collections.Generic.List<Game.ItemDefinition.Container.SequentialRewardsData>();
                this._sequentialRewardsData.Add(key:  val_6.Season, value:  null);
            }
            
            new Game.ItemDefinition.Container.SequentialRewardsData() = new System.Object();
            .season = val_6.Season;
            .sequence = UnityEngine.Mathf.RoundToInt(f:  (float)val_6.Sequence);
            .cooldown = UnityEngine.Mathf.RoundToInt(f:  (float)val_6.Cooldown);
            .iconRef = val_6.IconRef;
            .localizationRef = val_6.LocRef;
            .logical = val_6.Logical;
            .quantity = UnityEngine.Mathf.RoundToInt(f:  (float)val_6.Quantity);
            .rewardSubtype = val_6.RewardSubtype;
            .rewardType = val_6.RewardType;
            this._sequentialRewardsData.Item[val_6.Season].Add(item:  new Game.ItemDefinition.Container.SequentialRewardsData());
            goto label_35;
            label_9:
            val_33 = 0;
            val_34 = 254;
            if(val_2 == null)
            {
                
            }
            else
            {
                    var val_35 = 0;
                val_35 = val_35 + 1;
                val_2.Dispose();
            }
            
            if( == 254)
            {
                    val_34 = 0;
            }
            else
            {
                    if( != false)
            {
                    val_33 = 0;
            }
            
            }
            
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_28 = this._sequentialRewardsData.Keys.GetEnumerator();
            label_76:
            if(((-798926136) & 1) == 0)
            {
                goto label_73;
            }
            
            System.Comparison<Game.ItemDefinition.Container.SequentialRewardsData> val_31 = new System.Comparison<Game.ItemDefinition.Container.SequentialRewardsData>(object:  this, method:  System.Int32 Game.ItemDefinition.Container.ItemDefinitions::Sort(Game.ItemDefinition.Container.SequentialRewardsData x, Game.ItemDefinition.Container.SequentialRewardsData y));
            this._sequentialRewardsData.Item[0.emailUIDataHandler].Sort(comparison:  null);
            goto label_76;
            label_73:
            val_36 = 337;
            long val_32 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525282757320});
            if( == 0)
            {
                    return;
            }
            
            if( == 0)
            {
                    return;
            }
            
            if( == 337)
            {
                    return;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.ItemDefinition.Container.SequentialRewardsData GetSequentialRewardsBySeasonAndSequence(string seasonName, int index)
        {
            System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<Game.ItemDefinition.Container.SequentialRewardsData>> val_6;
            var val_7;
            val_6 = this;
            if((this._sequentialRewardsData.ContainsKey(key:  seasonName)) != false)
            {
                    if(this._sequentialRewardsData.Item[seasonName].Count > index)
            {
                    val_6 = this._sequentialRewardsData;
                Game.ItemDefinition.Container.SequentialRewardsData val_5 = val_6.Item[seasonName].Item[index];
                return (Game.ItemDefinition.Container.SequentialRewardsData)val_7;
            }
            
            }
            
            val_7 = 0;
            return (Game.ItemDefinition.Container.SequentialRewardsData)val_7;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int Sort(Game.ItemDefinition.Container.SequentialRewardsData x, Game.ItemDefinition.Container.SequentialRewardsData y)
        {
            return (int)x.sequence - y.sequence;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetPurchasedSlots(int slots)
        {
            this._purchasedSlots = slots;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void LoadRemnantDebuffDataFromServer(ProtoData.REMNANT_DEBUFF_DATA data)
        {
            var val_18;
            System.Collections.Generic.List<Game.ItemDefinition.Container.RemnantDebuffEntry> val_19;
            var val_20;
            var val_22;
            var val_24;
            var val_26;
            val_19 = this;
            if(data == null)
            {
                    return;
            }
            
            this._remnantDebuffLookup.Clear();
            System.Collections.Generic.IEnumerator<T> val_2 = data.Entries.GetEnumerator();
            val_20 = 1152921505267122176;
            goto label_10;
            label_26:
            var val_19 = 0;
            val_19 = val_19 + 1;
            T val_4 = val_2.Current;
            if(val_4 != 0)
            {
                    new Game.ItemDefinition.Container.RemnantDebuffEntry() = new System.Object();
                REMNANTDEBUFF val_6 = val_4.RemnantDebuff;
                if(val_6 != null)
            {
                    double val_8 = (val_6 == 0) ? 0 : (val_6).RemnantCollected;
            }
            
                val_22 = 0;
                if(((-798240464) & 1) != 0)
            {
                    val_22 = 0.South;
            }
            
                .RemnantCollected = (int)val_22;
                REMNANTDEBUFF val_10 = val_4.RemnantDebuff;
                if(val_10 != null)
            {
                    double val_12 = (val_10 == 0) ? 0 : (val_10).ShockWindowIncrease;
            }
            
                float val_20 = (float)0.South;
                .ShockWindowIncrease = val_20;
                val_20 = val_20 * 100f;
                .PlayerFacingPercent = val_20 + "%"("%");
                this._remnantDebuffLookup.Add(item:  new Game.ItemDefinition.Container.RemnantDebuffEntry());
                val_20 = 1152921505267122176;
            }
            
            label_10:
            var val_21 = 0;
            val_21 = val_21 + 1;
            if(val_2.MoveNext() == true)
            {
                goto label_26;
            }
            
            val_18 = 0;
            val_24 = 283;
            if(val_2 == null)
            {
                
            }
            else
            {
                    var val_22 = 0;
                val_22 = val_22 + 1;
                val_2.Dispose();
            }
            
            val_19 = this._remnantDebuffLookup;
            val_26 = null;
            val_26 = null;
            if((ItemDefinitions.<>c.<>9__56_0) == null)
            {
                goto label_49;
            }
            
            label_54:
            val_19.Sort(comparison:  ItemDefinitions.<>c.<>9__56_0);
            return;
            label_49:
            ItemDefinitions.<>c.<>9__56_0 = new System.Comparison<Game.ItemDefinition.Container.RemnantDebuffEntry>(object:  ItemDefinitions.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 ItemDefinitions.<>c::<LoadRemnantDebuffDataFromServer>b__56_0(Game.ItemDefinition.Container.RemnantDebuffEntry a, Game.ItemDefinition.Container.RemnantDebuffEntry b));
            if(val_19 != null)
            {
                goto label_54;
            }
            
            goto label_54;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.ItemDefinition.Container.RemnantDebuffEntry GetEntryForRemnant(int remnant)
        {
            System.Collections.Generic.List<Game.ItemDefinition.Container.RemnantDebuffEntry> val_4;
            var val_5;
            val_4 = remnant;
            int val_4 = this._remnantDebuffLookup.Count;
            label_5:
            val_4 = val_4 - 1;
            if((val_4 & 2147483648) != 0)
            {
                goto label_2;
            }
            
            Game.ItemDefinition.Container.RemnantDebuffEntry val_2 = this._remnantDebuffLookup.Item[val_4];
            if(val_2.RemnantCollected > val_4)
            {
                goto label_5;
            }
            
            val_4 = this._remnantDebuffLookup;
            Game.ItemDefinition.Container.RemnantDebuffEntry val_3 = val_4.Item[val_4];
            return (Game.ItemDefinition.Container.RemnantDebuffEntry)val_5;
            label_2:
            val_5 = 0;
            return (Game.ItemDefinition.Container.RemnantDebuffEntry)val_5;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void LoadSeasonDataFromServer(ProtoData.SEASONAL_DATA alertData)
        {
            var val_18;
            var val_19;
            var val_22;
            var val_23;
            val_18 = 1152921504689487872;
            val_19 = alertData.Entries.GetEnumerator();
            label_17:
            var val_20 = 0;
            val_20 = val_20 + 1;
            if(val_19.MoveNext() == false)
            {
                goto label_8;
            }
            
            var val_21 = 0;
            val_21 = val_21 + 1;
            T val_6 = val_19.Current;
            this._seasonalData.Add(key:  val_6.Logical, value:  val_6.Mechanics);
            goto label_17;
            label_8:
            val_22 = 0;
            val_23 = 64;
            if(val_19 == null)
            {
                
            }
            else
            {
                    var val_22 = 0;
                val_22 = val_22 + 1;
                val_19.Dispose();
            }
            
            if( == 64)
            {
                    return;
            }
            
            if( == false)
            {
                    return;
            }
            
            val_19 = ???;
            val_23 = ???;
            val_18 = ???;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string GetSequentialRewardKeyBySeason(string logical)
        {
            if((this._seasonalData.ContainsKey(key:  logical)) == false)
            {
                    return (string)System.String.alignConst;
            }
            
            MECHANICS val_2 = this._seasonalData.Item[logical];
            if(val_2 != null)
            {
                    return val_2.SequentialRewards;
            }
            
            return val_2.SequentialRewards;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, float> GetModifiersForAttackProfile(Game.ItemDefinition.Data.DataDefinitions.EndoskeletonData endoskeleton, int wearAndTear)
        {
            var val_8;
            var val_17;
            var val_18;
            System.Collections.Generic.Dictionary<System.String, System.Single> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Single>();
            Game.ItemDefinition.Data.DataDefinitions.EssenceData val_2 = this.GetEssenceDataForAmount(amount:  endoskeleton.numEssence);
            val_1.Add(key:  "BatteryDrainRate", value:  val_2.BatteryMult);
            Game.ItemDefinition.Data.DataDefinitions.WearAndTearData val_3 = this.GetWearAndTearData(index:  wearAndTear);
            if(val_3 == null)
            {
                goto label_4;
            }
            
            if(val_1 != null)
            {
                goto label_39;
            }
            
            label_40:
            label_39:
            val_1.Add(key:  "HaywireCircleActivation", value:  val_3.HaywireCircleChance);
            if(val_3 == null)
            {
                goto label_6;
            }
            
            if(val_1 != null)
            {
                goto label_41;
            }
            
            label_42:
            label_41:
            val_1.Add(key:  "HaywireCircleActivationModifier", value:  val_3.HaywireCircleModifier);
            if(val_3 == null)
            {
                goto label_8;
            }
            
            if(val_1 != null)
            {
                goto label_43;
            }
            
            label_44:
            label_43:
            val_1.Add(key:  "HaywirePauseActivation", value:  val_3.HaywirePauseChance);
            if(val_3 == null)
            {
                goto label_10;
            }
            
            if(val_1 != null)
            {
                goto label_45;
            }
            
            label_46:
            label_45:
            val_1.Add(key:  "HaywirePauseActivationModifier", value:  val_3.HaywirePauseModifier);
            val_17 = 0;
            val_18 = 0;
            goto label_12;
            label_38:
            if((this.GetModById(id:  endoskeleton.mods.Item[0])) == null)
            {
                goto label_35;
            }
            
            List.Enumerator<T> val_6 = val_5.Effects.GetEnumerator();
            do
            {
                label_24:
                if(((-797540848) & 1) == 0)
            {
                goto label_25;
            }
            
                GameUI.EmailUIDataHandler val_9 = val_8.emailUIDataHandler;
            }
            while((System.String.IsNullOrEmpty(value:  val_9._masterDomain)) == true);
            
            if((val_1.ContainsKey(key:  val_9._masterDomain)) != true)
            {
                    val_1.Add(key:  val_9._masterDomain, value:  1f);
            }
            
            float val_12 = val_1.Item[val_9._masterDomain];
            val_12 = val_12 * val_9._serverGameUIDataModel;
            val_1.set_Item(key:  val_9._masterDomain, value:  val_12);
            goto label_24;
            label_25:
            long val_13 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525284142608});
            if(((321 == 0) ? 321 : 321) == 321)
            {
                
            }
            else
            {
                    if( != 0)
            {
                    val_17 = 0;
            }
            
            }
            
            label_35:
            val_18 = 1;
            label_12:
            if(val_18 < endoskeleton.mods.Count)
            {
                goto label_38;
            }
            
            return val_1;
            label_4:
            if(val_1 != null)
            {
                goto label_39;
            }
            
            goto label_40;
            label_6:
            if(val_1 != null)
            {
                goto label_41;
            }
            
            goto label_42;
            label_8:
            if(val_1 != null)
            {
                goto label_43;
            }
            
            goto label_44;
            label_10:
            if(val_1 != null)
            {
                goto label_45;
            }
            
            goto label_46;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string PrintAttackProfileModDictionary(System.Collections.Generic.Dictionary<string, float> mods)
        {
            int val_11;
            string val_12;
            var val_13;
            val_11 = System.String.alignConst;
            Dictionary.Enumerator<TKey, TValue> val_1 = mods.GetEnumerator();
            label_3:
            if(((-797335544) & 1) == 0)
            {
                goto label_2;
            }
            
            UnityEngine.XR.ARSubsystems.TrackableId val_2 = 0f.trackableId;
            string val_8 = val_11 + ((System.String.IsNullOrWhiteSpace(value:  val_11)) != true) ? "{" : ","(((System.String.IsNullOrWhiteSpace(value:  val_11)) != true) ? "{" : ",")(val_11 + ((System.String.IsNullOrWhiteSpace(value:  val_11)) != true) ? "{" : ","(((System.String.IsNullOrWhiteSpace(value:  val_11)) != true) ? "{" : ",")) + System.String.Format(format:  "\"{0}\":{1}", arg0:  val_2.m_SubId1.System.IConvertible.ToUInt64(provider:  public System.String System.Collections.Generic.KeyValuePair<System.String, System.Single>::get_Key()), arg1:  0f)(System.String.Format(format:  "\"{0}\":{1}", arg0:  val_2.m_SubId1.System.IConvertible.ToUInt64(provider:  public System.String System.Collections.Generic.KeyValuePair<System.String, System.Single>::get_Key()), arg1:  0f));
            goto label_3;
            label_2:
            val_12 = 0;
            val_13 = 1;
            long val_9 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525284347912});
            return (string) + "}";
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ItemDefinitions()
        {
            this._modDictionary = new System.Collections.Generic.Dictionary<System.String, Game.ItemDefinition.Data.DataDefinitions.ModData>();
            this._cpuDictionary = new System.Collections.Generic.Dictionary<System.String, Game.ItemDefinition.Data.DataDefinitions.CPUData>();
            this._attackProfileDictionary = new System.Collections.Generic.Dictionary<System.String, Game.ItemDefinition.Data.DataDefinitions.AttackProfile>();
            this._plushSuitDictionary = new System.Collections.Generic.Dictionary<System.String, Game.ItemDefinition.Data.DataDefinitions.PlushSuitData>();
            this._deviceDictionary = new System.Collections.Generic.Dictionary<System.String, Game.ItemDefinition.Data.DataDefinitions.DeviceData>();
            this._rewardDictionary = new System.Collections.Generic.Dictionary<Game.ItemDefinition.Container.RewardCategory, Game.ItemDefinition.Container.RewardsData>();
            this._wearAndTearData = new System.Collections.Generic.List<Game.ItemDefinition.Data.DataDefinitions.WearAndTearData>();
            this._essenceData = new System.Collections.Generic.List<Game.ItemDefinition.Data.DataDefinitions.EssenceData>();
            this._progressionDataList = new System.Collections.Generic.List<Game.ItemDefinition.Container.ProgressionData>();
            this._modUnlockStreak = new System.Collections.Generic.List<System.Int32>();
            this._slotUnlockStreak = new System.Collections.Generic.List<System.Int32>();
            this._remnantDebuffLookup = new System.Collections.Generic.List<Game.ItemDefinition.Container.RemnantDebuffEntry>();
            this._sequentialRewardsData = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<Game.ItemDefinition.Container.SequentialRewardsData>>();
            this._seasonalData = new System.Collections.Generic.Dictionary<System.String, MECHANICS>();
            this._inboxDatas = new System.Collections.Generic.List<Game.ItemDefinition.Data.DataDefinitions.InboxData>();
            this._alertInboxDatas = new System.Collections.Generic.List<Game.ItemDefinition.Data.DataDefinitions.AlertInboxData>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static ItemDefinitions()
        {
            Game.ItemDefinition.Container.ItemDefinitions.NullWearAndTear = new Game.ItemDefinition.Data.DataDefinitions.WearAndTearData(entry:  0);
            Game.ItemDefinition.Container.ItemDefinitions.NullConfig = new Game.ItemDefinition.Data.DataDefinitions.AttackProfile(rawSettings:  0);
        }
    
    }

}
