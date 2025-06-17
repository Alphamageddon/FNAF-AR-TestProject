using UnityEngine;

namespace FlurrySDKInternal
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class FlurryAgentAndroid : FlurryAgent
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static UnityEngine.NetworkReachability internetReachability;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly string ORIGIN_NAME;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly string ORIGIN_VERSION;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static UnityEngine.AndroidJavaClass cls_FlurryAgent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static UnityEngine.AndroidJavaClass cls_FlurryAgentConstants;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void SetAge(int age)
        {
            null = null;
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(age != 0)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(age == 0)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = age;
            FlurrySDKInternal.FlurryAgentAndroid.cls_FlurryAgent.CallStatic(methodName:  "setAge", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void SetGender(FlurrySDK.Flurry.Gender gender)
        {
            var val_3;
            var val_4;
            UnityEngine.AndroidJavaClass val_5;
            string val_6;
            var val_7;
            var val_8;
            val_3 = null;
            if(gender != 0)
            {
                    val_4 = null;
                val_5 = FlurrySDKInternal.FlurryAgentAndroid.cls_FlurryAgentConstants;
                if(val_5 == null)
            {
                    val_5 = 0;
            }
            
                val_6 = "FEMALE";
            }
            else
            {
                    val_7 = null;
                val_5 = FlurrySDKInternal.FlurryAgentAndroid.cls_FlurryAgentConstants;
                if(val_5 == null)
            {
                    val_5 = 0;
            }
            
                val_6 = "MALE";
            }
            
            val_8 = null;
            val_8 = null;
            object[] val_2 = new object[1];
            val_2[0] = val_5.GetStatic<System.Byte>(fieldName:  val_6);
            FlurrySDKInternal.FlurryAgentAndroid.cls_FlurryAgent.CallStatic(methodName:  "setGender", args:  val_2);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void SetReportLocation(bool reportLocation)
        {
            var val_3;
            bool val_1 = reportLocation;
            val_3 = null;
            val_3 = null;
            object[] val_2 = new object[1];
            if(val_2 == null)
            {
                goto label_3;
            }
            
            if(val_1 == true)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(val_1 == false)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_2[0] = val_1;
            FlurrySDKInternal.FlurryAgentAndroid.cls_FlurryAgent.CallStatic(methodName:  "setReportLocation", args:  val_2);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void SetSessionOrigin(string originName, string deepLink)
        {
            null = null;
            object[] val_1 = new object[2];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(originName != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(originName == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = originName;
            val_1[1] = deepLink;
            FlurrySDKInternal.FlurryAgentAndroid.cls_FlurryAgent.CallStatic(methodName:  "setSessionOrigin", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void SetUserId(string userId)
        {
            null = null;
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(userId != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(userId == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = userId;
            FlurrySDKInternal.FlurryAgentAndroid.cls_FlurryAgent.CallStatic(methodName:  "setUserId", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void SetVersionName(string versionName)
        {
            null = null;
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(versionName != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(versionName == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = versionName;
            FlurrySDKInternal.FlurryAgentAndroid.cls_FlurryAgent.CallStatic(methodName:  "setVersionName", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void AddOrigin(string originName, string originVersion)
        {
            null = null;
            object[] val_1 = new object[2];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(originName != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(originName == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = originName;
            val_1[1] = originVersion;
            FlurrySDKInternal.FlurryAgentAndroid.cls_FlurryAgent.CallStatic(methodName:  "addOrigin", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void AddOrigin(string originName, string originVersion, System.Collections.Generic.IDictionary<string, string> originParameters)
        {
            null = null;
            object[] val_1 = new object[3];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(originName != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(originName == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = originName;
            val_1[1] = originVersion;
            val_1[2] = FlurrySDKInternal.FlurryAgentAndroid.ConvertMap(dictionary:  originParameters);
            FlurrySDKInternal.FlurryAgentAndroid.cls_FlurryAgent.CallStatic(methodName:  "addOrigin", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void AddSessionProperty(string name, string value)
        {
            null = null;
            object[] val_1 = new object[2];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(name != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(name == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = name;
            val_1[1] = value;
            FlurrySDKInternal.FlurryAgentAndroid.cls_FlurryAgent.CallStatic(methodName:  "addSessionProperty", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override int GetAgentVersion()
        {
            null = null;
            if(FlurrySDKInternal.FlurryAgentAndroid.cls_FlurryAgent != null)
            {
                    return FlurrySDKInternal.FlurryAgentAndroid.cls_FlurryAgent.CallStatic<System.Int32>(methodName:  "getAgentVersion", args:  System.Array.Empty<System.Object>());
            }
            
            return FlurrySDKInternal.FlurryAgentAndroid.cls_FlurryAgent.CallStatic<System.Int32>(methodName:  "getAgentVersion", args:  System.Array.Empty<System.Object>());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string GetReleaseVersion()
        {
            null = null;
            if(FlurrySDKInternal.FlurryAgentAndroid.cls_FlurryAgent != null)
            {
                    return FlurrySDKInternal.FlurryAgentAndroid.cls_FlurryAgent.CallStatic<System.String>(methodName:  "getReleaseVersion", args:  System.Array.Empty<System.Object>());
            }
            
            return FlurrySDKInternal.FlurryAgentAndroid.cls_FlurryAgent.CallStatic<System.String>(methodName:  "getReleaseVersion", args:  System.Array.Empty<System.Object>());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string GetSessionId()
        {
            null = null;
            if(FlurrySDKInternal.FlurryAgentAndroid.cls_FlurryAgent != null)
            {
                    return FlurrySDKInternal.FlurryAgentAndroid.cls_FlurryAgent.CallStatic<System.String>(methodName:  "getSessionId", args:  System.Array.Empty<System.Object>());
            }
            
            return FlurrySDKInternal.FlurryAgentAndroid.cls_FlurryAgent.CallStatic<System.String>(methodName:  "getSessionId", args:  System.Array.Empty<System.Object>());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override int LogEvent(string eventId)
        {
            null = null;
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(eventId != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(eventId == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = eventId;
            UnityEngine.AndroidJavaObject val_2 = FlurrySDKInternal.FlurryAgentAndroid.cls_FlurryAgent.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "logEvent", args:  val_1);
            if(val_2 != null)
            {
                    return val_2.Call<System.Int32>(methodName:  "ordinal", args:  System.Array.Empty<System.Object>());
            }
            
            return val_2.Call<System.Int32>(methodName:  "ordinal", args:  System.Array.Empty<System.Object>());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override int LogEvent(string eventId, bool timed)
        {
            null = null;
            object[] val_1 = new object[2];
            val_1[0] = eventId;
            val_1[1] = timed;
            return (int)FlurrySDKInternal.FlurryAgentAndroid.cls_FlurryAgent.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "logEvent", args:  val_1).Call<System.Int32>(methodName:  "ordinal", args:  System.Array.Empty<System.Object>());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override int LogEvent(string eventId, System.Collections.Generic.IDictionary<string, string> parameters)
        {
            null = null;
            object[] val_1 = new object[2];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(eventId != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(eventId == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = eventId;
            val_1[1] = FlurrySDKInternal.FlurryAgentAndroid.ConvertMap(dictionary:  parameters);
            UnityEngine.AndroidJavaObject val_3 = FlurrySDKInternal.FlurryAgentAndroid.cls_FlurryAgent.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "logEvent", args:  val_1);
            if(val_3 != null)
            {
                    return val_3.Call<System.Int32>(methodName:  "ordinal", args:  System.Array.Empty<System.Object>());
            }
            
            return val_3.Call<System.Int32>(methodName:  "ordinal", args:  System.Array.Empty<System.Object>());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override int LogEvent(string eventId, System.Collections.Generic.IDictionary<string, string> parameters, bool timed)
        {
            null = null;
            object[] val_1 = new object[3];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(eventId != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(eventId == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = eventId;
            val_1[1] = FlurrySDKInternal.FlurryAgentAndroid.ConvertMap(dictionary:  parameters);
            val_1[2] = timed;
            return (int)FlurrySDKInternal.FlurryAgentAndroid.cls_FlurryAgent.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "logEvent", args:  val_1).Call<System.Int32>(methodName:  "ordinal", args:  System.Array.Empty<System.Object>());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void EndTimedEvent(string eventId)
        {
            null = null;
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(eventId != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(eventId == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = eventId;
            FlurrySDKInternal.FlurryAgentAndroid.cls_FlurryAgent.CallStatic(methodName:  "endTimedEvent", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void EndTimedEvent(string eventId, System.Collections.Generic.IDictionary<string, string> parameters)
        {
            null = null;
            object[] val_1 = new object[2];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(eventId != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(eventId == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = eventId;
            val_1[1] = FlurrySDKInternal.FlurryAgentAndroid.ConvertMap(dictionary:  parameters);
            FlurrySDKInternal.FlurryAgentAndroid.cls_FlurryAgent.CallStatic(methodName:  "endTimedEvent", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void OnPageView()
        {
            null = null;
            FlurrySDKInternal.FlurryAgentAndroid.cls_FlurryAgent.CallStatic(methodName:  "onPageView", args:  System.Array.Empty<System.Object>());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void OnError(string errorId, string message, string errorClass)
        {
            null = null;
            object[] val_1 = new object[3];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(errorId != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(errorId == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = errorId;
            val_1[1] = message;
            val_1[2] = errorClass;
            FlurrySDKInternal.FlurryAgentAndroid.cls_FlurryAgent.CallStatic(methodName:  "onError", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void OnError(string errorId, string message, string errorClass, System.Collections.Generic.IDictionary<string, string> parameters)
        {
            null = null;
            object[] val_1 = new object[4];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(errorId != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(errorId == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = errorId;
            val_1[1] = message;
            val_1[2] = errorClass;
            val_1[3] = FlurrySDKInternal.FlurryAgentAndroid.ConvertMap(dictionary:  parameters);
            FlurrySDKInternal.FlurryAgentAndroid.cls_FlurryAgent.CallStatic(methodName:  "onError", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void LogBreadcrumb(string crashBreadcrumb)
        {
            null = null;
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(crashBreadcrumb != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(crashBreadcrumb == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = crashBreadcrumb;
            FlurrySDKInternal.FlurryAgentAndroid.cls_FlurryAgent.CallStatic(methodName:  "logBreadcrumb", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override int LogPayment(string productName, string productId, int quantity, double price, string currency, string transactionId, System.Collections.Generic.IDictionary<string, string> parameters)
        {
            null = null;
            object[] val_1 = new object[7];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(productName != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(productName == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = productName;
            val_1[1] = productId;
            val_1[2] = quantity;
            val_1[3] = price;
            val_1[4] = currency;
            val_1[5] = transactionId;
            val_1[6] = FlurrySDKInternal.FlurryAgentAndroid.ConvertMap(dictionary:  parameters);
            return (int)FlurrySDKInternal.FlurryAgentAndroid.cls_FlurryAgent.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "logPayment", args:  val_1).Call<System.Int32>(methodName:  "ordinal", args:  System.Array.Empty<System.Object>());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void SetIAPReportingEnabled(bool enableIAP)
        {
            UnityEngine.Debug.Log(message:  "setIAPReportingEnabled is not supported on Android. Please use LogPayment instead.");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static UnityEngine.AndroidJavaObject ConvertMap(System.Collections.Generic.IDictionary<string, string> dictionary)
        {
            System.Object[] val_10;
            var val_14;
            val_10 = System.Array.Empty<System.Object>();
            UnityEngine.AndroidJavaObject val_2 = new UnityEngine.AndroidJavaObject(className:  "java.util.HashMap", args:  val_10);
            if(dictionary == null)
            {
                    return val_2;
            }
            
            var val_13 = 0;
            val_13 = val_13 + 1;
            System.Collections.Generic.IEnumerator<T> val_4 = dictionary.GetEnumerator();
            label_25:
            var val_14 = 0;
            val_14 = val_14 + 1;
            if(val_4.MoveNext() == false)
            {
                goto label_11;
            }
            
            var val_15 = 0;
            val_15 = val_15 + 1;
            object[] val_9 = new object[2];
            val_9[0] = val_4.Current.emailUIDataHandler;
            val_9[1] = ;
            string val_11 = val_2.Call<System.String>(methodName:  "put", args:  val_9);
            goto label_25;
            label_11:
            val_10 = 0;
            val_14 = 93;
            if(val_4 == null)
            {
                
            }
            else
            {
                    var val_16 = 0;
                val_16 = val_16 + 1;
                val_4.Dispose();
            }
            
            if( == 93)
            {
                    return val_2;
            }
            
            if( == false)
            {
                    return val_2;
            }
            
            return val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void Dispose()
        {
            null = null;
            FlurrySDKInternal.FlurryAgentAndroid.cls_FlurryAgent.Dispose();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public FlurryAgentAndroid()
        {
            val_1 = new System.Object();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static FlurryAgentAndroid()
        {
            FlurrySDKInternal.FlurryAgentAndroid.internetReachability = UnityEngine.Application.internetReachability;
            FlurrySDKInternal.FlurryAgentAndroid.ORIGIN_NAME = "unity-flurry-sdk";
            FlurrySDKInternal.FlurryAgentAndroid.ORIGIN_VERSION = "1.1.0";
            FlurrySDKInternal.FlurryAgentAndroid.cls_FlurryAgent = new UnityEngine.AndroidJavaClass(className:  "com.flurry.android.FlurryAgent");
            FlurrySDKInternal.FlurryAgentAndroid.cls_FlurryAgentConstants = new UnityEngine.AndroidJavaClass(className:  "com.flurry.android.Constants");
        }
    
    }

}
