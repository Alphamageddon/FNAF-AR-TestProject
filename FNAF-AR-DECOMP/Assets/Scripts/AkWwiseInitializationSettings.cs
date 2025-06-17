using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkWwiseInitializationSettings : AkCommonPlatformSettings
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Collections.Generic.List<string> PlatformSettingsNameList;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Collections.Generic.List<AkWwiseInitializationSettings.PlatformSettings> PlatformSettingsList;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Collections.Generic.List<string> InvalidReferencePlatforms;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkCommonUserSettings UserSettings;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkCommonAdvancedSettings AdvancedSettings;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkCommonCommSettings CommsSettings;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly string[] AllGlobalValues;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static AkWwiseInitializationSettings m_Instance;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static AkBasePlatformSettings m_ActivePlatformSettings;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool IsValid { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int Count { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AkWwiseInitializationSettings Instance { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AkBasePlatformSettings ActivePlatformSettings { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool get_IsValid()
    {
        return (bool)(this.PlatformSettingsNameList.Count == this.PlatformSettingsList.Count) ? 1 : 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int get_Count()
    {
        if(this.PlatformSettingsList != null)
        {
                return this.PlatformSettingsList.Count;
        }
        
        return this.PlatformSettingsList.Count;
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
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AkWwiseInitializationSettings get_Instance()
    {
        var val_3;
        AkWwiseInitializationSettings val_4;
        var val_5;
        var val_6;
        val_3 = null;
        val_3 = null;
        val_4 = AkWwiseInitializationSettings.m_Instance;
        if(val_4 == 0)
        {
                val_5 = null;
            val_4 = UnityEngine.ScriptableObject.CreateInstance<AkWwiseInitializationSettings>();
            val_5 = null;
            AkWwiseInitializationSettings.m_Instance = val_4;
            UnityEngine.Debug.LogWarning(message:  "WwiseUnity: No platform specific settings were created. Default initialization settings will be used.");
        }
        
        val_6 = null;
        val_6 = null;
        return (AkWwiseInitializationSettings)AkWwiseInitializationSettings.m_Instance;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static AkBasePlatformSettings GetPlatformSettings(string platformName)
    {
        var val_9;
        var val_10;
        val_9 = AkWwiseInitializationSettings.Instance;
        if(val_9.IsValid == false)
        {
                return (AkBasePlatformSettings)val_9;
        }
        
        val_10 = 0;
        goto label_5;
        label_14:
        PlatformSettings val_3 = val_1.PlatformSettingsList.Item[0];
        if((UnityEngine.Object.op_Implicit(exists:  val_3)) != false)
        {
                if((System.String.Equals(a:  platformName, b:  val_1.PlatformSettingsNameList.Item[0], comparisonType:  5)) == true)
        {
            goto label_12;
        }
        
        }
        
        val_10 = 1;
        label_5:
        if(val_10 < val_9.Count)
        {
            goto label_14;
        }
        
        UnityEngine.Debug.LogWarning(message:  "WwiseUnity: Platform specific settings cannot be found for <"("WwiseUnity: Platform specific settings cannot be found for <") + platformName + ">. Using global settings."(">. Using global settings."));
        return (AkBasePlatformSettings)val_9;
        label_12:
        val_9 = val_3;
        return (AkBasePlatformSettings)val_9;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AkBasePlatformSettings get_ActivePlatformSettings()
    {
        var val_4;
        AkBasePlatformSettings val_5;
        var val_6;
        val_4 = null;
        val_4 = null;
        val_5 = AkWwiseInitializationSettings.m_ActivePlatformSettings;
        if(val_5 == 0)
        {
                val_5 = AkBasePathGetter.GetPlatformName();
            val_6 = null;
            AkWwiseInitializationSettings.m_ActivePlatformSettings = AkWwiseInitializationSettings.GetPlatformSettings(platformName:  val_5);
        }
        else
        {
                val_6 = null;
        }
        
        val_6 = null;
        return (AkBasePlatformSettings)AkWwiseInitializationSettings.m_ActivePlatformSettings;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void OnEnable()
    {
        var val_3;
        var val_4;
        var val_5;
        var val_6;
        val_3 = null;
        val_3 = null;
        val_4 = null;
        if(AkWwiseInitializationSettings.m_Instance == 0)
        {
                val_5 = null;
            AkWwiseInitializationSettings.m_Instance = this;
            return;
        }
        
        val_6 = null;
        if(this == this)
        {
                return;
        }
        
        UnityEngine.Debug.LogWarning(message:  "WwiseUnity: There are multiple AkWwiseInitializationSettings objects instantiated; only one will be used.");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static bool InitializeSoundEngine()
    {
        AkInitializationSettings val_18;
        var val_19;
        object val_20;
        var val_21;
        var val_22;
        var val_23;
        val_18 = AkWwiseInitializationSettings.ActivePlatformSettings;
        if((AkSoundEngine.Init(settings:  val_18)) != 1)
        {
            goto label_6;
        }
        
        val_19 = 0;
        if((AkSoundEngine.InitSpatialAudio(settings:  AkWwiseInitializationSettings.ActivePlatformSettings)) != 1)
        {
                val_19 = 0;
            UnityEngine.Debug.LogWarning(message:  "WwiseUnity: Failed to initialize spatial audio.");
        }
        
        val_18 = AkWwiseInitializationSettings.ActivePlatformSettings;
        AKRESULT val_6 = AkSoundEngine.InitCommunication(settings:  val_18);
        if((System.String.IsNullOrEmpty(value:  AkBasePathGetter.GetSoundbankBasePath())) == false)
        {
            goto label_22;
        }
        
        val_20 = "WwiseUnity: Couldn\'t find soundbanks base path. Terminating sound engine.";
        goto label_25;
        label_6:
        val_20 = "WwiseUnity: Failed to initialize the sound engine. Abort.";
        label_25:
        UnityEngine.Debug.LogError(message:  val_20);
        AkSoundEngine.Term();
        val_21 = 0;
        return (bool)val_21;
        label_22:
        string val_9 = AkSoundEngineController.GetDecodedBankFullPath();
        val_22 = 0;
        if((System.String.IsNullOrEmpty(value:  val_9)) != true)
        {
                val_22 = 0;
            AKRESULT val_11 = AkSoundEngine.SetDecodedBankPath(in_DecodedPath:  val_9);
        }
        
        AKRESULT val_13 = AkSoundEngine.SetCurrentLanguage(in_pszAudioSrcPath:  AkWwiseInitializationSettings.ActivePlatformSettings);
        val_23 = 0;
        if((System.String.IsNullOrEmpty(value:  val_9)) != true)
        {
                val_23 = 0;
            AKRESULT val_15 = AkSoundEngine.AddBasePath(in_pszBasePath:  val_9);
        }
        
        val_18 = AkWwiseInitializationSettings.ActivePlatformSettings;
        AKRESULT val_17 = AkCallbackManager.Init(settings:  val_18);
        UnityEngine.Debug.Log(message:  "WwiseUnity: Sound engine initialized successfully.");
        val_21 = 1;
        return (bool)val_21;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static bool ResetSoundEngine(bool isPlaying)
    {
        if(isPlaying != false)
        {
                AKRESULT val_1 = AkSoundEngine.ClearBanks();
            AkBankManager.LoadInitBank(doReset:  true);
        }
        
        AKRESULT val_3 = AkCallbackManager.Init(settings:  AkWwiseInitializationSettings.ActivePlatformSettings);
        return true;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void TerminateSoundEngine()
    {
        var val_6;
        if(AkSoundEngine.IsInitialized() == false)
        {
                return;
        }
        
        AkSoundEngine.StopAll();
        AKRESULT val_2 = AkSoundEngine.ClearBanks();
        AKRESULT val_3 = AkSoundEngine.RenderAudio();
        val_6 = 0;
        do
        {
            if(AkCallbackManager.PostCallbacks() == 0)
        {
                AkWwiseInitializationSettings.SleepForMilliseconds(milliseconds:  10);
            val_6 = val_6 + 1;
        }
        
            AkWwiseInitializationSettings.SleepForMilliseconds(milliseconds:  1);
        }
        while(val_6 < 5);
        
        AkSoundEngine.Term();
        int val_5 = AkCallbackManager.PostCallbacks();
        AkCallbackManager.Term();
        AkBankManager.Reset();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static void SleepForMilliseconds(double milliseconds)
    {
        var val_10;
        System.Threading.ManualResetEvent val_1 = null;
        val_10 = val_1;
        val_1 = new System.Threading.ManualResetEvent(initialState:  false);
        System.TimeSpan val_2 = System.TimeSpan.FromMilliseconds(value:  milliseconds);
        var val_10 = 0;
        val_10 = val_10 + 1;
        val_1.Dispose();
        if(0 == 0)
        {
                return;
        }
        
        if(32 == 32)
        {
                return;
        }
        
        val_10 = ???;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkWwiseInitializationSettings()
    {
        this.PlatformSettingsNameList = new System.Collections.Generic.List<System.String>();
        this.PlatformSettingsList = new System.Collections.Generic.List<PlatformSettings>();
        this.InvalidReferencePlatforms = new System.Collections.Generic.List<System.String>();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static AkWwiseInitializationSettings()
    {
        string[] val_1 = new string[45];
        val_1[0] = "UserSettings.m_BasePath";
        val_1[1] = "UserSettings.m_StartupLanguage";
        val_1[2] = "UserSettings.m_PreparePoolSize";
        val_1[3] = "UserSettings.m_CallbackManagerBufferSize";
        val_1[4] = "UserSettings.m_EngineLogging";
        val_1[5] = "UserSettings.m_MaximumNumberOfMemoryPools";
        val_1[6] = "UserSettings.m_MaximumNumberOfPositioningPaths";
        val_1[7] = "UserSettings.m_DefaultPoolSize";
        val_1[8] = "UserSettings.m_MemoryCutoffThreshold";
        val_1[9] = "UserSettings.m_CommandQueueSize";
        val_1[10] = "UserSettings.m_SamplesPerFrame";
        val_1[11] = "UserSettings.m_MainOutputSettings.m_AudioDeviceShareset";
        val_1[12] = "UserSettings.m_MainOutputSettings.m_DeviceID";
        val_1[13] = "UserSettings.m_MainOutputSettings.m_PanningRule";
        val_1[14] = "UserSettings.m_MainOutputSettings.m_ChannelConfig.m_ChannelConfigType";
        val_1[15] = "UserSettings.m_MainOutputSettings.m_ChannelConfig.m_ChannelMask";
        val_1[16] = "UserSettings.m_MainOutputSettings.m_ChannelConfig.m_NumberOfChannels";
        val_1[17] = "UserSettings.m_StreamingLookAheadRatio";
        val_1[18] = "UserSettings.m_StreamManagerPoolSize";
        val_1[19] = "UserSettings.m_SampleRate";
        val_1[20] = "UserSettings.m_LowerEnginePoolSize";
        val_1[21] = "UserSettings.m_LowerEngineMemoryCutoffThreshold";
        val_1[22] = "UserSettings.m_NumberOfRefillsInVoice";
        val_1[23] = "UserSettings.m_SpatialAudioSettings.m_PoolSize";
        val_1[24] = "UserSettings.m_SpatialAudioSettings.m_MaxSoundPropagationDepth";
        val_1[25] = "UserSettings.m_SpatialAudioSettings.m_DiffractionFlags";
        val_1[26] = "UserSettings.m_SpatialAudioSettings.m_MovementThreshold";
        val_1[27] = "CommsSettings.m_PoolSize";
        val_1[28] = "CommsSettings.m_DiscoveryBroadcastPort";
        val_1[29] = "CommsSettings.m_CommandPort";
        val_1[30] = "CommsSettings.m_NotificationPort";
        val_1[31] = "CommsSettings.m_InitializeSystemComms";
        val_1[32] = "CommsSettings.m_NetworkName";
        val_1[33] = "AdvancedSettings.m_IOMemorySize";
        val_1[34] = "AdvancedSettings.m_TargetAutoStreamBufferLengthMs";
        val_1[35] = "AdvancedSettings.m_UseStreamCache";
        val_1[36] = "AdvancedSettings.m_MaximumPinnedBytesInCache";
        val_1[37] = "AdvancedSettings.m_PrepareEventMemoryPoolID";
        val_1[38] = "AdvancedSettings.m_EnableGameSyncPreparation";
        val_1[39] = "AdvancedSettings.m_ContinuousPlaybackLookAhead";
        val_1[40] = "AdvancedSettings.m_MonitorPoolSize";
        val_1[41] = "AdvancedSettings.m_MonitorQueuePoolSize";
        val_1[42] = "AdvancedSettings.m_MaximumHardwareTimeoutMs";
        val_1[43] = "AdvancedSettings.m_SpatialAudioSettings.m_DiffractionShadowAttenuationFactor";
        val_1[44] = "AdvancedSettings.m_SpatialAudioSettings.m_DiffractionShadowDegrees";
        AkWwiseInitializationSettings.AllGlobalValues = val_1;
        AkWwiseInitializationSettings.m_Instance = 0;
        AkWwiseInitializationSettings.m_ActivePlatformSettings = 0;
    }

}
