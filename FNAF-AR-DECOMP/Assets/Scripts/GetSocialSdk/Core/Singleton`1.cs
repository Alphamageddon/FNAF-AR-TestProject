using UnityEngine;

namespace GetSocialSdk.Core
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract class Singleton<T> : MonoBehaviour
    {
        // Fields
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
        protected static void LoadInstance()
        {
            var val_1;
            var val_2;
            var val_3;
            val_1 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 8 + 294];
            val_1 = __RuntimeMethodHiddenParam + 24 + 192 + 8 + 294;
            if((val_1 & 1) == 0)
            {
                    val_1 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 8 + 294];
                val_1 = __RuntimeMethodHiddenParam + 24 + 192 + 8 + 294;
            }
            
            val_2 = mem[__RuntimeMethodHiddenParam + 24 + 294];
            val_2 = __RuntimeMethodHiddenParam + 24 + 294;
            val_3 = __RuntimeMethodHiddenParam + 24;
            if((val_2 & 1) == 0)
            {
                    val_3 = mem[__RuntimeMethodHiddenParam + 24];
                val_3 = __RuntimeMethodHiddenParam + 24;
                val_2 = mem[__RuntimeMethodHiddenParam + 24 + 294];
                val_2 = __RuntimeMethodHiddenParam + 24 + 294;
            }
            
            mem2[0] = __RuntimeMethodHiddenParam + 24 + 192;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static T get_Instance()
        {
            var val_20;
            var val_21;
            object val_22;
            var val_23;
            var val_24;
            var val_25;
            var val_26;
            object val_27;
            var val_28;
            var val_29;
            var val_30;
            var val_31;
            var val_32;
            var val_33;
            var val_34;
            var val_35;
            var val_36;
            val_20 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 8 + 294];
            val_20 = __RuntimeMethodHiddenParam + 24 + 192 + 8 + 294;
            if((val_20 & 1) == 0)
            {
                    val_20 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 8 + 294];
                val_20 = __RuntimeMethodHiddenParam + 24 + 192 + 8 + 294;
            }
            
            val_21 = mem[__RuntimeMethodHiddenParam + 24];
            val_21 = __RuntimeMethodHiddenParam + 24;
            if((__RuntimeMethodHiddenParam + 24 + 192 + 8 + 184 + 16) != 0)
            {
                    val_22 = "[Singleton] Instance \'" + System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 24 + 192 + 16})(System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 24 + 192 + 16})) + "\' already destroyed on application quit. Won\'t create again - returning null."("\' already destroyed on application quit. Won\'t create again - returning null.");
                UnityEngine.Debug.LogWarning(message:  val_22);
                val_23 = 0;
                return (GetSocialSdk.Core.MainThreadExecutor)val_23;
            }
            
            val_24 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 8 + 294];
            val_24 = __RuntimeMethodHiddenParam + 24 + 192 + 8 + 294;
            if((val_24 & 1) == 0)
            {
                    val_24 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 8 + 294];
                val_24 = __RuntimeMethodHiddenParam + 24 + 192 + 8 + 294;
            }
            
            val_22 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 8 + 184 + 8];
            val_22 = __RuntimeMethodHiddenParam + 24 + 192 + 8 + 184 + 8;
            bool val_3 = false;
            System.Threading.Monitor.Enter(obj:  val_22, lockTaken: ref  val_3);
            val_25 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 8 + 294];
            val_25 = __RuntimeMethodHiddenParam + 24 + 192 + 8 + 294;
            if((val_25 & 1) == 0)
            {
                    val_25 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 8 + 294];
                val_25 = __RuntimeMethodHiddenParam + 24 + 192 + 8 + 294;
            }
            
            if((__RuntimeMethodHiddenParam + 24 + 192 + 8 + 184) != 0)
            {
                goto label_114;
            }
            
            UnityEngine.Object val_6 = UnityEngine.Object.FindObjectOfType(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 24 + 192 + 16}));
            val_26 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 8 + 294];
            val_26 = __RuntimeMethodHiddenParam + 24 + 192 + 8 + 294;
            if((val_26 & 1) == 0)
            {
                    val_26 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 8 + 294];
                val_26 = __RuntimeMethodHiddenParam + 24 + 192 + 8 + 294;
            }
            
            val_27 = mem[__RuntimeMethodHiddenParam + 24];
            val_27 = __RuntimeMethodHiddenParam + 24;
            if(val_6 == null)
            {
                goto label_57;
            }
            
            val_28 = val_6;
            if(val_28 != null)
            {
                goto label_58;
            }
            
            label_57:
            val_28 = 0;
            label_58:
            mem2[0] = val_28;
            UnityEngine.Object[] val_9 = UnityEngine.Object.FindObjectsOfType(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 24 + 192 + 16}));
            if(val_9.Length >= 2)
            {
                goto label_61;
            }
            
            val_29 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 8 + 294];
            val_29 = __RuntimeMethodHiddenParam + 24 + 192 + 8 + 294;
            if((val_29 & 1) == 0)
            {
                    val_29 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 8 + 294];
                val_29 = __RuntimeMethodHiddenParam + 24 + 192 + 8 + 294;
            }
            
            if((__RuntimeMethodHiddenParam + 24 + 192 + 8 + 184) != 0)
            {
                goto label_74;
            }
            
            new UnityEngine.GameObject() = new UnityEngine.GameObject();
            val_30 = mem[__RuntimeMethodHiddenParam + 24 + 294];
            val_30 = __RuntimeMethodHiddenParam + 24 + 294;
            val_31 = __RuntimeMethodHiddenParam + 24;
            if((val_30 & 1) == 0)
            {
                    val_31 = mem[__RuntimeMethodHiddenParam + 24];
                val_31 = __RuntimeMethodHiddenParam + 24;
                val_30 = mem[__RuntimeMethodHiddenParam + 24 + 294];
                val_30 = __RuntimeMethodHiddenParam + 24 + 294;
            }
            
            val_32 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 8 + 294];
            val_32 = __RuntimeMethodHiddenParam + 24 + 192 + 8 + 294;
            if((val_32 & 1) == 0)
            {
                    val_32 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 8 + 294];
                val_32 = __RuntimeMethodHiddenParam + 24 + 192 + 8 + 294;
            }
            
            mem2[0] = new UnityEngine.GameObject();
            new UnityEngine.GameObject().name = "(singleton) " + System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 24 + 192 + 16})(System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 24 + 192 + 16}));
            UnityEngine.Object.DontDestroyOnLoad(target:  new UnityEngine.GameObject());
            object[] val_14 = new object[5];
            val_14[0] = "[Singleton] An instance of ";
            val_14[1] = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 24 + 192 + 16});
            val_27 = " is needed in the scene, so \'";
            val_14[2] = val_27;
            val_14[3] = new UnityEngine.GameObject();
            val_14[4] = "\' was created with DontDestroyOnLoad.";
            UnityEngine.Debug.Log(message:  +val_14);
            goto label_114;
            label_61:
            UnityEngine.Debug.LogError(message:  "[Singleton] Something went really wrong  - there should never be more than 1 singleton! Reopening the scene might fix it.");
            val_33 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 8 + 294];
            val_33 = __RuntimeMethodHiddenParam + 24 + 192 + 8 + 294;
            if((val_33 & 1) == 0)
            {
                    val_33 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 8 + 294];
                val_33 = __RuntimeMethodHiddenParam + 24 + 192 + 8 + 294;
            }
            
            val_34 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 8];
            val_34 = __RuntimeMethodHiddenParam + 24 + 192 + 8;
            if(((__RuntimeMethodHiddenParam + 24 + 192 + 8 + 294) & 1) != 0)
            {
                goto label_151;
            }
            
            goto label_151;
            label_74:
            val_35 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 8 + 294];
            val_35 = __RuntimeMethodHiddenParam + 24 + 192 + 8 + 294;
            if((val_35 & 1) == 0)
            {
                    val_35 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 8 + 294];
                val_35 = __RuntimeMethodHiddenParam + 24 + 192 + 8 + 294;
            }
            
            UnityEngine.Debug.Log(message:  "[Singleton] Using instance already created: "("[Singleton] Using instance already created: ") + __RuntimeMethodHiddenParam + 24 + 192 + 8 + 184.gameObject.name(__RuntimeMethodHiddenParam + 24 + 192 + 8 + 184.gameObject.name));
            label_114:
            val_36 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 8 + 294];
            val_36 = __RuntimeMethodHiddenParam + 24 + 192 + 8 + 294;
            if((val_36 & 1) == 0)
            {
                    val_36 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 8 + 294];
                val_36 = __RuntimeMethodHiddenParam + 24 + 192 + 8 + 294;
            }
            
            val_34 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 8];
            val_34 = __RuntimeMethodHiddenParam + 24 + 192 + 8;
            label_151:
            val_21 = 0;
            val_23 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 8 + 184];
            val_23 = __RuntimeMethodHiddenParam + 24 + 192 + 8 + 184;
            if(val_3 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  val_22);
            }
            
            if(334 == 334)
            {
                    return (GetSocialSdk.Core.MainThreadExecutor)val_23;
            }
            
            if(val_21 == 0)
            {
                    return (GetSocialSdk.Core.MainThreadExecutor)val_23;
            }
            
            return (GetSocialSdk.Core.MainThreadExecutor)val_23;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void OnDestroy()
        {
            var val_1 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 8 + 294];
            val_1 = __RuntimeMethodHiddenParam + 24 + 192 + 8 + 294;
            if((val_1 & 1) == 0)
            {
                    val_1 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 8 + 294];
                val_1 = __RuntimeMethodHiddenParam + 24 + 192 + 8 + 294;
            }
            
            mem2[0] = 1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected Singleton<T>()
        {
            if(this != null)
            {
                    return;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static Singleton<T>()
        {
            mem2[0] = new System.Object();
            mem2[0] = 0;
        }
    
    }

}
