using UnityEngine;

namespace Mapbox.Unity.MeshGeneration.Modifiers
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class HeightModifier : MeshModifier
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _scale;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.Map.GeometryExtrusionOptions _options;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _separateSubmesh;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _counter;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float height;
        
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
        public override void SetProperties(Mapbox.Unity.MeshGeneration.Modifiers.ModifierProperties properties)
        {
            Mapbox.Unity.MeshGeneration.Modifiers.ModifierProperties val_3 = properties;
            if(val_3 != null)
            {
                    val_3 = 0;
            }
            
            this._options = val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void Run(Mapbox.Unity.MeshGeneration.Data.VectorFeatureUnity feature, Mapbox.Unity.MeshGeneration.Data.MeshData md, float scale)
        {
            this._scale = scale;
            goto typeof(Mapbox.Unity.MeshGeneration.Modifiers.HeightModifier).__il2cppRuntimeField_1B8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void Run(Mapbox.Unity.MeshGeneration.Data.VectorFeatureUnity feature, Mapbox.Unity.MeshGeneration.Data.MeshData md, Mapbox.Unity.MeshGeneration.Data.UnityTile tile)
        {
            UnityEngine.Object val_5;
            float val_6;
            float val_7;
            val_5 = tile;
            this._counter = 0;
            if(feature == null)
            {
                    return;
            }
            
            if(md.Vertices.Count == 0)
            {
                    return;
            }
            
            if(feature.Points.Count < 1)
            {
                    return;
            }
            
            if(val_5 != 0)
            {
                    this._scale = val_5.TileScale;
            }
            
            val_5 = this._options;
            if(this._options == null)
            {
                    val_5 = this._options;
            }
            
            float val_5 = this._options.extrusionScaleFactor;
            val_6 = this._scale;
            val_5 = 1f * val_5;
            val_7 = val_5 * val_6;
            if(val_5 == null)
            {
                    val_6 = this._scale;
                val_7 = val_7;
            }
            
            float val_6 = this._options.extrusionScaleFactor;
            val_6 = 0f * val_6;
            val_6 = val_6 * val_6;
            val_6 = val_7 - val_6;
            this.height = val_6;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void GenerateWallMesh(Mapbox.Unity.MeshGeneration.Data.MeshData md)
        {
            var val_49;
            var val_50;
            int val_51;
            int val_52;
            Mapbox.Unity.Map.GeometryExtrusionOptions val_53;
            float val_54;
            var val_55;
            float val_56;
            float val_57;
            var val_58;
            var val_59;
            val_49 = md;
            if(val_49 != null)
            {
                    val_50 = val_49;
                val_51 = this._counter;
            }
            else
            {
                    val_50 = 112;
                val_51 = this._counter;
            }
            
            val_52 = 1152921519704465856;
            65536.Capacity = val_51 + (md.Edges.Count << 1);
            val_53 = this._options;
            if(this._options.extrusionGeometryType == 1)
            {
                    return;
            }
            
            int val_3 = md.Edges.Count;
            this._counter = val_3;
            System.Collections.Generic.List<System.Int32> val_5 = new System.Collections.Generic.List<System.Int32>(capacity:  val_3 + (val_3 << 1));
            System.Collections.Generic.List<UnityEngine.Vector2> val_7 = null;
            val_53 = val_7;
            val_7 = new System.Collections.Generic.List<UnityEngine.Vector2>(capacity:  this._counter << 1);
            if(65536 != 0)
            {
                    int val_8 = 65536.Count;
            }
            
            65536.Capacity = 65536.Count + (this._counter << 1);
            val_51 = md.Normals;
            if(val_51 != null)
            {
                    int val_11 = val_51.Count;
            }
            
            val_51.Capacity = val_51.Count + (this._counter << 1);
            if(this._counter >= 1)
            {
                    do
            {
                UnityEngine.Vector3 val_15 = 65536.Item[md.Edges.Item[0]];
                int val_16 = 0 + 1;
                UnityEngine.Vector3 val_18 = 65536.Item[md.Edges.Item[val_16]];
                int val_19 = val_50.Count;
                65536.Add(item:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
                65536.Add(item:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z});
                float val_20 = val_15.y - this.height;
                65536.Add(item:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                float val_21 = val_18.y - this.height;
                65536.Add(item:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                float val_22 = val_18.x - val_15.x;
                val_22 = val_22 + (val_18.y - val_15.y);
                float val_24 = val_18.z - val_15.z;
                val_22 = val_24 + val_22;
                if(val_24 >= _TYPE_MAX_)
            {
                    val_54 = val_22;
            }
            
                UnityEngine.Vector3 val_25 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z}, b:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
                val_52 = val_19 + 2;
                UnityEngine.Vector3 val_26 = 65536.Item[val_52];
                UnityEngine.Vector3 val_27 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z}, b:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
                UnityEngine.Vector3 val_28 = UnityEngine.Vector3.Cross(lhs:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z}, rhs:  new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z});
                UnityEngine.Vector3 val_29 = UnityEngine.Vector3.Normalize(value:  new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z});
                md.Normals.Add(item:  new UnityEngine.Vector3() {x = val_29.x, y = val_29.y, z = val_29.z});
                md.Normals.Add(item:  new UnityEngine.Vector3() {x = val_29.x, y = val_29.y, z = val_29.z});
                md.Normals.Add(item:  new UnityEngine.Vector3() {x = val_29.x, y = val_29.y, z = val_29.z});
                md.Normals.Add(item:  new UnityEngine.Vector3() {x = val_29.x, y = val_29.y, z = val_29.z});
                UnityEngine.Vector3 val_30 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z}, b:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
                UnityEngine.Vector4 val_31 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector3() {x = val_30.x, y = val_30.y, z = val_30.z});
                md.Tangents.Add(item:  new UnityEngine.Vector4() {x = val_31.x, y = val_31.y, z = val_31.z, w = val_31.w});
                UnityEngine.Vector4 val_32 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector3() {x = val_30.x, y = val_30.y, z = val_30.z});
                md.Tangents.Add(item:  new UnityEngine.Vector4() {x = val_32.x, y = val_32.y, z = val_32.z, w = val_32.w});
                UnityEngine.Vector4 val_33 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector3() {x = val_30.x, y = val_30.y, z = val_30.z});
                md.Tangents.Add(item:  new UnityEngine.Vector4() {x = val_33.x, y = val_33.y, z = val_33.z, w = val_33.w});
                UnityEngine.Vector4 val_34 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector3() {x = val_30.x, y = val_30.y, z = val_30.z});
                md.Tangents.Add(item:  new UnityEngine.Vector4() {x = val_34.x, y = val_34.y, z = val_34.z, w = val_34.w});
                UnityEngine.Vector2 val_35 = new UnityEngine.Vector2(x:  0f, y:  0f);
                if(val_53 != null)
            {
                    val_55 = 1152921517377849056;
                val_7.Add(item:  new UnityEngine.Vector2() {x = val_35.x, y = val_35.y});
                val_56 = val_54;
                val_57 = 0f;
                UnityEngine.Vector2 val_36 = new UnityEngine.Vector2(x:  val_56, y:  val_57);
            }
            else
            {
                    val_55 = 1152921517377849056;
                val_7.Add(item:  new UnityEngine.Vector2() {x = val_35.x, y = val_35.y});
                val_56 = val_54;
                val_57 = 0f;
                UnityEngine.Vector2 val_37 = new UnityEngine.Vector2(x:  val_56, y:  val_57);
            }
            
                val_7.Add(item:  new UnityEngine.Vector2() {x = val_37.x, y = val_37.y});
                UnityEngine.Vector2 val_38 = new UnityEngine.Vector2(x:  0f, y:  -this.height);
                if(val_53 != null)
            {
                    val_58 = 0;
            }
            else
            {
                    val_58 = 1;
            }
            
                val_7.Add(item:  new UnityEngine.Vector2() {x = val_38.x, y = val_38.y});
                UnityEngine.Vector2 val_39 = new UnityEngine.Vector2(x:  val_56, y:  -this.height);
                val_7.Add(item:  new UnityEngine.Vector2() {x = val_39.x, y = val_39.y});
                if(val_5 != null)
            {
                    val_59 = 1152921517654936784;
                val_5.Add(item:  val_19);
                int val_40 = val_19 + 1;
                val_5.Add(item:  val_40);
                val_5.Add(item:  val_52);
                val_5.Add(item:  val_40);
                val_5.Add(item:  val_19 + 3);
            }
            else
            {
                    val_59 = 1152921517654936784;
                val_5.Add(item:  val_19);
                int val_42 = val_19 + 1;
                val_5.Add(item:  val_42);
                val_5.Add(item:  val_52);
                val_5.Add(item:  val_42);
                val_5.Add(item:  val_19 + 3);
            }
            
                val_5.Add(item:  val_52);
                val_51 = val_16 + 1;
            }
            while(val_51 < val_51);
            
            }
            
            if(this._separateSubmesh != false)
            {
                    md.Triangles.Add(item:  val_5);
            }
            else
            {
                    val_51 = md.Triangles.Count;
                md.Triangles.Capacity = val_5.Count + val_51;
                md.Triangles.Item[0].AddRange(collection:  val_5);
            }
            
            val_49 = md.UV.Item[0];
            val_49.AddRange(collection:  val_7);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void GenerateRoofMesh(Mapbox.Unity.MeshGeneration.Data.MeshData md, float minHeight, float maxHeight)
        {
            if(this._options.extrusionGeometryType == 2)
            {
                    return;
            }
            
            this._counter = md.Vertices.Count;
            Mapbox.Unity.Map.ExtrusionType val_22 = this._options.extrusionType;
            val_22 = val_22 - 1;
            if(val_22 > 4)
            {
                    return;
            }
            
            var val_23 = 52956612 + ((this._options.extrusionType - 1)) << 2;
            val_23 = val_23 + 52956612;
            goto (52956612 + ((this._options.extrusionType - 1)) << 2 + 52956612);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void QueryHeight(Mapbox.Unity.MeshGeneration.Data.VectorFeatureUnity feature, Mapbox.Unity.MeshGeneration.Data.MeshData md, Mapbox.Unity.MeshGeneration.Data.UnityTile tile, out float maxHeight, out float minHeight)
        {
            object val_18;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_19;
            Mapbox.Unity.Map.GeometryExtrusionOptions val_20;
            var val_21;
            string val_22;
            Mapbox.Unity.Map.GeometryExtrusionOptions val_23;
            Mapbox.Unity.Map.GeometryExtrusionOptions val_24;
            Mapbox.Unity.Map.GeometryExtrusionOptions val_25;
            float val_26;
            var val_27;
            var val_28;
            val_18 = feature;
            val_19 = this;
            minHeight = 0f;
            maxHeight = 0f;
            val_20 = this._options;
            if((this._options.extrusionType - 1) >= 3)
            {
                goto label_2;
            }
            
            val_20 = feature.Properties;
            val_21 = 1152921515845838592;
            if((val_20.ContainsKey(key:  this._options.propertyName)) == false)
            {
                    return;
            }
            
            val_20 = feature.Properties.Item[this._options.propertyName];
            maxHeight = System.Convert.ToSingle(value:  val_20);
            val_19 = feature.Properties;
            if((val_19.ContainsKey(key:  "min_height")) == false)
            {
                    return;
            }
            
            val_19 = feature.Properties.Item["min_height"];
            float val_7 = System.Convert.ToSingle(value:  val_19);
            goto label_16;
            label_2:
            if(this._options.extrusionType != 4)
            {
                    if(this._options.extrusionType != 5)
            {
                    return;
            }
            
                val_19 = this._options;
                maxHeight = this._options.maximumHeight;
                return;
            }
            
            val_20 = feature.Properties;
            val_21 = 1152921515845838592;
            val_22 = this._options.propertyName;
            if((val_20.ContainsKey(key:  val_22)) == false)
            {
                    return;
            }
            
            val_23 = this._options;
            val_24 = val_23;
            if(val_23 == null)
            {
                    val_24 = this._options;
                if(val_24 == null)
            {
                goto label_51;
            }
            
            }
            
            if(this._options.minimumHeight <= this._options.maximumHeight)
            {
                goto label_27;
            }
            
            val_22 = 0;
            UnityEngine.Debug.LogError(message:  "Maximum Height less than Minimum Height.Swapping values for extrusion.");
            val_23 = this._options;
            val_25 = val_23;
            if(val_23 != null)
            {
                goto label_30;
            }
            
            val_25 = this._options;
            if(val_25 == null)
            {
                goto label_51;
            }
            
            label_30:
            this._options.minimumHeight = this._options.maximumHeight;
            this._options.maximumHeight = this._options.minimumHeight;
            label_27:
            val_20 = 1152921504621436928;
            val_26 = System.Math.Max(val1:  this._options.minimumHeight, val2:  System.Convert.ToSingle(value:  feature.Properties.Item[this._options.propertyName]));
            maxHeight = System.Math.Min(val1:  val_26, val2:  this._options.maximumHeight);
            if((feature.Properties.ContainsKey(key:  "min_height")) == false)
            {
                    return;
            }
            
            val_18 = feature.Properties.Item["min_height"];
            val_19 = this._options;
            val_26 = System.Convert.ToSingle(value:  val_18);
            label_16:
            minHeight = System.Math.Min(val1:  val_26, val2:  this._options.maximumHeight);
            return;
            label_51:
            val_27 = 0;
            if(val_22 == 1)
            {
                    if((null & 1) == 0)
            {
                    val_28 = 8;
                mem[8] = 1179403647;
            }
            else
            {
                    UnityEngine.Debug.LogError(message:  "Property: \'"("Property: \'") + this._options.propertyName + "\' must contain a numerical value for extrusion.");
                return;
            }
            
                val_27 = ;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public HeightModifier()
        {
            this._scale = 1f;
            this._separateSubmesh = true;
            mem[1152921519705520440] = true;
            val_1 = new UnityEngine.ScriptableObject();
        }
    
    }

}
