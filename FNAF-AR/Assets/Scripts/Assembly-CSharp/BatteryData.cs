using System.Collections.Generic;

public class BatteryData
{
	public const string BATTERY_DRAIN_RATE = "BatteryDrainRate";

	public readonly float BaseDrain;

	public readonly float FlashlightActivationDrain;

	public readonly float FlashlightActiveDrain;

	public readonly float ShockerActivationDrain;

	public readonly float ShockerActiveDrain;

	public readonly float HaywireShockDrain;

	public BatteryData(ATTACK_DATA.Battery rawSettings)
	{
		if (rawSettings.Base != null)
		{
			BaseDrain = rawSettings.Base.BaseDrain;
		}
		if (rawSettings.Flashlight != null)
		{
			FlashlightActivationDrain = rawSettings.Flashlight.ActivationDrain;
			FlashlightActiveDrain = rawSettings.Flashlight.ActiveDrain;
		}
		if (rawSettings.Shocker != null)
		{
			ShockerActivationDrain = rawSettings.Shocker.ActivationDrain;
			ShockerActiveDrain = rawSettings.Shocker.ActiveDrain;
		}
		if (rawSettings.Haywire != null)
		{
			HaywireShockDrain = rawSettings.Haywire.ShockDrain;
		}
	}

	public BatteryData(SCAVENGING_ATTACK_DATA.Battery rawSettings)
	{
		if (rawSettings.Flashlight != null)
		{
			FlashlightActivationDrain = rawSettings.Flashlight.ActivationDrain;
			FlashlightActiveDrain = rawSettings.Flashlight.ActiveDrain;
		}
		if (rawSettings.Shocker != null)
		{
			ShockerActivationDrain = rawSettings.Shocker.ActivationDrain;
		}
	}

	public BatteryData(BatteryData batteryData, Dictionary<string, float> mods)
	{
		float num = FloatHelper.ApplyModifier(1f, "BatteryDrainRate", mods);
		BaseDrain = num * batteryData.BaseDrain;
		FlashlightActivationDrain = num * batteryData.FlashlightActivationDrain;
		FlashlightActiveDrain = num * batteryData.FlashlightActiveDrain;
		ShockerActivationDrain = num * batteryData.ShockerActivationDrain;
		ShockerActiveDrain = num * batteryData.ShockerActiveDrain;
		HaywireShockDrain = num * batteryData.HaywireShockDrain;
	}

	public override string ToString()
	{
		return $"{{\"BaseDrain\":{BaseDrain},\"FlashlightActivationDrain\":{FlashlightActivationDrain},\"FlashlightActiveDrain\":{FlashlightActiveDrain},\"ShockerActivationDrain\":{ShockerActivationDrain},\"HaywireShockDrain\":{HaywireShockDrain}}}";
	}
}
