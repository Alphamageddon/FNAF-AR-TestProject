using System;
using UnityEngine;

public class Mover
{
	private Transform _cameraStableTransform;

	private Transform _animatronicPrefabTransform;

	private Transform _rootBone;

	private Transform _transformBone;

	private AnimatorDispatcher _animatorDispatcher;

	private SpaceMover _spaceMover;

	private readonly TransformOverrider _transformOverrider;

	private bool _isWalking;

	private float _workshopRotationSpeed;

	public Vector3 GetRootBonePosition()
	{
		return _rootBone.position;
	}

	public Vector3 GetPosition()
	{
		return _animatronicPrefabTransform.localPosition;
	}

	public Vector3 GetForward()
	{
		return _animatronicPrefabTransform.forward;
	}

	public void SetMovementMode(SpaceMover.Mode mode)
	{
		switch (mode)
		{
		case SpaceMover.Mode.LOCAL:
			SetTransformOverrideMode(TransformOverrider.Mode.AttackLocal);
			break;
		case SpaceMover.Mode.GLOBAL:
			SetTransformOverrideMode(TransformOverrider.Mode.AttackGlobal);
			break;
		case SpaceMover.Mode.SCAVENGING:
			SetTransformOverrideMode(TransformOverrider.Mode.Scavenging);
			break;
		default:
			SetTransformOverrideMode(TransformOverrider.Mode.AttackLocal);
			break;
		}
		_spaceMover.SetMoveTowardsCameraMode(mode);
	}

	public void SetTransformOverrideMode(TransformOverrider.Mode mode)
	{
		_transformOverrider.SetOverrideMode(mode);
	}

	public float GetAbsoluteAngleBetweenPositionAndCamera(Vector3 position)
	{
		return Math.Abs(GetSignedAngleBetweenPositionAndCamera(position));
	}

	public float GetAbsoluteAngleFromCamera()
	{
		return GetAbsoluteAngleBetweenPositionAndCamera(GetRootBonePosition());
	}

	public float GetSignedAngleBetweenPositionAndCamera(Vector3 position)
	{
		return Vector3.SignedAngle(position, _cameraStableTransform.forward, Vector3.up);
	}

	public float GetSignedAngleFromCamera()
	{
		return GetSignedAngleBetweenPositionAndCamera(GetRootBonePosition());
	}

	public float GetDistanceFromCamera()
	{
		return _spaceMover.GetDistanceFromCamera();
	}

	public void Teleport(float angleFromCamera, float distanceFromCamera, bool faceCamera)
	{
		if (_cameraStableTransform == null)
		{
			Debug.LogError("Animatronic3D Mover Teleport - Camera transform is null. Cannot teleport");
			return;
		}
		Vector3 vector = Vector3.ProjectOnPlane(_cameraStableTransform.forward, Vector3.up);
		Vector3 vector2 = Quaternion.AngleAxis(angleFromCamera, Vector3.up) * vector * ((Math.Abs(distanceFromCamera) == 0f) ? 0.001f : distanceFromCamera);
		_animatronicPrefabTransform.position = _cameraStableTransform.position + vector2;
		Debug.Log("DISTANCE IS - " + GetDistanceFromCamera());
		if (faceCamera)
		{
			Vector3 vector3 = _cameraStableTransform.position - _animatronicPrefabTransform.position;
			_animatronicPrefabTransform.forward = Vector3.ProjectOnPlane(vector3, Vector3.up);
		}
		VerifyAnimatronicPrefabUpVectorMatchesWorld("Teleport");
	}

	public void TeleportToLocalPosition(Vector3 position, Vector3 forward)
	{
		_animatronicPrefabTransform.localPosition = position;
		_animatronicPrefabTransform.forward = forward;
		VerifyAnimatronicPrefabUpVectorMatchesWorld("TeleportToLocalPosition");
	}

	public void TeleportInFrontOfCamera(float distanceFromCamera)
	{
		if (_cameraStableTransform == null)
		{
			Debug.LogError("Animatronic3D Teleport - Camera transform is null. Cannot teleport");
			return;
		}
		Teleport(0f, distanceFromCamera, faceCamera: true);
		VerifyAnimatronicPrefabUpVectorMatchesWorld("TeleportInFrontOfCamera");
	}

	public void TeleportAtCurrentAngle(float distanceFromCamera)
	{
		if (_cameraStableTransform == null)
		{
			Debug.LogError("Animatronic3D Teleport - Camera transform is null. Cannot teleport");
			return;
		}
		Vector3 normalized = (_animatronicPrefabTransform.position - _cameraStableTransform.position).normalized;
		_animatronicPrefabTransform.position = _cameraStableTransform.position + normalized * distanceFromCamera;
		_animatronicPrefabTransform.forward = (_cameraStableTransform.position - _animatronicPrefabTransform.position).normalized;
		VerifyAnimatronicPrefabUpVectorMatchesWorld("TeleportAtCurrentAngle");
	}

