using UnityEngine;

public class WaitForCamera : BaseWaitForCamera
{
	protected override void EnterPhase()
	{
		EndOfPhase.StartTimer(0.1f);
		Debug.Log(Blackboard.AttackProfile.WaitForCameraTime);
		RunSharedEnterPhase();
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
		return AttackPhase.InitialPause;
	}

	protected override void ExitPhase()
	{
		RunSharedExitPhase();
	}
}
