public class GlimpseState
{
	public readonly GlimpseData Config;

	public readonly SimpleTimer ExitTimer;

	public void Reset()
	{
		ExitTimer.Reset();
	}

	public GlimpseState(GlimpseData config)
	{
		ExitTimer = new SimpleTimer();
		Config = config;
	}
}
