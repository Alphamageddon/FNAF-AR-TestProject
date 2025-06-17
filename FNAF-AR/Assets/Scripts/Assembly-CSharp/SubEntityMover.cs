using System.Collections.Generic;
using UnityEngine;

public class SubEntityMover
{
	private enum SubEntityState
	{
		Inactive = 1,
		Cooldown = 2,
		SpawnAnimation = 3,
		ActiveLifetime = 4,
		DespawnAnimation = 5,
		Jumpscare = 6
	}

	private Blackboard _blackboard;

	private AttackProfile originalProfile;

	private Transform cameraStableTransform;

	private Transform jumpscarePlayerTransform;

	private ModifiedGlitchShader glitchShader;

	private AudioPlayer audioPlayer;

	private GameObject model;

	private Animator modelAnimator;

	private SkinnedMeshRenderer modelRenderer;

	private BoxCollider modelCollider;

	private LineRenderer[] mxesLines;

	private SubEntityData settings;

	private bool isRunning;

	private SubEntityState currentState = SubEntityState.Inactive;

	private float circleSpeed;

	private SimpleTimer activationCooldownTimer = new SimpleTimer();

	private SimpleTimer teleportCooldownTimer = new SimpleTimer();

	private SimpleTimer undoJumpscareEffectTimer = new SimpleTimer();

	private float lifeTimeCounter;

	private float deactivationTime;

	private float jumpscareTime;

	private bool deactivationTimeChangedLastFrame;

	private List<float> generatedTeleportDistances;

	private float currentTeleportDistance;

	public void Setup(Transform stableTransform, GameObject prefab, SubEntityData data, Blackboard blackBoard, AttackProfile profile, ModifiedGlitchShader glitch)
	{
		cameraStableTransform = stableTransform;
		jumpscarePlayerTransform = stableTransform.GetComponent<StableTransformDebug>().playerTransform;
		model = prefab;
		modelAnimator = model.GetComponent<Animator>();
		modelRenderer = model.GetComponentInChildren<SkinnedMeshRenderer>();
		modelCollider = model.GetComponent<BoxCollider>();
		mxesLines = model.GetComponentsInChildren<LineRenderer>();
		SetModelVisibility(visible: false);
		settings = data;
		_blackboard = blackBoard;
		originalProfile = profile;
		glitchShader = glitch;
		circleSpeed = 0f;
		deactivationTimeChangedLastFrame = false;
		audioPlayer = MasterDomain.GetDomain().GameAudioDomain.AudioPlayer;
		generatedTeleportDistances = null;
		Debug.Log("STATE IS NOW COOLDOWN!");
		currentState = SubEntityState.Cooldown;
		LoadSoundBank();
		isRunning = true;
	}

	private void LoadSoundBank()
	{
		SoundBankRequest soundBankRequest = new SoundBankRequest();
		soundBankRequest.SoundBankName = settings.SoundBank;
		soundBankRequest.Success = SoundBankSuccess;
		audioPlayer.SoundBankLoader.RequestSoundBank(soundBankRequest);
	}

	private void SoundBankSuccess(string name)
	{
		Debug.Log("SoundBank " + name + " loaded for SubEntity");
	}

	public void Update()
	{
		if (!isRunning)
		{
			return;
		}
		if (settings.Movement.HideIfMaskOff && (currentState == SubEntityState.ActiveLifetime || currentState == SubEntityState.DespawnAnimation || currentState == SubEntityState.SpawnAnimation))
		{
			if (_blackboard.Systems.Mask.IsMaskFullyOff())
			{
				SetModelVisibility(visible: false);
			}
			else
			{
				SetModelVisibility(visible: true);
			}
		}
		UpdateActivation();
		UpdateAnimations();
		UpdateMovement();
		UpdateEffects();
		UpdateJumpscare();
	}

