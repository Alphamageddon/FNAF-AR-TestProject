using UnityEngine;

namespace SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class IxSemanticVerticalPlaneVisualizer : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.GameObject tilePrefab;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.GameObject supportedPlanePrefab;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<UnityEngine.GameObject>> _planeToTiles;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<int, UnityEngine.GameObject> _planeToGameObjects;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<int, System.Collections.Generic.Dictionary<UnityEngine.Vector2, UnityEngine.GameObject>> _planeToTileTextObjects;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Camera _camera;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool showPlane;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AddPlane(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalSupportedPlane plane)
        {
            System.Collections.Generic.Dictionary<System.Int32, UnityEngine.GameObject> val_5;
            UnityEngine.GameObject val_1 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.supportedPlanePrefab);
            if(this.showPlane != false)
            {
                    val_1.GetComponent<SimpleConvexMesh>().InitializeMesh(orderedConvexVertices:  X23.ToArray());
                val_5 = this._planeToGameObjects;
            }
            else
            {
                    val_5 = this._planeToGameObjects;
            }
            
            val_5.set_Item(key:  W23, value:  val_1);
            this._planeToTiles.set_Item(key:  plane, value:  new System.Collections.Generic.List<UnityEngine.GameObject>());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SignificantUpdate(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalSupportedPlane plane)
        {
            this.UpdateBoundary(plane:  plane);
            this.UpdateAllTiles(plane:  plane);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateBoundary(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalSupportedPlane plane)
        {
            if(this.showPlane == false)
            {
                    return;
            }
            
            UnityEngine.GameObject val_1 = this._planeToGameObjects.Item[69742592];
            val_1.GetComponent<SimpleConvexMesh>().UpdateMesh(convexVertices:  val_1.ToArray());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AddTile(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalSupportedPlane plane, UnityEngine.Vector2 key, UnityEngine.Vector3[] tileCoords)
        {
            UnityEngine.GameObject val_2 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.tilePrefab);
            val_2.GetComponent<SimpleConvexMesh>().InitializeMesh(orderedConvexVertices:  tileCoords);
            this._planeToTiles.Item[plane].Add(item:  val_2);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateAllTiles(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalSupportedPlane plane)
        {
            UnityEngine.Vector3[] val_9;
            Dictionary.ValueCollection.Enumerator<TKey, TValue> val_3 = plane.TileCoords.Values.GetEnumerator();
            goto label_5;
            label_9:
            val_9 = 0.emailUIDataHandler;
            this._planeToTiles.Item[69742592].Item[0].GetComponent<SimpleConvexMesh>().UpdateMesh(convexVertices:  val_9);
            label_5:
            if((1377467704 & 1) != 0)
            {
                goto label_9;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void RemovePlane(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalSupportedPlane plane)
        {
            var val_9;
            UnityEngine.Object val_10;
            UnityEngine.GameObject val_1 = this._planeToGameObjects.Item[W22];
            val_1.SetActive(value:  false);
            UnityEngine.Object.Destroy(obj:  val_1);
            bool val_2 = this._planeToGameObjects.Remove(key:  W22);
            System.Collections.Generic.List<UnityEngine.GameObject> val_3 = this._planeToTiles.Item[W22];
            val_9 = 0;
            goto label_8;
            label_14:
            val_10 = val_3.Count;
            if(val_9 >= val_10)
            {
                goto label_9;
            }
            
            label_15:
            val_3.Item[0].SetActive(value:  false);
            val_10 = val_3.Item[0];
            UnityEngine.Object.Destroy(obj:  val_10);
            val_9 = 1;
            label_8:
            if(val_3 == null)
            {
                goto label_14;
            }
            
            if(val_9 < val_3.Count)
            {
                goto label_15;
            }
            
            label_9:
            val_3.Clear();
            bool val_8 = this._planeToTiles.Remove(key:  plane);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void LabelTile(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticVerticalPlane plane, UnityEngine.Vector2 key, string label, float confidence)
        {
            float val_24;
            var val_25;
            UnityEngine.Transform val_26;
            var val_27;
            float val_28;
            val_24 = key.y;
            if((this._planeToTileTextObjects.ContainsKey(key:  W23)) != true)
            {
                    this._planeToTileTextObjects.set_Item(key:  W23, value:  new System.Collections.Generic.Dictionary<UnityEngine.Vector2, UnityEngine.GameObject>());
            }
            
            System.Collections.Generic.Dictionary<UnityEngine.Vector2, UnityEngine.GameObject> val_3 = this._planeToTileTextObjects.Item[W23];
            if((val_3.ContainsKey(key:  new UnityEngine.Vector2() {x = key.x, y = val_24})) != false)
            {
                    UnityEngine.GameObject val_5 = val_3.Item[new UnityEngine.Vector2() {x = key.x, y = val_24}];
                val_5.GetComponent<UnityEngine.TextMesh>().text = label;
                val_26 = this._camera.transform;
                val_5.transform.LookAt(target:  val_26);
                val_27 = val_5.transform;
                UnityEngine.Vector3 val_10 = UnityEngine.Vector3.up;
                UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                val_24 = val_11.x;
                val_28 = val_11.z;
                val_27.Rotate(eulers:  new UnityEngine.Vector3() {x = val_24, y = val_11.y, z = val_28});
                return;
            }
            
            UnityEngine.Vector3[] val_12 = X23.Item[new UnityEngine.Vector2() {x = key.x, y = val_24}];
            UnityEngine.Vector3[] val_13 = plane.Item[new UnityEngine.Vector2() {x = key.x, y = val_24}];
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_12[0], y = val_12[0], z = val_12[1]}, b:  new UnityEngine.Vector3() {x = val_13[3], y = val_13[3], z = val_13[4]});
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, d:  2f);
            UnityEngine.GameObject val_16 = new UnityEngine.GameObject();
            val_25 = val_16.AddComponent<UnityEngine.TextMesh>();
            if(val_25 != null)
            {
                    val_25.text = label;
                val_25.fontSize = 15;
            }
            else
            {
                    val_25.text = label;
                val_25.fontSize = 15;
            }
            
            val_25.characterSize = 0.01f;
            val_16.transform.position = new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z};
            val_26 = this._camera.transform;
            val_16.transform.LookAt(target:  val_26);
            val_27 = val_16.transform;
            UnityEngine.Vector3 val_22 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_23 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            val_28 = val_23.x;
            val_27.Rotate(eulers:  new UnityEngine.Vector3() {x = val_28, y = val_23.y, z = val_23.z});
            val_3.set_Item(key:  new UnityEngine.Vector2() {x = key.x, y = val_24}, value:  val_16);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            this._planeToGameObjects = new System.Collections.Generic.Dictionary<System.Int32, UnityEngine.GameObject>();
            this._planeToTiles = new System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.List<UnityEngine.GameObject>>();
            this._planeToTileTextObjects = new System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.Dictionary<UnityEngine.Vector2, UnityEngine.GameObject>>();
            this._camera = this.GetComponentInParent<UnityEngine.XR.ARFoundation.ARSessionOrigin>().gameObject.GetComponentInChildren<UnityEngine.Camera>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnEnable()
        {
            SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.add_PlaneAddedEvent(value:  new IxVerticalSemanticPlaneDeliverer.Add(object:  this, method:  System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IxSemanticVerticalPlaneVisualizer::AddPlane(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalSupportedPlane plane)));
            SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.add_PlaneBoundaryUpdatedEvent(value:  new IxVerticalSemanticPlaneDeliverer.BoundaryUpdate(object:  this, method:  System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IxSemanticVerticalPlaneVisualizer::UpdateBoundary(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalSupportedPlane plane)));
            SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.add_PlaneRemovedEvent(value:  new IxVerticalSemanticPlaneDeliverer.Remove(object:  this, method:  System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IxSemanticVerticalPlaneVisualizer::RemovePlane(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalSupportedPlane plane)));
            SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.add_PlaneSignificantlyUpdatedEvent(value:  new IxVerticalSemanticPlaneDeliverer.SignificantUpdate(object:  this, method:  System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IxSemanticVerticalPlaneVisualizer::SignificantUpdate(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalSupportedPlane plane)));
            SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.add_PlaneTilesUpdatedEvent(value:  new IxVerticalSemanticPlaneDeliverer.TilesUpdate(object:  this, method:  System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IxSemanticVerticalPlaneVisualizer::AddTile(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalSupportedPlane plane, UnityEngine.Vector2 key, UnityEngine.Vector3[] tileCoords)));
            SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.add_PlaneTileLabeledEvent(value:  new IxVerticalSemanticPlaneDeliverer.TileLabel(object:  this, method:  System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IxSemanticVerticalPlaneVisualizer::LabelTile(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticVerticalPlane plane, UnityEngine.Vector2 key, string label, float confidence)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDisable()
        {
            SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.remove_PlaneTilesUpdatedEvent(value:  new IxVerticalSemanticPlaneDeliverer.TilesUpdate(object:  this, method:  System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IxSemanticVerticalPlaneVisualizer::AddTile(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalSupportedPlane plane, UnityEngine.Vector2 key, UnityEngine.Vector3[] tileCoords)));
            SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.remove_PlaneAddedEvent(value:  new IxVerticalSemanticPlaneDeliverer.Add(object:  this, method:  System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IxSemanticVerticalPlaneVisualizer::AddPlane(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalSupportedPlane plane)));
            SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.remove_PlaneBoundaryUpdatedEvent(value:  new IxVerticalSemanticPlaneDeliverer.BoundaryUpdate(object:  this, method:  System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IxSemanticVerticalPlaneVisualizer::UpdateBoundary(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalSupportedPlane plane)));
            SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.remove_PlaneRemovedEvent(value:  new IxVerticalSemanticPlaneDeliverer.Remove(object:  this, method:  System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IxSemanticVerticalPlaneVisualizer::RemovePlane(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalSupportedPlane plane)));
            SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.remove_PlaneSignificantlyUpdatedEvent(value:  new IxVerticalSemanticPlaneDeliverer.SignificantUpdate(object:  this, method:  System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IxSemanticVerticalPlaneVisualizer::SignificantUpdate(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalSupportedPlane plane)));
            SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.remove_PlaneTileLabeledEvent(value:  new IxVerticalSemanticPlaneDeliverer.TileLabel(object:  this, method:  System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IxSemanticVerticalPlaneVisualizer::LabelTile(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticVerticalPlane plane, UnityEngine.Vector2 key, string label, float confidence)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public IxSemanticVerticalPlaneVisualizer()
        {
            this.showPlane = true;
        }
    
    }

}
