using UnityEngine;

namespace Master.Startup
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class CheckLocationPermissionStartupTask : IStartupTask
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.Startup.StartupSequencer _parent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.Restart.GameLifecycleHandler _gameLifecycleHandler;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Master.Startup.CheckLocationPermissionStartupTask Setup(Master.Restart.GameLifecycleHandler gameLifecycleHandler)
        {
            this._gameLifecycleHandler = gameLifecycleHandler;
            return (Master.Startup.CheckLocationPermissionStartupTask)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Execute(Master.Startup.StartupSequencer parent)
        {
            this._parent = parent;
            this._gameLifecycleHandler.LocationPermissionGovernor._success = new System.Action(object:  this, method:  System.Void Master.Startup.CheckLocationPermissionStartupTask::OnSuccess());
            this._gameLifecycleHandler.LocationPermissionGovernor.QueryPermissions();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this._parent = 0;
            this._gameLifecycleHandler = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int GetSize()
        {
            return 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string GetName()
        {
            return "CheckLocationPermission";
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int GetPartialProgress()
        {
            return 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnSuccess()
        {
            this._parent.CompleteTask(task:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CheckLocationPermissionStartupTask()
        {
        
        }
    
    }

}
