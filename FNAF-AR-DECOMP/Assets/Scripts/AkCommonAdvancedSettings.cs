using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
[Serializable]
public class AkCommonAdvancedSettings : AkSettingsValidationHandler
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint m_IOMemorySize;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float m_TargetAutoStreamBufferLengthMs;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool m_UseStreamCache;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint m_MaximumPinnedBytesInCache;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int m_PrepareEventMemoryPoolID;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool m_EnableGameSyncPreparation;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint m_ContinuousPlaybackLookAhead;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint m_MonitorPoolSize;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint m_MonitorQueuePoolSize;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint m_MaximumHardwareTimeoutMs;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkCommonAdvancedSettings.SpatialAudioSettings m_SpatialAudioSettings;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public virtual void CopyTo(AkDeviceSettings settings)
    {
        float val_3;
        uint val_4;
        if(settings != null)
        {
                settings.uIOMemorySize = this.m_IOMemorySize;
            val_3 = this.m_TargetAutoStreamBufferLengthMs;
        }
        else
        {
                0.uIOMemorySize = this.m_IOMemorySize;
            val_3 = this.m_TargetAutoStreamBufferLengthMs;
        }
        
        settings.fTargetAutoStmBufferLength = val_3;
        if(settings != null)
        {
                settings.bUseStreamCache = (this.m_UseStreamCache == true) ? 1 : 0;
            val_4 = this.m_MaximumPinnedBytesInCache;
        }
        else
        {
                0.bUseStreamCache = (this.m_UseStreamCache == true) ? 1 : 0;
            val_4 = this.m_MaximumPinnedBytesInCache;
        }
        
        settings.uMaxCachePinnedBytes = val_4;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public virtual void CopyTo(AkInitSettings settings)
    {
        uint val_3;
        settings.uPrepareEventMemoryPoolID = this.m_PrepareEventMemoryPoolID;
        if(settings != null)
        {
                settings.bEnableGameSyncPreparation = (this.m_EnableGameSyncPreparation == true) ? 1 : 0;
            settings.uContinuousPlaybackLookAhead = this.m_ContinuousPlaybackLookAhead;
            settings.uMonitorPoolSize = this.m_MonitorPoolSize;
            settings.uMonitorQueuePoolSize = this.m_MonitorQueuePoolSize;
            val_3 = this.m_MaximumHardwareTimeoutMs;
        }
        else
        {
                0.bEnableGameSyncPreparation = (this.m_EnableGameSyncPreparation == true) ? 1 : 0;
            0.uContinuousPlaybackLookAhead = this.m_ContinuousPlaybackLookAhead;
            0.uMonitorPoolSize = this.m_MonitorPoolSize;
            0.uMonitorQueuePoolSize = this.m_MonitorQueuePoolSize;
            val_3 = this.m_MaximumHardwareTimeoutMs;
        }
        
        settings.uMaxHardwareTimeoutMs = val_3;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public virtual void CopyTo(AkPlatformInitSettings settings)
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public virtual void CopyTo(AkSpatialAudioInitSettings settings)
    {
        settings.fDiffractionShadowAttenFactor = this.m_SpatialAudioSettings.m_DiffractionShadowAttenuationFactor;
        settings.fDiffractionShadowDegrees = this.m_SpatialAudioSettings.m_DiffractionShadowDegrees;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public virtual void CopyTo(AkUnityPlatformSpecificSettings settings)
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override void Validate()
    {
        if(this.m_SpatialAudioSettings.m_DiffractionShadowAttenuationFactor <= 0f)
        {
                UnityEngine.Debug.LogWarning(message:  "WwiseUnity: m_SpatialAudioSettings.m_DiffractionShadowAttenuationFactor must be greater than zero. Value was reset to the default (2.0)");
            this.m_SpatialAudioSettings.m_DiffractionShadowAttenuationFactor = 2f;
        }
        
        if(this.m_SpatialAudioSettings.m_DiffractionShadowDegrees > 0f)
        {
                return;
        }
        
        UnityEngine.Debug.LogWarning(message:  "WwiseUnity: m_SpatialAudioSettings.m_DiffractionShadowDegrees must be greater than zero. Value was reset to the default (30.0)");
        this = this.m_SpatialAudioSettings;
        this.m_SpatialAudioSettings.m_DiffractionShadowDegrees = 30f;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkCommonAdvancedSettings()
    {
        this.m_IOMemorySize = 2097152;
        this.m_TargetAutoStreamBufferLengthMs = 380f;
        this.m_MaximumPinnedBytesInCache = 0;
        this.m_PrepareEventMemoryPoolID = 0;
        this.m_ContinuousPlaybackLookAhead = ;
        this.m_MonitorPoolSize = ;
        this.m_MonitorQueuePoolSize = 4294967361536;
        this.m_MaximumHardwareTimeoutMs = 1000;
    }

}
