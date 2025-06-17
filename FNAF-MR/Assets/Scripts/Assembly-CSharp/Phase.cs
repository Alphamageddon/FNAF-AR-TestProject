public abstract class Phase
{
	protected Blackboard Blackboard;

	protected SimpleTimer EndOfPhase;

	public abstract AttackPhase AttackPhase { get; }

	public void Enter()
	{
		EnterPhase();
	}

	public AttackPhase Update()
	{
		return UpdatePhase();
	}

	public void Exit()
	{
		ExitPhase();
		EndOfPhase.Reset();
	}

	protected abstract void EnterPhase();

	protected abstract AttackPhase UpdatePhase();

	protected abstract void ExitPhase();

	public void Setup(Blackboard blackboard)
	{
		Blackboard = blackboard;
		EndOfPhase = new SimpleTimer();
	}

	public void Teardown()
	{
		Blackboard = null;
		EndOfPhase = null;
	}
}
