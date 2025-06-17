public class InitialPauseData
{
	public RangeData Seconds;

	public InitialPauseData(ATTACK_DATA.InitialPause rawSettings)
	{
		Seconds = new RangeData(rawSettings.Seconds.Min, rawSettings.Seconds.Max);
	}
}
