using System.Collections.Generic;

public class HaywirePhaseSettingsData
{
	public readonly RandomChanceData ActivationChance;

	public readonly RangeData TriggerPercent;

	public readonly bool TeleportToCamera;

	public readonly float AllowedHalfAngle;

	public readonly bool AddToMax;

	public readonly bool UseMax;

	public readonly RandomChanceData CircleChance;

	public readonly RandomChanceData PauseChance;

	public readonly bool ForceCircleAfterPause;

	public HaywirePhaseSettingsData(ATTACK_DATA.Circle rawSettings)
	{
		if (rawSettings.Activation != null)
		{
			ActivationChance = new RandomChanceData(rawSettings.Activation.Chance, rawSettings.Activation.Modifier);
		}
		if (rawSettings.TriggerPercent != null)
		{
			TriggerPercent = new RangeData(rawSettings.TriggerPercent.Min, rawSettings.TriggerPercent.Max);
		}
		TeleportToCamera = rawSettings.TeleportToCamera;
		AllowedHalfAngle = rawSettings.AllowedHalfAngle;
		AddToMax = rawSettings.AddToMax;
		UseMax = rawSettings.UseMax;
		if (rawSettings.GoToCircle != null)
		{
			CircleChance = new RandomChanceData(rawSettings.GoToCircle.Chance, 0f);
		}
		if (rawSettings.GoToPause != null)
		{
			PauseChance = new RandomChanceData(rawSettings.GoToPause.Chance, 0f);
		}
		ForceCircleAfterPause = rawSettings.ForceCircleAfterPause;
	}

	public HaywirePhaseSettingsData(ATTACK_DATA.Pause rawSettings)
	{
		if (rawSettings.Activation != null)
		{
			ActivationChance = new RandomChanceData(rawSettings.Activation.Chance, rawSettings.Activation.Modifier);
		}
		if (rawSettings.TriggerPercent != null)
		{
			TriggerPercent = new RangeData(rawSettings.TriggerPercent.Min, rawSettings.TriggerPercent.Max);
		}
		TeleportToCamera = rawSettings.TeleportToCamera;
		AllowedHalfAngle = rawSettings.AllowedHalfAngle;
		AddToMax = rawSettings.AddToMax;
		UseMax = rawSettings.UseMax;
		if (rawSettings.GoToCircle != null)
		{
			CircleChance = new RandomChanceData(rawSettings.GoToCircle.Chance, 0f);
		}
		if (rawSettings.GoToPause != null)
		{
			PauseChance = new RandomChanceData(rawSettings.GoToPause.Chance, 0f);
		}
		ForceCircleAfterPause = rawSettings.ForceCircleAfterPause;
	}

	public HaywirePhaseSettingsData(ATTACK_DATA.Charge rawSettings)
	{
		if (rawSettings.Activation != null)
		{
			ActivationChance = new RandomChanceData(rawSettings.Activation.Chance, rawSettings.Activation.Modifier);
		}
		if (rawSettings.TriggerPercent != null)
		{
			TriggerPercent = new RangeData(rawSettings.TriggerPercent.Min, rawSettings.TriggerPercent.Max);
		}
		TeleportToCamera = rawSettings.TeleportToCamera;
		AllowedHalfAngle = rawSettings.AllowedHalfAngle;
		AddToMax = rawSettings.AddToMax;
		UseMax = rawSettings.UseMax;
		if (rawSettings.GoToCircle != null)
		{
			CircleChance = new RandomChanceData(rawSettings.GoToCircle.Chance, 0f);
		}
		if (rawSettings.GoToPause != null)
		{
			PauseChance = new RandomChanceData(rawSettings.GoToPause.Chance, 0f);
		}
		ForceCircleAfterPause = rawSettings.ForceCircleAfterPause;
	}

	public HaywirePhaseSettingsData(HaywirePhaseSettingsData phaseSettings, string chanceKey, string modifierKey, Dictionary<string, float> mods)
	{
		if (phaseSettings.ActivationChance != null)
		{
			ActivationChance = new RandomChanceData(phaseSettings.ActivationChance, chanceKey, modifierKey, mods);
		}
		TriggerPercent = phaseSettings.TriggerPercent;
		TeleportToCamera = phaseSettings.TeleportToCamera;
		AllowedHalfAngle = phaseSettings.AllowedHalfAngle;
		AddToMax = phaseSettings.AddToMax;
		UseMax = phaseSettings.UseMax;
		CircleChance = phaseSettings.CircleChance;
		PauseChance = phaseSettings.PauseChance;
		ForceCircleAfterPause = phaseSettings.ForceCircleAfterPause;
	}

	public override string ToString()
	{
		return $"{{\"ActivationChance\":{ActivationChance}}}";
	}
}
