using UnityEngine;

namespace SRF.Components
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract class SRAutoSingleton<T> : SRMonoBehaviour
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
            var val_6;
            var val_7;
            if(((__RuntimeMethodHiddenParam + 24 + 192 + 184) == 0) && (UnityEngine.Application.isPlaying != false))
            {
                    UnityEngine.GameObject val_5 = new UnityEngine.GameObject(name:  "_" + System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 24 + 192 + 16})(System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 24 + 192 + 16})));
                val_6 = mem[__RuntimeMethodHiddenParam + 24 + 294];
                val_6 = __RuntimeMethodHiddenParam + 24 + 294;
                val_7 = __RuntimeMethodHiddenParam + 24;
                if((val_6 & 1) == 0)
            {
                    val_7 = mem[__RuntimeMethodHiddenParam + 24];
                val_7 = __RuntimeMethodHiddenParam + 24;
                val_6 = mem[__RuntimeMethodHiddenParam + 24 + 294];
                val_6 = __RuntimeMethodHiddenParam + 24 + 294;
            }
            
            }
            
            if(((__RuntimeMethodHiddenParam + 24 + 192 + 294) & 1) != 0)
            {
                    return (SRF.Service.SRServiceManager)__RuntimeMethodHiddenParam + 24 + 192 + 184;
            }
            
            return (SRF.Service.SRServiceManager)__RuntimeMethodHiddenParam + 24 + 192 + 184;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool get_HasInstance()
        {
            return UnityEngine.Object.op_Inequality(x:  __RuntimeMethodHiddenParam + 24 + 192 + 184, y:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void Awake()
        {
            var val_6;
            var val_7;
            if((__RuntimeMethodHiddenParam + 24 + 192 + 184) != 0)
            {
                    object[] val_2 = new object[1];
                val_2[0] = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 24 + 192 + 16});
                UnityEngine.Debug.LogWarning(message:  SRF.SRFStringExtensions.Fmt(formatString:  "More than one singleton object of type {0} exists.", args:  val_2));
                return;
            }
            
            val_6 = mem[__RuntimeMethodHiddenParam + 24 + 192];
            val_6 = __RuntimeMethodHiddenParam + 24 + 192;
            if(((__RuntimeMethodHiddenParam + 24 + 192 + 294) & 1) == 0)
            {
                    val_6 = mem[__RuntimeMethodHiddenParam + 24 + 192];
                val_6 = __RuntimeMethodHiddenParam + 24 + 192;
            }
            
            if(this == null)
            {
                goto label_16;
            }
            
            val_7 = this;
            if(this != null)
            {
                goto label_17;
            }
            
            label_16:
            val_7 = 0;
            label_17:
            mem2[0] = val_7;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnApplicationQuit()
        {
            mem2[0] = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected SRAutoSingleton<T>()
        {
            if(this != null)
            {
                    return;
            }
        
        }
    
    }

}
