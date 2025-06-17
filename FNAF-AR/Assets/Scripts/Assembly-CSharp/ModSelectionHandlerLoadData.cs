using System;
using TMPro;
using UnityEngine;

public struct ModSelectionHandlerLoadData
{
	public ModCell cellPrefab;

	public Transform plushSuitCellParent;

	public Action<ModCell> SellDialog;

	public Action InvalidModCategoryDialog;

	public GameObject noModsLabel;

	public TextMeshProUGUI modCountText;

	public TextMeshProUGUI modsTotalCountText;

	public WorkshopSlotDataModel workshopSlotDataModel;

	public GameUIMasterDataConnector dataConnector;

	public ModInventory modInventory;

	public SellModsRequester sellModsRequester;

	public EventExposer eventExposer;

	public GameAssetManagementDomain gameAssetManagementDomain;

	public ServerGameUIDataModel ServerGameUiDataModel;
}
