using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class LightningBoltScript : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Camera Camera;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DigitalRuby.ThunderAndLightning.CameraMode CameraMode;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal DigitalRuby.ThunderAndLightning.CameraMode calculatedCameraMode;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool UseWorldSpace;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool CompensateForParentTransform;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DigitalRuby.ThunderAndLightning.LightningBoltQualitySetting QualitySetting;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool MultiThreaded;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float LevelOfDetailDistance;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string SortLayerName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int SortOrderInLayer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float SoftParticlesFactor;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int RenderQueue;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Material LightningMaterialMesh;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Material LightningMaterialMeshNoGlow;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Texture2D LightningTexture;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Texture2D LightningGlowTexture;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.ParticleSystem LightningOriginParticleSystem;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.ParticleSystem LightningDestinationParticleSystem;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Color LightningTintColor;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Color GlowTintColor;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Rendering.BlendMode SourceBlendMode;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Rendering.BlendMode DestinationBlendMode;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float JitterMultiplier;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Turbulence;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector3 TurbulenceVelocity;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector4 IntensityFlicker;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly UnityEngine.Vector4 intensityFlickerDefault;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Texture2D IntensityFlickerTexture;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<DigitalRuby.ThunderAndLightning.LightningBoltParameters, UnityEngine.Vector3, UnityEngine.Vector3> <LightningStartedCallback>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<DigitalRuby.ThunderAndLightning.LightningBoltParameters, UnityEngine.Vector3, UnityEngine.Vector3> <LightningEndedCallback>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<UnityEngine.Light> <LightAddedCallback>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<UnityEngine.Light> <LightRemovedCallback>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static UnityEngine.Vector4 <TimeVectorSinceStart>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static float <TimeSinceStart>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static float <DeltaTime>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static float TimeScale;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static bool needsTimeUpdate;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Material <lightningMaterialMeshInternal>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Material <lightningMaterialMeshNoGlowInternal>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Texture2D lastLightningTexture;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Texture2D lastLightningGlowTexture;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Collections.Generic.List<DigitalRuby.ThunderAndLightning.LightningBolt> activeBolts;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly DigitalRuby.ThunderAndLightning.LightningBoltParameters[] oneParameterArray;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Collections.Generic.List<DigitalRuby.ThunderAndLightning.LightningBolt> lightningBoltCache;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Collections.Generic.List<DigitalRuby.ThunderAndLightning.LightningBoltDependencies> dependenciesCache;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private DigitalRuby.ThunderAndLightning.LightningThreadState threadState;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static int shaderId_MainTex;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static int shaderId_GlowTex;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static int shaderId_TintColor;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static int shaderId_GlowTintColor;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static int shaderId_JitterMultiplier;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static int shaderId_Turbulence;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static int shaderId_TurbulenceVelocity;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static int shaderId_SrcBlendMode;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static int shaderId_DstBlendMode;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static int shaderId_InvFade;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static int shaderId_LightningTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static int shaderId_IntensityFlicker;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static int shaderId_IntensityFlickerTexture;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Action<DigitalRuby.ThunderAndLightning.LightningBoltParameters, UnityEngine.Vector3, UnityEngine.Vector3> LightningStartedCallback { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Action<DigitalRuby.ThunderAndLightning.LightningBoltParameters, UnityEngine.Vector3, UnityEngine.Vector3> LightningEndedCallback { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Action<UnityEngine.Light> LightAddedCallback { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Action<UnityEngine.Light> LightRemovedCallback { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool HasActiveBolts { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static UnityEngine.Vector4 TimeVectorSinceStart { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static float TimeSinceStart { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static float DeltaTime { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal UnityEngine.Material lightningMaterialMeshInternal { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal UnityEngine.Material lightningMaterialMeshNoGlowInternal { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Action<DigitalRuby.ThunderAndLightning.LightningBoltParameters, UnityEngine.Vector3, UnityEngine.Vector3> get_LightningStartedCallback()
        {
            return (System.Action<DigitalRuby.ThunderAndLightning.LightningBoltParameters, UnityEngine.Vector3, UnityEngine.Vector3>)this.<LightningStartedCallback>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_LightningStartedCallback(System.Action<DigitalRuby.ThunderAndLightning.LightningBoltParameters, UnityEngine.Vector3, UnityEngine.Vector3> value)
        {
            this.<LightningStartedCallback>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Action<DigitalRuby.ThunderAndLightning.LightningBoltParameters, UnityEngine.Vector3, UnityEngine.Vector3> get_LightningEndedCallback()
        {
            return (System.Action<DigitalRuby.ThunderAndLightning.LightningBoltParameters, UnityEngine.Vector3, UnityEngine.Vector3>)this.<LightningEndedCallback>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_LightningEndedCallback(System.Action<DigitalRuby.ThunderAndLightning.LightningBoltParameters, UnityEngine.Vector3, UnityEngine.Vector3> value)
        {
            this.<LightningEndedCallback>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Action<UnityEngine.Light> get_LightAddedCallback()
        {
            return (System.Action<UnityEngine.Light>)this.<LightAddedCallback>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_LightAddedCallback(System.Action<UnityEngine.Light> value)
        {
            this.<LightAddedCallback>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Action<UnityEngine.Light> get_LightRemovedCallback()
        {
            return (System.Action<UnityEngine.Light>)this.<LightRemovedCallback>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_LightRemovedCallback(System.Action<UnityEngine.Light> value)
        {
            this.<LightRemovedCallback>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_HasActiveBolts()
        {
            return (bool)(this.activeBolts.Count != 0) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static UnityEngine.Vector4 get_TimeVectorSinceStart()
        {
            null = null;
            return new UnityEngine.Vector4() {x = DigitalRuby.ThunderAndLightning.LightningBoltScript.<TimeVectorSinceStart>k__BackingField, y = DigitalRuby.ThunderAndLightning.LightningBoltScript.intensityFlickerDefault.__il2cppRuntimeField_14, z = DigitalRuby.ThunderAndLightning.LightningBoltScript.intensityFlickerDefault.__il2cppRuntimeField_18, w = DigitalRuby.ThunderAndLightning.LightningBoltScript.intensityFlickerDefault.__il2cppRuntimeField_1C};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void set_TimeVectorSinceStart(UnityEngine.Vector4 value)
        {
            null = null;
            DigitalRuby.ThunderAndLightning.LightningBoltScript.<TimeVectorSinceStart>k__BackingField = value.x;
            DigitalRuby.ThunderAndLightning.LightningBoltScript.intensityFlickerDefault.__il2cppRuntimeField_14 = value.y;
            DigitalRuby.ThunderAndLightning.LightningBoltScript.intensityFlickerDefault.__il2cppRuntimeField_18 = value.z;
            DigitalRuby.ThunderAndLightning.LightningBoltScript.intensityFlickerDefault.__il2cppRuntimeField_1C = value.w;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static float get_TimeSinceStart()
        {
            null = null;
            return (float)DigitalRuby.ThunderAndLightning.LightningBoltScript.<TimeSinceStart>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void set_TimeSinceStart(float value)
        {
            null = null;
            DigitalRuby.ThunderAndLightning.LightningBoltScript.<TimeSinceStart>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static float get_DeltaTime()
        {
            null = null;
            return (float)DigitalRuby.ThunderAndLightning.LightningBoltScript.<DeltaTime>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void set_DeltaTime(float value)
        {
            null = null;
            DigitalRuby.ThunderAndLightning.LightningBoltScript.<DeltaTime>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual void CreateLightningBolt(DigitalRuby.ThunderAndLightning.LightningBoltParameters p)
        {
            if(p == null)
            {
                    return;
            }
            
            if(this.Camera == 0)
            {
                    return;
            }
            
            this.UpdateTexture();
            this.oneParameterArray[0] = p;
            this.GetOrCreateLightningBolt().SetupLightningBolt(dependencies:  this.CreateLightningBoltDependencies(parameters:  this.oneParameterArray));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void CreateLightningBolts(System.Collections.Generic.ICollection<DigitalRuby.ThunderAndLightning.LightningBoltParameters> parameters)
        {
            if(parameters == null)
            {
                    return;
            }
            
            var val_6 = 0;
            val_6 = val_6 + 1;
            if(parameters.Count == 0)
            {
                    return;
            }
            
            if(this.Camera == 0)
            {
                    return;
            }
            
            this.UpdateTexture();
            this.GetOrCreateLightningBolt().SetupLightningBolt(dependencies:  this.CreateLightningBoltDependencies(parameters:  parameters));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void Awake()
        {
            this.UpdateShaderIds();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void Start()
        {
            this.UpdateCamera();
            this.UpdateMaterialsForLastTexture();
            this.UpdateShaderParameters();
            this.CheckCompensateForParentTransform();
            UnityEngine.SceneManagement.SceneManager.add_sceneLoaded(value:  new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>(object:  this, method:  System.Void DigitalRuby.ThunderAndLightning.LightningBoltScript::OnSceneLoaded(UnityEngine.SceneManagement.Scene arg0, UnityEngine.SceneManagement.LoadSceneMode arg1)));
            if(this.MultiThreaded == false)
            {
                    return;
            }
            
            this.threadState = new DigitalRuby.ThunderAndLightning.LightningThreadState();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void Update()
        {
            var val_10;
            float val_12;
            var val_13;
            val_10 = null;
            val_10 = null;
            if(DigitalRuby.ThunderAndLightning.LightningBoltScript.needsTimeUpdate != false)
            {
                    DigitalRuby.ThunderAndLightning.LightningBoltScript.needsTimeUpdate = false;
                float val_1 = UnityEngine.Time.unscaledDeltaTime;
                val_1 = val_1 * DigitalRuby.ThunderAndLightning.LightningBoltScript.TimeScale;
                DigitalRuby.ThunderAndLightning.LightningBoltScript.DeltaTime = val_1;
                val_12 = DigitalRuby.ThunderAndLightning.LightningBoltScript.TimeSinceStart;
                float val_3 = DigitalRuby.ThunderAndLightning.LightningBoltScript.DeltaTime;
                val_3 = val_12 + val_3;
                DigitalRuby.ThunderAndLightning.LightningBoltScript.TimeSinceStart = val_3;
            }
            
            if(this.HasActiveBolts != false)
            {
                    this.UpdateCamera();
                this.UpdateShaderParameters();
                this.CheckCompensateForParentTransform();
                this.UpdateActiveBolts();
                val_13 = null;
                val_13 = null;
                float val_6 = DigitalRuby.ThunderAndLightning.LightningBoltScript.TimeSinceStart;
                float val_11 = 0.05f;
                float val_10 = 3f;
                float val_9 = DigitalRuby.ThunderAndLightning.LightningBoltScript.TimeSinceStart + DigitalRuby.ThunderAndLightning.LightningBoltScript.TimeSinceStart;
                val_10 = DigitalRuby.ThunderAndLightning.LightningBoltScript.TimeSinceStart * val_10;
                val_11 = DigitalRuby.ThunderAndLightning.LightningBoltScript.TimeSinceStart * val_11;
                val_12 = 0f;
                DigitalRuby.ThunderAndLightning.LightningBoltScript.TimeVectorSinceStart = new UnityEngine.Vector4() {x = val_12, y = 0f, z = 0f, w = 0f};
                UnityEngine.Shader.SetGlobalVector(nameID:  DigitalRuby.ThunderAndLightning.LightningBoltScript.shaderId_LightningTime, value:  new UnityEngine.Vector4() {x = val_12, y = 0f, z = 0f, w = 0f});
            }
            
            if(this.threadState == null)
            {
                    return;
            }
            
            this.threadState.UpdateMainThreadActions();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void LateUpdate()
        {
            null = null;
            DigitalRuby.ThunderAndLightning.LightningBoltScript.needsTimeUpdate = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual DigitalRuby.ThunderAndLightning.LightningBoltParameters OnCreateParameters()
        {
            return DigitalRuby.ThunderAndLightning.LightningBoltParameters.GetOrCreateParameters();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected DigitalRuby.ThunderAndLightning.LightningBoltParameters CreateParameters()
        {
            this.Camera = this.QualitySetting;
            return (DigitalRuby.ThunderAndLightning.LightningBoltParameters)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void PopulateParameters(DigitalRuby.ThunderAndLightning.LightningBoltParameters p)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal UnityEngine.Material get_lightningMaterialMeshInternal()
        {
            return (UnityEngine.Material)this.<lightningMaterialMeshInternal>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_lightningMaterialMeshInternal(UnityEngine.Material value)
        {
            this.<lightningMaterialMeshInternal>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal UnityEngine.Material get_lightningMaterialMeshNoGlowInternal()
        {
            return (UnityEngine.Material)this.<lightningMaterialMeshNoGlowInternal>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_lightningMaterialMeshNoGlowInternal(UnityEngine.Material value)
        {
            this.<lightningMaterialMeshNoGlowInternal>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Coroutine StartCoroutineWrapper(System.Collections.IEnumerator routine)
        {
            if(this.isActiveAndEnabled == false)
            {
                    return 0;
            }
            
            return this.StartCoroutine(routine:  routine);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnSceneLoaded(UnityEngine.SceneManagement.Scene arg0, UnityEngine.SceneManagement.LoadSceneMode arg1)
        {
            DigitalRuby.ThunderAndLightning.LightningBolt.ClearCache();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private DigitalRuby.ThunderAndLightning.LightningBoltDependencies CreateLightningBoltDependencies(System.Collections.Generic.ICollection<DigitalRuby.ThunderAndLightning.LightningBoltParameters> parameters)
        {
            System.Collections.Generic.IEnumerable<T> val_17;
            System.Collections.Generic.List<DigitalRuby.ThunderAndLightning.LightningBoltDependencies> val_18;
            var val_19;
            val_17 = parameters;
            if(this.dependenciesCache.Count != 0)
            {
                    int val_3 = this.dependenciesCache.Count - 1;
                val_18 = this.dependenciesCache;
                val_19 = this.dependenciesCache.Item[val_3];
                val_18.RemoveAt(index:  val_3);
            }
            else
            {
                    DigitalRuby.ThunderAndLightning.LightningBoltDependencies val_5 = null;
                val_19 = val_5;
                val_5 = new DigitalRuby.ThunderAndLightning.LightningBoltDependencies();
                .AddActiveBolt = new System.Action<DigitalRuby.ThunderAndLightning.LightningBolt>(object:  this, method:  System.Void DigitalRuby.ThunderAndLightning.LightningBoltScript::AddActiveBolt(DigitalRuby.ThunderAndLightning.LightningBolt bolt));
                val_18 = 1152921504614674432;
                .LightAdded = new System.Action<UnityEngine.Light>(object:  this, method:  System.Void DigitalRuby.ThunderAndLightning.LightningBoltScript::OnLightAdded(UnityEngine.Light l));
                .LightRemoved = new System.Action<UnityEngine.Light>(object:  this, method:  System.Void DigitalRuby.ThunderAndLightning.LightningBoltScript::OnLightRemoved(UnityEngine.Light l));
                .ReturnToCache = new System.Action<DigitalRuby.ThunderAndLightning.LightningBoltDependencies>(object:  this, method:  System.Void DigitalRuby.ThunderAndLightning.LightningBoltScript::ReturnLightningDependenciesToCache(DigitalRuby.ThunderAndLightning.LightningBoltDependencies d));
                .StartCoroutine = new System.Func<System.Collections.IEnumerator, UnityEngine.Coroutine>(object:  this, method:  UnityEngine.Coroutine DigitalRuby.ThunderAndLightning.LightningBoltScript::StartCoroutineWrapper(System.Collections.IEnumerator routine));
                .Parent = this.gameObject;
            }
            
            UnityEngine.Vector3 val_13 = this.Camera.transform.position;
            .CameraPos = val_13;
            mem[1152921528880430428] = val_13.y;
            mem[1152921528880430432] = val_13.z;
            .CameraIsOrthographic = this.Camera.orthographic;
            .CameraMode = this.calculatedCameraMode;
            .LevelOfDetailDistance = this.LevelOfDetailDistance;
            .DestParticleSystem = this.LightningDestinationParticleSystem;
            .LightningMaterialMesh = this.<lightningMaterialMeshInternal>k__BackingField;
            .LightningMaterialMeshNoGlow = this.<lightningMaterialMeshNoGlowInternal>k__BackingField;
            .OriginParticleSystem = this.LightningOriginParticleSystem;
            .SortLayerName = this.SortLayerName;
            .SortOrderInLayer = this.SortOrderInLayer;
            .UseWorldSpace = this.UseWorldSpace;
            .ThreadState = this.threadState;
            if(this.threadState != null)
            {
                    val_17 = new System.Collections.Generic.List<DigitalRuby.ThunderAndLightning.LightningBoltParameters>(collection:  val_17);
            }
            
            .Parameters = val_17;
            .LightningBoltStarted = this.<LightningStartedCallback>k__BackingField;
            .LightningBoltEnded = this.<LightningEndedCallback>k__BackingField;
            return (DigitalRuby.ThunderAndLightning.LightningBoltDependencies)val_19;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ReturnLightningDependenciesToCache(DigitalRuby.ThunderAndLightning.LightningBoltDependencies d)
        {
            if(d != null)
            {
                    d.Parameters = 0;
                d.LightningMaterialMesh = 0;
                d.OriginParticleSystem = 0;
                d.DestParticleSystem = 0;
            }
            else
            {
                    mem[104] = 0;
                mem[40] = 0;
                mem[48] = 0;
                mem[24] = 0;
            }
            
            d.LightningMaterialMeshNoGlow = 0;
            this.dependenciesCache.Add(item:  d);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal void OnLightAdded(UnityEngine.Light l)
        {
            if((this.<LightAddedCallback>k__BackingField) == null)
            {
                    return;
            }
            
            this.<LightAddedCallback>k__BackingField.Invoke(obj:  l);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal void OnLightRemoved(UnityEngine.Light l)
        {
            if((this.<LightRemovedCallback>k__BackingField) == null)
            {
                    return;
            }
            
            this.<LightRemovedCallback>k__BackingField.Invoke(obj:  l);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal void AddActiveBolt(DigitalRuby.ThunderAndLightning.LightningBolt bolt)
        {
            this.activeBolts.Add(item:  bolt);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateShaderIds()
        {
            int val_14;
            var val_15;
            var val_16;
            val_15 = null;
            val_15 = null;
            if(DigitalRuby.ThunderAndLightning.LightningBoltScript.shaderId_MainTex != (-2147483648))
            {
                    return;
            }
            
            val_16 = null;
            val_14 = UnityEngine.Shader.PropertyToID(name:  "_MainTex");
            val_16 = null;
            DigitalRuby.ThunderAndLightning.LightningBoltScript.shaderId_MainTex = val_14;
            DigitalRuby.ThunderAndLightning.LightningBoltScript.shaderId_GlowTex = UnityEngine.Shader.PropertyToID(name:  "_GlowTex");
            DigitalRuby.ThunderAndLightning.LightningBoltScript.shaderId_TintColor = UnityEngine.Shader.PropertyToID(name:  "_TintColor");
            DigitalRuby.ThunderAndLightning.LightningBoltScript.shaderId_GlowTintColor = UnityEngine.Shader.PropertyToID(name:  "_GlowTintColor");
            DigitalRuby.ThunderAndLightning.LightningBoltScript.shaderId_JitterMultiplier = UnityEngine.Shader.PropertyToID(name:  "_JitterMultiplier");
            DigitalRuby.ThunderAndLightning.LightningBoltScript.shaderId_Turbulence = UnityEngine.Shader.PropertyToID(name:  "_Turbulence");
            DigitalRuby.ThunderAndLightning.LightningBoltScript.shaderId_TurbulenceVelocity = UnityEngine.Shader.PropertyToID(name:  "_TurbulenceVelocity");
            DigitalRuby.ThunderAndLightning.LightningBoltScript.shaderId_SrcBlendMode = UnityEngine.Shader.PropertyToID(name:  "_SrcBlendMode");
            DigitalRuby.ThunderAndLightning.LightningBoltScript.shaderId_DstBlendMode = UnityEngine.Shader.PropertyToID(name:  "_DstBlendMode");
            DigitalRuby.ThunderAndLightning.LightningBoltScript.shaderId_InvFade = UnityEngine.Shader.PropertyToID(name:  "_InvFade");
            DigitalRuby.ThunderAndLightning.LightningBoltScript.shaderId_LightningTime = UnityEngine.Shader.PropertyToID(name:  "_LightningTime");
            DigitalRuby.ThunderAndLightning.LightningBoltScript.shaderId_IntensityFlicker = UnityEngine.Shader.PropertyToID(name:  "_IntensityFlicker");
            DigitalRuby.ThunderAndLightning.LightningBoltScript.shaderId_IntensityFlickerTexture = UnityEngine.Shader.PropertyToID(name:  "_IntensityFlickerTexture");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateMaterialsForLastTexture()
        {
            UnityEngine.Material val_6;
            var val_7;
            var val_8;
            if(UnityEngine.Application.isPlaying == false)
            {
                    return;
            }
            
            this.calculatedCameraMode = 4;
            this.<lightningMaterialMeshInternal>k__BackingField = new UnityEngine.Material(source:  this.LightningMaterialMesh);
            UnityEngine.Material val_3 = null;
            val_6 = val_3;
            val_3 = new UnityEngine.Material(source:  this.LightningMaterialMeshNoGlow);
            this.<lightningMaterialMeshNoGlowInternal>k__BackingField = val_6;
            if(this.LightningTexture != 0)
            {
                    val_7 = null;
                val_7 = null;
                this.<lightningMaterialMeshInternal>k__BackingField.SetTexture(nameID:  DigitalRuby.ThunderAndLightning.LightningBoltScript.shaderId_MainTex, value:  this.LightningTexture);
                val_6 = this.<lightningMaterialMeshNoGlowInternal>k__BackingField;
                val_6.SetTexture(nameID:  DigitalRuby.ThunderAndLightning.LightningBoltScript.shaderId_MainTex, value:  this.LightningTexture);
            }
            
            if(this.LightningGlowTexture != 0)
            {
                    val_8 = null;
                val_8 = null;
                val_6 = DigitalRuby.ThunderAndLightning.LightningBoltScript.shaderId_GlowTex;
                this.<lightningMaterialMeshInternal>k__BackingField.SetTexture(nameID:  val_6, value:  this.LightningGlowTexture);
            }
            
            this.SetupMaterialCamera();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateTexture()
        {
            UnityEngine.Texture2D val_5;
            if(this.LightningTexture != 0)
            {
                    val_5 = this.lastLightningTexture;
                if(this.LightningTexture != val_5)
            {
                    this.lastLightningTexture = this.LightningTexture;
                this.UpdateMaterialsForLastTexture();
            }
            
            }
            
            if(this.LightningGlowTexture == 0)
            {
                    return;
            }
            
            val_5 = this.lastLightningGlowTexture;
            if(this.LightningGlowTexture == val_5)
            {
                    return;
            }
            
            this.lastLightningGlowTexture = this.LightningGlowTexture;
            this.UpdateMaterialsForLastTexture();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetMaterialPerspective()
        {
            if(this.calculatedCameraMode == 1)
            {
                    return;
            }
            
            this.calculatedCameraMode = 1;
            this.<lightningMaterialMeshInternal>k__BackingField.EnableKeyword(keyword:  "PERSPECTIVE");
            this.<lightningMaterialMeshNoGlowInternal>k__BackingField.EnableKeyword(keyword:  "PERSPECTIVE");
            this.<lightningMaterialMeshInternal>k__BackingField.DisableKeyword(keyword:  "ORTHOGRAPHIC_XY");
            this.<lightningMaterialMeshNoGlowInternal>k__BackingField.DisableKeyword(keyword:  "ORTHOGRAPHIC_XY");
            this.<lightningMaterialMeshInternal>k__BackingField.DisableKeyword(keyword:  "ORTHOGRAPHIC_XZ");
            this.<lightningMaterialMeshNoGlowInternal>k__BackingField.DisableKeyword(keyword:  "ORTHOGRAPHIC_XZ");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetMaterialOrthographicXY()
        {
            if(this.calculatedCameraMode == 2)
            {
                    return;
            }
            
            this.calculatedCameraMode = 2;
            this.<lightningMaterialMeshInternal>k__BackingField.EnableKeyword(keyword:  "ORTHOGRAPHIC_XY");
            this.<lightningMaterialMeshNoGlowInternal>k__BackingField.EnableKeyword(keyword:  "ORTHOGRAPHIC_XY");
            this.<lightningMaterialMeshInternal>k__BackingField.DisableKeyword(keyword:  "ORTHOGRAPHIC_XZ");
            this.<lightningMaterialMeshNoGlowInternal>k__BackingField.DisableKeyword(keyword:  "ORTHOGRAPHIC_XZ");
            this.<lightningMaterialMeshInternal>k__BackingField.DisableKeyword(keyword:  "PERSPECTIVE");
            this.<lightningMaterialMeshNoGlowInternal>k__BackingField.DisableKeyword(keyword:  "PERSPECTIVE");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetMaterialOrthographicXZ()
        {
            if(this.calculatedCameraMode == 3)
            {
                    return;
            }
            
            this.calculatedCameraMode = 3;
            this.<lightningMaterialMeshInternal>k__BackingField.EnableKeyword(keyword:  "ORTHOGRAPHIC_XZ");
            this.<lightningMaterialMeshNoGlowInternal>k__BackingField.EnableKeyword(keyword:  "ORTHOGRAPHIC_XZ");
            this.<lightningMaterialMeshInternal>k__BackingField.DisableKeyword(keyword:  "ORTHOGRAPHIC_XY");
            this.<lightningMaterialMeshNoGlowInternal>k__BackingField.DisableKeyword(keyword:  "ORTHOGRAPHIC_XY");
            this.<lightningMaterialMeshInternal>k__BackingField.DisableKeyword(keyword:  "PERSPECTIVE");
            this.<lightningMaterialMeshNoGlowInternal>k__BackingField.DisableKeyword(keyword:  "PERSPECTIVE");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetupMaterialCamera()
        {
            if(this.Camera == 0)
            {
                    if(this.CameraMode == 0)
            {
                goto label_9;
            }
            
            }
            
            if(this.CameraMode == 2)
            {
                goto label_5;
            }
            
            if(this.CameraMode == 1)
            {
                goto label_9;
            }
            
            if(this.CameraMode != 0)
            {
                goto label_7;
            }
            
            if(this.Camera.orthographic == false)
            {
                goto label_9;
            }
            
            label_5:
            this.SetMaterialOrthographicXY();
            return;
            label_9:
            this.SetMaterialPerspective();
            return;
            label_7:
            this.SetMaterialOrthographicXZ();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EnableKeyword(string keyword, bool enable, UnityEngine.Material m)
        {
            if(m == null)
            {
                goto label_0;
            }
            
            if(enable == false)
            {
                goto label_1;
            }
            
            label_2:
            m.EnableKeyword(keyword:  keyword);
            return;
            label_0:
            if(enable == true)
            {
                goto label_2;
            }
            
            label_1:
            m.DisableKeyword(keyword:  keyword);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateShaderParameters()
        {
            var val_9;
            var val_10;
            float val_11;
            float val_12;
            var val_13;
            var val_14;
            val_9 = null;
            val_9 = null;
            this.<lightningMaterialMeshInternal>k__BackingField.SetColor(nameID:  DigitalRuby.ThunderAndLightning.LightningBoltScript.shaderId_TintColor, value:  new UnityEngine.Color() {r = this.LightningTintColor, g = V9.16B, b = V10.16B, a = V11.16B});
            this.<lightningMaterialMeshInternal>k__BackingField.SetColor(nameID:  DigitalRuby.ThunderAndLightning.LightningBoltScript.shaderId_GlowTintColor, value:  new UnityEngine.Color() {r = this.GlowTintColor, g = V9.16B, b = V10.16B, a = V11.16B});
            this.<lightningMaterialMeshInternal>k__BackingField.SetFloat(nameID:  DigitalRuby.ThunderAndLightning.LightningBoltScript.shaderId_JitterMultiplier, value:  this.JitterMultiplier);
            val_10 = null;
            val_10 = null;
            this.<lightningMaterialMeshInternal>k__BackingField.SetFloat(nameID:  DigitalRuby.ThunderAndLightning.LightningBoltScript.shaderId_Turbulence, value:  this.Turbulence * DigitalRuby.ThunderAndLightning.LightningBoltParameters.Scale);
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = this.TurbulenceVelocity, y = DigitalRuby.ThunderAndLightning.LightningBoltParameters.Scale, z = V10.16B}, d:  DigitalRuby.ThunderAndLightning.LightningBoltParameters.Scale);
            UnityEngine.Vector4 val_3 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            this.<lightningMaterialMeshInternal>k__BackingField.SetVector(nameID:  DigitalRuby.ThunderAndLightning.LightningBoltScript.shaderId_TurbulenceVelocity, value:  new UnityEngine.Vector4() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w});
            this.<lightningMaterialMeshInternal>k__BackingField.SetInt(nameID:  DigitalRuby.ThunderAndLightning.LightningBoltScript.shaderId_SrcBlendMode, value:  this.SourceBlendMode);
            this.<lightningMaterialMeshInternal>k__BackingField.SetInt(nameID:  DigitalRuby.ThunderAndLightning.LightningBoltScript.shaderId_DstBlendMode, value:  this.DestinationBlendMode);
            this.<lightningMaterialMeshInternal>k__BackingField.renderQueue = this.RenderQueue;
            this.<lightningMaterialMeshInternal>k__BackingField.SetFloat(nameID:  DigitalRuby.ThunderAndLightning.LightningBoltScript.shaderId_InvFade, value:  this.SoftParticlesFactor);
            this.<lightningMaterialMeshNoGlowInternal>k__BackingField.SetColor(nameID:  DigitalRuby.ThunderAndLightning.LightningBoltScript.shaderId_TintColor, value:  new UnityEngine.Color() {r = this.LightningTintColor, g = val_3.y, b = val_3.z, a = val_3.w});
            this.<lightningMaterialMeshNoGlowInternal>k__BackingField.SetFloat(nameID:  DigitalRuby.ThunderAndLightning.LightningBoltScript.shaderId_JitterMultiplier, value:  this.JitterMultiplier);
            this.<lightningMaterialMeshNoGlowInternal>k__BackingField.SetFloat(nameID:  DigitalRuby.ThunderAndLightning.LightningBoltScript.shaderId_Turbulence, value:  this.Turbulence * DigitalRuby.ThunderAndLightning.LightningBoltParameters.Scale);
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = this.TurbulenceVelocity, y = val_3.y, z = val_3.z}, d:  DigitalRuby.ThunderAndLightning.LightningBoltParameters.Scale);
            UnityEngine.Vector4 val_6 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            val_11 = val_6.z;
            this.<lightningMaterialMeshNoGlowInternal>k__BackingField.SetVector(nameID:  DigitalRuby.ThunderAndLightning.LightningBoltScript.shaderId_TurbulenceVelocity, value:  new UnityEngine.Vector4() {x = val_6.x, y = val_6.y, z = val_11, w = val_6.w});
            this.<lightningMaterialMeshNoGlowInternal>k__BackingField.SetInt(nameID:  DigitalRuby.ThunderAndLightning.LightningBoltScript.shaderId_SrcBlendMode, value:  this.SourceBlendMode);
            this.<lightningMaterialMeshNoGlowInternal>k__BackingField.SetInt(nameID:  DigitalRuby.ThunderAndLightning.LightningBoltScript.shaderId_DstBlendMode, value:  this.DestinationBlendMode);
            this.<lightningMaterialMeshNoGlowInternal>k__BackingField.renderQueue = this.RenderQueue;
            val_12 = this.SoftParticlesFactor;
            this.<lightningMaterialMeshNoGlowInternal>k__BackingField.SetFloat(nameID:  DigitalRuby.ThunderAndLightning.LightningBoltScript.shaderId_InvFade, value:  val_12);
            if(((UnityEngine.Vector4.op_Inequality(lhs:  new UnityEngine.Vector4() {x = this.IntensityFlicker, y = val_6.y, z = val_11, w = val_6.w}, rhs:  new UnityEngine.Vector4() {x = DigitalRuby.ThunderAndLightning.LightningBoltScript.intensityFlickerDefault, y = DigitalRuby.ThunderAndLightning.LightningBoltScript.intensityFlickerDefault.__il2cppRuntimeField_4, z = DigitalRuby.ThunderAndLightning.LightningBoltScript.intensityFlickerDefault.__il2cppRuntimeField_8, w = DigitalRuby.ThunderAndLightning.LightningBoltScript.intensityFlickerDefault.__il2cppRuntimeField_C})) != false) && (this.IntensityFlickerTexture != 0))
            {
                    val_13 = null;
                val_13 = null;
                this.<lightningMaterialMeshInternal>k__BackingField.SetVector(nameID:  DigitalRuby.ThunderAndLightning.LightningBoltScript.shaderId_IntensityFlicker, value:  new UnityEngine.Vector4() {x = this.IntensityFlicker, y = val_6.y, z = val_11, w = val_6.w});
                this.<lightningMaterialMeshInternal>k__BackingField.SetTexture(nameID:  DigitalRuby.ThunderAndLightning.LightningBoltScript.shaderId_IntensityFlickerTexture, value:  this.IntensityFlickerTexture);
                val_12 = this.IntensityFlicker;
                this.<lightningMaterialMeshNoGlowInternal>k__BackingField.SetVector(nameID:  DigitalRuby.ThunderAndLightning.LightningBoltScript.shaderId_IntensityFlicker, value:  new UnityEngine.Vector4() {x = val_12, y = val_6.y, z = val_11, w = val_6.w});
                this.<lightningMaterialMeshNoGlowInternal>k__BackingField.SetTexture(nameID:  DigitalRuby.ThunderAndLightning.LightningBoltScript.shaderId_IntensityFlickerTexture, value:  this.IntensityFlickerTexture);
                val_14 = "INTENSITY_FLICKER";
                this.<lightningMaterialMeshInternal>k__BackingField.EnableKeyword(keyword:  "INTENSITY_FLICKER");
                this.<lightningMaterialMeshNoGlowInternal>k__BackingField.EnableKeyword(keyword:  "INTENSITY_FLICKER");
            }
            else
            {
                    val_14 = "INTENSITY_FLICKER";
                this.<lightningMaterialMeshInternal>k__BackingField.DisableKeyword(keyword:  "INTENSITY_FLICKER");
                this.<lightningMaterialMeshNoGlowInternal>k__BackingField.DisableKeyword(keyword:  "INTENSITY_FLICKER");
            }
            
            this.SetupMaterialCamera();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CheckCompensateForParentTransform()
        {
            var val_16;
            float val_17;
            float val_18;
            val_16 = this;
            if(this.CompensateForParentTransform == false)
            {
                    return;
            }
            
            UnityEngine.Transform val_2 = this.transform.parent;
            if(val_2 == 0)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_5 = val_2.position;
            this.transform.position = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
            if(val_2 != null)
            {
                    UnityEngine.Vector3 val_7 = val_2.localScale;
                val_17 = val_7.x;
                UnityEngine.Vector3 val_8 = val_2.localScale;
                val_18 = val_8.y;
            }
            else
            {
                    UnityEngine.Vector3 val_9 = 0.localScale;
                val_17 = val_9.x;
                UnityEngine.Vector3 val_10 = 0.localScale;
                val_18 = val_10.y;
            }
            
            UnityEngine.Vector3 val_11 = val_2.localScale;
            float val_12 = 1f / val_17;
            float val_13 = 1f / val_18;
            val_11.z = 1f / val_11.z;
            this.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            val_16 = this.transform;
            UnityEngine.Quaternion val_15 = val_2.rotation;
            val_16.rotation = new UnityEngine.Quaternion() {x = val_15.x, y = val_15.y, z = val_15.z, w = val_15.w};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateCamera()
        {
            UnityEngine.Camera val_7;
            bool val_1 = UnityEngine.Object.op_Equality(x:  this.Camera, y:  0);
            if(val_1 == false)
            {
                goto label_3;
            }
            
            if(UnityEngine.Camera.current != 0)
            {
                goto label_6;
            }
            
            UnityEngine.Camera val_4 = UnityEngine.Camera.main;
            if(this != null)
            {
                    if(val_1 ^ 1 == false)
            {
                goto label_9;
            }
            
            }
            
            label_3:
            val_7 = this.Camera;
            goto label_9;
            label_6:
            label_9:
            this.Camera = UnityEngine.Camera.current;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private DigitalRuby.ThunderAndLightning.LightningBolt GetOrCreateLightningBolt()
        {
            var val_10;
            var val_11;
            var val_12;
            if(this.lightningBoltCache.Count == 0)
            {
                goto label_2;
            }
            
            if(this.lightningBoltCache == null)
            {
                goto label_3;
            }
            
            val_10 = this.lightningBoltCache.Count;
            goto label_4;
            label_2:
            DigitalRuby.ThunderAndLightning.LightningBolt val_3 = null;
            val_11 = val_3;
            val_3 = new DigitalRuby.ThunderAndLightning.LightningBolt();
            return (DigitalRuby.ThunderAndLightning.LightningBolt)val_11;
            label_3:
            val_10 = 0.Count;
            label_4:
            val_11 = this.lightningBoltCache.Item[val_10 - 1];
            if(this.lightningBoltCache != null)
            {
                    val_12 = this.lightningBoltCache.Count;
            }
            else
            {
                    val_12 = 0.Count;
            }
            
            this.lightningBoltCache.RemoveAt(index:  val_12 - 1);
            return (DigitalRuby.ThunderAndLightning.LightningBolt)val_11;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateActiveBolts()
        {
            System.Collections.Generic.List<DigitalRuby.ThunderAndLightning.LightningBolt> val_4 = this.activeBolts;
            val_4 = val_4.Count - 1;
            if((val_4 & 2147483648) != 0)
            {
                    return;
            }
            
            do
            {
                DigitalRuby.ThunderAndLightning.LightningBolt val_2 = this.activeBolts.Item[val_4];
                if(val_2.Update() != true)
            {
                    this.activeBolts.RemoveAt(index:  val_4);
                val_2.Cleanup();
                this.lightningBoltCache.Add(item:  val_2);
            }
            
                val_4 = val_4 - 1;
            }
            while((val_4 & 2147483648) == 0);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnApplicationQuit()
        {
            if(this.threadState == null)
            {
                    return;
            }
            
            this.threadState.Running = false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Cleanup()
        {
            List.Enumerator<T> val_1 = this.activeBolts.GetEnumerator();
            label_4:
            if(((-1493146632) & 1) == 0)
            {
                goto label_2;
            }
            
            0.emailUIDataHandler.Cleanup();
            goto label_4;
            label_2:
            long val_3 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921528883504120});
            this.activeBolts.Clear();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDestroy()
        {
            if(this.threadState != null)
            {
                    this.threadState.TerminateAndWaitForEnd();
            }
            
            if((this.<lightningMaterialMeshInternal>k__BackingField) != 0)
            {
                    UnityEngine.Object.Destroy(obj:  this.<lightningMaterialMeshInternal>k__BackingField);
            }
            
            if((this.<lightningMaterialMeshNoGlowInternal>k__BackingField) != 0)
            {
                    UnityEngine.Object.Destroy(obj:  this.<lightningMaterialMeshNoGlowInternal>k__BackingField);
            }
            
            this.Cleanup();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDisable()
        {
            this.Cleanup();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LightningBoltScript()
        {
            var val_7;
            this.calculatedCameraMode = 4;
            this.UseWorldSpace = true;
            this.SoftParticlesFactor = 3f;
            this.RenderQueue = 0;
            UnityEngine.Color val_1 = UnityEngine.Color.white;
            this.LightningTintColor = val_1;
            mem[1152921528883932212] = val_1.g;
            mem[1152921528883932216] = val_1.b;
            mem[1152921528883932220] = val_1.a;
            this.SourceBlendMode = 5;
            this.GlowTintColor = 0;
            mem[1152921528883932228] = 0;
            mem[1152921528883932236] = 0;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            this.TurbulenceVelocity = val_2;
            mem[1152921528883932260] = val_2.y;
            mem[1152921528883932264] = val_2.z;
            val_7 = null;
            val_7 = null;
            this.IntensityFlicker = DigitalRuby.ThunderAndLightning.LightningBoltScript.intensityFlickerDefault;
            mem[1152921528883932272] = DigitalRuby.ThunderAndLightning.LightningBoltScript.intensityFlickerDefault.__il2cppRuntimeField_4;
            mem[1152921528883932280] = DigitalRuby.ThunderAndLightning.LightningBoltScript.intensityFlickerDefault.__il2cppRuntimeField_C;
            this.activeBolts = new System.Collections.Generic.List<DigitalRuby.ThunderAndLightning.LightningBolt>();
            this.oneParameterArray = new DigitalRuby.ThunderAndLightning.LightningBoltParameters[1];
            this.lightningBoltCache = new System.Collections.Generic.List<DigitalRuby.ThunderAndLightning.LightningBolt>();
            this.dependenciesCache = new System.Collections.Generic.List<DigitalRuby.ThunderAndLightning.LightningBoltDependencies>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static LightningBoltScript()
        {
            DigitalRuby.ThunderAndLightning.LightningBoltScript.intensityFlickerDefault = 0;
            DigitalRuby.ThunderAndLightning.LightningBoltScript.TimeScale = 1f;
            DigitalRuby.ThunderAndLightning.LightningBoltScript.needsTimeUpdate = true;
            DigitalRuby.ThunderAndLightning.LightningBoltScript.shaderId_MainTex = -2147483648;
        }
    
    }

}
