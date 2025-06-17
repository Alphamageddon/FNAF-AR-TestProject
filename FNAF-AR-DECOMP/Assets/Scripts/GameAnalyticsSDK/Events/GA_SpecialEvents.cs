using UnityEngine;

namespace GameAnalyticsSDK.Events
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class GA_SpecialEvents : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static int _frameCountAvg;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static float _lastUpdateAvg;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _frameCountCrit;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _lastUpdateCrit;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static int _criticalFpsCount;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Start()
        {
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.SubmitFPSRoutine());
            UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  this.CheckCriticalFPSRoutine());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.IEnumerator SubmitFPSRoutine()
        {
            .<>1__state = 0;
            return (System.Collections.IEnumerator)new GA_SpecialEvents.<SubmitFPSRoutine>d__6();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.IEnumerator CheckCriticalFPSRoutine()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new GA_SpecialEvents.<CheckCriticalFPSRoutine>d__7();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update()
        {
            var val_7;
            if(GameAnalyticsSDK.GameAnalytics.SettingsGA != 0)
            {
                    GameAnalyticsSDK.Setup.Settings val_3 = GameAnalyticsSDK.GameAnalytics.SettingsGA;
                if(val_3.SubmitFpsAverage != false)
            {
                    val_7 = null;
                val_7 = null;
                int val_7 = GameAnalyticsSDK.Events.GA_SpecialEvents._frameCountAvg;
                val_7 = val_7 + 1;
                GameAnalyticsSDK.Events.GA_SpecialEvents._frameCountAvg = val_7;
            }
            
            }
            
            if(GameAnalyticsSDK.GameAnalytics.SettingsGA == 0)
            {
                    return;
            }
            
            GameAnalyticsSDK.Setup.Settings val_6 = GameAnalyticsSDK.GameAnalytics.SettingsGA;
            if(val_6.SubmitFpsCritical == false)
            {
                    return;
            }
            
            int val_8 = this._frameCountCrit;
            val_8 = val_8 + 1;
            this._frameCountCrit = val_8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SubmitFPS()
        {
            var val_10;
            UnityEngine.Object val_12;
            var val_13;
            int val_14;
            if(GameAnalyticsSDK.GameAnalytics.SettingsGA != 0)
            {
                    GameAnalyticsSDK.Setup.Settings val_3 = GameAnalyticsSDK.GameAnalytics.SettingsGA;
                if(val_3.SubmitFpsAverage != false)
            {
                    float val_9 = UnityEngine.Time.unscaledTime;
                val_10 = null;
                val_10 = null;
                val_9 = val_9 - GameAnalyticsSDK.Events.GA_SpecialEvents._lastUpdateAvg;
                if(val_9 > 1f)
            {
                    val_9 = (float)GameAnalyticsSDK.Events.GA_SpecialEvents.__il2cppRuntimeField_static_fields / val_9;
                GameAnalyticsSDK.Events.GA_SpecialEvents._lastUpdateAvg = UnityEngine.Time.unscaledTime;
                GameAnalyticsSDK.Events.GA_SpecialEvents._frameCountAvg = 0;
                if(val_9 > 0f)
            {
                    GameAnalyticsSDK.GameAnalytics.NewDesignEvent(eventName:  "GA:AverageFPS", eventValue:  (float)(int)val_9);
            }
            
            }
            
            }
            
            }
            
            val_12 = GameAnalyticsSDK.GameAnalytics.SettingsGA;
            if(val_12 == 0)
            {
                    return;
            }
            
            val_12 = GameAnalyticsSDK.GameAnalytics.SettingsGA;
            if(val_8.SubmitFpsCritical == false)
            {
                    return;
            }
            
            val_12 = 1152921505332404224;
            val_13 = null;
            val_13 = null;
            val_14 = GameAnalyticsSDK.Events.GA_SpecialEvents._criticalFpsCount;
            if(val_14 < 1)
            {
                    return;
            }
            
            val_14 = GameAnalyticsSDK.Events.GA_SpecialEvents._criticalFpsCount;
            GameAnalyticsSDK.GameAnalytics.NewDesignEvent(eventName:  "GA:CriticalFPS", eventValue:  (float)val_14);
            GameAnalyticsSDK.Events.GA_SpecialEvents._criticalFpsCount = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void CheckCriticalFPS()
        {
            var val_8;
            var val_9;
            val_8 = this;
            if(GameAnalyticsSDK.GameAnalytics.SettingsGA == 0)
            {
                    return;
            }
            
            GameAnalyticsSDK.Setup.Settings val_3 = GameAnalyticsSDK.GameAnalytics.SettingsGA;
            if(val_3.SubmitFpsCritical == false)
            {
                    return;
            }
            
            float val_5 = UnityEngine.Time.unscaledTime - this._lastUpdateCrit;
            if(val_5 < 1f)
            {
                    return;
            }
            
            this._lastUpdateCrit = UnityEngine.Time.unscaledTime;
            this._frameCountCrit = 0;
            val_8 = GameAnalyticsSDK.GameAnalytics.SettingsGA;
            float val_8 = (float)this._frameCountCrit;
            val_8 = val_8 / val_5;
            if(val_8 > (float)val_7.FpsCriticalThreshold)
            {
                    return;
            }
            
            val_8 = 1152921505332404224;
            val_9 = null;
            val_9 = null;
            int val_9 = GameAnalyticsSDK.Events.GA_SpecialEvents._criticalFpsCount;
            val_9 = val_9 + 1;
            GameAnalyticsSDK.Events.GA_SpecialEvents._criticalFpsCount = val_9;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GA_SpecialEvents()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static GA_SpecialEvents()
        {
        
        }
    
    }

}
