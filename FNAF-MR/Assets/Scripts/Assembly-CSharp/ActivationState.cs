public class ActivationState
{
	public readonly HaywirePhaseSettingsData Config;

	public readonly SlashPhaseSettingsData SlashConfig;

	public int TimesActivated;

	public int TimesNotActivated;

	public float TriggerPercent;

	public ActivationState(HaywirePhaseSettingsData config)
	{
		Config = config;
	}

	public ActivationState(SlashPhaseSettingsData config)
	{
		SlashConfig = config;
	}
}
