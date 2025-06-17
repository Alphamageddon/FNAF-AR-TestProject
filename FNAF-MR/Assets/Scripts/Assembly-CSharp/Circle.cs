using UnityEngine;

public class Circle : Phase
{
	private CircleState _state;

	private readonly RandomChanceGroup _speedChangeChance;

	private readonly RandomChanceGroup _nextPhaseChance;

	private bool _lastWalkedClockwise;

	public override AttackPhase AttackPhase => AttackPhase.Circle;

	protected override void EnterPhase()
	{
		Debug.Log("ENTERED CIRCLE PHASE!!");
		Blackboard.Systems.AttackStatic.Container.UpdatePhaseStaticSettings(Blackboard.EntityId, Blackboard.StaticConfig.Circle, Blackboard.AttackProfile.ShearModifier);
		Blackboard.Model.RaiseAudioEventFromCpu(AudioEventName.AttackWalkBegin);
		Blackboard.Model.SetCloakState(cloakEnabled: true);
		Blackboard.Model.SetEyeCloakState(eyeCloakEnabled: true);
		Blackboard.Model.SetEyeGlow(eyeGlowEnabled: false);
		if (_state != null)
		{
			_state.Reset();
		}
		else
		{
			Debug.Log("SETTING UP CIRCLE PHASE");
			_state = new CircleState(Blackboard.AttackProfile.Circle);
			Debug.Log("adding speed change options");
			if (_state.Config.ChangeSpeedChance != null)
			{
				_speedChangeChance.AddOption(0, "NoSpeedChange", 1f - _state.Config.ChangeSpeedChance.Chance, 0f);
				_speedChangeChance.AddOption(1, "YesSpeedChange", _state.Config.ChangeSpeedChance.Chance, _state.Config.ChangeSpeedChance.Modifier);
				_speedChangeChance.CompleteSetup();
			}
			else
			{
				_speedChangeChance.AddOption(0, "NoSpeedChange", 1f, 0f);
				_speedChangeChance.AddOption(1, "YesSpeedChange", 0f, 0f);
				_speedChangeChance.CompleteSetup();
			}
			Debug.Log("adding next phase options");
			if (_state.Config.CircleChance != null)
			{
				_nextPhaseChance.AddOption(5, "NextPhaseCircle", _state.Config.CircleChance.Chance, 0f);
			}
			if (_state.Config.ChargeChance != null)
			{
				_nextPhaseChance.AddOption(8, "NextPhaseCharge", _state.Config.ChargeChance.Chance, 0f);
			}
			if (_state.Config.PauseChance != null)
			{
				_nextPhaseChance.AddOption(6, "NextPhasePause", _state.Config.PauseChance.Chance, 0f);
			}
			_nextPhaseChance.CompleteSetup();
		}
		_state.UseMinSpeed = Random.Range(0.0001f, 1f) <= 0.5f;
		float num = Random.Range(_state.Config.Seconds.Min, _state.Config.Seconds.Max);
		bool flag = Random.Range(0.0001f, 1f) >= 0.5f;
		bool num2 = flag ^ _lastWalkedClockwise;
		_lastWalkedClockwise = flag;
		if (num2 & Blackboard.ShouldCheckForDirectionChange)
		{
			Blackboard.Model.RaiseAudioEventFromCpu(AudioEventName.AttackDirectionChange);
		}
		if (ShouldChangeSpeed())
		{
			float num3 = Random.Range(_state.Config.TriggerPercent.Min, _state.Config.TriggerPercent.Max);
			_state.SpeedChangeTimer.StartTimer(num * num3);
		}
		if (ShouldGoSlash())
		{
			Debug.Log("starting slash timer");
			_state.SlashTimer.StartTimer(num * Blackboard.SlashState.ActiveState.TriggerPercent);
		}
		if (ShouldGoHaywire())
		{
			Debug.Log("starting haywire timer");
			_state.HaywireTimer.StartTimer(num * Blackboard.HaywireState.ActiveState.TriggerPercent);
		}
		if (Blackboard.Systems.VisibilityAlterEffect.ShouldBeActiveWhileCircling)
		{
			Blackboard.Systems.VisibilityAlterEffect.StartEffect();
		}
		StartMovement();
		EndOfPhase.StartTimer(num);
	}

