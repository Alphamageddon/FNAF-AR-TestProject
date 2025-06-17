using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkWwiseInitializationSettings.CommonPlatformSettings : AkWwiseInitializationSettings.PlatformSettings
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkCommonUserSettings UserSettings;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkCommonAdvancedSettings AdvancedSettings;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkCommonCommSettings CommsSettings;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected override AkCommonUserSettings GetUserSettings()
    {
        return (AkCommonUserSettings)this.UserSettings;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected override AkCommonAdvancedSettings GetAdvancedSettings()
    {
        return (AkCommonAdvancedSettings)this.AdvancedSettings;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected override AkCommonCommSettings GetCommsSettings()
    {
        return (AkCommonCommSettings)this.CommsSettings;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkWwiseInitializationSettings.CommonPlatformSettings()
    {
    
    }

}
