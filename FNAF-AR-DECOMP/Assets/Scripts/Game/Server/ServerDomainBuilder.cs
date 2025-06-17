using UnityEngine;

namespace Game.Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ServerDomainBuilder
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.Server.ServerDomain serverDomain;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ServerDomainBuilder(Master.MasterDomain masterDomain)
        {
            var val_5;
            if(masterDomain != null)
            {
                    val_5 = this;
                this.serverDomain = masterDomain.serverDomain;
            }
            else
            {
                    val_5 = this;
                this.serverDomain = 36;
            }
            
            this.NewResponseHandlers();
            this.InitializeLogEventHandler(masterDomain:  masterDomain, eventExposer:  masterDomain.eventExposer);
            this.InitializeRequesters(eventExposer:  masterDomain.eventExposer, logEventHandler:  this.serverDomain.logEventHandler);
            this.serverDomain.serverChunkLoader = new AnimatronicEntity.ServerChunkLoader();
            mem[68] = new Game.Server.NetworkAvailabilityCheckers.NetworkAvailabilityChecker(eventExposer:  masterDomain.eventExposer);
            mem[76] = new Systems.Server.PFCouponRedeemer();
            mem[84] = new Game.Server.HeartbeatDispatcher();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetupDomain(Master.MasterDomain masterDomain)
        {
            Game.Server.ServerDomain val_1;
            this.SetupResponseHandlers(masterDomain:  masterDomain);
            this.SetupRequesters(masterDomain:  masterDomain);
            this.serverDomain.couponRedeemer.Setup(eventExposer:  masterDomain.eventExposer);
            val_1 = this.serverDomain;
            if(this.serverDomain != null)
            {
                goto label_3;
            }
            
            val_1 = this.serverDomain;
            if(val_1 == null)
            {
                goto label_4;
            }
            
            label_3:
            this.serverDomain.heartbeatDispatcher.Setup(eventExposer:  masterDomain.eventExposer, requester:  this.serverDomain.heartbeatRequester);
            return;
            label_4:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void InitializeRequesters(Master.EventExposer eventExposer, Game.Server.LogEventHandler logEventHandler)
        {
            mem[1152921525197207936] = logEventHandler;
            this.serverDomain.playerAnimatronicDataLoader = new Game.Server.PlayerAnimatronicDataLoader();
            mem[1152921525197216128] = logEventHandler;
            this.serverDomain.playerWorkshopDataLoader = new Game.Server.PlayerWorkshopDataLoader();
            mem[1152921525197228416] = logEventHandler;
            .OnAttackModeLost = new System.Action(object:  eventExposer, method:  public System.Void Master.EventExposer::OnAttackModeLost());
            this.serverDomain.attackModeLostRequester = new Game.Server.AttackModeLostRequester();
            mem[1152921525197236608] = logEventHandler;
            this.serverDomain.nextAnimatronicRequester = new Game.Server.NextAnimatronicRequester();
            mem[1152921525197244800] = logEventHandler;
            this.serverDomain.animatronicEntitySaveRequester = new Game.Server.AnimatronicEntitySaveRequester();
            mem[1152921525197252992] = logEventHandler;
            this.serverDomain.entityRewardRequester = new Game.Server.EntityRewardRequester();
            mem[1152921525197261184] = logEventHandler;
            this.serverDomain.scavengeRequester = new Game.Server.ScavengeRequester();
            mem[1152921525197269376] = logEventHandler;
            this.serverDomain.recallScavengeRequester = new Game.Server.RecallScavengeRequester();
            this.serverDomain.endoskeletonConfigRequester = new Game.Server.SetEndoskeletonConfigRequester(eventHandler:  logEventHandler);
            mem[1152921525197285760] = logEventHandler;
            this.serverDomain.repairAnimatronicRequester = new Game.Server.RepairAnimatronicRequester();
            mem[1152921525197293952] = logEventHandler;
            this.serverDomain.serverDataRequester = new Game.Server.ServerDataRequester();
            mem[1152921525197302144] = logEventHandler;
            this.serverDomain.playerDataRequester = new Game.Server.PlayerDataRequester();
            mem[1152921525197310336] = logEventHandler;
            this.serverDomain.sellModsRequester = new Game.Server.SellModsRequester();
            mem[1152921525197318528] = logEventHandler;
            this.serverDomain.sendScavengeAnimatronicV2Requester = new Game.Server.SendScavengeAnimatronicV2Requester();
            this.serverDomain.startEssenceEncounterRequester = new Game.Server.StartEssenceEncounterRequester(eventHandler:  logEventHandler);
            mem[1152921525197334912] = logEventHandler;
            this.serverDomain.essenceNodeCollectRequester = new Game.Server.EssenceNodeCollectRequester();
            mem[1152921525197343104] = logEventHandler;
            this.serverDomain.essenceNodeSpawnRequester = new Game.Server.EssenceNodeSpawnRequester();
            mem[1152921525197355392] = logEventHandler;
            .OnDeviceDataUpdated = new System.Action(object:  eventExposer, method:  public System.Void Master.EventExposer::OnDeviceDataRequested());
            this.serverDomain.deviceRequester = new Game.Server.DeviceRequester();
            mem[1152921525197367680] = logEventHandler;
            .OnDeviceDataUpdated = new System.Action(object:  eventExposer, method:  public System.Void Master.EventExposer::OnDeviceDataRequested());
            this.serverDomain.deviceRequester = new Game.Server.DeviceRequester();
            this.serverDomain.tutorialRequester = new Game.Server.TutorialRequester(eventHandler:  logEventHandler);
            mem[1152921525197384064] = logEventHandler;
            this.serverDomain.removeEntityRequester = new Game.Server.RemoveEntityRequester();
            mem[1152921525197392256] = logEventHandler;
            this.serverDomain.animatronicDataByIdRequester = new Game.Server.AnimatronicDataByIDRequester();
            mem[1152921525197400448] = logEventHandler;
            this.serverDomain.getInboxMessagesRequester = new Game.Server.Inbox.GetInboxMessagesRequster();
            mem[1152921525197408640] = logEventHandler;
            this.serverDomain.markInboxMessageRequester = new Game.Server.Inbox.MarkInboxMessageRequester();
            mem[1152921525197416832] = logEventHandler;
            this.serverDomain.removeInboxMessageRequester = new Game.Server.Inbox.RemoveInboxMessageRequester();
            mem[1152921525197425024] = logEventHandler;
            this.serverDomain.batchInboxRequester = new Game.Server.Inbox.BatchInboxRequester();
            mem[1152921525197433216] = logEventHandler;
            this.serverDomain.sendInboxAlertMessageRequester = new Game.Server.Inbox.SendInboxAlertMessageRequester();
            this.serverDomain.iapRequester = new Game.Server.IAPRequester(eventHandler:  this.serverDomain.logEventHandler, exposer:  eventExposer);
            this.serverDomain.virtualGoodsListRequester = new Game.Server.VirtualGoodsListRequester(eventHandler:  logEventHandler);
            mem[1152921525197461888] = logEventHandler;
            this.serverDomain.getOwnedGoodsRequester = new Game.Server.GetOwnedGoodsRequester();
            mem[1152921525197470080] = logEventHandler;
            this.serverDomain.getSocialInviteSendPayloadRequester = new Game.Server.GetSocialInviteSendPayloadRequester();
            mem[1152921525197478272] = logEventHandler;
            this.serverDomain.getSocialInviteQueryPayloadRequester = new Game.Server.GetSocialInviteQueryPayloadRequester();
            mem[1152921525197486464] = logEventHandler;
            this.serverDomain.getSocialInviteResultRequester = new Game.Server.Requester.GetSocialInviteResultRequester();
            mem[1152921525197494656] = logEventHandler;
            this.serverDomain.getSocialAuthenticationRequester = new Game.Server.Requester.GetSocialAuthenticationRequester();
            mem[1152921525197502848] = logEventHandler;
            this.serverDomain.avatarSaveRequester = new Game.Server.AvatarSaveRequester();
            mem[1152921525197511040] = logEventHandler;
            this.serverDomain.sendAnimatronicV2Requester = new Game.Server.SendAnimatronicV2Requester();
            mem[1152921525197519232] = logEventHandler;
            this.serverDomain.recallAttackingAnimatronicRequester = new Game.Server.RecallAttackingAnimatronicRequester();
            this.serverDomain.registerForPushNotificationsRequester = new Game.Server.Requester.RegisterForPushNotificationsRequester(eventHandler:  logEventHandler);
            mem[1152921525197535616] = logEventHandler;
            this.serverDomain.getPlayerFriendsRequester = new Game.Server.Requester.GetPlayerFriendsRequester();
            mem[1152921525197543808] = logEventHandler;
            this.serverDomain.updatePlayerFriendsRequester = new Game.Server.Requester.UpdatePlayerFriendsRequester();
            mem[1152921525197552000] = logEventHandler;
            this.serverDomain.removeFriendRequester = new Game.Server.Requester.RemoveFriendRequester();
            mem[1152921525197560192] = logEventHandler;
            this.serverDomain.expressDeliveryRequester = new Game.Server.ExpressDeliveryRequester();
            mem[1152921525197568384] = logEventHandler;
            this.serverDomain.remnantLevelUpAlertRequester = new Game.Server.Inbox.RemnantLevelUpAlertRequester();
            mem[1152921525197576576] = logEventHandler;
            this.serverDomain.friendCodeRequester = new Game.Server.FriendCodeRequester();
            mem[1152921525197584768] = logEventHandler;
            this.serverDomain.heartbeatRequester = new Game.Server.HeartbeatRequester();
            mem[1152921525197592960] = logEventHandler;
            this.serverDomain.sequentialRewardRequester = new Game.Server.SequentialRewardRequester();
            mem[1152921525197601152] = logEventHandler;
            this.serverDomain.dailyChallengeDataRequester = new Game.Server.DailyChallengeDataRequester();
            mem[1152921525197609344] = logEventHandler;
            this.serverDomain.collectDailyChallengeRewardsRequester = new Game.Server.CollectDailyChallengeRewardsRequester();
            mem[1152921525197617536] = logEventHandler;
            this.serverDomain.debugDailyChallengeForceRefresh = new Game.Server.Requester.DailyChallenge.DebugDailyChallengeForceRefresh();
            this.serverDomain.debugCompleteDailyChallengeRequester = new DefaultNamespace.DebugCompleteDailyChallengeRequester(eventHandler:  logEventHandler);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetupRequesters(Master.MasterDomain masterDomain)
        {
            this.serverDomain.animatronicEntitySaveRequester.generator = masterDomain.AnimatronicEntityDomain.chunkToGsRequestGenerator;
            this.serverDomain.animatronicEntitySaveRequester.creator = masterDomain.AnimatronicEntityDomain.SaveChunkGetter;
            this.serverDomain.scavengeRequester.generator = masterDomain.AnimatronicEntityDomain.chunkToGsRequestGenerator;
            this.serverDomain.recallScavengeRequester.generator = masterDomain.AnimatronicEntityDomain.chunkToGsRequestGenerator;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void NewResponseHandlers()
        {
            this.serverDomain.animatronicEntityResponseHandler = new Game.Server.AnimatronicEntityResponseHandler();
            this.serverDomain.animatronicStatsResponseHandler = new Game.Server.AnimatronicStatsResponseHandler();
            this.serverDomain.streakDataResponseHandler = new Game.Server.StreakDataResponseHandler();
            this.serverDomain.nextUpdateTimeResponseHandler = new Game.Server.NextUpdateTimeResponseHandler();
            this.serverDomain.newAnimatronicResponseHandler = new Game.Server.NewAnimatronicResponseHandler();
            this.serverDomain.rewardsResponseHandler = new Game.Server.RewardsResponseHandler();
            this.serverDomain.WorkshopDataResponseHandler = new Game.Server.WorkshopDataResponseHandler();
            this.serverDomain.inventoryResponseHandler = new Game.Server.InventoryResponseHandler();
            this.serverDomain.modInventoryResponseHandler = new Game.Server.ModInventoryResponseHandler();
            this.serverDomain.animatronicEntityUpdateResponseHandler = new Game.Server.AnimatronicEntityUpdateResponseHandler();
            this.serverDomain.currencyDataResponseHandler = new Game.Server.CurrencyDataResponseHandler();
            this.serverDomain.rewardsV2ResponseHandler = new Game.Server.RewardsV2ResponseHandler();
            this.serverDomain.WorkshopDataV2ResponseHandler = new Game.Server.WorkshopDataV2ResponseHandler();
            this.serverDomain.cpuInventoryResponseHandler = new Game.Server.CPUInventoryResponseHandler();
            this.serverDomain.configDataResponseHandler = new Game.Server.ConfigDataResponseHandler();
            this.serverDomain.playerAlertDataResponseHandler = new Game.Server.PlayerAlertDataResponseHandler();
            this.serverDomain.timeResponseHandler = new Game.Server.TimeResponseHandler();
            this.serverDomain.playerEssenceDataResponseHandler = new Game.Server.PlayerEssenceDataResponseHandler();
            this.serverDomain.essencesToSpawnResponseHandler = new Game.Server.EssencesToSpawnResponseHandler();
            this.serverDomain.deviceDataResponseHandler = new Game.Server.DeviceDataResponseHandler();
            this.serverDomain.purchaseDataResponseHandler = new Game.Server.PurchaseDataResponseHandler();
            this.serverDomain.tutorialDataResponseHandler = new Game.Server.TutorialDataResponseHandler();
            this.serverDomain.animatronicDataForIdResponseHandler = new Game.Server.AnimatronicDataForIDResponseHandler();
            this.serverDomain.featureFlagsResponseHandler = new Game.Server.FeatureFlagsResponseHandler();
            this.serverDomain.inboxResponseHandler = new Game.Server.InboxResponseHandler();
            this.serverDomain.getSocialInvitePayloadResponseHandler = new Game.Server.GetSocialInvitePayloadResponseHandler();
            this.serverDomain.getSocialAuthenticationResponseHandler = new Game.Server.GetSocialAuthenticationResponseHandler();
            this.serverDomain.friendsListResponseHandler = new Game.Server.FriendsListResponseHandler();
            this.serverDomain.friendCodeResponseHandler = new Game.Server.FriendCodeResponseHandler();
            this.serverDomain.purchasedSlotsResponseHandler = new Game.Server.PurchasedSlotsResponseHandler();
            this.serverDomain.playerStatsDataResponseHandler = new Game.Server.PlayerStatsDataResponseHandler();
            this.serverDomain.playerGoodsResponseHandler = new Game.Server.PlayerGoodsResponseHandler();
            this.serverDomain.playerProfileResponseHandler = new Game.Server.PlayerProfileResponseHandler();
            this.serverDomain.updateAnimatronicEntitiesResponseHandler = new Game.Server.UpdateAnimatronicEntitiesResponseHandler();
            this.serverDomain.heartbeatPeriodResponseHandler = new Game.Server.HeartbeatPeriodResponseHandler();
            this.serverDomain.seasonalEventDataResponseHandler = new Game.Server.SeasonalEventDataResponseHandler();
            this.serverDomain.virtualGoodsListResponseHandler = new Game.Server.VirtualGoodsListResponseHandler();
            this.serverDomain.storeIdChangedResponseHandler = new Game.Server.StoreIdChangedResponseHandler();
            this.serverDomain.passiveRequestListResponseHandler = new Game.Server.PassiveRequestListResponseHandler();
            this.serverDomain.dailyChallengeDataResponseHandler = new Game.Server.DailyChallengeDataResponseHandler();
            this.serverDomain.dailyChallengeRewardsResponseHandler = new Game.Server.DailyChallengeRewardsResponseHandler();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetupResponseHandlers(Master.MasterDomain masterDomain)
        {
            Game.Server.ServerDomain val_55;
            Game.Server.ServerDomain val_56;
            Game.Server.ServerDomain val_57;
            this.serverDomain.animatronicEntityResponseHandler.loader = new System.Func<Systems.Server.ServerData, AnimatronicEntity.SaveGameChunk>(object:  masterDomain.AnimatronicEntityDomain.ServerChunkLoader, method:  public AnimatronicEntity.SaveGameChunk AnimatronicEntity.ServerChunkLoader::GenerateChunk(Systems.Server.ServerData data));
            this.serverDomain.animatronicEntityResponseHandler.PlayerAnimatronicDataLoaded = new System.Action<System.Collections.Generic.List<AnimatronicEntity.SaveGameChunk>>(object:  masterDomain.eventExposer, method:  public System.Void Master.EventExposer::OnPlayerAnimatronicDataLoaded(System.Collections.Generic.List<AnimatronicEntity.SaveGameChunk> e));
            this.serverDomain.animatronicStatsResponseHandler.PlayerAnimatronicStatsDataLoaded = new System.Action<System.Collections.Generic.Dictionary<System.String, Animatronics.AnimatronicStats.StatsData>>(object:  masterDomain.eventExposer, method:  public System.Void Master.EventExposer::OnAnimatronicStatsUpdated(System.Collections.Generic.Dictionary<string, Animatronics.AnimatronicStats.StatsData> data));
            this.serverDomain.streakDataResponseHandler.Setup(eventExposer:  masterDomain.eventExposer);
            this.serverDomain.nextUpdateTimeResponseHandler.UpdateNextAnimatronicRequestTime = new System.Action<System.Int64>(object:  masterDomain.eventExposer, method:  public System.Void Master.EventExposer::OnUpdateNextAnimatronicRequestTime(long nextTime));
            val_55 = this.serverDomain;
            if(this.serverDomain != null)
            {
                goto label_11;
            }
            
            val_55 = this.serverDomain;
            if(val_55 == null)
            {
                goto label_81;
            }
            
            label_11:
            this.serverDomain.newAnimatronicResponseHandler.EntityChunkGenerated = new System.Action<AnimatronicEntity.SaveGameChunk>(object:  masterDomain.eventExposer, method:  public System.Void Master.EventExposer::OnEntityChunkGenerated(AnimatronicEntity.SaveGameChunk e));
            this.serverDomain.newAnimatronicResponseHandler.GenerateChunk = new System.Func<Systems.Server.ServerData, AnimatronicEntity.SaveGameChunk>(object:  this.serverDomain.serverChunkLoader, method:  public AnimatronicEntity.SaveGameChunk AnimatronicEntity.ServerChunkLoader::GenerateChunk(Systems.Server.ServerData data));
            this.serverDomain.rewardsResponseHandler.OnRewardReceived = new System.Action<Game.TheGame.Data.RewardData>(object:  masterDomain.eventExposer, method:  public System.Void Master.EventExposer::OnRewardsReceived(Game.TheGame.Data.RewardData e));
            this.serverDomain.WorkshopDataResponseHandler.Setup(callback:  new System.Action<AnimatronicEntity.Data.WorkshopData>(object:  masterDomain.eventExposer, method:  public System.Void Master.EventExposer::OnWorkshopDataUpdated(AnimatronicEntity.Data.WorkshopData data)), processor:  new System.Func<Systems.Server.ServerData, AnimatronicEntity.Data.WorkshopEntry>(object:  0, method:  public static AnimatronicEntity.Data.WorkshopEntry Game.Server.Processors.ServerProcessors::ProcessWorkshopDataEntry(Systems.Server.ServerData entry)));
            this.serverDomain.inventoryResponseHandler.InventoryUpdated = new System.Action<TheGame.PlayerInventory>(object:  masterDomain.eventExposer, method:  public System.Void Master.EventExposer::OnInventoryUpdated(TheGame.PlayerInventory e));
            this.serverDomain.modInventoryResponseHandler.ModInventoryUpdated = new System.Action<Game.Workshop.Data.ModInventory>(object:  masterDomain.eventExposer, method:  public System.Void Master.EventExposer::OnModInventoryUpdated(Game.Workshop.Data.ModInventory data));
            val_56 = this.serverDomain;
            if(this.serverDomain != null)
            {
                goto label_22;
            }
            
            val_56 = this.serverDomain;
            if(val_56 == null)
            {
                goto label_81;
            }
            
            label_22:
            this.serverDomain.animatronicEntityUpdateResponseHandler.AnimatronicEntityUpdated = new System.Action<AnimatronicEntity.SaveGameChunk>(object:  masterDomain.eventExposer, method:  public System.Void Master.EventExposer::OnAnimatronicEntityUpdated(AnimatronicEntity.SaveGameChunk data));
            this.serverDomain.animatronicEntityUpdateResponseHandler.loader = new System.Func<Systems.Server.ServerData, AnimatronicEntity.SaveGameChunk>(object:  this.serverDomain.serverChunkLoader, method:  public AnimatronicEntity.SaveGameChunk AnimatronicEntity.ServerChunkLoader::GenerateChunk(Systems.Server.ServerData data));
            this.serverDomain.currencyDataResponseHandler.GotCurrencyData = new System.Action<System.Collections.Generic.Dictionary<System.String, System.Int32>>(object:  masterDomain.eventExposer, method:  public System.Void Master.EventExposer::OnPlayerCurrencyRefreshed(System.Collections.Generic.Dictionary<string, int> e));
            this.serverDomain.rewardsV2ResponseHandler.ProcessRewards = new System.Func<Systems.Server.ServerData, Game.TheGame.Data.RewardDataV2>(object:  0, method:  public static Game.TheGame.Data.RewardDataV2 Game.Server.Processors.ServerProcessors::ProcessRewardData(Systems.Server.ServerData data));
            this.serverDomain.rewardsV2ResponseHandler.RewardsV2Received = new System.Action<Game.TheGame.Data.RewardDataV2>(object:  masterDomain.eventExposer, method:  public System.Void Master.EventExposer::OnRewardsV2Received(Game.TheGame.Data.RewardDataV2 e));
            this.serverDomain.WorkshopDataV2ResponseHandler.Setup(callback:  new System.Action<AnimatronicEntity.Data.WorkshopData>(object:  masterDomain.eventExposer, method:  public System.Void Master.EventExposer::OnWorkshopDataV2Updated(AnimatronicEntity.Data.WorkshopData data)), processor:  new System.Func<Systems.Server.ServerData, AnimatronicEntity.Data.WorkshopEntry>(object:  0, method:  public static AnimatronicEntity.Data.WorkshopEntry Game.Server.Processors.ServerProcessors::ProcessWorkshopDataEntry(Systems.Server.ServerData entry)));
            this.serverDomain.cpuInventoryResponseHandler.CPUInventoryUpdated = new System.Action<Game.TheGame.Data.CPUInventory>(object:  masterDomain.eventExposer, method:  public System.Void Master.EventExposer::OnCPUInventoryUpdated(Game.TheGame.Data.CPUInventory data));
            this.serverDomain.configDataResponseHandler.Setup(eventExposer:  masterDomain.eventExposer);
            this.serverDomain.playerAlertDataResponseHandler.PlayerAlertDataUpdated = new System.Action<Alerts.Data.PlayerAlertData>(object:  masterDomain.eventExposer, method:  public System.Void Master.EventExposer::OnAlertPlayerDataUpdatedEvent(Alerts.Data.PlayerAlertData e));
            this.serverDomain.timeResponseHandler.Setup(callback:  new System.Action<System.Int64>(object:  masterDomain.eventExposer, method:  public System.Void Master.EventExposer::OnServerTimeReceived(long e)));
            this.serverDomain.playerEssenceDataResponseHandler.PlayerEssenceDataUpdated = new System.Action<Game.Server.PlayerEssenceData>(object:  masterDomain.eventExposer, method:  public System.Void Master.EventExposer::OnPlayerEssenceDataUpdated(Game.Server.PlayerEssenceData data));
            this.serverDomain.essencesToSpawnResponseHandler.SpawnEssences = new System.Action<System.Collections.Generic.List<Game.Server.EssenceNodeEntry>>(object:  masterDomain.eventExposer, method:  public System.Void Master.EventExposer::OnSpawnEssences(System.Collections.Generic.List<Game.Server.EssenceNodeEntry> data));
            this.serverDomain.deviceDataResponseHandler.DeviceDataReceived = new System.Action<Game.TheGame.Data.AllPlayerDevices>(object:  masterDomain.eventExposer, method:  public System.Void Master.EventExposer::OnDeviceDataReceived(Game.TheGame.Data.AllPlayerDevices data));
            this.serverDomain.purchaseDataResponseHandler.PurchaseDataReceived = new System.Action<System.Collections.Generic.Dictionary<System.String, System.Int32>>(object:  masterDomain.eventExposer, method:  public System.Void Master.EventExposer::OnPurchaseDataReceived(System.Collections.Generic.Dictionary<string, int> data));
            this.serverDomain.tutorialDataResponseHandler.Setup(callback:  new System.Action<Game.TheGame.Data.TutorialData>(object:  masterDomain.eventExposer, method:  public System.Void Master.EventExposer::OnTutorialStartupDataReceived(Game.TheGame.Data.TutorialData data)));
            this.serverDomain.seasonalEventDataResponseHandler.SeasonalDataReceived = new System.Action<System.Collections.Generic.List<Game.SeasonalEvents.Data.SeasonalEventData>>(object:  masterDomain.eventExposer, method:  public System.Void Master.EventExposer::OnSeasonalEventDataReceived(System.Collections.Generic.List<Game.SeasonalEvents.Data.SeasonalEventData> data));
            this.serverDomain.virtualGoodsListResponseHandler.Setup(callback:  new System.Action<StoreIdentificationData, System.Collections.Generic.List<VirtualGoodResponseData>>(object:  masterDomain.eventExposer, method:  public System.Void Master.EventExposer::OnVirtualGoodsDataReceived(Game.Store.Container.StoreContainer.StoreIdentificationData storeData, System.Collections.Generic.List<Game.Store.Container.StoreContainer.VirtualGoodResponseData> response)));
            this.serverDomain.storeIdChangedResponseHandler.Setup(callback:  new System.Action<System.String>(object:  masterDomain.eventExposer, method:  public System.Void Master.EventExposer::OnStoreIdReceived(string data)));
            this.serverDomain.animatronicDataForIdResponseHandler.ChunkGenerator = new System.Func<Systems.Server.ServerData, AnimatronicEntity.SaveGameChunk>(object:  masterDomain.AnimatronicEntityDomain.ServerChunkLoader, method:  public AnimatronicEntity.SaveGameChunk AnimatronicEntity.ServerChunkLoader::GenerateChunk(Systems.Server.ServerData data));
            this.serverDomain.animatronicDataForIdResponseHandler.AnimatronicDataRecieved = new System.Action<System.String, System.String, AnimatronicEntity.SaveGameChunk>(object:  masterDomain.eventExposer, method:  public System.Void Master.EventExposer::OnAnimatronicDataSentForId(string cpuID, string plushSuitID, AnimatronicEntity.SaveGameChunk animatronicEntity));
            this.serverDomain.featureFlagsResponseHandler.FeatureFlagUpdated = new System.Action<Systems.Guide.FeatureFlags.FeatureFlagMap>(object:  masterDomain.eventExposer, method:  public System.Void Master.EventExposer::OnFeatureFlagsUpdated(Systems.Guide.FeatureFlags.FeatureFlagMap map));
            this.serverDomain.getSocialInvitePayloadResponseHandler.PayloadReceived = new System.Action<System.String>(object:  masterDomain.eventExposer, method:  public System.Void Master.EventExposer::OnGetSocialInvitePayloadReceived(string payload));
            this.serverDomain.getSocialAuthenticationResponseHandler._responseReceived = new System.Action<System.Boolean, System.Boolean, System.Int32>(object:  masterDomain.eventExposer, method:  public System.Void Master.EventExposer::OnGetSocialValidated(bool fazPassInEffect, bool canContinue, int numInvites));
            this.serverDomain.inboxResponseHandler.OnInboxDataReceivedFromServer = new System.Action<System.Collections.Generic.List<GameUI.EmailData>>(object:  masterDomain.eventExposer, method:  public System.Void Master.EventExposer::OnInboxDataReceivedFromServer(System.Collections.Generic.List<GameUI.EmailData> emailDatas));
            this.serverDomain.inboxResponseHandler.EmailDataLoader = new System.Func<Systems.Server.ServerData, GameUI.EmailData>(object:  0, method:  public static GameUI.EmailData Game.Server.Processors.ServerProcessors::ProcessEmailData(Systems.Server.ServerData data));
            this.serverDomain.friendsListResponseHandler.OnFriendsListUpdated = new System.Action<System.Collections.Generic.List<Game.Server.PlayerFriendsEntry>>(object:  masterDomain.eventExposer, method:  public System.Void Master.EventExposer::OnFriendListUpdated(System.Collections.Generic.List<Game.Server.PlayerFriendsEntry> data));
            this.serverDomain.friendCodeResponseHandler.OnFriendCodeUpdated = new System.Action<System.String>(object:  masterDomain.eventExposer, method:  public System.Void Master.EventExposer::OnPersonalFriendCodeUpdated(string friendCode));
            this.serverDomain.friendCodeResponseHandler.OnFriendCodeLookedUp = new System.Action<FriendLookupResponse>(object:  masterDomain.eventExposer, method:  public System.Void Master.EventExposer::OnFriendCodeLookedUp(Game.Server.FriendCodeResponseHandler.FriendLookupResponse response));
            this.serverDomain.purchasedSlotsResponseHandler.PurchasedSlotsUpdated = new System.Action<System.Int32>(object:  masterDomain.eventExposer, method:  public System.Void Master.EventExposer::OnPurchasedSlotsUpdated(int purchasedSlots));
            this.serverDomain.playerStatsDataResponseHandler.PlayerStatsDataUpdated = new System.Action<Game.PlayerStats.Data.PlayerStatsData>(object:  masterDomain.eventExposer, method:  public System.Void Master.EventExposer::OnPlayerStatsUpdated(Game.PlayerStats.Data.PlayerStatsData statsData));
            this.serverDomain.playerStatsDataResponseHandler.ProcessPlayerStats = new System.Func<Systems.Server.ServerData, Game.PlayerStats.Data.PlayerStatsData>(object:  0, method:  public static Game.PlayerStats.Data.PlayerStatsData Game.Server.Processors.ServerProcessors::ProcessPlayerStats(Systems.Server.ServerData data));
            this.serverDomain.playerGoodsResponseHandler.PlayerGoodsUpdated = new System.Action<System.Collections.Generic.Dictionary<System.String, System.Int32>>(object:  masterDomain.eventExposer, method:  public System.Void Master.EventExposer::OnPlayerGoodsUpdated(System.Collections.Generic.Dictionary<string, int> ownedGoods));
            this.serverDomain.playerGoodsResponseHandler.ProcessPlayerGoods = new System.Func<System.Collections.Generic.List<Systems.Server.ServerData>, System.Collections.Generic.Dictionary<System.String, System.Int32>>(object:  0, method:  public static System.Collections.Generic.Dictionary<System.String, System.Int32> Game.Server.Processors.ServerProcessors::ProcessPlayerGoods(System.Collections.Generic.List<Systems.Server.ServerData> data));
            Server.LoginDomain val_48 = masterDomain.theGameDomain.loginDomain;
            this.serverDomain.playerProfileResponseHandler.playerProfileUpdater = val_48.playerProfileUpdater;
            val_57 = this.serverDomain;
            if(this.serverDomain != null)
            {
                goto label_80;
            }
            
            val_57 = this.serverDomain;
            if(val_57 == null)
            {
                goto label_81;
            }
            
            label_80:
            this.serverDomain.updateAnimatronicEntitiesResponseHandler.Setup(loadFunc:  new System.Func<Systems.Server.ServerData, AnimatronicEntity.SaveGameChunk>(object:  this.serverDomain.serverChunkLoader, method:  public AnimatronicEntity.SaveGameChunk AnimatronicEntity.ServerChunkLoader::GenerateChunk(Systems.Server.ServerData data)), callback:  new System.Action<AnimatronicEntity.SaveGameChunk>(object:  masterDomain.eventExposer, method:  public System.Void Master.EventExposer::OnAnimatronicEntityUpdated(AnimatronicEntity.SaveGameChunk data)));
            this.serverDomain.heartbeatPeriodResponseHandler.OnHeartbeatPeriodReceivedFromServer = new System.Action<System.Single>(object:  masterDomain.eventExposer, method:  public System.Void Master.EventExposer::OnHeartbeatPeriodChanged(float heartbeatPeriod));
            this.serverDomain.passiveRequestListResponseHandler.Callback = new System.Action<System.Collections.Generic.List<System.String>>(object:  masterDomain.eventExposer, method:  public System.Void Master.EventExposer::OnPassiveRequestListReceived(System.Collections.Generic.List<string> passiveRequestList));
            this.serverDomain.dailyChallengeDataResponseHandler.ChallengeDataReceived = new System.Action<Game.Server.DailyChallengeResponseData>(object:  masterDomain.eventExposer, method:  public System.Void Master.EventExposer::OnDailyChallengeListReceived(Game.Server.DailyChallengeResponseData responseData));
            this.serverDomain.dailyChallengeRewardsResponseHandler.RewardReceived = new System.Action<System.String>(object:  masterDomain.eventExposer, method:  public System.Void Master.EventExposer::OnDailyChallengeRewardReceived(string rewardId));
            return;
            label_81:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void InitializeLogEventHandler(Master.MasterDomain masterDomain, Master.EventExposer eventExposer)
        {
            System.Collections.Generic.HashSet<Game.Server.EventResponseHandler> val_1 = new System.Collections.Generic.HashSet<Game.Server.EventResponseHandler>();
            bool val_2 = val_1.Add(item:  this.serverDomain.newAnimatronicResponseHandler);
            bool val_3 = val_1.Add(item:  this.serverDomain.animatronicStatsResponseHandler);
            bool val_4 = val_1.Add(item:  this.serverDomain.animatronicEntityResponseHandler);
            bool val_5 = val_1.Add(item:  this.serverDomain.streakDataResponseHandler);
            bool val_6 = val_1.Add(item:  this.serverDomain.nextUpdateTimeResponseHandler);
            bool val_7 = val_1.Add(item:  this.serverDomain.rewardsResponseHandler);
            bool val_8 = val_1.Add(item:  this.serverDomain.WorkshopDataResponseHandler);
            bool val_9 = val_1.Add(item:  this.serverDomain.inventoryResponseHandler);
            bool val_10 = val_1.Add(item:  this.serverDomain.modInventoryResponseHandler);
            bool val_11 = val_1.Add(item:  this.serverDomain.animatronicEntityUpdateResponseHandler);
            bool val_12 = val_1.Add(item:  this.serverDomain.currencyDataResponseHandler);
            bool val_13 = val_1.Add(item:  this.serverDomain.rewardsV2ResponseHandler);
            bool val_14 = val_1.Add(item:  this.serverDomain.WorkshopDataV2ResponseHandler);
            bool val_15 = val_1.Add(item:  this.serverDomain.cpuInventoryResponseHandler);
            bool val_16 = val_1.Add(item:  this.serverDomain.configDataResponseHandler);
            bool val_17 = val_1.Add(item:  this.serverDomain.playerAlertDataResponseHandler);
            bool val_18 = val_1.Add(item:  this.serverDomain.timeResponseHandler);
            bool val_19 = val_1.Add(item:  this.serverDomain.playerEssenceDataResponseHandler);
            bool val_20 = val_1.Add(item:  this.serverDomain.essencesToSpawnResponseHandler);
            bool val_21 = val_1.Add(item:  this.serverDomain.deviceDataResponseHandler);
            bool val_22 = val_1.Add(item:  this.serverDomain.purchaseDataResponseHandler);
            bool val_23 = val_1.Add(item:  this.serverDomain.tutorialDataResponseHandler);
            bool val_24 = val_1.Add(item:  this.serverDomain.animatronicDataForIdResponseHandler);
            bool val_25 = val_1.Add(item:  this.serverDomain.featureFlagsResponseHandler);
            bool val_26 = val_1.Add(item:  this.serverDomain.inboxResponseHandler);
            bool val_27 = val_1.Add(item:  this.serverDomain.getSocialInvitePayloadResponseHandler);
            bool val_28 = val_1.Add(item:  this.serverDomain.getSocialAuthenticationResponseHandler);
            bool val_29 = val_1.Add(item:  this.serverDomain.friendsListResponseHandler);
            bool val_30 = val_1.Add(item:  this.serverDomain.friendCodeResponseHandler);
            bool val_31 = val_1.Add(item:  this.serverDomain.purchasedSlotsResponseHandler);
            bool val_32 = val_1.Add(item:  this.serverDomain.playerStatsDataResponseHandler);
            bool val_33 = val_1.Add(item:  this.serverDomain.playerGoodsResponseHandler);
            bool val_34 = val_1.Add(item:  this.serverDomain.playerProfileResponseHandler);
            bool val_35 = val_1.Add(item:  this.serverDomain.updateAnimatronicEntitiesResponseHandler);
            bool val_36 = val_1.Add(item:  this.serverDomain.heartbeatPeriodResponseHandler);
            bool val_37 = val_1.Add(item:  this.serverDomain.seasonalEventDataResponseHandler);
            bool val_38 = val_1.Add(item:  this.serverDomain.virtualGoodsListResponseHandler);
            bool val_39 = val_1.Add(item:  this.serverDomain.storeIdChangedResponseHandler);
            bool val_40 = val_1.Add(item:  this.serverDomain.passiveRequestListResponseHandler);
            bool val_41 = val_1.Add(item:  this.serverDomain.dailyChallengeDataResponseHandler);
            bool val_42 = val_1.Add(item:  this.serverDomain.dailyChallengeRewardsResponseHandler);
            ._masterDomain = masterDomain;
            ._eventExposer = eventExposer;
            this.serverDomain.LogEventErrorHandler = new Game.Server.LogEventErrorHandler();
            this.serverDomain.logEventHandler = new Game.Server.LogEventHandler(logEventErrorHandler:  this.serverDomain.LogEventErrorHandler, responseSet:  val_1, eventExposer:  eventExposer);
        }
    
    }

}
