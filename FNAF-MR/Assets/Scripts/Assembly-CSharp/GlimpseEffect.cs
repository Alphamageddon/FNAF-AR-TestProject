using UnityEngine;

public class GlimpseEffect
{
	private bool _wasSeen;

	private bool _finished;

	private float _cloakDelayTime;

	private readonly SimpleTimer _cloakDelayTimer;

	private float _cloakTime;

	private readonly SimpleTimer _cloakTimer;

	private readonly SimpleTimer _expireTimer;

	public bool IsFinished()
	{
		return _finished;
	}

	public void SpawnGlimpse(Blackboard blackboard, float angleFromCamera, float distance, float cloakDelayTime, float cloakTime, float expireTime)
	{
		Debug.LogError("GLIMPSE SPAWNED");
		Reset();
		blackboard.Model.Teleport(angleFromCamera, distance, faceCamera: true);
		blackboard.Model.SetCloakState(cloakEnabled: false);
		blackboard.Model.SetEyeCloakState(eyeCloakEnabled: false);
		blackboard.Model.SetEyeColorMode(EyeColorMode.Normal);
		blackboard.Model.SetEyeGlow(eyeGlowEnabled: false);
		blackboard.Model.SetAnimationInt(AnimationInt.GlimpsePoseIndex, Random.Range(0, 3));
		blackboard.Model.SetAnimationBool(AnimationBool.GlimpseActive, value: true);
		_cloakDelayTime = cloakDelayTime;
		_cloakTime = cloakTime;
		_expireTimer.StartTimer(expireTime);
	}

	public void EndGlimpse(Blackboard blackboard)
	{
		blackboard.Model.SetAnimationBool(AnimationBool.GlimpseActive, value: false);
	}

	public void Update(Blackboard blackboard)
	{
		if (_cloakTimer.Started && _cloakTimer.IsExpired())
		{
			Debug.LogWarning("glimpse cloak ended");
			EndGlimpse(blackboard);
			_finished = true;
		}
		if (_finished)
		{
			return;
		}
		if (_cloakDelayTimer.Started && _cloakDelayTimer.IsExpired())
		{
			BeginCloak(blackboard);
		}
		if (_expireTimer.Started && _expireTimer.IsExpired())
		{
			Debug.LogWarning("Glimpse expired");
			BeginCloak(blackboard);
		}
		if (_wasSeen)
		{
			if (blackboard.Model.IsBodyFullyCloaked())
			{
				blackboard.Model.TeleportAtCurrentAngle(blackboard.AttackProfile.TeleportReposition.DistanceFromCamera.Max);
			}
		}
		else if (blackboard.IsAABBOnScreen)
		{
			Debug.LogError("GLIMPSE SEEN");
			MarkSeen();
		}
	}

	private void Reset()
	{
		_wasSeen = false;
		_finished = false;
		_cloakDelayTime = 0f;
		_cloakDelayTimer.Reset();
		_cloakTime = 0f;
		_cloakTimer.Reset();
		_expireTimer.Reset();
	}

	private void MarkSeen()
	{
		_wasSeen = true;
		_cloakDelayTimer.StartTimer(_cloakDelayTime);
	}

	private void BeginCloak(Blackboard blackboard)
	{
		if (_wasSeen)
		{
			blackboard.Model.RaiseAudioEventFromPlushSuit(AudioEventName.AttackCloakBegin);
			blackboard.Model.BeginCloak();
			blackboard.Model.BeginEyeCloak();
			_cloakTimer.StartTimer(_cloakTime);
			_cloakDelayTimer.Reset();
			_expireTimer.Reset();
		}
		else
		{
			blackboard.Model.SetCloakState(cloakEnabled: true);
			blackboard.Model.SetEyeCloakState(eyeCloakEnabled: true);
			_cloakTimer.StartTimer(0f);
			_cloakDelayTimer.Reset();
			_expireTimer.Reset();
		}
	}

	public GlimpseEffect()
	{
		_cloakDelayTimer = new SimpleTimer();
		_cloakTimer = new SimpleTimer();
		_expireTimer = new SimpleTimer();
	}
}
