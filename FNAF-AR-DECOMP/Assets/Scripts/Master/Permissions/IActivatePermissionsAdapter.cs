using UnityEngine;

namespace Master.Permissions
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface IActivatePermissionsAdapter
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void Setup(Master.Startup.IActivatePermissionsDelegate activatePermissionsDelegate, Master.EventExposer masterEvents); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void Execute(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void Update(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void Teardown(); // 0
    
    }

}
