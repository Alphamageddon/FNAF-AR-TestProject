using UnityEngine;

namespace VLB
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Config : ScriptableObject
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool geometryOverrideLayer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int geometryLayerID;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string geometryTag;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int geometryRenderQueue;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public VLB.RenderPipeline renderPipeline;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool forceSinglePass;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public VLB.RenderingMode renderingMode;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Shader beamShader1Pass;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Shader beamShader2Pass;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int sharedMeshSides;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int sharedMeshSegments;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float globalNoiseScale;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector3 globalNoiseVelocity;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string fadeOutCameraTag;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.TextAsset noise3DData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int noise3DSize;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.ParticleSystem dustParticlesPrefab;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int pluginVersion;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Transform m_CachedFadeOutCamera;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string kAssetName = "Config";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static VLB.Config m_Instance;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public VLB.RenderingMode actualRenderingMode { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool useSinglePassShader { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Shader beamShader { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector4 globalNoiseParam { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform fadeOutCameraTransform { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static VLB.Config Instance { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public VLB.RenderingMode get_actualRenderingMode()
        {
            return (VLB.RenderingMode)this.renderingMode;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_useSinglePassShader()
        {
            return (bool)(this.renderingMode != 0) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Shader get_beamShader()
        {
            return (UnityEngine.Shader)(this.renderingMode == 0) ? this.beamShader2Pass : this.beamShader1Pass;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector4 get_globalNoiseParam()
        {
            return new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform get_fadeOutCameraTransform()
        {
            if(this.m_CachedFadeOutCamera != 0)
            {
                    return (UnityEngine.Transform)this.m_CachedFadeOutCamera;
            }
            
            this.ForceUpdateFadeOutCamera();
            return (UnityEngine.Transform)this.m_CachedFadeOutCamera;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ForceUpdateFadeOutCamera()
        {
            UnityEngine.GameObject val_1 = UnityEngine.GameObject.FindGameObjectWithTag(tag:  this.fadeOutCameraTag);
            if((UnityEngine.Object.op_Implicit(exists:  val_1)) == false)
            {
                    return;
            }
            
            this.m_CachedFadeOutCamera = val_1.transform;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void OnStartup()
        {
            VLB.Config val_1 = VLB.Config.Instance;
            val_1.m_CachedFadeOutCamera = 0;
            VLB.Config val_2 = VLB.Config.Instance;
            VLB.Config.OnRenderPipelineChanged(pipeline:  val_2.renderPipeline);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void OnRenderPipelineChanged(VLB.RenderPipeline pipeline)
        {
            if(pipeline == 1)
            {
                    UnityEngine.Shader.EnableKeyword(keyword:  "VLB_SRP_API");
                return;
            }
            
            UnityEngine.Shader.DisableKeyword(keyword:  "VLB_SRP_API");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Reset()
        {
            var val_8;
            var val_9;
            UnityEngine.ParticleSystem val_10;
            this.geometryOverrideLayer = true;
            this.geometryLayerID = true;
            this.geometryRenderQueue = 3000;
            this.geometryTag = "Untagged";
            this.beamShader1Pass = UnityEngine.Shader.Find(name:  "Hidden/VolumetricLightBeam1Pass");
            this.beamShader2Pass = UnityEngine.Shader.Find(name:  "Hidden/VolumetricLightBeam2Pass");
            this.sharedMeshSides = 24;
            this.sharedMeshSegments = 5;
            this.globalNoiseScale = 0.5f;
            val_8 = null;
            val_8 = null;
            this.globalNoiseVelocity = VLB.Consts.NoiseVelocityDefault;
            mem[1152921528912420204] = VLB.Consts.ConfigSharedMeshSegments.__il2cppRuntimeField_1C;
            UnityEngine.Object val_3 = UnityEngine.Resources.Load(path:  "Noise3D_64x64x64");
            val_9 = 0;
            this.noise3DData = ;
            this.noise3DSize = 64;
            UnityEngine.Object val_6 = UnityEngine.Resources.Load(path:  "DustParticles", systemTypeInstance:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            if(val_6 != null)
            {
                    var val_7 = (null == null) ? (val_6) : 0;
            }
            else
            {
                    val_10 = 0;
            }
            
            this.dustParticlesPrefab = val_10;
            this.renderPipeline = 0;
            this.renderingMode = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.ParticleSystem NewVolumetricDustParticles()
        {
            var val_7;
            if((UnityEngine.Object.op_Implicit(exists:  this.dustParticlesPrefab)) == false)
            {
                goto label_3;
            }
            
            val_7 = UnityEngine.Object.Instantiate<UnityEngine.ParticleSystem>(original:  this.dustParticlesPrefab);
            if(val_7 == null)
            {
                goto label_6;
            }
            
            val_7.useAutoRandomSeed = false;
            val_7.name = "Dust Particles";
            goto label_7;
            label_3:
            val_7 = 0;
            if(UnityEngine.Application.isPlaying == false)
            {
                    return (UnityEngine.ParticleSystem)val_7;
            }
            
            UnityEngine.Debug.LogError(message:  "Failed to instantiate VolumetricDustParticles prefab.");
            val_7 = 0;
            return (UnityEngine.ParticleSystem)val_7;
            label_6:
            val_7.useAutoRandomSeed = false;
            0.name = "Dust Particles";
            label_7:
            val_7.gameObject.hideFlags = VLB.Consts.ProceduralObjectsHideFlags;
            val_7.gameObject.SetActive(value:  true);
            return (UnityEngine.ParticleSystem)val_7;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnEnable()
        {
            this.HandleBackwardCompatibility(serializedVersion:  this.pluginVersion, newVersion:  164);
            this.pluginVersion = 1700;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
        {
            if(serializedVersion == newVersion)
            {
                    return;
            }
            
            if(serializedVersion > 1599)
            {
                    return;
            }
            
            this.renderingMode = this.forceSinglePass;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static VLB.Config get_Instance()
        {
            var val_5;
            VLB.Config val_6;
            var val_7;
            var val_8;
            val_5 = null;
            val_5 = null;
            val_6 = VLB.Config.m_Instance;
            if(val_6 == 0)
            {
                    val_6 = UnityEngine.Resources.Load<VLB.ConfigOverride>(path:  "VLBConfigOverride");
                if((UnityEngine.Object.op_Implicit(exists:  val_6)) != false)
            {
                    val_7 = null;
            }
            else
            {
                    val_6 = UnityEngine.Resources.Load<VLB.Config>(path:  "Config");
                val_7 = null;
            }
            
                VLB.Config.m_Instance = val_6;
            }
            
            val_8 = null;
            val_8 = null;
            return (VLB.Config)VLB.Config.m_Instance;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Config()
        {
            var val_1;
            this.geometryOverrideLayer = true;
            this.geometryLayerID = true;
            this.geometryRenderQueue = 3000;
            this.sharedMeshSides = 24;
            this.sharedMeshSegments = 5;
            this.globalNoiseScale = 0.5f;
            this.geometryTag = "Untagged";
            val_1 = null;
            val_1 = null;
            this.globalNoiseVelocity = VLB.Consts.NoiseVelocityDefault;
            mem[1152921528913068828] = VLB.Consts.ConfigSharedMeshSegments.__il2cppRuntimeField_1C;
            this.noise3DSize = 64;
            this.fadeOutCameraTag = "MainCamera";
            this.pluginVersion = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static Config()
        {
        
        }
    
    }

}
