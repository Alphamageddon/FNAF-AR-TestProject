using UnityEngine;

namespace Mapbox.Unity.MeshGeneration.Modifiers
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class LoftModifier : MeshModifier
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.GameObject Slice;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool _closeEdges;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _counter;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<UnityEngine.Vector3> _slice;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _sliceCount;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _sliceTotalMagnitude;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector2[] _sliceUvs;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override Mapbox.Unity.MeshGeneration.Modifiers.ModifierType Type { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override Mapbox.Unity.MeshGeneration.Modifiers.ModifierType get_Type()
        {
            return 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void Initialize()
        {
            float val_25;
            float val_26;
            float val_27;
            var val_29;
            System.Collections.Generic.List<UnityEngine.Vector3> val_30;
            var val_33;
            int val_35;
            float val_36;
            float val_37;
            this._slice = new System.Collections.Generic.List<UnityEngine.Vector3>();
            System.Collections.IEnumerator val_3 = this.Slice.transform.GetEnumerator();
            goto label_13;
            label_20:
            var val_27 = 0;
            val_27 = val_27 + 1;
            object val_5 = val_3.Current;
            UnityEngine.Vector3 val_8 = 0.position;
            val_25 = val_8.x;
            val_26 = val_8.z;
            val_27 = val_26;
            this._slice.Add(item:  new UnityEngine.Vector3() {x = val_25, y = val_8.y, z = val_27});
            label_13:
            var val_28 = 0;
            val_28 = val_28 + 1;
            if(val_3.MoveNext() == true)
            {
                goto label_20;
            }
            
            val_29 = 0;
            val_30 = 92;
            val_33 = 1152921504620691456;
            if(val_3 != null)
            {
                    var val_29 = 0;
                val_29 = val_29 + 1;
                val_3.Dispose();
            }
            
            val_35 = this._slice;
            int val_12 = val_35.Count;
            this._sliceCount = val_12;
            this._sliceTotalMagnitude = 0f;
            if((val_12 - 1) >= 1)
            {
                    val_33 = 1152921518725068768;
                float val_30 = 0f;
                do
            {
                int val_14 = 0 + 1;
                UnityEngine.Vector3 val_15 = this._slice.Item[val_14];
                val_30 = this._slice;
                val_25 = val_15.x;
                val_26 = val_15.z;
                UnityEngine.Vector3 val_16 = val_30.Item[0];
                val_36 = val_16.y;
                val_27 = val_26;
                UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_25, y = val_15.y, z = val_27}, b:  new UnityEngine.Vector3() {x = val_16.x, y = val_36, z = val_16.z});
                val_35 = this._sliceCount;
                val_30 = val_30 + val_17.x;
                this._sliceTotalMagnitude = val_30;
            }
            while(val_14 < (val_35 - 1));
            
            }
            
            UnityEngine.Vector2[] val_19 = new UnityEngine.Vector2[0];
            UnityEngine.Vector2 val_20;
            this._sliceUvs = val_19;
            val_20 = new UnityEngine.Vector2(x:  0f, y:  0f);
            val_37 = val_20.x;
            val_19[0] = val_37;
            val_19[0] = val_20.y;
            int val_31 = this._sliceCount;
            val_31 = val_31 - 1;
            if(val_31 < 1)
            {
                    return;
            }
            
            val_33 = 1152921518725068768;
            do
            {
                int val_21 = 0 + 1;
                UnityEngine.Vector3 val_22 = this._slice.Item[val_21];
                val_25 = val_22.x;
                val_26 = val_22.z;
                val_37 = val_21 - 1;
                UnityEngine.Vector3 val_23 = this._slice.Item[val_37];
                val_36 = val_23.y;
                UnityEngine.Vector3 val_24 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_25, y = val_22.y, z = val_26}, b:  new UnityEngine.Vector3() {x = val_23.x, y = val_36, z = val_23.z});
                float val_33 = this._sliceTotalMagnitude;
                UnityEngine.Vector2 val_25;
                val_24.x = val_24.x / val_33;
                val_33 = this._sliceUvs[0] + val_24.x;
                val_25 = new UnityEngine.Vector2(x:  0f, y:  val_33);
                this._sliceUvs[(long)val_21] = val_25.x;
                this._sliceUvs[(long)val_21] = val_25.y;
                int val_34 = this._sliceCount;
                val_34 = val_34 - 1;
            }
            while((val_37 + 1) < val_34);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void Run(Mapbox.Unity.MeshGeneration.Data.VectorFeatureUnity feature, Mapbox.Unity.MeshGeneration.Data.MeshData md, Mapbox.Unity.MeshGeneration.Data.UnityTile tile)
        {
            var val_5;
            System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Vector3>> val_113;
            var val_114;
            var val_115;
            var val_116;
            var val_117;
            System.Collections.Generic.List<System.Collections.Generic.List<System.Int32>> val_118;
            float val_119;
            float val_120;
            float val_121;
            float val_122;
            var val_123;
            int val_124;
            var val_125;
            var val_126;
            System.Collections.Generic.List<System.Single> val_127;
            System.Collections.Generic.List<System.Int32> val_128;
            System.Func<System.Int32, System.Int32> val_129;
            var val_130;
            var val_131;
            System.Collections.Generic.List<T> val_132;
            val_113 = feature;
            val_114 = this;
            .md = md;
            if(feature.Points.Count < 1)
            {
                    return;
            }
            
            val_113 = feature.Points;
            List.Enumerator<T> val_3 = val_113.GetEnumerator();
            val_115 = 1152921519706114784;
            val_116 = 1152921519706115808;
            val_117 = 1152921504689860608;
            goto label_150;
            label_181:
            val_118 = val_5.emailUIDataHandler;
            val_113 = val_118.Count;
            this._counter = val_113;
            if(val_113 < 2)
            {
                goto label_150;
            }
            
            System.Collections.Generic.List<UnityEngine.Vector3> val_9 = new System.Collections.Generic.List<UnityEngine.Vector3>(capacity:  this._sliceCount * val_113);
            System.Collections.Generic.List<UnityEngine.Vector3> val_10 = new System.Collections.Generic.List<UnityEngine.Vector3>(capacity:  this._counter);
            if(this._counter < 1)
            {
                goto label_9;
            }
            
            label_47:
            UnityEngine.Vector3 val_11 = val_118.Item[0];
            if(this._counter < 1)
            {
                goto label_13;
            }
            
            int val_112 = this._counter;
            val_112 = val_112 - 1;
            if(0 >= val_112)
            {
                goto label_14;
            }
            
            UnityEngine.Vector3 val_12 = val_118.Item[0];
            UnityEngine.Vector3 val_13 = val_118.Item[-1];
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, b:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z});
            val_119 = val_14.x;
            UnityEngine.Vector3 val_15 = val_118.Item[1];
            UnityEngine.Vector3 val_16 = val_118.Item[0];
            UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, b:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z});
            UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z}, b:  new UnityEngine.Vector3() {x = val_119, y = val_14.y, z = val_14.z});
            val_120 = val_18.x;
            val_121 = val_18.z;
            goto label_27;
            label_13:
            if(0 == 0)
            {
                goto label_22;
            }
            
            label_14:
            UnityEngine.Vector3 val_19 = val_118.Item[0];
            UnityEngine.Vector3 val_20 = val_118.Item[-1];
            val_119 = val_20.x;
            UnityEngine.Vector3 val_21 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z}, b:  new UnityEngine.Vector3() {x = val_119, y = val_20.y, z = val_20.z});
            val_120 = val_21.x;
            val_121 = val_21.z;
            goto label_27;
            label_22:
            UnityEngine.Vector3 val_22 = val_118.Item[1];
            UnityEngine.Vector3 val_23 = val_118.Item[0];
            val_119 = val_23.x;
            UnityEngine.Vector3 val_24 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z}, b:  new UnityEngine.Vector3() {x = val_119, y = val_23.y, z = val_23.z});
            val_120 = val_24.x;
            val_121 = val_24.z;
            label_27:
            UnityEngine.Quaternion val_25 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = val_120, y = val_24.y, z = val_121});
            val_122 = val_25.z;
            int val_26 = this._slice.Count;
            if(this._counter >= 1)
            {
                    do
            {
                UnityEngine.Vector3 val_28 = this._slice.Item[0];
                UnityEngine.Vector3 val_29 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_25.x, y = val_25.y, z = val_122, w = val_25.w}, point:  new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z});
                val_120 = val_29.x;
                val_121 = val_29.z;
                UnityEngine.Vector3 val_30 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_120, y = val_29.y, z = val_121}, b:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
                val_119 = val_30.y;
                null.Add(item:  new UnityEngine.Vector3() {x = val_30.x, y = val_119, z = val_30.z});
                if((val_26 - 1) == 0)
            {
                    UnityEngine.Vector3 val_31 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_120, y = val_29.y, z = val_121}, b:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
                val_120 = val_31.x;
                val_121 = val_31.z;
                val_10.Add(item:  new UnityEngine.Vector3() {x = val_120, y = val_31.y, z = val_121});
            }
            
            }
            while(1 < val_26);
            
            }
            
            val_115 = val_115;
            if(1 < this._counter)
            {
                goto label_47;
            }
            
            label_9:
            if(md.Triangles.Count == 0)
            {
                    System.Collections.Generic.List<System.Int32> val_33 = new System.Collections.Generic.List<System.Int32>();
                md.Triangles.Add(item:  null);
            }
            
            if(.md != null)
            {
                
            }
            else
            {
                    if(.md != null)
            {
                
            }
            
            }
            
            md.Vertices.Capacity = 65536.Count + ((null.Count - this._sliceCount) << 2);
            if(.md != null)
            {
                
            }
            else
            {
                    if(.md != null)
            {
                
            }
            
            }
            
            md.Normals.Capacity = 1.Count + ((null.Count - this._sliceCount) << 2);
            if(.md != null)
            {
                    val_118 = mem[md + 136];
                val_118 = md.Triangles;
                val_113 = 1152921518724785408;
            }
            else
            {
                    val_118 = mem[md + 136];
                val_118 = md.Triangles;
                val_113 = 1152921518724785408;
                if(.md != null)
            {
                
            }
            
            }
            
            val_123 = 62656512.Count;
            val_118.Capacity = val_123 + ((null.Count - this._sliceCount) * 6);
            val_124 = this._counter;
            val_125 = 1152921518724785408;
            val_117 = 1152921504689860608;
            if((val_124 - 1) >= 1)
            {
                    float val_115 = 0f;
                val_126 = 1;
                val_121 = 0f;
                do
            {
                if((this._sliceCount - 1) >= 1)
            {
                    do
            {
                UnityEngine.Vector3 val_49 = null.Item[0 + (val_126 * this._sliceCount)];
                int val_50 = 0 + (0 * this._sliceCount);
                UnityEngine.Vector3 val_51 = null.Item[val_50];
                UnityEngine.Vector3 val_52 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_49.x, y = val_49.y, z = val_49.z}, b:  new UnityEngine.Vector3() {x = val_51.x, y = val_51.y, z = val_51.z});
                val_121 = val_52.x;
                int val_53 = md.Vertices.Count;
                UnityEngine.Vector3 val_54 = null.Item[val_50];
                int val_55 = val_50 + 1;
                UnityEngine.Vector3 val_56 = null.Item[val_55];
                UnityEngine.Vector3 val_57 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_54.x, y = val_54.y, z = val_54.z}, b:  new UnityEngine.Vector3() {x = val_56.x, y = val_56.y, z = val_56.z});
                UnityEngine.Vector3 val_60 = null.Item[0 + (this._sliceCount + (0 * this._sliceCount))];
                UnityEngine.Vector3 val_61 = null.Item[val_50];
                UnityEngine.Vector3 val_62 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_60.x, y = val_60.y, z = val_60.z}, b:  new UnityEngine.Vector3() {x = val_61.x, y = val_61.y, z = val_61.z});
                UnityEngine.Vector3 val_63 = UnityEngine.Vector3.Cross(lhs:  new UnityEngine.Vector3() {x = val_57.x, y = val_57.y, z = val_57.z}, rhs:  new UnityEngine.Vector3() {x = val_62.x, y = val_62.y, z = val_62.z});
                val_119 = val_63.y;
                UnityEngine.Vector3 val_64 = null.Item[val_50];
                md.Vertices.Add(item:  new UnityEngine.Vector3() {x = val_64.x, y = val_64.y, z = val_64.z});
                UnityEngine.Vector3 val_65 = null.Item[val_55];
                md.Vertices.Add(item:  new UnityEngine.Vector3() {x = val_65.x, y = val_65.y, z = val_65.z});
                UnityEngine.Vector3 val_68 = null.Item[0 + (this._sliceCount + (0 * this._sliceCount))];
                md.Vertices.Add(item:  new UnityEngine.Vector3() {x = val_68.x, y = val_68.y, z = val_68.z});
                int val_69 = this._sliceCount + (0 * this._sliceCount);
                val_69 = 0 + val_69;
                UnityEngine.Vector3 val_71 = null.Item[val_69 + 1];
                md.Vertices.Add(item:  new UnityEngine.Vector3() {x = val_71.x, y = val_71.y, z = val_71.z});
                float val_113 = -1f;
                float val_114 = 0f;
                float val_73 = val_114 + val_113;
                val_113 = val_73 / (float)this._sliceCount;
                UnityEngine.Vector2 val_74 = new UnityEngine.Vector2(x:  val_115, y:  val_113);
                md.UV.Item[0].Add(item:  new UnityEngine.Vector2() {x = val_74.x, y = val_74.y});
                val_114 = val_114 / (float)this._sliceCount;
                UnityEngine.Vector2 val_76 = new UnityEngine.Vector2(x:  val_115, y:  val_114);
                md.UV.Item[0].Add(item:  new UnityEngine.Vector2() {x = val_76.x, y = val_76.y});
                float val_78 = val_115 + val_121;
                UnityEngine.Vector2 val_80 = new UnityEngine.Vector2(x:  val_78, y:  val_73 / (float)this._sliceCount);
                md.UV.Item[0].Add(item:  new UnityEngine.Vector2() {x = val_80.x, y = val_80.y});
                UnityEngine.Vector2 val_82 = new UnityEngine.Vector2(x:  val_78, y:  val_114);
                md.UV.Item[0].Add(item:  new UnityEngine.Vector2() {x = val_82.x, y = val_82.y});
                val_5 = 0;
                md.Tangents.Add(item:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
                md.Tangents.Add(item:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
                md.Tangents.Add(item:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
                val_120 = 0f;
                val_122 = 0f;
                md.Tangents.Add(item:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
                md.Normals.Add(item:  new UnityEngine.Vector3() {x = val_63.x, y = val_119, z = val_63.z});
                md.Normals.Add(item:  new UnityEngine.Vector3() {x = val_63.x, y = val_119, z = val_63.z});
                md.Normals.Add(item:  new UnityEngine.Vector3() {x = val_63.x, y = val_119, z = val_63.z});
                md.Normals.Add(item:  new UnityEngine.Vector3() {x = val_63.x, y = val_119, z = val_63.z});
                md.Triangles.Item[0].Add(item:  val_53);
                int val_85 = val_53 + 2;
                md.Triangles.Item[0].Add(item:  val_85);
                int val_87 = val_53 + 1;
                md.Triangles.Item[0].Add(item:  val_87);
                md.Triangles.Item[0].Add(item:  val_87);
                val_125 = 1152921518724785408;
                md.Triangles.Item[0].Add(item:  val_85);
                val_117 = 1152921504689860608;
                val_123 = md.Triangles.Item[0];
                val_123.Add(item:  val_53 + 3);
                val_126 = val_126;
            }
            while(1 < (this._sliceCount - 1));
            
                val_124 = this._counter;
            }
            
                val_113 = 0 + 1;
                val_115 = val_115 + val_121;
                val_118 = val_126 + 1;
            }
            while(val_113 < (val_124 - 1));
            
            }
            
            val_116 = 1152921519706115808;
            if((this._closeEdges == false) || (val_10.Count < 3))
            {
                goto label_150;
            }
            
            if(md.Triangles.Count <= 1)
            {
                    System.Collections.Generic.List<System.Int32> val_96 = new System.Collections.Generic.List<System.Int32>();
                md.Triangles.Add(item:  null);
            }
            
            System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Vector3>> val_97 = new System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Vector3>>();
            null.Add(item:  val_10);
            if((Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.EarcutLibrary.Flatten(data:  null)) != null)
            {
                    val_127 = val_98.Vertices;
                val_128 = val_98.Holes;
            }
            else
            {
                    val_127 = 11993091;
                val_128 = 15026800;
            }
            
            val_118 = md.Triangles.Item[1];
            val_129 = mem[1152921519707264408];
            if(val_129 == 0)
            {
                    val_129 = null;
                val_129 = new System.Func<System.Int32, System.Int32>(object:  new LoftModifier.<>c__DisplayClass10_0(), method:  System.Int32 LoftModifier.<>c__DisplayClass10_0::<Run>b__0(int x));
                mem[1152921519707264408] = val_129;
            }
            
            val_118.AddRange(collection:  System.Linq.Enumerable.ToList<System.Int32>(source:  System.Linq.Enumerable.Select<System.Int32, System.Int32>(source:  Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.EarcutLibrary.Earcut(data:  val_127, holeIndices:  val_128, dim:  val_98.Dim), selector:  null)));
            val_130 = 0;
            goto label_164;
            label_180:
            UnityEngine.Vector3 val_104 = val_10.Item[0];
            md.Vertices.Add(item:  new UnityEngine.Vector3() {x = val_104.x, y = val_104.y, z = val_104.z});
            val_131 = null;
            val_131 = null;
            md.Normals.Add(item:  new UnityEngine.Vector3() {x = Constants.Math.Vector3Up, y = Constants.Math.Vector3Zero.__il2cppRuntimeField_10, z = Constants.Math.Vector3Zero.__il2cppRuntimeField_14});
            UnityEngine.Vector3 val_106 = val_10.Item[0];
            val_120 = val_106.x;
            UnityEngine.Vector3 val_107 = val_10.Item[0];
            UnityEngine.Vector2 val_108 = new UnityEngine.Vector2(x:  val_120, y:  val_107.z);
            md.UV.Item[0].Add(item:  new UnityEngine.Vector2() {x = val_108.x, y = val_108.y});
            val_118 = mem[md + 128];
            val_118 = md.Tangents;
            val_5 = 0;
            val_118.Add(item:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
            val_130 = 1;
            label_164:
            val_132 = val_10;
            if(val_132 == 0)
            {
                    val_132 = val_10;
            }
            
            if(val_130 < val_10.Count)
            {
                goto label_180;
            }
            
            label_150:
            if(((-2079508256) & 1) != 0)
            {
                goto label_181;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LoftModifier()
        {
            mem[1152921519707471384] = 1;
            val_1 = new UnityEngine.ScriptableObject();
        }
    
    }

}
