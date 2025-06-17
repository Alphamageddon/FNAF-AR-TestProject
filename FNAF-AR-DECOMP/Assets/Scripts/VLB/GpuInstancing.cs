using UnityEngine;

namespace VLB
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class GpuInstancing
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const bool isSupported = True;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool forceEnableDepthBlend { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool get_forceEnableDepthBlend()
        {
            VLB.Config val_1 = VLB.Config.Instance;
            return (bool)(val_1.renderingMode == 2) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetMaterialProperties(UnityEngine.Material material, bool enableInstancing)
        {
            bool val_1 = enableInstancing;
            material.enableInstancing = val_1;
            VLB.Utils.SetKeywordEnabled(mat:  material, name:  "VLB_GPU_INSTANCING", enabled:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool CanBeBatched(VLB.VolumetricLightBeam beamA, VLB.VolumetricLightBeam beamB, ref string reasons)
        {
            VLB.VolumetricLightBeam val_9;
            var val_10;
            val_9 = beamB;
            if(beamA == null)
            {
                    val_9 = 0;
            }
            
            val_10 = (VLB.GpuInstancing.CanBeBatched(beam:  beamA, reason: ref  string val_1 = reasons)) & (VLB.GpuInstancing.CanBeBatched(beam:  val_9, reason: ref  val_1));
            if(beamB == null)
            {
                    val_9 = 0;
            }
            
            if(beamA.colorMode != beamB.colorMode)
            {
                    val_9 = 1152921528917360320;
                VLB.GpuInstancing.AppendErrorMessage(message: ref  val_1, toAppend:  "Color Mode mismatch");
                val_10 = 0;
            }
            
            if(beamA.blendingMode != beamB.blendingMode)
            {
                    val_9 = 1152921528917360320;
                VLB.GpuInstancing.AppendErrorMessage(message: ref  val_1, toAppend:  "Blending Mode mismatch");
                val_10 = 0;
            }
            
            if(((beamA.noiseEnabled == true) ? 1 : 0) != ((beamB.noiseEnabled == true) ? 1 : 0))
            {
                    val_9 = 1152921528917360320;
                VLB.GpuInstancing.AppendErrorMessage(message: ref  val_1, toAppend:  "3D Noise enabled mismatch");
                val_10 = 0;
            }
            
            if(VLB.GpuInstancing.forceEnableDepthBlend == true)
            {
                    return (bool)val_10 & 1;
            }
            
            if(((beamA.depthBlendDistance > 0f) ? 1 : 0) == ((beamB.depthBlendDistance > 0f) ? 1 : 0))
            {
                    return (bool)val_10 & 1;
            }
            
            VLB.GpuInstancing.AppendErrorMessage(message: ref  val_1, toAppend:  "Opaque Geometry Blending mismatch");
            val_10 = 0;
            return (bool)val_10 & 1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool CanBeBatched(VLB.VolumetricLightBeam beam, ref string reason)
        {
            var val_8;
            if(beam.geomMeshType != 0)
            {
                    VLB.GpuInstancing.AppendErrorMessage(message: ref  string val_3 = reason, toAppend:  System.String.Format(format:  "{0} is not using shared mesh", arg0:  beam.name));
                val_8 = 0;
            }
            else
            {
                    val_8 = 1;
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  beam.GetComponent<VLB.DynamicOcclusion>())) == false)
            {
                    return (bool)val_8;
            }
            
            VLB.GpuInstancing.AppendErrorMessage(message: ref  val_3, toAppend:  System.String.Format(format:  "{0}: dynamically occluded and non occluded beams cannot be batched together", arg0:  beam.name));
            val_8 = 0;
            return (bool)val_8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void AppendErrorMessage(ref string message, string toAppend)
        {
            string val_4 = message;
            if((System.String.op_Inequality(a:  message, b:  "")) != false)
            {
                    val_4 = val_4 + "\n";
                message = val_4;
            }
            
            message = val_4 + "- "("- ") + toAppend;
        }
    
    }

}
