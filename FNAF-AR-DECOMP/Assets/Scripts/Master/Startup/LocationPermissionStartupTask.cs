using UnityEngine;

namespace Master.Startup
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class LocationPermissionStartupTask : IStartupTask, IActivatePermissionsDelegate
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.Startup.StartupSequencer _parent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.Permissions.IActivatePermissionsAdapter _adapter;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Master.Startup.LocationPermissionStartupTask Setup(Master.EventExposer masterEvents)
        {
            Master.Permissions.AndroidActivateLocationPermissionAdapter val_1 = new Master.Permissions.AndroidActivateLocationPermissionAdapter();
            this._adapter = val_1;
            var val_3 = 0;
            val_3 = val_3 + 1;
            val_1.Setup(activatePermissionsDelegate:  this, masterEvents:  masterEvents);
            return (Master.Startup.LocationPermissionStartupTask)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Execute(Master.Startup.StartupSequencer parent)
        {
            this._parent = parent;
            parent.add_UpdateTime(value:  new System.Action<System.Single>(object:  this, method:  System.Void Master.Startup.LocationPermissionStartupTask::ParentOnUpdateTime(float obj)));
            var val_3 = 0;
            val_3 = val_3 + 1;
            this._adapter.Execute();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ParentOnUpdateTime(float obj)
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            this._adapter.Update();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this._parent = 0;
            var val_2 = 0;
            val_2 = val_2 + 1;
            this._adapter.Teardown();
            this._adapter = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int GetSize()
        {
            return 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string GetName()
        {
            return "ActivateLocationPermission";
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int GetPartialProgress()
        {
            return 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void CompleteTask()
        {
            this._parent.remove_UpdateTime(value:  new System.Action<System.Single>(object:  this, method:  System.Void Master.Startup.LocationPermissionStartupTask::ParentOnUpdateTime(float obj)));
            this._parent.CompleteTask(task:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SubscribeUpdateTimeEvent(System.Action<float> action)
        {
            this._parent.add_UpdateTime(value:  action);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void UnsubscribeUpdateTimeEvent(System.Action<float> action)
        {
            this._parent.remove_UpdateTime(value:  action);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LocationPermissionStartupTask()
        {
        
        }
    
    }

}
