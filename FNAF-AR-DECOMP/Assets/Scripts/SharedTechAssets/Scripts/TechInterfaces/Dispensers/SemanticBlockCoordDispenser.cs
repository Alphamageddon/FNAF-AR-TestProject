using UnityEngine;

namespace SharedTechAssets.Scripts.TechInterfaces.Dispensers
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SemanticBlockCoordDispenser
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.ISemanticBlockCoordAccepter> _accepters;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AddAccepter(SharedTechAssets.Scripts.TechInterfaces.Accepters.ISemanticBlockCoordAccepter accepter)
        {
            this._accepters.Add(item:  accepter);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetAccepters(System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.ISemanticBlockCoordAccepter> accepters)
        {
            this._accepters = accepters;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AddBlockCoord(UnityEngine.Vector3Int coord, string label, int labelId, float confidence)
        {
            var val_4;
            int val_4 = coord.m_Z;
            val_4 = 0;
            val_4 = val_4 & 4294967295;
            goto label_1;
            label_9:
            var val_5 = 0;
            val_5 = val_5 + 1;
            this._accepters.Item[0].AddBlockCoord(blockCoord:  new UnityEngine.Vector3Int() {m_X = coord.m_X, m_Y = coord.m_Y, m_Z = val_4}, label:  label, predId:  labelId, confidence:  confidence);
            val_4 = 1;
            label_1:
            if(val_4 < this._accepters.Count)
            {
                goto label_9;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void UpdateBlockCoord(UnityEngine.Vector3Int coord, string label, int labelId, float confidence)
        {
            var val_4;
            int val_4 = coord.m_Z;
            val_4 = 0;
            val_4 = val_4 & 4294967295;
            goto label_1;
            label_9:
            var val_5 = 0;
            val_5 = val_5 + 1;
            this._accepters.Item[0].UpdateBlockCoord(blockCoord:  new UnityEngine.Vector3Int() {m_X = coord.m_X, m_Y = coord.m_Y, m_Z = val_4}, label:  label, predId:  labelId, confidence:  confidence);
            val_4 = 1;
            label_1:
            if(val_4 < this._accepters.Count)
            {
                goto label_9;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RemoveBlockCoord(UnityEngine.Vector3Int coord)
        {
            var val_4;
            int val_4 = coord.m_Z;
            val_4 = 0;
            val_4 = val_4 & 4294967295;
            goto label_1;
            label_9:
            var val_5 = 0;
            val_5 = val_5 + 1;
            this._accepters.Item[0].RemoveBlock(blockCoord:  new UnityEngine.Vector3Int() {m_X = coord.m_X, m_Y = coord.m_Y, m_Z = val_4});
            val_4 = 1;
            label_1:
            if(val_4 < this._accepters.Count)
            {
                goto label_9;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SemanticBlockCoordDispenser()
        {
            this._accepters = new System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.ISemanticBlockCoordAccepter>();
        }
    
    }

}
