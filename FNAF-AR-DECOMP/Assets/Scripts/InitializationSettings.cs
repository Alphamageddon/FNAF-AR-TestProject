using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkCallbackManager.InitializationSettings
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static int DefaultBufferSize;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static bool DefaultIsLoggingEnabled;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int BufferSize;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool IsLoggingEnabled;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkCallbackManager.InitializationSettings()
    {
        null = null;
        this.BufferSize = AkCallbackManager.InitializationSettings.DefaultBufferSize;
        this.IsLoggingEnabled = AkCallbackManager.InitializationSettings.DefaultIsLoggingEnabled;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static AkCallbackManager.InitializationSettings()
    {
        AkCallbackManager.InitializationSettings.DefaultBufferSize = 4096;
        AkCallbackManager.InitializationSettings.DefaultIsLoggingEnabled = true;
    }

}
