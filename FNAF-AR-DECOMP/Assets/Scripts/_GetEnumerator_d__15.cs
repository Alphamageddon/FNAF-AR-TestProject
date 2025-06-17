using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class SRList.<GetEnumerator>d__15<T> : IEnumerator<T>, IEnumerator, IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <>1__state;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private T <>2__current;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public SRF.SRList<T> <>4__this;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <i>5__2;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private T System.Collections.Generic.IEnumerator<T>.Current { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public SRList.<GetEnumerator>d__15<T>(int <>1__state)
    {
        mem[1152921520743215232] = <>1__state;
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
        val_3 = __RuntimeMethodHiddenParam;
        if(W8 == 1)
        {
            goto label_0;
        }
        
        if(W8 != 0)
        {
            goto label_7;
        }
        
        mem[1152921520743439232] = 0;
        val_4 = X20;
        if(val_4 == 0)
        {
                return (bool)val_4;
        }
        
        val_5 = this;
        val_6 = 0;
        mem[1152921520743439248] = 0;
        if(X20 != 0)
        {
            goto label_6;
        }
        
        goto label_5;
        label_0:
        val_5 = this;
        val_6 = W8 + 1;
        mem[1152921520743439232] = 0;
        mem[1152921520743439248] = val_6;
        if(X20 != 0)
        {
            goto label_6;
        }
        
        label_5:
        label_6:
        if(val_6 < X20)
        {
                val_3 = mem[1152921520743439248];
            var val_1 = X20 + (((W8 + 1)) << 2);
            val_4 = 1;
            mem[1152921520743439232] = val_4;
            mem[1152921520743439236] = (X20 + ((W8 + 1)) << 2) + 32;
            return (bool)val_4;
        }
        
        label_7:
        val_4 = 0;
        return (bool)val_4;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private T System.Collections.Generic.IEnumerator<T>.get_Current()
    {
        return (int)this;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.IEnumerator.get_Current()
    {
        if(((__RuntimeMethodHiddenParam + 24 + 192 + 16 + 294) & 1) != 0)
        {
                return -1042943748;
        }
        
        return -1042943748;
    }

}