	public void ScavengingTeleportToStartPoint(ScavengingEnvironment env)
	{
		_spaceMover.ScavengingTeleportToStartPoint(env);
	}

	public void SwapWaypointIncrement()
	{
		_spaceMover.SwapWaypointIncrement();
	}

	public void InvertFacing()
	{
		_animatronicPrefabTransform.forward = -_animatronicPrefabTransform.forward;
	}

	public void RotateFacingInWorkshop(Vector3 mPrevPos, Vector3 mCurrPos)
	{
		_transformBone.Rotate(0f, 0f - (mCurrPos.x - mPrevPos.x) * _workshopRotationSpeed, 0f, Space.Self);
	}

	public void ResetFacing()
	{
		_transformBone.localEulerAngles = new Vector3(_transformBone.localRotation.x, 0f, _transformBone.localRotation.z);
	}

	public bool IsMoving()
	{
		return _spaceMover.IsMoving;
	}

	public void StopMovement()
	{
		_spaceMover.StopMovement();
	}

	public float GetMoveSpeed()
	{
		return _spaceMover.GetMoveSpeed();
	}

	public void MoveInCircleAroundCamera(float degreesPerSecond, bool isWalking, float duration = -1f)
	{
		_isWalking = isWalking;
		_spaceMover.MoveInCircleAroundOrigin(degreesPerSecond, duration);
	}

	public void MoveInLineTowardCamera(float unitsPerSecond, bool isWalking, float duration = -1f)
	{
		_isWalking = isWalking;
		_spaceMover.MoveInLineTowardOrigin(unitsPerSecond, duration);
	}

	public void MoveFollowWaypoints(float unitsPerSecond, bool isWalking, float duration = -1f)
	{
		_isWalking = isWalking;
		_spaceMover.MoveFollowWaypoints(unitsPerSecond, duration);
	}

	public void Update()
	{
		_spaceMover.Update();
		VerifyAnimatronicPrefabUpVectorMatchesWorld("Update");
	}

	public void LateUpdate()
	{
		_transformOverrider.LateUpdate();
		VerifyAnimatronicPrefabUpVectorMatchesWorld("LateUpdate");
	}

	private void VerifyAnimatronicPrefabUpVectorMatchesWorld(string callingFunction)
	{
		if (!_transformOverrider.IsFollowingCameraPosition())
		{
			float num = Vector3.Dot(_animatronicPrefabTransform.up, Vector3.up);
			if (!(1f - num <= 0.0001f))
			{
				Debug.LogError("Mover VerifyAnimatronicPrefabUpVectorMatchesWorld - The animatronic is not upright.");
			}
		}
	}

	private void StartedMoving()
	{
		_animatorDispatcher.SetAnimationBool(AnimationBool.IsWalking, _isWalking);
	}

	private void StoppedMoving()
	{
		_animatorDispatcher.SetAnimationBool(AnimationBool.IsWalking, value: false);
	}

	public Mover(Transform cameraStableTransform, Transform animatronic3DTransform, AnimatorDispatcher animatorDispatcher, AnimatronicModelConfig animatronicModelConfig, CloakController cloakController)
	{
		_cameraStableTransform = cameraStableTransform;
		_animatronicPrefabTransform = animatronicModelConfig.ModelTransforms.PrefabTransform;
		_rootBone = animatronicModelConfig.ModelTransforms.RootBone;
		_transformBone = animatronicModelConfig.ModelTransforms.TransformBone;
		_animatorDispatcher = animatorDispatcher;
		_spaceMover = new SpaceMover(_animatronicPrefabTransform, _cameraStableTransform);
		_transformOverrider = new TransformOverrider(_cameraStableTransform, animatronic3DTransform, animatronicModelConfig.ModelTransforms, animatronicModelConfig.AdditionalOffsets, cloakController, animatronicModelConfig.AABBCollider, animatronicModelConfig.AnimatronicMaterialController);
		float num = (float)Screen.width * 0.5f;
		_workshopRotationSpeed = 180f / num;
		_spaceMover.add_OnStartedMoving(StartedMoving);
		_spaceMover.add_OnStoppedMoving(StoppedMoving);
	}

	public void Teardown()
	{
		_spaceMover.remove_OnStartedMoving(StartedMoving);
		_spaceMover.remove_OnStoppedMoving(StoppedMoving);
		_transformOverrider.Teardown();
		_spaceMover.Teardown();
		_rootBone = null;
		_animatorDispatcher = null;
		_cameraStableTransform = null;
	}
}
