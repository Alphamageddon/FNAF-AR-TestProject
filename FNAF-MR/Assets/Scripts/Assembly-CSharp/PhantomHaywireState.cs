public class PhantomHaywireState
{
	public readonly HaywireGlobalState GlobalState;

	public readonly HaywireData Config;

	public float Duration;

	public bool LookAway;

	public float LookSwapTime;

	public bool HasTriggeredCounter;

	public float CumulativeLookTime;

	public void Reset()
	{
		Duration = 0f;
		LookAway = false;
		LookSwapTime = -1f;
		HasTriggeredCounter = false;
		CumulativeLookTime = 0f;
	}

	public PhantomHaywireState(HaywireGlobalState globalState)
	{
		GlobalState = globalState;
		Config = globalState.Config;
	}
}
