using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class EyeGlowLightController : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Collections.Generic.List<UnityEngine.Transform> eyeGlows;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Collections.Generic.List<UnityEngine.Transform> eyelidBones;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Collections.Generic.List<VLB.VolumetricLightBeam> eyeGlowLights;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float eyelidOpenValue;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float eyelidClosedValue;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.GameObject revealPlane;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float intensityMultiplier;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Light eyeGlowPointLight;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.GameObject eyeGlowGrp;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Color normalEyeGlowColor;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private float _currentEyelidRotation;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Color _currentColor;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Start()
    {
        this._currentColor = this.normalEyeGlowColor;
        mem[1152921518850133440] = ???;
        mem[1152921518850133448] = ???;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Update()
    {
        var val_22;
        float val_23;
        val_22 = 0;
        val_23 = 0f;
        goto label_1;
        label_24:
        UnityEngine.Quaternion val_2 = this.eyelidBones.Item[0].localRotation;
        this._currentEyelidRotation = val_2.x;
        UnityEngine.Vector3 val_8 = this.eyeGlows.Item[0].localScale;
        UnityEngine.Vector3 val_10 = this.eyeGlows.Item[0].localScale;
        this.eyeGlows.Item[0].localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        UnityEngine.Vector3 val_12 = this.revealPlane.transform.localScale;
        float val_22 = this.intensityMultiplier;
        UnityEngine.Vector3 val_14 = this.revealPlane.transform.localScale;
        float val_15 = UnityEngine.Mathf.Clamp(value:  val_14.y, min:  0f, max:  50f);
        val_22 = val_12.x * val_22;
        VLB.VolumetricLightBeam val_16 = this.eyeGlowLights.Item[0];
        float val_17 = UnityEngine.Time.deltaTime;
        val_17 = val_15 * val_17;
        val_17 = val_17 + 1f;
        val_17 = val_22 * val_17;
        val_17 = (UnityEngine.Mathf.Clamp(value:  UnityEngine.Mathf.Lerp(a:  1f, b:  0f, t:  UnityEngine.Mathf.InverseLerp(a:  this.eyelidOpenValue, b:  this.eyelidClosedValue, value:  val_2.x)), min:  0f, max:  1f)) * val_17;
        val_16.intensityInside = val_17;
        VLB.VolumetricLightBeam val_18 = this.eyeGlowLights.Item[0];
        VLB.VolumetricLightBeam val_19 = this.eyeGlowLights.Item[0];
        val_19.color = this._currentColor;
        mem2[0] = ???;
        mem2[0] = ???;
        mem2[0] = ???;
        val_23 = val_23 + val_18.intensityInside;
        this.eyeGlowPointLight.color = new UnityEngine.Color() {r = this._currentColor, g = val_17, b = val_15, a = val_22};
        val_22 = 1;
        label_1:
        if(val_22 < this.eyeGlows.Count)
        {
            goto label_24;
        }
        
        this.eyeGlowPointLight.intensity = UnityEngine.Mathf.Clamp(value:  val_23, min:  0f, max:  3f);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void StartEyeColorOverride(UnityEngine.Color color)
    {
        this._currentColor = color;
        mem[1152921518850532544] = color.g;
        mem[1152921518850532548] = color.b;
        mem[1152921518850532552] = color.a;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void EndEyeColorOverride()
    {
        this._currentColor = this.normalEyeGlowColor;
        mem[1152921518850644544] = ???;
        mem[1152921518850644552] = ???;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void SetEyeGlow(bool eyeGlowEnabled)
    {
        eyeGlowEnabled = eyeGlowEnabled;
        this.eyeGlowGrp.SetActive(value:  eyeGlowEnabled);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public EyeGlowLightController()
    {
        this.intensityMultiplier = 5f;
    }

}
