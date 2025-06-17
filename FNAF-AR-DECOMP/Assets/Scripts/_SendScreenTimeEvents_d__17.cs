using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class PlayFabHttp.<SendScreenTimeEvents>d__17 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <>1__state;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object <>2__current;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float secondsBetweenBatches;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.WaitForSeconds <delay>5__2;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public PlayFabHttp.<SendScreenTimeEvents>d__17(int <>1__state)
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
        int val_4;
        var val_5;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        this.<delay>5__2 = new UnityEngine.WaitForSeconds(seconds:  this.secondsBetweenBatches);
        goto label_3;
        label_1:
        this.<>1__state = 0;
        label_3:
        if(PlayFab.PlayFabSettings.DisableFocusTimeCollection == false)
        {
            goto label_6;
        }
        
        label_2:
        val_4 = 0;
        return (bool)val_4;
        label_6:
        val_5 = null;
        val_5 = null;
        var val_4 = 0;
        val_4 = val_4 + 1;
        PlayFab.Internal.PlayFabHttp.screenTimeTracker.Send();
        val_4 = 1;
        this.<>1__state = val_4;
        this.<>2__current = this.<delay>5__2;
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
