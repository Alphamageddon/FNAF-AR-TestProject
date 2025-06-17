using System.Collections.Generic;

public class ServerDomainBuilder
{
	private readonly ServerDomain _serverDomain;

	public ServerDomainBuilder(MasterDomain masterDomain)
	{
		_serverDomain = masterDomain.ServerDomain;
		EventExposer eventExposer = masterDomain.eventExposer;
		NewResponseHandlers();
		InitializeLogEventHandler(masterDomain, eventExposer);
		InitializeRequesters(eventExposer, _serverDomain.logEventHandler);
		_serverDomain.MapEntityServerStateParser = new MapEntityServerStateParser();
		_serverDomain.ScavengingEntityServerStateParser = new ScavengingEntityServerStateParser();
		_serverDomain.networkAvailabilityChecker = new NetworkAvailabilityChecker(eventExposer);
	}

	public void SetupDomain(MasterDomain masterDomain)
	{
		SetupResponseHandlers(masterDomain);
		SetupRequesters(masterDomain);
		_ = masterDomain.eventExposer;
	}

	private void InitializeRequesters(EventExposer eventExposer, LogEventHandler logEventHandler)
	{
		_serverDomain.endoskeletonConfigRequester = new SetEndoskeletonConfigRequester(logEventHandler);
		_serverDomain.playerDataRequester = new PlayerDataRequester(logEventHandler);
		_serverDomain.sellModsRequester = new SellModsRequester(logEventHandler);
		_serverDomain.iapRequester = new IAPRequester(_serverDomain.logEventHandler, eventExposer, _serverDomain.CreatePurchaseItemRequest(), _serverDomain.CreateValidatePurchaseReceiptRequest());
		_serverDomain.virtualGoodsListRequester = new VirtualGoodsListRequester(logEventHandler);
		_serverDomain.getOwnedGoodsRequester = new GetOwnedGoodsRequester(logEventHandler);
		_serverDomain.avatarSaveRequester = new AvatarSaveRequester(logEventHandler);
		_serverDomain.sendAnimatronicV2Requester = new SendAnimatronicV2Requester(logEventHandler);
		_serverDomain.recallAttackingAnimatronicRequester = new RecallAttackingAnimatronicRequester(logEventHandler);
		_serverDomain.getPlayerFriendsRequester = new GetPlayerFriendsRequester(logEventHandler);
		_serverDomain.updatePlayerFriendsRequester = new UpdatePlayerFriendsRequester(logEventHandler);
		_serverDomain.removeFriendRequester = new RemoveFriendRequester(logEventHandler);
		_serverDomain.friendCodeRequester = new FriendCodeRequester(logEventHandler);
		_serverDomain.mapEntityJamRequester = new MapEntityJamRequester(logEventHandler);
		_serverDomain.mapEntityInteractionFinishedRequester = new MapEntityInteractionFinishedRequester(logEventHandler);
		_serverDomain.mapEntityEncounterWonRequester = new MapEntityEncounterWonRequester(logEventHandler);
		_serverDomain.mapEntityEncounterLostRequester = new MapEntityEncounterLostRequester(logEventHandler);
		_serverDomain.mapEntityScanAndRetireEntitiesRequester = new MapEntityScanAndRetireEntitiesRequester(logEventHandler);
		_serverDomain.mapEntityEncounterLeftRequester = new MapEntityEncounterLeftRequester(logEventHandler);
		_serverDomain.grantItemRequester = new GrantItemRequester(logEventHandler);
		_serverDomain.toggleFriendSendsRequester = new ToggleFriendSendsRequester(logEventHandler);
		_serverDomain.toggleFriendAddsRequester = new ToggleFriendAddsRequester(logEventHandler);
		_serverDomain.scavengingEntityRetireEntitiesRequester = new ScavengingEntityRetireEntitiesRequester(logEventHandler);
	}

	private void SetupRequesters(MasterDomain masterDomain)
	{
	}

	private void NewResponseHandlers()
	{
		_serverDomain.streakDataResponseHandler = new StreakDataResponseHandler();
		_serverDomain.inventoryResponseHandler = new InventoryResponseHandler();
		_serverDomain.modInventoryResponseHandler = new ModInventoryResponseHandler();
		_serverDomain.currencyDataResponseHandler = new CurrencyDataResponseHandler();
		_serverDomain.WorkshopDataV2ResponseHandler = new WorkshopDataV2ResponseHandler();
		_serverDomain.cpuInventoryResponseHandler = new CPUInventoryResponseHandler();
		_serverDomain.friendsListResponseHandler = new FriendsListResponseHandler();
		_serverDomain.friendCodeResponseHandler = new FriendCodeResponseHandler();
		_serverDomain.playerGoodsResponseHandler = new PlayerGoodsResponseHandler();
		_serverDomain.playerProfileResponseHandler = new PlayerProfileResponseHandler();
		_serverDomain.virtualGoodsListResponseHandler = new VirtualGoodsListResponseHandler();
		_serverDomain.playerAvatarResponseHandler = new PlayerAvatarResponseHandler();
		_serverDomain.playerStoreDataResponseHandler = new PlayerStoreDataResponseHandler();
		_serverDomain.mapEntityResponseHandler = new MapEntityResponseHandler();
		_serverDomain.crateRewardResponseHandler = new CrateRewardResponseHandler();
		_serverDomain.trophyInventoryResponseHandler = new TrophyInventoryResponseHandler();
		_serverDomain.scavengingEntityResponseHandler = new ScavengingEntityResponseHandler();
	}

