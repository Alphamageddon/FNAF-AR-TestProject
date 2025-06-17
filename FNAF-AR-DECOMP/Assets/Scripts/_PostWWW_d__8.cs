using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class TelemetryWebgl.<PostWWW>d__8 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <>1__state;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object <>2__current;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string bodyJsonString;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string url;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public TelemetryWebgl.<PostWWW>d__8(int <>1__state)
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
        var val_4;
        int val_5;
        val_4 = 0;
        if((this.<>1__state) != 1)
        {
                if((this.<>1__state) != 0)
        {
                return (bool)val_4;
        }
        
            this.<>1__state = 0;
            System.Collections.Generic.Dictionary<System.String, System.String> val_2 = new System.Collections.Generic.Dictionary<System.String, System.String>();
            val_2.Add(key:  "Content-Type", value:  "application/json");
            val_5 = 1;
            val_4 = 1;
            this.<>2__current = new UnityEngine.WWW(url:  this.url, postData:  System.Text.Encoding.UTF8, headers:  val_2);
        }
        else
        {
                val_5 = 0;
        }
        
        this.<>1__state = val_5;
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