	protected override AttackPhase UpdatePhase()
	{
		if (_state.SlashTimer.Started && _state.SlashTimer.IsExpired())
		{
			Debug.Log("Slash timer has ended");
			if (SlashActivator.CanActivate(Blackboard, Blackboard.AbsoluteAngleFromCamera))
			{
				Debug.Log("Slash activated.");
				return AttackPhase.Slash;
			}
			Debug.Log("Slash could not activate.");
		}
		if (_state.HaywireTimer.Started && _state.HaywireTimer.IsExpired())
		{
			Debug.Log("Haywire timer has ended");
			if (HaywireActivator.CanActivate(Blackboard, Blackboard.AbsoluteAngleFromCamera))
			{
				Debug.Log("Haywire activated.");
				return AttackPhase.Haywire;
			}
			Debug.Log("Haywire could not activate.");
		}
		if (_state.SpeedChangeTimer.Started && _state.SpeedChangeTimer.IsExpired())
		{
			_state.SpeedChangeTimer.Reset();
			if (_state != null)
			{
				_state.UseMinSpeed = !_state.UseMinSpeed;
			}
			StartMovement();
		}
		if (EndOfPhase.IsExpired() && EndOfPhase.Started)
		{
			return ChooseNextPhase();
		}
		return AttackPhase.Null;
	}

	protected override void ExitPhase()
	{
		Blackboard.Systems.AttackStatic.Container.ClearPhaseStaticSettings(Blackboard.EntityId);
		Blackboard.Model.RaiseAudioEventFromCpu(AudioEventName.AttackWalkEnd);
		Blackboard.Model.StopMoving();
		if (Blackboard.Systems.VisibilityAlterEffect.ShouldBeActiveWhileCircling)
		{
			Blackboard.Systems.VisibilityAlterEffect.StopEffect();
		}
		Blackboard.ForceCircleAfterPause = false;
		Blackboard.ShouldCheckForDirectionChange = true;
	}

	private bool ShouldChangeSpeed()
	{
		return _speedChangeChance.GetRandomOption() > 0;
	}

	private bool ShouldGoHaywire()
	{
		HaywireActivator.CalculateActivation(Blackboard.HaywireState, AttackPhase.Circle);
		if (Blackboard.HaywireState.ActiveState == null)
		{
			Debug.Log("haywire state is null. Shouldnt haywire.");
		}
		return Blackboard.HaywireState.ActiveState != null;
	}

	private bool ShouldGoSlash()
	{
		SlashActivator.CalculateActivation(Blackboard.SlashState, AttackPhase.Circle);
		if (Blackboard.SlashState.ActiveState == null)
		{
			Debug.Log("slash state is null. Shouldnt slash.");
		}
		return Blackboard.SlashState.ActiveState != null;
	}

	private void StartMovement()
	{
		if (_state != null)
		{
			float num = ((!_state.UseMinSpeed) ? _state.Config.DegreesPerSecond.Max : _state.Config.DegreesPerSecond.Min);
			num *= (_lastWalkedClockwise ? (-1f) : 1f);
			Blackboard.Model.MoveInCircleAroundCamera(num, isWalking: true);
			Blackboard.Model.SetAnimationFloat(AnimationFloat.WalkSpeedModifier, (!_state.UseMinSpeed) ? _state.Config.FootstepSpeedScalar.Max : _state.Config.FootstepSpeedScalar.Min);
		}
	}

	private AttackPhase ChooseNextPhase()
	{
		if (LowBatteryDetector.ShouldCharge(Blackboard) || Blackboard.ForceCharge)
		{
			Blackboard.ForceCharge = false;
			return AttackPhase.Charge;
		}
		int randomOption = _nextPhaseChance.GetRandomOption();
		if (randomOption != 8)
		{
			return (AttackPhase)randomOption;
		}
		if (!Blackboard.Systems.DropsObjectsMechanic.ViewModel.IsDroppedObjectActive)
		{
			return AttackPhase.Charge;
		}
		return (AttackPhase)_nextPhaseChance.GetHighestWeightedOption(8);
	}

	public Circle()
	{
		_speedChangeChance = new RandomChanceGroup("CircleSpeedChange");
		_nextPhaseChance = new RandomChanceGroup("CircleNextPhase");
	}
}
