using UnityEngine;

public class TransformOverrider
{
	public enum Mode
	{
		None = 0,
		AttackLocal = 1,
		AttackGlobal = 2,
		Jumpscare = 3,
		JumpscareGlobal = 4,
		Workshop = 5,
		Scavenging = 6
	}

	private Transform _cameraStableTransform;

	private Transform _animatronic3DTransform;

	private ModelTransforms _transforms;

	private AdditionalOffsets _offsets;

	private BoxCollider _aabbCollider;

	private CloakController _cloakController;

	private Vector3 _additionalOffset;

	private Vector3 _additionalRotation;

	private Vector3 _colliderCenter;

	private bool _shouldOverrideAnimatedTransformBone;

	private bool _shouldOverrideAnimatedRootBone;

	private bool _shouldOverrideAnimatedCloakPlane;

	private bool _shouldOverrideAnimatedEyeCloakPlane;

	private bool _shouldOverridePrefabDirectly;

	private bool _shouldFollowCameraPosition;

	private bool _shouldFollowCameraRotation;

	private Mode _offsetMode;

	private AnimatronicMaterialController matController;

	private StableTransformDebug stableDebug;

	public bool IsFollowingCameraPosition()
	{
		return _shouldFollowCameraPosition;
	}

	public bool IsFollowingCameraRotation()
	{
		return _shouldFollowCameraRotation;
	}

	public void SetOverrideMode(Mode mode)
	{
		_offsetMode = mode;
		UpdateOverrides();
	}

	public void LateUpdate()
	{
		if (stableDebug == null && _cameraStableTransform != null)
		{
			stableDebug = _cameraStableTransform.gameObject.GetComponent<StableTransformDebug>();
		}
		if (_offsets.ShouldUpdateEveryFrame)
		{
			UpdateOverrides();
		}
		UpdateAnimatronic3DPosition();
		UpdateAnimatronic3DRotation();
		SetAdditionalOffset();
		OverrideAnimatedTransformBone();
		OverrideAnimatedRootBone();
		OverrideAnimatedCloakPlane();
		OverrideAnimatedEyeCloakPlane();
		if (matController != null)
		{
			matController.LaterUpdater();
		}
	}

	private void UpdateOverrides()
	{
		switch (_offsetMode)
		{
		case Mode.None:
			_additionalOffset = Vector3.zero;
			_additionalRotation = Vector3.zero;
			break;
		case Mode.AttackLocal:
			_shouldOverrideAnimatedCloakPlane = true;
			_shouldOverrideAnimatedEyeCloakPlane = true;
			_shouldFollowCameraPosition = true;
			_shouldFollowCameraRotation = false;
			_shouldOverrideAnimatedTransformBone = true;
			_shouldOverrideAnimatedRootBone = true;
			_additionalOffset = _offsets.AttackOffset;
			_additionalRotation = _offsets.AttackRotation;
			_shouldOverridePrefabDirectly = false;
			break;
		case Mode.AttackGlobal:
			_shouldOverrideAnimatedCloakPlane = true;
			_shouldOverrideAnimatedEyeCloakPlane = true;
			_shouldFollowCameraPosition = false;
			_shouldFollowCameraRotation = false;
			_shouldOverrideAnimatedTransformBone = true;
			_shouldOverrideAnimatedRootBone = true;
			_additionalOffset = _offsets.AttackOffset;
			_additionalRotation = _offsets.AttackRotation;
			_shouldOverridePrefabDirectly = true;
			break;
		case Mode.Jumpscare:
			_shouldOverrideAnimatedCloakPlane = false;
			_shouldOverrideAnimatedEyeCloakPlane = false;
			_shouldFollowCameraPosition = true;
			_shouldFollowCameraRotation = true;
			_shouldOverrideAnimatedTransformBone = false;
			_shouldOverrideAnimatedRootBone = false;
			_additionalOffset = _offsets.JumpscareOffset;
			_additionalRotation = _offsets.JumpscareRotation;
			_shouldOverridePrefabDirectly = false;
			break;
		case Mode.JumpscareGlobal:
			_shouldOverrideAnimatedCloakPlane = false;
			_shouldOverrideAnimatedEyeCloakPlane = false;
			_shouldFollowCameraPosition = true;
			_shouldFollowCameraRotation = true;
			_shouldOverrideAnimatedTransformBone = false;
			_shouldOverrideAnimatedRootBone = false;
			_additionalOffset = _offsets.JumpscareOffset;
			_additionalRotation = _offsets.JumpscareRotation;
			_shouldOverridePrefabDirectly = true;
			break;
		case Mode.Workshop:
			_shouldOverrideAnimatedCloakPlane = true;
			_shouldOverrideAnimatedEyeCloakPlane = false;
			_shouldFollowCameraPosition = false;
			_shouldFollowCameraRotation = false;
			_shouldOverrideAnimatedTransformBone = false;
			_shouldOverrideAnimatedRootBone = false;
			_additionalOffset = _offsets.WorkshopOffset;
			_additionalRotation = _offsets.WorkshopRotation;
			_shouldOverridePrefabDirectly = false;
			break;
		case Mode.Scavenging:
			_shouldOverrideAnimatedCloakPlane = true;
			_shouldOverrideAnimatedEyeCloakPlane = true;
			_shouldFollowCameraPosition = false;
			_shouldFollowCameraRotation = false;
			_shouldOverrideAnimatedTransformBone = true;
			_shouldOverrideAnimatedRootBone = true;
			_additionalOffset = _offsets.ScavengingOffset;
			_additionalRotation = Vector3.zero;
			_shouldOverridePrefabDirectly = true;
			break;
		}
	}

