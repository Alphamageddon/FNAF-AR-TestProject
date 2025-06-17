using UnityEngine;

namespace SRDebugger.Profiler
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ProfilerServiceImpl : SRServiceBase<SRDebugger.Services.IProfilerService>, IProfilerService
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const int FrameBufferSize = 400;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly SRF.SRList<SRDebugger.Profiler.ProfilerCameraListener> _cameraListeners;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly SRDebugger.CircularBuffer<SRDebugger.Services.ProfilerFrame> _frameBuffer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Camera[] _cameraCache;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SRDebugger.Profiler.ProfilerLateUpdateListener _lateUpdateListener;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private double _renderDuration;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _reportedCameras;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Diagnostics.Stopwatch _stopwatch;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private double _updateDuration;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private double _updateToRenderDuration;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float <AverageFrameTime>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float <LastFrameTime>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float AverageFrameTime { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float LastFrameTime { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRDebugger.CircularBuffer<SRDebugger.Services.ProfilerFrame> FrameBuffer { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_AverageFrameTime()
        {
            return (float)this.<AverageFrameTime>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_AverageFrameTime(float value)
        {
            this.<AverageFrameTime>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_LastFrameTime()
        {
            return (float)this.<LastFrameTime>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_LastFrameTime(float value)
        {
            this.<LastFrameTime>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRDebugger.CircularBuffer<SRDebugger.Services.ProfilerFrame> get_FrameBuffer()
        {
            return (SRDebugger.CircularBuffer<SRDebugger.Services.ProfilerFrame>)this._frameBuffer;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void PushFrame(double totalTime, double updateTime, double renderTime)
        {
            double val_1 = totalTime;
            totalTime = val_1 - updateTime;
            val_1 = totalTime - renderTime;
            this._frameBuffer.PushBack(item:  new SRDebugger.Services.ProfilerFrame());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void Awake()
        {
            this.Awake();
            this._lateUpdateListener = this.gameObject.AddComponent<SRDebugger.Profiler.ProfilerLateUpdateListener>();
            val_2.OnLateUpdate = new System.Action(object:  this, method:  System.Void SRDebugger.Profiler.ProfilerServiceImpl::OnLateUpdate());
            this.CachedGameObject.hideFlags = 8;
            this.CachedTransform.SetParent(parent:  SRF.Hierarchy.Get(key:  "SRDebugger"), worldPositionStays:  true);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void Update()
        {
            var val_13;
            var val_14;
            float val_15;
            this.Update();
            if(this._frameBuffer.Count >= 1)
            {
                    SRDebugger.Services.ProfilerFrame val_2 = this._frameBuffer.Back();
                val_13 = V1.16B;
                float val_3 = UnityEngine.Time.deltaTime;
                if(this._frameBuffer != null)
            {
                    val_14 = this._frameBuffer.Count;
            }
            else
            {
                    val_14 = 0.Count;
            }
            
                this._frameBuffer.set_Item(index:  val_14 - 1, value:  new SRDebugger.Services.ProfilerFrame());
            }
            
            float val_7 = UnityEngine.Time.deltaTime;
            this.<LastFrameTime>k__BackingField = val_7;
            int val_9 = UnityEngine.Mathf.Min(a:  20, b:  this._frameBuffer.Count);
            if(val_9 >= 1)
            {
                    var val_13 = 0;
                do
            {
                SRDebugger.Services.ProfilerFrame val_10 = this._frameBuffer.Item[0];
                val_13 = val_13 + 1;
                val_13 = 0 + val_7;
            }
            while(val_9 != val_13);
            
                val_15 = (float)val_13;
            }
            else
            {
                    val_15 = 0f;
            }
            
            val_15 = val_15 / (float)val_9;
            this.<AverageFrameTime>k__BackingField = val_15;
            int val_11 = this._cameraListeners.Count;
            if(this._stopwatch.IsRunning != false)
            {
                    this._stopwatch.Stop();
                this._stopwatch.Reset();
            }
            
            this._renderDuration = 0;
            this._reportedCameras = 0;
            this._updateDuration = 0;
            this._updateToRenderDuration = 0;
            this.CameraCheck();
            this._stopwatch.Start();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnLateUpdate()
        {
            System.TimeSpan val_1 = this._stopwatch.Elapsed;
            this._updateDuration = val_1._ticks.TotalSeconds;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EndFrame()
        {
            if(this._stopwatch.IsRunning == false)
            {
                    return;
            }
            
            System.TimeSpan val_2 = this._stopwatch.Elapsed;
            this.PushFrame(totalTime:  val_2._ticks.TotalSeconds, updateTime:  this._updateDuration, renderTime:  this._renderDuration);
            this._stopwatch.Reset();
            this = this._stopwatch;
            this.Start();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CameraDurationCallback(SRDebugger.Profiler.ProfilerCameraListener listener, double duration)
        {
            int val_4 = this._reportedCameras;
            val_4 = val_4 + 1;
            this._reportedCameras = val_4;
            System.TimeSpan val_1 = this._stopwatch.Elapsed;
            double val_2 = val_1._ticks.TotalSeconds;
            val_2 = val_2 - this._updateDuration;
            val_2 = val_2 - this._updateToRenderDuration;
            this._renderDuration = val_2;
            if(this._reportedCameras < this.GetExpectedCameraCount())
            {
                    return;
            }
            
            this.EndFrame();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int GetExpectedCameraCount()
        {
            var val_9;
            var val_10;
            val_9 = 0;
            val_10 = 0;
            goto label_1;
            label_14:
            if(this._cameraListeners.Item[0] != 0)
            {
                    if((this._cameraListeners.Item[0].isActiveAndEnabled == false) || (this._cameraListeners.Item[0].Camera.isActiveAndEnabled == false))
            {
                goto label_12;
            }
            
            }
            
            val_10 = 1;
            label_12:
            val_9 = 1;
            label_1:
            if(val_9 < this._cameraListeners.Count)
            {
                goto label_14;
            }
            
            return (int)val_10;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CameraCheck()
        {
            var val_17;
            SRF.SRList<SRDebugger.Profiler.ProfilerCameraListener> val_18;
            UnityEngine.Camera[] val_19;
            SRF.SRList<SRDebugger.Profiler.ProfilerCameraListener> val_17 = this._cameraListeners;
            val_17 = val_17.Count - 1;
            if((val_17 & 2147483648) == 0)
            {
                    val_17 = 1152921523008944704;
                do
            {
                if(this._cameraListeners.Item[val_17] == 0)
            {
                    this._cameraListeners.RemoveAt(index:  val_17);
            }
            
                val_17 = val_17 - 1;
            }
            while((val_17 & 2147483648) == 0);
            
            }
            
            val_18 = this._cameraListeners;
            if(UnityEngine.Camera.allCamerasCount == val_18.Count)
            {
                    return;
            }
            
            val_18 = this._cameraCache;
            if(UnityEngine.Camera.allCamerasCount > this._cameraCache.Length)
            {
                    int val_7 = UnityEngine.Camera.allCamerasCount;
                this._cameraCache = new UnityEngine.Camera[0];
            }
            else
            {
                    val_19 = this._cameraCache;
            }
            
            int val_9 = UnityEngine.Camera.GetAllCameras(cameras:  val_19);
            if(val_9 < 1)
            {
                    return;
            }
            
            var val_19 = 0;
            val_17 = val_9;
            label_30:
            UnityEngine.Camera val_18 = this._cameraCache[val_19];
            label_23:
            if(0 >= this._cameraListeners.Count)
            {
                goto label_18;
            }
            
            val_18 = 0 + 1;
            if(this._cameraListeners.Item[0].Camera != val_18)
            {
                goto label_23;
            }
            
            goto label_24;
            label_18:
            SRDebugger.Profiler.ProfilerCameraListener val_15 = val_18.gameObject.AddComponent<SRDebugger.Profiler.ProfilerCameraListener>();
            val_15.hideFlags = 60;
            val_15.RenderDurationCallback = new System.Action<SRDebugger.Profiler.ProfilerCameraListener, System.Double>(object:  this, method:  System.Void SRDebugger.Profiler.ProfilerServiceImpl::CameraDurationCallback(SRDebugger.Profiler.ProfilerCameraListener listener, double duration));
            val_18 = this._cameraListeners;
            val_18.Add(item:  val_15);
            label_24:
            val_19 = val_19 + 1;
            if(val_19 != val_17)
            {
                goto label_30;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProfilerServiceImpl()
        {
            this._cameraListeners = new SRF.SRList<SRDebugger.Profiler.ProfilerCameraListener>();
            this._frameBuffer = new SRDebugger.CircularBuffer<SRDebugger.Services.ProfilerFrame>(capacity:  144);
            this._cameraCache = new UnityEngine.Camera[6];
            this._stopwatch = new System.Diagnostics.Stopwatch();
        }
    
    }

}
