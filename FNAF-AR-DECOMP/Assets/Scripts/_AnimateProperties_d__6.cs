using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class ShaderPropAnimator.<AnimateProperties>d__6 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <>1__state;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object <>2__current;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public TMPro.Examples.ShaderPropAnimator <>4__this;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ShaderPropAnimator.<AnimateProperties>d__6(int <>1__state)
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
        UnityEngine.AnimationCurve val_6;
        int val_7;
        var val_8;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        this.<>4__this.m_frame = UnityEngine.Random.Range(min:  0f, max:  1f);
        goto label_4;
        label_1:
        this.<>1__state = 0;
        if((this.<>4__this) == null)
        {
            goto label_5;
        }
        
        label_4:
        val_6 = this.<>4__this.GlowCurve;
        goto label_6;
        label_2:
        val_7 = 0;
        return (bool)val_7;
        label_5:
        val_6 = 69077560;
        label_6:
        val_8 = null;
        val_8 = null;
        this.<>4__this.m_Material.SetFloat(nameID:  TMPro.ShaderUtilities.ID_GlowPower, value:  val_6.Evaluate(time:  this.<>4__this.m_frame));
        float val_4 = UnityEngine.Random.Range(min:  0.2f, max:  0.3f);
        val_4 = UnityEngine.Time.deltaTime * val_4;
        val_4 = (this.<>4__this.m_frame) + val_4;
        this.<>4__this.m_frame = val_4;
        val_7 = 1;
        this.<>2__current = new UnityEngine.WaitForEndOfFrame();
        this.<>1__state = val_7;
        return (bool)val_7;
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
