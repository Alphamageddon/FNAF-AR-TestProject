using UnityEngine;

namespace Mapbox.Platform
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Response
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Platform.IAsyncRequest <Request>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool LoadedFromCache;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsUpdate;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string RequestUrl;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<int> StatusCode;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ContentType;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<int> XRateLimitInterval;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<long> XRateLimitLimit;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<System.DateTime> XRateLimitReset;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<System.Exception> _exceptions;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, string> Headers;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public byte[] Data;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Platform.IAsyncRequest Request { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool RateLimitHit { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool HasError { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.ObjectModel.ReadOnlyCollection<System.Exception> Exceptions { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ExceptionsAsString { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Response()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Platform.IAsyncRequest get_Request()
        {
            return (Mapbox.Platform.IAsyncRequest)this.<Request>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_Request(Mapbox.Platform.IAsyncRequest value)
        {
            this.<Request>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_RateLimitHit()
        {
            var val_2;
            if((this.StatusCode & 1) != 0)
            {
                    var val_1 = (this.StatusCode == 429) ? 1 : 0;
                return (bool)val_2;
            }
            
            val_2 = 0;
            return (bool)val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_HasError()
        {
            if(this._exceptions == null)
            {
                    return (bool)(this._exceptions.Count > 0) ? 1 : 0;
            }
            
            return (bool)(this._exceptions.Count > 0) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.ObjectModel.ReadOnlyCollection<System.Exception> get_Exceptions()
        {
            if(this._exceptions == null)
            {
                    return (System.Collections.ObjectModel.ReadOnlyCollection<System.Exception>)this._exceptions.AsReadOnly();
            }
            
            return (System.Collections.ObjectModel.ReadOnlyCollection<System.Exception>)this._exceptions.AsReadOnly();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_ExceptionsAsString()
        {
            var val_6;
            System.Func<System.Exception, System.String> val_8;
            if(this._exceptions == null)
            {
                    return (string)System.String.alignConst;
            }
            
            if(this._exceptions.Count == 0)
            {
                    return (string)System.String.alignConst;
            }
            
            val_6 = null;
            val_6 = null;
            val_8 = Response.<>c.<>9__21_0;
            if(val_8 != null)
            {
                    return System.String.Join(separator:  System.Environment.NewLine, value:  System.Linq.Enumerable.ToArray<System.String>(source:  System.Linq.Enumerable.Select<System.Exception, System.String>(source:  this._exceptions, selector:  System.Func<System.Exception, System.String> val_3 = null)));
            }
            
            val_8 = val_3;
            val_3 = new System.Func<System.Exception, System.String>(object:  Response.<>c.__il2cppRuntimeField_static_fields, method:  System.String Response.<>c::<get_ExceptionsAsString>b__21_0(System.Exception e));
            Response.<>c.<>9__21_0 = val_8;
            return System.String.Join(separator:  System.Environment.NewLine, value:  System.Linq.Enumerable.ToArray<System.String>(source:  System.Linq.Enumerable.Select<System.Exception, System.String>(source:  this._exceptions, selector:  val_3)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AddException(System.Exception ex)
        {
            System.Collections.Generic.List<System.Exception> val_2 = this._exceptions;
            if(val_2 == null)
            {
                    System.Collections.Generic.List<System.Exception> val_1 = null;
                val_2 = val_1;
                val_1 = new System.Collections.Generic.List<System.Exception>();
                this._exceptions = val_2;
            }
            
            val_1.Add(item:  ex);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Mapbox.Platform.Response FromCache(byte[] data)
        {
            Mapbox.Platform.Response val_1 = new Mapbox.Platform.Response();
            if(val_1 != null)
            {
                    .Data = data;
            }
            else
            {
                    mem[112] = data;
            }
            
            .LoadedFromCache = true;
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Mapbox.Platform.Response FromWebResponse(Mapbox.Platform.IAsyncRequest request, UnityEngine.Networking.UnityWebRequest apiResponse, System.Exception apiEx)
        {
            System.Nullable<System.Int32> val_16;
            System.Exception val_41;
            var val_42;
            var val_44;
            Mapbox.Platform.Response val_1 = new Mapbox.Platform.Response();
            .<Request>k__BackingField = request;
            if(apiEx != null)
            {
                    val_1.AddException(ex:  apiEx);
            }
            
            if(apiResponse.isNetworkError != false)
            {
                    if((System.String.IsNullOrEmpty(value:  apiResponse.error)) != true)
            {
                    System.Exception val_6 = null;
                val_41 = val_6;
                val_6 = new System.Exception(message:  apiResponse.error);
                val_1.AddException(ex:  val_6);
            }
            
            }
            
            val_42 = 1152921505127505920;
            var val_42 = 0;
            val_42 = val_42 + 1;
            if(request.RequestType != 1)
            {
                    if(apiResponse.downloadHandler.data == null)
            {
                goto label_16;
            }
            
            }
            
            if(apiResponse != null)
            {
                goto label_42;
            }
            
            label_43:
            label_42:
            System.Collections.Generic.Dictionary<System.String, System.String> val_11 = apiResponse.GetResponseHeaders();
            if(val_11 == null)
            {
                goto label_59;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.String> val_12 = null;
            val_41 = val_12;
            val_12 = new System.Collections.Generic.Dictionary<System.String, System.String>();
            .Headers = val_41;
            Dictionary.Enumerator<TKey, TValue> val_13 = val_11.GetEnumerator();
            val_44 = 1152921515881770608;
            goto label_37;
            label_38:
            UnityEngine.XR.ARSubsystems.TrackableId val_17 = val_16.trackableId;
            val_41 = val_17.m_SubId1.System.IConvertible.ToUInt64(provider:  public System.String System.Collections.Generic.KeyValuePair<System.String, System.String>::get_Key());
            (Mapbox.Platform.Response)[1152921519953549952].Headers.Add(key:  val_41, value:  val_17.m_SubId1);
            if((val_41.Equals(value:  "X-Rate-Limit-Interval", comparisonType:  3)) == false)
            {
                goto label_23;
            }
            
            if((System.Int32.TryParse(s:  val_17.m_SubId1, result: out  0)) == false)
            {
                goto label_37;
            }
            
            val_16 = 0;
            .XRateLimitInterval = val_16;
            goto label_37;
            label_23:
            if((val_41.Equals(value:  "X-Rate-Limit-Limit", comparisonType:  3)) == false)
            {
                goto label_27;
            }
            
            if((System.Int64.TryParse(s:  val_17.m_SubId1, result: out  0)) == false)
            {
                goto label_37;
            }
            
            val_16 = 0;
            .XRateLimitLimit = val_16;
            mem[1152921519953550024] = 0;
            goto label_37;
            label_27:
            if((val_41.Equals(value:  "X-Rate-Limit-Reset", comparisonType:  3)) == false)
            {
                goto label_31;
            }
            
            if((System.Double.TryParse(s:  val_17.m_SubId1, result: out  double val_26 = 1.28823414374274E-231)) == false)
            {
                goto label_37;
            }
            
            System.DateTime val_28 = Mapbox.Utils.UnixTimestampUtils.From(timestamp:  0);
            val_16 = 0;
            .XRateLimitReset = val_16;
            mem[1152921519953550040] = 0;
            goto label_37;
            label_31:
            if((val_41.Equals(value:  "Content-Type", comparisonType:  3)) != false)
            {
                    .ContentType = ;
            }
            
            label_37:
            if(((-1833222640) & 1) != 0)
            {
                goto label_38;
            }
            
            long val_30 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519953493520});
            val_42 = 1152921505127505920;
            if(apiResponse != null)
            {
                goto label_60;
            }
            
            goto label_40;
            label_16:
            val_1.AddException(ex:  new System.Exception(message:  "Response has no data."));
            if(apiResponse != null)
            {
                goto label_42;
            }
            
            goto label_43;
            label_59:
            if(apiResponse != null)
            {
                goto label_60;
            }
            
            label_40:
            label_60:
            long val_33 = apiResponse.responseCode;
            val_16 = 0;
            .StatusCode = val_16;
            if(val_33 != 200)
            {
                    val_16 = apiResponse.responseCode;
                val_44 = 1152921504618721280;
                val_41 = System.String.Format(format:  "Status Code {0}", arg0:  val_16);
                val_1.AddException(ex:  new System.Exception(message:  val_41));
                if(val_33 == 429)
            {
                    val_1.AddException(ex:  new System.Exception(message:  "Rate limit hit"));
            }
            
            }
            
            var val_43 = 0;
            val_43 = val_43 + 1;
            if(request.RequestType == 1)
            {
                    return val_1;
            }
            
            .Data = apiResponse.downloadHandler.data;
            return val_1;
        }
    
    }

}
