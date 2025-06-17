public class MapEntityDummyInteractionController : IMapEntityInteraction
{
	private readonly ServerDomain _serverDomain;

	private MapEntityInteractionMutex _interactionMutex;

	private readonly EventExposer _eventExposer;

	public MapEntityDummyInteractionController(ServerDomain serverDomain, MapEntityInteractionMutex interactionMutex, EventExposer eventExposer)
	{
		_interactionMutex = interactionMutex;
		_eventExposer = eventExposer;
		_serverDomain = serverDomain;
	}

	public void OnInteract(MapEntity entity)
	{
		_ = _interactionMutex.AllowNewInteractions;
	}

	private void FinishInteraction(MapEntity entity)
	{
		_eventExposer.OnMapEntityInteractionFinished(entity, giveRewards: false);
	}

	private void ScanEntity(MapEntity entity)
	{
		_ = entity.SynchronizeOnServer;
	}
}
