using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class PhantomFxController : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.GameObject manifestVfx;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.GameObject burnVfx;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.GameObject repositionVfx;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.GameObject shutdownVfx;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.GameObject burnDistortion;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.GameObject mesh;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Animator animator;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ParticleSystemDuration manifestVfxDuration;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ParticleSystemDuration repositionVfxDuration;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ParticleSystemDuration shutdownVfxDuration;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool editorMode;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private PhantomFxController.States editorState;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private PhantomFxController.States _state;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool _burning;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool _reposition;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private float _targetWeight;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private float _smoothTime;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private float _animSpeed;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private float _emissionRate;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.ParticleSystem _burnParticleSystem;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.ParticleSystem.EmissionModule _burnParticleEmission;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private float _currentAnimLayerWeight;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private float _animLayerBlendVelocity;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly int HitReact;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly int Shutdown;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly int Jumpscare;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly int Overload;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly int OverloadEnd;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Action OnMeshToggled;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void add_OnMeshToggled(System.Action value)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.OnMeshToggled, b:  value);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.OnMeshToggled != 1152921518882915504);
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void remove_OnMeshToggled(System.Action value)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.OnMeshToggled, value:  value);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.OnMeshToggled != 1152921518883052080);
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void RegisterForMeshToggle(System.Action callback)
    {
        this.add_OnMeshToggled(value:  callback);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void UnregisterForMeshToggle(System.Action callback)
    {
        this.remove_OnMeshToggled(value:  callback);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float GetAnimationSpeedModifier()
    {
        return (float)this._animSpeed;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void SetState(PhantomFxController.States newState)
    {
        this._state = newState;
        this._burning = false;
        this._reposition = false;
        this._targetWeight = ;
        this._smoothTime = ;
        this._animSpeed = 1f;
        this._emissionRate = 0f;
        if((newState - 4) <= 5)
        {
                var val_2 = 49756048 + ((newState - 4)) << 2;
            val_2 = val_2 + 49756048;
        }
        else
        {
                this.ExecuteFx();
            this.ExecuteStateOnEnter();
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void ResetFx()
    {
        this._burning = false;
        this._reposition = false;
        this._targetWeight = ;
        this._smoothTime = ;
        this._animSpeed = 1f;
        this._emissionRate = 0f;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void SetStateFxConfig()
    {
        States val_1 = this._state;
        val_1 = val_1 - 4;
        if(val_1 > 5)
        {
                return;
        }
        
        var val_2 = 49756072 + ((this._state - 4)) << 2;
        val_2 = val_2 + 49756072;
        goto (49756072 + ((this._state - 4)) << 2 + 49756072);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void ExecuteStateOnEnter()
    {
        this.animator.gameObject.SetActive(value:  true);
        this.mesh.SetActive(value:  true);
        this.shutdownVfx.SetActive(value:  false);
        States val_26 = this._state;
        val_26 = val_26 - 1;
        if(val_26 > 8)
        {
                return;
        }
        
        var val_27 = 49756104 + ((this._state - 1)) << 2;
        val_27 = val_27 + 49756104;
        goto (49756104 + ((this._state - 1)) << 2 + 49756104);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void ExecuteFx()
    {
        this.burnDistortion.SetActive(value:  (this._burning == true) ? 1 : 0);
        this.repositionVfx.SetActive(value:  (this._reposition == true) ? 1 : 0);
        this.animator.speed = this._animSpeed;
        MinMaxCurve val_3 = ParticleSystem.MinMaxCurve.op_Implicit(constant:  this._emissionRate);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Start()
    {
        this.editorMode = false;
        this.editorState = 4294967297;
        UnityEngine.ParticleSystem val_1 = this.burnVfx.GetComponent<UnityEngine.ParticleSystem>();
        this._burnParticleSystem = val_1;
        EmissionModule val_2 = val_1.emission;
        this._burnParticleEmission = val_2.m_ParticleSystem;
        this._state = 1;
        this._burning = false;
        this._reposition = false;
        this._targetWeight = ;
        this._smoothTime = ;
        this._animSpeed = 1f;
        this._emissionRate = 0f;
        this.ExecuteFx();
        this.ExecuteStateOnEnter();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Update()
    {
        if((this.editorMode != false) && (this._state != this.editorState))
        {
                this.SetState(newState:  this.editorState);
        }
        
        this.animator.SetLayerWeight(layerIndex:  1, weight:  this.GetLayerBlendWeight(targetWeight:  this._targetWeight, smoothTime:  this._smoothTime));
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Collections.IEnumerator TurnOffManifestVfx(float seconds)
    {
        PhantomFxController.<TurnOffManifestVfx>d__42 val_1 = new PhantomFxController.<TurnOffManifestVfx>d__42();
        .<>1__state = 0;
        if(val_1 != null)
        {
                .<>4__this = this;
        }
        else
        {
                mem[40] = this;
        }
        
        .seconds = seconds;
        return (System.Collections.IEnumerator)val_1;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Collections.IEnumerator TurnOnShutdownVfx(float seconds)
    {
        PhantomFxController.<TurnOnShutdownVfx>d__43 val_1 = new PhantomFxController.<TurnOnShutdownVfx>d__43();
        .<>1__state = 0;
        if(val_1 != null)
        {
                .<>4__this = this;
        }
        else
        {
                mem[40] = this;
        }
        
        .seconds = seconds;
        return (System.Collections.IEnumerator)val_1;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Collections.IEnumerator ToggleAnimator(bool status, float seconds)
    {
        PhantomFxController.<ToggleAnimator>d__44 val_1 = new PhantomFxController.<ToggleAnimator>d__44();
        .<>1__state = 0;
        if(val_1 != null)
        {
                .<>4__this = this;
            .status = status;
        }
        else
        {
                mem[40] = this;
            mem[48] = status;
        }
        
        .seconds = seconds;
        return (System.Collections.IEnumerator)val_1;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Collections.IEnumerator ToggleMesh(bool status, float seconds)
    {
        PhantomFxController.<ToggleMesh>d__45 val_1 = new PhantomFxController.<ToggleMesh>d__45();
        .<>1__state = 0;
        if(val_1 != null)
        {
                .<>4__this = this;
            .status = status;
        }
        else
        {
                mem[40] = this;
            .status = status;
        }
        
        .seconds = seconds;
        return (System.Collections.IEnumerator)val_1;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private float GetLayerBlendWeight(float targetWeight, float smoothTime)
    {
        return UnityEngine.Mathf.SmoothDamp(current:  this.animator.GetLayerWeight(layerIndex:  1), target:  targetWeight, currentVelocity: ref  this._animLayerBlendVelocity, smoothTime:  smoothTime);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public PhantomFxController()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static PhantomFxController()
    {
        PhantomFxController.HitReact = UnityEngine.Animator.StringToHash(name:  "hitReact");
        PhantomFxController.Shutdown = UnityEngine.Animator.StringToHash(name:  "shutdown");
        PhantomFxController.Jumpscare = UnityEngine.Animator.StringToHash(name:  "jumpscare");
        PhantomFxController.Overload = UnityEngine.Animator.StringToHash(name:  "overload");
        PhantomFxController.OverloadEnd = UnityEngine.Animator.StringToHash(name:  "overloadEnd");
    }

}
