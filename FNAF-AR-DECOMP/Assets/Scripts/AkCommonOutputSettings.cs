using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
[Serializable]
public class AkCommonOutputSettings
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string m_AudioDeviceShareset;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint m_DeviceID;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkCommonOutputSettings.PanningRule m_PanningRule;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkCommonOutputSettings.ChannelConfiguration m_ChannelConfig;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void CopyTo(AkOutputSettings settings)
    {
        uint val_4;
        ChannelConfiguration val_5;
        if((System.String.IsNullOrEmpty(value:  this.m_AudioDeviceShareset)) == false)
        {
            goto label_1;
        }
        
        val_4 = 0;
        if(settings == null)
        {
            goto label_2;
        }
        
        label_6:
        settings.audioDeviceShareset = 0;
        settings.idDevice = this.m_DeviceID;
        settings.ePanningRule = this.m_PanningRule;
        val_5 = this.m_ChannelConfig;
        goto label_3;
        label_1:
        val_4 = AkUtilities.ShortIDGenerator.Compute(in_name:  this.m_AudioDeviceShareset);
        if(settings != null)
        {
            goto label_6;
        }
        
        label_2:
        settings.audioDeviceShareset = val_4;
        0.idDevice = this.m_DeviceID;
        0.ePanningRule = this.m_PanningRule;
        val_5 = this.m_ChannelConfig;
        label_3:
        val_5.CopyTo(config:  settings.channelConfig);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkCommonOutputSettings()
    {
        this.m_AudioDeviceShareset = System.String.alignConst;
        this.m_ChannelConfig = new AkCommonOutputSettings.ChannelConfiguration();
    }

}
