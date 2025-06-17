using UnityEngine;

namespace GetSocialSdk.Core
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal class RunnableProxy : JavaInterfaceProxy
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Action _runnable;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public RunnableProxy(System.Action runnable)
        {
            this._runnable = runnable;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void run()
        {
            GetSocialSdk.Core.MainThreadExecutor.Queue(action:  this._runnable);
        }
    
    }

}
