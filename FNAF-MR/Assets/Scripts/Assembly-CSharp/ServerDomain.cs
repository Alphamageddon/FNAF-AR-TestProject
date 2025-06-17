using PlayFab;

public class ServerDomain
{
	public static PlayFabAuthenticationContext AuthContext;

	public static IllumixAuthenticationContext IllumixAuthContext;

	public static string CatalogName;

	public static string StoreName;

	public static string CurrentSessionToken;

	public static int ExecuteCloudScriptCount;

	public static int ExecuteCloudScriptLastProcessed;

	public static int OutOfOrderCounter;

	public LogEventHandler logEventHandler;

	public NetworkAvailabilityChecker networkAvailabilityChecker;

	public SetEndoskeletonConfigRequester endoskeletonConfigRequester;

	public PlayerDataRequester playerDataRequester;

	public SellModsRequester sellModsRequester;

	public IAPRequester iapRequester;

	public VirtualGoodsListRequester virtualGoodsListRequester;

	public AvatarSaveRequester avatarSaveRequester;

	public SendAnimatronicV2Requester sendAnimatronicV2Requester;

	public RecallAttackingAnimatronicRequester recallAttackingAnimatronicRequester;

	public GetPlayerFriendsRequester getPlayerFriendsRequester;

	public UpdatePlayerFriendsRequester updatePlayerFriendsRequester;

	public RemoveFriendRequester removeFriendRequester;

	public GetOwnedGoodsRequester getOwnedGoodsRequester;

	public FriendCodeRequester friendCodeRequester;

	public MapEntityJamRequester mapEntityJamRequester;

	public MapEntityInteractionFinishedRequester mapEntityInteractionFinishedRequester;

	public MapEntityEncounterWonRequester mapEntityEncounterWonRequester;

	public MapEntityEncounterLostRequester mapEntityEncounterLostRequester;

	public MapEntityScanAndRetireEntitiesRequester mapEntityScanAndRetireEntitiesRequester;

	public GrantItemRequester grantItemRequester;

	public MapEntityEncounterLeftRequester mapEntityEncounterLeftRequester;

	public ToggleFriendSendsRequester toggleFriendSendsRequester;

	public ToggleFriendAddsRequester toggleFriendAddsRequester;

	public ScavengingEntityRetireEntitiesRequester scavengingEntityRetireEntitiesRequester;

	public StreakDataResponseHandler streakDataResponseHandler;

	public InventoryResponseHandler inventoryResponseHandler;

	public ModInventoryResponseHandler modInventoryResponseHandler;

	public CurrencyDataResponseHandler currencyDataResponseHandler;

	public WorkshopDataV2ResponseHandler WorkshopDataV2ResponseHandler;

	public CPUInventoryResponseHandler cpuInventoryResponseHandler;

	public FriendsListResponseHandler friendsListResponseHandler;

	public FriendCodeResponseHandler friendCodeResponseHandler;

	public PlayerGoodsResponseHandler playerGoodsResponseHandler;

	public PlayerProfileResponseHandler playerProfileResponseHandler;

	public VirtualGoodsListResponseHandler virtualGoodsListResponseHandler;

	public PlayerAvatarResponseHandler playerAvatarResponseHandler;

	public PlayerStoreDataResponseHandler playerStoreDataResponseHandler;

	public MapEntityResponseHandler mapEntityResponseHandler;

	public CrateRewardResponseHandler crateRewardResponseHandler;

	public TrophyInventoryResponseHandler trophyInventoryResponseHandler;

	public ScavengingEntityResponseHandler scavengingEntityResponseHandler;

	public MapEntityServerStateParser MapEntityServerStateParser;

	public ScavengingEntityServerStateParser ScavengingEntityServerStateParser;

	private readonly PlayFabExecuteScriptRequest baseRequester;

	private readonly ExecuteCloudScriptLimiter secondsLimiter;

	public void Update()
	{
		logEventHandler.Update();
		networkAvailabilityChecker.Update();
	}

	public void Update(float timeElapsed)
	{
		secondsLimiter.Update(timeElapsed);
	}

	public IExecuteScriptRequest CreateQueueExecuteScriptRequest()
	{
		return new ExecuteScriptQueue(secondsLimiter);
	}

	public IPurchaseItemRequest CreatePurchaseItemRequest()
	{
		return new PlayFabPurchaseItemRequest(PlayFabClientAPI.PurchaseItem);
	}

	public IValidatePurchaseReceiptRequest CreateValidatePurchaseReceiptRequest()
	{
		return new PlayFabValidatePurchaseReceiptRequest(PlayFabClientAPI.ValidateGooglePlayPurchase);
	}

	public IUpdateUserTitleDisplayNameRequest CreateUpdateUserTitleDisplayNameRequest()
	{
		return new PlayFabUpdateUserTitleDisplayNameRequest(PlayFabClientAPI.UpdateUserTitleDisplayName);
	}

	public void Teardown()
	{
	}

	public ServerDomain()
	{
		baseRequester = new PlayFabExecuteScriptRequest(PlayFabClientAPI.ExecuteCloudScript);
		secondsLimiter = new ExecuteCloudScriptLimiter(10, 20f, baseRequester);
	}

	static ServerDomain()
	{
		CatalogName = "Test";
		StoreName = "Default";
		CurrentSessionToken = "";
		ExecuteCloudScriptCount = 0;
		ExecuteCloudScriptLastProcessed = 0;
		OutOfOrderCounter = 0;
	}
}