	private void UpdateActivation()
	{
		if (currentState == SubEntityState.Cooldown)
		{
			SetModelVisibility(visible: false);
			if (!activationCooldownTimer.Started)
			{
				activationCooldownTimer.StartTimer(settings.Activation.Cooldown);
			}
			else
			{
				if (!activationCooldownTimer.Started || !activationCooldownTimer.IsExpired())
				{
					return;
				}
				switch (settings.Activation.ActivationType)
				{
				case SubEntityData.SubEntityActivationType.Automatic:
					deactivationTime = 0f;
					jumpscareTime = 0f;
					activationCooldownTimer.Reset();
					ActivateModel();
					break;
				case SubEntityData.SubEntityActivationType.FlashlightOn:
					if (_blackboard.Systems.Flashlight.IsOn)
					{
						deactivationTime = 0f;
						jumpscareTime = 0f;
						activationCooldownTimer.Reset();
						ActivateModel();
					}
					break;
				}
			}
		}
		else
		{
			if (currentState != SubEntityState.ActiveLifetime)
			{
				return;
			}
			if (deactivationTime >= settings.Activation.DeactivationTime)
			{
				if (settings.Activation.DeactivationRequirement == SubEntityData.SubEntityDeactivationRequirement.Glimpse && IsModelOnScreen())
				{
					return;
				}
				deactivationTime = 0f;
				teleportCooldownTimer.Reset();
				switch (settings.Activation.DeactivationType)
				{
				case SubEntityData.SubEntityDeactivationType.Instant:
					DeactivateModel();
					break;
				case SubEntityData.SubEntityDeactivationType.TeleportDistance:
					if (generatedTeleportDistances.IndexOf(currentTeleportDistance) < 1)
					{
						DeactivateModel();
						break;
					}
					currentTeleportDistance = generatedTeleportDistances[generatedTeleportDistances.IndexOf(currentTeleportDistance) - 1];
					Teleport(Random.Range(-180f, 180f), currentTeleportDistance, faceCamera: true);
					break;
				}
				return;
			}
			switch (settings.Activation.DeactivationRequirement)
			{
			case SubEntityData.SubEntityDeactivationRequirement.Automatic:
				deactivationTime += Time.deltaTime;
				if (!deactivationTimeChangedLastFrame)
				{
					audioPlayer.RaiseGameEventForModeWithOverride(AudioEventName.SubEntityBurn, settings.Logical, AudioMode.Camera);
				}
				deactivationTimeChangedLastFrame = true;
				return;
			case SubEntityData.SubEntityDeactivationRequirement.FlashlightLookAt:
				if (_blackboard.Systems.Flashlight.IsOn && IsModelOnScreen())
				{
					deactivationTime += Time.deltaTime;
					if (!deactivationTimeChangedLastFrame)
					{
						audioPlayer.RaiseGameEventForModeWithOverride(AudioEventName.SubEntityBurn, settings.Logical, AudioMode.Camera);
					}
					deactivationTimeChangedLastFrame = true;
					return;
				}
				break;
			case SubEntityData.SubEntityDeactivationRequirement.MaskOnLookAt:
				if (_blackboard.Systems.Mask.IsMaskFullyOn() && IsModelOnScreen())
				{
					deactivationTime += Time.deltaTime;
					if (!deactivationTimeChangedLastFrame)
					{
						audioPlayer.RaiseGameEventForModeWithOverride(AudioEventName.SubEntityBurn, settings.Logical, AudioMode.Camera);
					}
					deactivationTimeChangedLastFrame = true;
					return;
				}
				break;
			case SubEntityData.SubEntityDeactivationRequirement.FlashlightOff:
				if (!_blackboard.Systems.Flashlight.IsOn)
				{
					deactivationTime += Time.deltaTime;
					if (!deactivationTimeChangedLastFrame)
					{
						audioPlayer.RaiseGameEventForModeWithOverride(AudioEventName.SubEntityBurn, settings.Logical, AudioMode.Camera);
					}
					deactivationTimeChangedLastFrame = true;
					return;
				}
				break;
			case SubEntityData.SubEntityDeactivationRequirement.Glimpse:
				if (IsModelOnScreen())
				{
					deactivationTime += Time.deltaTime;
					if (!deactivationTimeChangedLastFrame)
					{
						audioPlayer.RaiseGameEventForModeWithOverride(AudioEventName.SubEntityBurn, settings.Logical, AudioMode.Camera);
					}
					deactivationTimeChangedLastFrame = true;
					return;
				}
				break;
			}
			if (deactivationTimeChangedLastFrame)
			{
				deactivationTimeChangedLastFrame = false;
				audioPlayer.RaiseGameEventForModeWithOverride(AudioEventName.SubEntityStopBurn, settings.Logical, AudioMode.Camera);
			}
		}
	}

