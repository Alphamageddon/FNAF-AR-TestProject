using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private class ThunderAndLightningScript.LightningBoltHandler
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private float <VolumeMultiplier>k__BackingField;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private DigitalRuby.ThunderAndLightning.ThunderAndLightningScript script;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private readonly System.Random random;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float VolumeMultiplier { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float get_VolumeMultiplier()
    {
        return (float)this.<VolumeMultiplier>k__BackingField;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_VolumeMultiplier(float value)
    {
        this.<VolumeMultiplier>k__BackingField = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ThunderAndLightningScript.LightningBoltHandler(DigitalRuby.ThunderAndLightning.ThunderAndLightningScript script)
    {
        this.random = new System.Random();
        this.script = script;
        this.CalculateNextLightningTime();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void UpdateLighting()
    {
        DigitalRuby.ThunderAndLightning.ThunderAndLightningScript val_3;
        if(this.script.lightningInProgress != false)
        {
                return;
        }
        
        if(this.script.ModifySkyboxExposure == false)
        {
            goto label_12;
        }
        
        this.script.skyboxExposureStorm = 0.35f;
        if((this.script.skyboxMaterial == 0) || ((this.script.skyboxMaterial.HasProperty(name:  "_Exposure")) == false))
        {
            goto label_12;
        }
        
        val_3 = this.script;
        if(this.script != null)
        {
            goto label_13;
        }
        
        val_3 = this.script;
        if(val_3 == null)
        {
            goto label_14;
        }
        
        label_13:
        this.script.skyboxMaterial.SetFloat(name:  "_Exposure", value:  this.script.skyboxExposureStorm);
        label_12:
        this.CheckForLightning();
        return;
        label_14:
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void CalculateNextLightningTime()
    {
        DigitalRuby.ThunderAndLightning.ThunderAndLightningScript val_3;
        float val_1 = DigitalRuby.ThunderAndLightning.LightningBoltScript.TimeSinceStart;
        val_1 = val_1 + val_1;
        this.script.nextLightningTime = val_1;
        this.script.lightningInProgress = false;
        if(this.script.ModifySkyboxExposure == false)
        {
                return;
        }
        
        if((this.script.skyboxMaterial.HasProperty(name:  "_Exposure")) == false)
        {
                return;
        }
        
        val_3 = this.script;
        if(this.script != null)
        {
            goto label_11;
        }
        
        val_3 = this.script;
        if(val_3 == null)
        {
            goto label_12;
        }
        
        label_11:
        this.script.skyboxMaterial.SetFloat(name:  "_Exposure", value:  this.script.skyboxExposureStorm);
        return;
        label_12:
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Collections.IEnumerator ProcessLightning(System.Nullable<UnityEngine.Vector3> _start, System.Nullable<UnityEngine.Vector3> _end, bool intense, bool visible)
    {
        ThunderAndLightningScript.LightningBoltHandler.<ProcessLightning>d__9 val_1 = new ThunderAndLightningScript.LightningBoltHandler.<ProcessLightning>d__9();
        .<>1__state = 0;
        if(val_1 != null)
        {
                .<>4__this = this;
            ._start = _start;
            mem[1152921528902427956] = _end.HasValue;
            ._end = intense;
            mem[1152921528902427972] = visible;
            .intense = W5 & 1;
        }
        else
        {
                mem[32] = this;
            ._start = _start;
            mem[1152921528902427956] = _end.HasValue;
            ._end = intense;
            mem[1152921528902427972] = visible;
            mem[40] = W5 & 1;
        }
        
        .visible = W6 & 1;
        return (System.Collections.IEnumerator)val_1;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Strike(System.Nullable<UnityEngine.Vector3> _start, System.Nullable<UnityEngine.Vector3> _end, bool intense, float intensity, UnityEngine.Camera camera, UnityEngine.Camera visibleInCamera)
    {
        float val_44;
        float val_45;
        float val_46;
        float val_47;
        float val_48;
        var val_51;
        float val_52;
        float val_53;
        float val_55;
        var val_56;
        float val_57;
        float val_58;
        val_44 = -1000f;
        float val_1 = (visibleInCamera != 1) ? (val_44) : -5000f;
        float val_2 = (visibleInCamera != 1) ? 1000f : 5000f;
        float val_3 = (visibleInCamera != 1) ? 500f : 2500f;
        if((UnityEngine.Random.Range(min:  0, max:  2)) != 0)
        {
                val_45 = val_3;
        }
        else
        {
                val_45 = val_1;
        }
        
        if((UnityEngine.Random.Range(min:  0, max:  2)) != 0)
        {
                val_46 = val_3;
            val_47 = val_2;
        }
        else
        {
                val_47 = -val_3;
            val_46 = val_1;
        }
        
        val_48 = UnityEngine.Random.Range(min:  val_46, max:  val_47);
        UnityEngine.Vector3 val_9 = this.script.Camera.transform.position;
        if(X7 == 0)
        {
            goto label_11;
        }
        
        UnityEngine.Quaternion val_12 = X7.transform.rotation;
        UnityEngine.Quaternion val_14 = UnityEngine.Quaternion.Euler(x:  0f, y:  val_12.y, z:  0f);
        X7.transform.rotation = new UnityEngine.Quaternion() {x = val_14.x, y = val_14.y, z = val_14.z, w = val_14.w};
        if(X7 == 0)
        {
            goto label_18;
        }
        
        val_51 = X7.pixelWidth;
        goto label_19;
        label_11:
        val_52 = (UnityEngine.Random.Range(min:  val_45, max:  -val_3)) + val_9.x;
        val_53 = val_48 + val_9.z;
        goto label_20;
        label_18:
        val_51 = 0.pixelWidth;
        label_19:
        float val_42 = 0.1f;
        float val_43 = 0.9f;
        val_42 = (float)val_51 * val_42;
        val_43 = (float)X7.pixelWidth * val_43;
        float val_18 = UnityEngine.Random.Range(min:  val_42, max:  val_43);
        float val_19 = X7.nearClipPlane;
        val_19 = val_3 + val_19;
        val_19 = val_3 + val_19;
        float val_20 = UnityEngine.Random.Range(min:  val_19, max:  val_2);
        UnityEngine.Vector3 val_21 = X7.ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        val_52 = val_21.x;
        val_53 = val_21.z;
        val_44 = val_12.z;
        X7.transform.rotation = new UnityEngine.Quaternion() {x = val_12.x, y = val_12.y, z = val_44, w = val_12.w};
        val_48 = val_48;
        label_20:
        if((UnityEngine.Random.Range(min:  0, max:  4)) != 0)
        {
                val_55 = -1f;
        }
        else
        {
                val_55 = UnityEngine.Random.Range(min:  -1f, max:  600f);
        }
        
        UnityEngine.Vector3 val_28 = X6.transform.forward;
        float val_44 = val_28.x;
        val_48 = val_48 + (UnityEngine.Random.Range(min:  -100f, max:  100f));
        val_44 = val_3 * val_44;
        val_56 = X6.transform;
        val_48 = val_53 + val_48;
        val_57 = (val_52 + (UnityEngine.Random.Range(min:  -100f, max:  100f))) + val_44;
        goto label_35;
        label_38:
        UnityEngine.Vector3 val_32 = X6.transform.forward;
        val_57 = val_57 + (val_3 * val_32.x);
        val_56 = X6.transform;
        label_35:
        UnityEngine.Vector3 val_35 = val_56.forward;
        val_58 = val_48 + (val_3 * val_35.z);
        UnityEngine.Vector3 val_37 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_52, y = this.script.LightningYStart, z = val_53}, b:  new UnityEngine.Vector3() {x = val_57, y = val_55, z = val_58});
        if(val_37.x < 0)
        {
            goto label_38;
        }
        
        if(((-1474027104) & 1) != 0)
        {
                val_52 = val_37.x;
            val_53 = val_37.z;
        }
        
        if(((-1474027104) & 1) != 0)
        {
                val_57 = val_37.x;
            val_55 = val_37.y;
            val_58 = val_37.z;
        }
        
        UnityEngine.Vector3 val_38 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_52, y = val_37.y, z = val_53}, b:  new UnityEngine.Vector3() {x = val_57, y = val_55, z = val_58});
        if((UnityEngine.Physics.Raycast(origin:  new UnityEngine.Vector3() {x = val_52, y = val_37.y, z = val_53}, direction:  new UnityEngine.Vector3() {x = val_38.x, y = val_38.y, z = val_38.z}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, maxDistance:  3.402823E+38f)) != false)
        {
                val_57 = val_52;
            val_55 = val_37.y;
            val_58 = val_53;
        }
        
        if(UnityEngine.Random.value < 0)
        {
                DigitalRuby.ThunderAndLightning.LightningBoltPrefabScript val_41 = this.script.LightningBoltScript + 372;
            mem2[0] = 0;
            mem2[0] = 1;
        }
        
        float val_45 = 0.5f;
        val_45 = intensity * val_45;
        mem2[0] = val_45;
        this.script.LightningBoltScript.Trigger(start:  new System.Nullable<UnityEngine.Vector3>() {HasValue = false}, end:  new System.Nullable<UnityEngine.Vector3>() {HasValue = false});
        mem2[0] = this.script;
        mem2[0] = _end.HasValue;
        mem2[0] = intense;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void CheckForLightning()
    {
        DigitalRuby.ThunderAndLightning.ThunderAndLightningScript val_7;
        var val_8;
        if(UnityEngine.Time.time < this.script.nextLightningTime)
        {
                return;
        }
        
        float val_2 = UnityEngine.Random.value;
        val_7 = this.script;
        if(val_7 != null)
        {
                val_8 = 0;
            var val_3 = (val_2 < 0) ? 1 : 0;
        }
        else
        {
                val_7 = this.script;
            var val_4 = (val_2 < 0) ? 1 : 0;
            if(val_7 != null)
        {
                val_8 = 0;
        }
        else
        {
                val_8 = 1;
        }
        
        }
        
        UnityEngine.Coroutine val_6 = val_7.StartCoroutine(routine:  this.ProcessLightning(_start:  new System.Nullable<UnityEngine.Vector3>() {HasValue = false}, _end:  new System.Nullable<UnityEngine.Vector3>() {HasValue = false}, intense:  false, visible:  false));
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Update()
    {
        this.UpdateLighting();
    }

}
