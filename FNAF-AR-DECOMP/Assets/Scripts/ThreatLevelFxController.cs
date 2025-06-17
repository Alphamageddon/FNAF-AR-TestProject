using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class ThreatLevelFxController : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.GameObject threatLevel;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Rendering.PostProcessing.PostProcessVolume postProcess;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private float _strength;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float smoothTime;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool _isThreatLevelNull;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool _isPostProcessNull;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Rendering.PostProcessing.ColorGrading _colorGrading;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.ParticleSystem[] _smokeVfxs;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private float _refVelocity;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool _isFxEnabled;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private const float _threshold = 0.05;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Start()
    {
        this._isThreatLevelNull = UnityEngine.Object.op_Equality(x:  this.threatLevel, y:  0);
        this._isPostProcessNull = UnityEngine.Object.op_Equality(x:  this.postProcess, y:  0);
        if(this.postProcess != 0)
        {
                bool val_8 = this.postProcess.profile.TryGetSettings<UnityEngine.Rendering.PostProcessing.ColorGrading>(outSetting: out  this._colorGrading);
        }
        
        this._smokeVfxs = this.threatLevel.GetComponentsInChildren<UnityEngine.ParticleSystem>();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Update()
    {
        bool val_4;
        if(this._strength <= 0.05f)
        {
            goto label_0;
        }
        
        if(this._strength <= 0.05f)
        {
            goto label_1;
        }
        
        this.EnableFx();
        val_4 = 1;
        goto label_2;
        label_0:
        this.DisableFx();
        val_4 = false;
        label_2:
        this._isFxEnabled = val_4;
        label_1:
        if(this._isThreatLevelNull == true)
        {
                return;
        }
        
        if(this._isPostProcessNull == true)
        {
                return;
        }
        
        if(this._isFxEnabled == false)
        {
                return;
        }
        
        UnityEngine.Vector3 val_2 = this.GetThreatScale();
        this.threatLevel.transform.localScale = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        mem2[0] = this.GetTemperatureValue();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void SetStrength(float strength)
    {
        this._strength = UnityEngine.Mathf.Clamp(value:  strength, min:  0f, max:  1f);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void OnDisable()
    {
        this.threatLevel.SetActive(value:  false);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void EnableFx()
    {
        UnityEngine.ParticleSystem val_6;
        var val_7;
        val_6 = this;
        this.threatLevel.SetActive(value:  true);
        val_7 = 0;
        goto label_1;
        label_5:
        val_6 = this._smokeVfxs[0];
        EmissionModule val_1 = val_6.emission;
        MinMaxCurve val_2 = ParticleSystem.MinMaxCurve.op_Implicit(constant:  2f);
        val_7 = 1;
        label_1:
        if(val_7 < this._smokeVfxs.Length)
        {
            goto label_5;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void DisableFx()
    {
        goto label_0;
        label_4:
        EmissionModule val_1 = this._smokeVfxs[0].emission;
        MinMaxCurve val_2 = ParticleSystem.MinMaxCurve.op_Implicit(constant:  0f);
        0 = 1;
        label_0:
        if(0 < this._smokeVfxs.Length)
        {
            goto label_4;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Vector3 GetThreatScale()
    {
        float val_1 = this.GetNormalizedStrength();
        UnityEngine.Vector3 val_3 = this.threatLevel.transform.localScale;
        float val_7 = UnityEngine.Mathf.SmoothDamp(current:  val_3.x, target:  UnityEngine.Mathf.Lerp(a:  1.1f, b:  0.7f, t:  val_1), currentVelocity: ref  this._refVelocity, smoothTime:  this.smoothTime);
        float val_9 = UnityEngine.Mathf.SmoothDamp(current:  val_3.y, target:  UnityEngine.Mathf.Lerp(a:  1.2f, b:  1f, t:  val_1), currentVelocity: ref  this._refVelocity, smoothTime:  this.smoothTime);
        return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private float GetTemperatureValue()
    {
        return UnityEngine.Mathf.Lerp(a:  -70f, b:  -90f, t:  this.GetNormalizedStrength());
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private float GetNormalizedStrength()
    {
        return UnityEngine.Mathf.InverseLerp(a:  0f, b:  1f, value:  this._strength);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ThreatLevelFxController()
    {
        this.smoothTime = 0.75f;
    }

}
