using UnityEngine;

namespace GetSocialSdk.Core
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class JniUtils
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static UnityEngine.AndroidJavaObject _activity;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string JavaHashMapClass = "java.util.HashMap";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string JavaArrayList = "java.util.ArrayList";
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static UnityEngine.AndroidJavaObject Activity { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static UnityEngine.AndroidJavaObject get_Activity()
        {
            if(GetSocialSdk.Core.JniUtils.JavaArrayList != null)
            {
                    return val_1;
            }
            
            UnityEngine.AndroidJavaObject val_1 = GetSocialSdk.Core.JniUtils.GetMainActivity();
            GetSocialSdk.Core.JniUtils.JavaArrayList = val_1;
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static UnityEngine.AndroidJavaObject GetMainActivity()
        {
            UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  "com.unity3d.player.UnityPlayer");
            if(val_1 != null)
            {
                    return val_1.GetStatic<UnityEngine.AndroidJavaObject>(fieldName:  "currentActivity");
            }
            
            return val_1.GetStatic<UnityEngine.AndroidJavaObject>(fieldName:  "currentActivity");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void RunOnUiThread(System.Action action)
        {
            object[] val_2 = new object[1];
            UnityEngine.AndroidJavaRunnable val_3 = new UnityEngine.AndroidJavaRunnable(object:  action, method:  public System.Void System.Action::Invoke());
            if(val_2 == null)
            {
                goto label_1;
            }
            
            if(val_3 != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(val_3 == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_2[0] = val_3;
            GetSocialSdk.Core.JniExtensionMethods.CallSafe(ajo:  GetSocialSdk.Core.JniUtils.Activity, methodName:  "runOnUiThread", args:  val_2);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool RunOnUiThreadSafe(System.Action action)
        {
            GetSocialSdk.Core.JniUtils.RunOnUiThread(action:  action);
            return true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void CheckIfClassIsCorrect(UnityEngine.AndroidJavaObject ajo, string expectedSimpleClassName)
        {
            string val_1 = GetSocialSdk.Core.JniUtils.GetClassSimpleName(ajo:  ajo);
            if((System.String.op_Inequality(a:  val_1, b:  expectedSimpleClassName)) != true)
            {
                    return;
            }
            
            System.InvalidOperationException val_4 = new System.InvalidOperationException(message:  System.String.Format(format:  "This AndroidJavaObject is not {0}, it is {1}!", arg0:  expectedSimpleClassName, arg1:  val_1));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static UnityEngine.AndroidJavaObject NewJavaThrowable(string message)
        {
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(message != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(message == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = message;
            return (UnityEngine.AndroidJavaObject)new UnityEngine.AndroidJavaObject(className:  "java.lang.Throwable", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool IsJavaNull(UnityEngine.AndroidJavaObject ajo)
        {
            var val_4;
            if(ajo != null)
            {
                    var val_3 = (ajo.GetRawObject().GetHashCode() == 0) ? 1 : 0;
                return (bool)val_4;
            }
            
            val_4 = 1;
            return (bool)val_4;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static UnityEngine.AndroidJavaObject ToJavaHashMap<TKey, TValue>(System.Collections.Generic.Dictionary<TKey, TValue> dictionary)
        {
            var val_3;
            var val_4;
            var val_5;
            var val_13;
            UnityEngine.AndroidJavaObject val_14;
            var val_15;
            var val_16;
            val_13 = dictionary;
            if(val_13 == null)
            {
                goto label_1;
            }
            
            UnityEngine.AndroidJavaObject val_2 = null;
            val_14 = val_2;
            val_2 = new UnityEngine.AndroidJavaObject(className:  "java.util.HashMap", args:  System.Array.Empty<System.Object>());
            label_10:
            if((7188768 & 1) == 0)
            {
                goto label_2;
            }
            
            UnityEngine.XR.ARSubsystems.TrackableId val_6 = val_5.trackableId;
            object[] val_7 = new object[2];
            val_7[0] = val_6.m_SubId1.System.IConvertible.ToUInt64(provider:  __RuntimeMethodHiddenParam + 48 + 16);
            val_7[1] = ;
            UnityEngine.AndroidJavaObject val_9 = GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  val_2, methodName:  "put", args:  val_7);
            goto label_10;
            label_1:
            val_14 = 0;
            return val_14;
            label_2:
            val_13 = 0;
            val_15 = 111;
            val_5 = __RuntimeMethodHiddenParam + 48 + 56;
            val_3 = val_4;
            val_4 = val_5;
            if((__RuntimeMethodHiddenParam + 48 + 56 + 286) == 0)
            {
                goto label_23;
            }
            
            var val_11 = __RuntimeMethodHiddenParam + 48 + 56 + 176;
            var val_12 = 0;
            val_11 = val_11 + 8;
            label_22:
            if(((__RuntimeMethodHiddenParam + 48 + 56 + 176 + 8) + -8) == null)
            {
                goto label_21;
            }
            
            val_12 = val_12 + 1;
            val_11 = val_11 + 16;
            if(val_12 < (__RuntimeMethodHiddenParam + 48 + 56 + 286))
            {
                goto label_22;
            }
            
            goto label_23;
            label_21:
            val_16 = ((__RuntimeMethodHiddenParam + 48 + 56) + (((__RuntimeMethodHiddenParam + 48 + 56 + 176 + 8)) << 4)) + 296;
            label_23:
            val_5.Dispose();
            if( == 111)
            {
                    return val_14;
            }
            
            if( == 0)
            {
                    return val_14;
            }
            
            return val_14;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static System.Collections.Generic.Dictionary<string, string> FromJavaHashMap(UnityEngine.AndroidJavaObject javaHashMap)
        {
            var val_18;
            if(javaHashMap != null)
            {
                    if((GetSocialSdk.Core.JniUtils.IsJavaNull(ajo:  javaHashMap)) == false)
            {
                goto label_2;
            }
            
            }
            
            System.Collections.Generic.Dictionary<System.String, System.String> val_2 = null;
            val_18 = val_2;
            val_2 = new System.Collections.Generic.Dictionary<System.String, System.String>();
            return (System.Collections.Generic.Dictionary<System.String, System.String>)val_18;
            label_2:
            System.Collections.Generic.Dictionary<System.String, System.String> val_5 = null;
            val_18 = val_5;
            val_5 = new System.Collections.Generic.Dictionary<System.String, System.String>(capacity:  GetSocialSdk.Core.JniExtensionMethods.CallInt(ajo:  javaHashMap, methodName:  "size", args:  System.Array.Empty<System.Object>()));
            UnityEngine.AndroidJavaObject val_9 = GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  javaHashMap, methodName:  "keySet", args:  System.Array.Empty<System.Object>()), methodName:  "iterator", args:  System.Array.Empty<System.Object>());
            if((GetSocialSdk.Core.JniExtensionMethods.CallBool(ajo:  val_9, methodName:  "hasNext", args:  System.Array.Empty<System.Object>())) == false)
            {
                goto label_4;
            }
            
            label_12:
            string val_13 = GetSocialSdk.Core.JniExtensionMethods.CallStr(ajo:  val_9, methodName:  "next", args:  System.Array.Empty<System.Object>());
            object[] val_14 = new object[1];
            if(val_14 == null)
            {
                goto label_5;
            }
            
            if(val_13 != null)
            {
                goto label_6;
            }
            
            goto label_9;
            label_5:
            if(val_13 == null)
            {
                goto label_9;
            }
            
            label_6:
            label_9:
            val_14[0] = val_13;
            val_5.Add(key:  val_13, value:  GetSocialSdk.Core.JniExtensionMethods.CallStr(ajo:  javaHashMap, methodName:  "get", args:  val_14));
            if((GetSocialSdk.Core.JniExtensionMethods.CallBool(ajo:  val_9, methodName:  "hasNext", args:  System.Array.Empty<System.Object>())) == true)
            {
                goto label_12;
            }
            
            label_4:
            javaHashMap.Dispose();
            return (System.Collections.Generic.Dictionary<System.String, System.String>)val_18;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static System.Collections.Generic.List<UnityEngine.AndroidJavaObject> FromJavaList(UnityEngine.AndroidJavaObject javaList)
        {
            var val_10;
            var val_11;
            var val_13;
            System.Collections.Generic.List<UnityEngine.AndroidJavaObject> val_1 = new System.Collections.Generic.List<UnityEngine.AndroidJavaObject>();
            UnityEngine.AndroidJavaObject val_3 = GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  javaList, methodName:  "iterator", args:  System.Array.Empty<System.Object>());
            label_3:
            if((GetSocialSdk.Core.JniExtensionMethods.CallBool(ajo:  val_3, methodName:  "hasNext", args:  System.Array.Empty<System.Object>())) == false)
            {
                goto label_1;
            }
            
            val_1.Add(item:  GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  val_3, methodName:  "next", args:  System.Array.Empty<System.Object>()));
            goto label_3;
            label_1:
            val_10 = 0;
            val_11 = 91;
            if(val_3 == null)
            {
                
            }
            else
            {
                    var val_10 = 0;
                val_10 = val_10 + 1;
                val_3.Dispose();
            }
            
            if(( == 91) || ( == false))
            {
                goto label_19;
            }
            
            val_10 = 0;
            val_13 = 0;
            if(javaList != null)
            {
                goto label_20;
            }
            
            goto label_24;
            label_19:
            val_13 = ;
            if(javaList == null)
            {
                goto label_24;
            }
            
            label_20:
            var val_11 = 0;
            val_11 = val_11 + 1;
            javaList.Dispose();
            label_24:
            if( == 91)
            {
                    return val_1;
            }
            
            if(val_13 == false)
            {
                    return val_1;
            }
            
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static UnityEngine.AndroidJavaObject ToJavaList<T>(System.Collections.Generic.List<T> list)
        {
            var val_3;
            if(list != null)
            {
                    mem2[0] = new UnityEngine.AndroidJavaObject(className:  "java.util.ArrayList", args:  System.Array.Empty<System.Object>());
                val_3 = mem[__RuntimeMethodHiddenParam + 48 + 16];
                val_3 = __RuntimeMethodHiddenParam + 48 + 16;
                return (UnityEngine.AndroidJavaObject)val_3;
            }
            
            val_3 = 0;
            return (UnityEngine.AndroidJavaObject)val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static GetSocialSdk.Core.GetSocialError ToGetSocialError(UnityEngine.AndroidJavaObject getSocialExceptionAJO)
        {
            GetSocialSdk.Core.GetSocialError val_1 = new GetSocialSdk.Core.GetSocialError();
            if(val_1 != null)
            {
                    return val_1.ParseFromAJO(ajo:  getSocialExceptionAJO);
            }
            
            return val_1.ParseFromAJO(ajo:  getSocialExceptionAJO);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string GetClassName(UnityEngine.AndroidJavaObject ajo)
        {
            return GetSocialSdk.Core.JniExtensionMethods.CallStr(ajo:  GetSocialSdk.Core.JniUtils.GetJavaClass(ajo:  ajo), methodName:  "getName", args:  System.Array.Empty<System.Object>());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string GetClassSimpleName(UnityEngine.AndroidJavaObject ajo)
        {
            return GetSocialSdk.Core.JniExtensionMethods.CallStr(ajo:  GetSocialSdk.Core.JniUtils.GetJavaClass(ajo:  ajo), methodName:  "getSimpleName", args:  System.Array.Empty<System.Object>());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static UnityEngine.AndroidJavaObject GetJavaClass(UnityEngine.AndroidJavaObject ajo)
        {
            return GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  ajo, methodName:  "getClass", args:  System.Array.Empty<System.Object>());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static UnityEngine.AndroidJavaObject ToJavaStringArray(System.Collections.Generic.IList<string> values)
        {
            object val_12;
            object val_13;
            var val_14;
            if(values != null)
            {
                    UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  "java.lang.reflect.Array");
                object[] val_2 = new object[2];
                val_2[0] = new UnityEngine.AndroidJavaClass(className:  "java.lang.String");
                var val_14 = 0;
                val_14 = val_14 + 1;
            }
            else
            {
                    val_12 = 0;
                return (UnityEngine.AndroidJavaObject)val_12;
            }
            
            val_2[1] = values.Count;
            val_12 = val_1.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "newInstance", args:  val_2);
            val_13 = 0;
            goto label_16;
            label_47:
            object[] val_7 = new object[3];
            if(val_7 == null)
            {
                goto label_17;
            }
            
            if(val_12 != null)
            {
                goto label_18;
            }
            
            goto label_21;
            label_17:
            if(val_12 == null)
            {
                goto label_21;
            }
            
            label_18:
            if(val_12 == null)
            {
                    val_14 = 0;
            }
            
            label_21:
            if(val_7.Length == 0)
            {
                    val_14 = 0;
            }
            
            val_7[0] = val_12;
            if((val_13 != 0) && (val_13 == 0))
            {
                    val_14 = 0;
            }
            
            if(val_7.Length <= 1)
            {
                    val_14 = 0;
            }
            
            val_7[1] = val_13;
            object[] val_8 = new object[1];
            var val_15 = 0;
            val_15 = val_15 + 1;
            val_14 = 0;
            T val_10 = values.Item[0];
            if(val_8 == null)
            {
                goto label_30;
            }
            
            if(val_10 != 0)
            {
                goto label_31;
            }
            
            goto label_34;
            label_30:
            if(val_10 == 0)
            {
                goto label_34;
            }
            
            label_31:
            label_34:
            val_8[0] = val_10;
            UnityEngine.AndroidJavaObject val_11 = new UnityEngine.AndroidJavaObject(className:  "java.lang.String", args:  val_8);
            if(val_7 == null)
            {
                goto label_36;
            }
            
            if(val_11 != null)
            {
                goto label_37;
            }
            
            goto label_40;
            label_36:
            if(val_11 == null)
            {
                goto label_40;
            }
            
            label_37:
            label_40:
            val_7[2] = val_11;
            val_1.CallStatic(methodName:  "set", args:  val_7);
            val_13 = 1;
            label_16:
            var val_16 = 0;
            val_16 = val_16 + 1;
            if(val_13 < values.Count)
            {
                goto label_47;
            }
            
            return (UnityEngine.AndroidJavaObject)val_12;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static UnityEngine.Texture2D FromAndroidBitmap(UnityEngine.AndroidJavaObject bitmapAJO)
        {
            if((GetSocialSdk.Core.JniUtils.IsJavaNull(ajo:  bitmapAJO)) != false)
            {
                    return 0;
            }
            
            object[] val_3 = new object[1];
            val_3[0] = bitmapAJO;
            return GetSocialSdk.MiniJSON.GSJson.FromBase64(base64Image:  GetSocialSdk.Core.JniExtensionMethods.CallStaticStr(ajo:  new UnityEngine.AndroidJavaClass(className:  "im.getsocial.sdk.internal.unity.BitmapFactory"), methodName:  "encodeBase64", args:  val_3));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static UnityEngine.AndroidJavaObject ToAjoBitmap(UnityEngine.Texture2D texture2D)
        {
            object[] val_2 = new object[1];
            string val_3 = GetSocialSdk.MiniJSON.GSJson.TextureToBase64(obj:  texture2D);
            if(val_2 == null)
            {
                goto label_3;
            }
            
            if(val_3 != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(val_3 == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_2[0] = val_3;
            return GetSocialSdk.Core.JniExtensionMethods.CallStaticAJO(ajo:  new UnityEngine.AndroidJavaClass(className:  "im.getsocial.sdk.internal.unity.BitmapFactory"), methodName:  "decodeBase64", args:  val_2);
        }
    
    }

}
