using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class CircularBuffer.<GetEnumerator>d__12<T> : IEnumerator<T>, IEnumerator, IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <>1__state;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private T <>2__current;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Mapbox.Utils.CircularBuffer<T> <>4__this;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <i>5__2;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private T System.Collections.Generic.IEnumerator<T>.Current { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public CircularBuffer.<GetEnumerator>d__12<T>(int <>1__state)
    {
        mem[1152921519928684224] = <>1__state;
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
        var val_5;
        if(W8 == 1)
        {
            goto label_0;
        }
        
        if(W8 != 0)
        {
            goto label_10;
        }
        
        mem[1152921519928908224] = 0;
        val_2 = X20;
        if(val_2 == 0)
        {
                return (bool)val_2;
        }
        
        if((X20 + 16 + 24) == 0)
        {
            goto label_10;
        }
        
        val_3 = this;
        val_4 = 0;
        val_5 = 0;
        mem[1152921519928908256] = 0;
        goto label_9;
        label_0:
        val_3 = this;
        val_5 = W8 + 1;
        mem[1152921519928908224] = 0;
        mem[1152921519928908256] = val_5;
        if(X20 != 0)
        {
                val_4 = 0;
        }
        else
        {
                val_4 = 1;
        }
        
        label_9:
        if(val_5 < X20)
        {
                val_2 = 1;
            mem[1152921519928908232] = ???;
            mem[1152921519928908240] = ???;
            mem[1152921519928908224] = val_2;
            return (bool)val_2;
        }
        
        label_10:
        val_2 = 0;
        return (bool)val_2;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private T System.Collections.Generic.IEnumerator<T>.get_Current()
    {
        return new Mapbox.Utils.Vector2d();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object);
    }

}
