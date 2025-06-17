using UnityEngine;

namespace Mapbox.Unity.Location
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class MapboxLocationServiceMock : IMapboxLocationService, IDisposable
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.Location.LocationLogReader _logReader;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.IEnumerator<Mapbox.Unity.Location.Location> _locationEnumerator;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _isRunning;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _disposed;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool isEnabledByUser { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.LocationServiceStatus status { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Location.IMapboxLocationInfo lastData { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapboxLocationServiceMock(byte[] locationLogFileContents)
        {
            if((locationLogFileContents != null) && (locationLogFileContents.Length > 0))
            {
                    Mapbox.Unity.Location.LocationLogReader val_1 = new Mapbox.Unity.Location.LocationLogReader(contents:  locationLogFileContents);
                this._logReader = val_1;
                this._locationEnumerator = val_1.GetLocations();
                return;
            }
            
            System.ArgumentNullException val_3 = new System.ArgumentNullException(paramName:  "locationLogFileContents");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void Finalize()
        {
            this.Finalize();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Dispose()
        {
            System.GC.SuppressFinalize(obj:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void Dispose(bool disposeManagedResources)
        {
            if(this._disposed == true)
            {
                    return;
            }
            
            if(disposeManagedResources != false)
            {
                    if(this._locationEnumerator != null)
            {
                    var val_2 = 0;
                val_2 = val_2 + 1;
                this._locationEnumerator.Dispose();
                this._locationEnumerator = 0;
            }
            
                if(this._logReader != null)
            {
                    this._logReader.Dispose();
                this._logReader = 0;
            }
            
            }
            
            this._disposed = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_isEnabledByUser()
        {
            return true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.LocationServiceStatus get_status()
        {
            return (UnityEngine.LocationServiceStatus)(this._isRunning == false) ? 0 : 2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Location.IMapboxLocationInfo get_lastData()
        {
            System.Collections.Generic.IEnumerator<Mapbox.Unity.Location.Location> val_3;
            var val_5;
            var val_6;
            val_3 = this;
            if(this._locationEnumerator != null)
            {
                    var val_5 = 0;
                val_5 = val_5 + 1;
            }
            else
            {
                    val_5 = 1152921505114247168;
                return (Mapbox.Unity.Location.IMapboxLocationInfo)val_6;
            }
            
            bool val_2 = this._locationEnumerator.MoveNext();
            val_3 = this._locationEnumerator;
            var val_6 = 0;
            val_6 = val_6 + 1;
            T val_4 = val_3.Current;
            val_5 = 1152921505114247168;
            val_6;
            return (Mapbox.Unity.Location.IMapboxLocationInfo)val_6;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Start(float desiredAccuracyInMeters, float updateDistanceInMeters)
        {
            this._isRunning = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Stop()
        {
            this._isRunning = false;
        }
    
    }

}
