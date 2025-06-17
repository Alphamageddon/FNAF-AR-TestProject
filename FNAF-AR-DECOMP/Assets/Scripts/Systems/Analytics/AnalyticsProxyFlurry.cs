using UnityEngine;

namespace Systems.Analytics
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AnalyticsProxyFlurry : IAnalyticsProxy
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<string, string> _payload;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly string GENERIC_SEND_STRING;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnalyticsProxyFlurry()
        {
            this._payload = new System.Collections.Generic.Dictionary<System.String, System.String>();
            Systems.Analytics.FlurryConfiguration val_2 = UnityEngine.Object.FindObjectOfType<Systems.Analytics.FlurryConfiguration>();
            new Flurry.Builder().WithCrashReporting(crashReporting:  true).WithLogEnabled(enableLog:  true).WithLogLevel(logLevel:  2).Build(apiKey:  val_2.FlurryAndroidApiKey);
            FlurrySDK.Flurry.SetReportLocation(reportLocation:  true);
            FlurrySDK.Flurry.SetVersionName(versionName:  UnityEngine.Application.version);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void FireEvent(Systems.Analytics.AnalyticsEventMode mode, string key)
        {
            if(mode == 2)
            {
                goto label_0;
            }
            
            if(mode == 1)
            {
                goto label_1;
            }
            
            if(mode != 0)
            {
                    return;
            }
            
            this.FireSimpleEvent(key:  key);
            return;
            label_0:
            this.EndSimpleTimedEvent(key:  key);
            return;
            label_1:
            this.StartSimpleTimedEvent(key:  key);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void FireEventWithInt(Systems.Analytics.AnalyticsEventMode mode, string key, string intField, int intValue)
        {
            this._payload.Clear();
            this._payload.set_Item(key:  intField, value:  intValue.ToString());
            this.FireEventWithPayload(mode:  mode, key:  key, payload:  this._payload);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void FireEventWithIntInt(Systems.Analytics.AnalyticsEventMode mode, string key, string intField1, int intValue1, string intField2, int intValue2)
        {
            this._payload.Clear();
            this._payload.set_Item(key:  intField1, value:  intValue1.ToString());
            this._payload.set_Item(key:  intField2, value:  intValue2.ToString());
            this.FireEventWithPayload(mode:  mode, key:  key, payload:  this._payload);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void FireEventWithStr(Systems.Analytics.AnalyticsEventMode mode, string key, string strField, string stringValue)
        {
            this._payload.Clear();
            this._payload.set_Item(key:  strField, value:  stringValue);
            this.FireEventWithPayload(mode:  mode, key:  key, payload:  this._payload);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void FireEventWithStrStr(Systems.Analytics.AnalyticsEventMode mode, string key, string strField1, string stringValue1, string strField2, string stringValue2)
        {
            this._payload.Clear();
            this._payload.set_Item(key:  strField1, value:  stringValue1);
            this._payload.set_Item(key:  strField2, value:  stringValue2);
            this.FireEventWithPayload(mode:  mode, key:  key, payload:  this._payload);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void FireEventWithStrStrStr(Systems.Analytics.AnalyticsEventMode mode, string key, string strField1, string stringValue1, string strField2, string stringValue2, string strField3, string stringValue3)
        {
            this._payload.Clear();
            this._payload.set_Item(key:  strField1, value:  stringValue1);
            this._payload.set_Item(key:  strField2, value:  stringValue2);
            this._payload.set_Item(key:  strField3, value:  stringValue3);
            this.FireEventWithPayload(mode:  mode, key:  key, payload:  this._payload);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void FireEventWithStrInt(Systems.Analytics.AnalyticsEventMode mode, string key, string strField, string stringValue, string intField, int intValue)
        {
            this._payload.Clear();
            this._payload.set_Item(key:  strField, value:  stringValue);
            this._payload.set_Item(key:  intField, value:  intValue.ToString());
            this.FireEventWithPayload(mode:  mode, key:  key, payload:  this._payload);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void FireEventWithStrStrInt(Systems.Analytics.AnalyticsEventMode mode, string key, string strField1, string stringValue1, string strField2, string stringValue2, string intField, int intValue)
        {
            this._payload.Clear();
            this._payload.set_Item(key:  strField1, value:  stringValue1);
            this._payload.set_Item(key:  strField2, value:  stringValue2);
            this._payload.set_Item(key:  intField, value:  intValue.ToString());
            this.FireEventWithPayload(mode:  mode, key:  key, payload:  this._payload);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void FireEventWithStrStrStrInt(Systems.Analytics.AnalyticsEventMode mode, string key, string strField1, string stringValue1, string strField2, string stringValue2, string strField3, string stringValue3, string intField, int intValue)
        {
            this._payload.Clear();
            this._payload.set_Item(key:  strField1, value:  stringValue1);
            this._payload.set_Item(key:  strField2, value:  stringValue2);
            this._payload.set_Item(key:  strField3, value:  stringValue3);
            this._payload.set_Item(key:  intField, value:  intValue.ToString());
            this.FireEventWithPayload(mode:  mode, key:  key, payload:  this._payload);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void FireEventWithPayload(Systems.Analytics.AnalyticsEventMode mode, string key, System.Collections.Generic.Dictionary<string, string> payload)
        {
            if(mode == 2)
            {
                goto label_0;
            }
            
            if(mode == 1)
            {
                goto label_1;
            }
            
            if(mode != 0)
            {
                    return;
            }
            
            this.FireEventWithPayload(key:  key, payload:  payload);
            return;
            label_0:
            this.EndTimedEventWithPayload(key:  key, payload:  payload);
            return;
            label_1:
            this.StartTimedEventWithPayload(key:  key, payload:  payload);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void FireSimpleEvent(string key)
        {
            EventRecordStatus val_1 = FlurrySDK.Flurry.LogEvent(eventId:  key);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void FireEventWithPayload(string key, System.Collections.Generic.Dictionary<string, string> payload)
        {
            EventRecordStatus val_1 = FlurrySDK.Flurry.LogEvent(eventId:  key, parameters:  payload);
            string val_2 = System.String.Join<System.Collections.Generic.KeyValuePair<System.String, System.String>>(separator:  ",", values:  payload);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void StartSimpleTimedEvent(string key)
        {
            EventRecordStatus val_1 = FlurrySDK.Flurry.LogEvent(eventId:  key, timed:  true);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void StartTimedEventWithPayload(string key, System.Collections.Generic.Dictionary<string, string> payload)
        {
            EventRecordStatus val_1 = FlurrySDK.Flurry.LogEvent(eventId:  key, timed:  true);
            string val_2 = System.String.Join<System.Collections.Generic.KeyValuePair<System.String, System.String>>(separator:  ",", values:  payload);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EndSimpleTimedEvent(string key)
        {
            FlurrySDK.Flurry.EndTimedEvent(eventId:  key);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EndTimedEventWithPayload(string key, System.Collections.Generic.Dictionary<string, string> payload)
        {
            FlurrySDK.Flurry.EndTimedEvent(eventId:  key, parameters:  payload);
            string val_1 = System.String.Join<System.Collections.Generic.KeyValuePair<System.String, System.String>>(separator:  ",", values:  payload);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static AnalyticsProxyFlurry()
        {
            Systems.Analytics.AnalyticsProxyFlurry.GENERIC_SEND_STRING = "Sent";
        }
    
    }

}
