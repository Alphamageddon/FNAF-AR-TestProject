public class MapEntitySpecialDeliveryInteractionController : IMapEntityInteraction
{
	private readonly EventExposer _eventExposer;

	private MapEntityInteractionMutex _interactionMutex;

	public MapEntitySpecialDeliveryInteractionController(EventExposer eventExposer, MapEntityInteractionMutex interactionMutex)
	{
		_eventExposer = eventExposer;
		_interactionMutex = interactionMutex;
	}

	public void OnInteract(MapEntity entity)
	{
		if (_interactionMutex.AllowNewInteractions)
		{
			_interactionMutex.OnInteractionDisplayWillOpen();
			_eventExposer.OnEntitySpecialDeliveryDisplayRequestReceived(new EntityDisplayData
			{
				entity = entity,
				eventExposer = _eventExposer,
				interactionMutex = _interactionMutex,
				onConfirmStandardAction = TriggerEncounter,
				onDismiss = DismissEncounter
			});
		}
	}

	public void TriggerEncounter(MapEntity entity)
	{
		entity.HideOnMap = true;
		_eventExposer.OnOrtonEncounterMapEntityChosen(entity);
	}

	public void DismissEncounter(MapEntity entity)
	{
		entity.HideOnMap = true;
		_eventExposer.OnMapEntityInteractionFinished(entity, giveRewards: false);
	}
}
