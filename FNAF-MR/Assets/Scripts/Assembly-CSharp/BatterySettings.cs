using UnityEngine;

public class BatterySettings
{
	public readonly float BaseRecharge;

	public readonly float EssenceFlashlightDrain;

	public readonly int AllowedExtraBatteries;

	public BatterySettings(CONFIG_DATA.BatteryBehavior rawSettings)
	{
		BaseRecharge = (float)rawSettings.BatteryBaseRecharge;
		EssenceFlashlightDrain = (float)rawSettings.EssenceFlashlightDrain;
		AllowedExtraBatteries = Mathf.RoundToInt(rawSettings.AllowedExtraBatteries);
	}
}
