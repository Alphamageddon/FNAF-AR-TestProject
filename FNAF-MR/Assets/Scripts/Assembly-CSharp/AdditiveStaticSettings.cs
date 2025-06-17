public class AdditiveStaticSettings
{
	public readonly bool IsPositional;

	public readonly StaticFadeSettings FadeSettings;

	public readonly StaticValueRange Duration;

	public readonly StaticEffectSettings Effects;

	public AdditiveStaticSettings(STATIC_DATA.WalkFootsteps rawSettings)
	{
		IsPositional = true;
		FadeSettings = new StaticFadeSettings(rawSettings.FadeSettings);
		Duration = new StaticValueRange(rawSettings.Duration);
		Effects = new StaticEffectSettings(rawSettings.Effects);
	}

	public AdditiveStaticSettings(STATIC_DATA.RunFootsteps rawSettings)
	{
		IsPositional = rawSettings.IsPositional;
		FadeSettings = new StaticFadeSettings(rawSettings.FadeSettings);
		Duration = new StaticValueRange(rawSettings.Duration);
		Effects = new StaticEffectSettings(rawSettings.Effects);
	}
}
