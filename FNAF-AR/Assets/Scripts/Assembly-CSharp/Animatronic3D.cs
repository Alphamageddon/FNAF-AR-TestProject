using System;
using System.Collections.Generic;
using UnityEngine;

public class Animatronic3D : MonoBehaviour
{
	private AnimatronicConfigData _animatronicConfigData;

	private PlushSuitData _plushSuitData;

	private Transform _cameraStableTransform;

	private AudioPlayer _audioPlayer;

	private AnimatronicModelConfig _modelConfig;

	private AnimationEventDispatcher _animationEventDispatcher;

	private AnimatorDispatcher _animatorDispatcher;

	private EffectsDispatcher _effectsDispatcher;

	private AudioDispatcher _audioDispatcher;

	private CloakController _cloakController;

	private Footsteps _footsteps;

	private Mover _mover;

	private Collider _collider;

	public FieldOfView FOV => _modelConfig.FieldOfView;

	private event Action<AnimationEvent> OnAnimationGameEventReceived;

	private event Action OnUpdate;

	public void SetAnimationMode(AnimationMode animationMode)
	{
		_animatorDispatcher.SetAnimationMode(animationMode);
	}

	public bool IsAnimationTagActive(AnimationTag animationTag)
	{
		return _animatorDispatcher.IsAnimationTagActive(animationTag);
	}

	public bool IsAnimating()
	{
		return _animatorDispatcher.IsAnimating();
	}

	public void SetAnimationBool(AnimationBool animationBool, bool value)
	{
		_animatorDispatcher.SetAnimationBool(animationBool, value);
	}

	public void SetAnimationInt(AnimationInt animationInt, int value)
	{
		_animatorDispatcher.SetAnimationInt(animationInt, value);
	}

	public void SetAnimationFloat(AnimationFloat animationFloat, float value)
	{
		_animatorDispatcher.SetAnimationFloat(animationFloat, value);
	}

	public void SetAnimationTrigger(AnimationTrigger animationTrigger, bool shouldSet)
	{
		_animatorDispatcher.SetAnimationTrigger(animationTrigger, shouldSet);
	}

	public void ExecuteRandomizedPose(AnimationTrigger animationTrigger)
	{
		LookAwayApproachPoseData lookAwayApproachPose = _plushSuitData.LookAwayApproachPose;
		switch (animationTrigger)
		{
		case AnimationTrigger.StartPose:
		{
			int startPoseCount = lookAwayApproachPose.StartPoseCount;
			int value7 = UnityEngine.Random.Range(0, startPoseCount);
			_animatorDispatcher.SetAnimationInt(AnimationInt.StartPoseIndex, value7);
			break;
		}
		case AnimationTrigger.InChair:
		{
			int inChairPoseCount = lookAwayApproachPose.InChairPoseCount;
			int value6 = UnityEngine.Random.Range(0, inChairPoseCount);
			_animatorDispatcher.SetAnimationInt(AnimationInt.InChairPoseIndex, value6);
			break;
		}
		case AnimationTrigger.OnFloor:
		{
			int onFloorPoseCount = lookAwayApproachPose.OnFloorPoseCount;
			int value5 = UnityEngine.Random.Range(0, onFloorPoseCount);
			_animatorDispatcher.SetAnimationInt(AnimationInt.OnFloorPoseIndex, value5);
			break;
		}
		case AnimationTrigger.BehindDoorLeft:
		{
			int behindDoorLeftPoseCount = lookAwayApproachPose.BehindDoorLeftPoseCount;
			int value4 = UnityEngine.Random.Range(0, behindDoorLeftPoseCount);
			_animatorDispatcher.SetAnimationInt(AnimationInt.BehindDoorLeftPoseIndex, value4);
			break;
		}
		case AnimationTrigger.BehindDoorRight:
		{
			int behindDoorRightPoseCount = lookAwayApproachPose.BehindDoorRightPoseCount;
			int value3 = UnityEngine.Random.Range(0, behindDoorRightPoseCount);
			_animatorDispatcher.SetAnimationInt(AnimationInt.BehindDoorRightPoseIndex, value3);
			break;
		}
		case AnimationTrigger.BehindRubble:
		{
			int behindRubblePoseCount = lookAwayApproachPose.BehindRubblePoseCount;
			int value2 = UnityEngine.Random.Range(0, behindRubblePoseCount);
			_animatorDispatcher.SetAnimationInt(AnimationInt.BehindRubblePoseIndex, value2);
			break;
		}
		case AnimationTrigger.FinalPose:
		{
			int finalPoseCount = lookAwayApproachPose.FinalPoseCount;
			int value = UnityEngine.Random.Range(0, finalPoseCount);
			_animatorDispatcher.SetAnimationInt(AnimationInt.FinalPoseIndex, value);
			break;
		}
		}
		SetAnimationTrigger(animationTrigger, shouldSet: true);
	}

