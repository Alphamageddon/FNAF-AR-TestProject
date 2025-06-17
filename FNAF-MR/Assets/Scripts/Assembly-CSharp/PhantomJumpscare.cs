public class PhantomJumpscare : BaseJumpscare
{
	protected override void EnterPhase()
	{
		Blackboard.Model.SetPhantomEffectAndAnimationState(PhantomFxController.States.Jumpscare);
		RunSharedEnterPhase();
		if (!Blackboard.AttackProfile.PhantomSettings.UseGlobalMovement)
		{
			Blackboard.Model.SetTransformOverrideMode(TransformOverrider.Mode.Jumpscare);
		}
		else
		{
			Blackboard.Model.SetTransformOverrideMode(TransformOverrider.Mode.JumpscareGlobal);
		}
	}

	protected override AttackPhase UpdatePhase()
	{
		if (Blackboard.Model.IsAnimationTagActive(AnimationTag.Walking))
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
		_ = Blackboard.Systems;
	}
}
