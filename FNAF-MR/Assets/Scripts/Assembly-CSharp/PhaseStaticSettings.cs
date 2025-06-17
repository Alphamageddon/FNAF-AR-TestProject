public class PhaseStaticSettings
{
	public readonly StaticValueRange BaseAngle;

	public readonly StaticEffectSettings BaseEffects;

	public readonly StaticValueRange Angle;

	public readonly StaticEffectSettings Effects;

	public readonly StaticValueRange FlashlightAngle;

	public readonly StaticEffectSettings FlashlightEffects;

	public PhaseStaticSettings(STATIC_DATA.Circle rawSettings)
	{
		if (rawSettings.BaseAngle != null)
		{
			BaseAngle = new StaticValueRange(rawSettings.BaseAngle);
		}
		if (rawSettings.BaseEffects != null)
		{
			BaseEffects = new StaticEffectSettings(rawSettings.BaseEffects);
		}
		Angle = new StaticValueRange(rawSettings.Angle);
		Effects = new StaticEffectSettings(rawSettings.Effects);
		FlashlightAngle = new StaticValueRange(rawSettings.FlashlightAngle);
		FlashlightEffects = new StaticEffectSettings(rawSettings.FlashlightEffects);
	}

	public PhaseStaticSettings(STATIC_DATA.Pause rawSettings)
	{
		BaseAngle = new StaticValueRange(rawSettings.BaseAngle);
		BaseEffects = new StaticEffectSettings(rawSettings.BaseEffects);
		Angle = new StaticValueRange(rawSettings.Angle);
		Effects = new StaticEffectSettings(rawSettings.Effects);
		FlashlightAngle = new StaticValueRange(rawSettings.FlashlightAngle);
		FlashlightEffects = new StaticEffectSettings(rawSettings.FlashlightEffects);
	}

	public PhaseStaticSettings(STATIC_DATA.Charge rawSettings)
	{
		BaseAngle = new StaticValueRange(rawSettings.BaseAngle);
		BaseEffects = new StaticEffectSettings(rawSettings.BaseEffects);
		Angle = new StaticValueRange(rawSettings.Angle);
		Effects = new StaticEffectSettings(rawSettings.Effects);
		FlashlightAngle = new StaticValueRange(rawSettings.FlashlightAngle);
		FlashlightEffects = new StaticEffectSettings(rawSettings.FlashlightEffects);
	}

	public PhaseStaticSettings(STATIC_DATA.PhantomWalk rawSettings)
	{
		BaseAngle = new StaticValueRange(rawSettings.BaseAngle);
		BaseEffects = new StaticEffectSettings(rawSettings.BaseEffects);
		Angle = new StaticValueRange(rawSettings.Angle);
		Effects = new StaticEffectSettings(rawSettings.Effects);
		FlashlightAngle = new StaticValueRange(rawSettings.FlashlightAngle);
		FlashlightEffects = new StaticEffectSettings(rawSettings.FlashlightEffects);
	}
}