	private void ActivateModel()
	{
		switch (settings.Movement.MovementType)
		{
		case SubEntityData.SubEntityMovementType.Circle:
			circleSpeed = ((Random.Range(0, 2) == 0) ? settings.Movement.CircleDegreesPerSecond.Min : settings.Movement.CircleDegreesPerSecond.Max);
			Teleport(Random.Range(-180f, 180f), Random.Range(settings.Movement.CircleDistance.Min, settings.Movement.CircleDistance.Max), faceCamera: true);
			if (settings.Movement.HideIfMaskOff && _blackboard.Systems.Mask.IsMaskFullyOff())
			{
				SetModelVisibility(visible: false);
			}
			else
			{
				SetModelVisibility(visible: true);
			}
			break;
		case SubEntityData.SubEntityMovementType.CircleTeleportApproach:
			Teleport(Random.Range(-180f, 180f), settings.Movement.ApproachStartDistance, faceCamera: true);
			if (settings.Movement.HideIfMaskOff && _blackboard.Systems.Mask.IsMaskFullyOff())
			{
				SetModelVisibility(visible: false);
			}
			else
			{
				SetModelVisibility(visible: true);
			}
			break;
		case SubEntityData.SubEntityMovementType.Approach:
			Teleport(Random.Range(-180f, 180f), settings.Movement.ApproachStartDistance, faceCamera: true);
			if (settings.Movement.HideIfMaskOff && _blackboard.Systems.Mask.IsMaskFullyOff())
			{
				SetModelVisibility(visible: false);
			}
			else
			{
				SetModelVisibility(visible: true);
			}
			break;
		case SubEntityData.SubEntityMovementType.Stationary:
		{
			float angleFromCamera = Random.Range(settings.Movement.StationaryAngleFromCamera.Min, settings.Movement.StationaryAngleFromCamera.Max) * ((Random.Range(0, 2) > 0) ? (-1f) : 1f);
			Debug.Log("Phantom Stationary Angle: " + angleFromCamera);
			Teleport(angleFromCamera, Random.Range(settings.Movement.StationaryDistance.Min, settings.Movement.StationaryDistance.Max), faceCamera: true);
			if (settings.Movement.HideIfMaskOff && _blackboard.Systems.Mask.IsMaskFullyOff())
			{
				SetModelVisibility(visible: false);
			}
			else
			{
				SetModelVisibility(visible: true);
			}
			break;
		}
		}
		modelAnimator.SetFloat("MoveSpeed", 0f);
		modelAnimator.SetTrigger("Spawn");
		modelAnimator.ResetTrigger("Jumpscare");
		modelAnimator.ResetTrigger("Active");
		Debug.Log("STATE IS NOW SPAWN ANIMATION!");
		currentState = SubEntityState.SpawnAnimation;
		audioPlayer.RaiseGameEventForModeWithOverride(AudioEventName.SubEntitySpawn, settings.Logical, AudioMode.Camera);
	}

	private void DeactivateModel()
	{
		modelAnimator.SetTrigger("Despawn");
		modelAnimator.ResetTrigger("Active");
		Debug.Log("STATE IS NOW DESPAWN ANIMATION!");
		currentState = SubEntityState.DespawnAnimation;
		audioPlayer.RaiseGameEventForModeWithOverride(AudioEventName.SubEntityDespawn, settings.Logical, AudioMode.Camera);
	}

	private void UpdateAnimations()
	{
		if (currentState == SubEntityState.SpawnAnimation)
		{
			if (!modelAnimator.GetCurrentAnimatorStateInfo(0).IsTag("subentitycooldown") && !modelAnimator.GetCurrentAnimatorStateInfo(0).IsTag("subentityspawn"))
			{
				modelAnimator.SetTrigger("Active");
				modelAnimator.ResetTrigger("Spawn");
				Debug.Log("STATE IS NOW ACTIVE!");
				currentState = SubEntityState.ActiveLifetime;
			}
		}
		else if (currentState == SubEntityState.DespawnAnimation && !modelAnimator.GetCurrentAnimatorStateInfo(0).IsTag("subentityactive") && !modelAnimator.GetCurrentAnimatorStateInfo(0).IsTag("subentitydespawn"))
		{
			modelAnimator.SetTrigger("Active");
			modelAnimator.ResetTrigger("Despawn");
			Debug.Log("STATE IS NOW COOLDOWN!");
			currentState = SubEntityState.Cooldown;
		}
	}

