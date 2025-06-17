using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class ThunderAndLightningScript.LightningBoltHandler.<ProcessLightning>d__9 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <>1__state;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object <>2__current;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public DigitalRuby.ThunderAndLightning.ThunderAndLightningScript.LightningBoltHandler <>4__this;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool intense;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Nullable<UnityEngine.Vector3> _start;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Nullable<UnityEngine.Vector3> _end;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool visible;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.AudioClip[] <sounds>5__2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private float <intensity>5__3;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ThunderAndLightningScript.LightningBoltHandler.<ProcessLightning>d__9(int <>1__state)
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
        float val_11;
        float val_13;
        UnityEngine.AudioClip[] val_14;
        System.Nullable<UnityEngine.Vector3> val_15;
        UnityEngine.AudioClip val_16;
        DigitalRuby.ThunderAndLightning.ThunderAndLightningScript val_17;
        int val_18;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_45;
        }
        
        this.<>1__state = 0;
        this.<>4__this.script.lightningInProgress = true;
        val_11 = 1f;
        float val_1 = UnityEngine.Random.Range(min:  0f, max:  val_11);
        if(this.intense == false)
        {
            goto label_5;
        }
        
        float val_2 = UnityEngine.Mathf.Lerp(a:  2f, b:  8f, t:  val_1);
        this.<intensity>5__3 = val_2;
        val_13 = 5f / val_2;
        val_14 = this.<>4__this.script.ThunderSoundsIntense;
        goto label_9;
        label_1:
        this.<>1__state = 0;
        val_15 = 1152921504851574784;
        label_19:
        val_16 = this.<sounds>5__2[(long)UnityEngine.Random.Range(min:  0, max:  (this.<sounds>5__2.Length) - 1)];
        if((this.<sounds>5__2.Length) >= 2)
        {
                if(val_16 == (this.<>4__this.script.lastThunderSound))
        {
            goto label_19;
        }
        
        }
        
        this.<>4__this.script.lastThunderSound = val_16;
        val_11 = this.<intensity>5__3;
        float val_11 = 0.5f;
        val_11 = val_11 * val_11;
        val_11 = val_11 * (this.<>4__this.<VolumeMultiplier>k__BackingField);
        this.<>4__this.script.audioSourceThunder.PlayOneShot(clip:  val_16, volumeScale:  val_11);
        goto label_45;
        label_5:
        float val_6 = UnityEngine.Mathf.Lerp(a:  0f, b:  2f, t:  val_1);
        this.<intensity>5__3 = val_6;
        val_13 = 30f / val_6;
        val_14 = this.<>4__this.script.ThunderSoundsNormal;
        label_9:
        this.<sounds>5__2 = mem[this.<>4__this.script.ThunderSoundsNormal];
        if(((this.<>4__this.script.skyboxMaterial) == 0) || ((this.<>4__this.script.ModifySkyboxExposure) == false))
        {
            goto label_33;
        }
        
        val_17 = this.<>4__this.script;
        if((this.<>4__this.script) != null)
        {
            goto label_34;
        }
        
        val_17 = this.<>4__this.script;
        if(val_17 == null)
        {
            goto label_35;
        }
        
        label_34:
        float val_12 = 0.5f;
        val_12 = (this.<intensity>5__3) * val_12;
        this.<>4__this.script.skyboxMaterial.SetFloat(name:  "_Exposure", value:  UnityEngine.Mathf.Max(a:  val_12, b:  this.<>4__this.script.skyboxExposureStorm));
        label_33:
        val_16 = this._start;
        val_15 = this._end;
        if(this.visible != false)
        {
                if((this.<>4__this.script) != null)
        {
            goto label_42;
        }
        
        }
        
        label_42:
        this.<>4__this.Strike(_start:  new System.Nullable<UnityEngine.Vector3>() {HasValue = val_16}, _end:  new System.Nullable<UnityEngine.Vector3>() {HasValue = true}, intense:  val_15, intensity:  this.<intensity>5__3, camera:  X24, visibleInCamera:  (this.intense == true) ? 1 : 0);
        this.<>4__this.CalculateNextLightningTime();
        if((((this.<intensity>5__3) >= val_11) && ((this.<sounds>5__2) != null)) && ((this.<sounds>5__2.Length) != 0))
        {
                val_18 = 1;
            .remaining = val_13;
            this.<>2__current = new DigitalRuby.ThunderAndLightning.WaitForSecondsLightning();
            this.<>1__state = val_18;
            return (bool)val_18;
        }
        
        label_45:
        val_18 = 0;
        return (bool)val_18;
        label_35:
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
