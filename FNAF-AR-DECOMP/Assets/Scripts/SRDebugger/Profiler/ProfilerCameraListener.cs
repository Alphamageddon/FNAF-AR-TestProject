using UnityEngine;

namespace SRDebugger.Profiler
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ProfilerCameraListener : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Camera _camera;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Diagnostics.Stopwatch _stopwatch;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Action<SRDebugger.Profiler.ProfilerCameraListener, double> RenderDurationCallback;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected System.Diagnostics.Stopwatch Stopwatch { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Camera Camera { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected System.Diagnostics.Stopwatch get_Stopwatch()
        {
            System.Diagnostics.Stopwatch val_2 = this._stopwatch;
            if(val_2 != null)
            {
                    return val_2;
            }
            
            System.Diagnostics.Stopwatch val_1 = null;
            val_2 = val_1;
            val_1 = new System.Diagnostics.Stopwatch();
            this._stopwatch = val_2;
            return val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Camera get_Camera()
        {
            UnityEngine.Camera val_3;
            if(this._camera == 0)
            {
                    this._camera = this.GetComponent<UnityEngine.Camera>();
                return val_3;
            }
            
            val_3 = this._camera;
            return val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnPreCull()
        {
            if(this.isActiveAndEnabled == false)
            {
                    return;
            }
            
            this.Stopwatch.Start();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnPostRender()
        {
            if(this.isActiveAndEnabled == false)
            {
                    return;
            }
            
            System.TimeSpan val_2 = this._stopwatch.Elapsed;
            this.Stopwatch.Stop();
            this.Stopwatch.Reset();
            if(this.RenderDurationCallback != null)
            {
                    this.RenderDurationCallback.Invoke(arg1:  this, arg2:  val_2._ticks.TotalSeconds);
                return;
            }
            
            UnityEngine.Object.Destroy(obj:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProfilerCameraListener()
        {
        
        }
    
    }

}
