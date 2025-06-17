using UnityEngine;

namespace Mapbox.Unity.Location
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class LocationLogWriter : LocationLogAbstractBase, IDisposable
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _disposed;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.IO.TextWriter _textWriter;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private long _lineCount;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LocationLogWriter()
        {
            System.DateTime val_1 = System.DateTime.Now;
            string val_4 = System.IO.Path.Combine(path1:  UnityEngine.Application.persistentDataPath, path2:  "MBX-location-log-"("MBX-location-log-") + val_1.dateData + ".txt");
            UnityEngine.Debug.Log(message:  "starting new log file: "("starting new log file: ") + val_4);
            System.IO.StreamWriter val_7 = new System.IO.StreamWriter(path:  val_4, append:  false, encoding:  new System.Text.UTF8Encoding(encoderShouldEmitUTF8Identifier:  false));
            this._textWriter = val_7;
            string val_10 = "#" + System.String.Join(separator:  val_4, value:  val_7.HeaderNames)(System.String.Join(separator:  val_4, value:  val_7.HeaderNames));
            if(val_7 != null)
            {
                    return;
            }
        
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
                    object[] val_1 = new object[1];
                val_1[0] = this._lineCount;
                UnityEngine.Debug.LogFormat(format:  "{0} locations logged", args:  val_1);
                if(this._textWriter != null)
            {
                    this._textWriter.Dispose();
                this._textWriter = 0;
            }
            
            }
            
            this._disposed = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Write(Mapbox.Unity.Location.Location location)
        {
            string[] val_1 = new string[17];
            string val_2 = location.IsLocationServiceEnabled.ToString();
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(val_2 != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(val_2 == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = val_2;
            val_1[1] = location.IsLocationServiceInitializing.ToString();
            val_1[2] = location.IsLocationUpdated.ToString();
            val_1[3] = ToString();
            val_1[4] = mem[1152921519791751008];
            val_1[5] = GetType();
            System.DateTime val_7 = System.DateTime.UtcNow;
            val_1[6] = ;
            System.DateTime val_8 = Mapbox.Utils.UnixTimestampUtils.From(timestamp:  location.Timestamp);
            val_1[7] = ;
            string val_9 = System.String.Format(provider:  val_8.dateData, format:  "{0:0.00000000}", arg0:  location.LatitudeLongitude.x);
            val_1[8] = val_9;
            string val_10 = System.String.Format(provider:  val_9, format:  "{0:0.00000000}", arg0:  location.LatitudeLongitude.y);
            val_1[9] = val_10;
            string val_11 = System.String.Format(provider:  val_10, format:  "{0:0.0}", arg0:  location.Accuracy);
            val_1[10] = val_11;
            string val_12 = System.String.Format(provider:  val_11, format:  "{0:0.0}", arg0:  location.UserHeading);
            val_1[11] = val_12;
            val_1[12] = System.String.Format(provider:  val_12, format:  "{0:0.0}", arg0:  location.DeviceOrientation);
            val_1[13] = this.nullableAsStr<System.Single>(val:  new System.Nullable<T>() {HasValue = true}, formatString:  "{0:0.0}");
            val_1[14] = this.nullableAsStr<System.Boolean>(val:  new System.Nullable<T>() {HasValue = location.HasGpsFix.HasValue}, formatString:  "{0}");
            val_1[15] = this.nullableAsStr<System.Int32>(val:  new System.Nullable<T>() {HasValue = true}, formatString:  "{0}");
            string val_17 = this.nullableAsStr<System.Int32>(val:  new System.Nullable<T>() {HasValue = mem[1152921519791750980]}, formatString:  "{0}");
            val_1[16] = val_17;
            long val_19 = this._lineCount;
            val_19 = val_19 + 1;
            this._lineCount = val_19;
            UnityEngine.Debug.Log(message:  System.String.Join(separator:  val_17, value:  val_1));
            if(this._textWriter != null)
            {
                    return;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string nullableAsStr<T>(System.Nullable<T> val, string formatString)
        {
            System.IFormatProvider val_3;
            var val_4;
            System.IFormatProvider val_5;
            object val_6;
            val_3 = this;
            if((formatString == null) && (((-1994778180) & 1) == 0))
            {
                    val_4 = "[not supported by provider]";
                return (string)System.String.Format(provider:  this, format:  formatString, arg0:  val.HasValue);
            }
            
            if((formatString != null) && (((-1994778180) & 1) == 0))
            {
                    val_6 = "[not supported by provider]";
                return (string)System.String.Format(provider:  this, format:  formatString, arg0:  val.HasValue);
            }
            
            if((formatString == null) && (((-1994778180) & 1) != 0))
            {
                    string val_1 = 0.ToString();
                return (string)System.String.Format(provider:  this, format:  formatString, arg0:  val.HasValue);
            }
            
            val_6;
            val_5 = val_3;
            return (string)System.String.Format(provider:  this, format:  formatString, arg0:  val.HasValue);
        }
    
    }

}
