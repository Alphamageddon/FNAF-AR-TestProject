using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
[Serializable]
public class AppCenterSettings : ScriptableObject
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string iOSAppSecret;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string AndroidAppSecret;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string UWPAppSecret;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool UseAnalytics;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool UseCrashes;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool UseDistribute;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public CustomUrlProperty CustomApiUrl;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public CustomUrlProperty CustomInstallUrl;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool EnableDistributeForDebuggableBuild;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool UsePush;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool EnableFirebaseAnalytics;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Microsoft.AppCenter.Unity.LogLevel InitialLogLevel;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public CustomUrlProperty CustomLogUrl;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public MaxStorageSizeProperty MaxStorageSize;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string AppSecret { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Type[] Services { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string get_AppSecret()
    {
        string val_7;
        var val_8;
        System.Func<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.Boolean> val_10;
        var val_11;
        System.Func<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.String> val_13;
        System.Collections.Generic.Dictionary<System.String, System.String> val_1 = new System.Collections.Generic.Dictionary<System.String, System.String>();
        val_1.Add(key:  "ios", value:  this.iOSAppSecret);
        val_7 = this.AndroidAppSecret;
        val_1.Add(key:  "android", value:  val_7);
        val_1.Add(key:  "uwp", value:  this.UWPAppSecret);
        val_8 = null;
        val_8 = null;
        val_10 = AppCenterSettings.<>c.<>9__15_0;
        if(val_10 == null)
        {
                System.Func<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.Boolean> val_2 = null;
            val_10 = val_2;
            val_2 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.Boolean>(object:  AppCenterSettings.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean AppCenterSettings.<>c::<get_AppSecret>b__15_0(System.Collections.Generic.KeyValuePair<string, string> i));
            AppCenterSettings.<>c.<>9__15_0 = val_10;
        }
        
        val_11 = null;
        val_11 = null;
        val_13 = AppCenterSettings.<>c.<>9__15_1;
        if(val_13 != null)
        {
                return +System.Linq.Enumerable.ToArray<System.String>(source:  System.Linq.Enumerable.Select<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.String>(source:  System.Linq.Enumerable.Where<System.Collections.Generic.KeyValuePair<System.String, System.String>>(source:  val_1, predicate:  val_2), selector:  System.Func<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.String> val_4 = null))(System.Linq.Enumerable.ToArray<System.String>(source:  System.Linq.Enumerable.Select<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.String>(source:  System.Linq.Enumerable.Where<System.Collections.Generic.KeyValuePair<System.String, System.String>>(source:  val_1, predicate:  val_2), selector:  System.Func<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.String> val_4 = null)));
        }
        
        val_13 = val_4;
        val_4 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.String>(object:  AppCenterSettings.<>c.__il2cppRuntimeField_static_fields, method:  System.String AppCenterSettings.<>c::<get_AppSecret>b__15_1(System.Collections.Generic.KeyValuePair<string, string> i));
        AppCenterSettings.<>c.<>9__15_1 = val_13;
        return +System.Linq.Enumerable.ToArray<System.String>(source:  System.Linq.Enumerable.Select<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.String>(source:  System.Linq.Enumerable.Where<System.Collections.Generic.KeyValuePair<System.String, System.String>>(source:  val_1, predicate:  val_2), selector:  val_4))(System.Linq.Enumerable.ToArray<System.String>(source:  System.Linq.Enumerable.Select<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.String>(source:  System.Linq.Enumerable.Where<System.Collections.Generic.KeyValuePair<System.String, System.String>>(source:  val_1, predicate:  val_2), selector:  val_4)));
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Type[] get_Services()
    {
        System.Type val_8;
        var val_9;
        System.Func<System.Type, System.Boolean> val_11;
        System.Collections.Generic.List<System.Type> val_1 = new System.Collections.Generic.List<System.Type>();
        if(this.UseAnalytics != false)
        {
                val_8 = Microsoft.AppCenter.Unity.AppCenter.Analytics;
            val_1.Add(item:  val_8);
        }
        
        if(this.UseCrashes != false)
        {
                val_8 = Microsoft.AppCenter.Unity.AppCenter.Crashes;
            val_1.Add(item:  val_8);
        }
        
        if(this.UseDistribute != false)
        {
                val_8 = Microsoft.AppCenter.Unity.AppCenter.Distribute;
            val_1.Add(item:  val_8);
        }
        
        if(this.UsePush != false)
        {
                val_1.Add(item:  Microsoft.AppCenter.Unity.AppCenter.Push);
        }
        
        val_9 = null;
        val_9 = null;
        val_11 = AppCenterSettings.<>c.<>9__17_0;
        if(val_11 != null)
        {
                return System.Linq.Enumerable.ToArray<System.Type>(source:  System.Linq.Enumerable.Where<System.Type>(source:  val_1, predicate:  System.Func<System.Type, System.Boolean> val_6 = null));
        }
        
        val_11 = val_6;
        val_6 = new System.Func<System.Type, System.Boolean>(object:  AppCenterSettings.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean AppCenterSettings.<>c::<get_Services>b__17_0(System.Type i));
        AppCenterSettings.<>c.<>9__17_0 = val_11;
        return System.Linq.Enumerable.ToArray<System.Type>(source:  System.Linq.Enumerable.Where<System.Type>(source:  val_1, predicate:  val_6));
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AppCenterSettings()
    {
        this.UseAnalytics = true;
        this.UseCrashes = true;
        this.UseDistribute = true;
        this.iOSAppSecret = "";
        this.AndroidAppSecret = "";
        this.UWPAppSecret = "";
        this.CustomApiUrl = new CustomUrlProperty(urlName:  "API");
        this.CustomInstallUrl = new CustomUrlProperty(urlName:  "Install");
        this.UsePush = true;
        this.InitialLogLevel = 4;
        this.CustomLogUrl = new CustomUrlProperty(urlName:  "Log");
        this.MaxStorageSize = new MaxStorageSizeProperty();
    }

}
