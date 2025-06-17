public class VisibilityAlterEffectData
{
	public readonly bool WhileCircling;

	public readonly bool WhilePaused;

	public readonly float YOffset;

	public readonly float Distance;

	public VisibilityAlterEffectData(ATTACK_DATA.VisibilityAlterEffect rawSettings)
	{
		if (rawSettings.Settings != null)
		{
			WhileCircling = rawSettings.Settings.WhileCircling;
			WhilePaused = rawSettings.Settings.WhilePaused;
			YOffset = rawSettings.Settings.YOffset;
			Distance = rawSettings.Settings.Distance;
		}
	}
}
