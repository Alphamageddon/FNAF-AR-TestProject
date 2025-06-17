using UnityEngine;

namespace Mapbox.Unity.Telemetry
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class TelemetryFallback : ITelemetryLibrary
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _url;
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
            return (Mapbox.Unity.Telemetry.ITelemetryLibrary)Mapbox.Unity.Telemetry.TelemetryFallback._instance;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Initialize(string accessToken)
        {
            this._url = System.String.Format(format:  "{0}events/v2?access_token={1}", arg0:  "https://events.mapbox.com/", arg1:  accessToken);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SendTurnstile()
        {
            System.DateTime val_1 = System.DateTime.Now;
            long val_2 = val_1.dateData.Ticks;
            bool val_3 = val_2.ShouldPostTurnstile(ticks:  val_2);
            if(val_3 == false)
            {
                    return;
            }
            
            this = this._url;
            string val_4 = val_3.GetPostBody();
            int val_6 = Mapbox.Unity.Utilities.Runnable.Run(routine:  val_4.PostWWW(url:  this, bodyJsonString:  val_4));
            UnityEngine.PlayerPrefs.SetString(key:  "MAPBOX_TELEMETRY_TURNSTILE_LAST_TICKS_FALLBACK", value:  val_2.ToString());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string GetPostBody()
        {
            System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String, System.Object>> val_1 = new System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String, System.Object>>();
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            System.DateTime val_3 = System.DateTime.UtcNow;
            val_2.Add(key:  "event", value:  "appUserTurnstile");
            val_2.Add(key:  "created", value:  (long)Mapbox.Utils.UnixTimestampUtils.To(date:  new System.DateTime() {dateData = val_3.dateData}));
            val_2.Add(key:  "userId", value:  UnityEngine.SystemInfo.deviceUniqueIdentifier);
            val_2.Add(key:  "enabled.telemetry", value:  null);
            val_1.Add(item:  val_2);
            return (string)Mapbox.Json.JsonConvert.SerializeObject(value:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool ShouldPostTurnstile(long ticks)
        {
            System.DateTime val_1 = System.DateTime.Now;
            System.DateTime val_2 = val_1.dateData.AddDays(value:  -100);
            bool val_7 = System.Int64.TryParse(s:  UnityEngine.PlayerPrefs.GetString(key:  "MAPBOX_TELEMETRY_TURNSTILE_LAST_TICKS_FALLBACK", defaultValue:  val_2.dateData.Ticks.ToString()), result: out  0);
            System.TimeSpan val_8 = System.DateTime.op_Subtraction(d1:  new System.DateTime(), d2:  new System.DateTime());
            return (bool)(val_8._ticks.Days > 0) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.IEnumerator PostWWW(string url, string bodyJsonString)
        {
            TelemetryFallback.<PostWWW>d__8 val_1 = new TelemetryFallback.<PostWWW>d__8();
            .<>1__state = 0;
            if(val_1 != null)
            {
                    .url = url;
            }
            else
            {
                    mem[40] = url;
            }
            
            .bodyJsonString = bodyJsonString;
            return (System.Collections.IEnumerator)val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static string GetUserAgent()
        {
            object[] val_1 = new object[5];
            string val_2 = UnityEngine.Application.identifier;
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
            val_1[1] = UnityEngine.Application.version;
            val_1[2] = "0";
            val_1[3] = UnityEngine.Application.platform;
            val_1[4] = "1.4.5";
            return (string)System.String.Format(format:  "{0}/{1}/{2} MapboxEventsUnity{3}/{4}", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetLocationCollectionState(bool enable)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TelemetryFallback()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static TelemetryFallback()
        {
            Mapbox.Unity.Telemetry.TelemetryFallback._instance = new Mapbox.Unity.Telemetry.TelemetryFallback();
        }
    
    }

}
