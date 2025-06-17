using UnityEngine;

namespace Ibuprogames.VideoGlitchesAsset
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract class VideoGlitchBase : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float strength;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Ibuprogames.VideoGlitchesAsset.EffectModes effectMode;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool enableColorControls;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float brightness;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float contrast;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float gamma;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float hue;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float saturation;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.LayerMask layer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.AnimationCurve distanceCurve;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Ibuprogames.VideoGlitchesAsset.RenderDepth renderDepth;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float depthThreshold;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool useScaledTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float timeScale;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float customTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Shader shader;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected UnityEngine.Material material;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Texture2D distanceTexture;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string variableStrength = "_Strength";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string variableCustomTime = "_CustomTime";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string variableBrightness = "_Brightness";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string variableContrast = "_Contrast";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string variableGamma = "_Gamma";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string variableHue = "_Hue";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string variableSaturation = "_Saturation";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string variableRenderToTexture = "_RTT";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string variableDepthThreshold = "_DepthThreshold";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string variableDistanceTexture = "_DistanceTex";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string keywordModeScreen = "MODE_SCREEN";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string keywordModeLayer = "MODE_LAYER";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string keywordModeDistance = "MODE_DISTANCE";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string keywordColorControls = "COLOR_CONTROLS";
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Strength { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Ibuprogames.VideoGlitchesAsset.EffectModes EffectMode { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.LayerMask Layer { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.AnimationCurve DistanceCurve { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool EnableColorControls { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Brightness { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Contrast { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Gamma { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Hue { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Saturation { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float DepthThreshold { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool UseScaledTime { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float CustomTimeScale { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Material Material { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_Strength()
        {
            return (float)this.strength;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Strength(float value)
        {
            this.strength = UnityEngine.Mathf.Clamp01(value:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Ibuprogames.VideoGlitchesAsset.EffectModes get_EffectMode()
        {
            return (Ibuprogames.VideoGlitchesAsset.EffectModes)this.effectMode;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_EffectMode(Ibuprogames.VideoGlitchesAsset.EffectModes value)
        {
            if(this.effectMode == value)
            {
                    return;
            }
            
            this.effectMode = value;
            UnityEngine.Camera val_1 = this.GetComponent<UnityEngine.Camera>();
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if(value == 0)
            {
                goto label_3;
            }
            
            label_4:
            val_1.depthTextureMode = 1;
            this.CreateDepthCamera();
            return;
            label_2:
            if(value != 0)
            {
                goto label_4;
            }
            
            label_3:
            val_1.depthTextureMode = 0;
            this.DestroyDepthCamera();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.LayerMask get_Layer()
        {
            return (UnityEngine.LayerMask)this.layer;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Layer(UnityEngine.LayerMask value)
        {
            this.layer = value;
            if(this.renderDepth == 0)
            {
                    return;
            }
            
            this = UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask() {m_Mask = this.layer});
            this.renderDepth.layer = this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.AnimationCurve get_DistanceCurve()
        {
            return (UnityEngine.AnimationCurve)this.distanceCurve;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_DistanceCurve(UnityEngine.AnimationCurve value)
        {
            this.distanceCurve = value;
            this.UpdateDistanceCurveTexture();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_EnableColorControls()
        {
            return (bool)this.enableColorControls;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_EnableColorControls(bool value)
        {
            this.enableColorControls = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_Brightness()
        {
            return (float)this.brightness;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Brightness(float value)
        {
            this.brightness = UnityEngine.Mathf.Clamp(value:  value, min:  -1f, max:  1f);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_Contrast()
        {
            return (float)this.contrast;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Contrast(float value)
        {
            this.contrast = UnityEngine.Mathf.Clamp(value:  value, min:  -1f, max:  1f);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_Gamma()
        {
            return (float)this.gamma;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Gamma(float value)
        {
            this.gamma = UnityEngine.Mathf.Clamp(value:  value, min:  0.1f, max:  10f);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_Hue()
        {
            return (float)this.hue;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Hue(float value)
        {
            this.hue = UnityEngine.Mathf.Clamp01(value:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_Saturation()
        {
            return (float)this.saturation;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Saturation(float value)
        {
            this.saturation = UnityEngine.Mathf.Clamp(value:  value, min:  0f, max:  2f);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_DepthThreshold()
        {
            return (float)this.depthThreshold;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_DepthThreshold(float value)
        {
            this.depthThreshold = UnityEngine.Mathf.Clamp01(value:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_UseScaledTime()
        {
            return (bool)this.useScaledTime;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_UseScaledTime(bool value)
        {
            this.useScaledTime = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_CustomTimeScale()
        {
            return (float)this.timeScale;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_CustomTimeScale(float value)
        {
            this.timeScale = (value >= 0f) ? value : 0f;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsSupported()
        {
            UnityEngine.RenderTextureFormat val_5;
            if(UnityEngine.SystemInfo.supportsImageEffects == false)
            {
                goto label_7;
            }
            
            UnityEngine.Shader val_2 = UnityEngine.Resources.Load<UnityEngine.Shader>(path:  this);
            if(val_2 == 0)
            {
                goto label_7;
            }
            
            if(val_2.isSupported == false)
            {
                goto label_6;
            }
            
            UnityEngine.Resources.UnloadAsset(assetToUnload:  val_2);
            if((this & 1) == 0)
            {
                goto label_7;
            }
            
            Ibuprogames.VideoGlitchesAsset.EffectModes val_5 = this.effectMode;
            val_5 = 1;
            val_5 = val_5 - 1;
            if(val_5 > 1)
            {
                    return (bool)val_5;
            }
            
            return UnityEngine.SystemInfo.SupportsRenderTextureFormat(format:  val_5);
            label_6:
            UnityEngine.Resources.UnloadAsset(assetToUnload:  val_2);
            label_7:
            val_5 = 0;
            return (bool)val_5;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual void ResetDefaultValues()
        {
            this.strength = 1f;
            this.saturation = 1f;
            this.depthThreshold = 0.004f;
            this.useScaledTime = true;
            this.brightness = ;
            this.contrast = ;
            this.gamma = 1f;
            this.hue = 0f;
            this.timeScale = 1f;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string ToString()
        {
            return "No description.";
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual string ShaderPath()
        {
            System.Type val_1 = this.GetType();
            if(val_1 != null)
            {
                    return System.String.Format(format:  "Shaders/{0}", arg0:  val_1);
            }
            
            return System.String.Format(format:  "Shaders/{0}", arg0:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Material get_Material()
        {
            UnityEngine.Material val_7;
            if(this.material != 0)
            {
                    return (UnityEngine.Material)this.material;
            }
            
            if(this.shader == 0)
            {
                    return (UnityEngine.Material)this.material;
            }
            
            System.Type val_3 = this.GetType();
            UnityEngine.Material val_4 = new UnityEngine.Material(shader:  this.shader);
            this.material = val_4;
            if(val_4 != 0)
            {
                    val_7 = this.material;
                val_7.name = val_3;
                this.material.hideFlags = 61;
                return (UnityEngine.Material)this.material;
            }
            
            object[] val_6 = new object[1];
            val_7 = val_6;
            val_7[0] = val_3;
            UnityEngine.Debug.LogErrorFormat(format:  "[Ibuprogames.VideoGlitches] \'{0}\' material null. Please contact with \'hello@ibuprogames.com\' and send the log file.", args:  val_6);
            this.enabled = false;
            return (UnityEngine.Material)this.material;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CreateDepthCamera()
        {
            if(this.renderDepth != 0)
            {
                    return;
            }
            
            System.Type[] val_2 = new System.Type[1];
            val_2[0] = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            UnityEngine.GameObject val_4 = new UnityEngine.GameObject(name:  "VideoGlitchesDepthCamera", components:  val_2);
            if(val_4 != null)
            {
                    val_4.hideFlags = 61;
            }
            else
            {
                    0.hideFlags = 61;
            }
            
            val_4.transform.parent = this.transform;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.zero;
            val_4.transform.localPosition = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
            UnityEngine.Quaternion val_10 = UnityEngine.Quaternion.identity;
            val_4.transform.localRotation = new UnityEngine.Quaternion() {x = val_10.x, y = val_10.y, z = val_10.z, w = val_10.w};
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.one;
            val_4.transform.localScale = new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
            this.renderDepth = val_4.AddComponent<Ibuprogames.VideoGlitchesAsset.RenderDepth>();
            this = UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask() {m_Mask = this.layer});
            val_13.layer = this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void DestroyDepthCamera()
        {
            if(this.renderDepth == 0)
            {
                    return;
            }
            
            this.renderDepth = 0;
            UnityEngine.Object.DestroyImmediate(obj:  this.renderDepth.gameObject);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected abstract void SendValuesToShader(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void LoadCustomResources()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected UnityEngine.Texture2D LoadTextureFromResources(string texturePathFromResources)
        {
            UnityEngine.Texture2D val_1 = UnityEngine.Resources.Load<UnityEngine.Texture2D>(path:  texturePathFromResources);
            if(val_1 != 0)
            {
                    return val_1;
            }
            
            object[] val_3 = new object[1];
            val_3[0] = texturePathFromResources;
            UnityEngine.Debug.LogErrorFormat(format:  "[Ibuprogames.VideoGlitches] Texture \'{0}\' not found in \'Ibuprogames/VideoGlitches/Resources/Textures\' folder. Please contact with \'hello@ibuprogames.com\' and send the log file.", args:  val_3);
            this.enabled = false;
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual bool CheckHardwareRequirements()
        {
            var val_2;
            Ibuprogames.VideoGlitchesAsset.EffectModes val_2 = this.effectMode;
            val_2 = val_2 - 1;
            if(val_2 <= 1)
            {
                    val_2 = 1;
                if((UnityEngine.SystemInfo.SupportsRenderTextureFormat(format:  1)) == true)
            {
                    return (bool)val_2;
            }
            
                UnityEngine.Debug.LogWarning(message:  "[Ibuprogames.Vintage] Depth textures aren\'t supported on this device.");
                val_2 = 0;
                return (bool)val_2;
            }
            
            val_2 = 1;
            return (bool)val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateDistanceCurveTexture()
        {
            UnityEngine.Object val_10;
            UnityEngine.Texture2D val_11;
            var val_12;
            var val_13;
            val_10 = 0;
            if(this.distanceTexture != val_10)
            {
                goto label_3;
            }
            
            UnityEngine.Texture2D val_2 = null;
            val_11 = val_2;
            val_2 = new UnityEngine.Texture2D(width:  1024, height:  2);
            if(val_11 == null)
            {
                goto label_4;
            }
            
            val_2.filterMode = 1;
            val_2.wrapMode = 1;
            goto label_5;
            label_3:
            val_11 = this.distanceTexture;
            if(val_11 != null)
            {
                goto label_8;
            }
            
            goto label_7;
            label_4:
            0.filterMode = 1;
            0.wrapMode = 1;
            label_5:
            val_10 = 1;
            0.anisoLevel = 1;
            this.distanceTexture = val_11;
            if(val_11 != null)
            {
                goto label_8;
            }
            
            label_7:
            label_8:
            val_12 = public System.Int32 UnityEngine.Texture::get_width();
            val_13 = 0;
            goto label_9;
            label_16:
            UnityEngine.Color val_5 = UnityEngine.Color.white;
            float val_10 = 0f;
            val_10 = (1f / (float)val_2.width) * val_10;
            UnityEngine.Color val_8 = UnityEngine.Color.op_Multiply(a:  new UnityEngine.Color() {r = val_5.r, g = val_5.g, b = val_5.b, a = val_5.a}, b:  UnityEngine.Mathf.Clamp01(value:  this.distanceCurve.Evaluate(time:  val_10)));
            this.distanceTexture.SetPixel(x:  0, y:  0, color:  new UnityEngine.Color() {r = val_8.r, g = val_8.g, b = val_8.b, a = val_8.a});
            val_12 = val_13;
            this.distanceTexture.SetPixel(x:  0, y:  1, color:  new UnityEngine.Color() {r = val_8.r, g = val_8.g, b = val_8.b, a = val_8.a});
            val_13 = 1;
            label_9:
            if(val_13 < this.distanceTexture.width)
            {
                goto label_16;
            }
            
            this.distanceTexture.Apply();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            string val_10;
            System.Object[] val_11;
            var val_12;
            System.Object[] val_13;
            string val_14;
            val_10 = this;
            if(UnityEngine.SystemInfo.supportsImageEffects == false)
            {
                goto label_1;
            }
            
            UnityEngine.Shader val_2 = UnityEngine.Resources.Load<UnityEngine.Shader>(path:  this);
            this.shader = val_2;
            if(val_2 == 0)
            {
                goto label_4;
            }
            
            if((this.shader.isSupported == false) || ((val_10 & 1) == 0))
            {
                goto label_7;
            }
            
            val_10 = ???;
            goto typeof(Ibuprogames.VideoGlitchesAsset.VideoGlitchBase).__il2cppRuntimeField_198;
            label_1:
            object[] val_5 = new object[1];
            val_5[0] = val_10.GetType();
            val_11 = val_5;
            val_12 = "[Ibuprogames.VideoGlitches] Hardware not support Image Effects. \'{0}\' disabled.";
            goto label_15;
            label_4:
            val_13 = new object[2];
            val_13[0] = val_10;
            val_13[1] = this.GetType();
            val_14 = "[Ibuprogames.VideoGlitches] Shader \'Ibuprogames/VideoGlitches/Resources/{0}.shader\' not found. \'{1}\' disabled.";
            goto label_26;
            label_7:
            object[] val_9 = new object[1];
            val_13 = val_9;
            val_13[0] = val_10;
            val_14 = "[Ibuprogames.VideoGlitches] \'{0}\' shader not supported. Please contact with \'hello@ibuprogames.com\' and send the log file.";
            label_26:
            val_11 = val_13;
            label_15:
            UnityEngine.Debug.LogErrorFormat(format:  val_14, args:  val_9);
            this.enabled = false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnEnable()
        {
            if(this.effectMode != 0)
            {
                    if(this.renderDepth == 0)
            {
                    this.CreateDepthCamera();
            }
            
            }
            
            this.GetComponent<UnityEngine.Camera>().depthTextureMode = (this.effectMode != 0) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void OnDestroy()
        {
            if(this.material == 0)
            {
                    return;
            }
            
            UnityEngine.Object.Destroy(obj:  this.material);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            if(this.useScaledTime != false)
            {
                    float val_1 = UnityEngine.Time.deltaTime;
            }
            else
            {
                    float val_2 = UnityEngine.Time.unscaledDeltaTime;
            }
            
            val_2 = val_2 * this.timeScale;
            val_2 = this.customTime + val_2;
            this.customTime = val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnRenderImage(UnityEngine.RenderTexture source, UnityEngine.RenderTexture destination)
        {
            string val_6;
            if(this.Material == 0)
            {
                goto label_3;
            }
            
            this.material.shaderKeywords = 0;
            this.material.SetFloat(name:  "_Strength", value:  this.strength);
            float val_6 = 20f;
            float val_7 = 3f;
            val_6 = this.customTime / val_6;
            float val_3 = this.customTime + this.customTime;
            val_7 = this.customTime * val_7;
            val_6 = "_CustomTime";
            this.material.SetVector(name:  val_6, value:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
            if(this.effectMode == 0)
            {
                goto label_7;
            }
            
            if(this.effectMode == 1)
            {
                goto label_8;
            }
            
            if(this.effectMode != 2)
            {
                goto label_19;
            }
            
            this.material.EnableKeyword(keyword:  "MODE_DISTANCE");
            if(this.distanceTexture == 0)
            {
                    this.UpdateDistanceCurveTexture();
            }
            
            val_6 = "_DistanceTex";
            this.material.SetTexture(name:  val_6, value:  this.distanceTexture);
            goto label_19;
            label_3:
            UnityEngine.Graphics.Blit(source:  source, dest:  destination);
            return;
            label_7:
            val_6 = "MODE_SCREEN";
            this.material.EnableKeyword(keyword:  val_6);
            goto label_19;
            label_8:
            this.material.EnableKeyword(keyword:  "MODE_LAYER");
            if(this.renderDepth != 0)
            {
                    this.material.SetTexture(name:  "_RTT", value:  this.renderDepth.renderTexture);
            }
            
            val_6 = "_DepthThreshold";
            this.material.SetFloat(name:  val_6, value:  this.depthThreshold);
            label_19:
            if((this.enableColorControls != false) && (this.strength > 0f))
            {
                    this.material.EnableKeyword(keyword:  "COLOR_CONTROLS");
                this.material.SetFloat(name:  "_Brightness", value:  this.brightness);
                this.material.SetFloat(name:  "_Contrast", value:  this.contrast);
                float val_8 = 1f;
                val_8 = val_8 / this.gamma;
                this.material.SetFloat(name:  "_Gamma", value:  val_8);
                this.material.SetFloat(name:  "_Hue", value:  this.hue);
                val_6 = "_Saturation";
                this.material.SetFloat(name:  val_6, value:  this.saturation);
            }
            
            UnityEngine.Graphics.Blit(source:  source, dest:  destination, mat:  this.material);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected VideoGlitchBase()
        {
            this.strength = 1f;
            this.gamma = 1f;
            this.saturation = 1f;
            UnityEngine.LayerMask val_1 = UnityEngine.LayerMask.op_Implicit(intVal:  0);
            this.layer = val_1;
            UnityEngine.Keyframe[] val_2 = new UnityEngine.Keyframe[2];
            val_2[0] = 0;
            val_2[0] = 0;
            val_2[1] = 0;
            val_2[1] = 0;
            this.distanceCurve = new UnityEngine.AnimationCurve(keys:  val_2);
            this.depthThreshold = 0.004f;
            this.useScaledTime = true;
            this.timeScale = 1f;
        }
    
    }

}