	public void SetAnimatorLayerWeight(int layer, float weight)
	{
		_animatorDispatcher.SetAnimatorLayerWeight(layer, weight);
	}

	public void RaiseAudioEventAnimatronic(AudioEventName eventName, bool useCpu)
	{
		_audioDispatcher.RaiseGameEventAnimatronic(eventName, useCpu);
	}

	public void RaiseAudioEventAnimatronic(AudioEventName eventName, string prefix)
	{
		_audioDispatcher.RaiseGameEventAnimatronic(eventName, prefix);
	}

	public void RaiseAudioEventCamera(AudioEventName eventName, bool useCpu)
	{
		_audioDispatcher.RaiseGameEventCamera(eventName, useCpu);
	}

	public void RaiseAudioEventCamera(AudioEventName eventName, string prefix)
	{
		_audioDispatcher.RaiseGameEventCamera(eventName, prefix);
	}

	public void RaiseAudioEventGlobal(AudioEventName eventName, bool useCpu)
	{
		_audioDispatcher.RaiseGameEventGlobal(eventName, useCpu);
	}

	public void RaiseAudioEventGlobal(AudioEventName eventName, string prefix)
	{
		_audioDispatcher.RaiseGameEventGlobal(eventName, prefix);
	}

	public void RaiseAudioEventFromCpu(AudioEventName eventName)
	{
		_audioDispatcher.RaiseEventFromCpu(eventName);
	}

	public void RaiseAudioEventFromPlushSuit(AudioEventName eventName)
	{
		_audioDispatcher.RaiseEventFromPlushSuit(eventName);
	}

	public void SetAudioParameterAnimatronic(AudioParameterName parameterName, float value)
	{
		_audioDispatcher.SetParameterAnimatronic(parameterName, value);
	}

	public void SetAudioState(AudioStateGroupName groupName, AudioStateName stateName)
	{
		_audioDispatcher.SetState(groupName, stateName);
	}

	public void SetAudioMute(bool shouldMute)
	{
		_audioDispatcher.SetMute(shouldMute);
	}

	public CloakSettings GetCloakSettings()
	{
		if (_modelConfig != null)
		{
			return _modelConfig.CloakSettings;
		}
		return null;
	}

	public void SetEyeColorMode(EyeColorMode mode)
	{
		_effectsDispatcher.SetEyeColorMode(mode);
	}

	public void SetEyeGlow(bool eyeGlowEnabled)
	{
		_effectsDispatcher.SetEyeGlow(eyeGlowEnabled);
	}

	public Dictionary<EyeColorMode, EyeColorData> GetEyeColors()
	{
		return _effectsDispatcher._eyeOverrides;
	}

	public void SetCloakState(bool cloakEnabled)
	{
		_cloakController.SetCloakState(cloakEnabled);
	}

	public void BeginCloak()
	{
		_cloakController.BeginCloak();
	}

	public void BeginDecloak(bool shouldOpenShock = true)
	{
		_cloakController.BeginDecloak(shouldOpenShock);
	}

