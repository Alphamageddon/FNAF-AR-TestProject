using UnityEngine;

namespace Systems.Analytics
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AnalyticsProxyRepeater : IAnalyticsProxy
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.Analytics.IAnalyticsProxy[] _targets;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnalyticsProxyRepeater(Systems.Analytics.IAnalyticsProxy[] targets)
        {
            this._targets = targets;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void FireEvent(Systems.Analytics.AnalyticsEventMode mode, string key)
        {
            goto label_1;
            label_10:
            var val_3 = 0;
            val_3 = val_3 + 1;
            this._targets[0].FireEvent(mode:  mode, key:  key);
            0 = 1;
            label_1:
            if(0 < this._targets.Length)
            {
                goto label_10;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void FireEventWithInt(Systems.Analytics.AnalyticsEventMode mode, string key, string intField, int intValue)
        {
            goto label_1;
            label_10:
            var val_3 = 0;
            val_3 = val_3 + 1;
            this._targets[0].FireEventWithInt(mode:  mode, key:  key, intField:  intField, intValue:  intValue);
            0 = 1;
            label_1:
            if(0 < this._targets.Length)
            {
                goto label_10;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void FireEventWithIntInt(Systems.Analytics.AnalyticsEventMode mode, string key, string intField1, int intValue1, string intField2, int intValue2)
        {
            goto label_1;
            label_10:
            var val_3 = 0;
            val_3 = val_3 + 1;
            this._targets[0].FireEventWithIntInt(mode:  mode, key:  key, intField1:  intField1, intValue1:  intValue1, intField2:  intField2, intValue2:  intValue2);
            0 = 1;
            label_1:
            if(0 < this._targets.Length)
            {
                goto label_10;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void FireEventWithStr(Systems.Analytics.AnalyticsEventMode mode, string key, string strField, string stringValue)
        {
            goto label_1;
            label_10:
            var val_3 = 0;
            val_3 = val_3 + 1;
            this._targets[0].FireEventWithStr(mode:  mode, key:  key, strField:  strField, stringValue:  stringValue);
            0 = 1;
            label_1:
            if(0 < this._targets.Length)
            {
                goto label_10;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void FireEventWithStrStr(Systems.Analytics.AnalyticsEventMode mode, string key, string strField1, string stringValue1, string strField2, string stringValue2)
        {
            goto label_1;
            label_10:
            var val_3 = 0;
            val_3 = val_3 + 1;
            this._targets[0].FireEventWithStrStr(mode:  mode, key:  key, strField1:  strField1, stringValue1:  stringValue1, strField2:  strField2, stringValue2:  stringValue2);
            0 = 1;
            label_1:
            if(0 < this._targets.Length)
            {
                goto label_10;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void FireEventWithStrStrStr(Systems.Analytics.AnalyticsEventMode mode, string key, string strField1, string stringValue1, string strField2, string stringValue2, string strField3, string stringValue3)
        {
            goto label_1;
            label_10:
            var val_3 = 0;
            val_3 = val_3 + 1;
            this._targets[0].FireEventWithStrStrStr(mode:  mode, key:  key, strField1:  strField1, stringValue1:  stringValue1, strField2:  strField2, stringValue2:  stringValue2, strField3:  strField3, stringValue3:  stringValue3);
            0 = 1;
            label_1:
            if(0 < this._targets.Length)
            {
                goto label_10;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void FireEventWithStrInt(Systems.Analytics.AnalyticsEventMode mode, string key, string strField, string stringValue, string intField, int intValue)
        {
            goto label_1;
            label_10:
            var val_3 = 0;
            val_3 = val_3 + 1;
            this._targets[0].FireEventWithStrInt(mode:  mode, key:  key, strField:  strField, stringValue:  stringValue, intField:  intField, intValue:  intValue);
            0 = 1;
            label_1:
            if(0 < this._targets.Length)
            {
                goto label_10;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void FireEventWithStrStrInt(Systems.Analytics.AnalyticsEventMode mode, string key, string strField1, string stringValue1, string strField2, string stringValue2, string intField, int intValue)
        {
            goto label_1;
            label_10:
            var val_3 = 0;
            val_3 = val_3 + 1;
            this._targets[0].FireEventWithStrStrInt(mode:  mode, key:  key, strField1:  strField1, stringValue1:  stringValue1, strField2:  strField2, stringValue2:  stringValue2, intField:  intField, intValue:  intValue);
            0 = 1;
            label_1:
            if(0 < this._targets.Length)
            {
                goto label_10;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void FireEventWithStrStrStrInt(Systems.Analytics.AnalyticsEventMode mode, string key, string strField1, string stringValue1, string strField2, string stringValue2, string strField3, string stringValue3, string intField, int intValue)
        {
            goto label_1;
            label_10:
            var val_3 = 0;
            val_3 = val_3 + 1;
            this._targets[0].FireEventWithStrStrStrInt(mode:  mode, key:  key, strField1:  strField1, stringValue1:  stringValue1, strField2:  strField2, stringValue2:  stringValue2, strField3:  strField3, stringValue3:  stringValue3, intField:  intField, intValue:  intValue);
            0 = 1;
            label_1:
            if(0 < this._targets.Length)
            {
                goto label_10;
            }
        
        }
    
    }

}
