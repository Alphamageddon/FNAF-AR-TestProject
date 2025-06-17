using UnityEngine;

public class ShakeDetector
{
	private const float AccelerometerUpdateInterval = 1f / 60f;

	private const float LowPassKernelWidthInSeconds = 1f;

	private const float LowPassFilterFactor = 1f / 60f;

	private const float DefaultMagnitude = 2f;

	private const float DefaultGraceTime = 0.1f;

	private Vector3 _lowPassValue;

	private float _graceTime;

	private RangeData _shakeMagnitudeRange;

	private float _rampTime;

	private float _currentTime;

	private bool _isDisruptionRamping;

	private readonly SimpleTimer _shakeGracePeriod;

	private Transform _cameraTransform;

	private Quaternion _lastRotation;

	private Quaternion _currentRotation;

	private const float TRANSFORM_MOTION_MOD = 1f;

	public bool IsShaking { get; set; }

	private float _magnitude
	{
		get
		{
			if (_shakeMagnitudeRange == null)
			{
				return 2f;
			}
			return Mathf.Lerp(_shakeMagnitudeRange.Min, _shakeMagnitudeRange.Max, _currentTime / _rampTime);
		}
	}

	public void SetConfigValues(DisruptionData settings)
	{
		_graceTime = settings.ShakeGraceTime;
		_shakeMagnitudeRange = settings.ShakeMagnitude;
		_rampTime = settings.RampTime;
		_currentTime = 0f;
	}

	public void ClearConfigValues()
	{
		_graceTime = 0.1f;
		_shakeMagnitudeRange = null;
	}

	public void Reset()
	{
		_currentTime = 0f;
		_isDisruptionRamping = true;
	}

	public void Stop()
	{
		_isDisruptionRamping = false;
	}

	public void Update()
	{
		if (!(_cameraTransform == null))
		{
			_lastRotation = _currentRotation;
			_currentRotation = _cameraTransform.rotation;
			Vector3 zero = Vector3.zero;
			zero = new Vector3(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"), 0f) * 1f;
			_lowPassValue = Vector3.Lerp(_lowPassValue, zero, 1f / 60f);
			if ((zero - _lowPassValue).magnitude >= _magnitude)
			{
				IsShaking = true;
				_shakeGracePeriod.StartTimer(_graceTime);
			}
			else if (_shakeGracePeriod.Started && _shakeGracePeriod.IsExpired())
			{
				IsShaking = false;
				_shakeGracePeriod.Reset();
			}
			if (_isDisruptionRamping)
			{
				_currentTime += Time.deltaTime;
			}
		}
	}

	public ShakeDetector()
	{
		_graceTime = 0.1f;
		_rampTime = 1f;
		_shakeGracePeriod = new SimpleTimer();
		_lowPassValue = Input.acceleration;
	}

	public void SetTransform(Transform t)
	{
		_cameraTransform = t;
		_lastRotation = _cameraTransform.rotation;
		_currentRotation = _cameraTransform.rotation;
		_lowPassValue = Vector3.zero;
	}
}
