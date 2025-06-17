using System;
using System.Collections.Generic;

public class SurgeData
{
	public const string SURGE_CHANCE = "ChanceToSurge";

	public const string SURGE_CHANCE_MODIFIER = "ChanceToSurgeModifier";

	public const string SURGE_CANCEL_DURATION = "SurgeCancelDuration";

	public readonly RangeData Seconds;

	public readonly RandomChanceData ActivationChance;

	public readonly float CancelTime;

	public readonly SurgeCancelAction CancelAction;

	public readonly float BatteryDrainRateBase;

	public readonly float BatteryDrainRateCancel;

	public readonly float BatterySurgeBlinkDuration;

	public readonly float BatterySurgeMaskLightFadeTime;

	public SurgeData(ATTACK_DATA.Surge rawSettings)
	{
		if (rawSettings.Settings.Cooldown != null)
		{
			Seconds = new RangeData(rawSettings.Settings.Cooldown.Min, rawSettings.Settings.Cooldown.Max);
		}
		if (rawSettings.Settings.Activation != null)
		{
			ActivationChance = new RandomChanceData(rawSettings.Settings.Activation.Chance, rawSettings.Settings.Activation.Modifier);
		}
		if (rawSettings.Settings != null)
		{
			CancelTime = rawSettings.Settings.CancelTime;
			CancelAction = (SurgeCancelAction)Enum.Parse(typeof(SurgeCancelAction), rawSettings.Settings.CancelAction);
			BatteryDrainRateBase = rawSettings.Settings.BatteryDrainRateBase;
			BatteryDrainRateCancel = rawSettings.Settings.BatteryDrainRateCancel;
			BatterySurgeBlinkDuration = rawSettings.Settings.BlinkDuration;
			BatterySurgeMaskLightFadeTime = rawSettings.Settings.MaskLightFadeTime;
		}
	}

	public SurgeData(SurgeData surge, Dictionary<string, float> mods)
	{
		Seconds = surge.Seconds;
		if (surge.ActivationChance != null)
		{
			ActivationChance = new RandomChanceData(surge.ActivationChance, "ChanceToSurge", "ChanceToSurgeModifier", mods);
		}
		CancelTime = FloatHelper.ApplyModifier(surge.CancelTime, "SurgeCancelDuration", mods);
		CancelAction = surge.CancelAction;
		BatteryDrainRateBase = surge.BatteryDrainRateBase;
		BatteryDrainRateCancel = surge.BatteryDrainRateCancel;
		BatterySurgeBlinkDuration = surge.BatterySurgeBlinkDuration;
		BatterySurgeMaskLightFadeTime = surge.BatterySurgeMaskLightFadeTime;
	}

	public override string ToString()
	{
		return $"{{\"ActivationChance\":{ActivationChance},\"CancelTime\":{CancelTime}}}";
	}
}
