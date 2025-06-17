using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public static class SRDebug
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const string Version = "1.7.1";
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static SRDebugger.Services.IDebugService Instance { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static SRDebugger.Services.IDebugService get_Instance()
    {
        return 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void Init()
    {
        if((SRF.Service.SRServiceManager.HasService<SRDebugger.Services.IConsoleService>()) != true)
        {
                SRDebugger.Services.Implementation.StandardConsoleService val_2 = new SRDebugger.Services.Implementation.StandardConsoleService();
        }
        
        SRDebugger.Services.IDebugService val_3 = SRF.Service.SRServiceManager.GetService<SRDebugger.Services.IDebugService>();
    }

}
