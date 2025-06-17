using UnityEngine;

namespace Microsoft.AppCenter.Unity.Internal.Utility
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class JavaDateHelper
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string DotNetDateFormat = "yyyy-MM-dd\'T\'HH:mm:ss.fffK";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static UnityEngine.AndroidJavaObject _javaDateFormatter;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static UnityEngine.AndroidJavaObject JavaDateFormatter { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static UnityEngine.AndroidJavaObject get_JavaDateFormatter()
        {
            System.Object[] val_3;
            UnityEngine.AndroidJavaObject val_4 = Microsoft.AppCenter.Unity.Internal.Utility.JavaDateHelper._javaDateFormatter;
            if(val_4 != null)
            {
                    return val_4;
            }
            
            object[] val_1 = new object[1];
            val_3 = val_1;
            val_3[0] = "yyyy-MM-dd\'T\'HH:mm:ss.SSSXXX";
            Microsoft.AppCenter.Unity.Internal.Utility.JavaDateHelper._javaDateFormatter = new UnityEngine.AndroidJavaObject(className:  "java.text.SimpleDateFormat", args:  val_1);
            val_4 = Microsoft.AppCenter.Unity.Internal.Utility.JavaDateHelper._javaDateFormatter;
            return val_4;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static UnityEngine.AndroidJavaObject DateTimeConvert(System.DateTime date)
        {
            object[] val_2 = new object[1];
            if(val_2 == null)
            {
                goto label_1;
            }
            
            if(date.dateData != 0)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(date.dateData == 0)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_2[0] = ;
            return (UnityEngine.AndroidJavaObject)Microsoft.AppCenter.Unity.Internal.Utility.JavaDateHelper.JavaDateFormatter.Call<UnityEngine.AndroidJavaObject>(methodName:  "parse", args:  val_2);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static System.DateTimeOffset DateTimeConvert(UnityEngine.AndroidJavaObject date)
        {
            object[] val_2 = new object[1];
            if(val_2 == null)
            {
                goto label_1;
            }
            
            if(date != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(date == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_2[0] = date;
            System.DateTime val_5 = System.DateTime.ParseExact(s:  Microsoft.AppCenter.Unity.Internal.Utility.JavaDateHelper.JavaDateFormatter.Call<System.String>(methodName:  "format", args:  val_2), format:  "yyyy-MM-dd\'T\'HH:mm:ss.fffK", provider:  System.Globalization.CultureInfo.InvariantCulture, style:  16);
            return new System.DateTimeOffset() {m_dateTime = new System.DateTime()};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public JavaDateHelper()
        {
        
        }
    
    }

}
