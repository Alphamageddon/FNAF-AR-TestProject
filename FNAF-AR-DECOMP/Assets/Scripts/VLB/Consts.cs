using UnityEngine;

namespace VLB
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class Consts
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string HelpUrlBase = "http://saladgamer.com/vlb-doc/";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string HelpUrlBeam = "http://saladgamer.com/vlb-doc/comp-lightbeam/";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string HelpUrlDustParticles = "http://saladgamer.com/vlb-doc/comp-dustparticles/";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string HelpUrlDynamicOcclusion = "http://saladgamer.com/vlb-doc/comp-dynocclusion/";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string HelpUrlTriggerZone = "http://saladgamer.com/vlb-doc/comp-triggerzone/";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string HelpUrlConfig = "http://saladgamer.com/vlb-doc/config/";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static readonly bool ProceduralObjectsVisibleInEditor;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static readonly UnityEngine.Color FlatColor;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const VLB.ColorMode ColorModeDefault = 0;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const float IntensityDefault = 1;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const float IntensityMin = 0;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const float IntensityMax = 8;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const float SpotAngleDefault = 35;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const float SpotAngleMin = 0.1;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const float SpotAngleMax = 179.9;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const float ConeRadiusStart = 0.1;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const VLB.MeshType GeomMeshType = 0;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const int GeomSidesDefault = 18;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const int GeomSidesMin = 3;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const int GeomSidesMax = 256;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const int GeomSegmentsDefault = 5;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const int GeomSegmentsMin = 0;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const int GeomSegmentsMax = 64;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const bool GeomCap = False;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const VLB.AttenuationEquation AttenuationEquationDefault = 1;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const float AttenuationCustomBlending = 0.5;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const float FallOffStart = 0;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const float FallOffEnd = 3;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const float FallOffDistancesMinThreshold = 0.01;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const float DepthBlendDistance = 2;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const float CameraClippingDistance = 0.5;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const float FresnelPowMaxValue = 10;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const float FresnelPow = 8;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const float GlareFrontal = 0.5;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const float GlareBehind = 0.5;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const float NoiseIntensityMin = 0;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const float NoiseIntensityMax = 1;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const float NoiseIntensityDefault = 0.5;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const float NoiseScaleMin = 0.01;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const float NoiseScaleMax = 2;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const float NoiseScaleDefault = 0.5;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static readonly UnityEngine.Vector3 NoiseVelocityDefault;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const VLB.BlendingMode BlendingModeDefault = 0;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const VLB.OccluderDimensions DynOcclusionDimensionsDefault = 0;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static readonly UnityEngine.LayerMask DynOcclusionLayerMaskDefault;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const bool DynOcclusionConsiderTriggersDefault = False;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const float DynOcclusionMinOccluderAreaDefault = 0;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const int DynOcclusionWaitFrameCountDefault = 3;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const float DynOcclusionMinSurfaceRatioDefault = 0.5;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const float DynOcclusionMinSurfaceRatioMin = 50;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const float DynOcclusionMinSurfaceRatioMax = 100;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const float DynOcclusionMaxSurfaceDotDefault = 0.25;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const float DynOcclusionMaxSurfaceAngleMin = 45;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const float DynOcclusionMaxSurfaceAngleMax = 90;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const VLB.PlaneAlignment DynOcclusionPlaneAlignmentDefault = 0;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const float DynOcclusionPlaneOffsetDefault = 0.1;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const bool ConfigGeometryOverrideLayerDefault = True;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const int ConfigGeometryLayerIDDefault = 1;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string ConfigGeometryTagDefault = "Untagged";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string ConfigFadeOutCameraTagDefault = "MainCamera";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const VLB.RenderQueue ConfigGeometryRenderQueueDefault = 3000;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const VLB.RenderPipeline ConfigGeometryRenderPipelineDefault = 0;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const VLB.RenderingMode ConfigGeometryRenderingModeDefault = 0;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const int ConfigNoise3DSizeDefault = 64;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const int ConfigSharedMeshSides = 24;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const int ConfigSharedMeshSegments = 5;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static UnityEngine.HideFlags ProceduralObjectsHideFlags { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static UnityEngine.HideFlags get_ProceduralObjectsHideFlags()
        {
            null = null;
            return (UnityEngine.HideFlags)(VLB.Consts.ConfigSharedMeshSegments == 0) ? (60 + 1) : 60;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static Consts()
        {
            VLB.Consts.ConfigSharedMeshSegments = 1;
            UnityEngine.Color val_1 = UnityEngine.Color.white;
            VLB.Consts.FlatColor = val_1.r;
            VLB.Consts.ConfigSharedMeshSegments.__il2cppRuntimeField_8 = val_1.g;
            VLB.Consts.ConfigSharedMeshSegments.__il2cppRuntimeField_C = val_1.b;
            VLB.Consts.ConfigSharedMeshSegments.__il2cppRuntimeField_10 = val_1.a;
            VLB.Consts.NoiseVelocityDefault = 0;
            VLB.Consts.ConfigSharedMeshSegments.__il2cppRuntimeField_1C = 0;
            UnityEngine.LayerMask val_2 = UnityEngine.LayerMask.op_Implicit(intVal:  0);
            VLB.Consts.DynOcclusionLayerMaskDefault = val_2.m_Mask;
        }
    
    }

}
