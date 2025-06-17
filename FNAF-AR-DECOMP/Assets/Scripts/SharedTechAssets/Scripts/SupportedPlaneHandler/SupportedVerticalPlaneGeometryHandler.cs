using UnityEngine;

namespace SharedTechAssets.Scripts.SupportedPlaneHandler
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SupportedVerticalPlaneGeometryHandler : ISemanticGeometryHandler, ISupportedVerticalPlaneAccepter
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<UnityEngine.GameObject>> _planeToTiles;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<int, UnityEngine.GameObject> _planeToGameObjects;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SharedTechAssets.Scripts.ObjectPinner.GeometryHandler.SupportedVerticalPlaneGeometryHandler_Config _config;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SharedTechAssets.Scripts.TechInterfaces.Dispensers.SemanticVerticalPlaneDispenser _dispenser;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<int, SharedTechAssets.Scripts.SupportedPlaneHandler.SupportedVerticalPlaneGeometryHandler.VerticalSemanticPlane> _idToPlane;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<UnityEngine.GameObject, int> _objToPlane;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<UnityEngine.GameObject, UnityEngine.Vector2> _objToTile;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SharedTechAssets.Scripts.ObjectPinner.GeometryHandler.GeometryToDataHandler _dataHandler;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SupportedVerticalPlaneGeometryHandler(SharedTechAssets.Scripts.ObjectPinner.GeometryHandler.SupportedVerticalPlaneGeometryHandler_Config config, SharedTechAssets.Scripts.TechInterfaces.Dispensers.SemanticVerticalPlaneDispenser dispenser)
        {
            val_1 = new System.Object();
            mem[1152921523063467872] = "SupportedVerticalPlaneGeometryHandler";
            this._planeToTiles = new System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.List<UnityEngine.GameObject>>();
            this._planeToGameObjects = new System.Collections.Generic.Dictionary<System.Int32, UnityEngine.GameObject>();
            this._objToTile = new System.Collections.Generic.Dictionary<UnityEngine.GameObject, UnityEngine.Vector2>();
            this._objToPlane = new System.Collections.Generic.Dictionary<UnityEngine.GameObject, System.Int32>();
            this._dispenser = val_1;
            this._idToPlane = new System.Collections.Generic.Dictionary<System.Int32, VerticalSemanticPlane>();
            this._config = config;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void SetupDataHandler(SharedTechAssets.Scripts.ObjectPinner.GeometryHandler.GeometryToDataHandler dataHandler)
        {
            this._dataHandler = dataHandler;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnVerticalSupportedPlaneAdd(int id, System.Collections.Generic.List<UnityEngine.Vector3> boundary, UnityEngine.Vector3 normal, UnityEngine.Vector3 center)
        {
            UnityEngine.GameObject val_1 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this._config.supportedPlanePrefab);
            if(this._config.usePlane != false)
            {
                    val_1.GetComponent<SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.SimpleConvexMeshWithCollider>().InitializeMesh(orderedConvexVertices:  boundary.ToArray());
            }
            
            this._objToPlane.set_Item(key:  val_1, value:  id);
            this._planeToGameObjects.set_Item(key:  id, value:  val_1);
            this._planeToTiles.set_Item(key:  id, value:  new System.Collections.Generic.List<UnityEngine.GameObject>());
            this._idToPlane.set_Item(key:  id, value:  new VerticalSemanticPlane() {tileToLabels = new System.Collections.Generic.Dictionary<UnityEngine.Vector2, System.String>()});
            this._dataHandler.AddGO(go:  val_1, accepter:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnVerticalSupportedPlaneUpdatePoints(int id, System.Collections.Generic.Dictionary<UnityEngine.Vector2, UnityEngine.Vector3> points)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnVerticalSupportedPlaneUpdateBoundary(int id, System.Collections.Generic.List<UnityEngine.Vector3> boundary)
        {
            if(this._config.usePlane != false)
            {
                    this._planeToGameObjects.Item[id].GetComponent<SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.SimpleConvexMeshWithCollider>().UpdateMesh(convexVertices:  boundary.ToArray());
            }
            
            VerticalSemanticPlane val_4 = this._idToPlane.Item[id];
            this._idToPlane.set_Item(key:  id, value:  new VerticalSemanticPlane() {tileToLabels = val_4.tileToLabels});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnVerticalSupportedPlaneSignificantUpdate(int id, System.Collections.Generic.List<UnityEngine.Vector3> boundary, UnityEngine.Vector3 normal, System.Collections.Generic.Dictionary<UnityEngine.Vector2, UnityEngine.Vector3> reprojectedPoints, System.Collections.Generic.Dictionary<UnityEngine.Vector2, UnityEngine.Vector3[]> reprojectedTiles)
        {
            this.OnVerticalSupportedPlaneUpdateBoundary(id:  id, boundary:  boundary);
            this.UpdateAllTiles(id:  id, reprojectedTiles:  reprojectedTiles);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateAllTiles(int id, System.Collections.Generic.Dictionary<UnityEngine.Vector2, UnityEngine.Vector3[]> reprojectedTiles)
        {
            System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.List<UnityEngine.GameObject>> val_8;
            var val_9;
            var val_10;
            val_8 = this._planeToTiles;
            Dictionary.ValueCollection.Enumerator<TKey, TValue> val_3 = reprojectedTiles.Values.GetEnumerator();
            goto label_4;
            label_8:
            val_8 = 0.emailUIDataHandler;
            val_8.Item[id].Item[0].GetComponent<SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.SimpleConvexMeshWithCollider>().UpdateMesh(convexVertices:  val_8);
            label_4:
            if((1277835528 & 1) != 0)
            {
                goto label_8;
            }
            
            val_9 = 0;
            val_10 = 1;
            long val_7 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523064551688});
            if(( & 1) != 0)
            {
                    return;
            }
            
            if( == 0)
            {
                    return;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnVerticalSupportedPlaneAddTile(int id, UnityEngine.Vector2 key, UnityEngine.Vector2Int discretizedKey, UnityEngine.Vector3[] boundary)
        {
            UnityEngine.GameObject val_2 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this._config.tilePrefab);
            val_2.GetComponent<SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.SimpleConvexMeshWithCollider>().InitializeMesh(orderedConvexVertices:  boundary);
            this._planeToTiles.Item[id].Add(item:  val_2);
            this._objToTile.set_Item(key:  val_2, value:  new UnityEngine.Vector2() {x = key.x, y = key.y});
            this._objToPlane.set_Item(key:  val_2, value:  id);
            this._dataHandler.AddGO(go:  val_2, accepter:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnVerticalSupportedPlaneRemove(int id)
        {
            var val_11;
            UnityEngine.Object val_12;
            UnityEngine.GameObject val_1 = this._planeToGameObjects.Item[id];
            val_1.SetActive(value:  false);
            bool val_2 = this._objToPlane.Remove(key:  val_1);
            UnityEngine.Object.Destroy(obj:  val_1);
            bool val_3 = this._planeToGameObjects.Remove(key:  id);
            System.Collections.Generic.List<UnityEngine.GameObject> val_4 = this._planeToTiles.Item[id];
            val_11 = 0;
            goto label_8;
            label_14:
            val_12 = val_4.Count;
            if(val_11 >= val_12)
            {
                goto label_9;
            }
            
            label_15:
            val_4.Item[0].SetActive(value:  false);
            val_12 = val_4.Item[0];
            UnityEngine.Object.Destroy(obj:  val_12);
            val_11 = 1;
            label_8:
            if(val_4 == null)
            {
                goto label_14;
            }
            
            if(val_11 < val_4.Count)
            {
                goto label_15;
            }
            
            label_9:
            val_4.Clear();
            bool val_9 = this._planeToTiles.Remove(key:  id);
            bool val_10 = this._idToPlane.Remove(key:  id);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void SemanticsUpdate(UnityEngine.GameObject go, string label, int predId, UnityEngine.RaycastHit hit, float confidence)
        {
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
            VerticalSemanticPlane val_4 = this._idToPlane.Item[val_2];
            val_4.tileToLabels.set_Item(key:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y}, value:  label);
            this._dispenser.LabelTile(id:  val_2, key:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y}, label:  label, label_id:  predId, confidence:  confidence);
            return;
            label_2:
            if(val_1 == true)
            {
                goto label_8;
            }
            
            label_3:
            bool val_5 = this._objToPlane.ContainsKey(key:  go);
        }
    
    }

}
