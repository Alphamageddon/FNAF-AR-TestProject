using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public abstract class AkCommonPlatformSettings : AkBasePlatformSettings
{
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override AkInitializationSettings AkInitializationSettings { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override AkSpatialAudioInitSettings AkSpatialAudioInitSettings { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override AkCallbackManager.InitializationSettings CallbackManagerInitializationSettings { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override string InitialLanguage { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override string SoundbankPath { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override AkCommunicationSettings AkCommunicationSettings { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected abstract AkCommonUserSettings GetUserSettings(); // 0
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected abstract AkCommonAdvancedSettings GetAdvancedSettings(); // 0
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected abstract AkCommonCommSettings GetCommsSettings(); // 0
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override AkInitializationSettings get_AkInitializationSettings()
    {
        AkInitializationSettings val_1 = this.AkInitializationSettings;
        this.CopyTo(settings:  val_1.memSettings);
        AkDeviceSettings val_3 = val_1.deviceSettings;
        if(val_1 != null)
        {
                this.CopyTo(settings:  val_1.streamMgrSettings);
        }
        else
        {
                this.CopyTo(settings:  0.streamMgrSettings);
        }
        
        AkInitSettings val_6 = val_1.initSettings;
        if(val_1 != null)
        {
                AkPlatformInitSettings val_7 = val_1.platformSettings;
        }
        else
        {
                AkPlatformInitSettings val_8 = 0.platformSettings;
        }
        
        this.CopyTo(settings:  val_1.musicSettings);
        AkUnityPlatformSpecificSettings val_10 = val_1.unityPlatformSpecificSettings;
        val_1.preparePoolSize = 1908016240;
        AkDeviceSettings val_11 = val_1.deviceSettings;
        if(val_1 != null)
        {
                AkInitSettings val_12 = val_1.initSettings;
        }
        else
        {
                AkInitSettings val_13 = 0.initSettings;
        }
        
        AkPlatformInitSettings val_14 = val_1.platformSettings;
        AkUnityPlatformSpecificSettings val_15 = val_1.unityPlatformSpecificSettings;
        return val_1;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override AkSpatialAudioInitSettings get_AkSpatialAudioInitSettings()
    {
        if(this != null)
        {
                return (AkSpatialAudioInitSettings)this.AkSpatialAudioInitSettings;
        }
        
        return (AkSpatialAudioInitSettings)this.AkSpatialAudioInitSettings;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override AkCallbackManager.InitializationSettings get_CallbackManagerInitializationSettings()
    {
        AkCallbackManager.InitializationSettings val_1 = new AkCallbackManager.InitializationSettings();
        if(val_1 != null)
        {
                .BufferSize = ;
        }
        else
        {
                mem[16] = ???;
        }
        
        .IsLoggingEnabled = this;
        return (InitializationSettings)val_1;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override string get_InitialLanguage()
    {
        if(this != null)
        {
                return (string)this;
        }
        
        return (string)this;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override string get_SoundbankPath()
    {
        if(this != null)
        {
                return (string)this;
        }
        
        return (string)this;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override AkCommunicationSettings get_AkCommunicationSettings()
    {
        if(this != null)
        {
                return (AkCommunicationSettings)this.AkCommunicationSettings;
        }
        
        return (AkCommunicationSettings)this.AkCommunicationSettings;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected AkCommonPlatformSettings()
    {
        val_1 = new UnityEngine.ScriptableObject();
    }

}
