using UnityEngine;

namespace Mapbox.Platform
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface IAsyncRequest
    {
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool IsCompleted { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract Mapbox.Unity.Utilities.HttpRequestType RequestType { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool get_IsCompleted(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void Cancel(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract Mapbox.Unity.Utilities.HttpRequestType get_RequestType(); // 0
    
    }

}
