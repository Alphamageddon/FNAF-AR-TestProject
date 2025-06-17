using UnityEngine;

public class CameraEquipmentDomain
{
	private BatteryState _battery;

	private FlashlightState _flashlight;

	private MaskState _mask;

	private ShockerState _shocker;

	private ItemDefinitionDomain _itemDefinitionDomain;

	private EventExposer _eventExposer;

	private SceneLookupTableAccess _sceneLookupTableAccess;

	private bool addedCallback;

	private CameraSceneLookupTable lookupTable;

	public IBattery Battery => _battery;

	public IFlashlight Flashlight => _flashlight;

	public IMask Mask => _mask;

	public IShocker Shocker => _shocker;

	public void Update()
	{
		if (_shocker != null)
		{
			_shocker.Update();
		}
		if (_flashlight != null)
		{
			_flashlight.Update();
		}
		if (_battery != null)
		{
			_battery.Update();
		}
	}

	public void Setup(SceneLookupTableAccess sceneLookupTableAccess, EventExposer masterEventExposer, MasterDataDomain masterDataDomain, ItemDefinitionDomain itemDefinitionDomain)
	{
		_eventExposer = masterEventExposer;
		_itemDefinitionDomain = itemDefinitionDomain;
		_battery = new BatteryState(masterEventExposer);
		_mask = new MaskState(masterEventExposer);
		_flashlight = new FlashlightState(masterEventExposer, _battery, _mask);
		_shocker = new ShockerState(masterEventExposer, _battery);
		masterDataDomain.GetAccessToData.GetConfigDataEntryAsync(ConfigDataReady);
		_eventExposer.add_AnimatronicEncounterStarted(ResetForEncounter);
		_eventExposer.add_AnimatronicScavengingEncounterStarted(ResetForScavengingEncounter);
		_sceneLookupTableAccess = sceneLookupTableAccess;
		masterEventExposer.add_GameDisplayChange(GameDisplayOrtonChange);
	}

	private void GameDisplayOrtonChange(GameDisplayData yeah)
	{
		Debug.LogWarning("GAME DISPLAY CHANGE SEEN!");
		if ((yeah.currentDisplay == GameDisplayData.DisplayType.camera || yeah.currentDisplay == GameDisplayData.DisplayType.scavengingui) && lookupTable == null)
		{
			_sceneLookupTableAccess.GetCameraSceneLookupTableAsync(CameraSceneLookupTableReady);
		}
	}

	private void CameraSceneLookupTableReady(CameraSceneLookupTable cameraSceneLookupTable)
	{
		lookupTable = cameraSceneLookupTable;
		Debug.LogError("CAM EQUIPMENT DOMAIN HAS FOUND CAMERA SCENE LOOKUP");
		_flashlight.SetFxRoot(cameraSceneLookupTable.FlashlightFxController);
		_mask.SetFxController(cameraSceneLookupTable.MaskController);
		_shocker.SetFxRoot(cameraSceneLookupTable.ShockerFxController);
	}

	private void ConfigDataReady(CONFIG_DATA.Root configDataEntry)
	{
		if (configDataEntry != null && _battery != null)
		{
			_battery.SetConfigData(configDataEntry.Entries[0].BatteryBehavior);
		}
	}

	public void Teardown()
	{
		Debug.Log("CAM EQUIPMENT DOMAIN TEARDOWN");
		_shocker.Teardown();
		_shocker = null;
		_flashlight.Teardown();
		_flashlight = null;
		_battery.Teardown();
		_battery = null;
		_eventExposer.remove_AnimatronicEncounterStarted(ResetForEncounter);
		_eventExposer.remove_AnimatronicScavengingEncounterStarted(ResetForScavengingEncounter);
		_eventExposer = null;
	}

	public void ResetForEncounter(MapEntity entity)
	{
	}

	public void ResetForScavengingEncounter(ScavengingEntity entity)
	{
	}
}
