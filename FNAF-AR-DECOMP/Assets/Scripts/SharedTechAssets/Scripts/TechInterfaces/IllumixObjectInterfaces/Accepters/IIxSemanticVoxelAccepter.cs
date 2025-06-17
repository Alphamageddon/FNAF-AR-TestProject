using UnityEngine;

namespace SharedTechAssets.Scripts.TechInterfaces.IllumixObjectInterfaces.Accepters
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface IIxSemanticVoxelAccepter
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void OnAddVoxelEvent(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticVoxel v); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void OnUpdateVoxelEvent(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticVoxel v); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void OnRemoveVoxelEvent(UnityEngine.Vector3 coord); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticVoxel GetVoxel(UnityEngine.Vector3 vec); // 0
    
    }

}
