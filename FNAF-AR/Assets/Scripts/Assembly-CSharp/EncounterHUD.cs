using System;
using System.Collections.Generic;
using UnityEngine;

public class EncounterHUD : IxSceneDisplay
{
	public enum HUDComponent
	{
		Shocker = 0,
		Flashlight = 1,
		Battery = 2,
		ExtraBattery = 3,
		Buff = 4,
		PlayerShield = 5,
		AnimatronicShield = 6,
		HaywireIndicator = 7
	}

	private CameraStateUIActions _actions;

	private AttackSequenceDomain _attackSequenceDomain;

	private CameraEquipmentDomain _cameraEquipmentDomain;

	private readonly Dictionary<HUDComponent, EncounterHUDComponent> _activeComponents;

	public Transform Transform => _root.transform;

	public EncounterHUD(GameObject mainCanvas)
		: base(mainCanvas)
	{
		_activeComponents = new Dictionary<HUDComponent, EncounterHUDComponent>();
	}

	public void UpdateRoot(GameObject root)
	{
		_root = root;
		_activeComponents.Clear();
		_root.SetActive(value: true);
	}

	public void Setup(AttackSequenceDomain attackSequenceDomain, CameraEquipmentDomain cameraEquipmentDomain, CameraStateUIActions actions)
	{
		_activeComponents.Clear();
		_actions = actions;
		_attackSequenceDomain = attackSequenceDomain;
		_cameraEquipmentDomain = cameraEquipmentDomain;
		_root.SetActive(value: true);
	}

	protected override void CacheAndPopulateComponents()
	{
		ComponentContainer components = new ComponentContainer();
		_components = components;
		Type[] onlyCacheTypes = new Type[1] { typeof(RectTransform) };
		_components.CacheComponents(_root, onlyCacheTypes);
	}

	public void InitializeShockerComponent()
	{
		GameObject gameObject = _components.TryGetComponent<RectTransform>("Button_Shocker").gameObject;
		if (gameObject == null)
		{
			Debug.LogError("EncounterHUD InitializeShockerComponent - The current HUD layout has no Shocker Component");
		}
		ShockerUIComponent shockerUIComponent = new ShockerUIComponent(gameObject);
		shockerUIComponent.Setup(_actions, _attackSequenceDomain, _cameraEquipmentDomain.Shocker);
		_activeComponents.Add(HUDComponent.Shocker, shockerUIComponent);
	}

	public void InitializeFlashlightComponent()
	{
		GameObject gameObject = _components.TryGetComponent<RectTransform>("Button_Flashlight").gameObject;
		if (gameObject == null)
		{
			Debug.LogError("EncounterHUD InitializeFlashlightComponent - The current HUD layout has no Flashlight Component");
		}
		FlashlightUIComponent flashlightUIComponent = new FlashlightUIComponent(gameObject);
		flashlightUIComponent.Setup(_actions, _attackSequenceDomain, _cameraEquipmentDomain.Flashlight);
		_activeComponents.Add(HUDComponent.Flashlight, flashlightUIComponent);
	}

	public void InitializeBatteryComponent(SurgeMechanicUIHandler surgeHandler, List<BatteryColorToValue> colorValues, Color surgeColor)
	{
		GameObject gameObject = _components.TryGetComponent<RectTransform>("BatteryPanel").gameObject;
		if (gameObject == null)
		{
			Debug.LogError("EncounterHUD InitializeBatteryComponent - The current HUD layout has no Battery Component");
		}
		BatteryUIComponent batteryUIComponent = new BatteryUIComponent(gameObject);
		batteryUIComponent.Setup(surgeHandler, colorValues, surgeColor, _attackSequenceDomain, _cameraEquipmentDomain.Battery);
		_activeComponents.Add(HUDComponent.Battery, batteryUIComponent);
	}

	public void InitializeHaywireIndicatorComponent()
	{
		GameObject gameObject = _components.TryGetComponent<RectTransform>("HaywireIndicator").gameObject;
		if (gameObject == null)
		{
			Debug.LogError("EncounterHUD InitializeHaywireIndicatorComponent - The current HUD layout has no Haywire Indicator Component");
		}
		HaywireIndicatorUIComponent haywireIndicatorUIComponent = new HaywireIndicatorUIComponent(gameObject);
		haywireIndicatorUIComponent.Setup(_attackSequenceDomain.GetHaywireIndicator());
		_activeComponents.Add(HUDComponent.HaywireIndicator, haywireIndicatorUIComponent);
	}

	public void Update()
	{
		foreach (EncounterHUDComponent value in _activeComponents.Values)
		{
			value.Update();
		}
	}

	public void UpdateVisibility()
	{
		foreach (EncounterHUDComponent value in _activeComponents.Values)
		{
			value.UpdateVisibility(_cameraEquipmentDomain.Mask.IsMaskFullyOff());
		}
	}

	public override void Teardown()
	{
		foreach (EncounterHUDComponent value in _activeComponents.Values)
		{
			value.Teardown();
		}
		_activeComponents.Clear();
	}
}
