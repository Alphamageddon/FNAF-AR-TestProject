using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class CircularBuffer.<GetEnumerator>d__18<T> : IEnumerator<T>, IEnumerator, IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <>1__state;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private T <>2__current;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public SRDebugger.CircularBuffer<T> <>4__this;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.ArraySegment<T>[] <>7__wrap1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <>7__wrap2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.ArraySegment<T> <segment>5__4;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <i>5__5;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private T System.Collections.Generic.IEnumerator<T>.Current { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public CircularBuffer.<GetEnumerator>d__18<T>(int <>1__state)
    {
        mem[1152921522922423168] = <>1__state;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void System.IDisposable.Dispose()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool MoveNext()
    {
        var val_5;
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        if(W8 == 1)
        {
            goto label_0;
        }
        
        if(W8 != 0)
        {
            goto label_1;
        }
        
        mem[1152921522922671760] = 0;
        val_5 = __RuntimeMethodHiddenParam + 24 + 192;
        mem2[0] = X22;
        mem2[0] = __RuntimeMethodHiddenParam + 24 + 192 + 8;
        mem2[0] = X22;
        mem2[0] = __RuntimeMethodHiddenParam + 24 + 192 + 16;
        val_6 = this;
        mem[1152921522922671816] = 0;
        val_7 = 1152921522922671816;
        val_8 = 0;
        mem[1152921522922671808] = val_5;
        if(val_5 != 0)
        {
            goto label_18;
        }
        
        goto label_9;
        label_0:
        val_9 = this;
        val_6 = W8 + 1;
        val_10 = 1152921522922671824;
        mem[1152921522922671760] = 0;
        mem[1152921522922671840] = val_6;
        goto label_10;
        label_1:
        val_11 = 0;
        return (bool)val_11;
        label_19:
        var val_1 = X22 + ((X23) << 4);
        val_9 = this;
        mem[1152921522922671840] = 0;
        val_10 = 1152921522922671840;
        val_6 = 0;
        mem[1152921522922671824] = (X22 + (X23) << 4) + 32;
        mem[1152921522922671832] = (X22 + (X23) << 4) + 32 + 8;
        label_10:
        if(val_6 < 1152921522922671824)
        {
                val_5 = (long)mem[1152921522922671840] + 1152921522922671824;
            GameUI.EmailUIDataHandler val_4 = mem[1152921522922671824].emailUIDataHandler + (((long)(int)((mem[1152921522922671840] + 1152921522922671824))) << 5);
            val_11 = 1;
            mem[1152921522922671768] = (val_2 + ((long)(int)((mem[1152921522922671840] + 1152921522922671824))) << 5)._emailDatas;
            mem[1152921522922671776] = (val_2 + ((long)(int)((mem[1152921522922671840] + 1152921522922671824))) << 5)._emailIdsToBeDeletedOnServer;
            mem[1152921522922671792] = (val_2 + ((long)(int)((mem[1152921522922671840] + 1152921522922671824))) << 5)._itemDefinitions;
            mem[1152921522922671760] = val_11;
            return (bool)val_11;
        }
        
        mem[1152921522922671824] = 0;
        mem[1152921522922671832] = 0;
        val_7 = this;
        val_6 = 1152921522922671808;
        val_8 = 1;
        mem[1152921522922671816] = val_8;
        if(mem[1152921522922671824] != 0)
        {
            goto label_18;
        }
        
        label_9:
        label_18:
        if(val_8 < mem[1152921522922671816])
        {
            goto label_19;
        }
        
        val_11 = 0;
        mem[1152921522922671808] = 0;
        return (bool)val_11;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private T System.Collections.Generic.IEnumerator<T>.get_Current()
    {
        SRDebugger.Services.ProfilerFrame val_0;
        return val_0;
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
