using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
[Serializable]
public class AkCommonUserSettings : AkSettingsValidationHandler
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string m_BasePath;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string m_StartupLanguage;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint m_PreparePoolSize;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int m_CallbackManagerBufferSize;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool m_EngineLogging;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint m_MaximumNumberOfMemoryPools;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint m_MaximumNumberOfPositioningPaths;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint m_DefaultPoolSize;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float m_MemoryCutoffThreshold;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint m_CommandQueueSize;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint m_SamplesPerFrame;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkCommonOutputSettings m_MainOutputSettings;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float m_StreamingLookAheadRatio;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint m_StreamManagerPoolSize;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint m_SampleRate;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint m_LowerEnginePoolSize;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float m_LowerEngineMemoryCutoffThreshold;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ushort m_NumberOfRefillsInVoice;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkCommonUserSettings.SpatialAudioSettings m_SpatialAudioSettings;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void CopyTo(AkMemSettings settings)
    {
        settings.uMaxNumPools = this.m_MaximumNumberOfMemoryPools;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected static string GetPluginPath()
    {
        return 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public virtual void CopyTo(AkInitSettings settings)
    {
        AkCommonOutputSettings val_2;
        if(settings != null)
        {
                settings.uMaxNumPaths = this.m_MaximumNumberOfPositioningPaths;
            settings.uDefaultPoolSize = this.m_DefaultPoolSize;
            settings.fDefaultPoolRatioThreshold = this.m_MemoryCutoffThreshold;
            settings.uCommandQueueSize = this.m_CommandQueueSize;
            settings.uNumSamplesPerFrame = this.m_SamplesPerFrame;
            val_2 = this.m_MainOutputSettings;
        }
        else
        {
                0.uMaxNumPaths = this.m_MaximumNumberOfPositioningPaths;
            0.uDefaultPoolSize = this.m_DefaultPoolSize;
            0.fDefaultPoolRatioThreshold = this.m_MemoryCutoffThreshold;
            0.uCommandQueueSize = this.m_CommandQueueSize;
            0.uNumSamplesPerFrame = this.m_SamplesPerFrame;
            val_2 = this.m_MainOutputSettings;
        }
        
        val_2.CopyTo(settings:  settings.settingsMainOutput);
        settings.szPluginDLLPath = 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void CopyTo(AkMusicSettings settings)
    {
        settings.fStreamingLookAheadRatio = this.m_StreamingLookAheadRatio;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void CopyTo(AkStreamMgrSettings settings)
    {
        settings.uMemorySize = this.m_StreamManagerPoolSize;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public virtual void CopyTo(AkDeviceSettings settings)
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public virtual void CopyTo(AkPlatformInitSettings settings)
    {
        ushort val_1;
        if(settings != null)
        {
                settings.uSampleRate = this.m_SampleRate;
            settings.uLEngineDefaultPoolSize = this.m_LowerEnginePoolSize;
            settings.fLEngineDefaultPoolRatioThreshold = this.m_LowerEngineMemoryCutoffThreshold;
            val_1 = this.m_NumberOfRefillsInVoice;
        }
        else
        {
                0.uSampleRate = this.m_SampleRate;
            0.uLEngineDefaultPoolSize = this.m_LowerEnginePoolSize;
            0.fLEngineDefaultPoolRatioThreshold = this.m_LowerEngineMemoryCutoffThreshold;
            val_1 = this.m_NumberOfRefillsInVoice;
        }
        
        settings.uNumRefillsInVoice = val_1;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public virtual void CopyTo(AkSpatialAudioInitSettings settings)
    {
        settings.uPoolSize = this.m_SpatialAudioSettings.m_PoolSize;
        settings.uMaxSoundPropagationDepth = this.m_SpatialAudioSettings.m_MaxSoundPropagationDepth;
        settings.uDiffractionFlags = this.m_SpatialAudioSettings.m_DiffractionFlags;
        settings.fMovementThreshold = this.m_SpatialAudioSettings.m_MovementThreshold;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public virtual void CopyTo(AkUnityPlatformSpecificSettings settings)
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override void Validate()
    {
        uint val_1 = this.m_PreparePoolSize;
        val_1 = val_1 - 1;
        if(val_1 > 8094)
        {
                return;
        }
        
        this.m_PreparePoolSize = 8096;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkCommonUserSettings()
    {
        var val_1;
        var val_2;
        val_1 = null;
        val_1 = null;
        this.m_BasePath = AkBasePathGetter.DefaultBasePath;
        this.m_StartupLanguage = "English(US)";
        val_2 = null;
        val_2 = null;
        this.m_CallbackManagerBufferSize = AkCallbackManager.InitializationSettings.DefaultBufferSize;
        this.m_MaximumNumberOfMemoryPools = 255;
        this.m_MaximumNumberOfPositioningPaths = 255;
        this.m_DefaultPoolSize = 1065353216;
        this.m_MemoryCutoffThreshold = 1f;
        this.m_CommandQueueSize = 262144;
        this.m_SamplesPerFrame = 1024;
        this.m_StreamingLookAheadRatio = 1.007813f;
        this.m_StreamManagerPoolSize = 65536;
        this.m_SampleRate = 48000;
        this.m_LowerEnginePoolSize = 16777216;
        this.m_LowerEngineMemoryCutoffThreshold = 1f;
        this.m_EngineLogging = AkCallbackManager.InitializationSettings.DefaultIsLoggingEnabled;
        this.m_NumberOfRefillsInVoice = 4;
    }

}
