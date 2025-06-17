using UnityEngine;

namespace SharedTechAssets.Scripts.TechInterfaces.Dispensers
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SupportedVerticalPlaneDispenser
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.ISupportedVerticalPlaneAccepter> _accepters;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AddAccepter(SharedTechAssets.Scripts.TechInterfaces.Accepters.ISupportedVerticalPlaneAccepter accepter)
        {
            this._accepters.Add(item:  accepter);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetAccepters(System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.ISupportedVerticalPlaneAccepter> accepters)
        {
            this._accepters = accepters;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void VerticalSupportedPlaneAddedEvent(int id, System.Collections.Generic.List<UnityEngine.Vector3> boundary, UnityEngine.Vector3 normal, UnityEngine.Vector3 center)
        {
            goto label_1;
            label_9:
            var val_4 = 0;
            val_4 = val_4 + 1;
            this._accepters.Item[0].OnVerticalSupportedPlaneAdd(id:  id, boundary:  boundary, normal:  new UnityEngine.Vector3() {x = normal.x, y = normal.y, z = normal.z}, center:  new UnityEngine.Vector3() {x = center.x, y = center.y, z = center.z});
            0 = 1;
            label_1:
            if(0 < this._accepters.Count)
            {
                goto label_9;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void VerticalSupportedPlaneUpdatePointsEvent(int id, System.Collections.Generic.Dictionary<UnityEngine.Vector2, UnityEngine.Vector3> points)
        {
            goto label_1;
            label_9:
            var val_4 = 0;
            val_4 = val_4 + 1;
            this._accepters.Item[0].OnVerticalSupportedPlaneUpdatePoints(id:  id, points:  points);
            0 = 1;
            label_1:
            if(0 < this._accepters.Count)
            {
                goto label_9;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnVerticalSupportedPlaneUpdateBoundary(int id, System.Collections.Generic.List<UnityEngine.Vector3> boundary)
        {
            goto label_1;
            label_9:
            var val_4 = 0;
            val_4 = val_4 + 1;
            this._accepters.Item[0].OnVerticalSupportedPlaneUpdateBoundary(id:  id, boundary:  boundary);
            0 = 1;
            label_1:
            if(0 < this._accepters.Count)
            {
                goto label_9;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void VerticalSupportedPlaneUpdateSignificantUpdateEvent(int id, System.Collections.Generic.List<UnityEngine.Vector3> boundary, UnityEngine.Vector3 normal, System.Collections.Generic.Dictionary<UnityEngine.Vector2, UnityEngine.Vector3> reprojectedPoints, System.Collections.Generic.Dictionary<UnityEngine.Vector2, UnityEngine.Vector3[]> reprojectedTiles)
        {
            goto label_1;
            label_9:
            var val_4 = 0;
            val_4 = val_4 + 1;
            this._accepters.Item[0].OnVerticalSupportedPlaneSignificantUpdate(id:  id, boundary:  boundary, normal:  new UnityEngine.Vector3() {x = normal.x, y = normal.y, z = normal.z}, reprojectedPoints:  reprojectedPoints, reprojectedTiles:  reprojectedTiles);
            0 = 1;
            label_1:
            if(0 < this._accepters.Count)
            {
                goto label_9;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void VerticalSupportedPlaneAddTileEvent(int id, UnityEngine.Vector2 key, UnityEngine.Vector2Int discretizedKey, UnityEngine.Vector3[] vertices)
        {
            goto label_1;
            label_9:
            var val_4 = 0;
            val_4 = val_4 + 1;
            this._accepters.Item[0].OnVerticalSupportedPlaneAddTile(id:  id, key:  new UnityEngine.Vector2() {x = key.x, y = key.y}, discretizedKey:  new UnityEngine.Vector2Int() {m_X = discretizedKey.m_X, m_Y = discretizedKey.m_Y}, boundary:  vertices);
            0 = 1;
            label_1:
            if(0 < this._accepters.Count)
            {
                goto label_9;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void VerticalSupportedPlaneRemovedEvent(int id)
        {
            var val_4;
            var val_5;
            val_4 = 0;
            goto label_1;
            label_9:
            val_5 = public SharedTechAssets.Scripts.TechInterfaces.Accepters.ISupportedVerticalPlaneAccepter System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.ISupportedVerticalPlaneAccepter>::get_Item(int index);
            var val_4 = 0;
            val_4 = val_4 + 1;
            val_5 = 5;
            this._accepters.Item[0].OnVerticalSupportedPlaneRemove(id:  id);
            val_4 = 1;
            label_1:
            if(val_4 < this._accepters.Count)
            {
                goto label_9;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SupportedVerticalPlaneDispenser()
        {
            this._accepters = new System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.ISupportedVerticalPlaneAccepter>();
        }
    
    }

}
