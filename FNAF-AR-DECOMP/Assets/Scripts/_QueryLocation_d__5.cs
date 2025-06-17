using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class AbstractEditorLocationProvider.<QueryLocation>d__5 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <>1__state;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object <>2__current;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Mapbox.Unity.Location.AbstractEditorLocationProvider <>4__this;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AbstractEditorLocationProvider.<QueryLocation>d__5(int <>1__state)
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
        UnityEngine.WaitForSeconds val_4;
        int val_5;
        var val_6;
        if(((this.<>1__state) - 1) >= 2)
        {
            goto label_1;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this._autoFireEvent) != false)
        {
                Mapbox.Unity.Location.AbstractEditorLocationProvider val_2 = (this.<>4__this) + 24;
        }
        
        val_4 = this.<>4__this._wait;
        val_5 = 2;
        goto label_5;
        label_1:
        if((this.<>1__state) != 0)
        {
            goto label_6;
        }
        
        this.<>1__state = 0;
        UnityEngine.WaitForSeconds val_3 = null;
        val_4 = val_3;
        val_3 = new UnityEngine.WaitForSeconds(seconds:  0.1f);
        val_5 = 1;
        label_5:
        val_6 = 1;
        this.<>2__current = val_4;
        this.<>1__state = val_5;
        return (bool)val_6;
        label_6:
        val_6 = 0;
        return (bool)val_6;
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
