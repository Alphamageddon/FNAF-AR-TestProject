using UnityEngine;

namespace SharedTechAssets.Scripts.TechInterfaces.IllumixObjectInterfaces.Accepters
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface IIxSemanticHorizontalPlaneAccepter
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void OnPlaneAddEvent(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticHorizontalPlane plane); // 0
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
        public abstract void OnTileLabelEvent(int key, UnityEngine.Vector2 tileCenter, string label, float confidence); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticHorizontalPlane GetPlane(int key); // 0
    
    }

}
