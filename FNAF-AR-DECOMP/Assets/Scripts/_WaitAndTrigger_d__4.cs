using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class TutorialDelayedTransition.<WaitAndTrigger>d__4 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <>1__state;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object <>2__current;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public TutorialDelayedTransition <>4__this;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public TutorialDelayedTransition.<WaitAndTrigger>d__4(int <>1__state)
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
        P7.CanvasFlow.CanvasController val_2;
        int val_3;
        val_2 = this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        val_3 = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  this.<>4__this._delay);
        this.<>1__state = val_3;
        return (bool)val_3;
        label_1:
        this.<>1__state = 0;
        if((this.<>4__this) != null)
        {
                val_2 = this.<>4__this._canvasController;
        }
        else
        {
                val_2 = 15026800;
        }
        
        val_2.PerformTransitionWithIdentifier(identifier:  this.<>4__this._transitionName);
        label_2:
        val_3 = 0;
        return (bool)val_3;
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
