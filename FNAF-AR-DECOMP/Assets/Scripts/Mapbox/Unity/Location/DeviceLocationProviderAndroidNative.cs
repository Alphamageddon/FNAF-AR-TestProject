using UnityEngine;

namespace Mapbox.Unity.Location
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class DeviceLocationProviderAndroidNative : AbstractLocationProvider, IDisposable
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _updateDistanceInMeters;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private long _updateTimeInMilliSeconds;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.WaitForSeconds _wait1sec;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.WaitForSeconds _wait5sec;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.WaitForSeconds _wait60sec;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.WaitForSeconds _waitUpdateTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _disposed;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static object _lock;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Coroutine _pollLocation;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.AndroidJavaObject _activityContext;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.AndroidJavaObject _gpsInstance;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.AndroidJavaObject _sensorInstance;
        
        // Methods
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
                    this.shutdown();
            }
            
            this._disposed = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void shutdown()
        {
            var val_4;
            UnityEngine.AndroidJavaObject val_5;
            val_4 = null;
            val_4 = null;
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  Mapbox.Unity.Location.DeviceLocationProviderAndroidNative._lock, lockTaken: ref  val_1);
            if(this._gpsInstance != null)
            {
                    this._gpsInstance.Call(methodName:  "stopLocationListeners", args:  System.Array.Empty<System.Object>());
                this._gpsInstance.Dispose();
                this._gpsInstance = 0;
            }
            
            val_5 = this._sensorInstance;
            if(val_5 != null)
            {
                    val_5.Call(methodName:  "stopSensorListeners", args:  System.Array.Empty<System.Object>());
                this._sensorInstance.Dispose();
                val_5 = 0;
                this._sensorInstance = 0;
            }
            
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  Mapbox.Unity.Location.DeviceLocationProviderAndroidNative._lock);
            }
            
            if(122 == 122)
            {
                    return;
            }
            
            if(val_5 == 0)
            {
                    return;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void OnDestroy()
        {
            this.shutdown();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void OnDisable()
        {
            this.shutdown();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void Awake()
        {
            if(this.enabled == false)
            {
                    return;
            }
            
            if(this.transform.gameObject.activeInHierarchy == false)
            {
                    return;
            }
            
            this._wait1sec = new UnityEngine.WaitForSeconds(seconds:  1f);
            this._wait5sec = new UnityEngine.WaitForSeconds(seconds:  5f);
            this._wait60sec = new UnityEngine.WaitForSeconds(seconds:  60f);
            if(this._updateTimeInMilliSeconds < 500)
            {
                
            }
            else
            {
                    float val_12 = 1000f;
                val_12 = (float)this._updateTimeInMilliSeconds / val_12;
            }
            
            new UnityEngine.WaitForSeconds() = new UnityEngine.WaitForSeconds(seconds:  val_12);
            this._waitUpdateTime = new UnityEngine.WaitForSeconds();
            mem[1152921519780790388] = 1;
            if(UnityEngine.Application.platform != 11)
            {
                    return;
            }
            
            this.getActivityContext();
            this.getGpsInstance(showToastMessages:  false);
            this.getSensorInstance();
            if(this._pollLocation != null)
            {
                    return;
            }
            
            this._pollLocation = this.StartCoroutine(routine:  this.locationRoutine());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void getActivityContext()
        {
            UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  "com.unity3d.player.UnityPlayer");
            this._activityContext = val_1.GetStatic<UnityEngine.AndroidJavaObject>(fieldName:  "currentActivity");
            if(val_1 != null)
            {
                    var val_4 = 0;
                val_4 = val_4 + 1;
                val_1.Dispose();
            }
            
            if(this._activityContext != null)
            {
                    return;
            }
            
            UnityEngine.Debug.LogError(message:  "Could not get UnityPlayer activity");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void getGpsInstance(bool showToastMessages = False)
        {
            var val_8;
            if(this._activityContext == null)
            {
                    return;
            }
            
            UnityEngine.AndroidJavaClass val_1 = null;
            val_8 = val_1;
            val_1 = new UnityEngine.AndroidJavaClass(className:  "com.mapbox.android.unity.AndroidGps");
            if(val_8 == null)
            {
                goto label_2;
            }
            
            object[] val_2 = new object[1];
            val_2[0] = this._activityContext;
            UnityEngine.AndroidJavaObject val_3 = val_1.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "instance", args:  val_2);
            this._gpsInstance = val_3;
            if(val_3 == null)
            {
                goto label_7;
            }
            
            object[] val_4 = new object[1];
            new UnityEngine.AndroidJavaRunnable() = new UnityEngine.AndroidJavaRunnable(object:  this, method:  System.Void Mapbox.Unity.Location.DeviceLocationProviderAndroidNative::<getGpsInstance>b__20_0());
            val_4[0] = new UnityEngine.AndroidJavaRunnable();
            this._activityContext.Call(methodName:  "runOnUiThread", args:  val_4);
            object[] val_6 = new object[2];
            val_6[0] = this._updateDistanceInMeters;
            val_6[1] = this._updateTimeInMilliSeconds;
            this._gpsInstance.Call(methodName:  "startLocationListeners", args:  val_6);
            goto label_21;
            label_2:
            UnityEngine.Debug.LogError(message:  "Could not get class \'AndroidGps\'");
            return;
            label_7:
            UnityEngine.Debug.LogError(message:  "Could not get \'AndroidGps\' instance");
            label_21:
            var val_8 = 0;
            val_8 = val_8 + 1;
            val_1.Dispose();
            if(0 == 0)
            {
                    return;
            }
            
            if(189 == 189)
            {
                    return;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void getSensorInstance()
        {
            var val_12;
            var val_13;
            if(this._activityContext == null)
            {
                    return;
            }
            
            UnityEngine.AndroidJavaClass val_1 = null;
            val_12 = val_1;
            val_1 = new UnityEngine.AndroidJavaClass(className:  "com.mapbox.android.unity.AndroidSensors");
            if(val_12 == null)
            {
                goto label_2;
            }
            
            object[] val_2 = new object[1];
            val_2[0] = this._activityContext;
            UnityEngine.AndroidJavaObject val_3 = val_1.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "instance", args:  val_2);
            this._sensorInstance = val_3;
            if(val_3 == null)
            {
                goto label_7;
            }
            
            val_3.Call(methodName:  "startSensorListeners", args:  System.Array.Empty<System.Object>());
            goto label_8;
            label_2:
            UnityEngine.Debug.LogError(message:  "Could not get class \'AndroidSensors\'");
            return;
            label_7:
            UnityEngine.Debug.LogError(message:  "Could not get \'AndroidSensors\' instance");
            label_8:
            val_13 = 120;
            var val_12 = 0;
            val_12 = val_12 + 1;
            val_1.Dispose();
            if(0 == 0)
            {
                    return;
            }
            
            if(val_13 == 120)
            {
                    return;
            }
            
            val_12 = ???;
            val_13 = ???;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.IEnumerator locationRoutine()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new DeviceLocationProviderAndroidNative.<locationRoutine>d__22();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void populateCurrentLocation(UnityEngine.AndroidJavaObject location)
        {
            System.Object[] val_32;
            var val_33;
            if(location == null)
            {
                goto label_1;
            }
            
            double val_4 = location.Call<System.Double>(methodName:  "getLongitude", args:  System.Array.Empty<System.Object>());
            Mapbox.Utils.Vector2d val_5 = new Mapbox.Utils.Vector2d(x:  location.Call<System.Double>(methodName:  "getLatitude", args:  System.Array.Empty<System.Object>()), y:  val_4);
            mem[1152921519782006440] = val_5.x;
            mem[1152921519782006448] = val_5.y;
            float val_7 = location.Call<System.Single>(methodName:  "getAccuracy", args:  System.Array.Empty<System.Object>());
            mem[1152921519782006480] = val_7;
            long val_9 = location.Call<System.Int64>(methodName:  "getTime", args:  System.Array.Empty<System.Object>());
            mem[1152921519782006464] = 1.84467449498829E+16;
            string val_11 = location.Call<System.String>(methodName:  "getProvider", args:  System.Array.Empty<System.Object>());
            mem[1152921519782006520] = val_11;
            if((location.Call<System.Boolean>(methodName:  "hasBearing", args:  System.Array.Empty<System.Object>())) == false)
            {
                goto label_2;
            }
            
            float val_16 = location.Call<System.Single>(methodName:  "getBearing", args:  System.Array.Empty<System.Object>());
            mem[1152921519782006456] = val_16;
            var val_17 = (val_16 != val_4) ? 1 : 0;
            goto label_3;
            label_1:
            mem[1152921519782006486] = 0;
            mem[1152921519782006536] = 0;
            return;
            label_2:
            val_33 = 0;
            label_3:
            mem[1152921519782006536] = val_33;
            float val_21 = location.Call<System.Single>(methodName:  "getSpeed", args:  System.Array.Empty<System.Object>());
            bool val_24 = (System.String.op_Inequality(a:  val_11, b:  "getProvider")) | 1152921519781994273;
            bool val_32 = true;
            val_24 = ((val_7 != S9) ? 1 : 0) | val_24;
            val_32 = ((0.distance != 0.distance) ? 1 : 0) | val_32;
            val_24 = ((D10 != (1.84467449498829E+16)) ? 1 : 0) | val_24;
            val_32 = val_24 | val_32;
            mem[1152921519782006508] = 0;
            mem[1152921519782006486] = val_32;
            val_32 = System.Array.Empty<System.Object>();
            if((this._gpsInstance.Call<System.Boolean>(methodName:  "getIsGpsEnabled", args:  val_32)) != false)
            {
                    string val_33 = "hasGpsFix";
                val_33 = this._gpsInstance.Get<System.Boolean>(fieldName:  val_33);
                mem[1152921519782006487] = 0;
                val_32 = 1152921519781977184;
                int val_30 = this._gpsInstance.Get<System.Int32>(fieldName:  "satellitesInView");
                mem[1152921519782006492] = 0;
                int val_31 = this._gpsInstance.Get<System.Int32>(fieldName:  "satellitesUsedInFix");
                mem[1152921519782006500] = 0;
                return;
            }
            
            mem[1152921519782006487] = 0;
            mem[1152921519782006500] = 0;
            mem[1152921519782006492] = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void populateWithBetterLocation(UnityEngine.AndroidJavaObject locGps, UnityEngine.AndroidJavaObject locNetwork)
        {
            var val_9;
            System.Object[] val_10;
            UnityEngine.AndroidJavaObject val_11;
            val_9 = "getTime";
            val_10 = System.Array.Empty<System.Object>();
            if((locGps.Call<System.Int64>(methodName:  "getTime", args:  System.Array.Empty<System.Object>())) > (locNetwork.Call<System.Int64>(methodName:  "getTime", args:  val_10)))
            {
                goto label_3;
            }
            
            val_10 = "getAccuracy";
            val_9 = 1152921519781735744;
            float val_8 = locNetwork.Call<System.Single>(methodName:  "getAccuracy", args:  System.Array.Empty<System.Object>());
            if((locGps.Call<System.Single>(methodName:  "getAccuracy", args:  System.Array.Empty<System.Object>())) >= 0)
            {
                goto label_6;
            }
            
            label_3:
            val_11 = locGps;
            goto label_7;
            label_6:
            val_11 = locNetwork;
            label_7:
            this.populateCurrentLocation(location:  val_11);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void Update()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string time2str(UnityEngine.AndroidJavaObject loc)
        {
            System.TimeSpan val_3 = System.TimeSpan.FromMilliseconds(value:  (double)loc.Call<System.Int64>(methodName:  "getTime", args:  System.Array.Empty<System.Object>()));
            return -2003672968;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string loc2str(UnityEngine.AndroidJavaObject loc)
        {
            System.IFormatProvider val_7;
            var val_8;
            val_7 = loc;
            if(val_7 != null)
            {
                    val_7 = System.Globalization.CultureInfo.InvariantCulture;
                string val_6 = System.String.Format(provider:  val_7, format:  "{0:0.00000000} / {1:0.00000000}", arg0:  val_7.Call<System.Double>(methodName:  "getLatitude", args:  System.Array.Empty<System.Object>()), arg1:  val_7.Call<System.Double>(methodName:  "getLongitude", args:  System.Array.Empty<System.Object>()));
                return (string)val_8;
            }
            
            val_8 = "loc: NULL";
            return (string)val_8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DeviceLocationProviderAndroidNative()
        {
            this._updateTimeInMilliSeconds = 1000;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static DeviceLocationProviderAndroidNative()
        {
            Mapbox.Unity.Location.DeviceLocationProviderAndroidNative._lock = new System.Object();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void <getGpsInstance>b__20_0()
        {
            object[] val_1 = new object[1];
            val_1[0] = "starting location listeners";
            this._gpsInstance.Call(methodName:  "showMessage", args:  val_1);
        }
    
    }

}
