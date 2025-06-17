public class ItemDefinitionDomain
{
	private EventExposer _eventExposer;

	private MasterDataConnector _masterDataConnector;

	private EventExposer eventExposer;

	public ItemDefinitions ItemDefinitions { get; set; }

	protected bool IsReady
	{
		get
		{
			if (_masterDataConnector.HaveCpusLoaded && _masterDataConnector.HavePlushSuitsLoaded && _masterDataConnector.HaveAttackProfilesLoaded)
			{
				return true;
			}
			return false;
		}
	}

	protected ItemDefinitionDomain GetPublicInterface => this;

	public ItemDefinitionDomain(EventExposer eventExposer, MasterDataDomain masterDataDomain)
	{
		_eventExposer = eventExposer;
		ItemDefinitions = new ItemDefinitions();
		_masterDataConnector = new MasterDataConnector(masterDataDomain, ItemDefinitions);
	}

	public void Setup()
	{
	}

	public void Teardown()
	{
		_eventExposer = null;
		_masterDataConnector = null;
	}
}
