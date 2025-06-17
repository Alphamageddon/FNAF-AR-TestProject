using UnityEngine;

namespace AmplifyMotion
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal class SolidState : MotionState
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.MeshRenderer m_meshRenderer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AmplifyMotion.MotionState.Matrix3x4 m_prevLocalToWorld;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AmplifyMotion.MotionState.Matrix3x4 m_currLocalToWorld;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Mesh m_mesh;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AmplifyMotion.MotionState.MaterialDesc[] m_sharedMaterials;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool m_moved;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool m_wasVisible;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static System.Collections.Generic.HashSet<AmplifyMotionObjectBase> m_uniqueWarnings;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SolidState(AmplifyMotionCamera owner, AmplifyMotionObjectBase obj)
        {
            this.m_meshRenderer = obj.GetComponent<UnityEngine.MeshRenderer>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void IssueError(string message)
        {
            var val_3;
            System.Collections.Generic.HashSet<AmplifyMotionObjectBase> val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = AmplifyMotion.SolidState.m_uniqueWarnings;
            if((val_4.Contains(item:  X22)) != true)
            {
                    UnityEngine.Debug.LogWarning(message:  message);
                val_5 = null;
                val_5 = null;
                bool val_2 = AmplifyMotion.SolidState.m_uniqueWarnings.Add(item:  val_4);
            }
            
            mem[1152921520146866704] = 1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal override void Initialize()
        {
            UnityEngine.MeshFilter val_1 = GetComponent<UnityEngine.MeshFilter>();
            if(val_1 != 0)
            {
                    if(val_1.sharedMesh != 0)
            {
                goto label_8;
            }
            
            }
            
            this.IssueError(message:  "[AmplifyMotion] Invalid MeshFilter/Mesh in object "("[AmplifyMotion] Invalid MeshFilter/Mesh in object ") + val_1.name + ". Skipping.");
            return;
            label_8:
            mem[1152921520147081281] = 1;
            this.m_mesh = val_1.sharedMesh;
            UnityEngine.Material[] val_8 = this.m_meshRenderer.sharedMaterials;
            this.m_sharedMaterials = val_8.ProcessSharedMaterials(mats:  val_8);
            this.m_wasVisible = false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal override void UpdateTransform(UnityEngine.Rendering.CommandBuffer updateCB, bool starting)
        {
            MotionState.Matrix3x4 val_2;
            var val_3;
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
            var val_27;
            var val_28;
            var val_29;
            var val_30;
            bool val_31;
            val_28 = starting;
            val_29 = this;
            if(true == 0)
            {
                goto label_1;
            }
            
            if((val_28 != true) && (this.m_wasVisible != false))
            {
                    mem[1152921520147299896] = ???;
                mem[1152921520147299880] = ???;
                this.m_prevLocalToWorld = this.m_currLocalToWorld;
            }
            
            UnityEngine.Matrix4x4 val_1 = localToWorldMatrix;
            this.m_currLocalToWorld = val_2;
            mem[1152921520147299916] = val_5;
            mem[1152921520147299920] = val_8;
            mem[1152921520147299924] = val_11;
            mem[1152921520147299928] = val_3;
            mem[1152921520147299932] = val_6;
            mem[1152921520147299936] = val_9;
            mem[1152921520147299940] = val_12;
            mem[1152921520147299944] = val_4;
            mem[1152921520147299948] = val_7;
            mem[1152921520147299952] = val_10;
            mem[1152921520147299956] = val_13;
            mem[1152921520147299976] = 1;
            if(Overlay == true)
            {
                goto label_6;
            }
            
            if(val_28 == false)
            {
                goto label_7;
            }
            
            val_31 = 1;
            goto label_8;
            label_1:
            val_27 = ???;
            val_28 = ???;
            val_30 = ???;
            goto typeof(AmplifyMotion.SolidState).__il2cppRuntimeField_168;
            label_7:
            mem2[0] = ??? + 32;
            mem2[0] = ??? + 16;
            mem2[0] = ???;
            val_31 = AmplifyMotion.MotionState.MatrixChanged(a:  new Matrix3x4() {m00 = val_27 + -112, m01 = val_27 + -112, m02 = val_27 + -112, m03 = val_27 + -112, m10 = val_27 + -96, m11 = val_27 + -96, m12 = val_27 + -96, m13 = val_27 + -96, m20 = val_27 + -96 + 16, m21 = val_27 + -96 + 16, m22 = val_27 + -96 + 16, m23 = val_27 + -96 + 16}, b:  new Matrix3x4() {m00 = ??? + 56, m01 = ??? + 56, m02 = ??? + 56, m03 = ??? + 56, m10 = ??? + 72, m11 = ??? + 72, m12 = ??? + 72, m13 = ??? + 72, m20 = ??? + 88, m21 = ??? + 88, m22 = ??? + 88, m23 = ??? + 88});
            label_8:
            mem2[0] = val_31;
            label_6:
            if((val_28 & 1) == 0)
            {
                    if((??? + 169) != 0)
            {
                goto label_12;
            }
            
            }
            
            mem2[0] = ??? + 32;
            mem2[0] = ??? + 16;
            mem2[0] = ???;
            label_12:
            mem2[0] = ??? + 48.isVisible;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal override void RenderVectors(UnityEngine.Camera camera, UnityEngine.Rendering.CommandBuffer renderCB, float scale, AmplifyMotion.Quality quality)
        {
            float val_17;
            float val_18;
            float val_19;
            float val_22;
            float val_23;
            UnityEngine.GameObject val_24;
            var val_26;
            var val_27;
            float val_28;
            float val_29;
            var val_30;
            float val_31;
            float val_32;
            MotionState.Matrix3x4 val_33;
            float val_34;
            var val_35;
            UnityEngine.Material val_36;
            float val_37;
            var val_39;
            string val_40;
            val_23 = scale;
            if(true == 0)
            {
                    return;
            }
            
            if(true != 0)
            {
                    return;
            }
            
            if(this.m_meshRenderer.isVisible == false)
            {
                    return;
            }
            
            val_22 = mem[69734424];
            val_24 = X23.gameObject;
            int val_5 = val_24.layer & 31;
            val_5 = 1 << val_5;
            val_5 = val_5 & (UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask() {m_Mask = mem[69734424] + 72}));
            if(val_5 != 0)
            {
                    if(this.m_moved == false)
            {
                    return;
            }
            
                val_26 = (mem[69734424] + 24 + 36) * val_23;
                val_27 = (mem[69734424] + 24 + 40) * val_23;
                val_23 = ((float)mem[69734424] + 24.GenerateObjectId(obj:  val_24.gameObject)) * 0.003921569f;
            }
            else
            {
                    val_23 = 1f;
                val_26 = 0f;
                val_27 = 0f;
            }
            
            if(renderCB == null)
            {
                    val_28 = ???;
                val_31 = ???;
                val_29 = ???;
                val_30 = 1;
            }
            
            renderCB.SetGlobalMatrix(name:  "_AM_MATRIX_PREV_M", value:  new UnityEngine.Matrix4x4() {m00 = this.m_prevLocalToWorld, m10 = quality, m20 = ???, m30 = 0f, m01 = val_28, m11 = ???, m21 = val_24, m31 = 0f, m02 = val_29, m12 = ???, m22 = val_22, m32 = 0f, m03 = 1.401298E-45f, m13 = val_31, m23 = ???, m33 = 1f});
            val_33 = this.m_currLocalToWorld;
            if(renderCB == null)
            {
                    val_32 = val_28;
                val_37 = val_31;
                val_34 = val_29;
                val_35 = val_30;
            }
            
            renderCB.SetGlobalMatrix(name:  "_AM_MATRIX_CURR_M", value:  new UnityEngine.Matrix4x4() {m00 = val_33, m10 = ???, m20 = ???, m30 = 0f, m01 = val_32, m11 = val_22, m21 = quality, m31 = 0f, m02 = val_34, m12 = ???, m22 = this.m_prevLocalToWorld, m32 = 0f, m03 = 1.401298E-45f, m13 = val_37, m23 = ???, m33 = 1f});
            renderCB.SetGlobalVector(name:  "_AM_MOTION_PARAMS", value:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
            val_39 = 0;
            goto label_22;
            label_39:
            if(0 != 0)
            {
                    UnityEngine.Texture val_10 = 64.mainTexture;
                if(val_10 != 0)
            {
                    69077560.SetTexture(name:  "_MainTex", value:  val_10);
            }
            
                if((0 & 65280) != 0)
            {
                    val_40 = "_Cutoff";
                if(64 == 0)
            {
                    val_40 = "_Cutoff";
            }
            
                val_23 = 64.GetFloat(name:  val_40);
                69077560.SetFloat(name:  "_Cutoff", value:  val_23);
            }
            
            }
            
            val_33 = this.m_mesh;
            UnityEngine.Matrix4x4 val_14 = val_10.localToWorldMatrix;
            val_36 = 0.SolidVectorsMaterial;
            renderCB.DrawMesh(mesh:  val_33, matrix:  new UnityEngine.Matrix4x4() {m00 = 0f, m10 = 0f, m20 = 0f, m30 = 0f, m01 = val_19, m11 = val_19, m21 = val_19, m31 = val_19, m02 = val_17, m12 = val_17, m22 = val_17, m32 = val_17, m03 = val_18, m13 = val_18, m23 = val_18, m33 = val_18}, material:  val_36, submeshIndex:  0, shaderPass:  ((quality == 0) ? 0 : 2) | ((0 != 255) ? 1 : 0), properties:  69077560);
            val_39 = 1;
            label_22:
            val_22 = this.m_sharedMaterials;
            if(val_39 < this.m_sharedMaterials.Length)
            {
                goto label_39;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static SolidState()
        {
            AmplifyMotion.SolidState.m_uniqueWarnings = new System.Collections.Generic.HashSet<AmplifyMotionObjectBase>();
        }
    
    }

}
