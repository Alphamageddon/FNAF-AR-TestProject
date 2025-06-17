using UnityEngine;

public struct GameUIData
{
	public ServerGameUIDataModel serverGameUIDataModel { get; set; }

	public WorkshopSlotDataModel workshopSlotDataModel { get; set; }

	public ResultsDataModel rewardDataModel { get; set; }

	public string storeScrollSection { get; set; }

	public string storeScrollItem { get; set; }

	public GameUIMasterDataConnector gameUIMasterDataConnector { get; set; }

	public FriendCodeModel friendCodeModel { get; set; }

	public PlayerAvatarDataModel playerAvatarDataModel { get; set; }

	public GameUIData(MasterDomain masterDomain, MonoBehaviour coroutineHost)
	{
		WorkshopSlotDataModelLoadData data = default(WorkshopSlotDataModelLoadData);
		data.EventExposer = masterDomain.eventExposer;
		data.ItemDefinitionDomain = masterDomain.ItemDefinitionDomain;
		data.Container = masterDomain.AnimatronicEntityDomain.container;
		workshopSlotDataModel = new WorkshopSlotDataModel(data);
		rewardDataModel = new ResultsDataModel(masterDomain);
		friendCodeModel = new FriendCodeModel(masterDomain);
		storeScrollSection = "";
		storeScrollItem = "";
		serverGameUIDataModel = new ServerGameUIDataModel(masterDomain);
		playerAvatarDataModel = new PlayerAvatarDataModel(masterDomain.eventExposer);
		gameUIMasterDataConnector = new GameUIMasterDataConnector(masterDomain.MasterDataDomain);
	}
}
