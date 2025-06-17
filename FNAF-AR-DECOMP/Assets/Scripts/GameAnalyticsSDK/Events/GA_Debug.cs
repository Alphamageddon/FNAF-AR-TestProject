using UnityEngine;

namespace GameAnalyticsSDK.Events
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class GA_Debug
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static int MaxErrorCount;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static int _errorCount;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static bool _showLogOnGUI;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static System.Collections.Generic.List<string> Messages;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void HandleLog(string logString, string stackTrace, UnityEngine.LogType type)
        {
            string val_14;
            var val_15;
            var val_17;
            var val_18;
            string val_19;
            GameAnalyticsSDK.GAErrorSeverity val_20;
            val_14 = stackTrace;
            val_15 = null;
            val_15 = null;
            if(GameAnalyticsSDK.Events.GA_Debug._showLogOnGUI != false)
            {
                    val_15 = null;
                if(GameAnalyticsSDK.Events.GA_Debug.Messages == null)
            {
                    System.Collections.Generic.List<System.String> val_1 = new System.Collections.Generic.List<System.String>();
                val_15 = null;
                val_15 = null;
                GameAnalyticsSDK.Events.GA_Debug.Messages = val_1;
            }
            
                val_15 = null;
                val_1.Add(item:  logString);
            }
            
            GameAnalyticsSDK.Setup.Settings val_2 = GameAnalyticsSDK.GameAnalytics.SettingsGA;
            if(val_2.SubmitErrors == false)
            {
                    return;
            }
            
            val_17 = null;
            val_17 = null;
            if(type == 3)
            {
                    return;
            }
            
            if(GameAnalyticsSDK.Events.GA_Debug._errorCount >= GameAnalyticsSDK.Events.GA_Debug.MaxErrorCount)
            {
                    return;
            }
            
            if((System.String.IsNullOrEmpty(value:  val_14)) != false)
            {
                    System.Diagnostics.StackTrace val_4 = new System.Diagnostics.StackTrace();
                val_14 = val_4;
            }
            
            val_18 = null;
            val_18 = null;
            int val_14 = GameAnalyticsSDK.Events.GA_Debug._errorCount;
            val_14 = val_14 + 1;
            GameAnalyticsSDK.Events.GA_Debug._errorCount = val_14;
            val_19 = logString.Replace(oldChar:  '"', newChar:  ''').Replace(oldChar:  '
            ', newChar:  ' ').Replace(oldChar:  '', newChar:  ' ')(logString.Replace(oldChar:  '"', newChar:  ''').Replace(oldChar:  '
            ', newChar:  ' ').Replace(oldChar:  '', newChar:  ' ')) + " " + val_4.Replace(oldChar:  '"', newChar:  ''').Replace(oldChar:  '
            ', newChar:  ' ').Replace(oldChar:  '', newChar:  ' ')(val_4.Replace(oldChar:  '"', newChar:  ''').Replace(oldChar:  '
            ', newChar:  ' ').Replace(oldChar:  '', newChar:  ' '));
            if(val_19.Length > 8192)
            {
                    val_19 = val_19.Substring(startIndex:  8192);
            }
            
            if(type <= 4)
            {
                    val_20 = mem[52949824 + (type) << 2];
                val_20 = 52949824 + (type) << 2;
            }
            else
            {
                    val_20 = 2;
            }
            
            GameAnalyticsSDK.Events.GA_Error.CreateNewEvent(severity:  val_20, message:  val_19, fields:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void SubmitError(string message, UnityEngine.LogType type)
        {
            GameAnalyticsSDK.GAErrorSeverity val_1;
            if(type <= 4)
            {
                    val_1 = mem[52949824 + (type) << 2];
                val_1 = 52949824 + (type) << 2;
            }
            else
            {
                    val_1 = 2;
            }
            
            GameAnalyticsSDK.Events.GA_Error.CreateNewEvent(severity:  val_1, message:  message, fields:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void EnabledLog()
        {
            null = null;
            GameAnalyticsSDK.Events.GA_Debug._showLogOnGUI = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static GA_Debug()
        {
            GameAnalyticsSDK.Events.GA_Debug.MaxErrorCount = 10;
            GameAnalyticsSDK.Events.GA_Debug._errorCount = 0;
            GameAnalyticsSDK.Events.GA_Debug._showLogOnGUI = false;
        }
    
    }

}
