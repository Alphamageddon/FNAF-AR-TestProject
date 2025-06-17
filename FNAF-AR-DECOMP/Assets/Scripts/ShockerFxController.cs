using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class ShockerFxController : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const float NoBatteryDuration = 0.07;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const float MissDuration = 0.4;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const float HitDuration = 0.8;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Light shockerLight;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.GameObject[] lightningBolts;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float duration;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool _targetHit;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool _batteryEmpty;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool _isShockerLightNull;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool _isLightningBoltsNull;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private DigitalRuby.LightningBolt.LightningBoltScript[] _missedBoltScripts;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private DigitalRuby.LightningBolt.LightningBoltScript[] _hitBoltScripts;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.ParticleSystem _spark;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.ParticleSystem.EmissionModule _emissionModule;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Start()
    {
        this._isShockerLightNull = UnityEngine.Object.op_Equality(x:  this.shockerLight, y:  0);
        this._isLightningBoltsNull = (this.lightningBolts == null) ? 1 : 0;
        this._missedBoltScripts = this.lightningBolts[1].GetComponentsInChildren<DigitalRuby.LightningBolt.LightningBoltScript>();
        this._hitBoltScripts = this.lightningBolts[2].GetComponentsInChildren<DigitalRuby.LightningBolt.LightningBoltScript>();
        UnityEngine.ParticleSystem val_6 = this.lightningBolts[2].GetComponentInChildren<UnityEngine.ParticleSystem>();
        this._spark = val_6;
        EmissionModule val_7 = val_6.emission;
        this._emissionModule = val_7.m_ParticleSystem;
        this.Reset();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void StartEffect(bool didHit)
    {
        this._batteryEmpty = false;
        this._targetHit = didHit;
        this.StartEffect();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void EndEffect()
    {
        if(this._isLightningBoltsNull == true)
        {
                return;
        }
        
        if(this._isShockerLightNull != false)
        {
                return;
        }
        
        this.Reset();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void StartEffect()
    {
        var val_4;
        var val_5;
        if(this._isLightningBoltsNull == true)
        {
                return;
        }
        
        bool val_4 = this._isShockerLightNull;
        val_4 = val_4 + 3;
        var val_5 = ~val_4;
        val_5 = val_5 & 3;
        if(val_5 != 0)
        {
                return;
        }
        
        this.Reset();
        if(this._batteryEmpty != false)
        {
                this.duration = 0.07f;
            this.lightningBolts[0].SetActive(value:  true);
            this.shockerLight.enabled = true;
            this.shockerLight.range = 0f;
            return;
        }
        
        if(this._targetHit == false)
        {
            goto label_8;
        }
        
        this.duration = 0.8f;
        this.shockerLight.enabled = true;
        this.shockerLight.range = 10f;
        MinMaxCurve val_1 = ParticleSystem.MinMaxCurve.op_Implicit(constant:  300f);
        val_4 = 0;
        goto label_11;
        label_15:
        DigitalRuby.LightningBolt.LightningBoltScript val_7 = this._hitBoltScripts[0];
        val_4 = 1;
        this._hitBoltScripts[0x0][0].ManualMode = false;
        label_11:
        if(val_4 < this._hitBoltScripts.Length)
        {
            goto label_15;
        }
        
        return;
        label_8:
        this.duration = 0.4f;
        this.shockerLight.enabled = true;
        this.shockerLight.range = 2.5f;
        val_5 = 0;
        goto label_19;
        label_23:
        DigitalRuby.LightningBolt.LightningBoltScript val_8 = this._missedBoltScripts[0];
        val_5 = 1;
        this._missedBoltScripts[0x0][0].ManualMode = false;
        label_19:
        if(val_5 < this._missedBoltScripts.Length)
        {
            goto label_23;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Reset()
    {
        var val_4;
        var val_5;
        val_4 = 0;
        goto label_0;
        label_4:
        DigitalRuby.LightningBolt.LightningBoltScript val_4 = this._missedBoltScripts[0];
        val_4 = 1;
        this._missedBoltScripts[0x0][0].ManualMode = true;
        label_0:
        if(val_4 < this._missedBoltScripts.Length)
        {
            goto label_4;
        }
        
        val_5 = 0;
        goto label_5;
        label_9:
        DigitalRuby.LightningBolt.LightningBoltScript val_5 = this._hitBoltScripts[0];
        val_5 = 1;
        this._hitBoltScripts[0x0][0].ManualMode = true;
        label_5:
        if(val_5 < this._hitBoltScripts.Length)
        {
            goto label_9;
        }
        
        MinMaxCurve val_1 = ParticleSystem.MinMaxCurve.op_Implicit(constant:  0f);
        this.lightningBolts[0].SetActive(value:  false);
        this.shockerLight.range = 0f;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ShockerFxController()
    {
    
    }

}
