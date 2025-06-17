using UnityEngine;

namespace Mapbox.Unity.Location
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class KalmanLatLong
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _minAccuracy;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _qMetresPerSecond;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private long _timeStampMilliseconds;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private double _lat;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private double _lng;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _variance;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public long TimeStamp { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double Lat { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double Lng { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Accuracy { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public KalmanLatLong(float Q_metres_per_second)
        {
            this._minAccuracy = 1f;
            this._qMetresPerSecond = Q_metres_per_second;
            this._variance = -1f;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public long get_TimeStamp()
        {
            return (long)this._timeStampMilliseconds;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double get_Lat()
        {
            return (double)this._lat;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double get_Lng()
        {
            return (double)this._lng;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_Accuracy()
        {
            if(S0 <= _TYPE_MAX_)
            {
                    return (float)S0;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetState(double lat, double lng, float accuracy, long TimeStamp_milliseconds)
        {
            this._lat = lat;
            this._lng = lng;
            this._variance = accuracy * accuracy;
            this._timeStampMilliseconds = TimeStamp_milliseconds;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Process(double lat_measurement, double lng_measurement, float accuracy, long TimeStamp_milliseconds)
        {
            float val_4;
            float val_1 = (this._minAccuracy > accuracy) ? this._minAccuracy : accuracy;
            if(this._variance < 0)
            {
                    this._timeStampMilliseconds = TimeStamp_milliseconds;
                this._lat = lat_measurement;
                this._lng = lng_measurement;
                val_4 = val_1 * val_1;
            }
            else
            {
                    val_1 = val_1 * val_1;
                val_1 = val_1 + this._variance;
                float val_2 = 1f;
                val_1 = this._variance / val_1;
                val_2 = val_2 - val_1;
                lat_measurement = lat_measurement - this._lat;
                lng_measurement = lng_measurement - this._lng;
                lat_measurement = lat_measurement * (double)val_1;
                lng_measurement = lng_measurement * (double)val_1;
                lat_measurement = this._lat + lat_measurement;
                lng_measurement = this._lng + lng_measurement;
                this._lat = lat_measurement;
                this._lng = lng_measurement;
                val_4 = val_2 * this._variance;
            }
            
            this._variance = val_4;
        }
    
    }

}
