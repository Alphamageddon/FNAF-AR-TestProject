using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class PhantomFxController.<ToggleAnimator>d__44 : IEnumerator<object>, IEnumerator, IDisposable
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
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool status;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public PhantomFxController.<ToggleAnimator>d__44(int <>1__state)
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
        var val_4;
        int val_5;
        val_4 = this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        val_5 = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  this.seconds);
        this.<>1__state = val_5;
        return (bool)val_5;
        label_1:
        this.<>1__state = 0;
        val_4 = this.<>4__this.animator.gameObject;
        val_4.SetActive(value:  (this.status == true) ? 1 : 0);
        label_2:
        val_5 = 0;
        return (bool)val_5;
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
