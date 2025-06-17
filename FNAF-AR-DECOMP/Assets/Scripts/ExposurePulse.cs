using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class ExposurePulse : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Rendering.PostProcessing.PostProcessVolume volume;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float VignetteSpeed;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float ExposureSpeed;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Rendering.PostProcessing.Vignette vignetteSettings;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Rendering.PostProcessing.ColorGrading colorGradingSettings;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private float random;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float minIntensity;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float maxIntensity;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Start()
    {
        object val_9;
        if(this.volume.profile != 0)
        {
            goto label_4;
        }
        
        this.enabled = false;
        val_9 = "Cant load PostProcess volume";
        goto label_16;
        label_4:
        if((this.volume.profile.TryGetSettings<UnityEngine.Rendering.PostProcessing.ColorGrading>(outSetting: out  this.colorGradingSettings)) == false)
        {
            goto label_10;
        }
        
        if((this.volume.profile.TryGetSettings<UnityEngine.Rendering.PostProcessing.Vignette>(outSetting: out  this.vignetteSettings)) == false)
        {
            goto label_13;
        }
        
        return;
        label_10:
        this.enabled = false;
        val_9 = "Cant load ColorGrading settings";
        goto label_16;
        label_13:
        this.enabled = false;
        val_9 = "Cant load Vignette settings";
        label_16:
        UnityEngine.Debug.Log(message:  val_9);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Update()
    {
        float val_1 = UnityEngine.Time.time;
        val_1 = val_1 * this.ExposureSpeed;
        mem2[0] = UnityEngine.Mathf.Lerp(a:  this.minIntensity, b:  this.maxIntensity, t:  UnityEngine.Mathf.PingPong(t:  val_1, length:  1f));
        float val_4 = UnityEngine.Time.time;
        val_4 = val_4 * this.VignetteSpeed;
        mem2[0] = UnityEngine.Mathf.Lerp(a:  0.1f, b:  0.6f, t:  UnityEngine.Mathf.PingPong(t:  val_4, length:  1f));
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ExposurePulse()
    {
        this.VignetteSpeed = Infinityf;
        this.ExposureSpeed = 0.5f;
        this.minIntensity = -1f;
        this.maxIntensity = 0.25f;
    }

}
