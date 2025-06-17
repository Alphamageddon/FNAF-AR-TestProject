using System;

public class SubEntityEffect
{
	public readonly SubEntityData.SubEntityEffectRequirement EffectRequirement;

	public readonly SubEntityData.SubEntityEffectType EffectType;

	public readonly RangeData MinMaxLifetime;

	public readonly RangeData MinMaxDistance;

	public readonly RangeData MinMaxValues;

	public readonly SubEntityData.SubEntityEffectValueType ValueType;

	public SubEntityEffect(SUB_ENTITY_DATA.Effect rawSettings)
	{
		EffectRequirement = (SubEntityData.SubEntityEffectRequirement)Enum.Parse(typeof(SubEntityData.SubEntityEffectRequirement), rawSettings.EffectRequirement);
		EffectType = (SubEntityData.SubEntityEffectType)Enum.Parse(typeof(SubEntityData.SubEntityEffectType), rawSettings.EffectType);
		if (rawSettings.MinMaxLifetime != null)
		{
			MinMaxLifetime = new RangeData(rawSettings.MinMaxLifetime.Min, rawSettings.MinMaxLifetime.Max);
		}
		if (rawSettings.MinMaxDistance != null)
		{
			MinMaxDistance = new RangeData(rawSettings.MinMaxDistance.Min, rawSettings.MinMaxDistance.Max);
		}
		MinMaxValues = new RangeData(rawSettings.MinMaxValues.Min, rawSettings.MinMaxValues.Max);
		ValueType = (SubEntityData.SubEntityEffectValueType)Enum.Parse(typeof(SubEntityData.SubEntityEffectValueType), rawSettings.ValueType);
	}
}
