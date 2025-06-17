using UnityEngine;

public class FlashlightState : IFlashlight
{
	public delegate void StateChanged(bool isFlashlightOn, bool shouldPlayAudio);

	private EventExposer _masterEventExposer;

	private GameDisplayData.DisplayType _currentMode;

	private BatteryState _battery;

	private IMask _mask;

	private FlashlightFxController _fxRoot;

	private float _cooldownTotal;

	private readonly SimpleTimer _cooldown;

	public bool IsOn { get; set; }

	private bool IsOnCooldown
	{
		get
		{
			if (_cooldown.Started)
			{
				return !_cooldown.IsExpired();
			}
			return false;
		}
	}

	public bool IsFlashlightAvailable { get; set; }

	public float GetCooldownPercent()
	{
		if (_cooldownTotal <= 0f)
		{
			return 0f;
		}
		return 1f - Mathf.Clamp(_cooldown.GetRemainingTime() / _cooldownTotal, 0f, 1f);
	}

	public bool CanTurnOn()
	{
		if (HasEnoughBatteryToActivate())
		{
			return !IsOnCooldown;
		}
		return false;
	}

	public bool HasEnoughBatteryToActivate()
	{
		return _battery.IsEnoughChargeToActivateFlashlight();
	}

	public void TriedToTurnOn()
	{
		_masterEventExposer.OnFlashlightTriedToActivate();
	}

	public void SetFlashlightState(bool setOn, bool shouldPlayAudio)
	{
		if (IsOn ^ setOn)
		{
			IsOn = setOn;
			DrainBatteryForActivation();
			SetFlashlightFx();
			_masterEventExposer.OnFlashlightStateChanged(IsOn, shouldPlayAudio);
		}
	}

	public void SetFlashlightCooldown(float cooldown)
	{
		_cooldownTotal = cooldown;
		_cooldown.StartTimer(cooldown);
	}

	public void Update()
	{
		if (IsOn)
		{
			if (!_battery.DrainForActiveFlashlight())
			{
				SetFlashlightState(setOn: false, shouldPlayAudio: true);
			}
			else if (!_mask.IsMaskFullyOff())
			{
				SetFlashlightState(setOn: false, shouldPlayAudio: true);
			}
		}
		if (_cooldown.Started && _cooldown.IsExpired())
		{
			_cooldown.Reset();
			if (HasEnoughBatteryToActivate())
			{
				_masterEventExposer.OnFlashlightCooldownComplete();
			}
		}
	}

	public void SetFlashlightAvailable(bool shouldFlashlightBeAvailable)
	{
		IsFlashlightAvailable = shouldFlashlightBeAvailable;
	}

	private void GameDisplayChanged(GameDisplayData args)
	{
		_currentMode = args.currentDisplay;
		if (args.currentDisplay != GameDisplayData.DisplayType.camera && args.currentDisplay != GameDisplayData.DisplayType.scavengingui && IsOn)
		{
			SetFlashlightState(setOn: false, shouldPlayAudio: false);
		}
	}

	private void DrainBatteryForActivation()
	{
		if (IsOn)
		{
			_battery.DrainForFlashlightActivation();
		}
	}

	private void SetFlashlightFx()
	{
		if ((bool)_fxRoot)
		{
			_fxRoot.ToggleFlashlight(IsOn);
		}
	}

	public FlashlightState(EventExposer masterEventExposer, BatteryState battery, IMask mask)
	{
		_cooldown = new SimpleTimer();
		_masterEventExposer = masterEventExposer;
		_battery = battery;
		_mask = mask;
		IsFlashlightAvailable = true;
		masterEventExposer.add_GameDisplayChange(GameDisplayChanged);
	}

	public void SetFxRoot(FlashlightFxController fxRoot)
	{
		_fxRoot = fxRoot;
		SetFlashlightFx();
	}

	public void Teardown()
	{
		_masterEventExposer.remove_GameDisplayChange(GameDisplayChanged);
		_fxRoot = null;
		_battery = null;
		_mask = null;
		_masterEventExposer = null;
	}
}
