using UnityEngine;

public class PhantomInitialPause : BaseInitialPause
{
	protected override void EnterPhase()
	{
		if (Blackboard.AttackProfile.PhantomSettings.UseGlobalMovement)
		{
			Blackboard.Model.SetMovementMode(SpaceMover.Mode.GLOBAL);
		}
		else
		{
			Blackboard.Model.SetMovementMode(SpaceMover.Mode.LOCAL);
		}
		_ = Blackboard.AttackProfile.PhantomSettings.AndroidOcclusionEnabled;
		RunSharedEnterPhase();
	}

	protected override AttackPhase UpdatePhase()
	{
		if (!EndOfPhase.IsExpired() || !EndOfPhase.Started)
		{
			return AttackPhase.Null;
		}
		return AttackPhase.PhantomWalk;
	}

	protected override void ExitPhase()
	{
		RunSharedExitPhase();
		TeleportReposition.PhantomTeleport(Blackboard, Random.Range(Blackboard.AttackProfile.TeleportReposition.DistanceFromCamera.Min, Blackboard.AttackProfile.TeleportReposition.DistanceFromCamera.Max));
	}
}
