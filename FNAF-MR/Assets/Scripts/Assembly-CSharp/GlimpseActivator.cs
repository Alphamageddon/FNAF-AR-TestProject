using System;
using UnityEngine;

public class GlimpseActivator : BaseGlimpseActivator
{
	private Vector3 _thisProjectedCameraForward;

	private Vector3 _lastProjectedCameraForward;

	private float _signedCameraAngleDelta;

	private float _absoluteCameraAngleDelta;

	private bool _shouldUseDeadZone;

	public override void Reset(Blackboard blackboard)
	{
		base.Reset(blackboard);
		_thisProjectedCameraForward = Vector3.zero;
		_lastProjectedCameraForward = Vector3.zero;
		_signedCameraAngleDelta = 0f;
		_absoluteCameraAngleDelta = 0f;
		StartCooldown();
	}

	public override void Update(Blackboard blackboard, float remainingAvailableTime)
	{
		_lastProjectedCameraForward = _thisProjectedCameraForward;
		_thisProjectedCameraForward = Vector3.ProjectOnPlane(blackboard.Systems.CameraStableTransform.forward, Vector3.up);
		if (_thisProjectedCameraForward == Vector3.zero || _lastProjectedCameraForward == Vector3.zero)
		{
			return;
		}
		_signedCameraAngleDelta = Vector3.SignedAngle(_thisProjectedCameraForward, _lastProjectedCameraForward, Vector3.up);
		_absoluteCameraAngleDelta = Math.Abs(_signedCameraAngleDelta);
		UpdateActiveGlimpseEffect(blackboard);
		if (GlimpseActive)
		{
			StartCooldown();
			return;
		}
		_ = base.MaxGlimpseTime;
		if (Cooldown.Started && Cooldown.IsExpired())
		{
			float randomAngle = GetRandomAngle();
			if (_shouldUseDeadZone)
			{
				IsTargetInDeadZone(_absoluteCameraAngleDelta, randomAngle);
			}
			GlimpseEffect.SpawnGlimpse(blackboard, randomAngle, GetRandomDistance(), GetRandomCloakDelayTime(), CloakTime, Mathf.Min(GetRandomExpireTime(), remainingAvailableTime));
			GlimpseActive = true;
			Cooldown.Reset();
		}
	}

	public GlimpseActivator(GlimpseData config, CloakSettings cloakConfig, bool shouldUseDeadZone)
		: base(config, cloakConfig)
	{
		_shouldUseDeadZone = shouldUseDeadZone;
		StartCooldown();
	}

	private bool IsCameraMoving()
	{
		return _absoluteCameraAngleDelta > 0f;
	}

	private bool IsTargetInDeadZone(float targetAngle, float signedStaticAngle)
	{
		UnityEngine.Random.Range(Config.HalfAngleDeadZone.Min, Config.HalfAngleDeadZone.Min);
		return false;
	}

	private float GetRandomAngle()
	{
		float num = UnityEngine.Random.Range(Config.HalfAngleTeleport.Min, Config.HalfAngleTeleport.Max) + _absoluteCameraAngleDelta;
		if (!(_signedCameraAngleDelta >= 0f))
		{
			return num;
		}
		return 0f - num;
	}
}
