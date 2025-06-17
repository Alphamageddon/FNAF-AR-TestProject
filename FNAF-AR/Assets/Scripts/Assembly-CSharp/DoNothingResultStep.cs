public class DoNothingResultStep : BaseResultStep
{
	public DoNothingResultStep(ResultStepConfig config)
		: base(config)
	{
	}

	public override bool IsComplete()
	{
		return true;
	}

	protected override void StartStep()
	{
	}
}
