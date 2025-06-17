using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class CircularBuffer.<GetEnumerable>d__14<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <>1__state;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private T <>2__current;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <>l__initialThreadId;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Mapbox.Utils.CircularBuffer<T> <>4__this;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Collections.Generic.IEnumerator<T> <enumerator>5__2;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private T System.Collections.Generic.IEnumerator<T>.Current { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public CircularBuffer.<GetEnumerable>d__14<T>(int <>1__state)
    {
        mem[1152921519929365440] = <>1__state;
        mem[1152921519929365464] = System.Environment.CurrentManagedThreadId;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void System.IDisposable.Dispose()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool MoveNext()
    {
        var val_3;
        var val_4;
        var val_5;
        var val_6;
        var val_7;
        var val_8;
        if(true == 1)
        {
            goto label_1;
        }
        
        if(true != 0)
        {
            goto label_11;
        }
        
        mem[1152921519929589456] = 0;
        val_3 = 69165056;
        val_4 = this;
        mem[1152921519929589496] = val_3;
        if(!=0)
        {
            goto label_6;
        }
        
        goto label_5;
        label_1:
        val_4 = this;
        mem[1152921519929589456] = 0;
        if(!=0)
        {
            goto label_6;
        }
        
        label_5:
        label_6:
        var val_4 = mem[69165056];
        if((mem[69165056] + 286) == 0)
        {
            goto label_10;
        }
        
        var val_2 = mem[69165056] + 176;
        var val_3 = 0;
        val_2 = val_2 + 8;
        label_9:
        if(((mem[69165056] + 176 + 8) + -8) == null)
        {
            goto label_8;
        }
        
        val_3 = val_3 + 1;
        val_2 = val_2 + 16;
        if(val_3 < (mem[69165056] + 286))
        {
            goto label_9;
        }
        
        goto label_10;
        label_8:
        val_4 = val_4 + (((mem[69165056] + 176 + 8)) << 4);
        val_5 = val_4 + 296;
        label_10:
        val_6 = public System.Boolean System.Collections.IEnumerator::MoveNext();
        if(MoveNext() == false)
        {
            goto label_11;
        }
        
        val_3 = mem[1152921519929589496];
        var val_7 = mem[69165056];
        if((mem[69165056] + 286) == 0)
        {
            goto label_14;
        }
        
        var val_5 = mem[69165056] + 176;
        var val_6 = 0;
        val_5 = val_5 + 8;
        label_16:
        if(((mem[69165056] + 176 + 8) + -8) == (__RuntimeMethodHiddenParam + 24 + 192 + 8))
        {
            goto label_15;
        }
        
        val_6 = val_6 + 1;
        val_5 = val_5 + 16;
        if(val_6 < (mem[69165056] + 286))
        {
            goto label_16;
        }
        
        label_14:
        val_6 = __RuntimeMethodHiddenParam + 24 + 192 + 8;
        goto label_17;
        label_11:
        val_8 = 0;
        return (bool)val_8;
        label_15:
        val_7 = val_7 + (((mem[69165056] + 176 + 8)) << 4);
        val_7 = val_7 + 296;
        label_17:
        val_8 = 1;
        mem[1152921519929589464] = ???;
        mem[1152921519929589472] = ???;
        mem[1152921519929589456] = val_8;
        return (bool)val_8;
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
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
    {
        CircularBuffer.<GetEnumerable>d__14<T> val_2 = this;
        if(W8 == 2)
        {
                if(W21 == System.Environment.CurrentManagedThreadId)
        {
                mem[1152921519930046688] = 0;
            return (System.Collections.Generic.IEnumerator<T>)val_2;
        }
        
        }
        
        mem2[0] = val_2;
        val_2 = __RuntimeMethodHiddenParam + 24 + 192 + 24;
        return (System.Collections.Generic.IEnumerator<T>)val_2;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        if(this == null)
        {
            
        }
    
    }

}
