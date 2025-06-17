using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AmplifyMotionCamera : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal AmplifyMotionEffectBase Instance;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal UnityEngine.Matrix4x4 PrevViewProjMatrix;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal UnityEngine.Matrix4x4 ViewProjMatrix;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal UnityEngine.Matrix4x4 InvViewProjMatrix;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal UnityEngine.Matrix4x4 PrevViewProjMatrixRT;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal UnityEngine.Matrix4x4 ViewProjMatrixRT;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal UnityEngine.Transform Transform;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool m_linked;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool m_initialized;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool m_starting;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool m_autoStep;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool m_step;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool m_overlay;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Camera m_camera;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int m_prevFrameCount;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Collections.Generic.HashSet<AmplifyMotionObjectBase> m_affectedObjectsTable;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private AmplifyMotionObjectBase[] m_affectedObjects;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool m_affectedObjectsChanged;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private const UnityEngine.Rendering.CameraEvent m_renderCBEvent = 18;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Rendering.CommandBuffer m_renderCB;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Initialized { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool AutoStep { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Overlay { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Camera Camera { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool get_Initialized()
    {
        return (bool)this.m_initialized;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool get_AutoStep()
    {
        return (bool)this.m_autoStep;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool get_Overlay()
    {
        return (bool)this.m_overlay;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Camera get_Camera()
    {
        return (UnityEngine.Camera)this.m_camera;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void RegisterObject(AmplifyMotionObjectBase obj)
    {
        bool val_1 = this.m_affectedObjectsTable.Add(item:  obj);
        this.m_affectedObjectsChanged = true;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void UnregisterObject(AmplifyMotionObjectBase obj)
    {
        bool val_1 = this.m_affectedObjectsTable.Remove(item:  obj);
        this.m_affectedObjectsChanged = true;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void UpdateAffectedObjects()
    {
        AmplifyMotionObjectBase[] val_4;
        if((this.m_affectedObjects != null) && (this.m_affectedObjectsTable.Count == this.m_affectedObjects.Length))
        {
                val_4 = this.m_affectedObjects;
        }
        else
        {
                int val_2 = this.m_affectedObjectsTable.Count;
            AmplifyMotionObjectBase[] val_3 = new AmplifyMotionObjectBase[0];
            val_4 = val_3;
            this.m_affectedObjects = val_4;
        }
        
        this.m_affectedObjectsTable.CopyTo(array:  val_3);
        this.m_affectedObjectsChanged = false;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void LinkTo(AmplifyMotionEffectBase instance, bool overlay)
    {
        var val_6;
        this.Instance = instance;
        UnityEngine.Camera val_1 = this.GetComponent<UnityEngine.Camera>();
        this.m_camera = val_1;
        if(val_1 != null)
        {
                val_6 = val_1.depthTextureMode;
        }
        else
        {
                val_6 = val_1.depthTextureMode;
        }
        
        val_1.depthTextureMode = val_6 | 1;
        this.InitializeCommandBuffers();
        this.m_overlay = overlay;
        this.m_linked = true;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Initialize()
    {
        this.m_step = false;
        this.UpdateMatrices();
        this.m_initialized = true;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void InitializeCommandBuffers()
    {
        this.ShutdownCommandBuffers();
        UnityEngine.Rendering.CommandBuffer val_1 = new UnityEngine.Rendering.CommandBuffer();
        this.m_renderCB = val_1;
        val_1.name = "AmplifyMotion.Render";
        this.m_camera.AddCommandBuffer(evt:  18, buffer:  this.m_renderCB);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void ShutdownCommandBuffers()
    {
        if(this.m_renderCB == null)
        {
                return;
        }
        
        this.m_camera.RemoveCommandBuffer(evt:  18, buffer:  this.m_renderCB);
        this.m_renderCB.Release();
        this.m_renderCB = 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Awake()
    {
        this.Transform = this.transform;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void OnEnable()
    {
        AmplifyMotionEffectBase.RegisterCamera(cam:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void OnDisable()
    {
        this.m_initialized = false;
        this.ShutdownCommandBuffers();
        AmplifyMotionEffectBase.UnregisterCamera(cam:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void OnDestroy()
    {
        if(this.Instance == 0)
        {
                return;
        }
        
        this.Instance.RemoveCamera(reference:  this.m_camera);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void StopAutoStep()
    {
        if(this.m_autoStep == false)
        {
                return;
        }
        
        mem2[0] = 256;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void StartAutoStep()
    {
        this.m_autoStep = true;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Step()
    {
        this.m_step = true;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Update()
    {
        var val_6;
        if(this.m_linked == false)
        {
                return;
        }
        
        if(this.Instance.isActiveAndEnabled == false)
        {
                return;
        }
        
        if(this.m_initialized != true)
        {
                this.m_step = false;
            this.UpdateMatrices();
            this.m_initialized = true;
        }
        
        if((this.m_camera.depthTextureMode & 1) != 0)
        {
                return;
        }
        
        if(this.m_camera != null)
        {
                val_6 = this.m_camera.depthTextureMode;
        }
        else
        {
                val_6 = 0.depthTextureMode;
        }
        
        this.m_camera.depthTextureMode = val_6 | 1;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void UpdateMatrices()
    {
        float val_2;
        float val_3;
        float val_4;
        float val_5;
        float val_7;
        float val_8;
        float val_9;
        float val_10;
        float val_12;
        float val_13;
        float val_14;
        float val_15;
        float val_17;
        float val_18;
        float val_19;
        UnityEngine.Matrix4x4 val_20;
        var val_22;
        var val_23;
        var val_24;
        UnityEngine.Matrix4x4 val_25;
        float val_27;
        float val_28;
        float val_29;
        float val_30;
        float val_32;
        float val_33;
        float val_34;
        float val_35;
        var val_37;
        var val_38;
        var val_39;
        UnityEngine.Matrix4x4 val_40;
        var val_41 = this;
        if(this.m_starting != true)
        {
                mem[1152921519051475984] = ???;
            mem[1152921519051476000] = 0;
            this.PrevViewProjMatrix = this.ViewProjMatrix;
            mem[1152921519051475968] = ???;
            this.PrevViewProjMatrixRT = this.ViewProjMatrixRT;
            mem[1152921519051476160] = ???;
            mem[1152921519051476176] = this.ViewProjMatrix;
            mem[1152921519051476192] = ???;
        }
        
        UnityEngine.Matrix4x4 val_1 = this.m_camera.worldToCameraMatrix;
        UnityEngine.Matrix4x4 val_6 = this.m_camera.projectionMatrix;
        UnityEngine.Matrix4x4 val_11 = UnityEngine.GL.GetGPUProjectionMatrix(proj:  new UnityEngine.Matrix4x4() {m00 = val_9, m10 = val_9, m20 = val_9, m30 = val_9, m01 = val_10, m11 = val_10, m21 = val_10, m31 = val_10, m02 = val_7, m12 = val_7, m22 = val_7, m32 = val_7, m03 = val_8, m13 = val_8, m23 = val_8, m33 = val_8}, renderIntoTexture:  false);
        UnityEngine.Matrix4x4 val_16 = UnityEngine.Matrix4x4.op_Multiply(lhs:  new UnityEngine.Matrix4x4() {m00 = val_14, m10 = val_14, m20 = val_14, m30 = val_14, m01 = val_15, m11 = val_15, m21 = val_15, m31 = val_15, m02 = val_12, m12 = val_12, m22 = val_12, m32 = val_12, m03 = val_13, m13 = val_13, m23 = val_13, m33 = val_13}, rhs:  new UnityEngine.Matrix4x4() {m00 = val_4, m10 = val_4, m20 = val_4, m30 = val_4, m01 = val_5, m11 = val_5, m21 = val_5, m31 = val_5, m02 = val_2, m12 = val_2, m22 = val_2, m32 = val_2, m03 = val_3, m13 = val_3, m23 = val_3, m33 = val_3});
        mem[1152921519051476064] = val_18;
        mem[1152921519051476048] = val_17;
        mem[1152921519051476032] = val_19;
        this.ViewProjMatrix = val_20;
        UnityEngine.Matrix4x4 val_21 = UnityEngine.Matrix4x4.Inverse(m:  new UnityEngine.Matrix4x4() {m00 = val_20, m10 = val_20, m20 = val_20, m30 = val_20, m01 = val_19, m11 = val_19, m21 = val_19, m31 = val_19, m02 = val_17, m12 = val_17, m22 = val_17, m32 = val_17, m03 = val_18, m13 = val_18, m23 = val_18, m33 = val_18});
        mem[1152921519051476128] = val_22;
        mem[1152921519051476112] = val_23;
        mem[1152921519051476096] = val_24;
        this.InvViewProjMatrix = val_25;
        UnityEngine.Matrix4x4 val_26 = this.m_camera.projectionMatrix;
        UnityEngine.Matrix4x4 val_31 = UnityEngine.GL.GetGPUProjectionMatrix(proj:  new UnityEngine.Matrix4x4() {m00 = val_29, m10 = val_29, m20 = val_29, m30 = val_29, m01 = val_30, m11 = val_30, m21 = val_30, m31 = val_30, m02 = val_27, m12 = val_27, m22 = val_27, m32 = val_27, m03 = val_28, m13 = val_28, m23 = val_28, m33 = val_28}, renderIntoTexture:  true);
        UnityEngine.Matrix4x4 val_36 = UnityEngine.Matrix4x4.op_Multiply(lhs:  new UnityEngine.Matrix4x4() {m00 = val_34, m10 = val_34, m20 = val_34, m30 = val_34, m01 = val_35, m11 = val_35, m21 = val_35, m31 = val_35, m02 = val_32, m12 = val_32, m22 = val_32, m32 = val_32, m03 = val_33, m13 = val_33, m23 = val_33, m33 = val_33}, rhs:  new UnityEngine.Matrix4x4() {m00 = val_4, m10 = val_4, m20 = val_4, m30 = val_4, m01 = val_5, m11 = val_5, m21 = val_5, m31 = val_5, m02 = val_2, m12 = val_2, m22 = val_2, m32 = val_2, m03 = val_3, m13 = val_3, m23 = val_3, m33 = val_3});
        mem[1152921519051476256] = val_37;
        mem[1152921519051476240] = val_38;
        mem[1152921519051476224] = val_39;
        this.ViewProjMatrixRT = val_40;
        if(this.m_starting == false)
        {
                return;
        }
        
        mem[1152921519051476000] = this.ViewProjMatrix.m03;
        mem[1152921519051475984] = this.ViewProjMatrix.m02;
        mem[1152921519051475968] = this.ViewProjMatrix.m01;
        this.PrevViewProjMatrix = this.ViewProjMatrix.m00;
        mem[1152921519051476192] = this.ViewProjMatrixRT.m03;
        mem[1152921519051476176] = this.ViewProjMatrixRT.m02;
        mem[1152921519051476160] = this.ViewProjMatrixRT.m01;
        this.PrevViewProjMatrixRT = this.ViewProjMatrixRT.m00;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void FixedUpdateTransform(AmplifyMotionEffectBase inst, UnityEngine.Rendering.CommandBuffer updateCB)
    {
        var val_2;
        AmplifyMotionObjectBase val_3;
        if(this.m_initialized != true)
        {
                this.m_step = false;
            this.UpdateMatrices();
            this.m_initialized = true;
        }
        
        if(this.m_affectedObjectsChanged != false)
        {
                this.UpdateAffectedObjects();
        }
        
        val_2 = 0;
        goto label_2;
        label_11:
        val_3 = this.m_affectedObjects[0];
        if(this.m_affectedObjects[0x0][0].m_fixedStep != false)
        {
                val_3 = this.m_camera;
            this.m_affectedObjects[0].OnUpdateTransform(inst:  inst, camera:  val_3, updateCB:  updateCB, starting:  (this.m_starting == true) ? 1 : 0);
        }
        
        val_2 = 1;
        label_2:
        if(val_2 < this.m_affectedObjects.Length)
        {
            goto label_11;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void UpdateTransform(AmplifyMotionEffectBase inst, UnityEngine.Rendering.CommandBuffer updateCB)
    {
        var val_4;
        AmplifyMotionObjectBase val_5;
        if(this.m_initialized != true)
        {
                this.m_step = false;
            this.UpdateMatrices();
            this.m_initialized = true;
        }
        
        if(UnityEngine.Time.frameCount <= this.m_prevFrameCount)
        {
                return;
        }
        
        if(this.m_autoStep != true)
        {
                if(this.m_step == false)
        {
                return;
        }
        
        }
        
        this.UpdateMatrices();
        if(this.m_affectedObjectsChanged != false)
        {
                this.UpdateAffectedObjects();
        }
        
        val_4 = 0;
        goto label_5;
        label_14:
        val_5 = this.m_affectedObjects[0];
        if(this.m_affectedObjects[0x0][0].m_fixedStep != true)
        {
                val_5 = this.m_camera;
            this.m_affectedObjects[0].OnUpdateTransform(inst:  inst, camera:  val_5, updateCB:  updateCB, starting:  (this.m_starting == true) ? 1 : 0);
        }
        
        val_4 = 1;
        label_5:
        if(val_4 < this.m_affectedObjects.Length)
        {
            goto label_14;
        }
        
        this.m_starting = false;
        this.m_step = false;
        this.m_prevFrameCount = UnityEngine.Time.frameCount;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void RenderReprojectionVectors(UnityEngine.RenderTexture destination, float scale)
    {
        float val_2;
        float val_3;
        float val_4;
        float val_5;
        UnityEngine.CubemapFace val_7;
        UnityEngine.Rendering.BuiltinRenderTextureType val_8;
        IntPtr val_9;
        UnityEngine.Matrix4x4 val_1 = UnityEngine.Matrix4x4.op_Multiply(lhs:  new UnityEngine.Matrix4x4() {m00 = this.PrevViewProjMatrix, m10 = this.PrevViewProjMatrix, m20 = this.PrevViewProjMatrix, m30 = this.PrevViewProjMatrix, m01 = scale, m02 = scale, m03 = scale}, rhs:  new UnityEngine.Matrix4x4() {m00 = this.InvViewProjMatrix, m10 = this.InvViewProjMatrix, m20 = this.InvViewProjMatrix, m30 = this.InvViewProjMatrix, m01 = this.PrevViewProjMatrix, m11 = this.PrevViewProjMatrix, m21 = this.PrevViewProjMatrix, m31 = this.PrevViewProjMatrix, m02 = this.PrevViewProjMatrix, m12 = this.PrevViewProjMatrix, m22 = this.PrevViewProjMatrix, m32 = this.PrevViewProjMatrix, m03 = this.PrevViewProjMatrix, m13 = this.PrevViewProjMatrix, m23 = this.PrevViewProjMatrix, m33 = this.PrevViewProjMatrix});
        this.m_renderCB.SetGlobalMatrix(name:  "_AM_MATRIX_CURR_REPROJ", value:  new UnityEngine.Matrix4x4() {m00 = val_4, m10 = val_4, m20 = val_4, m30 = val_4, m01 = val_5, m11 = val_5, m21 = val_5, m31 = val_5, m02 = val_2, m12 = val_2, m22 = val_2, m32 = val_2, m03 = val_3, m13 = val_3, m23 = val_3, m33 = val_3});
        this.m_renderCB.SetGlobalFloat(name:  "_AM_MOTION_SCALE", value:  scale);
        UnityEngine.Rendering.RenderTargetIdentifier val_6 = UnityEngine.Rendering.RenderTargetIdentifier.op_Implicit(tex:  destination);
        this.m_renderCB.Blit(source:  new UnityEngine.Rendering.RenderTargetIdentifier(), dest:  new UnityEngine.Rendering.RenderTargetIdentifier() {m_Type = val_8, m_NameID = val_8, m_InstanceID = val_8, m_BufferPointer = val_9, m_MipLevel = val_9, m_CubeFace = val_7}, mat:  this.Instance.m_reprojectionMaterial);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void PreRenderVectors(UnityEngine.RenderTexture motionRT, bool clearColor, float rcpDepthThreshold)
    {
        UnityEngine.CubemapFace val_5;
        IntPtr val_6;
        UnityEngine.Rendering.BuiltinRenderTextureType val_7;
        AmplifyMotionEffectBase val_10;
        this.m_renderCB.Clear();
        this.m_renderCB.SetGlobalFloat(name:  "_AM_MIN_VELOCITY", value:  this.Instance.MinVelocity);
        this.m_renderCB.SetGlobalFloat(name:  "_AM_MAX_VELOCITY", value:  this.Instance.MaxVelocity);
        val_10 = this.Instance;
        if(this.Instance != null)
        {
            goto label_6;
        }
        
        val_10 = this.Instance;
        if(val_10 == null)
        {
            goto label_7;
        }
        
        label_6:
        float val_1 = this.Instance.MaxVelocity - this.Instance.MinVelocity;
        val_1 = 1f / val_1;
        this.m_renderCB.SetGlobalFloat(name:  "_AM_RCP_TOTAL_VELOCITY", value:  val_1);
        UnityEngine.Vector2 val_2 = new UnityEngine.Vector2(x:  this.Instance.DepthThreshold, y:  rcpDepthThreshold);
        UnityEngine.Vector4 val_3 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y});
        this.m_renderCB.SetGlobalVector(name:  "_AM_DEPTH_THRESHOLD", value:  new UnityEngine.Vector4() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w});
        UnityEngine.Rendering.RenderTargetIdentifier val_4 = UnityEngine.Rendering.RenderTargetIdentifier.op_Implicit(tex:  motionRT);
        this.m_renderCB.SetRenderTarget(rt:  new UnityEngine.Rendering.RenderTargetIdentifier() {m_Type = val_7, m_NameID = val_7, m_InstanceID = val_7, m_BufferPointer = val_6, m_MipLevel = val_6, m_CubeFace = val_5});
        UnityEngine.Color val_8 = UnityEngine.Color.black;
        this.m_renderCB.ClearRenderTarget(clearDepth:  true, clearColor:  clearColor, backgroundColor:  new UnityEngine.Color() {r = val_8.r, g = val_8.g, b = val_8.b, a = val_8.a});
        return;
        label_7:
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void RenderVectors(float scale, float fixedScale, AmplifyMotion.Quality quality)
    {
        var val_10;
        float val_11;
        float val_12;
        float val_13;
        var val_14;
        if(this.m_initialized != true)
        {
                this.m_step = false;
            this.UpdateMatrices();
            this.m_initialized = true;
        }
        
        float val_2 = this.m_camera.farClipPlane;
        val_10 = null;
        val_11 = val_2 / this.m_camera.nearClipPlane;
        float val_9 = 1f;
        val_12 = val_9 - val_11;
        if(AmplifyMotionEffectBase.IsD3D != true)
        {
                val_9 = val_11 + val_9;
            val_12 = val_12 * 0.5f;
            val_11 = val_9 * 0.5f;
        }
        
        val_13 = val_11 / val_2;
        this.m_renderCB.SetGlobalVector(name:  "_AM_ZBUFFER_PARAMS", value:  new UnityEngine.Vector4() {x = val_12, y = val_11, z = val_12 / val_2, w = val_13});
        this.m_renderCB.SetGlobalMatrix(name:  "_AM_MATRIX_PREV_VP", value:  new UnityEngine.Matrix4x4() {m00 = this.PrevViewProjMatrixRT, m10 = this.PrevViewProjMatrixRT, m20 = this.PrevViewProjMatrixRT, m30 = this.PrevViewProjMatrixRT, m01 = val_12, m02 = val_12, m03 = val_12});
        if(this.m_affectedObjectsChanged != false)
        {
                this.UpdateAffectedObjects();
        }
        
        val_14 = 0;
        goto label_10;
        label_24:
        this.m_affectedObjects[0] = this.m_affectedObjects[0].gameObject.layer & 31;
        this.m_affectedObjects[0] = 1 << this.m_affectedObjects[0];
        this.m_affectedObjects[0] = this.m_affectedObjects[0] & this.m_camera.cullingMask;
        if(this.m_affectedObjects[0] != 0)
        {
                AmplifyMotionObjectBase val_12 = this.m_affectedObjects[0];
            this.m_affectedObjects[0].OnRenderVectors(camera:  this.m_camera, renderCB:  this.m_renderCB, scale:  (this.m_affectedObjects[0x0][0].m_fixedStep == true) ? fixedScale : scale, quality:  quality);
        }
        
        val_14 = 1;
        label_10:
        if(val_14 < this.m_affectedObjects.Length)
        {
            goto label_24;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AmplifyMotionCamera()
    {
        this.m_starting = true;
        this.m_autoStep = true;
        this.m_affectedObjectsTable = new System.Collections.Generic.HashSet<AmplifyMotionObjectBase>();
        this.m_affectedObjectsChanged = true;
    }

}
