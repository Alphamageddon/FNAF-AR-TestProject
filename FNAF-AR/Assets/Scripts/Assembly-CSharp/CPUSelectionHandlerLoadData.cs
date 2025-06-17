using UnityEngine;

public struct CPUSelectionHandlerLoadData
{
	public CPUCell cpuCellPrefab;

	public Transform cpuCellParent;

	public GameAssetManagementDomain gameAssetManagementDomain;

	public ItemDefinitions itemDefinitions;

	public EventExposer eventExposer;

	public Inventory inventory;

	public WorkshopSlotDataModel workshopSlotDataModel;
}
