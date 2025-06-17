using UnityEngine;

namespace VLB
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class BeamGeometry : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private VLB.VolumetricLightBeam m_Master;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Matrix4x4 m_ColorGradientMatrix;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private VLB.MeshType m_CurrentMeshType;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Material m_CustomMaterial;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.MeshRenderer <meshRenderer>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.MeshFilter <meshFilter>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Mesh <coneMesh>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Plane m_ClippingPlaneWS;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.MeshRenderer meshRenderer { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.MeshFilter meshFilter { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Mesh coneMesh { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool visible { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int sortingLayerID { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int sortingOrder { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool isCustomRenderPipelineSupported { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool isNoiseEnabled { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool isClippingPlaneEnabled { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool isDepthBlendEnabled { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.MeshRenderer get_meshRenderer()
        {
            return (UnityEngine.MeshRenderer)this.<meshRenderer>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_meshRenderer(UnityEngine.MeshRenderer value)
        {
            this.<meshRenderer>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.MeshFilter get_meshFilter()
        {
            return (UnityEngine.MeshFilter)this.<meshFilter>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_meshFilter(UnityEngine.MeshFilter value)
        {
            this.<meshFilter>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Mesh get_coneMesh()
        {
            return (UnityEngine.Mesh)this.<coneMesh>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_coneMesh(UnityEngine.Mesh value)
        {
            this.<coneMesh>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_visible()
        {
            if((this.<meshRenderer>k__BackingField) != null)
            {
                    return this.<meshRenderer>k__BackingField.enabled;
            }
            
            return this.<meshRenderer>k__BackingField.enabled;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_visible(bool value)
        {
            value = value;
            this.<meshRenderer>k__BackingField.enabled = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_sortingLayerID()
        {
            if((this.<meshRenderer>k__BackingField) != null)
            {
                    return this.<meshRenderer>k__BackingField.sortingLayerID;
            }
            
            return this.<meshRenderer>k__BackingField.sortingLayerID;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_sortingLayerID(int value)
        {
            this.<meshRenderer>k__BackingField.sortingLayerID = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_sortingOrder()
        {
            if((this.<meshRenderer>k__BackingField) != null)
            {
                    return this.<meshRenderer>k__BackingField.sortingOrder;
            }
            
            return this.<meshRenderer>k__BackingField.sortingOrder;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_sortingOrder(int value)
        {
            this.<meshRenderer>k__BackingField.sortingOrder = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float ComputeFadeOutFactor(UnityEngine.Transform camTransform)
        {
            float val_3;
            VLB.VolumetricLightBeam val_11;
            float val_12;
            if(this.m_Master.fadeOutEnd < 0f)
            {
                    return (float)UnityEngine.Mathf.InverseLerp(a:  val_12 * this.m_Master.fadeOutEnd, b:  this.m_Master.fadeOutBegin * this.m_Master.fadeOutBegin, value:  UnityEngine.Vector3.SqrMagnitude(vector:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}));
            }
            
            UnityEngine.Bounds val_1 = this.<meshRenderer>k__BackingField.bounds;
            UnityEngine.Vector3 val_4 = camTransform.position;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_3, y = V1.16B, z = V2.16B}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            val_11 = this.m_Master;
            if(val_11 != null)
            {
                    val_12 = this.m_Master.fadeOutEnd;
                return (float)UnityEngine.Mathf.InverseLerp(a:  val_12 * this.m_Master.fadeOutEnd, b:  this.m_Master.fadeOutBegin * this.m_Master.fadeOutBegin, value:  UnityEngine.Vector3.SqrMagnitude(vector:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}));
            }
            
            val_12 = this.m_Master.fadeOutEnd;
            if(this.m_Master != null)
            {
                    val_11 = this.m_Master;
                return (float)UnityEngine.Mathf.InverseLerp(a:  val_12 * this.m_Master.fadeOutEnd, b:  this.m_Master.fadeOutBegin * this.m_Master.fadeOutBegin, value:  UnityEngine.Vector3.SqrMagnitude(vector:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}));
            }
            
            if(this.m_Master != null)
            {
                    return (float)UnityEngine.Mathf.InverseLerp(a:  val_12 * this.m_Master.fadeOutEnd, b:  this.m_Master.fadeOutBegin * this.m_Master.fadeOutBegin, value:  UnityEngine.Vector3.SqrMagnitude(vector:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}));
            }
            
            if(this.m_Master != null)
            {
                    return (float)UnityEngine.Mathf.InverseLerp(a:  val_12 * this.m_Master.fadeOutEnd, b:  this.m_Master.fadeOutBegin * this.m_Master.fadeOutBegin, value:  UnityEngine.Vector3.SqrMagnitude(vector:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}));
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.IEnumerator CoUpdateFadeOut()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new BeamGeometry.<CoUpdateFadeOut>d__26();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ComputeFadeOutFactor()
        {
            UnityEngine.Transform val_2 = VLB.Config.Instance.fadeOutCameraTransform;
            if((UnityEngine.Object.op_Implicit(exists:  val_2)) == false)
            {
                goto label_6;
            }
            
            if((this.ComputeFadeOutFactor(camTransform:  val_2)) <= 0f)
            {
                goto label_8;
            }
            
            this.<meshRenderer>k__BackingField.enabled = true;
            goto label_9;
            label_6:
            label_9:
            this.SetFadeOutFactorProp(value:  1f);
            return;
            label_8:
            this.<meshRenderer>k__BackingField.enabled = false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetFadeOutFactorProp(float value)
        {
            this.MaterialChangeStart();
            this.SetMaterialProp(name:  "_FadeOutFactor", value:  value);
            this.MaterialChangeStop();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void RestartFadeOutCoroutine()
        {
            this.StopAllCoroutines();
            if((UnityEngine.Object.op_Implicit(exists:  this.m_Master)) == false)
            {
                    return;
            }
            
            if(this.m_Master.fadeOutEnd < 0f)
            {
                    return;
            }
            
            UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.CoUpdateFadeOut());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            if((UnityEngine.Object.op_Implicit(exists:  this.m_Master)) != false)
            {
                    return;
            }
            
            UnityEngine.Object.DestroyImmediate(obj:  this.gameObject);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDestroy()
        {
            if((UnityEngine.Object.op_Implicit(exists:  this.m_CustomMaterial)) == false)
            {
                    return;
            }
            
            UnityEngine.Object.DestroyImmediate(obj:  this.m_CustomMaterial);
            this.m_CustomMaterial = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static bool IsUsingCustomRenderPipeline()
        {
            if(UnityEngine.Experimental.Rendering.RenderPipelineManager.currentPipeline == null)
            {
                    return UnityEngine.Object.op_Inequality(x:  UnityEngine.Rendering.GraphicsSettings.renderPipelineAsset, y:  0);
            }
            
            return true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDisable()
        {
            if(VLB.BeamGeometry.IsUsingCustomRenderPipeline() == false)
            {
                    return;
            }
            
            UnityEngine.Experimental.Rendering.RenderPipeline.remove_beginCameraRendering(value:  new System.Action<UnityEngine.Camera>(object:  this, method:  System.Void VLB.BeamGeometry::OnBeginCameraRendering(UnityEngine.Camera cam)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool get_isCustomRenderPipelineSupported()
        {
            return true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnEnable()
        {
            this.RestartFadeOutCoroutine();
            if(VLB.BeamGeometry.IsUsingCustomRenderPipeline() == false)
            {
                    return;
            }
            
            UnityEngine.Experimental.Rendering.RenderPipeline.add_beginCameraRendering(value:  new System.Action<UnityEngine.Camera>(object:  this, method:  System.Void VLB.BeamGeometry::OnBeginCameraRendering(UnityEngine.Camera cam)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Initialize(VLB.VolumetricLightBeam master)
        {
            UnityEngine.HideFlags val_1 = VLB.Consts.ProceduralObjectsHideFlags;
            this.m_Master = master;
            this.transform.SetParent(parent:  master.transform, worldPositionStays:  false);
            UnityEngine.MeshRenderer val_5 = VLB.Utils.GetOrAddComponent<UnityEngine.MeshRenderer>(self:  this.gameObject);
            this.<meshRenderer>k__BackingField = val_5;
            val_5.hideFlags = val_1;
            this.<meshRenderer>k__BackingField.shadowCastingMode = 0;
            this.<meshRenderer>k__BackingField.receiveShadows = false;
            this.<meshRenderer>k__BackingField.lightProbeUsage = 0;
            VLB.Config val_6 = VLB.Config.Instance;
            if(val_6.renderingMode != 2)
            {
                    this.m_CustomMaterial = VLB.MaterialManager.NewMaterial(gpuInstanced:  false);
                bool val_8 = this.ApplyMaterial();
            }
            
            bool val_9 = UnityEngine.SortingLayer.IsValid(id:  this.m_Master._SortingLayerID);
            if(this.m_Master == null)
            {
                goto label_18;
            }
            
            if(val_9 == false)
            {
                goto label_19;
            }
            
            label_21:
            this.sortingLayerID = this.m_Master._SortingLayerID;
            goto label_20;
            label_18:
            if(val_9 == true)
            {
                goto label_21;
            }
            
            label_19:
            UnityEngine.Debug.LogError(message:  System.String.Format(format:  "Beam \'{0}\' has an invalid sortingLayerID ({1}). Please fix it by setting a valid layer.", arg0:  VLB.Utils.GetPath(current:  this.m_Master.transform), arg1:  this.m_Master._SortingLayerID));
            label_20:
            this.sortingOrder = this.m_Master._SortingOrder;
            UnityEngine.MeshFilter val_14 = VLB.Utils.GetOrAddComponent<UnityEngine.MeshFilter>(self:  this.gameObject);
            this.<meshFilter>k__BackingField = val_14;
            val_14.hideFlags = val_1;
            this.gameObject.hideFlags = val_1;
            this.RestartFadeOutCoroutine();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RegenerateMesh()
        {
            UnityEngine.MeshFilter val_15;
            VLB.VolumetricLightBeam val_16;
            VLB.VolumetricLightBeam val_17;
            int val_18;
            VLB.VolumetricLightBeam val_19;
            VLB.Config val_1 = VLB.Config.Instance;
            UnityEngine.GameObject val_2 = this.gameObject;
            if(val_1.geometryOverrideLayer == false)
            {
                goto label_4;
            }
            
            VLB.Config val_3 = VLB.Config.Instance;
            if(val_2 != null)
            {
                goto label_23;
            }
            
            label_24:
            label_23:
            val_2.layer = val_3.geometryLayerID;
            VLB.Config val_5 = VLB.Config.Instance;
            this.gameObject.tag = val_5.geometryTag;
            val_15 = 1152921504851574784;
            if(((UnityEngine.Object.op_Implicit(exists:  this.<coneMesh>k__BackingField)) != false) && (this.m_CurrentMeshType == 1))
            {
                    UnityEngine.Object.DestroyImmediate(obj:  this.<coneMesh>k__BackingField);
            }
            
            val_16 = this.m_Master;
            if(val_16 == null)
            {
                goto label_19;
            }
            
            this.m_CurrentMeshType = this.m_Master.geomMeshType;
            goto label_20;
            label_4:
            int val_8 = this.m_Master.gameObject.layer;
            if(val_2 != null)
            {
                goto label_23;
            }
            
            goto label_24;
            label_19:
            val_16 = this.m_Master;
            this.m_CurrentMeshType = this.m_Master.geomMeshType;
            if(this.m_Master == null)
            {
                goto label_39;
            }
            
            label_20:
            if(this.m_Master.geomMeshType == 0)
            {
                goto label_26;
            }
            
            if(this.m_Master.geomMeshType != 1)
            {
                goto label_27;
            }
            
            val_17 = this.m_Master;
            if(val_17 == null)
            {
                goto label_28;
            }
            
            val_18 = this.m_Master.geomCustomSides;
            val_19 = val_17;
            goto label_38;
            label_26:
            UnityEngine.Mesh val_9 = VLB.GlobalMesh.Get();
            val_15 = this.<meshFilter>k__BackingField;
            this.<coneMesh>k__BackingField = val_9;
            val_15.sharedMesh = val_9;
            goto label_36;
            label_27:
            UnityEngine.Debug.LogError(message:  "Unsupported MeshType");
            goto label_36;
            label_28:
            val_19 = this.m_Master;
            val_18 = this.m_Master.geomCustomSides;
            if(val_19 == null)
            {
                goto label_37;
            }
            
            val_17 = val_19;
            goto label_38;
            label_37:
            val_17 = this.m_Master;
            if(val_17 == null)
            {
                goto label_39;
            }
            
            label_38:
            VLB.Config val_10 = VLB.Config.Instance;
            UnityEngine.Mesh val_13 = VLB.MeshGenerator.GenerateConeZ_Radius(lengthZ:  1f, radiusStart:  1f, radiusEnd:  1f, numSides:  val_18, numSegments:  this.m_Master.geomCustomSegments, cap:  (this.m_Master.geomCap == true) ? 1 : 0, doubleSided:  (val_10.renderingMode != 0) ? 1 : 0);
            this.<coneMesh>k__BackingField = val_13;
            val_13.hideFlags = VLB.Consts.ProceduralObjectsHideFlags;
            val_15 = this.<coneMesh>k__BackingField;
            this.<meshFilter>k__BackingField.mesh = val_15;
            label_36:
            this.UpdateMaterialAndBounds();
            return;
            label_39:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ComputeLocalMatrix()
        {
            VLB.VolumetricLightBeam val_4;
            float val_5;
            val_4 = this.m_Master;
            if(val_4 != null)
            {
                    val_5 = this.m_Master.coneRadiusStart;
            }
            else
            {
                    val_5 = this.m_Master.coneRadiusStart;
                if(this.m_Master != null)
            {
                    val_4 = this.m_Master;
            }
            else
            {
                    val_4 = 0;
            }
            
            }
            
            float val_2 = UnityEngine.Mathf.Max(a:  val_5, b:  val_4.coneRadiusEnd);
            this.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool get_isNoiseEnabled()
        {
            if(this.m_Master.noiseEnabled == false)
            {
                    return false;
            }
            
            this = this.m_Master;
            if(this.m_Master.noiseIntensity <= 0f)
            {
                    return false;
            }
            
            return VLB.Noise3D.isSupported;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool get_isClippingPlaneEnabled()
        {
            return (bool)(S0 > 0f) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool get_isDepthBlendEnabled()
        {
            var val_3;
            if(VLB.GpuInstancing.forceEnableDepthBlend == false)
            {
                    return (bool)(this.m_Master.depthBlendDistance > 0f) ? 1 : 0;
            }
            
            val_3 = 1;
            return (bool)(this.m_Master.depthBlendDistance > 0f) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool ApplyMaterial()
        {
            MaterialManager.ColorGradient val_13;
            UnityEngine.Material val_14;
            if(this.m_Master.colorMode == 1)
            {
                    var val_2 = (VLB.Utils.GetFloatPackingPrecision() == 64) ? (1 + 1) : 1;
            }
            else
            {
                    val_13 = 0;
            }
            
            MaterialManager.StaticProperties val_3 = new MaterialManager.StaticProperties();
            .blendingMode = this.m_Master.blendingMode;
            .noise3D = this.isNoiseEnabled;
            bool val_7 = this.isDepthBlendEnabled;
            if(val_3 != null)
            {
                    .depthBlend = val_7;
            }
            else
            {
                    mem[24] = val_7;
            }
            
            .colorGradient = val_13;
            .clippingPlane = this.isClippingPlaneEnabled;
            VLB.Config val_10 = VLB.Config.Instance;
            if(val_10.renderingMode == 2)
            {
                    val_14 = VLB.MaterialManager.GetInstancedMaterial(groupID:  this.m_Master.<_INTERNAL_InstancedMaterialGroupID>k__BackingField, staticProps:  val_3);
            }
            else
            {
                    val_14 = this.m_CustomMaterial;
                if((UnityEngine.Object.op_Implicit(exists:  val_14)) != false)
            {
                    val_3.ApplyToMaterial(mat:  val_14);
            }
            
            }
            
            this.<meshRenderer>k__BackingField.material = val_14;
            return UnityEngine.Object.op_Inequality(x:  val_14, y:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetMaterialProp(string name, float value)
        {
            var val_2;
            if((UnityEngine.Object.op_Implicit(exists:  this.m_CustomMaterial)) != false)
            {
                    this.m_CustomMaterial.SetFloat(name:  name, value:  value);
                return;
            }
            
            val_2 = null;
            val_2 = null;
            VLB.MaterialManager.materialPropertyBlock.SetFloat(name:  name, value:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetMaterialProp(string name, UnityEngine.Vector4 value)
        {
            var val_2;
            if((UnityEngine.Object.op_Implicit(exists:  this.m_CustomMaterial)) != false)
            {
                    this.m_CustomMaterial.SetVector(name:  name, value:  new UnityEngine.Vector4() {x = value.x, y = value.y, z = value.z, w = value.w});
                return;
            }
            
            val_2 = null;
            val_2 = null;
            VLB.MaterialManager.materialPropertyBlock.SetVector(name:  name, value:  new UnityEngine.Vector4() {x = value.x, y = value.y, z = value.z, w = value.w});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetMaterialProp(string name, UnityEngine.Color value)
        {
            var val_2;
            if((UnityEngine.Object.op_Implicit(exists:  this.m_CustomMaterial)) != false)
            {
                    this.m_CustomMaterial.SetColor(name:  name, value:  new UnityEngine.Color() {r = value.r, g = value.g, b = value.b, a = value.a});
                return;
            }
            
            val_2 = null;
            val_2 = null;
            VLB.MaterialManager.materialPropertyBlock.SetColor(name:  name, value:  new UnityEngine.Color() {r = value.r, g = value.g, b = value.b, a = value.a});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetMaterialProp(string name, UnityEngine.Matrix4x4 value)
        {
            UnityEngine.Material val_2;
            var val_3;
            if((UnityEngine.Object.op_Implicit(exists:  this.m_CustomMaterial)) != false)
            {
                    val_2 = this.m_CustomMaterial;
                val_2.SetMatrix(name:  name, value:  new UnityEngine.Matrix4x4() {m00 = value.m00, m01 = value.m01, m02 = value.m02, m03 = value.m03});
                return;
            }
            
            val_3 = null;
            val_3 = null;
            val_2 = VLB.MaterialManager.materialPropertyBlock;
            val_2.SetMatrix(name:  name, value:  new UnityEngine.Matrix4x4() {m00 = value.m00, m01 = value.m01, m02 = value.m02, m03 = value.m03});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void MaterialChangeStart()
        {
            var val_2;
            if(this.m_CustomMaterial != 0)
            {
                    return;
            }
            
            val_2 = null;
            val_2 = null;
            this.<meshRenderer>k__BackingField.GetPropertyBlock(properties:  VLB.MaterialManager.materialPropertyBlock);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void MaterialChangeStop()
        {
            var val_2;
            if(this.m_CustomMaterial != 0)
            {
                    return;
            }
            
            val_2 = null;
            val_2 = null;
            this.<meshRenderer>k__BackingField.SetPropertyBlock(properties:  VLB.MaterialManager.materialPropertyBlock);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SendMaterialClippingPlaneProp()
        {
            this.SetMaterialProp(name:  "_ClippingPlaneWS", value:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void UpdateMaterialAndBounds()
        {
            var val_19;
            var val_20;
            var val_21;
            UnityEngine.Matrix4x4 val_22;
            float val_31;
            float val_32;
            float val_33;
            float val_34;
            VLB.VolumetricLightBeam val_35;
            UnityEngine.Vector3 val_36;
            VLB.VolumetricLightBeam val_37;
            if(this.ApplyMaterial() == false)
            {
                    return;
            }
            
            this.MaterialChangeStart();
            if(this.isClippingPlaneEnabled != false)
            {
                    if(this.m_CustomMaterial == 0)
            {
                    this.SendMaterialClippingPlaneProp();
            }
            
            }
            
            float val_4 = this.m_Master.coneAngle;
            val_4 = val_4 * 0.01745329f;
            float val_5 = val_4 * 0.5f;
            UnityEngine.Vector2 val_6 = new UnityEngine.Vector2(x:  val_5, y:  val_5);
            UnityEngine.Vector4 val_7 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y});
            this.SetMaterialProp(name:  "_ConeSlopeCosSin", value:  new UnityEngine.Vector4() {x = val_7.x, y = val_7.y, z = val_7.z, w = val_7.w});
            UnityEngine.Vector2 val_11 = new UnityEngine.Vector2(x:  UnityEngine.Mathf.Max(a:  this.m_Master.coneRadiusStart, b:  0.0001f), y:  UnityEngine.Mathf.Max(a:  this.m_Master.coneRadiusEnd, b:  0.0001f));
            UnityEngine.Vector4 val_12 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector2() {x = val_11.x, y = val_11.y});
            this.SetMaterialProp(name:  "_ConeRadius", value:  new UnityEngine.Vector4() {x = val_12.x, y = val_12.y, z = val_12.z, w = val_12.w});
            float val_13 = this.m_Master.coneRadiusEnd;
            val_13 = this.m_Master.coneRadiusStart / val_13;
            val_31 = 1f;
            if(val_13 == val_31)
            {
                    val_32 = 3.402823E+38f;
            }
            else
            {
                    float val_30 = this.m_Master.fallOffEnd;
                val_30 = val_13 * val_30;
                val_13 = val_31 - val_13;
                val_32 = val_30 / val_13;
            }
            
            float val_15 = this.m_Master.coneRadiusEnd;
            val_15 = this.m_Master.coneRadiusStart / val_15;
            if(val_15 == val_31)
            {
                    val_33 = 3.402823E+38f;
            }
            else
            {
                    float val_31 = this.m_Master.fallOffEnd;
                val_31 = val_15 * val_31;
                val_15 = val_31 - val_15;
                val_33 = val_31 / val_15;
            }
            
            float val_16 = UnityEngine.Mathf.Max(a:  System.Math.Abs(val_33), b:  0.0001f);
            val_16 = (UnityEngine.Mathf.Sign(f:  val_32)) * val_16;
            this.SetMaterialProp(name:  "_ConeApexOffsetZ", value:  val_16);
            if(this.m_Master.colorMode != 0)
            {
                    UnityEngine.Matrix4x4 val_18 = VLB.Utils.SampleInMatrix(self:  this.m_Master.colorGradient, floatPackingPrecision:  VLB.Utils.GetFloatPackingPrecision());
                mem[1152921528909503552] = val_19;
                mem[1152921528909503536] = val_20;
                mem[1152921528909503520] = val_21;
                this.m_ColorGradientMatrix = val_22;
            }
            else
            {
                    this.SetMaterialProp(name:  "_ColorFlat", value:  new UnityEngine.Color() {r = this.m_Master.color, g = 0.0001f, b = val_12.z, a = val_12.w});
            }
            
            this.SetMaterialProp(name:  "_AlphaInside", value:  this.m_Master.intensityInside);
            this.SetMaterialProp(name:  "_AlphaOutside", value:  this.m_Master.intensityOutside);
            if(this.m_Master.attenuationEquation == 0)
            {
                goto label_29;
            }
            
            if(this.m_Master.attenuationEquation == 1)
            {
                goto label_31;
            }
            
            val_31 = this.m_Master.attenuationCustomBlending;
            goto label_31;
            label_29:
            val_31 = 0f;
            label_31:
            this.SetMaterialProp(name:  "_AttenuationLerpLinearQuad", value:  val_31);
            this.SetMaterialProp(name:  "_DistanceFadeStart", value:  this.m_Master.fallOffStart);
            this.SetMaterialProp(name:  "_DistanceFadeEnd", value:  this.m_Master.fallOffEnd);
            this.SetMaterialProp(name:  "_DistanceCamClipping", value:  this.m_Master.cameraClippingDistance);
            val_34 = this.m_Master.fresnelPow;
            this.SetMaterialProp(name:  "_FresnelPow", value:  UnityEngine.Mathf.Max(a:  0.001f, b:  val_34));
            this.SetMaterialProp(name:  "_GlareBehind", value:  this.m_Master.glareBehind);
            this.SetMaterialProp(name:  "_GlareFrontal", value:  this.m_Master.glareFrontal);
            this.SetMaterialProp(name:  "_DrawCap", value:  (this.m_Master.geomCap == true) ? 1f : 0f);
            if(this.isDepthBlendEnabled != false)
            {
                    this.SetMaterialProp(name:  "_DepthBlendDistance", value:  this.m_Master.depthBlendDistance);
            }
            
            if(this.isNoiseEnabled == false)
            {
                goto label_43;
            }
            
            VLB.Noise3D.LoadIfNeeded();
            val_35 = this.m_Master;
            if(val_35 == null)
            {
                goto label_46;
            }
            
            val_36 = this.m_Master.noiseVelocityLocal;
            goto label_47;
            label_46:
            val_36 = this.m_Master.noiseVelocityLocal;
            if(this.m_Master == null)
            {
                goto label_48;
            }
            
            val_35 = this.m_Master;
            label_47:
            label_54:
            label_55:
            this.SetMaterialProp(name:  "_NoiseLocal", value:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
            val_37 = this.m_Master;
            if(this.m_Master != null)
            {
                goto label_49;
            }
            
            val_37 = this.m_Master;
            if(val_37 == null)
            {
                goto label_50;
            }
            
            label_49:
            val_34 = this.m_Master.noiseIntensity;
            var val_27 = (this.m_Master.noiseVelocityUseGlobal == true) ? 1f : 0f;
            var val_28 = (this.m_Master.noiseScaleUseGlobal == true) ? 1f : 0f;
            UnityEngine.Vector4 val_29 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            this.SetMaterialProp(name:  "_NoiseParam", value:  new UnityEngine.Vector4() {x = val_29.x, y = val_29.y, z = val_29.z, w = val_29.w});
            label_43:
            this.MaterialChangeStop();
            this.ComputeLocalMatrix();
            return;
            label_48:
            if(this.m_Master != null)
            {
                goto label_54;
            }
            
            if(this.m_Master != null)
            {
                goto label_55;
            }
            
            label_50:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetClippingPlane(UnityEngine.Plane planeWS)
        {
            this.m_ClippingPlaneWS = V0.16B;
            mem[1152921528909750940] = V1.16B;
            mem[1152921528909750944] = V2.16B;
            mem[1152921528909750948] = V3.16B;
            if((UnityEngine.Object.op_Implicit(exists:  this.m_CustomMaterial)) != false)
            {
                    this.m_CustomMaterial.EnableKeyword(keyword:  "VLB_CLIPPING_PLANE");
                this.SendMaterialClippingPlaneProp();
                return;
            }
            
            this.UpdateMaterialAndBounds();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetClippingPlaneOff()
        {
            this.m_ClippingPlaneWS = 0;
            mem[1152921528909879328] = 0;
            if((UnityEngine.Object.op_Implicit(exists:  this.m_CustomMaterial)) != false)
            {
                    this.m_CustomMaterial.DisableKeyword(keyword:  "VLB_CLIPPING_PLANE");
                return;
            }
            
            this.UpdateMaterialAndBounds();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnBeginCameraRendering(UnityEngine.Camera cam)
        {
            this.UpdateCameraRelatedProperties(cam:  cam);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnWillRenderObject()
        {
            if(VLB.BeamGeometry.IsUsingCustomRenderPipeline() == true)
            {
                    return;
            }
            
            UnityEngine.Camera val_2 = UnityEngine.Camera.current;
            if(val_2 == 0)
            {
                    return;
            }
            
            this.UpdateCameraRelatedProperties(cam:  val_2);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static bool IsEditorCamera(UnityEngine.Camera cam)
        {
            return false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateCameraRelatedProperties(UnityEngine.Camera cam)
        {
            var val_16;
            VLB.VolumetricLightBeam val_17;
            float val_19;
            var val_20;
            val_16 = this;
            val_17 = 1152921504851574784;
            if((UnityEngine.Object.op_Implicit(exists:  cam)) == false)
            {
                    return;
            }
            
            val_17 = this.m_Master;
            if((UnityEngine.Object.op_Implicit(exists:  val_17)) == false)
            {
                    return;
            }
            
            this.MaterialChangeStart();
            UnityEngine.Vector3 val_5 = cam.transform.position;
            UnityEngine.Vector3 val_6 = this.m_Master.transform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            UnityEngine.Vector3 val_9 = cam.transform.forward;
            UnityEngine.Vector3 val_10 = this.transform.InverseTransformDirection(direction:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
            if(cam.orthographic != false)
            {
                    val_19 = -1f;
            }
            else
            {
                    val_19 = this.m_Master.GetInsideBeamFactorFromObjectSpacePos(posOS:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
            }
            
            this.SetMaterialProp(name:  "_CameraParams", value:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
            val_17 = this.m_Master;
            if(this.m_Master.colorMode == 1)
            {
                    this.SetMaterialProp(name:  "_ColorGradientMatrix", value:  new UnityEngine.Matrix4x4() {m00 = this.m_ColorGradientMatrix, m10 = this.m_ColorGradientMatrix, m20 = this.m_ColorGradientMatrix, m30 = this.m_ColorGradientMatrix, m01 = 0f, m11 = 0f, m21 = 0f, m31 = 0f, m02 = 0f, m12 = 0f, m22 = 0f, m32 = 0f, m03 = 0f, m13 = 0f, m23 = 0f, m33 = 0f});
            }
            
            this.MaterialChangeStop();
            if(this.m_Master.depthBlendDistance <= 0f)
            {
                    return;
            }
            
            if(cam != null)
            {
                    val_20 = cam.depthTextureMode;
            }
            else
            {
                    val_20 = 0.depthTextureMode;
            }
            
            cam.depthTextureMode = val_20 | 1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public BeamGeometry()
        {
        
        }
    
    }

}
