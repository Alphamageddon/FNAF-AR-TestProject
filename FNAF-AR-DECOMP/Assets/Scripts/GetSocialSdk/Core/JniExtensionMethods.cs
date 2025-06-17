using UnityEngine;

namespace GetSocialSdk.Core
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class JniExtensionMethods
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string CallStaticStr(UnityEngine.AndroidJavaObject ajo, string methodName, object[] args)
        {
            System.Object[] val_8;
            var val_9;
            val_8 = args;
            IntPtr val_1 = ajo.GetRawClass();
            if(val_8 == null)
            {
                    object[] val_2 = new object[1];
                val_8 = val_2;
            }
            
            UnityEngine.jvalue[] val_4 = UnityEngine.AndroidJNIHelper.CreateJNIArgArray(args:  val_2);
            IntPtr val_5 = UnityEngine.AndroidJNI.CallStaticObjectMethod(clazz:  val_1, methodID:  UnityEngine.AndroidJNIHelper.GetMethodID<System.String>(jclass:  val_1, methodName:  methodName, args:  val_2, isStatic:  true), args:  val_4);
            if((System.IntPtr.op_Inequality(value1:  0, value2:  val_5)) != false)
            {
                    val_9 = UnityEngine.AndroidJNI.GetStringUTFChars(str:  val_5);
                UnityEngine.AndroidJNI.DeleteLocalRef(obj:  val_5);
                UnityEngine.AndroidJNIHelper.DeleteJNIArgArray(args:  val_2, jniArgs:  val_4);
                return (string)val_9;
            }
            
            UnityEngine.AndroidJNIHelper.DeleteJNIArgArray(args:  val_2, jniArgs:  val_4);
            val_9 = 0;
            return (string)val_9;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool CallStaticBool(UnityEngine.AndroidJavaObject ajo, string methodName, object[] args)
        {
            return GetSocialSdk.Core.JniExtensionMethods.CallStaticSafe<System.Boolean>(ajo:  ajo, methodName:  methodName, args:  args);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static int CallStaticInt(UnityEngine.AndroidJavaObject ajo, string methodName, object[] args)
        {
            return GetSocialSdk.Core.JniExtensionMethods.CallStaticSafe<System.Int32>(ajo:  ajo, methodName:  methodName, args:  args);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static long CallStaticLong(UnityEngine.AndroidJavaObject ajo, string methodName, object[] args)
        {
            return GetSocialSdk.Core.JniExtensionMethods.CallStaticSafe<System.Int64>(ajo:  ajo, methodName:  methodName, args:  args);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static float CallStaticFloat(UnityEngine.AndroidJavaObject ajo, string methodName, object[] args)
        {
            return GetSocialSdk.Core.JniExtensionMethods.CallStaticSafe<System.Single>(ajo:  ajo, methodName:  methodName, args:  args);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static UnityEngine.AndroidJavaObject CallStaticAJO(UnityEngine.AndroidJavaObject ajo, string methodName, object[] args)
        {
            return GetSocialSdk.Core.JniExtensionMethods.CallStaticSafe<UnityEngine.AndroidJavaObject>(ajo:  ajo, methodName:  methodName, args:  args);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void CallStaticSafe(UnityEngine.AndroidJavaObject ajo, string methodName, object[] args)
        {
            ajo.CallStatic(methodName:  methodName, args:  args);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool CallBool(UnityEngine.AndroidJavaObject ajo, string methodName, object[] args)
        {
            return GetSocialSdk.Core.JniExtensionMethods.CallSafe<System.Boolean>(ajo:  ajo, methodName:  methodName, args:  args);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static int CallInt(UnityEngine.AndroidJavaObject ajo, string methodName, object[] args)
        {
            return GetSocialSdk.Core.JniExtensionMethods.CallSafe<System.Int32>(ajo:  ajo, methodName:  methodName, args:  args);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static long CallLong(UnityEngine.AndroidJavaObject ajo, string methodName, object[] args)
        {
            return GetSocialSdk.Core.JniExtensionMethods.CallSafe<System.Int64>(ajo:  ajo, methodName:  methodName, args:  args);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static float CallFloat(UnityEngine.AndroidJavaObject ajo, string methodName, object[] args)
        {
            return GetSocialSdk.Core.JniExtensionMethods.CallSafe<System.Single>(ajo:  ajo, methodName:  methodName, args:  args);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string CallStr(UnityEngine.AndroidJavaObject ajo, string methodName, object[] args)
        {
            var val_9;
            if(args == null)
            {
                goto label_1;
            }
            
            label_8:
            UnityEngine.jvalue[] val_3 = UnityEngine.AndroidJNIHelper.CreateJNIArgArray(args:  args);
            IntPtr val_5 = UnityEngine.AndroidJNI.CallObjectMethod(obj:  ajo.GetRawObject(), methodID:  UnityEngine.AndroidJNIHelper.GetMethodID<System.String>(jclass:  ajo.GetRawClass(), methodName:  methodName, args:  args, isStatic:  false), args:  val_3);
            if((System.IntPtr.op_Inequality(value1:  0, value2:  val_5)) == false)
            {
                goto label_4;
            }
            
            val_9 = UnityEngine.AndroidJNI.GetStringUTFChars(str:  val_5);
            UnityEngine.AndroidJNI.DeleteLocalRef(obj:  val_5);
            UnityEngine.AndroidJNIHelper.DeleteJNIArgArray(args:  args, jniArgs:  val_3);
            return (string)val_9;
            label_1:
            object[] val_8 = new object[1];
            if(ajo != null)
            {
                goto label_8;
            }
            
            goto label_8;
            label_4:
            UnityEngine.AndroidJNIHelper.DeleteJNIArgArray(args:  args, jniArgs:  val_3);
            val_9 = 0;
            return (string)val_9;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static UnityEngine.AndroidJavaObject CallAJO(UnityEngine.AndroidJavaObject ajo, string methodName, object[] args)
        {
            return GetSocialSdk.Core.JniExtensionMethods.CallSafe<UnityEngine.AndroidJavaObject>(ajo:  ajo, methodName:  methodName, args:  args);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void CallSafe(UnityEngine.AndroidJavaObject ajo, string methodName, object[] args)
        {
            ajo.Call(methodName:  methodName, args:  args);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static T GetSafe<T>(UnityEngine.AndroidJavaObject ajo, string fieldName)
        {
            if(ajo != null)
            {
                    return (object)ajo;
            }
            
            return (object)ajo;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static T CallStaticSafe<T>(UnityEngine.AndroidJavaObject ajo, string methodName, object[] args)
        {
            UnityEngine.AndroidJavaObject val_1 = ajo;
            val_1 = val_1 & 1;
            return (bool)val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static T CallSafe<T>(UnityEngine.AndroidJavaObject ajo, string methodName, object[] args)
        {
            UnityEngine.AndroidJavaObject val_1 = ajo;
            val_1 = val_1 & 1;
            return (bool)val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void HandleAndroidJavaObjectCallException<T>(UnityEngine.AndroidJavaObject ajo, string methodName, System.Exception exception)
        {
            if((System.Type.op_Equality(left:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 48}), right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
            {
                    return;
            }
            
            bool val_4 = exception.Contains(value:  "AndroidJavaObject with null ptr");
        }
    
    }

}
