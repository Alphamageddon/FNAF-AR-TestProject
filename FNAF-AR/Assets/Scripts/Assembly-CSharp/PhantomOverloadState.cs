public class PhantomOverloadState
{
	public readonly PhantomOverloadData Config;

	public bool HasOverloadEffectTriggered;

	public bool HasRepositionTriggered;

	public readonly SimpleTimer OverloadTimer;

	public void Reset()
	{
		HasOverloadEffectTriggered = false;
		HasRepositionTriggered = false;
		OverloadTimer.Reset();
	}

	public PhantomOverloadState(PhantomOverloadData config)
	{
		OverloadTimer = new SimpleTimer();
		Config = config;
	}
}
