public class Slashed : Phase
{
	private bool _animStarted;

	public override AttackPhase AttackPhase => AttackPhase.Slashed;

	protected override void EnterPhase()
	{
		_animStarted = false;
		Blackboard.Model.SetCloakState(cloakEnabled: false);
		Blackboard.Model.SetEyeCloakState(eyeCloakEnabled: false);
		Blackboard.Model.SetEyeColorMode(EyeColorMode.Attack);
		Blackboard.Model.SetEyeGlow(eyeGlowEnabled: true);
		Blackboard.Model.TeleportInFrontOfCamera(Blackboard.Model.GetMovementSettings().HaywireDistance);
		Blackboard.Model.SetAnimationTrigger(AnimationTrigger.Slashed, shouldSet: true);
		if (Blackboard.Systems != null)
		{
			Blackboard.Systems.Shocker.DisableShocker();
		}
	}

	protected override AttackPhase UpdatePhase()
	{
		if (Blackboard.Model.IsAnimationTagActive(AnimationTag.Slashed) && !_animStarted)
		{
			_animStarted = true;
		}
		if (!_animStarted)
		{
			return AttackPhase.Null;
		}
		if (Blackboard.Model.IsAnimationTagActive(AnimationTag.Slashed))
		{
			return AttackPhase.Null;
		}
		ApplyDamage();
		SetUpForPausePhase();
		if (!Blackboard.HasAnimatronicToActivate(EncounterTrigger.Slashed))
		{
			return AttackPhase.Pause;
		}
		Blackboard.ActivateNextAnimatronic(EncounterTrigger.Slashed);
		return AttackPhase.WaitForCamera;
	}

	private void ApplyDamage()
	{
	}

	private void SetUpForPausePhase()
	{
		TeleportReposition.NormalTeleport(Blackboard);
		Blackboard.ForceCircleAfterPause = Blackboard.AttackProfile.Charge.ForceCircleAfterPause;
		Blackboard.ResetPausePhaseChangeGroup = true;
	}

	protected override void ExitPhase()
	{
		Blackboard.Systems.AttackStatic.Container.ClearPhaseStaticSettings(Blackboard.EntityId);
		Blackboard.Systems.Shocker.EnableShocker();
	}
}
