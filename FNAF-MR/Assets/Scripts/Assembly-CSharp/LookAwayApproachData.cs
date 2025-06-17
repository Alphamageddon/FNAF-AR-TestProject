public class LookAwayApproachData
{
	public readonly float ApproachSpeed;

	public readonly float StareDurationForBlackoutNoChargeSeconds;

	public readonly float StareDurationForBlackoutFullChargeSeconds;

	public LookAwayApproachData(ATTACK_DATA.LookAwayApproach rawSettings)
	{
		ApproachSpeed = rawSettings.ApproachSpeed;
		StareDurationForBlackoutNoChargeSeconds = rawSettings.StareDurationForBlackoutNoChargeSeconds;
		StareDurationForBlackoutFullChargeSeconds = rawSettings.StareDurationForBlackoutFullChargeSeconds;
	}
}
