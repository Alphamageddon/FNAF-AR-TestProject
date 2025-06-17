using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class DisruptionFxController : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Ibuprogames.VideoGlitchesAsset.VideoGlitchVHSNoise vhsNoise1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Ibuprogames.VideoGlitchesAsset.VideoGlitchVHSNoise vhsNoise2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Ibuprogames.VideoGlitchesAsset.VideoGlitchNoiseAnalog noiseAnalog;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Ibuprogames.VideoGlitchesAsset.VideoGlitchBrokenCamera brokenCamera;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.GameObject frostDisruption;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool useFrostDisruption;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private float _strength;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool _isVhsNoise1Null;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool _isVhsNoise2Null;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool _isNoiseAnalogNull;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool _isBrokenCameraNull;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool _isFrostDisruptionNull;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Material frostMaterial;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool _isFrostMaterialNull;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool _isFxEnabled;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Start()
    {
        UnityEngine.Material val_14;
        this._isVhsNoise1Null = UnityEngine.Object.op_Equality(x:  this.vhsNoise1, y:  0);
        this._isVhsNoise2Null = UnityEngine.Object.op_Equality(x:  this.vhsNoise2, y:  0);
        this._isNoiseAnalogNull = UnityEngine.Object.op_Equality(x:  this.noiseAnalog, y:  0);
        UnityEngine.GameObject val_14 = this.frostDisruption;
        this._isBrokenCameraNull = UnityEngine.Object.op_Equality(x:  this.brokenCamera, y:  0);
        bool val_9 = UnityEngine.Object.op_Equality(x:  val_14, y:  0);
        val_14 = val_9;
        this._isFrostDisruptionNull = val_14;
        if(val_9 != false)
        {
                val_14 = this.frostMaterial;
        }
        else
        {
                val_14 = this.frostDisruption.GetComponent<UnityEngine.MeshRenderer>().sharedMaterial;
            this.frostMaterial = val_14;
        }
        
        this._isFrostMaterialNull = UnityEngine.Object.op_Equality(x:  val_14, y:  0);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Update()
    {
        if(this._isVhsNoise2Null == true)
        {
                return;
        }
        
        if(this._isVhsNoise1Null == true)
        {
                return;
        }
        
        if(this._isNoiseAnalogNull == true)
        {
                return;
        }
        
        if(this._isBrokenCameraNull == true)
        {
                return;
        }
        
        if(this._isFrostDisruptionNull == true)
        {
                return;
        }
        
        if(this._isFrostMaterialNull == true)
        {
                return;
        }
        
        if(this._strength > 0f)
        {
                this.enableFx();
            return;
        }
        
        this.disableFrostFx();
        this.disableImageFx();
        this._isFxEnabled = false;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void SetStrength(float strength)
    {
        this._strength = UnityEngine.Mathf.Clamp(value:  strength, min:  0f, max:  1f);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void enableFx()
    {
        if(this.useFrostDisruption != false)
        {
                this.enableFrostFx();
        }
        else
        {
                this.enableImageFx();
        }
        
        this._isFxEnabled = true;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void disableFx()
    {
        this.disableFrostFx();
        this.disableImageFx();
        this._isFxEnabled = false;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void enableFrostFx()
    {
        this.frostMaterial.SetFloat(name:  "_Grow", value:  this._strength);
        if(this._isFxEnabled != false)
        {
                return;
        }
        
        this.frostDisruption.SetActive(value:  true);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void disableFrostFx()
    {
        this.frostDisruption.SetActive(value:  false);
        this.frostMaterial.SetFloat(name:  "_Grow", value:  0f);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void enableImageFx()
    {
        float val_1 = UnityEngine.Random.Range(min:  5f, max:  30f);
        val_1 = this._strength * val_1;
        this.noiseAnalog.BarsCount = (int)val_1;
        this.vhsNoise1.Strength = this._strength;
        float val_2 = 1.8f;
        val_2 = this._strength * val_2;
        this.vhsNoise2.Strength = val_2;
        float val_3 = 0.8f;
        val_3 = this._strength * val_3;
        this.noiseAnalog.Strength = val_3;
        float val_4 = 1.1f;
        val_4 = this._strength * val_4;
        this.brokenCamera.Strength = val_4;
        if(this._isFxEnabled != false)
        {
                return;
        }
        
        this.vhsNoise1.enabled = true;
        this.vhsNoise2.enabled = true;
        this.noiseAnalog.enabled = true;
        this.brokenCamera.enabled = true;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void disableImageFx()
    {
        this.vhsNoise1.enabled = false;
        this.vhsNoise2.enabled = false;
        this.noiseAnalog.enabled = false;
        this.brokenCamera.enabled = false;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public DisruptionFxController()
    {
    
    }

}
