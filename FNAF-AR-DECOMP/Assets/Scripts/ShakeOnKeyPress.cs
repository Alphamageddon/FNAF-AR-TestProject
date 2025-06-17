using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class ShakeOnKeyPress : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float Magnitude;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float Roughness;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float FadeOutTime;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool DoShake;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Update()
    {
        if(this.DoShake != true)
        {
                if((UnityEngine.Input.GetKeyDown(key:  48)) == false)
        {
                return;
        }
        
        }
        
        this.Shake();
        this.DoShake = false;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Shake()
    {
        null = null;
        EZCameraShake.CameraShakeInstance val_1 = EZCameraShake.CameraShaker.Instance.ShakeOnce(magnitude:  this.Magnitude, roughness:  this.Roughness, fadeInTime:  0f, fadeOutTime:  this.FadeOutTime);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ShakeOnKeyPress()
    {
        this.Magnitude = 2f;
        this.Roughness = 10f;
        this.FadeOutTime = 5f;
    }

}
