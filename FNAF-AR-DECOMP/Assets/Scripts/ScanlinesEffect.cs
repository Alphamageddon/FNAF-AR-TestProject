using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class ScanlinesEffect : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Shader shader;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Material _material;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float lineWidth;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float hardness;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float displacementSpeed;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected UnityEngine.Material material { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected UnityEngine.Material get_material()
    {
        if(this._material != 0)
        {
                return (UnityEngine.Material)this._material;
        }
        
        UnityEngine.Material val_2 = new UnityEngine.Material(shader:  this.shader);
        this._material = val_2;
        val_2.hideFlags = 61;
        return (UnityEngine.Material)this._material;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void OnRenderImage(UnityEngine.RenderTexture source, UnityEngine.RenderTexture destination)
    {
        if(this.shader == 0)
        {
                return;
        }
        
        this.material.SetFloat(name:  "_LineWidth", value:  this.lineWidth);
        this.material.SetFloat(name:  "_Hardness", value:  this.hardness);
        this.material.SetFloat(name:  "_Speed", value:  this.displacementSpeed);
        UnityEngine.Graphics.Blit(source:  source, dest:  destination, mat:  this.material, pass:  0);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void OnDisable()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this._material)) == false)
        {
                return;
        }
        
        UnityEngine.Object.DestroyImmediate(obj:  this._material);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ScanlinesEffect()
    {
        this.lineWidth = 2f;
        this.hardness = 3.673364E-41f;
        this.displacementSpeed = 0.1f;
    }

}
