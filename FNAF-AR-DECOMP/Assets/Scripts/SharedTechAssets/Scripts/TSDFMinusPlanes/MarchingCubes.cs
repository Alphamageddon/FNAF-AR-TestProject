using UnityEngine;

namespace SharedTechAssets.Scripts.TSDFMinusPlanes
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class MarchingCubes
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private com.illumix.IntVector3.IntVector3Cache _coordCache;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private MeshBlockDispenser _dispenser;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float resolution;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<com.illumix.IntVector3.IntVector3, SharedTechAssets.Scripts.TSDFMinusPlanes.MarchingCubes.MeshBlock> cachedBlocks;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int blockSize;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<int> triangleList;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.HashSet<com.illumix.IntVector3.IntVector3> blocksUpdated;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.HashSet<com.illumix.IntVector3.IntVector3> seenCubes;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MarchingCubes(com.illumix.IntVector3.IntVector3Cache cache, MeshBlockDispenser dispenser)
        {
            this.resolution = 0.05f;
            this.blockSize = 4;
            this.triangleList = new System.Collections.Generic.List<System.Int32>();
            this.seenCubes = new System.Collections.Generic.HashSet<com.illumix.IntVector3.IntVector3>();
            val_3 = new System.Object();
            this._coordCache = cache;
            this.blocksUpdated = new System.Collections.Generic.HashSet<com.illumix.IntVector3.IntVector3>();
            this._dispenser = val_3;
            this.cachedBlocks = new System.Collections.Generic.Dictionary<com.illumix.IntVector3.IntVector3, MeshBlock>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private com.illumix.IntVector3.IntVector3 IdxToVectorPosition(com.illumix.IntVector3.IntVector3 base_vec, int idx)
        {
            if(idx <= 7)
            {
                    var val_42 = 52950336 + (idx) << 2;
                val_42 = val_42 + 52950336;
            }
            else
            {
                    System.Exception val_41 = new System.Exception(message:  "Invalid idx");
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector3 IntVectorToVertexPosition(com.illumix.IntVector3.IntVector3 intVertex, float resolution)
        {
            var val_6;
            var val_7;
            if(intVertex != null)
            {
                    val_6 = intVertex.Item1;
                val_7 = intVertex.Item2;
            }
            else
            {
                    val_6 = 0.Item1;
                val_7 = 0.Item2;
            }
            
            float val_6 = (float)val_6;
            float val_7 = (float)val_7;
            float val_8 = (float)intVertex.Item3;
            float val_9 = 0.5f;
            val_6 = val_6 * resolution;
            val_7 = val_7 * resolution;
            val_8 = val_8 * resolution;
            val_6 = val_6 * val_9;
            val_7 = val_7 * val_9;
            val_9 = val_8 * val_9;
            return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CubeTypeToTriangles(int cubeType, com.illumix.IntVector3.IntVector3 baseVector, SharedTechAssets.Scripts.TSDFMinusPlanes.MarchingCubes.MeshBlock block)
        {
            MeshBlock val_25;
            com.illumix.IntVector3.IntVector3 val_26;
            int val_27;
            var val_28;
            var val_29;
            var val_30;
            var val_31;
            var val_32;
            int val_33;
            var val_34;
            var val_35;
            val_25 = block;
            val_26 = baseVector;
            val_27 = cubeType;
            val_28 = 1152921505070956544;
            val_29 = (long)val_27;
            val_30 = 0;
            goto label_1;
            label_32:
            val_31 = null;
            val_31 = null;
            val_32 = mem[MarchingCubeConstants.triTable + 16];
            val_32 = MarchingCubeConstants.triTable + 16;
            if(val_32 <= val_27)
            {
                    val_32 = mem[MarchingCubeConstants.triTable + 16];
                val_32 = MarchingCubeConstants.triTable + 16;
            }
            
            var val_1 = X22 + ((MarchingCubeConstants.triTable + 16 + 16) * val_29);
            System.Int32[,] val_2 = MarchingCubeConstants.triTable + (((MarchingCubeConstants.triTable + 16 + 16 * (long)(int)(cubeType)) + X22) << 2);
            com.illumix.IntVector3.IntVector3[] val_3 = MarchingCubeConstants.edgeIdxToCoords + (((MarchingCubeConstants.triTable + ((MarchingCubeConstants.triTable + 16 + 16 * (long)(int)(cubeType)) + X22) << 2) + 32) << 3);
            com.illumix.IntVector3.IntVector3 val_13 = this._coordCache.GenerateIntVector(x:  ((MarchingCubeConstants.edgeIdxToCoords + ((MarchingCubeConstants.triTable + ((MarchingCubeConstants.triTable + 16 + 16 * (long)(int)(cubeType)) + X22) << 2) + 32) << 3) + 32.Item1) + val_26.Item1, y:  ((MarchingCubeConstants.edgeIdxToCoords + ((MarchingCubeConstants.triTable + ((MarchingCubeConstants.triTable + 16 + 16 * (long)(int)(cubeType)) + X22) << 2) + 32) << 3) + 32.Item2) + val_26.Item2, z:  ((MarchingCubeConstants.edgeIdxToCoords + ((MarchingCubeConstants.triTable + ((MarchingCubeConstants.triTable + 16 + 16 * (long)(int)(cubeType)) + X22) << 2) + 32) << 3) + 32.Item3) + val_26.Item3);
            UnityEngine.Vector3 val_14 = val_13.IntVectorToVertexPosition(intVertex:  val_13, resolution:  this.resolution);
            val_25 = val_25;
            val_29 = val_29;
            val_27 = val_27;
            val_26 = val_26;
            val_28 = val_28;
            if((block + 24.ContainsKey(key:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z})) != true)
            {
                    if((block + 24) != 0)
            {
                    val_33 = block + 24.Count;
            }
            else
            {
                    val_33 = block + 24.Count;
            }
            
                block + 24.set_Item(key:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, value:  val_33);
                block + 16.Add(item:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z});
            }
            
            if(val_30 == 0)
            {
                    block + 32.set_Item(key:  val_26, value:  new System.Collections.Generic.List<System.Int32>());
            }
            
            block + 32.Item[val_26].Add(item:  block + 24.Item[new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}]);
            val_30 = val_30 + 1;
            label_1:
            val_34 = null;
            val_35 = mem[MarchingCubeConstants.triTable + 16];
            val_35 = MarchingCubeConstants.triTable + 16;
            if(val_35 <= val_27)
            {
                    val_35 = mem[MarchingCubeConstants.triTable + 16];
                val_35 = MarchingCubeConstants.triTable + 16;
            }
            
            var val_21 = (long)val_30 + ((MarchingCubeConstants.triTable + 16 + 16) * val_29);
            System.Int32[,] val_22 = MarchingCubeConstants.triTable + (((MarchingCubeConstants.triTable + 16 + 16 * (long)(int)(cubeType)) + (long)(int)((val_30 + 1))) << 2);
            if(((MarchingCubeConstants.triTable + ((MarchingCubeConstants.triTable + 16 + 16 * (long)(int)(cubeType)) + (long)(int)((val_30 + 1))) << 2) + 32) != 1)
            {
                goto label_32;
            }
            
            if(val_30 != 0)
            {
                    return;
            }
            
            val_30 = mem[block + 32];
            val_30 = block + 32;
            if((val_30.ContainsKey(key:  val_26)) == false)
            {
                    return;
            }
            
            bool val_24 = block + 32.Remove(key:  val_26);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public com.illumix.IntVector3.IntVector3 GetBlockKey(com.illumix.IntVector3.IntVector3 discretePoint)
        {
            var val_28;
            var val_29;
            int val_30;
            var val_31;
            var val_32;
            int val_33;
            var val_34;
            int val_35;
            int val_36;
            if(discretePoint != null)
            {
                    val_28 = discretePoint.Item1;
                val_29 = discretePoint;
            }
            else
            {
                    val_28 = 0.Item1;
                val_29 = 0;
            }
            
            int val_3 = val_29.Item1;
            int val_23 = this.blockSize;
            if((val_28 & 2147483648) != 0)
            {
                goto label_2;
            }
            
            var val_4 = (val_3 < 0) ? (val_3 + 1) : (val_3);
            val_4 = val_4 >> 1;
            val_30 = val_4 / val_23;
            if(discretePoint == null)
            {
                goto label_3;
            }
            
            label_5:
            val_31 = discretePoint.Item2;
            val_32 = discretePoint;
            goto label_4;
            label_2:
            var val_8 = ((val_3 + 1) < 0) ? (val_3 + 2) : (val_3 + 1);
            val_8 = val_8 >> 1;
            val_23 = val_8 / val_23;
            val_30 = val_23 - 1;
            if(discretePoint != null)
            {
                goto label_5;
            }
            
            label_3:
            val_31 = 0.Item2;
            val_32 = 0;
            label_4:
            int val_10 = val_32.Item2;
            int val_24 = val_23;
            if((val_31 & 2147483648) != 0)
            {
                goto label_6;
            }
            
            var val_11 = (val_10 < 0) ? (val_10 + 1) : (val_10);
            val_11 = val_11 >> 1;
            val_33 = val_11 / val_24;
            if(discretePoint == null)
            {
                goto label_7;
            }
            
            label_10:
            val_34 = discretePoint;
            int val_13 = val_34.Item3;
            val_35 = val_23;
            if((discretePoint.Item3 & 2147483648) != 0)
            {
                goto label_8;
            }
            
            label_11:
            var val_14 = (val_13 < 0) ? (val_13 + 1) : (val_13);
            val_14 = val_14 >> 1;
            val_36 = val_14 / val_35;
            goto label_9;
            label_6:
            var val_17 = ((val_10 + 1) < 0) ? (val_10 + 2) : (val_10 + 1);
            val_17 = val_17 >> 1;
            val_24 = val_17 / val_24;
            val_33 = val_24 - 1;
            if(discretePoint != null)
            {
                goto label_10;
            }
            
            label_7:
            val_34 = 0;
            int val_19 = val_34.Item3;
            val_35 = val_23;
            if((0.Item3 & 2147483648) == 0)
            {
                goto label_11;
            }
            
            label_8:
            var val_22 = ((val_19 + 1) < 0) ? (val_19 + 2) : (val_19 + 1);
            val_22 = val_22 >> 1;
            val_35 = val_22 / val_35;
            val_36 = val_35 - 1;
            label_9:
            if(this._coordCache != null)
            {
                    return this._coordCache.GenerateIntVector(x:  val_30, y:  val_33, z:  val_36);
            }
            
            return this._coordCache.GenerateIntVector(x:  val_30, y:  val_33, z:  val_36);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GetMeshInfoFromBlock(SharedTechAssets.Scripts.TSDFMinusPlanes.MarchingCubes.MeshBlock block, out UnityEngine.Vector3[] coordsArr, out int[] trianglesArr)
        {
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_2 = block.cubeToTriangles.Keys.GetEnumerator();
            label_7:
            if((1248963016 & 1) == 0)
            {
                goto label_4;
            }
            
            this.triangleList.AddRange(collection:  block.cubeToTriangles.Item[0.emailUIDataHandler]);
            goto label_7;
            label_4:
            long val_5 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523035679176});
            coordsArr = block.vertices_1d_list.ToArray();
            trianglesArr = this.triangleList.ToArray();
            this.triangleList.Clear();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public com.illumix.IntVector3.IntVector3 BlockKeyToResolutionSpace(com.illumix.IntVector3.IntVector3 blockKey)
        {
            int val_12;
            var val_13;
            int val_14;
            var val_15;
            if(blockKey != null)
            {
                    val_12 = this.blockSize;
                val_13 = blockKey.Item1;
                val_14 = val_12;
                val_15 = blockKey.Item2;
                return this._coordCache.GenerateIntVector(x:  (val_13 * val_12) << 1, y:  (val_14 * val_15) << 1, z:  (blockKey.Item3 * val_12) << 1);
            }
            
            val_12 = this.blockSize;
            val_13 = 0.Item1;
            val_14 = val_12;
            val_15 = 0.Item2;
            return this._coordCache.GenerateIntVector(x:  (val_13 * val_12) << 1, y:  (val_14 * val_15) << 1, z:  (blockKey.Item3 * val_12) << 1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SendMeshBlockEvents()
        {
            var val_3;
            System.Int32[] val_7 = 0;
            UnityEngine.Vector3[] val_6 = 0;
            HashSet.Enumerator<T> val_1 = this.blocksUpdated.GetEnumerator();
            label_9:
            if((1249372192 & 1) == 0)
            {
                goto label_2;
            }
            
            GameUI.EmailUIDataHandler val_4 = val_3.emailUIDataHandler;
            this.GetMeshInfoFromBlock(block:  this.cachedBlocks.Item[val_4], coordsArr: out  val_6, trianglesArr: out  val_7);
            com.illumix.IntVector3.IntVector3 val_8 = this.BlockKeyToResolutionSpace(blockKey:  val_4);
            com.illumix.IntVector3.IntVector3 val_18 = this._coordCache.GenerateIntVector(x:  val_8.Item1 + (((this.blockSize < 0) ? (this.blockSize + 1) : this.blockSize) >> 1), y:  val_8.Item2 + (((this.blockSize < 0) ? (this.blockSize + 1) : this.blockSize) >> 1), z:  val_8.Item3 + (((this.blockSize < 0) ? (this.blockSize + 1) : this.blockSize) >> 1));
            UnityEngine.Vector3 val_19 = val_18.IntVectorToVertexPosition(intVertex:  val_18, resolution:  this.resolution);
            this._dispenser.SendMeshBlockEvent(key:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z}, vertices:  val_6, triangles:  val_7);
            goto label_9;
            label_2:
            long val_20 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523036088352});
            this.blocksUpdated.Clear();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void PerformMarchingCubes(System.Collections.Generic.HashSet<com.illumix.IntVector3.IntVector3> discretizedPoints, System.Collections.Generic.Dictionary<com.illumix.IntVector3.IntVector3, bool> updatedPoints)
        {
            var val_4;
            var val_28;
            int val_29;
            this.seenCubes.Clear();
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_2 = updatedPoints.Keys.GetEnumerator();
            label_12:
            if((1249596864 & 1) == 0)
            {
                goto label_4;
            }
            
            GameUI.EmailUIDataHandler val_5 = val_4.emailUIDataHandler;
            var val_28 = 0;
            label_11:
            com.illumix.IntVector3.IntVector3 val_7 = this.IdxToVectorPosition(base_vec:  val_5, idx:  0);
            com.illumix.IntVector3.IntVector3 val_8 = this.GetBlockKey(discretePoint:  val_7);
            if((this.cachedBlocks.ContainsKey(key:  val_8)) != true)
            {
                    new MarchingCubes.MeshBlock() = new MarchingCubes.MeshBlock();
                this.cachedBlocks.set_Item(key:  val_8, value:  new MarchingCubes.MeshBlock());
            }
            
            if((this.seenCubes.Contains(item:  val_7)) == false)
            {
                goto label_10;
            }
            
            label_22:
            val_28 = val_28 + 1;
            if(val_28 <= 6)
            {
                goto label_11;
            }
            
            goto label_12;
            label_10:
            val_28 = null;
            val_28 = null;
            int val_12 = MarchingCubeConstants.InverseEdge.Item[0];
            int val_13 = val_12 & 31;
            var val_29 = 0;
            val_13 = 1 << val_13;
            do
            {
                int val_16 = (val_12 + 1) + val_29;
                var val_18 = (val_16 < 0) ? (val_16 + 7) : (val_16);
                val_18 = val_18 & 4294967288;
                int val_19 = val_16 - val_18;
                if((discretizedPoints.Contains(item:  this.IdxToVectorPosition(base_vec:  val_7, idx:  val_19))) != false)
            {
                    int val_22 = val_19 & 31;
                val_22 = 1 << val_22;
                val_29 = val_22 | ((updatedPoints.Item[val_5] != true) ? (val_13) : 0);
            }
            
                val_29 = val_29 + 1;
            }
            while(val_29 < 7);
            
            bool val_23 = this.seenCubes.Add(item:  val_7);
            this.CubeTypeToTriangles(cubeType:  val_29, baseVector:  val_7, block:  this.cachedBlocks.Item[val_8]);
            bool val_25 = this.blocksUpdated.Add(item:  val_8);
            goto label_22;
            label_4:
            long val_26 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523036313024});
            this.SendMeshBlockEvents();
        }
    
    }

}
