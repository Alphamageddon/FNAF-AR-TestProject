using UnityEngine;

namespace Utilities
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract class AsyncInterfaceAccess<T>
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<T> _ready;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected abstract bool IsReady { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected abstract T GetPublicInterface { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected abstract bool get_IsReady(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected abstract T get_GetPublicInterface(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetInterfaceAsync(System.Action<T> callback)
        {
            var val_3;
            System.Delegate val_1 = System.Delegate.Combine(a:  this, b:  callback);
            if(val_1 == null)
            {
                goto label_1;
            }
            
            val_3 = val_1;
            if(val_3 != null)
            {
                goto label_2;
            }
            
            label_1:
            val_3 = 0;
            label_2:
            mem[1152921523190771632] = val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void TryToDispatchPublicInterface()
        {
            if((this & 1) == 0)
            {
                    return;
            }
            
            mem[1152921523190891824] = 0;
            if(X21 == 0)
            {
                    return;
            }
            
            __RuntimeMethodHiddenParam = ???;
            goto __RuntimeMethodHiddenParam + 24 + 192 + 32;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected AsyncInterfaceAccess<T>()
        {
            if(this != null)
            {
                    return;
            }
        
        }
    
    }

}
