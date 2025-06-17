using UnityEngine;

namespace SharedTechAssets.Scripts.ObjectPinner.GeometryHandler
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SupportedHorizontalPlaneGeometryHandler : ISemanticGeometryHandler, ISupportedHorizontalPlaneAccepter
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<UnityEngine.GameObject>> _planeToTiles;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<int, UnityEngine.GameObject> _planeToGameObjects;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<int, SharedTechAssets.Scripts.ObjectPinner.GeometryHandler.SupportedHorizontalPlaneGeometryHandler.HorizontalSemanticPlane> _idToPlane;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<UnityEngine.GameObject, int> _objToPlane;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<UnityEngine.GameObject, UnityEngine.Vector2> _objToTile;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SharedTechAssets.Scripts.ObjectPinner.GeometryHandler.SupportedHorizontalPlaneGeometry_Config _config;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SharedTechAssets.Scripts.ObjectPinner.GeometryHandler.GeometryToDataHandler _dataHandler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SharedTechAssets.Scripts.TechInterfaces.Dispensers.SemanticHorizontalPlaneDispenser _dispenser;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3[] verticesBuffer;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SupportedHorizontalPlaneGeometryHandler(SharedTechAssets.Scripts.ObjectPinner.GeometryHandler.SupportedHorizontalPlaneGeometry_Config config, SharedTechAssets.Scripts.TechInterfaces.Dispensers.SemanticHorizontalPlaneDispenser dispenser)
        {
            this.verticesBuffer = new UnityEngine.Vector3[4];
            val_2 = new System.Object();
            this._config = config;
            this._dispenser = val_2;
            mem[1152921523083554496] = "SupportedHorizontalPlaneGeometryHandler";
            this._planeToTiles = new System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.List<UnityEngine.GameObject>>();
            this._planeToGameObjects = new System.Collections.Generic.Dictionary<System.Int32, UnityEngine.GameObject>();
            this._idToPlane = new System.Collections.Generic.Dictionary<System.Int32, HorizontalSemanticPlane>();
            this._objToTile = new System.Collections.Generic.Dictionary<UnityEngine.GameObject, UnityEngine.Vector2>();
            this._objToPlane = new System.Collections.Generic.Dictionary<UnityEngine.GameObject, System.Int32>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void SetupDataHandler(SharedTechAssets.Scripts.ObjectPinner.GeometryHandler.GeometryToDataHandler handler)
        {
            this._dataHandler = handler;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnHorizontalSupportedPlaneAdd(int id, System.Collections.Generic.List<UnityEngine.Vector3> boundary, UnityEngine.Vector3 center, UnityEngine.Vector2 discretizedCenter, float tileLength)
        {
            UnityEngine.GameObject val_1 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this._config.supportedPlanePrefab);
            if(this._config.usePlane != false)
            {
                    val_1.GetComponent<SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.SimpleConvexMeshWithCollider>().InitializeMesh(orderedConvexVertices:  boundary.ToArray());
            }
            
            this._planeToGameObjects.set_Item(key:  id, value:  val_1);
            this._planeToTiles.set_Item(key:  id, value:  new System.Collections.Generic.List<UnityEngine.GameObject>());
            this._objToPlane.set_Item(key:  val_1, value:  id);
            this._idToPlane.set_Item(key:  id, value:  new HorizontalSemanticPlane() {height = center.y, tileLength = tileLength, tileCenters = new System.Collections.Generic.List<UnityEngine.Vector2>(), tileToLabels = new System.Collections.Generic.Dictionary<UnityEngine.Vector2, System.String>()});
            this._dataHandler.AddGO(go:  val_1, accepter:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnHorizontalSupportedPlaneAddPoints(int id, System.Collections.Generic.List<UnityEngine.Vector2> points)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnHorizontalSupportedPlaneUpdateBoundary(int id, System.Collections.Generic.List<UnityEngine.Vector3> boundary, float height)
        {
            float val_6;
            if(this._config.usePlane != false)
            {
                    this._planeToGameObjects.Item[id].GetComponent<SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.SimpleConvexMeshWithCollider>().UpdateMesh(convexVertices:  boundary.ToArray());
            }
            
            HorizontalSemanticPlane val_4 = this._idToPlane.Item[id];
            this._idToPlane.set_Item(key:  id, value:  new HorizontalSemanticPlane() {height = height, tileLength = val_6, tileCenters = val_6, tileToLabels = val_6});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateAllTiles(int id)
        {
            var val_2;
            var val_8;
            HorizontalSemanticPlane val_1 = this._idToPlane.Item[id];
            System.Collections.Generic.List<UnityEngine.GameObject> val_3 = this._planeToTiles.Item[id];
            val_8 = 0;
            goto label_3;
            label_9:
            UnityEngine.Vector2 val_4 = val_2.Item[0];
            this.SetTileCoords(id:  id, center:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y});
            val_3.Item[0].GetComponent<SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.SimpleConvexMeshWithCollider>().UpdateMesh(convexVertices:  this.verticesBuffer);
            val_8 = 2;
            label_3:
            if(val_8 < val_3.Count)
            {
                goto label_9;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnHorizontalSupportedPlaneSignificantUpdate(int id, System.Collections.Generic.List<UnityEngine.Vector3> boundary, float height)
        {
            if(this._config.usePlane != false)
            {
                    this.OnHorizontalSupportedPlaneUpdateBoundary(id:  id, boundary:  boundary, height:  height);
            }
            
            this.UpdateAllTiles(id:  id);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetTileCoords(int id, UnityEngine.Vector2 center)
        {
            float val_3;
            float val_7 = center.y;
            float val_8 = center.x;
            HorizontalSemanticPlane val_1 = this._idToPlane.Item[id];
            float val_6 = val_3;
            float val_4 = val_6 * 0.5f;
            float val_5 = val_8 - val_4;
            val_6 = val_7 - val_4;
            val_7 = val_7 + val_4;
            val_8 = val_8 + val_4;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnHorizontalSupportedPlaneAddTile(int id, UnityEngine.Vector2 center)
        {
            var val_4;
            UnityEngine.GameObject val_2 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this._config.tilePrefab);
            HorizontalSemanticPlane val_3 = this._idToPlane.Item[id];
            val_4.Add(item:  new UnityEngine.Vector2() {x = center.x, y = center.y});
            this.SetTileCoords(id:  id, center:  new UnityEngine.Vector2() {x = center.x, y = center.y});
            val_2.GetComponent<SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.SimpleConvexMeshWithCollider>().InitializeMesh(orderedConvexVertices:  this.verticesBuffer);
            this._objToTile.set_Item(key:  val_2, value:  new UnityEngine.Vector2() {x = center.x, y = center.y});
            this._objToPlane.set_Item(key:  val_2, value:  id);
            this._dataHandler.AddGO(go:  val_2, accepter:  this);
            this._planeToTiles.Item[id].Add(item:  val_2);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnHorizontalSupportedPlaneRemove(int id)
        {
            var val_9;
            UnityEngine.Object val_10;
            UnityEngine.GameObject val_1 = this._planeToGameObjects.Item[id];
            val_1.SetActive(value:  false);
            UnityEngine.Object.Destroy(obj:  val_1);
            bool val_2 = this._planeToGameObjects.Remove(key:  id);
            System.Collections.Generic.List<UnityEngine.GameObject> val_3 = this._planeToTiles.Item[id];
            val_9 = 0;
            goto label_7;
            label_13:
            val_10 = val_3.Count;
            if(val_9 >= val_10)
            {
                goto label_8;
            }
            
            label_14:
            val_3.Item[0].SetActive(value:  false);
            val_10 = val_3.Item[0];
            UnityEngine.Object.Destroy(obj:  val_10);
            val_9 = 1;
            label_7:
            if(val_3 == null)
            {
                goto label_13;
            }
            
            if(val_9 < val_3.Count)
            {
                goto label_14;
            }
            
            label_8:
            val_3.Clear();
            bool val_8 = this._planeToTiles.Remove(key:  id);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void SemanticsUpdate(UnityEngine.GameObject go, string label, int predId, UnityEngine.RaycastHit hit, float confidence)
        {
            var val_5;
            bool val_1 = this._objToTile.ContainsKey(key:  go);
            if(this._objToPlane == null)
            {
                goto label_2;
            }
            
            if(val_1 == false)
            {
                goto label_3;
            }
            
            label_8:
            int val_2 = this._objToPlane.Item[go];
            UnityEngine.Vector2 val_3 = this._objToTile.Item[go];
            HorizontalSemanticPlane val_4 = this._idToPlane.Item[val_2];
            val_5.set_Item(key:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y}, value:  label);
            this._dispenser.LabelTile(id:  val_2, key:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y}, label:  label, label_id:  predId, confidence:  confidence);
            return;
            label_2:
            if(val_1 == true)
            {
                goto label_8;
            }
            
            label_3:
            bool val_6 = this._objToPlane.ContainsKey(key:  go);
        }
    
    }

}