	public void SetEyeCloakState(bool eyeCloakEnabled)
	{
		_cloakController.SetEyeCloakState(eyeCloakEnabled);
	}

	public void BeginEyeCloak()
	{
		_cloakController.BeginEyeCloak();
	}

	public void BeginEyeDecloak()
	{
		_cloakController.BeginEyeDecloak();
	}

	public bool IsBodyFullyCloaked()
	{
		return _cloakController.BodyFullyCloaked();
	}

	public bool IsEyesFullyCloaked()
	{
		return _cloakController.EyesFullyCloaked();
	}

	public void CloseShockWindow()
	{
		ShockWindowClosed();
	}

	public void RegisterForPhantomManifestComplete(Action callback)
	{
		if (_modelConfig.PhantomFxController != null)
		{
			_modelConfig.PhantomFxController.RegisterForMeshToggle(callback);
		}
	}

	public void UnregisterForPhantomManifestComplete(Action callback)
	{
		if (_modelConfig.PhantomFxController != null)
		{
			_modelConfig.PhantomFxController.UnregisterForMeshToggle(callback);
		}
	}

	public float GetPhantomAnimationSpeedModifier()
	{
		if (_modelConfig.PhantomFxController == null)
		{
			return 1f;
		}
		return _modelConfig.PhantomFxController.GetAnimationSpeedModifier();
	}

	public float GetPhantomRepositionEffectTime()
	{
		if (_modelConfig.PhantomFxController == null)
		{
			return 0f;
		}
		if (_modelConfig.PhantomFxController.repositionVfxDuration != null)
		{
			return _modelConfig.PhantomFxController.repositionVfxDuration.GetDuration();
		}
		return 0f;
	}

	public float GetPhantomShutdownEffectTime()
	{
		if (_modelConfig.PhantomFxController == null)
		{
			return 0f;
		}
		if (_modelConfig.PhantomFxController.shutdownVfxDuration != null)
		{
			return _modelConfig.PhantomFxController.shutdownVfxDuration.GetDuration();
		}
		return 0f;
	}

	public void SetPhantomEffectAndAnimationState(PhantomFxController.States state)
	{
		if (_modelConfig.PhantomFxController != null)
		{
			_modelConfig.PhantomFxController.SetState(state);
		}
	}

	public void SetWearAndTear(int value)
	{
		_effectsDispatcher.SetWearAndTear(value);
	}

	public void TriggerRepairInterpolation()
	{
		_effectsDispatcher.TriggerRepairInterpolation();
	}

	public Vector3 GetRootBonePosition()
	{
		if (_mover == null)
		{
			return Vector3.zero;
		}
		return _mover.GetRootBonePosition();
	}

	public Vector3 GetPosition()
	{
		if (_mover == null)
		{
			return Vector3.zero;
		}
		return _mover.GetPosition();
	}

	public Vector3 GetForward()
	{
		if (_mover == null)
		{
			return Vector3.forward;
		}
		return _mover.GetForward();
	}

	public MovementSettings GetMovementSettings()
	{
		return _modelConfig.MovementSettings;
	}

	public void SetMovementMode(SpaceMover.Mode mode)
	{
		if (_mover != null)
		{
			_mover.SetMovementMode(mode);
		}
	}

	public void SetTransformOverrideMode(TransformOverrider.Mode mode)
	{
		if (_mover != null)
		{
			_mover.SetTransformOverrideMode(mode);
		}
	}

	public float GetAbsoluteAngleBetweenPositionAndCamera(Vector3 position)
	{
		if (_mover == null)
		{
			return 0f;
		}
		return _mover.GetAbsoluteAngleBetweenPositionAndCamera(position);
	}

	public float GetSignedAngleBetweenPositionAndCamera(Vector3 position)
	{
		if (_mover == null)
		{
			return 0f;
		}
		return _mover.GetSignedAngleBetweenPositionAndCamera(position);
	}

