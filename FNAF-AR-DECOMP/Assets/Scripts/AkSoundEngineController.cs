using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkSoundEngineController
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static AkSoundEngineController ms_Instance;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AkSoundEngineController Instance { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AkSoundEngineController get_Instance()
    {
        AkSoundEngineController val_2;
        AkSoundEngineController val_3 = AkSoundEngineController.ms_Instance;
        if(val_3 != null)
        {
                return val_3;
        }
        
        AkSoundEngineController val_1 = null;
        val_2 = val_1;
        val_1 = new AkSoundEngineController();
        AkSoundEngineController.ms_Instance = val_2;
        val_3 = AkSoundEngineController.ms_Instance;
        return val_3;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private AkSoundEngineController()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected override void Finalize()
    {
        if(AkSoundEngineController.ms_Instance == this)
        {
                AkSoundEngineController.ms_Instance = 0;
        }
        
        this.Finalize();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static string GetDecodedBankFolder()
    {
        return "DecodedBanks";
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static string GetDecodedBankFullPath()
    {
        return System.IO.Path.Combine(path1:  UnityEngine.Application.persistentDataPath, path2:  "DecodedBanks");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void LateUpdate()
    {
        AkRoomPortalManager.UpdatePortals();
        int val_1 = AkCallbackManager.PostCallbacks();
        AkBankManager.DoUnloadBanks();
        AKRESULT val_2 = AkSoundEngine.RenderAudio();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Init(AkInitializer akInitializer)
    {
        UnityEngine.Object val_5;
        object val_6;
        val_5 = akInitializer;
        if(val_5 != 0)
        {
            goto label_3;
        }
        
        val_6 = "WwiseUnity: AkInitializer must not be null. Sound engine will not be initialized.";
        goto label_6;
        label_3:
        val_5 = AkSoundEngine.IsInitialized();
        AkLogger.Instance.Init();
        if(val_5 == false)
        {
            goto label_12;
        }
        
        val_6 = "WwiseUnity: Sound engine is already initialized.";
        label_6:
        UnityEngine.Debug.LogError(message:  val_6);
        return;
        label_12:
        bool val_4 = AkWwiseInitializationSettings.InitializeSoundEngine();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void OnDisable()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Terminate()
    {
        AkWwiseInitializationSettings.TerminateSoundEngine();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void OnApplicationPause(bool pauseStatus)
    {
        pauseStatus = (~pauseStatus) & 1;
        this.ActivateAudio(activate:  pauseStatus);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void OnApplicationFocus(bool focus)
    {
        this.ActivateAudio(activate:  focus);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void ActivateAudio(bool activate)
    {
        if(AkSoundEngine.IsInitialized() == false)
        {
                return;
        }
        
        if(activate != false)
        {
                AKRESULT val_2 = AkSoundEngine.WakeupFromSuspend();
        }
        else
        {
                AKRESULT val_3 = AkSoundEngine.Suspend();
        }
        
        AKRESULT val_4 = AkSoundEngine.RenderAudio();
    }

}
