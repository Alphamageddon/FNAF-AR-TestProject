using UnityEngine;

namespace Microsoft.AppCenter.Unity
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class UnityAppCenterConsumer<T> : AndroidJavaProxy
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<T> <CompletionCallback>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal System.Action<T> CompletionCallback { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal System.Action<T> get_CompletionCallback()
        {
            return (System.Action<T>)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal void set_CompletionCallback(System.Action<T> value)
        {
            mem[1152921526201798272] = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal UnityAppCenterConsumer<T>()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void accept(T t)
        {
            bool val_7 = t;
            if(this == null)
            {
                    return;
            }
            
            bool val_1 = val_7;
            val_7 = ???;
            goto __RuntimeMethodHiddenParam + 24 + 192 + 8;
        }
    
    }

}
