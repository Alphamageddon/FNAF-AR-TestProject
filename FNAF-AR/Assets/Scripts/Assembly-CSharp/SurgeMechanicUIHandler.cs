using UnityEngine;

public class SurgeMechanicUIHandler
{
	private SurgeMechanicUIHandlerData _data;

	private float _batterySurgeBlinkDuration;

	private float _batterySurgeMaskLightFadeTime;

	private bool _blinkState;

	private bool _blinkStateLastFrame;

	private bool _isSurgeActive;

	private float _blinkTimer;

	public bool BlinkState => _blinkState;

	public float BatterySurgeMaskLightFadeTime => _batterySurgeMaskLightFadeTime;

	public SurgeMechanicUIHandler(SurgeMechanicUIHandlerData surgeMechanicUIHandlerData)
	{
		_data = surgeMechanicUIHandlerData;
		surgeMechanicUIHandlerData.eventExposer.add_AttackSurgeStateChanged(EventExposer_AttackSurgeStateChanged);
	}

	public void Update()
	{
		_blinkTimer += Time.deltaTime;
		if (_blinkTimer >= _batterySurgeBlinkDuration)
		{
			_blinkTimer = 0f;
			_blinkState = !_blinkState & _isSurgeActive;
		}
		if (_blinkState && !_blinkStateLastFrame)
		{
			VibrationSettings.VibrationIsEnabled();
		}
		_blinkStateLastFrame = _blinkState;
	}

	public void Teardown()
	{
		_data.eventExposer.remove_AttackSurgeStateChanged(EventExposer_AttackSurgeStateChanged);
	}

	private void EventExposer_AttackSurgeStateChanged(bool state, SurgeData surgeSettings)
	{
		_isSurgeActive = state;
		if (surgeSettings != null)
		{
			_batterySurgeBlinkDuration = surgeSettings.BatterySurgeBlinkDuration;
		}
		else
		{
			_batterySurgeBlinkDuration = 0f;
		}
		_batterySurgeMaskLightFadeTime = surgeSettings.BatterySurgeMaskLightFadeTime;
	}
}
