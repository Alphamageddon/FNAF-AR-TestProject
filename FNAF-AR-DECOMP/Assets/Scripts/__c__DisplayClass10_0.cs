using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class CrashesInternal.<>c__DisplayClass10_0
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Microsoft.AppCenter.Unity.AppCenterTask<Microsoft.AppCenter.Unity.Crashes.ErrorReport> errorReportTask;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public CrashesInternal.<>c__DisplayClass10_0()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal void <GetLastSessionCrashReportAsync>b__0(Microsoft.AppCenter.Unity.AppCenterTask<UnityEngine.AndroidJavaObject> t)
    {
        this.errorReportTask.SetResult(result:  JavaObjectsConverter.ConvertErrorReport(errorReport:  t.Result));
    }

}
