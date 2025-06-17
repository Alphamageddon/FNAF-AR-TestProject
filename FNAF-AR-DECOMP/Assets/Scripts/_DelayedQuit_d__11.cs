using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class PlatformBase.<DelayedQuit>d__11 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <>1__state;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object <>2__current;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public GameSparks.Platforms.PlatformBase <>4__this;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public PlatformBase.<DelayedQuit>d__11(int <>1__state)
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
        int val_5;
        if(((this.<>1__state) - 1) >= 2)
        {
            goto label_1;
        }
        
        this.<>1__state = 0;
        if(GameSparks.Core.GS.Available == false)
        {
            goto label_2;
        }
        
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  0.1f);
        this.<>1__state = 2;
        val_5 = 1;
        return (bool)val_5;
        label_1:
        if((this.<>1__state) != 0)
        {
            goto label_4;
        }
        
        this.<>1__state = 0;
        val_5 = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  1f);
        this.<>1__state = val_5;
        return (bool)val_5;
        label_2:
        this.<>4__this._allowQuitting = true;
        UnityEngine.Application.Quit();
        label_4:
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
