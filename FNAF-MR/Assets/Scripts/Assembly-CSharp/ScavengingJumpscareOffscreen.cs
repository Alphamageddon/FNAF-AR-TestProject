public class ScavengingJumpscareOffscreen : BaseScavengingJumpscare
{
	public override AttackPhase AttackPhase => AttackPhase.JumpscareOffscreen;

	protected override void EnterPhase()
	{
		RunSharedEnterPhase();
	}

	protected override AttackPhase UpdatePhase()
	{
		return AttackPhase.Results;
	}

	protected override void ExitPhase()
	{
		RunSharedExitPhase();
	}
}
