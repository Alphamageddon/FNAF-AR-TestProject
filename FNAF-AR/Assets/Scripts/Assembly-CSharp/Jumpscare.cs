public class Jumpscare : BaseJumpscare
{
	protected override void EnterPhase()
	{
		Blackboard.Model.SetCloakState(cloakEnabled: false);
		Blackboard.Model.SetEyeCloakState(eyeCloakEnabled: false);
		Blackboard.Model.SetEyeColorMode(EyeColorMode.Attack);
		Blackboard.Model.SetEyeGlow(eyeGlowEnabled: true);
		Blackboard.Model.SetAnimationTrigger(AnimationTrigger.Jumpscare, shouldSet: true);
		RunSharedEnterPhase();
	}

	protected override AttackPhase UpdatePhase()
	{
		if (Blackboard.Model.IsAnimationTagActive(AnimationTag.Default))
		{
			return AttackPhase.Null;
		}
		if (Blackboard.Model.IsAnimationTagActive(AnimationTag.Walking))
		{
			return AttackPhase.Null;
		}
		if (Blackboard.Model.IsAnimationTagActive(AnimationTag.Haywire))
		{
			return AttackPhase.Null;
		}
		if (Blackboard.Model.IsAnimationTagActive(AnimationTag.Glimpse))
		{
			return AttackPhase.Null;
		}
		if (Blackboard.Model.IsAnimationTagActive(AnimationTag.Charge))
		{
			return AttackPhase.Null;
		}
		if (!Blackboard.Model.IsAnimationTagActive(AnimationTag.Jumpscare))
		{
			return AttackPhase.Results;
		}
		return AttackPhase.Null;
	}

	protected override void ExitPhase()
	{
		RunSharedExitPhase();
	}
}
