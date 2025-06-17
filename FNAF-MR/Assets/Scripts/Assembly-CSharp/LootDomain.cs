public class LootDomain
{
	private LootMasterDataConnector _masterDataConnector;

	private PseudoRandom _prng;

	private WorkshopDomain _workshopDomain;

	private EventExposer _exposer;

	private ServerDomain _serverDomain;

	public LootContainer LootContainer { get; set; }

	public CrateOpener CrateOpener { get; set; }

	public LootRewardsManager LootRewardsManager { get; set; }

	protected bool IsReady { get; set; }

	public LootDomain(EventExposer exposer, WorkshopDomain workshopDomain, ServerDomain serverDomain)
	{
		IsReady = false;
		PseudoRandom prng = new PseudoRandom();
		_prng = prng;
		_prng.SetSeed(456);
		_exposer = exposer;
		_workshopDomain = workshopDomain;
		_serverDomain = serverDomain;
		LootContainer = new LootContainer();
		LootRewardsManager = new LootRewardsManager(exposer);
		CrateOpener = new CrateOpener(LootContainer, _prng);
	}

	public void Setup(MasterDataDomain masterDataDomain)
	{
		_masterDataConnector = new LootMasterDataConnector(masterDataDomain, LootContainer, TryToDispatchPublicInterface);
	}

	public void Teardown()
	{
		LootContainer = null;
		_prng = null;
		LootRewardsManager.Teardown();
		_masterDataConnector = null;
		CrateOpener = null;
		LootRewardsManager = null;
	}

	public void OpenCrate(string CrateId, EligibilityContext context)
	{
	}

	public string GetCrateInfoForCrateId(string crateId, EligibilityContext context)
	{
		LootStructureData lootStructureForId = LootContainer.GetLootStructureForId(crateId);
		if (lootStructureForId == null)
		{
			return null;
		}
		return CrateOpener.SelectPackageFromCrate(lootStructureForId, context).CrateInfo;
	}

	private void TryToDispatchPublicInterface()
	{
		if (_masterDataConnector.HasLootStructureDataLoaded && _masterDataConnector.HasLootPackageDataLoaded && _masterDataConnector.HasLootTableDataLoaded && _masterDataConnector.HasLootItemDataLoaded && _masterDataConnector.HasCrateInfoDataLoaded)
		{
			IsReady = true;
		}
	}
}
