using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_RandomOnMesh : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _previous;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool ToggleToGenerate;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool SavePoints2D;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Dest.Math.ProjectionPlanes Projection;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool SavePoints3D;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Count;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool DistanceFiltering;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Distance;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float ParticleSize;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool UseSpawnMap;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Texture2D SpawnMap;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float MinFactor;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float MaxFactor;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.MeshFilter MeshFilter;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.ParticleSystem Particles;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            bool val_3 = this.ToggleToGenerate;
            if(((val_3 == true) ? 1 : 0) != ((this._previous == true) ? 1 : 0))
            {
                    this.Generate();
                val_3 = this.ToggleToGenerate;
            }
            
            this._previous = val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Generate()
        {
            float val_9;
            float val_11;
            float val_12;
            object val_39;
            Dest.Math.Tests.Test_RandomOnMesh val_40;
            float val_41;
            UnityEngine.Vector3[] val_43;
            string val_44;
            var val_45;
            float val_46;
            var val_47;
            var val_48;
            Particle[] val_49;
            var val_50;
            var val_51;
            var val_52;
            int val_54;
            int val_55;
            int val_58;
            val_40 = this;
            UnityEngine.Mesh val_1 = this.MeshFilter.sharedMesh;
            Dest.Math.IndexedTrianglesSampler val_2 = new Dest.Math.IndexedTrianglesSampler(mesh:  val_1);
            if(this.UseSpawnMap != false)
            {
                    val_41 = this.MinFactor;
                UnityEngine.Vector3[] val_4 = val_2.SampleArray(count:  this.Count, uvs:  val_1.uv, sampleMap:  this.SpawnMap, min:  val_41, max:  this.MaxFactor);
            }
            
            val_43 = val_2.SampleArray(count:  this.Count);
            val_44 = val_5.Length + " points were generated";
            if(this.DistanceFiltering == false)
            {
                goto label_8;
            }
            
            UnityEngine.Bounds val_8 = this.MeshFilter.sharedMesh.bounds;
            Dest.Math.AAB3 val_10 = Dest.Math.AAB3.op_Implicit(value:  new UnityEngine.Bounds() {m_Center = new UnityEngine.Vector3() {x = val_5.Length}, m_Extents = new UnityEngine.Vector3() {y = val_9, z = val_9}});
            val_41 = this.Distance;
            val_45 = null;
            val_45 = null;
            System.Collections.Generic.List<System.Int32> val_13 = Dest.Math.PointsFilter.DistanceFilter(points:  val_43, pointsAAB:  new Dest.Math.AAB3() {Min = new UnityEngine.Vector3() {x = val_11, y = val_11, z = val_11}, Max = new UnityEngine.Vector3() {x = val_11, y = val_12, z = val_12}}, radius:  val_41, rand:  Dest.Math.Rand.Instance);
            int val_14 = val_13.Count;
            val_46 = 1152921518615434288;
            val_47 = 0;
            goto label_14;
            label_20:
            var val_17 = val_43 + ((long)val_13.Item[0] * 12);
            val_48 = mem[((long)(int)(val_16) * 12) + val_5 + 32];
            val_48 = ((long)(int)(val_16) * 12) + val_5 + 32;
            val_47 = 1;
            mem[1152921519587625456] = val_48;
            mem[1152921519587625460] = ((long)(int)(val_16) * 12) + val_5 + 32 + 4;
            mem[1152921519587625464] = ((long)(int)(val_16) * 12) + val_5 + 40;
            label_14:
            if(val_47 < val_13.Count)
            {
                goto label_20;
            }
            
            object[] val_19 = new object[4];
            val_40 = val_40;
            val_19[0] = val_44;
            val_19[1] = ". ";
            val_19[2] = val_13.Count;
            val_39 = " points left after filtering";
            val_19[3] = val_39;
            val_44 = +val_19;
            val_43 = new UnityEngine.Vector3[0];
            label_8:
            Dest.Math.Logger.LogInfo(value:  val_44);
            Particle[] val_22 = new Particle[0];
            val_49 = val_22;
            val_50 = 0;
            val_51 = 124;
            goto label_37;
            label_42:
            val_48 = 0;
            UnityEngine.Color val_23 = UnityEngine.Color.blue;
            UnityEngine.Color32 val_24 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = val_23.r, g = val_23.g, b = val_23.b, a = val_23.a});
            byte val_25 = val_24.r & 4294967295;
            var val_27 = (val_49 + (val_48 * val_51)) + 32;
            val_50 = 1;
            label_37:
            if(val_50 < val_15.Length)
            {
                goto label_42;
            }
            
            if(val_49 == null)
            {
                goto label_43;
            }
            
            label_58:
            mem[1152921519587437920].SetParticles(particles:  val_22, size:  val_22.Length);
            if(mem[1152921519587437866] == false)
            {
                goto label_45;
            }
            
            val_49 = new UnityEngine.GameObject(name:  "Vector2Array").AddComponent<Dest.Math.Tests.Test_Vector2Array>();
            UnityEngine.Vector2[] val_30 = new UnityEngine.Vector2[0];
            if(mem[1152921519587437868] == 0)
            {
                goto label_47;
            }
            
            val_52 = val_15.Length & 4294967295;
            if(mem[1152921519587437868] != 1)
            {
                goto label_48;
            }
            
            if(val_15.Length < 1)
            {
                goto label_67;
            }
            
            val_51 = 0;
            goto label_50;
            label_55:
            val_54 = val_15.Length;
            val_51 = 1;
            label_50:
            if(val_51 >= val_54)
            {
                    val_54 = val_15.Length;
            }
            
            UnityEngine.Vector2 val_32 = new UnityEngine.Vector2(x:  4.372641E+10f, y:  4.372641E+10f);
            val_46 = val_32.x;
            val_39 = val_32.y;
            mem2[0] = val_46;
            mem2[0] = val_39;
            if((val_52 - 1) != val_51)
            {
                goto label_55;
            }
            
            goto label_67;
            label_43:
            if(mem[1152921519587437920] != 0)
            {
                goto label_58;
            }
            
            goto label_58;
            label_47:
            if(val_15.Length < 1)
            {
                goto label_67;
            }
            
            val_55 = val_15.Length & 4294967295;
            val_51 = 0;
            goto label_60;
            label_65:
            val_55 = val_15.Length;
            val_51 = 1;
            label_60:
            if(val_51 >= val_55)
            {
                    val_55 = val_15.Length;
            }
            
            UnityEngine.Vector2 val_34 = new UnityEngine.Vector2(x:  4.372641E+10f, y:  4.372641E+10f);
            val_46 = val_34.x;
            val_39 = val_34.y;
            mem2[0] = val_46;
            mem2[0] = val_39;
            if((val_55 - 1) != val_51)
            {
                goto label_65;
            }
            
            goto label_67;
            label_48:
            if(val_15.Length < 1)
            {
                goto label_67;
            }
            
            val_51 = 0;
            goto label_68;
            label_73:
            val_58 = val_15.Length;
            val_51 = 1;
            label_68:
            if(val_51 >= val_58)
            {
                    val_58 = val_15.Length;
            }
            
            UnityEngine.Vector2 val_36 = new UnityEngine.Vector2(x:  4.372641E+10f, y:  4.372641E+10f);
            val_46 = val_36.x;
            val_39 = val_36.y;
            mem2[0] = val_46;
            mem2[0] = val_39;
            if((val_52 - 1) != val_51)
            {
                goto label_73;
            }
            
            label_67:
            val_29.Array = val_30;
            label_45:
            if(mem[1152921519587437872] == false)
            {
                    return;
            }
            
            val_39 = new UnityEngine.GameObject(name:  "Vector3Array").AddComponent<Dest.Math.Tests.Test_Vector3Array>();
            val_38.Array = val_43;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_RandomOnMesh()
        {
        
        }
    
    }

}
