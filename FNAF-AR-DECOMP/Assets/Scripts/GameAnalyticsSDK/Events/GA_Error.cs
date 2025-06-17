using UnityEngine;

namespace GameAnalyticsSDK.Events
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class GA_Error
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void NewEvent(GameAnalyticsSDK.GAErrorSeverity severity, string message, System.Collections.Generic.IDictionary<string, object> fields)
        {
            GameAnalyticsSDK.Events.GA_Error.CreateNewEvent(severity:  severity, message:  message, fields:  fields);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void CreateNewEvent(GameAnalyticsSDK.GAErrorSeverity severity, string message, System.Collections.Generic.IDictionary<string, object> fields)
        {
            GameAnalyticsSDK.Wrapper.GA_Wrapper.AddErrorEvent(severity:  severity, message:  message, fields:  fields);
        }
    
    }

}
