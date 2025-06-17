using UnityEngine;

namespace GameAnalyticsSDK.Events
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class GA_Progression
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void NewEvent(GameAnalyticsSDK.GAProgressionStatus progressionStatus, string progression01, System.Collections.Generic.IDictionary<string, object> fields)
        {
            GameAnalyticsSDK.Events.GA_Progression.CreateEvent(progressionStatus:  progressionStatus, progression01:  progression01, progression02:  0, progression03:  0, score:  new System.Nullable<System.Int32>() {HasValue = false}, fields:  fields);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void NewEvent(GameAnalyticsSDK.GAProgressionStatus progressionStatus, string progression01, string progression02, System.Collections.Generic.IDictionary<string, object> fields)
        {
            GameAnalyticsSDK.Events.GA_Progression.CreateEvent(progressionStatus:  progressionStatus, progression01:  progression01, progression02:  progression02, progression03:  0, score:  new System.Nullable<System.Int32>() {HasValue = false}, fields:  fields);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void NewEvent(GameAnalyticsSDK.GAProgressionStatus progressionStatus, string progression01, string progression02, string progression03, System.Collections.Generic.IDictionary<string, object> fields)
        {
            GameAnalyticsSDK.Events.GA_Progression.CreateEvent(progressionStatus:  progressionStatus, progression01:  progression01, progression02:  progression02, progression03:  progression03, score:  new System.Nullable<System.Int32>() {HasValue = false}, fields:  fields);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void NewEvent(GameAnalyticsSDK.GAProgressionStatus progressionStatus, string progression01, int score, System.Collections.Generic.IDictionary<string, object> fields)
        {
            GameAnalyticsSDK.Events.GA_Progression.CreateEvent(progressionStatus:  progressionStatus, progression01:  progression01, progression02:  0, progression03:  0, score:  new System.Nullable<System.Int32>() {HasValue = false}, fields:  fields);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void NewEvent(GameAnalyticsSDK.GAProgressionStatus progressionStatus, string progression01, string progression02, int score, System.Collections.Generic.IDictionary<string, object> fields)
        {
            GameAnalyticsSDK.Events.GA_Progression.CreateEvent(progressionStatus:  progressionStatus, progression01:  progression01, progression02:  progression02, progression03:  0, score:  new System.Nullable<System.Int32>() {HasValue = false}, fields:  fields);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void NewEvent(GameAnalyticsSDK.GAProgressionStatus progressionStatus, string progression01, string progression02, string progression03, int score, System.Collections.Generic.IDictionary<string, object> fields)
        {
            GameAnalyticsSDK.Events.GA_Progression.CreateEvent(progressionStatus:  progressionStatus, progression01:  progression01, progression02:  progression02, progression03:  progression03, score:  new System.Nullable<System.Int32>() {HasValue = false}, fields:  fields);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void CreateEvent(GameAnalyticsSDK.GAProgressionStatus progressionStatus, string progression01, string progression02, string progression03, System.Nullable<int> score, System.Collections.Generic.IDictionary<string, object> fields)
        {
            if((61329976 & 1) != 0)
            {
                    GameAnalyticsSDK.Wrapper.GA_Wrapper.AddProgressionEventWithScore(progressionStatus:  progressionStatus, progression01:  progression01, progression02:  progression02, progression03:  progression03, score:  61329976, fields:  fields);
                return;
            }
            
            GameAnalyticsSDK.Wrapper.GA_Wrapper.AddProgressionEvent(progressionStatus:  progressionStatus, progression01:  progression01, progression02:  progression02, progression03:  progression03, fields:  fields);
        }
    
    }

}
