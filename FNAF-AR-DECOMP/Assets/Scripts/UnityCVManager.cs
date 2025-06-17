using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class UnityCVManager
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static System.Collections.Generic.Dictionary<CVModels, UnityCVManager.CoreMLFrameUpdate> callbacks;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static UnityCVManager.CoreMLFrameUpdate lastCallback;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static UnityCVManager.FloatUpdate floatCallback;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static UnityCVManager.IntUpdate intCallback;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static UnityCVManager.StringUpdate stringCallback;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static UnityCVManager.BoolUpdate pushNotificationStatusCallback;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static System.Collections.Generic.Dictionary<CVModels, UnityCVManager.DownloadProgressUpdate> downloadProgressCallbacks;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static System.Collections.Generic.Dictionary<CVModels, UnityCVManager.DownloadComplete> downloadCompleteCallbacks;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static UnityCVManager instance;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static float[] floatData;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static double[] doubleData;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static UnityCVManager Instance { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static UnityCVManager get_Instance()
    {
        UnityCVManager val_2;
        var val_3 = null;
        if(UnityCVManager.instance == null)
        {
                UnityCVManager val_1 = null;
            val_2 = val_1;
            val_1 = new UnityCVManager();
            val_3 = null;
            val_3 = null;
            UnityCVManager.instance = val_2;
        }
        
        val_3 = null;
        return (UnityCVManager)UnityCVManager.instance;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityCVManager()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int StartCoreMLSession(IntPtr pixelBuffer, UnityCVManager.CoreMLFrameUpdate callback, CVModels modelType)
    {
        null = null;
        bool val_1 = UnityCVManager.callbacks.ContainsKey(key:  modelType);
        return 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int StartCoreMLSessionWithSparseDepth(float[] sparseDepth, UnityCVManager.CoreMLFrameUpdate callback, CVModels modelType, bool useCPUOnly)
    {
        null = null;
        bool val_1 = UnityCVManager.callbacks.ContainsKey(key:  modelType);
        return 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int StartCoreMLSessionForObjDetection(UnityCVManager.CoreMLFrameUpdate callback, CVModels modelType, bool useCPUOnly)
    {
        null = null;
        bool val_1 = UnityCVManager.callbacks.ContainsKey(key:  modelType);
        return 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void StartCoreMLSessionForSceneRecognition(UnityCVManager.CoreMLFrameUpdate callback, CVModels modelType, float minProbThreshold, bool useCPUOnly)
    {
        null = null;
        bool val_1 = UnityCVManager.callbacks.ContainsKey(key:  modelType);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void LoadModelLocally(CVModels modelIdx)
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void DownloadModel(CVModels modelIdx, string url)
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int PassARSessionPtr(IntPtr sessPtr)
    {
        return 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool QueryCameraPermissionAskedYet()
    {
        return false;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool QueryCameraPermission()
    {
        return false;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool QueryGPSPermission()
    {
        return false;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void QuerySettingsURL()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void QueryRemotePushNotificationEnabled()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void ActivateDepthSession()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void SetupPushNotifCallback(UnityCVManager.BoolUpdate callback)
    {
        null = null;
        UnityCVManager.pushNotificationStatusCallback = callback;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void SetupStringCallback(UnityCVManager.StringUpdate callback)
    {
        null = null;
        UnityCVManager.stringCallback = callback;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void SetupFloatCallback(UnityCVManager.FloatUpdate callback)
    {
        null = null;
        UnityCVManager.floatCallback = callback;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void SetupIntCallback(UnityCVManager.IntUpdate callback)
    {
        null = null;
        UnityCVManager.intCallback = callback;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void SetupDownloadProgressCallback(CVModels modelType, UnityCVManager.DownloadProgressUpdate callback)
    {
        null = null;
        UnityCVManager.downloadProgressCallbacks.set_Item(key:  modelType, value:  callback);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void SetupDownloadCompleteCallback(CVModels modelType, UnityCVManager.DownloadComplete callback)
    {
        null = null;
        UnityCVManager.downloadCompleteCallbacks.set_Item(key:  modelType, value:  callback);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static void downloadProgressReceived(int modelType, int bytesWritten, int totalBytesToWrite)
    {
        null = null;
        DownloadProgressUpdate val_1 = UnityCVManager.downloadProgressCallbacks.Item[modelType];
        if(val_1 == null)
        {
                return;
        }
        
        val_1.Invoke(modelIndex:  modelType, bytesWritten:  bytesWritten, bytesToWrite:  totalBytesToWrite);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static void downloadCompleted(int modelType, int failed)
    {
        null = null;
        DownloadComplete val_1 = UnityCVManager.downloadCompleteCallbacks.Item[modelType];
        if(val_1 == null)
        {
                return;
        }
        
        val_1.Invoke(modelIndex:  modelType, failed:  (failed == 1) ? 1 : 0);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static void floatResultReceived(IntPtr floats, int length)
    {
        var val_2;
        float[] val_1 = new float[0];
        System.Runtime.InteropServices.Marshal.Copy(source:  floats, destination:  val_1, startIndex:  0, length:  length);
        val_2 = null;
        val_2 = null;
        if(UnityCVManager.floatCallback == null)
        {
                return;
        }
        
        UnityCVManager.floatCallback.Invoke(floats:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static void intResultReceived(int result)
    {
        null = null;
        if(UnityCVManager.intCallback == null)
        {
                return;
        }
        
        UnityCVManager.intCallback.Invoke(integer:  result);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static void coremlResultReceived(int index, int modelType, IntPtr strings, int numChars, IntPtr floats, int floatsW, int floatsH, IntPtr doubles, int doublesW, int doublesH)
    {
        System.Single[] val_9;
        var val_10;
        System.Double[] val_11;
        var val_12;
        var val_13;
        int val_2 = floatsH * floatsW;
        val_9 = UnityCVManager.floatData;
        if(val_9 == null)
        {
            goto label_7;
        }
        
        val_9 = UnityCVManager.floatData;
        if(val_9 == null)
        {
            goto label_18;
        }
        
        if(val_2 != UnityCVManager.floatData.Length)
        {
            goto label_7;
        }
        
        val_10 = null;
        goto label_8;
        label_7:
        float[] val_3 = new float[0];
        val_10 = null;
        val_10 = null;
        UnityCVManager.floatData = val_3;
        label_8:
        System.Runtime.InteropServices.Marshal.Copy(source:  floats, destination:  val_3, startIndex:  0, length:  val_2);
        int val_4 = doublesH * doublesW;
        val_11 = UnityCVManager.doubleData;
        if(val_11 == null)
        {
            goto label_19;
        }
        
        val_11 = UnityCVManager.doubleData;
        if(val_11 == null)
        {
            goto label_18;
        }
        
        if(val_4 != UnityCVManager.doubleData.Length)
        {
            goto label_19;
        }
        
        val_12 = null;
        goto label_20;
        label_19:
        double[] val_5 = new double[0];
        val_12 = null;
        val_12 = null;
        UnityCVManager.doubleData = val_5;
        label_20:
        val_12 = null;
        System.Runtime.InteropServices.Marshal.Copy(source:  doubles, destination:  val_5, startIndex:  0, length:  val_4);
        if((UnityCVManager.callbacks.TryGetValue(key:  modelType, value: out  0)) == false)
        {
                return;
        }
        
        val_13 = null;
        val_13 = null;
        bool val_8 = UnityCVManager.callbacks.Remove(key:  modelType);
        val_6.Invoke(index:  index, strings:  UnityCVManager.MarshalStringArray(dataPtr:  strings, arraySize:  numChars), floats:  val_3, floatsW:  floatsW, floatsH:  floatsH, doubles:  val_5, doublesW:  doublesW, doublesH:  doublesH);
        return;
        label_18:
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static void strResultReceived(IntPtr strPtr, int len)
    {
        null = null;
        if(UnityCVManager.stringCallback == null)
        {
                return;
        }
        
        UnityCVManager.stringCallback.Invoke(str:  UnityCVManager.MarshalString(strPtr:  strPtr, len:  len));
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static void pushNotifStatusReceived(int status)
    {
        null = null;
        if(UnityCVManager.pushNotificationStatusCallback == null)
        {
                return;
        }
        
        UnityCVManager.pushNotificationStatusCallback.Invoke(b:  (status == 1) ? 1 : 0);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static string MarshalString(IntPtr strPtr, int len)
    {
        int val_5;
        string val_6;
        val_5 = len;
        byte[] val_1 = new byte[0];
        System.Runtime.InteropServices.Marshal.Copy(source:  strPtr, destination:  val_1, startIndex:  0, length:  val_5);
        val_6 = "";
        if(val_5 < 1)
        {
                return (string)val_6;
        }
        
        var val_5 = 0;
        do
        {
            char val_2 = System.Convert.ToChar(value:  144);
            if((val_2 & 65535) == 0)
        {
                return (string)val_6;
        }
        
            val_5 = val_5 + 1;
            val_6 = val_6 + val_2;
        }
        while(val_5 < (long)val_5);
        
        return (string)val_6;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static string[] MarshalStringArray(IntPtr dataPtr, int arraySize)
    {
        string val_8;
        var val_9;
        byte[] val_1 = new byte[0];
        System.Runtime.InteropServices.Marshal.Copy(source:  dataPtr, destination:  val_1, startIndex:  0, length:  arraySize);
        val_8 = "";
        System.Collections.Generic.List<System.String> val_2 = new System.Collections.Generic.List<System.String>();
        val_9 = 0;
        goto label_3;
        label_11:
        char val_3 = System.Convert.ToChar(value:  val_1[0]);
        if((val_3 & 65535) != 0)
        {
                val_8 = val_8 + val_3;
        }
        else
        {
                val_2.Add(item:  System.String.Copy(str:  val_8));
            val_8 = "";
        }
        
        val_9 = 1;
        label_3:
        if(val_9 < val_1.Length)
        {
            goto label_11;
        }
        
        return (System.String[])val_2.ToArray();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static UnityCVManager()
    {
        UnityCVManager.callbacks = new System.Collections.Generic.Dictionary<CVModels, CoreMLFrameUpdate>();
        UnityCVManager.downloadProgressCallbacks = new System.Collections.Generic.Dictionary<CVModels, DownloadProgressUpdate>();
        UnityCVManager.downloadCompleteCallbacks = new System.Collections.Generic.Dictionary<CVModels, DownloadComplete>();
        UnityCVManager.floatData = 0;
        UnityCVManager.doubleData = 0;
    }

}
