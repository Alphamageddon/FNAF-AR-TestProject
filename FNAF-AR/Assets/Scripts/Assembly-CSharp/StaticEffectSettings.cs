public class StaticEffectSettings
{
	private readonly float Shear;

	private readonly float Audio;

	public StaticEffectSettings(STATIC_DATA.Effects rawSettings)
	{
		Shear = (float)rawSettings.Shear;
		Audio = (float)rawSettings.Audio;
	}

	public StaticEffectSettings(STATIC_DATA.BaseEffects rawSettings)
	{
		Shear = (float)rawSettings.Shear;
		Audio = (float)rawSettings.Audio;
	}

	public StaticEffectSettings(STATIC_DATA.FlashlightEffects rawSettings)
	{
		Shear = (float)rawSettings.Shear;
		Audio = (float)rawSettings.Audio;
	}

	public float GetModifiedShear(float modifier)
	{
		return Shear * modifier;
	}

	public float GetModifiedAudio(float modifier)
	{
		return Audio * modifier;
	}
}
