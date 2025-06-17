using System.Collections.Generic;
using UnityEngine;

public class AttackDisruption
{
	public delegate void StateChanged(bool isDisruptionActive, DisruptionStyle style);

	private EventExposer _masterEventExposer;

	private AssetCache _assetCache;

	private GameDisplayData.DisplayType _currentMode;

	private DisruptionData _settings;

	private DisruptionFxController _fxController;

	private Camera _minireenaCamera;

	private MinireenasController _minireenasController;

	private AttackAnimatronicExternalSystems _systems;

	private ShakeDetector _shakeDetector;

	private int _timesActivated;

	private int _timesNotActivated;

	private bool _isActive;

	private bool _hasReachedMaxStrength;

	private float _strength;

	private float _increasePerSecond;

	private float _decreasePerSecond;

	private float _disruptionActiveTime;

	private const float MaxStrength = 1f;

	private bool _isPaused;

	private float _resumeTime;

	private List<DisruptionStyle> _activeDisruptionStyles;

	private readonly SimpleTimer _cooldown;

	public bool IsDisruptionFullyActive
	{
		get
		{
			if (!_isActive || !_fxController.enabled)
			{
				return false;
			}
			return _hasReachedMaxStrength;
		}
	}

	public void SetUpDisruption(DisruptionData settings, string soundBankName, PlushSuitData plushSuitData)
	{
		if (_shakeDetector != null)
		{
			_shakeDetector.SetConfigValues(settings);
		}
		_settings = settings;
		_timesActivated = 0;
		_timesNotActivated = 0;
		if (_fxController != null)
		{
			_fxController.useFrostDisruption = _settings.Style == DisruptionStyle.Frozen;
			_fxController.useSmokeDisruption = _settings.Style == DisruptionStyle.Smoke;
		}
		if (_settings.Style == DisruptionStyle.Minireena)
		{
			LoadBundledMinireenas(settings, soundBankName, plushSuitData, _minireenaCamera, _systems.CameraStableTransform);
		}
	}

	public void StartDisruption()
	{
		_timesActivated = 0;
		_timesNotActivated = 0;
		StartCooldownTimer();
	}

	private void LoadBundledMinireenas(DisruptionData settings, string soundBankName, PlushSuitData plushSuitData, Camera minireenaCamera, Transform parent)
	{
		string bundleName = plushSuitData.DisruptionScreenObjectBundleName;
		string assetName = plushSuitData.DisruptionScreenObjectAssetName;
		_assetCache.Instantiate(bundleName, assetName, delegate(GameObject minireenaContainer)
		{
			minireenaContainer.transform.SetParent(parent, worldPositionStays: false);
			_minireenasController = minireenaContainer.GetComponent<MinireenasController>();
			_minireenasController.SetDisruptionData(settings, soundBankName, minireenaCamera);
		}, delegate
		{
			Debug.LogError("AttackDisruption LoadBundledMinireenas - Failed to load and instantiate bundledMinireenas for " + bundleName + "." + assetName);
		});
	}

	private void CleanUpMinireenaDisruption()
	{
		_minireenasController.SetStrength(_strength);
		_minireenasController.Deactivate();
		_assetCache.ReleaseInstance(_minireenasController.gameObject);
		_minireenasController = null;
	}

	public void StopDisruption()
	{
		_shakeDetector.ClearConfigValues();
		StopDisruptionEffect();
		_isActive = false;
		_isPaused = false;
		_strength = 0f;
		_fxController.SetStrength(0f);
		if (_minireenasController != null)
		{
			CleanUpMinireenaDisruption();
		}
		_settings = null;
	}

	public void PauseDisruption()
	{
		_resumeTime = _cooldown.GetRemainingTime();
		_cooldown.Reset();
		_isPaused = true;
	}

	public void UnPauseDisruption()
	{
		_isPaused = false;
		if (!_isActive)
		{
			if (_resumeTime > 0f)
			{
				_cooldown.StartTimer(_resumeTime);
			}
			else
			{
				StartCooldownTimer();
			}
		}
	}

	public void Update()
	{
		if (_settings != null && !(_fxController == null))
		{
			if (_cooldown.Started && _cooldown.IsExpired())
			{
				_cooldown.Reset();
				TryToActivate();
			}
			if (_isActive)
			{
				UpdateActiveDisruption();
			}
		}
	}

	private void GameDisplayChanged(GameDisplayData args)
	{
		_currentMode = args.currentDisplay;
	}

	private void StartCooldownTimer()
	{
		if (_settings != null && !_isPaused && (_settings.Seconds.Min != 0f || _settings.Seconds.Max != 0f))
		{
			_cooldown.StartTimer(Random.Range(_settings.Seconds.Min, _settings.Seconds.Max));
		}
	}

	private void TryToActivate()
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

