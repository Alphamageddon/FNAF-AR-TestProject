using UnityEngine;

namespace SharedTechAssets.Scripts.Adapters
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class IxSupportedPlaneAdapter : ISupportedVerticalPlaneAccepter, ISupportedHorizontalPlaneAccepter
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private DefaultNamespace.IIxHorizontalSupportedPlaneAccepter _horizontalSupportedPlaneAccepter;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SharedTechAssets.Scripts.TechInterfaces.IllumixObjectInterfaces.Accepters.IIxVerticalSupportedPlaneAccepter _verticalSupportedPlaneAccepter;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(DefaultNamespace.IIxHorizontalSupportedPlaneAccepter horizontalSupportedPlaneAccepter, SharedTechAssets.Scripts.TechInterfaces.IllumixObjectInterfaces.Accepters.IIxVerticalSupportedPlaneAccepter verticalSupportedPlaneAccepter)
        {
            this._horizontalSupportedPlaneAccepter = horizontalSupportedPlaneAccepter;
            this._verticalSupportedPlaneAccepter = verticalSupportedPlaneAccepter;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnHorizontalSupportedPlaneAdd(int id, System.Collections.Generic.List<UnityEngine.Vector3> boundary, UnityEngine.Vector3 center, UnityEngine.Vector2 discretizedCenter, float tileLength)
        {
            int val_3;
            SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixHorizontalSupportedPlane val_1 = null;
            val_3 = id;
            val_1 = new SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixHorizontalSupportedPlane(boundary:  boundary, initialCenter:  new UnityEngine.Vector3() {x = center.x, y = center.y, z = center.z}, discretizedCenter:  new UnityEngine.Vector2() {x = discretizedCenter.x, y = discretizedCenter.y}, updateKey:  val_3, tileLength:  tileLength);
            var val_3 = 0;
            val_3 = val_3 + 1;
            val_3 = 0;
            this._horizontalSupportedPlaneAccepter.OnPlaneAddEvent(plane:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnHorizontalSupportedPlaneAddPoints(int id, System.Collections.Generic.List<UnityEngine.Vector2> points)
        {
            var val_4 = 0;
            val_4 = val_4 + 1;
            this._horizontalSupportedPlaneAccepter.GetPlane(key:  id).UpdatePoints(newPoints:  points);
            var val_5 = 0;
            val_5 = val_5 + 1;
            this._horizontalSupportedPlaneAccepter.OnPointsUpdateEvent(key:  id, points:  points);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnHorizontalSupportedPlaneUpdateBoundary(int id, System.Collections.Generic.List<UnityEngine.Vector3> boundary, float height)
        {
            var val_4;
            var val_4 = 0;
            val_4 = val_4 + 1;
            val_4 = 0;
            this._horizontalSupportedPlaneAccepter.GetPlane(key:  id).UpdatePlane(boundary:  boundary, weightedHeight:  height);
            var val_5 = 0;
            val_5 = val_5 + 1;
            val_4 = 1;
            this._horizontalSupportedPlaneAccepter.OnBoundaryUpdateEvent(key:  id);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnHorizontalSupportedPlaneSignificantUpdate(int id, System.Collections.Generic.List<UnityEngine.Vector3> boundary, float height)
        {
            var val_4;
            var val_4 = 0;
            val_4 = val_4 + 1;
            val_4 = 0;
            this._horizontalSupportedPlaneAccepter.GetPlane(key:  id).UpdatePlane(boundary:  boundary, weightedHeight:  height);
            var val_5 = 0;
            val_5 = val_5 + 1;
            val_4 = 2;
            this._horizontalSupportedPlaneAccepter.OnSignificantUpdateEvent(key:  id);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnHorizontalSupportedPlaneAddTile(int id, UnityEngine.Vector2 center)
        {
            var val_4;
            var val_4 = 0;
            val_4 = val_4 + 1;
            val_4 = public SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixHorizontalSupportedPlane DefaultNamespace.IIxHorizontalSupportedPlaneAccepter::GetPlane(int key);
            this._horizontalSupportedPlaneAccepter.GetPlane(key:  id).AddTile(tile:  new UnityEngine.Vector2() {x = center.x, y = center.y});
            var val_5 = 0;
            val_5 = val_5 + 1;
            val_4 = 4;
            this._horizontalSupportedPlaneAccepter.OnTileUpdateEvent(key:  id, tileCenters:  new UnityEngine.Vector2() {x = center.x, y = center.y});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnHorizontalSupportedPlaneRemove(int id)
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            this._horizontalSupportedPlaneAccepter.OnPlaneRemoveEvent(key:  id);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnVerticalSupportedPlaneAdd(int id, System.Collections.Generic.List<UnityEngine.Vector3> boundary, UnityEngine.Vector3 normal, UnityEngine.Vector3 center)
        {
            int val_3;
            SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalSupportedPlane val_1 = null;
            val_3 = id;
            val_1 = new SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalSupportedPlane(boundary:  boundary, initialCenter:  new UnityEngine.Vector3() {x = center.x, y = center.y, z = center.z}, normal:  new UnityEngine.Vector3() {x = normal.x, y = normal.y, z = normal.z}, updateKey:  val_3);
            var val_3 = 0;
            val_3 = val_3 + 1;
            val_3 = 0;
            this._verticalSupportedPlaneAccepter.OnPlaneAddEvent(plane:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnVerticalSupportedPlaneUpdatePoints(int id, System.Collections.Generic.Dictionary<UnityEngine.Vector2, UnityEngine.Vector3> points)
        {
            var val_4 = 0;
            val_4 = val_4 + 1;
            this._verticalSupportedPlaneAccepter.GetPlane(key:  id).UpdatePoints(newPoints:  points);
            var val_5 = 0;
            val_5 = val_5 + 1;
            this._verticalSupportedPlaneAccepter.OnPointsUpdateEvent(key:  id, points:  points);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnVerticalSupportedPlaneUpdateBoundary(int id, System.Collections.Generic.List<UnityEngine.Vector3> boundary)
        {
            var val_4;
            var val_4 = 0;
            val_4 = val_4 + 1;
            val_4 = 0;
            this._verticalSupportedPlaneAccepter.GetPlane(key:  id).UpdatePlane(boundary:  boundary);
            var val_5 = 0;
            val_5 = val_5 + 1;
            val_4 = 1;
            this._verticalSupportedPlaneAccepter.OnBoundaryUpdateEvent(key:  id);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnVerticalSupportedPlaneSignificantUpdate(int id, System.Collections.Generic.List<UnityEngine.Vector3> boundary, UnityEngine.Vector3 normal, System.Collections.Generic.Dictionary<UnityEngine.Vector2, UnityEngine.Vector3> reprojectedPoints, System.Collections.Generic.Dictionary<UnityEngine.Vector2, UnityEngine.Vector3[]> reprojectedTileVertices)
        {
            var val_4;
            var val_4 = 0;
            val_4 = val_4 + 1;
            SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalSupportedPlane val_2 = this._verticalSupportedPlaneAccepter.GetPlane(key:  id);
            if(val_2 != null)
            {
                    val_2.UpdateNormal(normal:  new UnityEngine.Vector3() {x = normal.x, y = normal.y, z = normal.z});
                val_2.UpdatePlane(boundary:  boundary);
                val_2.ReplacePoints(newPoints:  reprojectedPoints);
            }
            else
            {
                    0.UpdateNormal(normal:  new UnityEngine.Vector3() {x = normal.x, y = normal.y, z = normal.z});
                0.UpdatePlane(boundary:  boundary);
                0.ReplacePoints(newPoints:  reprojectedPoints);
            }
            
            val_4 = 0;
            val_2.ReplaceTileVertices(newVertices:  reprojectedTileVertices);
            var val_5 = 0;
            val_5 = val_5 + 1;
            val_4 = 2;
            this._verticalSupportedPlaneAccepter.OnSignificantUpdateEvent(key:  id);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnVerticalSupportedPlaneAddTile(int id, UnityEngine.Vector2 key, UnityEngine.Vector2Int discretizedKey, UnityEngine.Vector3[] boundary)
        {
            var val_4 = 0;
            val_4 = val_4 + 1;
            this._verticalSupportedPlaneAccepter.GetPlane(key:  id).AddTile(key:  new UnityEngine.Vector2() {x = key.x, y = key.y}, discretizedKey:  new UnityEngine.Vector2Int() {m_X = discretizedKey.m_X, m_Y = discretizedKey.m_Y}, tile:  boundary);
            var val_5 = 0;
            val_5 = val_5 + 1;
            this._verticalSupportedPlaneAccepter.OnTileUpdateEvent(key:  id, planeSpaceCenter:  new UnityEngine.Vector2() {x = key.x, y = key.y}, tileCoords:  boundary);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnVerticalSupportedPlaneRemove(int id)
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            this._verticalSupportedPlaneAccepter.OnRemoveEvent(key:  id);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public IxSupportedPlaneAdapter()
        {
        
        }
    
    }

}
