using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class StoreStateUIView.<DelayByFrames>d__30 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <>1__state;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object <>2__current;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int frames;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Action action;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <framesLeft>5__2;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public StoreStateUIView.<DelayByFrames>d__30(int <>1__state)
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
        int val_1;
        int val_2;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        val_1 = this.frames;
        this.<>1__state = 0;
        goto label_3;
        label_1:
        this.<>1__state = 0;
        val_1 = (this.<framesLeft>5__2) - 1;
        label_3:
        this.<framesLeft>5__2 = val_1;
        if(val_1 > 0)
        {
                this.<>2__current = 0;
            val_2 = 1;
            this.<>1__state = val_2;
            return (bool)val_2;
        }
        
        val_2 = this.action;
        if(val_2 == null)
        {
                return (bool)val_2;
        }
        
        val_2.Invoke();
        label_2:
        val_2 = 0;
        return (bool)val_2;
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
