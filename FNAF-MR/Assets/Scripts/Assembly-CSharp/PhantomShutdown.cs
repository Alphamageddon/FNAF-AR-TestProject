public class PhantomShutdown : BaseShutdown
{
	protected override void EnterPhase()
	{
		Blackboard.Model.SetPhantomEffectAndAnimationState(PhantomFxController.States.Shutdown);
		RunSharedEnterPhase();
	}

	protected override AttackPhase UpdatePhase()
	{
		if (EndOfPhase.Started && EndOfPhase.IsExpired())
		{
			return AttackPhase.Results;
		}
		if (!Blackboard.Model.IsAnimationTagActive(AnimationTag.Walking) && !Blackboard.Model.IsAnimationTagActive(AnimationTag.Shutdown) && !EndOfPhase.Started)
		{
			EndOfPhase.StartTimer(Blackboard.Model.GetPhantomShutdownEffectTime());
		}
		return AttackPhase.Null;
	}

	protected override void ExitPhase()
	{
		RunSharedExitPhase();
		_ = Blackboard.Systems;
	}
}
