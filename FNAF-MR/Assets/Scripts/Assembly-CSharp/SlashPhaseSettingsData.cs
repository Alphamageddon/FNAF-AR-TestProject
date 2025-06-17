public class SlashPhaseSettingsData
{
	public readonly RandomChanceData ActivationChance;

	public readonly RangeData TriggerPercent;

	public readonly bool TeleportToCamera;

	public readonly float AllowedHalfAngle;

	public readonly bool AddToMax;

	public readonly bool UseMax;

	public SlashPhaseSettingsData(ATTACK_DATA.Circle rawSettings)
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
	}

	public SlashPhaseSettingsData(ATTACK_DATA.Pause rawSettings)
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
	}
}
