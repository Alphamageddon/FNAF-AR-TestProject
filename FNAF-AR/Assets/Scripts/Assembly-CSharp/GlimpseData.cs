public class GlimpseData
{
	public readonly RangeData Cooldown;

	public readonly RangeData Distance;

	public readonly RangeData CloakDelayTime;

	public readonly RangeData ExpireTime;

	public readonly RangeData HalfAngleDeadZone;

	public readonly RangeData HalfAngleTeleport;

	public readonly RangeData PhaseDuration;

	public readonly RangeData RepositionDelay;

	public GlimpseData(ATTACK_DATA.Glimpse rawSettings)
	{
		if (rawSettings.Cooldown != null)
		{
			Cooldown = new RangeData(rawSettings.Cooldown.Min, rawSettings.Cooldown.Max);
		}
		if (rawSettings.Distance != null)
		{
			Distance = new RangeData(rawSettings.Distance.Min, rawSettings.Distance.Max);
		}
		if (rawSettings.CloakDelayTime != null)
		{
			CloakDelayTime = new RangeData(rawSettings.CloakDelayTime.Min, rawSettings.CloakDelayTime.Max);
		}
		if (rawSettings.ExpireTime != null)
		{
			ExpireTime = new RangeData(rawSettings.ExpireTime.Min, rawSettings.ExpireTime.Max);
		}
		if (rawSettings.HalfAngleDeadZone != null)
		{
			HalfAngleDeadZone = new RangeData(rawSettings.HalfAngleDeadZone.Min, rawSettings.HalfAngleDeadZone.Max);
		}
		if (rawSettings.HalfAngleTeleport != null)
		{
			HalfAngleTeleport = new RangeData(rawSettings.HalfAngleTeleport.Min, rawSettings.HalfAngleTeleport.Max);
		}
		if (rawSettings.PhaseDuration != null)
		{
			PhaseDuration = new RangeData(rawSettings.PhaseDuration.Min, rawSettings.PhaseDuration.Max);
		}
		if (rawSettings.RepositionDelay != null)
		{
			RepositionDelay = new RangeData(rawSettings.RepositionDelay.Min, rawSettings.RepositionDelay.Max);
		}
	}
}
