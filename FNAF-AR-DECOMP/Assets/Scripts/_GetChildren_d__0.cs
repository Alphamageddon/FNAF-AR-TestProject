using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class SRFTransformExtensions.<GetChildren>d__0 : IEnumerable<UnityEngine.Transform>, IEnumerable, IEnumerator<UnityEngine.Transform>, IEnumerator, IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <>1__state;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Transform <>2__current;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <>l__initialThreadId;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Transform t;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Transform <>3__t;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <i>5__2;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Transform System.Collections.Generic.IEnumerator<UnityEngine.Transform>.Current { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public SRFTransformExtensions.<GetChildren>d__0(int <>1__state)
    {
        this.<>1__state = <>1__state;
        this.<>l__initialThreadId = System.Environment.CurrentManagedThreadId;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void System.IDisposable.Dispose()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool MoveNext()
    {
        int val_4;
        int val_5;
        if((this.<>1__state) == 1)
        {
            goto label_0;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_4;
        }
        
        val_4 = 0;
        this.<>1__state = 0;
        this.<i>5__2 = 0;
        goto label_2;
        label_0:
        this.<>1__state = 0;
        val_4 = (this.<i>5__2) + 1;
        this.<i>5__2 = val_4;
        label_2:
        if(val_4 < this.t.childCount)
        {
                this.<>2__current = this.t.GetChild(index:  this.<i>5__2);
            val_5 = 1;
            this.<>1__state = val_5;
            return (bool)val_5;
        }
        
        label_4:
        val_5 = 0;
        return (bool)val_5;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Transform System.Collections.Generic.IEnumerator<UnityEngine.Transform>.get_Current()
    {
        return (UnityEngine.Transform)this.<>2__current;
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
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Collections.Generic.IEnumerator<UnityEngine.Transform> System.Collections.Generic.IEnumerable<UnityEngine.Transform>.GetEnumerator()
    {
        var val_4;
        if(((this.<>1__state) != 2) || ((this.<>l__initialThreadId) != System.Environment.CurrentManagedThreadId))
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        val_4 = this;
        goto label_3;
        label_2:
        SRFTransformExtensions.<GetChildren>d__0 val_2 = null;
        val_4 = val_2;
        val_2 = new SRFTransformExtensions.<GetChildren>d__0();
        .<>1__state = 0;
        .<>l__initialThreadId = System.Environment.CurrentManagedThreadId;
        if(val_4 == null)
        {
            goto label_4;
        }
        
        label_3:
        .t = this.<>3__t;
        return (System.Collections.Generic.IEnumerator<UnityEngine.Transform>)val_4;
        label_4:
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return this.System.Collections.Generic.IEnumerable<UnityEngine.Transform>.GetEnumerator();
    }

}
