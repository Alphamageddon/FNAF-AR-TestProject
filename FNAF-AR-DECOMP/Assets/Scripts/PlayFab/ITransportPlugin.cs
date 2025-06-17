using UnityEngine;

namespace PlayFab
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface ITransportPlugin : IPlayFabPlugin
    {
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool IsInitialized { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool get_IsInitialized(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void Initialize(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void Update(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void OnDestroy(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void SimpleGetCall(string fullUrl, System.Action<byte[]> successCallback, System.Action<string> errorCallback); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void SimplePutCall(string fullUrl, byte[] payload, System.Action<byte[]> successCallback, System.Action<string> errorCallback); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void SimplePostCall(string fullUrl, byte[] payload, System.Action<byte[]> successCallback, System.Action<string> errorCallback); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void MakeApiCall(object reqContainer); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract int GetPendingMessages(); // 0
    
    }

}
