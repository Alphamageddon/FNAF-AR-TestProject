using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkAndroidSettings : AkWwiseInitializationSettings.PlatformSettings
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkCommonUserSettings UserSettings;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkAndroidSettings.PlatformAdvancedSettings AdvancedSettings;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkCommonCommSettings CommsSettings;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkAndroidSettings()
    {
        .m_PanningRule = 1;
        AkCommonOutputSettings.ChannelConfiguration val_3 = new AkCommonOutputSettings.ChannelConfiguration();
        if(val_3 != null)
        {
                .m_ChannelConfigType = 1;
        }
        else
        {
                mem[16] = 1;
        }
        
        .m_ChannelMask = 3;
        .m_ChannelConfig = val_3;
        .m_MainOutputSettings = new AkCommonOutputSettings();
        this.UserSettings = new AkCommonUserSettings();
        this.SetUseGlobalPropertyValue(propertyPath:  "UserSettings.m_MainOutputSettings.m_PanningRule", use:  false);
        this.SetUseGlobalPropertyValue(propertyPath:  "UserSettings.m_MainOutputSettings.m_ChannelConfig.m_ChannelConfigType", use:  false);
        this.SetUseGlobalPropertyValue(propertyPath:  "UserSettings.m_MainOutputSettings.m_ChannelConfig.m_ChannelMask", use:  false);
    }
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

}