	private void UpdateMovement()
	{
		if (currentState != SubEntityState.ActiveLifetime)
		{
			return;
		}
		switch (settings.Movement.MovementType)
		{
		case SubEntityData.SubEntityMovementType.Circle:
			modelAnimator.SetFloat("MoveSpeed", 1f);
			if (settings.Movement.FollowPlayerForward)
			{
				float signedAngleBetweenPositionAndCamera = GetSignedAngleBetweenPositionAndCamera(model.transform.position);
				if (signedAngleBetweenPositionAndCamera < 30f && signedAngleBetweenPositionAndCamera > -30f)
				{
					modelAnimator.SetFloat("MoveSpeed", 0f);
				}
				else if (signedAngleBetweenPositionAndCamera <= 0f)
				{
					RotateAroundOrigin(SpaceMover.Mode.LOCAL, circleSpeed * -1f);
				}
				else
				{
					RotateAroundOrigin(SpaceMover.Mode.LOCAL, circleSpeed);
				}
			}
			else
			{
				RotateAroundOrigin(SpaceMover.Mode.LOCAL, circleSpeed);
			}
			break;
		case SubEntityData.SubEntityMovementType.CircleTeleportApproach:
			if (generatedTeleportDistances == null)
			{
				generatedTeleportDistances = new List<float>();
				int num = Random.Range(settings.Movement.TeleportPositions.Min, settings.Movement.TeleportPositions.Max + 1);
				float approachStartDistance = settings.Movement.ApproachStartDistance;
				float approachEndDistance = settings.Movement.ApproachEndDistance;
				for (int i = 1; i <= num; i++)
				{
					generatedTeleportDistances.Add(Mathf.Lerp(approachStartDistance, approachEndDistance, (float)(i - 1) / (float)(num - 1)));
				}
				currentTeleportDistance = approachStartDistance;
			}
			if (!teleportCooldownTimer.Started)
			{
				teleportCooldownTimer.StartTimer(Random.Range(settings.Movement.TeleportCooldown.Min, settings.Movement.TeleportCooldown.Max));
			}
			else if (teleportCooldownTimer.IsExpired())
			{
				teleportCooldownTimer.Reset();
				int num2 = generatedTeleportDistances.IndexOf(currentTeleportDistance);
				if (generatedTeleportDistances.Count > num2 + 1)
				{
					currentTeleportDistance = generatedTeleportDistances[num2 + 1];
					Teleport(Random.Range(-180f, 180f), currentTeleportDistance, faceCamera: true);
				}
			}
			break;
		case SubEntityData.SubEntityMovementType.Approach:
		case SubEntityData.SubEntityMovementType.Stationary:
			break;
		}
	}

	private void UpdateEffects()
	{
		if (currentState != SubEntityState.ActiveLifetime)
		{
			if (lifeTimeCounter != 0f)
			{
				UndoActiveEffects();
			}
			lifeTimeCounter = 0f;
			return;
		}
		lifeTimeCounter += Time.deltaTime;
		foreach (SubEntityEffect effect in settings.Effects)
		{
			switch (effect.EffectRequirement)
			{
			case SubEntityData.SubEntityEffectRequirement.Lifetime:
			{
				float valueForEffect2 = GetValueForEffect(effect.MinMaxLifetime, effect.MinMaxValues, lifeTimeCounter);
				UpdateEffect(effect, valueForEffect2);
				break;
			}
			case SubEntityData.SubEntityEffectRequirement.Distance:
			{
				float valueForEffect = GetValueForEffect(effect.MinMaxDistance, effect.MinMaxValues, GetModelDistanceFromCamera(SpaceMover.Mode.LOCAL));
				UpdateEffect(effect, valueForEffect);
				break;
			}
			}
		}
	}

