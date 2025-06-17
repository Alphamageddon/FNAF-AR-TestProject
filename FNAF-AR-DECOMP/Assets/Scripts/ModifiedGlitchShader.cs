using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class ModifiedGlitchShader : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float ShearStrength;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool InvertScreen;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool InvertGrayScreen;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Material _material;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private float TimeCount;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private float HorizontalResolution;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private float VerticalResolution;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void OnRenderImage(UnityEngine.RenderTexture source, UnityEngine.RenderTexture destination)
    {
        if(this._material == 0)
        {
                UnityEngine.Material val_3 = new UnityEngine.Material(shader:  UnityEngine.Shader.Find(name:  "Custom/Mobile Modified Glitch Shader"));
            this._material = val_3;
            val_3.hideFlags = 61;
        }
        
        this._material.SetFloat(name:  "_ResHorizontal", value:  this.HorizontalResolution);
        this._material.SetFloat(name:  "_ResVertical", value:  this.VerticalResolution);
        this._material.SetFloat(name:  "_Timer", value:  this.TimeCount);
        this._material.SetFloat(name:  "_ShearStrength", value:  this.ShearStrength);
        this._material.SetFloat(name:  "_InvertScreen", value:  (this.InvertScreen == true) ? 1f : 0f);
        this._material.SetFloat(name:  "_InvertGrayScreen", value:  (this.InvertGrayScreen == true) ? 1f : 0f);
        UnityEngine.Graphics.Blit(source:  source, dest:  destination, mat:  this._material);
        float val_6 = UnityEngine.Time.deltaTime;
        val_6 = val_6 * 0.5f;
        val_6 = this.TimeCount + val_6;
        this.TimeCount = (val_6 > 10f) ? 0f : (val_6);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void OnDisable()
    {
        if(this._material == 0)
        {
                return;
        }
        
        UnityEngine.Object.DestroyImmediate(obj:  this._material);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ModifiedGlitchShader()
    {
        this.HorizontalResolution = (float)UnityEngine.Screen.width;
        this.VerticalResolution = (float)UnityEngine.Screen.height;
    }

}
