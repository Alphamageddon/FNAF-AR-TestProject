using UnityEngine;

namespace Master.Permissions
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class DefaultActivatePermissionsAdapter : IActivatePermissionsAdapter
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.Startup.IActivatePermissionsDelegate _taskCompleter;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(Master.Startup.IActivatePermissionsDelegate activatePermissionsDelegate, Master.EventExposer masterEvents)
        {
            this._taskCompleter = activatePermissionsDelegate;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Execute()
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            this._taskCompleter.CompleteTask();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this._taskCompleter = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DefaultActivatePermissionsAdapter()
        {
        
        }
    
    }

}
