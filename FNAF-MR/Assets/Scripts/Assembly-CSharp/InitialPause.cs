using UnityEngine;

public class InitialPause : BaseInitialPause
{
	protected override void EnterPhase()
	{
		Blackboard.Model.SetMovementMode(SpaceMover.Mode.LOCAL);
		Blackboard.Model.SetAnimationMode(AnimationMode.Attack);
		Blackboard.Model.SetCloakState(cloakEnabled: true);
		Blackboard.Model.SetEyeCloakState(eyeCloakEnabled: true);
		Blackboard.Model.SetEyeGlow(eyeGlowEnabled: false);
		Debug.LogError("INTITATING TELEPORT FOR INITIAL PAUSE");
		TeleportReposition.NormalTeleport(Blackboard);
		RunSharedEnterPhase();
	}

	protected override AttackPhase UpdatePhase()
	{
		if (!EndOfPhase.IsExpired() || !EndOfPhase.Started)
		{
			return AttackPhase.Null;
		}
		return AttackPhase.Circle;
	}

	protected override void ExitPhase()
	{
		RunSharedExitPhase();
	}
}
