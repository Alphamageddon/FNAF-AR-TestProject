using UnityEngine;

namespace Game.Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ServerDomain
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Systems.Server.ServerType CurrentServer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static PlayFab.PlayFabAuthenticationContext AuthContext;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string CatalogName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string StoreName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string CurrentSessionToken;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static int ExecuteCloudScriptCount;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static int ExecuteCloudScriptLastProcessed;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static int OutOfOrderCounter;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.LogEventHandler logEventHandler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.LogEventErrorHandler LogEventErrorHandler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.NetworkAvailabilityCheckers.NetworkAvailabilityChecker networkAvailabilityChecker;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Systems.Server.PFCouponRedeemer couponRedeemer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.HeartbeatDispatcher heartbeatDispatcher;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.PlayerAnimatronicDataLoader playerAnimatronicDataLoader;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.AttackModeLostRequester attackModeLostRequester;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.NextAnimatronicRequester nextAnimatronicRequester;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.AnimatronicEntitySaveRequester animatronicEntitySaveRequester;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.EntityRewardRequester entityRewardRequester;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.ScavengeRequester scavengeRequester;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.RecallScavengeRequester recallScavengeRequester;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.PlayerWorkshopDataLoader playerWorkshopDataLoader;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.SetEndoskeletonConfigRequester endoskeletonConfigRequester;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.RepairAnimatronicRequester repairAnimatronicRequester;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.ServerDataRequester serverDataRequester;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.PlayerDataRequester playerDataRequester;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.SellModsRequester sellModsRequester;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.SendScavengeAnimatronicV2Requester sendScavengeAnimatronicV2Requester;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.StartEssenceEncounterRequester startEssenceEncounterRequester;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.EssenceNodeCollectRequester essenceNodeCollectRequester;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.EssenceNodeSpawnRequester essenceNodeSpawnRequester;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.DeviceRequester deviceRequester;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.TutorialRequester tutorialRequester;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.RemoveEntityRequester removeEntityRequester;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.AnimatronicDataByIDRequester animatronicDataByIdRequester;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.Inbox.GetInboxMessagesRequster getInboxMessagesRequester;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.Inbox.MarkInboxMessageRequester markInboxMessageRequester;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.Inbox.RemoveInboxMessageRequester removeInboxMessageRequester;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.Inbox.BatchInboxRequester batchInboxRequester;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.Inbox.SendInboxAlertMessageRequester sendInboxAlertMessageRequester;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.GetSocialInviteSendPayloadRequester getSocialInviteSendPayloadRequester;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.GetSocialInviteQueryPayloadRequester getSocialInviteQueryPayloadRequester;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.Requester.GetSocialInviteResultRequester getSocialInviteResultRequester;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.Requester.GetSocialAuthenticationRequester getSocialAuthenticationRequester;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.IAPRequester iapRequester;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.VirtualGoodsListRequester virtualGoodsListRequester;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.AvatarSaveRequester avatarSaveRequester;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.SendAnimatronicV2Requester sendAnimatronicV2Requester;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.RecallAttackingAnimatronicRequester recallAttackingAnimatronicRequester;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.Requester.RegisterForPushNotificationsRequester registerForPushNotificationsRequester;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.Requester.GetPlayerFriendsRequester getPlayerFriendsRequester;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.Requester.UpdatePlayerFriendsRequester updatePlayerFriendsRequester;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.Requester.RemoveFriendRequester removeFriendRequester;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.ExpressDeliveryRequester expressDeliveryRequester;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.Inbox.RemnantLevelUpAlertRequester remnantLevelUpAlertRequester;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.GetOwnedGoodsRequester getOwnedGoodsRequester;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.FriendCodeRequester friendCodeRequester;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.HeartbeatRequester heartbeatRequester;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.SequentialRewardRequester sequentialRewardRequester;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.DailyChallengeDataRequester dailyChallengeDataRequester;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.CollectDailyChallengeRewardsRequester collectDailyChallengeRewardsRequester;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.StreakDataResponseHandler streakDataResponseHandler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.AnimatronicStatsResponseHandler animatronicStatsResponseHandler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.AnimatronicEntityResponseHandler animatronicEntityResponseHandler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.NextUpdateTimeResponseHandler nextUpdateTimeResponseHandler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.NewAnimatronicResponseHandler newAnimatronicResponseHandler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.RewardsResponseHandler rewardsResponseHandler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.WorkshopDataResponseHandler WorkshopDataResponseHandler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.InventoryResponseHandler inventoryResponseHandler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.ModInventoryResponseHandler modInventoryResponseHandler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.AnimatronicEntityUpdateResponseHandler animatronicEntityUpdateResponseHandler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.CurrencyDataResponseHandler currencyDataResponseHandler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.RewardsV2ResponseHandler rewardsV2ResponseHandler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.WorkshopDataV2ResponseHandler WorkshopDataV2ResponseHandler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.CPUInventoryResponseHandler cpuInventoryResponseHandler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.ConfigDataResponseHandler configDataResponseHandler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.PlayerAlertDataResponseHandler playerAlertDataResponseHandler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.TimeResponseHandler timeResponseHandler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.PlayerEssenceDataResponseHandler playerEssenceDataResponseHandler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.EssencesToSpawnResponseHandler essencesToSpawnResponseHandler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.DeviceDataResponseHandler deviceDataResponseHandler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.PurchaseDataResponseHandler purchaseDataResponseHandler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.TutorialDataResponseHandler tutorialDataResponseHandler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.AnimatronicDataForIDResponseHandler animatronicDataForIdResponseHandler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.FeatureFlagsResponseHandler featureFlagsResponseHandler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.InboxResponseHandler inboxResponseHandler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.GetSocialInvitePayloadResponseHandler getSocialInvitePayloadResponseHandler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.GetSocialAuthenticationResponseHandler getSocialAuthenticationResponseHandler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.FriendsListResponseHandler friendsListResponseHandler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.FriendCodeResponseHandler friendCodeResponseHandler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.PurchasedSlotsResponseHandler purchasedSlotsResponseHandler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.PlayerStatsDataResponseHandler playerStatsDataResponseHandler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.PlayerGoodsResponseHandler playerGoodsResponseHandler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.PlayerProfileResponseHandler playerProfileResponseHandler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.UpdateAnimatronicEntitiesResponseHandler updateAnimatronicEntitiesResponseHandler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.HeartbeatPeriodResponseHandler heartbeatPeriodResponseHandler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.SeasonalEventDataResponseHandler seasonalEventDataResponseHandler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.VirtualGoodsListResponseHandler virtualGoodsListResponseHandler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.StoreIdChangedResponseHandler storeIdChangedResponseHandler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.PassiveRequestListResponseHandler passiveRequestListResponseHandler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.DailyChallengeDataResponseHandler dailyChallengeDataResponseHandler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.DailyChallengeRewardsResponseHandler dailyChallengeRewardsResponseHandler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DefaultNamespace.DebugCompleteDailyChallengeRequester debugCompleteDailyChallengeRequester;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.Requester.DailyChallenge.DebugDailyChallengeForceRefresh debugDailyChallengeForceRefresh;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.ServerChunkLoader serverChunkLoader;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update()
        {
            this.logEventHandler.FirePendingRequest();
            this.networkAvailabilityChecker.Update();
            this.heartbeatDispatcher.Update();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this.heartbeatDispatcher.Teardown();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ServerDomain()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static ServerDomain()
        {
            Game.Server.ServerDomain.CurrentServer = 2;
            Game.Server.ServerDomain.CatalogName = "Test";
            Game.Server.ServerDomain.StoreName = "Default";
            Game.Server.ServerDomain.CurrentSessionToken = "";
            Game.Server.ServerDomain.ExecuteCloudScriptCount = 0;
            Game.Server.ServerDomain.ExecuteCloudScriptLastProcessed = 0;
            Game.Server.ServerDomain.OutOfOrderCounter = 0;
        }
    
    }

}
