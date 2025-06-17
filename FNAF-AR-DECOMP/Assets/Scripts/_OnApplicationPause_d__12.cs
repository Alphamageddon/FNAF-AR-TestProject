using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class DomainLifecycle.<OnApplicationPause>d__12 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <>1__state;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object <>2__current;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Initialization.DomainLifecycle <>4__this;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool paused;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public DomainLifecycle.<OnApplicationPause>d__12(int <>1__state)
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
        bool val_3;
        int val_4;
        val_3 = this;
        if((this.<>1__state) == 1)
        {
            goto label_0;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_1;
        }
        
        this.<>1__state = 0;
        this.<>4__this.masterDomain.getSocialDomain.HandlePause(paused:  (this.paused == true) ? 1 : 0);
        if((this.<>4__this.masterDomain.AnimatronicEntityDomain) != null)
        {
                this.<>4__this.masterDomain.AnimatronicEntityDomain.HandleApplicationPause(paused:  this.paused);
        }
        
        val_4 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_4;
        return (bool)val_4;
        label_0:
        this.<>1__state = 0;
        val_3 = this.paused;
        this.<>4__this.masterDomain.GameLifecycleHandler.HandleUpdateAfterPause(paused:  (val_3 == true) ? 1 : 0);
        label_1:
        val_4 = 0;
        return (bool)val_4;
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
