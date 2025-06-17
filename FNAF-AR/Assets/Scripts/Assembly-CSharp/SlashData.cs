public class SlashData
{
	public readonly float Seconds;

	public readonly float Cooldown;

	public readonly float MaxCount;

	public readonly MultislashData Multislash;

	public readonly SlashPhaseSettingsData Circle;

	public readonly SlashPhaseSettingsData Pause;

	public SlashData(ATTACK_DATA.AttackDataSlash rawSettings)
	{
		if (rawSettings.Settings != null)
		{
			Seconds = rawSettings.Settings.Seconds;
			Cooldown = rawSettings.Settings.Cooldown;
			MaxCount = rawSettings.Settings.MaxCount;
		}
		if (rawSettings.Multislash != null)
		{
			Multislash = new MultislashData(rawSettings.Multislash);
		}
		if (rawSettings.Circle != null)
		{
			Circle = new SlashPhaseSettingsData(rawSettings.Circle);
		}
		if (rawSettings.Pause != null)
		{
			Pause = new SlashPhaseSettingsData(rawSettings.Pause);
		}
	}
}
