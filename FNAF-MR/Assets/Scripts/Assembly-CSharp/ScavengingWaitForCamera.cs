public class ScavengingWaitForCamera : BaseWaitForCamera
{
	protected override void EnterPhase()
	{
		EndOfPhase.StartTimer(0.1f);
	}

	protected override AttackPhase UpdatePhase()
	{
		if (!Blackboard.HasEnteredCameraMode)
		{
			if (!EndOfPhase.IsExpired())
			{
				return AttackPhase.Null;
			}
			return AttackPhase.JumpscareOffscreen;
		}
		if (!EndOfPhase.IsExpired())
		{
			return AttackPhase.Null;
		}
		if (!Blackboard.Systems.IntroScreen.IsDone())
		{
			return AttackPhase.Null;
		}
		return AttackPhase.ScavengingDormant;
	}

	protected override void ExitPhase()
	{
	}
}
