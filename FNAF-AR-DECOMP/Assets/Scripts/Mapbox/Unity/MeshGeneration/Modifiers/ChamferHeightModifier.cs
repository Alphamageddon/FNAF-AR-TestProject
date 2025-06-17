using UnityEngine;

namespace Mapbox.Unity.MeshGeneration.Modifiers
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ChamferHeightModifier : MeshModifier
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _flatTops;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _height;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _forceHeight;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _offset;
        
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
        public override void Run(Mapbox.Unity.MeshGeneration.Data.VectorFeatureUnity feature, Mapbox.Unity.MeshGeneration.Data.MeshData md, Mapbox.Unity.MeshGeneration.Data.UnityTile tile)
        {
            System.Collections.Generic.List<UnityEngine.Vector3> val_18;
            var val_20;
            val_18 = md.Vertices;
            if(feature == null)
            {
                    return;
            }
            
            if(val_18.Count == 0)
            {
                    return;
            }
            
            val_18 = feature.Points;
            if(val_18.Count < 1)
            {
                    return;
            }
            
            if(this._forceHeight != true)
            {
                    Mapbox.Unity.MeshGeneration.Modifiers.ChamferHeightModifier.GetHeightData(feature:  feature, scale:  tile.TileScale, minHeight: ref  float val_4 = -1.089537E-36f, hf: ref  float val_5 = -1.089537E-36f);
            }
            
            UnityEngine.Vector3 val_6 = md.Vertices.Item[0];
            UnityEngine.Vector3 val_7 = md.Vertices.Item[0];
            if(this._flatTops == false)
            {
                goto label_11;
            }
            
            Mapbox.Unity.MeshGeneration.Modifiers.ChamferHeightModifier.FlattenTops(meshData:  md, minHeight:  0f, hf: ref  float val_8 = -1.089537E-36f, max: ref  float val_9 = -1.089533E-36f, min: ref  float val_10 = -1.089533E-36f);
            goto label_12;
            label_11:
            val_20 = 0;
            goto label_13;
            label_19:
            UnityEngine.Vector3 val_11 = md.Vertices.Item[0];
            UnityEngine.Vector3 val_12 = md.Vertices.Item[0];
            UnityEngine.Vector3 val_13 = md.Vertices.Item[0];
            float val_15 = (val_12.y + 0f) + this._height;
            md.Vertices.set_Item(index:  0, value:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            val_20 = 1;
            label_13:
            val_18 = md.Vertices;
            if(val_20 < val_18.Count)
            {
                goto label_19;
            }
            
            label_12:
            this.Chamfer(feature:  feature, md:  md, tile:  tile);
            this.Sides(feature:  feature, meshData:  md, hf:  this._height, originalVertexCount:  md.Vertices.Count);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Sides(Mapbox.Unity.MeshGeneration.Data.VectorFeatureUnity feature, Mapbox.Unity.MeshGeneration.Data.MeshData meshData, float hf, int originalVertexCount)
        {
            int val_47;
            float val_48;
            float val_49;
            float val_50;
            var val_51;
            var val_52;
            float val_53;
            float val_54;
            int val_55;
            int val_44 = originalVertexCount;
            System.Collections.Generic.List<System.Int32> val_1 = new System.Collections.Generic.List<System.Int32>();
            System.Collections.Generic.List<UnityEngine.Vector2> val_2 = new System.Collections.Generic.List<UnityEngine.Vector2>();
            if(meshData == null)
            {
                goto label_3;
            }
            
            if(meshData.Vertices != null)
            {
                goto label_59;
            }
            
            label_60:
            label_59:
            val_44 = val_44 - 1;
            UnityEngine.Vector3 val_3 = meshData.Vertices.Item[val_44];
            UnityEngine.Vector3 val_4 = meshData + 112.Item[val_44];
            UnityEngine.Vector3 val_5 = meshData + 112.Item[val_44];
            float val_6 = val_4.y - hf;
            meshData.Vertices.Add(item:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            if(meshData == null)
            {
                goto label_10;
            }
            
            val_47 = meshData;
            if(meshData.Tangents != null)
            {
                goto label_61;
            }
            
            label_62:
            label_61:
            UnityEngine.Vector4 val_7 = meshData.Tangents.Item[val_44];
            val_48 = val_7.w;
            meshData.Tangents.Add(item:  new UnityEngine.Vector4() {x = val_7.x, y = val_7.y, z = val_7.z, w = val_48});
            UnityEngine.Vector2 val_8 = new UnityEngine.Vector2(x:  0f, y:  -hf);
            val_2.Add(item:  new UnityEngine.Vector2() {x = val_8.x, y = val_8.y});
            if(meshData == null)
            {
                goto label_14;
            }
            
            if(meshData.Normals != null)
            {
                goto label_63;
            }
            
            label_64:
            label_63:
            UnityEngine.Vector3 val_9 = meshData.Normals.Item[val_44];
            val_49 = val_9.x;
            val_50 = val_9.y;
            meshData.Normals.Add(item:  new UnityEngine.Vector3() {x = val_49, y = val_50, z = val_9.z});
            val_51 = 0;
            goto label_17;
            label_55:
            UnityEngine.Vector3 val_11 = meshData + 112.Item[meshData.Edges.Item[0]];
            int val_46 = 1;
            UnityEngine.Vector3 val_13 = meshData + 112.Item[meshData.Edges.Item[1]];
            val_48 = val_13.z;
            int val_14 = meshData + 112.Count;
            meshData + 112.Add(item:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
            meshData + 112.Add(item:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_48});
            float val_45 = val_11.y;
            val_45 = val_45 - hf;
            meshData + 112.Add(item:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            float val_15 = val_13.y - hf;
            meshData + 112.Add(item:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            val_46 = val_46 - 1;
            UnityEngine.Vector3 val_17 = meshData + 120.Item[meshData.Edges.Item[val_46]];
            meshData + 120.Add(item:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z});
            val_46 = val_46 + 1;
            UnityEngine.Vector3 val_19 = meshData + 120.Item[meshData.Edges.Item[val_46]];
            meshData + 120.Add(item:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z});
            val_46 = val_46 - 1;
            UnityEngine.Vector3 val_21 = meshData + 120.Item[meshData.Edges.Item[val_46]];
            meshData + 120.Add(item:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z});
            int val_22 = val_46 + 1;
            UnityEngine.Vector3 val_24 = meshData + 120.Item[meshData.Edges.Item[val_22]];
            meshData + 120.Add(item:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z});
            UnityEngine.Vector3 val_25 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_48}, b:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z});
            UnityEngine.Vector4 val_26 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z});
            meshData + 128.Add(item:  new UnityEngine.Vector4() {x = val_26.x, y = val_26.y, z = val_26.z, w = val_26.w});
            UnityEngine.Vector3 val_27 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_48}, b:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z});
            UnityEngine.Vector4 val_28 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z});
            meshData + 128.Add(item:  new UnityEngine.Vector4() {x = val_28.x, y = val_28.y, z = val_28.z, w = val_28.w});
            UnityEngine.Vector3 val_29 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_48}, b:  new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z});
            UnityEngine.Vector4 val_30 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector3() {x = val_29.x, y = val_29.y, z = val_29.z});
            meshData + 128.Add(item:  new UnityEngine.Vector4() {x = val_30.x, y = val_30.y, z = val_30.z, w = val_30.w});
            UnityEngine.Vector3 val_31 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_48}, b:  new UnityEngine.Vector3() {x = val_30.x, y = val_30.y, z = val_30.z});
            UnityEngine.Vector4 val_32 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector3() {x = val_31.x, y = val_31.y, z = val_31.z});
            val_49 = val_32.x;
            meshData + 128.Add(item:  new UnityEngine.Vector4() {x = val_49, y = val_32.y, z = val_32.z, w = val_32.w});
            UnityEngine.Vector3 val_33 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_48}, b:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
            val_50 = val_33.x;
            UnityEngine.Vector2 val_34 = new UnityEngine.Vector2(x:  0f, y:  0f);
            if(val_2 != 0)
            {
                    val_52 = 1152921517377849056;
                val_2.Add(item:  new UnityEngine.Vector2() {x = val_34.x, y = val_34.y});
                val_53 = 0f;
                UnityEngine.Vector2 val_35 = new UnityEngine.Vector2(x:  val_50, y:  val_53);
            }
            else
            {
                    val_52 = 1152921517377849056;
                val_2.Add(item:  new UnityEngine.Vector2() {x = val_34.x, y = val_34.y});
                val_53 = 0f;
                UnityEngine.Vector2 val_36 = new UnityEngine.Vector2(x:  val_50, y:  val_53);
            }
            
            val_2.Add(item:  new UnityEngine.Vector2() {x = val_36.x, y = val_36.y});
            UnityEngine.Vector2 val_37 = new UnityEngine.Vector2(x:  0f, y:  -hf);
            if(val_2 != 0)
            {
                    val_2.Add(item:  new UnityEngine.Vector2() {x = val_37.x, y = val_37.y});
                val_54 = -hf;
                UnityEngine.Vector2 val_38 = new UnityEngine.Vector2(x:  val_50, y:  val_54);
            }
            else
            {
                    val_2.Add(item:  new UnityEngine.Vector2() {x = val_37.x, y = val_37.y});
                val_54 = -hf;
                UnityEngine.Vector2 val_39 = new UnityEngine.Vector2(x:  val_50, y:  val_54);
            }
            
            val_2.Add(item:  new UnityEngine.Vector2() {x = val_39.x, y = val_39.y});
            if(val_1 != null)
            {
                    val_1.Add(item:  val_14);
                val_47 = val_14 + 1;
                val_1.Add(item:  val_47);
                val_55 = val_14 + 2;
                val_1.Add(item:  val_55);
                val_1.Add(item:  val_47);
                val_1.Add(item:  val_14 + 3);
            }
            else
            {
                    val_1.Add(item:  val_14);
                val_47 = val_14 + 1;
                val_1.Add(item:  val_47);
                val_55 = val_14 + 2;
                val_1.Add(item:  val_55);
                val_1.Add(item:  val_47);
                val_1.Add(item:  val_14 + 3);
            }
            
            val_1.Add(item:  val_55);
            val_51 = val_22 + 1;
            label_17:
            if(val_51 < meshData.Edges.Count)
            {
                goto label_55;
            }
            
            meshData.Triangles.Add(item:  val_1);
            meshData.UV.Item[0].AddRange(collection:  val_2);
            return;
            label_3:
            if(65536 != 0)
            {
                goto label_59;
            }
            
            goto label_60;
            label_10:
            if(62590976 != 0)
            {
                goto label_61;
            }
            
            goto label_62;
            label_14:
            if(1 != 0)
            {
                goto label_63;
            }
            
            goto label_64;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void FlattenTops(Mapbox.Unity.MeshGeneration.Data.MeshData meshData, float minHeight, ref float hf, ref float max, ref float min)
        {
            var val_10;
            float val_11;
            var val_12;
            val_10 = 0;
            goto label_1;
            label_10:
            UnityEngine.Vector3 val_1 = meshData.Vertices.Item[0];
            val_11 = max;
            UnityEngine.Vector3 val_2 = meshData.Vertices.Item[0];
            if(val_1.y > val_11)
            {
                    max = val_2.y;
            }
            else
            {
                    if(val_2.y < 0)
            {
                    UnityEngine.Vector3 val_3 = meshData.Vertices.Item[0];
                min = val_3.y;
            }
            
            }
            
            val_10 = 1;
            label_1:
            if(val_10 < meshData.Vertices.Count)
            {
                goto label_10;
            }
            
            val_12 = 0;
            goto label_11;
            label_16:
            UnityEngine.Vector3 val_5 = meshData.Vertices.Item[0];
            val_11 = max;
            UnityEngine.Vector3 val_6 = meshData.Vertices.Item[0];
            float val_8 = (val_11 + minHeight) + hf;
            meshData.Vertices.set_Item(index:  0, value:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            val_12 = 1;
            label_11:
            if(val_12 < meshData.Vertices.Count)
            {
                goto label_16;
            }
            
            float val_10 = max;
            val_10 = val_10 - min;
            val_10 = hf + val_10;
            hf = val_10;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void GetHeightData(Mapbox.Unity.MeshGeneration.Data.VectorFeatureUnity feature, float scale, ref float minHeight, ref float hf)
        {
            float val_10;
            if((feature.Properties.ContainsKey(key:  "height")) != false)
            {
                    val_10 = (System.Convert.ToSingle(value:  feature.Properties.Item["height"])) * scale;
                hf = val_10;
                if((feature.Properties.ContainsKey(key:  "min_height")) != false)
            {
                    float val_6 = System.Convert.ToSingle(value:  feature.Properties.Item["min_height"]);
                val_6 = val_6 * scale;
                minHeight = val_6;
                val_10 = hf - val_6;
                hf = val_10;
            }
            
            }
            
            if((feature.Properties.ContainsKey(key:  "ele")) == false)
            {
                    return;
            }
            
            float val_9 = System.Convert.ToSingle(value:  feature.Properties.Item["ele"]);
            val_9 = val_9 * scale;
            hf = val_9;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Chamfer(Mapbox.Unity.MeshGeneration.Data.VectorFeatureUnity feature, Mapbox.Unity.MeshGeneration.Data.MeshData md, Mapbox.Unity.MeshGeneration.Data.UnityTile tile)
        {
            System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Vector2>> val_99;
            Mapbox.Unity.MeshGeneration.Data.VectorFeatureUnity val_100;
            System.Collections.Generic.List<UnityEngine.Vector3> val_101;
            var val_102;
            var val_103;
            System.Collections.Generic.List<UnityEngine.Vector3> val_104;
            System.Collections.Generic.List<UnityEngine.Vector3> val_105;
            float val_106;
            float val_107;
            float val_108;
            float val_109;
            var val_110;
            float val_111;
            float val_112;
            float val_113;
            float val_114;
            float val_115;
            float val_116;
            float val_117;
            float val_118;
            float val_119;
            float val_120;
            float val_121;
            float val_122;
            val_99 = md;
            val_100 = feature;
            if(md.Vertices.Count == 0)
            {
                    return;
            }
            
            if(feature.Points.Count < 1)
            {
                    return;
            }
            
            System.Collections.Generic.List<UnityEngine.Vector3> val_3 = null;
            val_101 = val_3;
            val_3 = new System.Collections.Generic.List<UnityEngine.Vector3>();
            System.Collections.Generic.List<UnityEngine.Vector2> val_4 = new System.Collections.Generic.List<UnityEngine.Vector2>();
            md.Normals.Clear();
            md.Edges.Clear();
            md.Tangents.Clear();
            goto label_10;
            label_16:
            System.Collections.Generic.List<System.Int32> val_5 = md.Triangles.Item[0];
            if(val_5 != null)
            {
                    int val_6 = val_5.Item[0];
            }
            else
            {
                    int val_7 = val_5.Item[0];
            }
            
            val_5.set_Item(index:  0, value:  val_7 + (val_7 << 1));
            label_10:
            int val_10 = md.Triangles.Item[0].Count;
            if(1 < val_10)
            {
                goto label_16;
            }
            
            val_100 = 1152921518725068768;
            val_102 = 1152921518605502048;
            val_103 = 0;
            goto label_17;
            label_128:
            int val_12 = 1.Item[0].Count;
            int val_13 = val_3.Count;
            if(1 < val_10)
            {
                goto label_21;
            }
            
            int val_102 = val_13;
            var val_103 = 0;
            int val_15 = val_102 + 1;
            val_102 = val_102 + 2;
            var val_104 = 4;
            goto label_125;
            label_112:
            val_104 = md.Normals;
            val_105 = md.Normals;
            if(val_105 != null)
            {
                goto label_113;
            }
            
            goto label_24;
            label_125:
            if(((-val_12) + val_103) == 1)
            {
                goto label_25;
            }
            
            var val_17 = (val_103 < 1) ? (val_12 - 1) : 0;
            val_17 = 0 + val_17;
            int val_18 = val_17 + val_103;
            val_18 = val_18 - 1;
            UnityEngine.Vector3 val_19 = md.Vertices.Item[0];
            UnityEngine.Vector3 val_20 = md.Vertices.Item[val_18];
            UnityEngine.Vector3 val_21 = md.Vertices.Item[0];
            UnityEngine.Vector3 val_22 = md.Vertices.Item[val_18];
            float val_23 = val_19.x - val_20.x;
            val_22.z = val_21.z - val_22.z;
            val_106 = this._offset;
            UnityEngine.Vector3 val_24 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, d:  -val_106);
            UnityEngine.Vector3 val_25 = md.Vertices.Item[val_18];
            UnityEngine.Vector3 val_26 = md.Vertices.Item[val_18];
            float val_27 = val_25.x + 0f;
            val_26.z = val_26.z + 0f;
            UnityEngine.Vector3 val_28 = md.Vertices.Item[0];
            UnityEngine.Vector3 val_29 = md.Vertices.Item[0];
            float val_30 = val_28.x + 0f;
            val_29.z = val_29.z + 0f;
            UnityEngine.Vector3 val_31 = md.Vertices.Item[1];
            UnityEngine.Vector3 val_32 = md.Vertices.Item[0];
            UnityEngine.Vector3 val_33 = md.Vertices.Item[1];
            val_107 = val_33.z;
            UnityEngine.Vector3 val_34 = md.Vertices.Item[0];
            float val_35 = val_31.x - val_32.x;
            val_34.z = val_107 - val_34.z;
            UnityEngine.Vector3 val_36 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, d:  -this._offset);
            UnityEngine.Vector3 val_37 = md.Vertices.Item[0];
            UnityEngine.Vector3 val_38 = md.Vertices.Item[0];
            float val_39 = val_37.x + 0f;
            val_38.z = val_38.z + 0f;
            UnityEngine.Vector3 val_40 = md.Vertices.Item[1];
            UnityEngine.Vector3 val_41 = md.Vertices.Item[1];
            float val_42 = val_40.x + 0f;
            val_41.z = val_41.z + 0f;
            0.FindIntersection(p1:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, p2:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, p3:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, p4:  new UnityEngine.Vector3() {x = 0f}, lines_intersect: out  false, segments_intersect: out  false, intersection: out  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, close_p1: out  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, close_p2: out  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            val_108 = this._offset;
            val_109 = val_108 * 10f;
            if((UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f})) > val_109)
            {
                    UnityEngine.Vector3 val_46 = md.Vertices.Item[0];
                UnityEngine.Vector3 val_47 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z});
                UnityEngine.Vector3 val_48 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_47.x, y = val_47.y, z = val_47.z}, b:  new UnityEngine.Vector3() {x = val_36.x, y = val_36.y, z = val_36.z});
                UnityEngine.Vector3 val_49 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, b:  new UnityEngine.Vector3() {x = val_48.x, y = val_48.y, z = val_48.z});
                UnityEngine.Vector3 val_50 = md.Vertices.Item[0];
                val_107 = 0f;
                val_106 = 0f;
                UnityEngine.Vector3 val_51 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z});
                UnityEngine.Vector3 val_52 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_51.x, y = val_51.y, z = val_51.z}, b:  new UnityEngine.Vector3() {x = val_36.x, y = val_36.y, z = val_36.z});
                UnityEngine.Vector3 val_53 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_107, y = val_106, z = 0f}, b:  new UnityEngine.Vector3() {x = val_52.x, y = val_52.y, z = val_52.z});
                float val_54 = val_46.x + val_49.x;
                val_53.z = val_50.z + val_53.z;
                val_109 = 0f;
                val_108 = this._offset;
            }
            
            UnityEngine.Vector3 val_55 = md.Vertices.Item[0];
            val_55.y = (0f + val_108) + val_55.y;
            val_3.Add(item:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            UnityEngine.Vector3 val_57 = md.Vertices.Item[0];
            UnityEngine.Vector3 val_58 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_57.x, y = val_57.y, z = val_57.z}, b:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z});
            val_3.Add(item:  new UnityEngine.Vector3() {x = val_58.x, y = val_58.y, z = val_58.z});
            UnityEngine.Vector3 val_59 = md.Vertices.Item[0];
            UnityEngine.Vector3 val_60 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_59.x, y = val_59.y, z = val_59.z}, b:  new UnityEngine.Vector3() {x = val_36.x, y = val_36.y, z = val_36.z});
            val_3.Add(item:  new UnityEngine.Vector3() {x = val_60.x, y = val_60.y, z = val_60.z});
            val_110 = null;
            val_110 = null;
            md.Normals.Add(item:  new UnityEngine.Vector3() {x = Constants.Math.Vector3Up, y = Constants.Math.Vector3Zero.__il2cppRuntimeField_10, z = Constants.Math.Vector3Zero.__il2cppRuntimeField_14});
            UnityEngine.Vector3 val_61 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            md.Normals.Add(item:  new UnityEngine.Vector3() {x = val_61.x, y = val_61.y, z = val_61.z});
            UnityEngine.Vector3 val_62 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            md.Normals.Add(item:  new UnityEngine.Vector3() {x = val_62.x, y = val_62.y, z = val_62.z});
            UnityEngine.Vector3 val_63 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z}, b:  new UnityEngine.Vector3() {x = val_36.x, y = val_36.y, z = val_36.z});
            UnityEngine.Vector4 val_64 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector3() {x = val_63.x, y = val_63.y, z = val_63.z});
            md.Tangents.Add(item:  new UnityEngine.Vector4() {x = val_64.x, y = val_64.y, z = val_64.z, w = val_64.w});
            UnityEngine.Vector3 val_65 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z}, b:  new UnityEngine.Vector3() {x = val_36.x, y = val_36.y, z = val_36.z});
            UnityEngine.Vector4 val_66 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector3() {x = val_65.x, y = val_65.y, z = val_65.z});
            md.Tangents.Add(item:  new UnityEngine.Vector4() {x = val_66.x, y = val_66.y, z = val_66.z, w = val_66.w});
            UnityEngine.Vector3 val_67 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z}, b:  new UnityEngine.Vector3() {x = val_36.x, y = val_36.y, z = val_36.z});
            UnityEngine.Vector4 val_68 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector3() {x = val_67.x, y = val_67.y, z = val_67.z});
            val_111 = val_68.z;
            md.Tangents.Add(item:  new UnityEngine.Vector4() {x = val_68.x, y = val_68.y, z = val_111, w = val_68.w});
            UnityEngine.Vector2 val_70 = md.UV.Item[0].Item[0];
            val_4.Add(item:  new UnityEngine.Vector2() {x = val_70.x, y = val_70.y});
            UnityEngine.Vector2 val_72 = md.UV.Item[0].Item[0];
            val_4.Add(item:  new UnityEngine.Vector2() {x = val_72.x, y = val_72.y});
            UnityEngine.Vector2 val_74 = md.UV.Item[0].Item[0];
            val_112 = val_74.x;
            val_4.Add(item:  new UnityEngine.Vector2() {x = val_112, y = val_74.y});
            int val_76 = val_104 - 4;
            md.Triangles.Item[0].Add(item:  val_76);
            int val_78 = val_104 - 3;
            md.Triangles.Item[0].Add(item:  val_78);
            int val_80 = val_104 - 2;
            md.Triangles.Item[0].Add(item:  val_80);
            md.Edges.Add(item:  val_80);
            md.Edges.Add(item:  val_78);
            int val_82 = val_104 - 1;
            md.Triangles.Item[0].Add(item:  val_82);
            md.Triangles.Item[0].Add(item:  val_80);
            md.Triangles.Item[0].Add(item:  4);
            md.Triangles.Item[0].Add(item:  val_76);
            md.Triangles.Item[0].Add(item:  val_80);
            md.Triangles.Item[0].Add(item:  val_82);
            md.Edges.Add(item:  4);
            val_102 = 1152921518605502048;
            md.Edges.Add(item:  val_80);
            val_101 = val_101;
            val_100 = 1152921518725068768;
            goto label_99;
            label_25:
            UnityEngine.Vector3 val_88 = val_3.Item[val_13];
            if(val_101 != null)
            {
                    val_113 = val_88.x;
                val_114 = val_88.y;
                val_115 = val_88.z;
                val_3.Add(item:  new UnityEngine.Vector3() {x = val_113, y = val_114, z = val_115});
            }
            else
            {
                    val_113 = val_88.x;
                val_114 = val_88.y;
                val_115 = val_88.z;
                val_3.Add(item:  new UnityEngine.Vector3() {x = val_113, y = val_114, z = val_115});
            }
            
            UnityEngine.Vector3 val_89 = val_3.Item[val_15];
            if(val_101 != null)
            {
                    val_116 = val_89.x;
                val_117 = val_89.y;
                val_118 = val_89.z;
                val_3.Add(item:  new UnityEngine.Vector3() {x = val_116, y = val_117, z = val_118});
            }
            else
            {
                    val_116 = val_89.x;
                val_117 = val_89.y;
                val_118 = val_89.z;
                val_3.Add(item:  new UnityEngine.Vector3() {x = val_116, y = val_117, z = val_118});
            }
            
            UnityEngine.Vector3 val_90 = val_3.Item[val_102];
            val_3.Add(item:  new UnityEngine.Vector3() {x = val_90.x, y = val_90.y, z = val_90.z});
            UnityEngine.Vector2 val_91 = val_4.Item[val_13];
            if(val_4 != 0)
            {
                    val_119 = val_91.x;
                val_120 = val_91.y;
                val_4.Add(item:  new UnityEngine.Vector2() {x = val_119, y = val_120});
            }
            else
            {
                    val_119 = val_91.x;
                val_120 = val_91.y;
                val_4.Add(item:  new UnityEngine.Vector2() {x = val_119, y = val_120});
            }
            
            UnityEngine.Vector2 val_92 = val_4.Item[val_15];
            if(val_4 != 0)
            {
                    val_121 = val_92.x;
                val_122 = val_92.y;
                val_4.Add(item:  new UnityEngine.Vector2() {x = val_121, y = val_122});
            }
            else
            {
                    val_121 = val_92.x;
                val_122 = val_92.y;
                val_4.Add(item:  new UnityEngine.Vector2() {x = val_121, y = val_122});
            }
            
            UnityEngine.Vector2 val_93 = val_4.Item[val_102];
            val_4.Add(item:  new UnityEngine.Vector2() {x = val_93.x, y = val_93.y});
            if(val_99 == null)
            {
                goto label_112;
            }
            
            val_105 = md.Normals;
            val_104 = val_105;
            if(val_105 != null)
            {
                goto label_113;
            }
            
            label_24:
            label_113:
            UnityEngine.Vector3 val_94 = val_105.Item[val_13];
            val_104.Add(item:  new UnityEngine.Vector3() {x = val_94.x, y = val_94.y, z = val_94.z});
            UnityEngine.Vector3 val_95 = md.Normals.Item[val_15];
            md.Normals.Add(item:  new UnityEngine.Vector3() {x = val_95.x, y = val_95.y, z = val_95.z});
            UnityEngine.Vector3 val_96 = md.Normals.Item[val_102];
            md.Normals.Add(item:  new UnityEngine.Vector3() {x = val_96.x, y = val_96.y, z = val_96.z});
            UnityEngine.Vector4 val_97 = md.Tangents.Item[val_13];
            md.Tangents.Add(item:  new UnityEngine.Vector4() {x = val_97.x, y = val_97.y, z = val_97.z, w = val_97.w});
            UnityEngine.Vector4 val_98 = md.Tangents.Item[val_15];
            md.Tangents.Add(item:  new UnityEngine.Vector4() {x = val_98.x, y = val_98.y, z = val_98.z, w = val_98.w});
            UnityEngine.Vector4 val_99 = md.Tangents.Item[val_102];
            val_112 = val_99.x;
            val_111 = val_99.z;
            md.Tangents.Add(item:  new UnityEngine.Vector4() {x = val_112, y = val_99.y, z = val_111, w = val_99.w});
            label_99:
            val_103 = val_103 + 1;
            val_104 = val_104 + 3;
            if(((-val_12) + val_103) != 0)
            {
                goto label_125;
            }
            
            label_21:
            int val_105 = 0;
            val_105 = val_12 + val_105;
            val_103 = 1;
            label_17:
            if(val_103 < (feature + 32.Count))
            {
                goto label_128;
            }
            
            if(val_99 != null)
            {
                    md.Vertices = val_101;
            }
            else
            {
                    md.Vertices = val_101;
            }
            
            val_99 = md.UV;
            val_99.set_Item(index:  0, value:  val_4);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<UnityEngine.Vector3> GetEnlargedPolygon(System.Collections.Generic.List<UnityEngine.Vector3> old_points, float offset)
        {
            float val_45;
            float val_46;
            float val_47;
            var val_48;
            var val_49;
            var val_50;
            float val_51;
            float val_52;
            float val_53;
            var val_54;
            var val_55;
            System.Collections.Generic.List<UnityEngine.Vector3> val_1 = new System.Collections.Generic.List<UnityEngine.Vector3>();
            int val_2 = old_points.Count;
            if()
            {
                    return val_1;
            }
            
            var val_41 = 0;
            do
            {
                var val_4 = (val_41 > 0) ? 0 : (val_2);
                val_4 = val_4 + val_41;
                int val_5 = val_4 - 1;
                int val_6 = ((val_2 - 1) == val_41) ? 0 : (val_41 + 1);
                if(old_points != null)
            {
                    UnityEngine.Vector3 val_7 = old_points.Item[0];
                val_45 = val_7.x;
                UnityEngine.Vector3 val_8 = old_points.Item[val_5];
                val_46 = val_8.x;
                UnityEngine.Vector3 val_9 = old_points.Item[0];
                val_47 = val_9.z;
            }
            else
            {
                    UnityEngine.Vector3 val_10 = 0.Item[0];
                val_45 = val_10.x;
                UnityEngine.Vector3 val_11 = 0.Item[val_5];
                val_46 = val_11.x;
                UnityEngine.Vector3 val_12 = 0.Item[0];
                val_47 = val_12.z;
            }
            
                UnityEngine.Vector3 val_13 = old_points.Item[val_5];
                float val_14 = val_45 - val_46;
                val_13.z = val_47 - val_13.z;
                UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, d:  offset);
                UnityEngine.Vector3 val_16 = old_points.Item[val_5];
                if(old_points != null)
            {
                    UnityEngine.Vector3 val_17 = old_points.Item[val_5];
                val_48 = val_16.x + 0f;
                val_49 = val_17.z + 0f;
            }
            else
            {
                    UnityEngine.Vector3 val_18 = 0.Item[val_5];
                val_48 = val_16.x + 0f;
                val_49 = val_18.z + 0f;
            }
            
                UnityEngine.Vector3 val_19 = old_points.Item[0];
                if(old_points != null)
            {
                    UnityEngine.Vector3 val_20 = old_points.Item[0];
                float val_21 = val_19.x + 0f;
                val_50 = val_20.z + 0f;
                UnityEngine.Vector3 val_22 = old_points.Item[val_6];
                val_51 = val_22.x;
                UnityEngine.Vector3 val_23 = old_points.Item[0];
                val_52 = val_23.x;
                UnityEngine.Vector3 val_24 = old_points.Item[val_6];
                val_53 = val_24.z;
            }
            else
            {
                    UnityEngine.Vector3 val_25 = 0.Item[0];
                float val_26 = val_19.x + 0f;
                val_50 = val_25.z + 0f;
                UnityEngine.Vector3 val_27 = 0.Item[val_6];
                val_51 = val_27.x;
                UnityEngine.Vector3 val_28 = 0.Item[0];
                val_52 = val_28.x;
                UnityEngine.Vector3 val_29 = 0.Item[val_6];
                val_53 = val_29.z;
            }
            
                UnityEngine.Vector3 val_30 = old_points.Item[0];
                float val_31 = val_51 - val_52;
                val_30.z = val_53 - val_30.z;
                UnityEngine.Vector3 val_32 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, d:  offset);
                UnityEngine.Vector3 val_33 = old_points.Item[0];
                if(old_points != null)
            {
                    UnityEngine.Vector3 val_34 = old_points.Item[0];
                val_54 = val_33.x + 0f;
                val_55 = val_34.z + 0f;
            }
            else
            {
                    UnityEngine.Vector3 val_35 = 0.Item[0];
                val_54 = val_33.x + 0f;
                val_55 = val_35.z + 0f;
            }
            
                UnityEngine.Vector3 val_36 = old_points.Item[val_6];
                val_41 = val_41 + 1;
                UnityEngine.Vector3 val_37 = old_points.Item[val_6];
                float val_38 = val_36.x + 0f;
                val_37.z = val_37.z + 0f;
                0.FindIntersection(p1:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, p2:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, p3:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, p4:  new UnityEngine.Vector3() {x = 0f, z = 0f}, lines_intersect: out  false, segments_intersect: out  false, intersection: out  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, close_p1: out  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, close_p2: out  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                val_1.Add(item:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            }
            while(val_2 != val_41);
            
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void FindIntersection(UnityEngine.Vector3 p1, UnityEngine.Vector3 p2, UnityEngine.Vector3 p3, UnityEngine.Vector3 p4, out bool lines_intersect, out bool segments_intersect, out UnityEngine.Vector3 intersection, out UnityEngine.Vector3 close_p1, out UnityEngine.Vector3 close_p2)
        {
            float val_23;
            float val_24;
            float val_25;
            var val_26;
            float val_27;
            val_23 = p1.z;
            float val_1 = p2.x - p1.x;
            float val_2 = p2.z - val_23;
            float val_3 = p3.z - p3.x;
            float val_4 = p4.x - p3.y;
            float val_7 = p1.x - p3.x;
            val_24 = (val_2 * val_3) - (val_1 * val_4);
            float val_8 = p3.y - val_23;
            val_7 = val_7 * val_4;
            val_8 = val_8 * val_3;
            val_7 = val_7 + val_8;
            val_25 = val_7 / val_24;
            if((System.Single.IsInfinity(f:  val_25)) != false)
            {
                    val_23 = 0f;
                lines_intersect = false;
                segments_intersect = false;
                intersection.z = 0f;
                intersection.x = 0f;
                intersection.y = 0f;
                close_p1.z = 0f;
                close_p1.x = 0f;
                close_p1.y = 0f;
                close_p2.z = 0f;
                val_26 = 0;
            }
            else
            {
                    float val_11 = val_23 - p3.y;
                p2.z = val_2 * (p3.x - p1.x);
                val_11 = val_1 * val_11;
                val_4 = val_1 * val_25;
                val_3 = val_2 * val_25;
                val_11 = p2.z + val_11;
                float val_12 = p1.x + val_4;
                val_24 = val_11 / (-val_24);
                float val_13 = val_23 + val_3;
                lines_intersect = true;
                var val_14 = (val_25 <= 1f) ? 1 : 0;
                intersection.z = 0f;
                bool val_16 = (val_24 <= 1f) ? 1 : 0;
                val_14 = ((val_25 >= 0f) ? 1 : 0) & val_14;
                val_14 = ((val_24 >= 0f) ? 1 : 0) & val_14;
                val_16 = val_16 & val_14;
                val_27 = 0f;
                intersection.x = 0f;
                intersection.y = 0f;
                segments_intersect = val_16;
                if(val_25 >= 0)
            {
                    val_27 = val_25;
                if(val_25 > 1f)
            {
                    val_27 = 1f;
            }
            
            }
            
                val_25 = 0f;
                if(val_24 >= 0)
            {
                    val_25 = val_24;
                if(val_24 > 1f)
            {
                    val_25 = 1f;
            }
            
            }
            
                float val_19 = val_2 * val_27;
                val_27 = p1.x + (val_1 * val_27);
                val_19 = val_23 + val_19;
                close_p1.z = 0f;
                float val_21 = val_3;
                float val_22 = val_4;
                val_21 = val_21 * val_25;
                val_22 = val_22 * val_25;
                val_21 = p3.x + val_21;
                float val_20 = p3.y + val_22;
                close_p1.x = 0f;
                close_p1.y = 0f;
                close_p2.z = 0f;
                val_26 = 0;
            }
            
            close_p2.x = 0f;
            close_p2.y = 0f;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ChamferHeightModifier()
        {
            this._offset = 0.2f;
            mem[1152921519703595288] = 1;
            val_1 = new UnityEngine.ScriptableObject();
        }
    
    }

}
