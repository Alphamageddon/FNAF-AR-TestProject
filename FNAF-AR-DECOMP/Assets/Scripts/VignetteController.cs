using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class VignetteController : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Rendering.PostProcessing.PostProcessVolume postProcess;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Rendering.PostProcessing.Vignette _vignette;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Start()
    {
        if(this.postProcess == 0)
        {
                return;
        }
        
        bool val_4 = this.postProcess.profile.TryGetSettings<UnityEngine.Rendering.PostProcessing.Vignette>(outSetting: out  this._vignette);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void setStrength(float value)
    {
        if((UnityEngine.Object.op_Implicit(exists:  this._vignette)) == false)
        {
                return;
        }
        
        this = this._vignette.intensity;
        mem2[0] = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public VignetteController()
    {
    
    }

}
