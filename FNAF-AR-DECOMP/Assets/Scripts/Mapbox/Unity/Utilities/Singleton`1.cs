using UnityEngine;

namespace Mapbox.Unity.Utilities
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Singleton<T>
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static T sm_Instance;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static T Instance { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static T get_Instance()
        {
            var val_2;
            var val_3;
            var val_4;
            var val_5;
            var val_6;
            val_2 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
            val_2 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
            if((val_2 & 1) == 0)
            {
                    val_2 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
                val_2 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
            }
            
            if((__RuntimeMethodHiddenParam + 24 + 192 + 184) == 0)
            {
                    val_3 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
                val_3 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
                if((val_3 & 1) == 0)
            {
                    val_3 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
                val_3 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
            }
            
                val_4 = mem[__RuntimeMethodHiddenParam + 24 + 294];
                val_4 = __RuntimeMethodHiddenParam + 24 + 294;
                val_5 = __RuntimeMethodHiddenParam + 24;
                if((val_4 & 1) == 0)
            {
                    val_5 = mem[__RuntimeMethodHiddenParam + 24];
                val_5 = __RuntimeMethodHiddenParam + 24;
                val_4 = mem[__RuntimeMethodHiddenParam + 24 + 294];
                val_4 = __RuntimeMethodHiddenParam + 24 + 294;
            }
            
            }
            
            val_6 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
            val_6 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
            if((val_6 & 1) == 0)
            {
                    val_6 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
                val_6 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
            }
            
            if(((__RuntimeMethodHiddenParam + 24 + 192 + 294) & 1) != 0)
            {
                    return (Mapbox.Unity.Utilities.Runnable)__RuntimeMethodHiddenParam + 24 + 192 + 184;
            }
            
            return (Mapbox.Unity.Utilities.Runnable)__RuntimeMethodHiddenParam + 24 + 192 + 184;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void CreateInstance()
        {
            UnityEngine.Object val_18;
            var val_19;
            var val_20;
            UnityEngine.Object val_21;
            var val_22;
            var val_23;
            var val_24;
            var val_25;
            var val_26;
            var val_27;
            var val_28;
            var val_29;
            System.Type val_2 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 24 + 192 + 24});
            if(((System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())) & 1) == 0)
            {
                goto label_6;
            }
            
            string val_4 = "_" + System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 24 + 192 + 24})(System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 24 + 192 + 24}));
            val_18 = UnityEngine.GameObject.Find(name:  val_4);
            if(val_18 == 0)
            {
                    UnityEngine.GameObject val_7 = null;
                val_18 = val_7;
                val_7 = new UnityEngine.GameObject(name:  val_4);
            }
            
            if(val_18 == null)
            {
                goto label_13;
            }
            
            val_7.hideFlags = 61;
            goto label_14;
            label_6:
            object val_9 = System.Activator.CreateInstance(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 24 + 192 + 24}));
            val_19 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
            val_19 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
            if((val_19 & 1) == 0)
            {
                    val_19 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
                val_19 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
            }
            
            val_20 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 184];
            val_20 = __RuntimeMethodHiddenParam + 24 + 192 + 184;
            val_21 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 8];
            val_21 = __RuntimeMethodHiddenParam + 24 + 192 + 8;
            if(val_9 == null)
            {
                goto label_69;
            }
            
            val_22 = val_9;
            if(val_22 != null)
            {
                goto label_70;
            }
            
            val_23 = 0;
            goto label_33;
            label_13:
            val_7.hideFlags = 61;
            label_14:
            val_24 = mem[__RuntimeMethodHiddenParam + 24 + 294];
            val_24 = __RuntimeMethodHiddenParam + 24 + 294;
            val_25 = __RuntimeMethodHiddenParam + 24;
            if((val_24 & 1) == 0)
            {
                    val_25 = mem[__RuntimeMethodHiddenParam + 24];
                val_25 = __RuntimeMethodHiddenParam + 24;
                val_24 = mem[__RuntimeMethodHiddenParam + 24 + 294];
                val_24 = __RuntimeMethodHiddenParam + 24 + 294;
            }
            
            val_26 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
            val_26 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
            if((val_26 & 1) == 0)
            {
                    val_26 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
                val_26 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
            }
            
            mem2[0] = val_18;
            val_21 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 184];
            val_21 = __RuntimeMethodHiddenParam + 24 + 192 + 184;
            if(val_21 != 0)
            {
                goto label_50;
            }
            
            UnityEngine.Component val_13 = val_7.AddComponent(componentType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 24 + 192 + 24}));
            val_27 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
            val_27 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
            if((val_27 & 1) == 0)
            {
                    val_27 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
                val_27 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
            }
            
            val_20 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 184];
            val_20 = __RuntimeMethodHiddenParam + 24 + 192 + 184;
            val_21 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 8];
            val_21 = __RuntimeMethodHiddenParam + 24 + 192 + 8;
            if(val_13 == null)
            {
                goto label_69;
            }
            
            val_22 = val_13;
            if(val_22 != null)
            {
                goto label_70;
            }
            
            val_23 = 0;
            label_33:
            label_69:
            val_22 = 0;
            label_70:
            mem2[0] = val_22;
            label_50:
            val_28 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
            val_28 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
            if((val_28 & 1) == 0)
            {
                    val_28 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
                val_28 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
            }
            
            if((__RuntimeMethodHiddenParam + 24 + 192 + 184) != 0)
            {
                    return;
            }
            
            val_29 = new System.Exception(message:  "Failed to create instance " + System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 24 + 192 + 24})(System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 24 + 192 + 24})));
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
        
        }
    
    }

}
