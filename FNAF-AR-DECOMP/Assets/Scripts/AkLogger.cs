using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkLogger
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static AkLogger ms_Instance;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private AkLogger.ErrorLoggerInteropDelegate errorLoggerDelegate;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AkLogger Instance { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private AkLogger()
    {
        var val_1;
        this.errorLoggerDelegate = 1863;
        val_1 = null;
        val_1 = null;
        if(AkLogger.ms_Instance != null)
        {
                return;
        }
        
        AkLogger.ms_Instance = this;
        AkSoundEngine.SetErrorLogger(logger:  this.errorLoggerDelegate);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AkLogger get_Instance()
    {
        null = null;
        return (AkLogger)AkLogger.ms_Instance;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected override void Finalize()
    {
        var val_1 = null;
        if(AkLogger.ms_Instance == this)
        {
                AkLogger.ms_Instance = 0;
            this.errorLoggerDelegate = 0;
            AkSoundEngine.SetErrorLogger();
        }
        
        this.Finalize();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Init()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void WwiseInternalLogError(string message)
    {
        UnityEngine.Debug.LogError(message:  "Wwise: "("Wwise: ") + message);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void Message(string message)
    {
        UnityEngine.Debug.Log(message:  "WwiseUnity: "("WwiseUnity: ") + message);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void Warning(string message)
    {
        UnityEngine.Debug.LogWarning(message:  "WwiseUnity: "("WwiseUnity: ") + message);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void Error(string message)
    {
        UnityEngine.Debug.LogError(message:  "WwiseUnity: "("WwiseUnity: ") + message);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static AkLogger()
    {
        AkLogger.ms_Instance = new AkLogger();
    }

}
