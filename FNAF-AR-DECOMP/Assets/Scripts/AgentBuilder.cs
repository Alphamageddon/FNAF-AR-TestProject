using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public abstract class FlurryAgent.AgentBuilder
{
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract void Build(string apiKey); // 0
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract void WithCrashReporting(bool crashReporting); // 0
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract void WithContinueSessionMillis(long sessionMillis); // 0
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract void WithIncludeBackgroundSessionsInMetrics(bool includeBackgroundSessionsInMetrics); // 0
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract void WithLogEnabled(bool enableLog); // 0
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract void WithLogLevel(FlurrySDK.Flurry.LogLevel logLevel); // 0
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected FlurryAgent.AgentBuilder()
    {
    
    }

}
