using UnityEngine;

namespace Systems.Analytics
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface IAnalyticsProxy
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void FireEvent(Systems.Analytics.AnalyticsEventMode mode, string key); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void FireEventWithInt(Systems.Analytics.AnalyticsEventMode mode, string key, string intField, int intValue); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void FireEventWithIntInt(Systems.Analytics.AnalyticsEventMode mode, string key, string intField1, int intValue1, string intField2, int intValue2); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void FireEventWithStr(Systems.Analytics.AnalyticsEventMode mode, string key, string strField, string stringValue); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void FireEventWithStrStr(Systems.Analytics.AnalyticsEventMode mode, string key, string strField1, string stringValue1, string strField2, string stringValue2); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void FireEventWithStrStrStr(Systems.Analytics.AnalyticsEventMode mode, string key, string strField1, string stringValue1, string strField2, string stringValue2, string strField3, string stringValue3); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void FireEventWithStrInt(Systems.Analytics.AnalyticsEventMode mode, string key, string strField, string stringValue, string intField, int intValue); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void FireEventWithStrStrInt(Systems.Analytics.AnalyticsEventMode mode, string key, string strField1, string stringValue1, string strField2, string stringValue2, string intField, int intValue); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void FireEventWithStrStrStrInt(Systems.Analytics.AnalyticsEventMode mode, string key, string strField1, string stringValue1, string strField2, string stringValue2, string strField3, string stringValue3, string intField, int intValue); // 0
    
    }

}
