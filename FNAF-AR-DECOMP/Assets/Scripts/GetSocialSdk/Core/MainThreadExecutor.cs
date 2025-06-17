using UnityEngine;

namespace GetSocialSdk.Core
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal class MainThreadExecutor : Singleton<GetSocialSdk.Core.MainThreadExecutor>
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly object _queueLock;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Collections.Generic.List<System.Action> _queuedActions;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Collections.Generic.List<System.Action> _executingActions;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void Init()
        {
            GetSocialSdk.Core.Singleton<GetSocialSdk.Core.MainThreadExecutor>.LoadInstance();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal static void Queue(System.Action action)
        {
            object val_4;
            if(action != null)
            {
                    GetSocialSdk.Core.MainThreadExecutor val_1 = GetSocialSdk.Core.Singleton<GetSocialSdk.Core.MainThreadExecutor>.Instance;
                val_4 = val_1._queueLock;
                bool val_2 = false;
                System.Threading.Monitor.Enter(obj:  val_4, lockTaken: ref  val_2);
                GetSocialSdk.Core.MainThreadExecutor val_3 = GetSocialSdk.Core.Singleton<GetSocialSdk.Core.MainThreadExecutor>.Instance;
                val_3._queuedActions.Add(item:  action);
                if(val_2 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  val_4);
            }
            
                if(63 == 63)
            {
                    return;
            }
            
                if(0 == 0)
            {
                    return;
            }
            
                return;
            }
            
            UnityEngine.Debug.LogWarning(message:  "Trying to queue null action");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            this.MoveQueuedActionsToExecuting();
            goto label_1;
            label_6:
            this._executingActions.RemoveAt(index:  0);
            this._executingActions.Item[0].Invoke();
            label_1:
            if(this._executingActions.Count > 0)
            {
                goto label_6;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void MoveQueuedActionsToExecuting()
        {
            var val_4;
            var val_5;
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  this._queueLock, lockTaken: ref  val_1);
            label_6:
            if(this._queuedActions.Count < 1)
            {
                goto label_2;
            }
            
            this._executingActions.Add(item:  this._queuedActions.Item[0]);
            this._queuedActions.RemoveAt(index:  0);
            goto label_6;
            label_2:
            val_4 = 0;
            val_5 = 82;
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  this._queueLock);
            }
            
            if( == 82)
            {
                    return;
            }
            
            if( == 0)
            {
                    return;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MainThreadExecutor()
        {
            this._queueLock = new System.Object();
            this._queuedActions = new System.Collections.Generic.List<System.Action>();
            this._executingActions = new System.Collections.Generic.List<System.Action>();
        }
    
    }

}