	private void UpdateEffect(SubEntityEffect effect, float value)
	{
		switch (effect.EffectType)
		{
		case SubEntityData.SubEntityEffectType.DisruptionStrength:
			switch (effect.ValueType)
			{
			case SubEntityData.SubEntityEffectValueType.Additive:
				_blackboard.AttackProfile.Disruption.RampTime = originalProfile.Disruption.RampTime + value;
				break;
			case SubEntityData.SubEntityEffectValueType.Multiply:
				_blackboard.AttackProfile.Disruption.RampTime = originalProfile.Disruption.RampTime * value;
				break;
			case SubEntityData.SubEntityEffectValueType.Override:
				_blackboard.AttackProfile.Disruption.RampTime = value;
				break;
			}
			break;
		case SubEntityData.SubEntityEffectType.DegreesPerSecond:
			switch (effect.ValueType)
			{
			case SubEntityData.SubEntityEffectValueType.Additive:
			{
				float num6 = originalProfile.Circle.DegreesPerSecond.Min + value;
				_blackboard.AttackProfile.Circle.DegreesPerSecond = new RangeData(num6, num6);
				break;
			}
			case SubEntityData.SubEntityEffectValueType.Multiply:
			{
				float num5 = originalProfile.Circle.DegreesPerSecond.Min * value;
				_blackboard.AttackProfile.Circle.DegreesPerSecond = new RangeData(num5, num5);
				break;
			}
			case SubEntityData.SubEntityEffectValueType.Override:
				_blackboard.AttackProfile.Circle.DegreesPerSecond = new RangeData(value, value);
				break;
			}
			break;
		case SubEntityData.SubEntityEffectType.FootstepSpeedScalar:
			switch (effect.ValueType)
			{
			case SubEntityData.SubEntityEffectValueType.Additive:
			{
				float num4 = originalProfile.Circle.FootstepSpeedScalar.Min + value;
				_blackboard.AttackProfile.Circle.FootstepSpeedScalar = new RangeData(num4, num4);
				break;
			}
			case SubEntityData.SubEntityEffectValueType.Multiply:
			{
				float num3 = originalProfile.Circle.FootstepSpeedScalar.Min * value;
				_blackboard.AttackProfile.Circle.FootstepSpeedScalar = new RangeData(num3, num3);
				break;
			}
			case SubEntityData.SubEntityEffectValueType.Override:
				_blackboard.AttackProfile.Circle.FootstepSpeedScalar = new RangeData(value, value);
				break;
			}
			break;
		case SubEntityData.SubEntityEffectType.ChargeSeconds:
			switch (effect.ValueType)
			{
			case SubEntityData.SubEntityEffectValueType.Additive:
			{
				float num2 = originalProfile.Charge.Seconds.Min + value;
				_blackboard.AttackProfile.Charge.Seconds = new RangeData(num2, num2);
				break;
			}
			case SubEntityData.SubEntityEffectValueType.Multiply:
			{
				float num = originalProfile.Charge.Seconds.Min * value;
				_blackboard.AttackProfile.Charge.Seconds = new RangeData(num, num);
				break;
			}
			case SubEntityData.SubEntityEffectValueType.Override:
				_blackboard.AttackProfile.Charge.Seconds = new RangeData(value, value);
				break;
			}
			break;
		case SubEntityData.SubEntityEffectType.ShearModifier:
			switch (effect.ValueType)
			{
			case SubEntityData.SubEntityEffectValueType.Additive:
				_blackboard.AttackProfile.ShearModifier = originalProfile.ShearModifier + value;
				break;
			case SubEntityData.SubEntityEffectValueType.Multiply:
				_blackboard.AttackProfile.ShearModifier = originalProfile.ShearModifier * value;
				break;
			case SubEntityData.SubEntityEffectValueType.Override:
				_blackboard.AttackProfile.ShearModifier = value;
				break;
			}
			break;
		}
	}

