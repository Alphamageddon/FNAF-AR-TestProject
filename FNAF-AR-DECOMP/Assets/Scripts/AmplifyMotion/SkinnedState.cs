using UnityEngine;

namespace AmplifyMotion
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal class SkinnedState : MotionState
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.SkinnedMeshRenderer m_renderer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int m_boneCount;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Transform[] m_boneTransforms;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AmplifyMotion.MotionState.Matrix3x4[] m_bones;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int m_weightCount;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int[] m_boneIndices;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float[] m_boneWeights;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int m_vertexCount;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector4[] m_baseVertices;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3[] m_prevVertices;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3[] m_currVertices;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int m_gpuBoneTexWidth;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int m_gpuBoneTexHeight;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int m_gpuVertexTexWidth;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int m_gpuVertexTexHeight;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Material m_gpuSkinDeformMat;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Color[] m_gpuBoneData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Texture2D m_gpuBones;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Texture2D m_gpuBoneIndices;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Texture2D[] m_gpuBaseVertices;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.RenderTexture m_gpuPrevVertices;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.RenderTexture m_gpuCurrVertices;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Mesh m_clonedMesh;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AmplifyMotion.MotionState.Matrix3x4 m_worldToLocalMatrix;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AmplifyMotion.MotionState.Matrix3x4 m_prevLocalToWorld;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AmplifyMotion.MotionState.Matrix3x4 m_currLocalToWorld;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AmplifyMotion.MotionState.MaterialDesc[] m_sharedMaterials;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Threading.ManualResetEvent m_asyncUpdateSignal;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool m_asyncUpdateTriggered;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool m_starting;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool m_wasVisible;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool m_useFallback;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool m_useGPU;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static System.Collections.Generic.HashSet<AmplifyMotionObjectBase> m_uniqueWarnings;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SkinnedState(AmplifyMotionCamera owner, AmplifyMotionObjectBase obj)
        {
            this.m_renderer = obj.GetComponent<UnityEngine.SkinnedMeshRenderer>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void IssueWarning(string message)
        {
            var val_3;
            var val_4;
            val_3 = null;
            val_3 = null;
            if((AmplifyMotion.SkinnedState.m_uniqueWarnings.Contains(item:  X22)) != false)
            {
                    return;
            }
            
            UnityEngine.Debug.LogWarning(message:  message);
            val_4 = null;
            val_4 = null;
            bool val_2 = AmplifyMotion.SkinnedState.m_uniqueWarnings.Add(item:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void IssueError(string message)
        {
            this.IssueWarning(message:  message);
            mem[1152921520136335648] = 1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal override void Initialize()
        {
            bool val_40;
            int val_42;
            System.Single[] val_43;
            var val_44;
            UnityEngine.Mesh val_1 = this.m_renderer.sharedMesh;
            if(val_1.isReadable == false)
            {
                goto label_3;
            }
            
            if(this.m_renderer.bones == null)
            {
                goto label_5;
            }
            
            var val_4 = (val_3.Length == 0) ? 1 : 0;
            goto label_6;
            label_3:
            this.IssueWarning(message:  "[AmplifyMotion] Read/Write Import Setting disabled in object "("[AmplifyMotion] Read/Write Import Setting disabled in object ") + val_1.name + ". Skipping.");
            mem[1152921520136915120] = 1;
            return;
            label_5:
            val_40 = true;
            label_6:
            this.m_useFallback = val_40;
            if(val_40 == 0)
            {
                    this.m_useGPU = this.m_renderer.CanUseGPU;
            }
            
            mem[1152921520136915121] = 1;
            this.m_vertexCount = this.m_renderer.sharedMesh.vertexCount;
            this.m_prevVertices = new UnityEngine.Vector3[0];
            this.m_currVertices = new UnityEngine.Vector3[0];
            this.m_clonedMesh = new UnityEngine.Mesh();
            if(this.m_useFallback == true)
            {
                goto label_44;
            }
            
            if(this.m_renderer.quality != 0)
            {
                    UnityEngine.SkinQuality val_15 = this.m_renderer.quality;
            }
            
            this.m_weightCount = UnityEngine.QualitySettings.blendWeights;
            this.m_boneTransforms = this.m_renderer.bones;
            UnityEngine.Transform[] val_18 = this.m_renderer.bones;
            this.m_boneCount = val_18.Length;
            int val_19 = val_18.Length & 4294967295;
            this.m_bones = new Matrix3x4[0];
            int val_21 = this.m_weightCount * this.m_vertexCount;
            UnityEngine.Vector4[] val_22 = new UnityEngine.Vector4[0];
            int val_23 = this.m_weightCount * this.m_vertexCount;
            int[] val_24 = new int[0];
            val_42 = this.m_weightCount;
            if(val_42 >= 2)
            {
                    int val_25 = this.m_vertexCount * val_42;
                val_42 = this.m_weightCount;
                val_43 = new float[0];
            }
            else
            {
                    val_43 = 0;
            }
            
            if(val_42 == 2)
            {
                goto label_24;
            }
            
            if(val_42 != 1)
            {
                goto label_25;
            }
            
            this.InitializeBone1(baseVertices:  val_22, boneIndices:  val_24);
            goto label_27;
            label_24:
            this.InitializeBone2(baseVertices:  val_22, boneIndices:  val_24, boneWeights:  val_43);
            goto label_27;
            label_25:
            this.InitializeBone4(baseVertices:  val_22, boneIndices:  val_24, boneWeights:  val_43);
            label_27:
            this.m_baseVertices = val_22;
            mem[1152921520136915192] = val_24;
            mem[1152921520136915200] = val_43;
            UnityEngine.Mesh val_27 = this.m_renderer.sharedMesh;
            this.m_clonedMesh.vertices = val_27.vertices;
            this.m_clonedMesh.normals = val_27.vertices;
            this.m_clonedMesh.uv = val_27.uv;
            this.m_clonedMesh.subMeshCount = val_27.subMeshCount;
            val_44 = 0;
            goto label_37;
            label_41:
            this.m_clonedMesh.SetTriangles(triangles:  val_27.GetTriangles(submesh:  0), submesh:  0);
            val_44 = 1;
            label_37:
            if(val_44 < val_27.subMeshCount)
            {
                goto label_41;
            }
            
            if(this.m_useGPU == false)
            {
                goto label_45;
            }
            
            if(this.InitializeGPUSkinDeform() == false)
            {
                goto label_43;
            }
            
            mem[1152921520136915192] = 0;
            mem[1152921520136915200] = 0;
            mem[1152921520136915224] = 0;
            mem[1152921520136915232] = 0;
            mem[1152921520136915216] = 0;
            if(this.m_useGPU == true)
            {
                goto label_44;
            }
            
            goto label_45;
            label_43:
            UnityEngine.Debug.LogWarning(message:  "[AmplifyMotion] Failed initializing GPU skin deform for object " + val_27.name + ". Falling back to CPU path.");
            this.m_useGPU = false;
            label_45:
            this.m_asyncUpdateSignal = new System.Threading.ManualResetEvent(initialState:  false);
            this.m_asyncUpdateTriggered = false;
            label_44:
            UnityEngine.Material[] val_38 = this.m_renderer.sharedMaterials;
            this.m_sharedMaterials = val_38.ProcessSharedMaterials(mats:  val_38);
            this.m_wasVisible = false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal override void Shutdown()
        {
            if(this.m_useFallback == false)
            {
                goto label_1;
            }
            
            label_10:
            if(this.m_useGPU == true)
            {
                goto label_2;
            }
            
            goto label_3;
            label_1:
            if(this.m_useGPU == false)
            {
                goto label_4;
            }
            
            label_2:
            this.ShutdownGPUSkinDeform();
            label_3:
            if(this.m_clonedMesh != 0)
            {
                    UnityEngine.Object.Destroy(obj:  this.m_clonedMesh);
                this.m_clonedMesh = 0;
            }
            
            this.m_sharedMaterials = 0;
            this.m_boneTransforms = 0;
            this.m_bones = 0;
            this.m_boneIndices = 0;
            this.m_boneWeights = 0;
            this.m_prevVertices = 0;
            this.m_currVertices = 0;
            this.m_baseVertices = 0;
            return;
            label_4:
            this.WaitForAsyncUpdate();
            goto label_10;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool InitializeGPUSkinDeform()
        {
            float val_48;
            UnityEngine.Vector4[] val_49;
            var val_50;
            var val_51;
            int val_52;
            var val_57;
            UnityEngine.Color val_58;
            UnityEngine.Texture2D[] val_59;
            int val_60;
            int val_61;
            int val_62;
            float val_63;
            int val_64;
            UnityEngine.Material val_65;
            UnityEngine.Mesh val_66;
            var val_67;
            this.m_gpuBoneTexWidth = this.m_boneCount;
            this.m_gpuBoneTexHeight = 3;
            int val_1 = UnityEngine.Mathf.CeilToInt(f:  (float)this.m_vertexCount);
            val_48 = (float)val_1;
            this.m_gpuVertexTexWidth = val_1;
            float val_48 = (float)this.m_vertexCount;
            val_48 = val_48 / val_48;
            this.m_gpuVertexTexHeight = UnityEngine.Mathf.CeilToInt(f:  val_48);
            new UnityEngine.Material() = new UnityEngine.Material(shader:  UnityEngine.Shader.Find(name:  "Hidden/Amplify Motion/GPUSkinDeform"));
            new UnityEngine.Material().hideFlags = 52;
            this.m_gpuSkinDeformMat = new UnityEngine.Material();
            new UnityEngine.Texture2D() = new UnityEngine.Texture2D(width:  this.m_gpuBoneTexWidth, height:  this.m_gpuBoneTexHeight, textureFormat:  20, mipChain:  false, linear:  true);
            this.m_gpuBones = new UnityEngine.Texture2D();
            new UnityEngine.Texture2D().hideFlags = 52;
            val_49 = "AM-";
            val_50 = "-Bones";
            this.m_gpuBones.name = "AM-"("AM-") + this.m_gpuBoneTexWidth.name + "-Bones"("-Bones");
            this.m_gpuBones.filterMode = 0;
            val_51 = 1152921505977891136;
            int val_8 = this.m_gpuBoneTexHeight * this.m_gpuBoneTexWidth;
            this.m_gpuBoneData = new UnityEngine.Color[0];
            this.UpdateBonesGPU();
            val_52 = this.m_gpuVertexTexHeight;
            new UnityEngine.Texture2D() = new UnityEngine.Texture2D(width:  this.m_gpuVertexTexWidth, height:  val_52, textureFormat:  (this.m_weightCount == 4) ? 17 : ((this.m_weightCount == 2) ? (15 + 1) : 15), mipChain:  false, linear:  true);
            this.m_gpuBoneIndices = new UnityEngine.Texture2D();
            new UnityEngine.Texture2D().hideFlags = 52;
            this.m_gpuBoneIndices.name = "AM-"("AM-") + this.m_gpuVertexTexWidth.name + "-Bones"("-Bones");
            this.m_gpuBoneIndices.filterMode = 0;
            this.m_gpuBoneIndices.wrapMode = 1;
            int val_17 = this.m_gpuVertexTexHeight * this.m_gpuVertexTexWidth;
            UnityEngine.Color[] val_18 = new UnityEngine.Color[0];
            if(this.m_vertexCount >= 1)
            {
                    var val_51 = 0;
                do
            {
                val_49 = 0;
                UnityEngine.BoneWeight val_49 = this.m_renderer.sharedMesh.boneWeights[0];
                UnityEngine.BoneWeight val_50 = this.m_renderer.sharedMesh.boneWeights[0];
                val_52 = val_49.region;
                val_50 = val_49.WireType;
                int val_21 = val_49.Position;
                int val_22 = val_49.Length;
                val_48 = 0f;
                UnityEngine.Color val_23 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = val_48, z = 0f, w = 0f});
                val_57 = val_23.r;
                val_58 = val_23.b;
                val_18[0] = val_23;
                val_18[0] = val_23.g;
                val_18[0] = val_58;
                val_18[0] = val_23.a;
                val_51 = val_51 + 1;
            }
            while(val_51 < this.m_vertexCount);
            
            }
            
            this.m_gpuBoneIndices.SetPixels(colors:  val_18);
            this.m_gpuBoneIndices.Apply();
            val_59 = new UnityEngine.Texture2D[0];
            val_60 = this.m_weightCount;
            this.m_gpuBaseVertices = val_59;
            if(val_60 < 1)
            {
                goto label_24;
            }
            
            var val_55 = 0;
            goto label_25;
            label_40:
            val_59 = this.m_gpuBaseVertices;
            label_25:
            new UnityEngine.Texture2D() = new UnityEngine.Texture2D(width:  this.m_gpuVertexTexWidth, height:  this.m_gpuVertexTexHeight, textureFormat:  20, mipChain:  false, linear:  true);
            val_52 = 0;
            val_59[val_52] = new UnityEngine.Texture2D();
            this.m_gpuBaseVertices[val_52].hideFlags = 52;
            this.m_gpuBaseVertices[val_52].name = "AM-"("AM-") + new UnityEngine.Texture2D().name + "-BaseVerts"("-BaseVerts");
            this.m_gpuBaseVertices[val_52].filterMode = 0;
            val_60 = this.m_weightCount;
            val_55 = val_55 + 1;
            if(val_55 < val_60)
            {
                goto label_40;
            }
            
            label_24:
            System.Collections.Generic.List<UnityEngine.Color[]> val_28 = new System.Collections.Generic.List<UnityEngine.Color[]>(capacity:  val_60);
            val_61 = this.m_weightCount;
            if(val_61 >= 1)
            {
                    do
            {
                int val_29 = this.m_gpuVertexTexHeight * this.m_gpuVertexTexWidth;
                null.Add(item:  new UnityEngine.Color[0]);
                val_61 = this.m_weightCount;
                val_52 = 0 + 1;
            }
            while(val_52 < val_61);
            
            }
            
            val_62 = this.m_vertexCount;
            if(val_62 >= 1)
            {
                    var val_60 = 0;
                do
            {
                if(val_61 >= 1)
            {
                    var val_59 = 0;
                do
            {
                val_52 = null.Item[0];
                val_49 = this.m_baseVertices;
                val_51 = val_59 + (val_60 * this.m_weightCount);
                val_48 = val_49[(long)val_51];
                UnityEngine.Color val_32 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = val_49[(long)val_51], y = val_48, z = val_49[(long)val_51], w = val_49[(long)val_51]});
                val_57 = val_32.r;
                val_58 = val_32.b;
                val_52[0] = val_32;
                val_52[0] = val_32.g;
                val_52[0] = val_58;
                val_52[0] = val_32.a;
                val_61 = this.m_weightCount;
                val_59 = val_59 + 1;
            }
            while(val_59 < val_61);
            
                val_62 = this.m_vertexCount;
            }
            
                val_60 = val_60 + 1;
            }
            while(val_60 < val_62);
            
            }
            
            if(val_61 >= 1)
            {
                    var val_62 = 0;
                do
            {
                val_49 = 0;
                this.m_gpuBaseVertices[val_49].SetPixels(colors:  null.Item[0]);
                val_52 = this.m_gpuBaseVertices[val_49];
                val_52.Apply();
                val_62 = val_62 + 1;
            }
            while(val_62 < this.m_weightCount);
            
            }
            
            val_63 = 1152921504851148800;
            new UnityEngine.RenderTexture() = new UnityEngine.RenderTexture(width:  this.m_gpuVertexTexWidth, height:  this.m_gpuVertexTexHeight, depth:  0, format:  11, readWrite:  1);
            this.m_gpuPrevVertices = new UnityEngine.RenderTexture();
            new UnityEngine.RenderTexture().hideFlags = 52;
            this.m_gpuPrevVertices.name = "AM-"("AM-") + this.m_gpuVertexTexWidth.name + "-PrevVerts"("-PrevVerts");
            this.m_gpuPrevVertices.filterMode = 0;
            this.m_gpuPrevVertices.wrapMode = 1;
            bool val_37 = this.m_gpuPrevVertices.Create();
            val_64 = this.m_gpuVertexTexHeight;
            new UnityEngine.RenderTexture() = new UnityEngine.RenderTexture(width:  this.m_gpuVertexTexWidth, height:  val_64, depth:  0, format:  11, readWrite:  1);
            this.m_gpuCurrVertices = new UnityEngine.RenderTexture();
            new UnityEngine.RenderTexture().hideFlags = 52;
            this.m_gpuCurrVertices.name = "AM-"("AM-") + this.m_gpuVertexTexWidth.name + "-CurrVerts"("-CurrVerts");
            this.m_gpuCurrVertices.filterMode = 0;
            this.m_gpuCurrVertices.wrapMode = 1;
            bool val_41 = this.m_gpuCurrVertices.Create();
            this.m_gpuSkinDeformMat.SetTexture(name:  "_AM_BONE_TEX", value:  this.m_gpuBones);
            val_65 = this.m_gpuSkinDeformMat;
            val_65.SetTexture(name:  "_AM_BONE_INDEX_TEX", value:  this.m_gpuBoneIndices);
            if(this.m_weightCount >= 1)
            {
                    val_49 = "_AM_BASE_VERTEX";
                do
            {
                val_65 = "_AM_BASE_VERTEX" + 0 + "_TEX";
                val_64 = this.m_gpuBaseVertices[0];
                this.m_gpuSkinDeformMat.SetTexture(name:  val_65, value:  val_64);
                val_63 = 0 + 1;
            }
            while(val_63 < this.m_weightCount);
            
            }
            
            int val_63 = this.m_gpuBoneTexWidth;
            int val_64 = this.m_gpuBoneTexHeight;
            val_63 = 1f / (float)val_63;
            val_64 = 1f / (float)val_64;
            int val_65 = this.m_gpuVertexTexWidth;
            int val_66 = this.m_gpuVertexTexHeight;
            val_65 = 1f / (float)val_65;
            val_66 = 1f / (float)val_66;
            this.m_gpuSkinDeformMat.SetVector(name:  "_AM_BONE_TEXEL_SIZE", value:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
            UnityEngine.Vector4 val_43 = UnityEngine.Vector4.op_Multiply(a:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f}, d:  0.5f);
            this.m_gpuSkinDeformMat.SetVector(name:  "_AM_BONE_TEXEL_HALFSIZE", value:  new UnityEngine.Vector4() {x = val_43.x, y = val_43.y, z = val_43.z, w = val_43.w});
            this.m_gpuSkinDeformMat.SetVector(name:  "_AM_VERTEX_TEXEL_SIZE", value:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
            UnityEngine.Vector4 val_44 = UnityEngine.Vector4.op_Multiply(a:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f}, d:  0.5f);
            this.m_gpuSkinDeformMat.SetVector(name:  "_AM_VERTEX_TEXEL_HALFSIZE", value:  new UnityEngine.Vector4() {x = val_44.x, y = val_44.y, z = val_44.z, w = val_44.w});
            UnityEngine.Vector2[] val_45 = new UnityEngine.Vector2[0];
            if(this.m_vertexCount >= 1)
            {
                    do
            {
                int val_67 = this.m_gpuVertexTexWidth;
                float val_70 = 0f;
                float val_71 = 0f;
                int val_46 = 0 / val_67;
                float val_69 = (float)val_67;
                float val_68 = (float)this.m_gpuVertexTexHeight;
                val_67 = 0 - (val_46 * val_67);
                val_68 = (float)val_46 / val_68;
                val_69 = (float)val_67 / val_69;
                val_70 = val_70 * 0.5f;
                val_71 = val_71 * 0.5f;
                val_68 = val_68 + val_71;
                val_70 = val_70 + val_69;
                UnityEngine.Vector2 val_47 = new UnityEngine.Vector2(x:  val_70, y:  val_68);
                val_63 = val_47.x;
                val_45[0] = val_63;
                val_45[0] = val_47.y;
                val_65 = 0 + 1;
            }
            while(val_65 < this.m_vertexCount);
            
            }
            
            val_66 = this.m_clonedMesh;
            val_66.uv2 = val_45;
            val_67 = 1;
            return (bool)val_67;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ShutdownGPUSkinDeform()
        {
            UnityEngine.Texture2D[] val_6;
            var val_7;
            if(this.m_gpuSkinDeformMat != 0)
            {
                    UnityEngine.Object.DestroyImmediate(obj:  this.m_gpuSkinDeformMat);
                this.m_gpuSkinDeformMat = 0;
            }
            
            this.m_gpuBoneData = 0;
            if(this.m_gpuBones != 0)
            {
                    UnityEngine.Object.DestroyImmediate(obj:  this.m_gpuBones);
                this.m_gpuBones = 0;
            }
            
            if(this.m_gpuBoneIndices != 0)
            {
                    UnityEngine.Object.DestroyImmediate(obj:  this.m_gpuBoneIndices);
                this.m_gpuBoneIndices = 0;
            }
            
            val_6 = this.m_gpuBaseVertices;
            if(val_6 == null)
            {
                goto label_16;
            }
            
            val_7 = 0;
            goto label_17;
            label_23:
            UnityEngine.Object.DestroyImmediate(obj:  this.m_gpuBaseVertices[0]);
            val_6 = this.m_gpuBaseVertices;
            val_7 = 1;
            label_17:
            if(val_7 < this.m_gpuBaseVertices.Length)
            {
                goto label_23;
            }
            
            this.m_gpuBaseVertices = 0;
            label_16:
            if(this.m_gpuPrevVertices != 0)
            {
                    UnityEngine.RenderTexture.active = 0;
                this.m_gpuPrevVertices.Release();
                UnityEngine.Object.DestroyImmediate(obj:  this.m_gpuPrevVertices);
                this.m_gpuPrevVertices = 0;
            }
            
            if(this.m_gpuCurrVertices == 0)
            {
                    return;
            }
            
            UnityEngine.RenderTexture.active = 0;
            this.m_gpuCurrVertices.Release();
            UnityEngine.Object.DestroyImmediate(obj:  this.m_gpuCurrVertices);
            this.m_gpuCurrVertices = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateBonesGPU()
        {
            int val_3 = this.m_boneCount;
            if(val_3 > 0)
            {
                    var val_6 = 0;
                do
            {
                if(this.m_gpuBoneTexHeight >= 1)
            {
                    var val_5 = 0;
                do
            {
                var val_2 = (this.m_bones + (0 * 48)) + 32;
                UnityEngine.Color val_3 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4());
                this.m_gpuBoneData[(long)val_6 + (this.m_gpuBoneTexWidth * val_5)] = val_3;
                this.m_gpuBoneData[(long)val_6 + (this.m_gpuBoneTexWidth * val_5)] = val_3.g;
                this.m_gpuBoneData[(long)val_6 + (this.m_gpuBoneTexWidth * val_5)] = val_3.b;
                this.m_gpuBoneData[(long)val_6 + (this.m_gpuBoneTexWidth * val_5)] = val_3.a;
                val_5 = val_5 + 1;
            }
            while(val_5 < this.m_gpuBoneTexHeight);
            
                val_3 = this.m_boneCount;
            }
            
                val_6 = val_6 + 1;
            }
            while(val_6 < val_3);
            
            }
            
            this.m_gpuBones.SetPixels(colors:  this.m_gpuBoneData);
            this.m_gpuBones.Apply();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateVerticesGPU(UnityEngine.Rendering.CommandBuffer updateCB, bool starting)
        {
            UnityEngine.CubemapFace val_2;
            UnityEngine.Rendering.BuiltinRenderTextureType val_3;
            IntPtr val_4;
            float val_10;
            float val_11;
            float val_12;
            float val_13;
            bool val_14;
            if((starting != true) && (this.m_wasVisible != false))
            {
                    this.m_gpuPrevVertices.DiscardContents();
                UnityEngine.Rendering.RenderTargetIdentifier val_1 = UnityEngine.Rendering.RenderTargetIdentifier.op_Implicit(tex:  this.m_gpuPrevVertices);
                updateCB.Blit(source:  new UnityEngine.Rendering.RenderTargetIdentifier(), dest:  new UnityEngine.Rendering.RenderTargetIdentifier() {m_Type = val_3, m_NameID = val_3, m_InstanceID = val_3, m_BufferPointer = val_4, m_MipLevel = val_4, m_CubeFace = val_2});
            }
            
            if(updateCB == null)
            {
                    val_10 = ???;
                val_13 = ???;
                val_11 = ???;
                val_12 = val_2;
            }
            
            updateCB.SetGlobalMatrix(name:  "_AM_WORLD_TO_LOCAL_MATRIX", value:  new UnityEngine.Matrix4x4() {m00 = this.m_worldToLocalMatrix, m10 = ???, m20 = ???, m30 = 0f, m01 = val_10, m11 = starting, m21 = this.m_gpuPrevVertices, m31 = 0f, m02 = val_11, m12 = ???, m22 = ???, m32 = 0f, m03 = val_12, m13 = val_13, m23 = ???, m33 = 1f});
            this.m_gpuCurrVertices.DiscardContents();
            UnityEngine.Rendering.RenderTargetIdentifier val_5 = UnityEngine.Rendering.RenderTargetIdentifier.op_Implicit(tex:  this.m_gpuCurrVertices);
            val_14 = starting;
            updateCB.Blit(source:  new UnityEngine.Rendering.RenderTargetIdentifier(), dest:  new UnityEngine.Rendering.RenderTargetIdentifier() {m_Type = val_3, m_NameID = val_3, m_InstanceID = val_3, m_BufferPointer = val_4, m_MipLevel = val_4, m_CubeFace = val_2}, mat:  this.m_gpuSkinDeformMat, pass:  UnityEngine.Mathf.Min(a:  this.m_weightCount - 1, b:  2));
            if(val_14 != true)
            {
                    if(this.m_wasVisible == true)
            {
                    return;
            }
            
            }
            
            val_14 = this.m_gpuPrevVertices;
            val_14.DiscardContents();
            UnityEngine.Rendering.RenderTargetIdentifier val_8 = UnityEngine.Rendering.RenderTargetIdentifier.op_Implicit(tex:  this.m_gpuPrevVertices);
            updateCB.Blit(source:  new UnityEngine.Rendering.RenderTargetIdentifier(), dest:  new UnityEngine.Rendering.RenderTargetIdentifier() {m_Type = val_3, m_NameID = val_3, m_InstanceID = val_3, m_BufferPointer = val_4, m_MipLevel = val_4, m_CubeFace = val_2});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateBones()
        {
            var val_4;
            var val_5;
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_17;
            AmplifyMotion.SkinnedState val_18;
            var val_19;
            UnityEngine.Transform val_20;
            var val_21;
            var val_22;
            var val_23;
            var val_24;
            var val_25;
            var val_26;
            var val_27;
            var val_28;
            Matrix3x4[] val_29;
            val_18 = this;
            if(this.m_boneCount >= 1)
            {
                    var val_17 = 0;
                do
            {
                val_19 = 0;
                val_20 = this.m_boneTransforms[val_19];
                val_21 = 0;
                if(val_20 != 0)
            {
                    if(val_17 >= this.m_boneTransforms.Length)
            {
                    val_21 = 0;
            }
            
                val_20 = this.m_boneTransforms[val_19];
                UnityEngine.Matrix4x4 val_2 = val_20.localToWorldMatrix;
            }
            else
            {
                    UnityEngine.Matrix4x4 val_3 = UnityEngine.Matrix4x4.identity;
            }
            
                val_23 = val_4;
                val_22 = val_5;
                val_24 = val_6;
                val_17 = val_7;
                val_25 = val_12;
                val_26 = val_13;
                val_27 = val_14;
                val_28 = val_15;
                val_29 = this.m_bones;
                if(val_29 == 0)
            {
                    val_19 = val_22;
                val_28 = val_28;
                val_27 = val_27;
                val_25 = val_25;
                val_17 = val_17;
                val_29 = this.m_bones;
                val_26 = val_26;
                val_24 = val_24;
                val_22 = val_19;
                val_23 = val_23;
            }
            
                if(val_17 >= (this.m_bones + 24))
            {
                    val_19 = val_27;
                val_24 = val_24;
                val_22 = val_22;
                val_23 = val_23;
                val_29 = this.m_bones;
                val_28 = val_28;
                val_27 = val_19;
                val_26 = val_26;
                val_25 = val_25;
            }
            
                var val_18 = 48;
                val_17 = val_17 + 1;
                val_18 = val_29 + (val_19 * val_18);
                mem2[0] = val_23;
                mem2[0] = val_17;
                mem2[0] = val_10;
                mem2[0] = val_26;
                mem2[0] = val_22;
                mem2[0] = val_8;
                mem2[0] = val_11;
                mem2[0] = val_27;
                mem2[0] = val_24;
                mem2[0] = val_9;
                mem2[0] = val_25;
                mem2[0] = val_28;
                val_18 = val_18;
            }
            while(val_17 < this.m_boneCount);
            
            }
            
            UnityEngine.Matrix4x4 val_16 = mem[1152921520140225480].worldToLocalMatrix;
            mem[1152921520140225672] = val_4;
            mem[1152921520140225676] = val_7;
            mem[1152921520140225680] = val_10;
            mem[1152921520140225684] = val_13;
            mem[1152921520140225688] = val_5;
            mem[1152921520140225692] = val_8;
            mem[1152921520140225696] = val_11;
            mem[1152921520140225700] = val_14;
            mem[1152921520140225704] = val_6;
            mem[1152921520140225708] = val_9;
            mem[1152921520140225712] = val_12;
            mem[1152921520140225716] = val_15;
            if(mem[1152921520140225836] == false)
            {
                    return;
            }
            
            this.UpdateBonesGPU();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateVerticesFallback(bool starting)
        {
            UnityEngine.Mesh val_6;
            if((starting != true) && (this.m_wasVisible != false))
            {
                    System.Array.Copy(sourceArray:  this.m_currVertices, destinationArray:  this.m_prevVertices, length:  this.m_vertexCount);
            }
            
            this.m_renderer.BakeMesh(mesh:  this.m_clonedMesh);
            val_6 = this.m_clonedMesh;
            if(val_6.vertexCount != 0)
            {
                    val_6 = this.m_clonedMesh.vertexCount;
                if(val_6 == this.m_prevVertices.Length)
            {
                    val_6 = this.m_clonedMesh;
                System.Array.Copy(sourceArray:  val_6.vertices, destinationArray:  this.m_currVertices, length:  this.m_vertexCount);
                if(starting != true)
            {
                    if(this.m_wasVisible == true)
            {
                    return;
            }
            
            }
            
                System.Array.Copy(sourceArray:  this.m_currVertices, destinationArray:  this.m_prevVertices, length:  this.m_vertexCount);
                return;
            }
            
            }
            
            this.IssueWarning(message:  "[AmplifyMotion] Invalid mesh obtained from SkinnedMeshRenderer.BakeMesh in object " + starting.name + ". Skipping.");
            mem[1152921520140755648] = 1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AsyncUpdateVertices(bool starting)
        {
            var val_3;
            var val_4;
            var val_5;
            if((starting != true) && (this.m_wasVisible != false))
            {
                    System.Array.Copy(sourceArray:  this.m_currVertices, destinationArray:  this.m_prevVertices, length:  this.m_vertexCount);
            }
            
            if(this.m_boneCount >= 1)
            {
                    var val_7 = 0;
                do
            {
                long val_6 = 0;
                val_6 = (this.m_bones + (val_6 * 48)) + 32;
                Matrix3x4 val_2 = MotionState.Matrix3x4.op_Multiply(a:  new Matrix3x4() {m00 = this.m_worldToLocalMatrix.m00, m10 = this.m_worldToLocalMatrix.m10, m20 = this.m_worldToLocalMatrix.m20}, b:  new Matrix3x4() {m00 = (0 * 48) + this.m_bones + 32, m01 = (0 * 48) + this.m_bones + 32, m02 = (0 * 48) + this.m_bones + 32, m03 = (0 * 48) + this.m_bones + 32, m10 = (0 * 48) + this.m_bones + 48, m11 = (0 * 48) + this.m_bones + 48, m12 = (0 * 48) + this.m_bones + 48, m13 = (0 * 48) + this.m_bones + 48, m20 = (0 * 48) + this.m_bones + 64, m21 = (0 * 48) + this.m_bones + 64, m22 = (0 * 48) + this.m_bones + 64, m23 = (0 * 48) + this.m_bones + 64});
                val_7 = val_7 + 1;
                mem2[0] = val_4;
                mem2[0] = val_3;
                mem2[0] = val_5;
            }
            while(val_7 < this.m_boneCount);
            
            }
            
            if(this.m_weightCount == 2)
            {
                goto label_7;
            }
            
            if(this.m_weightCount != 1)
            {
                goto label_8;
            }
            
            this.UpdateVerticesBone1();
            if(starting == false)
            {
                goto label_11;
            }
            
            goto label_13;
            label_7:
            this.UpdateVerticesBone2();
            if(starting == false)
            {
                goto label_11;
            }
            
            goto label_13;
            label_8:
            this.UpdateVerticesBone4();
            if(starting == true)
            {
                goto label_13;
            }
            
            label_11:
            if(this.m_wasVisible == true)
            {
                    return;
            }
            
            label_13:
            System.Array.Copy(sourceArray:  this.m_currVertices, destinationArray:  this.m_prevVertices, length:  this.m_vertexCount);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void InitializeBone1(UnityEngine.Vector4[] baseVertices, int[] boneIndices)
        {
            var val_11;
            var val_12;
            var val_13;
            UnityEngine.Vector4[] val_14;
            val_11 = boneIndices;
            val_12 = this.m_renderer.sharedMesh.vertices;
            val_13 = this.m_renderer.sharedMesh;
            UnityEngine.Matrix4x4[] val_4 = val_13.bindposes;
            if(this.m_vertexCount < 1)
            {
                    return;
            }
            
            var val_13 = 0;
            goto label_20;
            label_14:
            if(val_12 != null)
            {
                goto label_9;
            }
            
            goto label_9;
            label_20:
            val_11[((long)(int)((this.m_weightCount * 0))) << 2] = this.m_renderer.sharedMesh.boneWeights[0][32].region;
            if(val_4 == 0)
            {
                goto label_14;
            }
            
            label_9:
            var val_11 = 12;
            val_11 = val_12 + (0 * val_11);
            UnityEngine.Matrix4x4[] val_12 = val_4;
            val_12 = val_12 + (((long)(int)(val_8)) << 6);
            UnityEngine.Matrix4x4[] val_9 = val_12 + 32;
            val_13 = val_12;
            val_14 = baseVertices;
            if(val_14 == 0)
            {
                    val_14 = baseVertices;
            }
            
            if((this.m_weightCount * val_13) >= (baseVertices + 24))
            {
                    val_14 = baseVertices;
            }
            
            UnityEngine.Vector4[] val_10 = val_14 + (((long)(int)((this.m_weightCount * 0))) << 4);
            mem2[0] = 0;
            mem2[0] = 0;
            mem2[0] = 0;
            mem2[0] = 0;
            val_13 = val_13 + 1;
            val_11 = val_11;
            val_12 = val_13;
            if(val_13 < this.m_vertexCount)
            {
                goto label_20;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void InitializeBone2(UnityEngine.Vector4[] baseVertices, int[] boneIndices, float[] boneWeights)
        {
            var val_21;
            System.Single[] val_22;
            UnityEngine.Vector4[] val_23;
            var val_24;
            UnityEngine.BoneWeight[] val_25;
            val_22 = boneWeights;
            val_23 = baseVertices;
            UnityEngine.Matrix4x4[] val_4 = this.m_renderer.sharedMesh.bindposes;
            val_24 = this.m_renderer.sharedMesh;
            val_25 = val_24.boneWeights;
            if(this.m_vertexCount < 1)
            {
                    return;
            }
            
            var val_28 = 0;
            goto label_30;
            label_19:
            if(boneIndices != 0)
            {
                goto label_10;
            }
            
            goto label_10;
            label_30:
            long val_25 = 0;
            UnityEngine.BoneWeight val_21 = val_25[0];
            UnityEngine.BoneWeight val_22 = val_25[0];
            int val_7 = this.m_weightCount * val_28;
            System.Int32[] val_10 = boneIndices + (((long)(int)((this.m_weightCount * 0))) << 2);
            mem2[0] = val_21.region;
            val_24 = (long)val_7 + 1;
            System.Int32[] val_12 = boneIndices + (((long)(int)(((this.m_weightCount * 0) + 1))) << 2);
            mem2[0] = val_21.WireType;
            float val_13 = val_21.weight0;
            float val_23 = val_13;
            float val_24 = val_13;
            val_13 = val_23 + val_24;
            float val_14 = 1f / val_13;
            val_23 = val_23 * val_14;
            val_22[(long)val_7] = val_23;
            val_24 = val_24 * val_14;
            val_22[val_24] = val_24;
            if(val_4 == 0)
            {
                goto label_19;
            }
            
            label_10:
            val_25 = this.m_renderer.sharedMesh.vertices + (val_25 * 12);
            UnityEngine.Matrix4x4[] val_26 = val_4;
            val_26 = val_26 + (((long)(int)(val_8)) << 6);
            UnityEngine.Matrix4x4[] val_15 = val_26 + 32;
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Multiply(d:  val_23, a:  new UnityEngine.Vector3() {x = (0 * 12) + val_2 + 32, y = (0 * 12) + val_2 + 32 + 4, z = (0 * 12) + val_2 + 32 + 8});
            val_23 = val_23;
            UnityEngine.Matrix4x4[] val_27 = val_4;
            val_27 = val_27 + (((long)(int)(val_11)) << 6);
            UnityEngine.Matrix4x4[] val_17 = val_27 + 32;
            UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_Multiply(d:  val_24, a:  new UnityEngine.Vector3() {x = (0 * 12) + val_2 + 32, y = (0 * 12) + val_2 + 32 + 4, z = (0 * 12) + val_2 + 32 + 8});
            UnityEngine.Vector4[] val_19 = val_23 + (((long)(int)((this.m_weightCount * 0))) << 4);
            mem2[0] = 0;
            mem2[0] = 0;
            mem2[0] = 0;
            mem2[0] = 0;
            val_21 = 0;
            UnityEngine.Vector4[] val_20 = val_23 + (((long)(int)(((this.m_weightCount * 0) + 1))) << 4);
            mem2[0] = val_21;
            mem2[0] = 0;
            mem2[0] = 0;
            mem2[0] = 0;
            val_25 = val_25;
            val_22 = val_22;
            val_28 = val_28 + 1;
            if(val_28 < this.m_vertexCount)
            {
                goto label_30;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void InitializeBone4(UnityEngine.Vector4[] baseVertices, int[] boneIndices, float[] boneWeights)
        {
            AmplifyMotion.SkinnedState val_20;
            UnityEngine.Vector3[] val_21;
            val_20 = this;
            val_21 = this.m_renderer.sharedMesh.vertices;
            UnityEngine.Matrix4x4[] val_4 = this.m_renderer.sharedMesh.bindposes;
            if(this.m_vertexCount < 1)
            {
                    return;
            }
            
            var val_23 = 0;
            goto label_40;
            label_23:
            if(val_21 != null)
            {
                goto label_10;
            }
            
            goto label_10;
            label_40:
            UnityEngine.BoneWeight val_21 = this.m_renderer.sharedMesh.boneWeights[0];
            UnityEngine.BoneWeight val_22 = this.m_renderer.sharedMesh.boneWeights[0];
            int val_7 = this.m_weightCount * val_23;
            UnityEngine.XR.ARCore.ARCoreFaceRegion val_8 = val_21.region;
            boneIndices[((long)(int)((this.m_weightCount * 0))) << 2] = val_8;
            GameSparks.RT.Proto.Wire val_11 = val_21.WireType;
            boneIndices[((long)(int)(((this.m_weightCount * 0) + 1))) << 2] = val_11;
            int val_13 = val_21.Position;
            boneIndices[((long)(int)(((this.m_weightCount * 0) + 2))) << 2] = val_13;
            int val_14 = val_21.Length;
            boneIndices[((long)(int)(((this.m_weightCount * 0) + 3))) << 2] = val_14;
            float val_15 = val_21.weight0;
            boneWeights[(long)val_7] = val_15;
            boneWeights[(long)val_7 + 1] = val_15;
            boneWeights[(long)val_7 + 2] = val_15;
            boneWeights[(long)val_7 + 3] = val_15;
            if(val_4 == null)
            {
                goto label_23;
            }
            
            label_10:
            var val_16 = val_21 + (0 * 12);
            UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Multiply(d:  val_15, a:  new UnityEngine.Vector3() {x = (0 * 12) + val_2 + 32, y = (0 * 12) + val_2 + 32 + 4, z = (0 * 12) + val_2 + 32 + 8});
            UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_Multiply(d:  val_15, a:  new UnityEngine.Vector3() {x = (0 * 12) + val_2 + 32, y = (0 * 12) + val_2 + 32 + 4, z = (0 * 12) + val_2 + 32 + 8});
            UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_Multiply(d:  val_15, a:  new UnityEngine.Vector3() {x = (0 * 12) + val_2 + 32, y = (0 * 12) + val_2 + 32 + 4, z = (0 * 12) + val_2 + 32 + 8});
            UnityEngine.Vector3 val_20 = UnityEngine.Vector3.op_Multiply(d:  val_15, a:  new UnityEngine.Vector3() {x = (0 * 12) + val_2 + 32, y = (0 * 12) + val_2 + 32 + 4, z = (0 * 12) + val_2 + 32 + 8});
            baseVertices[((long)(int)((this.m_weightCount * 0))) << 4] = 0;
            baseVertices[((long)(int)((this.m_weightCount * 0))) << 4] = 0;
            baseVertices[((long)(int)((this.m_weightCount * 0))) << 4] = 0;
            baseVertices[((long)(int)((this.m_weightCount * 0))) << 4] = 0;
            baseVertices[((long)(int)(((this.m_weightCount * 0) + 1))) << 4] = 0;
            baseVertices[((long)(int)(((this.m_weightCount * 0) + 1))) << 4] = 0;
            baseVertices[((long)(int)(((this.m_weightCount * 0) + 1))) << 4] = 0;
            baseVertices[((long)(int)(((this.m_weightCount * 0) + 1))) << 4] = 0;
            baseVertices[((long)(int)(((this.m_weightCount * 0) + 2))) << 4] = 0;
            baseVertices[((long)(int)(((this.m_weightCount * 0) + 2))) << 4] = 0;
            baseVertices[((long)(int)(((this.m_weightCount * 0) + 2))) << 4] = 0;
            baseVertices[((long)(int)(((this.m_weightCount * 0) + 2))) << 4] = 0;
            val_21 = 0;
            val_23 = val_23 + 1;
            baseVertices[((long)(int)(((this.m_weightCount * 0) + 3))) << 4] = val_21;
            baseVertices[((long)(int)(((this.m_weightCount * 0) + 3))) << 4] = 0;
            baseVertices[((long)(int)(((this.m_weightCount * 0) + 3))) << 4] = 0;
            baseVertices[((long)(int)(((this.m_weightCount * 0) + 3))) << 4] = 0;
            val_20 = val_20;
            if(val_23 < this.m_vertexCount)
            {
                goto label_40;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateVerticesBone1()
        {
            if(this.m_vertexCount < 1)
            {
                    return;
            }
            
            var val_10 = 0;
            do
            {
                UnityEngine.Vector3[] val_9 = this.m_currVertices;
                val_9 = (val_9 + (0 * 12)) + 32;
                AmplifyMotion.MotionState.MulPoint3x4_XYZ(result: ref  new UnityEngine.Vector3() {x = val_9, y = val_9, z = val_9}, mat: ref  new Matrix3x4() {m00 = (this.m_bones + (this.m_boneIndices[0] * 48)) + 32, m01 = (this.m_bones + (this.m_boneIndices[0] * 48)) + 32, m02 = (this.m_bones + (this.m_boneIndices[0] * 48)) + 32, m03 = (this.m_bones + (this.m_boneIndices[0] * 48)) + 32, m10 = (this.m_bones + (this.m_boneIndices[0] * 48)) + 32, m11 = (this.m_bones + (this.m_boneIndices[0] * 48)) + 32, m12 = (this.m_bones + (this.m_boneIndices[0] * 48)) + 32, m13 = (this.m_bones + (this.m_boneIndices[0] * 48)) + 32, m20 = (this.m_bones + (this.m_boneIndices[0] * 48)) + 32, m21 = (this.m_bones + (this.m_boneIndices[0] * 48)) + 32, m22 = (this.m_bones + (this.m_boneIndices[0] * 48)) + 32, m23 = (this.m_bones + (this.m_boneIndices[0] * 48)) + 32}, vec:  new UnityEngine.Vector4() {x = this.m_baseVertices[0], y = this.m_baseVertices[0], z = this.m_baseVertices[0], w = this.m_baseVertices[0]});
                val_10 = val_10 + 1;
            }
            while(val_10 < this.m_vertexCount);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateVerticesBone2()
        {
            Matrix3x4[] val_4;
            UnityEngine.Vector4 val_5;
            UnityEngine.Vector4 val_6;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            if(this.m_vertexCount < 1)
            {
                    return;
            }
            
            var val_14 = 0;
            var val_15 = 1;
            do
            {
                val_4 = val_15 - 1;
                val_6 = this.m_baseVertices[(long)val_4];
                val_5 = this.m_baseVertices[(long)val_4];
                var val_9 = 48;
                val_9 = this.m_bones + (this.m_boneIndices[(long)val_4] * val_9);
                AmplifyMotion.MotionState.MulPoint3x4_XYZW(result: ref  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, mat: ref  new Matrix3x4() {m00 = val_9 + 32, m01 = val_9 + 32, m02 = val_9 + 32, m03 = val_9 + 32, m10 = val_9 + 32, m11 = val_9 + 32, m12 = val_9 + 32, m13 = val_9 + 32, m20 = val_9 + 32, m21 = val_9 + 32, m22 = val_9 + 32, m23 = val_9 + 32}, vec:  new UnityEngine.Vector4() {x = this.m_baseVertices[(long)val_4], y = this.m_baseVertices[(long)val_4], z = val_6, w = val_5});
                if(this.m_boneWeights[1] != 0f)
            {
                    val_4 = this.m_bones;
                val_6 = this.m_baseVertices[1];
                val_5 = this.m_baseVertices[1];
                var val_12 = 48;
                val_12 = val_4 + (this.m_boneIndices[1] * val_12);
                AmplifyMotion.MotionState.MulAddPoint3x4_XYZW(result: ref  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, mat: ref  new Matrix3x4() {m00 = val_12 + 32, m01 = val_12 + 32, m02 = val_12 + 32, m03 = val_12 + 32, m10 = val_12 + 32, m11 = val_12 + 32, m12 = val_12 + 32, m13 = val_12 + 32, m20 = val_12 + 32, m21 = val_12 + 32, m22 = val_12 + 32, m23 = val_12 + 32}, vec:  new UnityEngine.Vector4() {x = this.m_baseVertices[1], y = this.m_baseVertices[1], z = val_6, w = val_5});
            }
            
                var val_13 = 12;
                val_13 = this.m_currVertices + (0 * val_13);
                mem2[0] = val_1.x;
                mem2[0] = val_1.y;
                mem2[0] = val_1.z;
                val_14 = val_14 + 1;
                val_15 = val_15 + 2;
            }
            while(val_14 < this.m_vertexCount);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateVerticesBone4()
        {
            UnityEngine.Vector4 val_6;
            UnityEngine.Vector4 val_7;
            UnityEngine.Vector4 val_8;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            if(this.m_vertexCount < 1)
            {
                    return;
            }
            
            var val_26 = 0;
            var val_27 = 3;
            do
            {
                val_6 = this.m_baseVertices[(long)val_27 - 3];
                val_8 = this.m_baseVertices[(long)val_27 - 3];
                val_7 = this.m_baseVertices[(long)val_27 - 3];
                var val_17 = 48;
                val_17 = this.m_bones + ((this.m_boneIndices[(long)val_27 - 3]) * val_17);
                AmplifyMotion.MotionState.MulPoint3x4_XYZW(result: ref  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, mat: ref  new Matrix3x4() {m00 = val_17 + 32, m01 = val_17 + 32, m02 = val_17 + 32, m03 = val_17 + 32, m10 = val_17 + 32, m11 = val_17 + 32, m12 = val_17 + 32, m13 = val_17 + 32, m20 = val_17 + 32, m21 = val_17 + 32, m22 = val_17 + 32, m23 = val_17 + 32}, vec:  new UnityEngine.Vector4() {x = this.m_baseVertices[(long)val_27 - 3], y = val_6, z = val_8, w = val_7});
                if((this.m_boneWeights[(long)val_27 - 2]) != 0f)
            {
                    val_6 = this.m_baseVertices[(long)val_27 - 2];
                val_8 = this.m_baseVertices[(long)val_27 - 2];
                val_7 = this.m_baseVertices[(long)val_27 - 2];
                var val_19 = 48;
                val_19 = this.m_bones + ((this.m_boneIndices[(long)val_27 - 2]) * val_19);
                AmplifyMotion.MotionState.MulAddPoint3x4_XYZW(result: ref  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, mat: ref  new Matrix3x4() {m00 = val_19 + 32, m01 = val_19 + 32, m02 = val_19 + 32, m03 = val_19 + 32, m10 = val_19 + 32, m11 = val_19 + 32, m12 = val_19 + 32, m13 = val_19 + 32, m20 = val_19 + 32, m21 = val_19 + 32, m22 = val_19 + 32, m23 = val_19 + 32}, vec:  new UnityEngine.Vector4() {x = this.m_baseVertices[(long)val_27 - 2], y = val_6, z = val_8, w = val_7});
            }
            
                if((this.m_boneWeights[(long)val_27 - 1]) != 0f)
            {
                    val_6 = this.m_baseVertices[(long)val_27 - 1];
                val_8 = this.m_baseVertices[(long)val_27 - 1];
                val_7 = this.m_baseVertices[(long)val_27 - 1];
                var val_21 = 48;
                val_21 = this.m_bones + ((this.m_boneIndices[(long)val_27 - 1]) * val_21);
                AmplifyMotion.MotionState.MulAddPoint3x4_XYZW(result: ref  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, mat: ref  new Matrix3x4() {m00 = val_21 + 32, m01 = val_21 + 32, m02 = val_21 + 32, m03 = val_21 + 32, m10 = val_21 + 32, m11 = val_21 + 32, m12 = val_21 + 32, m13 = val_21 + 32, m20 = val_21 + 32, m21 = val_21 + 32, m22 = val_21 + 32, m23 = val_21 + 32}, vec:  new UnityEngine.Vector4() {x = this.m_baseVertices[(long)val_27 - 1], y = val_6, z = val_8, w = val_7});
            }
            
                if(this.m_boneWeights[3] != 0f)
            {
                    val_8 = this.m_baseVertices[3];
                val_7 = this.m_baseVertices[3];
                var val_24 = 48;
                val_24 = this.m_bones + (this.m_boneIndices[3] * val_24);
                AmplifyMotion.MotionState.MulAddPoint3x4_XYZW(result: ref  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, mat: ref  new Matrix3x4() {m00 = val_24 + 32, m01 = val_24 + 32, m02 = val_24 + 32, m03 = val_24 + 32, m10 = val_24 + 32, m11 = val_24 + 32, m12 = val_24 + 32, m13 = val_24 + 32, m20 = val_24 + 32, m21 = val_24 + 32, m22 = val_24 + 32, m23 = val_24 + 32}, vec:  new UnityEngine.Vector4() {x = this.m_baseVertices[3], y = this.m_baseVertices[3], z = val_8, w = val_7});
            }
            
                var val_25 = 12;
                val_25 = this.m_currVertices + (0 * val_25);
                mem2[0] = val_1.x;
                mem2[0] = val_1.y;
                mem2[0] = val_1.z;
                val_26 = val_26 + 1;
                val_27 = val_27 + 4;
            }
            while(val_26 < this.m_vertexCount);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal override void AsyncUpdate()
        {
            System.Threading.ManualResetEvent val_7;
            this.AsyncUpdateVertices(starting:  this.m_starting);
            val_7 = this.m_asyncUpdateSignal;
            bool val_1 = val_7.Set();
            if(52 == 52)
            {
                    return;
            }
            
            if(0 == 0)
            {
                    return;
            }
            
            val_7 = ???;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal override void UpdateTransform(UnityEngine.Rendering.CommandBuffer updateCB, bool starting)
        {
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            AmplifyMotion.MotionState val_36;
            var val_37;
            bool val_38;
            var val_39;
            bool val_40;
            val_36 = this;
            val_37 = starting;
            if(W8 == 0)
            {
                goto label_0;
            }
            
            if((val_37 != true) && (this.m_wasVisible != false))
            {
                    val_38 = 1152921520145962392;
                mem[1152921520145962408] = null;
                mem[1152921520145962392] = null;
                mem2[0] = this.m_currLocalToWorld.m00;
            }
            
            val_39 = this.m_renderer.isVisible;
            bool val_2 = val_39 | val_37;
            if((val_2 == false) || (val_2 == true))
            {
                goto label_5;
            }
            
            this.UpdateBones();
            val_38 = this.m_useFallback;
            val_40 = this.m_useFallback;
            bool val_3 = (this.m_wasVisible == false) ? 1 : 0;
            val_3 = val_3 | val_37;
            bool val_4 = val_3;
            this.m_starting = val_4;
            if(val_38 == false)
            {
                goto label_6;
            }
            
            this.UpdateVerticesFallback(starting:  val_4);
            goto label_17;
            label_0:
            val_37 = ???;
            val_36 = ???;
            val_39 = ???;
            goto typeof(AmplifyMotion.SkinnedState).__il2cppRuntimeField_168;
            label_5:
            val_40 = val_36 + 379;
            label_17:
            UnityEngine.Matrix4x4 val_5 = val_36 + 24.localToWorldMatrix;
            mem2[0] = val_6;
            mem2[0] = val_9;
            mem2[0] = val_12;
            mem2[0] = val_15;
            mem2[0] = val_7;
            mem2[0] = val_10;
            mem2[0] = val_13;
            mem2[0] = val_16;
            mem2[0] = val_8;
            mem2[0] = val_11;
            mem2[0] = val_14;
            mem2[0] = val_17;
            if((val_37 & 1) == 0)
            {
                    if((val_36 + 378) != 0)
            {
                goto label_10;
            }
            
            }
            
            var val_19 = val_36 + 296;
            var val_20 = val_36 + 280;
            mem2[0] = val_36 + 344;
            mem2[0] = val_36 + 328;
            var val_23 = val_36 + 264;
            mem2[0] = val_36 + 312;
            label_10:
            mem2[0] = val_39 & 1;
            return;
            label_6:
            if(this.m_useGPU == false)
            {
                goto label_11;
            }
            
            starting = val_3;
            this.UpdateVerticesGPU(updateCB:  updateCB, starting:  starting);
            goto label_17;
            label_11:
            bool val_32 = this.m_asyncUpdateSignal.Reset();
            this.m_asyncUpdateTriggered = true;
            this.m_asyncUpdateSignal.WorkerPool.EnqueueAsyncUpdate(state:  this);
            goto label_17;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void WaitForAsyncUpdate()
        {
            if(this.m_asyncUpdateTriggered == false)
            {
                    return;
            }
            
            if((this.m_asyncUpdateSignal & 1) != 0)
            {
                    this.m_asyncUpdateTriggered = false;
                return;
            }
            
            UnityEngine.Debug.LogWarning(message:  "[AmplifyMotion] Aborted abnormally long Async Skin deform operation. Not a critical error but might indicate a problem. Please contact support.");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal override void RenderVectors(UnityEngine.Camera camera, UnityEngine.Rendering.CommandBuffer renderCB, float scale, AmplifyMotion.Quality quality)
        {
            UnityEngine.CubemapFace val_10;
            IntPtr val_11;
            UnityEngine.CubemapFace val_13;
            IntPtr val_14;
            UnityEngine.Rendering.BuiltinRenderTextureType val_15;
            var val_26;
            float val_27;
            AmplifyMotion.SkinnedState val_28;
            var val_29;
            float val_30;
            float val_31;
            var val_32;
            float val_33;
            MotionState.Matrix3x4 val_34;
            float val_35;
            var val_36;
            float val_37;
            UnityEngine.Material val_38;
            float val_39;
            UnityEngine.Rendering.CommandBuffer val_40;
            bool val_41;
            UnityEngine.Rendering.CommandBuffer val_42;
            var val_43;
            string val_44;
            UnityEngine.Rendering.CommandBuffer val_45;
            val_27 = scale;
            val_28 = this;
            if(true == 0)
            {
                    return;
            }
            
            if(true != 0)
            {
                    return;
            }
            
            if(this.m_renderer.isVisible == false)
            {
                    return;
            }
            
            if(this.m_useFallback == false)
            {
                goto label_5;
            }
            
            label_52:
            if(this.m_useGPU == true)
            {
                goto label_10;
            }
            
            if(this.m_useFallback != true)
            {
                    this.m_clonedMesh.vertices = this.m_currVertices;
            }
            
            this.m_clonedMesh.normals = this.m_prevVertices;
            goto label_10;
            label_5:
            if(this.m_useGPU == false)
            {
                goto label_11;
            }
            
            label_10:
            int val_2 = UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask() {m_Mask = mem[69734424] + 72});
            UnityEngine.GameObject val_3 = X23.gameObject;
            int val_5 = val_3.layer & 31;
            val_5 = 1 << val_5;
            val_5 = val_5 & val_2;
            if(val_5 != 0)
            {
                    val_29 = (mem[69734424] + 24 + 36) * val_27;
                val_30 = (mem[69734424] + 24 + 40) * val_27;
                val_27 = ((float)mem[69734424] + 24.GenerateObjectId(obj:  val_3.gameObject)) * 0.003921569f;
            }
            else
            {
                    val_29 = 0f;
                val_27 = 1f;
                val_30 = 0f;
            }
            
            if(renderCB == 0)
            {
                    val_33 = ???;
                val_31 = ???;
                val_32 = 1;
            }
            
            renderCB.SetGlobalMatrix(name:  "_AM_MATRIX_PREV_M", value:  new UnityEngine.Matrix4x4() {m00 = this.m_prevLocalToWorld, m10 = mem[69734424], m20 = quality, m30 = 0f, m01 = val_3, m11 = ???, m21 = val_2, m31 = 0f, m02 = val_31, m12 = ???, m22 = ???, m32 = 0f, m03 = 1.401298E-45f, m13 = val_33, m23 = ???, m33 = 1f});
            val_34 = this.m_currLocalToWorld;
            if(renderCB == 0)
            {
                    val_39 = val_33;
                val_35 = val_31;
                val_36 = val_32;
            }
            
            renderCB.SetGlobalMatrix(name:  "_AM_MATRIX_CURR_M", value:  new UnityEngine.Matrix4x4() {m00 = val_34, m10 = quality, m20 = val_2, m30 = 0f, m01 = ???, m11 = ???, m21 = mem[69734424], m31 = 0f, m02 = val_35, m12 = ???, m22 = this.m_prevLocalToWorld, m32 = 0f, m03 = 1.401298E-45f, m13 = val_39, m23 = ???, m33 = 1f});
            val_40 = renderCB;
            if(val_40 == 0)
            {
                    val_40 = renderCB;
            }
            
            val_40.SetGlobalVector(name:  "_AM_MOTION_PARAMS", value:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
            val_28 = val_28;
            val_41 = this.m_useGPU;
            if(val_41 != false)
            {
                    var val_25 = mem[1152921520146354768];
                var val_26 = mem[1152921520146354772];
                val_25 = 1f / (float)val_25;
                val_26 = 1f / (float)val_26;
                if(val_40 == 0)
            {
                    val_40 = renderCB;
            }
            
                val_40.SetGlobalVector(name:  "_AM_VERTEX_TEXEL_SIZE", value:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
                UnityEngine.Vector4 val_8 = UnityEngine.Vector4.op_Multiply(a:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f}, d:  0.5f);
                val_27 = val_8.x;
                val_30 = val_8.z;
                renderCB.SetGlobalVector(name:  "_AM_VERTEX_TEXEL_HALFSIZE", value:  new UnityEngine.Vector4() {x = val_27, y = val_8.y, z = val_30, w = val_8.w});
                UnityEngine.Rendering.RenderTargetIdentifier val_9 = UnityEngine.Rendering.RenderTargetIdentifier.op_Implicit(tex:  mem[1152921520146354816]);
                renderCB.SetGlobalTexture(name:  "_AM_PREV_VERTEX_TEX", value:  new UnityEngine.Rendering.RenderTargetIdentifier() {m_BufferPointer = val_11, m_MipLevel = val_11, m_CubeFace = val_10});
                UnityEngine.Rendering.RenderTargetIdentifier val_12 = UnityEngine.Rendering.RenderTargetIdentifier.op_Implicit(tex:  mem[1152921520146354824]);
                val_42 = renderCB;
                if(val_42 == 0)
            {
                    val_42 = renderCB;
            }
            
                val_42.SetGlobalTexture(name:  "_AM_CURR_VERTEX_TEX", value:  new UnityEngine.Rendering.RenderTargetIdentifier() {m_Type = val_15, m_NameID = val_15, m_InstanceID = val_15, m_BufferPointer = val_14, m_MipLevel = val_14, m_CubeFace = val_13});
                val_41 = this.m_useGPU << 2;
            }
            
            val_41 = val_41 | ((quality == 0) ? 0 : 2);
            val_43 = 0;
            goto label_35;
            label_51:
            var val_27 = 24;
            val_27 = mem[1152921520146354984] + (0 * val_27);
            if((((0 * 24) + mem[1152921520146354984] + 40 + 8) & 255) != 0)
            {
                    UnityEngine.Texture val_19 = (0 * 24) + mem[1152921520146354984] + 32.mainTexture;
                if(val_19 != 0)
            {
                    (0 * 24) + mem[1152921520146354984] + 40.SetTexture(name:  "_MainTex", value:  val_19);
            }
            
                if((((0 * 24) + mem[1152921520146354984] + 40 + 8) & 65280) != 0)
            {
                    val_44 = "_Cutoff";
                if(((0 * 24) + mem[1152921520146354984] + 32) == 0)
            {
                    val_44 = "_Cutoff";
            }
            
                val_27 = (0 * 24) + mem[1152921520146354984] + 32.GetFloat(name:  val_44);
                (0 * 24) + mem[1152921520146354984] + 40.SetFloat(name:  "_Cutoff", value:  val_27);
            }
            
            }
            
            val_37 = mem[1152921520146354952];
            val_34 = mem[1152921520146354980];
            val_45 = renderCB;
            val_38 = mem[1152921520146354656] + 24.SkinnedVectorsMaterial;
            if(val_45 == 0)
            {
                    val_45 = renderCB;
            }
            
            val_45.DrawMesh(mesh:  this.m_clonedMesh, matrix:  new UnityEngine.Matrix4x4() {m00 = val_34, m10 = val_37, m20 = mem[1152921520146354968], m30 = 0f, m01 = mem[1152921520146354940], m11 = mem[1152921520146354956], m21 = mem[1152921520146354972], m31 = 0f, m02 = mem[1152921520146354944], m12 = mem[1152921520146354960], m22 = mem[1152921520146354976], m32 = 0f, m03 = mem[1152921520146354948], m13 = mem[1152921520146354964], m23 = val_34, m33 = 1f}, material:  val_38, submeshIndex:  0, shaderPass:  val_41 | ((((0 * 24) + mem[1152921520146354984] + 40 + 8) != 255) ? 1 : 0), properties:  (0 * 24) + mem[1152921520146354984] + 40);
            val_28 = val_28;
            val_43 = 1;
            label_35:
            val_26 = mem[1152921520146354984];
            if(val_43 < (mem[1152921520146354984] + 24))
            {
                goto label_51;
            }
            
            return;
            label_11:
            this.WaitForAsyncUpdate();
            goto label_52;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static SkinnedState()
        {
            AmplifyMotion.SkinnedState.m_uniqueWarnings = new System.Collections.Generic.HashSet<AmplifyMotionObjectBase>();
        }
    
    }

}
