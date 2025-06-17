using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class HaywireFxController : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Rendering.PostProcessing.PostProcessVolume postProcess;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Ibuprogames.VideoGlitchesAsset.VideoGlitchNoiseDigital noiseDigital;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Ibuprogames.VideoGlitchesAsset.VideoGlitchShift shift;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private float _strength;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool editorMode;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool _isNoiseDigitalNull;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool _isShiftNull;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Rendering.PostProcessing.ColorGrading _colorGrading;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool _strengthChanged;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Start()
    {
        this._isNoiseDigitalNull = UnityEngine.Object.op_Equality(x:  this.noiseDigital, y:  0);
        this._isShiftNull = UnityEngine.Object.op_Equality(x:  this.shift, y:  0);
        if(this.postProcess == 0)
        {
                return;
        }
        
        bool val_8 = this.postProcess.profile.TryGetSettings<UnityEngine.Rendering.PostProcessing.ColorGrading>(outSetting: out  this._colorGrading);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Update()
    {
        var val_3;
        if(this._isShiftNull != false)
        {
                if(this._isNoiseDigitalNull == true)
        {
                return;
        }
        
        }
        
        if(this._strengthChanged != true)
        {
                if(this.editorMode == false)
        {
                return;
        }
        
        }
        
        if(this._strength == 0f)
        {
                this.noiseDigital.enabled = false;
            val_3 = 0;
        }
        else
        {
                this.noiseDigital.enabled = true;
            val_3 = 1;
        }
        
        this.shift.enabled = true;
        mem2[0] = UnityEngine.Mathf.Lerp(a:  -40f, b:  -70f, t:  UnityEngine.Mathf.InverseLerp(a:  0f, b:  1f, value:  this._strength));
        this.noiseDigital.Strength = this._strength;
        this.shift.Strength = this._strength;
        this._strengthChanged = false;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void SetStrength(float strength)
    {
        this._strength = UnityEngine.Mathf.Clamp(value:  strength, min:  0f, max:  1f);
        this._strengthChanged = true;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public HaywireFxController()
    {
    
    }

}
