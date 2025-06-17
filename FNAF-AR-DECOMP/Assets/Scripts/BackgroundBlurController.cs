using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class BackgroundBlurController : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Rendering.PostProcessing.PostProcessVolume postProcess;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.GameObject _planeBone;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Rendering.PostProcessing.DepthOfField _depthOfField;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Start()
    {
        if(this.postProcess == 0)
        {
                return;
        }
        
        bool val_4 = this.postProcess.profile.TryGetSettings<UnityEngine.Rendering.PostProcessing.DepthOfField>(outSetting: out  this._depthOfField);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void FixedUpdate()
    {
        this._planeBone = UnityEngine.GameObject.FindGameObjectWithTag(tag:  "PlaneBone");
        if(this.postProcess == 0)
        {
                return;
        }
        
        if(this._depthOfField == 0)
        {
                return;
        }
        
        if(this._planeBone == 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_6 = this._planeBone.transform.localPosition;
        this = this._depthOfField.focusDistance;
        mem2[0] = UnityEngine.Mathf.Clamp(value:  UnityEngine.Mathf.Lerp(a:  0.1f, b:  9f, t:  UnityEngine.Mathf.InverseLerp(a:  -0.9f, b:  0.9f, value:  val_6.z)), min:  0.1f, max:  10f);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public BackgroundBlurController()
    {
    
    }

}
