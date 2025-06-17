using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class LightningBolt.<NotifyBolt>d__42 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <>1__state;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object <>2__current;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public DigitalRuby.ThunderAndLightning.LightningBoltParameters p;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public DigitalRuby.ThunderAndLightning.LightningBoltDependencies dependencies;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Vector3 start;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Vector3 end;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Transform transform;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private float <lifeTime>5__2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private DigitalRuby.ThunderAndLightning.LightningCustomTransformStateInfo <state>5__3;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public LightningBolt.<NotifyBolt>d__42(int <>1__state)
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
        DigitalRuby.ThunderAndLightning.LightningBoltParameters val_5;
        int val_8;
        val_5 = this;
        if((this.<>1__state) <= 3)
        {
                var val_5 = 52952464 + (this.<>1__state) << 2;
            val_5 = val_5 + 52952464;
        }
        else
        {
                val_8 = 0;
            return (bool);
        }
    
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
