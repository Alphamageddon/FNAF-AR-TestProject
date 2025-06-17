using UnityEngine;

namespace AmplifyMotion
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal class ClothState : MotionState
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Cloth m_cloth;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Renderer m_renderer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AmplifyMotion.MotionState.Matrix3x4 m_prevLocalToWorld;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AmplifyMotion.MotionState.Matrix3x4 m_currLocalToWorld;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int m_targetVertexCount;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int[] m_targetRemap;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3[] m_prevVertices;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3[] m_currVertices;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Mesh m_clonedMesh;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AmplifyMotion.MotionState.MaterialDesc[] m_sharedMaterials;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool m_starting;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool m_wasVisible;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static System.Collections.Generic.HashSet<AmplifyMotionObjectBase> m_uniqueWarnings;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ClothState(AmplifyMotionCamera owner, AmplifyMotionObjectBase obj)
        {
            this.m_cloth = obj.GetComponent<UnityEngine.Cloth>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void IssueError(string message)
        {
            var val_3;
            System.Collections.Generic.HashSet<AmplifyMotionObjectBase> val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = AmplifyMotion.ClothState.m_uniqueWarnings;
            if((val_4.Contains(item:  X22)) != true)
            {
                    UnityEngine.Debug.LogWarning(message:  message);
                val_5 = null;
                val_5 = null;
                bool val_2 = AmplifyMotion.ClothState.m_uniqueWarnings.Add(item:  val_4);
            }
            
            mem[1152921520129579936] = 1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal override void Initialize()
        {
            int val_34;
            UnityEngine.Vector3[] val_35;
            UnityEngine.Vector2[] val_36;
            if(this.m_cloth.vertices == null)
            {
                goto label_2;
            }
            
            UnityEngine.SkinnedMeshRenderer val_3 = this.m_cloth.gameObject.GetComponent<UnityEngine.SkinnedMeshRenderer>();
            UnityEngine.Mesh val_4 = val_3.sharedMesh;
            if(((val_4 == 0) || (val_4.vertices == null)) || (val_4.triangles == null))
            {
                goto label_12;
            }
            
            mem[1152921520130316113] = 1;
            this.m_renderer = this.m_cloth.gameObject.GetComponent<UnityEngine.Renderer>();
            if(val_4 == null)
            {
                goto label_15;
            }
            
            val_34 = val_4.vertexCount;
            val_35 = val_4.vertices;
            val_36 = val_4.uv;
            goto label_16;
            label_12:
            string val_14 = "[AmplifyMotion] Invalid Mesh on Cloth-enabled object "("[AmplifyMotion] Invalid Mesh on Cloth-enabled object ") + val_3.name;
            goto label_18;
            label_2:
            string[] val_15 = new string[5];
            val_15[0] = "[AmplifyMotion] Invalid ";
            val_15[1] = this.m_cloth.GetType();
            val_15[2] = " vertices in object ";
            val_15[3] = name;
            val_15[4] = ". Skipping.";
            label_18:
            this.IssueError(message:  +val_15);
            return;
            label_15:
            val_34 = 0.vertexCount;
            val_35 = 0.vertices;
            val_36 = 0.uv;
            label_16:
            this.m_targetRemap = new int[0];
            UnityEngine.Vector3[] val_24 = this.m_cloth.vertices;
            UnityEngine.Vector3[] val_25 = val_4.vertices;
            if(val_24.Length != val_25.Length)
            {
                goto label_42;
            }
            
            if(val_34 < 1)
            {
                goto label_48;
            }
            
            int val_35 = 0;
            do
            {
                this.m_targetRemap[val_35] = val_35;
                val_35 = val_35 + 1;
            }
            while(val_34 != val_35);
            
            goto label_48;
            label_42:
            System.Collections.Generic.Dictionary<UnityEngine.Vector3, System.Int32> val_26 = new System.Collections.Generic.Dictionary<UnityEngine.Vector3, System.Int32>();
            if(val_34 >= 1)
            {
                    var val_36 = 0;
                do
            {
                if((val_26.TryGetValue(key:  new UnityEngine.Vector3() {x = 4.372641E+10f, y = 4.372641E+10f, z = 4.372641E+10f}, value: out  0)) != false)
            {
                    this.m_targetRemap[val_36] = 0;
            }
            else
            {
                    this.m_targetRemap[val_36] = 0;
                var val_29 = 0 + 1;
                val_26.Add(key:  new UnityEngine.Vector3() {x = 4.372641E+10f, y = 4.372641E+10f, z = 4.372641E+10f}, value:  0);
            }
            
                val_36 = val_36 + 1;
            }
            while(val_34 != val_36);
            
            }
            
            label_48:
            this.m_targetVertexCount = val_34;
            this.m_prevVertices = new UnityEngine.Vector3[0];
            this.m_currVertices = new UnityEngine.Vector3[0];
            UnityEngine.Mesh val_32 = new UnityEngine.Mesh();
            this.m_clonedMesh = val_32;
            val_32.vertices = val_35;
            this.m_clonedMesh.normals = val_35;
            this.m_clonedMesh.uv = val_36;
            this.m_clonedMesh.triangles = val_4.triangles;
            UnityEngine.Material[] val_33 = this.m_renderer.sharedMaterials;
            this.m_sharedMaterials = val_33.ProcessSharedMaterials(mats:  val_33);
            this.m_wasVisible = false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal override void Shutdown()
        {
            UnityEngine.Object.Destroy(obj:  this.m_clonedMesh);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal override void UpdateTransform(UnityEngine.Rendering.CommandBuffer updateCB, bool starting)
        {
            MotionState.Matrix3x4 val_7;
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
            var val_18;
            var val_21 = this;
            if(true == 0)
            {
                goto typeof(AmplifyMotion.ClothState).__il2cppRuntimeField_168;
            }
            
            if((starting != true) && (this.m_wasVisible != false))
            {
                    mem[1152921520131252976] = ???;
                mem[1152921520131252992] = ???;
                this.m_prevLocalToWorld = this.m_currLocalToWorld;
            }
            
            bool val_1 = this.m_renderer.isVisible;
            bool val_2 = val_1 | starting;
            if((((val_2 != false) && (val_2 != true)) && (starting != true)) && (this.m_wasVisible != false))
            {
                    System.Array.Copy(sourceArray:  this.m_currVertices, destinationArray:  this.m_prevVertices, length:  this.m_targetVertexCount);
            }
            
            UnityEngine.Vector3 val_3 = X22.position;
            UnityEngine.Quaternion val_4 = X22.rotation;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.one;
            UnityEngine.Matrix4x4 val_6 = UnityEngine.Matrix4x4.TRS(pos:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, q:  new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w}, s:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.z});
            this.m_currLocalToWorld = val_7;
            mem[1152921520131253012] = val_10;
            mem[1152921520131253016] = val_13;
            mem[1152921520131253020] = val_16;
            mem[1152921520131253024] = val_8;
            mem[1152921520131253028] = val_11;
            mem[1152921520131253032] = val_14;
            mem[1152921520131253036] = val_17;
            mem[1152921520131253040] = val_9;
            mem[1152921520131253044] = val_12;
            mem[1152921520131253048] = val_15;
            mem[1152921520131253052] = val_18;
            if(starting != true)
            {
                    if(this.m_wasVisible == true)
            {
                goto label_16;
            }
            
            }
            
            mem[1152921520131252992] = mem[1152921520131253040];
            mem[1152921520131252976] = mem[1152921520131253024];
            this.m_prevLocalToWorld = this.m_currLocalToWorld;
            label_16:
            this.m_starting = starting;
            this.m_wasVisible = val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal override void RenderVectors(UnityEngine.Camera camera, UnityEngine.Rendering.CommandBuffer renderCB, float scale, AmplifyMotion.Quality quality)
        {
            var val_21;
            float val_22;
            AmplifyMotion.ClothState val_23;
            float val_24;
            var val_25;
            int val_26;
            UnityEngine.Rendering.CommandBuffer val_27;
            var val_28;
            float val_29;
            var val_30;
            float val_31;
            MotionState.Matrix3x4 val_32;
            float val_33;
            var val_34;
            var val_35;
            float val_36;
            UnityEngine.Material val_37;
            UnityEngine.Rendering.CommandBuffer val_38;
            var val_39;
            string val_40;
            UnityEngine.Rendering.CommandBuffer val_41;
            val_22 = scale;
            val_23 = this;
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
            
            UnityEngine.GameObject val_3 = X23.gameObject;
            int val_5 = val_3.layer & 31;
            val_5 = 1 << val_5;
            int val_6 = val_5 & (UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask() {m_Mask = mem[69734424] + 72}));
            if(val_6 != 0)
            {
                    val_24 = ((float)mem[69734424] + 24.GenerateObjectId(obj:  val_3.gameObject)) * 0.003921569f;
            }
            else
            {
                    val_24 = 1f;
            }
            
            UnityEngine.Vector3[] val_9 = this.m_cloth.vertices;
            val_26 = this.m_targetVertexCount;
            if(val_26 >= 1)
            {
                    var val_22 = 0;
                do
            {
                if(this.m_targetRemap == null)
            {
                    val_25 = 0;
            }
            
                if(val_9 == null)
            {
                    val_25 = 0;
            }
            
                int val_10 = val_9 + (this.m_targetRemap[0] * (1.681558E-44f));
                if(this.m_currVertices == null)
            {
                    val_25 = 0;
            }
            
                var val_11 = this.m_currVertices + (0 * (1.681558E-44f));
                mem2[0] = (this.m_targetRemap[0x0][0] * 12) + val_9 + 32;
                mem2[0] = (this.m_targetRemap[0x0][0] * 12) + val_9 + 32 + 4;
                mem2[0] = (this.m_targetRemap[0x0][0] * 12) + val_9 + 40;
                val_26 = this.m_targetVertexCount;
                val_22 = val_22 + 1;
            }
            while(val_22 < val_26);
            
            }
            
            if(this.m_starting == false)
            {
                goto label_23;
            }
            
            label_25:
            System.Array.Copy(sourceArray:  this.m_currVertices, destinationArray:  this.m_prevVertices, length:  val_26);
            goto label_24;
            label_23:
            if(this.m_wasVisible == false)
            {
                goto label_25;
            }
            
            label_24:
            this.m_clonedMesh.vertices = this.m_currVertices;
            this.m_clonedMesh.normals = this.m_prevVertices;
            if(val_6 != 0)
            {
                    val_27 = renderCB;
                if(((this.m_targetRemap[0x0][0] * 12) + val_9 + 32 + 4) == 0)
            {
                    val_27 = renderCB;
            }
            
                if(((this.m_targetRemap[0x0][0] * 12) + val_9 + 32 + 4 + 24) == 0)
            {
                    val_27 = renderCB;
            }
            
                val_28 = ((this.m_targetRemap[0x0][0] * 12) + val_9 + 32 + 24 + 36) * val_22;
                val_22 = ((this.m_targetRemap[0x0][0] * 12) + val_9 + 32 + 4 + 24 + 40) * val_22;
            }
            else
            {
                    val_27 = renderCB;
                val_28 = 0f;
                val_22 = 0f;
            }
            
            if(val_27 == 0)
            {
                    val_31 = ???;
                val_29 = ???;
                val_30 = 1;
            }
            
            renderCB.SetGlobalMatrix(name:  "_AM_MATRIX_PREV_M", value:  new UnityEngine.Matrix4x4() {m00 = this.m_prevLocalToWorld, m10 = (this.m_targetRemap[0x0][0] * 12) + val_9 + 32, m20 = (this.m_targetRemap[0x0][0] * 12) + val_9 + 32 + 4, m30 = 0f, m01 = this.m_prevVertices, m11 = this.m_currVertices, m21 = this.m_clonedMesh, m31 = 0f, m02 = val_29, m12 = val_6, m32 = 0f, m03 = 1.401298E-45f, m13 = val_31, m23 = 1.681558E-44f, m33 = 1f});
            val_32 = this.m_currLocalToWorld;
            if(renderCB == 0)
            {
                    val_36 = val_31;
                val_33 = val_29;
                val_34 = val_30;
            }
            
            renderCB.SetGlobalMatrix(name:  "_AM_MATRIX_CURR_M", value:  new UnityEngine.Matrix4x4() {m00 = val_32, m10 = (this.m_targetRemap[0x0][0] * 12) + val_9 + 32 + 4, m20 = this.m_clonedMesh, m30 = 0f, m01 = val_6, m21 = (this.m_targetRemap[0x0][0] * 12) + val_9 + 32, m31 = 0f, m02 = val_33, m12 = 1.681558E-44f, m22 = this.m_prevLocalToWorld, m32 = 0f, m03 = 1.401298E-45f, m13 = val_36, m23 = this.m_currVertices, m33 = 1f});
            val_38 = renderCB;
            if(val_38 == 0)
            {
                    val_38 = renderCB;
            }
            
            val_38.SetGlobalVector(name:  "_AM_MOTION_PARAMS", value:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
            val_39 = 0;
            goto label_37;
            label_53:
            var val_23 = 24;
            val_23 = 259694 + (0 * val_23);
            if((((0 * 24) + 259694 + 40 + 8) & 255) != 0)
            {
                    UnityEngine.Texture val_15 = (0 * 24) + 259694 + 32.mainTexture;
                if(val_15 != 0)
            {
                    (0 * 24) + 259694 + 40.SetTexture(name:  "_MainTex", value:  val_15);
            }
            
                if((((0 * 24) + 259694 + 40 + 8) & 65280) != 0)
            {
                    val_40 = "_Cutoff";
                if(((0 * 24) + 259694 + 32) == 0)
            {
                    val_40 = "_Cutoff";
            }
            
                val_22 = (0 * 24) + 259694 + 32.GetFloat(name:  val_40);
                (0 * 24) + 259694 + 40.SetFloat(name:  "_Cutoff", value:  val_22);
            }
            
            }
            
            val_35 = -2013265920;
            val_32 = 536870912;
            val_41 = renderCB;
            val_37 = mem[4035225266123964440].ClothVectorsMaterial;
            if(val_41 == 0)
            {
                    val_41 = renderCB;
            }
            
            val_41.DrawMesh(mesh:  259694, matrix:  new UnityEngine.Matrix4x4() {m00 = 3.587324E-43f, m10 = 3.426119E-40f, m20 = 3.429706E-40f, m30 = 0f, m01 = 2.350989E-38f, m11 = 0f, m21 = -3.85186E-34f, m31 = 0f, m02 = 2.407412E-35f, m12 = 3.429706E-40f, m22 = 3.55033E-41f, m32 = 0f, m03 = 0f, m13 = 0f, m23 = 1.084202E-19f, m33 = 1f}, material:  val_37, submeshIndex:  0, shaderPass:  ((quality == 0) ? 0 : 2) | ((((0 * 24) + 259694 + 40 + 8) != 255) ? 1 : 0), properties:  (0 * 24) + 259694 + 40);
            val_39 = 1;
            label_37:
            val_23 = val_23;
            val_21 = mem[1152921520131754600];
            if(val_39 < (mem[1152921520131754600] + 24))
            {
                goto label_53;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static ClothState()
        {
            AmplifyMotion.ClothState.m_uniqueWarnings = new System.Collections.Generic.HashSet<AmplifyMotionObjectBase>();
        }
    
    }

}
