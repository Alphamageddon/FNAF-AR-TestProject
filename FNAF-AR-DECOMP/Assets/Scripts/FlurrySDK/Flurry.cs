using UnityEngine;

namespace FlurrySDK
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Flurry : IDisposable
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static FlurrySDKInternal.FlurryAgent flurryAgent;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static Flurry()
        {
            if(UnityEngine.Application.platform != 11)
            {
                    return;
            }
            
            FlurrySDK.Flurry.flurryAgent = new FlurrySDKInternal.FlurryAgentAndroid();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetAge(int age)
        {
            var val_5;
            var val_6;
            FlurrySDKInternal.FlurryAgent val_7;
            val_5 = age;
            val_6 = null;
            val_6 = null;
            val_7 = FlurrySDK.Flurry.flurryAgent;
            if(val_7 == null)
            {
                    return;
            }
            
            val_7 = FlurrySDK.Flurry.flurryAgent;
            if(val_7 != null)
            {
                    val_5 = ???;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetGender(FlurrySDK.Flurry.Gender gender)
        {
            var val_5;
            var val_6;
            FlurrySDKInternal.FlurryAgent val_7;
            val_5 = gender;
            val_6 = null;
            val_6 = null;
            val_7 = FlurrySDK.Flurry.flurryAgent;
            if(val_7 == null)
            {
                    return;
            }
            
            val_7 = FlurrySDK.Flurry.flurryAgent;
            if(val_7 != null)
            {
                    val_5 = ???;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetReportLocation(bool reportLocation)
        {
            var val_6;
            var val_7;
            FlurrySDKInternal.FlurryAgent val_8;
            val_6 = reportLocation;
            val_7 = null;
            val_7 = null;
            val_8 = FlurrySDK.Flurry.flurryAgent;
            if(val_8 == null)
            {
                    return;
            }
            
            val_8 = FlurrySDK.Flurry.flurryAgent;
            if(val_8 != null)
            {
                    bool val_1 = val_6;
                val_6 = ???;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetSessionOrigin(string originName, string deepLink)
        {
            var val_6;
            var val_7;
            FlurrySDKInternal.FlurryAgent val_8;
            val_6 = deepLink;
            val_7 = null;
            val_7 = null;
            val_8 = FlurrySDK.Flurry.flurryAgent;
            if(val_8 == null)
            {
                    return;
            }
            
            val_8 = FlurrySDK.Flurry.flurryAgent;
            if(val_8 != null)
            {
                    val_6 = ???;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetUserId(string userId)
        {
            var val_5;
            var val_6;
            FlurrySDKInternal.FlurryAgent val_7;
            val_5 = userId;
            val_6 = null;
            val_6 = null;
            val_7 = FlurrySDK.Flurry.flurryAgent;
            if(val_7 == null)
            {
                    return;
            }
            
            val_7 = FlurrySDK.Flurry.flurryAgent;
            if(val_7 != null)
            {
                    val_5 = ???;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetVersionName(string versionName)
        {
            var val_5;
            var val_6;
            FlurrySDKInternal.FlurryAgent val_7;
            val_5 = versionName;
            val_6 = null;
            val_6 = null;
            val_7 = FlurrySDK.Flurry.flurryAgent;
            if(val_7 == null)
            {
                    return;
            }
            
            val_7 = FlurrySDK.Flurry.flurryAgent;
            if(val_7 != null)
            {
                    val_5 = ???;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void AddOrigin(string originName, string originVersion)
        {
            var val_6;
            var val_7;
            FlurrySDKInternal.FlurryAgent val_8;
            val_6 = originVersion;
            val_7 = null;
            val_7 = null;
            val_8 = FlurrySDK.Flurry.flurryAgent;
            if(val_8 == null)
            {
                    return;
            }
            
            val_8 = FlurrySDK.Flurry.flurryAgent;
            if(val_8 != null)
            {
                    val_6 = ???;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void AddOrigin(string originName, string originVersion, System.Collections.Generic.IDictionary<string, string> originParameters)
        {
            var val_7;
            var val_8;
            var val_9;
            FlurrySDKInternal.FlurryAgent val_10;
            val_7 = originParameters;
            val_8 = originName;
            val_9 = null;
            val_9 = null;
            val_10 = FlurrySDK.Flurry.flurryAgent;
            if(val_10 == null)
            {
                    return;
            }
            
            val_10 = FlurrySDK.Flurry.flurryAgent;
            if(val_10 != null)
            {
                    val_7 = ???;
                val_8 = ???;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void AddSessionProperty(string name, string value)
        {
            var val_6;
            var val_7;
            FlurrySDKInternal.FlurryAgent val_8;
            val_6 = value;
            val_7 = null;
            val_7 = null;
            val_8 = FlurrySDK.Flurry.flurryAgent;
            if(val_8 == null)
            {
                    return;
            }
            
            val_8 = FlurrySDK.Flurry.flurryAgent;
            if(val_8 != null)
            {
                    val_6 = ???;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static int GetAgentVersion()
        {
            var val_4;
            FlurrySDKInternal.FlurryAgent val_5;
            val_4 = null;
            val_4 = null;
            val_5 = FlurrySDK.Flurry.flurryAgent;
            if(val_5 == null)
            {
                    return 0;
            }
            
            val_5 = FlurrySDK.Flurry.flurryAgent;
            if(val_5 != null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string GetReleaseVersion()
        {
            var val_4;
            FlurrySDKInternal.FlurryAgent val_5;
            val_4 = null;
            val_4 = null;
            val_5 = FlurrySDK.Flurry.flurryAgent;
            if(val_5 == null)
            {
                    return 0;
            }
            
            val_5 = FlurrySDK.Flurry.flurryAgent;
            if(val_5 != null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string GetSessionId()
        {
            var val_4;
            FlurrySDKInternal.FlurryAgent val_5;
            val_4 = null;
            val_4 = null;
            val_5 = FlurrySDK.Flurry.flurryAgent;
            if(val_5 == null)
            {
                    return 0;
            }
            
            val_5 = FlurrySDK.Flurry.flurryAgent;
            if(val_5 != null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static FlurrySDK.Flurry.EventRecordStatus LogEvent(string eventId)
        {
            var val_5;
            var val_6;
            FlurrySDKInternal.FlurryAgent val_7;
            val_5 = eventId;
            val_6 = null;
            val_6 = null;
            val_7 = FlurrySDK.Flurry.flurryAgent;
            if(val_7 == null)
            {
                    return 1;
            }
            
            val_7 = FlurrySDK.Flurry.flurryAgent;
            if(val_7 != null)
            {
                    val_5 = ???;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static FlurrySDK.Flurry.EventRecordStatus LogEvent(string eventId, bool timed)
        {
            var val_7;
            var val_8;
            FlurrySDKInternal.FlurryAgent val_9;
            val_7 = timed;
            val_8 = null;
            val_8 = null;
            val_9 = FlurrySDK.Flurry.flurryAgent;
            if(val_9 == null)
            {
                    return 1;
            }
            
            val_9 = FlurrySDK.Flurry.flurryAgent;
            if(val_9 != null)
            {
                    bool val_1 = val_7;
                val_7 = ???;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static FlurrySDK.Flurry.EventRecordStatus LogEvent(string eventId, System.Collections.Generic.IDictionary<string, string> parameters)
        {
            var val_6;
            var val_7;
            FlurrySDKInternal.FlurryAgent val_8;
            val_6 = parameters;
            val_7 = null;
            val_7 = null;
            val_8 = FlurrySDK.Flurry.flurryAgent;
            if(val_8 == null)
            {
                    return 1;
            }
            
            val_8 = FlurrySDK.Flurry.flurryAgent;
            if(val_8 != null)
            {
                    val_6 = ???;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static FlurrySDK.Flurry.EventRecordStatus LogEvent(string eventId, System.Collections.Generic.IDictionary<string, string> parameters, bool timed)
        {
            var val_8;
            var val_9;
            var val_10;
            FlurrySDKInternal.FlurryAgent val_11;
            val_8 = parameters;
            val_9 = eventId;
            val_10 = null;
            val_10 = null;
            val_11 = FlurrySDK.Flurry.flurryAgent;
            if(val_11 == null)
            {
                    return 1;
            }
            
            val_11 = FlurrySDK.Flurry.flurryAgent;
            if(val_11 != null)
            {
                    bool val_1 = timed;
                val_8 = ???;
                val_9 = ???;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void EndTimedEvent(string eventId)
        {
            var val_5;
            var val_6;
            FlurrySDKInternal.FlurryAgent val_7;
            val_5 = eventId;
            val_6 = null;
            val_6 = null;
            val_7 = FlurrySDK.Flurry.flurryAgent;
            if(val_7 == null)
            {
                    return;
            }
            
            val_7 = FlurrySDK.Flurry.flurryAgent;
            if(val_7 != null)
            {
                    val_5 = ???;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void EndTimedEvent(string eventId, System.Collections.Generic.IDictionary<string, string> parameters)
        {
            var val_6;
            var val_7;
            FlurrySDKInternal.FlurryAgent val_8;
            val_6 = parameters;
            val_7 = null;
            val_7 = null;
            val_8 = FlurrySDK.Flurry.flurryAgent;
            if(val_8 == null)
            {
                    return;
            }
            
            val_8 = FlurrySDK.Flurry.flurryAgent;
            if(val_8 != null)
            {
                    val_6 = ???;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void OnPageView()
        {
            var val_4;
            FlurrySDKInternal.FlurryAgent val_5;
            val_4 = null;
            val_4 = null;
            val_5 = FlurrySDK.Flurry.flurryAgent;
            if(val_5 == null)
            {
                    return;
            }
            
            val_5 = FlurrySDK.Flurry.flurryAgent;
            if(val_5 != null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void OnError(string errorId, string message, string errorClass)
        {
            var val_7;
            var val_8;
            var val_9;
            FlurrySDKInternal.FlurryAgent val_10;
            val_7 = errorClass;
            val_8 = errorId;
            val_9 = null;
            val_9 = null;
            val_10 = FlurrySDK.Flurry.flurryAgent;
            if(val_10 == null)
            {
                    return;
            }
            
            val_10 = FlurrySDK.Flurry.flurryAgent;
            if(val_10 != null)
            {
                    val_7 = ???;
                val_8 = ???;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void OnError(string errorId, string message, string errorClass, System.Collections.Generic.IDictionary<string, string> parameters)
        {
            var val_8;
            var val_9;
            var val_10;
            FlurrySDKInternal.FlurryAgent val_11;
            val_8 = parameters;
            val_9 = message;
            val_10 = null;
            val_10 = null;
            val_11 = FlurrySDK.Flurry.flurryAgent;
            if(val_11 == null)
            {
                    return;
            }
            
            val_11 = FlurrySDK.Flurry.flurryAgent;
            if(val_11 != null)
            {
                    val_8 = ???;
                val_9 = ???;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void LogBreadcrumb(string crashBreadcrumb)
        {
            var val_5;
            var val_6;
            FlurrySDKInternal.FlurryAgent val_7;
            val_5 = crashBreadcrumb;
            val_6 = null;
            val_6 = null;
            val_7 = FlurrySDK.Flurry.flurryAgent;
            if(val_7 == null)
            {
                    return;
            }
            
            val_7 = FlurrySDK.Flurry.flurryAgent;
            if(val_7 != null)
            {
                    val_5 = ???;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static FlurrySDK.Flurry.EventRecordStatus LogPayment(string productName, string productId, int quantity, double price, string currency, string transactionId, System.Collections.Generic.IDictionary<string, string> parameters)
        {
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            FlurrySDKInternal.FlurryAgent val_15;
            val_11 = parameters;
            val_12 = currency;
            val_13 = productId;
            val_14 = null;
            val_14 = null;
            val_15 = FlurrySDK.Flurry.flurryAgent;
            if(val_15 == null)
            {
                    return 1;
            }
            
            val_15 = FlurrySDK.Flurry.flurryAgent;
            if(val_15 != null)
            {
                    val_11 = ???;
                val_12 = ???;
                val_13 = ???;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetIAPReportingEnabled(bool enableIAP)
        {
            var val_6;
            var val_7;
            FlurrySDKInternal.FlurryAgent val_8;
            val_6 = enableIAP;
            val_7 = null;
            val_7 = null;
            val_8 = FlurrySDK.Flurry.flurryAgent;
            if(val_8 == null)
            {
                    return;
            }
            
            val_8 = FlurrySDK.Flurry.flurryAgent;
            if(val_8 != null)
            {
                    bool val_1 = val_6;
                val_6 = ???;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Dispose()
        {
            var val_4;
            FlurrySDKInternal.FlurryAgent val_5;
            val_4 = null;
            val_4 = null;
            val_5 = FlurrySDK.Flurry.flurryAgent;
            if(val_5 == null)
            {
                    return;
            }
            
            val_5 = FlurrySDK.Flurry.flurryAgent;
            if(val_5 != null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Flurry()
        {
        
        }
    
    }

}
