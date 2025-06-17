using UnityEngine;

public static class VibrationSettings
{
	private const string VIBRATION_ENABLE = "VIBRATION_ENABLE";

	static VibrationSettings()
	{
		if (!PlayerPrefs.HasKey("VIBRATION_ENABLE"))
		{
			VibrationEnable(value: true);
		}
	}

	public static bool VibrationIsEnabled()
	{
		return PlayerPrefs.GetInt("VIBRATION_ENABLE", 1) == 1;
	}

	public static void VibrationEnable(bool value)
	{
		PlayerPrefs.SetInt("VIBRATION_ENABLE", value ? 1 : 0);
		PlayerPrefs.Save();
	}
}
