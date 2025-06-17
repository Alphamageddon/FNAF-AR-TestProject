public class MapEntity
{
	private bool _synchronizeOnServer;

	private bool _hideOnMap;

	private MapEntitySynchronizeableState _synchronizeableState;

	private IMapEntityInteraction _interactionController;

	private static readonly string _commonKeysCpu = "Cpu";

	private static readonly string _commonKeysPlushSuit = "PlushSuit";

	public MapEntitySynchronizeableState SynchronizeableState
	{
		get
		{
			return _synchronizeableState;
		}
		set
		{
			_synchronizeableState = value;
		}
	}

	public string EntityId => _synchronizeableState.entityId;

	public bool SynchronizeOnServer => _synchronizeOnServer;

	public bool HideOnMap
	{
		get
		{
			return _hideOnMap;
		}
		set
		{
			_hideOnMap = value;
		}
	}

	public IMapEntityInteraction InteractionController => _interactionController;

	public string CPUId
	{
		get
		{
			if (_synchronizeableState.parts != null && _synchronizeableState.parts.ContainsKey(_commonKeysCpu))
			{
				return _synchronizeableState.parts[_commonKeysCpu];
			}
			return null;
		}
	}

	public string PlushSuitId
	{
		get
		{
			if (_synchronizeableState.parts != null && _synchronizeableState.parts.ContainsKey(_commonKeysPlushSuit))
			{
				return _synchronizeableState.parts[_commonKeysPlushSuit];
			}
			return null;
		}
	}

	public float LocalSpawnTime { get; set; }

	public float LocalRemoveTime { get; set; }

	public void ReplaceRemoveTime(float newTime)
	{
		LocalRemoveTime = newTime;
	}

	public MapEntity(MapEntitySynchronizeableState synchronizeableState, bool synchronizeOnServer, IMapEntityInteraction interactionController)
	{
		_hideOnMap = false;
		_synchronizeableState = synchronizeableState;
		_synchronizeOnServer = synchronizeOnServer;
		_interactionController = interactionController;
	}
}
