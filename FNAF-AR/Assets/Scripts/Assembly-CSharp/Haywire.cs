using UnityEngine;

public class Haywire : Phase
{
	private HaywireState _state;

	private RandomChanceGroup _haywireTypeChance;

	private RandomChanceGroup _nextPhaseChance;

	private bool _moveLeft;

	public override AttackPhase AttackPhase => AttackPhase.Haywire;

	protected override void EnterPhase()
	{
		if (_state == null || _state.GlobalState != Blackboard.HaywireState)
		{
			_state = new HaywireState(Blackboard.HaywireState);
			BuildHaywireTypeChance();
			BuildNextPhaseChance();
		}
		_state.Reset();
		int randomOption = _haywireTypeChance.GetRandomOption();
		_state.Duration = Random.Range(_state.Config.Seconds.Min, _state.Config.Seconds.Max);
		_state.LookAway = randomOption == 0;
		_state.IsContinuous = randomOption == 3;
		if (randomOption == 2)
		{
			Debug.LogWarning("LOOK AT THEN AWAY");
			float num = Mathf.Clamp(Random.Range(_state.Config.LookChangeTriggerPercent.Min, _state.Config.LookChangeTriggerPercent.Max), 0f, 1f);
			float num2 = _state.Duration * num;
			_state.LookSwapTime = _state.Duration - num2;
			Debug.Log("LookSwapTime = " + _state.LookSwapTime);
		}
		if (randomOption == 3)
		{
			Debug.LogWarning("LOOK CONTINUOUS");
			_state.ContinuousSwapTimer.StartTimer(Random.Range(_state.Config.ContinuousChangeTriggerInterval.Min, _state.Config.ContinuousChangeTriggerInterval.Max));
		}
		if (_state.Config.CoverEyes)
		{
			Blackboard.Model.SetAnimatorLayerWeight(1, 1f);
		}
		else
		{
			Blackboard.Model.SetAnimatorLayerWeight(1, 0f);
		}
		Blackboard.Systems.HaywireIndicator.SetVisibilityType(_state.Config.CoverEyes ? HaywireIndicator.IndicatorVisibility.AlwaysHaywire : HaywireIndicator.IndicatorVisibility.AnimatronicOnScreen);
		if (_state.GlobalState.UseMultiwire())
		{
			StartMultiwire();
		}
		else
		{
			StartHaywire();
		}
	}

