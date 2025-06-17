using UnityEngine;

public class AttackPlayer : Phase
{
	private bool _isJumpscare;

	public override AttackPhase AttackPhase => AttackPhase.AttackPlayer;

	protected override void EnterPhase()
	{
		float time = 0f;
		_isJumpscare = WillKillPlayer();
		if (_isJumpscare)
		{
			time = GetJumpscareDelay();
		}
		EndOfPhase.StartTimer(time);
	}

	private bool WillKillPlayer()
	{
		return true;
	}

	private float GetJumpscareDelay()
	{
		if (Blackboard.AttackProfile.Charge.JumpscareDelayTime != null)
		{
			return Random.Range(Blackboard.AttackProfile.Charge.JumpscareDelayTime.Min, Blackboard.AttackProfile.Charge.JumpscareDelayTime.Max);
		}
		return 0f;
	}

	protected override AttackPhase UpdatePhase()
	{
		if (EndOfPhase.IsExpired())
		{
			if (_isJumpscare)
			{
				return AttackPhase.Jumpscare;
			}
			return AttackPhase.Slashed;
		}
		return AttackPhase.Null;
	}

	protected override void ExitPhase()
	{
	}
}
