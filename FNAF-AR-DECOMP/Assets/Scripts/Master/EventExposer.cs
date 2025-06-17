using UnityEngine;

namespace Master
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class EventExposer
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action FTUEComplete;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action ShouldStartCheckingSeasonalUpdate;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<float> HeartbeatPeriodChanged;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<Alerts.Data.PlayerAlertData> AlertPlayerDataUpdatedEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<AnimatronicEntity.FastForwardCompleteArgs> EntityFastForwardComplete;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<AnimatronicEntity.Container.EntityAddedRemovedArgs> EntityAddedEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<AnimatronicEntity.Container.EntityAddedRemovedArgs> EntityRemovedEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<AnimatronicEntity.Container.EntitiesClearedArgs> EntitiesClearedEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<AnimatronicEntity.Mover.EntityMovedArgs> EntityMovedEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<AnimatronicEntity.StateChooser.EntityStateChangedArgs> EntityStateChangedEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<AnimatronicEntity.Loader.LoadedArgs> LoadedEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<AnimatronicEntity.SaveGameChunk> EntityChunkGenerated;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<string> AnimatronicRequestedFromServer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action NewAnimatronicSpawned;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<MapMode.GeoPositionObject.Container.GeoPositionObjectAddedRemovedArgs> GeoPositionObjectAddedEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action Authenticated;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<string> ForcedUpdate;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<System.Collections.Generic.List<AnimatronicEntity.SaveGameChunk>> PlayerAnimatronicDataLoaded;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<System.Collections.Generic.Dictionary<string, int>> PlayerCurrencyRefreshed;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<Game.TheGame.Data.RewardData> RewardsReceived;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<TheGame.PlayerInventory> InventoryUpdated;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<long> ServerTimeReceived;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action AttackModeLost;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<string> ConfigJsonDataReceived;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<string> AnimatronicJsonDataReceived;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<string> AlertJsonDataReceived;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action DeviceDataRequested;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<Game.TheGame.Data.AllPlayerDevices> DeviceDataReceived;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<System.Collections.Generic.Dictionary<string, int>> PurchaseDataReceived;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action PurchaseProcessed;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<bool> PurchaseRequestAudioInvoked;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<Game.TheGame.Data.TutorialData> TutorialStartupDataReceived;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<long> UpdateNextAnimatronicRequestTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action LoadingDone;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<TheGame.Data.StreakData> StreakDataUpdated;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<int> PurchasedSlotsUpdated;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<Game.PlayerStats.Data.PlayerStatsData> PlayerStatsUpdated;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<System.Collections.Generic.Dictionary<string, int>> PlayerGoodsUpdated;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<System.Collections.Generic.List<TheGame.Data.LeaderboardEntry>> BestStreakLeaderboardUpdated;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<System.Collections.Generic.List<TheGame.Data.LeaderboardEntry>> CurrentStreakLeaderboardUpdated;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<int> MasterDataVersionReceived;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<Game.AssetManagement.AssetBundleVersionInfo> AssetBundleVersionReceived;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<System.Collections.Generic.Dictionary<string, Animatronics.AnimatronicStats.StatsData>> AnimatronicStatsUpdated;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<string> AnimatronicSent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<AnimatronicEntity.Data.WorkshopData> WorkshopDataUpdated;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<UnityEngine.Vector3, UnityEngine.Vector3> WorkshopCameraRotated;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<string> AudioJsonDataReceived;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<string> DevicesJsonDataReceived;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<string> TutorialJsonDataReceived;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<string> KeyValueJsonDataReceived;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<string> EssenceJsonDataReceived;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<string> EssenceTypesJsonDataReceived;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<string> FTUEJsonDataReceived;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<string> LoginABSJsonDataReceived;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<string> LoginRepeatJsonDataReceived;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<string> MetricsJsonDataReceived;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<string> ModsJsonDataReceived;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<string> ProgressionJsonDataReceived;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<string> StaticJsonDataReceived;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<string> WearAndTearJsonReceived;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<string> CPUJsonDataReceived;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<string> PlushSuitJsonDataReceived;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<string> AttackJsonDataReceived;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<string> LocJsonDataReceived;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<string> StoreJsonDataReceived;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<string> StoreSectionJsonDataReceived;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<string> DailyChallengeJsonDataReceived;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<string> DailyChallengeRewardsJsonDataReceived;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<string> RemnantDebuffJsonDataReceived;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<string> ModCategoriesDataRecieved;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<string> ServerBlockingErrorDataReceived;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<string> SeasonalDataReceived;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<string> SeasonalAssetsDataReceived;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<System.Collections.Generic.List<Game.SeasonalEvents.Data.SeasonalEventData>> SeasonalEventDataReceived;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<Game.SeasonalEvents.SeasonMechanicTag, System.Collections.Generic.List<string>> ActiveSeasonalEventsUpdated;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<string> SequentialRewardsDataReceived;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<Game.Store.Container.StoreContainer.StoreIdentificationData, System.Collections.Generic.List<Game.Store.Container.StoreContainer.VirtualGoodResponseData>> VirtualGoodsDataReceived;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<string> StoreIdReceived;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<string> StorePackJsonDataReceived;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<Game.Workshop.Data.ModInventory> ModInventoryUpdated;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<AnimatronicEntity.SaveGameChunk> AnimatronicEntityUpdated;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<MapMode.GeoPositionObject.Container.GeoPositionObjectAddedRemovedArgs> GeoPositionObjectAdded;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<Game.TheGame.Data.RewardDataV2> RewardsV2Received;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<AnimatronicEntity.Data.WorkshopData> WorkshopDataV2Updated;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<Game.TheGame.Data.CPUInventory> CPUInventoryUpdated;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<GameUI.GenericDialogData> GenericDialogRequestReceived;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action BuyMoreCoinsDialogRequest;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<GameUI.PopDownData> GenericPopDownRequested;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<Game.Server.PlayerEssenceData> PlayerEssenceDataUpdated;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<System.Collections.Generic.List<Game.Server.EssenceNodeEntry>> SpawnEssences;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<Systems.Guide.FeatureFlags.FeatureFlagMap> FeatureFlagsUpdatedEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<bool, string> EncounterEndedEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action StoreOpened;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action StoreClosed;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action ReadyToActivateLocationServices;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action ReadyToActivateAR;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<bool> HandleApplicationFocus;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<bool> NetworkConnectionUpdated;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<GameUI.GenericDialogData> NetworkDialogRequestReceived;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action NetworkDialogRequestRemoved;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action RewardDialogOpened;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action RewardDialogClosed;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action ToSAccepted;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action RecallButtonTapped;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<System.Collections.Generic.List<GameUI.WorkshopSlotData>> WorkshopSlotDataUpdated;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action RequestRestartOnMapOnly;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action RequestRestartGlobally;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<int> LocalGameplayAssetsReady;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action LocalGameplayEnded;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<int> TableOfContentsDownloadFailure;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<Systems.AssetManagement.Bundles.BundleDownloadProgressData> AssetBundleDownloadProgressUpdated;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<int> AssetBundleDownloadSegmentsAllComplete;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<string, UnityEngine.Transform> PopulateSeasonalAssetsRequest;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action WorkshopCpuChanged;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action WorkshopCpuMenuClosed;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action WorkshopCpuMenuOpened;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action WorkshopModMenuClosed;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action WorkshopModMenuOpened;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action WorkshopRepairSuccess;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<bool> WorkshopModIconPressed;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<Game.CameraEquipment.Battery.ExtraBatteryStateChange> ExtraBatteryStateChanged;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.CameraEquipment.Flashlight.FlashlightState.StateChanged FlashlightStateChanged;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action FlashlightTriedToActivate;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action FlashlightCooldownComplete;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<Game.CameraEquipment.Shocker.ShockerActivation> ShockerActivated;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action ShockerCooldownComplete;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action MaskForcedOff;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.CameraEquipment.Mask.MaskState.StateChanged MaskStateChanged;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.AttackSequence.DisruptionMechanic.AttackDisruption.StateChanged AttackDisruptionStateChanged;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.AttackSequence.SurgeMechanic.AttackSurge.StateChanged AttackSurgeStateChanged;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<Game.ItemDefinition.Data.DataDefinitions.EncounterType> AttackEncounterStarted;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<Game.AttackSequence.Encounters.EncounterResult> AttackSequenceReadyForUi;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action AttackEncounterEnded;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<Game.AttackSequence.Static.StaticSettings> StaticSettingsUpdated;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action AnimatronicAttackWindowClosed;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action AnimatronicShocked;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action AnimatronicDefeated;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<Game.AttackSequence.Animatronic.PhaseManagement.AttackPhase> PhaseCompleted;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action RewardsFlowCompleted;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<Game.EssenceCollection.Actions.EssenceNodes.CameraInfoRecorder.TrackerSessionPackage, System.Collections.Generic.List<Game.Server.EssenceNodeEntry>> EssenceNodeSelected;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<Game.EssenceCollection.Actions.EssenceNodes.CameraInfoRecorder.TrackerSessionPackage> EssenceTrackerSessionCompleted;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action RemnantCollectionAudioStarted;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action RemnantCollectionAudioEnded;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action NodeReset;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<UnityEngine.Vector3, UnityEngine.Vector2, float> GuidePointerRequested;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action GuidePointerDismissed;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<Server.PlayerProfile> PlayerProfileUpdated;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action PlayerAvatarUpdated;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<GameUI.UserNameSetError> DisplayNameObscenityFound;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action HardGlitchesEnded;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<string> StartupTaskCompleted;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<P7.CanvasFlow.CanvasController, string> PreloadEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<string> GuidePopupRequested;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<string> GuidePopupDismissed;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<string> GuidePopupClosing;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action GuideVisualizerPresent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action AnalyticsVisualizerPresent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<TutorialSendUIEvent.TutorialUIEvent> TutorialUIEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<string, string, AnimatronicEntity.SaveGameChunk> AnimatronicDataSentForId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer.FabButtonChangeHandler FabButtonConfigurationChangeEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action CompleteFTUEVideo;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action AnimatronicEntityReturned;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action StartMusic;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action PopulateExistingSeasonalReceivers;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<System.Collections.Generic.List<GameUI.EmailData>> InboxDataReceivedFromServer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<System.Collections.Generic.List<GameUI.EmailData>> EmailDataModelUpdated;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action InboxOpened;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action InboxClosed;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<int> MaxEmailsToDeletePacketSizeReceived;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<int> MaxEmailsSetReadPacketSizeReceived;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<string> InboxFolderDataReceived;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action ResultsDataUpdated;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<System.Collections.Generic.List<Game.SeasonalEvents.Data.SeasonalEventData>> SequentialRewardsModelUpdated;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<string> GetSocialInvitePayloadReceived;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<Systems.GetSocialInviteHandling.InviteSender.GetSocialInviteContent> GetSocialInviteExplicitContent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<bool, bool, int> GetSocialValidated;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<string> ReauthPayload;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<System.Collections.Generic.List<Game.Server.PlayerFriendsEntry>> FriendListUpdated;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action GameReadyForAlertsEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action GameReadyForAnimatronicsEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action GameReadyForServerHeartbeat;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<TheGame.GameDisplayData> GameDisplayChange;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<TheGame.GameDisplayData.DisplayType> UICanvasDidAppear;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<TheGame.GameDisplayData.DisplayType> UICanvasClosed;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<TheGame.GameDisplayData.DisplayType> UIChangeRequest;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<bool> ShowUIBars;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<string> RedeemCoupon;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<bool> CouponRedeemed;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<string> PersonalFriendCodeUpdated;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<Game.Server.FriendCodeResponseHandler.FriendLookupResponse> FriendCodeLookedUp;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<bool> AddedFriendByCode;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<Systems.Guide.UI.CameraUIIconAnimator> NewCameraUIIconAnimator;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<System.Collections.Generic.List<string>> PassiveRequestListReceived;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action ActiveDailyChallengesUpdated;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<Game.Server.DailyChallengeResponseData> DailyChallengeListReceived;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<string> DailyChallengeRewardReceived;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<GameUI.SequentialRewardsButtonDisplay> SequentialRewardsButtonReady;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_FTUEComplete(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.FTUEComplete, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.FTUEComplete != 1152921523202367952);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_FTUEComplete(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.FTUEComplete, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.FTUEComplete != 1152921523202504528);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_ShouldStartCheckingSeasonalUpdate(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.ShouldStartCheckingSeasonalUpdate, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.ShouldStartCheckingSeasonalUpdate != 1152921523202641112);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_ShouldStartCheckingSeasonalUpdate(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.ShouldStartCheckingSeasonalUpdate, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.ShouldStartCheckingSeasonalUpdate != 1152921523202777688);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_HeartbeatPeriodChanged(System.Action<float> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.HeartbeatPeriodChanged, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.HeartbeatPeriodChanged != 1152921523202914272);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_HeartbeatPeriodChanged(System.Action<float> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.HeartbeatPeriodChanged, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.HeartbeatPeriodChanged != 1152921523203050848);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_AlertPlayerDataUpdatedEvent(System.Action<Alerts.Data.PlayerAlertData> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.AlertPlayerDataUpdatedEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.AlertPlayerDataUpdatedEvent != 1152921523203187432);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_AlertPlayerDataUpdatedEvent(System.Action<Alerts.Data.PlayerAlertData> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.AlertPlayerDataUpdatedEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.AlertPlayerDataUpdatedEvent != 1152921523203324008);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_EntityFastForwardComplete(System.Action<AnimatronicEntity.FastForwardCompleteArgs> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.EntityFastForwardComplete, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.EntityFastForwardComplete != 1152921523203460592);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_EntityFastForwardComplete(System.Action<AnimatronicEntity.FastForwardCompleteArgs> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.EntityFastForwardComplete, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.EntityFastForwardComplete != 1152921523203597168);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_EntityAddedEvent(System.Action<AnimatronicEntity.Container.EntityAddedRemovedArgs> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.EntityAddedEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.EntityAddedEvent != 1152921523203733752);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_EntityAddedEvent(System.Action<AnimatronicEntity.Container.EntityAddedRemovedArgs> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.EntityAddedEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.EntityAddedEvent != 1152921523203870328);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_EntityRemovedEvent(System.Action<AnimatronicEntity.Container.EntityAddedRemovedArgs> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.EntityRemovedEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.EntityRemovedEvent != 1152921523204006912);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_EntityRemovedEvent(System.Action<AnimatronicEntity.Container.EntityAddedRemovedArgs> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.EntityRemovedEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.EntityRemovedEvent != 1152921523204143488);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_EntitiesClearedEvent(System.Action<AnimatronicEntity.Container.EntitiesClearedArgs> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.EntitiesClearedEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.EntitiesClearedEvent != 1152921523204280072);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_EntitiesClearedEvent(System.Action<AnimatronicEntity.Container.EntitiesClearedArgs> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.EntitiesClearedEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.EntitiesClearedEvent != 1152921523204416648);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_EntityMovedEvent(System.Action<AnimatronicEntity.Mover.EntityMovedArgs> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.EntityMovedEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.EntityMovedEvent != 1152921523204553232);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_EntityMovedEvent(System.Action<AnimatronicEntity.Mover.EntityMovedArgs> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.EntityMovedEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.EntityMovedEvent != 1152921523204689808);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_EntityStateChangedEvent(System.Action<AnimatronicEntity.StateChooser.EntityStateChangedArgs> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.EntityStateChangedEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.EntityStateChangedEvent != 1152921523204826392);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_EntityStateChangedEvent(System.Action<AnimatronicEntity.StateChooser.EntityStateChangedArgs> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.EntityStateChangedEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.EntityStateChangedEvent != 1152921523204962968);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_LoadedEvent(System.Action<AnimatronicEntity.Loader.LoadedArgs> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.LoadedEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.LoadedEvent != 1152921523205099552);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_LoadedEvent(System.Action<AnimatronicEntity.Loader.LoadedArgs> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.LoadedEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.LoadedEvent != 1152921523205236128);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_EntityChunkGenerated(System.Action<AnimatronicEntity.SaveGameChunk> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.EntityChunkGenerated, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.EntityChunkGenerated != 1152921523205372712);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_EntityChunkGenerated(System.Action<AnimatronicEntity.SaveGameChunk> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.EntityChunkGenerated, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.EntityChunkGenerated != 1152921523205509288);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_AnimatronicRequestedFromServer(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.AnimatronicRequestedFromServer, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.AnimatronicRequestedFromServer != 1152921523205645872);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_AnimatronicRequestedFromServer(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.AnimatronicRequestedFromServer, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.AnimatronicRequestedFromServer != 1152921523205782448);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_NewAnimatronicSpawned(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.NewAnimatronicSpawned, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.NewAnimatronicSpawned != 1152921523205919032);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_NewAnimatronicSpawned(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.NewAnimatronicSpawned, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.NewAnimatronicSpawned != 1152921523206055608);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_GeoPositionObjectAddedEvent(System.Action<MapMode.GeoPositionObject.Container.GeoPositionObjectAddedRemovedArgs> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.GeoPositionObjectAddedEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.GeoPositionObjectAddedEvent != 1152921523206192192);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_GeoPositionObjectAddedEvent(System.Action<MapMode.GeoPositionObject.Container.GeoPositionObjectAddedRemovedArgs> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.GeoPositionObjectAddedEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.GeoPositionObjectAddedEvent != 1152921523206328768);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_Authenticated(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.Authenticated, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.Authenticated != 1152921523206465352);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_Authenticated(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.Authenticated, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.Authenticated != 1152921523206601928);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_ForcedUpdate(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.ForcedUpdate, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.ForcedUpdate != 1152921523206738512);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_ForcedUpdate(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.ForcedUpdate, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.ForcedUpdate != 1152921523206875088);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_PlayerAnimatronicDataLoaded(System.Action<System.Collections.Generic.List<AnimatronicEntity.SaveGameChunk>> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.PlayerAnimatronicDataLoaded, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.PlayerAnimatronicDataLoaded != 1152921523207011672);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_PlayerAnimatronicDataLoaded(System.Action<System.Collections.Generic.List<AnimatronicEntity.SaveGameChunk>> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.PlayerAnimatronicDataLoaded, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.PlayerAnimatronicDataLoaded != 1152921523207148248);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_PlayerCurrencyRefreshed(System.Action<System.Collections.Generic.Dictionary<string, int>> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.PlayerCurrencyRefreshed, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.PlayerCurrencyRefreshed != 1152921523207284832);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_PlayerCurrencyRefreshed(System.Action<System.Collections.Generic.Dictionary<string, int>> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.PlayerCurrencyRefreshed, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.PlayerCurrencyRefreshed != 1152921523207421408);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_RewardsReceived(System.Action<Game.TheGame.Data.RewardData> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.RewardsReceived, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.RewardsReceived != 1152921523207557992);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_RewardsReceived(System.Action<Game.TheGame.Data.RewardData> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.RewardsReceived, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.RewardsReceived != 1152921523207694568);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_InventoryUpdated(System.Action<TheGame.PlayerInventory> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.InventoryUpdated, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.InventoryUpdated != 1152921523207831152);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_InventoryUpdated(System.Action<TheGame.PlayerInventory> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.InventoryUpdated, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.InventoryUpdated != 1152921523207967728);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_ServerTimeReceived(System.Action<long> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.ServerTimeReceived, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.ServerTimeReceived != 1152921523208104312);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_ServerTimeReceived(System.Action<long> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.ServerTimeReceived, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.ServerTimeReceived != 1152921523208240888);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_AttackModeLost(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.AttackModeLost, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.AttackModeLost != 1152921523208377472);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_AttackModeLost(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.AttackModeLost, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.AttackModeLost != 1152921523208514048);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_ConfigJsonDataReceived(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.ConfigJsonDataReceived, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.ConfigJsonDataReceived != 1152921523208650632);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_ConfigJsonDataReceived(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.ConfigJsonDataReceived, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.ConfigJsonDataReceived != 1152921523208787208);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_AnimatronicJsonDataReceived(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.AnimatronicJsonDataReceived, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.AnimatronicJsonDataReceived != 1152921523208923792);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_AnimatronicJsonDataReceived(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.AnimatronicJsonDataReceived, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.AnimatronicJsonDataReceived != 1152921523209060368);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_AlertJsonDataReceived(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.AlertJsonDataReceived, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.AlertJsonDataReceived != 1152921523209196952);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_AlertJsonDataReceived(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.AlertJsonDataReceived, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.AlertJsonDataReceived != 1152921523209333528);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_DeviceDataRequested(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.DeviceDataRequested, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.DeviceDataRequested != 1152921523209470112);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_DeviceDataRequested(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.DeviceDataRequested, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.DeviceDataRequested != 1152921523209606688);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_DeviceDataReceived(System.Action<Game.TheGame.Data.AllPlayerDevices> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.DeviceDataReceived, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.DeviceDataReceived != 1152921523209743272);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_DeviceDataReceived(System.Action<Game.TheGame.Data.AllPlayerDevices> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.DeviceDataReceived, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.DeviceDataReceived != 1152921523209879848);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_PurchaseDataReceived(System.Action<System.Collections.Generic.Dictionary<string, int>> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.PurchaseDataReceived, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.PurchaseDataReceived != 1152921523210016432);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_PurchaseDataReceived(System.Action<System.Collections.Generic.Dictionary<string, int>> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.PurchaseDataReceived, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.PurchaseDataReceived != 1152921523210153008);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_PurchaseProcessed(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.PurchaseProcessed, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.PurchaseProcessed != 1152921523210289592);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_PurchaseProcessed(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.PurchaseProcessed, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.PurchaseProcessed != 1152921523210426168);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_PurchaseRequestAudioInvoked(System.Action<bool> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.PurchaseRequestAudioInvoked, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.PurchaseRequestAudioInvoked != this.PurchaseRequestAudioInvoked);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_PurchaseRequestAudioInvoked(System.Action<bool> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.PurchaseRequestAudioInvoked, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.PurchaseRequestAudioInvoked != this.PurchaseRequestAudioInvoked);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_TutorialStartupDataReceived(System.Action<Game.TheGame.Data.TutorialData> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.TutorialStartupDataReceived, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.TutorialStartupDataReceived != this.TutorialStartupDataReceived);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_TutorialStartupDataReceived(System.Action<Game.TheGame.Data.TutorialData> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.TutorialStartupDataReceived, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.TutorialStartupDataReceived != this.TutorialStartupDataReceived);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_UpdateNextAnimatronicRequestTime(System.Action<long> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.UpdateNextAnimatronicRequestTime, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.UpdateNextAnimatronicRequestTime != this.UpdateNextAnimatronicRequestTime);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_UpdateNextAnimatronicRequestTime(System.Action<long> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.UpdateNextAnimatronicRequestTime, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.UpdateNextAnimatronicRequestTime != this.UpdateNextAnimatronicRequestTime);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_LoadingDone(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.LoadingDone, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.LoadingDone != this.LoadingDone);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_LoadingDone(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.LoadingDone, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.LoadingDone != this.LoadingDone);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_StreakDataUpdated(System.Action<TheGame.Data.StreakData> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.StreakDataUpdated, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.StreakDataUpdated != this.StreakDataUpdated);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_StreakDataUpdated(System.Action<TheGame.Data.StreakData> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.StreakDataUpdated, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.StreakDataUpdated != this.StreakDataUpdated);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_PurchasedSlotsUpdated(System.Action<int> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.PurchasedSlotsUpdated, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.PurchasedSlotsUpdated != this.PurchasedSlotsUpdated);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_PurchasedSlotsUpdated(System.Action<int> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.PurchasedSlotsUpdated, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.PurchasedSlotsUpdated != this.PurchasedSlotsUpdated);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_PlayerStatsUpdated(System.Action<Game.PlayerStats.Data.PlayerStatsData> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.PlayerStatsUpdated, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.PlayerStatsUpdated != this.PlayerStatsUpdated);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_PlayerStatsUpdated(System.Action<Game.PlayerStats.Data.PlayerStatsData> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.PlayerStatsUpdated, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.PlayerStatsUpdated != this.PlayerStatsUpdated);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_PlayerGoodsUpdated(System.Action<System.Collections.Generic.Dictionary<string, int>> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.PlayerGoodsUpdated, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.PlayerGoodsUpdated != this.PlayerGoodsUpdated);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_PlayerGoodsUpdated(System.Action<System.Collections.Generic.Dictionary<string, int>> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.PlayerGoodsUpdated, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.PlayerGoodsUpdated != this.PlayerGoodsUpdated);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_BestStreakLeaderboardUpdated(System.Action<System.Collections.Generic.List<TheGame.Data.LeaderboardEntry>> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.BestStreakLeaderboardUpdated, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.BestStreakLeaderboardUpdated != this.BestStreakLeaderboardUpdated);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_BestStreakLeaderboardUpdated(System.Action<System.Collections.Generic.List<TheGame.Data.LeaderboardEntry>> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.BestStreakLeaderboardUpdated, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.BestStreakLeaderboardUpdated != this.BestStreakLeaderboardUpdated);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_CurrentStreakLeaderboardUpdated(System.Action<System.Collections.Generic.List<TheGame.Data.LeaderboardEntry>> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.CurrentStreakLeaderboardUpdated, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.CurrentStreakLeaderboardUpdated != this.CurrentStreakLeaderboardUpdated);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_CurrentStreakLeaderboardUpdated(System.Action<System.Collections.Generic.List<TheGame.Data.LeaderboardEntry>> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.CurrentStreakLeaderboardUpdated, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.CurrentStreakLeaderboardUpdated != this.CurrentStreakLeaderboardUpdated);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_MasterDataVersionReceived(System.Action<int> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.MasterDataVersionReceived, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.MasterDataVersionReceived != this.MasterDataVersionReceived);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_MasterDataVersionReceived(System.Action<int> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.MasterDataVersionReceived, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.MasterDataVersionReceived != this.MasterDataVersionReceived);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_AssetBundleVersionReceived(System.Action<Game.AssetManagement.AssetBundleVersionInfo> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.AssetBundleVersionReceived, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.AssetBundleVersionReceived != this.AssetBundleVersionReceived);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_AssetBundleVersionReceived(System.Action<Game.AssetManagement.AssetBundleVersionInfo> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.AssetBundleVersionReceived, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.AssetBundleVersionReceived != this.AssetBundleVersionReceived);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_AnimatronicStatsUpdated(System.Action<System.Collections.Generic.Dictionary<string, Animatronics.AnimatronicStats.StatsData>> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.AnimatronicStatsUpdated, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.AnimatronicStatsUpdated != this.AnimatronicStatsUpdated);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_AnimatronicStatsUpdated(System.Action<System.Collections.Generic.Dictionary<string, Animatronics.AnimatronicStats.StatsData>> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.AnimatronicStatsUpdated, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.AnimatronicStatsUpdated != this.AnimatronicStatsUpdated);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_AnimatronicSent(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.AnimatronicSent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.AnimatronicSent != this.AnimatronicSent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_AnimatronicSent(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.AnimatronicSent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.AnimatronicSent != this.AnimatronicSent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_WorkshopDataUpdated(System.Action<AnimatronicEntity.Data.WorkshopData> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.WorkshopDataUpdated, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.WorkshopDataUpdated != this.WorkshopDataUpdated);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_WorkshopDataUpdated(System.Action<AnimatronicEntity.Data.WorkshopData> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.WorkshopDataUpdated, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.WorkshopDataUpdated != this.WorkshopDataUpdated);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_WorkshopCameraRotated(System.Action<UnityEngine.Vector3, UnityEngine.Vector3> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.WorkshopCameraRotated, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.WorkshopCameraRotated != this.WorkshopCameraRotated);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_WorkshopCameraRotated(System.Action<UnityEngine.Vector3, UnityEngine.Vector3> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.WorkshopCameraRotated, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.WorkshopCameraRotated != this.WorkshopCameraRotated);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_AudioJsonDataReceived(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.AudioJsonDataReceived, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.AudioJsonDataReceived != this.AudioJsonDataReceived);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_AudioJsonDataReceived(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.AudioJsonDataReceived, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.AudioJsonDataReceived != this.AudioJsonDataReceived);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_DevicesJsonDataReceived(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.DevicesJsonDataReceived, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.DevicesJsonDataReceived != this.DevicesJsonDataReceived);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_DevicesJsonDataReceived(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.DevicesJsonDataReceived, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.DevicesJsonDataReceived != this.DevicesJsonDataReceived);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_TutorialJsonDataReceived(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.TutorialJsonDataReceived, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.TutorialJsonDataReceived != this.TutorialJsonDataReceived);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_TutorialJsonDataReceived(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.TutorialJsonDataReceived, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.TutorialJsonDataReceived != this.TutorialJsonDataReceived);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_KeyValueJsonDataReceived(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.KeyValueJsonDataReceived, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.KeyValueJsonDataReceived != this.KeyValueJsonDataReceived);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_KeyValueJsonDataReceived(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.KeyValueJsonDataReceived, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.KeyValueJsonDataReceived != this.KeyValueJsonDataReceived);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_EssenceJsonDataReceived(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.EssenceJsonDataReceived, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.EssenceJsonDataReceived != this.EssenceJsonDataReceived);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_EssenceJsonDataReceived(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.EssenceJsonDataReceived, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.EssenceJsonDataReceived != this.EssenceJsonDataReceived);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_EssenceTypesJsonDataReceived(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.EssenceTypesJsonDataReceived, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.EssenceTypesJsonDataReceived != this.EssenceTypesJsonDataReceived);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_EssenceTypesJsonDataReceived(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.EssenceTypesJsonDataReceived, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.EssenceTypesJsonDataReceived != this.EssenceTypesJsonDataReceived);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_FTUEJsonDataReceived(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.FTUEJsonDataReceived, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.FTUEJsonDataReceived != this.FTUEJsonDataReceived);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_FTUEJsonDataReceived(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.FTUEJsonDataReceived, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.FTUEJsonDataReceived != this.FTUEJsonDataReceived);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_LoginABSJsonDataReceived(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.LoginABSJsonDataReceived, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.LoginABSJsonDataReceived != this.LoginABSJsonDataReceived);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_LoginABSJsonDataReceived(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.LoginABSJsonDataReceived, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.LoginABSJsonDataReceived != this.LoginABSJsonDataReceived);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_LoginRepeatJsonDataReceived(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.LoginRepeatJsonDataReceived, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.LoginRepeatJsonDataReceived != this.LoginRepeatJsonDataReceived);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_LoginRepeatJsonDataReceived(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.LoginRepeatJsonDataReceived, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.LoginRepeatJsonDataReceived != this.LoginRepeatJsonDataReceived);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_MetricsJsonDataReceived(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.MetricsJsonDataReceived, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.MetricsJsonDataReceived != this.MetricsJsonDataReceived);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_MetricsJsonDataReceived(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.MetricsJsonDataReceived, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.MetricsJsonDataReceived != this.MetricsJsonDataReceived);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_ModsJsonDataReceived(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.ModsJsonDataReceived, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.ModsJsonDataReceived != this.ModsJsonDataReceived);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_ModsJsonDataReceived(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.ModsJsonDataReceived, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.ModsJsonDataReceived != this.ModsJsonDataReceived);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_ProgressionJsonDataReceived(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.ProgressionJsonDataReceived, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.ProgressionJsonDataReceived != this.ProgressionJsonDataReceived);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_ProgressionJsonDataReceived(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.ProgressionJsonDataReceived, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.ProgressionJsonDataReceived != this.ProgressionJsonDataReceived);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_StaticJsonDataReceived(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.StaticJsonDataReceived, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.StaticJsonDataReceived != this.StaticJsonDataReceived);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_StaticJsonDataReceived(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.StaticJsonDataReceived, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.StaticJsonDataReceived != this.StaticJsonDataReceived);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_WearAndTearJsonReceived(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.WearAndTearJsonReceived, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.WearAndTearJsonReceived != this.WearAndTearJsonReceived);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_WearAndTearJsonReceived(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.WearAndTearJsonReceived, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.WearAndTearJsonReceived != this.WearAndTearJsonReceived);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_CPUJsonDataReceived(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.CPUJsonDataReceived, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.CPUJsonDataReceived != this.CPUJsonDataReceived);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_CPUJsonDataReceived(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.CPUJsonDataReceived, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.CPUJsonDataReceived != this.CPUJsonDataReceived);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_PlushSuitJsonDataReceived(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.PlushSuitJsonDataReceived, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.PlushSuitJsonDataReceived != this.PlushSuitJsonDataReceived);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_PlushSuitJsonDataReceived(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.PlushSuitJsonDataReceived, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.PlushSuitJsonDataReceived != this.PlushSuitJsonDataReceived);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_AttackJsonDataReceived(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.AttackJsonDataReceived, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.AttackJsonDataReceived != this.AttackJsonDataReceived);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_AttackJsonDataReceived(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.AttackJsonDataReceived, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.AttackJsonDataReceived != this.AttackJsonDataReceived);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_LocJsonDataReceived(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.LocJsonDataReceived, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.LocJsonDataReceived != this.LocJsonDataReceived);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_LocJsonDataReceived(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.LocJsonDataReceived, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.LocJsonDataReceived != this.LocJsonDataReceived);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_StoreJsonDataReceived(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.StoreJsonDataReceived, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.StoreJsonDataReceived != this.StoreJsonDataReceived);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_StoreJsonDataReceived(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.StoreJsonDataReceived, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.StoreJsonDataReceived != this.StoreJsonDataReceived);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_StoreSectionJsonDataReceived(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.StoreSectionJsonDataReceived, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.StoreSectionJsonDataReceived != this.StoreSectionJsonDataReceived);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_StoreSectionJsonDataReceived(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.StoreSectionJsonDataReceived, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.StoreSectionJsonDataReceived != this.StoreSectionJsonDataReceived);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_DailyChallengeJsonDataReceived(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.DailyChallengeJsonDataReceived, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.DailyChallengeJsonDataReceived != this.DailyChallengeJsonDataReceived);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_DailyChallengeJsonDataReceived(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.DailyChallengeJsonDataReceived, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.DailyChallengeJsonDataReceived != this.DailyChallengeJsonDataReceived);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_DailyChallengeRewardsJsonDataReceived(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.DailyChallengeRewardsJsonDataReceived, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.DailyChallengeRewardsJsonDataReceived != this.DailyChallengeRewardsJsonDataReceived);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_DailyChallengeRewardsJsonDataReceived(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.DailyChallengeRewardsJsonDataReceived, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.DailyChallengeRewardsJsonDataReceived != this.DailyChallengeRewardsJsonDataReceived);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_RemnantDebuffJsonDataReceived(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.RemnantDebuffJsonDataReceived, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.RemnantDebuffJsonDataReceived != this.RemnantDebuffJsonDataReceived);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_RemnantDebuffJsonDataReceived(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.RemnantDebuffJsonDataReceived, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.RemnantDebuffJsonDataReceived != this.RemnantDebuffJsonDataReceived);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_ModCategoriesDataRecieved(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.ModCategoriesDataRecieved, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.ModCategoriesDataRecieved != this.ModCategoriesDataRecieved);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_ModCategoriesDataRecieved(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.ModCategoriesDataRecieved, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.ModCategoriesDataRecieved != this.ModCategoriesDataRecieved);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_ServerBlockingErrorDataReceived(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.ServerBlockingErrorDataReceived, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.ServerBlockingErrorDataReceived != this.ServerBlockingErrorDataReceived);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_ServerBlockingErrorDataReceived(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.ServerBlockingErrorDataReceived, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.ServerBlockingErrorDataReceived != this.ServerBlockingErrorDataReceived);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_SeasonalDataReceived(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.SeasonalDataReceived, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.SeasonalDataReceived != this.SeasonalDataReceived);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_SeasonalDataReceived(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.SeasonalDataReceived, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.SeasonalDataReceived != this.SeasonalDataReceived);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_SeasonalAssetsDataReceived(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.SeasonalAssetsDataReceived, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.SeasonalAssetsDataReceived != this.SeasonalAssetsDataReceived);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_SeasonalAssetsDataReceived(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.SeasonalAssetsDataReceived, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.SeasonalAssetsDataReceived != this.SeasonalAssetsDataReceived);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_SeasonalEventDataReceived(System.Action<System.Collections.Generic.List<Game.SeasonalEvents.Data.SeasonalEventData>> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.SeasonalEventDataReceived, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.SeasonalEventDataReceived != this.SeasonalEventDataReceived);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_SeasonalEventDataReceived(System.Action<System.Collections.Generic.List<Game.SeasonalEvents.Data.SeasonalEventData>> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.SeasonalEventDataReceived, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.SeasonalEventDataReceived != this.SeasonalEventDataReceived);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_ActiveSeasonalEventsUpdated(System.Action<Game.SeasonalEvents.SeasonMechanicTag, System.Collections.Generic.List<string>> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.ActiveSeasonalEventsUpdated, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.ActiveSeasonalEventsUpdated != this.ActiveSeasonalEventsUpdated);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_ActiveSeasonalEventsUpdated(System.Action<Game.SeasonalEvents.SeasonMechanicTag, System.Collections.Generic.List<string>> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.ActiveSeasonalEventsUpdated, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.ActiveSeasonalEventsUpdated != this.ActiveSeasonalEventsUpdated);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_SequentialRewardsDataReceived(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.SequentialRewardsDataReceived, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.SequentialRewardsDataReceived != this.SequentialRewardsDataReceived);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_SequentialRewardsDataReceived(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.SequentialRewardsDataReceived, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.SequentialRewardsDataReceived != this.SequentialRewardsDataReceived);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_VirtualGoodsDataReceived(System.Action<Game.Store.Container.StoreContainer.StoreIdentificationData, System.Collections.Generic.List<Game.Store.Container.StoreContainer.VirtualGoodResponseData>> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.VirtualGoodsDataReceived, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.VirtualGoodsDataReceived != this.VirtualGoodsDataReceived);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_VirtualGoodsDataReceived(System.Action<Game.Store.Container.StoreContainer.StoreIdentificationData, System.Collections.Generic.List<Game.Store.Container.StoreContainer.VirtualGoodResponseData>> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.VirtualGoodsDataReceived, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.VirtualGoodsDataReceived != this.VirtualGoodsDataReceived);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_StoreIdReceived(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.StoreIdReceived, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.StoreIdReceived != this.StoreIdReceived);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_StoreIdReceived(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.StoreIdReceived, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.StoreIdReceived != this.StoreIdReceived);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_StorePackJsonDataReceived(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.StorePackJsonDataReceived, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.StorePackJsonDataReceived != this.StorePackJsonDataReceived);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_StorePackJsonDataReceived(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.StorePackJsonDataReceived, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.StorePackJsonDataReceived != this.StorePackJsonDataReceived);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_ModInventoryUpdated(System.Action<Game.Workshop.Data.ModInventory> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.ModInventoryUpdated, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.ModInventoryUpdated != this.ModInventoryUpdated);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_ModInventoryUpdated(System.Action<Game.Workshop.Data.ModInventory> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.ModInventoryUpdated, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.ModInventoryUpdated != this.ModInventoryUpdated);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_AnimatronicEntityUpdated(System.Action<AnimatronicEntity.SaveGameChunk> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.AnimatronicEntityUpdated, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.AnimatronicEntityUpdated != this.AnimatronicEntityUpdated);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_AnimatronicEntityUpdated(System.Action<AnimatronicEntity.SaveGameChunk> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.AnimatronicEntityUpdated, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.AnimatronicEntityUpdated != this.AnimatronicEntityUpdated);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_GeoPositionObjectAdded(System.Action<MapMode.GeoPositionObject.Container.GeoPositionObjectAddedRemovedArgs> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.GeoPositionObjectAdded, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.GeoPositionObjectAdded != this.GeoPositionObjectAdded);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_GeoPositionObjectAdded(System.Action<MapMode.GeoPositionObject.Container.GeoPositionObjectAddedRemovedArgs> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.GeoPositionObjectAdded, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.GeoPositionObjectAdded != this.GeoPositionObjectAdded);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_RewardsV2Received(System.Action<Game.TheGame.Data.RewardDataV2> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.RewardsV2Received, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.RewardsV2Received != this.RewardsV2Received);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_RewardsV2Received(System.Action<Game.TheGame.Data.RewardDataV2> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.RewardsV2Received, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.RewardsV2Received != this.RewardsV2Received);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_WorkshopDataV2Updated(System.Action<AnimatronicEntity.Data.WorkshopData> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.WorkshopDataV2Updated, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.WorkshopDataV2Updated != this.WorkshopDataV2Updated);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_WorkshopDataV2Updated(System.Action<AnimatronicEntity.Data.WorkshopData> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.WorkshopDataV2Updated, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.WorkshopDataV2Updated != this.WorkshopDataV2Updated);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_CPUInventoryUpdated(System.Action<Game.TheGame.Data.CPUInventory> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.CPUInventoryUpdated, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.CPUInventoryUpdated != this.CPUInventoryUpdated);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_CPUInventoryUpdated(System.Action<Game.TheGame.Data.CPUInventory> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.CPUInventoryUpdated, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.CPUInventoryUpdated != this.CPUInventoryUpdated);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_GenericDialogRequestReceived(System.Action<GameUI.GenericDialogData> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.GenericDialogRequestReceived, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.GenericDialogRequestReceived != this.GenericDialogRequestReceived);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_GenericDialogRequestReceived(System.Action<GameUI.GenericDialogData> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.GenericDialogRequestReceived, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.GenericDialogRequestReceived != this.GenericDialogRequestReceived);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_BuyMoreCoinsDialogRequest(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.BuyMoreCoinsDialogRequest, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.BuyMoreCoinsDialogRequest != this.BuyMoreCoinsDialogRequest);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_BuyMoreCoinsDialogRequest(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.BuyMoreCoinsDialogRequest, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.BuyMoreCoinsDialogRequest != this.BuyMoreCoinsDialogRequest);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_GenericPopDownRequested(System.Action<GameUI.PopDownData> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.GenericPopDownRequested, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.GenericPopDownRequested != this.GenericPopDownRequested);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_GenericPopDownRequested(System.Action<GameUI.PopDownData> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.GenericPopDownRequested, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.GenericPopDownRequested != this.GenericPopDownRequested);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_PlayerEssenceDataUpdated(System.Action<Game.Server.PlayerEssenceData> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.PlayerEssenceDataUpdated, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.PlayerEssenceDataUpdated != this.PlayerEssenceDataUpdated);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_PlayerEssenceDataUpdated(System.Action<Game.Server.PlayerEssenceData> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.PlayerEssenceDataUpdated, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.PlayerEssenceDataUpdated != this.PlayerEssenceDataUpdated);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_SpawnEssences(System.Action<System.Collections.Generic.List<Game.Server.EssenceNodeEntry>> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.SpawnEssences, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.SpawnEssences != this.SpawnEssences);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_SpawnEssences(System.Action<System.Collections.Generic.List<Game.Server.EssenceNodeEntry>> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.SpawnEssences, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.SpawnEssences != this.SpawnEssences);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_FeatureFlagsUpdatedEvent(System.Action<Systems.Guide.FeatureFlags.FeatureFlagMap> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.FeatureFlagsUpdatedEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.FeatureFlagsUpdatedEvent != this.FeatureFlagsUpdatedEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_FeatureFlagsUpdatedEvent(System.Action<Systems.Guide.FeatureFlags.FeatureFlagMap> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.FeatureFlagsUpdatedEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.FeatureFlagsUpdatedEvent != this.FeatureFlagsUpdatedEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_EncounterEndedEvent(System.Action<bool, string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.EncounterEndedEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.EncounterEndedEvent != this.EncounterEndedEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_EncounterEndedEvent(System.Action<bool, string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.EncounterEndedEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.EncounterEndedEvent != this.EncounterEndedEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_StoreOpened(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.StoreOpened, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.StoreOpened != this.StoreOpened);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_StoreOpened(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.StoreOpened, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.StoreOpened != this.StoreOpened);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_StoreClosed(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.StoreClosed, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.StoreClosed != this.StoreClosed);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_StoreClosed(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.StoreClosed, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.StoreClosed != this.StoreClosed);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_ReadyToActivateLocationServices(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.ReadyToActivateLocationServices, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.ReadyToActivateLocationServices != this.ReadyToActivateLocationServices);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_ReadyToActivateLocationServices(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.ReadyToActivateLocationServices, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.ReadyToActivateLocationServices != this.ReadyToActivateLocationServices);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_ReadyToActivateAR(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.ReadyToActivateAR, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.ReadyToActivateAR != this.ReadyToActivateAR);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_ReadyToActivateAR(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.ReadyToActivateAR, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.ReadyToActivateAR != this.ReadyToActivateAR);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_HandleApplicationFocus(System.Action<bool> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.HandleApplicationFocus, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.HandleApplicationFocus != this.HandleApplicationFocus);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_HandleApplicationFocus(System.Action<bool> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.HandleApplicationFocus, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.HandleApplicationFocus != this.HandleApplicationFocus);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_NetworkConnectionUpdated(System.Action<bool> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.NetworkConnectionUpdated, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.NetworkConnectionUpdated != this.NetworkConnectionUpdated);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_NetworkConnectionUpdated(System.Action<bool> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.NetworkConnectionUpdated, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.NetworkConnectionUpdated != this.NetworkConnectionUpdated);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_NetworkDialogRequestReceived(System.Action<GameUI.GenericDialogData> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.NetworkDialogRequestReceived, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.NetworkDialogRequestReceived != this.NetworkDialogRequestReceived);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_NetworkDialogRequestReceived(System.Action<GameUI.GenericDialogData> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.NetworkDialogRequestReceived, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.NetworkDialogRequestReceived != this.NetworkDialogRequestReceived);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_NetworkDialogRequestRemoved(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.NetworkDialogRequestRemoved, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.NetworkDialogRequestRemoved != this.NetworkDialogRequestRemoved);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_NetworkDialogRequestRemoved(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.NetworkDialogRequestRemoved, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.NetworkDialogRequestRemoved != this.NetworkDialogRequestRemoved);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_RewardDialogOpened(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.RewardDialogOpened, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.RewardDialogOpened != this.RewardDialogOpened);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_RewardDialogOpened(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.RewardDialogOpened, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.RewardDialogOpened != this.RewardDialogOpened);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_RewardDialogClosed(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.RewardDialogClosed, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.RewardDialogClosed != this.RewardDialogClosed);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_RewardDialogClosed(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.RewardDialogClosed, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.RewardDialogClosed != this.RewardDialogClosed);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_ToSAccepted(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.ToSAccepted, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.ToSAccepted != this.ToSAccepted);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_ToSAccepted(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.ToSAccepted, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.ToSAccepted != this.ToSAccepted);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_RecallButtonTapped(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.RecallButtonTapped, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.RecallButtonTapped != this.RecallButtonTapped);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_RecallButtonTapped(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.RecallButtonTapped, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.RecallButtonTapped != this.RecallButtonTapped);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_WorkshopSlotDataUpdated(System.Action<System.Collections.Generic.List<GameUI.WorkshopSlotData>> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.WorkshopSlotDataUpdated, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.WorkshopSlotDataUpdated != this.WorkshopSlotDataUpdated);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_WorkshopSlotDataUpdated(System.Action<System.Collections.Generic.List<GameUI.WorkshopSlotData>> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.WorkshopSlotDataUpdated, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.WorkshopSlotDataUpdated != this.WorkshopSlotDataUpdated);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_RequestRestartOnMapOnly(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.RequestRestartOnMapOnly, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.RequestRestartOnMapOnly != this.RequestRestartOnMapOnly);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_RequestRestartOnMapOnly(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.RequestRestartOnMapOnly, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.RequestRestartOnMapOnly != this.RequestRestartOnMapOnly);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_RequestRestartGlobally(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.RequestRestartGlobally, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.RequestRestartGlobally != this.RequestRestartGlobally);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_RequestRestartGlobally(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.RequestRestartGlobally, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.RequestRestartGlobally != this.RequestRestartGlobally);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_LocalGameplayAssetsReady(System.Action<int> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.LocalGameplayAssetsReady, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.LocalGameplayAssetsReady != this.LocalGameplayAssetsReady);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_LocalGameplayAssetsReady(System.Action<int> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.LocalGameplayAssetsReady, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.LocalGameplayAssetsReady != this.LocalGameplayAssetsReady);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_LocalGameplayEnded(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.LocalGameplayEnded, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.LocalGameplayEnded != this.LocalGameplayEnded);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_LocalGameplayEnded(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.LocalGameplayEnded, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.LocalGameplayEnded != this.LocalGameplayEnded);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_TableOfContentsDownloadFailure(System.Action<int> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.TableOfContentsDownloadFailure, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.TableOfContentsDownloadFailure != this.TableOfContentsDownloadFailure);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_TableOfContentsDownloadFailure(System.Action<int> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.TableOfContentsDownloadFailure, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.TableOfContentsDownloadFailure != this.TableOfContentsDownloadFailure);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_AssetBundleDownloadProgressUpdated(System.Action<Systems.AssetManagement.Bundles.BundleDownloadProgressData> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.AssetBundleDownloadProgressUpdated, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.AssetBundleDownloadProgressUpdated != this.AssetBundleDownloadProgressUpdated);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_AssetBundleDownloadProgressUpdated(System.Action<Systems.AssetManagement.Bundles.BundleDownloadProgressData> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.AssetBundleDownloadProgressUpdated, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.AssetBundleDownloadProgressUpdated != this.AssetBundleDownloadProgressUpdated);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_AssetBundleDownloadSegmentsAllComplete(System.Action<int> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.AssetBundleDownloadSegmentsAllComplete, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.AssetBundleDownloadSegmentsAllComplete != this.AssetBundleDownloadSegmentsAllComplete);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_AssetBundleDownloadSegmentsAllComplete(System.Action<int> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.AssetBundleDownloadSegmentsAllComplete, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.AssetBundleDownloadSegmentsAllComplete != this.AssetBundleDownloadSegmentsAllComplete);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_PopulateSeasonalAssetsRequest(System.Action<string, UnityEngine.Transform> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.PopulateSeasonalAssetsRequest, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.PopulateSeasonalAssetsRequest != this.PopulateSeasonalAssetsRequest);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_PopulateSeasonalAssetsRequest(System.Action<string, UnityEngine.Transform> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.PopulateSeasonalAssetsRequest, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.PopulateSeasonalAssetsRequest != this.PopulateSeasonalAssetsRequest);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_WorkshopCpuChanged(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.WorkshopCpuChanged, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.WorkshopCpuChanged != this.WorkshopCpuChanged);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_WorkshopCpuChanged(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.WorkshopCpuChanged, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.WorkshopCpuChanged != this.WorkshopCpuChanged);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_WorkshopCpuMenuClosed(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.WorkshopCpuMenuClosed, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.WorkshopCpuMenuClosed != this.WorkshopCpuMenuClosed);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_WorkshopCpuMenuClosed(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.WorkshopCpuMenuClosed, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.WorkshopCpuMenuClosed != this.WorkshopCpuMenuClosed);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_WorkshopCpuMenuOpened(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.WorkshopCpuMenuOpened, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.WorkshopCpuMenuOpened != this.WorkshopCpuMenuOpened);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_WorkshopCpuMenuOpened(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.WorkshopCpuMenuOpened, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.WorkshopCpuMenuOpened != this.WorkshopCpuMenuOpened);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_WorkshopModMenuClosed(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.WorkshopModMenuClosed, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.WorkshopModMenuClosed != this.WorkshopModMenuClosed);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_WorkshopModMenuClosed(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.WorkshopModMenuClosed, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.WorkshopModMenuClosed != this.WorkshopModMenuClosed);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_WorkshopModMenuOpened(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.WorkshopModMenuOpened, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.WorkshopModMenuOpened != this.WorkshopModMenuOpened);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_WorkshopModMenuOpened(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.WorkshopModMenuOpened, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.WorkshopModMenuOpened != this.WorkshopModMenuOpened);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_WorkshopRepairSuccess(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.WorkshopRepairSuccess, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.WorkshopRepairSuccess != this.WorkshopRepairSuccess);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_WorkshopRepairSuccess(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.WorkshopRepairSuccess, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.WorkshopRepairSuccess != this.WorkshopRepairSuccess);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_WorkshopModIconPressed(System.Action<bool> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.WorkshopModIconPressed, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.WorkshopModIconPressed != this.WorkshopModIconPressed);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_WorkshopModIconPressed(System.Action<bool> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.WorkshopModIconPressed, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.WorkshopModIconPressed != this.WorkshopModIconPressed);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_ExtraBatteryStateChanged(System.Action<Game.CameraEquipment.Battery.ExtraBatteryStateChange> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.ExtraBatteryStateChanged, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.ExtraBatteryStateChanged != this.ExtraBatteryStateChanged);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_ExtraBatteryStateChanged(System.Action<Game.CameraEquipment.Battery.ExtraBatteryStateChange> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.ExtraBatteryStateChanged, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.ExtraBatteryStateChanged != this.ExtraBatteryStateChanged);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_FlashlightStateChanged(Game.CameraEquipment.Flashlight.FlashlightState.StateChanged value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.FlashlightStateChanged, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.FlashlightStateChanged != this.FlashlightStateChanged);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_FlashlightStateChanged(Game.CameraEquipment.Flashlight.FlashlightState.StateChanged value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.FlashlightStateChanged, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.FlashlightStateChanged != this.FlashlightStateChanged);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_FlashlightTriedToActivate(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.FlashlightTriedToActivate, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.FlashlightTriedToActivate != this.FlashlightTriedToActivate);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_FlashlightTriedToActivate(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.FlashlightTriedToActivate, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.FlashlightTriedToActivate != this.FlashlightTriedToActivate);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_FlashlightCooldownComplete(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.FlashlightCooldownComplete, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.FlashlightCooldownComplete != this.FlashlightCooldownComplete);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_FlashlightCooldownComplete(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.FlashlightCooldownComplete, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.FlashlightCooldownComplete != this.FlashlightCooldownComplete);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_ShockerActivated(System.Action<Game.CameraEquipment.Shocker.ShockerActivation> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.ShockerActivated, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.ShockerActivated != this.ShockerActivated);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_ShockerActivated(System.Action<Game.CameraEquipment.Shocker.ShockerActivation> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.ShockerActivated, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.ShockerActivated != this.ShockerActivated);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_ShockerCooldownComplete(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.ShockerCooldownComplete, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.ShockerCooldownComplete != this.ShockerCooldownComplete);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_ShockerCooldownComplete(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.ShockerCooldownComplete, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.ShockerCooldownComplete != this.ShockerCooldownComplete);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_MaskForcedOff(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.MaskForcedOff, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.MaskForcedOff != this.MaskForcedOff);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_MaskForcedOff(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.MaskForcedOff, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.MaskForcedOff != this.MaskForcedOff);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_MaskStateChanged(Game.CameraEquipment.Mask.MaskState.StateChanged value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.MaskStateChanged, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.MaskStateChanged != this.MaskStateChanged);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_MaskStateChanged(Game.CameraEquipment.Mask.MaskState.StateChanged value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.MaskStateChanged, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.MaskStateChanged != this.MaskStateChanged);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_AttackDisruptionStateChanged(Game.AttackSequence.DisruptionMechanic.AttackDisruption.StateChanged value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.AttackDisruptionStateChanged, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.AttackDisruptionStateChanged != this.AttackDisruptionStateChanged);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_AttackDisruptionStateChanged(Game.AttackSequence.DisruptionMechanic.AttackDisruption.StateChanged value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.AttackDisruptionStateChanged, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.AttackDisruptionStateChanged != this.AttackDisruptionStateChanged);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_AttackSurgeStateChanged(Game.AttackSequence.SurgeMechanic.AttackSurge.StateChanged value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.AttackSurgeStateChanged, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.AttackSurgeStateChanged != this.AttackSurgeStateChanged);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_AttackSurgeStateChanged(Game.AttackSequence.SurgeMechanic.AttackSurge.StateChanged value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.AttackSurgeStateChanged, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.AttackSurgeStateChanged != this.AttackSurgeStateChanged);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_AttackEncounterStarted(System.Action<Game.ItemDefinition.Data.DataDefinitions.EncounterType> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.AttackEncounterStarted, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.AttackEncounterStarted != this.AttackEncounterStarted);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_AttackEncounterStarted(System.Action<Game.ItemDefinition.Data.DataDefinitions.EncounterType> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.AttackEncounterStarted, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.AttackEncounterStarted != this.AttackEncounterStarted);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_AttackSequenceReadyForUi(System.Action<Game.AttackSequence.Encounters.EncounterResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.AttackSequenceReadyForUi, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.AttackSequenceReadyForUi != this.AttackSequenceReadyForUi);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_AttackSequenceReadyForUi(System.Action<Game.AttackSequence.Encounters.EncounterResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.AttackSequenceReadyForUi, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.AttackSequenceReadyForUi != this.AttackSequenceReadyForUi);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_AttackEncounterEnded(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.AttackEncounterEnded, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.AttackEncounterEnded != this.AttackEncounterEnded);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_AttackEncounterEnded(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.AttackEncounterEnded, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.AttackEncounterEnded != this.AttackEncounterEnded);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_StaticSettingsUpdated(System.Action<Game.AttackSequence.Static.StaticSettings> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.StaticSettingsUpdated, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.StaticSettingsUpdated != this.StaticSettingsUpdated);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_StaticSettingsUpdated(System.Action<Game.AttackSequence.Static.StaticSettings> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.StaticSettingsUpdated, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.StaticSettingsUpdated != this.StaticSettingsUpdated);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_AnimatronicAttackWindowClosed(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.AnimatronicAttackWindowClosed, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.AnimatronicAttackWindowClosed != this.AnimatronicAttackWindowClosed);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_AnimatronicAttackWindowClosed(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.AnimatronicAttackWindowClosed, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.AnimatronicAttackWindowClosed != this.AnimatronicAttackWindowClosed);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_AnimatronicShocked(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.AnimatronicShocked, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.AnimatronicShocked != this.AnimatronicShocked);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_AnimatronicShocked(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.AnimatronicShocked, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.AnimatronicShocked != this.AnimatronicShocked);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_AnimatronicDefeated(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.AnimatronicDefeated, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.AnimatronicDefeated != this.AnimatronicDefeated);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_AnimatronicDefeated(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.AnimatronicDefeated, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.AnimatronicDefeated != this.AnimatronicDefeated);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_PhaseCompleted(System.Action<Game.AttackSequence.Animatronic.PhaseManagement.AttackPhase> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.PhaseCompleted, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.PhaseCompleted != this.PhaseCompleted);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_PhaseCompleted(System.Action<Game.AttackSequence.Animatronic.PhaseManagement.AttackPhase> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.PhaseCompleted, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.PhaseCompleted != this.PhaseCompleted);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_RewardsFlowCompleted(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.RewardsFlowCompleted, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.RewardsFlowCompleted != this.RewardsFlowCompleted);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_RewardsFlowCompleted(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.RewardsFlowCompleted, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.RewardsFlowCompleted != this.RewardsFlowCompleted);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_EssenceNodeSelected(System.Action<Game.EssenceCollection.Actions.EssenceNodes.CameraInfoRecorder.TrackerSessionPackage, System.Collections.Generic.List<Game.Server.EssenceNodeEntry>> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.EssenceNodeSelected, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.EssenceNodeSelected != this.EssenceNodeSelected);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_EssenceNodeSelected(System.Action<Game.EssenceCollection.Actions.EssenceNodes.CameraInfoRecorder.TrackerSessionPackage, System.Collections.Generic.List<Game.Server.EssenceNodeEntry>> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.EssenceNodeSelected, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.EssenceNodeSelected != this.EssenceNodeSelected);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_EssenceTrackerSessionCompleted(System.Action<Game.EssenceCollection.Actions.EssenceNodes.CameraInfoRecorder.TrackerSessionPackage> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.EssenceTrackerSessionCompleted, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.EssenceTrackerSessionCompleted != this.EssenceTrackerSessionCompleted);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_EssenceTrackerSessionCompleted(System.Action<Game.EssenceCollection.Actions.EssenceNodes.CameraInfoRecorder.TrackerSessionPackage> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.EssenceTrackerSessionCompleted, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.EssenceTrackerSessionCompleted != this.EssenceTrackerSessionCompleted);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_RemnantCollectionAudioStarted(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.RemnantCollectionAudioStarted, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.RemnantCollectionAudioStarted != this.RemnantCollectionAudioStarted);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_RemnantCollectionAudioStarted(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.RemnantCollectionAudioStarted, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.RemnantCollectionAudioStarted != this.RemnantCollectionAudioStarted);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_RemnantCollectionAudioEnded(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.RemnantCollectionAudioEnded, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.RemnantCollectionAudioEnded != this.RemnantCollectionAudioEnded);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_RemnantCollectionAudioEnded(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.RemnantCollectionAudioEnded, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.RemnantCollectionAudioEnded != this.RemnantCollectionAudioEnded);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_NodeReset(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.NodeReset, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.NodeReset != this.NodeReset);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_NodeReset(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.NodeReset, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.NodeReset != this.NodeReset);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_GuidePointerRequested(System.Action<UnityEngine.Vector3, UnityEngine.Vector2, float> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.GuidePointerRequested, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.GuidePointerRequested != this.GuidePointerRequested);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_GuidePointerRequested(System.Action<UnityEngine.Vector3, UnityEngine.Vector2, float> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.GuidePointerRequested, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.GuidePointerRequested != this.GuidePointerRequested);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_GuidePointerDismissed(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.GuidePointerDismissed, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.GuidePointerDismissed != this.GuidePointerDismissed);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_GuidePointerDismissed(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.GuidePointerDismissed, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.GuidePointerDismissed != this.GuidePointerDismissed);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_PlayerProfileUpdated(System.Action<Server.PlayerProfile> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.PlayerProfileUpdated, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.PlayerProfileUpdated != this.PlayerProfileUpdated);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_PlayerProfileUpdated(System.Action<Server.PlayerProfile> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.PlayerProfileUpdated, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.PlayerProfileUpdated != this.PlayerProfileUpdated);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_PlayerAvatarUpdated(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.PlayerAvatarUpdated, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.PlayerAvatarUpdated != this.PlayerAvatarUpdated);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_PlayerAvatarUpdated(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.PlayerAvatarUpdated, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.PlayerAvatarUpdated != this.PlayerAvatarUpdated);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_DisplayNameObscenityFound(System.Action<GameUI.UserNameSetError> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.DisplayNameObscenityFound, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.DisplayNameObscenityFound != this.DisplayNameObscenityFound);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_DisplayNameObscenityFound(System.Action<GameUI.UserNameSetError> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.DisplayNameObscenityFound, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.DisplayNameObscenityFound != this.DisplayNameObscenityFound);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_HardGlitchesEnded(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.HardGlitchesEnded, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.HardGlitchesEnded != this.HardGlitchesEnded);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_HardGlitchesEnded(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.HardGlitchesEnded, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.HardGlitchesEnded != this.HardGlitchesEnded);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_StartupTaskCompleted(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.StartupTaskCompleted, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.StartupTaskCompleted != this.StartupTaskCompleted);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_StartupTaskCompleted(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.StartupTaskCompleted, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.StartupTaskCompleted != this.StartupTaskCompleted);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_PreloadEvent(System.Action<P7.CanvasFlow.CanvasController, string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.PreloadEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.PreloadEvent != this.PreloadEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_PreloadEvent(System.Action<P7.CanvasFlow.CanvasController, string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.PreloadEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.PreloadEvent != this.PreloadEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_GuidePopupRequested(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.GuidePopupRequested, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.GuidePopupRequested != this.GuidePopupRequested);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_GuidePopupRequested(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.GuidePopupRequested, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.GuidePopupRequested != this.GuidePopupRequested);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_GuidePopupDismissed(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.GuidePopupDismissed, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.GuidePopupDismissed != this.GuidePopupDismissed);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_GuidePopupDismissed(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.GuidePopupDismissed, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.GuidePopupDismissed != this.GuidePopupDismissed);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_GuidePopupClosing(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.GuidePopupClosing, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.GuidePopupClosing != this.GuidePopupClosing);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_GuidePopupClosing(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.GuidePopupClosing, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.GuidePopupClosing != this.GuidePopupClosing);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_GuideVisualizerPresent(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.GuideVisualizerPresent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.GuideVisualizerPresent != this.GuideVisualizerPresent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_GuideVisualizerPresent(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.GuideVisualizerPresent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.GuideVisualizerPresent != this.GuideVisualizerPresent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_AnalyticsVisualizerPresent(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.AnalyticsVisualizerPresent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.AnalyticsVisualizerPresent != this.AnalyticsVisualizerPresent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_AnalyticsVisualizerPresent(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.AnalyticsVisualizerPresent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.AnalyticsVisualizerPresent != this.AnalyticsVisualizerPresent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_TutorialUIEvent(System.Action<TutorialSendUIEvent.TutorialUIEvent> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.TutorialUIEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.TutorialUIEvent != this.TutorialUIEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_TutorialUIEvent(System.Action<TutorialSendUIEvent.TutorialUIEvent> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.TutorialUIEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.TutorialUIEvent != this.TutorialUIEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_AnimatronicDataSentForId(System.Action<string, string, AnimatronicEntity.SaveGameChunk> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.AnimatronicDataSentForId, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.AnimatronicDataSentForId != this.AnimatronicDataSentForId);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_AnimatronicDataSentForId(System.Action<string, string, AnimatronicEntity.SaveGameChunk> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.AnimatronicDataSentForId, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.AnimatronicDataSentForId != this.AnimatronicDataSentForId);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_FabButtonConfigurationChangeEvent(Master.EventExposer.FabButtonChangeHandler value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.FabButtonConfigurationChangeEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.FabButtonConfigurationChangeEvent != this.FabButtonConfigurationChangeEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_FabButtonConfigurationChangeEvent(Master.EventExposer.FabButtonChangeHandler value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.FabButtonConfigurationChangeEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.FabButtonConfigurationChangeEvent != this.FabButtonConfigurationChangeEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_CompleteFTUEVideo(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.CompleteFTUEVideo, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.CompleteFTUEVideo != this.CompleteFTUEVideo);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_CompleteFTUEVideo(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.CompleteFTUEVideo, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.CompleteFTUEVideo != this.CompleteFTUEVideo);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_AnimatronicEntityReturned(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.AnimatronicEntityReturned, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.AnimatronicEntityReturned != this.AnimatronicEntityReturned);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_AnimatronicEntityReturned(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.AnimatronicEntityReturned, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.AnimatronicEntityReturned != this.AnimatronicEntityReturned);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_StartMusic(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.StartMusic, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.StartMusic != this.StartMusic);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_StartMusic(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.StartMusic, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.StartMusic != this.StartMusic);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_PopulateExistingSeasonalReceivers(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.PopulateExistingSeasonalReceivers, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.PopulateExistingSeasonalReceivers != this.PopulateExistingSeasonalReceivers);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_PopulateExistingSeasonalReceivers(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.PopulateExistingSeasonalReceivers, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.PopulateExistingSeasonalReceivers != this.PopulateExistingSeasonalReceivers);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_InboxDataReceivedFromServer(System.Action<System.Collections.Generic.List<GameUI.EmailData>> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.InboxDataReceivedFromServer, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.InboxDataReceivedFromServer != this.InboxDataReceivedFromServer);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_InboxDataReceivedFromServer(System.Action<System.Collections.Generic.List<GameUI.EmailData>> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.InboxDataReceivedFromServer, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.InboxDataReceivedFromServer != this.InboxDataReceivedFromServer);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_EmailDataModelUpdated(System.Action<System.Collections.Generic.List<GameUI.EmailData>> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.EmailDataModelUpdated, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.EmailDataModelUpdated != this.EmailDataModelUpdated);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_EmailDataModelUpdated(System.Action<System.Collections.Generic.List<GameUI.EmailData>> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.EmailDataModelUpdated, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.EmailDataModelUpdated != this.EmailDataModelUpdated);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_InboxOpened(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.InboxOpened, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.InboxOpened != this.InboxOpened);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_InboxOpened(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.InboxOpened, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.InboxOpened != this.InboxOpened);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_InboxClosed(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.InboxClosed, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.InboxClosed != this.InboxClosed);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_InboxClosed(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.InboxClosed, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.InboxClosed != this.InboxClosed);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_MaxEmailsToDeletePacketSizeReceived(System.Action<int> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.MaxEmailsToDeletePacketSizeReceived, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.MaxEmailsToDeletePacketSizeReceived != this.MaxEmailsToDeletePacketSizeReceived);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_MaxEmailsToDeletePacketSizeReceived(System.Action<int> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.MaxEmailsToDeletePacketSizeReceived, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.MaxEmailsToDeletePacketSizeReceived != this.MaxEmailsToDeletePacketSizeReceived);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_MaxEmailsSetReadPacketSizeReceived(System.Action<int> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.MaxEmailsSetReadPacketSizeReceived, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.MaxEmailsSetReadPacketSizeReceived != this.MaxEmailsSetReadPacketSizeReceived);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_MaxEmailsSetReadPacketSizeReceived(System.Action<int> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.MaxEmailsSetReadPacketSizeReceived, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.MaxEmailsSetReadPacketSizeReceived != this.MaxEmailsSetReadPacketSizeReceived);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_InboxFolderDataReceived(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.InboxFolderDataReceived, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.InboxFolderDataReceived != this.InboxFolderDataReceived);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_InboxFolderDataReceived(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.InboxFolderDataReceived, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.InboxFolderDataReceived != this.InboxFolderDataReceived);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_ResultsDataUpdated(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.ResultsDataUpdated, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.ResultsDataUpdated != this.ResultsDataUpdated);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_ResultsDataUpdated(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.ResultsDataUpdated, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.ResultsDataUpdated != this.ResultsDataUpdated);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_SequentialRewardsModelUpdated(System.Action<System.Collections.Generic.List<Game.SeasonalEvents.Data.SeasonalEventData>> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.SequentialRewardsModelUpdated, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.SequentialRewardsModelUpdated != this.SequentialRewardsModelUpdated);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_SequentialRewardsModelUpdated(System.Action<System.Collections.Generic.List<Game.SeasonalEvents.Data.SeasonalEventData>> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.SequentialRewardsModelUpdated, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.SequentialRewardsModelUpdated != this.SequentialRewardsModelUpdated);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_GetSocialInvitePayloadReceived(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.GetSocialInvitePayloadReceived, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.GetSocialInvitePayloadReceived != this.GetSocialInvitePayloadReceived);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_GetSocialInvitePayloadReceived(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.GetSocialInvitePayloadReceived, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.GetSocialInvitePayloadReceived != this.GetSocialInvitePayloadReceived);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_GetSocialInviteExplicitContent(System.Action<Systems.GetSocialInviteHandling.InviteSender.GetSocialInviteContent> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.GetSocialInviteExplicitContent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.GetSocialInviteExplicitContent != this.GetSocialInviteExplicitContent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_GetSocialInviteExplicitContent(System.Action<Systems.GetSocialInviteHandling.InviteSender.GetSocialInviteContent> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.GetSocialInviteExplicitContent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.GetSocialInviteExplicitContent != this.GetSocialInviteExplicitContent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_GetSocialValidated(System.Action<bool, bool, int> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.GetSocialValidated, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.GetSocialValidated != this.GetSocialValidated);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_GetSocialValidated(System.Action<bool, bool, int> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.GetSocialValidated, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.GetSocialValidated != this.GetSocialValidated);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_ReauthPayload(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.ReauthPayload, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.ReauthPayload != this.ReauthPayload);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_ReauthPayload(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.ReauthPayload, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.ReauthPayload != this.ReauthPayload);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_FriendListUpdated(System.Action<System.Collections.Generic.List<Game.Server.PlayerFriendsEntry>> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.FriendListUpdated, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.FriendListUpdated != this.FriendListUpdated);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_FriendListUpdated(System.Action<System.Collections.Generic.List<Game.Server.PlayerFriendsEntry>> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.FriendListUpdated, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.FriendListUpdated != this.FriendListUpdated);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_GameReadyForAlertsEvent(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.GameReadyForAlertsEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.GameReadyForAlertsEvent != this.GameReadyForAlertsEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_GameReadyForAlertsEvent(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.GameReadyForAlertsEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.GameReadyForAlertsEvent != this.GameReadyForAlertsEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_GameReadyForAnimatronicsEvent(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.GameReadyForAnimatronicsEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.GameReadyForAnimatronicsEvent != this.GameReadyForAnimatronicsEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_GameReadyForAnimatronicsEvent(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.GameReadyForAnimatronicsEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.GameReadyForAnimatronicsEvent != this.GameReadyForAnimatronicsEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_GameReadyForServerHeartbeat(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.GameReadyForServerHeartbeat, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.GameReadyForServerHeartbeat != this.GameReadyForServerHeartbeat);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_GameReadyForServerHeartbeat(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.GameReadyForServerHeartbeat, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.GameReadyForServerHeartbeat != this.GameReadyForServerHeartbeat);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_GameDisplayChange(System.Action<TheGame.GameDisplayData> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.GameDisplayChange, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.GameDisplayChange != this.GameDisplayChange);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_GameDisplayChange(System.Action<TheGame.GameDisplayData> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.GameDisplayChange, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.GameDisplayChange != this.GameDisplayChange);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_UICanvasDidAppear(System.Action<TheGame.GameDisplayData.DisplayType> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.UICanvasDidAppear, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.UICanvasDidAppear != this.UICanvasDidAppear);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_UICanvasDidAppear(System.Action<TheGame.GameDisplayData.DisplayType> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.UICanvasDidAppear, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.UICanvasDidAppear != this.UICanvasDidAppear);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_UICanvasClosed(System.Action<TheGame.GameDisplayData.DisplayType> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.UICanvasClosed, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.UICanvasClosed != this.UICanvasClosed);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_UICanvasClosed(System.Action<TheGame.GameDisplayData.DisplayType> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.UICanvasClosed, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.UICanvasClosed != this.UICanvasClosed);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_UIChangeRequest(System.Action<TheGame.GameDisplayData.DisplayType> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.UIChangeRequest, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.UIChangeRequest != this.UIChangeRequest);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_UIChangeRequest(System.Action<TheGame.GameDisplayData.DisplayType> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.UIChangeRequest, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.UIChangeRequest != this.UIChangeRequest);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_ShowUIBars(System.Action<bool> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.ShowUIBars, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.ShowUIBars != this.ShowUIBars);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_ShowUIBars(System.Action<bool> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.ShowUIBars, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.ShowUIBars != this.ShowUIBars);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_RedeemCoupon(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.RedeemCoupon, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.RedeemCoupon != this.RedeemCoupon);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_RedeemCoupon(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.RedeemCoupon, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.RedeemCoupon != this.RedeemCoupon);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_CouponRedeemed(System.Action<bool> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.CouponRedeemed, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.CouponRedeemed != this.CouponRedeemed);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_CouponRedeemed(System.Action<bool> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.CouponRedeemed, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.CouponRedeemed != this.CouponRedeemed);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_PersonalFriendCodeUpdated(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.PersonalFriendCodeUpdated, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.PersonalFriendCodeUpdated != this.PersonalFriendCodeUpdated);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_PersonalFriendCodeUpdated(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.PersonalFriendCodeUpdated, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.PersonalFriendCodeUpdated != this.PersonalFriendCodeUpdated);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_FriendCodeLookedUp(System.Action<Game.Server.FriendCodeResponseHandler.FriendLookupResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.FriendCodeLookedUp, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.FriendCodeLookedUp != this.FriendCodeLookedUp);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_FriendCodeLookedUp(System.Action<Game.Server.FriendCodeResponseHandler.FriendLookupResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.FriendCodeLookedUp, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.FriendCodeLookedUp != this.FriendCodeLookedUp);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_AddedFriendByCode(System.Action<bool> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.AddedFriendByCode, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.AddedFriendByCode != this.AddedFriendByCode);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_AddedFriendByCode(System.Action<bool> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.AddedFriendByCode, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.AddedFriendByCode != this.AddedFriendByCode);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_NewCameraUIIconAnimator(System.Action<Systems.Guide.UI.CameraUIIconAnimator> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.NewCameraUIIconAnimator, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.NewCameraUIIconAnimator != this.NewCameraUIIconAnimator);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_NewCameraUIIconAnimator(System.Action<Systems.Guide.UI.CameraUIIconAnimator> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.NewCameraUIIconAnimator, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.NewCameraUIIconAnimator != this.NewCameraUIIconAnimator);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_PassiveRequestListReceived(System.Action<System.Collections.Generic.List<string>> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.PassiveRequestListReceived, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.PassiveRequestListReceived != this.PassiveRequestListReceived);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_PassiveRequestListReceived(System.Action<System.Collections.Generic.List<string>> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.PassiveRequestListReceived, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.PassiveRequestListReceived != this.PassiveRequestListReceived);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_ActiveDailyChallengesUpdated(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.ActiveDailyChallengesUpdated, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.ActiveDailyChallengesUpdated != this.ActiveDailyChallengesUpdated);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_ActiveDailyChallengesUpdated(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.ActiveDailyChallengesUpdated, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.ActiveDailyChallengesUpdated != this.ActiveDailyChallengesUpdated);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_DailyChallengeListReceived(System.Action<Game.Server.DailyChallengeResponseData> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.DailyChallengeListReceived, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.DailyChallengeListReceived != this.DailyChallengeListReceived);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_DailyChallengeListReceived(System.Action<Game.Server.DailyChallengeResponseData> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.DailyChallengeListReceived, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.DailyChallengeListReceived != this.DailyChallengeListReceived);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_DailyChallengeRewardReceived(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.DailyChallengeRewardReceived, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.DailyChallengeRewardReceived != this.DailyChallengeRewardReceived);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_DailyChallengeRewardReceived(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.DailyChallengeRewardReceived, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.DailyChallengeRewardReceived != this.DailyChallengeRewardReceived);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_SequentialRewardsButtonReady(System.Action<GameUI.SequentialRewardsButtonDisplay> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.SequentialRewardsButtonReady, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.SequentialRewardsButtonReady != this.SequentialRewardsButtonReady);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_SequentialRewardsButtonReady(System.Action<GameUI.SequentialRewardsButtonDisplay> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.SequentialRewardsButtonReady, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.SequentialRewardsButtonReady != this.SequentialRewardsButtonReady);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnDailyChallengeRewardReceived(string rewardId)
        {
            if(this.DailyChallengeRewardReceived == null)
            {
                    return;
            }
            
            this.DailyChallengeRewardReceived.Invoke(obj:  rewardId);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnDailyChallengeListReceived(Game.Server.DailyChallengeResponseData responseData)
        {
            if(this.DailyChallengeListReceived == null)
            {
                    return;
            }
            
            this.DailyChallengeListReceived.Invoke(obj:  responseData);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnPassiveRequestListReceived(System.Collections.Generic.List<string> passiveRequestList)
        {
            if(this.PassiveRequestListReceived == null)
            {
                    return;
            }
            
            this.PassiveRequestListReceived.Invoke(obj:  passiveRequestList);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnFTUEComplete()
        {
            if(this.FTUEComplete == null)
            {
                    return;
            }
            
            this.FTUEComplete.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnHeartbeatPeriodChanged(float heartbeatPeriod)
        {
            if(this.HeartbeatPeriodChanged == null)
            {
                    return;
            }
            
            this.HeartbeatPeriodChanged.Invoke(obj:  heartbeatPeriod);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnRedeemCoupon(string couponId)
        {
            if(this.RedeemCoupon == null)
            {
                    return;
            }
            
            this.RedeemCoupon.Invoke(obj:  couponId);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnCouponRedeemed(bool didComplete)
        {
            if(this.CouponRedeemed == null)
            {
                    return;
            }
            
            didComplete = didComplete;
            this.CouponRedeemed.Invoke(obj:  didComplete);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnFriendListUpdated(System.Collections.Generic.List<Game.Server.PlayerFriendsEntry> data)
        {
            if(this.FriendListUpdated == null)
            {
                    return;
            }
            
            this.FriendListUpdated.Invoke(obj:  data);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnSpawnEssences(System.Collections.Generic.List<Game.Server.EssenceNodeEntry> data)
        {
            if(this.SpawnEssences == null)
            {
                    return;
            }
            
            this.SpawnEssences.Invoke(obj:  data);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnPlayerEssenceDataUpdated(Game.Server.PlayerEssenceData data)
        {
            var val_2 = 1152921523257355024;
            if(this.PlayerEssenceDataUpdated == null)
            {
                    return;
            }
            
            this.PlayerEssenceDataUpdated.Invoke(obj:  new Game.Server.PlayerEssenceData() {lastGlobalTrigger = data.lastGlobalTrigger, lastCategoryTriggers = data.lastCategoryTriggers, counts = data.lastCategoryTriggers, nodes = data.nodes});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnWorkshopDataV2Updated(AnimatronicEntity.Data.WorkshopData data)
        {
            if(this.WorkshopDataV2Updated == null)
            {
                    return;
            }
            
            this.WorkshopDataV2Updated.Invoke(obj:  data);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnNewAnimatronicSpawned()
        {
            if(this.NewAnimatronicSpawned == null)
            {
                    return;
            }
            
            this.NewAnimatronicSpawned.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnWorkshopRotateCamera(UnityEngine.Vector3 prev, UnityEngine.Vector3 curr)
        {
            if(this.WorkshopCameraRotated == null)
            {
                    return;
            }
            
            this.WorkshopCameraRotated.Invoke(arg1:  new UnityEngine.Vector3() {x = prev.x, y = prev.y, z = prev.z}, arg2:  new UnityEngine.Vector3() {x = curr.x, y = curr.y, z = curr.z});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnNodeReset()
        {
            if(this.NodeReset == null)
            {
                    return;
            }
            
            this.NodeReset.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnRewardsV2Received(Game.TheGame.Data.RewardDataV2 e)
        {
            if(this.RewardsV2Received == null)
            {
                    return;
            }
            
            this.RewardsV2Received.Invoke(obj:  e);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnGeoPositionObjectAdded(MapMode.GeoPositionObject.Container.GeoPositionObjectAddedRemovedArgs data)
        {
            if(this.GeoPositionObjectAdded == null)
            {
                    return;
            }
            
            this.GeoPositionObjectAdded.Invoke(obj:  data);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnAnimatronicEntityUpdated(AnimatronicEntity.SaveGameChunk data)
        {
            if(this.AnimatronicEntityUpdated == null)
            {
                    return;
            }
            
            this.AnimatronicEntityUpdated.Invoke(obj:  data);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnModInventoryUpdated(Game.Workshop.Data.ModInventory data)
        {
            if(this.ModInventoryUpdated == null)
            {
                    return;
            }
            
            this.ModInventoryUpdated.Invoke(obj:  data);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnWorkshopDataUpdated(AnimatronicEntity.Data.WorkshopData data)
        {
            if(this.WorkshopDataUpdated == null)
            {
                    return;
            }
            
            this.WorkshopDataUpdated.Invoke(obj:  data);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnAnimatronicSent(string data)
        {
            if(this.AnimatronicSent == null)
            {
                    return;
            }
            
            this.AnimatronicSent.Invoke(obj:  data);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnAudioJsonDataReceived(string data)
        {
            if(this.AudioJsonDataReceived == null)
            {
                    return;
            }
            
            this.AudioJsonDataReceived.Invoke(obj:  data);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnDevicesJsonDataReceived(string data)
        {
            if(this.DevicesJsonDataReceived == null)
            {
                    return;
            }
            
            this.DevicesJsonDataReceived.Invoke(obj:  data);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnTutorialJsonDataReceived(string data)
        {
            if(this.TutorialJsonDataReceived == null)
            {
                    return;
            }
            
            this.TutorialJsonDataReceived.Invoke(obj:  data);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnKeyValueJsonDataReceived(string data)
        {
            if(this.KeyValueJsonDataReceived == null)
            {
                    return;
            }
            
            this.KeyValueJsonDataReceived.Invoke(obj:  data);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnEssenceJsonDataReceived(string data)
        {
            if(this.EssenceJsonDataReceived == null)
            {
                    return;
            }
            
            this.EssenceJsonDataReceived.Invoke(obj:  data);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnEssenceTypesJsonDataReceived(string data)
        {
            if(this.EssenceTypesJsonDataReceived == null)
            {
                    return;
            }
            
            this.EssenceTypesJsonDataReceived.Invoke(obj:  data);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnFTUEJsonDataReceived(string data)
        {
            if(this.FTUEJsonDataReceived == null)
            {
                    return;
            }
            
            this.FTUEJsonDataReceived.Invoke(obj:  data);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnLoginABSJsonDataReceived(string data)
        {
            if(this.LoginABSJsonDataReceived == null)
            {
                    return;
            }
            
            this.LoginABSJsonDataReceived.Invoke(obj:  data);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnLoginRepeatJsonDataReceived(string data)
        {
            if(this.LoginRepeatJsonDataReceived == null)
            {
                    return;
            }
            
            this.LoginRepeatJsonDataReceived.Invoke(obj:  data);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnMetricsJsonDataReceived(string data)
        {
            if(this.MetricsJsonDataReceived == null)
            {
                    return;
            }
            
            this.MetricsJsonDataReceived.Invoke(obj:  data);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnModsJsonDataReceived(string data)
        {
            if(this.ModsJsonDataReceived == null)
            {
                    return;
            }
            
            this.ModsJsonDataReceived.Invoke(obj:  data);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnProgressionJsonDataReceived(string data)
        {
            if(this.ProgressionJsonDataReceived == null)
            {
                    return;
            }
            
            this.ProgressionJsonDataReceived.Invoke(obj:  data);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnStaticJsonDataReceived(string data)
        {
            if(this.StaticJsonDataReceived == null)
            {
                    return;
            }
            
            this.StaticJsonDataReceived.Invoke(obj:  data);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnWearAndTearJsonDataReceived(string data)
        {
            if(this.WearAndTearJsonReceived == null)
            {
                    return;
            }
            
            this.WearAndTearJsonReceived.Invoke(obj:  data);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnCPUJsonDataReceived(string data)
        {
            if(this.CPUJsonDataReceived == null)
            {
                    return;
            }
            
            this.CPUJsonDataReceived.Invoke(obj:  data);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnPlushSuitJsonDataReceived(string data)
        {
            if(this.PlushSuitJsonDataReceived == null)
            {
                    return;
            }
            
            this.PlushSuitJsonDataReceived.Invoke(obj:  data);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnAttackJsonDataReceived(string data)
        {
            if(this.AttackJsonDataReceived == null)
            {
                    return;
            }
            
            this.AttackJsonDataReceived.Invoke(obj:  data);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnLocJsonDataReceived(string data)
        {
            if(this.LocJsonDataReceived == null)
            {
                    return;
            }
            
            this.LocJsonDataReceived.Invoke(obj:  data);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnAnimatronicStatsUpdated(System.Collections.Generic.Dictionary<string, Animatronics.AnimatronicStats.StatsData> data)
        {
            if(this.AnimatronicStatsUpdated == null)
            {
                    return;
            }
            
            this.AnimatronicStatsUpdated.Invoke(obj:  data);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnMasterDataVersionReceived(int data)
        {
            if(this.MasterDataVersionReceived == null)
            {
                    return;
            }
            
            this.MasterDataVersionReceived.Invoke(obj:  data);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnPlayerProfileUpdated(Server.PlayerProfile data)
        {
            if(this.PlayerProfileUpdated == null)
            {
                    return;
            }
            
            this.PlayerProfileUpdated.Invoke(obj:  data);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnPlayerAvatarUpdated()
        {
            if(this.PlayerAvatarUpdated == null)
            {
                    return;
            }
            
            this.PlayerAvatarUpdated.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnDisplayNameObscenityFound(GameUI.UserNameSetError error)
        {
            if(this.DisplayNameObscenityFound == null)
            {
                    return;
            }
            
            this.DisplayNameObscenityFound.Invoke(obj:  error);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnCPUInventoryUpdated(Game.TheGame.Data.CPUInventory data)
        {
            if(this.CPUInventoryUpdated == null)
            {
                    return;
            }
            
            this.CPUInventoryUpdated.Invoke(obj:  data);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnStoreJsonDataReceived(string data)
        {
            if(this.StoreJsonDataReceived == null)
            {
                    return;
            }
            
            this.StoreJsonDataReceived.Invoke(obj:  data);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnStoreSectionJsonDataReceived(string data)
        {
            if(this.StoreSectionJsonDataReceived == null)
            {
                    return;
            }
            
            this.StoreSectionJsonDataReceived.Invoke(obj:  data);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnDailyChallengeJsonDataReceived(string data)
        {
            if(this.DailyChallengeJsonDataReceived == null)
            {
                    return;
            }
            
            this.DailyChallengeJsonDataReceived.Invoke(obj:  data);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnDailyChallengeRewardsJsonDataReceived(string data)
        {
            if(this.DailyChallengeRewardsJsonDataReceived == null)
            {
                    return;
            }
            
            this.DailyChallengeRewardsJsonDataReceived.Invoke(obj:  data);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnRemnantDebuffJsonDataReceived(string data)
        {
            if(this.RemnantDebuffJsonDataReceived == null)
            {
                    return;
            }
            
            this.RemnantDebuffJsonDataReceived.Invoke(obj:  data);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnModCategoriesDataRecieved(string data)
        {
            if(this.ModCategoriesDataRecieved == null)
            {
                    return;
            }
            
            this.ModCategoriesDataRecieved.Invoke(obj:  data);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnServerBlockingErrorDataReceived(string data)
        {
            if(this.ServerBlockingErrorDataReceived == null)
            {
                    return;
            }
            
            this.ServerBlockingErrorDataReceived.Invoke(obj:  data);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnSeasonalEventDataReceived(System.Collections.Generic.List<Game.SeasonalEvents.Data.SeasonalEventData> data)
        {
            if(this.SeasonalEventDataReceived == null)
            {
                    return;
            }
            
            this.SeasonalEventDataReceived.Invoke(obj:  data);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnActiveSeasonalEventsUpdated(Game.SeasonalEvents.SeasonMechanicTag tag, System.Collections.Generic.List<string> activeIds)
        {
            if(this.ActiveSeasonalEventsUpdated == null)
            {
                    return;
            }
            
            this.ActiveSeasonalEventsUpdated.Invoke(arg1:  tag, arg2:  activeIds);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnSequentialRewardsDataReceived(string data)
        {
            if(this.SequentialRewardsDataReceived == null)
            {
                    return;
            }
            
            this.SequentialRewardsDataReceived.Invoke(obj:  data);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnSeasonalDataReceived(string data)
        {
            if(this.SeasonalDataReceived == null)
            {
                    return;
            }
            
            this.SeasonalDataReceived.Invoke(obj:  data);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnSeasonalAssetsDataReceived(string data)
        {
            if(this.SeasonalAssetsDataReceived == null)
            {
                    return;
            }
            
            this.SeasonalAssetsDataReceived.Invoke(obj:  data);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnVirtualGoodsDataReceived(Game.Store.Container.StoreContainer.StoreIdentificationData storeData, System.Collections.Generic.List<Game.Store.Container.StoreContainer.VirtualGoodResponseData> response)
        {
            if(this.VirtualGoodsDataReceived == null)
            {
                    return;
            }
            
            this.VirtualGoodsDataReceived.Invoke(arg1:  storeData, arg2:  response);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnStoreIdReceived(string data)
        {
            if(this.StoreIdReceived == null)
            {
                    return;
            }
            
            this.StoreIdReceived.Invoke(obj:  data);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnStorePackJsonDataReceived(string data)
        {
            if(this.StorePackJsonDataReceived == null)
            {
                    return;
            }
            
            this.StorePackJsonDataReceived.Invoke(obj:  data);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnAssetBundleVersionReceived(Game.AssetManagement.AssetBundleVersionInfo info)
        {
            if(this.AssetBundleVersionReceived == null)
            {
                    return;
            }
            
            this.AssetBundleVersionReceived.Invoke(obj:  info);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnBestStreakLeaderboardUpdated(System.Collections.Generic.List<TheGame.Data.LeaderboardEntry> data)
        {
            if(this.BestStreakLeaderboardUpdated == null)
            {
                    return;
            }
            
            this.BestStreakLeaderboardUpdated.Invoke(obj:  data);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnCurrentStreakLeaderboardUpdated(System.Collections.Generic.List<TheGame.Data.LeaderboardEntry> data)
        {
            if(this.CurrentStreakLeaderboardUpdated == null)
            {
                    return;
            }
            
            this.CurrentStreakLeaderboardUpdated.Invoke(obj:  data);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnStreakDataUpdated(TheGame.Data.StreakData data)
        {
            if(this.StreakDataUpdated == null)
            {
                    return;
            }
            
            this.StreakDataUpdated.Invoke(obj:  data);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnPurchasedSlotsUpdated(int purchasedSlots)
        {
            if(this.PurchasedSlotsUpdated == null)
            {
                    return;
            }
            
            this.PurchasedSlotsUpdated.Invoke(obj:  purchasedSlots);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnPlayerStatsUpdated(Game.PlayerStats.Data.PlayerStatsData statsData)
        {
            if(this.PlayerStatsUpdated == null)
            {
                    return;
            }
            
            this.PlayerStatsUpdated.Invoke(obj:  statsData);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnPlayerGoodsUpdated(System.Collections.Generic.Dictionary<string, int> ownedGoods)
        {
            if(this.PlayerGoodsUpdated == null)
            {
                    return;
            }
            
            this.PlayerGoodsUpdated.Invoke(obj:  ownedGoods);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnLoadingDone()
        {
            if(this.LoadingDone == null)
            {
                    return;
            }
            
            this.LoadingDone.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnHardGlitchesEnded()
        {
            if(this.HardGlitchesEnded == null)
            {
                    return;
            }
            
            this.HardGlitchesEnded.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnUpdateNextAnimatronicRequestTime(long nextTime)
        {
            if(this.UpdateNextAnimatronicRequestTime == null)
            {
                    return;
            }
            
            this.UpdateNextAnimatronicRequestTime.Invoke(obj:  nextTime);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnAlertPlayerDataUpdatedEvent(Alerts.Data.PlayerAlertData e)
        {
            if(this.AlertPlayerDataUpdatedEvent == null)
            {
                    return;
            }
            
            this.AlertPlayerDataUpdatedEvent.Invoke(obj:  e);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnEntityFastForwardComplete(AnimatronicEntity.FastForwardCompleteArgs args)
        {
            if(this.EntityFastForwardComplete == null)
            {
                    return;
            }
            
            this.EntityFastForwardComplete.Invoke(obj:  args);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnEntityAddedEvent(AnimatronicEntity.Container.EntityAddedRemovedArgs e)
        {
            if(this.EntityAddedEvent == null)
            {
                    return;
            }
            
            this.EntityAddedEvent.Invoke(obj:  e);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnEntityRemovedEvent(AnimatronicEntity.Container.EntityAddedRemovedArgs e)
        {
            if(this.EntityRemovedEvent == null)
            {
                    return;
            }
            
            this.EntityRemovedEvent.Invoke(obj:  e);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnEntitiesClearedEvent(AnimatronicEntity.Container.EntitiesClearedArgs e)
        {
            if(this.EntitiesClearedEvent == null)
            {
                    return;
            }
            
            this.EntitiesClearedEvent.Invoke(obj:  e);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnEntityMovedEvent(AnimatronicEntity.Mover.EntityMovedArgs e)
        {
            if(this.EntityMovedEvent == null)
            {
                    return;
            }
            
            this.EntityMovedEvent.Invoke(obj:  e);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnEntityStateChangedEvent(AnimatronicEntity.StateChooser.EntityStateChangedArgs e)
        {
            if(this.EntityStateChangedEvent == null)
            {
                    return;
            }
            
            this.EntityStateChangedEvent.Invoke(obj:  e);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnLoadedEvent(AnimatronicEntity.Loader.LoadedArgs e)
        {
            if(this.LoadedEvent == null)
            {
                    return;
            }
            
            this.LoadedEvent.Invoke(obj:  e);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnEntityChunkGenerated(AnimatronicEntity.SaveGameChunk e)
        {
            if(this.EntityChunkGenerated == null)
            {
                    return;
            }
            
            this.EntityChunkGenerated.Invoke(obj:  e);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnAnimatronicRequestedFromServer(string e)
        {
            if(this.AnimatronicRequestedFromServer == null)
            {
                    return;
            }
            
            this.AnimatronicRequestedFromServer.Invoke(obj:  e);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnOnGeoPositionObjectAddedEvent(MapMode.GeoPositionObject.Container.GeoPositionObjectAddedRemovedArgs e)
        {
            if(this.GeoPositionObjectAddedEvent == null)
            {
                    return;
            }
            
            this.GeoPositionObjectAddedEvent.Invoke(obj:  e);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnAuthenticated()
        {
            if(this.Authenticated == null)
            {
                    return;
            }
            
            this.Authenticated.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnForcedUpdate(string url)
        {
            if(this.ForcedUpdate == null)
            {
                    return;
            }
            
            this.ForcedUpdate.Invoke(obj:  url);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnPlayerAnimatronicDataLoaded(System.Collections.Generic.List<AnimatronicEntity.SaveGameChunk> e)
        {
            if(this.PlayerAnimatronicDataLoaded == null)
            {
                    return;
            }
            
            this.PlayerAnimatronicDataLoaded.Invoke(obj:  e);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnPlayerCurrencyRefreshed(System.Collections.Generic.Dictionary<string, int> e)
        {
            if(this.PlayerCurrencyRefreshed == null)
            {
                    return;
            }
            
            this.PlayerCurrencyRefreshed.Invoke(obj:  e);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnRewardsReceived(Game.TheGame.Data.RewardData e)
        {
            if(this.RewardsReceived == null)
            {
                    return;
            }
            
            this.RewardsReceived.Invoke(obj:  e);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnInventoryUpdated(TheGame.PlayerInventory e)
        {
            if(this.InventoryUpdated == null)
            {
                    return;
            }
            
            this.InventoryUpdated.Invoke(obj:  e);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnServerTimeReceived(long e)
        {
            if(this.ServerTimeReceived == null)
            {
                    return;
            }
            
            this.ServerTimeReceived.Invoke(obj:  e);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnAttackModeLost()
        {
            if(this.AttackModeLost == null)
            {
                    return;
            }
            
            this.AttackModeLost.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnConfigJsonDataReceived(string e)
        {
            if(this.ConfigJsonDataReceived == null)
            {
                    return;
            }
            
            this.ConfigJsonDataReceived.Invoke(obj:  e);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnAnimatronicJsonDataReceived(string e)
        {
            if(this.AnimatronicJsonDataReceived == null)
            {
                    return;
            }
            
            this.AnimatronicJsonDataReceived.Invoke(obj:  e);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnAlertJsonDataReceived(string e)
        {
            if(this.AlertJsonDataReceived == null)
            {
                    return;
            }
            
            this.AlertJsonDataReceived.Invoke(obj:  e);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnDeviceDataRequested()
        {
            if(this.DeviceDataRequested == null)
            {
                    return;
            }
            
            this.DeviceDataRequested.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnDeviceDataReceived(Game.TheGame.Data.AllPlayerDevices data)
        {
            if(this.DeviceDataReceived == null)
            {
                    return;
            }
            
            this.DeviceDataReceived.Invoke(obj:  data);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnPurchaseDataReceived(System.Collections.Generic.Dictionary<string, int> data)
        {
            if(this.PurchaseDataReceived == null)
            {
                    return;
            }
            
            this.PurchaseDataReceived.Invoke(obj:  data);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnPurchaseRequestAudioInvoked(bool canAfford)
        {
            if(this.PurchaseRequestAudioInvoked == null)
            {
                    return;
            }
            
            canAfford = canAfford;
            this.PurchaseRequestAudioInvoked.Invoke(obj:  canAfford);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnPurchaseProcessed()
        {
            if(this.PurchaseProcessed == null)
            {
                    return;
            }
            
            this.PurchaseProcessed.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnStoreOpened()
        {
            if(this.StoreOpened == null)
            {
                    return;
            }
            
            this.StoreOpened.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnStoreClosed()
        {
            if(this.StoreClosed == null)
            {
                    return;
            }
            
            this.StoreClosed.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnReadyToActivateLocationServices()
        {
            if(this.ReadyToActivateLocationServices == null)
            {
                    return;
            }
            
            this.ReadyToActivateLocationServices.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnReadyToActivateAR()
        {
            if(this.ReadyToActivateAR == null)
            {
                    return;
            }
            
            this.ReadyToActivateAR.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnApplicationFocus(bool focus)
        {
            if(this.HandleApplicationFocus == null)
            {
                    return;
            }
            
            focus = focus;
            this.HandleApplicationFocus.Invoke(obj:  focus);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnNetworkConnectionUpdate(bool connectionIsOn)
        {
            if(this.NetworkConnectionUpdated == null)
            {
                    return;
            }
            
            connectionIsOn = connectionIsOn;
            this.NetworkConnectionUpdated.Invoke(obj:  connectionIsOn);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnNetworkDialogRequestReceived(GameUI.GenericDialogData data)
        {
            if(this.NetworkDialogRequestReceived == null)
            {
                    return;
            }
            
            this.NetworkDialogRequestReceived.Invoke(obj:  data);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnNetworkDialogRequestRemoved()
        {
            if(this.NetworkDialogRequestRemoved == null)
            {
                    return;
            }
            
            this.NetworkDialogRequestRemoved.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnRewardDialogOpened()
        {
            if(this.RewardDialogOpened == null)
            {
                    return;
            }
            
            this.RewardDialogOpened.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnRewardDialogClosed()
        {
            if(this.RewardDialogClosed == null)
            {
                    return;
            }
            
            this.RewardDialogClosed.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnTutorialStartupDataReceived(Game.TheGame.Data.TutorialData data)
        {
            if(this.TutorialStartupDataReceived == null)
            {
                    return;
            }
            
            this.TutorialStartupDataReceived.Invoke(obj:  data);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnFeatureFlagsUpdated(Systems.Guide.FeatureFlags.FeatureFlagMap map)
        {
            if(this.FeatureFlagsUpdatedEvent == null)
            {
                    return;
            }
            
            this.FeatureFlagsUpdatedEvent.Invoke(obj:  map);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnEncounterEnded(bool success, string cpuId)
        {
            if(this.EncounterEndedEvent == null)
            {
                    return;
            }
            
            success = success;
            this.EncounterEndedEvent.Invoke(arg1:  success, arg2:  cpuId);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnLocalGameplayAssetsReady(int failedAssetCount)
        {
            if(this.LocalGameplayAssetsReady == null)
            {
                    return;
            }
            
            this.LocalGameplayAssetsReady.Invoke(obj:  failedAssetCount);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnLocalGameplayEnded()
        {
            if(this.LocalGameplayEnded == null)
            {
                    return;
            }
            
            this.LocalGameplayEnded.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnTableOfContentsDownloadFailure(int failureCount)
        {
            if(this.TableOfContentsDownloadFailure == null)
            {
                    return;
            }
            
            this.TableOfContentsDownloadFailure.Invoke(obj:  failureCount);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnAssetBundleDownloadProgressUpdated(Systems.AssetManagement.Bundles.BundleDownloadProgressData progressData)
        {
            if(this.AssetBundleDownloadProgressUpdated == null)
            {
                    return;
            }
            
            this.AssetBundleDownloadProgressUpdated.Invoke(obj:  progressData);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnAssetBundleDownloadSegmentsAllComplete(int failedAssetCount)
        {
            if(this.AssetBundleDownloadSegmentsAllComplete == null)
            {
                    return;
            }
            
            this.AssetBundleDownloadSegmentsAllComplete.Invoke(obj:  failedAssetCount);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnPopulateSeasonalAssetsRequest(string receiverId, UnityEngine.Transform target)
        {
            if(this.PopulateSeasonalAssetsRequest == null)
            {
                    return;
            }
            
            this.PopulateSeasonalAssetsRequest.Invoke(arg1:  receiverId, arg2:  target);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnWorkshopCpuChanged()
        {
            if(this.WorkshopCpuChanged == null)
            {
                    return;
            }
            
            this.WorkshopCpuChanged.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnWorkshopCpuMenuClosed()
        {
            if(this.WorkshopCpuMenuClosed == null)
            {
                    return;
            }
            
            this.WorkshopCpuMenuClosed.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnWorkshopCpuMenuOpened()
        {
            if(this.WorkshopCpuMenuOpened == null)
            {
                    return;
            }
            
            this.WorkshopCpuMenuOpened.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnWorkshopModMenuClosed()
        {
            if(this.WorkshopModMenuClosed == null)
            {
                    return;
            }
            
            this.WorkshopModMenuClosed.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnWorkshopModMenuOpened()
        {
            if(this.WorkshopModMenuOpened == null)
            {
                    return;
            }
            
            this.WorkshopModMenuOpened.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnWorkshopRepairSuccess()
        {
            if(this.WorkshopRepairSuccess == null)
            {
                    return;
            }
            
            this.WorkshopRepairSuccess.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnWorkshopModIconPressed(bool unlocked)
        {
            if(this.WorkshopModIconPressed == null)
            {
                    return;
            }
            
            unlocked = unlocked;
            this.WorkshopModIconPressed.Invoke(obj:  unlocked);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnExtraBatteryStateChanged(Game.CameraEquipment.Battery.ExtraBatteryStateChange extraBatteryStateChange)
        {
            if(this.ExtraBatteryStateChanged == null)
            {
                    return;
            }
            
            this.ExtraBatteryStateChanged.Invoke(obj:  extraBatteryStateChange);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnFlashlightStateChanged(bool isFlashlightOn, bool shouldPlayAudio)
        {
            if(this.FlashlightStateChanged == null)
            {
                    return;
            }
            
            this.FlashlightStateChanged.Invoke(isFlashlightOn:  isFlashlightOn, shouldPlayAudio:  shouldPlayAudio);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnFlashlightTriedToActivate()
        {
            if(this.FlashlightTriedToActivate == null)
            {
                    return;
            }
            
            this.FlashlightTriedToActivate.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnFlashlightCooldownComplete()
        {
            if(this.FlashlightCooldownComplete == null)
            {
                    return;
            }
            
            this.FlashlightCooldownComplete.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnShockerActivated(Game.CameraEquipment.Shocker.ShockerActivation shockerActivation)
        {
            if(this.ShockerActivated == null)
            {
                    return;
            }
            
            this.ShockerActivated.Invoke(obj:  shockerActivation);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnShockerCooldownComplete()
        {
            if(this.ShockerCooldownComplete == null)
            {
                    return;
            }
            
            this.ShockerCooldownComplete.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnMaskForcedOff()
        {
            if(this.MaskForcedOff == null)
            {
                    return;
            }
            
            this.MaskForcedOff.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnMaskStateChanged(bool isMaskGoingOn, bool isMaskTransitionBeginning)
        {
            if(this.MaskStateChanged == null)
            {
                    return;
            }
            
            this.MaskStateChanged.Invoke(isMaskGoingOn:  isMaskGoingOn, isMaskTransitionBeginning:  isMaskTransitionBeginning);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnAttackDisruptionStateChanged(bool isDisruptionActive, Game.AttackSequence.DisruptionMechanic.DisruptionStyle style)
        {
            if(this.AttackDisruptionStateChanged == null)
            {
                    return;
            }
            
            this.AttackDisruptionStateChanged.Invoke(isDisruptionActive:  isDisruptionActive, style:  style);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnAttackSurgeStateChanged(bool isSurgeActive, Game.ItemDefinition.Data.DataDefinitions.SurgeData surgeSettings)
        {
            if(this.AttackSurgeStateChanged == null)
            {
                    return;
            }
            
            this.AttackSurgeStateChanged.Invoke(isSurgeActive:  isSurgeActive, surgeSettings:  surgeSettings);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnAttackEncounterStarted(Game.ItemDefinition.Data.DataDefinitions.EncounterType type)
        {
            if(this.AttackEncounterStarted == null)
            {
                    return;
            }
            
            this.AttackEncounterStarted.Invoke(obj:  type);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnAttackSequenceReadyForUi(Game.AttackSequence.Encounters.EncounterResult result)
        {
            if(this.AttackSequenceReadyForUi == null)
            {
                    return;
            }
            
            this.AttackSequenceReadyForUi.Invoke(obj:  result);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnAttackEncounterEnded()
        {
            if(this.AttackEncounterEnded == null)
            {
                    return;
            }
            
            this.AttackEncounterEnded.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnAnimatronicAttackWindowClosed()
        {
            if(this.AnimatronicAttackWindowClosed == null)
            {
                    return;
            }
            
            this.AnimatronicAttackWindowClosed.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnAnimatronicShocked()
        {
            if(this.AnimatronicShocked == null)
            {
                    return;
            }
            
            this.AnimatronicShocked.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnAnimatronicDefeated()
        {
            if(this.AnimatronicDefeated == null)
            {
                    return;
            }
            
            this.AnimatronicDefeated.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnPhaseCompleted(Game.AttackSequence.Animatronic.PhaseManagement.AttackPhase phase)
        {
            if(this.PhaseCompleted == null)
            {
                    return;
            }
            
            this.PhaseCompleted.Invoke(obj:  phase);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnRewardsFlowCompleted()
        {
            if(this.RewardsFlowCompleted == null)
            {
                    return;
            }
            
            this.RewardsFlowCompleted.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnStaticSettingsUpdated(Game.AttackSequence.Static.StaticSettings staticSettings)
        {
            if(this.StaticSettingsUpdated == null)
            {
                    return;
            }
            
            this.StaticSettingsUpdated.Invoke(obj:  staticSettings);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GenericDialogRequest(GameUI.GenericDialogData genericDialogData)
        {
            if(this.GenericDialogRequestReceived == null)
            {
                    return;
            }
            
            this.GenericDialogRequestReceived.Invoke(obj:  genericDialogData);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnBuyMoreCoinsDialogRequest()
        {
            if(this.BuyMoreCoinsDialogRequest == null)
            {
                    return;
            }
            
            this.BuyMoreCoinsDialogRequest.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnStartupTaskCompleted(string taskName)
        {
            if(this.StartupTaskCompleted == null)
            {
                    return;
            }
            
            this.StartupTaskCompleted.Invoke(obj:  taskName);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SendPreloadEvent(P7.CanvasFlow.CanvasController preloadView, string eventName)
        {
            if(this.PreloadEvent == null)
            {
                    return;
            }
            
            this.PreloadEvent.Invoke(arg1:  preloadView, arg2:  eventName);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RequestGuidePopup(string popupName)
        {
            if(this.GuidePopupRequested == null)
            {
                    return;
            }
            
            this.GuidePopupRequested.Invoke(obj:  popupName);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void DismissGuidePopup(string popupName)
        {
            if(this.GuidePopupDismissed == null)
            {
                    return;
            }
            
            this.GuidePopupDismissed.Invoke(obj:  popupName);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void CloseGuidePopup(string popupName)
        {
            if(this.GuidePopupClosing == null)
            {
                    return;
            }
            
            this.GuidePopupClosing.Invoke(obj:  popupName);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GenericPopdownRequest(GameUI.PopDownData popDownData)
        {
            if(this.GenericPopDownRequested == null)
            {
                    return;
            }
            
            this.GenericPopDownRequested.Invoke(obj:  popDownData);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RequestGuidePointer(UnityEngine.Vector3 worldPos, UnityEngine.Vector2 canvasOffset, float rotation)
        {
            if(this.GuidePointerRequested == null)
            {
                    return;
            }
            
            this.GuidePointerRequested.Invoke(arg1:  new UnityEngine.Vector3() {x = worldPos.x, y = worldPos.y, z = worldPos.z}, arg2:  new UnityEngine.Vector2() {x = canvasOffset.x, y = canvasOffset.y}, arg3:  rotation);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void DismissGuidePointer()
        {
            if(this.GuidePointerDismissed == null)
            {
                    return;
            }
            
            this.GuidePointerDismissed.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnWorkshopSlotDataUpdated(System.Collections.Generic.List<GameUI.WorkshopSlotData> datas)
        {
            if(this.WorkshopSlotDataUpdated == null)
            {
                    return;
            }
            
            this.WorkshopSlotDataUpdated.Invoke(obj:  datas);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnEssenceNodeSelected(Game.EssenceCollection.Actions.EssenceNodes.CameraInfoRecorder.TrackerSessionPackage trackerSessionPackage, System.Collections.Generic.List<Game.Server.EssenceNodeEntry> types)
        {
            if(this.EssenceNodeSelected == null)
            {
                    return;
            }
            
            this.EssenceNodeSelected.Invoke(arg1:  new TrackerSessionPackage() {cameraInfoFrames = trackerSessionPackage.cameraInfoFrames, detectedObjects = trackerSessionPackage.cameraInfoFrames, canSelectObjectEvaluations = trackerSessionPackage.canSelectObjectEvaluations}, arg2:  types);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnEssenceTrackerSessionCompleted(Game.EssenceCollection.Actions.EssenceNodes.CameraInfoRecorder.TrackerSessionPackage trackerSessionPackage)
        {
            var val_2 = 1152921523275870784;
            if(this.EssenceTrackerSessionCompleted == null)
            {
                    return;
            }
            
            this.EssenceTrackerSessionCompleted.Invoke(obj:  new TrackerSessionPackage() {cameraInfoFrames = trackerSessionPackage.cameraInfoFrames, detectedObjects = trackerSessionPackage.cameraInfoFrames, canSelectObjectEvaluations = trackerSessionPackage.canSelectObjectEvaluations});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnRemnantCollectionAudioStarted()
        {
            if(this.RemnantCollectionAudioStarted == null)
            {
                    return;
            }
            
            this.RemnantCollectionAudioStarted.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnRemnantCollectionAudioEnded()
        {
            if(this.RemnantCollectionAudioEnded == null)
            {
                    return;
            }
            
            this.RemnantCollectionAudioEnded.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnAnalyticsVisualizerPresent()
        {
            if(this.AnalyticsVisualizerPresent == null)
            {
                    return;
            }
            
            this.AnalyticsVisualizerPresent.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnGuideVisualizerPresent()
        {
            if(this.GuideVisualizerPresent == null)
            {
                    return;
            }
            
            this.GuideVisualizerPresent.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnAnimatronicDataSentForId(string cpuID, string plushSuitID, AnimatronicEntity.SaveGameChunk animatronicEntity)
        {
            if(this.AnimatronicDataSentForId == null)
            {
                    return;
            }
            
            this.AnimatronicDataSentForId.Invoke(arg1:  cpuID, arg2:  plushSuitID, arg3:  animatronicEntity);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ConfigureFabButton(string buttonName, bool desiredState, object requestingEntity)
        {
            if(this.FabButtonConfigurationChangeEvent == null)
            {
                    return;
            }
            
            this.FabButtonConfigurationChangeEvent.Invoke(buttonName:  buttonName, desiredState:  desiredState, requestingEntity:  requestingEntity);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnReachedMusicStartPoint()
        {
            if(this.StartMusic == null)
            {
                    return;
            }
            
            this.StartMusic.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnReachedPopulateExistingSeasonalReceiversPoint()
        {
            if(this.PopulateExistingSeasonalReceivers == null)
            {
                    return;
            }
            
            this.PopulateExistingSeasonalReceivers.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnAnimatronicEntityReturned()
        {
            if(this.AnimatronicEntityReturned == null)
            {
                    return;
            }
            
            this.AnimatronicEntityReturned.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnInboxDataReceivedFromServer(System.Collections.Generic.List<GameUI.EmailData> emailDatas)
        {
            if(this.InboxDataReceivedFromServer == null)
            {
                    return;
            }
            
            this.InboxDataReceivedFromServer.Invoke(obj:  emailDatas);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnEmailModelUpdated(System.Collections.Generic.List<GameUI.EmailData> emailDatas)
        {
            if(this.EmailDataModelUpdated == null)
            {
                    return;
            }
            
            this.EmailDataModelUpdated.Invoke(obj:  emailDatas);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnInboxOpened()
        {
            if(this.InboxOpened == null)
            {
                    return;
            }
            
            this.InboxOpened.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnInboxClosed()
        {
            if(this.InboxClosed == null)
            {
                    return;
            }
            
            this.InboxClosed.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnMaxEmailsToDeletePacketSizeReceived(int num)
        {
            if(this.MaxEmailsToDeletePacketSizeReceived == null)
            {
                    return;
            }
            
            this.MaxEmailsToDeletePacketSizeReceived.Invoke(obj:  num);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnMaxEmailsSetReadPacketSizeReceived(int num)
        {
            if(this.MaxEmailsSetReadPacketSizeReceived == null)
            {
                    return;
            }
            
            this.MaxEmailsSetReadPacketSizeReceived.Invoke(obj:  num);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnInboxFolderDataReceived(string data)
        {
            if(this.InboxFolderDataReceived == null)
            {
                    return;
            }
            
            this.InboxFolderDataReceived.Invoke(obj:  data);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnResultsDataUpdated()
        {
            if(this.ResultsDataUpdated == null)
            {
                    return;
            }
            
            this.ResultsDataUpdated.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnSequentialRewardsModelUpdated(System.Collections.Generic.List<Game.SeasonalEvents.Data.SeasonalEventData> packages)
        {
            if(this.SequentialRewardsModelUpdated == null)
            {
                    return;
            }
            
            this.SequentialRewardsModelUpdated.Invoke(obj:  packages);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnGetSocialInvitePayloadReceived(string payload)
        {
            if(this.GetSocialInvitePayloadReceived == null)
            {
                    return;
            }
            
            this.GetSocialInvitePayloadReceived.Invoke(obj:  payload);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnGetSocialInviteExplicitContent(Systems.GetSocialInviteHandling.InviteSender.GetSocialInviteContent payload)
        {
            if(this.GetSocialInviteExplicitContent == null)
            {
                    return;
            }
            
            this.GetSocialInviteExplicitContent.Invoke(obj:  new GetSocialInviteContent() {Title = payload.Title, Description = payload.Description});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnGetSocialValidated(bool fazPassInEffect, bool canContinue, int numInvites)
        {
            if(this.GetSocialValidated == null)
            {
                    return;
            }
            
            fazPassInEffect = fazPassInEffect;
            canContinue = canContinue;
            this.GetSocialValidated.Invoke(arg1:  fazPassInEffect, arg2:  canContinue, arg3:  numInvites);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnReauthPayload(string payload)
        {
            if(this.ReauthPayload == null)
            {
                    return;
            }
            
            this.ReauthPayload.Invoke(obj:  payload);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnGameReadyForAlertsEvent()
        {
            if(this.GameReadyForAlertsEvent == null)
            {
                    return;
            }
            
            this.GameReadyForAlertsEvent.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnShouldStartCheckingSeasonalUpdate()
        {
            if(this.ShouldStartCheckingSeasonalUpdate == null)
            {
                    return;
            }
            
            this.ShouldStartCheckingSeasonalUpdate.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnTutorialUIEvent(TutorialSendUIEvent.TutorialUIEvent eventId)
        {
            if(this.TutorialUIEvent == null)
            {
                    return;
            }
            
            this.TutorialUIEvent.Invoke(obj:  eventId);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnGameReadyForAnimatronicsEvent()
        {
            if(this.GameReadyForAnimatronicsEvent == null)
            {
                    return;
            }
            
            this.GameReadyForAnimatronicsEvent.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnGameReadyForServerHeartbeat()
        {
            if(this.GameReadyForServerHeartbeat == null)
            {
                    return;
            }
            
            this.GameReadyForServerHeartbeat.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnGameDisplayChange(TheGame.GameDisplayData e)
        {
            if(this.GameDisplayChange == null)
            {
                    return;
            }
            
            this.GameDisplayChange.Invoke(obj:  e);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnUICanvasDidAppear(TheGame.GameDisplayData.DisplayType displayType)
        {
            if(this.UICanvasDidAppear == null)
            {
                    return;
            }
            
            this.UICanvasDidAppear.Invoke(obj:  displayType);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnUIChangeRequest(TheGame.GameDisplayData.DisplayType obj)
        {
            if(this.UIChangeRequest == null)
            {
                    return;
            }
            
            this.UIChangeRequest.Invoke(obj:  obj);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnUICanvasClosed(TheGame.GameDisplayData.DisplayType displayType)
        {
            if(this.UICanvasClosed == null)
            {
                    return;
            }
            
            this.UICanvasClosed.Invoke(obj:  displayType);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnShowUIBars(bool value)
        {
            if(this.ShowUIBars == null)
            {
                    return;
            }
            
            value = value;
            this.ShowUIBars.Invoke(obj:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnCompleteFTUEVideo()
        {
            if(this.CompleteFTUEVideo == null)
            {
                    return;
            }
            
            this.CompleteFTUEVideo.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnPersonalFriendCodeUpdated(string friendCode)
        {
            if(this.PersonalFriendCodeUpdated == null)
            {
                    return;
            }
            
            this.PersonalFriendCodeUpdated.Invoke(obj:  friendCode);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnFriendCodeLookedUp(Game.Server.FriendCodeResponseHandler.FriendLookupResponse response)
        {
            if(this.FriendCodeLookedUp == null)
            {
                    return;
            }
            
            this.FriendCodeLookedUp.Invoke(obj:  response);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnAddedFriendByCode(bool success)
        {
            if(this.AddedFriendByCode == null)
            {
                    return;
            }
            
            success = success;
            this.AddedFriendByCode.Invoke(obj:  success);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnNewCameraUIIconAnimator(Systems.Guide.UI.CameraUIIconAnimator cameraUIIconAnimator)
        {
            if(this.NewCameraUIIconAnimator == null)
            {
                    return;
            }
            
            this.NewCameraUIIconAnimator.Invoke(obj:  cameraUIIconAnimator);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnToSAccepted()
        {
            if(this.ToSAccepted == null)
            {
                    return;
            }
            
            this.ToSAccepted.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnSequentialRewardsButtonReady(GameUI.SequentialRewardsButtonDisplay sequentialRewardsButtonDisplay)
        {
            if(sequentialRewardsButtonDisplay == 0)
            {
                    return;
            }
            
            if(this.SequentialRewardsButtonReady == null)
            {
                    return;
            }
            
            this.SequentialRewardsButtonReady.Invoke(obj:  sequentialRewardsButtonDisplay);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnRequestRestartOnMapOnly()
        {
            if(this.RequestRestartOnMapOnly == null)
            {
                    return;
            }
            
            this.RequestRestartOnMapOnly.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnRequestRestartGlobally()
        {
            if(this.RequestRestartGlobally == null)
            {
                    return;
            }
            
            this.RequestRestartGlobally.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnRecallButtonTapped()
        {
            if(this.RecallButtonTapped == null)
            {
                    return;
            }
            
            this.RecallButtonTapped.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnActiveDailyChallengesUpdated()
        {
            if(this.ActiveDailyChallengesUpdated == null)
            {
                    return;
            }
            
            this.ActiveDailyChallengesUpdated.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public EventExposer()
        {
        
        }
    
    }

}
