using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
[Serializable]
public class AkCommonOutputSettings.ChannelConfiguration
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkCommonOutputSettings.ChannelConfiguration.ChannelConfigType m_ChannelConfigType;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkCommonOutputSettings.ChannelConfiguration.ChannelMask m_ChannelMask;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint m_NumberOfChannels;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void CopyTo(AkChannelConfig config)
    {
        if(this.m_ChannelConfigType == 2)
        {
            goto label_0;
        }
        
        if(this.m_ChannelConfigType == 1)
        {
            goto label_1;
        }
        
        if(this.m_ChannelConfigType != 0)
        {
                return;
        }
        
        config.SetAnonymous(in_uNumChannels:  this.m_NumberOfChannels);
        return;
        label_0:
        config.SetAmbisonic(in_uNumChannels:  this.m_NumberOfChannels);
        return;
        label_1:
        config.SetStandard(in_uChannelMask:  this.m_ChannelMask);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkCommonOutputSettings.ChannelConfiguration()
    {
    
    }

}
