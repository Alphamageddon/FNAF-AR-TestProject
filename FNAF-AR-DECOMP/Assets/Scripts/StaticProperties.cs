using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class MaterialManager.StaticProperties
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public VLB.MaterialManager.BlendingMode blendingMode;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public VLB.MaterialManager.Noise3D noise3D;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public VLB.MaterialManager.DepthBlend depthBlend;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public VLB.MaterialManager.ColorGradient colorGradient;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public VLB.MaterialManager.ClippingPlane clippingPlane;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int materialID { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int get_materialID()
    {
        MaterialManager.BlendingMode val_2 = this.blendingMode;
        val_2 = this.noise3D + (val_2 << 1);
        val_2 = this.depthBlend + (val_2 << 1);
        val_2 = val_2 + (val_2 << 1);
        val_2 = val_2 + this.colorGradient;
        return (int)this.clippingPlane + (val_2 << 1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void ApplyToMaterial(UnityEngine.Material mat)
    {
        null = null;
        System.Boolean[] val_1 = VLB.MaterialManager.BlendingMode_AlphaAsBlack + this.blendingMode;
        VLB.Utils.SetKeywordEnabled(mat:  mat, name:  "VLB_ALPHA_AS_BLACK", enabled:  (((VLB.MaterialManager.BlendingMode_AlphaAsBlack + this.blendingMode) + 32) != 0) ? 1 : 0);
        UnityEngine.Rendering.BlendMode[] val_3 = VLB.MaterialManager.BlendingMode_SrcFactor + ((this.blendingMode) << 2);
        mat.SetInt(name:  "_BlendSrcFactor", value:  (VLB.MaterialManager.BlendingMode_SrcFactor + (this.blendingMode) << 2) + 32);
        UnityEngine.Rendering.BlendMode[] val_4 = VLB.MaterialManager.BlendingMode_DstFactor + ((this.blendingMode) << 2);
        mat.SetInt(name:  "_BlendDstFactor", value:  (VLB.MaterialManager.BlendingMode_DstFactor + (this.blendingMode) << 2) + 32);
        VLB.Utils.SetKeywordEnabled(mat:  mat, name:  "VLB_COLOR_GRADIENT_MATRIX_LOW", enabled:  (this.colorGradient == 1) ? 1 : 0);
        VLB.Utils.SetKeywordEnabled(mat:  mat, name:  "VLB_COLOR_GRADIENT_MATRIX_HIGH", enabled:  (this.colorGradient == 2) ? 1 : 0);
        VLB.Utils.SetKeywordEnabled(mat:  mat, name:  "VLB_DEPTH_BLEND", enabled:  (this.depthBlend == 1) ? 1 : 0);
        VLB.Utils.SetKeywordEnabled(mat:  mat, name:  "VLB_NOISE_3D", enabled:  (this.noise3D == 1) ? 1 : 0);
        VLB.Utils.SetKeywordEnabled(mat:  mat, name:  "VLB_CLIPPING_PLANE", enabled:  (this.clippingPlane == 1) ? 1 : 0);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public MaterialManager.StaticProperties()
    {
    
    }

}
