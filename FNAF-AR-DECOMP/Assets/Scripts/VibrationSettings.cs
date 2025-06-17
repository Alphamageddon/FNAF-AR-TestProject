using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public static class VibrationSettings
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private const string VIBRATION_ENABLE = "VIBRATION_ENABLE";
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static VibrationSettings()
    {
        if((UnityEngine.PlayerPrefs.HasKey(key:  "VIBRATION_ENABLE")) != false)
        {
                return;
        }
        
        VibrationSettings.VibrationEnable(value:  true);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static bool VibrationIsEnabled()
    {
        return (bool)((UnityEngine.PlayerPrefs.GetInt(key:  "VIBRATION_ENABLE", defaultValue:  1)) == 1) ? 1 : 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void VibrationEnable(bool value)
    {
        UnityEngine.PlayerPrefs.SetInt(key:  "VIBRATION_ENABLE", value:  value);
        UnityEngine.PlayerPrefs.Save();
    }

}