	protected override AttackPhase UpdatePhase()
	{
		bool flag = false;
		if (_state.HiddenTimer.Started)
		{
			if (!_state.HiddenTimer.IsExpired())
			{
				return AttackPhase.Null;
			}
			_state.HiddenTimer.Reset();
			RepositionForMultiwire();
			BeginHaywireEffect();
			_state.LocateTimer.StartTimer(Random.Range(_state.Config.Multiwire.LocateTime.Min, _state.Config.Multiwire.LocateTime.Max));
			return AttackPhase.Null;
		}
		if (_state.LocateTimer.Started)
		{
			if (!Blackboard.IsAABBOnScreen && !_state.LocateTimer.IsExpired())
			{
				return AttackPhase.Null;
			}
			_state.LocateTimer.Reset();
			EndOfPhase.StartTimer(_state.Duration);
			return AttackPhase.Null;
		}
		if ((_state.LookSwapTime >= 0f && EndOfPhase.Started && _state.LookSwapTime >= EndOfPhase.GetRemainingTime()) || (_state.IsContinuous && _state.ContinuousSwapTimer.Started && _state.ContinuousSwapTimer.IsExpired() && EndOfPhase.Started))
		{
			_state.LookAway = !_state.LookAway;
			if (_state.IsContinuous)
			{
				_state.ContinuousSwapTimer.Reset();
				_state.ContinuousSwapTimer.StartTimer(Random.Range(_state.Config.ContinuousChangeTriggerInterval.Min, _state.Config.ContinuousChangeTriggerInterval.Max));
			}
			else
			{
				_state.LookSwapTime = -1f;
			}
			if (!_state.Config.CoverEyes)
			{
				Blackboard.Model.SetEyeColorMode(_state.LookAway ? EyeColorMode.LookAway : EyeColorMode.LookAt);
			}
			Blackboard.Systems.EncounterEnvironment.SetLightColorMode(_state.LookAway ? Blackboard.Model.GetEyeColors()[EyeColorMode.LookAway].Color : Blackboard.Model.GetEyeColors()[EyeColorMode.LookAt].Color);
		}
		Blackboard.Systems.HaywireIndicator.SetHaywireInformation(Blackboard.IsAABBOnScreen, inHaywire: true, (!_state.LookAway) ? HaywireIndicator.HaywireIndicateType.LookAt : HaywireIndicator.HaywireIndicateType.LookAway);
		bool flag2 = _state.LookAway ^ Blackboard.IsAABBOnScreen;
		bool flag3;
		if (_state.Config.RequiredMaskState == HaywireMaskState.IgnoreMask || !flag2)
		{
			if (!flag2)
			{
				flag3 = true;
			}
			else
			{
				flag3 = false;
				_state.HasTriggeredCounter = false;
			}
		}
		else
		{
			if (_state.Config.RequiredMaskState == HaywireMaskState.MaskOff)
			{
				flag = false;
			}
			if (_state.Config.RequiredMaskState == HaywireMaskState.MaskOn)
			{
				flag = true;
			}
			if ((!flag && Blackboard.Systems.Mask.IsMaskFullyOff()) || (flag && !Blackboard.Systems.Mask.IsMaskFullyOff()))
			{
				flag3 = false;
				_state.HasTriggeredCounter = false;
			}
			else
			{
				flag3 = true;
			}
		}
		if (flag3 && _state.HasTriggeredCounter)
		{
			_state.CumulativeLookTime = Time.deltaTime + _state.CumulativeLookTime;
		}
		else
		{
			_state.HasTriggeredCounter = true;
		}
		if (Blackboard.ShockedDuringHaywire)
		{
			Blackboard.ShockedDuringHaywire = false;
			if (!Blackboard.Systems.AnimatronicState.IsLegacyAnimatronic && _state.Config.ShockCausesAttack)
			{
				return AttackPhase.AttackPlayer;
			}
			if (_state.Config.ShockCausesJumpscare)
			{
				Blackboard.Systems.Encounter.SetDeathText("death_haywire");
				return AttackPhase.Jumpscare;
			}
			Blackboard.Systems.Battery.DrainCharge(Blackboard.AttackProfile.Battery.HaywireShockDrain);
			PrepareForNonJumpscareExit();
			return ChooseNextPhase(shouldCheckForMultiwire: false);
		}
		if (_state.CumulativeLookTime < _state.Config.LookTime)
		{
			if (!EndOfPhase.IsExpired())
			{
				return AttackPhase.Null;
			}
			PrepareForNonJumpscareExit();
			return ChooseNextPhase(shouldCheckForMultiwire: true);
		}
		string text = _state.CumulativeLookTime.ToString();
		float lookTime = _state.Config.LookTime;
		Debug.LogError("YOU DIED - LOOK TIME: " + text + " OUT OF A NECESSARY: " + lookTime);
		Blackboard.Systems.Encounter.SetDeathText("death_haywire");
		if (!Blackboard.Systems.AnimatronicState.IsLegacyAnimatronic)
		{
			return AttackPhase.AttackPlayer;
		}
		return AttackPhase.Jumpscare;
	}

	protected override void ExitPhase()
	{
		EndHaywireEffect();
		Blackboard.Model.StopMoving();
		Blackboard.Model.SetAnimatorLayerWeight(1, 0f);
		Blackboard.Systems.HaywireIndicator.Reset();
		if (!_state.GlobalState.IsMultiwireActive || _state.GlobalState.RemainingActivations == 0)
		{
			_state.GlobalState.ActiveState = null;
			_state.GlobalState.Cooldown.StartTimer(_state.Config.Cooldown);
		}
	}

	private void BuildHaywireTypeChance()
	{
		Debug.Log("Building haywire type chance");
		_haywireTypeChance = new RandomChanceGroup("HaywireLookType");
		if (_state.Config.LookAway != null)
		{
			_haywireTypeChance.AddOption(0, "LookAway", _state.Config.LookAway.Chance, _state.Config.LookAway.Modifier);
		}
		if (_state.Config.LookAt != null)
		{
			_haywireTypeChance.AddOption(1, "LookAt", _state.Config.LookAt.Chance, _state.Config.LookAt.Modifier);
		}
		if (_state.Config.LookAtThenAway != null)
		{
			_haywireTypeChance.AddOption(2, "LookAtThenAway", _state.Config.LookAtThenAway.Chance, _state.Config.LookAtThenAway.Modifier);
		}
		if (_state.Config.LookAwayAndAtContinuous != null)
		{
			_haywireTypeChance.AddOption(3, "LookAwayAndAtContinuous", _state.Config.LookAwayAndAtContinuous.Chance, _state.Config.LookAwayAndAtContinuous.Modifier);
		}
		_haywireTypeChance.CompleteSetup();
	}

	private void BuildNextPhaseChance()
	{
		_nextPhaseChance = new RandomChanceGroup("HaywireNextPhase");
		if (_state.GlobalState.ActiveState.Config.CircleChance != null)
		{
			_nextPhaseChance.AddOption(5, "Circle", _state.GlobalState.ActiveState.Config.CircleChance.Chance, _state.GlobalState.ActiveState.Config.CircleChance.Modifier);
		}
		if (_state.GlobalState.ActiveState.Config.PauseChance != null)
		{
			_nextPhaseChance.AddOption(6, "Pause", _state.GlobalState.ActiveState.Config.PauseChance.Chance, _state.GlobalState.ActiveState.Config.PauseChance.Modifier);
		}
		_nextPhaseChance.CompleteSetup();
	}

