using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class FlashlightFxController : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.GameObject flashlight;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.GameObject ambientLight;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public VignetteController vignetteController;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float onValue;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float offValue;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool editorMode;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool _isFlashlightOn;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool _isFlashlightNull;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool _isAmbientLightNull;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Start()
    {
        UnityEngine.GameObject val_4 = this.ambientLight;
        this._isFlashlightNull = UnityEngine.Object.op_Equality(x:  this.flashlight, y:  0);
        val_4 = UnityEngine.Object.op_Equality(x:  val_4, y:  0);
        this._isAmbientLightNull = val_4;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Update()
    {
        if(this._isFlashlightNull == true)
        {
                return;
        }
        
        if(this._isAmbientLightNull != false)
        {
                return;
        }
        
        if(this.editorMode == false)
        {
                return;
        }
        
        this.setFlashlightStatus();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void ToggleFlashlight(bool status)
    {
        this._isFlashlightOn = status;
        if(this._isFlashlightNull == true)
        {
                return;
        }
        
        if(this._isAmbientLightNull != false)
        {
                return;
        }
        
        this.setFlashlightStatus();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void setFlashlightStatus()
    {
        this.flashlight.SetActive(value:  (this._isFlashlightOn == true) ? 1 : 0);
        this.ambientLight.SetActive(value:  (this._isFlashlightOn == false) ? 1 : 0);
        if(this._isFlashlightOn == false)
        {
            goto label_2;
        }
        
        if(this.vignetteController != null)
        {
            goto label_4;
        }
        
        label_5:
        label_4:
        this.vignetteController.setStrength(value:  this.onValue);
        return;
        label_2:
        if(this.vignetteController != null)
        {
            goto label_4;
        }
        
        goto label_5;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public FlashlightFxController()
    {
        this.onValue = 0.335f;
        this.offValue = 7.346868E-41f;
    }

}