	public float GetAbsoluteAngleFromCamera()
	{
		if (_mover == null)
		{
			return 0f;
		}
		return _mover.GetAbsoluteAngleFromCamera();
	}

	public float GetSignedAngleFromCamera()
	{
		if (_mover == null)
		{
			return 0f;
		}
		return _mover.GetSignedAngleFromCamera();
	}

	public float GetDistanceFromCamera()
	{
		if (_mover == null)
		{
			return 0f;
		}
		return _mover.GetDistanceFromCamera();
	}

	public void Teleport(float angleFromCamera, float distanceFromCamera, bool faceCamera)
	{
		if (_mover != null)
		{
			Debug.LogWarning("teleport request receieved. Angle - " + angleFromCamera + " Distance - " + distanceFromCamera);
			_mover.Teleport(angleFromCamera, distanceFromCamera, faceCamera);
		}
	}

	public void TeleportToLocalPosition(Vector3 position, Vector3 forward)
	{
		if (_mover != null)
		{
			_mover.TeleportToLocalPosition(position, forward);
		}
	}

	public void TeleportInFrontOfCamera(float distanceFromCamera)
	{
		if (_mover != null)
		{
			_mover.TeleportInFrontOfCamera(distanceFromCamera);
		}
	}

	public void TeleportAtCurrentAngle(float distanceFromCamera)
	{
		if (_mover != null)
		{
			_mover.TeleportAtCurrentAngle(distanceFromCamera);
		}
	}

	public void InvertFacing()
	{
		if (_mover != null)
		{
			_mover.InvertFacing();
		}
	}

	public void RotateFacingInWorkshop(Vector3 mPrevPos, Vector3 mCurrPos)
	{
		if (_mover != null)
		{
			_mover.RotateFacingInWorkshop(mPrevPos, mCurrPos);
		}
	}

	public void ResetFacing()
	{
		if (_mover != null)
		{
			_mover.ResetFacing();
		}
	}

	public void ReparentUnderAnimatronic(Transform other)
	{
		other.SetParent(base.transform);
	}

	public bool IsMoving()
	{
		if (_mover == null)
		{
			return false;
		}
		return _mover.IsMoving();
	}

	public void StopMoving()
	{
		if (_mover != null)
		{
			_mover.StopMovement();
		}
	}

	public float GetMoveSpeed()
	{
		if (_mover == null)
		{
			return 0f;
		}
		return _mover.GetMoveSpeed();
	}

	public void MoveInCircleAroundCamera(float degreesPerSecond, bool isWalking, float duration = -1f)
	{
		if (_mover != null)
		{
			_mover.MoveInCircleAroundCamera(degreesPerSecond, isWalking, duration);
		}
		_footsteps.SetMovementMode(isWalking);
	}

	public void MoveInLineTowardCamera(float unitsPerSecond, bool isWalking, float duration = -1f)
	{
		if (_mover != null)
		{
			_mover.MoveInLineTowardCamera(unitsPerSecond, isWalking, duration);
		}
		_footsteps.SetMovementMode(isWalking);
	}

	public void MoveFollowWaypoints(float unitsPerSecond, bool isWalking, float duration = -1f)
	{
		if (_mover != null)
		{
			_mover.MoveFollowWaypoints(unitsPerSecond, isWalking, duration);
		}
		_footsteps.SetMovementMode(isWalking);
	}

	public void ScavengingTeleportToStartPoint(ScavengingEnvironment env)
	{
		if (_mover != null)
		{
			_mover.ScavengingTeleportToStartPoint(env);
		}
	}

	public void SwapWaypointIncrement()
	{
		if (_mover != null)
		{
			_mover.SwapWaypointIncrement();
		}
	}

	public void SetFootstepConfig(FootstepConfigData walkConfigData, FootstepConfigData runConfigData)
	{
		_footsteps.SetFootstepConfig(walkConfigData, runConfigData);
	}

