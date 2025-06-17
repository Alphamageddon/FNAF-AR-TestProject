using UnityEngine;

namespace DefaultNamespace
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface IIxHorizontalSupportedPlaneAccepter
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void OnPlaneAddEvent(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixHorizontalSupportedPlane plane); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void OnBoundaryUpdateEvent(int key); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void OnSignificantUpdateEvent(int key); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void OnPointsUpdateEvent(int key, System.Collections.Generic.List<UnityEngine.Vector2> points); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void OnTileUpdateEvent(int key, UnityEngine.Vector2 tileCenters); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void OnPlaneRemoveEvent(int key); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixHorizontalSupportedPlane GetPlane(int key); // 0
    
    }

}
