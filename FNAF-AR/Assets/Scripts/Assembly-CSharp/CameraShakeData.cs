public class CameraShakeData
{
	public readonly float Magnitude;

	public readonly float Roughness;

	public readonly float FadeIn;

	public readonly float FadeOut;

	public CameraShakeData(ATTACK_DATA.CameraShake rawSettings)
	{
		Magnitude = rawSettings.Magnitude;
		Roughness = rawSettings.Roughness;
		FadeIn = rawSettings.FadeIn;
		FadeOut = rawSettings.FadeOut;
	}
}
