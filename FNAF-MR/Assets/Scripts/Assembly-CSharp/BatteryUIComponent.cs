using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BatteryUIComponent : EncounterHUDComponent
{
	private const string PERCENT_STRING = "%";

	private Slider _batterySlider;

	private Image _batteryBG;

	private Image _batteryColor;

	private TextMeshProUGUI _batteryPct;

	private RectTransform _batteryDefenderVFX;

	private BatteryColorHandler _batteryColorHandler;

	private AttackSequenceDomain _attackSequenceDomain;

	private IBattery _battery;

	private bool _allowed;

	public bool Active => _root.activeSelf;

	public BatteryUIComponent(GameObject mainCanvas)
		: base(mainCanvas)
	{
	}

	public void Setup(SurgeMechanicUIHandler surgeHandler, List<BatteryColorToValue> colorToValues, Color surgeColor, AttackSequenceDomain attackSequenceDomain, IBattery battery)
	{
		_batteryColorHandler = new BatteryColorHandler(new BatteryColorHandlerData(surgeHandler, _batterySlider, _batteryColor, _batteryBG, _batteryPct, colorToValues, surgeColor));
		_attackSequenceDomain = attackSequenceDomain;
		_battery = battery;
		_allowed = true;
	}

	protected override void CacheAndPopulateComponents()
	{
		_components = new ComponentContainer();
		Type[] onlyCacheTypes = new Type[4]
		{
			typeof(RectTransform),
			typeof(Image),
			typeof(Slider),
			typeof(TextMeshProUGUI)
		};
		_components.CacheComponents(_root, onlyCacheTypes);
		_batteryBG = _components.TryGetComponent<Image>("BG");
		_batteryColor = _components.TryGetComponent<Image>("Fill");
		_batterySlider = _components.TryGetComponent<Slider>("BatterySlider");
		_batteryPct = _components.TryGetComponent<TextMeshProUGUI>("ValueText");
	}

	public override void Update()
	{
		if (_root.activeSelf)
		{
			UpdateBatteryChargeNumber();
			UpdateBatteryChargeSlider();
			_batteryColorHandler.Update();
		}
	}

	private void UpdateBatteryChargeNumber()
	{
		if (_batteryPct != null)
		{
			_batteryPct.text = Mathf.FloorToInt(_battery.Charge * 100f) + "%";
		}
	}

	private void UpdateBatteryChargeSlider()
	{
		if (_batterySlider != null)
		{
			_batterySlider.value = _battery.Charge;
		}
	}

	public override void UpdateVisibility(bool isMaskFullyOff)
	{
		bool flag = false;
		if (_attackSequenceDomain.GetEncounterUIConfig() != null)
		{
			flag = _attackSequenceDomain.GetEncounterUIConfig().ShowBattery;
		}
		bool flag2 = _allowed && isMaskFullyOff;
		_root.SetActive(flag && flag2);
	}
}
