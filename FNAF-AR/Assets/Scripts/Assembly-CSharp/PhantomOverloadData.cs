public class PhantomOverloadData
{
	public readonly RangeData ReactionTime;

	public readonly RangeData FlashlightDisableTime;

	public PhantomOverloadData(ATTACK_DATA.PhantomOverload rawSettings)
	{
		ReactionTime = new RangeData(rawSettings.ReactionTime.Min, rawSettings.ReactionTime.Max);
		FlashlightDisableTime = new RangeData(rawSettings.FlashlightDisableTime.Min, rawSettings.FlashlightDisableTime.Max);
	}
}
