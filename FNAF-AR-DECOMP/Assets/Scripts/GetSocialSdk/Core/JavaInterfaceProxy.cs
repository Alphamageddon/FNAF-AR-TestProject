using UnityEngine;

namespace GetSocialSdk.Core
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class JavaInterfaceProxy : AndroidJavaProxy
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static GetSocialSdk.Core.JavaInterfaceProxy _comparingWho;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal JavaInterfaceProxy(string javaInterface)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected static void ExecuteOnMainThread(System.Action action)
        {
            GetSocialSdk.Core.MainThreadExecutor.Queue(action:  action);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void HandleError(UnityEngine.AndroidJavaObject throwable, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            System.Action<GetSocialSdk.Core.GetSocialError> val_12;
            UnityEngine.AndroidJavaObject val_13;
            val_12 = onFailure;
            val_13 = throwable;
            JavaInterfaceProxy.<>c__DisplayClass3_0 val_1 = new JavaInterfaceProxy.<>c__DisplayClass3_0();
            if(val_1 == null)
            {
                goto label_1;
            }
            
            .onFailure = val_12;
            if(val_12 != null)
            {
                goto label_2;
            }
            
            return;
            label_1:
            mem[16] = val_12;
            val_12 = mem[16];
            if(val_12 == 0)
            {
                    return;
            }
            
            label_2:
            new JavaInterfaceProxy.<>c__DisplayClass3_1() = new System.Object();
            .CS$<>8__locals1 = val_1;
            .ex = GetSocialSdk.Core.JniUtils.ToGetSocialError(getSocialExceptionAJO:  val_13);
            new System.Action() = new System.Action(object:  new JavaInterfaceProxy.<>c__DisplayClass3_1(), method:  System.Void JavaInterfaceProxy.<>c__DisplayClass3_1::<HandleError>b__0());
            GetSocialSdk.Core.MainThreadExecutor.Queue(action:  new System.Action());
            val_12 = 76;
            if(val_13 != null)
            {
                    var val_12 = 0;
                val_12 = val_12 + 1;
                val_13.Dispose();
            }
            
            if(76 == 76)
            {
                    return;
            }
            
            if(0 == 0)
            {
                    return;
            }
            
            val_13 = ???;
            val_12 = ???;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void HandleValue<T>(T value, System.Action<T> onSuccess)
        {
            if((__RuntimeMethodHiddenParam + 48) == 0)
            {
                goto label_2;
            }
            
            mem2[0] = onSuccess;
            mem2[0] = value;
            if(onSuccess == null)
            {
                    return;
            }
            
            label_4:
            GetSocialSdk.Core.JavaInterfaceProxy.ExecuteOnMainThread(action:  new System.Action(object:  __RuntimeMethodHiddenParam + 48, method:  __RuntimeMethodHiddenParam + 48 + 16));
            return;
            label_2:
            mem[16] = onSuccess;
            mem[24] = value;
            if(mem[16] != 0)
            {
                goto label_4;
            }
        
        }
    
    }

}
