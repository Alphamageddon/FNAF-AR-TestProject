using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AppCenterBehavior : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static System.Action InitializingServices;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static System.Action InitializedAppCenterAndServices;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static System.Action Started;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static AppCenterBehavior _instance;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AppCenterSettings Settings;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void add_InitializingServices(System.Action value)
    {
        System.Delegate val_3 = System.Delegate.Combine(a:  AppCenterBehavior.InitializingServices, b:  value);
        if(val_3 == null)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
        
        val_3 = 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void remove_InitializingServices(System.Action value)
    {
        System.Delegate val_3 = System.Delegate.Remove(source:  AppCenterBehavior.InitializingServices, value:  value);
        if(val_3 == null)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
        
        val_3 = 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void add_InitializedAppCenterAndServices(System.Action value)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  AppCenterBehavior.InitializedAppCenterAndServices, b:  value);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(AppCenterBehavior.InitializedAppCenterAndServices != 1152921505061482504);
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void remove_InitializedAppCenterAndServices(System.Action value)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  AppCenterBehavior.InitializedAppCenterAndServices, value:  value);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(AppCenterBehavior.InitializedAppCenterAndServices != 1152921505061482504);
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void add_Started(System.Action value)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  AppCenterBehavior.Started, b:  value);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(AppCenterBehavior.Started != 1152921505061482512);
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void remove_Started(System.Action value)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  AppCenterBehavior.Started, value:  value);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(AppCenterBehavior.Started != 1152921505061482512);
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Awake()
    {
        if(AppCenterBehavior._instance != 0)
        {
                UnityEngine.Debug.LogError(message:  "App Center Behavior should have only one instance!");
            UnityEngine.Object.DestroyImmediate(obj:  this.gameObject);
            return;
        }
        
        AppCenterBehavior._instance = this;
        UnityEngine.Object.DontDestroyOnLoad(target:  this.gameObject);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Start()
    {
        this.StartAppCenter();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void StartAppCenter()
    {
        string val_14;
        MaxStorageSizeProperty val_15;
        if(this.Settings == 0)
        {
                UnityEngine.Debug.LogError(message:  "App Center isn\'t configured!");
            return;
        }
        
        System.Type[] val_2 = this.Settings.Services;
        AppCenterBehavior.PrepareEventHandlers(services:  val_2);
        AppCenterBehavior.InvokeInitializingServices();
        Microsoft.AppCenter.Unity.AppCenter.SetWrapperSdk();
        Microsoft.AppCenter.Unity.AppCenter.CacheStorageSize(storageSize:  this.Settings.MaxStorageSize.Size);
        if(this.Settings.CustomLogUrl.UseCustomUrl != false)
        {
                Microsoft.AppCenter.Unity.AppCenter.CacheLogUrl(logUrl:  this.Settings.CustomLogUrl.Url);
        }
        
        val_14 = Microsoft.AppCenter.Unity.AppCenter.ParseAndSaveSecretForPlatform(secrets:  this.Settings.AppSecret);
        AppCenterBehaviorAdvanced val_5 = this.GetComponent<AppCenterBehaviorAdvanced>();
        if((val_5.IsStartFromAppCenterBehavior(advancedSettings:  val_5)) == false)
        {
            goto label_21;
        }
        
        Microsoft.AppCenter.Unity.AppCenter.LogLevel = this.Settings.InitialLogLevel;
        if(this.Settings.CustomLogUrl.UseCustomUrl != false)
        {
                Microsoft.AppCenter.Unity.AppCenter.SetLogUrl(logUrl:  this.Settings.CustomLogUrl.Url);
        }
        
        val_15 = this.Settings.MaxStorageSize;
        if(this.Settings.MaxStorageSize.UseCustomMaxStorageSize != false)
        {
                val_15 = this.Settings.MaxStorageSize;
            if(this.Settings.MaxStorageSize.Size >= 1)
        {
                Microsoft.AppCenter.Unity.Internal.AppCenterInternal.SetMaxStorageSize(size:  this.Settings.MaxStorageSize.Size);
        }
        
        }
        
        Microsoft.AppCenter.Unity.StartupType val_7 = this.Settings.MaxStorageSize.Size.GetStartupType(advancedSettings:  val_5);
        if(val_7 == 4)
        {
            goto label_57;
        }
        
        string val_8 = val_7.GetTransmissionTargetToken(advancedSettings:  val_5);
        string val_9 = val_8.GetAppSecretString(appSecret:  val_14, transmissionTargetToken:  val_8, startupType:  val_7);
        if((System.String.IsNullOrEmpty(value:  val_9)) == false)
        {
            goto label_43;
        }
        
        Microsoft.AppCenter.Unity.Internal.AppCenterInternal.Start(services:  val_2);
        goto label_57;
        label_21:
        val_14 = 0;
        goto label_47;
        label_53:
        System.Reflection.MethodInfo val_11 = val_2[0].GetMethod(name:  "StartCrashes");
        if((System.Reflection.MethodInfo.op_Inequality(left:  val_11, right:  0)) != false)
        {
                object val_13 = val_11.Invoke(obj:  0, parameters:  0);
        }
        
        val_14 = 1;
        label_47:
        if(val_14 < val_2.Length)
        {
            goto label_53;
        }
        
        label_57:
        AppCenterBehavior.InvokeInitializedServices();
        if(AppCenterBehavior.Started == null)
        {
                return;
        }
        
        AppCenterBehavior.Started.Invoke();
        return;
        label_43:
        Microsoft.AppCenter.Unity.Internal.AppCenterInternal.Start(appSecret:  val_9, services:  val_2);
        goto label_57;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool IsStartFromAppCenterBehavior(AppCenterBehaviorAdvanced advancedSettings)
    {
        UnityEngine.Object val_4;
        var val_5;
        val_4 = advancedSettings;
        if(val_4 != 0)
        {
                if(advancedSettings.SettingsAdvanced != 0)
        {
                val_4 = advancedSettings.SettingsAdvanced;
            var val_3 = (advancedSettings.SettingsAdvanced.StartAndroidNativeSDKFromAppCenterBehavior == true) ? 1 : 0;
            return (bool)val_5;
        }
        
        }
        
        val_5 = 0;
        return (bool)val_5;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Microsoft.AppCenter.Unity.StartupType GetStartupType(AppCenterBehaviorAdvanced advancedSettings)
    {
        UnityEngine.Object val_4;
        Microsoft.AppCenter.Unity.StartupType val_5;
        val_4 = advancedSettings;
        if(val_4 != 0)
        {
                if(advancedSettings.SettingsAdvanced != 0)
        {
                val_4 = advancedSettings.SettingsAdvanced;
            val_5 = advancedSettings.SettingsAdvanced.AppCenterStartupType;
            if(val_5 != 2)
        {
                return (Microsoft.AppCenter.Unity.StartupType)val_5;
        }
        
            if((System.String.IsNullOrEmpty(value:  advancedSettings.SettingsAdvanced.TransmissionTargetToken)) == false)
        {
                return (Microsoft.AppCenter.Unity.StartupType)val_5;
        }
        
        }
        
        }
        
        val_5 = 0;
        return (Microsoft.AppCenter.Unity.StartupType)val_5;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string GetTransmissionTargetToken(AppCenterBehaviorAdvanced advancedSettings)
    {
        UnityEngine.Object val_3;
        string val_4;
        val_3 = advancedSettings;
        if(val_3 == 0)
        {
                return (string)System.String.__il2cppRuntimeField_static_fields;
        }
        
        if(advancedSettings.SettingsAdvanced == 0)
        {
                return (string)System.String.__il2cppRuntimeField_static_fields;
        }
        
        val_3 = advancedSettings.SettingsAdvanced;
        val_4 = advancedSettings.SettingsAdvanced.TransmissionTargetToken;
        return (string)System.String.__il2cppRuntimeField_static_fields;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string GetAppSecretString(string appSecret, string transmissionTargetToken, Microsoft.AppCenter.Unity.StartupType startupType)
    {
        string val_1 = appSecret;
        if(startupType == 1)
        {
                return System.String.Format(format:  "target={0}", arg0:  transmissionTargetToken);
        }
        
        if(startupType == 2)
        {
                return System.String.Format(format:  "appsecret={0};target={1}", arg0:  val_1 = appSecret, arg1:  transmissionTargetToken);
        }
        
        if(startupType != 3)
        {
                return (string)val_1;
        }
        
        val_1 = System.String.alignConst;
        return (string)val_1;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static void PrepareEventHandlers(System.Type[] services)
    {
        goto label_1;
        label_7:
        System.Reflection.MethodInfo val_1 = services[0].GetMethod(name:  "PrepareEventHandlers");
        if((System.Reflection.MethodInfo.op_Inequality(left:  val_1, right:  0)) != false)
        {
                object val_3 = val_1.Invoke(obj:  0, parameters:  0);
        }
        
        0 = 1;
        label_1:
        if(0 < services.Length)
        {
            goto label_7;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static void InvokeInitializingServices()
    {
        if(AppCenterBehavior.InitializingServices == null)
        {
                return;
        }
        
        AppCenterBehavior.InitializingServices.Invoke();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static void InvokeInitializedServices()
    {
        if(AppCenterBehavior.InitializedAppCenterAndServices == null)
        {
                return;
        }
        
        AppCenterBehavior.InitializedAppCenterAndServices.Invoke();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AppCenterBehavior()
    {
    
    }

}
