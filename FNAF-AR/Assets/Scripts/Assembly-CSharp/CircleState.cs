public class CircleState
{
	public readonly CircleData Config;

	public readonly SimpleTimer SpeedChangeTimer;

	public readonly SimpleTimer HaywireTimer;

	public readonly SimpleTimer SlashTimer;

	public bool UseMinSpeed;

	public void Reset()
	{
		SpeedChangeTimer.Reset();
		HaywireTimer.Reset();
		SlashTimer.Reset();
		UseMinSpeed = false;
	}

	public CircleState(CircleData config)
	{
		SpeedChangeTimer = new SimpleTimer();
		HaywireTimer = new SimpleTimer();
		SlashTimer = new SimpleTimer();
		Config = config;
	}
}
