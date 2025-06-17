using UnityEngine;

namespace SRDebugger.Services.Implementation
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class DebugCameraServiceImpl : IDebugCameraService
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Camera _debugCamera;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Camera Camera { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DebugCameraServiceImpl()
        {
            if(SRDebugger.Settings.Instance.UseDebugCamera == false)
            {
                    return;
            }
            
            UnityEngine.Camera val_4 = new UnityEngine.GameObject(name:  "SRDebugCamera").AddComponent<UnityEngine.Camera>();
            this._debugCamera = val_4;
            val_4.cullingMask = 1 << (SRDebugger.Settings.Instance.DebugLayer & 31);
            this._debugCamera.depth = SRDebugger.Settings.Instance.DebugCameraDepth;
            this._debugCamera.clearFlags = 3;
            this._debugCamera.transform.SetParent(p:  SRF.Hierarchy.Get(key:  "SRDebugger"));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Camera get_Camera()
        {
            return (UnityEngine.Camera)this._debugCamera;
        }
    
    }

}
