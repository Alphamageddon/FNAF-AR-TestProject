using UnityEngine;

namespace Microsoft.AppCenter.Unity
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AppCenterTask : CustomYieldInstruction
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Collections.Generic.List<System.Action<Microsoft.AppCenter.Unity.AppCenterTask>> _continuationActions;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected readonly object _lockObject;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <IsComplete>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsComplete { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override bool keepWaiting { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AppCenterTask(UnityEngine.AndroidJavaObject javaFuture)
        {
            this._continuationActions = new System.Collections.Generic.List<System.Action<Microsoft.AppCenter.Unity.AppCenterTask>>();
            this._lockObject = new System.Object();
            Microsoft.AppCenter.Unity.UnityAppCenterConsumer<UnityEngine.AndroidJavaObject> val_3 = new Microsoft.AppCenter.Unity.UnityAppCenterConsumer<UnityEngine.AndroidJavaObject>();
            val_3.CompletionCallback = new System.Action<UnityEngine.AndroidJavaObject>(object:  this, method:  System.Void Microsoft.AppCenter.Unity.AppCenterTask::<.ctor>b__0_0(UnityEngine.AndroidJavaObject t));
            object[] val_5 = new object[1];
            if(val_5 == null)
            {
                goto label_2;
            }
            
            if(val_3 != null)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(val_3 == null)
            {
                goto label_6;
            }
            
            label_3:
            label_6:
            val_5[0] = val_3;
            javaFuture.Call(methodName:  "thenAccept", args:  val_5);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_IsComplete()
        {
            return (bool)this.<IsComplete>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_IsComplete(bool value)
        {
            this.<IsComplete>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AppCenterTask()
        {
            this._continuationActions = new System.Collections.Generic.List<System.Action<Microsoft.AppCenter.Unity.AppCenterTask>>();
            this._lockObject = new System.Object();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ContinueWith(System.Action<Microsoft.AppCenter.Unity.AppCenterTask> continuationAction)
        {
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  this._lockObject, lockTaken: ref  val_1);
            this._continuationActions.Add(item:  continuationAction);
            this.InvokeContinuationActions();
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  this._lockObject);
            }
            
            if(47 == 47)
            {
                    return;
            }
            
            if(0 == 0)
            {
                    return;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void CompletionAction()
        {
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  this._lockObject, lockTaken: ref  val_1);
            this.<IsComplete>k__BackingField = true;
            this.InvokeContinuationActions();
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  this._lockObject);
            }
            
            if(42 == 42)
            {
                    return;
            }
            
            if(0 == 0)
            {
                    return;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void ThrowIfCompleted()
        {
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  this._lockObject, lockTaken: ref  val_1);
            if((this.<IsComplete>k__BackingField) == true)
            {
                goto label_1;
            }
            
            label_8:
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  this._lockObject);
            }
            
            if(48 == 48)
            {
                    return;
            }
            
            if(0 == 0)
            {
                    return;
            }
            
            return;
            label_1:
            new System.InvalidOperationException() = new System.InvalidOperationException(message:  "The task has already completed");
            if(0 != 1)
            {
                goto label_7;
            }
            
            goto label_8;
            label_7:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal static Microsoft.AppCenter.Unity.AppCenterTask FromCompleted()
        {
            Microsoft.AppCenter.Unity.AppCenterTask val_1 = new Microsoft.AppCenter.Unity.AppCenterTask();
            if(val_1 != null)
            {
                    return val_1;
            }
            
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void InvokeContinuationActions()
        {
            var val_5;
            var val_11;
            var val_15;
            var val_16;
            var val_17;
            System.Collections.Generic.List<System.Action<Microsoft.AppCenter.Unity.AppCenterTask>> val_18;
            var val_19;
            System.Collections.Generic.List<System.Action<Microsoft.AppCenter.Unity.AppCenterTask>> val_1 = new System.Collections.Generic.List<System.Action<Microsoft.AppCenter.Unity.AppCenterTask>>();
            bool val_2 = false;
            System.Threading.Monitor.Enter(obj:  this._lockObject, lockTaken: ref  val_2);
            if((this.<IsComplete>k__BackingField) == false)
            {
                goto label_1;
            }
            
            List.Enumerator<T> val_3 = this._continuationActions.GetEnumerator();
            label_6:
            if((117913584 & 1) == 0)
            {
                goto label_3;
            }
            
            GameUI.EmailUIDataHandler val_6 = val_5.emailUIDataHandler;
            if(val_6 == null)
            {
                goto label_6;
            }
            
            val_1.Add(item:  val_6);
            goto label_6;
            label_1:
            val_15 = 0;
            val_16 = 166;
            goto label_16;
            label_3:
            val_15 = 0;
            val_17 = 96;
            long val_7 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921526199597040});
            if( == 96)
            {
                
            }
            else
            {
                    if( != 0)
            {
                    val_15 = 0;
            }
            
            }
            
            val_18 = this._continuationActions;
            val_18.Clear();
            val_16 = 119;
            label_16:
            if(val_2 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  this._lockObject);
            }
            
            var val_8 = (119 == 0) ? 119 : 119;
            if(val_8 == 119)
            {
                goto label_20;
            }
            
            if(val_8 == 166)
            {
                    return;
            }
            
            if(val_15 != 0)
            {
                    val_15 = 0;
            }
            
            label_28:
            List.Enumerator<T> val_9 = val_1.GetEnumerator();
            val_18 = 1152921526199567744;
            label_26:
            if((117913584 & 1) == 0)
            {
                goto label_24;
            }
            
            val_11.emailUIDataHandler.Invoke(obj:  this);
            goto label_26;
            label_20:
            if(val_1 != null)
            {
                goto label_28;
            }
            
            goto label_28;
            label_24:
            val_19 = 166;
            long val_13 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921526199597040});
            if( == 0)
            {
                    return;
            }
            
            if(166 == 0)
            {
                    return;
            }
            
            if(166 == 166)
            {
                    return;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Runtime.CompilerServices.TaskAwaiter GetAwaiter()
        {
            .taskCompletionSource = new System.Threading.Tasks.TaskCompletionSource<System.Boolean>();
            this.ContinueWith(continuationAction:  new System.Action<Microsoft.AppCenter.Unity.AppCenterTask>(object:  new AppCenterTask.<>c__DisplayClass13_0(), method:  System.Void AppCenterTask.<>c__DisplayClass13_0::<GetAwaiter>b__0(Microsoft.AppCenter.Unity.AppCenterTask task)));
            System.Threading.Tasks.Task<TResult> val_4 = (AppCenterTask.<>c__DisplayClass13_0)[1152921526199802304].taskCompletionSource.Task;
            if(val_4 != null)
            {
                    return val_4.GetAwaiter();
            }
            
            return val_4.GetAwaiter();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override bool get_keepWaiting()
        {
            return (bool)((this.<IsComplete>k__BackingField) == false) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void <.ctor>b__0_0(UnityEngine.AndroidJavaObject t)
        {
            goto typeof(Microsoft.AppCenter.Unity.AppCenterTask).__il2cppRuntimeField_1A8;
        }
    
    }

}
