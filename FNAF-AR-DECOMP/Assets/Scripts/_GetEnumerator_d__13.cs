using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class ShuffleBag.<GetEnumerator>d__13<T> : IEnumerator<T>, IEnumerator, IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <>1__state;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private T <>2__current;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Dest.Math.ShuffleBag<T> <>4__this;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <i>5__2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <len>5__3;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private T System.Collections.Generic.IEnumerator<T>.Current { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ShuffleBag.<GetEnumerator>d__13<T>(int <>1__state)
    {
        mem[1152921519522149552] = <>1__state;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void System.IDisposable.Dispose()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool MoveNext()
    {
        var val_2;
        var val_3;
        var val_4;
        if(W8 == 1)
        {
            goto label_0;
        }
        
        if(W8 != 0)
        {
            goto label_5;
        }
        
        mem[1152921519522373552] = 0;
        mem[1152921519522373576] = 0;
        val_2 = X20 + 24;
        mem[1152921519522373580] = val_2;
        goto label_4;
        label_0:
        mem[1152921519522373552] = 0;
        val_3 = W8 + 1;
        mem[1152921519522373576] = val_3;
        label_4:
        if(val_3 < this)
        {
                mem[1152921519522373560] = X20;
            val_4 = 1;
            mem[1152921519522373552] = val_4;
            return (bool)val_4;
        }
        
        label_5:
        val_4 = 0;
        return (bool)val_4;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private T System.Collections.Generic.IEnumerator<T>.get_Current()
    {
        return (object)this;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this;
    }

}
