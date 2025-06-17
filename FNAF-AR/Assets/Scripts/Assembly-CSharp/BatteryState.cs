using System.Collections.Generic;
using UnityEngine;

public class BatteryState : IBattery
{
	private const string ChargeKey = "BatteryLevel";

	private const string TimestampKey = "BatteryTimestamp";

	private const float MinCharge = 0f;

	private const float MaxCharge = 1f;

	private EventExposer _masterEventExposer;

	private BatterySettings _settings;

	private ExtraBatterySettings _extraBatterySettings;

	private Dictionary<string, BatteryData> _drainSettings;

	private bool _hasOfflineCatchUpCompleted;

	private long _lastTimestamp;

	private GameDisplayData.DisplayType _mode;

	private bool _isEncounterInProgress;

	private bool _batteryDrainedLastFrame;

	private bool _extraBatteryBlocked;

	private int _numExtraBatteriesUsed;

	private float _extraBatteryRechargePerSecond;

	private readonly SimpleTimer _extraBatteryDelay;

	private readonly SimpleTimer _extraBatteryTimer;

	public float Charge { get; set; }

	public int NumExtraBatteriesUsed => _numExtraBatteriesUsed;

	public bool IsExtraBatteryAvailableForUse()
	{
		if (_settings != null && _extraBatterySettings != null)
		{
			_ = (float)_numExtraBatteriesUsed;
			if (_settings.AllowedExtraBatteries >= 0)
			{
				_ = (float)_settings.AllowedExtraBatteries;
			}
			else
				_ = float.PositiveInfinity;
		}
		return false;
	}

	public bool IsExtraBatteryActive()
	{
		return _extraBatteryTimer.GetRemainingTime() > 0f;
	}

	public void SetExtraBatteryBlocker(bool isBlocked)
	{
		_extraBatteryBlocked = isBlocked;
	}

	public void SetBatteryDrain(string id, BatteryData drainSettings)
	{
		if (!_drainSettings.ContainsKey(id))
		{
			_drainSettings.Add(id, drainSettings);
		}
	}

	public void RemoveBatteryDrain(string id)
	{
		if (_drainSettings.ContainsKey(id))
		{
			_drainSettings.Remove(id);
		}
	}

	public void DrainCharge(float drainAmount)
	{
		Charge -= drainAmount;
		SetCharge(Charge);
	}

	public void RestoreCharge(float restoreAmount)
	{
		Charge += restoreAmount;
		SetCharge(Charge);
	}

	public bool IsEnoughChargeToActivateFlashlight()
	{
		if (_settings == null)
		{
			return false;
		}
		if (_isEncounterInProgress)
		{
			return Charge >= GetLargestDrain(DrainType.FlashlightActivation);
		}
		return Charge >= 0f;
	}

	public void DrainForFlashlightActivation()
	{
		DrainCharge(GetFlashlightActivationDrain());
	}

	public bool DrainForActiveFlashlight()
	{
		if (_settings == null)
		{
			return false;
		}
		if (_mode != GameDisplayData.DisplayType.results && _mode != GameDisplayData.DisplayType.camera && _mode != GameDisplayData.DisplayType.scavengingui)
		{
			return Charge > 0f;
		}
		DrainCharge(Time.deltaTime * GetFlashlightActiveDrain());
		_batteryDrainedLastFrame = true;
		return Charge > 0f;
	}

	public bool IsEnoughChargeToActivateShocker()
	{
		return Charge >= GetLargestDrain(DrainType.ShockerActivation);
	}

	public void DrainForShockerActivation()
	{
		DrainCharge(GetLargestDrain(DrainType.ShockerActivation));
	}

	public bool DrainForActiveShocker()
	{
		if (_settings == null)
		{
			return false;
		}
		if (_mode != GameDisplayData.DisplayType.results && _mode != GameDisplayData.DisplayType.camera && _mode != GameDisplayData.DisplayType.scavengingui)
		{
			return Charge > 0f;
		}
		DrainCharge(Time.deltaTime * GetLargestDrain(DrainType.ShockerActive));
		_batteryDrainedLastFrame = true;
		return Charge > 0f;
	}

	public void Update()
	{
		if (_settings != null)
		{
			UpdateStandardBattery();
			UpdateExtraBattery();
			SaveCharge();
		}
	}

	private void UpdateStandardBattery()
	{
		if (_isEncounterInProgress)
		{
			DrainCharge(GetLargestDrain(DrainType.BaseDrain) * Time.deltaTime);
			_batteryDrainedLastFrame = true;
			return;
		}
		if (!_batteryDrainedLastFrame)
		{
			Charge += _settings.BaseRecharge * Time.deltaTime;
			SetCharge(Charge);
		}
		_batteryDrainedLastFrame = false;
	}

