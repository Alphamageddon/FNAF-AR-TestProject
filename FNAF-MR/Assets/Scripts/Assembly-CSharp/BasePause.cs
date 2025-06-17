public abstract class BasePause : Phase
{
	public override AttackPhase AttackPhase => AttackPhase.Pause;

	protected void RunSharedEnterPhase()
	{
		Blackboard.Systems.AttackStatic.Container.UpdatePhaseStaticSettings(Blackboard.EntityId, Blackboard.StaticConfig.Pause, Blackboard.AttackProfile.ShearModifier);
		Blackboard.Model.RaiseAudioEventFromCpu(AudioEventName.AttackPauseBegin);
		if (Blackboard.Systems.VisibilityAlterEffect.ShouldBeActiveWhilePaused)
		{
			Blackboard.Systems.VisibilityAlterEffect.StartEffect();
		}
		Blackboard.Systems.AttackDisruption.PauseDisruption();
	}

	protected void RunSharedExitPhase()
	{
		Blackboard.Systems.AttackStatic.Container.ClearPhaseStaticSettings(Blackboard.EntityId);
		Blackboard.Model.RaiseAudioEventFromCpu(AudioEventName.AttackPauseEnd);
		if (Blackboard.Systems.VisibilityAlterEffect.ShouldBeActiveWhilePaused)
		{
			Blackboard.Systems.VisibilityAlterEffect.StopEffect();
		}
		Blackboard.Systems.AttackDisruption.UnPauseDisruption();
	}
}
