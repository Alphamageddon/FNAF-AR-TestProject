using UnityEngine;

namespace SharedTechAssets.Scripts.Adapters
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class IxSemanticVoxelAdapter : ISemanticBlockCoordAccepter
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SharedTechAssets.Scripts.TechInterfaces.IllumixObjectInterfaces.Accepters.IIxSemanticVoxelAccepter _accepter;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _resolution;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(SharedTechAssets.Scripts.TechInterfaces.IllumixObjectInterfaces.Accepters.IIxSemanticVoxelAccepter accepter, float resolution)
        {
            this._accepter = accepter;
            this._resolution = resolution;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 DiscreteToWorldPoint(UnityEngine.Vector3Int intVertex)
        {
            float val_4 = this._resolution;
            float val_2 = (float)intVertex.m_X.GetHashCode();
            float val_3 = 1.152922E+18f;
            val_2 = this._resolution * val_2;
            val_3 = this._resolution * val_3;
            val_4 = val_4 * (1.152922E+18f);
            val_2 = val_2 * 0.5f;
            val_3 = val_3 * 0.5f;
            val_4 = val_4 * 0.5f;
            return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AddBlockCoord(UnityEngine.Vector3Int blockCoord, string label, int predId, float confidence)
        {
            int val_4;
            blockCoord.m_Z = blockCoord.m_Z & 4294967295;
            UnityEngine.Vector3 val_1 = this.DiscreteToWorldPoint(intVertex:  new UnityEngine.Vector3Int() {m_X = blockCoord.m_X, m_Y = blockCoord.m_Y, m_Z = blockCoord.m_Z});
            SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticVoxel val_2 = null;
            val_4 = predId;
            val_2 = new SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticVoxel(center:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, sideLength:  this._resolution, label:  label, labelId:  val_4, confidence:  confidence);
            var val_4 = 0;
            val_4 = val_4 + 1;
            val_4 = 0;
            this._accepter.OnAddVoxelEvent(v:  val_2);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void UpdateBlockCoord(UnityEngine.Vector3Int blockCoord, string label, int predId, float confidence)
        {
            var val_6;
            blockCoord.m_Z = blockCoord.m_Z & 4294967295;
            UnityEngine.Vector3 val_1 = this.DiscreteToWorldPoint(intVertex:  new UnityEngine.Vector3Int() {m_X = blockCoord.m_X, m_Y = blockCoord.m_Y, m_Z = blockCoord.m_Z});
            var val_5 = 0;
            val_5 = val_5 + 1;
            val_6 = 0;
            val_3.Prediction = 0;
            mem2[0] = 0;
            var val_6 = 0;
            val_6 = val_6 + 1;
            val_6 = 1;
            this._accepter.OnUpdateVoxelEvent(v:  this._accepter.GetVoxel(vec:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RemoveBlock(UnityEngine.Vector3Int blockCoord)
        {
            blockCoord.m_Z = blockCoord.m_Z & 4294967295;
            UnityEngine.Vector3 val_1 = this.DiscreteToWorldPoint(intVertex:  new UnityEngine.Vector3Int() {m_X = blockCoord.m_X, m_Y = blockCoord.m_Y, m_Z = blockCoord.m_Z});
            var val_3 = 0;
            val_3 = val_3 + 1;
            this._accepter.OnRemoveVoxelEvent(coord:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public IxSemanticVoxelAdapter()
        {
        
        }
    
    }

}
