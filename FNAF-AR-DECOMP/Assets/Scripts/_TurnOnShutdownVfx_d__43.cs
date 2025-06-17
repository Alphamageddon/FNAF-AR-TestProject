using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class PhantomFxController.<TurnOnShutdownVfx>d__43 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <>1__state;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object <>2__current;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float seconds;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public PhantomFxController <>4__this;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public PhantomFxController.<TurnOnShutdownVfx>d__43(int <>1__state)
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
        ParticleSystem.EmissionModule val_6;
        int val_7;
        val_6 = this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        val_7 = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  this.seconds);
        this.<>1__state = val_7;
        return (bool)val_7;
        label_1:
        this.<>1__state = 0;
        this.<>4__this.shutdownVfx.SetActive(value:  true);
        val_6 = this.<>4__this._burnParticleEmission;
        MinMaxCurve val_2 = ParticleSystem.MinMaxCurve.op_Implicit(constant:  this.<>4__this._emissionRate);
        label_2:
        val_7 = 0;
        return (bool)val_7;
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
