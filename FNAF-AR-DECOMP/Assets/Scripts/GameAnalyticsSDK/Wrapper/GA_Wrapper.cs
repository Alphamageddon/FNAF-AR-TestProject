using UnityEngine;

namespace GameAnalyticsSDK.Wrapper
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class GA_Wrapper
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly UnityEngine.AndroidJavaClass GA;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly UnityEngine.AndroidJavaClass UNITY_GA;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly UnityEngine.AndroidJavaClass GA_IMEI;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void configureAvailableCustomDimensions01(string list)
        {
            var val_9;
            var val_10;
            var val_11;
            var val_14;
            var val_15;
            var val_17;
            if(list != null)
            {
                    val_9 = GA_MiniJSON.Parser.Parse(jsonString:  list);
            }
            else
            {
                    val_9 = 0;
            }
            
            System.Collections.ArrayList val_2 = new System.Collections.ArrayList();
            val_10 = null;
            var val_13 = 1179403647;
            if(mem[282584257676957] == 0)
            {
                goto label_4;
            }
            
            var val_11 = mem[282584257676847];
            var val_12 = 0;
            val_11 = val_11 + 8;
            label_6:
            if(((mem[282584257676847] + 8) + -8) == null)
            {
                goto label_5;
            }
            
            val_12 = val_12 + 1;
            val_11 = val_11 + 16;
            if(val_12 < mem[282584257676957])
            {
                goto label_6;
            }
            
            label_4:
            val_10 = null;
            goto label_7;
            label_5:
            val_13 = val_13 + (((mem[282584257676847] + 8)) << 4);
            val_11 = val_13 + 296;
            label_7:
            System.Collections.Generic.IEnumerator<T> val_3 = val_9.GetEnumerator();
            label_20:
            var val_14 = 0;
            val_14 = val_14 + 1;
            if(val_3.MoveNext() == false)
            {
                goto label_13;
            }
            
            var val_15 = 0;
            val_15 = val_15 + 1;
            T val_7 = val_3.Current;
            if(val_2 != null)
            {
                goto label_20;
            }
            
            goto label_20;
            label_13:
            val_14 = 0;
            val_15 = 60;
            if(val_3 == null)
            {
                
            }
            else
            {
                    var val_16 = 0;
                val_16 = val_16 + 1;
                val_3.Dispose();
            }
            
            val_17 = null;
            val_17 = null;
            object[] val_9 = new object[1];
            System.Type val_10 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            val_9[0] = val_2;
            GameAnalyticsSDK.Wrapper.GA_Wrapper.GA.CallStatic(methodName:  "configureAvailableCustomDimensions01", args:  val_9);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void configureAvailableCustomDimensions02(string list)
        {
            var val_9;
            var val_10;
            var val_11;
            var val_14;
            var val_15;
            var val_17;
            if(list != null)
            {
                    val_9 = GA_MiniJSON.Parser.Parse(jsonString:  list);
            }
            else
            {
                    val_9 = 0;
            }
            
            System.Collections.ArrayList val_2 = new System.Collections.ArrayList();
            val_10 = null;
            var val_13 = 1179403647;
            if(mem[282584257676957] == 0)
            {
                goto label_4;
            }
            
            var val_11 = mem[282584257676847];
            var val_12 = 0;
            val_11 = val_11 + 8;
            label_6:
            if(((mem[282584257676847] + 8) + -8) == null)
            {
                goto label_5;
            }
            
            val_12 = val_12 + 1;
            val_11 = val_11 + 16;
            if(val_12 < mem[282584257676957])
            {
                goto label_6;
            }
            
            label_4:
            val_10 = null;
            goto label_7;
            label_5:
            val_13 = val_13 + (((mem[282584257676847] + 8)) << 4);
            val_11 = val_13 + 296;
            label_7:
            System.Collections.Generic.IEnumerator<T> val_3 = val_9.GetEnumerator();
            label_20:
            var val_14 = 0;
            val_14 = val_14 + 1;
            if(val_3.MoveNext() == false)
            {
                goto label_13;
            }
            
            var val_15 = 0;
            val_15 = val_15 + 1;
            T val_7 = val_3.Current;
            if(val_2 != null)
            {
                goto label_20;
            }
            
            goto label_20;
            label_13:
            val_14 = 0;
            val_15 = 60;
            if(val_3 == null)
            {
                
            }
            else
            {
                    var val_16 = 0;
                val_16 = val_16 + 1;
                val_3.Dispose();
            }
            
            val_17 = null;
            val_17 = null;
            object[] val_9 = new object[1];
            System.Type val_10 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            val_9[0] = val_2;
            GameAnalyticsSDK.Wrapper.GA_Wrapper.GA.CallStatic(methodName:  "configureAvailableCustomDimensions02", args:  val_9);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void configureAvailableCustomDimensions03(string list)
        {
            var val_9;
            var val_10;
            var val_11;
            var val_14;
            var val_15;
            var val_17;
            if(list != null)
            {
                    val_9 = GA_MiniJSON.Parser.Parse(jsonString:  list);
            }
            else
            {
                    val_9 = 0;
            }
            
            System.Collections.ArrayList val_2 = new System.Collections.ArrayList();
            val_10 = null;
            var val_13 = 1179403647;
            if(mem[282584257676957] == 0)
            {
                goto label_4;
            }
            
            var val_11 = mem[282584257676847];
            var val_12 = 0;
            val_11 = val_11 + 8;
            label_6:
            if(((mem[282584257676847] + 8) + -8) == null)
            {
                goto label_5;
            }
            
            val_12 = val_12 + 1;
            val_11 = val_11 + 16;
            if(val_12 < mem[282584257676957])
            {
                goto label_6;
            }
            
            label_4:
            val_10 = null;
            goto label_7;
            label_5:
            val_13 = val_13 + (((mem[282584257676847] + 8)) << 4);
            val_11 = val_13 + 296;
            label_7:
            System.Collections.Generic.IEnumerator<T> val_3 = val_9.GetEnumerator();
            label_20:
            var val_14 = 0;
            val_14 = val_14 + 1;
            if(val_3.MoveNext() == false)
            {
                goto label_13;
            }
            
            var val_15 = 0;
            val_15 = val_15 + 1;
            T val_7 = val_3.Current;
            if(val_2 != null)
            {
                goto label_20;
            }
            
            goto label_20;
            label_13:
            val_14 = 0;
            val_15 = 60;
            if(val_3 == null)
            {
                
            }
            else
            {
                    var val_16 = 0;
                val_16 = val_16 + 1;
                val_3.Dispose();
            }
            
            val_17 = null;
            val_17 = null;
            object[] val_9 = new object[1];
            System.Type val_10 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            val_9[0] = val_2;
            GameAnalyticsSDK.Wrapper.GA_Wrapper.GA.CallStatic(methodName:  "configureAvailableCustomDimensions03", args:  val_9);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void configureAvailableResourceCurrencies(string list)
        {
            var val_9;
            var val_10;
            var val_11;
            var val_14;
            var val_15;
            var val_17;
            if(list != null)
            {
                    val_9 = GA_MiniJSON.Parser.Parse(jsonString:  list);
            }
            else
            {
                    val_9 = 0;
            }
            
            System.Collections.ArrayList val_2 = new System.Collections.ArrayList();
            val_10 = null;
            var val_13 = 1179403647;
            if(mem[282584257676957] == 0)
            {
                goto label_4;
            }
            
            var val_11 = mem[282584257676847];
            var val_12 = 0;
            val_11 = val_11 + 8;
            label_6:
            if(((mem[282584257676847] + 8) + -8) == null)
            {
                goto label_5;
            }
            
            val_12 = val_12 + 1;
            val_11 = val_11 + 16;
            if(val_12 < mem[282584257676957])
            {
                goto label_6;
            }
            
            label_4:
            val_10 = null;
            goto label_7;
            label_5:
            val_13 = val_13 + (((mem[282584257676847] + 8)) << 4);
            val_11 = val_13 + 296;
            label_7:
            System.Collections.Generic.IEnumerator<T> val_3 = val_9.GetEnumerator();
            label_20:
            var val_14 = 0;
            val_14 = val_14 + 1;
            if(val_3.MoveNext() == false)
            {
                goto label_13;
            }
            
            var val_15 = 0;
            val_15 = val_15 + 1;
            T val_7 = val_3.Current;
            if(val_2 != null)
            {
                goto label_20;
            }
            
            goto label_20;
            label_13:
            val_14 = 0;
            val_15 = 60;
            if(val_3 == null)
            {
                
            }
            else
            {
                    var val_16 = 0;
                val_16 = val_16 + 1;
                val_3.Dispose();
            }
            
            val_17 = null;
            val_17 = null;
            object[] val_9 = new object[1];
            System.Type val_10 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            val_9[0] = val_2;
            GameAnalyticsSDK.Wrapper.GA_Wrapper.GA.CallStatic(methodName:  "configureAvailableResourceCurrencies", args:  val_9);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void configureAvailableResourceItemTypes(string list)
        {
            var val_9;
            var val_10;
            var val_11;
            var val_14;
            var val_15;
            var val_17;
            if(list != null)
            {
                    val_9 = GA_MiniJSON.Parser.Parse(jsonString:  list);
            }
            else
            {
                    val_9 = 0;
            }
            
            System.Collections.ArrayList val_2 = new System.Collections.ArrayList();
            val_10 = null;
            var val_13 = 1179403647;
            if(mem[282584257676957] == 0)
            {
                goto label_4;
            }
            
            var val_11 = mem[282584257676847];
            var val_12 = 0;
            val_11 = val_11 + 8;
            label_6:
            if(((mem[282584257676847] + 8) + -8) == null)
            {
                goto label_5;
            }
            
            val_12 = val_12 + 1;
            val_11 = val_11 + 16;
            if(val_12 < mem[282584257676957])
            {
                goto label_6;
            }
            
            label_4:
            val_10 = null;
            goto label_7;
            label_5:
            val_13 = val_13 + (((mem[282584257676847] + 8)) << 4);
            val_11 = val_13 + 296;
            label_7:
            System.Collections.Generic.IEnumerator<T> val_3 = val_9.GetEnumerator();
            label_20:
            var val_14 = 0;
            val_14 = val_14 + 1;
            if(val_3.MoveNext() == false)
            {
                goto label_13;
            }
            
            var val_15 = 0;
            val_15 = val_15 + 1;
            T val_7 = val_3.Current;
            if(val_2 != null)
            {
                goto label_20;
            }
            
            goto label_20;
            label_13:
            val_14 = 0;
            val_15 = 60;
            if(val_3 == null)
            {
                
            }
            else
            {
                    var val_16 = 0;
                val_16 = val_16 + 1;
                val_3.Dispose();
            }
            
            val_17 = null;
            val_17 = null;
            object[] val_9 = new object[1];
            System.Type val_10 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            val_9[0] = val_2;
            GameAnalyticsSDK.Wrapper.GA_Wrapper.GA.CallStatic(methodName:  "configureAvailableResourceItemTypes", args:  val_9);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void configureSdkGameEngineVersion(string unitySdkVersion)
        {
            null = null;
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(unitySdkVersion != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(unitySdkVersion == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = unitySdkVersion;
            GameAnalyticsSDK.Wrapper.GA_Wrapper.GA.CallStatic(methodName:  "configureSdkGameEngineVersion", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void configureGameEngineVersion(string unityEngineVersion)
        {
            null = null;
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(unityEngineVersion != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(unityEngineVersion == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = unityEngineVersion;
            GameAnalyticsSDK.Wrapper.GA_Wrapper.GA.CallStatic(methodName:  "configureGameEngineVersion", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void configureBuild(string build)
        {
            null = null;
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(build != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(build == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = build;
            GameAnalyticsSDK.Wrapper.GA_Wrapper.GA.CallStatic(methodName:  "configureBuild", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void configureUserId(string userId)
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
            GameAnalyticsSDK.Wrapper.GA_Wrapper.GA.CallStatic(methodName:  "configureUserId", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void initializega(string gamekey, string gamesecret)
        {
            var val_10;
            var val_11;
            GameAnalyticsSDK.Setup.Settings val_1 = GameAnalyticsSDK.GameAnalytics.SettingsGA;
            if(val_1.UseIMEI != false)
            {
                    val_10 = null;
                val_10 = null;
                GameAnalyticsSDK.Wrapper.GA_Wrapper.GA_IMEI.CallStatic(methodName:  "readImei", args:  System.Array.Empty<System.Object>());
            }
            
            val_11 = null;
            val_11 = null;
            GameAnalyticsSDK.Wrapper.GA_Wrapper.UNITY_GA.CallStatic(methodName:  "initialize", args:  System.Array.Empty<System.Object>());
            object[] val_6 = new object[1];
            val_6[0] = null;
            GameAnalyticsSDK.Wrapper.GA_Wrapper.GA.CallStatic(methodName:  "setEnabledErrorReporting", args:  val_6);
            object[] val_8 = new object[1];
            val_8[0] = new UnityEngine.AndroidJavaClass(className:  "com.unity3d.player.UnityPlayer").GetStatic<UnityEngine.AndroidJavaObject>(fieldName:  "currentActivity");
            new UnityEngine.AndroidJavaClass(className:  "com.gameanalytics.sdk.GAPlatform").CallStatic(methodName:  "initializeWithActivity", args:  val_8);
            object[] val_9 = new object[2];
            val_9[0] = gamekey;
            val_9[1] = gamesecret;
            GameAnalyticsSDK.Wrapper.GA_Wrapper.GA.CallStatic(methodName:  "initializeWithGameKey", args:  val_9);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void setCustomDimension01(string customDimension)
        {
            null = null;
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(customDimension != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(customDimension == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = customDimension;
            GameAnalyticsSDK.Wrapper.GA_Wrapper.GA.CallStatic(methodName:  "setCustomDimension01", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void setCustomDimension02(string customDimension)
        {
            null = null;
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(customDimension != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(customDimension == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = customDimension;
            GameAnalyticsSDK.Wrapper.GA_Wrapper.GA.CallStatic(methodName:  "setCustomDimension02", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void setCustomDimension03(string customDimension)
        {
            null = null;
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(customDimension != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(customDimension == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = customDimension;
            GameAnalyticsSDK.Wrapper.GA_Wrapper.GA.CallStatic(methodName:  "setCustomDimension03", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void addBusinessEvent(string currency, int amount, string itemType, string itemId, string cartType, string fields)
        {
            null = null;
            object[] val_1 = new object[5];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(currency != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(currency == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = currency;
            val_1[1] = amount;
            val_1[2] = itemType;
            val_1[3] = itemId;
            val_1[4] = cartType;
            GameAnalyticsSDK.Wrapper.GA_Wrapper.GA.CallStatic(methodName:  "addBusinessEventWithCurrency", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void addBusinessEventWithReceipt(string currency, int amount, string itemType, string itemId, string cartType, string receipt, string store, string signature, string fields)
        {
            null = null;
            object[] val_1 = new object[8];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(currency != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(currency == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = currency;
            val_1[1] = amount;
            val_1[2] = itemType;
            val_1[3] = itemId;
            val_1[4] = cartType;
            val_1[5] = receipt;
            val_1[6] = store;
            val_1[7] = signature;
            GameAnalyticsSDK.Wrapper.GA_Wrapper.GA.CallStatic(methodName:  "addBusinessEventWithCurrency", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void addResourceEvent(int flowType, string currency, float amount, string itemType, string itemId, string fields)
        {
            null = null;
            object[] val_1 = new object[5];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(flowType != 0)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(flowType == 0)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = flowType;
            val_1[1] = currency;
            val_1[2] = amount;
            val_1[3] = itemType;
            val_1[4] = itemId;
            GameAnalyticsSDK.Wrapper.GA_Wrapper.GA.CallStatic(methodName:  "addResourceEventWithFlowType", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void addProgressionEvent(int progressionStatus, string progression01, string progression02, string progression03, string fields)
        {
            null = null;
            object[] val_1 = new object[4];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(progressionStatus != 0)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(progressionStatus == 0)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = progressionStatus;
            val_1[1] = progression01;
            val_1[2] = progression02;
            val_1[3] = progression03;
            GameAnalyticsSDK.Wrapper.GA_Wrapper.GA.CallStatic(methodName:  "addProgressionEventWithProgressionStatus", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void addProgressionEventWithScore(int progressionStatus, string progression01, string progression02, string progression03, int score, string fields)
        {
            null = null;
            object[] val_1 = new object[5];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(progressionStatus != 0)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(progressionStatus == 0)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = progressionStatus;
            val_1[1] = progression01;
            val_1[2] = progression02;
            val_1[3] = progression03;
            val_1[4] = (double)score;
            GameAnalyticsSDK.Wrapper.GA_Wrapper.GA.CallStatic(methodName:  "addProgressionEventWithProgressionStatus", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void addDesignEvent(string eventId, string fields)
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
            GameAnalyticsSDK.Wrapper.GA_Wrapper.GA.CallStatic(methodName:  "addDesignEventWithEventId", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void addDesignEventWithValue(string eventId, float value, string fields)
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
            val_1[1] = (double)value;
            GameAnalyticsSDK.Wrapper.GA_Wrapper.GA.CallStatic(methodName:  "addDesignEventWithEventId", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void addErrorEvent(int severity, string message, string fields)
        {
            null = null;
            object[] val_1 = new object[2];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(severity != 0)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(severity == 0)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = severity;
            val_1[1] = message;
            GameAnalyticsSDK.Wrapper.GA_Wrapper.GA.CallStatic(methodName:  "addErrorEventWithSeverity", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void addAdEventWithDuration(int adAction, int adType, string adSdkName, string adPlacement, long duration)
        {
            null = null;
            object[] val_1 = new object[5];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(adAction != 0)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(adAction == 0)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = adAction;
            val_1[1] = adType;
            val_1[2] = adSdkName;
            val_1[3] = adPlacement;
            val_1[4] = duration;
            GameAnalyticsSDK.Wrapper.GA_Wrapper.GA.CallStatic(methodName:  "addAdEvent", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void addAdEventWithReason(int adAction, int adType, string adSdkName, string adPlacement, int noAdReason)
        {
            null = null;
            object[] val_1 = new object[5];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(adAction != 0)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(adAction == 0)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = adAction;
            val_1[1] = adType;
            val_1[2] = adSdkName;
            val_1[3] = adPlacement;
            val_1[4] = noAdReason;
            GameAnalyticsSDK.Wrapper.GA_Wrapper.GA.CallStatic(methodName:  "addAdEvent", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void addAdEvent(int adAction, int adType, string adSdkName, string adPlacement)
        {
            null = null;
            object[] val_1 = new object[4];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(adAction != 0)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(adAction == 0)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = adAction;
            val_1[1] = adType;
            val_1[2] = adSdkName;
            val_1[3] = adPlacement;
            GameAnalyticsSDK.Wrapper.GA_Wrapper.GA.CallStatic(methodName:  "addAdEvent", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void setEnabledInfoLog(bool enabled)
        {
            var val_3;
            bool val_1 = enabled;
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
            GameAnalyticsSDK.Wrapper.GA_Wrapper.GA.CallStatic(methodName:  "setEnabledInfoLog", args:  val_2);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void setEnabledVerboseLog(bool enabled)
        {
            var val_3;
            bool val_1 = enabled;
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
            GameAnalyticsSDK.Wrapper.GA_Wrapper.GA.CallStatic(methodName:  "setEnabledVerboseLog", args:  val_2);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void setFacebookId(string facebookId)
        {
            null = null;
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(facebookId != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(facebookId == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = facebookId;
            GameAnalyticsSDK.Wrapper.GA_Wrapper.GA.CallStatic(methodName:  "setFacebookId", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void setGender(string gender)
        {
            string val_5;
            var val_6;
            System.Object[] val_7;
            var val_9;
            var val_10;
            val_5 = gender;
            if((System.String.op_Equality(a:  val_5, b:  "male")) != false)
            {
                    val_6 = null;
                val_6 = null;
                val_5 = GameAnalyticsSDK.Wrapper.GA_Wrapper.GA;
                val_7 = new object[1];
                val_9 = null;
            }
            else
            {
                    if((System.String.op_Equality(a:  val_5, b:  "female")) == false)
            {
                    return;
            }
            
                val_10 = null;
                val_10 = null;
                val_5 = GameAnalyticsSDK.Wrapper.GA_Wrapper.GA;
                object[] val_4 = new object[1];
                val_7 = val_4;
                val_9 = null;
            }
            
            if(val_7 == null)
            {
                goto label_8;
            }
            
            if(2 != 0)
            {
                goto label_9;
            }
            
            goto label_12;
            label_8:
            if(2 == 0)
            {
                goto label_12;
            }
            
            label_9:
            label_12:
            val_7[0] = 2;
            val_5.CallStatic(methodName:  "setGender", args:  val_4);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void setBirthYear(int birthYear)
        {
            null = null;
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(birthYear != 0)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(birthYear == 0)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = birthYear;
            GameAnalyticsSDK.Wrapper.GA_Wrapper.GA.CallStatic(methodName:  "setBirthYear", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void setManualSessionHandling(bool enabled)
        {
            var val_3;
            bool val_1 = enabled;
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
            GameAnalyticsSDK.Wrapper.GA_Wrapper.GA.CallStatic(methodName:  "setEnabledManualSessionHandling", args:  val_2);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void setEventSubmission(bool enabled)
        {
            var val_3;
            bool val_1 = enabled;
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
            GameAnalyticsSDK.Wrapper.GA_Wrapper.GA.CallStatic(methodName:  "setEnabledEventSubmission", args:  val_2);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void gameAnalyticsStartSession()
        {
            null = null;
            GameAnalyticsSDK.Wrapper.GA_Wrapper.GA.CallStatic(methodName:  "startSession", args:  System.Array.Empty<System.Object>());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void gameAnalyticsEndSession()
        {
            null = null;
            GameAnalyticsSDK.Wrapper.GA_Wrapper.GA.CallStatic(methodName:  "endSession", args:  System.Array.Empty<System.Object>());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static string getRemoteConfigsValueAsString(string key, string defaultValue)
        {
            null = null;
            object[] val_1 = new object[2];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(key != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(key == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = key;
            val_1[1] = defaultValue;
            if(GameAnalyticsSDK.Wrapper.GA_Wrapper.GA != null)
            {
                    return GameAnalyticsSDK.Wrapper.GA_Wrapper.GA.CallStatic<System.String>(methodName:  "getRemoteConfigsValueAsString", args:  val_1);
            }
            
            return GameAnalyticsSDK.Wrapper.GA_Wrapper.GA.CallStatic<System.String>(methodName:  "getRemoteConfigsValueAsString", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static bool isRemoteConfigsReady()
        {
            null = null;
            if(GameAnalyticsSDK.Wrapper.GA_Wrapper.GA != null)
            {
                    return GameAnalyticsSDK.Wrapper.GA_Wrapper.GA.CallStatic<System.Boolean>(methodName:  "isRemoteConfigsReady", args:  System.Array.Empty<System.Object>());
            }
            
            return GameAnalyticsSDK.Wrapper.GA_Wrapper.GA.CallStatic<System.Boolean>(methodName:  "isRemoteConfigsReady", args:  System.Array.Empty<System.Object>());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static string getRemoteConfigsContentAsString()
        {
            null = null;
            if(GameAnalyticsSDK.Wrapper.GA_Wrapper.GA != null)
            {
                    return GameAnalyticsSDK.Wrapper.GA_Wrapper.GA.CallStatic<System.String>(methodName:  "getRemoteConfigsContentAsString", args:  System.Array.Empty<System.Object>());
            }
            
            return GameAnalyticsSDK.Wrapper.GA_Wrapper.GA.CallStatic<System.String>(methodName:  "getRemoteConfigsContentAsString", args:  System.Array.Empty<System.Object>());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void startTimer(string key)
        {
            null = null;
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(key != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(key == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = key;
            GameAnalyticsSDK.Wrapper.GA_Wrapper.GA.CallStatic(methodName:  "startTimer", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void pauseTimer(string key)
        {
            null = null;
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(key != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(key == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = key;
            GameAnalyticsSDK.Wrapper.GA_Wrapper.GA.CallStatic(methodName:  "pauseTimer", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void resumeTimer(string key)
        {
            null = null;
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(key != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(key == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = key;
            GameAnalyticsSDK.Wrapper.GA_Wrapper.GA.CallStatic(methodName:  "resumeTimer", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static long stopTimer(string key)
        {
            null = null;
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(key != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(key == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = key;
            if(GameAnalyticsSDK.Wrapper.GA_Wrapper.GA != null)
            {
                    return GameAnalyticsSDK.Wrapper.GA_Wrapper.GA.CallStatic<System.Int64>(methodName:  "stopTimer", args:  val_1);
            }
            
            return GameAnalyticsSDK.Wrapper.GA_Wrapper.GA.CallStatic<System.Int64>(methodName:  "stopTimer", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetAvailableCustomDimensions01(string list)
        {
            GameAnalyticsSDK.Wrapper.GA_Wrapper.configureAvailableCustomDimensions01(list:  list);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetAvailableCustomDimensions02(string list)
        {
            GameAnalyticsSDK.Wrapper.GA_Wrapper.configureAvailableCustomDimensions02(list:  list);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetAvailableCustomDimensions03(string list)
        {
            GameAnalyticsSDK.Wrapper.GA_Wrapper.configureAvailableCustomDimensions03(list:  list);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetAvailableResourceCurrencies(string list)
        {
            GameAnalyticsSDK.Wrapper.GA_Wrapper.configureAvailableResourceCurrencies(list:  list);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetAvailableResourceItemTypes(string list)
        {
            GameAnalyticsSDK.Wrapper.GA_Wrapper.configureAvailableResourceItemTypes(list:  list);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetUnitySdkVersion(string unitySdkVersion)
        {
            GameAnalyticsSDK.Wrapper.GA_Wrapper.configureSdkGameEngineVersion(unitySdkVersion:  unitySdkVersion);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetUnityEngineVersion(string unityEngineVersion)
        {
            GameAnalyticsSDK.Wrapper.GA_Wrapper.configureGameEngineVersion(unityEngineVersion:  unityEngineVersion);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetBuild(string build)
        {
            GameAnalyticsSDK.Wrapper.GA_Wrapper.configureBuild(build:  build);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetCustomUserId(string userId)
        {
            GameAnalyticsSDK.Wrapper.GA_Wrapper.configureUserId(userId:  userId);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetEnabledManualSessionHandling(bool enabled)
        {
            GameAnalyticsSDK.Wrapper.GA_Wrapper.setManualSessionHandling(enabled:  enabled);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetEnabledEventSubmission(bool enabled)
        {
            GameAnalyticsSDK.Wrapper.GA_Wrapper.setEventSubmission(enabled:  enabled);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void StartSession()
        {
            if(GameAnalyticsSDK.State.GAState.IsManualSessionHandlingEnabled() != false)
            {
                    GameAnalyticsSDK.Wrapper.GA_Wrapper.gameAnalyticsStartSession();
                return;
            }
            
            UnityEngine.Debug.Log(message:  "Manual session handling is not enabled. \nPlease check the \"Use manual session handling\" option in the \"Advanced\" section of the Settings object.");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void EndSession()
        {
            if(GameAnalyticsSDK.State.GAState.IsManualSessionHandlingEnabled() != false)
            {
                    GameAnalyticsSDK.Wrapper.GA_Wrapper.gameAnalyticsEndSession();
                return;
            }
            
            UnityEngine.Debug.Log(message:  "Manual session handling is not enabled. \nPlease check the \"Use manual session handling\" option in the \"Advanced\" section of the Settings object.");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void Initialize(string gamekey, string gamesecret)
        {
            GameAnalyticsSDK.Wrapper.GA_Wrapper.initializega(gamekey:  gamekey, gamesecret:  gamesecret);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetCustomDimension01(string customDimension)
        {
            GameAnalyticsSDK.Wrapper.GA_Wrapper.setCustomDimension01(customDimension:  customDimension);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetCustomDimension02(string customDimension)
        {
            GameAnalyticsSDK.Wrapper.GA_Wrapper.setCustomDimension02(customDimension:  customDimension);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetCustomDimension03(string customDimension)
        {
            GameAnalyticsSDK.Wrapper.GA_Wrapper.setCustomDimension03(customDimension:  customDimension);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void AddBusinessEventWithReceipt(string currency, int amount, string itemType, string itemId, string cartType, string receipt, string store, string signature, System.Collections.Generic.IDictionary<string, object> fields)
        {
            string val_1 = GameAnalyticsSDK.Wrapper.GA_Wrapper.DictionaryToJsonString(dict:  fields);
            GameAnalyticsSDK.Wrapper.GA_Wrapper.addBusinessEventWithReceipt(currency:  currency, amount:  amount, itemType:  itemType, itemId:  itemId, cartType:  cartType, receipt:  receipt, store:  store, signature:  signature, fields:  fields);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void AddBusinessEvent(string currency, int amount, string itemType, string itemId, string cartType, System.Collections.Generic.IDictionary<string, object> fields)
        {
            string val_1 = GameAnalyticsSDK.Wrapper.GA_Wrapper.DictionaryToJsonString(dict:  fields);
            GameAnalyticsSDK.Wrapper.GA_Wrapper.addBusinessEvent(currency:  currency, amount:  amount, itemType:  itemType, itemId:  itemId, cartType:  cartType, fields:  fields);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void AddResourceEvent(GameAnalyticsSDK.GAResourceFlowType flowType, string currency, float amount, string itemType, string itemId, System.Collections.Generic.IDictionary<string, object> fields)
        {
            string val_1 = GameAnalyticsSDK.Wrapper.GA_Wrapper.DictionaryToJsonString(dict:  fields);
            GameAnalyticsSDK.Wrapper.GA_Wrapper.addResourceEvent(flowType:  flowType, currency:  currency, amount:  amount, itemType:  itemType, itemId:  itemId, fields:  fields);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void AddProgressionEvent(GameAnalyticsSDK.GAProgressionStatus progressionStatus, string progression01, string progression02, string progression03, System.Collections.Generic.IDictionary<string, object> fields)
        {
            string val_1 = GameAnalyticsSDK.Wrapper.GA_Wrapper.DictionaryToJsonString(dict:  fields);
            GameAnalyticsSDK.Wrapper.GA_Wrapper.addProgressionEvent(progressionStatus:  progressionStatus, progression01:  progression01, progression02:  progression02, progression03:  progression03, fields:  fields);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void AddProgressionEventWithScore(GameAnalyticsSDK.GAProgressionStatus progressionStatus, string progression01, string progression02, string progression03, int score, System.Collections.Generic.IDictionary<string, object> fields)
        {
            string val_1 = GameAnalyticsSDK.Wrapper.GA_Wrapper.DictionaryToJsonString(dict:  fields);
            GameAnalyticsSDK.Wrapper.GA_Wrapper.addProgressionEventWithScore(progressionStatus:  progressionStatus, progression01:  progression01, progression02:  progression02, progression03:  progression03, score:  score, fields:  fields);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void AddDesignEvent(string eventID, float eventValue, System.Collections.Generic.IDictionary<string, object> fields)
        {
            string val_1 = GameAnalyticsSDK.Wrapper.GA_Wrapper.DictionaryToJsonString(dict:  fields);
            GameAnalyticsSDK.Wrapper.GA_Wrapper.addDesignEventWithValue(eventId:  eventID, value:  eventValue, fields:  fields);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void AddDesignEvent(string eventID, System.Collections.Generic.IDictionary<string, object> fields)
        {
            string val_1 = GameAnalyticsSDK.Wrapper.GA_Wrapper.DictionaryToJsonString(dict:  fields);
            GameAnalyticsSDK.Wrapper.GA_Wrapper.addDesignEvent(eventId:  eventID, fields:  fields);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void AddErrorEvent(GameAnalyticsSDK.GAErrorSeverity severity, string message, System.Collections.Generic.IDictionary<string, object> fields)
        {
            string val_1 = GameAnalyticsSDK.Wrapper.GA_Wrapper.DictionaryToJsonString(dict:  fields);
            GameAnalyticsSDK.Wrapper.GA_Wrapper.addErrorEvent(severity:  severity, message:  message, fields:  fields);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void AddAdEventWithDuration(GameAnalyticsSDK.GAAdAction adAction, GameAnalyticsSDK.GAAdType adType, string adSdkName, string adPlacement, long duration)
        {
            GameAnalyticsSDK.Wrapper.GA_Wrapper.addAdEventWithDuration(adAction:  adAction, adType:  adType, adSdkName:  adSdkName, adPlacement:  adPlacement, duration:  duration);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void AddAdEventWithReason(GameAnalyticsSDK.GAAdAction adAction, GameAnalyticsSDK.GAAdType adType, string adSdkName, string adPlacement, GameAnalyticsSDK.GAAdError noAdReason)
        {
            GameAnalyticsSDK.Wrapper.GA_Wrapper.addAdEventWithReason(adAction:  adAction, adType:  adType, adSdkName:  adSdkName, adPlacement:  adPlacement, noAdReason:  noAdReason);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void AddAdEvent(GameAnalyticsSDK.GAAdAction adAction, GameAnalyticsSDK.GAAdType adType, string adSdkName, string adPlacement)
        {
            GameAnalyticsSDK.Wrapper.GA_Wrapper.addAdEvent(adAction:  adAction, adType:  adType, adSdkName:  adSdkName, adPlacement:  adPlacement);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetInfoLog(bool enabled)
        {
            GameAnalyticsSDK.Wrapper.GA_Wrapper.setEnabledInfoLog(enabled:  enabled);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetVerboseLog(bool enabled)
        {
            GameAnalyticsSDK.Wrapper.GA_Wrapper.setEnabledVerboseLog(enabled:  enabled);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetFacebookId(string facebookId)
        {
            GameAnalyticsSDK.Wrapper.GA_Wrapper.setFacebookId(facebookId:  facebookId);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetGender(string gender)
        {
            GameAnalyticsSDK.Wrapper.GA_Wrapper.setGender(gender:  gender);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetBirthYear(int birthYear)
        {
            GameAnalyticsSDK.Wrapper.GA_Wrapper.setBirthYear(birthYear:  birthYear);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string GetRemoteConfigsValueAsString(string key, string defaultValue)
        {
            return GameAnalyticsSDK.Wrapper.GA_Wrapper.getRemoteConfigsValueAsString(key:  key, defaultValue:  defaultValue);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool IsRemoteConfigsReady()
        {
            return GameAnalyticsSDK.Wrapper.GA_Wrapper.isRemoteConfigsReady();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string GetRemoteConfigsContentAsString()
        {
            return GameAnalyticsSDK.Wrapper.GA_Wrapper.getRemoteConfigsContentAsString();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static string DictionaryToJsonString(System.Collections.Generic.IDictionary<string, object> dict)
        {
            var val_11;
            var val_12;
            System.Collections.Hashtable val_1 = new System.Collections.Hashtable();
            if(dict == null)
            {
                    return (string)GA_MiniJSON.Serializer.Serialize(obj:  val_1);
            }
            
            var val_11 = 0;
            val_11 = val_11 + 1;
            System.Collections.Generic.IEnumerator<T> val_3 = dict.GetEnumerator();
            label_18:
            var val_12 = 0;
            val_12 = val_12 + 1;
            if(val_3.MoveNext() == false)
            {
                goto label_11;
            }
            
            var val_13 = 0;
            val_13 = val_13 + 1;
            GameUI.EmailUIDataHandler val_8 = val_3.Current.emailUIDataHandler;
            if(val_1 != null)
            {
                goto label_18;
            }
            
            goto label_18;
            label_11:
            val_11 = 0;
            val_12 = 65;
            if(val_3 == null)
            {
                    return (string)GA_MiniJSON.Serializer.Serialize(obj:  val_1);
            }
            
            var val_14 = 0;
            val_14 = val_14 + 1;
            val_3.Dispose();
            return (string)GA_MiniJSON.Serializer.Serialize(obj:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void StartTimer(string key)
        {
            GameAnalyticsSDK.Wrapper.GA_Wrapper.startTimer(key:  key);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void PauseTimer(string key)
        {
            GameAnalyticsSDK.Wrapper.GA_Wrapper.pauseTimer(key:  key);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void ResumeTimer(string key)
        {
            GameAnalyticsSDK.Wrapper.GA_Wrapper.resumeTimer(key:  key);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static long StopTimer(string key)
        {
            return GameAnalyticsSDK.Wrapper.GA_Wrapper.stopTimer(key:  key);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GA_Wrapper()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static GA_Wrapper()
        {
            GameAnalyticsSDK.Wrapper.GA_Wrapper.GA = new UnityEngine.AndroidJavaClass(className:  "com.gameanalytics.sdk.GameAnalytics");
            GameAnalyticsSDK.Wrapper.GA_Wrapper.UNITY_GA = new UnityEngine.AndroidJavaClass(className:  "com.gameanalytics.sdk.unity.UnityGameAnalytics");
            GameAnalyticsSDK.Wrapper.GA_Wrapper.GA_IMEI = new UnityEngine.AndroidJavaClass(className:  "com.gameanalytics.sdk.imei.GAImei");
        }
    
    }

}
