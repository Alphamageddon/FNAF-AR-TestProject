using UnityEngine;

namespace Master
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PreTOSAcceptanceHandler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _eventExposer;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void DisableUnityAnalytics()
        {
            UnityEngine.Analytics.Analytics.enabled = false;
            UnityEngine.Analytics.Analytics.limitUserTracking = true;
            UnityEngine.Analytics.Analytics.deviceStatsEnabled = false;
            UnityEngine.Analytics.Analytics.initializeOnStartup = false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EnableUnityAnalytics()
        {
            UnityEngine.Analytics.Analytics.enabled = true;
            UnityEngine.Analytics.Analytics.limitUserTracking = false;
            UnityEngine.Analytics.Analytics.deviceStatsEnabled = true;
            UnityEngine.Analytics.Analytics.initializeOnStartup = true;
            UnityEngine.Analytics.AnalyticsResult val_1 = UnityEngine.Analytics.Analytics.ResumeInitialization();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EnableFBAnalytics()
        {
            var val_2;
            Facebook.Unity.InitDelegate val_4;
            val_2 = null;
            val_2 = null;
            val_4 = PreTOSAcceptanceHandler.<>c.<>9__3_0;
            if(val_4 == null)
            {
                    Facebook.Unity.InitDelegate val_1 = null;
                val_4 = val_1;
                val_1 = new Facebook.Unity.InitDelegate(object:  PreTOSAcceptanceHandler.<>c.__il2cppRuntimeField_static_fields, method:  System.Void PreTOSAcceptanceHandler.<>c::<EnableFBAnalytics>b__3_0());
                PreTOSAcceptanceHandler.<>c.<>9__3_0 = val_4;
            }
            
            Facebook.Unity.FB.Init(onInitComplete:  val_1, onHideUnity:  0, authResponse:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void DisableNecessaryComponentsBeforeToSAcceptance()
        {
            GameAnalyticsSDK.GameAnalytics.SetEnabledEventSubmission(enabled:  false);
            this.DisableUnityAnalytics();
            this._eventExposer.add_ToSAccepted(value:  new System.Action(object:  this, method:  System.Void Master.PreTOSAcceptanceHandler::EnableComponentsAfterToSAcceptance()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EnableComponentsAfterToSAcceptance()
        {
            GameAnalyticsSDK.GameAnalytics.SetEnabledEventSubmission(enabled:  true);
            this.EnableUnityAnalytics();
            this.EnableFBAnalytics();
            this._eventExposer.remove_ToSAccepted(value:  new System.Action(object:  this, method:  System.Void Master.PreTOSAcceptanceHandler::EnableComponentsAfterToSAcceptance()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PreTOSAcceptanceHandler(Master.EventExposer eventExposer)
        {
            this._eventExposer = eventExposer;
        }
    
    }

}
