public class WaitForTapResultStep : BaseResultStep
{
	private bool _hasBeenClicked;

	private readonly SimpleTimer _expireTimer;

	public WaitForTapResultStep(ResultStepConfig config)
		: base(config)
	{
		_expireTimer = new SimpleTimer();
	}

	public override bool IsComplete()
	{
		TryToExpire();
		if (base.HasStarted)
		{
			return _hasBeenClicked;
		}
		return false;
	}

	protected override void StartStep()
	{
		_expireTimer.StartTimer(Config.timeoutTime);
		Config.button.onClick.AddListener(ButtonClick);
	}

	private void ButtonClick()
	{
		_hasBeenClicked = true;
		Config.button.onClick.RemoveListener(ButtonClick);
	}

	private void TryToExpire()
	{
		if (_expireTimer.Started && _expireTimer.IsExpired())
		{
			Config.button.onClick.Invoke();
		}
	}
}
