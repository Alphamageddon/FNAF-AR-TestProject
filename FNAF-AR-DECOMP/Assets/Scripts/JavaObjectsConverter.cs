using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class JavaObjectsConverter
{
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Microsoft.AppCenter.Unity.Crashes.ErrorReport ConvertErrorReport(UnityEngine.AndroidJavaObject errorReport)
    {
        string val_19;
        Microsoft.AppCenter.Unity.Crashes.ErrorReport val_20;
        if(errorReport != null)
        {
                val_19 = errorReport.Call<System.String>(methodName:  "getId", args:  System.Array.Empty<System.Object>());
            System.DateTimeOffset val_7 = Microsoft.AppCenter.Unity.Internal.Utility.JavaDateHelper.DateTimeConvert(date:  errorReport.Call<UnityEngine.AndroidJavaObject>(methodName:  "getAppStartTime", args:  System.Array.Empty<System.Object>()));
            System.DateTimeOffset val_10 = Microsoft.AppCenter.Unity.Internal.Utility.JavaDateHelper.DateTimeConvert(date:  errorReport.Call<UnityEngine.AndroidJavaObject>(methodName:  "getAppErrorTime", args:  System.Array.Empty<System.Object>()));
            val_20 = new Microsoft.AppCenter.Unity.Crashes.ErrorReport();
            val_20 = new Microsoft.AppCenter.Unity.Crashes.ErrorReport(id:  val_19, appStartTime:  new System.DateTimeOffset() {m_dateTime = new System.DateTime() {dateData = val_7.m_dateTime.dateData}, m_offsetMinutes = val_7.m_offsetMinutes}, appErrorTime:  new System.DateTimeOffset() {m_dateTime = new System.DateTime() {dateData = val_10.m_dateTime.dateData}, m_offsetMinutes = val_10.m_offsetMinutes}, exception:  JavaObjectsConverter.ConvertException(throwable:  errorReport.Call<UnityEngine.AndroidJavaObject>(methodName:  "getThrowable", args:  System.Array.Empty<System.Object>())), device:  JavaObjectsConverter.ConvertDevice(device:  errorReport.Call<UnityEngine.AndroidJavaObject>(methodName:  "getDevice", args:  System.Array.Empty<System.Object>())), threadName:  errorReport.Call<System.String>(methodName:  "getThreadName", args:  System.Array.Empty<System.Object>()));
            return (Microsoft.AppCenter.Unity.Crashes.ErrorReport)val_20;
        }
        
        val_20 = 0;
        return (Microsoft.AppCenter.Unity.Crashes.ErrorReport)val_20;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Microsoft.AppCenter.Unity.Crashes.Models.Exception ConvertException(UnityEngine.AndroidJavaObject throwable)
    {
        string val_13;
        var val_14;
        System.Text.StringBuilder val_5 = null;
        val_13 = 0;
        val_5 = new System.Text.StringBuilder();
        val_14 = 0;
        goto label_3;
        label_8:
        val_13 = "at " + throwable.Call<UnityEngine.AndroidJavaObject[]>(methodName:  "getStackTrace", args:  System.Array.Empty<System.Object>())[0].Call<System.String>(methodName:  "toString", args:  System.Array.Empty<System.Object>())(throwable.Call<UnityEngine.AndroidJavaObject[]>(methodName:  "getStackTrace", args:  System.Array.Empty<System.Object>())[0].Call<System.String>(methodName:  "toString", args:  System.Array.Empty<System.Object>()));
        System.Text.StringBuilder val_9 = val_5.AppendLine(value:  val_13);
        val_14 = 1;
        label_3:
        if(val_14 < val_4.Length)
        {
            goto label_8;
        }
        
        return (Microsoft.AppCenter.Unity.Crashes.Models.Exception)new Microsoft.AppCenter.Unity.Crashes.Models.Exception(message:  throwable.Call<System.String>(methodName:  "toString", args:  System.Array.Empty<System.Object>()), stackTrace:  val_5.TrimEnd(trimChars:  System.Array.Empty<System.Char>()));
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static Microsoft.AppCenter.Unity.Device ConvertDevice(UnityEngine.AndroidJavaObject device)
    {
        return (Microsoft.AppCenter.Unity.Device)new Microsoft.AppCenter.Unity.Device(sdkName:  device.Call<System.String>(methodName:  "getSdkName", args:  System.Array.Empty<System.Object>()), sdkVersion:  device.Call<System.String>(methodName:  "getSdkVersion", args:  System.Array.Empty<System.Object>()), model:  device.Call<System.String>(methodName:  "getModel", args:  System.Array.Empty<System.Object>()), oemName:  device.Call<System.String>(methodName:  "getOemName", args:  System.Array.Empty<System.Object>()), osName:  device.Call<System.String>(methodName:  "getOsName", args:  System.Array.Empty<System.Object>()), osVersion:  device.Call<System.String>(methodName:  "getOsVersion", args:  System.Array.Empty<System.Object>()), osBuild:  device.Call<System.String>(methodName:  "getOsBuild", args:  System.Array.Empty<System.Object>()), osApiLevel:  JavaObjectsConverter.GetIntValue(javaObject:  device, getterName:  "getOsApiLevel"), locale:  device.Call<System.String>(methodName:  "getLocale", args:  System.Array.Empty<System.Object>()), timeZoneOffset:  JavaObjectsConverter.GetIntValue(javaObject:  device, getterName:  "getTimeZoneOffset"), screenSize:  device.Call<System.String>(methodName:  "getScreenSize", args:  System.Array.Empty<System.Object>()), appVersion:  device.Call<System.String>(methodName:  "getAppVersion", args:  System.Array.Empty<System.Object>()), carrierName:  device.Call<System.String>(methodName:  "getCarrierName", args:  System.Array.Empty<System.Object>()), carrierCountry:  device.Call<System.String>(methodName:  "getCarrierCountry", args:  System.Array.Empty<System.Object>()), appBuild:  device.Call<System.String>(methodName:  "getAppBuild", args:  System.Array.Empty<System.Object>()), appNamespace:  device.Call<System.String>(methodName:  "getAppNamespace", args:  System.Array.Empty<System.Object>()));
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static int GetIntValue(UnityEngine.AndroidJavaObject javaObject, string getterName)
    {
        UnityEngine.AndroidJavaObject val_2 = javaObject.Call<UnityEngine.AndroidJavaObject>(methodName:  getterName, args:  System.Array.Empty<System.Object>());
        if(val_2 != null)
        {
                return val_2.Call<System.Int32>(methodName:  "intValue", args:  System.Array.Empty<System.Object>());
        }
        
        return val_2.Call<System.Int32>(methodName:  "intValue", args:  System.Array.Empty<System.Object>());
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public JavaObjectsConverter()
    {
    
    }

}