	public void SetFootstepEffectCallback(Footsteps.FootstepEffectTriggered callback)
	{
		_footsteps.OnFootstepEffectTriggered += callback;
	}

	public bool IsAABBInCameraFrustum(Camera cameraToTest)
	{
		Plane[] planes = GeometryUtility.CalculateFrustumPlanes(cameraToTest);
		if (_modelConfig.AABBCollider != null)
		{
			return GeometryUtility.TestPlanesAABB(planes, _modelConfig.AABBCollider.bounds);
		}
		return false;
	}

	public bool IsOnScreen(Camera cameraToTest, ShockTargetBorderData shockTargetBorder)
	{
		Vector3 vector = cameraToTest.WorldToViewportPoint(_modelConfig.ModelTransforms.RootBone.position);
		if (cameraToTest == null || !cameraToTest.isActiveAndEnabled)
		{
			return false;
		}
		float num;
		float num2;
		float num3;
		float num4;
		if (shockTargetBorder == null)
		{
			num = 0.1f;
			num2 = -0.1f;
			num3 = -0.5f;
			num4 = 0.5f;
		}
		else
		{
			num = shockTargetBorder.XMin;
			num2 = shockTargetBorder.XMax;
			num3 = shockTargetBorder.YMin;
			num4 = shockTargetBorder.YMax;
		}
		bool flag = vector.x <= num2 + num4 + 1f;
		flag = vector.y <= num2 + 1f && flag;
		flag = vector.x >= num + 0f && flag;
		flag = vector.y <= num4 + 1f && flag;
		flag = vector.y >= num3 + 0f && flag;
		return vector.z > 0f && flag;
	}

	public void RegisterForAnimationGameEvents(Action<AnimationEvent> eventReceived)
	{
		OnAnimationGameEventReceived += eventReceived;
	}

	public void UnregisterFromAnimationGameEvents(Action<AnimationEvent> eventReceived)
	{
		OnAnimationGameEventReceived -= eventReceived;
	}

	public void RegisterUpdateCallback(Action update)
	{
		OnUpdate += update;
	}

	public void UnregisterUpdateCallback(Action update)
	{
		OnUpdate -= update;
	}

	public void SetVisible(bool isVisible)
	{
		base.gameObject.SetActive(isVisible);
	}

	public AnimatronicModelConfig GetModelConfig()
	{
		return _modelConfig;
	}

	public Bounds GetModelBounds()
	{
		if (_collider != null)
		{
			return _collider.bounds;
		}
		return new Bounds(new Vector3(0f, 0f, 0f), new Vector3(0f, 0f, 0f));
	}

	private void AnimationGameEventReceived(AnimationEvent animationEvent)
	{
		this.OnAnimationGameEventReceived?.Invoke(animationEvent);
	}

	private void ShockWindowOpened()
	{
		Debug.Log("SHOCK WINDOW OPENED");
		AnimationEvent animationEvent = new AnimationEvent();
		animationEvent.intParameter = 2000;
		_animationEventDispatcher.AnimationEventReceived(animationEvent);
	}

	private void ShockWindowClosed()
	{
		AnimationEvent animationEvent = new AnimationEvent();
		animationEvent.intParameter = 2001;
		_animationEventDispatcher.AnimationEventReceived(animationEvent);
	}

	public void BeginShockFxScavenging()
	{
		_effectsDispatcher.BeginShockFxScavenging();
	}

	public void StopShockFxScavenging()
	{
		_effectsDispatcher.StopShockFxScavenging();
	}

	public void Setup(AnimatronicConfigData configData, AudioMode audioMode, Transform cameraStableTransform)
	{
		SetupCommon(configData, audioMode, cameraStableTransform);
		_mover = new Mover(cameraStableTransform, base.transform, _animatorDispatcher, _modelConfig, _cloakController);
	}

	public void SetupForModelViewer(AnimatronicConfigData configData, AudioMode audioMode)
	{
		SetupCommon(configData, audioMode);
	}

