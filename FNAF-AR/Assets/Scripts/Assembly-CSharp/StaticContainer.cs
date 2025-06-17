using System.Collections.Generic;
using UnityEngine;

public class StaticContainer
{
	public readonly Dictionary<string, StaticSource> StaticSources;

	public void RegisterStaticSource(string entityId)
	{
		if (!StaticSources.ContainsKey(entityId))
		{
			StaticSources.Add(entityId, new StaticSource());
		}
	}

	public void UpdateStaticSourceAngle(string entityId, float angle)
	{
		if (StaticSources.ContainsKey(entityId))
		{
			StaticSources[entityId].Angle = angle;
		}
	}

	public void UpdatePhaseStaticSettings(string entityId, PhaseStaticSettings settings, float shearModifier)
	{
		if (!StaticSources.ContainsKey(entityId) || StaticSources[entityId] == null)
		{
			return;
		}
		if (settings != null)
		{
			if (settings.BaseAngle != null)
			{
				StaticSources[entityId].BaseAngleStrength = new AngleStrength(settings.BaseAngle);
			}
			if (settings.BaseEffects != null)
			{
				StaticSources[entityId].BaseEffects = settings.BaseEffects;
			}
			if (settings.Angle != null)
			{
				StaticSources[entityId].AngleStrength = new AngleStrength(settings.Angle);
			}
			if (settings.Effects != null)
			{
				StaticSources[entityId].Effects = settings.Effects;
			}
			if (settings.FlashlightAngle != null)
			{
				StaticSources[entityId].FlashlightAngleStrength = new AngleStrength(settings.FlashlightAngle);
			}
			if (settings.FlashlightEffects != null)
			{
				StaticSources[entityId].FlashlightEffects = settings.FlashlightEffects;
			}
		}
		StaticSources[entityId].ShearModifier = shearModifier;
	}

	public void ClearPhaseStaticSettings(string entityId)
	{
		if (StaticSources.ContainsKey(entityId))
		{
			StaticSources[entityId].AngleStrength = null;
		}
	}

	public void DeregisterStaticSource(string entityId)
	{
		if (StaticSources.ContainsKey(entityId))
		{
			StaticSources.Remove(entityId);
		}
	}

	public void AddFootstepAdditive(string entityId, AdditiveStaticSettings settings)
	{
		if (StaticSources.ContainsKey(entityId) && settings != null)
		{
			AdditiveSource additiveSource = new AdditiveSource();
			additiveSource.IsPositional = settings.IsPositional;
			additiveSource.Strength = new FadeAndDurationStrength(settings.FadeSettings, settings.Duration);
			additiveSource.Strength.Start(Time.time);
			additiveSource.EffectSettings = settings.Effects;
			StaticSources[entityId].AdditiveSources.Add(additiveSource);
		}
	}

	public StaticContainer()
	{
		StaticSources = new Dictionary<string, StaticSource>();
	}
}
