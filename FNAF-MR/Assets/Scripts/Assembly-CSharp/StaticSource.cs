using System.Collections.Generic;

public class StaticSource
{
	public AngleStrength BaseAngleStrength;

	public StaticEffectSettings BaseEffects;

	public AngleStrength AngleStrength;

	public StaticEffectSettings Effects;

	public AngleStrength FlashlightAngleStrength;

	public StaticEffectSettings FlashlightEffects;

	public readonly List<AdditiveSource> AdditiveSources;

	public float ShearModifier;

	public float Angle;

	public StaticSource()
	{
		AdditiveSources = new List<AdditiveSource>();
	}
}
