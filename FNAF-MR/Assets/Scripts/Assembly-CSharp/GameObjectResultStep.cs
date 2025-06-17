public class GameObjectResultStep : BaseResultStep
{
	public GameObjectResultStep(ResultStepConfig config)
		: base(config)
	{
	}

	public override bool IsComplete()
	{
		return base.HasStarted;
	}

	protected override void StartStep()
	{
		if (Config.executionType == ResultStepConfig.Type.Enable)
		{
			Config.gameObject.SetActive(value: true);
		}
		else
		{
			Config.gameObject.SetActive(value: false);
		}
	}
}