	public void SetupCommon(AnimatronicConfigData configData, AudioMode audioMode, Transform cameraStableTransform = null)
	{
		if (_modelConfig == null)
		{
			Debug.LogError("SETUP COMMON IS FAILING CUZ MODEL CONFIG IS NULL..");
		}
		_animatronicConfigData = configData;
		_plushSuitData = configData.PlushSuitData;
		_cameraStableTransform = cameraStableTransform;
		_animationEventDispatcher = new AnimationEventDispatcher();
		_animationEventDispatcher.Setup(_modelConfig.AnimationEventListener);
		_animatorDispatcher = new AnimatorDispatcher();
		_animatorDispatcher.Setup(_modelConfig.Animator);
		_audioDispatcher = new AudioDispatcher();
		_audioDispatcher.Setup(configData.CpuData.SoundBankName, configData.PlushSuitData.SoundBankName, _audioPlayer, _modelConfig.AnimatronicAudioManager, audioMode);
		_footsteps = new Footsteps(_audioDispatcher);
		_cloakController = new CloakController(_modelConfig.CloakSettings);
		_effectsDispatcher = new EffectsDispatcher();
		_effectsDispatcher.Setup(_modelConfig, _footsteps, configData.CpuData);
		_animationEventDispatcher.OnSoundEventReceived += _audioDispatcher.SoundEventReceived;
		_animationEventDispatcher.OnGameEventReceived += AnimationGameEventReceived;
		_animationEventDispatcher.OnEffectEventReceived += _effectsDispatcher.EffectEventReceived;
		_cloakController.OnShockWindowOpened += ShockWindowOpened;
		_collider = GetComponentInChildren<Collider>();
	}

	public void Teardown()
	{
		Debug.LogError("TEARING DOWN ANIM3D");
		if (_animationEventDispatcher != null)
		{
			_animationEventDispatcher.OnSoundEventReceived -= _audioDispatcher.SoundEventReceived;
			_animationEventDispatcher.OnGameEventReceived -= AnimationGameEventReceived;
			_animationEventDispatcher.OnEffectEventReceived -= _effectsDispatcher.EffectEventReceived;
		}
		if (_cloakController != null)
		{
			_cloakController.OnShockWindowOpened -= ShockWindowOpened;
		}
		if (_mover != null)
		{
			_mover.Teardown();
		}
		_mover = null;
		if (_audioDispatcher != null)
		{
			_audioDispatcher.Teardown();
		}
		_audioDispatcher = null;
		if (_effectsDispatcher != null)
		{
			_effectsDispatcher.Teardown();
		}
		_effectsDispatcher = null;
		if (_animatorDispatcher != null)
		{
			_animatorDispatcher.Teardown();
		}
		_animatorDispatcher = null;
		if (_footsteps != null)
		{
			_footsteps.Teardown();
		}
		_footsteps = null;
		if (_animationEventDispatcher != null)
		{
			_animationEventDispatcher.Teardown();
		}
		_animationEventDispatcher = null;
		UnityEngine.Object.Destroy(_modelConfig);
		_cloakController = null;
		_audioPlayer = null;
		_modelConfig = null;
		_cameraStableTransform = null;
		UnityEngine.Object.Destroy(base.gameObject);
	}

	private void Update()
	{
		if (this.OnUpdate != null)
		{
			this.OnUpdate();
		}
		if (_mover != null)
		{
			_mover.Update();
			if (_mover.IsMoving())
			{
				_footsteps.Update(_mover.GetDistanceFromCamera());
			}
		}
	}

	private void LateUpdate()
	{
		if (_mover != null)
		{
			_mover.LateUpdate();
		}
	}

	public void SetAudioPlayer(AudioPlayer audioPlayer)
	{
		_audioPlayer = audioPlayer;
	}

	public void SetModelConfig(AnimatronicModelConfig modelConfig)
	{
		_modelConfig = modelConfig;
		modelConfig.transform.SetParent(base.transform, worldPositionStays: false);
	}
}
