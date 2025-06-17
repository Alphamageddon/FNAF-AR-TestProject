using UnityEngine;

namespace Mapbox.Unity.MeshGeneration.Modifiers
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PolygonMeshModifier : MeshGenerationBase
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _counter;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _secondCounter;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 _v1;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 _v2;
        
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
        public bool IsClockwise(System.Collections.Generic.IList<UnityEngine.Vector3> vertices)
        {
            var val_8;
            var val_9;
            var val_12;
            var val_14;
            var val_11 = 0;
            val_11 = val_11 + 1;
            val_9 = 0;
            int val_2 = vertices.Count;
            this._counter = val_2;
            if(val_2 >= 1)
            {
                    double val_15 = 0;
                do
            {
                var val_12 = 0;
                val_12 = val_12 + 1;
                val_9 = 0;
                val_12 = public T System.Collections.Generic.IList<T>::get_Item(int index);
                T val_4 = vertices.Item[0];
                int val_13 = this._counter;
                this._v1 = new UnityEngine.Vector3();
                mem[1152921519707939940] = ???;
                mem[1152921519707939944] = ???;
                val_8 = 0 + 1;
                val_13 = val_8 - ((val_8 / val_13) * val_13);
                var val_14 = 0;
                val_14 = val_14 + 1;
                val_12 = 0;
                T val_7 = vertices.Item[val_13];
                this._v2 = new UnityEngine.Vector3();
                mem[1152921519707939952] = ???;
                mem[1152921519707939956] = ???;
                float val_8 = S0 - this._v1;
                val_8 = val_8 * (S2 + S3);
                val_15 = val_15 + (double)val_8;
            }
            while(val_8 < this._counter);
            
                var val_10 = (val_15 > 0f) ? 1 : 0;
                return (bool)val_14;
            }
            
            val_14 = 0;
            return (bool)val_14;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void Run(Mapbox.Unity.MeshGeneration.Data.VectorFeatureUnity feature, Mapbox.Unity.MeshGeneration.Data.MeshData md, Mapbox.Unity.MeshGeneration.Data.UnityTile tile)
        {
            var val_7;
            System.Collections.Generic.List<System.Collections.Generic.List<System.Int32>> val_51;
            Mapbox.Unity.MeshGeneration.Data.VectorFeatureUnity val_52;
            int val_53;
            var val_54;
            System.Collections.Generic.List<T> val_56;
            var val_57;
            System.Collections.Generic.List<System.Single> val_58;
            System.Collections.Generic.List<System.Int32> val_59;
            System.Collections.Generic.List<T> val_60;
            System.Collections.Generic.List<T> val_61;
            var val_62;
            var val_63;
            var val_64;
            System.Collections.Generic.List<T> val_65;
            System.Collections.Generic.List<System.Single> val_66;
            System.Collections.Generic.List<System.Int32> val_67;
            System.Collections.Generic.List<T> val_68;
            val_51 = md;
            val_52 = feature;
            if((this.Criteria == null) || (this.Criteria.Count < 1))
            {
                goto label_17;
            }
            
            HashSet.Enumerator<T> val_5 = this.Criteria.GetEnumerator();
            val_53 = 1152921519708059680;
            val_54 = 1152921505108230144;
            label_11:
            if(((-2078524816) & 1) == 0)
            {
                goto label_5;
            }
            
            var val_51 = 0;
            val_51 = val_51 + 1;
            if((val_7.emailUIDataHandler.ShouldReplaceFeature(feature:  val_52)) == false)
            {
                goto label_11;
            }
            
            long val_11 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519708191344});
            return;
            label_5:
            long val_12 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519708191344});
            if(val_52 != null)
            {
                goto label_18;
            }
            
            goto label_14;
            label_17:
            if(val_52 != null)
            {
                goto label_18;
            }
            
            label_14:
            label_18:
            int val_14 = feature.Points.Count;
            mem[1152921519708203548] = val_14;
            System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Vector3>> val_15 = null;
            val_56 = val_15;
            val_15 = new System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Vector3>>(capacity:  val_14);
            if(mem[1152921519708203548] < 1)
            {
                goto label_20;
            }
            
            val_57 = 1152921517654936784;
            label_60:
            System.Collections.Generic.List<UnityEngine.Vector3> val_16 = feature.Points.Item[0];
            int val_17 = md.Vertices.Count;
            if((val_17 >= 1) && ((this.IsClockwise(vertices:  val_16)) != false))
            {
                    if((Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.EarcutLibrary.Flatten(data:  val_15)) != null)
            {
                    val_58 = val_19.Vertices;
                val_59 = val_19.Holes;
            }
            else
            {
                    val_58 = 11993091;
                val_59 = 15026800;
            }
            
                System.Collections.Generic.List<System.Int32> val_20 = Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.EarcutLibrary.Earcut(data:  val_58, holeIndices:  val_59, dim:  val_19.Dim);
                int val_21 = val_20.Count;
                if(0 != 0)
            {
                    0.Capacity = 0.Count + val_21;
            }
            else
            {
                    System.Collections.Generic.List<System.Int32> val_24 = new System.Collections.Generic.List<System.Int32>(capacity:  val_21);
            }
            
                if(val_21 >= 1)
            {
                    var val_52 = 0;
                do
            {
                val_60 = val_24;
                if(val_60 == 0)
            {
                    val_60 = val_24;
            }
            
                val_24.Add(item:  val_20.Item[0] + 0);
                val_52 = val_52 + 1;
            }
            while(val_21 != val_52);
            
            }
            
                val_61 = val_56;
                val_15.Clear();
            }
            
            val_15.Add(item:  val_16);
            int val_27 = val_16.Count;
            if(val_51 == null)
            {
                goto label_39;
            }
            
            if(md.Vertices != null)
            {
                goto label_44;
            }
            
            label_45:
            label_44:
            md.Vertices.Capacity = md.Vertices.Count + val_27;
            if(md.Normals == null)
            {
                goto label_42;
            }
            
            val_62 = md.Normals.Count;
            goto label_43;
            label_39:
            if(md.Vertices != null)
            {
                goto label_44;
            }
            
            goto label_45;
            label_42:
            val_62 = md.Normals.Count;
            label_43:
            md.Normals.Capacity = val_62 + val_27;
            if(md.Edges != null)
            {
                    val_63 = md.Edges.Count;
            }
            else
            {
                    val_63 = md.Edges.Count;
            }
            
            md.Edges.Capacity = val_63 + (val_27 << 1);
            if(val_27 >= 1)
            {
                    do
            {
                md.Edges.Add(item:  ((((-val_27) + 0) == 1) ? 0 : (0 + 1)) + val_17);
                md.Edges.Add(item:  val_17 + 0);
                UnityEngine.Vector3 val_40 = val_16.Item[0];
                md.Vertices.Add(item:  new UnityEngine.Vector3() {x = val_40.x, y = val_40.y, z = val_40.z});
                val_64 = null;
                val_64 = null;
                UnityEngine.Vector4 val_41 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector3() {x = Constants.Math.Vector3Forward, y = Constants.Math.Vector3Zero.__il2cppRuntimeField_34, z = Constants.Math.Vector3Zero.__il2cppRuntimeField_38});
                val_63 = 0 + 1;
                md.Tangents.Add(item:  new UnityEngine.Vector4() {x = val_41.x, y = val_41.y, z = val_41.z, w = val_41.w});
                md.Normals.Add(item:  new UnityEngine.Vector3() {x = Constants.Math.Vector3Up, y = Constants.Math.Vector3Zero.__il2cppRuntimeField_10, z = Constants.Math.Vector3Zero.__il2cppRuntimeField_14});
            }
            while(((-val_27) + val_63) != 0);
            
            }
            
            val_52 = val_52;
            val_65 = val_56;
            if(1 < mem[1152921519708203548])
            {
                goto label_60;
            }
            
            goto label_61;
            label_20:
            label_61:
            if((Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.EarcutLibrary.Flatten(data:  val_15)) != null)
            {
                    val_66 = val_43.Vertices;
                val_67 = val_43.Holes;
            }
            else
            {
                    val_66 = 11993091;
                val_67 = 15026800;
            }
            
            System.Collections.Generic.List<System.Int32> val_44 = Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers.EarcutLibrary.Earcut(data:  val_66, holeIndices:  val_67, dim:  val_43.Dim);
            val_53 = val_44.Count;
            if(0 != 0)
            {
                    0.Capacity = 0.Count + val_53;
            }
            else
            {
                    System.Collections.Generic.List<System.Int32> val_48 = new System.Collections.Generic.List<System.Int32>(capacity:  val_53);
            }
            
            if(val_53 >= 1)
            {
                    val_52 = 1152921517654936784;
                do
            {
                val_68 = val_48;
                if(val_68 == 0)
            {
                    val_68 = val_48;
            }
            
                val_48.Add(item:  val_44.Item[0] + 0);
                val_67 = 0 + 1;
            }
            while(val_53 != val_67);
            
            }
            
            val_51 = md.Triangles;
            val_51.Add(item:  val_48);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PolygonMeshModifier()
        {
        
        }
    
    }

}