	private void UndoActiveEffects()
	{
		if (_blackboard == null || settings == null || originalProfile == null || _blackboard.AttackProfile == null)
		{
			return;
		}
		using List<SubEntityEffect>.Enumerator enumerator = settings.Effects.GetEnumerator();
		while (enumerator.MoveNext())
		{
			switch (enumerator.Current.EffectType)
			{
			case SubEntityData.SubEntityEffectType.DisruptionStrength:
				_blackboard.AttackProfile.Disruption.RampTime = originalProfile.Disruption.RampTime;
				break;
			case SubEntityData.SubEntityEffectType.DegreesPerSecond:
				_blackboard.AttackProfile.Circle.DegreesPerSecond = originalProfile.Circle.DegreesPerSecond;
				break;
			case SubEntityData.SubEntityEffectType.FootstepSpeedScalar:
				_blackboard.AttackProfile.Circle.FootstepSpeedScalar = originalProfile.Circle.FootstepSpeedScalar;
				break;
			case SubEntityData.SubEntityEffectType.ChargeSeconds:
				_blackboard.AttackProfile.Charge.Seconds = originalProfile.Charge.Seconds;
				break;
			case SubEntityData.SubEntityEffectType.ShearModifier:
				_blackboard.AttackProfile.ShearModifier = originalProfile.ShearModifier;
				break;
			}
		}
	}

	private float GetValueForEffect(RangeData minMaxRange, RangeData minMaxValues, float rangeValue)
	{
		float t = Mathf.Clamp01((minMaxRange.Min - rangeValue) / (minMaxRange.Min - minMaxRange.Max));
		return Mathf.Lerp(minMaxValues.Max, minMaxValues.Min, t);
	}

	private void UpdateJumpscare()
	{
		if (undoJumpscareEffectTimer.Started && undoJumpscareEffectTimer.IsExpired())
		{
			undoJumpscareEffectTimer.Reset();
			UndoJumpscareEffects();
		}
		if (settings.Jumpscare.Source == SubEntityData.SubEntityJumpscareSource.None)
		{
			return;
		}
		if (currentState == SubEntityState.ActiveLifetime)
		{
			if (jumpscareTime >= settings.Jumpscare.TimeToJumpscare)
			{
				Debug.Log("STATE IS NOW JUMPSCARE!");
				currentState = SubEntityState.Jumpscare;
				model.transform.position = cameraStableTransform.position;
				model.transform.eulerAngles = new Vector3(jumpscarePlayerTransform.eulerAngles.x, jumpscarePlayerTransform.eulerAngles.y + 180f, jumpscarePlayerTransform.eulerAngles.z);
				modelAnimator.SetTrigger("Jumpscare");
				modelAnimator.ResetTrigger("Active");
				audioPlayer.RaiseGameEventForModeWithOverride(AudioEventName.SubEntityJumpscare, settings.Logical, AudioMode.Camera);
				return;
			}
			switch (settings.Jumpscare.Source)
			{
			case SubEntityData.SubEntityJumpscareSource.Lifetime:
				if (settings.Jumpscare.PauseWhileDeactivationRequirementActive)
				{
					switch (settings.Activation.DeactivationRequirement)
					{
					case SubEntityData.SubEntityDeactivationRequirement.Automatic:
						jumpscareTime += Time.deltaTime;
						break;
					case SubEntityData.SubEntityDeactivationRequirement.FlashlightLookAt:
						if (!_blackboard.Systems.Flashlight.IsOn || !IsModelOnScreen())
						{
							jumpscareTime += Time.deltaTime;
						}
						break;
					case SubEntityData.SubEntityDeactivationRequirement.MaskOnLookAt:
						if (!_blackboard.Systems.Mask.IsMaskFullyOn() || !IsModelOnScreen())
						{
							jumpscareTime += Time.deltaTime;
						}
						break;
					case SubEntityData.SubEntityDeactivationRequirement.FlashlightOff:
						if (_blackboard.Systems.Flashlight.IsOn)
						{
							jumpscareTime += Time.deltaTime;
						}
						break;
					case SubEntityData.SubEntityDeactivationRequirement.Glimpse:
						if (!IsModelOnScreen())
						{
							jumpscareTime += Time.deltaTime;
						}
						break;
					}
				}
				else
				{
					jumpscareTime += Time.deltaTime;
				}
				break;
			case SubEntityData.SubEntityJumpscareSource.LookAt:
				if (settings.Jumpscare.PauseWhileDeactivationRequirementActive)
				{
					switch (settings.Activation.DeactivationRequirement)
					{
					case SubEntityData.SubEntityDeactivationRequirement.Automatic:
						if (IsModelOnScreen())
						{
							jumpscareTime += Time.deltaTime;
						}
						break;
					case SubEntityData.SubEntityDeactivationRequirement.FlashlightLookAt:
						if ((!_blackboard.Systems.Flashlight.IsOn || !IsModelOnScreen()) && IsModelOnScreen())
						{
							jumpscareTime += Time.deltaTime;
						}
						break;
					case SubEntityData.SubEntityDeactivationRequirement.MaskOnLookAt:
						if ((!_blackboard.Systems.Mask.IsMaskFullyOn() || !IsModelOnScreen()) && IsModelOnScreen())
						{
							jumpscareTime += Time.deltaTime;
						}
						break;
					case SubEntityData.SubEntityDeactivationRequirement.FlashlightOff:
						if (_blackboard.Systems.Flashlight.IsOn && IsModelOnScreen())
						{
							jumpscareTime += Time.deltaTime;
						}
						break;
					case SubEntityData.SubEntityDeactivationRequirement.Glimpse:
						break;
					}
				}
				else if (IsModelOnScreen())
				{
					jumpscareTime += Time.deltaTime;
				}
				break;
			case SubEntityData.SubEntityJumpscareSource.None:
				break;
			}
		}
		else if (currentState == SubEntityState.Jumpscare)
		{
			model.transform.position = cameraStableTransform.position;
			model.transform.eulerAngles = new Vector3(jumpscarePlayerTransform.eulerAngles.x, jumpscarePlayerTransform.eulerAngles.y + 180f, jumpscarePlayerTransform.eulerAngles.z);
			if (!modelAnimator.GetCurrentAnimatorStateInfo(0).IsTag("subentityactive") && !modelAnimator.GetCurrentAnimatorStateInfo(0).IsTag("subentityjumpscare"))
			{
				model.transform.localEulerAngles = Vector3.zero;
				currentState = SubEntityState.Cooldown;
				Debug.Log("STATE IS NOW COOLDOWN!");
				modelAnimator.ResetTrigger("Jumpscare");
				ApplyJumpscareEffects();
			}
		}
	}

