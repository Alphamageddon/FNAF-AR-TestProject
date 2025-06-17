using UnityEngine;

public class BaseCharge : Phase
{
	private enum ChargeEndType
	{
		ChargeFeint = 0,
		ChargeDeflection = 1,
		ChargeDelay = 2
	}

	private ChargeState _state;

	private readonly RandomChanceGroup _jumpscareChance;

	private readonly RandomChanceGroup _skipJumpscareChance;

	public override AttackPhase AttackPhase => AttackPhase.Charge;

	protected override void EnterPhase()
	{
		Blackboard.Systems.AttackStatic.Container.UpdatePhaseStaticSettings(Blackboard.EntityId, Blackboard.StaticConfig.Charge, Blackboard.AttackProfile.ShearModifier);
		Blackboard.Model.RaiseAudioEventFromCpu(AudioEventName.AttackChargeBegin);
		Blackboard.Model.SetCloakState(cloakEnabled: true);
		Blackboard.Model.SetEyeCloakState(eyeCloakEnabled: false);
		Blackboard.Model.SetEyeColorMode(EyeColorMode.Attack);
		Blackboard.Model.SetEyeGlow(eyeGlowEnabled: true);
		if (_state != null)
		{
			_state.Reset();
		}
		else
		{
			Debug.LogError("Charge State is NULL.");
			_state = new ChargeState(Blackboard.AttackProfile.Charge);
			_jumpscareChance.AddOption(0, "NoJumpscare", 1f - _state.Config.JumpscareChance.Chance, 0f);
			_jumpscareChance.AddOption(1, "YesJumpscare", _state.Config.JumpscareChance.Chance, _state.Config.JumpscareChance.Modifier);
			_jumpscareChance.CompleteSetup();
			if (_state.Config.SkipJumpscareChance != null)
			{
				_skipJumpscareChance.AddOption(0, "NoSkipJumpscare", 1f - _state.Config.SkipJumpscareChance.Chance, 0f);
				_skipJumpscareChance.AddOption(1, "YesSkipJumpscare", _state.Config.SkipJumpscareChance.Chance, _state.Config.SkipJumpscareChance.Modifier);
			}
			else
			{
				_skipJumpscareChance.AddOption(0, "NoSkipJumpscare", 1f, 0f);
				_skipJumpscareChance.AddOption(1, "YesSkipJumpscare", 0f, 0f);
			}
			_skipJumpscareChance.CompleteSetup();
		}
		float num = Mathf.Max(Random.Range(_state.Config.Seconds.Min, _state.Config.Seconds.Max), 0.0001f);
		_state.NumShocksRemaining = Blackboard.NumShocksRemaining;
		if (LowBatteryDetector.ShouldCharge(Blackboard))
		{
			_state.WillJumpscare = true;
		}
		else
		{
			_state.WillJumpscare = _jumpscareChance.GetRandomOption() > 0;
			Debug.Log("Decloak Charge = " + _state.WillJumpscare);
		}
		if (!_state.WillJumpscare && ShouldGoHaywire())
		{
			_state.HaywireTimer.StartTimer(num * Blackboard.HaywireState.ActiveState.TriggerPercent);
		}
		if (_state.WillJumpscare)
		{
			_state.CanDeflectCharge = _state.Config.DeflectionAction != ChargeDeflectionAction.None;
			_state.WillSkipDelayedJumpscare = _skipJumpscareChance.GetRandomOption() > 0;
		}
		_state.JumpscareRange = Blackboard.Model.GetMovementSettings().DelayedJumpscareDistance;
		float num2 = Random.Range(_state.Config.ShockWindow.Min, _state.Config.ShockWindow.Max) * Blackboard.Model.GetMovementSettings().AnimatedSpeed;
		float num3 = Blackboard.Model.GetCloakSettings().ShockWindowOpenTime * Blackboard.Model.GetMovementSettings().AnimatedSpeed;
		_state.DecloakRange = num3 + num2 + _state.JumpscareRange;
		_state.CloakRange = _state.JumpscareRange + Blackboard.Model.GetMovementSettings().AnimatedSpeed * Blackboard.Model.GetCloakSettings().CloakTime;
		float num4 = Blackboard.Model.GetMovementSettings().AnimatedSpeed * (Blackboard.Systems.Shocker.GetTotalMissCooldownTime() + 0.25f);
		_state.BlockExtraBatteryRange = num4 + _state.JumpscareRange;
		float num5 = num * Blackboard.Model.GetMovementSettings().AnimatedSpeed;
		float distanceFromCamera = num5 + _state.DecloakRange;
		if (!_state.WillJumpscare)
		{
			_state.JumpscareRange = 0f;
			_state.DecloakRange = Blackboard.Model.GetMovementSettings().ChargeFeintDistance;
			_state.CloakRange = 0f;
		}
		Debug.Log("Charging! - correct distance: " + num5 + " + " + _state.DecloakRange);
		Debug.Log("Charging! - actual distance for some reason: " + distanceFromCamera);
		if (Blackboard.ForceFrontalCharge)
		{
			Blackboard.Model.TeleportInFrontOfCamera(distanceFromCamera);
			Blackboard.ForceFrontalCharge = false;
		}
		else
		{
			Blackboard.Model.TeleportAtCurrentAngle(distanceFromCamera);
		}
		Blackboard.Model.MoveInLineTowardCamera(Blackboard.Model.GetMovementSettings().AnimatedSpeed, isWalking: false);
		Blackboard.Model.SetAnimationTrigger(AnimationTrigger.Charge, shouldSet: true);
	}

