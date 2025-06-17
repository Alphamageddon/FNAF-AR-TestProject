public class PhantomPauseData
{
	public readonly RangeData Seconds;

	public PhantomPauseData(ATTACK_DATA.PhantomPause rawSettings)
	{
		Seconds = new RangeData(rawSettings.Seconds.Min, rawSettings.Seconds.Max);
	}
}
