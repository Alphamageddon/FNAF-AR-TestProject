using UnityEngine;

public class MasterDomain
{
	private EventExposer _eventExposer;

	private GameUnityHooks _unityHooks;

	public Animatronic3DDomain Animatronic3DDomain;

	public AnimatronicEntityDomain AnimatronicEntityDomain;

	public AttackSequenceDomain AttackSequenceDomain;

	public CameraEquipmentDomain CameraEquipmentDomain;

	public GameAudioDomain GameAudioDomain;

	public GameAssetManagementDomain GameAssetManagementDomain;

	public DialogDomain DialogDomain;

	public GameUIDomain GameUIDomain;

	public ItemDefinitionDomain ItemDefinitionDomain;

	public LocalizationDomain LocalizationDomain;

	public MapEntityDomain MapEntityDomain;

	public MasterDataDomain MasterDataDomain;

	public PlayerAvatarDomain PlayerAvatarDomain;

	public ServerDomain ServerDomain;

	public StoreDomain StoreDomain;

	public TheGameDomain TheGameDomain;

	public MasterDomainUpdateHandler UpdateHandler;

	public WorkshopDomain WorkshopDomain;

	public LootDomain LootDomain;

	public ScavengingEntityDomain ScavengingEntityDomain;

	public EventExposer eventExposer => _eventExposer;

	public SkyboxSceneConfig SkyboxConfigs => _unityHooks.SkyboxConfigs;

	public GameObject AfterTosAccept => _unityHooks.AfterTosAccept;

	public SceneLookupTableAccess SceneLookupTableAccess => _unityHooks.SceneLookupTableAccess;

	public MasterDomain(EventExposer eventExposer, GameUnityHooks unityHooks)
	{
		_eventExposer = eventExposer;
		_unityHooks = unityHooks;
	}

	public static MasterDomain GetDomain()
	{
		return GameLifecycleProxy.GetMasterDomain();
	}
}
