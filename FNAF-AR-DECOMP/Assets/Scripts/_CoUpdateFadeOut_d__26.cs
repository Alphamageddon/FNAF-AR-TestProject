using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class BeamGeometry.<CoUpdateFadeOut>d__26 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <>1__state;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object <>2__current;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public VLB.BeamGeometry <>4__this;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public BeamGeometry.<CoUpdateFadeOut>d__26(int <>1__state)
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
        if((this.<>1__state) >= 2)
        {
            goto label_0;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this.m_Master.fadeOutEnd) >= 0f)
        {
            goto label_3;
        }
        
        this.<>4__this.SetFadeOutFactorProp(value:  1f);
        label_0:
        val_1 = 0;
        return (bool)val_1;
        label_3:
        this.<>4__this.ComputeFadeOutFactor();
        val_1 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_1;
        return (bool)val_1;
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
