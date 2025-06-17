using UnityEngine;

public class ShockerState : IShocker
{
	private const float CONTINUOUS_SHOCKER_HAPTIC_REFIRE_RATE = 0.5f;

	private EventExposer _masterEventExposer;

	private ShockerSettings _settings;

	private BatteryState _battery;

	private readonly SimpleTimer _cooldownTimer;

	private ShockerFxController _fxRoot;

	private readonly SimpleTimer _fxDuration;

	private bool _isOn;

	private float _hapticRefireTicker;

	private bool _enabled;

	private bool _encounterInProgress;

	private EncounterType _encounterType;

	private float _attackPower;

	public float GetTotalMissCooldownTime()
	{
		return _settings.MissDuration + _settings.ShockerCooldownSeconds;
	}

	public float GetTotalHitCooldownTime()
	{
		return _settings.HitDuration + _settings.ShockerCooldownSeconds;
	}

	public float GetShockerAttackPower()
	{
		return _attackPower;
	}

	public ShockerStatus GetStatus()
	{
		if (!_encounterInProgress || _encounterType == EncounterType.Phantom || !_enabled)
		{
			return ShockerStatus.NotInAttackMode;
		}
		if (_isOn)
		{
			return ShockerStatus.Cooldown;
		}
		if (_battery.IsEnoughChargeToActivateShocker())
		{
			if (!(GetRemainingCooldownTime() > 0f))
			{
				return ShockerStatus.ReadyToShock;
			}
			return ShockerStatus.Cooldown;
		}
		return ShockerStatus.NotEnoughBattery;
	}

	public float GetRemainingCooldownTime()
	{
		return _cooldownTimer.GetRemainingTime();
	}

	public float GetCooldownPercent()
	{
		if (_settings == null)
		{
			return -1f;
		}
		if (_settings.ShockerCooldownSeconds <= 0f)
		{
			return 1f;
		}
		return 1f - Mathf.Clamp(GetRemainingCooldownTime(), 0f, 1f);
	}

	public void Activate(bool didHitAnimatronic, bool isDisruptionFullyActive)
	{
		Debug.Log("SHOCKER ACTIVATED. DID HIT - " + didHitAnimatronic);
		if (_settings != null && CanActivate(GetStatus()))
		{
			if (GetStatus() == ShockerStatus.Cooldown || isDisruptionFullyActive)
			{
				ActivateEffect(onCooldown: true, noBattery: false, didHit: false);
			}
			else if (GetStatus() == ShockerStatus.ReadyToShock)
			{
				ActivateEffect(onCooldown: false, noBattery: false, didHitAnimatronic);
			}
			else if (GetStatus() != ShockerStatus.NotEnoughBattery)
			{
				Debug.LogError("ShockerState Activate - " + $"Shocker was activated with unknown status: {GetStatus()}");
			}
			else
			{
				ActivateEffect(onCooldown: false, noBattery: true, didHit: false);
			}
		}
	}

	public void Deactivate()
	{
		if (_isOn)
		{
			_isOn = false;
			_fxRoot.EndEffect();
			_fxDuration.Reset();
			_cooldownTimer.StartTimer(_settings.ShockerCooldownSeconds);
		}
	}

	public void Update()
	{
		if (_isOn)
		{
			if (_settings.ContinuousShocker)
			{
				_hapticRefireTicker -= Time.deltaTime;
				if (_hapticRefireTicker < 0f)
				{
					ContinuousShockerVibrate();
					_hapticRefireTicker = 0.5f;
				}
			}
			if (!_battery.DrainForActiveShocker() || (_fxDuration.Started && _fxDuration.IsExpired()))
			{
				Deactivate();
			}
		}
		if (_cooldownTimer.Started && _cooldownTimer.IsExpired())
		{
			_cooldownTimer.Reset();
			if (_battery.IsEnoughChargeToActivateShocker())
			{
				_masterEventExposer.OnShockerCooldownComplete();
			}
		}
	}

	private void AttackEncounterStarted(EncounterType type)
	{
		Debug.Log("orton it was a success! scavenging IS real!");
		_encounterInProgress = true;
		_encounterType = type;
	}

	private void AttackEncounterEnded()
	{
		_encounterInProgress = false;
	}

	private static bool CanActivate(ShockerStatus status)
	{
		return status != ShockerStatus.Active;
	}

	private void ActivateEffect(bool onCooldown, bool noBattery, bool didHit)
	{
		if (!onCooldown)
		{
			ShockVibrate(noBattery, didHit);
			if (!noBattery)
			{
				_battery.DrainForShockerActivation();
				_fxRoot.StartEffect(didHit);
				if (!_settings.ContinuousShocker)
				{
					_fxDuration.StartTimer(_fxRoot.duration);
				}
				_isOn = true;
				_hapticRefireTicker = 0.5f;
			}
		}
		ShockerActivation shockerActivation = new ShockerActivation();
		shockerActivation.OnCooldown = onCooldown;
		shockerActivation.NoBattery = noBattery;
		shockerActivation.DidHit = didHit;
		_masterEventExposer.OnShockerActivated(shockerActivation);
	}

	private void ShockVibrate(bool noBattery, bool didHit)
	{
	}

	private void ContinuousShockerVibrate()
	{
		VibrationSettings.VibrationIsEnabled();
	}

	public ShockerState(EventExposer masterEventExposer, BatteryState battery)
	{
		_fxDuration = new SimpleTimer();
		_masterEventExposer = masterEventExposer;
		_battery = battery;
		masterEventExposer.add_AttackEncounterStarted(AttackEncounterStarted);
		masterEventExposer.add_AttackScavengingEncounterStarted(AttackEncounterStarted);
		masterEventExposer.add_AttackEncounterEnded(AttackEncounterEnded);
		masterEventExposer.add_AttackScavengingEncounterEnded(AttackEncounterEnded);
		_cooldownTimer = new SimpleTimer();
	}

	public void SetShockerData(float cooldownSeconds, bool isContinuous)
	{
		ShockerSettings shockerSettings = null;
		shockerSettings = new ShockerSettings(cooldownSeconds, isContinuous);
		_settings = shockerSettings;
		_fxRoot.SetShockerData(_settings);
		_isOn = false;
		_enabled = true;
	}

	public void InitShockerAttackPower(float attackPower)
	{
		_attackPower = attackPower;
	}

	public void SetFxRoot(ShockerFxController fxRoot)
	{
		_fxRoot = fxRoot;
	}

	public void Teardown()
	{
		_masterEventExposer.remove_AttackEncounterEnded(AttackEncounterEnded);
		_masterEventExposer.remove_AttackScavengingEncounterEnded(AttackEncounterEnded);
		_masterEventExposer.remove_AttackEncounterStarted(AttackEncounterStarted);
		_masterEventExposer.remove_AttackScavengingEncounterStarted(AttackEncounterStarted);
		_fxRoot = null;
		_battery = null;
		_masterEventExposer = null;
	}

	public void SetShockerOffset(Vector3 offset)
	{
		_fxRoot.SetShockerOffset(offset);
	}

	public void EnableShocker()
	{
		_enabled = true;
	}

	public void DisableShocker()
	{
		_enabled = false;
	}
}
