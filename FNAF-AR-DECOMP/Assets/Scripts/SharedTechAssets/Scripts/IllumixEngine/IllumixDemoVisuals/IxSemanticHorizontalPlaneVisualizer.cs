using UnityEngine;

namespace SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class IxSemanticHorizontalPlaneVisualizer : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.GameObject tilePrefab;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.GameObject supportedPlanePrefab;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<int, System.Collections.Generic.Dictionary<UnityEngine.Vector2, UnityEngine.GameObject>> planeToTileObjects;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<UnityEngine.Vector3>> planeToGridPoints;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<int, UnityEngine.GameObject> planeToGameObjects;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<int, System.Collections.Generic.Dictionary<UnityEngine.Vector2, UnityEngine.GameObject>> planeToTileTextObjects;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Camera _camera;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool showPlane;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly UnityEngine.Vector3[] verticesBuffer;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AddPlane(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticHorizontalPlane plane)
        {
            UnityEngine.GameObject val_1 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.supportedPlanePrefab);
            val_1.layer = 0;
            if(this.showPlane != false)
            {
                    val_1.GetComponent<SimpleConvexMesh>().InitializeMesh(orderedConvexVertices:  plane.Boundary.ToArray());
            }
            
            this.planeToGameObjects.set_Item(key:  plane.Key, value:  val_1);
            this.planeToGridPoints.set_Item(key:  plane.Key, value:  new System.Collections.Generic.List<UnityEngine.Vector3>());
            this.planeToTileObjects.set_Item(key:  plane.Key, value:  new System.Collections.Generic.Dictionary<UnityEngine.Vector2, UnityEngine.GameObject>());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SignificantUpdate(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticHorizontalPlane plane)
        {
            if(this.showPlane != false)
            {
                    this.UpdateBoundary(plane:  plane);
            }
            
            this.UpdateAllTiles(plane:  plane);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateBoundary(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticHorizontalPlane plane)
        {
            if(this.showPlane == false)
            {
                    return;
            }
            
            this.planeToGameObjects.Item[plane.Key].GetComponent<SimpleConvexMesh>().UpdateMesh(convexVertices:  plane.Boundary.ToArray());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AddTile(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticHorizontalPlane plane, UnityEngine.Vector2 center)
        {
            float val_1 = plane.Height;
            float val_2 = S10 * 0.5f;
            float val_3 = center.x - val_2;
            float val_4 = center.y - val_2;
            float val_5 = plane.Height;
            float val_6 = center.y + val_2;
            float val_7 = plane.Height;
            float val_8 = center.x + val_2;
            float val_9 = plane.Height;
            UnityEngine.GameObject val_12 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.tilePrefab);
            if(val_12 != null)
            {
                    val_12.layer = 0;
            }
            else
            {
                    val_12.layer = 0;
            }
            
            val_12.GetComponent<SimpleConvexMesh>().InitializeMesh(orderedConvexVertices:  this.verticesBuffer);
            this.planeToTileObjects.Item[plane.Key].set_Item(key:  new UnityEngine.Vector2() {x = center.x, y = center.y}, value:  val_12);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateAllTiles(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticHorizontalPlane plane)
        {
            float val_5;
            int val_1 = plane.Key;
            HashSet.Enumerator<T> val_3 = val_1.GetEnumerator();
            label_20:
            if((1375203360 & 1) == 0)
            {
                    return;
            }
            
            float val_6 = plane.Height;
            float val_7 = S10 * 0.5f;
            float val_8 = val_5 - val_7;
            float val_9 = V1.16B - val_7;
            float val_10 = plane.Height;
            float val_11 = V1.16B + val_7;
            float val_12 = plane.Height;
            float val_13 = val_5 + val_7;
            float val_14 = plane.Height;
            this.planeToTileObjects.Item[val_1].Item[new UnityEngine.Vector2() {x = val_5, y = V1.16B}].GetComponent<SimpleConvexMesh>().UpdateMesh(convexVertices:  this.verticesBuffer);
            goto label_20;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void RemovePlane(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticHorizontalPlane plane)
        {
            float val_9;
            var val_15;
            UnityEngine.GameObject val_2 = this.planeToGameObjects.Item[plane.Key];
            val_2.SetActive(value:  false);
            UnityEngine.Object.Destroy(obj:  val_2);
            bool val_4 = this.planeToGameObjects.Remove(key:  plane.Key);
            int val_5 = plane.Key;
            val_15 = this.planeToTileObjects.Item[val_5];
            HashSet.Enumerator<T> val_7 = val_5.GetEnumerator();
            label_17:
            if((1375561184 & 1) == 0)
            {
                goto label_12;
            }
            
            UnityEngine.GameObject val_10 = val_15.Item[new UnityEngine.Vector2() {x = val_9, y = V1.16B}];
            val_10.SetActive(value:  false);
            UnityEngine.Object.Destroy(obj:  val_10);
            goto label_17;
            label_12:
            long val_11 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523162277344});
            bool val_14 = this.planeToTileObjects.Remove(key:  plane.Key);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void LabelTile(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticHorizontalPlane plane, UnityEngine.Vector2 key, string label, float confidence)
        {
            float val_24;
            int val_25;
            UnityEngine.Transform val_26;
            var val_27;
            float val_28;
            val_24 = key.y;
            if((this.planeToTileTextObjects.ContainsKey(key:  plane.Key)) != true)
            {
                    this.planeToTileTextObjects.set_Item(key:  plane.Key, value:  new System.Collections.Generic.Dictionary<UnityEngine.Vector2, UnityEngine.GameObject>());
            }
            
            val_25 = plane.Key;
            System.Collections.Generic.Dictionary<UnityEngine.Vector2, UnityEngine.GameObject> val_6 = this.planeToTileTextObjects.Item[val_25];
            if((val_6.ContainsKey(key:  new UnityEngine.Vector2() {x = key.x, y = val_24})) != false)
            {
                    UnityEngine.GameObject val_8 = val_6.Item[new UnityEngine.Vector2() {x = key.x, y = val_24}];
                val_8.GetComponent<UnityEngine.TextMesh>().text = label;
                val_26 = this._camera.transform;
                val_8.transform.LookAt(target:  val_26);
                val_27 = val_8.transform;
                UnityEngine.Vector3 val_13 = UnityEngine.Vector3.up;
                UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                val_24 = val_14.x;
                val_28 = val_14.z;
                val_27.Rotate(eulers:  new UnityEngine.Vector3() {x = val_24, y = val_14.y, z = val_28});
                return;
            }
            
            float val_15 = plane.Height;
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
            val_16.transform.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            val_26 = this._camera.transform;
            val_16.transform.LookAt(target:  val_26);
            val_27 = val_16.transform;
            UnityEngine.Vector3 val_22 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_23 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            val_28 = val_23.x;
            val_27.Rotate(eulers:  new UnityEngine.Vector3() {x = val_28, y = val_23.y, z = val_23.z});
            val_6.set_Item(key:  new UnityEngine.Vector2() {x = key.x, y = val_24}, value:  val_16);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            this.planeToGameObjects = new System.Collections.Generic.Dictionary<System.Int32, UnityEngine.GameObject>();
            this.planeToGridPoints = new System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.List<UnityEngine.Vector3>>();
            this.planeToTileObjects = new System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.Dictionary<UnityEngine.Vector2, UnityEngine.GameObject>>();
            this.planeToTileTextObjects = new System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.Dictionary<UnityEngine.Vector2, UnityEngine.GameObject>>();
            this._camera = this.GetComponentInParent<UnityEngine.XR.ARFoundation.ARSessionOrigin>().gameObject.GetComponentInChildren<UnityEngine.Camera>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnEnable()
        {
            mem[1152921523162948320] = this;
            mem[1152921523162948328] = System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IxSemanticHorizontalPlaneVisualizer::AddPlane(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticHorizontalPlane plane);
            mem[1152921523162948304] = System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IxSemanticHorizontalPlaneVisualizer::AddPlane(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticHorizontalPlane plane);
            SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSemanticPlaneDeliverer.add_PlaneAddedEvent(value:  new IxHorizontalSemanticPlaneDeliverer.Add());
            mem[1152921523162952416] = this;
            mem[1152921523162952424] = System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IxSemanticHorizontalPlaneVisualizer::UpdateBoundary(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticHorizontalPlane plane);
            mem[1152921523162952400] = System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IxSemanticHorizontalPlaneVisualizer::UpdateBoundary(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticHorizontalPlane plane);
            SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSemanticPlaneDeliverer.add_PlaneBoundaryUpdatedEvent(value:  new IxHorizontalSemanticPlaneDeliverer.BoundaryUpdate());
            mem[1152921523162956512] = this;
            mem[1152921523162956520] = System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IxSemanticHorizontalPlaneVisualizer::SignificantUpdate(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticHorizontalPlane plane);
            mem[1152921523162956496] = System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IxSemanticHorizontalPlaneVisualizer::SignificantUpdate(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticHorizontalPlane plane);
            SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSemanticPlaneDeliverer.add_PlaneSignificantlyUpdatedEvent(value:  new IxHorizontalSemanticPlaneDeliverer.SignificantUpdate());
            mem[1152921523162960608] = this;
            mem[1152921523162960616] = System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IxSemanticHorizontalPlaneVisualizer::AddTile(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticHorizontalPlane plane, UnityEngine.Vector2 center);
            mem[1152921523162960592] = System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IxSemanticHorizontalPlaneVisualizer::AddTile(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticHorizontalPlane plane, UnityEngine.Vector2 center);
            SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSemanticPlaneDeliverer.add_PlaneTileAddedEvent(value:  new IxHorizontalSemanticPlaneDeliverer.TileUpdate());
            mem[1152921523162964704] = this;
            mem[1152921523162964712] = System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IxSemanticHorizontalPlaneVisualizer::LabelTile(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticHorizontalPlane plane, UnityEngine.Vector2 key, string label, float confidence);
            mem[1152921523162964688] = System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IxSemanticHorizontalPlaneVisualizer::LabelTile(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticHorizontalPlane plane, UnityEngine.Vector2 key, string label, float confidence);
            SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSemanticPlaneDeliverer.add_PlaneTileLabeledEvent(value:  new IxHorizontalSemanticPlaneDeliverer.TileLabel());
            mem[1152921523162968800] = this;
            mem[1152921523162968808] = System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IxSemanticHorizontalPlaneVisualizer::RemovePlane(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticHorizontalPlane plane);
            mem[1152921523162968784] = System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IxSemanticHorizontalPlaneVisualizer::RemovePlane(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticHorizontalPlane plane);
            SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSemanticPlaneDeliverer.add_PlaneRemovedEvent(value:  new IxHorizontalSemanticPlaneDeliverer.Remove());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDisable()
        {
            mem[1152921523163109472] = this;
            mem[1152921523163109480] = System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IxSemanticHorizontalPlaneVisualizer::AddPlane(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticHorizontalPlane plane);
            mem[1152921523163109456] = System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IxSemanticHorizontalPlaneVisualizer::AddPlane(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticHorizontalPlane plane);
            SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSemanticPlaneDeliverer.remove_PlaneAddedEvent(value:  new IxHorizontalSemanticPlaneDeliverer.Add());
            mem[1152921523163113568] = this;
            mem[1152921523163113576] = System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IxSemanticHorizontalPlaneVisualizer::SignificantUpdate(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticHorizontalPlane plane);
            mem[1152921523163113552] = System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IxSemanticHorizontalPlaneVisualizer::SignificantUpdate(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticHorizontalPlane plane);
            SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSemanticPlaneDeliverer.remove_PlaneSignificantlyUpdatedEvent(value:  new IxHorizontalSemanticPlaneDeliverer.SignificantUpdate());
            mem[1152921523163117664] = this;
            mem[1152921523163117672] = System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IxSemanticHorizontalPlaneVisualizer::UpdateBoundary(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticHorizontalPlane plane);
            mem[1152921523163117648] = System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IxSemanticHorizontalPlaneVisualizer::UpdateBoundary(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticHorizontalPlane plane);
            SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSemanticPlaneDeliverer.remove_PlaneBoundaryUpdatedEvent(value:  new IxHorizontalSemanticPlaneDeliverer.BoundaryUpdate());
            mem[1152921523163121760] = this;
            mem[1152921523163121768] = System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IxSemanticHorizontalPlaneVisualizer::AddTile(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticHorizontalPlane plane, UnityEngine.Vector2 center);
            mem[1152921523163121744] = System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IxSemanticHorizontalPlaneVisualizer::AddTile(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticHorizontalPlane plane, UnityEngine.Vector2 center);
            SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSemanticPlaneDeliverer.remove_PlaneTileAddedEvent(value:  new IxHorizontalSemanticPlaneDeliverer.TileUpdate());
            mem[1152921523163125856] = this;
            mem[1152921523163125864] = System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IxSemanticHorizontalPlaneVisualizer::RemovePlane(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticHorizontalPlane plane);
            mem[1152921523163125840] = System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IxSemanticHorizontalPlaneVisualizer::RemovePlane(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticHorizontalPlane plane);
            SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSemanticPlaneDeliverer.remove_PlaneRemovedEvent(value:  new IxHorizontalSemanticPlaneDeliverer.Remove());
            mem[1152921523163129952] = this;
            mem[1152921523163129960] = System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IxSemanticHorizontalPlaneVisualizer::LabelTile(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticHorizontalPlane plane, UnityEngine.Vector2 key, string label, float confidence);
            mem[1152921523163129936] = System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IxSemanticHorizontalPlaneVisualizer::LabelTile(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticHorizontalPlane plane, UnityEngine.Vector2 key, string label, float confidence);
            SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSemanticPlaneDeliverer.remove_PlaneTileLabeledEvent(value:  new IxHorizontalSemanticPlaneDeliverer.TileLabel());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public IxSemanticHorizontalPlaneVisualizer()
        {
            this.showPlane = true;
            this.verticesBuffer = new UnityEngine.Vector3[4];
        }
    
    }

}