	private void UpdateExtraBattery()
	{
		if (_extraBatteryTimer.Started && _extraBatteryTimer.IsExpired())
		{
			_extraBatteryRechargePerSecond = 0f;
			_extraBatteryTimer.Reset();
			ExtraBatteryStateChange extraBatteryStateChange = new ExtraBatteryStateChange();
			extraBatteryStateChange.IsExtraBatteryRunning = false;
			_masterEventExposer.OnExtraBatteryStateChanged(extraBatteryStateChange);
		}
		else if (!_extraBatteryTimer.Started)
		{
			if (!_extraBatteryDelay.Started)
			{
				if (Charge < 0f && _isEncounterInProgress && (!IsExtraBatteryAvailableForUse() || _extraBatteryBlocked))
				{
					if (!(_extraBatteryRechargePerSecond <= 0f))
					{
						Charge += Time.deltaTime * _extraBatteryRechargePerSecond;
						SetCharge(Charge);
					}
					return;
				}
				if (_extraBatterySettings == null)
				{
					return;
				}
				if (_extraBatterySettings.Duration <= 0f)
				{
					Charge = _extraBatterySettings.TotalRecharge + Charge;
					SetCharge(Charge);
					ExtraBatteryStateChange extraBatteryStateChange2 = new ExtraBatteryStateChange();
					extraBatteryStateChange2.IsExtraBatteryRunning = true;
					_masterEventExposer.OnExtraBatteryStateChanged(extraBatteryStateChange2);
					ExtraBatteryStateChange extraBatteryStateChange3 = new ExtraBatteryStateChange();
					extraBatteryStateChange3.IsExtraBatteryRunning = false;
					_masterEventExposer.OnExtraBatteryStateChanged(extraBatteryStateChange3);
				}
				else
				{
					_extraBatteryRechargePerSecond = _extraBatterySettings.TotalRecharge / _extraBatterySettings.Duration;
					_extraBatteryTimer.StartTimer(_extraBatterySettings.Duration);
					ExtraBatteryStateChange extraBatteryStateChange4 = new ExtraBatteryStateChange
					{
						IsExtraBatteryRunning = true
					};
					_masterEventExposer.OnExtraBatteryStateChanged(extraBatteryStateChange4);
				}
				_numExtraBatteriesUsed++;
			}
			if (_extraBatteryDelay.IsExpired())
			{
				_extraBatteryDelay.Reset();
			}
		}
		if (!(_extraBatteryRechargePerSecond <= 0f))
		{
			Charge += Time.deltaTime * _extraBatteryRechargePerSecond;
			SetCharge(Charge);
		}
	}

	private void SaveCharge()
	{
		long currentTime = ServerTime.GetCurrentTime();
		if (currentTime != _lastTimestamp)
		{
			_lastTimestamp = currentTime;
			PlayerPrefs.SetFloat("BatteryLevel", Charge);
			PlayerPrefs.SetString("BatteryTimestamp", _lastTimestamp.ToString());
		}
	}

	private void GameDisplayChanged(GameDisplayData args)
	{
		_mode = args.currentDisplay;
	}

	private void AttackEncounterStarted(EncounterType type)
	{
		_extraBatteryBlocked = false;
		_isEncounterInProgress = true;
		_numExtraBatteriesUsed = 0;
	}

	private void AttackEncounterEnded()
	{
		_isEncounterInProgress = false;
		_extraBatteryBlocked = false;
		_numExtraBatteriesUsed = 0;
	}

	private void SetCharge(float newChargeValue)
	{
		float num = Mathf.Clamp(newChargeValue, 0f, 1f);
		if (Charge != num)
		{
			Charge = num;
		}
	}

	private float GetFlashlightActivationDrain()
	{
		if (!_isEncounterInProgress)
		{
			return 0f;
		}
		return GetLargestDrain(DrainType.FlashlightActivation);
	}

	private float GetFlashlightActiveDrain()
	{
		if (_isEncounterInProgress)
		{
			return GetLargestDrain(DrainType.FlashlightActive);
		}
		if (_settings != null)
		{
			return _settings.EssenceFlashlightDrain;
		}
		return 0f;
	}

	private float GetLargestDrain(DrainType type)
	{
		if (_drainSettings == null)
		{
			return 0f;
		}
		if (_drainSettings.Values.Count < 1)
		{
			return 0f;
		}
		using (Dictionary<string, BatteryData>.ValueCollection.Enumerator enumerator = _drainSettings.Values.GetEnumerator())
		{
			if (enumerator.MoveNext())
			{
				BatteryData current = enumerator.Current;
				return type switch
				{
					DrainType.BaseDrain => current.BaseDrain, 
					DrainType.FlashlightActivation => current.FlashlightActivationDrain, 
					DrainType.FlashlightActive => current.FlashlightActiveDrain, 
					DrainType.ShockerActivation => current.ShockerActivationDrain, 
					DrainType.ShockerActive => current.ShockerActiveDrain, 
					DrainType.HaywireShock => current.HaywireShockDrain, 
					_ => 0f, 
				};
			}
		}
		return 0f;
	}

	public BatteryState(EventExposer masterEventExposer)
	{
		_mode = GameDisplayData.DisplayType.splash;
		_extraBatteryDelay = new SimpleTimer();
		_extraBatteryTimer = new SimpleTimer();
		Charge = 99f;
		_masterEventExposer = masterEventExposer;
		_drainSettings = new Dictionary<string, BatteryData>();
		_masterEventExposer.add_GameDisplayChange(GameDisplayChanged);
		_masterEventExposer.add_AttackEncounterStarted(AttackEncounterStarted);
		_masterEventExposer.add_AttackScavengingEncounterStarted(AttackEncounterStarted);
		_masterEventExposer.add_AttackEncounterEnded(AttackEncounterEnded);
		_masterEventExposer.add_AttackScavengingEncounterEnded(AttackEncounterEnded);
	}

	public void SetConfigData(CONFIG_DATA.BatteryBehavior rawSettings)
	{
		_settings = new BatterySettings(rawSettings);
	}

	public void Teardown()
	{
		_masterEventExposer.remove_AttackEncounterEnded(AttackEncounterEnded);
		_masterEventExposer.remove_AttackScavengingEncounterEnded(AttackEncounterEnded);
		_masterEventExposer.remove_AttackScavengingEncounterStarted(AttackEncounterStarted);
		_masterEventExposer.remove_AttackEncounterStarted(AttackEncounterStarted);
		_masterEventExposer.remove_GameDisplayChange(GameDisplayChanged);
		_drainSettings.Clear();
		_masterEventExposer = null;
		_extraBatterySettings = null;
		_drainSettings = null;
	}
}
