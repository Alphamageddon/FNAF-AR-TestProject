using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
[Serializable]
public class AkWindowsSettings.PlatformAdvancedSettings : AkCommonAdvancedSettings
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkWindowsSettings.PlatformAdvancedSettings.AudioAPI m_AudioAPI;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool m_GlobalFocus;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override void CopyTo(AkPlatformInitSettings settings)
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkWindowsSettings.PlatformAdvancedSettings()
    {
        this.m_AudioAPI = 0;
        this.m_GlobalFocus = true;
    }

}
