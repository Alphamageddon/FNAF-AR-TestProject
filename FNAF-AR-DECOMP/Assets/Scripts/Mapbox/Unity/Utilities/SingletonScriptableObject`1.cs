using UnityEngine;

namespace Mapbox.Unity.Utilities
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract class SingletonScriptableObject<T> : ScriptableObject
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static T _instance;
        
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
            var val_7;
            var val_8;
            val_2 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
            val_2 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
            if((val_2 & 1) == 0)
            {
                    val_2 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
                val_2 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  __RuntimeMethodHiddenParam + 24 + 192 + 184)) != true)
            {
                    val_3 = mem[__RuntimeMethodHiddenParam + 24 + 294];
                val_3 = __RuntimeMethodHiddenParam + 24 + 294;
                val_4 = __RuntimeMethodHiddenParam + 24;
                if((val_3 & 1) == 0)
            {
                    val_4 = mem[__RuntimeMethodHiddenParam + 24];
                val_4 = __RuntimeMethodHiddenParam + 24;
                val_3 = mem[__RuntimeMethodHiddenParam + 24 + 294];
                val_3 = __RuntimeMethodHiddenParam + 24 + 294;
            }
            
                val_5 = mem[__RuntimeMethodHiddenParam + 24 + 294];
                val_5 = __RuntimeMethodHiddenParam + 24 + 294;
                val_6 = __RuntimeMethodHiddenParam + 24;
                if((val_5 & 1) == 0)
            {
                    val_6 = mem[__RuntimeMethodHiddenParam + 24];
                val_6 = __RuntimeMethodHiddenParam + 24;
                val_5 = mem[__RuntimeMethodHiddenParam + 24 + 294];
                val_5 = __RuntimeMethodHiddenParam + 24 + 294;
            }
            
                val_7 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
                val_7 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
                if((val_7 & 1) == 0)
            {
                    val_7 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
                val_7 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
            }
            
                mem2[0] = __RuntimeMethodHiddenParam + 24 + 192 + 16;
            }
            
            val_8 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
            val_8 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
            if((val_8 & 1) == 0)
            {
                    val_8 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
                val_8 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
            }
            
            if(((__RuntimeMethodHiddenParam + 24 + 192 + 294) & 1) != 0)
            {
                    return (object)__RuntimeMethodHiddenParam + 24 + 192 + 184;
            }
            
            return (object)__RuntimeMethodHiddenParam + 24 + 192 + 184;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected SingletonScriptableObject<T>()
        {
            if(this != null)
            {
                    return;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static SingletonScriptableObject<T>()
        {
        
        }
    
    }

}
