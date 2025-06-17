using UnityEngine;

public class AttackSurge
{
	public delegate void StateChanged(bool isSurgeActive, SurgeData surgeSettings);

	private EventExposer _masterEventExposer;

	private GameDisplayData.DisplayType _currentMode;

	private SurgeData _settings;

	private AttackAnimatronicExternalSystems _systems;

	private int _timesActivated;

	private int _timesNotActivated;

	private bool _isActive;

	private float _cancelingAccruedDuration;

	private float _increasePerSecond;

	private float _decreasePerSecond;

	private const float MaxCancelling = 1f;

	private readonly SimpleTimer _cooldown;

	public void StartSurge(SurgeData settings)
	{
		_settings = settings;
		_timesActivated = 0;
		_timesNotActivated = 0;
		_cancelingAccruedDuration = 0f;
		StartCooldownTimer();
	}

	public void StopSurge()
	{
		StopSurgeEffect();
		_settings = null;
	}

	public void Update()
	{
		if (_settings != null)
		{
			if (_cooldown.Started && _cooldown.IsExpired())
			{
				_cooldown.Reset();
				TryToActivate();
			}
			if (_isActive)
			{
				UpdateActiveSurge();
			}
		}
	}

	private void GameDisplayChanged(GameDisplayData args)
	{
		_currentMode = args.currentDisplay;
	}

	private void StartCooldownTimer()
	{
		if (_settings != null && (_settings.Seconds.Min != 0f || _settings.Seconds.Max != 0f))
		{
			_cooldown.StartTimer(Random.Range(_settings.Seconds.Min, _settings.Seconds.Max));
		}
	}

	private void TryToActivate()
	{
		if (_settings != null && _settings.ActivationChance != null)
		{
			float num = ((!(_settings.ActivationChance.Modifier < 0f)) ? (_settings.ActivationChance.Chance + _settings.ActivationChance.Modifier * (float)_timesNotActivated) : (_settings.ActivationChance.Chance - _settings.ActivationChance.Modifier * (float)_timesActivated));
			if (Random.Range(0.0001f, 1f) > num)
			{
				StartCooldownTimer();
				_timesNotActivated++;
			}
			else
			{
				Activate();
				_timesActivated++;
				_timesNotActivated = 0;
			}
		}
	}

	private void Activate()
	{
		_isActive = true;
		_cancelingAccruedDuration = 0f;
		_decreasePerSecond = (_increasePerSecond = ((_settings.CancelTime == 0f) ? 1000f : (1f / _settings.CancelTime)));
		_masterEventExposer.OnAttackSurgeStateChanged(_isActive, _settings);
	}

	private void UpdateActiveSurge()
	{
		float drainAmount;
		if (IsCancelActionActive())
		{
			_cancelingAccruedDuration += _increasePerSecond * Time.deltaTime;
			drainAmount = Time.deltaTime * _settings.BatteryDrainRateCancel;
		}
		else
		{
			_cancelingAccruedDuration -= _decreasePerSecond * Time.deltaTime;
			drainAmount = Time.deltaTime * _settings.BatteryDrainRateBase;
		}
		_systems.Battery.DrainCharge(drainAmount);
		_cancelingAccruedDuration = Mathf.Clamp(_cancelingAccruedDuration, 0f, 1f);
		if (!(_cancelingAccruedDuration < 1f))
		{
			StopSurgeEffect();
		}
	}

	private bool IsCancelActionActive()
	{
		if (_settings == null)
		{
			return true;
		}
		return _systems.Mask.IsMaskFullyOn();
	}

	private void StopSurgeEffect()
	{
		if (_isActive)
		{
			_isActive = false;
			StartCooldownTimer();
			_masterEventExposer.OnAttackSurgeStateChanged(_isActive, _settings);
		}
	}

	public AttackSurge(EventExposer masterEventExposer)
	{
		_cooldown = new SimpleTimer();
		_masterEventExposer = masterEventExposer;
		masterEventExposer.add_GameDisplayChange(GameDisplayChanged);
	}

	public void Setup(AttackAnimatronicExternalSystems systems)
	{
		_systems = systems;
	}

	public void Teardown()
	{
		_masterEventExposer.remove_GameDisplayChange(GameDisplayChanged);
		_settings = null;
		_masterEventExposer = null;
	}
}
