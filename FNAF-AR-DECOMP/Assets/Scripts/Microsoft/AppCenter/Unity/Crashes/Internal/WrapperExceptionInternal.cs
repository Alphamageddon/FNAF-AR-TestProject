using UnityEngine;

namespace Microsoft.AppCenter.Unity.Crashes.Internal
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal class WrapperExceptionInternal
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static UnityEngine.AndroidJavaObject Create()
        {
            return (UnityEngine.AndroidJavaObject)new UnityEngine.AndroidJavaObject(className:  "com.microsoft.appcenter.crashes.ingestion.models.Exception", args:  System.Array.Empty<System.Object>());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetType(UnityEngine.AndroidJavaObject exception, string type)
        {
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(type != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(type == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = type;
            exception.Call(methodName:  "setType", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetMessage(UnityEngine.AndroidJavaObject exception, string message)
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
            exception.Call(methodName:  "setMessage", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetStacktrace(UnityEngine.AndroidJavaObject exception, string stacktrace)
        {
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(stacktrace != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(stacktrace == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = stacktrace;
            exception.Call(methodName:  "setStackTrace", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetInnerException(UnityEngine.AndroidJavaObject exception, UnityEngine.AndroidJavaObject innerException)
        {
            UnityEngine.AndroidJavaObject val_2 = new UnityEngine.AndroidJavaObject(className:  "java.util.LinkedList", args:  System.Array.Empty<System.Object>());
            object[] val_3 = new object[1];
            if(val_3 == null)
            {
                goto label_1;
            }
            
            if(innerException != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(innerException == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_3[0] = innerException;
            val_2.Call(methodName:  "addLast", args:  val_3);
            object[] val_4 = new object[1];
            if(val_4 == null)
            {
                goto label_8;
            }
            
            if(val_2 != null)
            {
                goto label_9;
            }
            
            goto label_12;
            label_8:
            if(val_2 == null)
            {
                goto label_12;
            }
            
            label_9:
            label_12:
            val_4[0] = val_2;
            exception.Call(methodName:  "setInnerExceptions", args:  val_4);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetWrapperSdkName(UnityEngine.AndroidJavaObject exception, string sdkName)
        {
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(sdkName != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(sdkName == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = sdkName;
            exception.Call(methodName:  "setWrapperSdkName", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public WrapperExceptionInternal()
        {
        
        }
    
    }

}
