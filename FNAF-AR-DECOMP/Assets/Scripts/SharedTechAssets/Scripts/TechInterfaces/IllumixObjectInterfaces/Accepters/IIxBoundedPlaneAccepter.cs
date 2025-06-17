using UnityEngine;

namespace SharedTechAssets.Scripts.TechInterfaces.IllumixObjectInterfaces.Accepters
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface IIxBoundedPlaneAccepter
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void OnHorizontalBoundedPlaneAddEvent(IllumixHorizontalBoundedPlane plane); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void OnHorizontalBoundedPlaneUpdateEvent(int key); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void OnHorizontalBoundedPlaneRemoveEvent(int key); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void OnVerticalBoundedPlaneAddEvent(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalBoundedPlane plane); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void OnVerticalBoundedPlaneUpdateEvent(int key); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void OnVerticalBoundedPlaneRemoveEvent(int key); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalBoundedPlane GetVerticalBoundedPlane(int key); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract IllumixHorizontalBoundedPlane GetHorizontalBoundedPlane(int key); // 0
    
    }

}
