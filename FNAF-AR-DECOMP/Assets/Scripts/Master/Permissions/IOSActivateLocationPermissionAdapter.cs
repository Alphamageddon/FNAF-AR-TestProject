using UnityEngine;

namespace Master.Permissions
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class IOSActivateLocationPermissionAdapter : IActivatePermissionsAdapter
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _masterEvents;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.Startup.IActivatePermissionsDelegate _activatePermissionsDelegate;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool shouldDelayComplete;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const float DELAY_TIME = 0.5;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _startTime;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(Master.Startup.IActivatePermissionsDelegate activatePermissionsDelegate, Master.EventExposer masterEvents)
        {
            this._masterEvents = masterEvents;
            this._activatePermissionsDelegate = activatePermissionsDelegate;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Execute()
        {
            this._startTime = UnityEngine.Time.time;
            this._masterEvents.add_HandleApplicationFocus(value:  new System.Action<System.Boolean>(object:  this, method:  System.Void Master.Permissions.IOSActivateLocationPermissionAdapter::MasterEventsOnHandleApplicationFocus(bool isFocus)));
            this._masterEvents.OnReadyToActivateLocationServices();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update()
        {
            float val_1 = UnityEngine.Time.time;
            val_1 = val_1 - this._startTime;
            if(val_1 <= 0.5f)
            {
                    return;
            }
            
            if(this.shouldDelayComplete != false)
            {
                    return;
            }
            
            this._masterEvents.remove_HandleApplicationFocus(value:  new System.Action<System.Boolean>(object:  this, method:  System.Void Master.Permissions.IOSActivateLocationPermissionAdapter::MasterEventsOnHandleApplicationFocus(bool isFocus)));
            var val_4 = 0;
            val_4 = val_4 + 1;
            this._activatePermissionsDelegate.CompleteTask();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void MasterEventsOnHandleApplicationFocus(bool isFocus)
        {
            if(isFocus != false)
            {
                    this._masterEvents.remove_HandleApplicationFocus(value:  new System.Action<System.Boolean>(object:  this, method:  System.Void Master.Permissions.IOSActivateLocationPermissionAdapter::MasterEventsOnHandleApplicationFocus(bool isFocus)));
                var val_3 = 0;
                val_3 = val_3 + 1;
            }
            else
            {
                    this.shouldDelayComplete = true;
                return;
            }
            
            this._activatePermissionsDelegate.CompleteTask();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this._masterEvents = 0;
            this._activatePermissionsDelegate = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public IOSActivateLocationPermissionAdapter()
        {
        
        }
    
    }

}
