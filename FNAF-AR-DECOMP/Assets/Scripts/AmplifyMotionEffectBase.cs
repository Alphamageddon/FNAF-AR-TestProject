using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AmplifyMotionEffectBase : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AmplifyMotion.Quality QualityLevel;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int QualitySteps;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float MotionScale;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float CameraMotionMult;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float ObjectMotionMult;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float MinVelocity;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float MaxVelocity;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float DepthThreshold;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Noise;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Camera[] OverlayCameras;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.LayerMask CullingMask;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool AutoRegisterObjs;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float MinResetDeltaDist;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float MinResetDeltaDistSqr;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int ResetFrameDelay;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int WorkerThreads;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool SystemThreadPool;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool ForceCPUOnly;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool DebugMode;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Camera m_camera;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool m_starting;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int m_width;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int m_height;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.RenderTexture m_motionRT;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Material m_blurMaterial;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Material m_solidVectorsMaterial;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Material m_skinnedVectorsMaterial;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Material m_clothVectorsMaterial;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Material m_reprojectionMaterial;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Material m_combineMaterial;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Material m_dilationMaterial;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Material m_depthMaterial;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Material m_debugMaterial;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Collections.Generic.Dictionary<UnityEngine.Camera, AmplifyMotionCamera> m_linkedCameras;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal UnityEngine.Camera[] m_linkedCameraKeys;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal AmplifyMotionCamera[] m_linkedCameraValues;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal bool m_linkedCamerasChanged;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private AmplifyMotionPostProcess m_currentPostProcess;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int m_globalObjectId;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private float m_deltaTime;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private float m_fixedDeltaTime;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private float m_motionScaleNorm;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private float m_fixedMotionScaleNorm;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private AmplifyMotion.Quality m_qualityLevel;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private AmplifyMotionCamera m_baseCamera;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private AmplifyMotion.WorkerThreadPool m_workerThreadPool;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static System.Collections.Generic.Dictionary<UnityEngine.GameObject, AmplifyMotionObjectBase> m_activeObjects;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static System.Collections.Generic.Dictionary<UnityEngine.Camera, AmplifyMotionCamera> m_activeCameras;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static bool m_isD3D;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool m_canUseGPU;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private const UnityEngine.Rendering.CameraEvent m_updateCBEvent = 12;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Rendering.CommandBuffer m_updateCB;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private const UnityEngine.Rendering.CameraEvent m_fixedUpdateCBEvent = 12;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Rendering.CommandBuffer m_fixedUpdateCB;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static bool m_ignoreMotionScaleWarning;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static AmplifyMotionEffectBase m_firstInstance;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int workerThreads { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal UnityEngine.Material ReprojectionMaterial { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal UnityEngine.Material SolidVectorsMaterial { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal UnityEngine.Material SkinnedVectorsMaterial { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal UnityEngine.Material ClothVectorsMaterial { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal UnityEngine.RenderTexture MotionRenderTexture { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Collections.Generic.Dictionary<UnityEngine.Camera, AmplifyMotionCamera> LinkedCameras { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal float MotionScaleNorm { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal float FixedMotionScaleNorm { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AmplifyMotionCamera BaseCamera { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal AmplifyMotion.WorkerThreadPool WorkerPool { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static bool IsD3D { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool CanUseGPU { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static bool IgnoreMotionScaleWarning { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AmplifyMotionEffectBase FirstInstance { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AmplifyMotionEffectBase Instance { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int get_workerThreads()
    {
        return (int)this.WorkerThreads;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_workerThreads(int value)
    {
        this.WorkerThreads = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal UnityEngine.Material get_ReprojectionMaterial()
    {
        return (UnityEngine.Material)this.m_reprojectionMaterial;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal UnityEngine.Material get_SolidVectorsMaterial()
    {
        return (UnityEngine.Material)this.m_solidVectorsMaterial;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal UnityEngine.Material get_SkinnedVectorsMaterial()
    {
        return (UnityEngine.Material)this.m_skinnedVectorsMaterial;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal UnityEngine.Material get_ClothVectorsMaterial()
    {
        return (UnityEngine.Material)this.m_clothVectorsMaterial;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal UnityEngine.RenderTexture get_MotionRenderTexture()
    {
        return (UnityEngine.RenderTexture)this.m_motionRT;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Collections.Generic.Dictionary<UnityEngine.Camera, AmplifyMotionCamera> get_LinkedCameras()
    {
        return (System.Collections.Generic.Dictionary<UnityEngine.Camera, AmplifyMotionCamera>)this.m_linkedCameras;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal float get_MotionScaleNorm()
    {
        return (float)this.m_motionScaleNorm;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal float get_FixedMotionScaleNorm()
    {
        return (float)this.m_fixedMotionScaleNorm;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AmplifyMotionCamera get_BaseCamera()
    {
        return (AmplifyMotionCamera)this.m_baseCamera;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal AmplifyMotion.WorkerThreadPool get_WorkerPool()
    {
        return (AmplifyMotion.WorkerThreadPool)this.m_workerThreadPool;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static bool get_IsD3D()
    {
        null = null;
        return (bool)AmplifyMotionEffectBase.m_isD3D;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool get_CanUseGPU()
    {
        return (bool)this.m_canUseGPU;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static bool get_IgnoreMotionScaleWarning()
    {
        null = null;
        return (bool)AmplifyMotionEffectBase.m_ignoreMotionScaleWarning;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AmplifyMotionEffectBase get_FirstInstance()
    {
        null = null;
        return (AmplifyMotionEffectBase)AmplifyMotionEffectBase.m_firstInstance;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AmplifyMotionEffectBase get_Instance()
    {
        null = null;
        return (AmplifyMotionEffectBase)AmplifyMotionEffectBase.m_firstInstance;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Awake()
    {
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        bool val_16;
        val_12 = 1152921505073831936;
        val_13 = null;
        val_13 = null;
        if(AmplifyMotionEffectBase.m_firstInstance == 0)
        {
                val_14 = null;
            val_14 = null;
            AmplifyMotionEffectBase.m_firstInstance = this;
        }
        
        val_15 = null;
        val_15 = null;
        AmplifyMotionEffectBase.m_isD3D = UnityEngine.SystemInfo.graphicsDeviceVersion.StartsWith(value:  "Direct3D");
        this.m_globalObjectId = 1;
        this.m_width = 0;
        this.m_height = 0;
        if(this.ForceCPUOnly != false)
        {
                val_16 = 0;
        }
        else
        {
                val_12 = UnityEngine.SystemInfo.SupportsTextureFormat(format:  16);
            bool val_11 = ((UnityEngine.SystemInfo.graphicsShaderLevel > 29) ? 1 : 0) & (UnityEngine.SystemInfo.SupportsTextureFormat(format:  15));
            val_11 = val_11 & val_12;
            val_11 = val_11 & (UnityEngine.SystemInfo.SupportsTextureFormat(format:  17));
            val_16 = val_11 & (UnityEngine.SystemInfo.SupportsRenderTextureFormat(format:  11));
        }
        
        this.m_canUseGPU = val_16;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal void ResetObjectId()
    {
        this.m_globalObjectId = 1;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal int GenerateObjectId(UnityEngine.GameObject obj)
    {
        var val_4;
        if(obj.isStatic != false)
        {
                val_4 = 0;
            return val_3;
        }
        
        int val_3 = ((this.m_globalObjectId + 1) > 254) ? 1 : (this.m_globalObjectId + 1);
        this.m_globalObjectId = val_3;
        return val_3;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void SafeDestroyMaterial(ref UnityEngine.Material mat)
    {
        if(mat == 0)
        {
                return;
        }
        
        UnityEngine.Object.DestroyImmediate(obj:  mat);
        mat = 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool CheckMaterialAndShader(UnityEngine.Material material, string name)
    {
        if(material != 0)
        {
                if(material.shader != 0)
        {
            goto label_7;
        }
        
        }
        
        label_14:
        UnityEngine.Debug.LogWarning(message:  "[AmplifyMotion] Error creating " + name + " material");
        return false;
        label_7:
        if(material.shader.isSupported == false)
        {
            goto label_14;
        }
        
        return false;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void DestroyMaterials()
    {
        this.SafeDestroyMaterial(mat: ref  this.m_blurMaterial);
        this.SafeDestroyMaterial(mat: ref  this.m_solidVectorsMaterial);
        this.SafeDestroyMaterial(mat: ref  this.m_skinnedVectorsMaterial);
        this.SafeDestroyMaterial(mat: ref  this.m_clothVectorsMaterial);
        this.SafeDestroyMaterial(mat: ref  this.m_reprojectionMaterial);
        this.SafeDestroyMaterial(mat: ref  this.m_combineMaterial);
        this.SafeDestroyMaterial(mat: ref  this.m_dilationMaterial);
        this.SafeDestroyMaterial(mat: ref  this.m_depthMaterial);
        this.SafeDestroyMaterial(mat: ref  this.m_debugMaterial);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool CreateMaterials()
    {
        var val_31;
        this.DestroyMaterials();
        string val_3 = "Hidden/Amplify Motion/MotionBlurSM"("Hidden/Amplify Motion/MotionBlurSM") + (UnityEngine.SystemInfo.graphicsShaderLevel > 29) ? (2 + 1) : 2((UnityEngine.SystemInfo.graphicsShaderLevel > 29) ? (2 + 1) : 2);
        new UnityEngine.Material() = new UnityEngine.Material(shader:  UnityEngine.Shader.Find(name:  val_3));
        new UnityEngine.Material().hideFlags = 52;
        this.m_blurMaterial = new UnityEngine.Material();
        new UnityEngine.Material() = new UnityEngine.Material(shader:  UnityEngine.Shader.Find(name:  "Hidden/Amplify Motion/SolidVectors"));
        new UnityEngine.Material().hideFlags = 52;
        this.m_solidVectorsMaterial = new UnityEngine.Material();
        new UnityEngine.Material() = new UnityEngine.Material(shader:  UnityEngine.Shader.Find(name:  "Hidden/Amplify Motion/SkinnedVectors"));
        new UnityEngine.Material().hideFlags = 52;
        this.m_skinnedVectorsMaterial = new UnityEngine.Material();
        new UnityEngine.Material() = new UnityEngine.Material(shader:  UnityEngine.Shader.Find(name:  "Hidden/Amplify Motion/ClothVectors"));
        new UnityEngine.Material().hideFlags = 52;
        this.m_clothVectorsMaterial = new UnityEngine.Material();
        new UnityEngine.Material() = new UnityEngine.Material(shader:  UnityEngine.Shader.Find(name:  "Hidden/Amplify Motion/ReprojectionVectors"));
        new UnityEngine.Material().hideFlags = 52;
        this.m_reprojectionMaterial = new UnityEngine.Material();
        new UnityEngine.Material() = new UnityEngine.Material(shader:  UnityEngine.Shader.Find(name:  "Hidden/Amplify Motion/Combine"));
        new UnityEngine.Material().hideFlags = 52;
        this.m_combineMaterial = new UnityEngine.Material();
        new UnityEngine.Material() = new UnityEngine.Material(shader:  UnityEngine.Shader.Find(name:  "Hidden/Amplify Motion/Dilation"));
        new UnityEngine.Material().hideFlags = 52;
        this.m_dilationMaterial = new UnityEngine.Material();
        new UnityEngine.Material() = new UnityEngine.Material(shader:  UnityEngine.Shader.Find(name:  "Hidden/Amplify Motion/Depth"));
        new UnityEngine.Material().hideFlags = 52;
        this.m_depthMaterial = new UnityEngine.Material();
        new UnityEngine.Material() = new UnityEngine.Material(shader:  UnityEngine.Shader.Find(name:  "Hidden/Amplify Motion/Debug"));
        val_31 = new UnityEngine.Material();
        new UnityEngine.Material().hideFlags = 52;
        this.m_debugMaterial = new UnityEngine.Material();
        bool val_22 = new UnityEngine.Material().CheckMaterialAndShader(material:  new UnityEngine.Material(), name:  val_3);
        if(val_22 == false)
        {
            goto label_17;
        }
        
        bool val_23 = val_22.CheckMaterialAndShader(material:  this.m_solidVectorsMaterial, name:  "Hidden/Amplify Motion/SolidVectors");
        if(val_23 == false)
        {
            goto label_17;
        }
        
        bool val_24 = val_23.CheckMaterialAndShader(material:  this.m_skinnedVectorsMaterial, name:  "Hidden/Amplify Motion/SkinnedVectors");
        if(val_24 == false)
        {
            goto label_17;
        }
        
        bool val_25 = val_24.CheckMaterialAndShader(material:  this.m_clothVectorsMaterial, name:  "Hidden/Amplify Motion/ClothVectors");
        if(val_25 == false)
        {
            goto label_17;
        }
        
        bool val_26 = val_25.CheckMaterialAndShader(material:  this.m_reprojectionMaterial, name:  "Hidden/Amplify Motion/ReprojectionVectors");
        if(val_26 == false)
        {
            goto label_17;
        }
        
        bool val_27 = val_26.CheckMaterialAndShader(material:  this.m_combineMaterial, name:  "Hidden/Amplify Motion/Combine");
        if(val_27 == false)
        {
            goto label_17;
        }
        
        bool val_28 = val_27.CheckMaterialAndShader(material:  this.m_dilationMaterial, name:  "Hidden/Amplify Motion/Dilation");
        if(val_28 == false)
        {
            goto label_17;
        }
        
        bool val_29 = val_28.CheckMaterialAndShader(material:  this.m_depthMaterial, name:  "Hidden/Amplify Motion/Depth");
        if(val_29 == false)
        {
            goto label_17;
        }
        
        bool val_30 = val_29.CheckMaterialAndShader(material:  this.m_debugMaterial, name:  "Hidden/Amplify Motion/Debug");
        goto label_18;
        label_17:
        val_31 = 0;
        label_18:
        val_31 = val_31 & 1;
        return (bool)val_31;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.RenderTexture CreateRenderTexture(string name, int depth, UnityEngine.RenderTextureFormat fmt, UnityEngine.RenderTextureReadWrite rw, UnityEngine.FilterMode fm)
    {
        UnityEngine.RenderTexture val_1 = new UnityEngine.RenderTexture(width:  this.m_width, height:  this.m_height, depth:  depth, format:  fmt, readWrite:  rw);
        if(val_1 != null)
        {
                val_1.hideFlags = 52;
            val_1.name = name;
            val_1.wrapMode = 1;
            val_1.filterMode = fm;
        }
        else
        {
                0.hideFlags = 52;
            0.name = name;
            0.wrapMode = 1;
            0.filterMode = fm;
        }
        
        bool val_2 = val_1.Create();
        return val_1;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void SafeDestroyRenderTexture(ref UnityEngine.RenderTexture rt)
    {
        if(rt == 0)
        {
                return;
        }
        
        UnityEngine.RenderTexture.active = 0;
        rt.Release();
        UnityEngine.Object.DestroyImmediate(obj:  rt);
        rt = 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void SafeDestroyTexture(ref UnityEngine.Texture tex)
    {
        if(tex == 0)
        {
                return;
        }
        
        UnityEngine.Object.DestroyImmediate(obj:  tex);
        tex = 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void DestroyRenderTextures()
    {
        UnityEngine.RenderTexture.active = 0;
        this.SafeDestroyRenderTexture(rt: ref  this.m_motionRT);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void UpdateRenderTextures(bool qualityChanged)
    {
        int val_12;
        int val_13;
        UnityEngine.RenderTexture val_14;
        float val_12 = (float)this.m_camera.pixelWidth;
        val_12 = val_12 + 0.5f;
        val_12 = UnityEngine.Mathf.Max(a:  UnityEngine.Mathf.FloorToInt(f:  val_12), b:  1);
        float val_13 = (float)this.m_camera.pixelHeight;
        val_13 = val_13 + 0.5f;
        val_13 = 0;
        int val_6 = UnityEngine.Mathf.Max(a:  UnityEngine.Mathf.FloorToInt(f:  val_13), b:  1);
        if(this.QualityLevel == 0)
        {
                val_12 = ((val_12 < 0) ? (val_12 + 1) : (val_12)) >> 1;
            val_13 = ((val_6 < 0) ? (val_6 + 1) : (val_6)) >> 1;
        }
        
        if((this.m_width == val_12) && (this.m_height == val_13))
        {
                val_14 = this.m_motionRT;
        }
        else
        {
                this.m_width = val_12;
            this.m_height = val_13;
            UnityEngine.RenderTexture.active = 0;
            val_14 = this.m_motionRT;
            this.SafeDestroyRenderTexture(rt: ref  val_14);
        }
        
        if(mem[this.m_motionRT] != 0)
        {
                return;
        }
        
        this.m_motionRT = this.CreateRenderTexture(name:  "AM-MotionVectors", depth:  24, fmt:  0, rw:  1, fm:  0);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool CheckSupport()
    {
        var val_2;
        if(UnityEngine.SystemInfo.supportsImageEffects != false)
        {
                val_2 = 1;
            return (bool)val_2;
        }
        
        UnityEngine.Debug.LogError(message:  "[AmplifyMotion] Initialization failed. This plugin requires support for Image Effects and Render Textures.");
        val_2 = 0;
        return (bool)val_2;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void InitializeThreadPool()
    {
        if(this.WorkerThreads <= 0)
        {
                int val_1 = System.Environment.ProcessorCount;
            this.WorkerThreads = UnityEngine.Mathf.Max(a:  ((val_1 < 0) ? (val_1 + 1) : (val_1)) >> 1, b:  1);
        }
        
        AmplifyMotion.WorkerThreadPool val_5 = new AmplifyMotion.WorkerThreadPool();
        this.m_workerThreadPool = val_5;
        val_5.InitializeAsyncUpdateThreads(threadCount:  this.WorkerThreads, systemThreadPool:  (this.SystemThreadPool == true) ? 1 : 0);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void ShutdownThreadPool()
    {
        if(this.m_workerThreadPool == null)
        {
                return;
        }
        
        this.m_workerThreadPool.FinalizeAsyncUpdateThreads();
        this.m_workerThreadPool = 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void InitializeCommandBuffers()
    {
        this.ShutdownCommandBuffers();
        UnityEngine.Rendering.CommandBuffer val_1 = new UnityEngine.Rendering.CommandBuffer();
        this.m_updateCB = val_1;
        val_1.name = "AmplifyMotion.Update";
        this.m_camera.AddCommandBuffer(evt:  12, buffer:  this.m_updateCB);
        UnityEngine.Rendering.CommandBuffer val_2 = new UnityEngine.Rendering.CommandBuffer();
        this.m_fixedUpdateCB = val_2;
        val_2.name = "AmplifyMotion.FixedUpdate";
        this.m_camera.AddCommandBuffer(evt:  12, buffer:  this.m_fixedUpdateCB);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void ShutdownCommandBuffers()
    {
        if(this.m_updateCB != null)
        {
                this.m_camera.RemoveCommandBuffer(evt:  12, buffer:  this.m_updateCB);
            this.m_updateCB.Release();
            this.m_updateCB = 0;
        }
        
        if(this.m_fixedUpdateCB == null)
        {
                return;
        }
        
        this.m_camera.RemoveCommandBuffer(evt:  12, buffer:  this.m_fixedUpdateCB);
        this.m_fixedUpdateCB.Release();
        this.m_fixedUpdateCB = 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void OnEnable()
    {
        object val_8;
        UnityEngine.Camera val_1 = this.GetComponent<UnityEngine.Camera>();
        this.m_camera = val_1;
        if(val_1.CheckSupport() == false)
        {
            goto label_1;
        }
        
        this.InitializeThreadPool();
        this.m_starting = true;
        bool val_3 = this.CreateMaterials();
        if(val_3 == false)
        {
            goto label_2;
        }
        
        if(this.AutoRegisterObjs != false)
        {
                val_3.UpdateActiveObjects();
        }
        
        this.InitializeCameras();
        this.InitializeCommandBuffers();
        this.UpdateRenderTextures(qualityChanged:  false);
        bool val_5 = this.m_linkedCameras.TryGetValue(key:  this.m_camera, value: out  this.m_baseCamera);
        if(mem[this.m_baseCamera] != 0)
        {
            goto label_7;
        }
        
        val_8 = "[AmplifyMotion] Failed setting up Base Camera. Please contact support@amplify.pt";
        goto label_10;
        label_2:
        val_8 = "[AmplifyMotion] Failed loading or compiling necessary shaders. Please try reinstalling Amplify Motion or contact support@amplify.pt";
        label_10:
        UnityEngine.Debug.LogError(message:  val_8);
        label_1:
        this.enabled = false;
        return;
        label_7:
        if(this.m_currentPostProcess != 0)
        {
                this.m_currentPostProcess.enabled = true;
        }
        
        this.m_qualityLevel = this.QualityLevel;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void OnDisable()
    {
        if(this.m_currentPostProcess != 0)
        {
                this.m_currentPostProcess.enabled = false;
        }
        
        this.ShutdownCommandBuffers();
        if(this.m_workerThreadPool == null)
        {
                return;
        }
        
        this.m_workerThreadPool.FinalizeAsyncUpdateThreads();
        this.m_workerThreadPool = 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Start()
    {
        this.UpdatePostProcess();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal void RemoveCamera(UnityEngine.Camera reference)
    {
        bool val_1 = this.m_linkedCameras.Remove(key:  reference);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void OnDestroy()
    {
        goto label_2;
        label_19:
        TSource val_10 = System.Linq.Enumerable.ToArray<AmplifyMotionCamera>(source:  this.m_linkedCameras.Values)[0];
        if((val_10 != 0) && (val_10.gameObject != this.gameObject))
        {
                UnityEngine.Camera val_7 = val_10.GetComponent<UnityEngine.Camera>();
            if(val_7 != 0)
        {
                val_7.targetTexture = 0;
        }
        
            UnityEngine.Object.DestroyImmediate(obj:  val_10);
        }
        
        0 = 1;
        label_2:
        if(0 < val_2.Length)
        {
            goto label_19;
        }
        
        UnityEngine.RenderTexture.active = 0;
        this.SafeDestroyRenderTexture(rt: ref  this.m_motionRT);
        this.DestroyMaterials();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.GameObject RecursiveFindCamera(UnityEngine.GameObject obj, string auxCameraName)
    {
        var val_12;
        UnityEngine.Object val_13;
        UnityEngine.Object val_14;
        var val_15;
        var val_18;
        val_13 = obj;
        val_14 = this;
        if((System.String.op_Equality(a:  val_13.name, b:  auxCameraName)) == true)
        {
                return (UnityEngine.GameObject)val_13;
        }
        
        System.Collections.IEnumerator val_4 = val_13.transform.GetEnumerator();
        val_15 = 0;
        label_22:
        var val_14 = 0;
        val_14 = val_14 + 1;
        if(val_4.MoveNext() == false)
        {
            goto label_10;
        }
        
        var val_15 = 0;
        val_15 = val_15 + 1;
        object val_8 = val_4.Current;
        UnityEngine.GameObject val_11 = 0.gameObject;
        val_13 = val_14;
        if(this == 0)
        {
            goto label_22;
        }
        
        val_18 = 0;
        val_14 = 98;
        goto label_23;
        label_10:
        val_18 = 0;
        val_14 = 98;
        val_13 = val_15;
        label_23:
        val_12 = val_4;
        if(val_12 != null)
        {
                var val_16 = 0;
            val_16 = val_16 + 1;
            val_12.Dispose();
        }
        
        if( == 98)
        {
                return (UnityEngine.GameObject)val_13;
        }
        
        if( == false)
        {
                return (UnityEngine.GameObject)val_13;
        }
        
        return (UnityEngine.GameObject)val_13;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void InitializeCameras()
    {
        var val_15;
        var val_16;
        UnityEngine.Camera val_17;
        bool val_18;
        var val_19;
        var val_20;
        System.Collections.Generic.Dictionary<UnityEngine.Camera, AmplifyMotionCamera> val_21;
        System.Collections.Generic.Dictionary<UnityEngine.Camera, AmplifyMotionCamera> val_22;
        UnityEngine.Object val_23;
        System.Collections.Generic.List<UnityEngine.Camera> val_1 = new System.Collections.Generic.List<UnityEngine.Camera>(capacity:  this.OverlayCameras.Length);
        val_15 = 0;
        goto label_2;
        label_12:
        if(this.OverlayCameras[0] != 0)
        {
                val_1.Add(item:  this.OverlayCameras[0]);
        }
        
        val_15 = 1;
        label_2:
        if(val_15 < this.OverlayCameras.Length)
        {
            goto label_12;
        }
        
        val_16 = 1152921519041354288;
        int val_4 = val_1.Count + 1;
        UnityEngine.Camera[] val_5 = new UnityEngine.Camera[0];
        val_17 = this.m_camera;
        if(val_5 == null)
        {
            goto label_14;
        }
        
        if(val_17 != null)
        {
            goto label_15;
        }
        
        goto label_18;
        label_14:
        if(val_17 == null)
        {
            goto label_18;
        }
        
        label_15:
        label_18:
        val_18 = 1152921519041363504;
        val_19 = 0;
        val_20 = 1;
        goto label_20;
        label_26:
        val_17 = val_1.Item[1152921519041234480];
        val_19 = 1;
        val_20 = 2;
        label_20:
        val_21 = val_20 - 1;
        val_5[val_19] = val_17;
        if(val_21 < val_1.Count)
        {
            goto label_26;
        }
        
        val_22 = this.m_linkedCameras;
        val_22.Clear();
        if(val_5.Length < 1)
        {
                return;
        }
        
        val_16 = 1152921519041373744;
        val_18 = true;
        label_45:
        val_22 = val_5[0];
        if((this.m_linkedCameras.ContainsKey(key:  val_22)) == true)
        {
            goto label_31;
        }
        
        val_23 = val_22.gameObject.GetComponent<AmplifyMotionCamera>();
        if(val_23 == 0)
        {
            goto label_36;
        }
        
        if(val_23 == null)
        {
            goto label_37;
        }
        
        val_23.enabled = false;
        goto label_38;
        label_36:
        val_23 = val_22.gameObject.AddComponent<AmplifyMotionCamera>();
        if(val_23 != null)
        {
            goto label_43;
        }
        
        goto label_42;
        label_37:
        0.enabled = false;
        label_38:
        0.enabled = true;
        if(val_23 != null)
        {
            goto label_43;
        }
        
        label_42:
        label_43:
        val_23.LinkTo(instance:  this, overlay:  (0 > 0) ? 1 : 0);
        val_21 = this.m_linkedCameras;
        val_21.Add(key:  val_22, value:  val_23);
        this.m_linkedCamerasChanged = val_18;
        label_31:
        if((0 + 1) < val_5.Length)
        {
            goto label_45;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void UpdateActiveCameras()
    {
        this.InitializeCameras();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal static void RegisterCamera(AmplifyMotionCamera cam)
    {
        AmplifyMotionCamera val_8;
        var val_9;
        var val_10;
        var val_11;
        val_8 = cam;
        val_9 = null;
        val_9 = null;
        if((AmplifyMotionEffectBase.m_activeCameras.ContainsValue(value:  val_8)) != true)
        {
                val_10 = null;
            val_10 = null;
            AmplifyMotionEffectBase.m_activeCameras.Add(key:  val_8.GetComponent<UnityEngine.Camera>(), value:  val_8);
        }
        
        val_11 = null;
        val_11 = null;
        Dictionary.ValueCollection.Enumerator<TKey, TValue> val_4 = AmplifyMotionEffectBase.m_fixedUpdateCBEvent.Values.GetEnumerator();
        label_15:
        if((1550125000 & 1) == 0)
        {
            goto label_13;
        }
        
        0.emailUIDataHandler.RegisterCamera(camera:  val_8);
        goto label_15;
        label_13:
        long val_6 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519041873864});
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal static void UnregisterCamera(AmplifyMotionCamera cam)
    {
        var val_8;
        var val_9;
        val_8 = null;
        val_8 = null;
        Dictionary.ValueCollection.Enumerator<TKey, TValue> val_2 = AmplifyMotionEffectBase.m_fixedUpdateCBEvent.Values.GetEnumerator();
        label_7:
        if((1550277944 & 1) == 0)
        {
            goto label_5;
        }
        
        0.emailUIDataHandler.UnregisterCamera(camera:  cam);
        goto label_7;
        label_5:
        long val_4 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519042026808});
        val_9 = null;
        val_9 = null;
        bool val_7 = AmplifyMotionEffectBase.m_activeCameras.Remove(key:  cam.GetComponent<UnityEngine.Camera>());
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void UpdateActiveObjects()
    {
        var val_4;
        var val_5;
        val_4 = 0;
        goto label_5;
        label_15:
        val_5 = null;
        val_5 = null;
        if((AmplifyMotionEffectBase.m_fixedUpdateCBEvent.ContainsKey(key:  UnityEngine.Object.FindObjectsOfType(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))[0])) != true)
        {
                AmplifyMotionEffectBase.TryRegister(gameObj:  val_2[0x0] + 32, autoReg:  true);
        }
        
        val_4 = 1;
        label_5:
        if(val_4 < val_2.Length)
        {
            goto label_15;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal static void RegisterObject(AmplifyMotionObjectBase obj)
    {
        AmplifyMotionObjectBase val_7;
        var val_8;
        val_7 = obj;
        val_8 = null;
        val_8 = null;
        AmplifyMotionEffectBase.m_fixedUpdateCBEvent.Add(key:  val_7.gameObject, value:  val_7);
        Dictionary.ValueCollection.Enumerator<TKey, TValue> val_3 = AmplifyMotionEffectBase.m_activeCameras.Values.GetEnumerator();
        label_9:
        if((1550639176 & 1) == 0)
        {
            goto label_7;
        }
        
        val_7.RegisterCamera(camera:  0.emailUIDataHandler);
        goto label_9;
        label_7:
        long val_5 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519042388040});
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal static void UnregisterObject(AmplifyMotionObjectBase obj)
    {
        var val_8;
        var val_9;
        val_8 = null;
        val_8 = null;
        Dictionary.ValueCollection.Enumerator<TKey, TValue> val_2 = AmplifyMotionEffectBase.m_activeCameras.Values.GetEnumerator();
        label_7:
        if((1550793144 & 1) == 0)
        {
            goto label_5;
        }
        
        obj.UnregisterCamera(camera:  0.emailUIDataHandler);
        goto label_7;
        label_5:
        long val_4 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519042542008});
        val_9 = null;
        val_9 = null;
        bool val_7 = AmplifyMotionEffectBase.m_fixedUpdateCBEvent.Remove(key:  obj.gameObject);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal static bool FindValidTag(UnityEngine.Material[] materials)
    {
        var val_8;
        var val_9;
        val_8 = 0;
        goto label_1;
        label_10:
        UnityEngine.Material val_7 = materials[0];
        if(val_7 == 0)
        {
            goto label_5;
        }
        
        string val_2 = val_7.GetTag(tag:  "RenderType", searchFallbacks:  false);
        if(((System.String.op_Equality(a:  val_2, b:  "Opaque")) == true) || ((System.String.op_Equality(a:  val_2, b:  "TransparentCutout")) == true))
        {
            goto label_8;
        }
        
        label_5:
        val_8 = 1;
        label_1:
        if(val_8 < materials.Length)
        {
            goto label_10;
        }
        
        goto label_11;
        label_8:
        if((val_7.IsKeywordEnabled(keyword:  "_ALPHABLEND_ON")) == false)
        {
            goto label_13;
        }
        
        label_11:
        val_9 = 0;
        goto label_14;
        label_13:
        bool val_6 = val_7.IsKeywordEnabled(keyword:  "_ALPHAPREMULTIPLY_ON");
        val_9 = val_6 ^ 1;
        label_14:
        val_6 = val_9;
        return (bool)val_6;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal static bool CanRegister(UnityEngine.GameObject gameObj, bool autoReg)
    {
        System.Type val_24;
        var val_25;
        if(gameObj.isStatic != true)
        {
                UnityEngine.Renderer val_2 = gameObj.GetComponent<UnityEngine.Renderer>();
            if(val_2 != 0)
        {
                if(val_2.sharedMaterials == null)
        {
                return (bool)val_25;
        }
        
            if(((val_2.isPartOfStaticBatch != true) && (val_2.enabled != false)) && (val_2.shadowCastingMode != 3))
        {
                val_24 = val_2.GetType();
            if((System.Type.op_Equality(left:  val_24, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) != true)
        {
                val_24 = val_2.sharedMaterials;
            if((AmplifyMotionEffectBase.FindValidTag(materials:  val_24)) != false)
        {
                val_24 = val_2.GetType();
            if((System.Type.op_Equality(left:  val_24, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) != true)
        {
                if((System.Type.op_Equality(left:  val_24, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
        {
            goto label_29;
        }
        
        }
        
            val_25 = 1;
            return (bool)val_25;
        }
        
        }
        
        }
        
        }
        
        }
        
        val_25 = 0;
        return (bool)val_25;
        label_29:
        if((System.Type.op_Equality(left:  val_24, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
        {
                return (bool)val_25;
        }
        
        if(autoReg == true)
        {
                return (bool)val_25;
        }
        
        if(val_2 != null)
        {
                var val_20 = (null == null) ? (val_2) : 0;
        }
        
        var val_23 = ((0.renderMode | 4) == 4) ? 1 : 0;
        return (bool)val_25;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal static void TryRegister(UnityEngine.GameObject gameObj, bool autoReg)
    {
        var val_5;
        autoReg = autoReg;
        if((AmplifyMotionEffectBase.CanRegister(gameObj:  gameObj, autoReg:  autoReg)) == false)
        {
                return;
        }
        
        if((gameObj.GetComponent<AmplifyMotionObjectBase>()) != 0)
        {
                return;
        }
        
        val_5 = null;
        val_5 = null;
        AmplifyMotionObjectBase.ApplyToChildren = false;
        AmplifyMotionObjectBase val_4 = gameObj.AddComponent<AmplifyMotionObjectBase>();
        AmplifyMotionObjectBase.ApplyToChildren = true;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal static void TryUnregister(UnityEngine.GameObject gameObj)
    {
        AmplifyMotionObjectBase val_1 = gameObj.GetComponent<AmplifyMotionObjectBase>();
        if(val_1 == 0)
        {
                return;
        }
        
        UnityEngine.Object.Destroy(obj:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Register(UnityEngine.GameObject gameObj)
    {
        null = null;
        if((AmplifyMotionEffectBase.m_fixedUpdateCBEvent.ContainsKey(key:  gameObj)) != false)
        {
                return;
        }
        
        AmplifyMotionEffectBase.TryRegister(gameObj:  gameObj, autoReg:  false);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void RegisterS(UnityEngine.GameObject gameObj)
    {
        null = null;
        if((AmplifyMotionEffectBase.m_fixedUpdateCBEvent.ContainsKey(key:  gameObj)) != false)
        {
                return;
        }
        
        AmplifyMotionEffectBase.TryRegister(gameObj:  gameObj, autoReg:  false);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void RegisterRecursively(UnityEngine.GameObject gameObj)
    {
        var val_10;
        var val_13;
        var val_14;
        val_10 = null;
        val_10 = null;
        if((AmplifyMotionEffectBase.m_fixedUpdateCBEvent.ContainsKey(key:  gameObj)) != true)
        {
                AmplifyMotionEffectBase.TryRegister(gameObj:  gameObj, autoReg:  false);
        }
        
        System.Collections.IEnumerator val_3 = gameObj.transform.GetEnumerator();
        label_24:
        var val_12 = 0;
        val_12 = val_12 + 1;
        if(val_3.MoveNext() == false)
        {
            goto label_14;
        }
        
        var val_13 = 0;
        val_13 = val_13 + 1;
        object val_7 = val_3.Current;
        UnityEngine.GameObject val_10 = 0.gameObject;
        goto label_24;
        label_14:
        val_13 = 0;
        val_14 = 85;
        if(val_3 != null)
        {
                var val_14 = 0;
            val_14 = val_14 + 1;
            val_3.Dispose();
        }
        
        if( == 85)
        {
                return;
        }
        
        if( == false)
        {
                return;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void RegisterRecursivelyS(UnityEngine.GameObject gameObj)
    {
        var val_12;
        var val_15;
        var val_16;
        var val_17;
        val_12 = null;
        val_12 = null;
        if((AmplifyMotionEffectBase.m_fixedUpdateCBEvent.ContainsKey(key:  gameObj)) != true)
        {
                AmplifyMotionEffectBase.TryRegister(gameObj:  gameObj, autoReg:  false);
        }
        
        System.Collections.IEnumerator val_3 = gameObj.transform.GetEnumerator();
        label_29:
        var val_14 = 0;
        val_14 = val_14 + 1;
        if(val_3.MoveNext() == false)
        {
            goto label_14;
        }
        
        var val_15 = 0;
        val_15 = val_15 + 1;
        val_15 = val_3.Current;
        if(val_15 != null)
        {
                val_15 = 0;
        }
        
        UnityEngine.GameObject val_12 = val_15.gameObject;
        goto label_29;
        label_14:
        val_16 = 0;
        val_17 = 82;
        if(val_3 != null)
        {
                var val_16 = 0;
            val_16 = val_16 + 1;
            val_3.Dispose();
        }
        
        if( == 82)
        {
                return;
        }
        
        if( == false)
        {
                return;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Unregister(UnityEngine.GameObject gameObj)
    {
        null = null;
        if((AmplifyMotionEffectBase.m_fixedUpdateCBEvent.ContainsKey(key:  gameObj)) == false)
        {
                return;
        }
        
        AmplifyMotionEffectBase.TryUnregister(gameObj:  gameObj);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void UnregisterS(UnityEngine.GameObject gameObj)
    {
        null = null;
        if((AmplifyMotionEffectBase.m_fixedUpdateCBEvent.ContainsKey(key:  gameObj)) == false)
        {
                return;
        }
        
        AmplifyMotionEffectBase.TryUnregister(gameObj:  gameObj);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void UnregisterRecursively(UnityEngine.GameObject gameObj)
    {
        var val_10;
        var val_13;
        var val_14;
        val_10 = null;
        val_10 = null;
        if((AmplifyMotionEffectBase.m_fixedUpdateCBEvent.ContainsKey(key:  gameObj)) != false)
        {
                AmplifyMotionEffectBase.TryUnregister(gameObj:  gameObj);
        }
        
        System.Collections.IEnumerator val_3 = gameObj.transform.GetEnumerator();
        label_24:
        var val_12 = 0;
        val_12 = val_12 + 1;
        if(val_3.MoveNext() == false)
        {
            goto label_14;
        }
        
        var val_13 = 0;
        val_13 = val_13 + 1;
        object val_7 = val_3.Current;
        UnityEngine.GameObject val_10 = 0.gameObject;
        goto label_24;
        label_14:
        val_13 = 0;
        val_14 = 84;
        if(val_3 != null)
        {
                var val_14 = 0;
            val_14 = val_14 + 1;
            val_3.Dispose();
        }
        
        if( == 84)
        {
                return;
        }
        
        if( == false)
        {
                return;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void UnregisterRecursivelyS(UnityEngine.GameObject gameObj)
    {
        var val_12;
        var val_15;
        var val_16;
        var val_17;
        val_12 = null;
        val_12 = null;
        if((AmplifyMotionEffectBase.m_fixedUpdateCBEvent.ContainsKey(key:  gameObj)) != false)
        {
                AmplifyMotionEffectBase.TryUnregister(gameObj:  gameObj);
        }
        
        System.Collections.IEnumerator val_3 = gameObj.transform.GetEnumerator();
        label_29:
        var val_14 = 0;
        val_14 = val_14 + 1;
        if(val_3.MoveNext() == false)
        {
            goto label_14;
        }
        
        var val_15 = 0;
        val_15 = val_15 + 1;
        val_15 = val_3.Current;
        if(val_15 != null)
        {
                val_15 = 0;
        }
        
        UnityEngine.GameObject val_12 = val_15.gameObject;
        goto label_29;
        label_14:
        val_16 = 0;
        val_17 = 81;
        if(val_3 != null)
        {
                var val_16 = 0;
            val_16 = val_16 + 1;
            val_3.Dispose();
        }
        
        if( == 81)
        {
                return;
        }
        
        if( == false)
        {
                return;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void UpdatePostProcess()
    {
        var val_16;
        UnityEngine.Camera val_17;
        AmplifyMotionPostProcess val_18;
        if(this.m_linkedCamerasChanged != false)
        {
                this.UpdateLinkedCameras();
        }
        
        val_16 = 0;
        val_17 = 0;
        goto label_2;
        label_22:
        if(this.m_linkedCameraKeys[0] != 0)
        {
                if(this.m_linkedCameraKeys[0].isActiveAndEnabled != false)
        {
                if(this.m_linkedCameraKeys[0].depth > (-3.402823E+38f))
        {
                val_17 = this.m_linkedCameraKeys[0];
            float val_4 = this.m_linkedCameraKeys[0].depth;
        }
        
        }
        
        }
        
        val_16 = 1;
        label_2:
        if(val_16 < this.m_linkedCameraKeys.Length)
        {
            goto label_22;
        }
        
        if(this.m_currentPostProcess != 0)
        {
                if(this.m_currentPostProcess.gameObject != val_17.gameObject)
        {
                UnityEngine.Object.DestroyImmediate(obj:  this.m_currentPostProcess);
            this.m_currentPostProcess = 0;
        }
        
        }
        
        val_18 = this.m_currentPostProcess;
        if(val_18 != 0)
        {
                return;
        }
        
        if(val_17 == 0)
        {
                return;
        }
        
        val_18 = this.m_camera;
        if(val_17 == val_18)
        {
                return;
        }
        
        val_18 = this.gameObject.GetComponents<AmplifyMotionPostProcess>();
        if(((val_18 != null) && (val_13.Length != 0)) && (val_13.Length >= 1))
        {
                do
        {
            UnityEngine.Object.DestroyImmediate(obj:  val_18[0]);
        }
        while((0 + 1) < val_13.Length);
        
        }
        
        this.m_currentPostProcess = val_17.gameObject.AddComponent<AmplifyMotionPostProcess>();
        val_16.m_instance = this;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void LateUpdate()
    {
        if(this.m_baseCamera.m_autoStep != false)
        {
                if(UnityEngine.Application.isPlaying != false)
        {
                float val_2 = UnityEngine.Time.unscaledDeltaTime;
        }
        else
        {
                float val_3 = UnityEngine.Time.fixedDeltaTime;
        }
        
            float val_4 = UnityEngine.Time.fixedDeltaTime;
            if(val_3 > (1.401298E-45f))
        {
                this.m_deltaTime = val_3;
        }
        
            this.m_fixedDeltaTime = this.m_fixedDeltaTime;
        }
        
        this.QualitySteps = UnityEngine.Mathf.Clamp(value:  this.QualitySteps, min:  0, max:  16);
        this.MotionScale = UnityEngine.Mathf.Max(a:  this.MotionScale, b:  0f);
        this.MinVelocity = UnityEngine.Mathf.Min(a:  this.MinVelocity, b:  this.MaxVelocity);
        this.DepthThreshold = UnityEngine.Mathf.Max(a:  this.DepthThreshold, b:  0f);
        float val_11 = 0f;
        float val_9 = UnityEngine.Mathf.Max(a:  this.MinResetDeltaDist, b:  val_11);
        val_11 = val_9 * val_9;
        this.MinResetDeltaDist = val_9;
        this.MinResetDeltaDistSqr = val_11;
        this.ResetFrameDelay = UnityEngine.Mathf.Max(a:  this.ResetFrameDelay, b:  0);
        this.UpdatePostProcess();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void StopAutoStep()
    {
        var val_7 = this.m_linkedCameras.Values;
        Dictionary.ValueCollection.Enumerator<TKey, TValue> val_2 = val_7.GetEnumerator();
        goto label_5;
        label_6:
        val_7 = 0.emailUIDataHandler;
        if(0 != 0)
        {
                GameUI.EmailUIDataHandler val_4 = val_7 + 363;
            mem2[0] = 256;
        }
        
        label_5:
        if((1553702840 & 1) != 0)
        {
            goto label_6;
        }
        
        long val_5 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519045451704});
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void StartAutoStep()
    {
        var val_6 = this.m_linkedCameras.Values;
        Dictionary.ValueCollection.Enumerator<TKey, TValue> val_2 = val_6.GetEnumerator();
        goto label_3;
        label_5:
        val_6 = 0.emailUIDataHandler;
        mem2[0] = 1;
        label_3:
        if((1553847608 & 1) != 0)
        {
            goto label_5;
        }
        
        long val_4 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519045596472});
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Step(float delta)
    {
        var val_6;
        this.m_deltaTime = delta;
        this.m_fixedDeltaTime = delta;
        val_6 = this.m_linkedCameras.Values;
        Dictionary.ValueCollection.Enumerator<TKey, TValue> val_2 = val_6.GetEnumerator();
        goto label_3;
        label_5:
        val_6 = 0.emailUIDataHandler;
        mem2[0] = 1;
        label_3:
        if((1553992360 & 1) != 0)
        {
            goto label_5;
        }
        
        long val_4 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519045741224});
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void UpdateLinkedCameras()
    {
        Dictionary.KeyCollection<TKey, TValue> val_1 = this.m_linkedCameras.Keys;
        Dictionary.ValueCollection<TKey, TValue> val_2 = this.m_linkedCameras.Values;
        if(this.m_linkedCameraKeys != null)
        {
                if(val_1.Count == this.m_linkedCameraKeys.Length)
        {
            goto label_6;
        }
        
        }
        
        int val_4 = val_1.Count;
        this.m_linkedCameraKeys = new UnityEngine.Camera[0];
        label_6:
        if(this.m_linkedCameraValues != null)
        {
                if(val_2.Count == this.m_linkedCameraValues.Length)
        {
            goto label_11;
        }
        
        }
        
        int val_7 = val_2.Count;
        this.m_linkedCameraValues = new AmplifyMotionCamera[0];
        label_11:
        val_1.CopyTo(array:  this.m_linkedCameraKeys, index:  0);
        val_2.CopyTo(array:  this.m_linkedCameraValues, index:  0);
        this.m_linkedCamerasChanged = false;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void FixedUpdate()
    {
        var val_4;
        UnityEngine.Rendering.CommandBuffer val_5;
        if(this.m_camera.enabled == false)
        {
                return;
        }
        
        if(this.m_linkedCamerasChanged != false)
        {
                this.UpdateLinkedCameras();
        }
        
        this.m_fixedUpdateCB.Clear();
        val_4 = 0;
        goto label_5;
        label_19:
        val_5 = 0;
        if(this.m_linkedCameraValues[val_5] != 0)
        {
                if(this.m_linkedCameraValues[val_5].isActiveAndEnabled != false)
        {
                val_5 = this.m_fixedUpdateCB;
            this.m_linkedCameraValues[val_5].FixedUpdateTransform(inst:  this, updateCB:  val_5);
        }
        
        }
        
        val_4 = 1;
        label_5:
        if(val_4 < this.m_linkedCameraValues.Length)
        {
            goto label_19;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void OnPreRender()
    {
        var val_6;
        UnityEngine.Rendering.CommandBuffer val_7;
        if(this.m_camera.enabled == false)
        {
                return;
        }
        
        if(UnityEngine.Time.frameCount != 1)
        {
                if(System.Math.Abs(UnityEngine.Time.unscaledDeltaTime) <= (1.401298E-45f))
        {
                return;
        }
        
        }
        
        if(this.m_linkedCamerasChanged != false)
        {
                this.UpdateLinkedCameras();
        }
        
        this.m_updateCB.Clear();
        val_6 = 0;
        goto label_9;
        label_23:
        val_7 = 0;
        if(this.m_linkedCameraValues[val_7] != 0)
        {
                if(this.m_linkedCameraValues[val_7].isActiveAndEnabled != false)
        {
                val_7 = this.m_updateCB;
            this.m_linkedCameraValues[val_7].UpdateTransform(inst:  this, updateCB:  val_7);
        }
        
        }
        
        val_6 = 1;
        label_9:
        if(val_6 < this.m_linkedCameraValues.Length)
        {
            goto label_23;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void OnPostRender()
    {
        int val_12;
        float val_13;
        float val_15;
        float val_16;
        float val_17;
        var val_18;
        var val_19;
        var val_20;
        this.m_qualityLevel = this.QualityLevel;
        this.UpdateRenderTextures(qualityChanged:  false);
        val_12 = 1;
        this.m_globalObjectId = val_12;
        if(this.CameraMotionMult > (1.401298E-45f))
        {
                bool val_1 = (this.m_starting == true) ? 1 : 0;
        }
        
        float val_11 = this.m_deltaTime;
        val_13 = 0f;
        float val_3 = (this.DepthThreshold > (1.401298E-45f)) ? (1f / this.DepthThreshold) : 3.402823E+38f;
        val_15 = 0f;
        if(val_11 >= (1.401298E-45f))
        {
                val_11 = 1f / val_11;
            val_15 = val_11 * this.MotionScale;
        }
        
        this.m_motionScaleNorm = val_15;
        if(this.m_fixedDeltaTime >= (1.401298E-45f))
        {
                val_15 = 1f / this.m_fixedDeltaTime;
            val_13 = val_15 * this.MotionScale;
        }
        
        val_16 = 0f;
        val_17 = 0f;
        this.m_fixedMotionScaleNorm = val_13;
        if(this.m_starting != true)
        {
                val_16 = this.m_motionScaleNorm;
            val_17 = val_13;
        }
        
        UnityEngine.Shader.SetGlobalFloat(name:  "_AM_MIN_VELOCITY", value:  this.MinVelocity);
        UnityEngine.Shader.SetGlobalFloat(name:  "_AM_MAX_VELOCITY", value:  this.MaxVelocity);
        float val_12 = this.MinVelocity;
        val_12 = this.MaxVelocity - val_12;
        val_12 = 1f / val_12;
        UnityEngine.Shader.SetGlobalFloat(name:  "_AM_RCP_TOTAL_VELOCITY", value:  val_12);
        UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  this.DepthThreshold, y:  val_3);
        UnityEngine.Vector4 val_5 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y});
        UnityEngine.Shader.SetGlobalVector(name:  "_AM_DEPTH_THRESHOLD", value:  new UnityEngine.Vector4() {x = val_5.x, y = val_5.y, z = val_5.z, w = val_5.w});
        this.m_motionRT.DiscardContents();
        this.m_baseCamera.PreRenderVectors(motionRT:  this.m_motionRT, clearColor:  val_1, rcpDepthThreshold:  val_3);
        val_18 = 0;
        goto label_9;
        label_19:
        AmplifyMotionCamera val_13 = this.m_linkedCameraValues[0];
        if((val_13 != 0) && (this.m_linkedCameraValues[0x0][0].m_overlay != false))
        {
                if(val_13.isActiveAndEnabled != false)
        {
                val_13.PreRenderVectors(motionRT:  this.m_motionRT, clearColor:  val_1, rcpDepthThreshold:  val_3);
            val_13.RenderVectors(scale:  val_16, fixedScale:  val_17, quality:  this.QualityLevel);
        }
        
        }
        
        val_18 = 1;
        label_9:
        if(val_18 < this.m_linkedCameraValues.Length)
        {
            goto label_19;
        }
        
        if(this.CameraMotionMult > (1.401298E-45f))
        {
                float val_14 = this.m_deltaTime;
            val_19 = 0f;
            if(val_14 >= (1.401298E-45f))
        {
                float val_15 = this.MotionScale;
            val_14 = 1f / val_14;
            val_15 = val_15 * this.CameraMotionMult;
            val_19 = val_14 * val_15;
        }
        
            this.m_motionRT.DiscardContents();
            this.m_baseCamera.RenderReprojectionVectors(destination:  this.m_motionRT, scale:  (this.m_starting == true) ? 0f : (val_19));
        }
        
        this.m_baseCamera.RenderVectors(scale:  val_16, fixedScale:  val_17, quality:  this.QualityLevel);
        val_20 = 0;
        goto label_25;
        label_35:
        val_18 = 0;
        AmplifyMotionCamera val_16 = this.m_linkedCameraValues[val_18];
        if((val_16 != 0) && (this.m_linkedCameraValues[0x0][0].m_overlay != false))
        {
                if(val_16.isActiveAndEnabled != false)
        {
                val_16.RenderVectors(scale:  val_16, fixedScale:  val_17, quality:  this.QualityLevel);
        }
        
        }
        
        val_20 = 1;
        label_25:
        if(val_20 < this.m_linkedCameraValues.Length)
        {
            goto label_35;
        }
        
        this.m_starting = false;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void ApplyMotionBlur(UnityEngine.RenderTexture source, UnityEngine.RenderTexture destination, UnityEngine.Vector4 blurStep)
    {
        UnityEngine.Texture val_13;
        UnityEngine.RenderTexture val_14;
        UnityEngine.Texture val_15;
        AmplifyMotion.Quality val_16;
        UnityEngine.Material val_17;
        UnityEngine.RenderTexture val_18;
        var val_19;
        UnityEngine.RenderTexture val_20;
        val_13 = source;
        if(this.QualityLevel != 0)
        {
                val_14 = 0;
        }
        else
        {
                val_14 = UnityEngine.RenderTexture.GetTemporary(width:  this.m_width, height:  this.m_height, depthBuffer:  0, format:  0);
            if(val_14 != null)
        {
                val_14.name = "AM-DepthTemp";
            val_14.wrapMode = 1;
        }
        else
        {
                0.name = "AM-DepthTemp";
            0.wrapMode = 1;
        }
        
            0.filterMode = 0;
        }
        
        UnityEngine.RenderTexture val_3 = UnityEngine.RenderTexture.GetTemporary(width:  this.m_width, height:  this.m_height, depthBuffer:  0, format:  val_13.format);
        if(val_3 != null)
        {
                val_3.name = "AM-CombinedTemp";
            val_3.wrapMode = 1;
            val_3.filterMode = 0;
            val_15 = val_3;
        }
        else
        {
                0.name = "AM-CombinedTemp";
            0.wrapMode = 1;
            0.filterMode = 0;
            val_15 = 0;
        }
        
        val_16 = this.QualityLevel;
        val_3.DiscardContents();
        this.m_combineMaterial.SetTexture(name:  "_MotionTex", value:  this.m_motionRT);
        val_13.filterMode = 0;
        UnityEngine.Graphics.Blit(source:  val_13, dest:  val_3, mat:  this.m_combineMaterial, pass:  0);
        val_17 = this.m_blurMaterial;
        AmplifyMotion.Quality val_4 = val_16 + (this.Noise << 2);
        val_17.SetTexture(name:  "_MotionTex", value:  this.m_motionRT);
        val_18 = val_3;
        if(val_16 == 0)
        {
                UnityEngine.Graphics.Blit(source:  0, dest:  val_14, mat:  this.m_depthMaterial, pass:  0);
            val_17 = this.m_blurMaterial;
            val_17.SetTexture(name:  "_DepthTex", value:  val_14);
        }
        
        if(this.QualitySteps >= 2)
        {
            goto label_17;
        }
        
        this.m_blurMaterial.SetVector(name:  "_AM_BLUR_STEP", value:  new UnityEngine.Vector4() {x = blurStep.x, y = blurStep.y, z = blurStep.z, w = blurStep.w});
        UnityEngine.Graphics.Blit(source:  val_15, dest:  destination, mat:  this.m_blurMaterial, pass:  val_4);
        if(val_16 != 0)
        {
            goto label_37;
        }
        
        goto label_22;
        label_17:
        val_15 = UnityEngine.RenderTexture.GetTemporary(width:  this.m_width, height:  this.m_height, depthBuffer:  0, format:  val_13.format);
        if(val_15 != null)
        {
                val_15.name = "AM-CombinedTemp2";
        }
        else
        {
                0.name = "AM-CombinedTemp2";
        }
        
        val_15.filterMode = 0;
        if(this.QualitySteps >= 1)
        {
                val_15 = 1152921504851574784;
            val_19 = "_AM_BLUR_STEP";
            float val_13 = 1f;
            var val_14 = 0;
            do
        {
            if(val_15 != destination)
        {
                val_15.DiscardContents();
        }
        
            UnityEngine.Vector4 val_9 = UnityEngine.Vector4.op_Multiply(a:  new UnityEngine.Vector4() {x = blurStep.x, y = blurStep.y, z = blurStep.z, w = blurStep.w}, d:  val_13);
            this.m_blurMaterial.SetVector(name:  "_AM_BLUR_STEP", value:  new UnityEngine.Vector4() {x = val_9.x, y = val_9.y, z = val_9.z, w = val_9.w});
            UnityEngine.Graphics.Blit(source:  val_3, dest:  val_15, mat:  this.m_blurMaterial, pass:  val_4);
            val_13 = val_13 - (val_13 / (float)this.QualitySteps);
            val_14 = val_14 + 1;
            var val_11 = (val_14 < (this.QualitySteps - 2)) ? (val_3) : destination;
        }
        while(val_14 < this.QualitySteps);
        
        }
        
        UnityEngine.RenderTexture.ReleaseTemporary(temp:  val_15);
        val_13 = val_13;
        val_20 = val_14;
        val_16 = val_16;
        val_18 = val_3;
        if(val_16 != 0)
        {
            goto label_37;
        }
        
        label_22:
        val_15 = this.m_motionRT;
        this.m_combineMaterial.SetTexture(name:  "_MotionTex", value:  val_15);
        UnityEngine.Graphics.Blit(source:  val_13, dest:  destination, mat:  this.m_combineMaterial, pass:  1);
        label_37:
        UnityEngine.RenderTexture.ReleaseTemporary(temp:  val_18);
        if(val_20 == 0)
        {
                return;
        }
        
        UnityEngine.RenderTexture.ReleaseTemporary(temp:  val_20);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void OnRenderImage(UnityEngine.RenderTexture source, UnityEngine.RenderTexture destination)
    {
        if(this.m_currentPostProcess == 0)
        {
                this.PostProcess(source:  source, destination:  destination);
            return;
        }
        
        UnityEngine.Graphics.Blit(source:  source, dest:  destination);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void PostProcess(UnityEngine.RenderTexture source, UnityEngine.RenderTexture destination)
    {
        UnityEngine.RenderTexture val_5;
        UnityEngine.Material val_6;
        UnityEngine.Vector4 val_1 = UnityEngine.Vector4.zero;
        val_5 = 0;
        if(UnityEngine.QualitySettings.antiAliasing >= 2)
        {
                val_5 = UnityEngine.RenderTexture.GetTemporary(width:  this.m_width, height:  this.m_height, depthBuffer:  0, format:  0, readWrite:  1);
            if(val_5 != null)
        {
                val_5.name = "AM-DilatedTemp";
        }
        else
        {
                0.name = "AM-DilatedTemp";
        }
        
            val_5.filterMode = 0;
            this.m_dilationMaterial.SetTexture(name:  "_MotionTex", value:  this.m_motionRT);
            UnityEngine.Graphics.Blit(source:  this.m_motionRT, dest:  val_5, mat:  this.m_dilationMaterial, pass:  0);
            val_6 = this.m_dilationMaterial;
            val_6.SetTexture(name:  "_MotionTex", value:  val_5);
            UnityEngine.Graphics.Blit(source:  val_5, dest:  this.m_motionRT, mat:  this.m_dilationMaterial, pass:  1);
        }
        
        if(this.DebugMode != false)
        {
                val_6 = this.m_debugMaterial;
            val_6.SetTexture(name:  "_MotionTex", value:  this.m_motionRT);
            UnityEngine.Graphics.Blit(source:  source, dest:  destination, mat:  this.m_debugMaterial);
        }
        else
        {
                float val_5 = 1000f;
            val_5 = this.MaxVelocity / val_5;
            this.ApplyMotionBlur(source:  source, destination:  destination, blurStep:  new UnityEngine.Vector4() {x = val_5, y = val_5, z = val_1.z, w = val_1.w});
        }
        
        if(val_5 == 0)
        {
                return;
        }
        
        UnityEngine.RenderTexture.ReleaseTemporary(temp:  val_5);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AmplifyMotionEffectBase()
    {
        this.QualityLevel = 4294967297;
        this.MaxVelocity = 10f;
        this.DepthThreshold = 7.714148E-41f;
        this.MotionScale = ;
        this.CameraMotionMult = ;
        this.ObjectMotionMult = 1f;
        this.MinVelocity = 1f;
        this.OverlayCameras = new UnityEngine.Camera[0];
        UnityEngine.LayerMask val_2 = UnityEngine.LayerMask.op_Implicit(intVal:  0);
        this.CullingMask = val_2;
        this.AutoRegisterObjs = true;
        this.MinResetDeltaDist = 1000f;
        this.ResetFrameDelay = true;
        this.m_starting = true;
        this.m_linkedCameras = new System.Collections.Generic.Dictionary<UnityEngine.Camera, AmplifyMotionCamera>();
        this.m_linkedCamerasChanged = true;
        this.m_globalObjectId = true;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static AmplifyMotionEffectBase()
    {
        AmplifyMotionEffectBase.m_fixedUpdateCBEvent = new System.Collections.Generic.Dictionary<UnityEngine.GameObject, AmplifyMotionObjectBase>();
        AmplifyMotionEffectBase.m_activeCameras = new System.Collections.Generic.Dictionary<UnityEngine.Camera, AmplifyMotionCamera>();
        AmplifyMotionEffectBase.m_isD3D = false;
        AmplifyMotionEffectBase.m_ignoreMotionScaleWarning = false;
        AmplifyMotionEffectBase.m_firstInstance = 0;
    }

}
