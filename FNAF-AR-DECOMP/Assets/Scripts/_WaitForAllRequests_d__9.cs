using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class FileSource.<WaitForAllRequests>d__9 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <>1__state;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object <>2__current;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Mapbox.Platform.FileSource <>4__this;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public FileSource.<WaitForAllRequests>d__9(int <>1__state)
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
        int val_12;
        System.Collections.Generic.Dictionary<Mapbox.Platform.IAsyncRequest, System.Int32> val_13;
        var val_15;
        var val_16;
        val_12 = 0;
        if((this.<>1__state) >= 2)
        {
                return (bool)val_12;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this._requests.Count) <= 0)
        {
            goto label_4;
        }
        
        bool val_2 = false;
        System.Threading.Monitor.Enter(obj:  this.<>4__this._lock, lockTaken: ref  val_2);
        System.Collections.Generic.List<TSource> val_4 = System.Linq.Enumerable.ToList<Mapbox.Platform.IAsyncRequest>(source:  this.<>4__this._requests.Keys);
        int val_6 = val_4.Count - 1;
        if((val_6 & 2147483648) != 0)
        {
            goto label_19;
        }
        
        do
        {
            val_13 = val_4.Item[val_6];
            var val_13 = 0;
            val_13 = val_13 + 1;
            if(val_13.IsCompleted != false)
        {
                val_13 = this.<>4__this._requests;
            Mapbox.Platform.IAsyncRequest val_10 = val_4.Item[val_6];
        }
        
            val_6 = val_6 - 1;
        }
        while((val_6 & 2147483648) == 0);
        
        goto label_19;
        label_4:
        val_12 = 0;
        return (bool)val_12;
        label_19:
        val_15 = 0;
        val_16 = 151;
        if(val_2 != 0)
        {
                System.Threading.Monitor.Exit(obj:  this.<>4__this._lock);
        }
        
        val_12 = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  0.2f);
        this.<>1__state = val_12;
        return (bool)val_12;
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
