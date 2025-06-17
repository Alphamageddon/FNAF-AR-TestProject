using UnityEngine;

namespace SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.TrackedObjectVisualization
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class IxSemanticHorizontalPlaneSubvisualizer
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.GameObject tilePrefab;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.GameObject supportedPlanePrefab;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<int, System.Collections.Generic.Dictionary<UnityEngine.Vector2, UnityEngine.GameObject>> planeToTileObjects;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<UnityEngine.Vector3>> planeToGridPoints;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<int, UnityEngine.GameObject> planeToGameObjects;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<int, System.Collections.Generic.Dictionary<UnityEngine.Vector2, UnityEngine.GameObject>> planeToTileTextObjects;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<UnityEngine.Vector3, System.Collections.Generic.List<string>> LabelsForTile;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<UnityEngine.Vector3, System.Collections.Generic.List<string>> TextForTile;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Camera _camera;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool showPlane;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly UnityEngine.Vector3[] verticesBuffer;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 PlaneAndTileToVector3(int planeId, UnityEngine.Vector2 tileKey)
        {
            return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
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
            if((1385861600 & 1) == 0)
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
            int val_32;
            var val_33;
            System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.Dictionary<UnityEngine.Vector2, UnityEngine.GameObject>> val_35;
            val_32 = plane;
            UnityEngine.GameObject val_2 = this.planeToGameObjects.Item[val_32.Key];
            val_2.SetActive(value:  false);
            UnityEngine.Object.Destroy(obj:  val_2);
            bool val_4 = this.planeToGameObjects.Remove(key:  val_32.Key);
            int val_5 = val_32.Key;
            val_33 = 1152921523148919008;
            HashSet.Enumerator<T> val_7 = val_5.GetEnumerator();
            label_17:
            if((1386267536 & 1) == 0)
            {
                goto label_12;
            }
            
            UnityEngine.GameObject val_10 = this.planeToTileObjects.Item[val_5].Item[new UnityEngine.Vector2() {x = val_9, y = V1.16B}];
            val_10.SetActive(value:  false);
            UnityEngine.Object.Destroy(obj:  val_10);
            goto label_17;
            label_12:
            long val_11 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523172983696});
            bool val_14 = this.planeToTileObjects.Remove(key:  val_32.Key);
            val_35 = this.planeToTileTextObjects;
            if((val_35.ContainsKey(key:  val_32.Key)) == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<UnityEngine.Vector2, UnityEngine.GameObject> val_18 = this.planeToTileTextObjects.Item[val_32.Key];
            Dictionary.ValueCollection.Enumerator<TKey, TValue> val_20 = val_18.Values.GetEnumerator();
            label_35:
            if((1386267504 & 1) == 0)
            {
                goto label_32;
            }
            
            UnityEngine.Object.Destroy(obj:  val_9.emailUIDataHandler);
            goto label_35;
            label_32:
            val_35 = 0;
            long val_22 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523172983664});
            if(((241 == 0) ? 241 : 241) != 241)
            {
                goto label_39;
            }
            
            if(val_18 != null)
            {
                goto label_43;
            }
            
            goto label_41;
            label_39:
            if( != 0)
            {
                    val_35 = 0;
            }
            
            if(val_18 != null)
            {
                goto label_43;
            }
            
            label_41:
            label_43:
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_25 = val_18.Keys.GetEnumerator();
            val_33 = 1152921523172951360;
            label_49:
            if((1386267480 & 1) == 0)
            {
                goto label_50;
            }
            
            int val_26 = val_32.Key;
            val_9 = 0;
            bool val_27 = this.LabelsForTile.Remove(key:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            bool val_28 = this.TextForTile.Remove(key:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            goto label_49;
            label_50:
            long val_29 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523172983640});
            val_32 = val_32.Key;
            bool val_31 = this.planeToTileTextObjects.Remove(key:  val_32);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void LabelTile(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticHorizontalPlane plane, UnityEngine.Vector2 key, string label, float confidence)
        {
            float val_33;
            int val_34;
            var val_35;
            val_33 = key.x;
            if((this.planeToTileTextObjects.ContainsKey(key:  plane.Key)) != true)
            {
                    this.planeToTileTextObjects.set_Item(key:  plane.Key, value:  new System.Collections.Generic.Dictionary<UnityEngine.Vector2, UnityEngine.GameObject>());
            }
            
            val_34 = plane.Key;
            val_35 = this.planeToTileTextObjects.Item[val_34];
            int val_7 = plane.Key;
            if((val_35.ContainsKey(key:  new UnityEngine.Vector2() {x = val_33, y = key.y})) != false)
            {
                    if((this.LabelsForTile.Item[new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}].Contains(item:  label)) == true)
            {
                    return;
            }
            
                UnityEngine.GameObject val_11 = val_35.Item[new UnityEngine.Vector2() {x = val_33, y = key.y}];
                UnityEngine.TextMesh val_12 = val_11.GetComponent<UnityEngine.TextMesh>();
                val_12.text = val_12.text + label;
                val_34 = this._camera.transform;
                val_11.transform.LookAt(target:  val_34);
                UnityEngine.Vector3 val_18 = UnityEngine.Vector3.up;
                UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                val_33 = val_19.y;
                val_11.transform.Rotate(eulers:  new UnityEngine.Vector3() {x = val_19.x, y = val_33, z = val_19.z});
                val_35 = this.LabelsForTile.Item[new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}];
                val_35.Add(item:  label);
                this.TextForTile.Item[new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}].Add(item:  label);
                return;
            }
            
            float val_22 = plane.Height;
            UnityEngine.GameObject val_23 = new UnityEngine.GameObject();
            UnityEngine.TextMesh val_24 = val_23.AddComponent<UnityEngine.TextMesh>();
            if(val_24 != null)
            {
                    val_24.text = label;
                val_24.fontSize = 15;
            }
            else
            {
                    val_24.text = label;
                val_24.fontSize = 15;
            }
            
            val_24.characterSize = 0.01f;
            val_23.transform.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            val_23.transform.LookAt(target:  this._camera.transform);
            UnityEngine.Vector3 val_29 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_30 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_29.x, y = val_29.y, z = val_29.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            val_23.transform.Rotate(eulers:  new UnityEngine.Vector3() {x = val_30.x, y = val_30.y, z = val_30.z});
            System.Collections.Generic.List<System.String> val_31 = new System.Collections.Generic.List<System.String>();
            val_31.Add(item:  label);
            this.LabelsForTile.set_Item(key:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, value:  val_31);
            System.Collections.Generic.List<System.String> val_32 = null;
            val_34 = val_32;
            val_32 = new System.Collections.Generic.List<System.String>();
            val_32.Add(item:  label);
            this.TextForTile.set_Item(key:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, value:  val_32);
            val_35.set_Item(key:  new UnityEngine.Vector2() {x = val_33, y = key.y}, value:  val_23);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void UpdateTextMesh(int planeId, UnityEngine.Vector2 tileKey, string label, UnityEngine.Color color)
        {
            var val_19;
            var val_20;
            string val_21;
            var val_22;
            System.Collections.Generic.List<System.String> val_4 = this.TextForTile.Item[new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}];
            System.Collections.Generic.List<System.String> val_5 = this.LabelsForTile.Item[new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}];
            val_19 = 1152921517172219232;
            val_20 = "</color>";
            val_21 = 0;
            goto label_6;
            label_27:
            if((System.String.op_Equality(a:  label, b:  val_5.Item[0])) != false)
            {
                    string[] val_9 = new string[5];
                val_9[0] = "<color=#";
                val_9[1] = UnityEngine.ColorUtility.ToHtmlStringRGBA(color:  new UnityEngine.Color() {r = color.r, g = color.g, b = color.b, a = color.a});
                val_20 = val_20;
                val_9[2] = ">";
                val_9[3] = label;
                val_9[4] = "</color>";
                val_4.set_Item(index:  0, value:  +val_9);
                val_19 = 1152921517172219232;
            }
            
            val_21 = 1;
            label_6:
            if(val_21 < val_5.Count)
            {
                goto label_27;
            }
            
            System.Text.StringBuilder val_12 = new System.Text.StringBuilder();
            val_22 = 0;
            goto label_28;
            label_35:
            val_21 = val_4.Item[0];
            System.Text.StringBuilder val_14 = val_12.Append(value:  val_21);
            if(val_22 != (val_4.Count - 1))
            {
                    System.Text.StringBuilder val_17 = val_12.Append(value:  "\n");
            }
            
            val_22 = 1;
            label_28:
            if(val_22 < val_4.Count)
            {
                goto label_35;
            }
            
            this.planeToTileTextObjects.Item[planeId].Item[new UnityEngine.Vector2() {x = tileKey.x, y = tileKey.y}].GetComponent<UnityEngine.TextMesh>().text = val_12;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public IxSemanticHorizontalPlaneSubvisualizer(UnityEngine.Camera camera, UnityEngine.GameObject tilePrefab, UnityEngine.GameObject planePrefab)
        {
            this.showPlane = true;
            this.verticesBuffer = new UnityEngine.Vector3[4];
            val_2 = new System.Object();
            this.tilePrefab = val_2;
            this.supportedPlanePrefab = planePrefab;
            this.planeToGameObjects = new System.Collections.Generic.Dictionary<System.Int32, UnityEngine.GameObject>();
            this.planeToGridPoints = new System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.List<UnityEngine.Vector3>>();
            this.planeToTileObjects = new System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.Dictionary<UnityEngine.Vector2, UnityEngine.GameObject>>();
            this.planeToTileTextObjects = new System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.Dictionary<UnityEngine.Vector2, UnityEngine.GameObject>>();
            this.LabelsForTile = new System.Collections.Generic.Dictionary<UnityEngine.Vector3, System.Collections.Generic.List<System.String>>();
            this.TextForTile = new System.Collections.Generic.Dictionary<UnityEngine.Vector3, System.Collections.Generic.List<System.String>>();
            this._camera = camera;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnEnable()
        {
            mem[1152921523174067904] = this;
            mem[1152921523174067912] = System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.TrackedObjectVisualization.IxSemanticHorizontalPlaneSubvisualizer::AddPlane(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticHorizontalPlane plane);
            mem[1152921523174067888] = System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.TrackedObjectVisualization.IxSemanticHorizontalPlaneSubvisualizer::AddPlane(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticHorizontalPlane plane);
            SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSemanticPlaneDeliverer.add_PlaneAddedEvent(value:  new IxHorizontalSemanticPlaneDeliverer.Add());
            mem[1152921523174072000] = this;
            mem[1152921523174072008] = System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.TrackedObjectVisualization.IxSemanticHorizontalPlaneSubvisualizer::UpdateBoundary(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticHorizontalPlane plane);
            mem[1152921523174071984] = System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.TrackedObjectVisualization.IxSemanticHorizontalPlaneSubvisualizer::UpdateBoundary(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticHorizontalPlane plane);
            SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSemanticPlaneDeliverer.add_PlaneBoundaryUpdatedEvent(value:  new IxHorizontalSemanticPlaneDeliverer.BoundaryUpdate());
            mem[1152921523174076096] = this;
            mem[1152921523174076104] = System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.TrackedObjectVisualization.IxSemanticHorizontalPlaneSubvisualizer::SignificantUpdate(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticHorizontalPlane plane);
            mem[1152921523174076080] = System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.TrackedObjectVisualization.IxSemanticHorizontalPlaneSubvisualizer::SignificantUpdate(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticHorizontalPlane plane);
            SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSemanticPlaneDeliverer.add_PlaneSignificantlyUpdatedEvent(value:  new IxHorizontalSemanticPlaneDeliverer.SignificantUpdate());
            mem[1152921523174080192] = this;
            mem[1152921523174080200] = System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.TrackedObjectVisualization.IxSemanticHorizontalPlaneSubvisualizer::AddTile(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticHorizontalPlane plane, UnityEngine.Vector2 center);
            mem[1152921523174080176] = System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.TrackedObjectVisualization.IxSemanticHorizontalPlaneSubvisualizer::AddTile(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticHorizontalPlane plane, UnityEngine.Vector2 center);
            SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSemanticPlaneDeliverer.add_PlaneTileAddedEvent(value:  new IxHorizontalSemanticPlaneDeliverer.TileUpdate());
            mem[1152921523174084288] = this;
            mem[1152921523174084296] = System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.TrackedObjectVisualization.IxSemanticHorizontalPlaneSubvisualizer::LabelTile(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticHorizontalPlane plane, UnityEngine.Vector2 key, string label, float confidence);
            mem[1152921523174084272] = System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.TrackedObjectVisualization.IxSemanticHorizontalPlaneSubvisualizer::LabelTile(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticHorizontalPlane plane, UnityEngine.Vector2 key, string label, float confidence);
            SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSemanticPlaneDeliverer.add_PlaneTileLabeledEvent(value:  new IxHorizontalSemanticPlaneDeliverer.TileLabel());
            mem[1152921523174088384] = this;
            mem[1152921523174088392] = System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.TrackedObjectVisualization.IxSemanticHorizontalPlaneSubvisualizer::RemovePlane(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticHorizontalPlane plane);
            mem[1152921523174088368] = System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.TrackedObjectVisualization.IxSemanticHorizontalPlaneSubvisualizer::RemovePlane(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticHorizontalPlane plane);
            SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSemanticPlaneDeliverer.add_PlaneRemovedEvent(value:  new IxHorizontalSemanticPlaneDeliverer.Remove());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnDisable()
        {
            mem[1152921523174229056] = this;
            mem[1152921523174229064] = System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.TrackedObjectVisualization.IxSemanticHorizontalPlaneSubvisualizer::AddPlane(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticHorizontalPlane plane);
            mem[1152921523174229040] = System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.TrackedObjectVisualization.IxSemanticHorizontalPlaneSubvisualizer::AddPlane(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticHorizontalPlane plane);
            SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSemanticPlaneDeliverer.remove_PlaneAddedEvent(value:  new IxHorizontalSemanticPlaneDeliverer.Add());
            mem[1152921523174233152] = this;
            mem[1152921523174233160] = System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.TrackedObjectVisualization.IxSemanticHorizontalPlaneSubvisualizer::SignificantUpdate(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticHorizontalPlane plane);
            mem[1152921523174233136] = System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.TrackedObjectVisualization.IxSemanticHorizontalPlaneSubvisualizer::SignificantUpdate(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticHorizontalPlane plane);
            SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSemanticPlaneDeliverer.remove_PlaneSignificantlyUpdatedEvent(value:  new IxHorizontalSemanticPlaneDeliverer.SignificantUpdate());
            mem[1152921523174237248] = this;
            mem[1152921523174237256] = System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.TrackedObjectVisualization.IxSemanticHorizontalPlaneSubvisualizer::UpdateBoundary(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticHorizontalPlane plane);
            mem[1152921523174237232] = System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.TrackedObjectVisualization.IxSemanticHorizontalPlaneSubvisualizer::UpdateBoundary(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticHorizontalPlane plane);
            SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSemanticPlaneDeliverer.remove_PlaneBoundaryUpdatedEvent(value:  new IxHorizontalSemanticPlaneDeliverer.BoundaryUpdate());
            mem[1152921523174241344] = this;
            mem[1152921523174241352] = System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.TrackedObjectVisualization.IxSemanticHorizontalPlaneSubvisualizer::AddTile(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticHorizontalPlane plane, UnityEngine.Vector2 center);
            mem[1152921523174241328] = System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.TrackedObjectVisualization.IxSemanticHorizontalPlaneSubvisualizer::AddTile(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticHorizontalPlane plane, UnityEngine.Vector2 center);
            SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSemanticPlaneDeliverer.remove_PlaneTileAddedEvent(value:  new IxHorizontalSemanticPlaneDeliverer.TileUpdate());
            mem[1152921523174245440] = this;
            mem[1152921523174245448] = System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.TrackedObjectVisualization.IxSemanticHorizontalPlaneSubvisualizer::RemovePlane(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticHorizontalPlane plane);
            mem[1152921523174245424] = System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.TrackedObjectVisualization.IxSemanticHorizontalPlaneSubvisualizer::RemovePlane(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticHorizontalPlane plane);
            SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSemanticPlaneDeliverer.remove_PlaneRemovedEvent(value:  new IxHorizontalSemanticPlaneDeliverer.Remove());
            mem[1152921523174249536] = this;
            mem[1152921523174249544] = System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.TrackedObjectVisualization.IxSemanticHorizontalPlaneSubvisualizer::LabelTile(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticHorizontalPlane plane, UnityEngine.Vector2 key, string label, float confidence);
            mem[1152921523174249520] = System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.TrackedObjectVisualization.IxSemanticHorizontalPlaneSubvisualizer::LabelTile(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticHorizontalPlane plane, UnityEngine.Vector2 key, string label, float confidence);
            SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSemanticPlaneDeliverer.remove_PlaneTileLabeledEvent(value:  new IxHorizontalSemanticPlaneDeliverer.TileLabel());
        }
    
    }

}
