using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class HTTPRequest.<DoRequest>d__12 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <>1__state;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object <>2__current;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Mapbox.Unity.Utilities.HTTPRequest <>4__this;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public HTTPRequest.<DoRequest>d__12(int <>1__state)
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
        Mapbox.Unity.Utilities.HTTPRequest val_3;
        int val_4;
        val_3 = this.<>4__this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        val_3 = this.<>4__this._request;
        this.<>2__current = val_3.Send();
        val_4 = 1;
        this.<>1__state = val_4;
        return (bool)val_4;
        label_1:
        this.<>1__state = 0;
        this.<>4__this._callback.Invoke(obj:  Mapbox.Platform.Response.FromWebResponse(request:  val_3, apiResponse:  this.<>4__this._request, apiEx:  0));
        this.<>4__this._request.Dispose();
        val_4 = 0;
        this.<>4__this._request = 0;
        this.<>4__this.<IsCompleted>k__BackingField = true;
        return (bool)val_4;
        label_2:
        val_4 = 0;
        return (bool)val_4;
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
