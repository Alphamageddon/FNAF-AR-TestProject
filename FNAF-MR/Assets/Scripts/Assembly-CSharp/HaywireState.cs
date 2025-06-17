public class HaywireState
{
	public readonly HaywireGlobalState GlobalState;

	public readonly HaywireData Config;

	public float Duration;

	public bool LookAway;

	public float LookSwapTime;

	public bool HasTriggeredCounter;

	public float CumulativeLookTime;

	public readonly SimpleTimer HiddenTimer;

	public readonly SimpleTimer LocateTimer;

	public readonly SimpleTimer ContinuousSwapTimer;

	public bool IsContinuous;

	public void Reset()
	{
		Duration = 0f;
		LookAway = false;
		LookSwapTime = -1f;
		HasTriggeredCounter = false;
		CumulativeLookTime = 0f;
		HiddenTimer.Reset();
		LocateTimer.Reset();
		ContinuousSwapTimer.Reset();
		IsContinuous = false;
	}

	public HaywireState(HaywireGlobalState globalState)
	{
		HiddenTimer = new SimpleTimer();
		LocateTimer = new SimpleTimer();
		ContinuousSwapTimer = new SimpleTimer();
		GlobalState = globalState;
		Config = globalState.Config;
	}
}
