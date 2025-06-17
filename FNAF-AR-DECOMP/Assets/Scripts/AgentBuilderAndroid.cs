using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class FlurryAgentAndroid.AgentBuilderAndroid : FlurryAgent.AgentBuilder
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.AndroidJavaObject obj_FlurryAgentBuilder;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override void Build(string apiKey)
    {
        var val_18;
        var val_19;
        string val_20;
        System.Object[] val_21;
        var val_22;
        var val_23;
        var val_25;
        UnityEngine.AndroidJavaClass val_1 = null;
        val_18 = val_1;
        val_1 = new UnityEngine.AndroidJavaClass(className:  "com.unity3d.player.UnityPlayer");
        UnityEngine.AndroidJavaObject val_2 = val_1.GetStatic<UnityEngine.AndroidJavaObject>(fieldName:  "currentActivity");
        val_19 = null;
        val_19 = null;
        object[] val_3 = new object[2];
        val_3[0] = FlurrySDKInternal.FlurryAgentAndroid.ORIGIN_NAME;
        val_20 = FlurrySDKInternal.FlurryAgentAndroid.ORIGIN_VERSION;
        val_3[1] = val_20;
        FlurrySDKInternal.FlurryAgentAndroid.cls_FlurryAgent.CallStatic(methodName:  "addOrigin", args:  val_3);
        object[] val_4 = new object[2];
        val_21 = val_4;
        val_21[0] = val_2;
        val_21[1] = apiKey;
        this.obj_FlurryAgentBuilder.Call(methodName:  "build", args:  val_4);
        val_22 = 0;
        val_23 = 112;
        if(val_2 != null)
        {
                var val_18 = 0;
            val_18 = val_18 + 1;
            val_2.Dispose();
        }
        
        if((val_23 == 112) || (val_22 == 0))
        {
            goto label_26;
        }
        
        val_22 = 0;
        val_25 = 0;
        if(val_18 != null)
        {
            goto label_27;
        }
        
        goto label_42;
        label_26:
        val_25 = ;
        if(val_18 == null)
        {
            goto label_42;
        }
        
        label_27:
        var val_19 = 0;
        val_19 = val_19 + 1;
        val_1.Dispose();
        label_42:
        if( == 112)
        {
                return;
        }
        
        if(val_25 == 0)
        {
                return;
        }
        
        val_18 = ???;
        val_22 = ???;
        val_21 = ???;
        val_20 = ???;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override void WithCrashReporting(bool crashReporting)
    {
        bool val_1 = crashReporting;
        object[] val_2 = new object[1];
        if(val_2 == null)
        {
            goto label_1;
        }
        
        if(val_1 == true)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(val_1 == false)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_2[0] = val_1;
        UnityEngine.AndroidJavaObject val_3 = this.obj_FlurryAgentBuilder.Call<UnityEngine.AndroidJavaObject>(methodName:  "withCaptureUncaughtExceptions", args:  val_2);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override void WithContinueSessionMillis(long sessionMillis)
    {
        object[] val_1 = new object[1];
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(sessionMillis != 0)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(sessionMillis == 0)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = sessionMillis;
        UnityEngine.AndroidJavaObject val_2 = this.obj_FlurryAgentBuilder.Call<UnityEngine.AndroidJavaObject>(methodName:  "withContinueSessionMillis", args:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override void WithIncludeBackgroundSessionsInMetrics(bool includeBackgroundSessionsInMetrics)
    {
        bool val_1 = includeBackgroundSessionsInMetrics;
        object[] val_2 = new object[1];
        if(val_2 == null)
        {
            goto label_1;
        }
        
        if(val_1 == true)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(val_1 == false)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_2[0] = val_1;
        UnityEngine.AndroidJavaObject val_3 = this.obj_FlurryAgentBuilder.Call<UnityEngine.AndroidJavaObject>(methodName:  "withIncludeBackgroundSessionsInMetrics", args:  val_2);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override void WithLogEnabled(bool enableLog)
    {
        bool val_1 = enableLog;
        object[] val_2 = new object[1];
        if(val_2 == null)
        {
            goto label_1;
        }
        
        if(val_1 == true)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(val_1 == false)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_2[0] = val_1;
        UnityEngine.AndroidJavaObject val_3 = this.obj_FlurryAgentBuilder.Call<UnityEngine.AndroidJavaObject>(methodName:  "withLogEnabled", args:  val_2);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override void WithLogLevel(FlurrySDK.Flurry.LogLevel logLevel)
    {
        object[] val_1 = new object[1];
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(logLevel != 0)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(logLevel == 0)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = logLevel;
        UnityEngine.AndroidJavaObject val_2 = this.obj_FlurryAgentBuilder.Call<UnityEngine.AndroidJavaObject>(methodName:  "withLogLevel", args:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public FlurryAgentAndroid.AgentBuilderAndroid()
    {
        this.obj_FlurryAgentBuilder = new UnityEngine.AndroidJavaObject(className:  "com.flurry.android.FlurryAgent$Builder", args:  System.Array.Empty<System.Object>());
        this = new System.Object();
    }

}
