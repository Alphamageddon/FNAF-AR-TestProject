public class Shutdown : BaseShutdown
{
	private bool _hasAnimatronicToActivate;

	protected override void EnterPhase()
	{
		Blackboard.Model.SetCloakState(cloakEnabled: false);
		Blackboard.Model.SetEyeCloakState(eyeCloakEnabled: false);
		Blackboard.Model.SetEyeColorMode(EyeColorMode.Attack);
		Blackboard.Model.SetEyeGlow(eyeGlowEnabled: true);
		Blackboard.NumAnimatronicsRemaining--;
		if (!Blackboard.HasAnimatronicToActivate(EncounterTrigger.PreShutdown))
		{
			Blackboard.Model.SetAnimationTrigger(AnimationTrigger.Shutdown, shouldSet: true);
			_hasAnimatronicToActivate = Blackboard.HasAnimatronicToActivate(EncounterTrigger.Shutdown);
			if (!_hasAnimatronicToActivate)
			{
				RunSharedEnterPhase();
			}
		}
	}

	protected override AttackPhase UpdatePhase()
	{
		if (Blackboard.HasAnimatronicToActivate(EncounterTrigger.PreShutdown))
		{
			Blackboard.ActivateNextAnimatronic(EncounterTrigger.PreShutdown);
			return AttackPhase.WaitForCamera;
		}
		if (Blackboard.Model.IsAnimationTagActive(AnimationTag.Charge))
		{
			return AttackPhase.Null;
		}
		if (Blackboard.Model.IsAnimationTagActive(AnimationTag.Slashed))
		{
			return AttackPhase.Null;
		}
		if (Blackboard.Model.IsAnimationTagActive(AnimationTag.Shutdown))
		{
			return AttackPhase.Null;
		}
		if (!_hasAnimatronicToActivate)
		{
			return AttackPhase.Results;
		}
		Blackboard.ActivateNextAnimatronic(EncounterTrigger.Shutdown);
		return AttackPhase.WaitForCamera;
	}

	protected override void ExitPhase()
	{
		RunSharedExitPhase();
	}
}