	private void UpdateAnimatronic3DPosition()
	{
		if (_shouldFollowCameraPosition && !(_cameraStableTransform == null))
		{
			if (_shouldOverridePrefabDirectly)
			{
				_transforms.PrefabTransform.position = _cameraStableTransform.position;
			}
			else
			{
				_animatronic3DTransform.position = _cameraStableTransform.position;
			}
		}
	}

	private void UpdateAnimatronic3DRotation()
	{
		if (!_shouldFollowCameraRotation)
		{
			_animatronic3DTransform.localEulerAngles = Vector3.zero;
			return;
		}
		Transform transform = _cameraStableTransform;
		if ((_offsetMode == Mode.Jumpscare || _offsetMode == Mode.JumpscareGlobal) && stableDebug != null)
		{
			transform = stableDebug.playerTransform;
		}
		if (!_shouldOverridePrefabDirectly)
		{
			_animatronic3DTransform.forward = transform.forward;
			_transforms.PrefabTransform.localEulerAngles = Vector3.zero;
		}
		else
		{
			_transforms.PrefabTransform.forward = transform.forward;
			_transforms.PrefabTransform.eulerAngles = transform.eulerAngles;
		}
	}

	private void SetAdditionalOffset()
	{
		_transforms.ModelRoot.localPosition = _additionalOffset;
		_transforms.ModelRoot.localEulerAngles = _additionalRotation;
		Vector3 vector = _aabbCollider.size.y * Vector3.up / 2f;
		_aabbCollider.center = _colliderCenter + _additionalOffset + vector;
	}

	private void OverrideAnimatedTransformBone()
	{
		if (_shouldOverrideAnimatedTransformBone)
		{
			_transforms.TransformBone.localPosition = new Vector3
			{
				x = Vector3.zero.x,
				y = Vector3.zero.y + -0.5f,
				z = Vector3.zero.z
			};
		}
	}

	private void OverrideAnimatedRootBone()
	{
		if (_shouldOverrideAnimatedRootBone)
		{
			_transforms.RootBone.localPosition = Vector3.zero;
		}
	}

	private void OverrideAnimatedCloakPlane()
	{
		if (_shouldOverrideAnimatedCloakPlane)
		{
			_transforms.CloakPlaneBone.localPosition = _cloakController.GetCloakPlanePosition();
		}
	}

	private void OverrideAnimatedEyeCloakPlane()
	{
		if (_shouldOverrideAnimatedEyeCloakPlane)
		{
			_transforms.EyeCloakPlane.localPosition = _cloakController.GetEyeCloakPlanePosition();
		}
		else
		{
			_transforms.EyeCloakPlane.localPosition = _transforms.CloakPlaneBone.localPosition;
		}
	}

	public TransformOverrider(Transform cameraStableTransform, Transform animatronic3DTransform, ModelTransforms modelTransforms, AdditionalOffsets additionalOffsets, CloakController cloakController, BoxCollider aabbCollider, AnimatronicMaterialController materialController)
	{
		_cameraStableTransform = cameraStableTransform;
		if (cameraStableTransform == null)
		{
			Debug.LogError("STABLE TRANSFORM IS NULL FOR TRANSFORM OVERRIDER");
		}
		_animatronic3DTransform = animatronic3DTransform;
		_transforms = modelTransforms;
		_offsets = additionalOffsets;
		_cloakController = cloakController;
		_aabbCollider = aabbCollider;
		matController = materialController;
		_colliderCenter = aabbCollider.center;
		_offsetMode = Mode.None;
		UpdateOverrides();
	}

	public void Teardown()
	{
		_cloakController = null;
		_cameraStableTransform = null;
		_transforms = null;
	}
}
