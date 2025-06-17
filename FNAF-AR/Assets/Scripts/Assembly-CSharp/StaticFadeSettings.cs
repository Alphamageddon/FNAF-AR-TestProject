public class StaticFadeSettings
{
	public readonly float FadeIn;

	public readonly float FadeOut;

	public StaticFadeSettings(STATIC_DATA.FadeSettings rawSettings)
	{
		FadeIn = (float)rawSettings.FadeIn;
		FadeOut = (float)rawSettings.FadeOut;
	}
}