	private void StartHaywire()
	{
		bool flag = false;
		if (_state.GlobalState.ActiveState != null)
		{
			flag = _state.GlobalState.ActiveState.Config.TeleportToCamera;
		}
		if (flag)
		{
			Blackboard.Model.TeleportInFrontOfCamera(Blackboard.Model.GetMovementSettings().HaywireDistance);
		}
		else
		{
			Blackboard.Model.TeleportAtCurrentAngle(Blackboard.Model.GetMovementSettings().HaywireDistance);
		}
		BeginHaywireEffect();
		EndOfPhase.StartTimer(_state.Duration);
	}

	private void StartMultiwire()
	{
		if (!_state.GlobalState.IsMultiwireActive)
		{
			_state.GlobalState.IsMultiwireActive = true;
			_state.GlobalState.RemainingActivations = Random.Range(_state.Config.Multiwire.Count.Min, _state.Config.Multiwire.Count.Max + 1);
			StartHaywire();
		}
		else
		{
			_state.HiddenTimer.StartTimer(Random.Range(_state.Config.Multiwire.HiddenTime.Min, _state.Config.Multiwire.HiddenTime.Max));
		}
		_state.GlobalState.RemainingActivations--;
	}

	private void RepositionForMultiwire()
	{
		float angleFromCamera = Random.Range(_state.Config.Multiwire.HalfAngle.Min, _state.Config.Multiwire.HalfAngle.Max) * ((Random.Range(0, 2) > 0) ? (-1f) : 1f);
		Blackboard.Model.Teleport(angleFromCamera, Blackboard.Model.GetMovementSettings().HaywireDistance, faceCamera: true);
	}

	private void BeginHaywireEffect()
	{
		Blackboard.Model.RaiseAudioEventFromCpu(AudioEventName.AttackHaywireBegin);
		Blackboard.Systems.HaywireFxController.SetStrength(1f);
		Blackboard.Model.SetAnimationTrigger(AnimationTrigger.Haywire, shouldSet: true);
		Blackboard.Model.SetCloakState(cloakEnabled: false);
		Blackboard.Model.SetEyeCloakState(eyeCloakEnabled: false);
		Debug.Log("doing haywire eye shit");
		if (!_state.Config.CoverEyes)
		{
			Blackboard.Model.SetEyeColorMode(_state.LookAway ? EyeColorMode.LookAway : EyeColorMode.LookAt);
		}
		Blackboard.Systems.EncounterEnvironment.SetLightColorMode(_state.LookAway ? Blackboard.Model.GetEyeColors()[EyeColorMode.LookAway].Color : Blackboard.Model.GetEyeColors()[EyeColorMode.LookAt].Color);
		Blackboard.Model.SetEyeGlow(eyeGlowEnabled: true);
	}

	private void EndHaywireEffect()
	{
		Blackboard.Model.RaiseAudioEventFromCpu(AudioEventName.AttackHaywireEnd);
		Blackboard.Systems.HaywireFxController.SetStrength(0f);
		Blackboard.Model.SetCloakState(cloakEnabled: true);
		Blackboard.Model.SetEyeCloakState(eyeCloakEnabled: true);
		Blackboard.Model.SetEyeColorMode(EyeColorMode.Normal);
		Blackboard.Systems.EncounterEnvironment.SetLightColorMode(Color.white);
		Blackboard.Model.SetEyeGlow(eyeGlowEnabled: false);
	}

	private void PrepareForNonJumpscareExit()
	{
		Blackboard.Model.SetAnimationTrigger(AnimationTrigger.HaywireEnd, shouldSet: true);
		TeleportReposition.NormalTeleport(Blackboard);
	}

	private AttackPhase ChooseNextPhase(bool shouldCheckForMultiwire)
	{
		if (shouldCheckForMultiwire && _state.GlobalState.IsMultiwireActive && _state.GlobalState.RemainingActivations > 0)
		{
			return AttackPhase.Haywire;
		}
		if (LowBatteryDetector.ShouldCharge(Blackboard))
		{
			return AttackPhase.Charge;
		}
		int randomOption = _nextPhaseChance.GetRandomOption();
		if (randomOption != 6)
		{
			return (AttackPhase)randomOption;
		}
		Blackboard.ForceCircleAfterPause = _state.GlobalState.ActiveState.Config.ForceCircleAfterPause;
		return AttackPhase.Pause;
	}

	private void StartMovement()
	{
		if (_state != null)
		{
			float num = 25f;
			num *= (_moveLeft ? (-1f) : 1f);
			Blackboard.Model.MoveInCircleAroundCamera(num, isWalking: true);
			Blackboard.Model.SetAnimationFloat(AnimationFloat.WalkSpeedModifier, 1f);
		}
	}
}