	private void ApplyJumpscareEffects()
	{
		using (List<SubEntityJumpscareEffect>.Enumerator enumerator = settings.Jumpscare.JumpscareEffects.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				switch (enumerator.Current.Type)
				{
				case SubEntityData.SubEntityJumpscareEffectType.DisableFlashlight:
					_blackboard.Systems.Flashlight.SetFlashlightAvailable(shouldFlashlightBeAvailable: false);
					_blackboard.Systems.Flashlight.SetFlashlightState(setOn: false, shouldPlayAudio: false);
					break;
				case SubEntityData.SubEntityJumpscareEffectType.InvertScreen:
					glitchShader.InvertScreen = true;
					break;
				case SubEntityData.SubEntityJumpscareEffectType.DisableShocker:
					_blackboard.AttackProfile.AttackUIData.ShowShocker = false;
					break;
				}
			}
		}
		undoJumpscareEffectTimer.StartTimer(settings.Jumpscare.EffectSeconds);
	}

	private void UndoJumpscareEffects()
	{
		using List<SubEntityJumpscareEffect>.Enumerator enumerator = settings.Jumpscare.JumpscareEffects.GetEnumerator();
		while (enumerator.MoveNext())
		{
			switch (enumerator.Current.Type)
			{
			case SubEntityData.SubEntityJumpscareEffectType.DisableFlashlight:
				_blackboard.Systems.Flashlight.SetFlashlightAvailable(originalProfile.AttackUIData.UseFlashlight);
				break;
			case SubEntityData.SubEntityJumpscareEffectType.InvertScreen:
				glitchShader.InvertScreen = false;
				break;
			case SubEntityData.SubEntityJumpscareEffectType.DisableShocker:
				Debug.Log("Setting shock shocker to " + originalProfile.AttackUIData.ShowShocker);
				_blackboard.AttackProfile.AttackUIData.ShowShocker = originalProfile.AttackUIData.ShowShocker;
				break;
			}
		}
	}

	private void SetModelVisibility(bool visible)
	{
		modelRenderer.enabled = visible;
		modelCollider.enabled = visible;
		LineRenderer[] array = mxesLines;
		for (int i = 0; i < array.Length; i++)
		{
			array[i].enabled = visible;
		}
	}

	public void StopSystem()
	{
		isRunning = false;
		Debug.Log("STATE IS NOW INACTIVE!");
		currentState = SubEntityState.Inactive;
		UndoActiveEffects();
		UndoJumpscareEffects();
		activationCooldownTimer.Reset();
		teleportCooldownTimer.Reset();
		undoJumpscareEffectTimer.Reset();
		generatedTeleportDistances = null;
		circleSpeed = 0f;
		deactivationTime = 0f;
		jumpscareTime = 0f;
		deactivationTimeChangedLastFrame = false;
		if (audioPlayer != null)
		{
			audioPlayer.RaiseGameEventForModeWithOverride(AudioEventName.SubEntityStop, settings.Logical, AudioMode.Camera);
		}
		audioPlayer = null;
		if (model != null)
		{
			Object.Destroy(model);
			model = null;
			modelRenderer = null;
			modelCollider = null;
			mxesLines = null;
			modelAnimator = null;
		}
	}

	public void TearDown()
	{
		StopSystem();
		_blackboard = null;
		originalProfile = null;
		cameraStableTransform = null;
		settings = null;
	}

	private bool IsModelOnScreen()
	{
		return IsAABBInCameraFrustum(_blackboard.Systems.CameraController.Camera);
	}

	private float GetModelDistanceFromCamera(SpaceMover.Mode mode)
	{
		if (mode == SpaceMover.Mode.LOCAL)
		{
			return model.transform.localPosition.magnitude;
		}
		return 0f;
	}

	private void RotateAroundOrigin(SpaceMover.Mode mode, float unitsPerSecond)
	{
		Transform transform = model.transform;
		if (mode == SpaceMover.Mode.LOCAL)
		{
			Vector3 vector = Quaternion.AngleAxis(unitsPerSecond * Time.deltaTime, Vector3.up) * transform.localPosition;
			transform.forward = vector - transform.localPosition;
			transform.localPosition = vector;
		}
	}

	private bool MoveTowardOrigin(SpaceMover.Mode mode, float unitsPerSecond)
	{
		Transform transform = model.transform;
		if (mode == SpaceMover.Mode.LOCAL)
		{
			float num = unitsPerSecond * Time.deltaTime;
			if (num < GetModelDistanceFromCamera(SpaceMover.Mode.LOCAL))
			{
				Vector3 translation = (-transform.localPosition).normalized * num;
				transform.Translate(translation, Space.World);
				transform.forward = -transform.localPosition;
				return false;
			}
			transform.localPosition = Vector3.zero;
			return true;
		}
		return true;
	}

	private bool IsAABBInCameraFrustum(Camera cameraToTest)
	{
		Plane[] planes = GeometryUtility.CalculateFrustumPlanes(cameraToTest);
		if (cameraToTest != null && modelCollider != null)
		{
			return GeometryUtility.TestPlanesAABB(planes, modelCollider.bounds);
		}
		return false;
	}

	private void Teleport(float angleFromCamera, float distanceFromCamera, bool faceCamera)
	{
		if (cameraStableTransform == null)
		{
			Debug.LogError("Animatronic3D Mover Teleport - Camera transform is null. Cannot teleport");
			return;
		}
		Vector3 vector = Vector3.ProjectOnPlane(cameraStableTransform.forward, Vector3.up);
		Vector3 vector2 = Quaternion.AngleAxis(angleFromCamera, Vector3.up) * vector * distanceFromCamera;
		model.transform.position = cameraStableTransform.position + vector2;
		if (faceCamera)
		{
			Vector3 vector3 = cameraStableTransform.position - model.transform.position;
			model.transform.forward = Vector3.ProjectOnPlane(vector3, Vector3.up);
		}
		if (settings.Movement.UseWorldHeightPosition)
		{
			model.transform.localPosition = new Vector3(model.transform.localPosition.x, 0f, model.transform.localPosition.z);
		}
		else
		{
			model.transform.localPosition = new Vector3(model.transform.localPosition.x, model.transform.localPosition.y - 1.7f, model.transform.localPosition.z);
		}
		audioPlayer.RaiseGameEventForModeWithOverride(AudioEventName.SubEntityTeleport, settings.Logical, AudioMode.Camera);
	}

	public float GetSignedAngleBetweenPositionAndCamera(Vector3 position)
	{
		return Vector3.SignedAngle(position, cameraStableTransform.forward, Vector3.up);
	}
}
