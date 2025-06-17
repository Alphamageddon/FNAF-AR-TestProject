public class NumberChangeResultStep : BaseResultStep
{
	public NumberChangeResultStep(ResultStepConfig config)
		: base(config)
	{
	}

	public override bool IsComplete()
	{
		if (base.HasStarted)
		{
			return Config.numberChanger.IsComplete;
		}
		return false;
	}

	protected override void StartStep()
	{
		Config.numberChanger.ChangeNumber();
	}
}
