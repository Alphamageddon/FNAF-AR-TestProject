using UnityEngine;

namespace SharedTechAssets.Scripts.Adapters
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class IxSemanticHorizontalPlaneAdapter : ISupportedHorizontalPlaneAccepter, ISemanticHorizontalPlaneAccepter
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SharedTechAssets.Scripts.TechInterfaces.IllumixObjectInterfaces.Accepters.IIxSemanticHorizontalPlaneAccepter _accepter;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(SharedTechAssets.Scripts.TechInterfaces.IllumixObjectInterfaces.Accepters.IIxSemanticHorizontalPlaneAccepter accepter)
        {
            this._accepter = accepter;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnHorizontalSupportedPlaneAdd(int id, System.Collections.Generic.List<UnityEngine.Vector3> boundary, UnityEngine.Vector3 center, UnityEngine.Vector2 discretizedCenter, float tileLength)
        {
            int val_3;
            SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticHorizontalPlane val_1 = null;
            val_3 = id;
            val_1 = new SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticHorizontalPlane(boundary:  boundary, initialCenter:  new UnityEngine.Vector3() {x = center.x, y = center.y, z = center.z}, discretizedCenter:  new UnityEngine.Vector2() {x = discretizedCenter.x, y = discretizedCenter.y}, updateKey:  val_3, tileLength:  tileLength);
            var val_3 = 0;
            val_3 = val_3 + 1;
            val_3 = 0;
            this._accepter.OnPlaneAddEvent(plane:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnHorizontalSupportedPlaneAddPoints(int id, System.Collections.Generic.List<UnityEngine.Vector2> points)
        {
            var val_4 = 0;
            val_4 = val_4 + 1;
            this._accepter.GetPlane(key:  id).UpdatePoints(newPoints:  points);
            var val_5 = 0;
            val_5 = val_5 + 1;
            this._accepter.OnPointsUpdateEvent(key:  id, points:  points);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnHorizontalSupportedPlaneUpdateBoundary(int id, System.Collections.Generic.List<UnityEngine.Vector3> boundary, float height)
        {
            var val_4;
            var val_4 = 0;
            val_4 = val_4 + 1;
            val_4 = 0;
            this._accepter.GetPlane(key:  id).UpdatePlane(boundary:  boundary, weightedHeight:  height);
            var val_5 = 0;
            val_5 = val_5 + 1;
            val_4 = 1;
            this._accepter.OnBoundaryUpdateEvent(key:  id);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnHorizontalSupportedPlaneSignificantUpdate(int id, System.Collections.Generic.List<UnityEngine.Vector3> boundary, float height)
        {
            var val_4;
            var val_4 = 0;
            val_4 = val_4 + 1;
            val_4 = 0;
            this._accepter.GetPlane(key:  id).UpdatePlane(boundary:  boundary, weightedHeight:  height);
            var val_5 = 0;
            val_5 = val_5 + 1;
            val_4 = 2;
            this._accepter.OnSignificantUpdateEvent(key:  id);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnHorizontalSupportedPlaneAddTile(int id, UnityEngine.Vector2 center)
        {
            var val_4;
            var val_4 = 0;
            val_4 = val_4 + 1;
            val_4 = public SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticHorizontalPlane SharedTechAssets.Scripts.TechInterfaces.IllumixObjectInterfaces.Accepters.IIxSemanticHorizontalPlaneAccepter::GetPlane(int key);
            this._accepter.GetPlane(key:  id).AddTile(tile:  new UnityEngine.Vector2() {x = center.x, y = center.y});
            var val_5 = 0;
            val_5 = val_5 + 1;
            val_4 = 4;
            this._accepter.OnTileUpdateEvent(key:  id, tileCenters:  new UnityEngine.Vector2() {x = center.x, y = center.y});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnHorizontalSupportedPlaneRemove(int id)
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            this._accepter.OnPlaneRemoveEvent(key:  id);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnLabelTile(int id, UnityEngine.Vector2 key, string label, int predId, float confidence)
        {
            var val_4 = 0;
            val_4 = val_4 + 1;
            this._accepter.GetPlane(key:  id).LabelTile(tileKey:  new UnityEngine.Vector2() {x = key.x, y = key.y}, label:  label, labelId:  predId, confidence:  confidence);
            var val_5 = 0;
            val_5 = val_5 + 1;
            this._accepter.OnTileLabelEvent(key:  id, tileCenter:  new UnityEngine.Vector2() {x = key.x, y = key.y}, label:  label, confidence:  confidence);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public IxSemanticHorizontalPlaneAdapter()
        {
        
        }
    
    }

}
