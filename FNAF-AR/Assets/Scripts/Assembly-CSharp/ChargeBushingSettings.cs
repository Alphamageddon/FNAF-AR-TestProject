public class ChargeBushingSettings
{
	public readonly float MaxChargeValue;

	public readonly RangeData InitialCharge;

	public readonly RangeData TargetChargeMin;

	public readonly RangeData TargetChargeMax;

	public readonly RangeData ToleranceAngle;

	public readonly RangeData FillRatePerSecond;

	public readonly RangeData DecayRatePerSecond;

	public readonly RangeData NumLightsPerMeter;

	public readonly RangeData NumBrokenLightsPerMeter;

	public ChargeBushingSettings(ATTACK_DATA.ChargeBushingSettings rawSettings)
	{
		MaxChargeValue = rawSettings.MaxChargeValue;
		if (rawSettings.InitialCharge != null)
		{
			InitialCharge = new RangeData(rawSettings.InitialCharge.Min, rawSettings.InitialCharge.Max);
		}
		if (rawSettings.TargetChargeMin != null)
		{
			TargetChargeMin = new RangeData(rawSettings.TargetChargeMin.Min, rawSettings.TargetChargeMin.Max);
		}
		if (rawSettings.TargetChargeMax != null)
		{
			TargetChargeMax = new RangeData(rawSettings.TargetChargeMax.Min, rawSettings.TargetChargeMax.Max);
		}
		if (rawSettings.ToleranceAngle != null)
		{
			ToleranceAngle = new RangeData(rawSettings.ToleranceAngle.Min, rawSettings.ToleranceAngle.Max);
		}
		if (rawSettings.FillRatePerSecond != null)
		{
			FillRatePerSecond = new RangeData(rawSettings.FillRatePerSecond.Min, rawSettings.FillRatePerSecond.Max);
		}
		if (rawSettings.DecayRatePerSecond != null)
		{
			DecayRatePerSecond = new RangeData(rawSettings.DecayRatePerSecond.Min, rawSettings.DecayRatePerSecond.Max);
		}
		if (rawSettings.NumLightsPerMeter != null)
		{
			NumLightsPerMeter = new RangeData(rawSettings.NumLightsPerMeter.Min, rawSettings.NumLightsPerMeter.Max);
		}
		if (rawSettings.NumBrokenLightsPerMeter != null)
		{
			NumBrokenLightsPerMeter = new RangeData(rawSettings.NumBrokenLightsPerMeter.Min, rawSettings.NumBrokenLightsPerMeter.Max);
		}
	}
}