	protected override AttackPhase UpdatePhase()
	{
		if (Blackboard.DistanceFromCamera <= _state.BlockExtraBatteryRange && _state.WillJumpscare && !_state.WillSkipDelayedJumpscare && Blackboard.Systems.AnimatronicState.IsLegacyAnimatronic && Blackboard.Systems.Shocker.GetRemainingCooldownTime() <= 0f)
		{
			Blackboard.Systems.Battery.SetExtraBatteryBlocker(isBlocked: true);
		}
		if (_state.CanDeflectCharge)
		{
			_state.DeflectionConditionTrue = IsDeflectionActionActive();
			_state.WasDeflectionConditionEverFalse |= IsDeflectionActionFailed();
		}
		if (_state.NumShocksRemaining != Blackboard.NumShocksRemaining)
		{
			ExecuteChargeEndAudio(ChargeEndType.ChargeDelay);
			Blackboard.Model.CloseShockWindow();
			return AttackPhase.Damaged;
		}
		if (_state.HaywireTimer.Started && _state.HaywireTimer.IsExpired() && HaywireActivator.CanActivate(Blackboard, Blackboard.AbsoluteAngleFromCamera))
		{
			return AttackPhase.Haywire;
		}
		if (Blackboard.DistanceFromCamera <= _state.JumpscareRange)
		{
			return HandleJumpscare();
		}
		if (!_state.StartedCloak && Blackboard.DistanceFromCamera <= _state.CloakRange)
		{
			_state.StartedCloak = true;
			Blackboard.Model.BeginCloak();
			Blackboard.Model.BeginEyeCloak();
		}
		if (!_state.StartedDecloak && Blackboard.DistanceFromCamera <= _state.DecloakRange)
		{
			if (!_state.WillJumpscare)
			{
				ExecuteChargeEnd(ChargeEndType.ChargeFeint);
				TeleportReposition.NormalTeleport(Blackboard);
				return ChooseNextPhase();
			}
			Blackboard.Model.RaiseAudioEventFromPlushSuit(AudioEventName.AttackDecloakBegin);
			_state.StartedDecloak = true;
			Blackboard.Model.BeginDecloak();
		}
		return AttackPhase.Null;
	}

	protected override void ExitPhase()
	{
		Blackboard.Model.StopMoving();
		Blackboard.Systems.AttackStatic.Container.ClearPhaseStaticSettings(Blackboard.EntityId);
	}

