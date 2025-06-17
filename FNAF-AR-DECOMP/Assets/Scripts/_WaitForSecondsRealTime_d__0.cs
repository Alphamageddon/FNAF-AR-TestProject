using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class Coroutines.<WaitForSecondsRealTime>d__0 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <>1__state;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object <>2__current;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float time;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private float <endTime>5__2;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Coroutines.<WaitForSecondsRealTime>d__0(int <>1__state)
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
        float val_3;
        int val_4;
        if((this.<>1__state) == 1)
        {
            goto label_0;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_1;
        }
        
        this.<>1__state = 0;
        float val_1 = UnityEngine.Time.realtimeSinceStartup;
        val_3 = this.<endTime>5__2;
        val_1 = val_1 + this.time;
        this.<endTime>5__2 = val_1;
        goto label_2;
        label_0:
        val_3 = this.<endTime>5__2;
        this.<>1__state = 0;
        label_2:
        if(UnityEngine.Time.realtimeSinceStartup < 0)
        {
            goto label_3;
        }
        
        label_1:
        val_4 = 0;
        return (bool)val_4;
        label_3:
        val_4 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_4;
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
