using UnityEngine;

namespace AmplifyMotion
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    internal abstract class MotionState
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const int AsyncUpdateTimeout = 100;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected bool m_error;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected bool m_initialized;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected UnityEngine.Transform m_transform;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected AmplifyMotionCamera m_owner;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected AmplifyMotionObjectBase m_obj;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static System.Collections.Generic.HashSet<UnityEngine.Material> m_materialWarnings;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AmplifyMotionCamera Owner { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool Initialized { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool Error { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AmplifyMotionCamera get_Owner()
        {
            return (AmplifyMotionCamera)this.m_owner;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_Initialized()
        {
            return (bool)this.m_initialized;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_Error()
        {
            return (bool)this.m_error;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MotionState(AmplifyMotionCamera owner, AmplifyMotionObjectBase obj)
        {
            this.m_error = false;
            this.m_initialized = false;
            this.m_owner = owner;
            this.m_obj = obj;
            this.m_transform = obj.transform;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal virtual void Initialize()
        {
            this.m_initialized = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal virtual void Shutdown()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal virtual void AsyncUpdate()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal abstract void UpdateTransform(UnityEngine.Rendering.CommandBuffer updateCB, bool starting); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal virtual void RenderVectors(UnityEngine.Camera camera, UnityEngine.Rendering.CommandBuffer renderCB, float scale, AmplifyMotion.Quality quality)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal virtual void RenderDebugHUD()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected AmplifyMotion.MotionState.MaterialDesc[] ProcessSharedMaterials(UnityEngine.Material[] mats)
        {
            int val_19;
            UnityEngine.Object val_20;
            var val_21;
            var val_22;
            var val_23;
            MaterialDesc[] val_1 = new MaterialDesc[0];
            val_19 = mats.Length;
            if(val_19 < 1)
            {
                    return val_1;
            }
            
            var val_23 = 0;
            do
            {
                if(val_1 == null)
            {
                    val_19 = mats.Length;
            }
            
                var val_2 = val_1 + (0 * 24);
                mem2[0] = mats[0];
                val_20 = mem[mats[0x0] + 32];
                val_20 = mats[0x0] + 32;
                if(val_20 != 0)
            {
                    if((System.String.op_Equality(a:  mats[0x0] + 32.GetTag(tag:  "RenderType", searchFallbacks:  false), b:  "TransparentCutout")) != false)
            {
                    val_21 = 1;
            }
            else
            {
                    val_21 = mats[0x0] + 32.IsKeywordEnabled(keyword:  "_ALPHATEST_ON");
            }
            
                var val_8 = val_1 + (0 * 24);
                mem2[0] = new UnityEngine.MaterialPropertyBlock();
                var val_11 = val_1 + (0 * 24);
                mem2[0] = val_21 & (mats[0x0] + 32.HasProperty(name:  "_MainTex"));
                val_20 = mats[0x0] + 32.HasProperty(name:  "_Cutoff");
                var val_14 = val_1 + (0 * 24);
                mem2[0] = val_20;
                if((val_21 != false) && (((0 * 24) + val_1 + 48) == 0))
            {
                    val_22 = null;
                val_22 = null;
                val_20 = AmplifyMotion.MotionState.m_materialWarnings;
                if((val_20.Contains(item:  (0 * 24) + val_1 + 32)) != true)
            {
                    string[] val_16 = new string[5];
                val_16[0] = "[AmplifyMotion] TransparentCutout material \"";
                val_16[1] = (0 * 24) + val_1 + 32.name;
                val_16[2] = "\" {";
                val_16[3] = (0 * 24) + val_1 + 32.shader.name;
                val_16[4] = "} not using _MainTex standard property.";
                UnityEngine.Debug.LogWarning(message:  +val_16);
                val_23 = null;
                val_23 = null;
                val_20 = AmplifyMotion.MotionState.m_materialWarnings;
                bool val_21 = val_20.Add(item:  (0 * 24) + val_1 + 32);
            }
            
            }
            
            }
            
                val_23 = val_23 + 1;
            }
            while(val_23 < mats.Length);
            
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected static bool MatrixChanged(AmplifyMotion.MotionState.Matrix3x4 a, AmplifyMotion.MotionState.Matrix3x4 b)
        {
            var val_11;
            float val_11 = a.m00;
            float val_12 = a.m01;
            val_11 = val_11 - b.m00;
            val_12 = val_12 - b.m01;
            float val_1 = a.m02 - b.m02;
            float val_2 = a.m03 - b.m03;
            if((UnityEngine.Vector4.SqrMagnitude(a:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f})) > 0f)
            {
                goto label_3;
            }
            
            float val_13 = a.m10;
            float val_14 = a.m11;
            val_13 = val_13 - b.m10;
            val_14 = val_14 - b.m11;
            float val_4 = a.m12 - b.m12;
            float val_5 = a.m13 - b.m13;
            if((UnityEngine.Vector4.SqrMagnitude(a:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f})) <= 0f)
            {
                goto label_6;
            }
            
            label_3:
            val_11 = 1;
            return (bool)((UnityEngine.Vector4.SqrMagnitude(a:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f})) > 0f) ? 1 : 0;
            label_6:
            float val_15 = a.m20;
            float val_16 = a.m21;
            val_15 = val_15 - b.m20;
            val_16 = val_16 - b.m21;
            float val_7 = a.m22 - b.m22;
            float val_8 = a.m23 - b.m23;
            return (bool)((UnityEngine.Vector4.SqrMagnitude(a:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f})) > 0f) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected static void MulPoint3x4_XYZ(ref UnityEngine.Vector3 result, ref AmplifyMotion.MotionState.Matrix3x4 mat, UnityEngine.Vector4 vec)
        {
            float val_2 = mat.m00;
            float val_3 = mat.m01;
            float val_4 = mat.m02;
            val_2 = vec.x * val_2;
            val_3 = vec.y * val_3;
            val_4 = vec.z * val_4;
            val_2 = val_2 + val_3;
            val_2 = val_2 + val_4;
            val_2 = mat.m03 + val_2;
            result.x = val_2;
            float val_5 = mat.m10;
            float val_6 = mat.m11;
            float val_7 = mat.m12;
            val_5 = vec.x * val_5;
            val_6 = vec.y * val_6;
            val_7 = vec.z * val_7;
            val_5 = val_5 + val_6;
            val_5 = val_5 + val_7;
            val_5 = mat.m13 + val_5;
            result.y = val_5;
            vec.x = vec.x * mat.m20;
            vec.y = vec.y * mat.m21;
            vec.x = vec.x + vec.y;
            vec.x = vec.x + (vec.z * mat.m22);
            vec.x = mat.m23 + vec.x;
            result.z = vec.x;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected static void MulPoint3x4_XYZW(ref UnityEngine.Vector3 result, ref AmplifyMotion.MotionState.Matrix3x4 mat, UnityEngine.Vector4 vec)
        {
            float val_2 = mat.m00;
            float val_3 = mat.m01;
            float val_4 = mat.m02;
            float val_5 = mat.m03;
            val_2 = vec.x * val_2;
            val_3 = vec.y * val_3;
            val_4 = vec.z * val_4;
            val_2 = val_2 + val_3;
            val_5 = vec.w * val_5;
            val_2 = val_2 + val_4;
            val_2 = val_2 + val_5;
            result.x = val_2;
            float val_6 = mat.m10;
            float val_7 = mat.m11;
            float val_8 = mat.m12;
            float val_9 = mat.m13;
            val_6 = vec.x * val_6;
            val_7 = vec.y * val_7;
            val_8 = vec.z * val_8;
            val_6 = val_6 + val_7;
            val_9 = vec.w * val_9;
            val_6 = val_6 + val_8;
            val_6 = val_6 + val_9;
            result.y = val_6;
            vec.x = vec.x * mat.m20;
            vec.y = vec.y * mat.m21;
            vec.z = vec.z * mat.m22;
            vec.x = vec.x + vec.y;
            vec.x = vec.x + vec.z;
            vec.x = vec.x + (vec.w * mat.m23);
            result.z = vec.x;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected static void MulAddPoint3x4_XYZW(ref UnityEngine.Vector3 result, ref AmplifyMotion.MotionState.Matrix3x4 mat, UnityEngine.Vector4 vec)
        {
            float val_2 = mat.m00;
            float val_3 = mat.m01;
            float val_4 = mat.m02;
            float val_5 = mat.m03;
            val_2 = vec.x * val_2;
            val_3 = vec.y * val_3;
            val_2 = val_2 + val_3;
            val_4 = vec.z * val_4;
            val_5 = vec.w * val_5;
            val_2 = val_2 + val_4;
            val_2 = val_2 + val_5;
            val_2 = result.x + val_2;
            result.x = val_2;
            float val_6 = mat.m10;
            float val_7 = mat.m11;
            float val_8 = mat.m12;
            float val_9 = mat.m13;
            val_6 = vec.x * val_6;
            val_7 = vec.y * val_7;
            val_6 = val_6 + val_7;
            val_8 = vec.z * val_8;
            val_9 = vec.w * val_9;
            val_6 = val_6 + val_8;
            val_6 = val_6 + val_9;
            val_6 = result.y + val_6;
            result.y = val_6;
            vec.x = vec.x * mat.m20;
            vec.y = vec.y * mat.m21;
            vec.z = vec.z * mat.m22;
            vec.x = vec.x + vec.y;
            vec.x = vec.x + vec.z;
            vec.x = vec.x + (vec.w * mat.m23);
            vec.x = result.z + vec.x;
            result.z = vec.x;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static MotionState()
        {
            AmplifyMotion.MotionState.m_materialWarnings = new System.Collections.Generic.HashSet<UnityEngine.Material>();
        }
    
    }

}
