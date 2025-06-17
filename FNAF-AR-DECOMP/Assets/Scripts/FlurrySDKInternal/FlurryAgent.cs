using UnityEngine;

namespace FlurrySDKInternal
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract class FlurryAgent : IDisposable
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void SetAge(int age); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void SetGender(FlurrySDK.Flurry.Gender gender); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void SetReportLocation(bool reportLocation); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void SetSessionOrigin(string originName, string deepLink); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void SetUserId(string userId); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void SetVersionName(string versionName); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void AddOrigin(string originName, string originVersion); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void AddOrigin(string originName, string originVersion, System.Collections.Generic.IDictionary<string, string> originParameters); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void AddSessionProperty(string name, string value); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract int GetAgentVersion(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract string GetReleaseVersion(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract string GetSessionId(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract int LogEvent(string eventId); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract int LogEvent(string eventId, bool timed); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract int LogEvent(string eventId, System.Collections.Generic.IDictionary<string, string> parameters); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract int LogEvent(string eventId, System.Collections.Generic.IDictionary<string, string> parameters, bool timed); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void EndTimedEvent(string eventId); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void EndTimedEvent(string eventId, System.Collections.Generic.IDictionary<string, string> parameters); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void OnPageView(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void OnError(string errorId, string message, string errorClass); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void OnError(string errorId, string message, string errorClass, System.Collections.Generic.IDictionary<string, string> parameters); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void LogBreadcrumb(string crashBreadcrumb); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract int LogPayment(string productName, string productId, int quantity, double price, string currency, string transactionId, System.Collections.Generic.IDictionary<string, string> parameters); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void SetIAPReportingEnabled(bool enableIAP); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void Dispose(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected FlurryAgent()
        {
        
        }
    
    }

}
