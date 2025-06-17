using UnityEngine;

namespace Mapbox.Examples.Scripts
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class LogLocationProviderData : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Text _logText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Toggle _logToggle;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Globalization.CultureInfo _invariantCulture;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _logToFile;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.Location.LocationLogWriter _logWriter;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            System.Action<Mapbox.Unity.Location.Location> val_8;
            IntPtr val_9;
            UnityEngine.Screen.sleepTimeout = 0;
            System.Action<Mapbox.Unity.Location.Location> val_3 = null;
            val_8 = val_3;
            val_9 = System.Void Mapbox.Examples.Scripts.LogLocationProviderData::LocationProvider_OnLocationUpdated(Mapbox.Unity.Location.Location location);
            val_3 = new System.Action<Mapbox.Unity.Location.Location>(object:  this, method:  val_9);
            var val_8 = 0;
            val_8 = val_8 + 1;
            val_9 = 0;
            Mapbox.Unity.Location.LocationProviderFactory.Instance.DefaultLocationProvider.add_OnLocationUpdated(value:  val_3);
            if(0 != this._logToggle)
            {
                    UnityEngine.Events.UnityAction<System.Boolean> val_6 = null;
                val_8 = val_6;
                val_6 = new UnityEngine.Events.UnityAction<System.Boolean>(object:  this, method:  System.Void Mapbox.Examples.Scripts.LogLocationProviderData::<Start>b__5_0(bool isOn));
                this._logToggle.onValueChanged.AddListener(call:  val_6);
            }
            else
            {
                    UnityEngine.Debug.LogError(message:  "no logtoggle attached, cannot log");
            }
            
            if(0 != this._logText)
            {
                    return;
            }
            
            UnityEngine.Debug.LogError(message:  "no text to log to");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDestroy()
        {
            IntPtr val_5;
            this.closeLogWriter();
            System.Action<Mapbox.Unity.Location.Location> val_3 = null;
            val_5 = System.Void Mapbox.Examples.Scripts.LogLocationProviderData::LocationProvider_OnLocationUpdated(Mapbox.Unity.Location.Location location);
            val_3 = new System.Action<Mapbox.Unity.Location.Location>(object:  this, method:  val_5);
            var val_5 = 0;
            val_5 = val_5 + 1;
            val_5 = 1;
            Mapbox.Unity.Location.LocationProviderFactory.Instance.DefaultLocationProvider.remove_OnLocationUpdated(value:  val_3);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void LocationProvider_OnLocationUpdated(Mapbox.Unity.Location.Location location)
        {
            Mapbox.Unity.Location.LocationLogWriter val_44;
            System.Text.StringBuilder val_1 = null;
            val_44 = val_1;
            val_1 = new System.Text.StringBuilder();
            System.Text.StringBuilder val_4 = val_1.AppendLine(value:  System.String.Format(format:  "IsLocationServiceEnabled: {0}", arg0:  (location.IsLocationServiceEnabled == true) ? 1 : 0));
            System.Text.StringBuilder val_7 = val_1.AppendLine(value:  System.String.Format(format:  "IsLocationServiceInitializing: {0}", arg0:  (location.IsLocationServiceInitializing == true) ? 1 : 0));
            System.Text.StringBuilder val_10 = val_1.AppendLine(value:  System.String.Format(format:  "IsLocationUpdated: {0}", arg0:  (location.IsLocationUpdated == true) ? 1 : 0));
            System.Text.StringBuilder val_13 = val_1.AppendLine(value:  System.String.Format(format:  "IsHeadingUpdated: {0}", arg0:  (mem[1152921519871520000] == true) ? 1 : 0));
            System.Text.StringBuilder val_18 = val_1.AppendLine(value:  System.String.Format(format:  "location provider: {0} ({1})", arg0:  mem[1152921519871519984], arg1:  Mapbox.Unity.Location.LocationProviderFactory.Instance.DefaultLocationProvider.GetType()));
            System.DateTime val_20 = System.DateTime.UtcNow;
            System.DateTime val_21 = Mapbox.Utils.UnixTimestampUtils.From(timestamp:  location.Timestamp);
            System.Text.StringBuilder val_23 = val_1.AppendLine(value:  System.String.Format(format:  "UTC time:{0}  - device:  {1}{0}  - location:{2}", arg0:  System.Environment.NewLine, arg1:  val_21.dateData, arg2:  val_21.dateData));
            System.Text.StringBuilder val_25 = val_1.AppendLine(value:  System.String.Format(provider:  this._invariantCulture, format:  "position: {0:0.00000000} / {1:0.00000000}", arg0:  location.LatitudeLongitude.x, arg1:  location.LatitudeLongitude.y));
            System.Text.StringBuilder val_27 = val_1.AppendLine(value:  System.String.Format(provider:  this._invariantCulture, format:  "accuracy: {0:0.0}m", arg0:  location.Accuracy));
            System.Text.StringBuilder val_29 = val_1.AppendLine(value:  System.String.Format(provider:  this._invariantCulture, format:  "user heading: {0:0.0}°", arg0:  location.UserHeading));
            System.Text.StringBuilder val_31 = val_1.AppendLine(value:  System.String.Format(provider:  this._invariantCulture, format:  "device orientation: {0:0.0}°", arg0:  location.DeviceOrientation));
            System.Text.StringBuilder val_33 = val_1.AppendLine(value:  this.nullableAsStr<System.Single>(val:  new System.Nullable<T>() {HasValue = true}, formatString:  "speed: {0:0.0}km/h"));
            System.Text.StringBuilder val_35 = val_1.AppendLine(value:  this.nullableAsStr<System.Boolean>(val:  new System.Nullable<T>() {HasValue = location.HasGpsFix.HasValue}, formatString:  "HasGpsFix: {0}"));
            System.Text.StringBuilder val_37 = val_1.AppendLine(value:  this.nullableAsStr<System.Int32>(val:  new System.Nullable<T>() {HasValue = true}, formatString:  "SatellitesUsed:{0} "));
            System.Text.StringBuilder val_39 = val_1.AppendLine(value:  this.nullableAsStr<System.Int32>(val:  new System.Nullable<T>() {HasValue = mem[1152921519871519956]}, formatString:  "SatellitesInView:{0}"));
            if(0 != this._logText)
            {
                    val_44 = val_44;
            }
            
            if(this._logToFile == false)
            {
                goto label_25;
            }
            
            val_44 = this._logWriter;
            if(val_44 != null)
            {
                goto label_26;
            }
            
            UnityEngine.Debug.Log(message:  "--- about to start logging to file ---");
            this._logWriter = new Mapbox.Unity.Location.LocationLogWriter();
            val_44 = this._logToggle.GetComponentInChildren<UnityEngine.UI.Text>();
            if(this._logToFile == true)
            {
                goto label_31;
            }
            
            label_25:
            if(this._logWriter == null)
            {
                    return;
            }
            
            UnityEngine.Debug.Log(message:  "--- about to stop logging to file ---");
            val_44 = this._logToggle.GetComponentInChildren<UnityEngine.UI.Text>();
            this.closeLogWriter();
            if(this._logToFile == false)
            {
                    return;
            }
            
            label_31:
            val_44 = this._logWriter;
            if(val_44 == null)
            {
                    return;
            }
            
            label_26:
            val_44.Write(location:  new Mapbox.Unity.Location.Location() {LatitudeLongitude = new Mapbox.Utils.Vector2d(), IsLocationServiceInitializing = false, IsLocationServiceEnabled = false, IsLocationUpdated = false, HasGpsFix = new System.Nullable<System.Boolean>() {HasValue = false}, SatellitesInView = new System.Nullable<System.Int32>() {HasValue = false}, SatellitesUsed = new System.Nullable<System.Int32>() {HasValue = false}, SpeedMetersPerSecond = new System.Nullable<System.Single>() {HasValue = false}, IsUserHeadingUpdated = false});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string nullableAsStr<T>(System.Nullable<T> val, string formatString)
        {
            System.Globalization.CultureInfo val_3;
            var val_4;
            System.Globalization.CultureInfo val_5;
            object val_6;
            val_3 = this;
            if((formatString == null) && (((-1914866116) & 1) == 0))
            {
                    val_4 = "[not supported by provider]";
                return (string)System.String.Format(provider:  val_5 = val_3, format:  formatString, arg0:  val.HasValue);
            }
            
            if((formatString != null) && (((-1914866116) & 1) == 0))
            {
                    val_5 = this._invariantCulture;
                val_6 = "[not supported by provider]";
                return (string)System.String.Format(provider:  val_5, format:  formatString, arg0:  val.HasValue);
            }
            
            if((formatString == null) && (((-1914866116) & 1) != 0))
            {
                    string val_1 = 0.ToString();
                return (string)System.String.Format(provider:  val_5, format:  formatString, arg0:  val.HasValue);
            }
            
            val_3 = this._invariantCulture;
            val_6;
            return (string)System.String.Format(provider:  val_5, format:  formatString, arg0:  val.HasValue);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void closeLogWriter()
        {
            if(this._logWriter == null)
            {
                    return;
            }
            
            UnityEngine.Debug.Log(message:  "closing stream writer");
            this._logWriter.Dispose();
            this._logWriter = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LogLocationProviderData()
        {
            this._invariantCulture = System.Globalization.CultureInfo.InvariantCulture;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void <Start>b__5_0(bool isOn)
        {
            this._logToFile = isOn;
        }
    
    }

}
