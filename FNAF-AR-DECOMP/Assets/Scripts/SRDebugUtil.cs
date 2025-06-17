using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public static class SRDebugUtil
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int LineBufferCount = 512;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static bool <IsFixedUpdate>k__BackingField;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static bool IsFixedUpdate { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static bool get_IsFixedUpdate()
    {
        return (bool)SRDebugUtil.<IsFixedUpdate>k__BackingField;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void set_IsFixedUpdate(bool value)
    {
        SRDebugUtil.<IsFixedUpdate>k__BackingField = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void AssertNotNull(object value, string message, UnityEngine.MonoBehaviour instance)
    {
        object val_6;
        if(((System.Collections.Generic.EqualityComparer<System.Object>.Default) & 1) == 0)
        {
                return;
        }
        
        if(message == null)
        {
                val_6 = "Assert Failed";
        }
        else
        {
                object[] val_2 = new object[1];
            val_2[0] = message;
            val_6 = SRF.SRFStringExtensions.Fmt(formatString:  "NotNullAssert Failed: {0}", args:  val_2);
        }
        
        UnityEngine.Debug.LogError(message:  val_6, context:  instance);
        if(instance != 0)
        {
                instance.enabled = false;
        }
        
        System.NullReferenceException val_5 = new System.NullReferenceException(message:  val_6);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void Assert(bool condition, string message, UnityEngine.MonoBehaviour instance)
    {
        object val_4;
        if(condition != false)
        {
                return;
        }
        
        if(message == null)
        {
                val_4 = "Assert Failed";
        }
        else
        {
                object[] val_1 = new object[1];
            val_1[0] = message;
            val_4 = SRF.SRFStringExtensions.Fmt(formatString:  "Assert Failed: {0}", args:  val_1);
        }
        
        UnityEngine.Debug.LogError(message:  val_4, context:  instance);
        System.Exception val_3 = new System.Exception(message:  val_4);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void EditorAssertNotNull(object value, string message, UnityEngine.MonoBehaviour instance)
    {
        SRDebugUtil.AssertNotNull(value:  value, message:  message, instance:  instance);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void EditorAssert(bool condition, string message, UnityEngine.MonoBehaviour instance)
    {
        SRDebugUtil.Assert(condition:  condition, message:  message, instance:  instance);
    }

}
