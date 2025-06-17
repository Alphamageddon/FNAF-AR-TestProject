public class MultiwireData
{
	public readonly IntRangeData Count;

	public readonly RangeData HalfAngle;

	public readonly RangeData LocateTime;

	public readonly RangeData HiddenTime;

	public MultiwireData(ATTACK_DATA.Multiwire rawSettings)
	{
		Count = new IntRangeData((int)rawSettings.Count.Min, (int)rawSettings.Count.Max);
		HalfAngle = new RangeData(rawSettings.HalfAngle.Min, rawSettings.HalfAngle.Max);
		LocateTime = new RangeData(rawSettings.LocateTime.Min, rawSettings.LocateTime.Max);
		HiddenTime = new RangeData(rawSettings.HiddenTime.Min, rawSettings.HiddenTime.Max);
	}
}
