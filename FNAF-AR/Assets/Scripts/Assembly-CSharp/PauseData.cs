public class PauseData
{
	public readonly RangeData Seconds;

	public readonly bool UseGlimpse;

	public readonly RandomChanceData GlimpseChance;

	public readonly RandomChanceData CircleChance;

	public readonly RandomChanceData ChargeChance;

	public PauseData(ATTACK_DATA.Pause rawSettings)
	{
		if (rawSettings.Seconds != null)
		{
			Seconds = new RangeData(rawSettings.Seconds.Min, rawSettings.Seconds.Max);
		}
		UseGlimpse = rawSettings.UseGlimpse;
		if (rawSettings.NextPhase.Glimpse != null)
		{
			GlimpseChance = new RandomChanceData(rawSettings.NextPhase.Glimpse.Chance, 0f);
		}
		if (rawSettings.NextPhase.Circle != null)
		{
			CircleChance = new RandomChanceData(rawSettings.NextPhase.Circle.Chance, 0f);
		}
		if (rawSettings.NextPhase.Charge != null)
		{
			ChargeChance = new RandomChanceData(rawSettings.NextPhase.Charge.Chance, rawSettings.NextPhase.Charge.Modifier);
		}
	}
}
