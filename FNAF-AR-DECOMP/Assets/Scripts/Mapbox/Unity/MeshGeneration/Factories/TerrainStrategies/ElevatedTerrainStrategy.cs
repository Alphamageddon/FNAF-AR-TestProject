using UnityEngine;

namespace Mapbox.Unity.MeshGeneration.Factories.TerrainStrategies
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ElevatedTerrainStrategy : TerrainStrategy, IElevationBasedTerrainStrategy
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
            mem[1152921519747054752] = elOptions;
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
        public override void UnregisterTile(Mapbox.Unity.MeshGeneration.Data.UnityTile tile)
        {
            bool val_1 = this._meshData.Remove(key:  new Mapbox.Map.UnwrappedTileId() {Z = tile.<UnwrappedTileId>k__BackingField, X = tile.<UnwrappedTileId>k__BackingField, Y = tile});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void DataErrorOccurred(Mapbox.Unity.MeshGeneration.Data.UnityTile t, Mapbox.Map.TileErrorEventArgs e)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void PostProcessTile(Mapbox.Unity.MeshGeneration.Data.UnityTile tile)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CreateBaseMesh(Mapbox.Unity.MeshGeneration.Data.UnityTile tile)
        {
            int val_19;
            var val_20;
            float val_21;
            var val_22;
            System.Collections.Generic.List<UnityEngine.Vector3> val_23;
            System.Collections.Generic.List<System.Int32> val_24;
            this._newVertexList.Clear();
            this._newNormalList.Clear();
            this._newUvList.Clear();
            this._newTriangleList.Clear();
            var val_1 = W26 - 1;
            if()
            {
                    val_19 = 1152921518605502048;
                val_20 = 1152921517377849056;
                do
            {
                float val_21 = (float)val_1;
                float val_25 = 0f;
                val_21 = 0f / val_21;
                do
            {
                float val_3 = val_25 / (float)val_1;
                Mapbox.Utils.Vector2d val_4 = tile.<Rect>k__BackingField.<Min>k__BackingField.Min;
                Mapbox.Utils.Vector2d val_5 = tile.<Rect>k__BackingField.<Min>k__BackingField.Min;
                Mapbox.Utils.Vector2d val_7 = tile.<Rect>k__BackingField.<Min>k__BackingField.Min;
                Mapbox.Utils.Vector2d val_8 = tile.<Rect>k__BackingField.<Min>k__BackingField.Min;
                double val_22 = (double)val_21;
                Mapbox.Utils.Vector2d val_10 = tile.<Rect>k__BackingField.<Min>k__BackingField.Size;
                if(tile != null)
            {
                    val_21 = tile.<TileScale>k__BackingField;
            }
            else
            {
                    val_21 = tile.<TileScale>k__BackingField;
            }
            
                Mapbox.Utils.Vector2d val_11 = tile.<Rect>k__BackingField.<Min>k__BackingField.Size;
                val_22 = (Mapbox.Utils.Mathd.Lerp(from:  val_7.y, to:  val_8.y, t:  val_22)) - val_11.y;
                float val_23 = (float)(Mapbox.Utils.Mathd.Lerp(from:  val_4.x, to:  val_5.x, t:  (double)val_3)) - val_10.x;
                float val_24 = (float)val_22;
                val_23 = val_21 * val_23;
                val_24 = (tile.<TileScale>k__BackingField) * val_24;
                this._newVertexList.Add(item:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                val_22 = null;
                val_22 = null;
                this._newNormalList.Add(item:  new UnityEngine.Vector3() {x = Constants.Math.Vector3Up, y = Constants.Math.Vector3Zero.__il2cppRuntimeField_10, z = Constants.Math.Vector3Zero.__il2cppRuntimeField_14});
                UnityEngine.Vector2 val_13 = new UnityEngine.Vector2(x:  val_3, y:  1f - val_21);
                this._newUvList.Add(item:  new UnityEngine.Vector2() {x = val_13.x, y = val_13.y});
                val_25 = val_25 + 1f;
            }
            while(val_25 < 0);
            
                float val_26 = 0f;
                val_26 = val_26 + 1f;
            }
            while(val_26 < 0);
            
            }
            
            if(val_1 >= 1)
            {
                    do
            {
                var val_27 = 0;
                do
            {
                int val_15 = (W26 + 0) + val_27;
                int val_16 = 0 + val_27;
                int val_17 = val_15 + 1;
                this._newTriangleList.Add(item:  val_16);
                this._newTriangleList.Add(item:  val_17);
                this._newTriangleList.Add(item:  val_15);
                val_19 = (0 + val_27) + 1;
                this._newTriangleList.Add(item:  val_16);
                this._newTriangleList.Add(item:  val_19);
                this._newTriangleList.Add(item:  val_17);
                val_27 = val_27 + 1;
            }
            while(val_1 != val_27);
            
                val_20 = 0 + (???);
            }
            while(1 != val_1);
            
            }
            
            UnityEngine.Mesh val_20 = tile.MeshFilter.mesh;
            val_23 = this._newVertexList;
            if(val_20 != null)
            {
                    val_20.SetVertices(inVertices:  val_23);
                val_20.SetNormals(inNormals:  this._newNormalList);
                val_20.SetUVs(channel:  0, uvs:  this._newUvList);
                val_24 = this._newTriangleList;
            }
            else
            {
                    0.SetVertices(inVertices:  val_23);
                0.SetNormals(inNormals:  this._newNormalList);
                val_23 = this._newUvList;
                0.SetUVs(channel:  0, uvs:  val_23);
                val_24 = this._newTriangleList;
            }
            
            val_20.SetTriangles(triangles:  val_24, submesh:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GenerateTerrainMesh(Mapbox.Unity.MeshGeneration.Data.UnityTile tile)
        {
            UnityEngine.Mesh val_54;
            float val_55;
            int val_56;
            float val_57;
            float val_58;
            int val_59;
            System.Collections.Generic.Dictionary<Mapbox.Map.UnwrappedTileId, UnityEngine.Mesh> val_60;
            Mapbox.Map.UnwrappedTileId val_61;
            var val_62;
            val_54 = tile;
            val_54.MeshFilter.mesh.GetVertices(vertices:  this._currentTileMeshData.Vertices);
            val_54.MeshFilter.mesh.GetNormals(normals:  this._currentTileMeshData.Normals);
            if()
            {
                    val_55 = 1f;
                val_56 = 1152921518724786432;
                float val_54 = 0f;
                do
            {
                val_54 = val_54 / 0f;
                val_57 = 1f - val_54;
                float val_55 = 0f;
                do
            {
                if(this._currentTileMeshData == null)
            {
                    if(this._currentTileMeshData == null)
            {
                goto label_13;
            }
            
            }
            
                UnityEngine.Vector3 val_7 = this._currentTileMeshData.Vertices.Item[(int)(val_54 * val_55) + val_55];
                float val_9 = val_54.QueryHeightData(x:  val_55 / 0f, y:  val_57);
                UnityEngine.Vector3 val_10 = this._currentTileMeshData.Vertices.Item[(int)(val_54 * val_55) + val_55];
                this._currentTileMeshData.Vertices.set_Item(index:  (int)(val_54 * val_55) + val_55, value:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                this._currentTileMeshData.Normals.set_Item(index:  (int)(val_54 * val_55) + val_55, value:  new UnityEngine.Vector3() {x = Constants.Math.Vector3Zero, y = Constants.Math.Vector3Zero.__il2cppRuntimeField_4, z = Constants.Math.Vector3Zero.__il2cppRuntimeField_8});
                val_55 = val_55 + 1f;
            }
            while(val_55 < 0);
            
                float val_56 = val_54;
                val_56 = val_56 + 1f;
            }
            while(val_56 < 0);
            
            }
            
            val_54.MeshFilter.mesh.SetVertices(inVertices:  this._currentTileMeshData.Vertices);
            if(0 >= 1)
            {
                    var val_58 = 0;
                do
            {
                var val_57 = 0;
                do
            {
                val_56 = 0;
                this._vertA = val_56;
                this._vertB = 2;
                this._vertC = 1;
                UnityEngine.Vector3 val_13 = this._currentTileMeshData.Vertices.Item[this._vertB];
                UnityEngine.Vector3 val_14 = this._currentTileMeshData.Vertices.Item[this._vertA];
                UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, b:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z});
                UnityEngine.Vector3 val_16 = this._currentTileMeshData.Vertices.Item[this._vertC];
                UnityEngine.Vector3 val_17 = this._currentTileMeshData.Vertices.Item[this._vertA];
                UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, b:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z});
                UnityEngine.Vector3 val_19 = UnityEngine.Vector3.Cross(lhs:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, rhs:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z});
                this._newDir = val_19;
                mem[1152921519748311532] = val_19.y;
                mem[1152921519748311536] = val_19.z;
                UnityEngine.Vector3 val_20 = this._currentTileMeshData.Normals.Item[this._vertA];
                UnityEngine.Vector3 val_21 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z}, b:  new UnityEngine.Vector3() {x = this._newDir, y = val_18.y, z = val_18.z});
                this._currentTileMeshData.Normals.set_Item(index:  this._vertA, value:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z});
                UnityEngine.Vector3 val_22 = this._currentTileMeshData.Normals.Item[this._vertB];
                UnityEngine.Vector3 val_23 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z}, b:  new UnityEngine.Vector3() {x = this._newDir, y = val_18.y, z = val_18.z});
                this._currentTileMeshData.Normals.set_Item(index:  this._vertB, value:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z});
                UnityEngine.Vector3 val_24 = this._currentTileMeshData.Normals.Item[this._vertC];
                UnityEngine.Vector3 val_25 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z}, b:  new UnityEngine.Vector3() {x = this._newDir, y = val_18.y, z = val_18.z});
                this._currentTileMeshData.Normals.set_Item(index:  this._vertC, value:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z});
                val_59 = (val_58 + val_57) + 1;
                this._vertA = val_56;
                this._vertB = val_59;
                this._vertC = 2;
                if(this._currentTileMeshData == null)
            {
                    val_59 = this._vertB;
            }
            
                UnityEngine.Vector3 val_27 = this._currentTileMeshData.Vertices.Item[val_59];
                UnityEngine.Vector3 val_28 = this._currentTileMeshData.Vertices.Item[this._vertA];
                UnityEngine.Vector3 val_29 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z}, b:  new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z});
                UnityEngine.Vector3 val_30 = this._currentTileMeshData.Vertices.Item[this._vertC];
                val_55 = val_30.y;
                UnityEngine.Vector3 val_31 = this._currentTileMeshData.Vertices.Item[this._vertA];
                UnityEngine.Vector3 val_32 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_30.x, y = val_55, z = val_30.z}, b:  new UnityEngine.Vector3() {x = val_31.x, y = val_31.y, z = val_31.z});
                UnityEngine.Vector3 val_33 = UnityEngine.Vector3.Cross(lhs:  new UnityEngine.Vector3() {x = val_29.x, y = val_29.y, z = val_29.z}, rhs:  new UnityEngine.Vector3() {x = val_32.x, y = val_32.y, z = val_32.z});
                this._newDir = val_33;
                mem[1152921519748311532] = val_33.y;
                mem[1152921519748311536] = val_33.z;
                UnityEngine.Vector3 val_34 = this._currentTileMeshData.Normals.Item[this._vertA];
                UnityEngine.Vector3 val_35 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_34.x, y = val_34.y, z = val_34.z}, b:  new UnityEngine.Vector3() {x = this._newDir, y = val_32.y, z = val_32.z});
                this._currentTileMeshData.Normals.set_Item(index:  this._vertA, value:  new UnityEngine.Vector3() {x = val_35.x, y = val_35.y, z = val_35.z});
                UnityEngine.Vector3 val_36 = this._currentTileMeshData.Normals.Item[this._vertB];
                UnityEngine.Vector3 val_37 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_36.x, y = val_36.y, z = val_36.z}, b:  new UnityEngine.Vector3() {x = this._newDir, y = val_32.y, z = val_32.z});
                this._currentTileMeshData.Normals.set_Item(index:  this._vertB, value:  new UnityEngine.Vector3() {x = val_37.x, y = val_37.y, z = val_37.z});
                UnityEngine.Vector3 val_38 = this._currentTileMeshData.Normals.Item[this._vertC];
                UnityEngine.Vector3 val_39 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_38.x, y = val_38.y, z = val_38.z}, b:  new UnityEngine.Vector3() {x = this._newDir, y = val_32.y, z = val_32.z});
                val_57 = val_39.x;
                val_58 = val_39.z;
                this._currentTileMeshData.Normals.set_Item(index:  this._vertC, value:  new UnityEngine.Vector3() {x = val_57, y = val_39.y, z = val_58});
                val_57 = val_57 + 1;
            }
            while(0 != val_57);
            
                val_58 = val_58 + true;
            }
            while(1 != 0);
            
            }
            
            this.FixStitches(tileId:  new Mapbox.Map.UnwrappedTileId() {Z = tile.<UnwrappedTileId>k__BackingField, X = tile.<UnwrappedTileId>k__BackingField, Y = 1233037568}, mesh:  this._currentTileMeshData);
            val_54.MeshFilter.mesh.SetNormals(inNormals:  this._currentTileMeshData.Normals);
            val_54.MeshFilter.mesh.SetVertices(inVertices:  this._currentTileMeshData.Vertices);
            val_54.MeshFilter.mesh.RecalculateBounds();
            val_60 = this._meshData;
            val_61 = tile.<UnwrappedTileId>k__BackingField;
            if((val_60.ContainsKey(key:  new Mapbox.Map.UnwrappedTileId() {Z = val_61, X = val_61, Y = this._currentTileMeshData.Vertices})) != true)
            {
                    val_61 = this._meshData;
                val_61.Add(key:  new Mapbox.Map.UnwrappedTileId() {Z = tile.<UnwrappedTileId>k__BackingField, X = tile.<UnwrappedTileId>k__BackingField, Y = val_60}, value:  val_54.MeshFilter.mesh);
            }
            
            if(this._currentTileMeshData.PositionInTile == 0)
            {
                    return;
            }
            
            UnityEngine.Collider val_49 = val_54.Collider;
            val_62 = 0;
            if((UnityEngine.Object.op_Implicit(exists:  null)) == false)
            {
                    return;
            }
            
            val_54 = val_54.MeshFilter.mesh;
            sharedMesh = val_54;
            return;
            label_13:
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
            System.Collections.Generic.List<UnityEngine.Vector3> val_87;
            var val_88;
            float val_89;
            float val_90;
            UnityEngine.Mesh val_91;
            System.Collections.Generic.Dictionary<Mapbox.Map.UnwrappedTileId, UnityEngine.Mesh> val_92;
            val_87 = this;
            int val_1 = mesh.Vertices.Count;
            this._stitchTarget = 0;
            bool val_2 = this._meshData.TryGetValue(key:  new Mapbox.Map.UnwrappedTileId() {Z = -2037077712, X = 268435459}, value: out  this._stitchTarget);
            if(this._stitchTarget != 0)
            {
                    this._stitchTarget.GetVertices(vertices:  this._stitchTargetMeshData.Vertices);
                this._stitchTarget.GetNormals(normals:  this._stitchTargetMeshData.Normals);
                if((mem[69738544] + 16) >= 1)
            {
                    do
            {
                UnityEngine.Vector3 val_5 = mesh.Vertices.Item[0];
                int val_6 = (val_1 - (mem[69738544] + 16)) + 0;
                UnityEngine.Vector3 val_7 = this._stitchTargetMeshData.Vertices.Item[val_6];
                UnityEngine.Vector3 val_8 = mesh.Vertices.Item[0];
                mesh.Vertices.set_Item(index:  0, value:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                UnityEngine.Vector3 val_9 = this._stitchTargetMeshData.Normals.Item[val_6];
                val_88 = val_9.x;
                UnityEngine.Vector3 val_10 = this._stitchTargetMeshData.Normals.Item[val_6];
                UnityEngine.Vector3 val_11 = this._stitchTargetMeshData.Normals.Item[val_6];
                val_89 = 0f;
                val_90 = 0f;
                mesh.Normals.set_Item(index:  0, value:  new UnityEngine.Vector3() {x = val_89, y = val_90, z = 0f});
            }
            while((mem[69738544] + 16) != 1);
            
            }
            
            }
            
            this._stitchTarget = 0;
            bool val_13 = this._meshData.TryGetValue(key:  new Mapbox.Map.UnwrappedTileId() {Z = -2037077712, X = 268435459}, value: out  this._stitchTarget);
            if(1179403647 != 0)
            {
                    this._stitchTarget.GetVertices(vertices:  this._stitchTargetMeshData.Vertices);
                this._stitchTarget.GetNormals(normals:  this._stitchTargetMeshData.Normals);
                if((mem[69738544] + 16) >= 1)
            {
                    do
            {
                int val_16 = (val_1 - (mem[69738544] + 16)) + 0;
                UnityEngine.Vector3 val_17 = mesh.Vertices.Item[val_16];
                UnityEngine.Vector3 val_18 = this._stitchTargetMeshData.Vertices.Item[0];
                UnityEngine.Vector3 val_19 = mesh.Vertices.Item[val_16];
                mesh.Vertices.set_Item(index:  val_16, value:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                UnityEngine.Vector3 val_20 = this._stitchTargetMeshData.Normals.Item[0];
                val_88 = val_20.x;
                UnityEngine.Vector3 val_21 = this._stitchTargetMeshData.Normals.Item[0];
                UnityEngine.Vector3 val_22 = this._stitchTargetMeshData.Normals.Item[0];
                val_89 = 0f;
                val_90 = 0f;
                mesh.Normals.set_Item(index:  val_16, value:  new UnityEngine.Vector3() {x = val_89, y = val_90, z = 0f});
            }
            while((mem[69738544] + 16) != 1);
            
            }
            
            }
            
            this._stitchTarget = 0;
            bool val_24 = this._meshData.TryGetValue(key:  new Mapbox.Map.UnwrappedTileId() {Z = -2037077712, X = 268435459}, value: out  this._stitchTarget);
            if(1179403647 != 0)
            {
                    this._stitchTarget.GetVertices(vertices:  this._stitchTargetMeshData.Vertices);
                this._stitchTarget.GetNormals(normals:  this._stitchTargetMeshData.Normals);
                if((mem[69738544] + 16) >= 1)
            {
                    var val_89 = 0;
                do
            {
                UnityEngine.Vector3 val_26 = mesh.Vertices.Item[0];
                int val_28 = ((mem[69738544] + 16) + val_89) - 1;
                UnityEngine.Vector3 val_29 = this._stitchTargetMeshData.Vertices.Item[val_28];
                UnityEngine.Vector3 val_30 = mesh.Vertices.Item[0];
                mesh.Vertices.set_Item(index:  0, value:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                UnityEngine.Vector3 val_31 = this._stitchTargetMeshData.Normals.Item[val_28];
                val_88 = val_31.x;
                UnityEngine.Vector3 val_32 = this._stitchTargetMeshData.Normals.Item[val_28];
                UnityEngine.Vector3 val_33 = this._stitchTargetMeshData.Normals.Item[val_28];
                val_89 = 0f;
                val_90 = 0f;
                mesh.Normals.set_Item(index:  0, value:  new UnityEngine.Vector3() {x = val_89, y = val_90, z = 0f});
                val_89 = val_89 + (mem[69738544] + 16);
            }
            while((mem[69738544] + 16) != 1);
            
            }
            
            }
            
            this._stitchTarget = 0;
            bool val_35 = this._meshData.TryGetValue(key:  new Mapbox.Map.UnwrappedTileId() {Z = -2037077712, X = 268435459}, value: out  this._stitchTarget);
            if(1179403647 != 0)
            {
                    this._stitchTarget.GetVertices(vertices:  this._stitchTargetMeshData.Vertices);
                this._stitchTarget.GetNormals(normals:  this._stitchTargetMeshData.Normals);
                if((mem[69738544] + 16) >= 1)
            {
                    var val_90 = 0;
                do
            {
                int val_38 = ((mem[69738544] + 16) + val_90) - 1;
                UnityEngine.Vector3 val_39 = mesh.Vertices.Item[val_38];
                UnityEngine.Vector3 val_40 = this._stitchTargetMeshData.Vertices.Item[0];
                UnityEngine.Vector3 val_41 = mesh.Vertices.Item[val_38];
                mesh.Vertices.set_Item(index:  val_38, value:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                UnityEngine.Vector3 val_42 = this._stitchTargetMeshData.Normals.Item[0];
                val_88 = val_42.x;
                UnityEngine.Vector3 val_43 = this._stitchTargetMeshData.Normals.Item[0];
                UnityEngine.Vector3 val_44 = this._stitchTargetMeshData.Normals.Item[0];
                val_89 = 0f;
                val_90 = 0f;
                mesh.Normals.set_Item(index:  val_38, value:  new UnityEngine.Vector3() {x = val_89, y = val_90, z = 0f});
                val_90 = val_90 + (mem[69738544] + 16);
            }
            while((mem[69738544] + 16) != 1);
            
            }
            
            }
            
            this._stitchTarget = 0;
            val_91 = this._stitchTarget;
            bool val_46 = this._meshData.TryGetValue(key:  new Mapbox.Map.UnwrappedTileId() {Z = -2037077712, X = 268435459}, value: out  val_91);
            if(1179403647 != 0)
            {
                    this._stitchTarget.GetVertices(vertices:  this._stitchTargetMeshData.Vertices);
                this._stitchTarget.GetNormals(normals:  this._stitchTargetMeshData.Normals);
                UnityEngine.Vector3 val_48 = mesh.Vertices.Item[0];
                int val_49 = val_1 - 1;
                UnityEngine.Vector3 val_50 = this._stitchTargetMeshData.Vertices.Item[val_49];
                UnityEngine.Vector3 val_51 = mesh.Vertices.Item[0];
                mesh.Vertices.set_Item(index:  0, value:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                UnityEngine.Vector3 val_52 = this._stitchTargetMeshData.Normals.Item[val_49];
                val_88 = val_52.x;
                UnityEngine.Vector3 val_53 = this._stitchTargetMeshData.Normals.Item[val_49];
                UnityEngine.Vector3 val_54 = this._stitchTargetMeshData.Normals.Item[val_49];
                val_89 = 0f;
                val_90 = 0f;
                mesh.Normals.set_Item(index:  0, value:  new UnityEngine.Vector3() {x = val_89, y = val_90, z = 0f});
                val_91 = this._stitchTarget;
            }
            
            this._stitchTarget = 0;
            bool val_57 = this._meshData.TryGetValue(key:  new Mapbox.Map.UnwrappedTileId() {Z = -2037077712, X = 268435459, Y = 0 & 4294967295}, value: out  val_91);
            if(1179403647 != 0)
            {
                    this._stitchTarget.GetVertices(vertices:  this._stitchTargetMeshData.Vertices);
                this._stitchTarget.GetNormals(normals:  this._stitchTargetMeshData.Normals);
                int val_59 = (mem[69738544] + 16) - 1;
                UnityEngine.Vector3 val_60 = mesh.Vertices.Item[val_59];
                int val_61 = val_1 - (mem[69738544] + 16);
                UnityEngine.Vector3 val_62 = this._stitchTargetMeshData.Vertices.Item[val_61];
                UnityEngine.Vector3 val_63 = mesh.Vertices.Item[val_59];
                mesh.Vertices.set_Item(index:  val_59, value:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                UnityEngine.Vector3 val_64 = this._stitchTargetMeshData.Normals.Item[val_61];
                val_88 = val_64.x;
                UnityEngine.Vector3 val_65 = this._stitchTargetMeshData.Normals.Item[val_61];
                UnityEngine.Vector3 val_66 = this._stitchTargetMeshData.Normals.Item[val_61];
                val_89 = 0f;
                val_90 = 0f;
                mesh.Normals.set_Item(index:  val_59, value:  new UnityEngine.Vector3() {x = val_89, y = val_90, z = 0f});
                val_91 = this._stitchTarget;
            }
            
            this._stitchTarget = 0;
            bool val_69 = this._meshData.TryGetValue(key:  new Mapbox.Map.UnwrappedTileId() {Z = -2037077712, X = 268435459, Y = 0 & 4294967295}, value: out  val_91);
            if(1179403647 != 0)
            {
                    this._stitchTarget.GetVertices(vertices:  this._stitchTargetMeshData.Vertices);
                this._stitchTarget.GetNormals(normals:  this._stitchTargetMeshData.Normals);
                int val_71 = val_1 - (mem[69738544] + 16);
                UnityEngine.Vector3 val_72 = mesh.Vertices.Item[val_71];
                int val_73 = (mem[69738544] + 16) - 1;
                UnityEngine.Vector3 val_74 = this._stitchTargetMeshData.Vertices.Item[val_73];
                UnityEngine.Vector3 val_75 = mesh.Vertices.Item[val_71];
                mesh.Vertices.set_Item(index:  val_71, value:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                UnityEngine.Vector3 val_76 = this._stitchTargetMeshData.Normals.Item[val_73];
                val_88 = val_76.x;
                UnityEngine.Vector3 val_77 = this._stitchTargetMeshData.Normals.Item[val_73];
                UnityEngine.Vector3 val_78 = this._stitchTargetMeshData.Normals.Item[val_73];
                val_89 = 0f;
                val_90 = 0f;
                mesh.Normals.set_Item(index:  val_71, value:  new UnityEngine.Vector3() {x = val_89, y = val_90, z = 0f});
                val_91 = this._stitchTarget;
            }
            
            val_92 = this._meshData;
            this._stitchTarget = 0;
            bool val_81 = val_92.TryGetValue(key:  new Mapbox.Map.UnwrappedTileId() {Z = -2037077712, X = 268435459, Y = 0 & 4294967295}, value: out  val_91);
            if(1179403647 == 0)
            {
                    return;
            }
            
            this._stitchTarget.GetVertices(vertices:  this._stitchTargetMeshData.Vertices);
            this._stitchTarget.GetNormals(normals:  this._stitchTargetMeshData.Normals);
            val_91 = val_1 - 1;
            UnityEngine.Vector3 val_83 = mesh.Vertices.Item[val_91];
            UnityEngine.Vector3 val_84 = this._stitchTargetMeshData.Vertices.Item[0];
            UnityEngine.Vector3 val_85 = mesh.Vertices.Item[val_91];
            val_92 = 1152921518724786432;
            mesh.Vertices.set_Item(index:  val_91, value:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            UnityEngine.Vector3 val_86 = this._stitchTargetMeshData.Normals.Item[0];
            val_88 = val_86.x;
            UnityEngine.Vector3 val_87 = this._stitchTargetMeshData.Normals.Item[0];
            val_87 = this._stitchTargetMeshData.Normals;
            UnityEngine.Vector3 val_88 = val_87.Item[0];
            mesh.Normals.set_Item(index:  val_91, value:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ElevatedTerrainStrategy()
        {
        
        }
    
    }

}
