using UnityEngine;

namespace Microsoft.AppCenter.Unity.Internal.Utility
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class JavaNumberHelper
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static UnityEngine.AndroidJavaObject Convert(int val)
        {
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(val != 0)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(val == 0)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = val;
            return (UnityEngine.AndroidJavaObject)new UnityEngine.AndroidJavaObject(className:  "java.lang.Integer", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static UnityEngine.AndroidJavaObject Convert(long val)
        {
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(val != 0)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(val == 0)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = val;
            return (UnityEngine.AndroidJavaObject)new UnityEngine.AndroidJavaObject(className:  "java.lang.Long", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static UnityEngine.AndroidJavaObject Convert(float val)
        {
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(val != 0)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(val == 0)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = val;
            return (UnityEngine.AndroidJavaObject)new UnityEngine.AndroidJavaObject(className:  "java.lang.Float", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static UnityEngine.AndroidJavaObject Convert(double val)
        {
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(val != 0)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(val == 0)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = val;
            return (UnityEngine.AndroidJavaObject)new UnityEngine.AndroidJavaObject(className:  "java.lang.Double", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public JavaNumberHelper()
        {
        
        }
    
    }

}
