using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
[Serializable]
public class AkCommonCommSettings : AkSettingsValidationHandler
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint m_PoolSize;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static ushort DefaultDiscoveryBroadcastPort;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ushort m_DiscoveryBroadcastPort;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ushort m_CommandPort;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ushort m_NotificationPort;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool m_InitializeSystemComms;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string m_NetworkName;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public virtual void CopyTo(AkCommunicationSettings settings)
    {
        ushort val_4;
        string val_5;
        if(settings != null)
        {
                settings.uPoolSize = this.m_PoolSize;
            settings.uDiscoveryBroadcastPort = this.m_DiscoveryBroadcastPort;
            settings.uCommandPort = this.m_CommandPort;
            val_4 = this.m_NotificationPort;
        }
        else
        {
                0.uPoolSize = this.m_PoolSize;
            0.uDiscoveryBroadcastPort = this.m_DiscoveryBroadcastPort;
            0.uCommandPort = this.m_CommandPort;
            val_4 = this.m_NotificationPort;
        }
        
        settings.uNotificationPort = val_4;
        settings.bInitSystemLib = (this.m_InitializeSystemComms == true) ? 1 : 0;
        val_5 = this.m_NetworkName;
        if((System.String.IsNullOrEmpty(value:  val_5)) != false)
        {
                val_5 = UnityEngine.Application.productName;
        }
        
        settings.szAppNetworkName = val_5;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkCommonCommSettings()
    {
        var val_1;
        this.m_PoolSize = 262144;
        val_1 = null;
        val_1 = null;
        this.m_InitializeSystemComms = true;
        this.m_DiscoveryBroadcastPort = AkCommonCommSettings.DefaultDiscoveryBroadcastPort;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static AkCommonCommSettings()
    {
        AkCommonCommSettings.DefaultDiscoveryBroadcastPort = 24024;
    }

}
