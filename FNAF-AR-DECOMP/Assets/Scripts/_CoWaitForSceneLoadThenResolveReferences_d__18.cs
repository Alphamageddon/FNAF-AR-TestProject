using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class AmsCrossSceneReferences.<CoWaitForSceneLoadThenResolveReferences>d__18 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <>1__state;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object <>2__current;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public CodingJar.MultiScene.AmsCrossSceneReferences <>4__this;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.SceneManagement.Scene scene;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AmsCrossSceneReferences.<CoWaitForSceneLoadThenResolveReferences>d__18(int <>1__state)
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
        UnityEngine.SceneManagement.Scene val_5;
        int val_6;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_8;
        }
        
        this.<>1__state = 0;
        if(UnityEngine.Application.isPlaying == false)
        {
            goto label_3;
        }
        
        val_5 = this.scene;
        if(val_5.IsValid() == true)
        {
            goto label_4;
        }
        
        goto label_8;
        label_1:
        val_5 = this.scene;
        this.<>1__state = 0;
        label_4:
        if(val_5.isLoaded == false)
        {
            goto label_6;
        }
        
        this.<>4__this.ConditionalResolveReferences(references:  this.<>4__this._referencesToResolve);
        goto label_8;
        label_6:
        val_6 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_6;
        return (bool)val_6;
        label_3:
        UnityEngine.Debug.LogErrorFormat(context:  this.<>4__this, format:  "CoWaitForSceneLoadThenResolveReferences called, but we\'re not playing. Co-routines do not work reliably in the Editor!", args:  System.Array.Empty<System.Object>());
        label_8:
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
