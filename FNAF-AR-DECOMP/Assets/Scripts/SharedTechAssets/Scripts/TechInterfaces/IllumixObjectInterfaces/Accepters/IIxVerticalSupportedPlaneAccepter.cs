using UnityEngine;

namespace SharedTechAssets.Scripts.TechInterfaces.IllumixObjectInterfaces.Accepters
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface IIxVerticalSupportedPlaneAccepter
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void OnPlaneAddEvent(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalSupportedPlane plane); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void OnBoundaryUpdateEvent(int key); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void OnSignificantUpdateEvent(int key); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void OnPointsUpdateEvent(int key, System.Collections.Generic.Dictionary<UnityEngine.Vector2, UnityEngine.Vector3> points); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void OnTileUpdateEvent(int key, UnityEngine.Vector2 planeSpaceCenter, UnityEngine.Vector3[] tileCoords); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void OnRemoveEvent(int key); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalSupportedPlane GetPlane(int key); // 0
    
    }

}
