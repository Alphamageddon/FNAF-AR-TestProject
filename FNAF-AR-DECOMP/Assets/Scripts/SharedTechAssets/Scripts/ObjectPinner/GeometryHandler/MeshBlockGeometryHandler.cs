using UnityEngine;

namespace SharedTechAssets.Scripts.ObjectPinner.GeometryHandler
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class MeshBlockGeometryHandler : ISemanticGeometryHandler, IMeshBlockAccepter, IBlockCoordAccepter
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<UnityEngine.Vector3, UnityEngine.GameObject> _meshObjects;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SharedTechAssets.Scripts.ObjectPinner.GeometryHandler.MeshBlockGeometry_Config _config;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SharedTechAssets.Scripts.ObjectPinner.GeometryHandler.GeometryToDataHandler _handler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<UnityEngine.Vector3Int, string> _voxelToLabel;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SharedTechAssets.Scripts.TechInterfaces.Dispensers.SemanticBlockCoordDispenser _dispenser;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.HashSet<UnityEngine.Vector3Int> _blocks;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int[] intBuffer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.HashSet<UnityEngine.Vector3Int> hitBlocks;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int currPredId;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MeshBlockGeometryHandler(SharedTechAssets.Scripts.ObjectPinner.GeometryHandler.MeshBlockGeometry_Config config, SharedTechAssets.Scripts.TechInterfaces.Dispensers.SemanticBlockCoordDispenser dispenser)
        {
            this.intBuffer = new int[3];
            this.hitBlocks = new System.Collections.Generic.HashSet<UnityEngine.Vector3Int>();
            val_3 = new System.Object();
            this._dispenser = val_3;
            this._config = config;
            mem[1152921523081644384] = "MeshBlockGeometryHandler";
            this._voxelToLabel = new System.Collections.Generic.Dictionary<UnityEngine.Vector3Int, System.String>();
            this._meshObjects = new System.Collections.Generic.Dictionary<UnityEngine.Vector3, UnityEngine.GameObject>();
            this._blocks = new System.Collections.Generic.HashSet<UnityEngine.Vector3Int>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnMeshBlockUpdatedEvent(UnityEngine.Vector3 key, UnityEngine.Vector3[] indexes, int[] triangles)
        {
            if((this._meshObjects.ContainsKey(key:  new UnityEngine.Vector3() {x = key.x, y = key.y, z = key.z})) != false)
            {
                    this._meshObjects.Item[new UnityEngine.Vector3() {x = key.x, y = key.y, z = key.z}].GetComponent<SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.SimpleMeshWithCollider>().UpdateMesh(vertices:  indexes, triangles:  triangles);
                return;
            }
            
            UnityEngine.GameObject val_4 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this._config.meshPrefab);
            this._meshObjects.set_Item(key:  new UnityEngine.Vector3() {x = key.x, y = key.y, z = key.z}, value:  val_4);
            val_4.GetComponent<SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.SimpleMeshWithCollider>().InitializeMesh(vertices:  indexes, triangles:  triangles);
            this._handler.AddGO(go:  val_4, accepter:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3Int DiscretizeVertex(UnityEngine.Vector3 vertex)
        {
            var val_6 = 0;
            do
            {
                float val_4 = this._config.resolution;
                val_4 = System.Math.Abs(vertex.x) / val_4;
                int val_5 = (int)val_4;
                val_4 = val_4 - (float)val_5;
                val_5 = ((val_4 > 0.5f) ? 1 : 0) + val_5;
                int val_2 = (vertex.x < 0) ? (-val_5) : (val_5);
                val_2 = val_2 << 1;
                val_6 = val_6 + 1;
                this.intBuffer[val_6] = val_2;
            }
            while(val_6 != 3);
            
            int val_7 = this.intBuffer[0];
            int val_8 = this.intBuffer[1];
            int val_9 = this.intBuffer[2];
            return new UnityEngine.Vector3Int();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void SemanticsUpdate(UnityEngine.GameObject go, string label, int predId, UnityEngine.RaycastHit hit, float confidence)
        {
            float val_8 = 0.05f;
            val_8 = this._config.resolution * val_8;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Multiply(d:  val_8, a:  new UnityEngine.Vector3() {x = confidence, y = V1.16B, z = V2.16B});
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = confidence, y = V1.16B, z = V2.16B}, b:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            UnityEngine.Vector3Int val_3 = this.DiscretizeVertex(vertex:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            int val_9 = val_3.m_Z;
            if(this.currPredId != predId)
            {
                    this.hitBlocks.Clear();
                this.currPredId = predId;
            }
            
            val_9 = val_9 & 4294967295;
            if((this.hitBlocks.Contains(item:  new UnityEngine.Vector3Int() {m_X = val_3.m_X, m_Y = val_3.m_Y, m_Z = val_9})) == true)
            {
                    return;
            }
            
            bool val_5 = this.hitBlocks.Add(item:  new UnityEngine.Vector3Int() {m_X = val_3.m_X, m_Y = val_3.m_Y, m_Z = val_9});
            if((this._blocks.Contains(item:  new UnityEngine.Vector3Int() {m_X = val_3.m_X, m_Y = val_3.m_Y, m_Z = val_9})) == false)
            {
                    return;
            }
            
            bool val_7 = this._voxelToLabel.ContainsKey(key:  new UnityEngine.Vector3Int() {m_X = val_3.m_X, m_Y = val_3.m_Y, m_Z = val_9});
            this._voxelToLabel.set_Item(key:  new UnityEngine.Vector3Int() {m_X = val_3.m_X, m_Y = val_3.m_Y, m_Z = val_9}, value:  label);
            if(this._dispenser == null)
            {
                goto label_13;
            }
            
            if(val_7 == false)
            {
                goto label_14;
            }
            
            label_15:
            this._dispenser.UpdateBlockCoord(coord:  new UnityEngine.Vector3Int() {m_X = val_3.m_X, m_Y = val_3.m_Y, m_Z = val_9}, label:  label, labelId:  predId, confidence:  confidence);
            return;
            label_13:
            if(val_7 == true)
            {
                goto label_15;
            }
            
            label_14:
            this._dispenser.AddBlockCoord(coord:  new UnityEngine.Vector3Int() {m_X = val_3.m_X, m_Y = val_3.m_Y, m_Z = val_9}, label:  label, labelId:  predId, confidence:  confidence);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void SetupDataHandler(SharedTechAssets.Scripts.ObjectPinner.GeometryHandler.GeometryToDataHandler handler)
        {
            this._handler = handler;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnBlockUpdatedEvent(UnityEngine.Vector3 center, System.Collections.Generic.List<UnityEngine.Vector3> pointsToAdd, System.Collections.Generic.List<UnityEngine.Vector3> pointsToRemove)
        {
            var val_13;
            int val_14;
            System.Collections.Generic.Dictionary<UnityEngine.Vector3Int, System.String> val_15;
            var val_16;
            val_13 = 0;
            goto label_1;
            label_5:
            UnityEngine.Vector3 val_1 = pointsToAdd.Item[0];
            UnityEngine.Vector3Int val_2 = this.DiscretizeVertex(vertex:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            val_14 = val_2.m_X;
            val_15 = val_2.m_Z;
            bool val_4 = this._blocks.Add(item:  new UnityEngine.Vector3Int() {m_X = val_14, m_Y = val_2.m_Y, m_Z = val_15 & 4294967295});
            val_13 = 1;
            label_1:
            if(val_13 < pointsToAdd.Count)
            {
                goto label_5;
            }
            
            val_16 = 0;
            goto label_6;
            label_14:
            UnityEngine.Vector3 val_6 = pointsToRemove.Item[0];
            UnityEngine.Vector3Int val_7 = this.DiscretizeVertex(vertex:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
            val_14 = val_7.m_X;
            int val_13 = val_7.m_Z;
            val_13 = val_13 & 4294967295;
            bool val_8 = this._blocks.Remove(item:  new UnityEngine.Vector3Int() {m_X = val_14, m_Y = val_7.m_Y, m_Z = val_13});
            val_15 = this._voxelToLabel;
            if((val_15.ContainsKey(key:  new UnityEngine.Vector3Int() {m_X = val_14, m_Y = val_7.m_Y, m_Z = val_13})) != false)
            {
                    bool val_10 = this._voxelToLabel.Remove(key:  new UnityEngine.Vector3Int() {m_X = val_14, m_Y = val_7.m_Y, m_Z = val_13});
                val_15 = this._dispenser;
                val_15.RemoveBlockCoord(coord:  new UnityEngine.Vector3Int() {m_X = val_14, m_Y = val_7.m_Y, m_Z = val_13 | 0});
            }
            
            val_16 = 1;
            label_6:
            if(val_16 < pointsToRemove.Count)
            {
                goto label_14;
            }
        
        }
    
    }

}
