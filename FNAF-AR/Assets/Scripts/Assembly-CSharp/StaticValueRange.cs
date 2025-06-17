public class StaticValueRange
{
	public readonly float Min;

	public readonly float Max;

	public StaticValueRange(STATIC_DATA.Duration rawSettings)
	{
		Min = (float)rawSettings.Min;
		Max = (float)rawSettings.Max;
	}

	public StaticValueRange(STATIC_DATA.BaseAngle rawSettings)
	{
		Min = rawSettings.Min;
		Max = rawSettings.Max;
	}

	public StaticValueRange(STATIC_DATA.Angle rawSettings)
	{
		Min = rawSettings.Min;
		Max = rawSettings.Max;
	}

	public StaticValueRange(STATIC_DATA.FlashlightAngle rawSettings)
	{
		Min = rawSettings.Min;
		Max = rawSettings.Max;
	}
}
