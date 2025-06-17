public class PhantomWalkData
{
	public readonly RangeData EncounterBurnTime;

	public readonly RangeData PhaseBurnTime;

	public readonly bool ShouldHaywire;

	public PhantomWalkData(ATTACK_DATA.PhantomWalk rawSettings)
	{
		EncounterBurnTime = new RangeData(rawSettings.EncounterBurnTime.Min, rawSettings.EncounterBurnTime.Max);
		PhaseBurnTime = new RangeData(rawSettings.PhaseBurnTime.Min, rawSettings.PhaseBurnTime.Max);
		ShouldHaywire = rawSettings.ShouldHaywire;
	}
}
