using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
[Serializable]
public class AppCenterSettingsAdvanced : ScriptableObject
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string TransmissionTargetToken;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Microsoft.AppCenter.Unity.StartupType AppCenterStartupType;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool StartAndroidNativeSDKFromAppCenterBehavior;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool StartIOSNativeSDKFromAppCenterBehavior;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static System.Reflection.Assembly AppCenterAssembly { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Microsoft.AppCenter.Unity.StartupType GetStartupType()
    {
        Microsoft.AppCenter.Unity.StartupType val_2 = this.AppCenterStartupType;
        if(val_2 != 2)
        {
                return val_2;
        }
        
        if((System.String.IsNullOrEmpty(value:  this.TransmissionTargetToken)) != false)
        {
                val_2 = 0;
            return val_2;
        }
        
        val_2 = this.AppCenterStartupType;
        return val_2;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static System.Reflection.Assembly get_AppCenterAssembly()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AppCenterSettingsAdvanced()
    {
        this.AppCenterStartupType = 2;
        this.TransmissionTargetToken = "";
    }

}
