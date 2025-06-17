using System;

public class LootMasterDataConnector
{
	private LootContainer _lootContainer;

	public bool HasLootStructureDataLoaded { get; set; }

	public bool HasLootPackageDataLoaded { get; set; }

	public bool HasLootTableDataLoaded { get; set; }

	public bool HasLootItemDataLoaded { get; set; }

	public bool HasCrateInfoDataLoaded { get; set; }

	private event Action OnDataLoaded;

	public LootMasterDataConnector(MasterDataDomain masterDataDomain, LootContainer lootContainer, Action callback)
	{
		_lootContainer = lootContainer;
		masterDataDomain.GetAccessToData.GetLootStructureDataAsync(SetLootStructureData);
		masterDataDomain.GetAccessToData.GetLootPackageDataAsync(SetLootPackageData);
		masterDataDomain.GetAccessToData.GetLootTableDataAsync(SetLootTableData);
		masterDataDomain.GetAccessToData.GetLootItemDataAsync(SetLootItemData);
		masterDataDomain.GetAccessToData.GetCrateInfoAsync(SetCrateInfoData);
		OnDataLoaded += callback;
	}

	private void SetLootStructureData(LOOT_STRUCTURE_DATA.Root lootStructureData)
	{
		_lootContainer.LoadLootStructureDataFromMasterData(lootStructureData);
		HasLootStructureDataLoaded = true;
		this.OnDataLoaded?.Invoke();
	}

	private void SetLootPackageData(LOOT_PACKAGE_DATA.Root lootPackageData)
	{
		_lootContainer.LoadLootPackageDataFromMasterData(lootPackageData);
		HasLootPackageDataLoaded = true;
		this.OnDataLoaded?.Invoke();
	}

	private void SetLootTableData(LOOT_TABLE_DATA.Root lootTableData)
	{
		_lootContainer.LoadLootTableDataFromMasterData(lootTableData);
		HasLootTableDataLoaded = true;
		this.OnDataLoaded?.Invoke();
	}

	private void SetLootItemData(LOOT_ITEM_DATA.Root lootItemData)
	{
		_lootContainer.LoadLootItemDataFromMasterData(lootItemData);
		HasLootItemDataLoaded = true;
		this.OnDataLoaded?.Invoke();
	}

	private void SetCrateInfoData(CRATE_INFO_DATA.Root crateInfoData)
	{
		_lootContainer.LoadCrateInfoDataFromMasterData(crateInfoData);
		HasCrateInfoDataLoaded = true;
		this.OnDataLoaded?.Invoke();
	}
}
