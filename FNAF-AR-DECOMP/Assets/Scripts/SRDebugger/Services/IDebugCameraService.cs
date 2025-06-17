using UnityEngine;

namespace SRDebugger.Services
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface IDebugCameraService
    {
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract UnityEngine.Camera Camera { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract UnityEngine.Camera get_Camera(); // 0
    
    }

}
