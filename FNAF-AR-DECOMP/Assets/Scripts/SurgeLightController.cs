using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class SurgeLightController : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.GameObject surgeLight;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private float surgeLightStrength;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Light _light;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool _lightIsNotNull;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Start()
    {
        UnityEngine.Light val_1 = this.surgeLight.GetComponent<UnityEngine.Light>();
        this._light = val_1;
        this._lightIsNotNull = UnityEngine.Object.op_Inequality(x:  val_1, y:  0);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Update()
    {
        if(this._lightIsNotNull == false)
        {
                return;
        }
        
        if(this.surgeLightStrength > 0f)
        {
                this.surgeLight.SetActive(value:  true);
            this._light.intensity = this.surgeLightStrength;
            return;
        }
        
        if(this.surgeLightStrength > 0f)
        {
                return;
        }
        
        this.surgeLight.SetActive(value:  false);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void SetSurgeLightStrength(float value)
    {
        this.surgeLightStrength = UnityEngine.Mathf.Clamp(value:  value, min:  0f, max:  1f);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public SurgeLightController()
    {
    
    }

}
