public class ScavengingSearching : Phase
{
	public override AttackPhase AttackPhase => AttackPhase.ScavengingSearching;

	protected override void EnterPhase()
	{
		Blackboard.Model.SetCloakState(cloakEnabled: false);
		Blackboard.Model.SetEyeCloakState(eyeCloakEnabled: false);
		Blackboard.Model.SetEyeGlow(eyeGlowEnabled: true);
		Blackboard.Model.SetEyeColorMode(EyeColorMode.Normal);
		if (Blackboard.ScavengingState.ElectrifiedTimer.Started && !Blackboard.ScavengingState.ElectrifiedTimer.IsExpired())
		{
			Blackboard.Model.MoveFollowWaypoints(Blackboard.ScavengingAttackProfile.Movement.ElectrifiedSpeed, isWalking: true);
		}
		else
		{
			Blackboard.Model.MoveFollowWaypoints(Blackboard.ScavengingAttackProfile.Movement.WalkSpeed, isWalking: true);
		}
	}

	protected override AttackPhase UpdatePhase()
	{
		float animatedSpeed = Blackboard.Model.GetMovementSettings().AnimatedSpeed;
		bool flag = Blackboard.Model.IsMoving();
		Blackboard.Model.SetAnimationFloat(AnimationFloat.ScavengingMoveSpeed, flag ? (Blackboard.Model.GetMoveSpeed() / animatedSpeed) : 0f);
		if (Blackboard.ScavengingState.ElectrifiedTimer.Started && Blackboard.ScavengingState.ElectrifiedTimer.IsExpired())
		{
			Blackboard.ScavengingState.ElectrifiedTimer.Reset();
			Blackboard.Model.StopShockFxScavenging();
			Blackboard.Model.MoveFollowWaypoints(Blackboard.ScavengingAttackProfile.Movement.WalkSpeed, isWalking: true);
		}
		if (Blackboard.ShockedDuringScavenging)
		{
			Blackboard.ShockedDuringScavenging = false;
			if (Blackboard.ScavengingState.ElectrifiedTimer.Started && !Blackboard.ScavengingState.ElectrifiedTimer.IsExpired())
			{
				return AttackPhase.Jumpscare;
			}
			return AttackPhase.ScavengingStunned;
		}
		if ((double)Blackboard.Model.GetDistanceFromCamera() < 1.5)
		{
			return AttackPhase.Jumpscare;
		}
		if (Blackboard.Model.FOV.canSeePlayer)
		{
			return AttackPhase.ScavengingSpotted;
		}
		return AttackPhase.Null;
	}

	protected override void ExitPhase()
	{
		Blackboard.Model.StopMoving();
	}
}
