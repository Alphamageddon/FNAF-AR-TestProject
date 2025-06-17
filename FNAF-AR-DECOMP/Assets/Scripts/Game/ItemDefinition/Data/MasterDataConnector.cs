using UnityEngine;

namespace Game.ItemDefinition.Data
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class MasterDataConnector
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <HaveModsLoaded>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <HaveCpusLoaded>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <HavePlushSuitsLoaded>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <HaveWearAndTearDataLoaded>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <HasProgressionDataLoaded>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <HaveDevicesLoaded>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <HasStoreDataLoaded>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <HasPackDataLoaded>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <HaveRewardsLoaded>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <HasEssenceLoaded>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <HaveAttackProfilesLoaded>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <HasRemnantDebuffDataLoaded>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <HasSequentialRewardsDataLoaded>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <HasSeasonDataLoaded>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <HasInboxDataLoaded>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <HasAlertDataLoaded>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.ItemDefinition.Container.ItemDefinitions _itemDefinitions;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action OnDataLoaded;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool HaveModsLoaded { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool HaveCpusLoaded { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool HavePlushSuitsLoaded { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool HaveWearAndTearDataLoaded { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool HasProgressionDataLoaded { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool HaveDevicesLoaded { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool HasStoreDataLoaded { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool HasPackDataLoaded { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool HaveRewardsLoaded { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool HasEssenceLoaded { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool HaveAttackProfilesLoaded { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool HasRemnantDebuffDataLoaded { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool HasSequentialRewardsDataLoaded { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool HasSeasonDataLoaded { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool HasInboxDataLoaded { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool HasAlertDataLoaded { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_HaveModsLoaded()
        {
            return (bool)this.<HaveModsLoaded>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_HaveModsLoaded(bool value)
        {
            this.<HaveModsLoaded>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_HaveCpusLoaded()
        {
            return (bool)this.<HaveCpusLoaded>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_HaveCpusLoaded(bool value)
        {
            this.<HaveCpusLoaded>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_HavePlushSuitsLoaded()
        {
            return (bool)this.<HavePlushSuitsLoaded>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_HavePlushSuitsLoaded(bool value)
        {
            this.<HavePlushSuitsLoaded>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_HaveWearAndTearDataLoaded()
        {
            return (bool)this.<HaveWearAndTearDataLoaded>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_HaveWearAndTearDataLoaded(bool value)
        {
            this.<HaveWearAndTearDataLoaded>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_HasProgressionDataLoaded()
        {
            return (bool)this.<HasProgressionDataLoaded>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_HasProgressionDataLoaded(bool value)
        {
            this.<HasProgressionDataLoaded>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_HaveDevicesLoaded()
        {
            return (bool)this.<HaveDevicesLoaded>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_HaveDevicesLoaded(bool value)
        {
            this.<HaveDevicesLoaded>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_HasStoreDataLoaded()
        {
            return (bool)this.<HasStoreDataLoaded>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_HasStoreDataLoaded(bool value)
        {
            this.<HasStoreDataLoaded>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_HasPackDataLoaded()
        {
            return (bool)this.<HasPackDataLoaded>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_HasPackDataLoaded(bool value)
        {
            this.<HasPackDataLoaded>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_HaveRewardsLoaded()
        {
            return (bool)this.<HaveRewardsLoaded>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_HaveRewardsLoaded(bool value)
        {
            this.<HaveRewardsLoaded>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_HasEssenceLoaded()
        {
            return (bool)this.<HasEssenceLoaded>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_HasEssenceLoaded(bool value)
        {
            this.<HasEssenceLoaded>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_HaveAttackProfilesLoaded()
        {
            return (bool)this.<HaveAttackProfilesLoaded>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_HaveAttackProfilesLoaded(bool value)
        {
            this.<HaveAttackProfilesLoaded>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_HasRemnantDebuffDataLoaded()
        {
            return (bool)this.<HasRemnantDebuffDataLoaded>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_HasRemnantDebuffDataLoaded(bool value)
        {
            this.<HasRemnantDebuffDataLoaded>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_HasSequentialRewardsDataLoaded()
        {
            return (bool)this.<HasSequentialRewardsDataLoaded>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_HasSequentialRewardsDataLoaded(bool value)
        {
            this.<HasSequentialRewardsDataLoaded>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_HasSeasonDataLoaded()
        {
            return (bool)this.<HasSeasonDataLoaded>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_HasSeasonDataLoaded(bool value)
        {
            this.<HasSeasonDataLoaded>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_HasInboxDataLoaded()
        {
            return (bool)this.<HasInboxDataLoaded>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_HasInboxDataLoaded(bool value)
        {
            this.<HasInboxDataLoaded>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_HasAlertDataLoaded()
        {
            return (bool)this.<HasAlertDataLoaded>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_HasAlertDataLoaded(bool value)
        {
            this.<HasAlertDataLoaded>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void add_OnDataLoaded(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnDataLoaded, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnDataLoaded != 1152921525290372760);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void remove_OnDataLoaded(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnDataLoaded, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnDataLoaded != 1152921525290509336);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MasterDataConnector(Game.MasterData.MasterDataDomain masterDataDomain, Game.ItemDefinition.Container.ItemDefinitions itemDefinitions, System.Action callback)
        {
            val_1 = new System.Object();
            this._itemDefinitions = val_1;
            masterDataDomain.<_getAccessToData>k__BackingField.GetModsDataAsync(returnModsDataCallback:  new GetAccessToData.ReturnAnyData<ProtoData.MODS_DATA>(object:  this, method:  System.Void Game.ItemDefinition.Data.MasterDataConnector::SetModData(ProtoData.MODS_DATA modData)));
            masterDataDomain.<_getAccessToData>k__BackingField.GetCPUDataAsync(returnCPUDataCallback:  new GetAccessToData.ReturnAnyData<ProtoData.CPU_DATA>(object:  this, method:  System.Void Game.ItemDefinition.Data.MasterDataConnector::SetCPUData(ProtoData.CPU_DATA cpuData)));
            masterDataDomain.<_getAccessToData>k__BackingField.GetPlushSuitDataAsync(returnPlushSuitDataCallback:  new GetAccessToData.ReturnAnyData<ProtoData.PLUSHSUIT_DATA>(object:  this, method:  System.Void Game.ItemDefinition.Data.MasterDataConnector::SetPlushSuitData(ProtoData.PLUSHSUIT_DATA plushSuitData)));
            mem[1152921525290859152] = this;
            mem[1152921525290859160] = System.Void Game.ItemDefinition.Data.MasterDataConnector::SetRewardData(ProtoData.CONFIG_DATA.Types.ENTRY configDataEntry);
            mem[1152921525290859136] = System.Void Game.ItemDefinition.Data.MasterDataConnector::SetRewardData(ProtoData.CONFIG_DATA.Types.ENTRY configDataEntry);
            masterDataDomain.<_getAccessToData>k__BackingField.AddConfigDataCallback(returnConfigDataEntryCallback:  new GetAccessToData.ReturnConfigDataEntry());
            masterDataDomain.<_getAccessToData>k__BackingField.TryCallConfigDataCallbacks();
            masterDataDomain.<_getAccessToData>k__BackingField.GetDevicesDataAsync(returnDevicesDataCallback:  new GetAccessToData.ReturnAnyData<ProtoData.DEVICES_DATA>(object:  this, method:  System.Void Game.ItemDefinition.Data.MasterDataConnector::SetDeviceData(ProtoData.DEVICES_DATA deviceData)));
            masterDataDomain.<_getAccessToData>k__BackingField.GetWearAndTearDataAsync(returnWearAndTearDataCallback:  new GetAccessToData.ReturnAnyData<ProtoData.WEARANDTEAR_DATA>(object:  this, method:  System.Void Game.ItemDefinition.Data.MasterDataConnector::SetWearAndTearData(ProtoData.WEARANDTEAR_DATA wearAndTearData)));
            masterDataDomain.<_getAccessToData>k__BackingField.GetProgressionDataAsync(returnProgressionDataCallback:  new GetAccessToData.ReturnAnyData<ProtoData.PROGRESSION_DATA>(object:  this, method:  System.Void Game.ItemDefinition.Data.MasterDataConnector::GetProgressionData(ProtoData.PROGRESSION_DATA progressionData)));
            masterDataDomain.<_getAccessToData>k__BackingField.GetEssenceDataAsync(returnEssenceDataCallback:  new GetAccessToData.ReturnAnyData<ProtoData.ESSENCE_DATA>(object:  this, method:  System.Void Game.ItemDefinition.Data.MasterDataConnector::SetEssenceData(ProtoData.ESSENCE_DATA data)));
            masterDataDomain.<_getAccessToData>k__BackingField.GetAttackDataAsync(returnAttackDataCallback:  new GetAccessToData.ReturnAnyData<ProtoData.ATTACK_DATA>(object:  this, method:  System.Void Game.ItemDefinition.Data.MasterDataConnector::SetAttackData(ProtoData.ATTACK_DATA data)));
            masterDataDomain.<_getAccessToData>k__BackingField.GetRemnantDebuffDataAsync(returnRemnantDebuffDataCallback:  new GetAccessToData.ReturnAnyData<ProtoData.REMNANT_DEBUFF_DATA>(object:  this, method:  System.Void Game.ItemDefinition.Data.MasterDataConnector::SetRemnantDebuffData(ProtoData.REMNANT_DEBUFF_DATA data)));
            masterDataDomain.<_getAccessToData>k__BackingField.GetSequentialRewardsDataAsync(setSequentialRewardsData:  new GetAccessToData.ReturnAnyData<ProtoData.SEQUENTIAL_REWARDS_DATA>(object:  this, method:  System.Void Game.ItemDefinition.Data.MasterDataConnector::SetSequentialRewardsData(ProtoData.SEQUENTIAL_REWARDS_DATA sequentialRewardsData)));
            masterDataDomain.<_getAccessToData>k__BackingField.GetSeasonalDataAsync(returnSeasonalDataCallback:  new GetAccessToData.ReturnAnyData<ProtoData.SEASONAL_DATA>(object:  this, method:  System.Void Game.ItemDefinition.Data.MasterDataConnector::GetDeasonalData(ProtoData.SEASONAL_DATA alertData)));
            masterDataDomain.<_getAccessToData>k__BackingField.GetInboxDataAsync(returnInboxData:  new GetAccessToData.ReturnAnyData<ProtoData.INBOX_DATA>(object:  this, method:  System.Void Game.ItemDefinition.Data.MasterDataConnector::GetInboxData(ProtoData.INBOX_DATA alertData)));
            masterDataDomain.<_getAccessToData>k__BackingField.GetAlertDataAsync(returnAlertDataCallback:  new GetAccessToData.ReturnAnyData<ProtoData.ALERT_DATA>(object:  this, method:  System.Void Game.ItemDefinition.Data.MasterDataConnector::GetAlertData(ProtoData.ALERT_DATA alertData)));
            this.add_OnDataLoaded(value:  callback);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GetAlertData(ProtoData.ALERT_DATA alertData)
        {
            this._itemDefinitions.LoadAlertData(alertData:  alertData);
            this.<HasAlertDataLoaded>k__BackingField = true;
            if(this.OnDataLoaded == null)
            {
                    return;
            }
            
            this.OnDataLoaded.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GetInboxData(ProtoData.INBOX_DATA alertData)
        {
            this._itemDefinitions.LoadInboxData(data:  alertData);
            this.<HasInboxDataLoaded>k__BackingField = true;
            if(this.OnDataLoaded == null)
            {
                    return;
            }
            
            this.OnDataLoaded.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetSequentialRewardsData(ProtoData.SEQUENTIAL_REWARDS_DATA sequentialRewardsData)
        {
            this._itemDefinitions.LoadSequentialRewardsDataFromServer(data:  sequentialRewardsData);
            this.<HasSequentialRewardsDataLoaded>k__BackingField = true;
            if(this.OnDataLoaded == null)
            {
                    return;
            }
            
            this.OnDataLoaded.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GetProgressionData(ProtoData.PROGRESSION_DATA progressionData)
        {
            this._itemDefinitions.LoadProgressionDataFromServer(progressionData:  progressionData);
            this.<HasProgressionDataLoaded>k__BackingField = true;
            if(this.OnDataLoaded == null)
            {
                    return;
            }
            
            this.OnDataLoaded.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetModData(ProtoData.MODS_DATA modData)
        {
            this._itemDefinitions.LoadModsFromServer(data:  modData);
            this.<HaveModsLoaded>k__BackingField = true;
            if(this.OnDataLoaded == null)
            {
                    return;
            }
            
            this.OnDataLoaded.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetCPUData(ProtoData.CPU_DATA cpuData)
        {
            this._itemDefinitions.LoadCPUsFromServer(data:  cpuData);
            this.<HaveCpusLoaded>k__BackingField = true;
            if(this.OnDataLoaded == null)
            {
                    return;
            }
            
            this.OnDataLoaded.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetPlushSuitData(ProtoData.PLUSHSUIT_DATA plushSuitData)
        {
            this._itemDefinitions.LoadPlushSuitsFromServer(data:  plushSuitData);
            this.<HavePlushSuitsLoaded>k__BackingField = true;
            if(this.OnDataLoaded == null)
            {
                    return;
            }
            
            this.OnDataLoaded.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetDeviceData(ProtoData.DEVICES_DATA deviceData)
        {
            this._itemDefinitions.LoadDevicesFromServer(data:  deviceData);
            this.<HaveDevicesLoaded>k__BackingField = true;
            if(this.OnDataLoaded == null)
            {
                    return;
            }
            
            this.OnDataLoaded.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetWearAndTearData(ProtoData.WEARANDTEAR_DATA wearAndTearData)
        {
            this._itemDefinitions.LoadWearAndTearDataFromServer(data:  wearAndTearData);
            this.<HaveWearAndTearDataLoaded>k__BackingField = true;
            if(this.OnDataLoaded == null)
            {
                    return;
            }
            
            this.OnDataLoaded.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetRewardData(ProtoData.CONFIG_DATA.Types.ENTRY configDataEntry)
        {
            this._itemDefinitions.LoadRewardDataFromServer(configDataEntry:  configDataEntry);
            this.<HaveRewardsLoaded>k__BackingField = true;
            if(this.OnDataLoaded == null)
            {
                    return;
            }
            
            this.OnDataLoaded.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetEssenceData(ProtoData.ESSENCE_DATA data)
        {
            this._itemDefinitions.LoadEssenceDataFromServer(data:  data);
            this.<HasEssenceLoaded>k__BackingField = true;
            if(this.OnDataLoaded == null)
            {
                    return;
            }
            
            this.OnDataLoaded.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetAttackData(ProtoData.ATTACK_DATA data)
        {
            this._itemDefinitions.LoadAttackDataFromServer(data:  data);
            this.<HaveAttackProfilesLoaded>k__BackingField = true;
            if(this.OnDataLoaded == null)
            {
                    return;
            }
            
            this.OnDataLoaded.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetRemnantDebuffData(ProtoData.REMNANT_DEBUFF_DATA data)
        {
            this._itemDefinitions.LoadRemnantDebuffDataFromServer(data:  data);
            this.<HasRemnantDebuffDataLoaded>k__BackingField = true;
            if(this.OnDataLoaded == null)
            {
                    return;
            }
            
            this.OnDataLoaded.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GetDeasonalData(ProtoData.SEASONAL_DATA alertData)
        {
            this._itemDefinitions.LoadSeasonDataFromServer(alertData:  alertData);
            this.<HasSeasonDataLoaded>k__BackingField = true;
            if(this.OnDataLoaded == null)
            {
                    return;
            }
            
            this.OnDataLoaded.Invoke();
        }
    
    }

}
