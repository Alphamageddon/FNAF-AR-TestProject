using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class PhantomFxController.<ToggleMesh>d__45 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <>1__state;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object <>2__current;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float seconds;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool status;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public PhantomFxController <>4__this;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public PhantomFxController.<ToggleMesh>d__45(int <>1__state)
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
        bool val_7;
        int val_8;
        val_7 = this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        val_8 = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  this.seconds);
        this.<>1__state = val_8;
        return (bool)val_8;
        label_1:
        this.<>1__state = 0;
        if(this.status == false)
        {
            goto label_4;
        }
        
        if((this.<>4__this) != null)
        {
            goto label_6;
        }
        
        goto label_6;
        label_4:
        MinMaxCurve val_2 = ParticleSystem.MinMaxCurve.op_Implicit(constant:  this.<>4__this._emissionRate);
        label_6:
        val_7 = this.status;
        this.<>4__this.mesh.SetActive(value:  (val_7 == true) ? 1 : 0);
        val_8 = this.<>4__this.OnMeshToggled;
        if(val_8 == null)
        {
                return (bool)val_8;
        }
        
        val_8.Invoke();
        label_2:
        val_8 = 0;
        return (bool)val_8;
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
