using UnityEngine;

public class PhantomPause : BasePause
{
	private PhantomPauseState _state;

	private float _startDistance;

	private float _startAngle;

	protected override void EnterPhase()
	{
		_startDistance = Blackboard.Model.GetDistanceFromCamera();
		_startAngle = Blackboard.Model.GetAbsoluteAngleFromCamera();
		if (_state == null)
		{
			_state = new PhantomPauseState(Blackboard.AttackProfile.PhantomPause);
		}
		EndOfPhase.StartTimer(Random.Range(_state.Config.Seconds.Min, _state.Config.Seconds.Max));
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
		Blackboard.Model.Teleport(_startAngle, _startDistance, faceCamera: false);
		RunSharedExitPhase();
	}
}
