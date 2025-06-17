using System;
using System.Collections.Generic;

public class HaywireData
{
	public const string HAYWIRE_CIRCLE_CHANCE = "HaywireCircleActivation";

	public const string HAYWIRE_CIRCLE_MODIFIER = "HaywireCircleActivationModifier";

	public const string HAYWIRE_PAUSE_CHANCE = "HaywirePauseActivation";

	public const string HAYWIRE_PAUSE_MODIFIER = "HaywirePauseActivationModifier";

	public const string HAYWIRE_CHARGE_CHANCE = "HaywireChargeActivation";

	public const string HAYWIRE_CHARGE_MODIFIER = "HaywireChargeActivationModifier";

	public const string HAYWIRE_LOOK_TIMER = "HaywireLookTimer";

	public readonly RangeData Seconds;

	public readonly bool ShockCausesJumpscare;

	public readonly bool ShockCausesAttack;

	public readonly bool CoverEyes;

	public readonly HaywireMaskState RequiredMaskState;

	public readonly RandomChanceData LookAway;

	public readonly RandomChanceData LookAt;

	public readonly RandomChanceData LookAtThenAway;

	public readonly RandomChanceData LookAwayAndAtContinuous;

	public readonly RangeData LookChangeTriggerPercent;

	public readonly RangeData ContinuousChangeTriggerInterval;

	public readonly float LookTime;

	public readonly float Cooldown;

	public readonly float MaxCount;

	public readonly MultiwireData Multiwire;

	public readonly HaywirePhaseSettingsData Circle;

	public readonly HaywirePhaseSettingsData Pause;

	public readonly HaywirePhaseSettingsData Charge;

	public HaywireData(ATTACK_DATA.Haywire rawSettings)
	{
		if (rawSettings.Settings.Seconds != null)
		{
			Seconds = new RangeData(rawSettings.Settings.Seconds.Min, rawSettings.Settings.Seconds.Max);
		}
		if (rawSettings.Settings != null)
		{
			ShockCausesJumpscare = rawSettings.Settings.ShockCausesJumpscare;
			ShockCausesAttack = rawSettings.Settings.ShockCausesAttack;
			CoverEyes = rawSettings.Settings.CoverEyes;
		}
		RequiredMaskState = (HaywireMaskState)Enum.Parse(typeof(HaywireMaskState), rawSettings.Settings.RequiredMaskState);
		if (rawSettings.Settings.ShouldLookAway != null)
		{
			LookAway = new RandomChanceData(rawSettings.Settings.ShouldLookAway.Chance, 0f);
		}
		if (rawSettings.Settings.ShouldLookAt != null)
		{
			LookAt = new RandomChanceData(rawSettings.Settings.ShouldLookAt.Chance, 0f);
		}
		if (rawSettings.Settings.ShouldLookAtThenAway != null)
		{
			LookAtThenAway = new RandomChanceData(rawSettings.Settings.ShouldLookAtThenAway.Chance, rawSettings.Settings.ShouldLookAtThenAway.Modifier);
		}
		if (rawSettings.Settings.ShouldLookContinuous != null)
		{
			LookAwayAndAtContinuous = new RandomChanceData(rawSettings.Settings.ShouldLookContinuous.Chance, 0f);
		}
		if (rawSettings.Settings.LookChangeTriggerPercent != null)
		{
			LookChangeTriggerPercent = new RangeData(rawSettings.Settings.LookChangeTriggerPercent.Min, rawSettings.Settings.LookChangeTriggerPercent.Max);
		}
		if (rawSettings.Settings.ContinuousChangeTriggerInterval != null)
		{
			ContinuousChangeTriggerInterval = new RangeData(rawSettings.Settings.ContinuousChangeTriggerInterval.Min, rawSettings.Settings.ContinuousChangeTriggerInterval.Max);
		}
		if (rawSettings.Settings != null)
		{
			LookTime = rawSettings.Settings.LookTime;
			Cooldown = rawSettings.Settings.Cooldown;
			MaxCount = rawSettings.Settings.MaxCount;
		}
		if (rawSettings.Multiwire != null)
		{
			Multiwire = new MultiwireData(rawSettings.Multiwire);
		}
		if (rawSettings.Circle != null)
		{
			Circle = new HaywirePhaseSettingsData(rawSettings.Circle);
		}
		if (rawSettings.Pause != null)
		{
			Pause = new HaywirePhaseSettingsData(rawSettings.Pause);
		}
		if (rawSettings.Charge != null)
		{
			Charge = new HaywirePhaseSettingsData(rawSettings.Charge);
		}
	}

	public HaywireData(HaywireData haywire, Dictionary<string, float> mods)
	{
		Seconds = haywire.Seconds;
		ShockCausesJumpscare = haywire.ShockCausesJumpscare;
		ShockCausesAttack = haywire.ShockCausesAttack;
		CoverEyes = haywire.CoverEyes;
		RequiredMaskState = haywire.RequiredMaskState;
		LookAway = haywire.LookAway;
		LookAt = haywire.LookAt;
		LookAtThenAway = haywire.LookAtThenAway;
		LookAwayAndAtContinuous = haywire.LookAwayAndAtContinuous;
		LookChangeTriggerPercent = haywire.LookChangeTriggerPercent;
		ContinuousChangeTriggerInterval = haywire.ContinuousChangeTriggerInterval;
		LookTime = FloatHelper.ApplyModifier(haywire.LookTime, "HaywireLookTimer", mods);
		Cooldown = haywire.Cooldown;
		MaxCount = haywire.MaxCount;
		Multiwire = haywire.Multiwire;
		if (haywire.Circle != null)
		{
			Circle = new HaywirePhaseSettingsData(haywire.Circle, "HaywireCircleActivation", "HaywireCircleActivationModifier", mods);
		}
		if (haywire.Pause != null)
		{
			Pause = new HaywirePhaseSettingsData(haywire.Pause, "HaywirePauseActivation", "HaywirePauseActivationModifier", mods);
		}
		if (haywire.Charge != null)
		{
			Charge = new HaywirePhaseSettingsData(haywire.Charge, "HaywireChargeActivation", "HaywireChargeActivationModifier", mods);
		}
	}

	public override string ToString()
	{
		return $"{{\"LookTime\":{LookTime},\"Circle\":{Circle},\"Pause\":{Pause},\"Charge\":{Charge}}}";
	}
}
