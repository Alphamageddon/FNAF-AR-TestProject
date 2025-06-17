using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class PopDownDispatcher.<ShowMessageTimer>d__12 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <>1__state;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object <>2__current;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public GameUI.PopDownData popDownData;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public GameUI.PopDownDispatcher <>4__this;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public PopDownDispatcher.<ShowMessageTimer>d__12(int <>1__state)
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
        int val_2;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        this.popDownData.show = true;
        this.<>4__this._currentPopDownData = this.popDownData;
        val_2 = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  this.popDownData.showTime);
        this.<>1__state = val_2;
        return (bool)val_2;
        label_1:
        this.<>1__state = 0;
        if((this.<>4__this._currentPopDownData) == this.popDownData)
        {
            goto label_8;
        }
        
        label_2:
        val_2 = 0;
        return (bool)val_2;
        label_8:
        this.<>4__this._currentPopDownData.show = false;
        this.<>4__this._currentPopDownData = this.popDownData;
        return (bool)val_2;
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
