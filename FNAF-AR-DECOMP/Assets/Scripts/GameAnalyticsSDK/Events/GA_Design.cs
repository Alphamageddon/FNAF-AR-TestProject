using UnityEngine;

namespace GameAnalyticsSDK.Events
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class GA_Design
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void NewEvent(string eventName, float eventValue, System.Collections.Generic.IDictionary<string, object> fields)
        {
            GameAnalyticsSDK.Events.GA_Design.CreateNewEvent(eventName:  eventName, eventValue:  new System.Nullable<System.Single>() {HasValue = false}, fields:  fields);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void NewEvent(string eventName, System.Collections.Generic.IDictionary<string, object> fields)
        {
            GameAnalyticsSDK.Events.GA_Design.CreateNewEvent(eventName:  eventName, eventValue:  new System.Nullable<System.Single>() {HasValue = false}, fields:  fields);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void CreateNewEvent(string eventName, System.Nullable<float> eventValue, System.Collections.Generic.IDictionary<string, object> fields)
        {
            if((60047560 & 1) != 0)
            {
                    GameAnalyticsSDK.Wrapper.GA_Wrapper.AddDesignEvent(eventID:  eventName, eventValue:  V0.16B, fields:  fields);
                return;
            }
            
            GameAnalyticsSDK.Wrapper.GA_Wrapper.AddDesignEvent(eventID:  eventName, fields:  fields);
        }
    
    }

}
