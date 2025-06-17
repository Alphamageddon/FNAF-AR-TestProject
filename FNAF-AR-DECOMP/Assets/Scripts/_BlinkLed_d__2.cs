using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class BlinkLight.<BlinkLed>d__2 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <>1__state;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object <>2__current;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public BlinkLight <>4__this;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Component <halo>5__2;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public BlinkLight.<BlinkLed>d__2(int <>1__state)
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
        UnityEngine.Component val_12;
        var val_13;
        int val_14;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        val_12 = this.<>4__this.gameObject.GetComponent(type:  "Halo");
        this.<halo>5__2 = val_12;
        if(val_12 == null)
        {
            goto label_5;
        }
        
        label_15:
        val_13 = 0.enabled;
        val_12 = 0;
        goto label_14;
        label_1:
        val_12 = this.<halo>5__2;
        this.<>1__state = 0;
        if(val_12 != null)
        {
            goto label_15;
        }
        
        label_5:
        val_13 = 0.enabled;
        label_14:
        val_12.enabled = (~val_13) & 1;
        val_14 = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  this.<>4__this.blinkDuration);
        this.<>1__state = val_14;
        return (bool)val_14;
        label_2:
        val_14 = 0;
        return (bool)val_14;
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
