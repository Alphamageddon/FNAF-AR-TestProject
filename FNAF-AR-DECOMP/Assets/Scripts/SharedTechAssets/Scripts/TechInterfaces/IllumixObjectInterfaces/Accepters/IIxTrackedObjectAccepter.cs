using UnityEngine;

namespace SharedTechAssets.Scripts.TechInterfaces.IllumixObjectInterfaces.Accepters
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface IIxTrackedObjectAccepter
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void AddTrackedObject(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxTrackedObject obj); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void UpdateTrackedObject(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxTrackedObject obj, SharedTechAssets.Scripts.ObjectPinner.ObjectTracking.ObjectGeometryUpdate update); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void RemoveTrackedObject(int objId); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxTrackedObject GetObject(int objId); // 0
    
    }

}
