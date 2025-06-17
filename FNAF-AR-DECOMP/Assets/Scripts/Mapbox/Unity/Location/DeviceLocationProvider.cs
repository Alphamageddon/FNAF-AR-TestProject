using UnityEngine;

namespace Mapbox.Unity.Location
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class DeviceLocationProvider : AbstractLocationProvider
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float _desiredAccuracyInMeters;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float _updateDistanceInMeters;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public long _updateTimeInMilliSeconds;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Location.AngleSmoothingAbstractBase _userHeadingSmoothing;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Location.AngleSmoothingAbstractBase _deviceOrientationSmoothing;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Location.DeviceLocationProvider.DebuggingInEditor _editorDebuggingOnly;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.Location.IMapboxLocationService _locationService;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Coroutine _pollRoutine;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private double _lastLocationTimestamp;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.WaitForSeconds _wait1sec;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.WaitForSeconds _waitUpdateTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Utils.CircularBuffer<Mapbox.Utils.Vector2d> _lastPositions;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _maxLastPositions;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private double _minDistanceOldestNewestPosition;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _gotPermissionRequestResponse;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnAllow()
        {
            this._gotPermissionRequestResponse = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDeny()
        {
            this._gotPermissionRequestResponse = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDenyAndNeverAskAgain()
        {
            this._gotPermissionRequestResponse = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void Awake()
        {
            this._locationService = new Mapbox.Unity.Location.MapboxLocationServiceUnityWrapper();
            mem[1152921519778151912] = "unity";
            this._wait1sec = new UnityEngine.WaitForSeconds(seconds:  1f);
            if(this._updateTimeInMilliSeconds < 500)
            {
                
            }
            else
            {
                    float val_13 = 1000f;
                val_13 = (float)this._updateTimeInMilliSeconds / val_13;
            }
            
            new UnityEngine.WaitForSeconds() = new UnityEngine.WaitForSeconds(seconds:  val_13);
            this._waitUpdateTime = new UnityEngine.WaitForSeconds();
            if(0 == this._userHeadingSmoothing)
            {
                    this._userHeadingSmoothing = this.transform.gameObject.AddComponent<Mapbox.Unity.Location.AngleSmoothingNoOp>();
            }
            
            if(0 == this._deviceOrientationSmoothing)
            {
                    this._deviceOrientationSmoothing = this.transform.gameObject.AddComponent<Mapbox.Unity.Location.AngleSmoothingNoOp>();
            }
            
            this._lastPositions = new Mapbox.Utils.CircularBuffer<Mapbox.Utils.Vector2d>(capacity:  this._maxLastPositions);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnEnable()
        {
            if(this._pollRoutine != null)
            {
                    return;
            }
            
            this._pollRoutine = this.StartCoroutine(routine:  this.PollLocationRoutine());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDisable()
        {
            if(this._pollRoutine == null)
            {
                    return;
            }
            
            this.StopCoroutine(routine:  this.PollLocationRoutine());
            this._pollRoutine = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.IEnumerator PollLocationRoutine()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new DeviceLocationProvider.<PollLocationRoutine>d__22();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DeviceLocationProvider()
        {
            this._desiredAccuracyInMeters = 1f;
            this._updateTimeInMilliSeconds = 500;
            this._maxLastPositions = 5;
            this._minDistanceOldestNewestPosition = 1.5;
        }
    
    }

}
