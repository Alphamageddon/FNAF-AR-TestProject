using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class UnityCVManager_Android : ITimeUpdateAccepter
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static UnityCVManager_Android.ObjDetectUpdate _objDetectCallback;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static UnityCVManager_Android instance;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static bool objDetectResultReceived;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static string[] strData;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static float[] minXArr;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static float[] minYArr;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static float[] maxXArr;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static float[] maxYArr;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static float[] confArr;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static UnityCVManager_Android Instance { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static UnityCVManager_Android get_Instance()
    {
        UnityCVManager_Android val_2;
        var val_3 = null;
        if(UnityCVManager_Android.instance == null)
        {
                UnityCVManager_Android val_1 = null;
            val_2 = val_1;
            val_1 = new UnityCVManager_Android();
            val_3 = null;
            val_3 = null;
            UnityCVManager_Android.instance = val_2;
        }
        
        val_3 = null;
        return (UnityCVManager_Android)UnityCVManager_Android.instance;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityCVManager_Android()
    {
        mem[1152921519019030272] = 0;
        mem[1152921519019030280] = static System.Void UnityCVManager_Android::onObjDetectResultReceived(IntPtr strings, int numChars, IntPtr minXs, IntPtr minYs, IntPtr maxXs, IntPtr maxYs, IntPtr confs, int numPreds);
        mem[1152921519019030256] = static System.Void UnityCVManager_Android::onObjDetectResultReceived(IntPtr strings, int numChars, IntPtr minXs, IntPtr minYs, IntPtr maxXs, IntPtr maxYs, IntPtr confs, int numPreds);
        UnityCVManager_Android._setObjDetectCallback(callback:  new UnityCVManager_Android.internal_UnityObjDetectUpdate());
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static extern void _setupSession(IntPtr sessionPtr, int w, int h)
    {
        if(52948160 != 0)
        {
                return;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static extern void _attemptObjectDetectionUpdate(int rotation, int useCPUOnly)
    {
        if(52948160 != 0)
        {
                return;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static extern void _setObjDetectCallback(UnityCVManager_Android.internal_UnityObjDetectUpdate callback)
    {
        if(52948160 != 0)
        {
                return;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void SetupObjDetectCallback(UnityCVManager_Android.ObjDetectUpdate callback)
    {
        null = null;
        UnityCVManager_Android._objDetectCallback = callback;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void SetupSession(IntPtr p)
    {
        Pt val_1 = System.Runtime.InteropServices.Marshal.PtrToStructure<Pt>(ptr:  p);
        UnityEngine.AndroidJavaObject val_3 = new UnityEngine.AndroidJavaClass(className:  "com.unity3d.player.UnityPlayer").GetStatic<UnityEngine.AndroidJavaObject>(fieldName:  "currentActivity");
        object[] val_5 = new object[1];
        if(val_5 == null)
        {
            goto label_4;
        }
        
        if(val_3 != null)
        {
            goto label_5;
        }
        
        goto label_8;
        label_4:
        if(val_3 == null)
        {
            goto label_8;
        }
        
        label_5:
        label_8:
        val_5[0] = val_3;
        new UnityEngine.AndroidJavaClass(className:  "com.illumix.androidplugin.NativeCVManager").CallStatic(methodName:  "Call", args:  val_5);
        UnityCVManager_Android._setupSession(sessionPtr:  val_1.arSessionPtr, w:  System.Math.Min(val1:  UnityEngine.Screen.width, val2:  UnityEngine.Screen.height), h:  System.Math.Max(val1:  UnityEngine.Screen.width, val2:  UnityEngine.Screen.height));
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void AttemptObjDetectUpdate(bool useCPU)
    {
        var val_7;
        if(UnityEngine.Screen.orientation == 3)
        {
                val_7 = 0;
        }
        else
        {
                if(UnityEngine.Screen.orientation == 1)
        {
                val_7 = 1;
        }
        else
        {
                if(UnityEngine.Screen.orientation == 4)
        {
                val_7 = 2;
        }
        
        }
        
        }
        
        UnityCVManager_Android._attemptObjectDetectionUpdate(rotation:  (UnityEngine.Screen.orientation == 2) ? 3 : 0, useCPUOnly:  useCPU);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static void onObjDetectResultReceived(IntPtr strings, int numChars, IntPtr minXs, IntPtr minYs, IntPtr maxXs, IntPtr maxYs, IntPtr confs, int numPreds)
    {
        int val_13;
        int val_14;
        var val_15;
        var val_16;
        val_13 = numPreds;
        val_14 = numChars;
        if(val_14 != 1)
        {
                UnityCVManager_Android.strData = UnityCVManager_Android.MarshalStringArray(dataPtr:  strings, arraySize:  val_14);
            float[] val_2 = new float[0];
            UnityCVManager_Android.minXArr = val_2;
            float[] val_3 = new float[0];
            UnityCVManager_Android.minYArr = val_3;
            float[] val_4 = new float[0];
            UnityCVManager_Android.maxXArr = val_4;
            float[] val_5 = new float[0];
            UnityCVManager_Android.maxYArr = val_5;
            float[] val_6 = new float[0];
            UnityCVManager_Android.confArr = val_6;
            val_14 = UnityCVManager_Android.minXArr;
            System.Runtime.InteropServices.Marshal.Copy(source:  minXs, destination:  val_2, startIndex:  0, length:  val_13);
            System.Runtime.InteropServices.Marshal.Copy(source:  minYs, destination:  val_3, startIndex:  0, length:  val_13);
            System.Runtime.InteropServices.Marshal.Copy(source:  maxXs, destination:  val_4, startIndex:  0, length:  val_13);
            System.Runtime.InteropServices.Marshal.Copy(source:  maxYs, destination:  val_5, startIndex:  0, length:  val_13);
            System.Runtime.InteropServices.Marshal.Copy(source:  confs, destination:  val_6, startIndex:  0, length:  val_13);
            val_15 = null;
        }
        else
        {
                val_16 = null;
            val_16 = null;
            UnityCVManager_Android.strData = new string[0];
            val_13 = 1152921505924375376;
            UnityCVManager_Android.minXArr = new float[0];
            UnityCVManager_Android.minYArr = new float[0];
            UnityCVManager_Android.maxXArr = new float[0];
            UnityCVManager_Android.maxYArr = new float[0];
            val_15 = null;
            UnityCVManager_Android.confArr = new float[0];
        }
        
        UnityCVManager_Android.objDetectResultReceived = true;
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
    public void TimeUpdateEvent()
    {
        var val_2 = null;
        if(UnityCVManager_Android.objDetectResultReceived == false)
        {
                return;
        }
        
        val_2 = null;
        if(UnityCVManager_Android.__il2cppRuntimeField_static_fields != null)
        {
                UnityCVManager_Android.__il2cppRuntimeField_static_fields.Invoke(labels:  UnityCVManager_Android.strData, minX:  UnityCVManager_Android.minXArr, minY:  UnityCVManager_Android.minYArr, maxX:  UnityCVManager_Android.maxXArr, maxY:  UnityCVManager_Android.maxYArr, confs:  UnityCVManager_Android.confArr);
            val_2 = null;
        }
        
        val_2 = null;
        UnityCVManager_Android.objDetectResultReceived = false;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static UnityCVManager_Android()
    {
        UnityCVManager_Android.objDetectResultReceived = false;
        UnityCVManager_Android.strData = new string[0];
        UnityCVManager_Android.minXArr = new float[0];
        UnityCVManager_Android.minYArr = new float[0];
        UnityCVManager_Android.maxXArr = new float[0];
        UnityCVManager_Android.maxYArr = new float[0];
        UnityCVManager_Android.confArr = new float[0];
    }

}
