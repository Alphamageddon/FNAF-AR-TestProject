using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkBasePlatformSettings : ScriptableObject
{
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public virtual AkInitializationSettings AkInitializationSettings { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public virtual AkSpatialAudioInitSettings AkSpatialAudioInitSettings { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public virtual AkCallbackManager.InitializationSettings CallbackManagerInitializationSettings { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public virtual string InitialLanguage { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public virtual string SoundbankPath { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public virtual AkCommunicationSettings AkCommunicationSettings { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public virtual AkInitializationSettings get_AkInitializationSettings()
    {
        return (AkInitializationSettings)new AkInitializationSettings();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public virtual AkSpatialAudioInitSettings get_AkSpatialAudioInitSettings()
    {
        return (AkSpatialAudioInitSettings)new AkSpatialAudioInitSettings();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public virtual AkCallbackManager.InitializationSettings get_CallbackManagerInitializationSettings()
    {
        return (InitializationSettings)new AkCallbackManager.InitializationSettings();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public virtual string get_InitialLanguage()
    {
        return "English(US)";
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public virtual string get_SoundbankPath()
    {
        null = null;
        return (string)AkBasePathGetter.DefaultBasePath;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public virtual AkCommunicationSettings get_AkCommunicationSettings()
    {
        return (AkCommunicationSettings)new AkCommunicationSettings();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkBasePlatformSettings()
    {
    
    }

}