	private void Activate()
	{
		_isActive = true;
		_hasReachedMaxStrength = false;
		_strength = 0f;
		_increasePerSecond = ((_settings.RampTime == 0f) ? 1000f : (1f / _settings.RampTime));
		_decreasePerSecond = ((_settings.CancelTime == 0f) ? 1000f : (1f / _settings.CancelTime));
		_masterEventExposer.OnAttackDisruptionStateChanged(_isActive, _settings.Style);
		_shakeDetector.Reset();
		_disruptionActiveTime = 0f;
		_activeDisruptionStyles.Add(_settings.Style);
		if (!(_minireenasController == null) && _settings.Style == DisruptionStyle.Minireena)
		{
			_minireenasController.Activate();
		}
	}

	private void UpdateActiveDisruption()
	{
		if (IsCancelActionActive())
		{
			_strength -= _decreasePerSecond * Time.deltaTime;
		}
		else
		{
			_strength += _increasePerSecond * Time.deltaTime;
		}
		_hasReachedMaxStrength = _strength >= 1f || _hasReachedMaxStrength;
		_strength = Mathf.Clamp(_strength, 0f, 1f);
		foreach (DisruptionStyle activeDisruptionStyle in _activeDisruptionStyles)
		{
			UpdateActiveDisruption(activeDisruptionStyle);
		}
		_disruptionActiveTime += Time.deltaTime;
		UpdateUITarget();
		if (!(_strength > 0f))
		{
			StopDisruptionEffect();
		}
	}

	private void UpdateActiveDisruption(DisruptionStyle disruptionStyle)
	{
		if (disruptionStyle == DisruptionStyle.Minireena)
		{
			if (!(_minireenasController == null))
			{
				_minireenasController.SetStrength(_strength);
			}
		}
		else if (_fxController == null)
		{
			Debug.LogError("FX CONTROLLER IS NULL.");
		}
		else
		{
			_fxController.SetStrength(_strength);
		}
	}

	private void UpdateUITarget()
	{
		if (_settings.UITarget == DisruptionUiTarget.AnimatronicNoiseMeter)
		{
			UpdateAnimatronicNoiseMeter();
		}
	}

	private void UpdateAnimatronicNoiseMeter()
	{
		if (!(_minireenasController == null) && _systems.NoiseMechanic != null && _systems.NoiseMechanic.AnimatronicNoiseMeter != null)
		{
			float t = ((_settings.RampTime > 0f) ? (_disruptionActiveTime / _settings.RampTime) : 1f);
			float displayValuePadding = Mathf.Lerp(_settings.UITargetRange.Min, _settings.UITargetRange.Max, t) * (float)_minireenasController.MinireenaCount;
			_systems.NoiseMechanic.AnimatronicNoiseMeter.SetDisplayValuePadding(displayValuePadding);
		}
	}

	private bool IsCancelActionActive()
	{
		if (_settings.CancelAction == DisruptionCancelAction.MaskOn)
		{
			return _systems.Mask.IsMaskFullyOn();
		}
		if (_settings.CancelAction != DisruptionCancelAction.Shake)
		{
			return true;
		}
		return _shakeDetector.IsShaking;
	}

	private void StopDisruptionEffect()
	{
		_isActive = false;
		_hasReachedMaxStrength = false;
		StartCooldownTimer();
		CleanUpActiveDisruptions();
	}

	private void CleanUpActiveDisruptions()
	{
		foreach (DisruptionStyle activeDisruptionStyle in _activeDisruptionStyles)
		{
			_masterEventExposer.OnAttackDisruptionStateChanged(isDisruptionActive: false, activeDisruptionStyle);
		}
		_activeDisruptionStyles.Clear();
		if (_systems.NoiseMechanic != null && _systems.NoiseMechanic.AnimatronicNoiseMeter != null)
		{
			_systems.NoiseMechanic.AnimatronicNoiseMeter.SetDisplayValuePadding(0f);
		}
	}

	private void StopDisruptionButtonPressed()
	{
		StopDisruption();
	}

	public AttackDisruption(EventExposer masterEventExposer, ShakeDetector shakeDetector)
	{
		_activeDisruptionStyles = new List<DisruptionStyle>();
		_cooldown = new SimpleTimer();
		_masterEventExposer = masterEventExposer;
		_shakeDetector = shakeDetector;
		_masterEventExposer.add_GameDisplayChange(GameDisplayChanged);
		_masterEventExposer.add_StopDisruptionButtonPressed(StopDisruptionButtonPressed);
	}

	public void Setup(DisruptionFxController fxController, Camera minireenaCamera, AttackAnimatronicExternalSystems systems)
	{
		_fxController = fxController;
		_minireenaCamera = minireenaCamera;
		_systems = systems;
		_assetCache = systems.AssetCacheAccess;
	}

	public void Teardown()
	{
		_masterEventExposer.remove_GameDisplayChange(GameDisplayChanged);
		_masterEventExposer.remove_StopDisruptionButtonPressed(StopDisruptionButtonPressed);
		_masterEventExposer = null;
		_systems = null;
		_minireenaCamera = null;
		_settings = null;
	}
}
