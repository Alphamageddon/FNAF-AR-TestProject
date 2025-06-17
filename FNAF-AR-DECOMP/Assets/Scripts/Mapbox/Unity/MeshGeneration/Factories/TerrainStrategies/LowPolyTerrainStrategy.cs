using UnityEngine;

namespace Mapbox.Unity.MeshGeneration.Factories.TerrainStrategies
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class LowPolyTerrainStrategy : TerrainStrategy, IElevationBasedTerrainStrategy
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected System.Collections.Generic.Dictionary<Mapbox.Map.UnwrappedTileId, UnityEngine.Mesh> _meshData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Mesh _stitchTarget;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.MeshGeneration.Data.MeshData _currentTileMeshData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.MeshGeneration.Data.MeshData _stitchTargetMeshData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<UnityEngine.Vector3> _newVertexList;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<UnityEngine.Vector3> _newNormalList;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<UnityEngine.Vector2> _newUvList;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<int> _newTriangleList;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 _newDir;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _vertA;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _vertB;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _vertC;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _counter;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void Initialize(Mapbox.Unity.Map.ElevationLayerProperties elOptions)
        {
            mem[1152921519756103392] = elOptions;
            this._meshData = new System.Collections.Generic.Dictionary<Mapbox.Map.UnwrappedTileId, UnityEngine.Mesh>();
            this._currentTileMeshData = new Mapbox.Unity.MeshGeneration.Data.MeshData();
            this._stitchTargetMeshData = new Mapbox.Unity.MeshGeneration.Data.MeshData();
            this._newVertexList = new System.Collections.Generic.List<UnityEngine.Vector3>(capacity:  -1722883072);
            this._newNormalList = new System.Collections.Generic.List<UnityEngine.Vector3>(capacity:  -1722883072);
            this._newUvList = new System.Collections.Generic.List<UnityEngine.Vector2>(capacity:  -1722883072);
            this._newTriangleList = new System.Collections.Generic.List<System.Int32>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void UnregisterTile(Mapbox.Unity.MeshGeneration.Data.UnityTile tile)
        {
            bool val_1 = this._meshData.Remove(key:  new Mapbox.Map.UnwrappedTileId() {Z = tile.<UnwrappedTileId>k__BackingField, X = tile.<UnwrappedTileId>k__BackingField, Y = tile});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void RegisterTile(Mapbox.Unity.MeshGeneration.Data.UnityTile tile)
        {
            if((X21 + 56 + 16) != 0)
            {
                    if(tile.gameObject.layer != (X22 + 56 + 20))
            {
                    tile.gameObject.layer = X22 + 56 + 56 + 20;
            }
            
            }
            
            if(tile.MeshFilter.mesh.vertexCount == 0)
            {
                    this.CreateBaseMesh(tile:  tile);
            }
            
            this.GenerateTerrainMesh(tile:  tile);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CreateBaseMesh(Mapbox.Unity.MeshGeneration.Data.UnityTile tile)
        {
            System.Collections.Generic.List<System.Int32> val_36;
            System.Collections.Generic.List<UnityEngine.Vector3> val_37;
            val_36 = this;
            this._newVertexList.Clear();
            this._newNormalList.Clear();
            this._newUvList.Clear();
            this._newTriangleList.Clear();
            if(69500007 >= 1)
            {
                    float val_36 = 0f;
                do
            {
                float val_1 = val_36 / (6.950001E+07f);
                val_36 = val_36 + 1f;
                val_36 = val_36 / (6.950001E+07f);
                val_1 = 1f - val_1;
                float val_2 = 1f - val_36;
                float val_37 = 0f;
                do
            {
                if(tile != null)
            {
                
            }
            
                Mapbox.Utils.Vector2d val_3 = tile.<Rect>k__BackingField.<Min>k__BackingField.Min;
                Mapbox.Utils.Vector2d val_4 = tile.<Rect>k__BackingField.<Min>k__BackingField.Min;
                float val_5 = val_37 / (6.950001E+07f);
                double val_39 = Mapbox.Utils.Mathd.Lerp(from:  val_3.x, to:  val_4.x, t:  (double)val_5);
                Mapbox.Utils.Vector2d val_7 = tile.<Rect>k__BackingField.<Min>k__BackingField.Size;
                if(tile != null)
            {
                
            }
            
                Mapbox.Utils.Vector2d val_8 = tile.<Rect>k__BackingField.<Min>k__BackingField.Min;
                Mapbox.Utils.Vector2d val_9 = tile.<Rect>k__BackingField.<Min>k__BackingField.Min;
                Mapbox.Utils.Vector2d val_11 = tile.<Rect>k__BackingField.<Min>k__BackingField.Size;
                double val_40 = val_11.y;
                if(tile != null)
            {
                
            }
            
                Mapbox.Utils.Vector2d val_12 = tile.<Rect>k__BackingField.<Min>k__BackingField.Min;
                Mapbox.Utils.Vector2d val_13 = tile.<Rect>k__BackingField.<Min>k__BackingField.Min;
                float val_38 = 1f;
                val_37 = val_37 + val_38;
                val_38 = val_37 / (6.950001E+07f);
                Mapbox.Utils.Vector2d val_15 = tile.<Rect>k__BackingField.<Min>k__BackingField.Size;
                double val_41 = val_15.x;
                if(tile != null)
            {
                
            }
            
                val_39 = val_39 - val_7.x;
                val_40 = (Mapbox.Utils.Mathd.Lerp(from:  val_8.y, to:  val_9.y, t:  (double)val_1)) - val_40;
                Mapbox.Utils.Vector2d val_16 = tile.<Rect>k__BackingField.<Min>k__BackingField.Min;
                val_41 = (Mapbox.Utils.Mathd.Lerp(from:  val_12.x, to:  val_13.x, t:  (double)val_38)) - val_41;
                float val_42 = (float)val_40;
                Mapbox.Utils.Vector2d val_17 = tile.<Rect>k__BackingField.<Min>k__BackingField.Min;
                double val_43 = Mapbox.Utils.Mathd.Lerp(from:  val_16.y, to:  val_17.y, t:  (double)val_36);
                val_39 = (tile.<TileScale>k__BackingField) * (float)val_39;
                val_42 = (tile.<TileScale>k__BackingField) * val_42;
                Mapbox.Utils.Vector2d val_19 = tile.<Rect>k__BackingField.<Min>k__BackingField.Size;
                val_43 = val_43 - val_19.y;
                float val_20 = (tile.<TileScale>k__BackingField) * (float)val_41;
                int val_21 = this._newVertexList.Count;
                float val_22 = (tile.<TileScale>k__BackingField) * (float)val_43;
                this._newVertexList.Add(item:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                this._newVertexList.Add(item:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                this._newVertexList.Add(item:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                this._newVertexList.Add(item:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                this._newVertexList.Add(item:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                this._newVertexList.Add(item:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                this._newNormalList.Add(item:  new UnityEngine.Vector3() {x = Constants.Math.Vector3Up, y = Constants.Math.Vector3Zero.__il2cppRuntimeField_10, z = Constants.Math.Vector3Zero.__il2cppRuntimeField_14});
                this._newNormalList.Add(item:  new UnityEngine.Vector3() {x = Constants.Math.Vector3Up, y = Constants.Math.Vector3Zero.__il2cppRuntimeField_10, z = Constants.Math.Vector3Zero.__il2cppRuntimeField_14});
                this._newNormalList.Add(item:  new UnityEngine.Vector3() {x = Constants.Math.Vector3Up, y = Constants.Math.Vector3Zero.__il2cppRuntimeField_10, z = Constants.Math.Vector3Zero.__il2cppRuntimeField_14});
                this._newNormalList.Add(item:  new UnityEngine.Vector3() {x = Constants.Math.Vector3Up, y = Constants.Math.Vector3Zero.__il2cppRuntimeField_10, z = Constants.Math.Vector3Zero.__il2cppRuntimeField_14});
                this._newNormalList.Add(item:  new UnityEngine.Vector3() {x = Constants.Math.Vector3Up, y = Constants.Math.Vector3Zero.__il2cppRuntimeField_10, z = Constants.Math.Vector3Zero.__il2cppRuntimeField_14});
                this._newNormalList.Add(item:  new UnityEngine.Vector3() {x = Constants.Math.Vector3Up, y = Constants.Math.Vector3Zero.__il2cppRuntimeField_10, z = Constants.Math.Vector3Zero.__il2cppRuntimeField_14});
                UnityEngine.Vector2 val_23 = new UnityEngine.Vector2(x:  val_5, y:  val_1);
                this._newUvList.Add(item:  new UnityEngine.Vector2() {x = val_23.x, y = val_23.y});
                UnityEngine.Vector2 val_24 = new UnityEngine.Vector2(x:  val_38, y:  val_1);
                this._newUvList.Add(item:  new UnityEngine.Vector2() {x = val_24.x, y = val_24.y});
                UnityEngine.Vector2 val_25 = new UnityEngine.Vector2(x:  val_5, y:  val_2);
                this._newUvList.Add(item:  new UnityEngine.Vector2() {x = val_25.x, y = val_25.y});
                UnityEngine.Vector2 val_26 = new UnityEngine.Vector2(x:  val_38, y:  val_1);
                this._newUvList.Add(item:  new UnityEngine.Vector2() {x = val_26.x, y = val_26.y});
                UnityEngine.Vector2 val_27 = new UnityEngine.Vector2(x:  val_38, y:  val_2);
                this._newUvList.Add(item:  new UnityEngine.Vector2() {x = val_27.x, y = val_27.y});
                UnityEngine.Vector2 val_28 = new UnityEngine.Vector2(x:  val_5, y:  val_2);
                this._newUvList.Add(item:  new UnityEngine.Vector2() {x = val_28.x, y = val_28.y});
                this._newTriangleList.Add(item:  val_21);
                this._newTriangleList.Add(item:  val_21 + 1);
                this._newTriangleList.Add(item:  val_21 + 2);
                this._newTriangleList.Add(item:  val_21 + 3);
                this._newTriangleList.Add(item:  val_21 + 4);
                this._newTriangleList.Add(item:  val_21 + 5);
            }
            while(val_37 < 0);
            
            }
            while(val_36 < 0);
            
            }
            
            UnityEngine.Mesh val_35 = tile.MeshFilter.mesh;
            val_37 = this._newVertexList;
            if(val_35 != null)
            {
                    val_35.SetVertices(inVertices:  val_37);
                val_35.SetNormals(inNormals:  this._newNormalList);
                val_35.SetUVs(channel:  0, uvs:  this._newUvList);
                val_35.SetTriangles(triangles:  this._newTriangleList, submesh:  0);
            }
            else
            {
                    0.SetVertices(inVertices:  val_37);
                0.SetNormals(inNormals:  this._newNormalList);
                val_37 = this._newUvList;
                0.SetUVs(channel:  0, uvs:  val_37);
                val_36 = this._newTriangleList;
                0.SetTriangles(triangles:  val_36, submesh:  0);
            }
            
            val_35.RecalculateBounds();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GenerateTerrainMesh(Mapbox.Unity.MeshGeneration.Data.UnityTile tile)
        {
            var val_64;
            Mapbox.Unity.MeshGeneration.Data.MeshData val_65;
            Mapbox.Unity.MeshGeneration.Data.MeshData val_66;
            UnityEngine.Vector3 val_67;
            float val_68;
            float val_69;
            UnityEngine.Vector3 val_70;
            float val_71;
            float val_72;
            System.Collections.Generic.Dictionary<Mapbox.Map.UnwrappedTileId, UnityEngine.Mesh> val_73;
            Mapbox.Map.UnwrappedTileId val_74;
            UnityEngine.Vector2 val_75;
            var val_76;
            val_64 = tile;
            val_64.MeshFilter.mesh.GetVertices(vertices:  this._currentTileMeshData.Vertices);
            val_64.MeshFilter.mesh.GetNormals(normals:  this._currentTileMeshData.Normals);
            Mapbox.Utils.Vector2d val_64 = this._currentTileMeshData.TileRect.<Max>k__BackingField;
            val_64 = val_64 - 1;
            if(val_64 < 1)
            {
                goto label_11;
            }
            
            float val_65 = 0f;
            label_85:
            val_65 = val_65 + 1f;
            float val_7 = 1f - (val_65 / (float)val_64);
            float val_9 = 1f - (val_65 / (float)val_64);
            float val_68 = 0f;
            label_84:
            if(this._currentTileMeshData == null)
            {
                    if(this._currentTileMeshData == null)
            {
                goto label_48;
            }
            
            }
            
            float val_66 = val_65 * (float)val_64;
            val_66 = val_66 + val_68;
            int val_67 = (int)val_66;
            val_67 = val_67 + (val_67 << 1);
            float val_10 = val_67 << 1;
            UnityEngine.Vector3 val_11 = this._currentTileMeshData.Vertices.Item[val_10];
            float val_12 = val_68 / (float)val_64;
            float val_13 = val_64.QueryHeightData(x:  val_12, y:  val_7);
            UnityEngine.Vector3 val_14 = this._currentTileMeshData.Vertices.Item[val_10];
            this._currentTileMeshData.Vertices.set_Item(index:  val_10, value:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            if(this._currentTileMeshData == null)
            {
                    if(this._currentTileMeshData == null)
            {
                goto label_48;
            }
            
            }
            
            float val_15 = val_10 | 1;
            UnityEngine.Vector3 val_16 = this._currentTileMeshData.Vertices.Item[val_15];
            val_68 = val_68 + 1f;
            float val_17 = val_68 / (float)val_64;
            float val_18 = val_64.QueryHeightData(x:  val_17, y:  val_7);
            UnityEngine.Vector3 val_19 = this._currentTileMeshData.Vertices.Item[val_15];
            this._currentTileMeshData.Vertices.set_Item(index:  val_15, value:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            if(this._currentTileMeshData == null)
            {
                    if(this._currentTileMeshData == null)
            {
                goto label_48;
            }
            
            }
            
            float val_20 = val_10 + 2;
            UnityEngine.Vector3 val_21 = this._currentTileMeshData.Vertices.Item[val_20];
            float val_22 = val_64.QueryHeightData(x:  val_12, y:  val_9);
            UnityEngine.Vector3 val_23 = this._currentTileMeshData.Vertices.Item[val_20];
            this._currentTileMeshData.Vertices.set_Item(index:  val_20, value:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            if(this._currentTileMeshData == null)
            {
                    if(this._currentTileMeshData == null)
            {
                goto label_48;
            }
            
            }
            
            float val_24 = val_10 + 3;
            UnityEngine.Vector3 val_25 = this._currentTileMeshData.Vertices.Item[val_24];
            float val_26 = val_64.QueryHeightData(x:  val_17, y:  val_7);
            UnityEngine.Vector3 val_27 = this._currentTileMeshData.Vertices.Item[val_24];
            this._currentTileMeshData.Vertices.set_Item(index:  val_24, value:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            val_65 = this._currentTileMeshData;
            if(this._currentTileMeshData != null)
            {
                goto label_40;
            }
            
            val_65 = this._currentTileMeshData;
            if(val_65 == null)
            {
                goto label_48;
            }
            
            label_40:
            float val_28 = val_10 + 4;
            UnityEngine.Vector3 val_29 = this._currentTileMeshData.Vertices.Item[val_28];
            float val_30 = val_64.QueryHeightData(x:  val_17, y:  val_9);
            UnityEngine.Vector3 val_31 = this._currentTileMeshData.Vertices.Item[val_28];
            this._currentTileMeshData.Vertices.set_Item(index:  val_28, value:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            val_66 = this._currentTileMeshData;
            if(this._currentTileMeshData != null)
            {
                goto label_47;
            }
            
            val_66 = this._currentTileMeshData;
            if(val_66 == null)
            {
                goto label_48;
            }
            
            label_47:
            float val_32 = val_10 + 5;
            UnityEngine.Vector3 val_33 = this._currentTileMeshData.Vertices.Item[val_32];
            float val_34 = val_64.QueryHeightData(x:  val_12, y:  val_9);
            UnityEngine.Vector3 val_35 = this._currentTileMeshData.Vertices.Item[val_32];
            this._currentTileMeshData.Vertices.set_Item(index:  val_32, value:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            val_64 = val_64;
            UnityEngine.Vector3 val_36 = this._currentTileMeshData.Vertices.Item[val_15];
            UnityEngine.Vector3 val_37 = this._currentTileMeshData.Vertices.Item[val_10];
            UnityEngine.Vector3 val_38 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_36.x, y = val_36.y, z = val_36.z}, b:  new UnityEngine.Vector3() {x = val_37.x, y = val_37.y, z = val_37.z});
            UnityEngine.Vector3 val_39 = this._currentTileMeshData.Vertices.Item[val_20];
            UnityEngine.Vector3 val_40 = this._currentTileMeshData.Vertices.Item[val_10];
            UnityEngine.Vector3 val_41 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_39.x, y = val_39.y, z = val_39.z}, b:  new UnityEngine.Vector3() {x = val_40.x, y = val_40.y, z = val_40.z});
            UnityEngine.Vector3 val_42 = UnityEngine.Vector3.Cross(lhs:  new UnityEngine.Vector3() {x = val_38.x, y = val_38.y, z = val_38.z}, rhs:  new UnityEngine.Vector3() {x = val_41.x, y = val_41.y, z = val_41.z});
            val_67 = val_42.x;
            val_68 = val_42.y;
            val_69 = val_42.z;
            this._newDir = val_42;
            mem[1152921519757333804] = val_68;
            mem[1152921519757333808] = val_69;
            if(this._currentTileMeshData == null)
            {
                    val_67 = this._newDir;
            }
            
            this._currentTileMeshData.Normals.set_Item(index:  val_10, value:  new UnityEngine.Vector3() {x = val_67, y = val_68, z = val_69});
            this._currentTileMeshData.Normals.set_Item(index:  val_15, value:  new UnityEngine.Vector3() {x = this._newDir, y = val_68, z = val_69});
            this._currentTileMeshData.Normals.set_Item(index:  val_20, value:  new UnityEngine.Vector3() {x = this._newDir, y = val_68, z = val_69});
            UnityEngine.Vector3 val_43 = this._currentTileMeshData.Vertices.Item[val_28];
            UnityEngine.Vector3 val_44 = this._currentTileMeshData.Vertices.Item[val_24];
            UnityEngine.Vector3 val_45 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_43.x, y = val_43.y, z = val_43.z}, b:  new UnityEngine.Vector3() {x = val_44.x, y = val_44.y, z = val_44.z});
            UnityEngine.Vector3 val_46 = this._currentTileMeshData.Vertices.Item[val_32];
            UnityEngine.Vector3 val_47 = this._currentTileMeshData.Vertices.Item[val_24];
            UnityEngine.Vector3 val_48 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_46.x, y = val_46.y, z = val_46.z}, b:  new UnityEngine.Vector3() {x = val_47.x, y = val_47.y, z = val_47.z});
            UnityEngine.Vector3 val_49 = UnityEngine.Vector3.Cross(lhs:  new UnityEngine.Vector3() {x = val_45.x, y = val_45.y, z = val_45.z}, rhs:  new UnityEngine.Vector3() {x = val_48.x, y = val_48.y, z = val_48.z});
            val_70 = val_49.x;
            val_71 = val_49.y;
            val_72 = val_49.z;
            this._newDir = val_49;
            mem[1152921519757333804] = val_71;
            mem[1152921519757333808] = val_72;
            if(this._currentTileMeshData == null)
            {
                    val_70 = this._newDir;
            }
            
            this._currentTileMeshData.Normals.set_Item(index:  val_24, value:  new UnityEngine.Vector3() {x = val_70, y = val_71, z = val_72});
            this._currentTileMeshData.Normals.set_Item(index:  val_28, value:  new UnityEngine.Vector3() {x = this._newDir, y = val_71, z = val_72});
            this._currentTileMeshData.Normals.set_Item(index:  val_32, value:  new UnityEngine.Vector3() {x = this._newDir, y = val_71, z = val_72});
            if(val_68 < 0)
            {
                goto label_84;
            }
            
            if(val_65 < 0)
            {
                goto label_85;
            }
            
            label_11:
            this.FixStitches(tileId:  new Mapbox.Map.UnwrappedTileId() {Z = tile.<UnwrappedTileId>k__BackingField, X = tile.<UnwrappedTileId>k__BackingField, Y = 1233037568}, mesh:  this._currentTileMeshData);
            val_64.MeshFilter.mesh.SetVertices(inVertices:  this._currentTileMeshData.Vertices);
            val_64.MeshFilter.mesh.SetNormals(inNormals:  this._currentTileMeshData.Normals);
            val_64.MeshFilter.mesh.RecalculateBounds();
            val_73 = this._meshData;
            val_74 = tile.<UnwrappedTileId>k__BackingField;
            if((val_73.ContainsKey(key:  new Mapbox.Map.UnwrappedTileId() {Z = val_74, X = val_74, Y = this._currentTileMeshData.Normals})) != true)
            {
                    val_74 = this._meshData;
                val_74.Add(key:  new Mapbox.Map.UnwrappedTileId() {Z = tile.<UnwrappedTileId>k__BackingField, X = tile.<UnwrappedTileId>k__BackingField, Y = val_73}, value:  val_64.MeshFilter.mesh);
            }
            
            val_75 = this._currentTileMeshData.MercatorCenter;
            if((mem[this._currentTileMeshData.MercatorCenter + 16]) == 0)
            {
                    return;
            }
            
            UnityEngine.Collider val_59 = val_64.Collider;
            val_76 = 0;
            if((UnityEngine.Object.op_Implicit(exists:  null)) == false)
            {
                    return;
            }
            
            val_75 = val_64.MeshFilter.mesh;
            sharedMesh = val_75;
            return;
            label_48:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ResetToFlatMesh(Mapbox.Unity.MeshGeneration.Data.UnityTile tile)
        {
            Mapbox.Unity.MeshGeneration.Data.MeshData val_12;
            var val_13;
            tile.MeshFilter.mesh.GetVertices(vertices:  this._currentTileMeshData.Vertices);
            tile.MeshFilter.mesh.GetNormals(normals:  this._currentTileMeshData.Normals);
            int val_5 = this._currentTileMeshData.Vertices.Count;
            this._counter = val_5;
            if(val_5 < 1)
            {
                goto label_11;
            }
            
            var val_12 = 0;
            label_22:
            val_12 = this._currentTileMeshData;
            if(this._currentTileMeshData != null)
            {
                goto label_12;
            }
            
            val_12 = this._currentTileMeshData;
            if(val_12 == null)
            {
                goto label_13;
            }
            
            label_12:
            UnityEngine.Vector3 val_6 = this._currentTileMeshData.Vertices.Item[0];
            UnityEngine.Vector3 val_7 = this._currentTileMeshData.Vertices.Item[0];
            this._currentTileMeshData.Vertices.set_Item(index:  0, value:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            val_13 = null;
            val_13 = null;
            this._currentTileMeshData.Normals.set_Item(index:  0, value:  new UnityEngine.Vector3() {x = Constants.Math.Vector3Up, y = Constants.Math.Vector3Zero.__il2cppRuntimeField_10, z = Constants.Math.Vector3Zero.__il2cppRuntimeField_14});
            val_12 = val_12 + 1;
            if(val_12 < this._counter)
            {
                goto label_22;
            }
            
            label_11:
            tile.MeshFilter.mesh.SetVertices(inVertices:  this._currentTileMeshData.Vertices);
            tile.MeshFilter.mesh.SetNormals(inNormals:  this._currentTileMeshData.Normals);
            return;
            label_13:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void FixStitches(Mapbox.Map.UnwrappedTileId tileId, Mapbox.Unity.MeshGeneration.Data.MeshData mesh)
        {
            System.Collections.Generic.List<UnityEngine.Vector3> val_112;
            var val_113;
            System.Collections.Generic.List<UnityEngine.Vector3> val_114;
            float val_115;
            float val_116;
            System.Collections.Generic.List<UnityEngine.Vector3> val_117;
            var val_118;
            UnityEngine.Object val_119;
            val_112 = mesh;
            this._stitchTarget = 0;
            bool val_2 = this._meshData.TryGetValue(key:  new Mapbox.Map.UnwrappedTileId() {Z = -2028044176, X = 268435459}, value: out  this._stitchTarget);
            var val_3 = W9 - 1;
            if(this._stitchTarget != 0)
            {
                    this._stitchTarget.GetVertices(vertices:  this._stitchTargetMeshData.Vertices);
                this._stitchTarget.GetNormals(normals:  this._stitchTargetMeshData.Normals);
                if(val_3 >= 1)
            {
                    var val_116 = ???;
                var val_117 = val_3;
                val_116 = val_116 - 2;
                val_116 = val_117 * val_116;
                val_116 = val_116 + (val_116 << 1);
                var val_5 = val_116 << 1;
                do
            {
                UnityEngine.Vector3 val_6 = mesh.Vertices.Item[0];
                val_116 = val_5 + 0;
                UnityEngine.Vector3 val_8 = this._stitchTargetMeshData.Vertices.Item[val_116 + 2];
                UnityEngine.Vector3 val_9 = mesh.Vertices.Item[0];
                mesh.Vertices.set_Item(index:  0, value:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                UnityEngine.Vector3 val_10 = mesh.Vertices.Item[1];
                int val_12 = (val_5 + 0) + 4;
                UnityEngine.Vector3 val_13 = this._stitchTargetMeshData.Vertices.Item[val_12];
                UnityEngine.Vector3 val_14 = mesh.Vertices.Item[1];
                mesh.Vertices.set_Item(index:  1, value:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                UnityEngine.Vector3 val_15 = mesh.Vertices.Item[3];
                val_113 = val_15.x;
                val_114 = this._stitchTargetMeshData.Vertices;
                UnityEngine.Vector3 val_16 = val_114.Item[val_12];
                UnityEngine.Vector3 val_17 = mesh.Vertices.Item[3];
                val_115 = 0f;
                val_116 = 0f;
                mesh.Vertices.set_Item(index:  3, value:  new UnityEngine.Vector3() {x = val_115, y = val_116, z = 0f});
                val_117 = val_117 - 1;
            }
            while(val_117 != 0);
            
            }
            
            }
            
            this._stitchTarget = 0;
            bool val_19 = this._meshData.TryGetValue(key:  new Mapbox.Map.UnwrappedTileId() {Z = -2028044176, X = 268435459}, value: out  this._stitchTarget);
            if(1179403647 != 0)
            {
                    this._stitchTarget.GetVertices(vertices:  this._stitchTargetMeshData.Vertices);
                this._stitchTarget.GetNormals(normals:  this._stitchTargetMeshData.Normals);
                if(val_3 >= 1)
            {
                    var val_118 = ???;
                val_118 = val_118 - 2;
                val_114 = 1152921518724786432;
                val_118 = val_3 * val_118;
                val_118 = val_118 + (val_118 << 1);
                var val_21 = val_118 << 1;
                var val_119 = val_3;
                do
            {
                val_118 = val_21 + 0;
                int val_22 = val_118 + 2;
                UnityEngine.Vector3 val_23 = mesh.Vertices.Item[val_22];
                UnityEngine.Vector3 val_24 = this._stitchTargetMeshData.Vertices.Item[0];
                UnityEngine.Vector3 val_25 = mesh.Vertices.Item[val_22];
                mesh.Vertices.set_Item(index:  val_22, value:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                int val_27 = (val_21 + 0) + 5;
                UnityEngine.Vector3 val_28 = mesh.Vertices.Item[val_27];
                UnityEngine.Vector3 val_29 = this._stitchTargetMeshData.Vertices.Item[0];
                UnityEngine.Vector3 val_30 = mesh.Vertices.Item[val_27];
                mesh.Vertices.set_Item(index:  val_27, value:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                int val_32 = (val_21 + 0) + 4;
                UnityEngine.Vector3 val_33 = mesh.Vertices.Item[val_32];
                val_113 = val_33.x;
                UnityEngine.Vector3 val_34 = this._stitchTargetMeshData.Vertices.Item[3];
                UnityEngine.Vector3 val_35 = mesh.Vertices.Item[val_32];
                val_115 = 0f;
                val_116 = 0f;
                mesh.Vertices.set_Item(index:  val_32, value:  new UnityEngine.Vector3() {x = val_115, y = val_116, z = 0f});
                val_119 = val_119 - 1;
            }
            while(val_119 != 0);
            
            }
            
            }
            
            this._stitchTarget = 0;
            bool val_37 = this._meshData.TryGetValue(key:  new Mapbox.Map.UnwrappedTileId() {Z = -2028044176, X = 268435459}, value: out  this._stitchTarget);
            if(1179403647 != 0)
            {
                    this._stitchTarget.GetVertices(vertices:  this._stitchTargetMeshData.Vertices);
                this._stitchTarget.GetNormals(normals:  this._stitchTargetMeshData.Normals);
                if(val_3 >= 1)
            {
                    var val_122 = val_3;
                var val_39 = val_122 + (val_122 << 1);
                val_39 = val_39 << 1;
                val_39 = val_39 + 6;
                do
            {
                UnityEngine.Vector3 val_40 = mesh.Vertices.Item[0];
                var val_120 = val_39;
                val_120 = val_120 + 5;
                UnityEngine.Vector3 val_42 = this._stitchTargetMeshData.Vertices.Item[val_120 - 16];
                UnityEngine.Vector3 val_43 = mesh.Vertices.Item[0];
                mesh.Vertices.set_Item(index:  0, value:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                UnityEngine.Vector3 val_44 = mesh.Vertices.Item[2];
                var val_121 = val_39;
                val_121 = val_121 + 5;
                int val_45 = val_121 - 13;
                UnityEngine.Vector3 val_46 = this._stitchTargetMeshData.Vertices.Item[val_45];
                val_114 = mesh.Vertices;
                UnityEngine.Vector3 val_47 = val_114.Item[2];
                mesh.Vertices.set_Item(index:  2, value:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                UnityEngine.Vector3 val_48 = mesh.Vertices.Item[5];
                val_113 = val_48.x;
                UnityEngine.Vector3 val_49 = this._stitchTargetMeshData.Vertices.Item[val_45];
                UnityEngine.Vector3 val_50 = mesh.Vertices.Item[5];
                val_115 = 0f;
                val_116 = 0f;
                mesh.Vertices.set_Item(index:  5, value:  new UnityEngine.Vector3() {x = val_115, y = val_116, z = 0f});
                val_122 = val_122 - 1;
                var val_51 = 5 + val_39;
            }
            while(val_122 != 0);
            
            }
            
            }
            
            this._stitchTarget = 0;
            bool val_53 = this._meshData.TryGetValue(key:  new Mapbox.Map.UnwrappedTileId() {Z = -2028044176, X = 268435459}, value: out  this._stitchTarget);
            if(1179403647 != 0)
            {
                    this._stitchTarget.GetVertices(vertices:  this._stitchTargetMeshData.Vertices);
                this._stitchTarget.GetNormals(normals:  this._stitchTargetMeshData.Normals);
                if(val_3 >= 1)
            {
                    var val_123 = val_3;
                var val_55 = val_123 + (val_123 << 1);
                val_55 = val_55 << 1;
                var val_56 = val_55 + 6;
                do
            {
                val_55 = val_56 + 5;
                int val_57 = val_55 - 16;
                UnityEngine.Vector3 val_58 = mesh.Vertices.Item[val_57];
                UnityEngine.Vector3 val_59 = this._stitchTargetMeshData.Vertices.Item[0];
                UnityEngine.Vector3 val_60 = mesh.Vertices.Item[val_57];
                mesh.Vertices.set_Item(index:  val_57, value:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                int val_62 = (val_56 + 5) - 14;
                UnityEngine.Vector3 val_63 = mesh.Vertices.Item[val_62];
                val_114 = this._stitchTargetMeshData.Vertices;
                UnityEngine.Vector3 val_64 = val_114.Item[0];
                UnityEngine.Vector3 val_65 = mesh.Vertices.Item[val_62];
                mesh.Vertices.set_Item(index:  val_62, value:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                int val_67 = (val_56 + 5) - 13;
                UnityEngine.Vector3 val_68 = mesh.Vertices.Item[val_67];
                val_113 = val_68.x;
                UnityEngine.Vector3 val_69 = this._stitchTargetMeshData.Vertices.Item[5];
                UnityEngine.Vector3 val_70 = mesh.Vertices.Item[val_67];
                val_115 = 0f;
                val_116 = 0f;
                mesh.Vertices.set_Item(index:  val_67, value:  new UnityEngine.Vector3() {x = val_115, y = val_116, z = 0f});
                val_123 = val_123 - 1;
                var val_71 = 5 + val_55;
            }
            while(val_123 != 0);
            
            }
            
            }
            
            this._stitchTarget = 0;
            val_117 = 0;
            bool val_74 = this._meshData.TryGetValue(key:  new Mapbox.Map.UnwrappedTileId() {Z = -2028044176, X = 268435459, Y = val_117 & 4294967295}, value: out  this._stitchTarget);
            if(1179403647 != 0)
            {
                    this._stitchTarget.GetVertices(vertices:  this._stitchTargetMeshData.Vertices);
                this._stitchTarget.GetNormals(normals:  this._stitchTargetMeshData.Normals);
                UnityEngine.Vector3 val_76 = mesh.Vertices.Item[0];
                val_113 = val_76.x;
                UnityEngine.Vector3 val_78 = this._stitchTargetMeshData.Vertices.Item[mesh.Vertices.Count - 2];
                UnityEngine.Vector3 val_79 = mesh.Vertices.Item[0];
                val_115 = 0f;
                val_116 = 0f;
                mesh.Vertices.set_Item(index:  0, value:  new UnityEngine.Vector3() {x = val_115, y = val_116, z = 0f});
            }
            
            this._stitchTarget = 0;
            bool val_82 = this._meshData.TryGetValue(key:  new Mapbox.Map.UnwrappedTileId() {Z = -2028044176, X = 268435459, Y = 0 & 4294967295}, value: out  this._stitchTarget);
            if(1179403647 != 0)
            {
                    this._stitchTarget.GetVertices(vertices:  this._stitchTargetMeshData.Vertices);
                this._stitchTarget.GetNormals(normals:  this._stitchTargetMeshData.Normals);
                var val_124 = val_3;
                val_124 = val_124 + (val_124 << 1);
                var val_84 = val_124 << 1;
                int val_85 = val_84 - 5;
                UnityEngine.Vector3 val_86 = mesh.Vertices.Item[val_85];
                var val_125 = 6;
                val_125 = (???) * val_125;
                val_125 = val_125 - 12;
                int val_87 = 2 + (val_125 * val_3);
                UnityEngine.Vector3 val_88 = this._stitchTargetMeshData.Vertices.Item[val_87];
                UnityEngine.Vector3 val_89 = mesh.Vertices.Item[val_85];
                val_114 = 1152921518724786432;
                mesh.Vertices.set_Item(index:  val_85, value:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                int val_90 = val_84 - 3;
                UnityEngine.Vector3 val_91 = mesh.Vertices.Item[val_90];
                val_113 = val_91.x;
                val_117 = this._stitchTargetMeshData.Vertices;
                UnityEngine.Vector3 val_92 = val_117.Item[val_87];
                UnityEngine.Vector3 val_93 = mesh.Vertices.Item[val_90];
                val_115 = 0f;
                val_116 = 0f;
                mesh.Vertices.set_Item(index:  val_90, value:  new UnityEngine.Vector3() {x = val_115, y = val_116, z = 0f});
            }
            
            this._stitchTarget = 0;
            bool val_96 = this._meshData.TryGetValue(key:  new Mapbox.Map.UnwrappedTileId() {Z = -2028044176, X = 268435459, Y = 0 & 4294967295}, value: out  this._stitchTarget);
            if(1179403647 != 0)
            {
                    this._stitchTarget.GetVertices(vertices:  this._stitchTargetMeshData.Vertices);
                this._stitchTarget.GetNormals(normals:  this._stitchTargetMeshData.Normals);
                var val_126 = 6;
                val_126 = (???) * val_126;
                val_126 = val_126 - 12;
                var val_98 = val_126 * val_3;
                int val_99 = val_98 + 2;
                UnityEngine.Vector3 val_100 = mesh.Vertices.Item[val_99];
                var val_127 = 6;
                val_127 = val_3 * val_127;
                int val_101 = val_127 - 5;
                UnityEngine.Vector3 val_102 = this._stitchTargetMeshData.Vertices.Item[val_101];
                UnityEngine.Vector3 val_103 = mesh.Vertices.Item[val_99];
                val_114 = 1152921518724786432;
                mesh.Vertices.set_Item(index:  val_99, value:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                int val_104 = val_98 + 5;
                UnityEngine.Vector3 val_105 = mesh.Vertices.Item[val_104];
                val_113 = val_105.x;
                val_117 = this._stitchTargetMeshData.Vertices;
                UnityEngine.Vector3 val_106 = val_117.Item[val_101];
                UnityEngine.Vector3 val_107 = mesh.Vertices.Item[val_104];
                val_115 = 0f;
                val_116 = 0f;
                mesh.Vertices.set_Item(index:  val_104, value:  new UnityEngine.Vector3() {x = val_115, y = val_116, z = 0f});
            }
            
            this._stitchTarget = 0;
            val_118;
            bool val_110 = this._meshData.TryGetValue(key:  new Mapbox.Map.UnwrappedTileId() {Z = -2028044176, X = 268435459, Y = 0 & 4294967295}, value: out  this._stitchTarget);
            val_119 = 1179403647;
            if(val_119 == 0)
            {
                    return;
            }
            
            this._stitchTarget.GetVertices(vertices:  this._stitchTargetMeshData.Vertices);
            this._stitchTarget.GetNormals(normals:  this._stitchTargetMeshData.Normals);
            val_119 = mesh.Vertices;
            var val_128 = val_3;
            val_118 = 1152921518725068768;
            val_128 = val_128 * val_128;
            val_128 = val_128 * 6;
            int val_112 = val_128 - 2;
            UnityEngine.Vector3 val_113 = val_119.Item[val_112];
            val_113 = val_113.x;
            UnityEngine.Vector3 val_114 = this._stitchTargetMeshData.Vertices.Item[0];
            val_112 = mesh.Vertices;
            UnityEngine.Vector3 val_115 = val_112.Item[val_112];
            val_119.set_Item(index:  val_112, value:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LowPolyTerrainStrategy()
        {
        
        }
    
    }

}
