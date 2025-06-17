using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class ARCameraConfigurator : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.XR.ARFoundation.ARCameraManager cameraManager;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int configIdx;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool configRetrievalAttempted;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private SharedTechAssets.Scripts.Utilities.ARCameraConfigurator_SROptions _options;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void GetConfigs()
    {
        Unity.Collections.NativeArray<UnityEngine.XR.ARSubsystems.XRCameraConfiguration> val_1 = this.cameraManager.GetConfigurations(allocator:  2);
        System.Nullable<UnityEngine.XR.ARSubsystems.XRCameraConfiguration> val_2 = this.cameraManager.currentConfiguration;
        if(( & 1) != 0)
        {
                System.Nullable<UnityEngine.XR.ARSubsystems.XRCameraConfiguration> val_3 = this.cameraManager.currentConfiguration;
            if(2 >= 1)
        {
                int val_11 = 0;
            do
        {
            Unity.Collections.Allocator val_10 = val_1.m_AllocatorLabel;
            val_10 = val_10 + (val_11 * 12);
            if((UnityEngine.XR.ARSubsystems.XRCameraConfiguration.op_Equality(lhs:  new UnityEngine.XR.ARSubsystems.XRCameraConfiguration() {m_Resolution = new UnityEngine.Vector2Int() {m_X = 1505000208, m_Y = 268435459}, m_Framerate = (X21 & (-4294967296)) | 1327766816}, rhs:  new UnityEngine.XR.ARSubsystems.XRCameraConfiguration() {m_Resolution = new UnityEngine.Vector2Int() {m_X = val_10, m_Y = val_10}, m_Framerate = (X22 & (-4294967296)) | ((0 * 12) + val_1.m_AllocatorLabel + 8)})) != false)
        {
                this.configIdx = val_11;
        }
        
            val_11 = val_11 + 1;
        }
        while(val_11 < 2);
        
        }
        
        }
        
        System.Nullable<UnityEngine.XR.ARSubsystems.XRCameraConfiguration> val_9 = this.cameraManager.currentConfiguration;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void PrintConfigs()
    {
        UnityEngine.XR.ARFoundation.ARCameraManager val_4 = this.cameraManager;
        Unity.Collections.NativeArray<UnityEngine.XR.ARSubsystems.XRCameraConfiguration> val_1 = val_4.GetConfigurations(allocator:  2);
        if(2 < 1)
        {
                return;
        }
        
        object val_5 = 0;
        do
        {
            object[] val_2 = new object[4];
            val_2[0] = "Config ";
            val_2[1] = val_5;
            val_2[2] = ": ";
            Unity.Collections.Allocator val_4 = val_1.m_AllocatorLabel;
            val_4 = val_4 + (val_5 * 12);
            val_2[3] = val_4;
            val_4 = +val_2;
            ConsoleLogger.LogError(className:  "ARCameraConfigurator", functionName:  "PrintConfigs", logString:  val_4);
            val_5 = val_5 + 1;
        }
        while(val_5 < 2);
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void UpdateConfig()
    {
        Unity.Collections.NativeArray<UnityEngine.XR.ARSubsystems.XRCameraConfiguration> val_1 = this.cameraManager.GetConfigurations(allocator:  2);
        if(((this.configIdx & 2147483648) != 0) || (this.configIdx >= 2))
        {
                return;
        }
        
        this = this.cameraManager;
        var val_2 = (long)this.configIdx;
        val_2 = val_1.m_AllocatorLabel + (val_2 * 12);
        this.currentConfiguration = new System.Nullable<UnityEngine.XR.ARSubsystems.XRCameraConfiguration>() {HasValue = false};
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Update()
    {
        if(this.cameraManager.subsystem == null)
        {
                return;
        }
        
        if(this.cameraManager.subsystem.running == false)
        {
                return;
        }
        
        if(this.configRetrievalAttempted == true)
        {
                return;
        }
        
        this.GetConfigs();
        this.configRetrievalAttempted = true;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Start()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void OnDestroy()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ARCameraConfigurator()
    {
        this.configIdx = 0;
    }

}
