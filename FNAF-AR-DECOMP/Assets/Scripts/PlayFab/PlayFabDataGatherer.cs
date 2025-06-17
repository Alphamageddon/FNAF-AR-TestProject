using UnityEngine;

namespace PlayFab
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PlayFabDataGatherer
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ProductName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ProductBundle;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Version;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Company;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.RuntimePlatform Platform;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool GraphicsMultiThreaded;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Rendering.GraphicsDeviceType GraphicsType;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string DataPath;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string PersistentDataPath;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string StreamingAssetsPath;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int TargetFrameRate;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string UnityVersion;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool RunInBackground;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string DeviceModel;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.DeviceType DeviceType;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string DeviceUniqueId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string OperatingSystem;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int GraphicsDeviceId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string GraphicsDeviceName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int GraphicsMemorySize;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int GraphicsShaderLevel;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int SystemMemorySize;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int ProcessorCount;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int ProcessorFrequency;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ProcessorType;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool SupportsAccelerometer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool SupportsGyroscope;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool SupportsLocationService;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFabDataGatherer()
        {
            this.ProductName = UnityEngine.Application.productName;
            this.Version = UnityEngine.Application.version;
            this.Company = UnityEngine.Application.companyName;
            this.Platform = UnityEngine.Application.platform;
            this.GraphicsMultiThreaded = UnityEngine.SystemInfo.graphicsMultiThreaded;
            this.GraphicsType = UnityEngine.SystemInfo.graphicsDeviceType;
            this.ProductBundle = UnityEngine.Application.identifier;
            this.DataPath = UnityEngine.Application.dataPath;
            this.PersistentDataPath = UnityEngine.Application.persistentDataPath;
            this.StreamingAssetsPath = UnityEngine.Application.streamingAssetsPath;
            this.TargetFrameRate = UnityEngine.Application.targetFrameRate;
            this.UnityVersion = UnityEngine.Application.unityVersion;
            this.RunInBackground = UnityEngine.Application.runInBackground;
            this.DeviceModel = UnityEngine.SystemInfo.deviceModel;
            this.DeviceType = UnityEngine.SystemInfo.deviceType;
            this.DeviceUniqueId = PlayFab.PlayFabSettings.DeviceUniqueIdentifier;
            this.OperatingSystem = UnityEngine.SystemInfo.operatingSystem;
            this.GraphicsDeviceId = UnityEngine.SystemInfo.graphicsDeviceID;
            this.GraphicsDeviceName = UnityEngine.SystemInfo.graphicsDeviceName;
            this.GraphicsMemorySize = UnityEngine.SystemInfo.graphicsMemorySize;
            this.GraphicsShaderLevel = UnityEngine.SystemInfo.graphicsShaderLevel;
            this.SystemMemorySize = UnityEngine.SystemInfo.systemMemorySize;
            this.ProcessorCount = UnityEngine.SystemInfo.processorCount;
            this.ProcessorFrequency = UnityEngine.SystemInfo.processorFrequency;
            this.ProcessorType = UnityEngine.SystemInfo.processorType;
            this.SupportsAccelerometer = UnityEngine.SystemInfo.supportsAccelerometer;
            this.SupportsGyroscope = UnityEngine.SystemInfo.supportsGyroscope;
            this.SupportsLocationService = UnityEngine.SystemInfo.supportsLocationService;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string GenerateReport()
        {
            string val_8;
            var val_9;
            System.Text.StringBuilder val_1 = new System.Text.StringBuilder();
            System.Text.StringBuilder val_2 = val_1.Append(value:  "Logging System Info: ========================================\n");
            val_8 = 0;
            val_9 = 0;
            goto label_3;
            label_9:
            System.Reflection.FieldInfo val_8 = PlayFab.WsaReflectionExtensions.GetTypeInfo(type:  this.GetType()).GetFields()[0];
            val_8 = "System Info - {0}: {1}\n";
            System.Text.StringBuilder val_7 = val_1.AppendFormat(format:  val_8, arg0:  val_8, arg1:  val_8.ToString());
            val_9 = 1;
            label_3:
            if(val_9 < val_5.Length)
            {
                goto label_9;
            }
            
            if(val_1 == null)
            {
                
            }
        
        }
    
    }

}
