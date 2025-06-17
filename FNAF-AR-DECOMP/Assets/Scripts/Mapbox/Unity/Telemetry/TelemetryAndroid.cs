using UnityEngine;

namespace Mapbox.Unity.Telemetry
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class TelemetryAndroid : ITelemetryLibrary
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.AndroidJavaObject _activityContext;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.AndroidJavaObject _telemInstance;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static Mapbox.Unity.Telemetry.ITelemetryLibrary _instance;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Mapbox.Unity.Telemetry.ITelemetryLibrary Instance { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Mapbox.Unity.Telemetry.ITelemetryLibrary get_Instance()
        {
            null = null;
            return (Mapbox.Unity.Telemetry.ITelemetryLibrary)Mapbox.Unity.Telemetry.TelemetryAndroid._instance;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Initialize(string accessToken)
        {
            string val_11;
            UnityEngine.AndroidJavaObject val_12;
            var val_13;
            var val_15;
            val_11 = accessToken;
            if((System.String.IsNullOrEmpty(value:  val_11)) == true)
            {
                goto label_1;
            }
            
            val_12 = 1152921504831234048;
            UnityEngine.AndroidJavaClass val_2 = new UnityEngine.AndroidJavaClass(className:  "com.unity3d.player.UnityPlayer");
            val_13 = 0;
            this._activityContext = val_2.GetStatic<UnityEngine.AndroidJavaObject>(fieldName:  "currentActivity");
            if(val_2 != null)
            {
                    var val_11 = 0;
                val_11 = val_11 + 1;
                val_2.Dispose();
            }
            
            if(59 == 59)
            {
                
            }
            else
            {
                    if(val_13 != 0)
            {
                    val_13 = 0;
            }
            
            }
            
            if(this._activityContext == null)
            {
                goto label_11;
            }
            
            UnityEngine.AndroidJavaClass val_5 = new UnityEngine.AndroidJavaClass(className:  "com.mapbox.services.android.telemetry.MapboxTelemetry");
            if(val_5 == null)
            {
                goto label_12;
            }
            
            val_12 = val_5.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "getInstance", args:  System.Array.Empty<System.Object>());
            this._telemInstance = val_12;
            if(val_12 == null)
            {
                goto label_13;
            }
            
            object[] val_8 = new object[3];
            val_8[0] = this._activityContext;
            val_8[1] = val_11;
            val_11 = "MapboxEventsUnityAndroid/1.4.5";
            val_8[2] = val_11;
            val_12.Call(methodName:  "initialize", args:  val_8);
            goto label_24;
            label_11:
            UnityEngine.Debug.LogError(message:  "Could not get current activity");
            return;
            label_12:
            UnityEngine.Debug.LogError(message:  "Could not get class \'MapboxTelemetry\'");
            val_15 = 201;
            if(val_13 != 0)
            {
                goto label_29;
            }
            
            return;
            label_13:
            UnityEngine.Debug.LogError(message:  "Could not get MapboxTelemetry instance");
            label_24:
            val_15 = 201;
            label_47:
            var val_12 = 0;
            val_12 = val_12 + 1;
            val_5.Dispose();
            label_48:
            if(val_13 == 0)
            {
                    return;
            }
            
            label_29:
            if(201 == 0)
            {
                    return;
            }
            
            if(201 == 201)
            {
                    return;
            }
            
            label_1:
            System.ArgumentNullException val_10 = new System.ArgumentNullException(paramName:  "accessToken");
            if(0 != 1)
            {
                goto label_49;
            }
            
            if((???) != 0)
            {
                goto label_47;
            }
            
            goto label_48;
            label_49:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SendTurnstile()
        {
            var val_12;
            var val_13;
            UnityEngine.AndroidJavaClass val_1 = null;
            val_12 = val_1;
            val_1 = new UnityEngine.AndroidJavaClass(className:  "com.mapbox.services.android.telemetry.MapboxEvent");
            if(val_12 != null)
            {
                    object[] val_4 = new object[1];
                val_4[0] = val_1.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "buildMapLoadEvent", args:  System.Array.Empty<System.Object>());
                this._telemInstance.Call(methodName:  "pushEvent", args:  val_4);
                val_13 = 81;
                var val_12 = 0;
                val_12 = val_12 + 1;
            }
            else
            {
                    UnityEngine.Debug.LogError(message:  "Could not get class \'MapboxEvent\'");
                return;
            }
            
            val_1.Dispose();
            if(0 == 0)
            {
                    return;
            }
            
            if(81 == 81)
            {
                    return;
            }
            
            val_12 = ???;
            val_13 = ???;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetLocationCollectionState(bool enable)
        {
            bool val_1 = enable;
            object[] val_2 = new object[1];
            if(val_2 == null)
            {
                goto label_1;
            }
            
            if(val_1 == true)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(val_1 == false)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_2[0] = val_1;
            this._telemInstance.Call(methodName:  "setTelemetryEnabled", args:  val_2);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TelemetryAndroid()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static TelemetryAndroid()
        {
            Mapbox.Unity.Telemetry.TelemetryAndroid._instance = new Mapbox.Unity.Telemetry.TelemetryAndroid();
        }
    
    }

}
