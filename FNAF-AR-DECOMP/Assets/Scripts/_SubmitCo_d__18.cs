using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class BugReportSheetController.<SubmitCo>d__18 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <>1__state;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object <>2__current;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public SRDebugger.UI.Other.BugReportSheetController <>4__this;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public BugReportSheetController.<SubmitCo>d__18(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void System.IDisposable.Dispose()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool MoveNext()
    {
        SRDebugger.UI.Other.BugReportSheetController val_16;
        int val_17;
        System.Collections.IEnumerator val_18;
        var val_19;
        var val_22;
        System.Byte[] val_23;
        val_16 = this.<>4__this;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_3;
        }
        
        this.<>1__state = 0;
        if(SRDebugger.Internal.BugReportScreenshotUtil.ScreenshotData != null)
        {
            goto label_9;
        }
        
        if((this.<>4__this.TakingScreenshot) != null)
        {
                this.<>4__this.TakingScreenshot.Invoke();
        }
        
        UnityEngine.WaitForEndOfFrame val_1 = null;
        val_16 = val_1;
        val_1 = new UnityEngine.WaitForEndOfFrame();
        val_17 = 1;
        this.<>2__current = val_16;
        this.<>1__state = val_17;
        return (bool)val_17;
        label_1:
        this.<>1__state = 0;
        if((this.<>4__this.ScreenshotComplete) != null)
        {
                this.<>4__this.ScreenshotComplete.Invoke();
        }
        
        label_9:
        SRDebugger.Services.BugReport val_3 = null;
        val_18 = val_3;
        val_3 = new SRDebugger.Services.BugReport();
        .Email = this.<>4__this.EmailField.text;
        .UserDescription = this.<>4__this.DescriptionField.text;
        var val_18 = 0;
        val_18 = val_18 + 1;
        val_19 = 4;
        goto label_20;
        label_2:
        this.<>1__state = 0;
        val_18 = SRDebugger.Internal.BugReportScreenshotUtil.ScreenshotCaptureCo();
        this.<>2__current = val_16.StartCoroutine(routine:  val_18);
        this.<>1__state = 2;
        val_17 = 1;
        return (bool)val_17;
        label_20:
        .ConsoleLog = System.Linq.Enumerable.ToList<SRDebugger.Services.ConsoleEntry>(source:  SRDebugger.Internal.Service.Console.AllEntries);
        var val_19 = 0;
        val_19 = val_19 + 1;
        val_19 = 3;
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.Object>> val_14 = SRF.Service.SRServiceManager.GetService<SRDebugger.Services.ISystemInformationService>().CreateReport(includePrivate:  false);
        if(val_18 != null)
        {
                .SystemInformation = val_14;
            val_22 = null;
            val_23 = SRDebugger.Internal.BugReportScreenshotUtil.ScreenshotData;
        }
        else
        {
                .SystemInformation = val_14;
            val_23 = SRDebugger.Internal.BugReportScreenshotUtil.ScreenshotData;
            val_22 = null;
        }
        
        .ScreenshotData = val_23;
        SRDebugger.Internal.BugReportScreenshotUtil.ScreenshotData = 0;
        var val_20 = 0;
        val_20 = val_20 + 1;
        SRF.Service.SRServiceManager.GetService<SRDebugger.Services.IBugReportService>().SendBugReport(report:  val_3, completeHandler:  new SRDebugger.Services.BugReportCompleteCallback(object:  val_16, method:  System.Void SRDebugger.UI.Other.BugReportSheetController::OnBugReportComplete(bool didSucceed, string errorMessage)), progressCallback:  new SRDebugger.Services.BugReportProgressCallback(object:  val_16, method:  System.Void SRDebugger.UI.Other.BugReportSheetController::OnBugReportProgress(float progress)));
        label_3:
        val_17 = 0;
        return (bool)val_17;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.<>2__current;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.<>2__current;
    }

}
