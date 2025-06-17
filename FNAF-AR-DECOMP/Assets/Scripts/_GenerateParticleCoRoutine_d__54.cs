using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class LightningBolt.<GenerateParticleCoRoutine>d__54 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <>1__state;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object <>2__current;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float delay;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.ParticleSystem p;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Vector3 pos;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public LightningBolt.<GenerateParticleCoRoutine>d__54(int <>1__state)
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
        var val_8;
        int val_16;
        float val_17;
        int val_18;
        int val_19;
        int val_20;
        val_16 = this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        val_17 = this.delay;
        val_18 = 1;
        this.<>2__current = new DigitalRuby.ThunderAndLightning.WaitForSecondsLightning(time:  val_17);
        this.<>1__state = val_18;
        return (bool)val_18;
        label_1:
        this.<>1__state = 0;
        val_17 = this.pos;
        this.p.transform.position = new UnityEngine.Vector3() {x = val_17, y = V9.16B, z = V10.16B};
        EmissionModule val_3 = this.p.emission;
        EmissionModule val_4 = this.p.emission;
        if( >= 1)
        {
                EmissionModule val_6 = this.p.emission;
            val_19 = ((int)new Burst[1741931784][32] & 65535) + 1;
            val_20 = (int)new Burst[1741931784][32] & 65535;
        }
        else
        {
                MinMaxCurve val_7 = val_6.m_ParticleSystem.rateOverTime;
            val_17 = val_8.targetValue;
            float val_11 = val_8.startValue;
            val_11 = val_17 - val_11;
            val_11 = val_11 * 0.5f;
            val_20 = (int)val_11;
            val_19 = val_20 << 1;
        }
        
        val_16 = UnityEngine.Random.Range(min:  val_20, max:  val_19);
        this.p.Emit(count:  val_16);
        label_2:
        val_18 = 0;
        return (bool)val_18;
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
