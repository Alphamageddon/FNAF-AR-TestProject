public class ScavengingStunned : Phase
{
	private bool startedReactivate;

	public override AttackPhase AttackPhase => AttackPhase.ScavengingStunned;

	protected override void EnterPhase()
	{
		startedReactivate = false;
		Blackboard.Model.SetCloakState(cloakEnabled: false);
		Blackboard.Model.SetEyeCloakState(eyeCloakEnabled: false);
		Blackboard.Model.SetEyeGlow(eyeGlowEnabled: true);
		Blackboard.Model.SetEyeColorMode(EyeColorMode.Normal);
		Blackboard.Model.StopMoving();
		Blackboard.Model.SetAnimationTrigger(AnimationTrigger.Shutdown, shouldSet: true);
	}

	protected override AttackPhase UpdatePhase()
	{
		if (Blackboard.ScavengingState.StunnedTimer.Started && Blackboard.ScavengingState.StunnedTimer.IsExpired())
		{
			if (!startedReactivate)
			{
				startedReactivate = true;
				Blackboard.Model.SetAnimationTrigger(AnimationTrigger.Reactivate, shouldSet: true);
			}
			if (Blackboard.Model.IsAnimationTagActive(AnimationTag.Shutdown))
			{
				return AttackPhase.Null;
			}
			return AttackPhase.ScavengingSearching;
		}
		if (!Blackboard.ScavengingState.StunnedTimer.Started)
		{
			Blackboard.ScavengingState.StunnedTimer.StartTimer(Blackboard.ScavengingAttackProfile.ShockedStunTime);
		}
		return AttackPhase.Null;
	}

	protected override void ExitPhase()
	{
		startedReactivate = false;
		Blackboard.ScavengingState.StunnedTimer.Reset();
		Blackboard.ScavengingState.ElectrifiedTimer.StartTimer(Blackboard.ScavengingAttackProfile.ElectrifiedTime);
		Blackboard.Model.BeginShockFxScavenging();
	}
}
