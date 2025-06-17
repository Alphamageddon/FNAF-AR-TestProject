using UnityEngine;

namespace PlayFab.Public
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface IScreenTimeTracker
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void OnEnable(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void OnDisable(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void OnDestroy(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void OnApplicationQuit(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void OnApplicationFocus(bool isFocused); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void ClientSessionStart(string entityId, string entityType, string playFabUserId); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void Send(); // 0
    
    }

}
