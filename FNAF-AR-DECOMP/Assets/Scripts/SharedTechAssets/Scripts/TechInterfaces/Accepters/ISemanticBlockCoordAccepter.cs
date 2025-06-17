using UnityEngine;

namespace SharedTechAssets.Scripts.TechInterfaces.Accepters
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface ISemanticBlockCoordAccepter
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void AddBlockCoord(UnityEngine.Vector3Int blockCoord, string label, int predId, float confidence); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void UpdateBlockCoord(UnityEngine.Vector3Int blockCoord, string label, int predId, float confidence); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void RemoveBlock(UnityEngine.Vector3Int blockCoord); // 0
    
    }

}
