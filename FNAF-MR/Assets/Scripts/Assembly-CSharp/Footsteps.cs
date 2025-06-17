using EZCameraShake;

public class Footsteps
{
	public delegate void FootstepEffectTriggered(bool isWalking);

	private AudioDispatcher _audioDispatcher;

	private FootstepConfigData _walkConfigData;

	private FootstepConfigData _runConfigData;

	private float _distanceFromCamera;

	private bool _isWalking;

	private readonly SimpleTimer _nextEffect;

	private FootstepConfigData _nextConfigData;

	public event FootstepEffectTriggered OnFootstepEffectTriggered;

	public void SetFootstepConfig(FootstepConfigData walkConfigData, FootstepConfigData runConfigData)
	{
		_walkConfigData = walkConfigData;
		_runConfigData = runConfigData;
	}

	public void SetMovementMode(bool isWalking)
	{
		_isWalking = isWalking;
	}

	public void TriggerFootstep()
	{
		_audioDispatcher.RaiseEventFromPlushSuit(_isWalking ? AudioEventName.AttackFootstepWalk : AudioEventName.AttackFootstepRun);
		_nextConfigData = (_isWalking ? _walkConfigData : _runConfigData);
		_nextEffect.StartTimer(_isWalking ? _walkConfigData.EffectDelay : _runConfigData.EffectDelay);
	}

	public void Update(float distanceFromCamera)
	{
		_distanceFromCamera = distanceFromCamera;
		UpdateFootstepEffects();
	}

	private void UpdateFootstepEffects()
	{
		float magnitude = 0f;
		float roughness = 0f;
		float fadeInTime = 0f;
		float fadeOutTime = 0f;
		if (_nextEffect.Started && _nextEffect.IsExpired())
		{
			_nextEffect.Reset();
			this.OnFootstepEffectTriggered?.Invoke(_isWalking);
			if (_nextConfigData != null && _nextConfigData.CameraShake != null)
			{
				fadeOutTime = _nextConfigData.CameraShake.FadeOut;
				magnitude = _nextConfigData.CameraShake.Magnitude;
				roughness = _nextConfigData.CameraShake.Roughness;
				fadeInTime = _nextConfigData.CameraShake.FadeIn;
			}
			CameraShaker.Instance.ShakeOnce(magnitude, roughness, fadeInTime, fadeOutTime);
		}
	}

	public Footsteps(AudioDispatcher audioDispatcher)
	{
		_nextEffect = new SimpleTimer();
		_audioDispatcher = audioDispatcher;
	}

	public void Teardown()
	{
		this.OnFootstepEffectTriggered = null;
		_audioDispatcher = null;
	}
}
