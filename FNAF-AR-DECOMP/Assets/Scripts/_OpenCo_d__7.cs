using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class BugReportPopoverService.<OpenCo>d__7 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <>1__state;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object <>2__current;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool takeScreenshot;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public SRDebugger.Services.Implementation.BugReportPopoverService <>4__this;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string descriptionText;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public BugReportPopoverService.<OpenCo>d__7(int <>1__state)
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
        string val_6;
        int val_7;
        val_6 = this;
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
            goto label_7;
        }
        
        this.<>1__state = 0;
        if(this.takeScreenshot == false)
        {
            goto label_4;
        }
        
        val_7 = 1;
        this.<>2__current = this.<>4__this.StartCoroutine(routine:  SRDebugger.Internal.BugReportScreenshotUtil.ScreenshotCaptureCo());
        this.<>1__state = val_7;
        return (bool)val_7;
        label_1:
        this.<>1__state = 0;
        if((System.String.IsNullOrEmpty(value:  this.descriptionText)) != true)
        {
                val_6 = this.descriptionText;
            this.<>4__this._sheet.DescriptionField.text = val_6;
        }
        
        label_7:
        val_7 = 0;
        return (bool)val_7;
        label_2:
        this.<>1__state = 0;
        label_4:
        val_7 = 1;
        this.<>4__this._popover.CachedGameObject.SetActive(value:  true);
        this.<>2__current = new UnityEngine.WaitForEndOfFrame();
        this.<>1__state = 2;
        return (bool)val_7;
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
