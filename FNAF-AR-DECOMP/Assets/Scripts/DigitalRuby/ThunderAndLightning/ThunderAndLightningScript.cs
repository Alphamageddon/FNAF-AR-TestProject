using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ThunderAndLightningScript : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DigitalRuby.ThunderAndLightning.LightningBoltPrefabScript LightningBoltScript;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Camera Camera;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DigitalRuby.ThunderAndLightning.RangeOfFloats LightningIntervalTimeRange;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float LightningIntenseProbability;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.AudioClip[] ThunderSoundsNormal;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.AudioClip[] ThunderSoundsIntense;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool LightningAlwaysVisible;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float CloudLightningChance;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool ModifySkyboxExposure;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float BaseLightRange;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float LightningYStart;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float VolumeMultiplier;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float skyboxExposureOriginal;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float skyboxExposureStorm;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float nextLightningTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool lightningInProgress;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.AudioSource audioSourceThunder;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private DigitalRuby.ThunderAndLightning.ThunderAndLightningScript.LightningBoltHandler lightningBoltHandler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Material skyboxMaterial;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.AudioClip lastThunderSound;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <EnableLightning>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float SkyboxExposureOriginal { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool EnableLightning { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            UnityEngine.Material val_13;
            var val_14;
            float val_15;
            this.<EnableLightning>k__BackingField = true;
            if(this.Camera == 0)
            {
                    this.Camera = UnityEngine.Camera.main;
            }
            
            if(UnityEngine.RenderSettings.skybox != 0)
            {
                    UnityEngine.Material val_6 = null;
                val_13 = val_6;
                val_6 = new UnityEngine.Material(source:  UnityEngine.RenderSettings.skybox);
                UnityEngine.RenderSettings.skybox = val_6;
                val_14 = this;
                this.skyboxMaterial = val_13;
            }
            else
            {
                    val_14 = this;
                val_13 = this.skyboxMaterial;
            }
            
            val_15 = 1f;
            if(val_13 != 0)
            {
                    if((val_6.HasProperty(name:  "_Exposure")) != false)
            {
                    val_15 = val_6.GetFloat(name:  "_Exposure");
            }
            
            }
            
            this.skyboxExposureOriginal = val_15;
            this.skyboxExposureStorm = val_15;
            this.audioSourceThunder = this.gameObject.AddComponent<UnityEngine.AudioSource>();
            this.lightningBoltHandler = new ThunderAndLightningScript.LightningBoltHandler(script:  this);
            .<VolumeMultiplier>k__BackingField = this.VolumeMultiplier;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            if(this.lightningBoltHandler == null)
            {
                    return;
            }
            
            if((this.<EnableLightning>k__BackingField) == false)
            {
                    return;
            }
            
            this.lightningBoltHandler.<VolumeMultiplier>k__BackingField = this.VolumeMultiplier;
            this.lightningBoltHandler.UpdateLighting();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void CallNormalLightning()
        {
            this.CallNormalLightning(start:  new System.Nullable<UnityEngine.Vector3>() {HasValue = false}, end:  new System.Nullable<UnityEngine.Vector3>() {HasValue = false});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void CallNormalLightning(System.Nullable<UnityEngine.Vector3> start, System.Nullable<UnityEngine.Vector3> end)
        {
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.lightningBoltHandler.ProcessLightning(_start:  new System.Nullable<UnityEngine.Vector3>() {HasValue = start.HasValue}, _end:  new System.Nullable<UnityEngine.Vector3>() {HasValue = end.HasValue}, intense:  X3, visible:  X4));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void CallIntenseLightning()
        {
            this.CallIntenseLightning(start:  new System.Nullable<UnityEngine.Vector3>() {HasValue = false}, end:  new System.Nullable<UnityEngine.Vector3>() {HasValue = false});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void CallIntenseLightning(System.Nullable<UnityEngine.Vector3> start, System.Nullable<UnityEngine.Vector3> end)
        {
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.lightningBoltHandler.ProcessLightning(_start:  new System.Nullable<UnityEngine.Vector3>() {HasValue = start.HasValue}, _end:  new System.Nullable<UnityEngine.Vector3>() {HasValue = end.HasValue}, intense:  X3, visible:  X4));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_SkyboxExposureOriginal()
        {
            return (float)this.skyboxExposureOriginal;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_EnableLightning()
        {
            return (bool)this.<EnableLightning>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_EnableLightning(bool value)
        {
            this.<EnableLightning>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ThunderAndLightningScript()
        {
            this.LightningIntervalTimeRange = new DigitalRuby.ThunderAndLightning.RangeOfFloats();
            this.LightningIntenseProbability = 0.2f;
            this.LightningAlwaysVisible = true;
            this.CloudLightningChance = 0.5f;
            this.BaseLightRange = 2000f;
            this.LightningYStart = 500f;
            this.VolumeMultiplier = 1f;
        }
    
    }

}
