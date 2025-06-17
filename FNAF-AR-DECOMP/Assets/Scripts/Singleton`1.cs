using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class Singleton<T> : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected static bool canCreateNew;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static T _instance;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static object _lock;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static bool applicationIsQuitting;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static T Instance { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static T get_Instance()
    {
        var val_22;
        var val_23;
        object val_24;
        var val_25;
        var val_26;
        var val_27;
        var val_28;
        object val_29;
        var val_30;
        var val_31;
        var val_32;
        var val_33;
        var val_34;
        var val_35;
        var val_36;
        var val_37;
        var val_38;
        var val_39;
        val_22 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
        val_22 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
        if((val_22 & 1) == 0)
        {
                val_22 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
            val_22 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
        }
        
        val_23 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 184 + 24];
        val_23 = __RuntimeMethodHiddenParam + 24 + 192 + 184 + 24;
        if(val_23 != 0)
        {
                val_24 = "[Singleton] Instance \'" + System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 24 + 192 + 8})(System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 24 + 192 + 8})) + "\' already destroyed on application quit. Won\'t create again - returning null."("\' already destroyed on application quit. Won\'t create again - returning null.");
            UnityEngine.Debug.LogWarning(message:  val_24);
            val_25 = 0;
            return (object)val_25;
        }
        
        val_26 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
        val_26 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
        if((val_26 & 1) == 0)
        {
                val_26 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
            val_26 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
        }
        
        val_24 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 184 + 16];
        val_24 = __RuntimeMethodHiddenParam + 24 + 192 + 184 + 16;
        bool val_3 = false;
        System.Threading.Monitor.Enter(obj:  val_24, lockTaken: ref  val_3);
        val_27 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
        val_27 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
        if((val_27 & 1) == 0)
        {
                val_27 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
            val_27 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
        }
        
        if((__RuntimeMethodHiddenParam + 24 + 192 + 184 + 8) != 0)
        {
            goto label_153;
        }
        
        UnityEngine.Object val_6 = UnityEngine.Object.FindObjectOfType(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 24 + 192 + 8}));
        val_28 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
        val_28 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
        if((val_28 & 1) == 0)
        {
                val_28 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
            val_28 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
        }
        
        val_29 = mem[__RuntimeMethodHiddenParam + 24];
        val_29 = __RuntimeMethodHiddenParam + 24;
        if(val_6 == null)
        {
            goto label_57;
        }
        
        val_30 = val_6;
        if(val_30 != null)
        {
            goto label_58;
        }
        
        label_57:
        val_30 = 0;
        label_58:
        mem2[0] = val_30;
        UnityEngine.Object[] val_9 = UnityEngine.Object.FindObjectsOfType(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 24 + 192 + 8}));
        if(val_9.Length >= 2)
        {
            goto label_61;
        }
        
        val_31 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
        val_31 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
        if((val_31 & 1) == 0)
        {
                val_31 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
            val_31 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
        }
        
        if((__RuntimeMethodHiddenParam + 24 + 192 + 184 + 8) != 0)
        {
            goto label_74;
        }
        
        val_32 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
        val_32 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
        if((val_32 & 1) == 0)
        {
                val_32 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
            val_32 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
        }
        
        if((__RuntimeMethodHiddenParam + 24 + 192 + 184) == 0)
        {
            goto label_85;
        }
        
        new UnityEngine.GameObject() = new UnityEngine.GameObject();
        val_33 = mem[__RuntimeMethodHiddenParam + 24 + 294];
        val_33 = __RuntimeMethodHiddenParam + 24 + 294;
        val_34 = __RuntimeMethodHiddenParam + 24;
        if((val_33 & 1) == 0)
        {
                val_34 = mem[__RuntimeMethodHiddenParam + 24];
            val_34 = __RuntimeMethodHiddenParam + 24;
            val_33 = mem[__RuntimeMethodHiddenParam + 24 + 294];
            val_33 = __RuntimeMethodHiddenParam + 24 + 294;
        }
        
        val_35 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
        val_35 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
        if((val_35 & 1) == 0)
        {
                val_35 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
            val_35 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
        }
        
        mem2[0] = new UnityEngine.GameObject();
        new UnityEngine.GameObject().name = "(singleton) " + System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 24 + 192 + 8})(System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 24 + 192 + 8}));
        UnityEngine.Object.DontDestroyOnLoad(target:  new UnityEngine.GameObject());
        object[] val_14 = new object[5];
        val_14[0] = "[Singleton] An instance of ";
        val_14[1] = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 24 + 192 + 8});
        val_29 = " is needed in the scene, so \'";
        val_14[2] = val_29;
        val_14[3] = new UnityEngine.GameObject();
        val_14[4] = "\' was created with DontDestroyOnLoad.";
        UnityEngine.Debug.Log(message:  +val_14);
        goto label_153;
        label_61:
        UnityEngine.Debug.LogError(message:  "[Singleton] Something went really wrong  - there should never be more than 1 singleton! Reopening the scene might fix it.");
        val_36 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
        val_36 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
        if((val_36 & 1) == 0)
        {
                val_36 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
            val_36 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
        }
        
        val_37 = mem[__RuntimeMethodHiddenParam + 24 + 192];
        val_37 = __RuntimeMethodHiddenParam + 24 + 192;
        if(((__RuntimeMethodHiddenParam + 24 + 192 + 294) & 1) != 0)
        {
            goto label_168;
        }
        
        goto label_168;
        label_74:
        val_38 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
        val_38 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
        if((val_38 & 1) == 0)
        {
                val_38 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
            val_38 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
        }
        
        UnityEngine.Debug.Log(message:  "[Singleton] Using instance already created: "("[Singleton] Using instance already created: ") + __RuntimeMethodHiddenParam + 24 + 192 + 184 + 8.gameObject.name(__RuntimeMethodHiddenParam + 24 + 192 + 184 + 8.gameObject.name));
        goto label_153;
        label_85:
        UnityEngine.Debug.LogWarning(message:  "[Singleton] Instance \'" + System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 24 + 192 + 8})(System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 24 + 192 + 8})) + "\' not created. Does not already exist. Marked as unable to create a new one - returning null."("\' not created. Does not already exist. Marked as unable to create a new one - returning null."));
        label_153:
        val_39 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
        val_39 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
        if((val_39 & 1) == 0)
        {
                val_39 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
            val_39 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
        }
        
        val_37 = mem[__RuntimeMethodHiddenParam + 24 + 192];
        val_37 = __RuntimeMethodHiddenParam + 24 + 192;
        label_168:
        val_23 = 0;
        val_25 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 184 + 8];
        val_25 = __RuntimeMethodHiddenParam + 24 + 192 + 184 + 8;
        if(val_3 != 0)
        {
                System.Threading.Monitor.Exit(obj:  val_24);
        }
        
        if(376 == 376)
        {
                return (object)val_25;
        }
        
        if(val_23 == 0)
        {
                return (object)val_25;
        }
        
        return (object)val_25;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void OnDestroy()
    {
        var val_1 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
        val_1 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
        if((val_1 & 1) == 0)
        {
                val_1 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
            val_1 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
        }
        
        mem2[0] = 1;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Singleton<T>()
    {
        if(this != null)
        {
                return;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static Singleton<T>()
    {
        mem2[0] = 1;
        mem2[0] = new System.Object();
        mem2[0] = 0;
    }

}
