using UnityEngine;

namespace Game.MasterData
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class DataDeserializer
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.MasterData.MasterData _masterData;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DataDeserializer(Game.MasterData.MasterData masterData, Master.EventExposer eventExposer)
        {
            val_1 = new System.Object();
            this._masterData = masterData;
            val_1.add_AlertJsonDataReceived(value:  new System.Action<System.String>(object:  this, method:  System.Void Game.MasterData.DataDeserializer::EventExposerOnAlertJsonDataReceived(string alertJsonData)));
            val_1.add_AudioJsonDataReceived(value:  new System.Action<System.String>(object:  this, method:  System.Void Game.MasterData.DataDeserializer::EventExposerOnAudioJsonDataReceived(string data)));
            val_1.add_ConfigJsonDataReceived(value:  new System.Action<System.String>(object:  this, method:  System.Void Game.MasterData.DataDeserializer::EventExposerOnConfigJsonDataReceived(string configJsonData)));
            val_1.add_DevicesJsonDataReceived(value:  new System.Action<System.String>(object:  this, method:  System.Void Game.MasterData.DataDeserializer::OnDevicesDataReceived(string data)));
            val_1.add_TutorialJsonDataReceived(value:  new System.Action<System.String>(object:  this, method:  System.Void Game.MasterData.DataDeserializer::OnTutorialDataReceived(string data)));
            val_1.add_KeyValueJsonDataReceived(value:  new System.Action<System.String>(object:  this, method:  System.Void Game.MasterData.DataDeserializer::OnKeyValueDataReceived(string data)));
            val_1.add_EssenceJsonDataReceived(value:  new System.Action<System.String>(object:  this, method:  System.Void Game.MasterData.DataDeserializer::OnEssenceDataReceived(string data)));
            val_1.add_EssenceTypesJsonDataReceived(value:  new System.Action<System.String>(object:  this, method:  System.Void Game.MasterData.DataDeserializer::OnEssenceTypesDataReceived(string data)));
            val_1.add_FTUEJsonDataReceived(value:  new System.Action<System.String>(object:  this, method:  System.Void Game.MasterData.DataDeserializer::OnFTUEDataReceived(string data)));
            val_1.add_LoginABSJsonDataReceived(value:  new System.Action<System.String>(object:  this, method:  System.Void Game.MasterData.DataDeserializer::OnLoginABSDataReceived(string data)));
            val_1.add_LoginRepeatJsonDataReceived(value:  new System.Action<System.String>(object:  this, method:  System.Void Game.MasterData.DataDeserializer::OnLoginRepeatDataReceived(string data)));
            val_1.add_MetricsJsonDataReceived(value:  new System.Action<System.String>(object:  this, method:  System.Void Game.MasterData.DataDeserializer::OnMetricsDataReceived(string data)));
            val_1.add_ModsJsonDataReceived(value:  new System.Action<System.String>(object:  this, method:  System.Void Game.MasterData.DataDeserializer::OnModsDataReceived(string data)));
            val_1.add_ProgressionJsonDataReceived(value:  new System.Action<System.String>(object:  this, method:  System.Void Game.MasterData.DataDeserializer::OnProgressionDataReceived(string data)));
            val_1.add_StaticJsonDataReceived(value:  new System.Action<System.String>(object:  this, method:  System.Void Game.MasterData.DataDeserializer::OnStaticDataReceived(string data)));
            val_1.add_WearAndTearJsonReceived(value:  new System.Action<System.String>(object:  this, method:  System.Void Game.MasterData.DataDeserializer::OnWearAndTearDataReceived(string data)));
            val_1.add_CPUJsonDataReceived(value:  new System.Action<System.String>(object:  this, method:  System.Void Game.MasterData.DataDeserializer::OnCPUDataReceived(string data)));
            val_1.add_PlushSuitJsonDataReceived(value:  new System.Action<System.String>(object:  this, method:  System.Void Game.MasterData.DataDeserializer::OnPlushSuitDataReceived(string data)));
            val_1.add_AttackJsonDataReceived(value:  new System.Action<System.String>(object:  this, method:  System.Void Game.MasterData.DataDeserializer::OnAttackDataReceived(string data)));
            val_1.add_LocJsonDataReceived(value:  new System.Action<System.String>(object:  this, method:  System.Void Game.MasterData.DataDeserializer::OnLocDataReceived(string data)));
            val_1.add_StoreJsonDataReceived(value:  new System.Action<System.String>(object:  this, method:  System.Void Game.MasterData.DataDeserializer::OnStoreDataReceived(string data)));
            val_1.add_RemnantDebuffJsonDataReceived(value:  new System.Action<System.String>(object:  this, method:  System.Void Game.MasterData.DataDeserializer::OnRemnantDebuffDataReceived(string data)));
            val_1.add_ModCategoriesDataRecieved(value:  new System.Action<System.String>(object:  this, method:  System.Void Game.MasterData.DataDeserializer::OnModCategoriesDataRecieved(string modCategoriesJSONData)));
            val_1.add_ServerBlockingErrorDataReceived(value:  new System.Action<System.String>(object:  this, method:  System.Void Game.MasterData.DataDeserializer::OnServerBlockingErrorDataReceived(string serverBlockingErrorJSONData)));
            val_1.add_SeasonalDataReceived(value:  new System.Action<System.String>(object:  this, method:  System.Void Game.MasterData.DataDeserializer::OnSeasonalDataReceived(string seasonalJSONData)));
            val_1.add_SeasonalAssetsDataReceived(value:  new System.Action<System.String>(object:  this, method:  System.Void Game.MasterData.DataDeserializer::OnSeasonalAssetsDataReceived(string seasonalAssetsJSONData)));
            val_1.add_SequentialRewardsDataReceived(value:  new System.Action<System.String>(object:  this, method:  System.Void Game.MasterData.DataDeserializer::OnSequentialRewardsDataReceived(string sequentialRewardsJSONData)));
            val_1.add_InboxFolderDataReceived(value:  new System.Action<System.String>(object:  this, method:  System.Void Game.MasterData.DataDeserializer::OnInboxFolderDataReceived(string json)));
            val_1.add_StoreSectionJsonDataReceived(value:  new System.Action<System.String>(object:  this, method:  System.Void Game.MasterData.DataDeserializer::OnStoreSectionDataReceived(string data)));
            val_1.add_DailyChallengeJsonDataReceived(value:  new System.Action<System.String>(object:  this, method:  System.Void Game.MasterData.DataDeserializer::OnDailyChallengeDataReceived(string dailyChallengeJSONData)));
            val_1.add_DailyChallengeRewardsJsonDataReceived(value:  new System.Action<System.String>(object:  this, method:  System.Void Game.MasterData.DataDeserializer::OnDailyChallengeRewardsDataReceived(string dailyChallengeRewardsJSONData)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnInboxFolderDataReceived(string json)
        {
            this._masterData.InboxData = ProtoDataLoader.DeserializeJSON<ProtoData.INBOX_DATA>(jsonSourceText:  json);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EventExposerOnAlertJsonDataReceived(string alertJsonData)
        {
            this._masterData.AlertData = ProtoDataLoader.DeserializeJSON<ProtoData.ALERT_DATA>(jsonSourceText:  alertJsonData);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EventExposerOnAudioJsonDataReceived(string data)
        {
            this._masterData.AudioData = ProtoDataLoader.DeserializeJSON<ProtoData.AUDIO_DATA>(jsonSourceText:  data);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EventExposerOnConfigJsonDataReceived(string configJsonData)
        {
            this._masterData.ConfigData = ProtoDataLoader.DeserializeJSON<ProtoData.CONFIG_DATA>(jsonSourceText:  configJsonData);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDevicesDataReceived(string data)
        {
            this._masterData.DevicesData = ProtoDataLoader.DeserializeJSON<ProtoData.DEVICES_DATA>(jsonSourceText:  data);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnTutorialDataReceived(string data)
        {
            this._masterData.TutorialData = ProtoDataLoader.DeserializeJSON<ProtoData.TUTORIAL_DATA>(jsonSourceText:  data);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnKeyValueDataReceived(string data)
        {
            this._masterData.KeyValueData = ProtoDataLoader.DeserializeJSON<ProtoData.KEY_VALUE_DATA>(jsonSourceText:  data);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnEssenceDataReceived(string data)
        {
            this._masterData.EssenceData = ProtoDataLoader.DeserializeJSON<ProtoData.ESSENCE_DATA>(jsonSourceText:  data);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnEssenceTypesDataReceived(string data)
        {
            this._masterData.EssenceTypesData = ProtoDataLoader.DeserializeJSON<ProtoData.ESSENCE_TYPES_DATA>(jsonSourceText:  data);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnFTUEDataReceived(string data)
        {
            this._masterData.FTUEData = ProtoDataLoader.DeserializeJSON<ProtoData.FTUE_DATA>(jsonSourceText:  data);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnLoginABSDataReceived(string data)
        {
            this._masterData.LoginABSData = ProtoDataLoader.DeserializeJSON<ProtoData.LOGIN_ABS_DATA>(jsonSourceText:  data);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnLoginRepeatDataReceived(string data)
        {
            this._masterData.LoginRepeatData = ProtoDataLoader.DeserializeJSON<ProtoData.LOGIN_REPEAT_DATA>(jsonSourceText:  data);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnMetricsDataReceived(string data)
        {
            this._masterData.MetricsData = ProtoDataLoader.DeserializeJSON<ProtoData.METRICS_DATA>(jsonSourceText:  data);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnModsDataReceived(string data)
        {
            this._masterData.ModsData = ProtoDataLoader.DeserializeJSON<ProtoData.MODS_DATA>(jsonSourceText:  data);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnProgressionDataReceived(string data)
        {
            this._masterData.ProgressionData = ProtoDataLoader.DeserializeJSON<ProtoData.PROGRESSION_DATA>(jsonSourceText:  data);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnStaticDataReceived(string data)
        {
            this._masterData.StaticData = ProtoDataLoader.DeserializeJSON<ProtoData.STATIC_DATA>(jsonSourceText:  data);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnWearAndTearDataReceived(string data)
        {
            this._masterData.WearAndTearData = ProtoDataLoader.DeserializeJSON<ProtoData.WEARANDTEAR_DATA>(jsonSourceText:  data);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnCPUDataReceived(string data)
        {
            this._masterData.CPUData = ProtoDataLoader.DeserializeJSON<ProtoData.CPU_DATA>(jsonSourceText:  data);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnPlushSuitDataReceived(string data)
        {
            this._masterData.PlushSuitData = ProtoDataLoader.DeserializeJSON<ProtoData.PLUSHSUIT_DATA>(jsonSourceText:  data);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnAttackDataReceived(string data)
        {
            this._masterData.AttackData = ProtoDataLoader.DeserializeJSON<ProtoData.ATTACK_DATA>(jsonSourceText:  data);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnLocDataReceived(string data)
        {
            this._masterData.LocData = ProtoDataLoader.DeserializeJSON<ProtoData.LOC_DATA>(jsonSourceText:  data);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnStoreDataReceived(string data)
        {
            this._masterData.StoreData = ProtoDataLoader.DeserializeJSON<ProtoData.STORE_DATA>(jsonSourceText:  data);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnStoreSectionDataReceived(string data)
        {
            this._masterData.StoreSectionData = ProtoDataLoader.DeserializeJSON<ProtoData.STORESECTIONS_DATA>(jsonSourceText:  data);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnRemnantDebuffDataReceived(string data)
        {
            this._masterData.RemnantDebuffData = ProtoDataLoader.DeserializeJSON<ProtoData.REMNANT_DEBUFF_DATA>(jsonSourceText:  data);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnModCategoriesDataRecieved(string modCategoriesJSONData)
        {
            this._masterData.ModCategoryData = ProtoDataLoader.DeserializeJSON<ProtoData.MODCATEGORIES_DATA>(jsonSourceText:  modCategoriesJSONData);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnServerBlockingErrorDataReceived(string serverBlockingErrorJSONData)
        {
            this._masterData.ServerblockingerrorData = ProtoDataLoader.DeserializeJSON<ProtoData.SERVERBLOCKINGERROR_DATA>(jsonSourceText:  serverBlockingErrorJSONData);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnSequentialRewardsDataReceived(string sequentialRewardsJSONData)
        {
            this._masterData.SequentialRewardsData = ProtoDataLoader.DeserializeJSON<ProtoData.SEQUENTIAL_REWARDS_DATA>(jsonSourceText:  sequentialRewardsJSONData);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnSeasonalDataReceived(string seasonalJSONData)
        {
            this._masterData.SeasonalData = ProtoDataLoader.DeserializeJSON<ProtoData.SEASONAL_DATA>(jsonSourceText:  seasonalJSONData);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnSeasonalAssetsDataReceived(string seasonalAssetsJSONData)
        {
            this._masterData.SeasonalAssetsData = ProtoDataLoader.DeserializeJSON<ProtoData.SEASONAL_ASSETS_DATA>(jsonSourceText:  seasonalAssetsJSONData);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDailyChallengeDataReceived(string dailyChallengeJSONData)
        {
            this._masterData.DailyChallengeData = ProtoDataLoader.DeserializeJSON<ProtoData.DAILY_CHALLENGE_DATA>(jsonSourceText:  dailyChallengeJSONData);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDailyChallengeRewardsDataReceived(string dailyChallengeRewardsJSONData)
        {
            this._masterData.DailyChallengeRewardsData = ProtoDataLoader.DeserializeJSON<ProtoData.DAILY_CHALLENGE_REWARDS_DATA>(jsonSourceText:  dailyChallengeRewardsJSONData);
        }
    
    }

}
