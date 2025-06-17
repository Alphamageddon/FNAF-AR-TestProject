using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ServerGameUIDataModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.MasterDomain _masterDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int <currentStreak>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int <bestStreak>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int <modSlotUnlocks>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int <workshopSlotsUnlocks>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int <masterDataVersion>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int <assetBundleVersion>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<TheGame.Data.LeaderboardEntry> <bestStreakLeaderboard>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<TheGame.Data.LeaderboardEntry> <currentStreakLeaderboard>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <showUIBars>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <AlertsAllowed>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int <maxEmailsToDeletePacketSize>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int <maxEmailsSetReadPacketSize>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <dailyChallengesEnabled>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.AttackSequence.Encounters.EncounterResult lastEncounter;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int currentStreak { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int bestStreak { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int modSlotUnlocks { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int workshopSlotsUnlocks { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int masterDataVersion { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int assetBundleVersion { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<TheGame.Data.LeaderboardEntry> bestStreakLeaderboard { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<TheGame.Data.LeaderboardEntry> currentStreakLeaderboard { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool showUIBars { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool AlertsAllowed { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int maxEmailsToDeletePacketSize { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int maxEmailsSetReadPacketSize { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool dailyChallengesEnabled { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int get_currentStreak()
        {
            return (int)this.<currentStreak>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_currentStreak(int value)
        {
            this.<currentStreak>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int get_bestStreak()
        {
            return (int)this.<bestStreak>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_bestStreak(int value)
        {
            this.<bestStreak>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_modSlotUnlocks()
        {
            return (int)this.<modSlotUnlocks>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_modSlotUnlocks(int value)
        {
            this.<modSlotUnlocks>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_workshopSlotsUnlocks()
        {
            return (int)this.<workshopSlotsUnlocks>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_workshopSlotsUnlocks(int value)
        {
            this.<workshopSlotsUnlocks>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_masterDataVersion()
        {
            return (int)this.<masterDataVersion>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_masterDataVersion(int value)
        {
            this.<masterDataVersion>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_assetBundleVersion()
        {
            return (int)this.<assetBundleVersion>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_assetBundleVersion(int value)
        {
            this.<assetBundleVersion>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<TheGame.Data.LeaderboardEntry> get_bestStreakLeaderboard()
        {
            return (System.Collections.Generic.List<TheGame.Data.LeaderboardEntry>)this.<bestStreakLeaderboard>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_bestStreakLeaderboard(System.Collections.Generic.List<TheGame.Data.LeaderboardEntry> value)
        {
            this.<bestStreakLeaderboard>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<TheGame.Data.LeaderboardEntry> get_currentStreakLeaderboard()
        {
            return (System.Collections.Generic.List<TheGame.Data.LeaderboardEntry>)this.<currentStreakLeaderboard>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_currentStreakLeaderboard(System.Collections.Generic.List<TheGame.Data.LeaderboardEntry> value)
        {
            this.<currentStreakLeaderboard>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_showUIBars()
        {
            return (bool)this.<showUIBars>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_showUIBars(bool value)
        {
            this.<showUIBars>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_AlertsAllowed()
        {
            return (bool)this.<AlertsAllowed>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_AlertsAllowed(bool value)
        {
            this.<AlertsAllowed>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_maxEmailsToDeletePacketSize()
        {
            return (int)this.<maxEmailsToDeletePacketSize>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_maxEmailsToDeletePacketSize(int value)
        {
            this.<maxEmailsToDeletePacketSize>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_maxEmailsSetReadPacketSize()
        {
            return (int)this.<maxEmailsSetReadPacketSize>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_maxEmailsSetReadPacketSize(int value)
        {
            this.<maxEmailsSetReadPacketSize>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_dailyChallengesEnabled()
        {
            return (bool)this.<dailyChallengesEnabled>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_dailyChallengesEnabled(bool value)
        {
            this.<dailyChallengesEnabled>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EventExposerShowUiBars(bool value)
        {
            this.<showUIBars>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnStreakDataUpdated(TheGame.Data.StreakData data)
        {
            this.lastEncounter = 0;
            if(data != null)
            {
                    this.<currentStreak>k__BackingField = data.currentStreak;
            }
            else
            {
                    this.<currentStreak>k__BackingField = 11993091;
            }
            
            this.<bestStreak>k__BackingField = data.bestStreak;
            this._masterDomain.ItemDefinitionDomain.GetInterfaceAsync(callback:  new System.Action<Game.ItemDefinition.IItemDefinitionDomain>(object:  this, method:  System.Void GameUI.ServerGameUIDataModel::UpdateStreakBasedUnlocks(Game.ItemDefinition.IItemDefinitionDomain itemDefinitionDomain)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateStreakBasedUnlocks(Game.ItemDefinition.IItemDefinitionDomain itemDefinitionDomain)
        {
            var val_7 = 0;
            val_7 = val_7 + 1;
            this.<modSlotUnlocks>k__BackingField = itemDefinitionDomain.ItemDefinitions.GetNumModSlotsUnlocked(bestStreak:  this.<bestStreak>k__BackingField);
            var val_8 = 0;
            val_8 = val_8 + 1;
            this.<workshopSlotsUnlocks>k__BackingField = itemDefinitionDomain.ItemDefinitions.GetNumWorkshopSlotsUnlocked(bestStreak:  this.<bestStreak>k__BackingField);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EventExposer_AttackSequenceReadyForUi(Game.AttackSequence.Encounters.EncounterResult result)
        {
            this.lastEncounter = result;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnBestStreakLeaderboardUpdated(System.Collections.Generic.List<TheGame.Data.LeaderboardEntry> data)
        {
            this.<bestStreakLeaderboard>k__BackingField = data;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnCurrentStreakLeaderboardUpdated(System.Collections.Generic.List<TheGame.Data.LeaderboardEntry> data)
        {
            this.<currentStreakLeaderboard>k__BackingField = data;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnMasterDataVersionReceived(int data)
        {
            this.<masterDataVersion>k__BackingField = data;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnAssetBundleVersionReceived(Game.AssetManagement.AssetBundleVersionInfo info)
        {
            this.<assetBundleVersion>k__BackingField = info.Version;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EventExposer_RewardsFlowCompleted()
        {
            this.lastEncounter = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EventExposer_FeatureFlagsUpdatedEvent(Systems.Guide.FeatureFlags.FeatureFlagMap obj)
        {
            this.<AlertsAllowed>k__BackingField = obj.AreAlertsAllowed();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EventExposer_MaxEmailsToDeletePacketSizeReceived(int num)
        {
            this.<maxEmailsToDeletePacketSize>k__BackingField = num;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EventExposer_MaxEmailsSetReadPacketSizeReceived(int num)
        {
            this.<maxEmailsSetReadPacketSize>k__BackingField = num;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ConfigDataReady(ProtoData.CONFIG_DATA.Types.ENTRY configDataEntry)
        {
            var val_12;
            bool val_13;
            this.<maxEmailsToDeletePacketSize>k__BackingField = UnityEngine.Mathf.RoundToInt(f:  (float)configDataEntry.InboxBatchLimits.MaxDelete);
            this.<maxEmailsSetReadPacketSize>k__BackingField = UnityEngine.Mathf.RoundToInt(f:  (float)configDataEntry.InboxBatchLimits.MaxSetToRead);
            if(configDataEntry == null)
            {
                goto label_8;
            }
            
            DAILYCHALLENGES val_7 = configDataEntry.DailyChallenges;
            if(val_7 == null)
            {
                goto label_8;
            }
            
            bool val_9 = val_7.Enable;
            val_12 = 0;
            goto label_9;
            label_8:
            val_12 = 0;
            label_9:
            if(((-1188478052) & 1) != 0)
            {
                    val_13 = val_12.GetValueOrDefault();
            }
            else
            {
                    val_13 = false;
            }
            
            this.<dailyChallengesEnabled>k__BackingField = val_13;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ServerGameUIDataModel(Master.MasterDomain masterDomain)
        {
            this.<maxEmailsToDeletePacketSize>k__BackingField = 4294967297;
            this.<maxEmailsSetReadPacketSize>k__BackingField = 1;
            this._masterDomain = masterDomain;
            masterDomain.eventExposer.add_ShowUIBars(value:  new System.Action<System.Boolean>(object:  this, method:  System.Void GameUI.ServerGameUIDataModel::EventExposerShowUiBars(bool value)));
            this._masterDomain.eventExposer.add_StreakDataUpdated(value:  new System.Action<TheGame.Data.StreakData>(object:  this, method:  System.Void GameUI.ServerGameUIDataModel::OnStreakDataUpdated(TheGame.Data.StreakData data)));
            this._masterDomain.eventExposer.add_AttackSequenceReadyForUi(value:  new System.Action<Game.AttackSequence.Encounters.EncounterResult>(object:  this, method:  System.Void GameUI.ServerGameUIDataModel::EventExposer_AttackSequenceReadyForUi(Game.AttackSequence.Encounters.EncounterResult result)));
            this._masterDomain.eventExposer.add_BestStreakLeaderboardUpdated(value:  new System.Action<System.Collections.Generic.List<TheGame.Data.LeaderboardEntry>>(object:  this, method:  System.Void GameUI.ServerGameUIDataModel::OnBestStreakLeaderboardUpdated(System.Collections.Generic.List<TheGame.Data.LeaderboardEntry> data)));
            this._masterDomain.eventExposer.add_CurrentStreakLeaderboardUpdated(value:  new System.Action<System.Collections.Generic.List<TheGame.Data.LeaderboardEntry>>(object:  this, method:  System.Void GameUI.ServerGameUIDataModel::OnCurrentStreakLeaderboardUpdated(System.Collections.Generic.List<TheGame.Data.LeaderboardEntry> data)));
            this._masterDomain.eventExposer.add_MasterDataVersionReceived(value:  new System.Action<System.Int32>(object:  this, method:  System.Void GameUI.ServerGameUIDataModel::OnMasterDataVersionReceived(int data)));
            this._masterDomain.eventExposer.add_AssetBundleVersionReceived(value:  new System.Action<Game.AssetManagement.AssetBundleVersionInfo>(object:  this, method:  System.Void GameUI.ServerGameUIDataModel::OnAssetBundleVersionReceived(Game.AssetManagement.AssetBundleVersionInfo info)));
            this._masterDomain.eventExposer.add_RewardsFlowCompleted(value:  new System.Action(object:  this, method:  System.Void GameUI.ServerGameUIDataModel::EventExposer_RewardsFlowCompleted()));
            this._masterDomain.eventExposer.add_FeatureFlagsUpdatedEvent(value:  new System.Action<Systems.Guide.FeatureFlags.FeatureFlagMap>(object:  this, method:  System.Void GameUI.ServerGameUIDataModel::EventExposer_FeatureFlagsUpdatedEvent(Systems.Guide.FeatureFlags.FeatureFlagMap obj)));
            this._masterDomain.eventExposer.add_MaxEmailsToDeletePacketSizeReceived(value:  new System.Action<System.Int32>(object:  this, method:  System.Void GameUI.ServerGameUIDataModel::EventExposer_MaxEmailsToDeletePacketSizeReceived(int num)));
            this._masterDomain.eventExposer.add_MaxEmailsSetReadPacketSizeReceived(value:  new System.Action<System.Int32>(object:  this, method:  System.Void GameUI.ServerGameUIDataModel::EventExposer_MaxEmailsSetReadPacketSizeReceived(int num)));
            this._masterDomain.MasterDataDomain.GetAccessToData.GetConfigDataEntryAsync(returnConfigDataEntryCallback:  new GetAccessToData.ReturnConfigDataEntry(object:  this, method:  System.Void GameUI.ServerGameUIDataModel::ConfigDataReady(ProtoData.CONFIG_DATA.Types.ENTRY configDataEntry)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int GetServerCurrentStreak()
        {
            return (int)this.<currentStreak>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int GetServerBestStreak()
        {
            return (int)this.<bestStreak>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int GetClientCurrentStreak()
        {
            return (int)(this.lastEncounter == 0) ? this.<currentStreak>k__BackingField : this.lastEncounter.NewCurrentStreak;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int GetClientBestStreak()
        {
            return (int)(this.lastEncounter == 0) ? this.<bestStreak>k__BackingField : this.lastEncounter.NewBestStreak;
        }
    
    }

}
