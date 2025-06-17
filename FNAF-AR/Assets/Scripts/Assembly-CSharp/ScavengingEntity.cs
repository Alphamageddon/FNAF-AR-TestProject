public class ScavengingEntity
{
	private bool _synchronizeOnServer;

	private ScavengingEntitySynchronizeableState _synchronizeableState;

	private static readonly string _commonKeysCpu;

	private static readonly string _commonKeysPlushSuit;

	public ScavengingEntitySynchronizeableState SynchronizeableState
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

	public ScavengingEntity(ScavengingEntitySynchronizeableState synchronizeableState, bool synchronizeOnServer)
	{
		_synchronizeableState = synchronizeableState;
		_synchronizeOnServer = synchronizeOnServer;
	}

	static ScavengingEntity()
	{
		_commonKeysCpu = "Cpu";
		_commonKeysPlushSuit = "PlushSuit";
	}
}
