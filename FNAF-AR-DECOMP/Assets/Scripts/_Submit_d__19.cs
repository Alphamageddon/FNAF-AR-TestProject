using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class BugReportApi.<Submit>d__19 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <>1__state;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object <>2__current;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public SRDebugger.Internal.BugReportApi <>4__this;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public BugReportApi.<Submit>d__19(int <>1__state)
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
        System.Byte[] val_17;
        int val_18;
        var val_19;
        var val_20;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this._isBusy) == true)
        {
            goto label_36;
        }
        
        this.<>4__this._isBusy = true;
        this.<>4__this.<IsComplete>k__BackingField = false;
        this.<>4__this.<WasSuccessful>k__BackingField = false;
        this.<>4__this._www = 0;
        this.<>4__this.<ErrorMessage>k__BackingField = "";
        string val_1 = SRDebugger.Internal.BugReportApi.BuildJsonRequest(report:  this.<>4__this._bugReport);
        val_17 = System.Text.Encoding.UTF8;
        System.Collections.Generic.Dictionary<System.String, System.String> val_3 = new System.Collections.Generic.Dictionary<System.String, System.String>();
        null.set_Item(key:  "Content-Type", value:  "application/json");
        null.set_Item(key:  "Accept", value:  "application/json");
        null.set_Item(key:  "Method", value:  "POST");
        null.set_Item(key:  "X-ApiKey", value:  this.<>4__this._apiKey);
        new UnityEngine.WWW() = new UnityEngine.WWW(url:  "http://srdebugger.stompyrobot.uk/report/submit", postData:  val_17, headers:  null);
        this.<>4__this._www = new UnityEngine.WWW();
        if(new UnityEngine.WWW() == null)
        {
            goto label_41;
        }
        
        label_40:
        val_18 = 1;
        this.<>2__current = new UnityEngine.WWW();
        this.<>1__state = val_18;
        return (bool)val_18;
        label_1:
        this.<>1__state = 0;
        val_17 = System.String.IsNullOrEmpty(value:  this.<>4__this._www.error);
        if((this.<>4__this._www) == null)
        {
            goto label_14;
        }
        
        if(val_17 == false)
        {
            goto label_15;
        }
        
        label_23:
        val_17 = "X-STATUS";
        if((this.<>4__this._www.responseHeaders.ContainsKey(key:  "X-STATUS")) == false)
        {
            goto label_17;
        }
        
        string val_10 = this.<>4__this._www.responseHeaders.Item["X-STATUS"];
        if((val_10.Contains(value:  "200")) == false)
        {
            goto label_21;
        }
        
        val_19 = 1;
        goto label_22;
        label_14:
        if(val_17 == true)
        {
            goto label_23;
        }
        
        label_15:
        label_26:
        this.<>4__this.<ErrorMessage>k__BackingField = this.<>4__this._www.error;
        goto label_41;
        label_17:
        this.<>4__this.<ErrorMessage>k__BackingField = "Completion State Unknown";
        label_41:
        val_19 = 0;
        label_22:
        this.<>4__this.SetCompletionState(wasSuccessful:  false);
        label_2:
        val_18 = 0;
        return (bool)val_18;
        label_21:
        string val_14 = SRDebugger.Internal.SRDebugApiUtil.ParseErrorResponse(response:  this.<>4__this._www.text, fallback:  val_10);
        goto label_26;
        label_36:
        val_20 = new System.InvalidOperationException(message:  "BugReportApi is already sending a bug report");
        if(0 != 1)
        {
            goto label_37;
        }
        
        if((null & 1) == 0)
        {
            goto label_38;
        }
        
        mem[1152921523012200360] = 1152921504621223936.Message;
        if(X23 != 0)
        {
            goto label_40;
        }
        
        goto label_41;
        label_38:
        mem[8] = null;
        val_20 = 8;
        label_37:
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
