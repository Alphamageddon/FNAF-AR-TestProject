using UnityEngine;

namespace SharedTechAssets.Scripts.TechInterfaces.Accepters
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface ISupportedHorizontalPlaneAccepter
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void OnHorizontalSupportedPlaneAdd(int id, System.Collections.Generic.List<UnityEngine.Vector3> boundary, UnityEngine.Vector3 center, UnityEngine.Vector2 discretizedCenter, float tileLength); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void OnHorizontalSupportedPlaneAddPoints(int id, System.Collections.Generic.List<UnityEngine.Vector2> points); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void OnHorizontalSupportedPlaneUpdateBoundary(int id, System.Collections.Generic.List<UnityEngine.Vector3> boundary, float height); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void OnHorizontalSupportedPlaneSignificantUpdate(int id, System.Collections.Generic.List<UnityEngine.Vector3> boundary, float height); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void OnHorizontalSupportedPlaneAddTile(int id, UnityEngine.Vector2 center); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void OnHorizontalSupportedPlaneRemove(int id); // 0
    
    }

}
