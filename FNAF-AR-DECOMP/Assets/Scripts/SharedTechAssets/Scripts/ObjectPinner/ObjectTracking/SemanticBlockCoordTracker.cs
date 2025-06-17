using UnityEngine;

namespace SharedTechAssets.Scripts.ObjectPinner.ObjectTracking
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SemanticBlockCoordTracker : ISemanticBlockCoordAccepter
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<UnityEngine.Vector3Int, SharedTechAssets.Scripts.ObjectPinner.ObjectTracking.SemanticBlockCoordTracker.BlockInfo> CoordToInfo;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<UnityEngine.Vector3Int> NewLabeledBlocks;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<UnityEngine.Vector3Int> AlreadyLabeledBlocks;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<UnityEngine.Vector3Int> CoordsToRemove;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<int> CurrentObjectCollisions;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<UnityEngine.Vector3Int, SharedTechAssets.Scripts.ObjectPinner.ObjectTracking.SemanticBlockCoordTracker.BlockInfo> VoxelsToRemove;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float VoxelResolution;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SemanticBlockCoordTracker(float voxelResolution)
        {
            this.VoxelResolution = voxelResolution;
            this.CoordToInfo = new System.Collections.Generic.Dictionary<UnityEngine.Vector3Int, BlockInfo>();
            this.NewLabeledBlocks = new System.Collections.Generic.List<UnityEngine.Vector3Int>();
            this.AlreadyLabeledBlocks = new System.Collections.Generic.List<UnityEngine.Vector3Int>();
            this.CurrentObjectCollisions = new System.Collections.Generic.List<System.Int32>();
            this.CoordsToRemove = new System.Collections.Generic.List<UnityEngine.Vector3Int>();
            this.VoxelsToRemove = new System.Collections.Generic.Dictionary<UnityEngine.Vector3Int, BlockInfo>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void LabelNewVoxels(int id, string label)
        {
            string val_7;
            var val_8;
            var val_9;
            val_7 = label;
            val_8 = 1152921523074484688;
            val_9 = 0;
            goto label_1;
            label_9:
            UnityEngine.Vector3Int val_1 = this.NewLabeledBlocks.Item[0];
            int val_2 = val_1.m_Z & 4294967295;
            if((this.CoordToInfo.ContainsKey(key:  new UnityEngine.Vector3Int() {m_X = val_1.m_X, m_Y = val_1.m_Y, m_Z = val_2})) != true)
            {
                    this.CoordToInfo.set_Item(key:  new UnityEngine.Vector3Int() {m_X = val_1.m_X, m_Y = val_1.m_Y, m_Z = val_2}, value:  new BlockInfo() {LabelToObjId = new System.Collections.Generic.Dictionary<System.String, System.Int32>()});
                val_8 = val_8;
                val_7 = val_7;
            }
            
            BlockInfo val_5 = this.CoordToInfo.Item[new UnityEngine.Vector3Int() {m_X = val_1.m_X, m_Y = val_1.m_Y, m_Z = val_2}];
            val_5.LabelToObjId.set_Item(key:  val_7, value:  id);
            val_9 = 1;
            label_1:
            if(val_9 < this.NewLabeledBlocks.Count)
            {
                goto label_9;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RelabelVoxels(int id, string label)
        {
            string val_7;
            var val_8;
            var val_9;
            val_7 = label;
            val_8 = 1152921523074484688;
            val_9 = 0;
            goto label_1;
            label_9:
            UnityEngine.Vector3Int val_1 = this.AlreadyLabeledBlocks.Item[0];
            int val_2 = val_1.m_Z & 4294967295;
            if((this.CoordToInfo.ContainsKey(key:  new UnityEngine.Vector3Int() {m_X = val_1.m_X, m_Y = val_1.m_Y, m_Z = val_2})) != true)
            {
                    this.CoordToInfo.set_Item(key:  new UnityEngine.Vector3Int() {m_X = val_1.m_X, m_Y = val_1.m_Y, m_Z = val_2}, value:  new BlockInfo() {LabelToObjId = new System.Collections.Generic.Dictionary<System.String, System.Int32>()});
                val_8 = val_8;
                val_7 = val_7;
            }
            
            BlockInfo val_5 = this.CoordToInfo.Item[new UnityEngine.Vector3Int() {m_X = val_1.m_X, m_Y = val_1.m_Y, m_Z = val_2}];
            val_5.LabelToObjId.set_Item(key:  val_7, value:  id);
            val_9 = 1;
            label_1:
            if(val_9 < this.AlreadyLabeledBlocks.Count)
            {
                goto label_9;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RelabelVoxelsForObject(System.Collections.Generic.HashSet<UnityEngine.Vector3Int> voxelCoords, int id, string label)
        {
            var val_6;
            var val_7;
            HashSet.Enumerator<T> val_1 = voxelCoords.GetEnumerator();
            label_5:
            if((1293171536 & 1) == 0)
            {
                goto label_2;
            }
            
            BlockInfo val_4 = this.CoordToInfo.Item[new UnityEngine.Vector3Int() {m_X = 1293171536, m_Y = 268435460, m_Z = 1287534896}];
            val_4.LabelToObjId.set_Item(key:  label, value:  id);
            goto label_5;
            label_2:
            val_6 = 0;
            val_7 = 1;
            long val_5 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523079887696});
            if(( & 1) != 0)
            {
                    return;
            }
            
            if( == 0)
            {
                    return;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void PopulateVoxelsToRemove()
        {
            var val_7;
            System.Collections.Generic.Dictionary<UnityEngine.Vector3Int, BlockInfo> val_8;
            val_7 = 0;
            goto label_1;
            label_9:
            UnityEngine.Vector3Int val_1 = X21.Item[0];
            val_8 = this.CoordToInfo;
            int val_2 = val_1.m_Z & 4294967295;
            if((val_8.ContainsKey(key:  new UnityEngine.Vector3Int() {m_X = val_1.m_X, m_Y = val_1.m_Y, m_Z = val_2})) != false)
            {
                    BlockInfo val_4 = this.CoordToInfo.Item[new UnityEngine.Vector3Int() {m_X = val_1.m_X, m_Y = val_1.m_Y, m_Z = val_2}];
                this.VoxelsToRemove.set_Item(key:  new UnityEngine.Vector3Int() {m_X = val_1.m_X, m_Y = val_1.m_Y, m_Z = val_2}, value:  new BlockInfo() {LabelToObjId = val_4.LabelToObjId});
                val_8 = this.CoordToInfo;
                bool val_5 = val_8.Remove(key:  new UnityEngine.Vector3Int() {m_X = val_1.m_X, m_Y = val_1.m_Y, m_Z = val_2});
            }
            
            val_7 = 1;
            label_1:
            if(val_7 < this.CoordsToRemove.Count)
            {
                goto label_9;
            }
            
            this.CoordsToRemove.Clear();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ClearInfo()
        {
            this.NewLabeledBlocks.Clear();
            this.AlreadyLabeledBlocks.Clear();
            this.CurrentObjectCollisions.Clear();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AddBlockCoord(UnityEngine.Vector3Int blockCoord, string label, int predId, float confidence)
        {
            blockCoord.m_Z = blockCoord.m_Z & 4294967295;
            this.NewLabeledBlocks.Add(item:  new UnityEngine.Vector3Int() {m_X = blockCoord.m_X, m_Y = blockCoord.m_Y, m_Z = blockCoord.m_Z});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void UpdateBlockCoord(UnityEngine.Vector3Int blockCoord, string label, int predId, float confidence)
        {
            var val_12;
            var val_13;
            System.Collections.Generic.List<System.Int32> val_14;
            System.Collections.Generic.List<UnityEngine.Vector3Int> val_15;
            int val_11 = blockCoord.m_Z;
            val_11 = val_11 & 4294967295;
            if((this.CoordToInfo.ContainsKey(key:  new UnityEngine.Vector3Int() {m_X = blockCoord.m_X, m_Y = blockCoord.m_Y, m_Z = val_11})) == true)
            {
                goto label_10;
            }
            
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_3 = this.CoordToInfo.Keys.GetEnumerator();
            label_6:
            if((1293762928 & 1) == 0)
            {
                goto label_5;
            }
            
            goto label_6;
            label_5:
            val_12 = 0;
            val_13 = 1;
            long val_6 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523080479088});
            label_10:
            BlockInfo val_7 = this.CoordToInfo.Item[new UnityEngine.Vector3Int() {m_X = blockCoord.m_X, m_Y = blockCoord.m_Y, m_Z = val_11}];
            val_14 = val_7.LabelToObjId;
            if((val_14.ContainsKey(key:  label)) == false)
            {
                goto label_13;
            }
            
            int val_9 = val_14.Item[label];
            val_14 = this.CurrentObjectCollisions;
            if((val_14.Contains(item:  val_9)) != true)
            {
                    val_14 = this.CurrentObjectCollisions;
                val_14.Add(item:  val_9);
            }
            
            val_15 = this.AlreadyLabeledBlocks;
            if(val_15 != null)
            {
                goto label_20;
            }
            
            goto label_19;
            label_13:
            val_15 = this.NewLabeledBlocks;
            if(val_15 != null)
            {
                goto label_20;
            }
            
            label_19:
            label_20:
            val_15.Add(item:  new UnityEngine.Vector3Int() {m_X = blockCoord.m_X, m_Y = blockCoord.m_Y, m_Z = val_11});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RemoveBlock(UnityEngine.Vector3Int blockCoord)
        {
            blockCoord.m_Z = blockCoord.m_Z & 4294967295;
            this.CoordsToRemove.Add(item:  new UnityEngine.Vector3Int() {m_X = blockCoord.m_X, m_Y = blockCoord.m_Y, m_Z = blockCoord.m_Z});
        }
    
    }

}
