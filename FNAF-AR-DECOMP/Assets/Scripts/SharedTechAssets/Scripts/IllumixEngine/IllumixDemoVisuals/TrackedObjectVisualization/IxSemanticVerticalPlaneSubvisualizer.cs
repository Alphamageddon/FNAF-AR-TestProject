using UnityEngine;

namespace SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.TrackedObjectVisualization
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class IxSemanticVerticalPlaneSubvisualizer
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.GameObject tilePrefab;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.GameObject supportedPlanePrefab;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<UnityEngine.GameObject>> _planeToTiles;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<int, UnityEngine.GameObject> _planeToGameObjects;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<int, System.Collections.Generic.Dictionary<UnityEngine.Vector2, UnityEngine.GameObject>> _planeToTileTextObjects;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Camera _camera;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<UnityEngine.Vector3, System.Collections.Generic.List<string>> LabelsForTile;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<UnityEngine.Vector3, System.Collections.Generic.List<string>> TextForTile;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool showPlane;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 PlaneAndTileToVector3(int planeId, UnityEngine.Vector2 tileKey)
        {
            return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AddPlane(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalSupportedPlane plane)
        {
            System.Collections.Generic.Dictionary<System.Int32, UnityEngine.GameObject> val_5;
            UnityEngine.GameObject val_1 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.supportedPlanePrefab);
            val_1.layer = 0;
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
            if(val_2 != null)
            {
                    val_2.layer = 0;
            }
            else
            {
                    val_2.layer = 0;
            }
            
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
            if((1388579032 & 1) != 0)
            {
                goto label_9;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void RemovePlane(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalSupportedPlane plane)
        {
            var val_14;
            int val_26;
            var val_27;
            var val_28;
            UnityEngine.Object val_29;
            System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.Dictionary<UnityEngine.Vector2, UnityEngine.GameObject>> val_30;
            val_26 = plane;
            UnityEngine.GameObject val_1 = this._planeToGameObjects.Item[W22];
            val_1.SetActive(value:  false);
            UnityEngine.Object.Destroy(obj:  val_1);
            bool val_2 = this._planeToGameObjects.Remove(key:  W22);
            System.Collections.Generic.List<UnityEngine.GameObject> val_3 = this._planeToTiles.Item[W22];
            val_27 = 1152921519845925248;
            val_28 = 0;
            goto label_8;
            label_14:
            val_29 = val_3.Count;
            if(val_28 >= val_29)
            {
                goto label_9;
            }
            
            label_15:
            val_3.Item[0].SetActive(value:  false);
            val_29 = val_3.Item[0];
            UnityEngine.Object.Destroy(obj:  val_29);
            val_28 = 1;
            label_8:
            if(val_3 == null)
            {
                goto label_14;
            }
            
            if(val_28 < val_3.Count)
            {
                goto label_15;
            }
            
            label_9:
            val_3.Clear();
            bool val_8 = this._planeToTiles.Remove(key:  1);
            val_30 = this._planeToTileTextObjects;
            if((val_30.ContainsKey(key:  1)) == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<UnityEngine.Vector2, UnityEngine.GameObject> val_10 = this._planeToTileTextObjects.Item[1];
            Dictionary.ValueCollection.Enumerator<TKey, TValue> val_12 = val_10.Values.GetEnumerator();
            label_26:
            if((1388805680 & 1) == 0)
            {
                goto label_23;
            }
            
            UnityEngine.Object.Destroy(obj:  val_14.emailUIDataHandler);
            goto label_26;
            label_23:
            long val_16 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523175521840});
            val_30 = val_10.Keys;
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_19 = val_30.GetEnumerator();
            val_29 = 1152921523172951360;
            val_27 = 1152921523172953408;
            label_38:
            if((1388805656 & 1) == 0)
            {
                goto label_46;
            }
            
            val_14 = 0;
            bool val_20 = this.LabelsForTile.Remove(key:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            bool val_21 = this.TextForTile.Remove(key:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            goto label_38;
            label_46:
            bool val_24 = this._planeToTileTextObjects.Remove(key:  val_26);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void LabelTile(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticVerticalPlane plane, UnityEngine.Vector2 key, string label, float confidence)
        {
            float val_32;
            UnityEngine.Transform val_33;
            var val_34;
            float val_35;
            float val_36;
            float val_37;
            val_32 = key.x;
            if((this._planeToTileTextObjects.ContainsKey(key:  W23)) != true)
            {
                    this._planeToTileTextObjects.set_Item(key:  W23, value:  new System.Collections.Generic.Dictionary<UnityEngine.Vector2, UnityEngine.GameObject>());
            }
            
            val_34 = this._planeToTileTextObjects.Item[W23];
            val_35 = 0f;
            val_36 = 0f;
            if((val_34.ContainsKey(key:  new UnityEngine.Vector2() {x = val_32, y = key.y})) != false)
            {
                    if((this.LabelsForTile.Item[new UnityEngine.Vector3() {x = val_35, y = 0f, z = val_36}].Contains(item:  label)) == true)
            {
                    return;
            }
            
                UnityEngine.GameObject val_7 = val_34.Item[new UnityEngine.Vector2() {x = val_32, y = key.y}];
                UnityEngine.TextMesh val_8 = val_7.GetComponent<UnityEngine.TextMesh>();
                val_8.text = val_8.text + " " + label;
                val_33 = this._camera.transform;
                val_7.transform.LookAt(target:  val_33);
                UnityEngine.Vector3 val_14 = UnityEngine.Vector3.up;
                val_37 = val_14.z;
                UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_37}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                val_32 = val_15.y;
                val_7.transform.Rotate(eulers:  new UnityEngine.Vector3() {x = val_15.x, y = val_32, z = val_15.z});
                val_35 = val_35;
                val_34 = this.LabelsForTile.Item[new UnityEngine.Vector3() {x = val_35, y = 0f, z = val_36}];
                val_34.Add(item:  label);
                this.TextForTile.Item[new UnityEngine.Vector3() {x = val_35, y = 0f, z = val_36}].Add(item:  label);
                return;
            }
            
            UnityEngine.Vector3[] val_18 = X23.Item[new UnityEngine.Vector2() {x = val_32, y = key.y}];
            UnityEngine.Vector3[] val_19 = plane.Item[new UnityEngine.Vector2() {x = val_32, y = key.y}];
            UnityEngine.Vector3 val_20 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_18[0], y = val_18[0], z = val_18[1]}, b:  new UnityEngine.Vector3() {x = val_19[3], y = val_19[3], z = val_19[4]});
            UnityEngine.Vector3 val_21 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z}, d:  2f);
            UnityEngine.GameObject val_22 = new UnityEngine.GameObject();
            UnityEngine.TextMesh val_23 = val_22.AddComponent<UnityEngine.TextMesh>();
            if(val_23 != null)
            {
                    val_23.text = label;
                val_23.fontSize = 15;
            }
            else
            {
                    val_23.text = label;
                val_23.fontSize = 15;
            }
            
            val_23.characterSize = 0.01f;
            val_22.transform.position = new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z};
            val_36 = 0f;
            val_22.transform.LookAt(target:  this._camera.transform);
            UnityEngine.Vector3 val_28 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_29 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            val_37 = val_29.z;
            val_22.transform.Rotate(eulers:  new UnityEngine.Vector3() {x = val_29.x, y = val_29.y, z = val_37});
            System.Collections.Generic.List<System.String> val_30 = new System.Collections.Generic.List<System.String>();
            val_30.Add(item:  label);
            val_35 = val_35;
            this.LabelsForTile.set_Item(key:  new UnityEngine.Vector3() {x = val_35, y = val_36, z = val_36}, value:  val_30);
            System.Collections.Generic.List<System.String> val_31 = null;
            val_33 = val_31;
            val_31 = new System.Collections.Generic.List<System.String>();
            val_31.Add(item:  label);
            this.TextForTile.set_Item(key:  new UnityEngine.Vector3() {x = val_35, y = val_36, z = val_36}, value:  val_31);
            val_34.set_Item(key:  new UnityEngine.Vector2() {x = val_32, y = key.y}, value:  val_22);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void UpdateTextMesh(int planeId, UnityEngine.Vector2 tileKey, string label, UnityEngine.Color color)
        {
            var val_17;
            var val_18;
            string val_19;
            var val_20;
            System.Collections.Generic.List<System.String> val_4 = this.TextForTile.Item[new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}];
            System.Collections.Generic.List<System.String> val_5 = this.LabelsForTile.Item[new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}];
            val_17 = 1152921517172219232;
            val_18 = "</color>";
            val_19 = 0;
            goto label_6;
            label_27:
            if((System.String.op_Equality(a:  label, b:  val_5.Item[0])) != false)
            {
                    string[] val_9 = new string[5];
                val_9[0] = "<color=#";
                val_9[1] = UnityEngine.ColorUtility.ToHtmlStringRGBA(color:  new UnityEngine.Color() {r = color.r, g = color.g, b = color.b, a = color.a});
                val_18 = val_18;
                val_9[2] = ">";
                val_9[3] = label;
                val_9[4] = "</color>";
                val_4.set_Item(index:  0, value:  +val_9);
                val_17 = 1152921517172219232;
            }
            
            val_19 = 1;
            label_6:
            if(val_19 < val_5.Count)
            {
                goto label_27;
            }
            
            System.Text.StringBuilder val_12 = new System.Text.StringBuilder();
            val_20 = 0;
            goto label_28;
            label_34:
            val_19 = val_4.Item[0];
            System.Text.StringBuilder val_14 = val_12.Append(value:  val_19);
            if(val_20 != 0)
            {
                    System.Text.StringBuilder val_15 = val_12.Append(value:  " ");
            }
            
            val_20 = 1;
            label_28:
            if(val_20 < val_4.Count)
            {
                goto label_34;
            }
            
            this._planeToTileTextObjects.Item[planeId].Item[new UnityEngine.Vector2() {x = tileKey.x, y = tileKey.y}].GetComponent<UnityEngine.TextMesh>().text = val_12;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public IxSemanticVerticalPlaneSubvisualizer(UnityEngine.Camera camera, UnityEngine.GameObject tilePrefab, UnityEngine.GameObject planePrefab)
        {
            this.showPlane = true;
            val_1 = new System.Object();
            this.tilePrefab = val_1;
            this.supportedPlanePrefab = planePrefab;
            this._planeToGameObjects = new System.Collections.Generic.Dictionary<System.Int32, UnityEngine.GameObject>();
            this._planeToTiles = new System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.List<UnityEngine.GameObject>>();
            this._planeToTileTextObjects = new System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.Dictionary<UnityEngine.Vector2, UnityEngine.GameObject>>();
            this.LabelsForTile = new System.Collections.Generic.Dictionary<UnityEngine.Vector3, System.Collections.Generic.List<System.String>>();
            this.TextForTile = new System.Collections.Generic.Dictionary<UnityEngine.Vector3, System.Collections.Generic.List<System.String>>();
            this._camera = camera;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnEnable()
        {
            SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.add_PlaneAddedEvent(value:  new IxVerticalSemanticPlaneDeliverer.Add(object:  this, method:  System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.TrackedObjectVisualization.IxSemanticVerticalPlaneSubvisualizer::AddPlane(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalSupportedPlane plane)));
            SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.add_PlaneBoundaryUpdatedEvent(value:  new IxVerticalSemanticPlaneDeliverer.BoundaryUpdate(object:  this, method:  System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.TrackedObjectVisualization.IxSemanticVerticalPlaneSubvisualizer::UpdateBoundary(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalSupportedPlane plane)));
            SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.add_PlaneRemovedEvent(value:  new IxVerticalSemanticPlaneDeliverer.Remove(object:  this, method:  System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.TrackedObjectVisualization.IxSemanticVerticalPlaneSubvisualizer::RemovePlane(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalSupportedPlane plane)));
            SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.add_PlaneSignificantlyUpdatedEvent(value:  new IxVerticalSemanticPlaneDeliverer.SignificantUpdate(object:  this, method:  System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.TrackedObjectVisualization.IxSemanticVerticalPlaneSubvisualizer::SignificantUpdate(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalSupportedPlane plane)));
            SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.add_PlaneTilesUpdatedEvent(value:  new IxVerticalSemanticPlaneDeliverer.TilesUpdate(object:  this, method:  System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.TrackedObjectVisualization.IxSemanticVerticalPlaneSubvisualizer::AddTile(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalSupportedPlane plane, UnityEngine.Vector2 key, UnityEngine.Vector3[] tileCoords)));
            SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.add_PlaneTileLabeledEvent(value:  new IxVerticalSemanticPlaneDeliverer.TileLabel(object:  this, method:  System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.TrackedObjectVisualization.IxSemanticVerticalPlaneSubvisualizer::LabelTile(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticVerticalPlane plane, UnityEngine.Vector2 key, string label, float confidence)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnDisable()
        {
            SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.remove_PlaneTilesUpdatedEvent(value:  new IxVerticalSemanticPlaneDeliverer.TilesUpdate(object:  this, method:  System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.TrackedObjectVisualization.IxSemanticVerticalPlaneSubvisualizer::AddTile(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalSupportedPlane plane, UnityEngine.Vector2 key, UnityEngine.Vector3[] tileCoords)));
            SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.remove_PlaneAddedEvent(value:  new IxVerticalSemanticPlaneDeliverer.Add(object:  this, method:  System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.TrackedObjectVisualization.IxSemanticVerticalPlaneSubvisualizer::AddPlane(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalSupportedPlane plane)));
            SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.remove_PlaneBoundaryUpdatedEvent(value:  new IxVerticalSemanticPlaneDeliverer.BoundaryUpdate(object:  this, method:  System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.TrackedObjectVisualization.IxSemanticVerticalPlaneSubvisualizer::UpdateBoundary(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalSupportedPlane plane)));
            SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.remove_PlaneRemovedEvent(value:  new IxVerticalSemanticPlaneDeliverer.Remove(object:  this, method:  System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.TrackedObjectVisualization.IxSemanticVerticalPlaneSubvisualizer::RemovePlane(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalSupportedPlane plane)));
            SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.remove_PlaneSignificantlyUpdatedEvent(value:  new IxVerticalSemanticPlaneDeliverer.SignificantUpdate(object:  this, method:  System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.TrackedObjectVisualization.IxSemanticVerticalPlaneSubvisualizer::SignificantUpdate(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalSupportedPlane plane)));
            SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.remove_PlaneTileLabeledEvent(value:  new IxVerticalSemanticPlaneDeliverer.TileLabel(object:  this, method:  System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.TrackedObjectVisualization.IxSemanticVerticalPlaneSubvisualizer::LabelTile(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticVerticalPlane plane, UnityEngine.Vector2 key, string label, float confidence)));
        }
    
    }

}
