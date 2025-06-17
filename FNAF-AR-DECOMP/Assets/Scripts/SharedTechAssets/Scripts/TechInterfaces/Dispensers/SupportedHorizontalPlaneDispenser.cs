using UnityEngine;

namespace SharedTechAssets.Scripts.TechInterfaces.Dispensers
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SupportedHorizontalPlaneDispenser
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.ISupportedHorizontalPlaneAccepter> _accepters;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AddAccepter(SharedTechAssets.Scripts.TechInterfaces.Accepters.ISupportedHorizontalPlaneAccepter accepter)
        {
            this._accepters.Add(item:  accepter);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetAccepters(System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.ISupportedHorizontalPlaneAccepter> accepters)
        {
            this._accepters = accepters;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void HorizontalSupportedPlaneAddedEvent(int id, System.Collections.Generic.List<UnityEngine.Vector3> boundary, UnityEngine.Vector3 center, UnityEngine.Vector2 discretizedCenter, float tileLength)
        {
            goto label_1;
            label_9:
            var val_4 = 0;
            val_4 = val_4 + 1;
            this._accepters.Item[0].OnHorizontalSupportedPlaneAdd(id:  id, boundary:  boundary, center:  new UnityEngine.Vector3() {x = center.x, y = center.y, z = center.z}, discretizedCenter:  new UnityEngine.Vector2() {x = discretizedCenter.x, y = discretizedCenter.y}, tileLength:  tileLength);
            0 = 1;
            label_1:
            if(0 < this._accepters.Count)
            {
                goto label_9;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void HorizontalSupportedPlaneUpdatePointsEvent(int id, System.Collections.Generic.List<UnityEngine.Vector2> points)
        {
            goto label_1;
            label_9:
            var val_4 = 0;
            val_4 = val_4 + 1;
            this._accepters.Item[0].OnHorizontalSupportedPlaneAddPoints(id:  id, points:  points);
            0 = 1;
            label_1:
            if(0 < this._accepters.Count)
            {
                goto label_9;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void HorizontalSupportedPlaneUpdateBoundaryEvent(int id, System.Collections.Generic.List<UnityEngine.Vector3> boundary, float height)
        {
            goto label_1;
            label_9:
            var val_4 = 0;
            val_4 = val_4 + 1;
            this._accepters.Item[0].OnHorizontalSupportedPlaneUpdateBoundary(id:  id, boundary:  boundary, height:  height);
            0 = 1;
            label_1:
            if(0 < this._accepters.Count)
            {
                goto label_9;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnHorizontalSupportedPlaneSignificantUpdateEvent(int id, System.Collections.Generic.List<UnityEngine.Vector3> boundary, float height)
        {
            goto label_1;
            label_9:
            var val_4 = 0;
            val_4 = val_4 + 1;
            this._accepters.Item[0].OnHorizontalSupportedPlaneSignificantUpdate(id:  id, boundary:  boundary, height:  height);
            0 = 1;
            label_1:
            if(0 < this._accepters.Count)
            {
                goto label_9;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void HorizontalSupportedPlaneAddTileEvent(int id, UnityEngine.Vector2 tileCenter)
        {
            var val_4;
            var val_5;
            val_4 = 0;
            goto label_1;
            label_9:
            val_5 = public SharedTechAssets.Scripts.TechInterfaces.Accepters.ISupportedHorizontalPlaneAccepter System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.ISupportedHorizontalPlaneAccepter>::get_Item(int index);
            var val_4 = 0;
            val_4 = val_4 + 1;
            val_5 = 4;
            this._accepters.Item[0].OnHorizontalSupportedPlaneAddTile(id:  id, center:  new UnityEngine.Vector2() {x = tileCenter.x, y = tileCenter.y});
            val_4 = 1;
            label_1:
            if(val_4 < this._accepters.Count)
            {
                goto label_9;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void HorizontalSupportedPlaneRemovedEvent(int id)
        {
            var val_4;
            var val_5;
            val_4 = 0;
            goto label_1;
            label_9:
            val_5 = public SharedTechAssets.Scripts.TechInterfaces.Accepters.ISupportedHorizontalPlaneAccepter System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.ISupportedHorizontalPlaneAccepter>::get_Item(int index);
            var val_4 = 0;
            val_4 = val_4 + 1;
            val_5 = 5;
            this._accepters.Item[0].OnHorizontalSupportedPlaneRemove(id:  id);
            val_4 = 1;
            label_1:
            if(val_4 < this._accepters.Count)
            {
                goto label_9;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SupportedHorizontalPlaneDispenser()
        {
            this._accepters = new System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.ISupportedHorizontalPlaneAccepter>();
        }
    
    }

}
