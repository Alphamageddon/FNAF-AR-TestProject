using UnityEngine;

namespace VLB
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class VolumetricDustParticles : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float alpha;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float size;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public VLB.VolumetricDustParticles.Direction direction;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float speed;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float density;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float spawnMaxDistance;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool cullingEnabled;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float cullingMaxDistance;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <isCulled>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool isFeatureSupported;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.ParticleSystem m_Particles;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.ParticleSystemRenderer m_Renderer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static bool ms_NoMainCameraLogged;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static UnityEngine.Camera ms_MainCamera;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private VLB.VolumetricLightBeam m_Master;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool isCulled { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool particlesAreInstantiated { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int particlesCurrentCount { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int particlesMaxCount { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Camera mainCamera { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_isCulled()
        {
            return (bool)this.<isCulled>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_isCulled(bool value)
        {
            this.<isCulled>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_particlesAreInstantiated()
        {
            return UnityEngine.Object.op_Implicit(exists:  this.m_Particles);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_particlesCurrentCount()
        {
            if((UnityEngine.Object.op_Implicit(exists:  this.m_Particles)) == false)
            {
                    return 0;
            }
            
            if(this.m_Particles != null)
            {
                    return this.m_Particles.particleCount;
            }
            
            return this.m_Particles.particleCount;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_particlesMaxCount()
        {
            UnityEngine.ParticleSystem val_4;
            var val_5;
            val_4 = this;
            if((UnityEngine.Object.op_Implicit(exists:  this.m_Particles)) != false)
            {
                    val_4 = this.m_Particles;
                MainModule val_2 = val_4.main;
                int val_3 = val_2.m_ParticleSystem.maxParticles;
                return (int)val_5;
            }
            
            val_5 = 0;
            return (int)val_5;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Camera get_mainCamera()
        {
            UnityEngine.Object val_6;
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            val_6 = this;
            val_7 = null;
            val_7 = null;
            if((UnityEngine.Object.op_Implicit(exists:  VLB.VolumetricDustParticles.ms_MainCamera)) != true)
            {
                    val_8 = null;
                val_8 = null;
                VLB.VolumetricDustParticles.ms_MainCamera = UnityEngine.Camera.main;
                if((UnityEngine.Object.op_Implicit(exists:  VLB.VolumetricDustParticles.ms_MainCamera)) != true)
            {
                    val_9 = null;
                val_9 = null;
                if(VLB.VolumetricDustParticles.ms_NoMainCameraLogged != true)
            {
                    val_6 = this.gameObject;
                UnityEngine.Debug.LogErrorFormat(context:  val_6, format:  "In order to use \'VolumetricDustParticles\' culling, you must have a MainCamera defined in your scene.", args:  System.Array.Empty<System.Object>());
                val_10 = null;
                val_10 = null;
                VLB.VolumetricDustParticles.ms_NoMainCameraLogged = true;
            }
            
            }
            
            }
            
            val_11 = null;
            val_11 = null;
            return (UnityEngine.Camera)VLB.VolumetricDustParticles.ms_MainCamera;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            this.<isCulled>k__BackingField = false;
            this.m_Master = this.GetComponent<VLB.VolumetricLightBeam>();
            this.InstantiateParticleSystem();
            this.SetActiveAndPlay();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void InstantiateParticleSystem()
        {
            int val_12;
            var val_13;
            var val_14;
            UnityEngine.Object val_15;
            int val_2 = val_1.Length - 1;
            if((val_2 & 2147483648) != 0)
            {
                goto label_2;
            }
            
            val_12 = val_1.Length & 4294967295;
            val_13 = (long)val_2;
            val_14 = val_1.Length - 2;
            goto label_3;
            label_8:
            val_12 = val_1.Length;
            val_13 = val_13 - 1;
            val_14 = val_14 - 1;
            label_3:
            val_15 = this.GetComponentsInChildren<UnityEngine.ParticleSystem>(includeInactive:  true)[val_13].gameObject;
            UnityEngine.Object.DestroyImmediate(obj:  val_15);
            if((val_14 & 2147483648) == 0)
            {
                goto label_8;
            }
            
            label_2:
            UnityEngine.ParticleSystem val_5 = VLB.Config.Instance.NewVolumetricDustParticles();
            this.m_Particles = val_5;
            if((UnityEngine.Object.op_Implicit(exists:  val_5)) == false)
            {
                    return;
            }
            
            val_15 = this.transform;
            this.m_Particles.transform.SetParent(parent:  val_15, worldPositionStays:  false);
            this.m_Renderer = this.m_Particles.GetComponent<UnityEngine.ParticleSystemRenderer>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnEnable()
        {
            this.SetActiveAndPlay();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetActiveAndPlay()
        {
            if((UnityEngine.Object.op_Implicit(exists:  this.m_Particles)) == false)
            {
                    return;
            }
            
            this.m_Particles.gameObject.SetActive(value:  true);
            this.SetParticleProperties();
            this.m_Particles.Play(withChildren:  true);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDisable()
        {
            if((UnityEngine.Object.op_Implicit(exists:  this.m_Particles)) == false)
            {
                    return;
            }
            
            this.m_Particles.gameObject.SetActive(value:  false);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDestroy()
        {
            if((UnityEngine.Object.op_Implicit(exists:  this.m_Particles)) != false)
            {
                    UnityEngine.Object.DestroyImmediate(obj:  this.m_Particles.gameObject);
            }
            
            this.m_Particles = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            if(UnityEngine.Application.isPlaying != false)
            {
                    this.UpdateCulling();
            }
            
            this.SetParticleProperties();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetParticleProperties()
        {
            float val_18;
            float val_20;
            UnityEngine.ParticleSystemRenderer val_38;
            VLB.VolumetricLightBeam val_39;
            var val_40;
            val_38 = this;
            if((UnityEngine.Object.op_Implicit(exists:  this.m_Particles)) == false)
            {
                    return;
            }
            
            if(this.m_Particles.gameObject.activeSelf == false)
            {
                    return;
            }
            
            float val_37 = -10f;
            val_37 = this.m_Master.fresnelPow / val_37;
            val_37 = val_37 + 1f;
            float val_4 = UnityEngine.Mathf.Clamp01(value:  val_37);
            float val_5 = this.m_Master.fallOffEnd * this.spawnMaxDistance;
            float val_6 = val_5 * this.density;
            MainModule val_7 = this.m_Particles.main;
            MinMaxCurve val_8 = val_7.m_ParticleSystem.startLifetime;
            UnityEngine.XR.ARFoundation.ARSessionStateChangedEventArgs val_11 = new UnityEngine.XR.ARFoundation.ARSessionStateChangedEventArgs(state:  3);
            val_11.<state>k__BackingField.startValue = 4f;
            val_11.<state>k__BackingField.targetValue = 6f;
            MinMaxCurve val_12 = val_7.m_ParticleSystem.startSize;
            UnityEngine.XR.ARFoundation.ARSessionStateChangedEventArgs val_15 = new UnityEngine.XR.ARFoundation.ARSessionStateChangedEventArgs(state:  3);
            float val_38 = this.size;
            val_38 = val_38 * 0.9f;
            val_15.<state>k__BackingField.startValue = val_38;
            float val_39 = this.size;
            val_39 = val_39 * 1.1f;
            val_15.<state>k__BackingField.targetValue = val_39;
            MinMaxGradient val_16 = val_7.m_ParticleSystem.startColor;
            if(this.m_Master.colorMode == 0)
            {
                goto label_13;
            }
            
            UnityEngine.XR.ARFoundation.ARSessionStateChangedEventArgs val_21 = new UnityEngine.XR.ARFoundation.ARSessionStateChangedEventArgs(state:  1);
            if(this.m_Master.colorGradient == null)
            {
                goto label_15;
            }
            
            val_39 = this.m_Master.colorGradient.colorKeys;
            goto label_16;
            label_13:
            UnityEngine.XR.ARFoundation.ARSessionStateChangedEventArgs val_23 = new UnityEngine.XR.ARFoundation.ARSessionStateChangedEventArgs(state:  0);
            val_39 = this.m_Master;
            val_23.<state>k__BackingField.targetColor = new UnityEngine.Color() {r = this.m_Master.color, g = val_18, b = val_20, a = S3 * this.alpha};
            goto label_18;
            label_15:
            val_39 = 0.colorKeys;
            label_16:
            UnityEngine.GradientAlphaKey[] val_26 = this.m_Master.colorGradient.alphaKeys;
            val_40 = 0;
            goto label_19;
            label_22:
            float val_41 = this.alpha;
            val_40 = 1;
            val_41 = val_26[0] * val_41;
            val_26[0] = val_41;
            label_19:
            if(val_40 < val_26.Length)
            {
                goto label_22;
            }
            
            UnityEngine.Gradient val_27 = new UnityEngine.Gradient();
            val_27.SetKeys(colorKeys:  val_39, alphaKeys:  val_26);
            val_23.<state>k__BackingField.emailUIDataHandler = val_27;
            label_18:
            MinMaxCurve val_28 = val_7.m_ParticleSystem.startSpeed;
            val_20.targetValue = this.speed;
            val_7.m_ParticleSystem.maxParticles = (int)val_6;
            ShapeModule val_29 = this.m_Particles.shape;
            val_29.m_ParticleSystem.shapeType = 8;
            float val_30 = UnityEngine.Mathf.Lerp(a:  0.3f, b:  1f, t:  val_4);
            val_30 = this.m_Master.coneRadiusStart * val_30;
            val_29.m_ParticleSystem.radius = val_30;
            float val_32 = UnityEngine.Mathf.Lerp(a:  0.7f, b:  1f, t:  val_4);
            float val_42 = 0.5f;
            val_42 = this.m_Master.coneAngle * val_42;
            val_32 = val_42 * val_32;
            val_29.m_ParticleSystem.angle = val_32;
            val_29.m_ParticleSystem.length = val_5;
            val_29.m_ParticleSystem.randomDirectionAmount = (this.direction == 1) ? 1f : 0f;
            EmissionModule val_34 = this.m_Particles.emission;
            MinMaxCurve val_35 = val_34.m_ParticleSystem.rateOverTime;
            val_20.targetValue = val_6;
            if((UnityEngine.Object.op_Implicit(exists:  this.m_Renderer)) == false)
            {
                    return;
            }
            
            val_39 = this.m_Master._SortingLayerID;
            this.m_Renderer.sortingLayerID = val_39;
            val_38 = this.m_Renderer;
            val_38.sortingOrder = this.m_Master._SortingOrder;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateCulling()
        {
            UnityEngine.ParticleSystem val_18;
            var val_19;
            val_18 = this;
            if((UnityEngine.Object.op_Implicit(exists:  this.m_Particles)) == false)
            {
                    return;
            }
            
            if((this.cullingEnabled == false) || (this.m_Master.hasGeometry == false))
            {
                goto label_6;
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  this.mainCamera)) == false)
            {
                goto label_9;
            }
            
            float val_18 = this.cullingMaxDistance;
            UnityEngine.Bounds val_5 = this.m_Master.bounds;
            val_18 = val_18 * val_18;
            UnityEngine.Vector3 val_10 = this.mainCamera.transform.position;
            var val_11 = (val_10.x <= val_18) ? 1 : 0;
            goto label_13;
            label_9:
            this.cullingEnabled = false;
            label_6:
            val_19 = 1;
            label_13:
            if(val_19 ^ this.m_Particles.gameObject.activeSelf != false)
            {
                    this.m_Particles.gameObject.SetActive(value:  true);
                this.<isCulled>k__BackingField = val_19 ^ 1;
            }
            
            if(val_19 == 0)
            {
                    return;
            }
            
            if(this.m_Particles.isPlaying == true)
            {
                    return;
            }
            
            val_18 = this.m_Particles;
            val_18.Play();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public VolumetricDustParticles()
        {
            this.alpha = 0.5f;
            this.size = 7.714148E-41f;
            this.direction = 1;
            this.density = 5f;
            this.spawnMaxDistance = 1.836682E-41f;
            this.cullingEnabled = true;
            this.cullingMaxDistance = 10f;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static VolumetricDustParticles()
        {
            VLB.VolumetricDustParticles.isFeatureSupported = true;
            VLB.VolumetricDustParticles.ms_NoMainCameraLogged = false;
            VLB.VolumetricDustParticles.ms_MainCamera = 0;
        }
    
    }

}
