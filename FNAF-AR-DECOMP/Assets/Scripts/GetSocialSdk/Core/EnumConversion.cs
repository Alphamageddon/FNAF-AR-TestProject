using UnityEngine;

namespace GetSocialSdk.Core
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class EnumConversion
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static UnityEngine.AndroidJavaObject ToAndroidJavaObject(GetSocialSdk.Core.ReportingReason reportingReason)
        {
            return GetSocialSdk.Core.EnumConversion.ToAndroidJavaObject<System.Int32>(type:  reportingReason, javaClass:  "im.getsocial.sdk.activities.ReportingReason");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static UnityEngine.AndroidJavaObject ToAndroidJavaObject(GetSocialSdk.Core.ActivitiesQuery.Filter filter)
        {
            return GetSocialSdk.Core.EnumConversion.ToAndroidJavaObject<System.Int32>(type:  filter, javaClass:  "im.getsocial.sdk.activities.ActivitiesQuery$Filter");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static UnityEngine.AndroidJavaObject ToAndroidJavaObject(GetSocialSdk.Core.NotificationsQuery.Filter filter)
        {
            return GetSocialSdk.Core.EnumConversion.ToAndroidJavaObject<System.Int32>(type:  filter, javaClass:  "im.getsocial.sdk.pushnotifications.NotificationsQuery$Filter");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static UnityEngine.AndroidJavaObject ToAndroidJavaObject(GetSocialSdk.Core.Analytics.PurchaseData.ProductType productType)
        {
            return GetSocialSdk.Core.EnumConversion.ToAndroidJavaObject<System.Int32>(type:  productType, javaClass:  "im.getsocial.sdk.iap.PurchaseData$ProductType");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static UnityEngine.AndroidJavaObject ToAndroidJavaObject<T>(T type, string javaClass)
        {
            UnityEngine.AndroidJavaObject val_3 = GetSocialSdk.Core.JniExtensionMethods.CallStaticAJO(ajo:  new UnityEngine.AndroidJavaClass(className:  javaClass), methodName:  "values", args:  System.Array.Empty<System.Object>());
            object[] val_5 = new object[2];
            if(val_5 == null)
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
            val_5[0] = val_3;
            val_5[1] = ;
            return (UnityEngine.AndroidJavaObject)GetSocialSdk.Core.JniExtensionMethods.CallStaticAJO(ajo:  new UnityEngine.AndroidJavaClass(className:  "java.lang.reflect.Array"), methodName:  "get", args:  val_5);
        }
    
    }

}
