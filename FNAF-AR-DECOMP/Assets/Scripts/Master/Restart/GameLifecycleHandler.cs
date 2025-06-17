using UnityEngine;

namespace Master.Restart
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class GameLifecycleHandler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Master.Restart.GameLifecycleHandler Instance;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Master.Restart.ShutdownHandler ShutdownHandler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Master.Restart.RestartHandler RestartHandler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Master.SceneLookupTableAccess _lookupTable;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Master.Permissions.LocationPermissionGovernor LocationPermissionGovernor;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void EnsureSingleton(Master.Restart.GameLifecycleHandler instance)
        {
            Master.Restart.GameLifecycleHandler.Instance = instance;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void HandleUpdateAfterPause(bool paused)
        {
            if(this.LocationPermissionGovernor.listenForPause == false)
            {
                    return;
            }
            
            if(paused == true)
            {
                    return;
            }
            
            this.LocationPermissionGovernor.listenForPause = false;
            this.LocationPermissionGovernor.QueryPermissions();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(Master.Restart.ShutdownParameters shutdownData, Master.Restart.RestartParameters restartData, Master.EventExposer masterEvents, Master.SceneLookupTableAccess lookupTable)
        {
            Master.Restart.GameLifecycleHandler.Instance = this;
            this.ShutdownHandler = new Master.Restart.ShutdownHandler();
            ._data = shutdownData;
            this.RestartHandler = new Master.Restart.RestartHandler();
            ._data = restartData;
            this._lookupTable = lookupTable;
            Master.Permissions.LocationPermissionGovernor val_3 = new Master.Permissions.LocationPermissionGovernor();
            this.LocationPermissionGovernor = val_3;
            val_3.Setup(masterEvents:  masterEvents);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            if(this.LocationPermissionGovernor != null)
            {
                    this.LocationPermissionGovernor.Teardown();
            }
            
            this.LocationPermissionGovernor = 0;
            if(this.RestartHandler != null)
            {
                    this.RestartHandler._data = 0;
            }
            
            this.RestartHandler = 0;
            if(this.ShutdownHandler != null)
            {
                    this.ShutdownHandler._data = 0;
            }
            
            this.ShutdownHandler = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameLifecycleHandler()
        {
        
        }
    
    }

}
