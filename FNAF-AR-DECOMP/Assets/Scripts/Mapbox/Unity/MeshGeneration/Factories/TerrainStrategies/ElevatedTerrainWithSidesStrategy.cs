using UnityEngine;

namespace Mapbox.Unity.MeshGeneration.Factories.TerrainStrategies
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ElevatedTerrainWithSidesStrategy : TerrainStrategy, IElevationBasedTerrainStrategy
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Mesh _stitchTarget;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected System.Collections.Generic.Dictionary<Mapbox.Map.UnwrappedTileId, UnityEngine.Mesh> _meshData;
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
            mem[1152921519750505376] = elOptions;
            this._meshData = new System.Collections.Generic.Dictionary<Mapbox.Map.UnwrappedTileId, UnityEngine.Mesh>();
            this._currentTileMeshData = new Mapbox.Unity.MeshGeneration.Data.MeshData();
            this._stitchTargetMeshData = new Mapbox.Unity.MeshGeneration.Data.MeshData();
            this._newVertexList = new System.Collections.Generic.List<UnityEngine.Vector3>(capacity:  -1722883072);
            this._newNormalList = new System.Collections.Generic.List<UnityEngine.Vector3>(capacity:  -1722883072);
            this._newUvList = new System.Collections.Generic.List<UnityEngine.Vector2>(capacity:  -1722883072);
            this._newTriangleList = new System.Collections.Generic.List<System.Int32>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void RegisterTile(Mapbox.Unity.MeshGeneration.Data.UnityTile tile)
        {
            UnityEngine.Object val_15;
            if((mem[69738552] + 16) != 0)
            {
                    if(tile.gameObject.layer != (X22 + 56 + 20))
            {
                    tile.gameObject.layer = X22 + 56 + 56 + 20;
            }
            
            }
            
            if((tile._rasterDataState != 3) && (tile._rasterDataState != 0))
            {
                    UnityEngine.Material val_15 = tile.MeshRenderer.materials[0];
                UnityEngine.Material[] val_7 = new UnityEngine.Material[2];
                val_7[0] = val_15;
                val_7[1] = val_15;
                tile.MeshRenderer.materials = val_7;
            }
            
            if(tile.MeshFilter.mesh.vertexCount == 0)
            {
                    this.CreateBaseMesh(tile:  tile);
            }
            
            if(val_7.Length != 0)
            {
                    val_15 = tile.Collider;
                if(val_15 == 0)
            {
                    val_15 = tile.gameObject;
                UnityEngine.MeshCollider val_14 = val_15.AddComponent<UnityEngine.MeshCollider>();
            }
            
            }
            
            this.GenerateTerrainMesh(tile:  tile);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CreateBaseMesh(Mapbox.Unity.MeshGeneration.Data.UnityTile tile)
        {
            System.Collections.Generic.List<System.Int32> val_97;
            var val_98;
            float val_99;
            float val_100;
            int val_101;
            var val_102;
            float val_105;
            float val_108;
            var val_109;
            int val_110;
            val_97 = this;
            this._newVertexList.Clear();
            this._newNormalList.Clear();
            this._newUvList.Clear();
            this._newTriangleList.Clear();
            if()
            {
                    val_98 = 1152921518605502048;
                do
            {
                float val_92 = 6.950001E+07f;
                float val_96 = 0f;
                val_92 = 0f / val_92;
                do
            {
                val_99 = val_96 / (6.950001E+07f);
                Mapbox.Utils.Vector2d val_2 = tile.<Rect>k__BackingField.<Min>k__BackingField.Min;
                Mapbox.Utils.Vector2d val_3 = tile.<Rect>k__BackingField.<Min>k__BackingField.Min;
                Mapbox.Utils.Vector2d val_5 = tile.<Rect>k__BackingField.<Min>k__BackingField.Min;
                Mapbox.Utils.Vector2d val_6 = tile.<Rect>k__BackingField.<Min>k__BackingField.Min;
                double val_93 = (double)val_92;
                Mapbox.Utils.Vector2d val_8 = tile.<Rect>k__BackingField.<Min>k__BackingField.Size;
                if(tile != null)
            {
                
            }
            
                Mapbox.Utils.Vector2d val_9 = tile.<Rect>k__BackingField.<Min>k__BackingField.Size;
                val_93 = (Mapbox.Utils.Mathd.Lerp(from:  val_5.y, to:  val_6.y, t:  val_93)) - val_9.y;
                float val_94 = (float)(Mapbox.Utils.Mathd.Lerp(from:  val_2.x, to:  val_3.x, t:  (double)val_99)) - val_8.x;
                float val_95 = (float)val_93;
                val_94 = (tile.<TileScale>k__BackingField) * val_94;
                val_95 = (tile.<TileScale>k__BackingField) * val_95;
                this._newVertexList.Add(item:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                val_100 = 1f;
                this._newNormalList.Add(item:  new UnityEngine.Vector3() {x = Constants.Math.Vector3Up, y = Constants.Math.Vector3Zero.__il2cppRuntimeField_10, z = Constants.Math.Vector3Zero.__il2cppRuntimeField_14});
                UnityEngine.Vector2 val_11 = new UnityEngine.Vector2(x:  val_99, y:  1f - val_92);
                this._newUvList.Add(item:  new UnityEngine.Vector2() {x = val_11.x, y = val_11.y});
                val_96 = val_96 + val_100;
            }
            while(val_96 < 0);
            
                float val_97 = 0f;
                val_97 = val_97 + val_100;
            }
            while(val_97 < 0);
            
            }
            
            if(69500007 >= 1)
            {
                    do
            {
                val_101 = 69500008;
                do
            {
                this._newTriangleList.Add(item:  0);
                this._newTriangleList.Add(item:  69500009);
                this._newTriangleList.Add(item:  1152921517710588640);
                val_98 = 1;
                this._newTriangleList.Add(item:  0);
                this._newTriangleList.Add(item:  1);
                this._newTriangleList.Add(item:  69500009);
                val_102 = 1;
            }
            while(69500007 != val_102);
            
            }
            while(1 != 69500007);
            
            }
            
            int val_12 = this._newVertexList.Count;
            System.Collections.Generic.List<System.Int32> val_13 = new System.Collections.Generic.List<System.Int32>();
            if(1152921517710588640 >= 1)
            {
                    val_100 = 1f;
                int val_14 = val_12 + 7;
                do
            {
                UnityEngine.Vector3 val_15 = this._newVertexList.Item[0];
                this._newVertexList.Add(item:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
                UnityEngine.Vector3 val_16 = this._newVertexList.Item[0];
                UnityEngine.Vector3 val_17 = this._newVertexList.Item[0];
                this._newVertexList.Add(item:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                this._newNormalList.Add(item:  new UnityEngine.Vector3() {x = Constants.Math.Vector3Forward, y = Constants.Math.Vector3Zero.__il2cppRuntimeField_34, z = Constants.Math.Vector3Zero.__il2cppRuntimeField_38});
                this._newNormalList.Add(item:  new UnityEngine.Vector3() {x = Constants.Math.Vector3Forward, y = Constants.Math.Vector3Zero.__il2cppRuntimeField_34, z = Constants.Math.Vector3Zero.__il2cppRuntimeField_38});
                val_101 = 1;
                UnityEngine.Vector2 val_18 = this._newUvList.Item[1];
                UnityEngine.Vector2 val_19 = new UnityEngine.Vector2(x:  val_18.y, y:  val_100);
                this._newUvList.Add(item:  new UnityEngine.Vector2() {x = val_19.x, y = val_19.y});
                if(this._newUvList != null)
            {
                    UnityEngine.Vector2 val_20 = this._newUvList.Item[1];
                UnityEngine.Vector2 val_21 = new UnityEngine.Vector2(x:  val_20.y, y:  0f);
            }
            else
            {
                    UnityEngine.Vector2 val_22 = 0.Item[1];
                UnityEngine.Vector2 val_23 = new UnityEngine.Vector2(x:  val_22.y, y:  0f);
            }
            
                this._newUvList.Add(item:  new UnityEngine.Vector2() {x = val_23.x, y = val_23.y});
                UnityEngine.Vector3 val_24 = this._newVertexList.Item[1];
                this._newVertexList.Add(item:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z});
                UnityEngine.Vector3 val_25 = this._newVertexList.Item[1];
                UnityEngine.Vector3 val_26 = this._newVertexList.Item[1];
                this._newVertexList.Add(item:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                UnityEngine.Vector3 val_27 = UnityEngine.Vector3.left;
                this._newNormalList.Add(item:  new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z});
                UnityEngine.Vector3 val_28 = UnityEngine.Vector3.left;
                this._newNormalList.Add(item:  new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z});
                if(this._newUvList != null)
            {
                    UnityEngine.Vector2 val_29 = this._newUvList.Item[1];
                UnityEngine.Vector2 val_30 = new UnityEngine.Vector2(x:  val_29.y, y:  val_100);
            }
            else
            {
                    UnityEngine.Vector2 val_31 = 0.Item[1];
                UnityEngine.Vector2 val_32 = new UnityEngine.Vector2(x:  val_31.y, y:  val_100);
            }
            
                this._newUvList.Add(item:  new UnityEngine.Vector2() {x = val_32.x, y = val_32.y});
                if(this._newUvList != null)
            {
                    UnityEngine.Vector2 val_33 = this._newUvList.Item[1];
                UnityEngine.Vector2 val_34 = new UnityEngine.Vector2(x:  val_33.y, y:  0f);
            }
            else
            {
                    UnityEngine.Vector2 val_35 = 0.Item[1];
                UnityEngine.Vector2 val_36 = new UnityEngine.Vector2(x:  val_35.y, y:  0f);
            }
            
                this._newUvList.Add(item:  new UnityEngine.Vector2() {x = val_36.x, y = val_36.y});
                UnityEngine.Vector3 val_37 = this._newVertexList.Item[1152921517710588640];
                this._newVertexList.Add(item:  new UnityEngine.Vector3() {x = val_37.x, y = val_37.y, z = val_37.z});
                UnityEngine.Vector3 val_38 = this._newVertexList.Item[1152921517710588640];
                UnityEngine.Vector3 val_39 = this._newVertexList.Item[1152921517710588640];
                this._newVertexList.Add(item:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                UnityEngine.Vector3 val_40 = UnityEngine.Vector3.right;
                this._newNormalList.Add(item:  new UnityEngine.Vector3() {x = val_40.x, y = val_40.y, z = val_40.z});
                UnityEngine.Vector3 val_41 = UnityEngine.Vector3.right;
                this._newNormalList.Add(item:  new UnityEngine.Vector3() {x = val_41.x, y = val_41.y, z = val_41.z});
                if(this._newUvList != null)
            {
                    UnityEngine.Vector2 val_42 = this._newUvList.Item[1];
                UnityEngine.Vector2 val_43 = new UnityEngine.Vector2(x:  val_42.y, y:  val_100);
            }
            else
            {
                    UnityEngine.Vector2 val_44 = 0.Item[1];
                UnityEngine.Vector2 val_45 = new UnityEngine.Vector2(x:  val_44.y, y:  val_100);
            }
            
                this._newUvList.Add(item:  new UnityEngine.Vector2() {x = val_45.x, y = val_45.y});
                if(this._newUvList != null)
            {
                    UnityEngine.Vector2 val_46 = this._newUvList.Item[1];
                UnityEngine.Vector2 val_47 = new UnityEngine.Vector2(x:  val_46.y, y:  0f);
            }
            else
            {
                    UnityEngine.Vector2 val_48 = 0.Item[1];
                UnityEngine.Vector2 val_49 = new UnityEngine.Vector2(x:  val_48.y, y:  0f);
            }
            
                this._newUvList.Add(item:  new UnityEngine.Vector2() {x = val_49.x, y = val_49.y});
                UnityEngine.Vector3 val_50 = this._newVertexList.Item[1972399576];
                this._newVertexList.Add(item:  new UnityEngine.Vector3() {x = val_50.x, y = val_50.y, z = val_50.z});
                UnityEngine.Vector3 val_51 = this._newVertexList.Item[1972399576];
                UnityEngine.Vector3 val_52 = this._newVertexList.Item[1972399576];
                this._newVertexList.Add(item:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                UnityEngine.Vector3 val_53 = UnityEngine.Vector3.back;
                var val_98 = 0;
                this._newNormalList.Add(item:  new UnityEngine.Vector3() {x = val_53.x, y = val_53.y, z = val_53.z});
                UnityEngine.Vector3 val_54 = UnityEngine.Vector3.back;
                val_99 = val_54.y;
                this._newNormalList.Add(item:  new UnityEngine.Vector3() {x = val_54.x, y = val_99, z = val_54.z});
                if(this._newUvList != null)
            {
                    UnityEngine.Vector2 val_55 = this._newUvList.Item[1];
                val_105 = val_100;
                UnityEngine.Vector2 val_56 = new UnityEngine.Vector2(x:  val_55.y, y:  val_105);
            }
            else
            {
                    UnityEngine.Vector2 val_57 = 0.Item[1];
                val_105 = val_100;
                UnityEngine.Vector2 val_58 = new UnityEngine.Vector2(x:  val_57.y, y:  val_105);
            }
            
                this._newUvList.Add(item:  new UnityEngine.Vector2() {x = val_58.x, y = val_58.y});
                if(this._newUvList != null)
            {
                    UnityEngine.Vector2 val_59 = this._newUvList.Item[1];
                val_108 = 0f;
                UnityEngine.Vector2 val_60 = new UnityEngine.Vector2(x:  val_59.y, y:  val_108);
            }
            else
            {
                    UnityEngine.Vector2 val_61 = 0.Item[1];
                val_108 = 0f;
                UnityEngine.Vector2 val_62 = new UnityEngine.Vector2(x:  val_61.y, y:  val_108);
            }
            
                val_102 = 0 + 1;
                this._newUvList.Add(item:  new UnityEngine.Vector2() {x = val_62.x, y = val_62.y});
                val_109 = 1152921517654936784;
                if(0 > 0)
            {
                    int val_63 = val_14 - 7;
                val_13.Add(item:  val_63);
                if(val_13 != null)
            {
                    val_13.Add(item:  val_14 - 15);
                int val_66 = val_14 - 14;
                val_13.Add(item:  val_66);
                val_13.Add(item:  val_63);
                val_13.Add(item:  val_66);
                val_13.Add(item:  val_14 - 6);
                int val_68 = val_14 - 5;
                val_13.Add(item:  val_68);
                int val_69 = val_14 - 12;
                val_13.Add(item:  val_69);
                val_13.Add(item:  val_14 - 13);
                val_13.Add(item:  val_68);
                val_13.Add(item:  val_14 - 4);
                val_13.Add(item:  val_69);
                int val_72 = val_14 - 3;
                val_13.Add(item:  val_72);
                val_13.Add(item:  val_14 - 11);
                int val_74 = val_14 - 10;
                val_13.Add(item:  val_74);
                val_13.Add(item:  val_72);
                val_13.Add(item:  val_74);
                val_13.Add(item:  val_14 - 2);
                val_101 = val_14 - 1;
                val_13.Add(item:  val_101);
                val_110 = (val_12 + 0) - 1;
                val_109 = 1152921517654936784;
                val_13.Add(item:  val_14 - 8);
                val_13.Add(item:  val_14 - 9);
                val_13.Add(item:  val_101);
                val_13.Add(item:  val_14);
            }
            else
            {
                    val_13.Add(item:  val_14 - 15);
                int val_79 = val_14 - 14;
                val_13.Add(item:  val_79);
                val_13.Add(item:  val_63);
                val_13.Add(item:  val_79);
                val_13.Add(item:  val_14 - 6);
                int val_81 = val_14 - 5;
                val_13.Add(item:  val_81);
                int val_82 = val_14 - 12;
                val_13.Add(item:  val_82);
                val_13.Add(item:  val_14 - 13);
                val_13.Add(item:  val_81);
                val_13.Add(item:  val_14 - 4);
                val_13.Add(item:  val_82);
                int val_85 = val_14 - 3;
                val_13.Add(item:  val_85);
                val_13.Add(item:  val_14 - 11);
                int val_87 = val_14 - 10;
                val_13.Add(item:  val_87);
                val_13.Add(item:  val_85);
                val_13.Add(item:  val_87);
                val_13.Add(item:  val_14 - 2);
                val_101 = val_14 - 1;
                val_13.Add(item:  val_101);
                val_110 = val_14 - 8;
                val_13.Add(item:  val_110);
                val_13.Add(item:  val_14 - 9);
                val_13.Add(item:  val_101);
                val_13.Add(item:  val_14);
            }
            
                val_13.Add(item:  val_110);
            }
            
                val_98 = val_98 + 1152921517710588640;
                val_98 = val_14 + 8;
            }
            while(1152921517710588640 != val_102);
            
            }
            
            UnityEngine.Mesh val_91 = tile.MeshFilter.mesh;
            if(val_91 != null)
            {
                    val_91.SetVertices(inVertices:  this._newVertexList);
                val_91.SetNormals(inNormals:  this._newNormalList);
                val_91.SetUVs(channel:  0, uvs:  this._newUvList);
                val_91.subMeshCount = 2;
                val_91.SetTriangles(triangles:  this._newTriangleList, submesh:  0);
            }
            else
            {
                    0.SetVertices(inVertices:  this._newVertexList);
                0.SetNormals(inNormals:  this._newNormalList);
                0.SetUVs(channel:  0, uvs:  this._newUvList);
                0.subMeshCount = 2;
                val_97 = this._newTriangleList;
                0.SetTriangles(triangles:  val_97, submesh:  0);
            }
            
            val_91.SetTriangles(triangles:  val_13, submesh:  1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void UnregisterTile(Mapbox.Unity.MeshGeneration.Data.UnityTile tile)
        {
            bool val_1 = this._meshData.Remove(key:  new Mapbox.Map.UnwrappedTileId() {Z = tile.<UnwrappedTileId>k__BackingField, X = tile.<UnwrappedTileId>k__BackingField, Y = tile});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GenerateTerrainMesh(Mapbox.Unity.MeshGeneration.Data.UnityTile tile)
        {
            Mapbox.Unity.MeshGeneration.Data.UnityTile val_59;
            float val_60;
            float val_61;
            float val_62;
            float val_63;
            float val_64;
            float val_65;
            int val_66;
            int val_67;
            System.Collections.Generic.Dictionary<Mapbox.Map.UnwrappedTileId, UnityEngine.Mesh> val_68;
            int val_69;
            UnityEngine.Vector2 val_70;
            var val_71;
            val_59 = tile;
            val_59.MeshFilter.mesh.GetVertices(vertices:  this._currentTileMeshData.Vertices);
            val_59.MeshFilter.mesh.GetNormals(normals:  this._currentTileMeshData.Normals);
            Mapbox.Utils.Vector2d val_60 = this._currentTileMeshData.TileRect.<Max>k__BackingField;
            val_60 = val_60 - 1;
            if()
            {
                goto label_11;
            }
            
            Mapbox.Utils.Vector2d val_61 = val_60;
            val_61 = val_61 * val_61;
            float val_68 = 0f;
            val_60 = 1f;
            label_46:
            float val_6 = val_68 / (float)val_60;
            val_6 = val_60 - val_6;
            Mapbox.Utils.Vector2d val_63 = (float)val_61;
            float val_62 = 8f;
            val_62 = val_68 * val_62;
            val_63 = val_62 + val_63;
            float val_64 = 2f;
            val_64 = val_63 + val_64;
            val_63 = val_63 + 4f;
            label_45:
            if(this._currentTileMeshData == null)
            {
                    if(this._currentTileMeshData == null)
            {
                goto label_42;
            }
            
            }
            
            float val_65 = val_68 * (float)val_61;
            val_65 = val_65 + 0f;
            UnityEngine.Vector3 val_7 = this._currentTileMeshData.Vertices.Item[(int)val_65];
            float val_9 = val_59.QueryHeightData(x:  0f / (float)val_60, y:  val_6);
            UnityEngine.Vector3 val_10 = this._currentTileMeshData.Vertices.Item[(int)val_65];
            this._currentTileMeshData.Vertices.set_Item(index:  (int)val_65, value:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            val_62 = Constants.Math.Vector3Zero;
            val_63 = Constants.Math.Vector3Zero.__il2cppRuntimeField_4;
            val_64 = Constants.Math.Vector3Zero.__il2cppRuntimeField_8;
            this._currentTileMeshData.Normals.set_Item(index:  (int)val_65, value:  new UnityEngine.Vector3() {x = val_62, y = val_63, z = val_64});
            if(val_68 != 0f)
            {
                goto label_23;
            }
            
            if(this._currentTileMeshData == null)
            {
                    if(this._currentTileMeshData == null)
            {
                goto label_42;
            }
            
            }
            
            UnityEngine.Vector3 val_11 = this._currentTileMeshData.Vertices.Item[(int)val_65];
            val_61 = val_11.y;
            float val_66 = 8f;
            val_66 = 0f * val_66;
            goto label_28;
            label_23:
            if(val_68 != (float)val_60)
            {
                goto label_29;
            }
            
            if(this._currentTileMeshData == null)
            {
                    if(this._currentTileMeshData == null)
            {
                goto label_42;
            }
            
            }
            
            UnityEngine.Vector3 val_12 = this._currentTileMeshData.Vertices.Item[(int)val_65];
            val_61 = val_12.y;
            float val_67 = 8f;
            val_67 = 0f * val_67;
            val_67 = val_67 + (float)val_61;
            label_28:
            val_67 = val_67 + 6f;
            val_62 = val_12.x;
            val_63 = val_61;
            val_64 = val_12.z;
            this._currentTileMeshData.Vertices.set_Item(index:  (int)val_67, value:  new UnityEngine.Vector3() {x = val_62, y = val_63, z = val_64});
            label_29:
            if(0f != 0f)
            {
                goto label_34;
            }
            
            if(this._currentTileMeshData == null)
            {
                    if(this._currentTileMeshData == null)
            {
                goto label_42;
            }
            
            }
            
            UnityEngine.Vector3 val_13 = this._currentTileMeshData.Vertices.Item[(int)val_65];
            val_61 = val_13.y;
            if(this._currentTileMeshData.Vertices != null)
            {
                goto label_39;
            }
            
            goto label_39;
            label_34:
            if(0f != (float)val_60)
            {
                goto label_40;
            }
            
            if(this._currentTileMeshData == null)
            {
                    if(this._currentTileMeshData == null)
            {
                goto label_42;
            }
            
            }
            
            UnityEngine.Vector3 val_14 = this._currentTileMeshData.Vertices.Item[(int)val_65];
            val_61 = val_14.y;
            label_39:
            val_62 = val_14.x;
            val_63 = val_61;
            val_64 = val_14.z;
            this._currentTileMeshData.Vertices.set_Item(index:  (int)val_63, value:  new UnityEngine.Vector3() {x = val_62, y = val_63, z = val_64});
            label_40:
            val_65 = 0f + val_60;
            if(val_65 < 0)
            {
                goto label_45;
            }
            
            val_68 = val_68 + val_60;
            if(val_68 < 0)
            {
                goto label_46;
            }
            
            label_11:
            val_59.MeshFilter.mesh.SetVertices(inVertices:  this._currentTileMeshData.Vertices);
            Mapbox.Utils.Vector2d val_69 = val_60;
            if(val_60 >= 1)
            {
                    var val_71 = 0;
                do
            {
                var val_70 = 0;
                do
            {
                val_69 = (val_69 + val_71) + val_70;
                Mapbox.Utils.Vector2d val_18 = val_69 + 1;
                val_59 = val_71 + val_70;
                val_66 = val_18;
                this._vertA = val_59;
                this._vertB = val_18;
                this._vertC = val_69;
                if(this._currentTileMeshData == null)
            {
                    val_66 = this._vertB;
            }
            
                UnityEngine.Vector3 val_19 = this._currentTileMeshData.Vertices.Item[val_66];
                UnityEngine.Vector3 val_20 = this._currentTileMeshData.Vertices.Item[this._vertA];
                UnityEngine.Vector3 val_21 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z}, b:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z});
                UnityEngine.Vector3 val_22 = this._currentTileMeshData.Vertices.Item[this._vertC];
                UnityEngine.Vector3 val_23 = this._currentTileMeshData.Vertices.Item[this._vertA];
                UnityEngine.Vector3 val_24 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z}, b:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z});
                UnityEngine.Vector3 val_25 = UnityEngine.Vector3.Cross(lhs:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z}, rhs:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z});
                this._newDir = val_25;
                mem[1152921519751959052] = val_25.y;
                mem[1152921519751959056] = val_25.z;
                UnityEngine.Vector3 val_26 = this._currentTileMeshData.Normals.Item[this._vertA];
                UnityEngine.Vector3 val_27 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z}, b:  new UnityEngine.Vector3() {x = this._newDir, y = val_24.y, z = val_24.z});
                this._currentTileMeshData.Normals.set_Item(index:  this._vertA, value:  new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z});
                UnityEngine.Vector3 val_28 = this._currentTileMeshData.Normals.Item[this._vertB];
                UnityEngine.Vector3 val_29 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z}, b:  new UnityEngine.Vector3() {x = this._newDir, y = val_24.y, z = val_24.z});
                this._currentTileMeshData.Normals.set_Item(index:  this._vertB, value:  new UnityEngine.Vector3() {x = val_29.x, y = val_29.y, z = val_29.z});
                UnityEngine.Vector3 val_30 = this._currentTileMeshData.Normals.Item[this._vertC];
                UnityEngine.Vector3 val_31 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_30.x, y = val_30.y, z = val_30.z}, b:  new UnityEngine.Vector3() {x = this._newDir, y = val_24.y, z = val_24.z});
                this._currentTileMeshData.Normals.set_Item(index:  this._vertC, value:  new UnityEngine.Vector3() {x = val_31.x, y = val_31.y, z = val_31.z});
                val_67 = (val_71 + val_70) + 1;
                this._vertA = val_59;
                this._vertB = val_67;
                this._vertC = val_18;
                if(this._currentTileMeshData == null)
            {
                    val_67 = this._vertB;
            }
            
                UnityEngine.Vector3 val_33 = this._currentTileMeshData.Vertices.Item[val_67];
                UnityEngine.Vector3 val_34 = this._currentTileMeshData.Vertices.Item[this._vertA];
                UnityEngine.Vector3 val_35 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_33.x, y = val_33.y, z = val_33.z}, b:  new UnityEngine.Vector3() {x = val_34.x, y = val_34.y, z = val_34.z});
                UnityEngine.Vector3 val_36 = this._currentTileMeshData.Vertices.Item[this._vertC];
                val_65 = val_36.y;
                UnityEngine.Vector3 val_37 = this._currentTileMeshData.Vertices.Item[this._vertA];
                UnityEngine.Vector3 val_38 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_36.x, y = val_65, z = val_36.z}, b:  new UnityEngine.Vector3() {x = val_37.x, y = val_37.y, z = val_37.z});
                UnityEngine.Vector3 val_39 = UnityEngine.Vector3.Cross(lhs:  new UnityEngine.Vector3() {x = val_35.x, y = val_35.y, z = val_35.z}, rhs:  new UnityEngine.Vector3() {x = val_38.x, y = val_38.y, z = val_38.z});
                this._newDir = val_39;
                mem[1152921519751959052] = val_39.y;
                mem[1152921519751959056] = val_39.z;
                UnityEngine.Vector3 val_40 = this._currentTileMeshData.Normals.Item[this._vertA];
                UnityEngine.Vector3 val_41 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_40.x, y = val_40.y, z = val_40.z}, b:  new UnityEngine.Vector3() {x = this._newDir, y = val_38.y, z = val_38.z});
                this._currentTileMeshData.Normals.set_Item(index:  this._vertA, value:  new UnityEngine.Vector3() {x = val_41.x, y = val_41.y, z = val_41.z});
                UnityEngine.Vector3 val_42 = this._currentTileMeshData.Normals.Item[this._vertB];
                UnityEngine.Vector3 val_43 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_42.x, y = val_42.y, z = val_42.z}, b:  new UnityEngine.Vector3() {x = this._newDir, y = val_38.y, z = val_38.z});
                this._currentTileMeshData.Normals.set_Item(index:  this._vertB, value:  new UnityEngine.Vector3() {x = val_43.x, y = val_43.y, z = val_43.z});
                UnityEngine.Vector3 val_44 = this._currentTileMeshData.Normals.Item[this._vertC];
                UnityEngine.Vector3 val_45 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_44.x, y = val_44.y, z = val_44.z}, b:  new UnityEngine.Vector3() {x = this._newDir, y = val_38.y, z = val_38.z});
                val_60 = val_45.x;
                val_61 = val_45.z;
                this._currentTileMeshData.Normals.set_Item(index:  this._vertC, value:  new UnityEngine.Vector3() {x = val_60, y = val_45.y, z = val_61});
                val_70 = val_70 + 1;
            }
            while(val_60 != val_70);
            
                val_71 = val_71 + val_60;
            }
            while(1 != val_60);
            
            }
            
            this.FixStitches(tileId:  new Mapbox.Map.UnwrappedTileId() {Z = tile + 180, X = tile + 180, Y = tile + 188}, mesh:  this._currentTileMeshData);
            val_59.MeshFilter.mesh.SetNormals(inNormals:  this._currentTileMeshData.Normals);
            val_59.MeshFilter.mesh.SetVertices(inVertices:  this._currentTileMeshData.Vertices);
            val_59.MeshFilter.mesh.RecalculateBounds();
            val_68 = this._meshData;
            val_69 = mem[tile + 180];
            val_69 = tile + 180;
            if((val_68.ContainsKey(key:  new Mapbox.Map.UnwrappedTileId() {Z = val_69, X = val_69, Y = tile + 188})) != true)
            {
                    val_69 = this._meshData;
                val_68 = mem[tile + 188];
                val_68 = tile + 188;
                val_69.Add(key:  new Mapbox.Map.UnwrappedTileId() {Z = tile + 180, X = tile + 180, Y = val_68}, value:  val_59.MeshFilter.mesh);
            }
            
            val_70 = this._currentTileMeshData.MercatorCenter;
            if((mem[this._currentTileMeshData.MercatorCenter + 16]) == 0)
            {
                    return;
            }
            
            UnityEngine.Collider val_55 = val_59.Collider;
            val_71 = 0;
            if((UnityEngine.Object.op_Implicit(exists:  null)) == false)
            {
                    return;
            }
            
            val_70 = val_59.MeshFilter.mesh;
            sharedMesh = val_70;
            return;
            label_42:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ResetToFlatMesh(Mapbox.Unity.MeshGeneration.Data.UnityTile tile)
        {
            Mapbox.Unity.MeshGeneration.Data.MeshData val_14;
            var val_15;
            tile.MeshFilter.mesh.GetVertices(vertices:  this._currentTileMeshData.Vertices);
            tile.MeshFilter.mesh.GetNormals(normals:  this._currentTileMeshData.Normals);
            int val_5 = this._currentTileMeshData.Vertices.Count;
            this._counter = val_5;
            if(val_5 < 1)
            {
                goto label_11;
            }
            
            var val_14 = 0;
            label_22:
            val_14 = this._currentTileMeshData;
            if(this._currentTileMeshData != null)
            {
                goto label_12;
            }
            
            val_14 = this._currentTileMeshData;
            if(val_14 == null)
            {
                goto label_13;
            }
            
            label_12:
            UnityEngine.Vector3 val_6 = this._currentTileMeshData.Vertices.Item[0];
            UnityEngine.Vector3 val_7 = this._currentTileMeshData.Vertices.Item[0];
            this._currentTileMeshData.Vertices.set_Item(index:  0, value:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            val_15 = null;
            val_15 = null;
            this._currentTileMeshData.Normals.set_Item(index:  0, value:  new UnityEngine.Vector3() {x = Constants.Math.Vector3Up, y = Constants.Math.Vector3Zero.__il2cppRuntimeField_10, z = Constants.Math.Vector3Zero.__il2cppRuntimeField_14});
            val_14 = val_14 + 1;
            if(val_14 < this._counter)
            {
                goto label_22;
            }
            
            label_11:
            tile.MeshFilter.mesh.SetVertices(inVertices:  this._currentTileMeshData.Vertices);
            tile.MeshFilter.mesh.SetNormals(inNormals:  this._currentTileMeshData.Normals);
            tile.MeshFilter.mesh.RecalculateBounds();
            return;
            label_13:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void FixStitches(Mapbox.Map.UnwrappedTileId tileId, Mapbox.Unity.MeshGeneration.Data.MeshData mesh)
        {
            System.Collections.Generic.List<UnityEngine.Vector3> val_91;
            var val_92;
            System.Collections.Generic.List<UnityEngine.Vector3> val_93;
            var val_94;
            float val_95;
            float val_96;
            var val_97;
            UnityEngine.Object val_98;
            val_91 = this;
            this._stitchTarget = 0;
            bool val_1 = this._meshData.TryGetValue(key:  new Mapbox.Map.UnwrappedTileId() {Z = -2033341120, X = 268435459}, value: out  this._stitchTarget);
            int val_93 = mem[69738544] + 16;
            val_93 = val_93 * val_93;
            if(this._stitchTarget == 0)
            {
                goto label_11;
            }
            
            this._stitchTarget.GetVertices(vertices:  this._stitchTargetMeshData.Vertices);
            this._stitchTarget.GetNormals(normals:  this._stitchTargetMeshData.Normals);
            if((mem[69738544] + 16) < 1)
            {
                goto label_11;
            }
            
            int val_94 = val_93;
            val_92 = mem[69738544] + 16;
            goto label_32;
            label_15:
            if(mesh.Vertices != null)
            {
                goto label_16;
            }
            
            goto label_14;
            label_32:
            if(mesh == null)
            {
                goto label_15;
            }
            
            if(mesh.Vertices != null)
            {
                goto label_16;
            }
            
            label_14:
            label_16:
            UnityEngine.Vector3 val_4 = mesh.Vertices.Item[0];
            int val_5 = (val_94 - val_92) + 0;
            UnityEngine.Vector3 val_6 = this._stitchTargetMeshData.Vertices.Item[val_5];
            UnityEngine.Vector3 val_7 = mesh.Vertices.Item[0];
            mesh.Vertices.set_Item(index:  0, value:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            UnityEngine.Vector3 val_8 = mesh.Vertices.Item[0];
            mesh.Vertices.set_Item(index:  val_94, value:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
            val_93 = mesh.Normals;
            UnityEngine.Vector3 val_9 = this._stitchTargetMeshData.Normals.Item[val_5];
            val_94 = val_9.x;
            UnityEngine.Vector3 val_10 = this._stitchTargetMeshData.Normals.Item[val_5];
            UnityEngine.Vector3 val_11 = this._stitchTargetMeshData.Normals.Item[val_5];
            val_95 = 0f;
            val_96 = 0f;
            val_93.set_Item(index:  0, value:  new UnityEngine.Vector3() {x = val_95, y = val_96, z = 0f});
            val_94 = val_94 + 8;
            if((mem[69738544] + 16) != 1)
            {
                goto label_32;
            }
            
            label_11:
            this._stitchTarget = 0;
            bool val_13 = this._meshData.TryGetValue(key:  new Mapbox.Map.UnwrappedTileId() {Z = -2033341120, X = 268435459}, value: out  this._stitchTarget);
            if(1179403647 == 0)
            {
                goto label_41;
            }
            
            this._stitchTarget.GetVertices(vertices:  this._stitchTargetMeshData.Vertices);
            this._stitchTarget.GetNormals(normals:  this._stitchTargetMeshData.Normals);
            if((mem[69738544] + 16) < 1)
            {
                goto label_41;
            }
            
            val_92 = mem[69738544] + 16;
            int val_16 = val_93 + 6;
            goto label_62;
            label_45:
            if(mesh.Vertices != null)
            {
                goto label_46;
            }
            
            goto label_44;
            label_62:
            if(mesh == null)
            {
                goto label_45;
            }
            
            if(mesh.Vertices != null)
            {
                goto label_46;
            }
            
            label_44:
            label_46:
            int val_17 = (val_93 - val_92) + 0;
            UnityEngine.Vector3 val_18 = mesh.Vertices.Item[val_17];
            UnityEngine.Vector3 val_19 = this._stitchTargetMeshData.Vertices.Item[0];
            UnityEngine.Vector3 val_20 = mesh.Vertices.Item[val_17];
            mesh.Vertices.set_Item(index:  val_17, value:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            UnityEngine.Vector3 val_21 = mesh.Vertices.Item[val_17];
            mesh.Vertices.set_Item(index:  val_16, value:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z});
            val_93 = mesh.Normals;
            UnityEngine.Vector3 val_22 = this._stitchTargetMeshData.Normals.Item[0];
            val_94 = val_22.x;
            UnityEngine.Vector3 val_23 = this._stitchTargetMeshData.Normals.Item[0];
            UnityEngine.Vector3 val_24 = this._stitchTargetMeshData.Normals.Item[0];
            val_95 = 0f;
            val_96 = 0f;
            val_93.set_Item(index:  val_17, value:  new UnityEngine.Vector3() {x = val_95, y = val_96, z = 0f});
            val_16 = val_16 + 8;
            if((mem[69738544] + 16) != 1)
            {
                goto label_62;
            }
            
            label_41:
            this._stitchTarget = 0;
            bool val_26 = this._meshData.TryGetValue(key:  new Mapbox.Map.UnwrappedTileId() {Z = -2033341120, X = 268435459}, value: out  this._stitchTarget);
            if(1179403647 == 0)
            {
                goto label_71;
            }
            
            this._stitchTarget.GetVertices(vertices:  this._stitchTargetMeshData.Vertices);
            this._stitchTarget.GetNormals(normals:  this._stitchTargetMeshData.Normals);
            if((mem[69738544] + 16) < 1)
            {
                goto label_71;
            }
            
            var val_96 = 0;
            int val_28 = val_93 + 2;
            goto label_92;
            label_75:
            if(mesh.Vertices != null)
            {
                goto label_76;
            }
            
            goto label_74;
            label_92:
            if(mesh == null)
            {
                goto label_75;
            }
            
            if(mesh.Vertices != null)
            {
                goto label_76;
            }
            
            label_74:
            label_76:
            UnityEngine.Vector3 val_29 = mesh.Vertices.Item[0];
            var val_95 = mem[69738544] + 16;
            val_95 = val_95 + val_96;
            int val_30 = val_95 - 1;
            UnityEngine.Vector3 val_31 = this._stitchTargetMeshData.Vertices.Item[val_30];
            UnityEngine.Vector3 val_32 = mesh.Vertices.Item[0];
            mesh.Vertices.set_Item(index:  0, value:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            UnityEngine.Vector3 val_33 = mesh.Vertices.Item[0];
            mesh.Vertices.set_Item(index:  val_28, value:  new UnityEngine.Vector3() {x = val_33.x, y = val_33.y, z = val_33.z});
            val_93 = mesh.Normals;
            UnityEngine.Vector3 val_34 = this._stitchTargetMeshData.Normals.Item[val_30];
            val_94 = val_34.x;
            UnityEngine.Vector3 val_35 = this._stitchTargetMeshData.Normals.Item[val_30];
            UnityEngine.Vector3 val_36 = this._stitchTargetMeshData.Normals.Item[val_30];
            val_95 = 0f;
            val_96 = 0f;
            val_93.set_Item(index:  0, value:  new UnityEngine.Vector3() {x = val_95, y = val_96, z = 0f});
            val_28 = val_28 + 8;
            val_96 = val_96 + (mem[69738544] + 16);
            if((mem[69738544] + 16) != 1)
            {
                goto label_92;
            }
            
            label_71:
            this._stitchTarget = 0;
            bool val_38 = this._meshData.TryGetValue(key:  new Mapbox.Map.UnwrappedTileId() {Z = -2033341120, X = 268435459}, value: out  this._stitchTarget);
            if(1179403647 == 0)
            {
                goto label_101;
            }
            
            this._stitchTarget.GetVertices(vertices:  this._stitchTargetMeshData.Vertices);
            this._stitchTarget.GetNormals(normals:  this._stitchTargetMeshData.Normals);
            if((mem[69738544] + 16) < 1)
            {
                goto label_101;
            }
            
            var val_98 = 0;
            int val_40 = val_93 + 4;
            goto label_122;
            label_105:
            if(mesh.Vertices != null)
            {
                goto label_106;
            }
            
            goto label_104;
            label_122:
            if(mesh == null)
            {
                goto label_105;
            }
            
            if(mesh.Vertices != null)
            {
                goto label_106;
            }
            
            label_104:
            label_106:
            var val_97 = mem[69738544] + 16;
            val_97 = val_97 + val_98;
            int val_41 = val_97 - 1;
            UnityEngine.Vector3 val_42 = mesh.Vertices.Item[val_41];
            UnityEngine.Vector3 val_43 = this._stitchTargetMeshData.Vertices.Item[0];
            UnityEngine.Vector3 val_44 = mesh.Vertices.Item[val_41];
            mesh.Vertices.set_Item(index:  val_41, value:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            UnityEngine.Vector3 val_45 = mesh.Vertices.Item[val_41];
            mesh.Vertices.set_Item(index:  val_40, value:  new UnityEngine.Vector3() {x = val_45.x, y = val_45.y, z = val_45.z});
            val_93 = mesh.Normals;
            UnityEngine.Vector3 val_46 = this._stitchTargetMeshData.Normals.Item[0];
            val_94 = val_46.x;
            UnityEngine.Vector3 val_47 = this._stitchTargetMeshData.Normals.Item[0];
            UnityEngine.Vector3 val_48 = this._stitchTargetMeshData.Normals.Item[0];
            val_95 = 0f;
            val_96 = 0f;
            val_93.set_Item(index:  val_41, value:  new UnityEngine.Vector3() {x = val_95, y = val_96, z = 0f});
            val_40 = val_40 + 8;
            val_98 = val_98 + (mem[69738544] + 16);
            if((mem[69738544] + 16) != 1)
            {
                goto label_122;
            }
            
            label_101:
            this._stitchTarget = 0;
            bool val_50 = this._meshData.TryGetValue(key:  new Mapbox.Map.UnwrappedTileId() {Z = -2033341120, X = 268435459}, value: out  this._stitchTarget);
            if(1179403647 == 0)
            {
                goto label_126;
            }
            
            this._stitchTarget.GetVertices(vertices:  this._stitchTargetMeshData.Vertices);
            this._stitchTarget.GetNormals(normals:  this._stitchTargetMeshData.Normals);
            if(mesh == null)
            {
                goto label_131;
            }
            
            if(mesh.Vertices != null)
            {
                goto label_215;
            }
            
            label_216:
            label_215:
            UnityEngine.Vector3 val_52 = mesh.Vertices.Item[0];
            int val_53 = val_93 - 1;
            UnityEngine.Vector3 val_54 = this._stitchTargetMeshData.Vertices.Item[val_53];
            UnityEngine.Vector3 val_55 = mesh + 112.Item[0];
            val_93 = 1152921518724786432;
            mesh.Vertices.set_Item(index:  0, value:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            UnityEngine.Vector3 val_56 = this._stitchTargetMeshData.Normals.Item[val_53];
            val_94 = val_56.x;
            UnityEngine.Vector3 val_57 = this._stitchTargetMeshData.Normals.Item[val_53];
            UnityEngine.Vector3 val_58 = this._stitchTargetMeshData.Normals.Item[val_53];
            val_95 = 0f;
            val_96 = 0f;
            mesh.Normals.set_Item(index:  0, value:  new UnityEngine.Vector3() {x = val_95, y = val_96, z = 0f});
            label_126:
            this._stitchTarget = 0;
            bool val_61 = this._meshData.TryGetValue(key:  new Mapbox.Map.UnwrappedTileId() {Z = -2033341120, X = 268435459, Y = 0 & 4294967295}, value: out  this._stitchTarget);
            if(1179403647 == 0)
            {
                goto label_149;
            }
            
            this._stitchTarget.GetVertices(vertices:  this._stitchTargetMeshData.Vertices);
            this._stitchTarget.GetNormals(normals:  this._stitchTargetMeshData.Normals);
            if(mesh == null)
            {
                goto label_154;
            }
            
            if(mesh.Vertices != null)
            {
                goto label_217;
            }
            
            label_218:
            label_217:
            int val_63 = (mem[69738544] + 16) - 1;
            UnityEngine.Vector3 val_64 = mesh.Vertices.Item[val_63];
            val_92 = mem[69738544] + 16;
            int val_65 = val_93 - val_92;
            UnityEngine.Vector3 val_66 = this._stitchTargetMeshData.Vertices.Item[val_65];
            UnityEngine.Vector3 val_67 = mesh + 112.Item[val_63];
            mesh.Vertices.set_Item(index:  val_63, value:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            UnityEngine.Vector3 val_68 = this._stitchTargetMeshData.Normals.Item[val_65];
            val_94 = val_68.x;
            UnityEngine.Vector3 val_69 = this._stitchTargetMeshData.Normals.Item[val_65];
            val_93 = this._stitchTargetMeshData.Normals;
            UnityEngine.Vector3 val_70 = val_93.Item[val_65];
            val_95 = 0f;
            val_96 = 0f;
            mesh.Normals.set_Item(index:  val_63, value:  new UnityEngine.Vector3() {x = val_95, y = val_96, z = 0f});
            label_149:
            this._stitchTarget = 0;
            bool val_73 = this._meshData.TryGetValue(key:  new Mapbox.Map.UnwrappedTileId() {Z = -2033341120, X = 268435459, Y = 0 & 4294967295}, value: out  this._stitchTarget);
            if(1179403647 == 0)
            {
                goto label_172;
            }
            
            this._stitchTarget.GetVertices(vertices:  this._stitchTargetMeshData.Vertices);
            this._stitchTarget.GetNormals(normals:  this._stitchTargetMeshData.Normals);
            if(mesh == null)
            {
                goto label_177;
            }
            
            if(mesh.Vertices != null)
            {
                goto label_219;
            }
            
            label_220:
            label_219:
            int val_75 = val_93 - (mem[69738544] + 16);
            UnityEngine.Vector3 val_76 = mesh.Vertices.Item[val_75];
            int val_77 = (mem[69738544] + 16) - 1;
            UnityEngine.Vector3 val_78 = this._stitchTargetMeshData.Vertices.Item[val_77];
            UnityEngine.Vector3 val_79 = mesh + 112.Item[val_75];
            mesh.Vertices.set_Item(index:  val_75, value:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            UnityEngine.Vector3 val_80 = this._stitchTargetMeshData.Normals.Item[val_77];
            val_94 = val_80.x;
            UnityEngine.Vector3 val_81 = this._stitchTargetMeshData.Normals.Item[val_77];
            val_93 = this._stitchTargetMeshData.Normals;
            UnityEngine.Vector3 val_82 = val_93.Item[val_77];
            val_95 = 0f;
            val_96 = 0f;
            mesh.Normals.set_Item(index:  val_75, value:  new UnityEngine.Vector3() {x = val_95, y = val_96, z = 0f});
            label_172:
            this._stitchTarget = 0;
            val_97;
            bool val_85 = this._meshData.TryGetValue(key:  new Mapbox.Map.UnwrappedTileId() {Z = -2033341120, X = 268435459, Y = 0 & 4294967295}, value: out  this._stitchTarget);
            val_98 = 1179403647;
            if(val_98 == 0)
            {
                    return;
            }
            
            this._stitchTarget.GetVertices(vertices:  this._stitchTargetMeshData.Vertices);
            this._stitchTarget.GetNormals(normals:  this._stitchTargetMeshData.Normals);
            if(mesh == null)
            {
                goto label_200;
            }
            
            val_93 = mesh;
            if(mesh.Vertices != null)
            {
                goto label_221;
            }
            
            label_222:
            label_221:
            val_98 = val_93 - 1;
            UnityEngine.Vector3 val_87 = mesh.Vertices.Item[val_98];
            UnityEngine.Vector3 val_88 = this._stitchTargetMeshData.Vertices.Item[0];
            UnityEngine.Vector3 val_89 = mesh + 112.Item[val_98];
            val_97 = 1152921518724786432;
            mesh.Vertices.set_Item(index:  val_98, value:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            UnityEngine.Vector3 val_90 = this._stitchTargetMeshData.Normals.Item[0];
            val_94 = val_90.x;
            UnityEngine.Vector3 val_91 = this._stitchTargetMeshData.Normals.Item[0];
            val_91 = this._stitchTargetMeshData.Normals;
            UnityEngine.Vector3 val_92 = val_91.Item[0];
            mesh.Normals.set_Item(index:  val_98, value:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            return;
            label_131:
            if(65536 != 0)
            {
                goto label_215;
            }
            
            goto label_216;
            label_154:
            if(65536 != 0)
            {
                goto label_217;
            }
            
            goto label_218;
            label_177:
            if(65536 != 0)
            {
                goto label_219;
            }
            
            goto label_220;
            label_200:
            if(65536 != 0)
            {
                goto label_221;
            }
            
            goto label_222;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ElevatedTerrainWithSidesStrategy()
        {
        
        }
    
    }

}
