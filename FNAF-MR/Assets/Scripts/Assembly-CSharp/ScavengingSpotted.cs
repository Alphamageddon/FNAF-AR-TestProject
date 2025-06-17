using UnityEngine;

public class ScavengingSpotted : Phase
{
	private SimpleTimer loseTimer = new SimpleTimer();

	public override AttackPhase AttackPhase => AttackPhase.ScavengingSpotted;

	protected override void EnterPhase()
	{
		Blackboard.Model.SetCloakState(cloakEnabled: false);
		Blackboard.Model.SetEyeCloakState(eyeCloakEnabled: false);
		Blackboard.Model.SetEyeGlow(eyeGlowEnabled: true);
		Blackboard.Model.SetEyeColorMode(EyeColorMode.Attack);
		loseTimer.StartTimer(Blackboard.ScavengingAttackProfile.LoseTime);
	}

	protected override AttackPhase UpdatePhase()
	{
		float animatedSpeed = Blackboard.Model.GetMovementSettings().AnimatedSpeed;
		Blackboard.Model.SetAnimationFloat(AnimationFloat.ScavengingMoveSpeed, Blackboard.Model.IsMoving() ? (Blackboard.Model.GetMoveSpeed() / animatedSpeed) : 0f);
		if (Blackboard.ScavengingState.ElectrifiedTimer.Started && Blackboard.ScavengingState.ElectrifiedTimer.IsExpired())
		{
			Blackboard.ScavengingState.ElectrifiedTimer.Reset();
			Blackboard.Model.StopShockFxScavenging();
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
		if (loseTimer.Started && loseTimer.IsExpired())
		{
			return AttackPhase.ScavengingSearching;
		}
		if (Blackboard.Model.FOV.canSeePlayer)
		{
			if (Blackboard.ScavengingState.ElectrifiedTimer.Started && !Blackboard.ScavengingState.ElectrifiedTimer.IsExpired())
			{
				Blackboard.Model.MoveInLineTowardCamera(Blackboard.ScavengingAttackProfile.Movement.ElectrifiedSpeed, isWalking: false, Blackboard.ScavengingAttackProfile.LoseTime);
			}
			else
			{
				Blackboard.Model.MoveInLineTowardCamera(Blackboard.ScavengingAttackProfile.Movement.RunSpeed, isWalking: false, Blackboard.ScavengingAttackProfile.LoseTime);
			}
			loseTimer.StartTimer(Blackboard.ScavengingAttackProfile.LoseTime);
		}
		return AttackPhase.Null;
	}

	protected override void ExitPhase()
	{
		Blackboard.Model.StopMoving();
		loseTimer.Reset();
		if (Random.Range(0.0001f, 1f) > Blackboard.ScavengingAttackProfile.SwapDirectionAfterLosePlayerChance)
		{
			Blackboard.Model.SwapWaypointIncrement();
		}
	}
}