	private bool ShouldGoHaywire()
	{
		HaywireActivator.CalculateActivation(Blackboard.HaywireState, AttackPhase.Charge);
		return Blackboard.HaywireState.ActiveState != null;
	}

	private bool IsDeflectionActionActive()
	{
		if (_state.Config.DeflectionAction != ChargeDeflectionAction.MaskOn)
		{
			return Blackboard.IsAABBOnScreen;
		}
		Debug.Log("Deflection action active: " + Blackboard.Systems.Mask.IsMaskFullyOn() + " - " + Blackboard.IsAABBOnScreen);
		if (Blackboard.Systems.Mask.IsMaskFullyOn())
		{
			return Blackboard.IsAABBOnScreen;
		}
		return false;
	}

	private bool IsDeflectionActionFailed()
	{
		if (_state.Config.DeflectionAction == ChargeDeflectionAction.MaskOn)
		{
			return !Blackboard.Systems.Mask.IsMaskFullyOn();
		}
		return false;
	}

	private bool ShouldAutoShutdown()
	{
		if (_state.Config.AutoShutdownType == AutoShutdownType.DropCollection)
		{
			string text = Blackboard.DroppedObjectsCollected.ToString();
			int autoShutdownCountTrigger = _state.Config.AutoShutdownCountTrigger;
			Debug.Log("Collected: " + text + " - RequiredCount: " + autoShutdownCountTrigger);
			return Blackboard.DroppedObjectsCollected >= _state.Config.AutoShutdownCountTrigger;
		}
		return _state.Config.AutoShutdownType == AutoShutdownType.Jumpscare;
	}

	private bool WasChargeDeflected()
	{
		if (_state.Config.DeflectionMustStartDuringCharge && !_state.WasDeflectionConditionEverFalse)
		{
			return false;
		}
		if (_state.CanDeflectCharge)
		{
			return _state.DeflectionConditionTrue;
		}
		return false;
	}

	private void ExecuteChargeEndAudio(ChargeEndType chargeEndType)
	{
		Blackboard.Model.RaiseAudioEventFromCpu(chargeEndType switch
		{
			ChargeEndType.ChargeDeflection => AudioEventName.AttackChargeDeflection, 
			ChargeEndType.ChargeDelay => AudioEventName.AttackChargeDelay, 
			_ => AudioEventName.AttackChargeFeint, 
		});
	}

	private AttackPhase HandleJumpscare()
	{
		Blackboard.Model.CloseShockWindow();
		if (_state.Config.AutoShutdownType != AutoShutdownType.None && ShouldAutoShutdown())
		{
			return AttackPhase.Shutdown;
		}
		if (!WasChargeDeflected())
		{
			ExecuteChargeEnd(ChargeEndType.ChargeDelay);
			if (!_state.WillSkipDelayedJumpscare)
			{
				Blackboard.Systems.Encounter.SetDeathText("death_charge");
				return AttackPhase.AttackPlayer;
			}
			return ChooseNextPhase();
		}
		TeleportReposition.NormalTeleport(Blackboard);
		ExecuteChargeEnd(ChargeEndType.ChargeDeflection);
		return ChooseNextPhase();
	}

	private void ExecuteChargeEnd(ChargeEndType chargeEndType)
	{
		ExecuteChargeEndAudio(chargeEndType);
		Blackboard.Model.SetAnimationTrigger(AnimationTrigger.ChargeEnd, shouldSet: true);
		Blackboard.Model.SetCloakState(cloakEnabled: true);
		Blackboard.Model.SetEyeCloakState(eyeCloakEnabled: true);
		Blackboard.Model.SetEyeGlow(eyeGlowEnabled: false);
		Blackboard.Model.StopMoving();
	}

	private AttackPhase ChooseNextPhase()
	{
		Blackboard.ForceCircleAfterPause = _state.Config.ForceCircleAfterPause;
		return AttackPhase.Pause;
	}

	public BaseCharge()
	{
		_jumpscareChance = new RandomChanceGroup("ChargeJumpscare");
		_skipJumpscareChance = new RandomChanceGroup("ChargeSkipJumpscareChance");
	}
}
