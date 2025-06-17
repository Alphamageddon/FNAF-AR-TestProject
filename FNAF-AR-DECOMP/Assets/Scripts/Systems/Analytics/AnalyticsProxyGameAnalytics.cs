using UnityEngine;

namespace Systems.Analytics
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AnalyticsProxyGameAnalytics : IAnalyticsProxy
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameAnalyticsSDK.GameAnalytics _gameAnalyticsObject;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnalyticsProxyGameAnalytics()
        {
            this._gameAnalyticsObject = UnityEngine.Object.FindObjectOfType<GameAnalyticsSDK.GameAnalytics>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void FireEvent(Systems.Analytics.AnalyticsEventMode mode, string key)
        {
            this.FireProgressionEvent(mode:  mode, key:  key, meta1:  0, meta2:  0, score:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void FireEventWithInt(Systems.Analytics.AnalyticsEventMode mode, string key, string intField, int intValue)
        {
            this.FireProgressionEvent(mode:  mode, key:  key, meta1:  0, meta2:  0, score:  intValue);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void FireEventWithIntInt(Systems.Analytics.AnalyticsEventMode mode, string key, string intField1, int intValue1, string intField2, int intValue2)
        {
            string val_1 = intValue2.ToString();
            val_1.FireProgressionEvent(mode:  mode, key:  key, meta1:  val_1, meta2:  0, score:  intValue1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void FireEventWithStr(Systems.Analytics.AnalyticsEventMode mode, string key, string strField, string stringValue)
        {
            this.FireProgressionEvent(mode:  mode, key:  key, meta1:  stringValue, meta2:  0, score:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void FireEventWithStrStr(Systems.Analytics.AnalyticsEventMode mode, string key, string strField1, string stringValue1, string strField2, string stringValue2)
        {
            this.FireProgressionEvent(mode:  mode, key:  key, meta1:  stringValue1, meta2:  stringValue2, score:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void FireEventWithStrStrStr(Systems.Analytics.AnalyticsEventMode mode, string key, string strField1, string stringValue1, string strField2, string stringValue2, string strField3, string stringValue3)
        {
            string val_1 = stringValue2 + ":"(":") + stringValue3;
            val_1.FireProgressionEvent(mode:  mode, key:  key, meta1:  stringValue1, meta2:  val_1, score:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void FireEventWithStrInt(Systems.Analytics.AnalyticsEventMode mode, string key, string strField, string stringValue, string intField, int intValue)
        {
            this.FireProgressionEvent(mode:  mode, key:  key, meta1:  stringValue, meta2:  0, score:  intValue);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void FireEventWithStrStrInt(Systems.Analytics.AnalyticsEventMode mode, string key, string strField1, string stringValue1, string strField2, string stringValue2, string intField, int intValue)
        {
            this.FireProgressionEvent(mode:  mode, key:  key, meta1:  stringValue1, meta2:  stringValue2, score:  intValue);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void FireEventWithStrStrStrInt(Systems.Analytics.AnalyticsEventMode mode, string key, string strField1, string stringValue1, string strField2, string stringValue2, string strField3, string stringValue3, string intField, int intValue)
        {
            string val_1 = stringValue2 + ":"(":") + stringValue3;
            val_1.FireProgressionEvent(mode:  mode, key:  key, meta1:  stringValue1, meta2:  val_1, score:  intValue);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void FireProgressionEvent(Systems.Analytics.AnalyticsEventMode mode, string key, string meta1, string meta2, int score)
        {
            GameAnalyticsSDK.GAProgressionStatus val_1;
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
            
            GameAnalyticsSDK.GameAnalytics.NewProgressionEvent(progressionStatus:  1, progression01:  key, progression02:  meta1, progression03:  meta2, score:  score);
            label_0:
            val_1 = 2;
            goto label_3;
            label_1:
            val_1 = 1;
            label_3:
            GameAnalyticsSDK.GameAnalytics.NewProgressionEvent(progressionStatus:  val_1, progression01:  key, progression02:  meta1, progression03:  meta2, score:  score);
        }
    
    }

}
