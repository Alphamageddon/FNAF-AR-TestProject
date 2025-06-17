using UnityEngine;

namespace Game.MasterData
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class GetAccessToData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.MasterData.MasterData <_masterData>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<Game.MasterData.GetAccessToData.ReturnConfigDataEntry> _configDataCallbacks;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<System.Type, Google.Protobuf.IMessage> _data;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<System.Type, System.Collections.Generic.List<Game.MasterData.GetAccessToData.ReturnData>> _dataCallbacks;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.MasterData.KeyValueAccess KeyValueAccess;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.MasterData.MasterData _masterData { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.MasterData.MasterData get__masterData()
        {
            return (Game.MasterData.MasterData)this.<_masterData>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetAccessToData(Game.MasterData.MasterData masterData)
        {
            this._configDataCallbacks = new System.Collections.Generic.List<ReturnConfigDataEntry>();
            this._data = new System.Collections.Generic.Dictionary<System.Type, Google.Protobuf.IMessage>();
            this._dataCallbacks = new System.Collections.Generic.Dictionary<System.Type, System.Collections.Generic.List<ReturnData>>();
            this.<_masterData>k__BackingField = masterData;
            this.KeyValueAccess = new Game.MasterData.KeyValueAccess();
            this.<_masterData>k__BackingField.add_ConfigDataSet(value:  new System.Action<ProtoData.CONFIG_DATA>(object:  this, method:  System.Void Game.MasterData.GetAccessToData::MasterDataOnConfigDataSet(ProtoData.CONFIG_DATA configData)));
            this.<_masterData>k__BackingField.add_KeyValueDataSet(value:  new System.Action<ProtoData.KEY_VALUE_DATA>(object:  this, method:  System.Void Game.MasterData.GetAccessToData::MasterDataOnKeyValueDataSet(ProtoData.KEY_VALUE_DATA keyValueData)));
            this.<_masterData>k__BackingField.add_AlertDataSet(value:  new System.Action<ProtoData.ALERT_DATA>(object:  this, method:  System.Void Game.MasterData.GetAccessToData::MasterDataOnDataSet<ProtoData.ALERT_DATA>(ProtoData.ALERT_DATA data)));
            this.<_masterData>k__BackingField.add_AudioDataSet(value:  new System.Action<ProtoData.AUDIO_DATA>(object:  this, method:  System.Void Game.MasterData.GetAccessToData::MasterDataOnDataSet<ProtoData.AUDIO_DATA>(ProtoData.AUDIO_DATA data)));
            this.<_masterData>k__BackingField.add_DevicesDataSet(value:  new System.Action<ProtoData.DEVICES_DATA>(object:  this, method:  System.Void Game.MasterData.GetAccessToData::MasterDataOnDataSet<ProtoData.DEVICES_DATA>(ProtoData.DEVICES_DATA data)));
            this.<_masterData>k__BackingField.add_TutorialDataSet(value:  new System.Action<ProtoData.TUTORIAL_DATA>(object:  this, method:  System.Void Game.MasterData.GetAccessToData::MasterDataOnDataSet<ProtoData.TUTORIAL_DATA>(ProtoData.TUTORIAL_DATA data)));
            this.<_masterData>k__BackingField.add_EssenceDataSet(value:  new System.Action<ProtoData.ESSENCE_DATA>(object:  this, method:  System.Void Game.MasterData.GetAccessToData::MasterDataOnDataSet<ProtoData.ESSENCE_DATA>(ProtoData.ESSENCE_DATA data)));
            this.<_masterData>k__BackingField.add_EssenceTypesDataSet(value:  new System.Action<ProtoData.ESSENCE_TYPES_DATA>(object:  this, method:  System.Void Game.MasterData.GetAccessToData::MasterDataOnDataSet<ProtoData.ESSENCE_TYPES_DATA>(ProtoData.ESSENCE_TYPES_DATA data)));
            this.<_masterData>k__BackingField.add_FTUEDataSet(value:  new System.Action<ProtoData.FTUE_DATA>(object:  this, method:  System.Void Game.MasterData.GetAccessToData::MasterDataOnDataSet<ProtoData.FTUE_DATA>(ProtoData.FTUE_DATA data)));
            this.<_masterData>k__BackingField.add_LoginABSDataSet(value:  new System.Action<ProtoData.LOGIN_ABS_DATA>(object:  this, method:  System.Void Game.MasterData.GetAccessToData::MasterDataOnDataSet<ProtoData.LOGIN_ABS_DATA>(ProtoData.LOGIN_ABS_DATA data)));
            this.<_masterData>k__BackingField.add_LoginRepeatDataSet(value:  new System.Action<ProtoData.LOGIN_REPEAT_DATA>(object:  this, method:  System.Void Game.MasterData.GetAccessToData::MasterDataOnDataSet<ProtoData.LOGIN_REPEAT_DATA>(ProtoData.LOGIN_REPEAT_DATA data)));
            this.<_masterData>k__BackingField.add_MetricsDataSet(value:  new System.Action<ProtoData.METRICS_DATA>(object:  this, method:  System.Void Game.MasterData.GetAccessToData::MasterDataOnDataSet<ProtoData.METRICS_DATA>(ProtoData.METRICS_DATA data)));
            this.<_masterData>k__BackingField.add_ModsDataSet(value:  new System.Action<ProtoData.MODS_DATA>(object:  this, method:  System.Void Game.MasterData.GetAccessToData::MasterDataOnDataSet<ProtoData.MODS_DATA>(ProtoData.MODS_DATA data)));
            this.<_masterData>k__BackingField.add_ProgressionDataSet(value:  new System.Action<ProtoData.PROGRESSION_DATA>(object:  this, method:  System.Void Game.MasterData.GetAccessToData::MasterDataOnDataSet<ProtoData.PROGRESSION_DATA>(ProtoData.PROGRESSION_DATA data)));
            this.<_masterData>k__BackingField.add_StaticDataSet(value:  new System.Action<ProtoData.STATIC_DATA>(object:  this, method:  System.Void Game.MasterData.GetAccessToData::MasterDataOnDataSet<ProtoData.STATIC_DATA>(ProtoData.STATIC_DATA data)));
            this.<_masterData>k__BackingField.add_WearAndTearDataSet(value:  new System.Action<ProtoData.WEARANDTEAR_DATA>(object:  this, method:  System.Void Game.MasterData.GetAccessToData::MasterDataOnDataSet<ProtoData.WEARANDTEAR_DATA>(ProtoData.WEARANDTEAR_DATA data)));
            this.<_masterData>k__BackingField.add_CPUDataSet(value:  new System.Action<ProtoData.CPU_DATA>(object:  this, method:  System.Void Game.MasterData.GetAccessToData::MasterDataOnDataSet<ProtoData.CPU_DATA>(ProtoData.CPU_DATA data)));
            this.<_masterData>k__BackingField.add_PlushSuitDataSet(value:  new System.Action<ProtoData.PLUSHSUIT_DATA>(object:  this, method:  System.Void Game.MasterData.GetAccessToData::MasterDataOnDataSet<ProtoData.PLUSHSUIT_DATA>(ProtoData.PLUSHSUIT_DATA data)));
            this.<_masterData>k__BackingField.add_AttackDataSet(value:  new System.Action<ProtoData.ATTACK_DATA>(object:  this, method:  System.Void Game.MasterData.GetAccessToData::MasterDataOnDataSet<ProtoData.ATTACK_DATA>(ProtoData.ATTACK_DATA data)));
            this.<_masterData>k__BackingField.add_LocDataSet(value:  new System.Action<ProtoData.LOC_DATA>(object:  this, method:  System.Void Game.MasterData.GetAccessToData::MasterDataOnDataSet<ProtoData.LOC_DATA>(ProtoData.LOC_DATA data)));
            this.<_masterData>k__BackingField.add_StoreDataSet(value:  new System.Action<ProtoData.STORE_DATA>(object:  this, method:  System.Void Game.MasterData.GetAccessToData::MasterDataOnDataSet<ProtoData.STORE_DATA>(ProtoData.STORE_DATA data)));
            this.<_masterData>k__BackingField.add_RemnantDebuffDataSet(value:  new System.Action<ProtoData.REMNANT_DEBUFF_DATA>(object:  this, method:  System.Void Game.MasterData.GetAccessToData::MasterDataOnDataSet<ProtoData.REMNANT_DEBUFF_DATA>(ProtoData.REMNANT_DEBUFF_DATA data)));
            this.<_masterData>k__BackingField.add_ModCategoryDataSet(value:  new System.Action<ProtoData.MODCATEGORIES_DATA>(object:  this, method:  System.Void Game.MasterData.GetAccessToData::MasterDataOnDataSet<ProtoData.MODCATEGORIES_DATA>(ProtoData.MODCATEGORIES_DATA data)));
            this.<_masterData>k__BackingField.add_ServerBlockingErrorDataSet(value:  new System.Action<ProtoData.SERVERBLOCKINGERROR_DATA>(object:  this, method:  System.Void Game.MasterData.GetAccessToData::MasterDataOnDataSet<ProtoData.SERVERBLOCKINGERROR_DATA>(ProtoData.SERVERBLOCKINGERROR_DATA data)));
            this.<_masterData>k__BackingField.add_SequentialRewardsDataSet(value:  new System.Action<ProtoData.SEQUENTIAL_REWARDS_DATA>(object:  this, method:  System.Void Game.MasterData.GetAccessToData::MasterDataOnDataSet<ProtoData.SEQUENTIAL_REWARDS_DATA>(ProtoData.SEQUENTIAL_REWARDS_DATA data)));
            this.<_masterData>k__BackingField.add_SeasonalDataSet(value:  new System.Action<ProtoData.SEASONAL_DATA>(object:  this, method:  System.Void Game.MasterData.GetAccessToData::MasterDataOnDataSet<ProtoData.SEASONAL_DATA>(ProtoData.SEASONAL_DATA data)));
            this.<_masterData>k__BackingField.add_SeasonalAssetsDataSet(value:  new System.Action<ProtoData.SEASONAL_ASSETS_DATA>(object:  this, method:  System.Void Game.MasterData.GetAccessToData::MasterDataOnDataSet<ProtoData.SEASONAL_ASSETS_DATA>(ProtoData.SEASONAL_ASSETS_DATA data)));
            this.<_masterData>k__BackingField.add_SequentialRewardsDataSet(value:  new System.Action<ProtoData.SEQUENTIAL_REWARDS_DATA>(object:  this, method:  System.Void Game.MasterData.GetAccessToData::MasterDataOnDataSet<ProtoData.SEQUENTIAL_REWARDS_DATA>(ProtoData.SEQUENTIAL_REWARDS_DATA data)));
            this.<_masterData>k__BackingField.add_InboxDataSet(value:  new System.Action<ProtoData.INBOX_DATA>(object:  this, method:  System.Void Game.MasterData.GetAccessToData::MasterDataOnDataSet<ProtoData.INBOX_DATA>(ProtoData.INBOX_DATA data)));
            this.<_masterData>k__BackingField.add_StoreSectionDataSet(value:  new System.Action<ProtoData.STORESECTIONS_DATA>(object:  this, method:  System.Void Game.MasterData.GetAccessToData::MasterDataOnDataSet<ProtoData.STORESECTIONS_DATA>(ProtoData.STORESECTIONS_DATA data)));
            this.<_masterData>k__BackingField.add_DailyChallengeDataSet(value:  new System.Action<ProtoData.DAILY_CHALLENGE_DATA>(object:  this, method:  System.Void Game.MasterData.GetAccessToData::MasterDataOnDataSet<ProtoData.DAILY_CHALLENGE_DATA>(ProtoData.DAILY_CHALLENGE_DATA data)));
            this.<_masterData>k__BackingField.add_DailyChallengeRewardsDataSet(value:  new System.Action<ProtoData.DAILY_CHALLENGE_REWARDS_DATA>(object:  this, method:  System.Void Game.MasterData.GetAccessToData::MasterDataOnDataSet<ProtoData.DAILY_CHALLENGE_REWARDS_DATA>(ProtoData.DAILY_CHALLENGE_REWARDS_DATA data)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsInitialized()
        {
            return (bool)((this.<_masterData>k__BackingField._configData) != 0) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetConfigDataEntryAsync(Game.MasterData.GetAccessToData.ReturnConfigDataEntry returnConfigDataEntryCallback)
        {
            this.AddConfigDataCallback(returnConfigDataEntryCallback:  returnConfigDataEntryCallback);
            this.TryCallConfigDataCallbacks();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetModCategoryDataAsync(Game.MasterData.GetAccessToData.ReturnAnyData<ProtoData.MODCATEGORIES_DATA> returnModCategoriesDataCallback)
        {
            this.GetDataAsync<ProtoData.MODCATEGORIES_DATA>(dataCallback:  returnModCategoriesDataCallback);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetAlertDataAsync(Game.MasterData.GetAccessToData.ReturnAnyData<ProtoData.ALERT_DATA> returnAlertDataCallback)
        {
            this.GetDataAsync<ProtoData.ALERT_DATA>(dataCallback:  returnAlertDataCallback);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetAudioDataAsync(Game.MasterData.GetAccessToData.ReturnAnyData<ProtoData.AUDIO_DATA> returnAudioDataCallback)
        {
            this.GetDataAsync<ProtoData.AUDIO_DATA>(dataCallback:  returnAudioDataCallback);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetDevicesDataAsync(Game.MasterData.GetAccessToData.ReturnAnyData<ProtoData.DEVICES_DATA> returnDevicesDataCallback)
        {
            this.GetDataAsync<ProtoData.DEVICES_DATA>(dataCallback:  returnDevicesDataCallback);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetTutorialDataAsync(Game.MasterData.GetAccessToData.ReturnAnyData<ProtoData.TUTORIAL_DATA> returnTutorialDataCallback)
        {
            this.GetDataAsync<ProtoData.TUTORIAL_DATA>(dataCallback:  returnTutorialDataCallback);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetKeyValueDataAsync(Game.MasterData.GetAccessToData.ReturnAnyData<ProtoData.KEY_VALUE_DATA> returnKeyValueDataCallback)
        {
            this.GetDataAsync<ProtoData.KEY_VALUE_DATA>(dataCallback:  returnKeyValueDataCallback);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetEssenceDataAsync(Game.MasterData.GetAccessToData.ReturnAnyData<ProtoData.ESSENCE_DATA> returnEssenceDataCallback)
        {
            this.GetDataAsync<ProtoData.ESSENCE_DATA>(dataCallback:  returnEssenceDataCallback);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetEssenceTypesDataAsync(Game.MasterData.GetAccessToData.ReturnAnyData<ProtoData.ESSENCE_TYPES_DATA> returnEssenceTypesDataCallback)
        {
            this.GetDataAsync<ProtoData.ESSENCE_TYPES_DATA>(dataCallback:  returnEssenceTypesDataCallback);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetFTUEDataAsync(Game.MasterData.GetAccessToData.ReturnAnyData<ProtoData.FTUE_DATA> returnFTUEDataCallback)
        {
            this.GetDataAsync<ProtoData.FTUE_DATA>(dataCallback:  returnFTUEDataCallback);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetLoginABSDataAsync(Game.MasterData.GetAccessToData.ReturnAnyData<ProtoData.LOGIN_ABS_DATA> returnLoginABSDataCallback)
        {
            this.GetDataAsync<ProtoData.LOGIN_ABS_DATA>(dataCallback:  returnLoginABSDataCallback);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetLoginRepeatDataAsync(Game.MasterData.GetAccessToData.ReturnAnyData<ProtoData.LOGIN_REPEAT_DATA> returnLoginRepeatDataCallback)
        {
            this.GetDataAsync<ProtoData.LOGIN_REPEAT_DATA>(dataCallback:  returnLoginRepeatDataCallback);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetMetricsDataAsync(Game.MasterData.GetAccessToData.ReturnAnyData<ProtoData.METRICS_DATA> returnMetricsDataCallback)
        {
            this.GetDataAsync<ProtoData.METRICS_DATA>(dataCallback:  returnMetricsDataCallback);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetModsDataAsync(Game.MasterData.GetAccessToData.ReturnAnyData<ProtoData.MODS_DATA> returnModsDataCallback)
        {
            this.GetDataAsync<ProtoData.MODS_DATA>(dataCallback:  returnModsDataCallback);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetCPUDataAsync(Game.MasterData.GetAccessToData.ReturnAnyData<ProtoData.CPU_DATA> returnCPUDataCallback)
        {
            this.GetDataAsync<ProtoData.CPU_DATA>(dataCallback:  returnCPUDataCallback);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetPlushSuitDataAsync(Game.MasterData.GetAccessToData.ReturnAnyData<ProtoData.PLUSHSUIT_DATA> returnPlushSuitDataCallback)
        {
            this.GetDataAsync<ProtoData.PLUSHSUIT_DATA>(dataCallback:  returnPlushSuitDataCallback);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetAttackDataAsync(Game.MasterData.GetAccessToData.ReturnAnyData<ProtoData.ATTACK_DATA> returnAttackDataCallback)
        {
            this.GetDataAsync<ProtoData.ATTACK_DATA>(dataCallback:  returnAttackDataCallback);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetProgressionDataAsync(Game.MasterData.GetAccessToData.ReturnAnyData<ProtoData.PROGRESSION_DATA> returnProgressionDataCallback)
        {
            this.GetDataAsync<ProtoData.PROGRESSION_DATA>(dataCallback:  returnProgressionDataCallback);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetStaticDataAsync(Game.MasterData.GetAccessToData.ReturnAnyData<ProtoData.STATIC_DATA> returnStaticDataCallback)
        {
            this.GetDataAsync<ProtoData.STATIC_DATA>(dataCallback:  returnStaticDataCallback);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetWearAndTearDataAsync(Game.MasterData.GetAccessToData.ReturnAnyData<ProtoData.WEARANDTEAR_DATA> returnWearAndTearDataCallback)
        {
            this.GetDataAsync<ProtoData.WEARANDTEAR_DATA>(dataCallback:  returnWearAndTearDataCallback);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetLocDataAsync(Game.MasterData.GetAccessToData.ReturnAnyData<ProtoData.LOC_DATA> returnLocDataCallback)
        {
            this.GetDataAsync<ProtoData.LOC_DATA>(dataCallback:  returnLocDataCallback);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetStoreDataAsync(Game.MasterData.GetAccessToData.ReturnAnyData<ProtoData.STORE_DATA> returnStoreDataCallback)
        {
            this.GetDataAsync<ProtoData.STORE_DATA>(dataCallback:  returnStoreDataCallback);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetStoreSectionDataAsync(Game.MasterData.GetAccessToData.ReturnAnyData<ProtoData.STORESECTIONS_DATA> returnStoreSectionDataCallback)
        {
            this.GetDataAsync<ProtoData.STORESECTIONS_DATA>(dataCallback:  returnStoreSectionDataCallback);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetRemnantDebuffDataAsync(Game.MasterData.GetAccessToData.ReturnAnyData<ProtoData.REMNANT_DEBUFF_DATA> returnRemnantDebuffDataCallback)
        {
            this.GetDataAsync<ProtoData.REMNANT_DEBUFF_DATA>(dataCallback:  returnRemnantDebuffDataCallback);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetServerBlockingErrorDataAsync(Game.MasterData.GetAccessToData.ReturnAnyData<ProtoData.SERVERBLOCKINGERROR_DATA> returnServerBlockingErrorDataCallback)
        {
            this.GetDataAsync<ProtoData.SERVERBLOCKINGERROR_DATA>(dataCallback:  returnServerBlockingErrorDataCallback);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetSequentialRewardsDataAsync(Game.MasterData.GetAccessToData.ReturnAnyData<ProtoData.SEQUENTIAL_REWARDS_DATA> setSequentialRewardsData)
        {
            this.GetDataAsync<ProtoData.SEQUENTIAL_REWARDS_DATA>(dataCallback:  setSequentialRewardsData);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetSeasonalDataAsync(Game.MasterData.GetAccessToData.ReturnAnyData<ProtoData.SEASONAL_DATA> returnSeasonalDataCallback)
        {
            this.GetDataAsync<ProtoData.SEASONAL_DATA>(dataCallback:  returnSeasonalDataCallback);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetSeasonalAssetsDataAsync(Game.MasterData.GetAccessToData.ReturnAnyData<ProtoData.SEASONAL_ASSETS_DATA> returnSeasonalAssetsDataCallback)
        {
            this.GetDataAsync<ProtoData.SEASONAL_ASSETS_DATA>(dataCallback:  returnSeasonalAssetsDataCallback);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetInboxDataAsync(Game.MasterData.GetAccessToData.ReturnAnyData<ProtoData.INBOX_DATA> returnInboxData)
        {
            this.GetDataAsync<ProtoData.INBOX_DATA>(dataCallback:  returnInboxData);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetDailyChallengeDataAsync(Game.MasterData.GetAccessToData.ReturnAnyData<ProtoData.DAILY_CHALLENGE_DATA> returnDailyChallengeData)
        {
            this.GetDataAsync<ProtoData.DAILY_CHALLENGE_DATA>(dataCallback:  returnDailyChallengeData);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetDailyChallengeRewardsDataAsync(Game.MasterData.GetAccessToData.ReturnAnyData<ProtoData.DAILY_CHALLENGE_REWARDS_DATA> returnDailyChallengeRewardsData)
        {
            this.GetDataAsync<ProtoData.DAILY_CHALLENGE_REWARDS_DATA>(dataCallback:  returnDailyChallengeRewardsData);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GetDataAsync<T>(Game.MasterData.GetAccessToData.ReturnAnyData<T> dataCallback)
        {
            mem2[0] = dataCallback;
            GetAccessToData.ReturnData val_1 = new GetAccessToData.ReturnData(object:  __RuntimeMethodHiddenParam + 48, method:  __RuntimeMethodHiddenParam + 48 + 16);
            if(this != null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AddConfigDataCallback(Game.MasterData.GetAccessToData.ReturnConfigDataEntry returnConfigDataEntryCallback)
        {
            this._configDataCallbacks.Add(item:  returnConfigDataEntryCallback);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void TryCallConfigDataCallbacks()
        {
            System.Collections.Generic.List<ReturnConfigDataEntry> val_6;
            var val_7;
            var val_8;
            val_6 = this;
            if((this.<_masterData>k__BackingField._configData) == null)
            {
                    return;
            }
            
            List.Enumerator<T> val_1 = this._configDataCallbacks.GetEnumerator();
            label_9:
            if(((-838029624) & 1) == 0)
            {
                goto label_4;
            }
            
            0.emailUIDataHandler.Invoke(configDataEntry:  this.<_masterData>k__BackingField._configData.Entries.Item[0]);
            goto label_9;
            label_4:
            val_7 = 0;
            val_8 = 1;
            long val_5 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525243653832});
            val_6 = this._configDataCallbacks;
            val_6.Clear();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AddDataCallback<T>(Game.MasterData.GetAccessToData.ReturnData dataCallback)
        {
            System.Type val_1 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 48});
            if((this._dataCallbacks.ContainsKey(key:  val_1)) != true)
            {
                    this._dataCallbacks.set_Item(key:  val_1, value:  new System.Collections.Generic.List<ReturnData>());
            }
            
            this._dataCallbacks.Item[val_1].Add(item:  dataCallback);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void TryCallDataCallbacks<T>()
        {
            System.Collections.Generic.Dictionary<System.Type, System.Collections.Generic.List<ReturnData>> val_11;
            System.Collections.Generic.Dictionary<System.Type, Google.Protobuf.IMessage> val_12;
            var val_13;
            val_11 = this;
            System.Type val_1 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 48});
            val_12 = this._data;
            if((val_12.ContainsKey(key:  val_1)) == false)
            {
                    return;
            }
            
            val_12 = this._dataCallbacks;
            if((val_12.ContainsKey(key:  val_1)) == false)
            {
                    return;
            }
            
            List.Enumerator<T> val_6 = this._dataCallbacks.Item[val_1].GetEnumerator();
            label_12:
            if(((-837663280) & 1) == 0)
            {
                goto label_10;
            }
            
            0.emailUIDataHandler.Invoke(data:  this._data.Item[val_1]);
            goto label_12;
            label_10:
            val_12 = 0;
            val_13 = 110;
            var val_9 = 0;
            val_9 = val_9 + 1;
            null.Dispose();
            val_11 = this._dataCallbacks;
            bool val_8 = val_11.Remove(key:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void MasterDataOnKeyValueDataSet(ProtoData.KEY_VALUE_DATA keyValueData)
        {
            this.KeyValueAccess.Setup(kvd:  keyValueData);
            this.MasterDataOnDataSet<ProtoData.KEY_VALUE_DATA>(data:  keyValueData);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void MasterDataOnConfigDataSet(ProtoData.CONFIG_DATA configData)
        {
            this.TryCallConfigDataCallbacks();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void MasterDataOnDataSet<T>(T data)
        {
            this._data.set_Item(key:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 48}), value:  data);
            goto __RuntimeMethodHiddenParam + 48 + 16;
        }
    
    }

}