	private void SetupResponseHandlers(MasterDomain masterDomain)
	{
		_serverDomain.streakDataResponseHandler.Setup(masterDomain.eventExposer);
		_serverDomain.mapEntityResponseHandler.Setup(_serverDomain.MapEntityServerStateParser.Parse, masterDomain.eventExposer.OnMapEntitiesReceivedFromServer);
		_serverDomain.inventoryResponseHandler.Setup(masterDomain.eventExposer.OnInventoryUpdated);
		_serverDomain.modInventoryResponseHandler.Setup(masterDomain.eventExposer.OnModInventoryUpdated);
		_serverDomain.currencyDataResponseHandler.Setup(masterDomain.eventExposer.OnPlayerCurrencyRefreshed);
		_serverDomain.WorkshopDataV2ResponseHandler.Setup(masterDomain.eventExposer.OnWorkshopDataV2Updated, ServerProcessors.ProcessWorkshopDataEntry);
		_serverDomain.cpuInventoryResponseHandler.Setup(masterDomain.eventExposer.OnCPUInventoryUpdated);
		_serverDomain.virtualGoodsListResponseHandler.Setup(masterDomain.eventExposer.OnVirtualGoodsDataReceived);
		_serverDomain.friendsListResponseHandler.Setup(masterDomain.eventExposer.OnFriendListUpdated);
		_serverDomain.friendCodeResponseHandler.Setup(masterDomain.eventExposer.OnPersonalFriendCodeUpdated, masterDomain.eventExposer.OnFriendCodeLookedUp);
		_serverDomain.playerGoodsResponseHandler.Setup(masterDomain.eventExposer.OnPlayerGoodsUpdated, ServerProcessors.ProcessPlayerGoods);
		_serverDomain.playerProfileResponseHandler.Setup(masterDomain.TheGameDomain.loginDomain.playerProfileUpdater);
		_serverDomain.playerAvatarResponseHandler.Setup(masterDomain.eventExposer.OnPlayerAvatarUnlockedListReceived);
		_serverDomain.playerStoreDataResponseHandler.Setup(masterDomain.eventExposer.OnPlayerStoreDataUpdated);
		_serverDomain.crateRewardResponseHandler.Setup(masterDomain.eventExposer.OnLootRewardProcessed);
		_serverDomain.trophyInventoryResponseHandler.Setup(masterDomain.eventExposer.OnTrophyInventoryUpdated);
		_serverDomain.scavengingEntityResponseHandler.Setup(_serverDomain.ScavengingEntityServerStateParser.Parse, masterDomain.eventExposer.OnScavengingEntitiesReceivedFromServer);
	}

	private void InitializeLogEventHandler(MasterDomain masterDomain, EventExposer eventExposer)
	{
		HashSet<EventResponseHandler> hashSet = new HashSet<EventResponseHandler>();
		hashSet.Add(_serverDomain.streakDataResponseHandler);
		hashSet.Add(_serverDomain.inventoryResponseHandler);
		hashSet.Add(_serverDomain.modInventoryResponseHandler);
		hashSet.Add(_serverDomain.currencyDataResponseHandler);
		hashSet.Add(_serverDomain.WorkshopDataV2ResponseHandler);
		hashSet.Add(_serverDomain.cpuInventoryResponseHandler);
		hashSet.Add(_serverDomain.friendsListResponseHandler);
		hashSet.Add(_serverDomain.friendCodeResponseHandler);
		hashSet.Add(_serverDomain.playerGoodsResponseHandler);
		hashSet.Add(_serverDomain.playerProfileResponseHandler);
		hashSet.Add(_serverDomain.virtualGoodsListResponseHandler);
		hashSet.Add(_serverDomain.playerAvatarResponseHandler);
		hashSet.Add(_serverDomain.playerStoreDataResponseHandler);
		hashSet.Add(_serverDomain.mapEntityResponseHandler);
		hashSet.Add(_serverDomain.crateRewardResponseHandler);
		hashSet.Add(_serverDomain.trophyInventoryResponseHandler);
		hashSet.Add(_serverDomain.scavengingEntityResponseHandler);
		_serverDomain.logEventHandler = new LogEventHandler(hashSet, eventExposer, masterDomain.ServerDomain.CreateQueueExecuteScriptRequest());
	}
}
