using UnityEngine;

public class Pause : BasePause
{
	private PauseState _state;

	private GlimpseActivator _glimpseActivator;

	private readonly RandomChanceGroup _nextPhaseChance;

	protected override void EnterPhase()
	{
		Blackboard.Model.SetCloakState(cloakEnabled: true);
		Blackboard.Model.SetEyeCloakState(eyeCloakEnabled: true);
		Blackboard.Model.SetEyeColorMode(EyeColorMode.Normal);
		Blackboard.Model.SetEyeGlow(eyeGlowEnabled: false);
		Blackboard.FreezeStaticAngle = true;
		Blackboard.FrozenStaticPosition = Blackboard.Model.GetRootBonePosition();
		if (_state != null)
		{
			_state.Reset();
		}
		else
		{
			_state = new PauseState(Blackboard.AttackProfile.Pause);
			SetUpNextPhaseChanceGroup();
		}
		if (Blackboard.ResetPausePhaseChangeGroup)
		{
			_state = new PauseState(Blackboard.AttackProfile.Pause);
			SetUpNextPhaseChanceGroup();
			Blackboard.ResetPausePhaseChangeGroup = false;
		}
		if (_glimpseActivator == null)
		{
			_glimpseActivator = new GlimpseActivator(Blackboard.AttackProfile.Glimpse, Blackboard.Model.GetCloakSettings(), shouldUseDeadZone: true);
		}
		else
		{
			_glimpseActivator.Reset(Blackboard);
		}
		_state.SavedPosition = Blackboard.Model.GetPosition();
		_state.SavedForward = Blackboard.Model.GetForward();
		float num = Random.Range(_state.Config.Seconds.Min, _state.Config.Seconds.Max);
		if (ShouldGoSlash())
		{
			_state.SlashTimer.StartTimer(num * Blackboard.SlashState.ActiveState.TriggerPercent);
		}
		if (ShouldGoHaywire())
		{
			_state.HaywireTimer.StartTimer(num * Blackboard.HaywireState.ActiveState.TriggerPercent);
		}
		EndOfPhase.StartTimer(num);
		RunSharedEnterPhase();
	}

	protected override AttackPhase UpdatePhase()
	{
		if (_state.SlashTimer.Started && _state.SlashTimer.IsExpired() && SlashActivator.CanActivate(Blackboard, Blackboard.AbsoluteAngleFromCamera))
		{
			return AttackPhase.Slash;
		}
		if (_state.HaywireTimer.Started && _state.HaywireTimer.IsExpired() && HaywireActivator.CanActivate(Blackboard, Blackboard.AbsoluteAngleFromCamera))
		{
			return AttackPhase.Haywire;
		}
		if (EndOfPhase.IsExpired())
		{
			return ChooseNextPhase();
		}
		if (_state.Config.UseGlimpse)
		{
			_glimpseActivator.Update(Blackboard, EndOfPhase.GetRemainingTime());
		}
		return AttackPhase.Null;
	}

	protected override void ExitPhase()
	{
		Blackboard.FreezeStaticAngle = false;
		Blackboard.Model.SetCloakState(cloakEnabled: true);
		Blackboard.Model.SetEyeCloakState(eyeCloakEnabled: true);
		Blackboard.Model.SetEyeGlow(eyeGlowEnabled: false);
		Blackboard.Model.SetEyeColorMode(EyeColorMode.Normal);
		Blackboard.Model.SetAnimationBool(AnimationBool.GlimpseActive, value: false);
		Blackboard.Model.TeleportToLocalPosition(_state.SavedPosition, _state.SavedForward);
		RunSharedExitPhase();
	}

	private void SetUpNextPhaseChanceGroup()
	{
		_nextPhaseChance.Clear();
		if (_state.Config.GlimpseChance != null)
		{
			_nextPhaseChance.AddOption(7, "Glimpse", _state.Config.GlimpseChance.Chance, _state.Config.GlimpseChance.Modifier);
		}
		if (_state.Config.CircleChance != null)
		{
			_nextPhaseChance.AddOption(5, "Circle", _state.Config.CircleChance.Chance, _state.Config.CircleChance.Modifier);
		}
		if (_state.Config.ChargeChance != null)
		{
			_nextPhaseChance.AddOption(8, "Charge", _state.Config.ChargeChance.Chance, _state.Config.ChargeChance.Modifier);
		}
		_nextPhaseChance.CompleteSetup();
	}

	private bool ShouldGoHaywire()
	{
		HaywireActivator.CalculateActivation(Blackboard.HaywireState, AttackPhase.Pause);
		return Blackboard.HaywireState.ActiveState != null;
	}

	private bool ShouldGoSlash()
	{
		SlashActivator.CalculateActivation(Blackboard.SlashState, AttackPhase.Pause);
		return Blackboard.SlashState.ActiveState != null;
	}

	private AttackPhase ChooseNextPhase()
	{
		if (LowBatteryDetector.ShouldCharge(Blackboard) || Blackboard.ForceCharge)
		{
			Blackboard.ForceCharge = false;
			return AttackPhase.Charge;
		}
		if (Blackboard.ForceCharge)
		{
			Blackboard.ForceCharge = false;
			return AttackPhase.Charge;
		}
		if (Blackboard.ForceCircleAfterPause)
		{
			return AttackPhase.Circle;
		}
		AttackPhase randomOption = (AttackPhase)_nextPhaseChance.GetRandomOption();
		if (randomOption != AttackPhase.Charge)
		{
			return randomOption;
		}
		if (!Blackboard.Systems.DropsObjectsMechanic.ViewModel.IsDroppedObjectActive)
		{
			return AttackPhase.Charge;
		}
		return (AttackPhase)_nextPhaseChance.GetHighestWeightedOption(8);
	}

	public Pause()
	{
		_nextPhaseChance = new RandomChanceGroup("PauseNextPhase");
	}
}
