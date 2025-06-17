using UnityEngine;

namespace Systems.Analytics
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AnalyticsProxyHistoryRecorder : IAnalyticsProxy
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.Analytics.AnalyticsHistory _history;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnalyticsProxyHistoryRecorder(Systems.Analytics.AnalyticsHistory history)
        {
            this._history = history;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void FireEvent(Systems.Analytics.AnalyticsEventMode mode, string key)
        {
            this._history.Log(mode:  mode, key:  key, metadata:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void FireEventWithInt(Systems.Analytics.AnalyticsEventMode mode, string key, string intField, int intValue)
        {
            System.Collections.Generic.Dictionary<System.String, System.String> val_1 = new System.Collections.Generic.Dictionary<System.String, System.String>();
            val_1.Add(key:  intField, value:  intValue.ToString());
            this._history.Log(mode:  mode, key:  key, metadata:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void FireEventWithIntInt(Systems.Analytics.AnalyticsEventMode mode, string key, string intField1, int intValue1, string intField2, int intValue2)
        {
            System.Collections.Generic.Dictionary<System.String, System.String> val_1 = new System.Collections.Generic.Dictionary<System.String, System.String>();
            val_1.Add(key:  intField1, value:  intValue1.ToString());
            val_1.Add(key:  intField2, value:  intValue2.ToString());
            this._history.Log(mode:  mode, key:  key, metadata:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void FireEventWithStr(Systems.Analytics.AnalyticsEventMode mode, string key, string strField, string stringValue)
        {
            System.Collections.Generic.Dictionary<System.String, System.String> val_1 = new System.Collections.Generic.Dictionary<System.String, System.String>();
            val_1.Add(key:  strField, value:  stringValue);
            this._history.Log(mode:  mode, key:  key, metadata:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void FireEventWithStrStr(Systems.Analytics.AnalyticsEventMode mode, string key, string strField1, string stringValue1, string strField2, string stringValue2)
        {
            System.Collections.Generic.Dictionary<System.String, System.String> val_1 = new System.Collections.Generic.Dictionary<System.String, System.String>();
            if(val_1 != null)
            {
                    val_1.Add(key:  strField1, value:  stringValue1);
            }
            else
            {
                    val_1.Add(key:  strField1, value:  stringValue1);
            }
            
            val_1.Add(key:  strField2, value:  stringValue2);
            this._history.Log(mode:  mode, key:  key, metadata:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void FireEventWithStrStrStr(Systems.Analytics.AnalyticsEventMode mode, string key, string strField1, string stringValue1, string strField2, string stringValue2, string strField3, string stringValue3)
        {
            System.Collections.Generic.Dictionary<System.String, System.String> val_1 = new System.Collections.Generic.Dictionary<System.String, System.String>();
            if(val_1 != null)
            {
                    val_1.Add(key:  strField1, value:  stringValue1);
            }
            else
            {
                    val_1.Add(key:  strField1, value:  stringValue1);
            }
            
            val_1.Add(key:  strField2, value:  stringValue2);
            val_1.Add(key:  strField3, value:  stringValue3);
            this._history.Log(mode:  mode, key:  key, metadata:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void FireEventWithStrInt(Systems.Analytics.AnalyticsEventMode mode, string key, string strField, string stringValue, string intField, int intValue)
        {
            System.Collections.Generic.Dictionary<System.String, System.String> val_1 = new System.Collections.Generic.Dictionary<System.String, System.String>();
            val_1.Add(key:  strField, value:  stringValue);
            val_1.Add(key:  intField, value:  intValue.ToString());
            this._history.Log(mode:  mode, key:  key, metadata:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void FireEventWithStrStrInt(Systems.Analytics.AnalyticsEventMode mode, string key, string strField1, string stringValue1, string strField2, string stringValue2, string intField, int intValue)
        {
            System.Collections.Generic.Dictionary<System.String, System.String> val_1 = new System.Collections.Generic.Dictionary<System.String, System.String>();
            if(val_1 != null)
            {
                    val_1.Add(key:  strField1, value:  stringValue1);
            }
            else
            {
                    val_1.Add(key:  strField1, value:  stringValue1);
            }
            
            val_1.Add(key:  strField2, value:  stringValue2);
            val_1.Add(key:  intField, value:  intValue.ToString());
            this._history.Log(mode:  mode, key:  key, metadata:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void FireEventWithStrStrStrInt(Systems.Analytics.AnalyticsEventMode mode, string key, string strField1, string stringValue1, string strField2, string stringValue2, string strField3, string stringValue3, string intField, int intValue)
        {
            System.Collections.Generic.Dictionary<System.String, System.String> val_1 = new System.Collections.Generic.Dictionary<System.String, System.String>();
            if(val_1 != null)
            {
                    val_1.Add(key:  strField1, value:  stringValue1);
            }
            else
            {
                    val_1.Add(key:  strField1, value:  stringValue1);
            }
            
            val_1.Add(key:  strField2, value:  stringValue2);
            val_1.Add(key:  strField3, value:  stringValue3);
            val_1.Add(key:  intField, value:  intValue.ToString());
            this._history.Log(mode:  mode, key:  key, metadata:  val_1);
        }
    
    }

}
