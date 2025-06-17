using UnityEngine;

namespace PlayFab.Internal
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SingletonMonoBehaviour<T> : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static T _instance;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected bool initialized;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static T instance { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static T get_instance()
        {
            var val_1;
            var val_2;
            val_1 = mem[__RuntimeMethodHiddenParam + 24 + 294];
            val_1 = __RuntimeMethodHiddenParam + 24 + 294;
            val_2 = __RuntimeMethodHiddenParam + 24;
            if((val_1 & 1) == 0)
            {
                    val_2 = mem[__RuntimeMethodHiddenParam + 24];
                val_2 = __RuntimeMethodHiddenParam + 24;
                val_1 = mem[__RuntimeMethodHiddenParam + 24 + 294];
                val_1 = __RuntimeMethodHiddenParam + 24 + 294;
            }
            
            if(((__RuntimeMethodHiddenParam + 24 + 192 + 8 + 294) & 1) != 0)
            {
                    return (PlayFab.Internal.PlayFabHttp)__RuntimeMethodHiddenParam + 24 + 192 + 8 + 184;
            }
            
            return (PlayFab.Internal.PlayFabHttp)__RuntimeMethodHiddenParam + 24 + 192 + 8 + 184;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void CreateInstance()
        {
            var val_5;
            var val_6;
            var val_7;
            var val_8;
            UnityEngine.Object val_9;
            var val_10;
            var val_11;
            val_5 = __RuntimeMethodHiddenParam;
            val_6 = 1152921504851574784;
            if((__RuntimeMethodHiddenParam + 24 + 192 + 8 + 184) != 0)
            {
                    return;
            }
            
            val_7 = mem[__RuntimeMethodHiddenParam + 24 + 294];
            val_7 = __RuntimeMethodHiddenParam + 24 + 294;
            val_8 = __RuntimeMethodHiddenParam + 24;
            if((val_7 & 1) == 0)
            {
                    val_8 = mem[__RuntimeMethodHiddenParam + 24];
                val_8 = __RuntimeMethodHiddenParam + 24;
                val_7 = mem[__RuntimeMethodHiddenParam + 24 + 294];
                val_7 = __RuntimeMethodHiddenParam + 24 + 294;
            }
            
            val_6 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 8];
            val_6 = __RuntimeMethodHiddenParam + 24 + 192 + 8;
            mem2[0] = __RuntimeMethodHiddenParam + 24 + 192 + 24;
            val_9 = 0;
            if((__RuntimeMethodHiddenParam + 24 + 192 + 8 + 184) == val_9)
            {
                    val_10 = mem[__RuntimeMethodHiddenParam + 24 + 294];
                val_10 = __RuntimeMethodHiddenParam + 24 + 294;
                val_11 = __RuntimeMethodHiddenParam + 24;
                if((val_10 & 1) == 0)
            {
                    val_11 = mem[__RuntimeMethodHiddenParam + 24];
                val_11 = __RuntimeMethodHiddenParam + 24;
                val_10 = mem[__RuntimeMethodHiddenParam + 24 + 294];
                val_10 = __RuntimeMethodHiddenParam + 24 + 294;
            }
            
                val_9 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 40];
                val_9 = __RuntimeMethodHiddenParam + 24 + 192 + 40;
                val_6 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 8];
                val_6 = __RuntimeMethodHiddenParam + 24 + 192 + 8;
                mem2[0] = new UnityEngine.GameObject(name:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 24 + 192 + 32}));
            }
            
            if((__RuntimeMethodHiddenParam + 24 + 192 + 8 + 184 + 24) != 0)
            {
                    return;
            }
            
            val_5 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 8 + 184];
            val_5 = __RuntimeMethodHiddenParam + 24 + 192 + 8 + 184;
            mem2[0] = 1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual void Awake()
        {
            if(UnityEngine.Application.isPlaying != false)
            {
                    UnityEngine.Object.DontDestroyOnLoad(target:  this);
            }
            
            if((__RuntimeMethodHiddenParam + 24 + 192 + 8 + 184) == 0)
            {
                    return;
            }
            
            UnityEngine.Object.DestroyImmediate(obj:  this.gameObject);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void Initialize()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SingletonMonoBehaviour<T>()
        {
            if(this != null)
            {
                    return;
            }
        
        }
    
    }

}
