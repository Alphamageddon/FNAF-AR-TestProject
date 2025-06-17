using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class ChildCellDisabler.<WaitThenReenable>d__7 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <>1__state;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object <>2__current;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float delay;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public GameUI.ChildCellDisabler <>4__this;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ChildCellDisabler.<WaitThenReenable>d__7(int <>1__state)
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
        object val_5;
        int val_6;
        var val_7;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        UnityEngine.WaitForSeconds val_1 = null;
        val_5 = val_1;
        val_1 = new UnityEngine.WaitForSeconds(seconds:  this.delay);
        val_6 = 1;
        this.<>2__current = val_5;
        this.<>1__state = val_6;
        return (bool)val_6;
        label_1:
        this.<>1__state = 0;
        val_5 = 0;
        goto label_4;
        label_13:
        val_7 = public GameUI.IDisableableChildCell System.Collections.Generic.List<GameUI.IDisableableChildCell>::get_Item(int index);
        var val_5 = 0;
        val_5 = val_5 + 1;
        val_7 = 0;
        this.<>4__this._children.Item[0].UpdateEnableState(state:  true);
        val_5 = 1;
        label_4:
        if(val_5 < (this.<>4__this._children.Count))
        {
            goto label_13;
        }
        
        val_6 = 0;
        this.<>4__this._isDisabling = false;
        return (bool)val_6;
        label_2:
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
