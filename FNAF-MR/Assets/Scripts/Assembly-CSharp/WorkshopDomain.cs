public class WorkshopDomain
{
	private EventExposer _eventExposer;

	private Inventory _inventory;

	public EventExposer eventExposer => _eventExposer;

	public Inventory Inventory => _inventory;

	public WorkshopDomain(EventExposer exposer)
	{
		_eventExposer = exposer;
	}

	public void Setup(ItemDefinitionDomain itemDefinitionDomain)
	{
		_inventory = new Inventory(this, itemDefinitionDomain);
	}

	public void Teardown()
	{
		_eventExposer = null;
		_inventory = null;
	}
}
