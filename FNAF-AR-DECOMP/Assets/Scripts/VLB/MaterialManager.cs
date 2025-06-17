using UnityEngine;

namespace VLB
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class MaterialManager
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static UnityEngine.MaterialPropertyBlock materialPropertyBlock;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly UnityEngine.Rendering.BlendMode[] BlendingMode_SrcFactor;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly UnityEngine.Rendering.BlendMode[] BlendingMode_DstFactor;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly bool[] BlendingMode_AlphaAsBlack;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static int kStaticPropertiesCount;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static System.Collections.Hashtable ms_MaterialsGroup;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static UnityEngine.Material NewMaterial(bool gpuInstanced)
        {
            UnityEngine.Object val_8;
            UnityEngine.Material val_9;
            VLB.Config val_1 = VLB.Config.Instance;
            val_8 = mem[val_1.renderingMode == null ? val_1.beamShader2Pass : val_1.beamShader1Pass];
            val_8 = (val_1.renderingMode == 0) ? val_1.beamShader2Pass : val_1.beamShader1Pass;
            if((UnityEngine.Object.op_Implicit(exists:  val_8)) != false)
            {
                    UnityEngine.Material val_4 = null;
                val_9 = val_4;
                val_4 = new UnityEngine.Material(shader:  val_8);
                val_4.hideFlags = VLB.Consts.ProceduralObjectsHideFlags;
                VLB.Config val_6 = VLB.Config.Instance;
                val_8 = val_6.geometryRenderQueue;
                val_4.renderQueue = val_8;
                VLB.GpuInstancing.SetMaterialProperties(material:  val_4, enableInstancing:  gpuInstanced);
                return (UnityEngine.Material)val_9;
            }
            
            UnityEngine.Debug.LogError(message:  "Invalid Beam Shader set in VLB Config");
            val_9 = 0;
            return (UnityEngine.Material)val_9;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static UnityEngine.Material GetInstancedMaterial(uint groupID, VLB.MaterialManager.StaticProperties staticProps)
        {
            uint val_2;
            var val_8;
            var val_9;
            var val_10;
            var val_12;
            var val_13;
            UnityEngine.Material val_15;
            val_8 = null;
            val_8 = null;
            val_9 = VLB.MaterialManager.ms_MaterialsGroup;
            val_10 = null;
            if(val_9 != null)
            {
                    val_12 = null;
            }
            
            MaterialManager.MaterialsGroup val_3 = null;
            val_9 = val_3;
            val_3 = new MaterialManager.MaterialsGroup();
            val_13 = null;
            val_13 = null;
            val_2 = groupID;
            MaterialManager.BlendingMode val_8 = staticProps.blendingMode;
            val_8 = staticProps.noise3D + (val_8 << 1);
            val_8 = staticProps.depthBlend + (val_8 << 1);
            val_8 = val_8 + (val_8 << 1);
            MaterialManager.DepthBlend val_4 = val_8 + staticProps.colorGradient;
            val_4 = staticProps.clippingPlane + (val_4 << 1);
            val_15 = (MaterialManager.MaterialsGroup)[1152921528918320256].materials[(long)val_4];
            if(val_15 != 0)
            {
                    return (UnityEngine.Material)val_15;
            }
            
            val_15 = VLB.MaterialManager.NewMaterial(gpuInstanced:  true);
            if((UnityEngine.Object.op_Implicit(exists:  val_15)) == false)
            {
                    return (UnityEngine.Material)val_15;
            }
            
            (MaterialManager.MaterialsGroup)[1152921528918320256].materials[(long)val_4] = val_15;
            staticProps.ApplyToMaterial(mat:  val_15);
            return (UnityEngine.Material)val_15;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static MaterialManager()
        {
            int val_6;
            VLB.MaterialManager.materialPropertyBlock = new UnityEngine.MaterialPropertyBlock();
            VLB.MaterialManager.BlendingMode_SrcFactor = new UnityEngine.Rendering.BlendMode[3];
            VLB.MaterialManager.BlendingMode_DstFactor = new UnityEngine.Rendering.BlendMode[3];
            bool[] val_4 = new bool[3];
            val_6 = val_4.Length;
            if(val_6 == 0)
            {
                    val_6 = val_4.Length;
            }
            
            val_4[0] = true;
            val_4[1] = true;
            VLB.MaterialManager.BlendingMode_AlphaAsBlack = val_4;
            VLB.MaterialManager.kStaticPropertiesCount = 72;
            VLB.MaterialManager.ms_MaterialsGroup = new System.Collections.Hashtable(capacity:  1);
        }
    
    }

}
