using UnityEngine;

namespace SharedTechAssets.Scripts.Adapters
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class IxSemanticVerticalPlaneAdapter : ISupportedVerticalPlaneAccepter, ISemanticVerticalPlaneAccepter
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SharedTechAssets.Scripts.TechInterfaces.IllumixObjectInterfaces.Accepters.IIxSemanticVerticalPlaneAccepter _accepter;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(SharedTechAssets.Scripts.TechInterfaces.IllumixObjectInterfaces.Accepters.IIxSemanticVerticalPlaneAccepter accepter)
        {
            this._accepter = accepter;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnVerticalSupportedPlaneAdd(int id, System.Collections.Generic.List<UnityEngine.Vector3> boundary, UnityEngine.Vector3 normal, UnityEngine.Vector3 center)
        {
            int val_3;
            SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticVerticalPlane val_1 = null;
            val_3 = id;
            val_1 = new SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticVerticalPlane(boundary:  boundary, initialCenter:  new UnityEngine.Vector3() {x = center.x, y = center.y, z = center.z}, normal:  new UnityEngine.Vector3() {x = normal.x, y = normal.y, z = normal.z}, updateKey:  val_3);
            var val_3 = 0;
            val_3 = val_3 + 1;
            val_3 = 0;
            this._accepter.OnPlaneAddEvent(plane:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnVerticalSupportedPlaneUpdatePoints(int id, System.Collections.Generic.Dictionary<UnityEngine.Vector2, UnityEngine.Vector3> points)
        {
            var val_4 = 0;
            val_4 = val_4 + 1;
            this._accepter.GetPlane(key:  id).UpdatePoints(newPoints:  points);
            var val_5 = 0;
            val_5 = val_5 + 1;
            this._accepter.OnPointsUpdateEvent(key:  id, points:  points);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnVerticalSupportedPlaneUpdateBoundary(int id, System.Collections.Generic.List<UnityEngine.Vector3> boundary)
        {
            var val_4;
            var val_4 = 0;
            val_4 = val_4 + 1;
            val_4 = 0;
            this._accepter.GetPlane(key:  id).UpdatePlane(boundary:  boundary);
            var val_5 = 0;
            val_5 = val_5 + 1;
            val_4 = 1;
            this._accepter.OnBoundaryUpdateEvent(key:  id);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnVerticalSupportedPlaneSignificantUpdate(int id, System.Collections.Generic.List<UnityEngine.Vector3> boundary, UnityEngine.Vector3 normal, System.Collections.Generic.Dictionary<UnityEngine.Vector2, UnityEngine.Vector3> reprojectedPoints, System.Collections.Generic.Dictionary<UnityEngine.Vector2, UnityEngine.Vector3[]> reprojectedTiles)
        {
            var val_4;
            var val_4 = 0;
            val_4 = val_4 + 1;
            SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticVerticalPlane val_2 = this._accepter.GetPlane(key:  id);
            if(val_2 != null)
            {
                    val_2.UpdatePlane(boundary:  boundary);
                val_2.UpdateNormal(normal:  new UnityEngine.Vector3() {x = normal.x, y = normal.y, z = normal.z});
                val_2.ReplacePoints(newPoints:  reprojectedPoints);
            }
            else
            {
                    0.UpdatePlane(boundary:  boundary);
                0.UpdateNormal(normal:  new UnityEngine.Vector3() {x = normal.x, y = normal.y, z = normal.z});
                0.ReplacePoints(newPoints:  reprojectedPoints);
            }
            
            val_4 = 0;
            val_2.ReplaceTileVertices(newVertices:  reprojectedTiles);
            var val_5 = 0;
            val_5 = val_5 + 1;
            val_4 = 2;
            this._accepter.OnSignificantUpdateEvent(key:  id);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnVerticalSupportedPlaneAddTile(int id, UnityEngine.Vector2 key, UnityEngine.Vector2Int discretizedKey, UnityEngine.Vector3[] boundary)
        {
            var val_4 = 0;
            val_4 = val_4 + 1;
            this._accepter.GetPlane(key:  id).AddTile(key:  new UnityEngine.Vector2() {x = key.x, y = key.y}, discretizedKey:  new UnityEngine.Vector2Int() {m_X = discretizedKey.m_X, m_Y = discretizedKey.m_Y}, tile:  boundary);
            var val_5 = 0;
            val_5 = val_5 + 1;
            this._accepter.OnTileUpdateEvent(key:  id, planeSpaceCenter:  new UnityEngine.Vector2() {x = key.x, y = key.y}, tileCoords:  boundary);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnVerticalSupportedPlaneRemove(int id)
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(this._accepter, typeof(public GameUI.LeaderboardCell List.Enumerator<GameUI.LeaderboardCell>::get_Current()), slot: 5);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnLabelTile(int id, UnityEngine.Vector2 key, string label, int predId, float confidence)
        {
            var val_4 = 0;
            val_4 = val_4 + 1;
            this._accepter.GetPlane(key:  id).LabelTile(tileKey:  new UnityEngine.Vector2() {x = key.x, y = key.y}, label:  label, labelId:  predId, confidence:  confidence);
            var val_5 = 0;
            val_5 = val_5 + 1;
            this._accepter.OnTileLabelEvent(key:  id, tileKey:  new UnityEngine.Vector2() {x = key.x, y = key.y}, label:  label, confidence:  confidence);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public IxSemanticVerticalPlaneAdapter()
        {
        
        }
    
    }

}
