using UnityEngine;

namespace Master.Permissions
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface IQueryPermissionsAdapter
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void Setup(Master.EventExposer masterEvents); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void Teardown(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool HasCameraPermissions(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool HasGPSPermissions(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void OpenSettings(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void OpenLocationSettings(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void Close(); // 0
    
    }

}
