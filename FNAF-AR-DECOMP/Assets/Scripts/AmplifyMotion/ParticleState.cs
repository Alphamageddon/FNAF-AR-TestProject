using UnityEngine;

namespace AmplifyMotion
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal class ParticleState : MotionState
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.ParticleSystem m_particleSystem;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.ParticleSystemRenderer m_renderer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Mesh m_mesh;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.ParticleSystem.RotationOverLifetimeModule rotationOverLifetime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.ParticleSystem.RotationBySpeedModule rotationBySpeed;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.ParticleSystem.Particle[] m_particles;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<uint, AmplifyMotion.ParticleState.Particle> m_particleDict;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<uint> m_listToRemove;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Stack<AmplifyMotion.ParticleState.Particle> m_particleStack;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int m_capacity;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AmplifyMotion.MotionState.MaterialDesc[] m_sharedMaterials;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool m_moved;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool m_wasVisible;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static System.Collections.Generic.HashSet<AmplifyMotionObjectBase> m_uniqueWarnings;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ParticleState(AmplifyMotionCamera owner, AmplifyMotionObjectBase obj)
        {
            UnityEngine.ParticleSystem val_1 = obj.GetComponent<UnityEngine.ParticleSystem>();
            this.m_particleSystem = val_1;
            this.m_renderer = val_1.GetComponent<UnityEngine.ParticleSystemRenderer>();
            RotationOverLifetimeModule val_3 = this.m_particleSystem.rotationOverLifetime;
            this.rotationOverLifetime = val_3.m_ParticleSystem;
            RotationBySpeedModule val_4 = this.m_particleSystem.rotationBySpeed;
            this.rotationBySpeed = val_4.m_ParticleSystem;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void IssueError(string message)
        {
            var val_3;
            System.Collections.Generic.HashSet<AmplifyMotionObjectBase> val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = AmplifyMotion.ParticleState.m_uniqueWarnings;
            if((val_4.Contains(item:  X22)) != true)
            {
                    UnityEngine.Debug.LogWarning(message:  message);
                val_5 = null;
                val_5 = null;
                bool val_2 = AmplifyMotion.ParticleState.m_uniqueWarnings.Add(item:  val_4);
            }
            
            mem[1152921520132455984] = 1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Mesh CreateBillboardMesh()
        {
            UnityEngine.Vector3[] val_2 = new UnityEngine.Vector3[4];
            val_2[0] = 0;
            val_2[0] = 0;
            val_2[1] = 0;
            val_2[1] = 0;
            val_2[2] = 0;
            val_2[2] = 0;
            val_2[3] = 0;
            val_2[3] = 0;
            val_2[4] = 0;
            val_2[4] = 0;
            val_2[5] = 0;
            val_2[5] = 0;
            UnityEngine.Vector2[] val_3 = new UnityEngine.Vector2[4];
            UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  0f, y:  0f);
            val_3[0] = val_4.x;
            val_3[0] = val_4.y;
            UnityEngine.Vector2 val_5 = new UnityEngine.Vector2(x:  1f, y:  0f);
            val_3[1] = val_5.x;
            val_3[1] = val_5.y;
            UnityEngine.Vector2 val_6 = new UnityEngine.Vector2(x:  1f, y:  1f);
            val_3[2] = val_6.x;
            val_3[2] = val_6.y;
            UnityEngine.Vector2 val_7 = new UnityEngine.Vector2(x:  0f, y:  1f);
            val_3[3] = val_7.x;
            val_3[3] = val_7.y;
            UnityEngine.Mesh val_8 = new UnityEngine.Mesh();
            if(val_8 != null)
            {
                    val_8.vertices = val_2;
                val_8.uv = val_3;
            }
            else
            {
                    val_8.vertices = val_2;
                val_8.uv = val_3;
            }
            
            val_8.triangles = new int[6] {0, 1, 2, 2, 3, 0};
            return val_8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Mesh CreateStretchedBillboardMesh()
        {
            UnityEngine.Vector3[] val_2 = new UnityEngine.Vector3[4];
            val_2[0] = 0;
            val_2[0] = 0;
            val_2[1] = 0;
            val_2[1] = 0;
            val_2[2] = 0;
            val_2[2] = 0;
            val_2[3] = 0;
            val_2[3] = 0;
            val_2[4] = 0;
            val_2[4] = 0;
            val_2[5] = 0;
            val_2[5] = 0;
            UnityEngine.Vector2[] val_3 = new UnityEngine.Vector2[4];
            UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  1f, y:  1f);
            val_3[0] = val_4.x;
            val_3[0] = val_4.y;
            UnityEngine.Vector2 val_5 = new UnityEngine.Vector2(x:  0f, y:  1f);
            val_3[1] = val_5.x;
            val_3[1] = val_5.y;
            UnityEngine.Vector2 val_6 = new UnityEngine.Vector2(x:  0f, y:  0f);
            val_3[2] = val_6.x;
            val_3[2] = val_6.y;
            UnityEngine.Vector2 val_7 = new UnityEngine.Vector2(x:  1f, y:  0f);
            val_3[3] = val_7.x;
            val_3[3] = val_7.y;
            UnityEngine.Mesh val_8 = new UnityEngine.Mesh();
            if(val_8 != null)
            {
                    val_8.vertices = val_2;
                val_8.uv = val_3;
            }
            else
            {
                    val_8.vertices = val_2;
                val_8.uv = val_3;
            }
            
            val_8.triangles = new int[6] {0, 1, 2, 2, 3, 0};
            return val_8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal override void Initialize()
        {
            int val_19;
            System.Collections.Generic.Stack<Particle> val_20;
            var val_21;
            if(this.m_renderer == 0)
            {
                    this.IssueError(message:  "[AmplifyMotion] Missing/Invalid Particle Renderer in object "("[AmplifyMotion] Missing/Invalid Particle Renderer in object ") + this.m_renderer.name + ". Skipping.");
                return;
            }
            
            mem[1152921520133016913] = 1;
            if(this.m_renderer.renderMode == 4)
            {
                    UnityEngine.Mesh val_5 = this.m_renderer.mesh;
            }
            else
            {
                    UnityEngine.ParticleSystemRenderMode val_6 = this.m_renderer.renderMode;
                if(val_6 == 1)
            {
                    UnityEngine.Mesh val_7 = val_6.CreateStretchedBillboardMesh();
            }
            
            }
            
            this.m_mesh = val_6.CreateBillboardMesh();
            UnityEngine.Material[] val_9 = this.m_renderer.sharedMaterials;
            this.m_sharedMaterials = val_9.ProcessSharedMaterials(mats:  val_9);
            MainModule val_11 = this.m_particleSystem.main;
            int val_12 = val_11.m_ParticleSystem.maxParticles;
            this.m_capacity = val_12;
            this.m_particleDict = new System.Collections.Generic.Dictionary<System.UInt32, Particle>(capacity:  val_12);
            this.m_particles = new Particle[0];
            this.m_listToRemove = new System.Collections.Generic.List<System.UInt32>(capacity:  this.m_capacity);
            val_19 = this.m_capacity;
            System.Collections.Generic.Stack<Particle> val_16 = null;
            val_20 = val_16;
            val_16 = new System.Collections.Generic.Stack<Particle>(capacity:  val_19);
            this.m_particleStack = val_20;
            if(this.m_capacity < 1)
            {
                goto label_14;
            }
            
            val_21 = 1;
            goto label_15;
            label_17:
            val_20 = this.m_particleStack;
            val_21 = 2;
            label_15:
            ParticleState.Particle val_17 = null;
            val_19 = val_17;
            val_17 = new ParticleState.Particle();
            val_20.Push(item:  val_17);
            if(val_21 < this.m_capacity)
            {
                goto label_17;
            }
            
            label_14:
            this.m_wasVisible = false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void RemoveDeadParticles()
        {
            var val_9;
            this.m_listToRemove.Clear();
            Dictionary.Enumerator<TKey, TValue> val_1 = this.m_particleDict.GetEnumerator();
            if(((-1653402792) & 1) == 0)
            {
                goto label_3;
            }
            
            label_12:
            UnityEngine.XR.ARSubsystems.TrackableId val_2 = 0.trackableId;
            if(0 <= 0)
            {
                goto label_5;
            }
            
            if(val_2.m_SubId1 != 0)
            {
                goto label_10;
            }
            
            goto label_10;
            label_5:
            this.m_particleStack.Push(item:  val_2.m_SubId1);
            if((this.m_listToRemove.Contains(item:  val_2.m_SubId1.region)) != true)
            {
                    this.m_listToRemove.Add(item:  val_2.m_SubId1.region);
            }
            
            label_10:
            if(((-1653402792) & 1) != 0)
            {
                goto label_12;
            }
            
            label_3:
            val_9 = 0;
            goto label_13;
            label_17:
            bool val_7 = this.m_particleDict.Remove(key:  this.m_listToRemove.Item[0]);
            val_9 = 1;
            label_13:
            if(val_9 < this.m_listToRemove.Count)
            {
                goto label_17;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal override void UpdateTransform(UnityEngine.Rendering.CommandBuffer updateCB, bool starting)
        {
            var val_4;
            var val_5;
            var val_6;
            float val_13;
            float val_26;
            float val_27;
            float val_28;
            var val_32;
            var val_33;
            var val_34;
            var val_35;
            var val_36;
            var val_37;
            var val_38;
            var val_39;
            var val_40;
            var val_41;
            var val_42;
            var val_43;
            Particle[] val_57;
            bool val_58;
            AmplifyMotion.ParticleState val_59;
            UnityEngine.ParticleSystem val_60;
            float val_63;
            float val_64;
            float val_65;
            float val_66;
            float val_67;
            float val_68;
            var val_70;
            var val_71;
            float val_72;
            float val_73;
            float val_74;
            float val_75;
            float val_76;
            float val_81;
            var val_82;
            var val_83;
            var val_84;
            var val_85;
            var val_86;
            var val_87;
            var val_88;
            var val_89;
            var val_90;
            var val_91;
            Particle[] val_92;
            float val_93;
            float val_94;
            float val_95;
            float val_96;
            Particle val_97;
            val_58 = starting;
            val_59 = this;
            val_60 = this.m_particleSystem;
            MainModule val_1 = val_60.main;
            if(true == 0)
            {
                    return;
            }
            
            if(this.m_capacity != val_1.m_ParticleSystem.maxParticles)
            {
                    return;
            }
            
            if((val_58 != true) && (this.m_wasVisible != false))
            {
                    Dictionary.Enumerator<TKey, TValue> val_3 = this.m_particleDict.GetEnumerator();
                val_57 = 1152921520133262592;
                if(((-1652713152) & 1) != 0)
            {
                    do
            {
                UnityEngine.XR.ARSubsystems.TrackableId val_7 = val_5.trackableId;
                if(val_7.m_SubId1 != 0)
            {
                    val_4 = 0;
                val_6 = 0;
                val_5 = 0;
            }
            else
            {
                    val_4 = 0;
                val_6 = 0;
                val_5 = 0;
            }
            
            }
            while(((-1652713152) & 1) != 0);
            
            }
            
            }
            
            this.m_moved = true;
            int val_8 = this.m_particleSystem.GetParticles(particles:  this.m_particles);
            UnityEngine.Vector3 val_9 = this.m_particleSystem.position;
            val_63 = val_9.z;
            UnityEngine.Quaternion val_10 = this.m_particleSystem.rotation;
            val_64 = val_10.y;
            val_65 = val_10.w;
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.one;
            val_66 = val_11.y;
            val_67 = val_9.x;
            val_68 = val_10.x;
            UnityEngine.Matrix4x4 val_12 = UnityEngine.Matrix4x4.TRS(pos:  new UnityEngine.Vector3() {x = val_67, y = val_9.y, z = val_63}, q:  new UnityEngine.Quaternion() {x = val_68, y = val_64, z = val_10.z, w = val_65}, s:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.z});
            val_60 = this.rotationOverLifetime;
            if((val_60.enabled != false) && ((val_60 & 1) != 0))
            {
                
            }
            else
            {
                    val_60 = this.rotationBySpeed;
                if(val_60.enabled != false)
            {
                
            }
            
            }
            
            if(val_8 < 1)
            {
                goto label_24;
            }
            
            val_70 = 0;
            val_71 = 32;
            label_99:
            val_57 = this.m_particles;
            uint val_56 = val_57[val_71];
            if(((this.m_particleDict.TryGetValue(key:  val_56, value: out  0)) != true) && (this.m_particleStack.Count >= 1))
            {
                    Particle val_19 = this.m_particleStack.Pop();
                this.m_particleDict.set_Item(key:  val_56, value:  val_19);
                val_58 = 1;
            }
            else
            {
                    val_58 = 0;
            }
            
            if(val_19 == 0)
            {
                goto label_96;
            }
            
            val_72 = val_13;
            val_73 = val_13;
            if(this.m_renderer.renderMode != 4)
            {
                goto label_38;
            }
            
            if((0 & 1) == 0)
            {
                goto label_41;
            }
            
            val_74 = val_13;
            val_75 = val_72;
            val_76 = val_73;
            UnityEngine.Quaternion val_21 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = val_74, y = val_75, z = val_76});
            goto label_44;
            label_38:
            if(this.m_renderer.renderMode == 0)
            {
                goto label_46;
            }
            
            UnityEngine.Matrix4x4 val_23 = UnityEngine.Matrix4x4.identity;
            goto label_49;
            label_41:
            val_74 = val_13;
            val_75 = val_13;
            val_76 = val_72;
            val_81 = val_73;
            UnityEngine.Quaternion val_24 = UnityEngine.Quaternion.AngleAxis(angle:  val_74, axis:  new UnityEngine.Vector3() {x = val_75, y = val_76, z = val_81});
            label_44:
            val_63 = val_24.z;
            val_66 = 0f;
            val_64 = val_24.x;
            val_65 = val_24.z;
            UnityEngine.Matrix4x4 val_25 = UnityEngine.Matrix4x4.TRS(pos:  new UnityEngine.Vector3() {x = val_64, y = val_24.y, z = val_65}, q:  new UnityEngine.Quaternion() {x = val_24.x, y = val_24.y, z = val_63, w = val_24.w}, s:  new UnityEngine.Vector3() {x = 0f, y = 0f});
            val_82 = 0;
            val_58 = 0;
            val_57 = 0;
            val_83 = 0;
            val_84 = 0;
            val_85 = 0;
            val_86 = 0;
            val_87 = 0;
            MainModule val_29 = val_60.main;
            if(val_29.m_ParticleSystem.simulationSpace != 1)
            {
                goto label_59;
            }
            
            val_89 = val_13;
            val_88 = 0;
            val_90 = val_26;
            val_91 = val_27;
            goto label_63;
            label_59:
            val_4 = val_4;
            val_13 = val_13;
            val_5 = val_5;
            val_6 = val_6;
            UnityEngine.Matrix4x4 val_31 = UnityEngine.Matrix4x4.op_Multiply(lhs:  new UnityEngine.Matrix4x4() {m00 = 0f, m10 = 0f, m20 = 0f, m30 = 0f, m01 = 0f, m11 = 0f, m21 = 0f, m31 = 0f, m02 = 0f, m12 = 0f, m22 = 0f, m32 = 0f, m03 = val_13, m13 = val_13, m23 = val_13, m33 = val_13}, rhs:  new UnityEngine.Matrix4x4() {m00 = 0f, m10 = 0f, m20 = 0f, m30 = 0f, m01 = 0f, m11 = 0f, m21 = 0f, m31 = 0f, m02 = 0f, m12 = 0f, m22 = 0f, m32 = 0f, m03 = val_13, m13 = val_26, m23 = val_27, m33 = val_28});
            val_88 = val_32;
            val_82 = val_33;
            val_58 = val_34;
            val_57 = val_35;
            val_83 = val_36;
            val_84 = val_37;
            val_85 = val_38;
            val_86 = val_39;
            val_87 = val_40;
            val_89 = val_41;
            val_90 = val_42;
            val_91 = val_43;
            goto label_63;
            label_46:
            MainModule val_44 = this.m_particleSystem.main;
            if(val_44.m_ParticleSystem.simulationSpace != 0)
            {
                goto label_65;
            }
            
            val_92 = this.m_particles;
            if(this.m_particles != null)
            {
                goto label_66;
            }
            
            val_92 = this.m_particles;
            if(val_92 == null)
            {
                goto label_95;
            }
            
            label_66:
            val_67 = val_13;
            val_72 = val_72;
            val_73 = val_73;
            label_65:
            if((0 & 1) != 0)
            {
                    val_93 = -val_67;
                val_94 = -val_72;
                val_95 = val_73;
                UnityEngine.Quaternion val_46 = UnityEngine.Quaternion.Euler(x:  val_93, y:  val_94, z:  val_95);
            }
            else
            {
                    UnityEngine.Vector3 val_47 = UnityEngine.Vector3.back;
                val_93 = val_67;
                val_94 = val_47.x;
                val_95 = val_47.y;
                val_96 = val_47.z;
                UnityEngine.Quaternion val_48 = UnityEngine.Quaternion.AngleAxis(angle:  val_93, axis:  new UnityEngine.Vector3() {x = val_94, y = val_95, z = val_96});
            }
            
            val_65 = val_48.z;
            UnityEngine.Quaternion val_49 = this.m_particles[2].rotation;
            UnityEngine.Quaternion val_50 = UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = val_49.x, y = val_49.y, z = val_49.z, w = val_49.w}, rhs:  new UnityEngine.Quaternion() {x = val_48.x, y = val_48.y, z = val_48.z, w = val_48.w});
            val_64 = 0f;
            val_66 = val_50.x;
            val_63 = val_50.z;
            UnityEngine.Matrix4x4 val_51 = UnityEngine.Matrix4x4.TRS(pos:  new UnityEngine.Vector3() {x = val_48.x, y = val_48.y, z = val_65}, q:  new UnityEngine.Quaternion() {x = val_66, y = val_50.y, z = val_63, w = val_50.w}, s:  new UnityEngine.Vector3() {x = 0f, y = 0f});
            label_49:
            val_88 = 0;
            val_82 = 0;
            val_58 = 0;
            val_57 = 0;
            val_83 = 0;
            val_84 = 0;
            val_85 = 0;
            val_86 = 0;
            val_87 = 0;
            val_89 = val_13;
            val_90 = val_13;
            val_91 = val_13;
            label_63:
            val_97 = val_19;
            if(val_97 == 0)
            {
                goto label_93;
            }
            
            mem2[0] = 1;
            goto label_94;
            label_93:
            val_91 = val_91;
            val_90 = val_90;
            val_89 = val_89;
            val_88 = val_88;
            val_82 = val_82;
            val_58 = val_58;
            val_57 = val_57;
            val_83 = val_83;
            val_84 = val_84;
            val_70 = val_70;
            val_85 = val_85;
            val_86 = val_86;
            val_87 = val_87;
            mem2[0] = 1;
            val_97 = val_19;
            if(val_19 == 0)
            {
                goto label_95;
            }
            
            label_94:
            mem2[0] = val_88;
            mem2[0] = val_57;
            mem2[0] = val_85;
            mem2[0] = val_89;
            mem2[0] = val_82;
            mem2[0] = val_83;
            mem2[0] = val_86;
            mem2[0] = val_90;
            mem2[0] = val_58;
            mem2[0] = val_84;
            mem2[0] = val_87;
            mem2[0] = val_91;
            val_59 = val_59;
            val_71 = val_71;
            if(val_58 != 0)
            {
                    val_57 = val_19;
                if(val_57 != 0)
            {
                    val_4 = val_19 + 100;
                val_6 = val_19 + 84;
                val_5 = val_19 + 68;
            }
            else
            {
                    val_4 = ;
                val_6 = ;
                val_5 = ;
            }
            
                mem2[0] = val_4;
                mem2[0] = val_6;
                mem2[0] = val_5;
            }
            
            label_96:
            val_70 = val_70 + 1;
            val_60 = val_71 + 124;
            if(val_8 != val_70)
            {
                goto label_99;
            }
            
            label_24:
            if(val_58 != true)
            {
                    if(this.m_wasVisible == true)
            {
                goto label_103;
            }
            
            }
            
            Dictionary.Enumerator<TKey, TValue> val_52 = this.m_particleDict.GetEnumerator();
            val_57 = 1152921520133262592;
            if(((-1652713232) & 1) != 0)
            {
                    val_60 = 1152921520133263616;
                do
            {
                UnityEngine.XR.ARSubsystems.TrackableId val_53 = 0.trackableId;
                if(val_53.m_SubId1 != 0)
            {
                    val_4 = 0;
                val_6 = 0;
                val_5 = 0;
            }
            else
            {
                    val_4 = 0;
                val_6 = 0;
                val_5 = 0;
            }
            
            }
            while(((-1652713232) & 1) != 0);
            
            }
            
            label_103:
            this.RemoveDeadParticles();
            this.m_wasVisible = this.m_renderer.isVisible;
            return;
            label_95:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal override void RenderVectors(UnityEngine.Camera camera, UnityEngine.Rendering.CommandBuffer renderCB, float scale, AmplifyMotion.Quality quality)
        {
            float val_18;
            float val_19;
            float val_20;
            float val_22;
            float val_23;
            float val_25;
            float val_26;
            float val_27;
            float val_28;
            var val_30;
            float val_31;
            AmplifyMotion.ParticleState val_32;
            UnityEngine.GameObject val_33;
            float val_34;
            UnityEngine.Material val_35;
            string val_36;
            float val_37;
            float val_38;
            val_31 = scale;
            val_32 = this;
            if(true == 0)
            {
                    return;
            }
            
            if(true != 0)
            {
                    return;
            }
            
            val_32 = this.m_renderer;
            if(val_32.isVisible == false)
            {
                    return;
            }
            
            val_30 = mem[mem[1152921520134697152] + 24];
            val_30 = mem[1152921520134697152] + 24;
            val_32 = UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask() {m_Mask = mem[1152921520134697152] + 24 + 72});
            val_33 = mem[1152921520134697160].gameObject;
            int val_5 = val_33.layer & 31;
            val_5 = 1 << val_5;
            int val_6 = val_5 & val_32;
            if(val_6 != 0)
            {
                    if(mem[1152921520134697256] == false)
            {
                    return;
            }
            
                val_33 = mem[1152921520134697160].gameObject;
                val_34 = ((float)mem[1152921520134697152] + 24.GenerateObjectId(obj:  val_33)) * 0.003921569f;
            }
            else
            {
                    val_34 = 1f;
            }
            
            renderCB.SetGlobalFloat(name:  "_AM_OBJECT_ID", value:  val_34);
            renderCB.SetGlobalFloat(name:  "_AM_MOTION_SCALE", value:  (val_6 != 0) ? (val_31) : 0f);
            val_32 = val_32;
            goto label_17;
            label_42:
            var val_30 = 24;
            val_30 = mem[1152921520134697248] + (0 * val_30);
            val_35 = mem[(0 * 24) + mem[1152921520134697248] + 40 + 8];
            val_35 = (0 * 24) + mem[1152921520134697248] + 40 + 8;
            if((val_35 & 255) != 0)
            {
                    UnityEngine.Texture val_13 = (0 * 24) + mem[1152921520134697248] + 32.mainTexture;
                if(val_13 != 0)
            {
                    (0 * 24) + mem[1152921520134697248] + 40.SetTexture(name:  "_MainTex", value:  val_13);
            }
            
                if((val_35 & 65280) != 0)
            {
                    val_36 = "_Cutoff";
                if(((0 * 24) + mem[1152921520134697248] + 32) == 0)
            {
                    val_36 = "_Cutoff";
            }
            
                val_31 = (0 * 24) + mem[1152921520134697248] + 32.GetFloat(name:  val_36);
                (0 * 24) + mem[1152921520134697248] + 40.SetFloat(name:  "_Cutoff", value:  val_31);
            }
            
            }
            
            val_33 = mem[1152921520134697216];
            Dictionary.Enumerator<TKey, TValue> val_17 = val_33.GetEnumerator();
            if(((-1652031200) & 1) != 0)
            {
                    int val_31 = (quality == 0) ? 0 : 2;
                val_31 = val_31 | ((val_35 != 255) ? 1 : 0);
                do
            {
                UnityEngine.XR.ARSubsystems.TrackableId val_21 = val_19.trackableId;
                val_18 = mem[1152921520134697152] + 256;
                val_20 = mem[1152921520134697152] + 240;
                val_19 = mem[1152921520134697152] + 224;
                val_37 = val_19;
                val_38 = val_20;
                val_37 = val_37;
                val_38 = val_38;
                UnityEngine.Matrix4x4 val_24 = UnityEngine.Matrix4x4.op_Multiply(lhs:  new UnityEngine.Matrix4x4() {m00 = val_19, m10 = val_19, m20 = val_19, m30 = val_19, m01 = val_20, m11 = val_20, m21 = val_20, m31 = val_20, m02 = val_18, m12 = val_18, m22 = val_18, m32 = val_18, m03 = mem[1152921520134697152] + 272, m13 = mem[1152921520134697152] + 272, m23 = mem[1152921520134697152] + 272, m33 = mem[1152921520134697152] + 272}, rhs:  new UnityEngine.Matrix4x4() {m00 = val_19, m10 = val_20, m20 = val_18, m30 = 0f, m01 = val_19, m11 = val_20, m21 = val_22, m31 = 0f, m02 = val_37, m12 = val_20, m22 = val_23, m32 = 0f, m03 = val_38, m13 = val_18, m23 = ???, m33 = 1f});
                renderCB.SetGlobalMatrix(name:  "_AM_MATRIX_PREV_MVP", value:  new UnityEngine.Matrix4x4() {m00 = val_27, m10 = val_27, m20 = val_27, m30 = val_27, m01 = val_28, m11 = val_28, m21 = val_28, m31 = val_28, m02 = val_25, m12 = val_25, m22 = val_25, m32 = val_25, m03 = val_26, m13 = val_26, m23 = val_26, m33 = val_26});
                val_33 = ???;
                val_35 = mem[1152921520134697152] + 24.SolidVectorsMaterial;
                renderCB.DrawMesh(mesh:  mem[1152921520134697184], matrix:  new UnityEngine.Matrix4x4() {m00 = ???, m10 = ???, m20 = ???, m30 = 0f, m01 = ???, m11 = ???, m21 = ???, m31 = 0f, m02 = ???, m12 = ???, m22 = ???, m32 = 0f, m03 = ???, m13 = ???, m23 = val_33, m33 = 1f}, material:  val_35, submeshIndex:  0, shaderPass:  val_31, properties:  (0 * 24) + mem[1152921520134697248] + 40);
                val_32 = val_32;
            }
            while(((-1652031200) & 1) != 0);
            
            }
            
            var val_32 = 0;
            val_32 = val_32 + 1;
            label_17:
            val_30 = mem[1152921520134697248];
            if(val_32 < (mem[1152921520134697248] + 24))
            {
                goto label_42;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static ParticleState()
        {
            AmplifyMotion.ParticleState.m_uniqueWarnings = new System.Collections.Generic.HashSet<AmplifyMotionObjectBase>();
        }
    
    }

}
