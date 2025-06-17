using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkInitializer : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static AkInitializer ms_Instance;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkWwiseInitializationSettings InitializationSettings;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Awake()
    {
        if((UnityEngine.Object.op_Implicit(exists:  AkInitializer.ms_Instance)) != false)
        {
                UnityEngine.Object.DestroyImmediate(obj:  this);
            return;
        }
        
        AkInitializer.ms_Instance = this;
        UnityEngine.Object.DontDestroyOnLoad(target:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void OnEnable()
    {
        this.InitializationSettings = AkWwiseInitializationSettings.Instance;
        if(AkInitializer.ms_Instance != this)
        {
                return;
        }
        
        AkSoundEngineController.Instance.Init(akInitializer:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void OnDisable()
    {
        if(AkInitializer.ms_Instance != this)
        {
                return;
        }
        
        AkSoundEngineController.Instance.OnDisable();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void OnDestroy()
    {
        if(AkInitializer.ms_Instance != this)
        {
                return;
        }
        
        this = AkSoundEngineController.Instance;
        this.Terminate();
        AkInitializer.ms_Instance = 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void OnApplicationPause(bool pauseStatus)
    {
        if(AkInitializer.ms_Instance != this)
        {
                return;
        }
        
        AkSoundEngineController.Instance.OnApplicationPause(pauseStatus:  pauseStatus);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void OnApplicationFocus(bool focus)
    {
        if(AkInitializer.ms_Instance != this)
        {
                return;
        }
        
        AkSoundEngineController.Instance.OnApplicationFocus(focus:  focus);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void OnApplicationQuit()
    {
        if(AkInitializer.ms_Instance != this)
        {
                return;
        }
        
        AkSoundEngineController.Instance.Terminate();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void LateUpdate()
    {
        if(AkInitializer.ms_Instance != this)
        {
                return;
        }
        
        AkSoundEngineController.Instance.LateUpdate();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkInitializer()
    {
    
    }

}
