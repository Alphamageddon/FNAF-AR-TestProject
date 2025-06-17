using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class LightningBolt.<EnableLastRendererCoRoutine>d__39 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <>1__state;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object <>2__current;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public DigitalRuby.ThunderAndLightning.LightningBolt <>4__this;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private DigitalRuby.ThunderAndLightning.LightningBolt.LineRendererMesh <lineRenderer>5__2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <tag>5__3;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public LightningBolt.<EnableLastRendererCoRoutine>d__39(int <>1__state)
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
        LightningBolt.LineRendererMesh val_5;
        int val_6;
        int val_7;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this) == null)
        {
            goto label_3;
        }
        
        if((this.<>4__this.activeLineRenderers) != null)
        {
            goto label_10;
        }
        
        label_11:
        label_10:
        val_5 = this.<>4__this.activeLineRenderers.Item[(this.<>4__this.activeLineRenderers.Count) - 1];
        this.<lineRenderer>5__2 = val_5;
        if(val_5 == null)
        {
            goto label_6;
        }
        
        val_6 = val_3.<Tag>k__BackingField;
        goto label_7;
        label_1:
        val_5 = this.<lineRenderer>5__2;
        this.<>1__state = 0;
        this.<>4__this.EnableLineRenderer(lineRenderer:  val_5, tag:  this.<tag>5__3);
        label_2:
        val_7 = 0;
        return (bool)val_7;
        label_3:
        if(0 != 0)
        {
            goto label_10;
        }
        
        goto label_11;
        label_6:
        val_5 = 24;
        val_6 = 15026800;
        label_7:
        mem[24] = 15026801;
        this.<tag>5__3 = 15026801;
        val_7 = 1;
        this.<>2__current = new DigitalRuby.ThunderAndLightning.WaitForSecondsLightning(time:  this.<>4__this.<MinimumDelay>k__BackingField);
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
