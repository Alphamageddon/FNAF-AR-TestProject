using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class VolumetricLightBeam.<CoPlaytimeUpdate>d__124 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <>1__state;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object <>2__current;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public VLB.VolumetricLightBeam <>4__this;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public VolumetricLightBeam.<CoPlaytimeUpdate>d__124(int <>1__state)
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
        int val_2;
        if((this.<>1__state) >= 2)
        {
            goto label_0;
        }
        
        this.<>1__state = 0;
        if(((this.<>4__this._TrackChangesDuringPlaytime) == false) || ((this.<>4__this.enabled) == false))
        {
            goto label_3;
        }
        
        val_2 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_2;
        return (bool)val_2;
        label_0:
        val_2 = 0;
        return (bool)val_2;
        label_3:
        val_2 = 0;
        this.<>4__this.m_CoPlaytimeUpdate = 0;
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
