using UnityEngine;

namespace SharedTechAssets.Scripts.TechInterfaces.Accepters
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface ITrackedObjectAccepter
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void AddObject(SharedTechAssets.Scripts.ObjectPinner.ObjectTracking.ObjectGeometryUpdate update); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void UpdateObject(SharedTechAssets.Scripts.ObjectPinner.ObjectTracking.ObjectGeometryUpdate update); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void RemoveObject(int objId); // 0
    
    }

}
