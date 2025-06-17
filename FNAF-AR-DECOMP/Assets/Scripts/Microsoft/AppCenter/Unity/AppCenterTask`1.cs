using UnityEngine;

namespace Microsoft.AppCenter.Unity
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AppCenterTask<TResult> : AppCenterTask
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Threading.ManualResetEvent _completionEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TResult _result;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Microsoft.AppCenter.Unity.UnityAppCenterConsumer<TResult> _consumer;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TResult Result { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TResult get_Result()
        {
            if(X20 != 0)
            {
                    return (bool)X20;
            }
            
            return (bool)X20;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AppCenterTask<TResult>(UnityEngine.AndroidJavaObject javaFuture)
        {
            mem[1152921526200500728] = new System.Threading.ManualResetEvent(initialState:  false);
            mem[1152921526200500744] = __RuntimeMethodHiddenParam + 24 + 192;
            object[] val_2 = new object[1];
            if(val_2 == null)
            {
                goto label_4;
            }
            
            if(__RuntimeMethodHiddenParam != 0)
            {
                goto label_5;
            }
            
            goto label_8;
            label_4:
            if(__RuntimeMethodHiddenParam == 0)
            {
                goto label_8;
            }
            
            label_5:
            label_8:
            val_2[0] = __RuntimeMethodHiddenParam;
            javaFuture.Call(methodName:  "thenAccept", args:  val_2);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal void SetResult(TResult result)
        {
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  X19, lockTaken: ref  val_1);
            this.ThrowIfCompleted();
            mem[1152921526200629136] = result;
            bool val_2 = __RuntimeMethodHiddenParam.Set();
            this.CompletionAction();
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  X19);
            }
            
            if(72 == 72)
            {
                    return;
            }
            
            if(0 == 0)
            {
                    return;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Runtime.CompilerServices.TaskAwaiter<TResult> GetAwaiter()
        {
            mem2[0] = __RuntimeMethodHiddenParam + 24 + 192 + 64;
            if((__RuntimeMethodHiddenParam + 24 + 192 + 48 + 16) == 0)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AppCenterTask<TResult>()
        {
            mem[1152921526200861320] = new System.Threading.ManualResetEvent(initialState:  false);
            mem[1152921526200861336] = __RuntimeMethodHiddenParam + 24 + 192;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ContinueWith(System.Action<Microsoft.AppCenter.Unity.AppCenterTask<TResult>> continuationAction)
        {
            if((__RuntimeMethodHiddenParam + 24 + 192 + 128) != 0)
            {
                    mem2[0] = continuationAction;
            }
            else
            {
                    mem[16] = continuationAction;
            }
            
            mem2[0] = this;
            this.ContinueWith(continuationAction:  new System.Action<Microsoft.AppCenter.Unity.AppCenterTask>(object:  __RuntimeMethodHiddenParam + 24 + 192 + 128, method:  __RuntimeMethodHiddenParam + 24 + 192 + 144));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal static Microsoft.AppCenter.Unity.AppCenterTask<TResult> FromCompleted(TResult result)
        {
            var val_2;
            var val_3;
            var val_4;
            var val_5;
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
            
            bool val_1 = result;
            return (Microsoft.AppCenter.Unity.AppCenterTask<TResult>)__RuntimeMethodHiddenParam + 24 + 192 + 152;
        }
    
    }

}
