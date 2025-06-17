using System.Collections.Generic;

public class Inventory
{
	public const string LOADOUT_EMPTY_SLOT = "Empty";

	private WorkshopData _workshopData;

	private WorkshopDomain _workshopDomain;

	private ModInventory _modInventory;

	private CPUInventory _cpuInventory;

	private CurrencyContainer _currencyContainer;

	private ItemDefinitions _itemDefinitions;

	private TrophyInventory _trophyInventory;

	public WorkshopData WorkshopData => _workshopData;

	public ModInventory ModInventory => _modInventory;

	public CPUInventory CpuInventory => _cpuInventory;

	public CurrencyContainer CurrencyContainer => _currencyContainer;

	public TrophyInventory TrophyInventory => _trophyInventory;

	public Inventory(WorkshopDomain workshopDomain, ItemDefinitionDomain itemDefinitionDomain)
	{
		_workshopDomain = workshopDomain;
		_currencyContainer = new CurrencyContainer();
		_workshopDomain.eventExposer.add_WorkshopDataV2Updated(OnWorkshopDataUpdated);
		_workshopDomain.eventExposer.add_ModInventoryUpdated(OnModInventoryUpdated);
		_workshopDomain.eventExposer.add_CPUInventoryUpdated(OnCPUInventoryUpdated);
		_workshopDomain.eventExposer.add_PlayerCurrencyRefreshed(OnCurrencyRefreshed);
		_workshopDomain.eventExposer.add_TrophyInventoryUpdated(OnTrophyInventoryUpdated);
		Callback(itemDefinitionDomain);
	}

	private void Callback(ItemDefinitionDomain itemDefinitionDomain)
	{
		_itemDefinitions = itemDefinitionDomain.ItemDefinitions;
		if (_modInventory != null)
		{
			_modInventory.UpdateFromLookup(itemDefinitionDomain.ItemDefinitions);
		}
	}

	private void OnModInventoryUpdated(ModInventory obj)
	{
		_modInventory = obj;
		UpdateModInventory();
	}

	private void UpdateModInventory()
	{
		if (_itemDefinitions != null && _modInventory != null)
		{
			_modInventory.UpdateFromLookup(_itemDefinitions);
		}
	}

	public void AddModById(string modId, int num)
	{
		ModData modById = _itemDefinitions.GetModById(modId);
		if (modById != null)
		{
			_modInventory.AddMod(modById, num);
		}
	}

	private void OnWorkshopDataUpdated(WorkshopData data)
	{
		_workshopData = data;
	}

	private void OnCPUInventoryUpdated(CPUInventory data)
	{
		_cpuInventory = data;
	}

	private void OnTrophyInventoryUpdated(TrophyInventory data)
	{
		_trophyInventory = data;
	}

	private void OnCurrencyRefreshed(Dictionary<string, int> currencies)
	{
		_currencyContainer.SetFazTokens(currencies["FAZ_TOKENS"]);
		_currencyContainer.SetParts(currencies["PARTS"]);
		_currencyContainer.UpdateEssence(currencies["ESSENCE"]);
		_currencyContainer.SetEventCurrency(currencies["EVENT_CURRENCY"]);
	}
}
