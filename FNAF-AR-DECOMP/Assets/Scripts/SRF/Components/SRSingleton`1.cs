using UnityEngine;

namespace SRF.Components
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract class SRSingleton<T> : SRMonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static T _instance;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static T Instance { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool HasInstance { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static T get_Instance()
        {
            if((__RuntimeMethodHiddenParam + 24 + 192 + 184) != 0)
            {
                    if(((__RuntimeMethodHiddenParam + 24 + 192 + 294) & 1) != 0)
            {
                    return (object)__RuntimeMethodHiddenParam + 24 + 192 + 184;
            }
            
                return (object)__RuntimeMethodHiddenParam + 24 + 192 + 184;
            }
            
            System.Type val_3 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 24 + 192 + 16});
            System.InvalidOperationException val_5 = new System.InvalidOperationException(message:  SRF.SRFStringExtensions.Fmt(formatString:  "No instance of {0} present in scene", args:  new object[1]));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool get_HasInstance()
        {
            return UnityEngine.Object.op_Inequality(x:  __RuntimeMethodHiddenParam + 24 + 192 + 184, y:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Register()
        {
            UnityEngine.Object val_8;
            var val_9;
            var val_10;
            var val_11;
            val_8 = this;
            if((__RuntimeMethodHiddenParam + 24 + 192 + 184) == 0)
            {
                goto label_4;
            }
            
            object[] val_2 = new object[1];
            val_2[0] = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 24 + 192 + 16});
            UnityEngine.Debug.LogWarning(message:  SRF.SRFStringExtensions.Fmt(formatString:  "More than one singleton object of type {0} exists.", args:  val_2));
            T[] val_5 = this.GetComponents<UnityEngine.Component>();
            if(val_5.Length != 2)
            {
                goto label_16;
            }
            
            val_8 = this.gameObject;
            val_9 = null;
            goto label_20;
            label_4:
            val_10 = mem[__RuntimeMethodHiddenParam + 24 + 192];
            val_10 = __RuntimeMethodHiddenParam + 24 + 192;
            if(((__RuntimeMethodHiddenParam + 24 + 192 + 294) & 1) == 0)
            {
                    val_10 = mem[__RuntimeMethodHiddenParam + 24 + 192];
                val_10 = __RuntimeMethodHiddenParam + 24 + 192;
            }
            
            if(this == null)
            {
                goto label_23;
            }
            
            val_11 = val_8;
            if(this != null)
            {
                goto label_24;
            }
            
            label_23:
            val_11 = 0;
            label_24:
            mem2[0] = val_11;
            return;
            label_16:
            val_9 = null;
            label_20:
            UnityEngine.Object.Destroy(obj:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void Awake()
        {
            if(this == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void OnEnable()
        {
            if((__RuntimeMethodHiddenParam + 24 + 192 + 184) != 0)
            {
                    return;
            }
            
            this = ???;
            goto __RuntimeMethodHiddenParam + 24 + 192 + 24;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnApplicationQuit()
        {
            mem2[0] = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected SRSingleton<T>()
        {
            if(this != null)
            {
                    return;
            }
        
        }
    
    }

}
