using UnityEngine;

namespace Game.MasterData
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class MasterData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<ProtoData.ALERT_DATA> AlertDataSet;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<ProtoData.AUDIO_DATA> AudioDataSet;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<ProtoData.CONFIG_DATA> ConfigDataSet;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<ProtoData.DEVICES_DATA> DevicesDataSet;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<ProtoData.TUTORIAL_DATA> TutorialDataSet;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<ProtoData.KEY_VALUE_DATA> KeyValueDataSet;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<ProtoData.ESSENCE_DATA> EssenceDataSet;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<ProtoData.ESSENCE_TYPES_DATA> EssenceTypesDataSet;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<ProtoData.FTUE_DATA> FTUEDataSet;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<ProtoData.LOGIN_ABS_DATA> LoginABSDataSet;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<ProtoData.LOGIN_REPEAT_DATA> LoginRepeatDataSet;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<ProtoData.METRICS_DATA> MetricsDataSet;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<ProtoData.MODS_DATA> ModsDataSet;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<ProtoData.PROGRESSION_DATA> ProgressionDataSet;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<ProtoData.STATIC_DATA> StaticDataSet;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<ProtoData.WEARANDTEAR_DATA> WearAndTearDataSet;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<ProtoData.CPU_DATA> CPUDataSet;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<ProtoData.PLUSHSUIT_DATA> PlushSuitDataSet;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<ProtoData.ATTACK_DATA> AttackDataSet;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<ProtoData.LOC_DATA> LocDataSet;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<ProtoData.STORE_DATA> StoreDataSet;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<ProtoData.STORESECTIONS_DATA> StoreSectionDataSet;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<ProtoData.REMNANT_DEBUFF_DATA> RemnantDebuffDataSet;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<ProtoData.MODCATEGORIES_DATA> ModCategoryDataSet;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<ProtoData.SERVERBLOCKINGERROR_DATA> ServerBlockingErrorDataSet;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<ProtoData.SEASONAL_ASSETS_DATA> SeasonalAssetsDataSet;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<ProtoData.SEQUENTIAL_REWARDS_DATA> SequentialRewardsDataSet;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<ProtoData.SEASONAL_DATA> SeasonalDataSet;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<ProtoData.INBOX_DATA> InboxDataSet;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<ProtoData.DAILY_CHALLENGE_DATA> DailyChallengeDataSet;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<ProtoData.DAILY_CHALLENGE_REWARDS_DATA> DailyChallengeRewardsDataSet;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private ProtoData.ALERT_DATA _alertData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private ProtoData.AUDIO_DATA _audioData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private ProtoData.CONFIG_DATA _configData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private ProtoData.DEVICES_DATA _devicesData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private ProtoData.TUTORIAL_DATA _tutorialData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private ProtoData.KEY_VALUE_DATA _keyValueData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private ProtoData.ESSENCE_DATA _essenceData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private ProtoData.ESSENCE_TYPES_DATA _essenceTypesData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private ProtoData.FTUE_DATA _ftueData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private ProtoData.LOGIN_ABS_DATA _loginABSData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private ProtoData.LOGIN_REPEAT_DATA _loginRepeatData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private ProtoData.METRICS_DATA _metricsData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private ProtoData.MODS_DATA _modsData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private ProtoData.PROGRESSION_DATA _progressionData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private ProtoData.STATIC_DATA _staticData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private ProtoData.WEARANDTEAR_DATA _wearAndTearData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private ProtoData.CPU_DATA _cpuData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private ProtoData.PLUSHSUIT_DATA _plushSuitData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private ProtoData.ATTACK_DATA _attackData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private ProtoData.LOC_DATA _locData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private ProtoData.STORE_DATA _storeData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private ProtoData.STORESECTIONS_DATA _storeSectionData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private ProtoData.REMNANT_DEBUFF_DATA _remnantDebuffData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private ProtoData.MODCATEGORIES_DATA _modCategoryData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private ProtoData.SERVERBLOCKINGERROR_DATA _serverblockingerrorData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private ProtoData.SEQUENTIAL_REWARDS_DATA _sequentialRewardsData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private ProtoData.SEASONAL_ASSETS_DATA _seasonalAssetsData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private ProtoData.SEASONAL_DATA _seasonalData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private ProtoData.INBOX_DATA _inboxData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private ProtoData.DAILY_CHALLENGE_DATA _dailyChallengeData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private ProtoData.DAILY_CHALLENGE_REWARDS_DATA _dailyChallengeRewardsData;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProtoData.ALERT_DATA AlertData { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProtoData.AUDIO_DATA AudioData { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProtoData.CONFIG_DATA ConfigData { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProtoData.DEVICES_DATA DevicesData { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProtoData.TUTORIAL_DATA TutorialData { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProtoData.KEY_VALUE_DATA KeyValueData { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProtoData.ESSENCE_DATA EssenceData { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProtoData.ESSENCE_TYPES_DATA EssenceTypesData { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProtoData.FTUE_DATA FTUEData { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProtoData.LOGIN_ABS_DATA LoginABSData { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProtoData.LOGIN_REPEAT_DATA LoginRepeatData { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProtoData.METRICS_DATA MetricsData { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProtoData.MODS_DATA ModsData { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProtoData.PROGRESSION_DATA ProgressionData { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProtoData.STATIC_DATA StaticData { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProtoData.WEARANDTEAR_DATA WearAndTearData { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProtoData.CPU_DATA CPUData { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProtoData.PLUSHSUIT_DATA PlushSuitData { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProtoData.ATTACK_DATA AttackData { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProtoData.LOC_DATA LocData { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProtoData.STORE_DATA StoreData { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProtoData.STORESECTIONS_DATA StoreSectionData { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProtoData.REMNANT_DEBUFF_DATA RemnantDebuffData { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProtoData.MODCATEGORIES_DATA ModCategoryData { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProtoData.SERVERBLOCKINGERROR_DATA ServerblockingerrorData { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProtoData.SEQUENTIAL_REWARDS_DATA SequentialRewardsData { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProtoData.SEASONAL_ASSETS_DATA SeasonalAssetsData { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProtoData.SEASONAL_DATA SeasonalData { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProtoData.INBOX_DATA InboxData { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProtoData.DAILY_CHALLENGE_DATA DailyChallengeData { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProtoData.DAILY_CHALLENGE_REWARDS_DATA DailyChallengeRewardsData { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_AlertDataSet(System.Action<ProtoData.ALERT_DATA> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.AlertDataSet, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.AlertDataSet != 1152921525247329680);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_AlertDataSet(System.Action<ProtoData.ALERT_DATA> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.AlertDataSet, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.AlertDataSet != 1152921525247466256);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_AudioDataSet(System.Action<ProtoData.AUDIO_DATA> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.AudioDataSet, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.AudioDataSet != 1152921525247602840);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_AudioDataSet(System.Action<ProtoData.AUDIO_DATA> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.AudioDataSet, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.AudioDataSet != 1152921525247739416);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_ConfigDataSet(System.Action<ProtoData.CONFIG_DATA> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.ConfigDataSet, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.ConfigDataSet != 1152921525247876000);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_ConfigDataSet(System.Action<ProtoData.CONFIG_DATA> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.ConfigDataSet, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.ConfigDataSet != 1152921525248012576);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_DevicesDataSet(System.Action<ProtoData.DEVICES_DATA> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.DevicesDataSet, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.DevicesDataSet != 1152921525248149160);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_DevicesDataSet(System.Action<ProtoData.DEVICES_DATA> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.DevicesDataSet, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.DevicesDataSet != 1152921525248285736);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_TutorialDataSet(System.Action<ProtoData.TUTORIAL_DATA> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.TutorialDataSet, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.TutorialDataSet != 1152921525248422320);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_TutorialDataSet(System.Action<ProtoData.TUTORIAL_DATA> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.TutorialDataSet, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.TutorialDataSet != 1152921525248558896);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_KeyValueDataSet(System.Action<ProtoData.KEY_VALUE_DATA> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.KeyValueDataSet, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.KeyValueDataSet != 1152921525248695480);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_KeyValueDataSet(System.Action<ProtoData.KEY_VALUE_DATA> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.KeyValueDataSet, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.KeyValueDataSet != 1152921525248832056);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_EssenceDataSet(System.Action<ProtoData.ESSENCE_DATA> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.EssenceDataSet, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.EssenceDataSet != 1152921525248968640);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_EssenceDataSet(System.Action<ProtoData.ESSENCE_DATA> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.EssenceDataSet, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.EssenceDataSet != 1152921525249105216);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_EssenceTypesDataSet(System.Action<ProtoData.ESSENCE_TYPES_DATA> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.EssenceTypesDataSet, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.EssenceTypesDataSet != 1152921525249241800);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_EssenceTypesDataSet(System.Action<ProtoData.ESSENCE_TYPES_DATA> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.EssenceTypesDataSet, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.EssenceTypesDataSet != 1152921525249378376);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_FTUEDataSet(System.Action<ProtoData.FTUE_DATA> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.FTUEDataSet, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.FTUEDataSet != 1152921525249514960);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_FTUEDataSet(System.Action<ProtoData.FTUE_DATA> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.FTUEDataSet, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.FTUEDataSet != 1152921525249651536);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_LoginABSDataSet(System.Action<ProtoData.LOGIN_ABS_DATA> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.LoginABSDataSet, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.LoginABSDataSet != 1152921525249788120);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_LoginABSDataSet(System.Action<ProtoData.LOGIN_ABS_DATA> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.LoginABSDataSet, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.LoginABSDataSet != 1152921525249924696);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_LoginRepeatDataSet(System.Action<ProtoData.LOGIN_REPEAT_DATA> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.LoginRepeatDataSet, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.LoginRepeatDataSet != 1152921525250061280);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_LoginRepeatDataSet(System.Action<ProtoData.LOGIN_REPEAT_DATA> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.LoginRepeatDataSet, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.LoginRepeatDataSet != 1152921525250197856);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_MetricsDataSet(System.Action<ProtoData.METRICS_DATA> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.MetricsDataSet, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.MetricsDataSet != 1152921525250334440);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_MetricsDataSet(System.Action<ProtoData.METRICS_DATA> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.MetricsDataSet, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.MetricsDataSet != 1152921525250471016);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_ModsDataSet(System.Action<ProtoData.MODS_DATA> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.ModsDataSet, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.ModsDataSet != 1152921525250607600);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_ModsDataSet(System.Action<ProtoData.MODS_DATA> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.ModsDataSet, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.ModsDataSet != 1152921525250744176);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_ProgressionDataSet(System.Action<ProtoData.PROGRESSION_DATA> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.ProgressionDataSet, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.ProgressionDataSet != 1152921525250880760);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_ProgressionDataSet(System.Action<ProtoData.PROGRESSION_DATA> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.ProgressionDataSet, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.ProgressionDataSet != 1152921525251017336);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_StaticDataSet(System.Action<ProtoData.STATIC_DATA> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.StaticDataSet, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.StaticDataSet != 1152921525251153920);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_StaticDataSet(System.Action<ProtoData.STATIC_DATA> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.StaticDataSet, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.StaticDataSet != 1152921525251290496);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_WearAndTearDataSet(System.Action<ProtoData.WEARANDTEAR_DATA> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.WearAndTearDataSet, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.WearAndTearDataSet != 1152921525251427080);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_WearAndTearDataSet(System.Action<ProtoData.WEARANDTEAR_DATA> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.WearAndTearDataSet, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.WearAndTearDataSet != 1152921525251563656);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_CPUDataSet(System.Action<ProtoData.CPU_DATA> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.CPUDataSet, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.CPUDataSet != 1152921525251700240);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_CPUDataSet(System.Action<ProtoData.CPU_DATA> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.CPUDataSet, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.CPUDataSet != 1152921525251836816);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_PlushSuitDataSet(System.Action<ProtoData.PLUSHSUIT_DATA> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.PlushSuitDataSet, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.PlushSuitDataSet != 1152921525251973400);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_PlushSuitDataSet(System.Action<ProtoData.PLUSHSUIT_DATA> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.PlushSuitDataSet, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.PlushSuitDataSet != 1152921525252109976);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_AttackDataSet(System.Action<ProtoData.ATTACK_DATA> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.AttackDataSet, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.AttackDataSet != 1152921525252246560);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_AttackDataSet(System.Action<ProtoData.ATTACK_DATA> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.AttackDataSet, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.AttackDataSet != 1152921525252383136);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_LocDataSet(System.Action<ProtoData.LOC_DATA> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.LocDataSet, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.LocDataSet != 1152921525252519720);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_LocDataSet(System.Action<ProtoData.LOC_DATA> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.LocDataSet, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.LocDataSet != 1152921525252656296);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_StoreDataSet(System.Action<ProtoData.STORE_DATA> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.StoreDataSet, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.StoreDataSet != 1152921525252792880);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_StoreDataSet(System.Action<ProtoData.STORE_DATA> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.StoreDataSet, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.StoreDataSet != 1152921525252929456);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_StoreSectionDataSet(System.Action<ProtoData.STORESECTIONS_DATA> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.StoreSectionDataSet, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.StoreSectionDataSet != 1152921525253066040);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_StoreSectionDataSet(System.Action<ProtoData.STORESECTIONS_DATA> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.StoreSectionDataSet, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.StoreSectionDataSet != 1152921525253202616);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_RemnantDebuffDataSet(System.Action<ProtoData.REMNANT_DEBUFF_DATA> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.RemnantDebuffDataSet, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.RemnantDebuffDataSet != 1152921525253339200);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_RemnantDebuffDataSet(System.Action<ProtoData.REMNANT_DEBUFF_DATA> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.RemnantDebuffDataSet, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.RemnantDebuffDataSet != 1152921525253475776);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_ModCategoryDataSet(System.Action<ProtoData.MODCATEGORIES_DATA> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.ModCategoryDataSet, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.ModCategoryDataSet != 1152921525253612360);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_ModCategoryDataSet(System.Action<ProtoData.MODCATEGORIES_DATA> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.ModCategoryDataSet, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.ModCategoryDataSet != 1152921525253748936);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_ServerBlockingErrorDataSet(System.Action<ProtoData.SERVERBLOCKINGERROR_DATA> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.ServerBlockingErrorDataSet, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.ServerBlockingErrorDataSet != 1152921525253885520);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_ServerBlockingErrorDataSet(System.Action<ProtoData.SERVERBLOCKINGERROR_DATA> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.ServerBlockingErrorDataSet, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.ServerBlockingErrorDataSet != 1152921525254022096);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_SeasonalAssetsDataSet(System.Action<ProtoData.SEASONAL_ASSETS_DATA> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.SeasonalAssetsDataSet, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.SeasonalAssetsDataSet != 1152921525254158680);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_SeasonalAssetsDataSet(System.Action<ProtoData.SEASONAL_ASSETS_DATA> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.SeasonalAssetsDataSet, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.SeasonalAssetsDataSet != 1152921525254295256);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_SequentialRewardsDataSet(System.Action<ProtoData.SEQUENTIAL_REWARDS_DATA> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.SequentialRewardsDataSet, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.SequentialRewardsDataSet != 1152921525254431840);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_SequentialRewardsDataSet(System.Action<ProtoData.SEQUENTIAL_REWARDS_DATA> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.SequentialRewardsDataSet, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.SequentialRewardsDataSet != 1152921525254568416);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_SeasonalDataSet(System.Action<ProtoData.SEASONAL_DATA> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.SeasonalDataSet, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.SeasonalDataSet != 1152921525254705000);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_SeasonalDataSet(System.Action<ProtoData.SEASONAL_DATA> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.SeasonalDataSet, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.SeasonalDataSet != 1152921525254841576);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_InboxDataSet(System.Action<ProtoData.INBOX_DATA> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.InboxDataSet, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.InboxDataSet != 1152921525254978160);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_InboxDataSet(System.Action<ProtoData.INBOX_DATA> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.InboxDataSet, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.InboxDataSet != 1152921525255114736);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_DailyChallengeDataSet(System.Action<ProtoData.DAILY_CHALLENGE_DATA> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.DailyChallengeDataSet, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.DailyChallengeDataSet != 1152921525255251320);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_DailyChallengeDataSet(System.Action<ProtoData.DAILY_CHALLENGE_DATA> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.DailyChallengeDataSet, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.DailyChallengeDataSet != 1152921525255387896);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_DailyChallengeRewardsDataSet(System.Action<ProtoData.DAILY_CHALLENGE_REWARDS_DATA> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.DailyChallengeRewardsDataSet, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.DailyChallengeRewardsDataSet != this.DailyChallengeRewardsDataSet);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_DailyChallengeRewardsDataSet(System.Action<ProtoData.DAILY_CHALLENGE_REWARDS_DATA> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.DailyChallengeRewardsDataSet, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.DailyChallengeRewardsDataSet != this.DailyChallengeRewardsDataSet);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProtoData.ALERT_DATA get_AlertData()
        {
            return (ProtoData.ALERT_DATA)this._alertData;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_AlertData(ProtoData.ALERT_DATA value)
        {
            this._alertData = value;
            if(this.AlertDataSet == null)
            {
                    return;
            }
            
            this.AlertDataSet.Invoke(obj:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProtoData.AUDIO_DATA get_AudioData()
        {
            return (ProtoData.AUDIO_DATA)this._audioData;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_AudioData(ProtoData.AUDIO_DATA value)
        {
            this._audioData = value;
            if(this.AudioDataSet == null)
            {
                    return;
            }
            
            this.AudioDataSet.Invoke(obj:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProtoData.CONFIG_DATA get_ConfigData()
        {
            return (ProtoData.CONFIG_DATA)this._configData;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_ConfigData(ProtoData.CONFIG_DATA value)
        {
            this._configData = value;
            if(this.ConfigDataSet == null)
            {
                    return;
            }
            
            this.ConfigDataSet.Invoke(obj:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProtoData.DEVICES_DATA get_DevicesData()
        {
            return (ProtoData.DEVICES_DATA)this._devicesData;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_DevicesData(ProtoData.DEVICES_DATA value)
        {
            this._devicesData = value;
            if(this.DevicesDataSet == null)
            {
                    return;
            }
            
            this.DevicesDataSet.Invoke(obj:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProtoData.TUTORIAL_DATA get_TutorialData()
        {
            return (ProtoData.TUTORIAL_DATA)this._tutorialData;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_TutorialData(ProtoData.TUTORIAL_DATA value)
        {
            this._tutorialData = value;
            if(this.TutorialDataSet == null)
            {
                    return;
            }
            
            this.TutorialDataSet.Invoke(obj:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProtoData.KEY_VALUE_DATA get_KeyValueData()
        {
            return (ProtoData.KEY_VALUE_DATA)this._keyValueData;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_KeyValueData(ProtoData.KEY_VALUE_DATA value)
        {
            this._keyValueData = value;
            if(this.KeyValueDataSet == null)
            {
                    return;
            }
            
            this.KeyValueDataSet.Invoke(obj:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProtoData.ESSENCE_DATA get_EssenceData()
        {
            return (ProtoData.ESSENCE_DATA)this._essenceData;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_EssenceData(ProtoData.ESSENCE_DATA value)
        {
            this._essenceData = value;
            if(this.EssenceDataSet == null)
            {
                    return;
            }
            
            this.EssenceDataSet.Invoke(obj:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProtoData.ESSENCE_TYPES_DATA get_EssenceTypesData()
        {
            return (ProtoData.ESSENCE_TYPES_DATA)this._essenceTypesData;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_EssenceTypesData(ProtoData.ESSENCE_TYPES_DATA value)
        {
            this._essenceTypesData = value;
            if(this.EssenceTypesDataSet == null)
            {
                    return;
            }
            
            this.EssenceTypesDataSet.Invoke(obj:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProtoData.FTUE_DATA get_FTUEData()
        {
            return (ProtoData.FTUE_DATA)this._ftueData;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_FTUEData(ProtoData.FTUE_DATA value)
        {
            this._ftueData = value;
            if(this.FTUEDataSet == null)
            {
                    return;
            }
            
            this.FTUEDataSet.Invoke(obj:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProtoData.LOGIN_ABS_DATA get_LoginABSData()
        {
            return (ProtoData.LOGIN_ABS_DATA)this._loginABSData;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_LoginABSData(ProtoData.LOGIN_ABS_DATA value)
        {
            this._loginABSData = value;
            if(this.LoginABSDataSet == null)
            {
                    return;
            }
            
            this.LoginABSDataSet.Invoke(obj:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProtoData.LOGIN_REPEAT_DATA get_LoginRepeatData()
        {
            return (ProtoData.LOGIN_REPEAT_DATA)this._loginRepeatData;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_LoginRepeatData(ProtoData.LOGIN_REPEAT_DATA value)
        {
            this._loginRepeatData = value;
            if(this.LoginRepeatDataSet == null)
            {
                    return;
            }
            
            this.LoginRepeatDataSet.Invoke(obj:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProtoData.METRICS_DATA get_MetricsData()
        {
            return (ProtoData.METRICS_DATA)this._metricsData;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_MetricsData(ProtoData.METRICS_DATA value)
        {
            this._metricsData = value;
            if(this.MetricsDataSet == null)
            {
                    return;
            }
            
            this.MetricsDataSet.Invoke(obj:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProtoData.MODS_DATA get_ModsData()
        {
            return (ProtoData.MODS_DATA)this._modsData;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_ModsData(ProtoData.MODS_DATA value)
        {
            this._modsData = value;
            if(this.ModsDataSet == null)
            {
                    return;
            }
            
            this.ModsDataSet.Invoke(obj:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProtoData.PROGRESSION_DATA get_ProgressionData()
        {
            return (ProtoData.PROGRESSION_DATA)this._progressionData;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_ProgressionData(ProtoData.PROGRESSION_DATA value)
        {
            this._progressionData = value;
            if(this.ProgressionDataSet == null)
            {
                    return;
            }
            
            this.ProgressionDataSet.Invoke(obj:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProtoData.STATIC_DATA get_StaticData()
        {
            return (ProtoData.STATIC_DATA)this._staticData;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_StaticData(ProtoData.STATIC_DATA value)
        {
            this._staticData = value;
            if(this.StaticDataSet == null)
            {
                    return;
            }
            
            this.StaticDataSet.Invoke(obj:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProtoData.WEARANDTEAR_DATA get_WearAndTearData()
        {
            return (ProtoData.WEARANDTEAR_DATA)this._wearAndTearData;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_WearAndTearData(ProtoData.WEARANDTEAR_DATA value)
        {
            this._wearAndTearData = value;
            if(this.WearAndTearDataSet == null)
            {
                    return;
            }
            
            this.WearAndTearDataSet.Invoke(obj:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProtoData.CPU_DATA get_CPUData()
        {
            return (ProtoData.CPU_DATA)this._cpuData;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_CPUData(ProtoData.CPU_DATA value)
        {
            this._cpuData = value;
            if(this.CPUDataSet == null)
            {
                    return;
            }
            
            this.CPUDataSet.Invoke(obj:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProtoData.PLUSHSUIT_DATA get_PlushSuitData()
        {
            return (ProtoData.PLUSHSUIT_DATA)this._plushSuitData;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_PlushSuitData(ProtoData.PLUSHSUIT_DATA value)
        {
            this._plushSuitData = value;
            if(this.PlushSuitDataSet == null)
            {
                    return;
            }
            
            this.PlushSuitDataSet.Invoke(obj:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProtoData.ATTACK_DATA get_AttackData()
        {
            return (ProtoData.ATTACK_DATA)this._attackData;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_AttackData(ProtoData.ATTACK_DATA value)
        {
            this._attackData = value;
            if(this.AttackDataSet == null)
            {
                    return;
            }
            
            this.AttackDataSet.Invoke(obj:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProtoData.LOC_DATA get_LocData()
        {
            return (ProtoData.LOC_DATA)this._locData;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_LocData(ProtoData.LOC_DATA value)
        {
            this._locData = value;
            if(this.LocDataSet == null)
            {
                    return;
            }
            
            this.LocDataSet.Invoke(obj:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProtoData.STORE_DATA get_StoreData()
        {
            return (ProtoData.STORE_DATA)this._storeData;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_StoreData(ProtoData.STORE_DATA value)
        {
            this._storeData = value;
            if(this.StoreDataSet == null)
            {
                    return;
            }
            
            this.StoreDataSet.Invoke(obj:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProtoData.STORESECTIONS_DATA get_StoreSectionData()
        {
            return (ProtoData.STORESECTIONS_DATA)this._storeSectionData;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_StoreSectionData(ProtoData.STORESECTIONS_DATA value)
        {
            this._storeSectionData = value;
            if(this.StoreSectionDataSet == null)
            {
                    return;
            }
            
            this.StoreSectionDataSet.Invoke(obj:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProtoData.REMNANT_DEBUFF_DATA get_RemnantDebuffData()
        {
            return (ProtoData.REMNANT_DEBUFF_DATA)this._remnantDebuffData;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_RemnantDebuffData(ProtoData.REMNANT_DEBUFF_DATA value)
        {
            this._remnantDebuffData = value;
            if(this.RemnantDebuffDataSet == null)
            {
                    return;
            }
            
            this.RemnantDebuffDataSet.Invoke(obj:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProtoData.MODCATEGORIES_DATA get_ModCategoryData()
        {
            return (ProtoData.MODCATEGORIES_DATA)this._modCategoryData;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_ModCategoryData(ProtoData.MODCATEGORIES_DATA value)
        {
            this._modCategoryData = value;
            if(this.ModCategoryDataSet == null)
            {
                    return;
            }
            
            this.ModCategoryDataSet.Invoke(obj:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProtoData.SERVERBLOCKINGERROR_DATA get_ServerblockingerrorData()
        {
            return (ProtoData.SERVERBLOCKINGERROR_DATA)this._serverblockingerrorData;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_ServerblockingerrorData(ProtoData.SERVERBLOCKINGERROR_DATA value)
        {
            this._serverblockingerrorData = value;
            if(this.ServerBlockingErrorDataSet == null)
            {
                    return;
            }
            
            this.ServerBlockingErrorDataSet.Invoke(obj:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProtoData.SEQUENTIAL_REWARDS_DATA get_SequentialRewardsData()
        {
            return (ProtoData.SEQUENTIAL_REWARDS_DATA)this._sequentialRewardsData;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_SequentialRewardsData(ProtoData.SEQUENTIAL_REWARDS_DATA value)
        {
            this._sequentialRewardsData = value;
            if(this.SequentialRewardsDataSet == null)
            {
                    return;
            }
            
            this.SequentialRewardsDataSet.Invoke(obj:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProtoData.SEASONAL_ASSETS_DATA get_SeasonalAssetsData()
        {
            return (ProtoData.SEASONAL_ASSETS_DATA)this._seasonalAssetsData;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_SeasonalAssetsData(ProtoData.SEASONAL_ASSETS_DATA value)
        {
            this._seasonalAssetsData = value;
            if(this.SeasonalAssetsDataSet == null)
            {
                    return;
            }
            
            this.SeasonalAssetsDataSet.Invoke(obj:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProtoData.SEASONAL_DATA get_SeasonalData()
        {
            return (ProtoData.SEASONAL_DATA)this._seasonalData;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_SeasonalData(ProtoData.SEASONAL_DATA value)
        {
            this._seasonalData = value;
            if(this.SeasonalDataSet == null)
            {
                    return;
            }
            
            this.SeasonalDataSet.Invoke(obj:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProtoData.INBOX_DATA get_InboxData()
        {
            return (ProtoData.INBOX_DATA)this._inboxData;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_InboxData(ProtoData.INBOX_DATA value)
        {
            this._inboxData = value;
            if(this.InboxDataSet == null)
            {
                    return;
            }
            
            this.InboxDataSet.Invoke(obj:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProtoData.DAILY_CHALLENGE_DATA get_DailyChallengeData()
        {
            return (ProtoData.DAILY_CHALLENGE_DATA)this._dailyChallengeData;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_DailyChallengeData(ProtoData.DAILY_CHALLENGE_DATA value)
        {
            this._dailyChallengeData = value;
            if(this.DailyChallengeDataSet == null)
            {
                    return;
            }
            
            this.DailyChallengeDataSet.Invoke(obj:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProtoData.DAILY_CHALLENGE_REWARDS_DATA get_DailyChallengeRewardsData()
        {
            return (ProtoData.DAILY_CHALLENGE_REWARDS_DATA)this._dailyChallengeRewardsData;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_DailyChallengeRewardsData(ProtoData.DAILY_CHALLENGE_REWARDS_DATA value)
        {
            this._dailyChallengeRewardsData = value;
            if(this.DailyChallengeRewardsDataSet == null)
            {
                    return;
            }
            
            this.DailyChallengeRewardsDataSet.Invoke(obj:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MasterData()
        {
        
        }
    
    }

}
