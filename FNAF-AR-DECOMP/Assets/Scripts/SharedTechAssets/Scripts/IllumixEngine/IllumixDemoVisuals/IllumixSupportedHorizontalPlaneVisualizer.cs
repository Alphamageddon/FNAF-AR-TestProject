using UnityEngine;

namespace SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class IllumixSupportedHorizontalPlaneVisualizer : MonoBehaviour
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
        private SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IxSupportedHorizontalPlaneVisualizer_SROptions _srOptions;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool showPoints;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool showPlane;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly UnityEngine.Vector3[] verticesBuffer;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AddPlane(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixHorizontalSupportedPlane plane)
        {
            UnityEngine.GameObject val_1 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.supportedPlanePrefab);
            if(this.showPlane != false)
            {
                    val_1.GetComponent<SimpleConvexMesh>().InitializeMesh(orderedConvexVertices:  plane.Boundary.ToArray());
            }
            
            this.planeToGameObjects.set_Item(key:  plane.Key, value:  val_1);
            this.planeToGridPoints.set_Item(key:  plane.Key, value:  new System.Collections.Generic.List<UnityEngine.Vector3>());
            this.planeToTileObjects.set_Item(key:  plane.Key, value:  new System.Collections.Generic.Dictionary<UnityEngine.Vector2, UnityEngine.GameObject>());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SignificantUpdate(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixHorizontalSupportedPlane plane)
        {
            if(this.showPlane != false)
            {
                    this.UpdateBoundary(plane:  plane);
            }
            
            if(this.showPoints != false)
            {
                    this.UpdateAllPoints(plane:  plane);
            }
            
            this.UpdateAllTiles(plane:  plane);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateBoundary(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixHorizontalSupportedPlane plane)
        {
            if(this.showPlane == false)
            {
                    return;
            }
            
            this.planeToGameObjects.Item[plane.Key].GetComponent<SimpleConvexMesh>().UpdateMesh(convexVertices:  plane.Boundary.ToArray());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AddNewPoints(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixHorizontalSupportedPlane plane, System.Collections.Generic.List<UnityEngine.Vector2> newPoints)
        {
            var val_6;
            if(this.showPoints == false)
            {
                    return;
            }
            
            val_6 = 0;
            goto label_4;
            label_9:
            UnityEngine.Vector2 val_3 = newPoints.Item[0];
            float val_4 = plane.Height;
            this.planeToGridPoints.Item[plane.Key].Add(item:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            val_6 = 1;
            label_4:
            if(val_6 < newPoints.Count)
            {
                goto label_9;
            }
            
            this.UpdateParticleSystem(plane:  plane);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateAllPoints(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixHorizontalSupportedPlane plane)
        {
            var val_6;
            if(this.showPoints == false)
            {
                    return;
            }
            
            System.Collections.Generic.List<UnityEngine.Vector3> val_2 = this.planeToGridPoints.Item[plane.Key];
            val_6 = 0;
            goto label_4;
            label_9:
            UnityEngine.Vector3 val_3 = val_2.Item[0];
            val_2.set_Item(index:  0, value:  new UnityEngine.Vector3() {x = val_3.x, y = plane.Height, z = val_3.z});
            val_6 = 1;
            label_4:
            if(val_6 < val_2.Count)
            {
                goto label_9;
            }
            
            this.UpdateParticleSystem(plane:  plane);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateParticleSystem(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixHorizontalSupportedPlane plane)
        {
            var val_12;
            Particle[] val_13;
            var val_14;
            val_13 = this;
            if(this.showPoints == false)
            {
                    return;
            }
            
            val_12 = this.planeToGameObjects.Item[plane.Key].GetComponent<UnityEngine.ParticleSystem>();
            val_12.Clear();
            System.Collections.Generic.List<UnityEngine.Vector3> val_5 = this.planeToGridPoints.Item[plane.Key];
            int val_6 = val_5.Count;
            Particle[] val_7 = new Particle[0];
            val_13 = val_7;
            val_14 = 0;
            goto label_9;
            label_14:
            UnityEngine.Vector3 val_8 = val_5.Item[0];
            UnityEngine.Color32 val_9 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f});
            byte val_10 = val_9.r & 4294967295;
            var val_11 = 1152921523148703264 + 32;
            val_14 = 1;
            label_9:
            if(val_14 < val_5.Count)
            {
                goto label_14;
            }
            
            if(val_13 == null)
            {
                goto label_15;
            }
            
            label_18:
            val_12.SetParticles(particles:  val_7, size:  val_7.Length);
            return;
            label_15:
            if(val_12 != null)
            {
                goto label_18;
            }
            
            goto label_18;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AddTile(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixHorizontalSupportedPlane plane, UnityEngine.Vector2 center)
        {
            float val_14 = plane.TileLength;
            float val_1 = plane.Height;
            float val_2 = val_14 * 0.5f;
            float val_3 = center.x - val_2;
            val_14 = center.y - val_2;
            float val_4 = plane.Height;
            float val_5 = center.y + val_2;
            float val_6 = plane.Height;
            float val_7 = center.x + val_2;
            float val_8 = plane.Height;
            System.Collections.Generic.Dictionary<UnityEngine.Vector2, UnityEngine.GameObject> val_10 = this.planeToTileObjects.Item[plane.Key];
            UnityEngine.GameObject val_11 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.tilePrefab);
            if(val_10 != null)
            {
                    val_10.set_Item(key:  new UnityEngine.Vector2() {x = center.x, y = center.y}, value:  val_11);
            }
            else
            {
                    0.set_Item(key:  new UnityEngine.Vector2() {x = center.x, y = center.y}, value:  val_11);
            }
            
            val_10.Item[new UnityEngine.Vector2() {x = center.x, y = center.y}].GetComponent<SimpleConvexMesh>().InitializeMesh(orderedConvexVertices:  this.verticesBuffer);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateAllTiles(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixHorizontalSupportedPlane plane)
        {
            float val_5;
            HashSet.Enumerator<T> val_3 = plane.Tiles.GetEnumerator();
            label_20:
            if((1362813056 & 1) == 0)
            {
                    return;
            }
            
            float val_18 = plane.TileLength;
            float val_6 = plane.Height;
            float val_7 = val_18 * 0.5f;
            float val_8 = val_5 - val_7;
            val_18 = V1.16B - val_7;
            float val_9 = plane.Height;
            float val_10 = V1.16B + val_7;
            float val_11 = plane.Height;
            float val_12 = val_5 + val_7;
            float val_13 = plane.Height;
            this.planeToTileObjects.Item[plane.Key].Item[new UnityEngine.Vector2() {x = val_5, y = V1.16B}].GetComponent<SimpleConvexMesh>().UpdateMesh(convexVertices:  this.verticesBuffer);
            goto label_20;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void RemovePlane(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixHorizontalSupportedPlane plane)
        {
            float val_9;
            var val_15;
            UnityEngine.GameObject val_2 = this.planeToGameObjects.Item[plane.Key];
            val_2.SetActive(value:  false);
            UnityEngine.Object.Destroy(obj:  val_2);
            bool val_4 = this.planeToGameObjects.Remove(key:  plane.Key);
            val_15 = this.planeToTileObjects.Item[plane.Key];
            HashSet.Enumerator<T> val_7 = plane.Tiles.GetEnumerator();
            label_17:
            if((1363180096 & 1) == 0)
            {
                goto label_12;
            }
            
            UnityEngine.GameObject val_10 = val_15.Item[new UnityEngine.Vector2() {x = val_9, y = V1.16B}];
            val_10.SetActive(value:  false);
            UnityEngine.Object.Destroy(obj:  val_10);
            goto label_17;
            label_12:
            long val_11 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523149896256});
            bool val_14 = this.planeToTileObjects.Remove(key:  plane.Key);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Awake()
        {
            this._srOptions = new SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IxSupportedHorizontalPlaneVisualizer_SROptions(viz:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            this.planeToGameObjects = new System.Collections.Generic.Dictionary<System.Int32, UnityEngine.GameObject>();
            this.planeToGridPoints = new System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.List<UnityEngine.Vector3>>();
            this.planeToTileObjects = new System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.Dictionary<UnityEngine.Vector2, UnityEngine.GameObject>>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnEnable()
        {
            SRDebugger.Services.IDebugService val_1 = SRDebug.Instance;
            if(val_1 != null)
            {
                    var val_9 = 0;
                val_9 = val_9 + 1;
                val_1.AddOptionContainer(container:  this._srOptions);
            }
            
            SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSupportedPlaneDeliverer.add_PlaneAddedEvent(value:  new IxHorizontalSupportedPlaneDeliverer.Add(object:  this, method:  System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IllumixSupportedHorizontalPlaneVisualizer::AddPlane(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixHorizontalSupportedPlane plane)));
            SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSupportedPlaneDeliverer.add_PlaneBoundaryUpdatedEvent(value:  new IxHorizontalSupportedPlaneDeliverer.BoundaryUpdate(object:  this, method:  System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IllumixSupportedHorizontalPlaneVisualizer::UpdateBoundary(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixHorizontalSupportedPlane plane)));
            SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSupportedPlaneDeliverer.add_PlaneSignificantlyUpdatedEvent(value:  new IxHorizontalSupportedPlaneDeliverer.SignificantUpdate(object:  this, method:  System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IllumixSupportedHorizontalPlaneVisualizer::SignificantUpdate(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixHorizontalSupportedPlane plane)));
            SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSupportedPlaneDeliverer.add_PlanePointsUpdatedEvent(value:  new IxHorizontalSupportedPlaneDeliverer.PointsUpdate(object:  this, method:  System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IllumixSupportedHorizontalPlaneVisualizer::AddNewPoints(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixHorizontalSupportedPlane plane, System.Collections.Generic.List<UnityEngine.Vector2> newPoints)));
            SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSupportedPlaneDeliverer.add_PlaneTileAddedEvent(value:  new IxHorizontalSupportedPlaneDeliverer.TileUpdate(object:  this, method:  System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IllumixSupportedHorizontalPlaneVisualizer::AddTile(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixHorizontalSupportedPlane plane, UnityEngine.Vector2 center)));
            SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSupportedPlaneDeliverer.add_PlaneRemovedEvent(value:  new IxHorizontalSupportedPlaneDeliverer.Remove(object:  this, method:  System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IllumixSupportedHorizontalPlaneVisualizer::RemovePlane(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixHorizontalSupportedPlane plane)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDisable()
        {
            SRDebugger.Services.IDebugService val_1 = SRDebug.Instance;
            if(val_1 != null)
            {
                    var val_9 = 0;
                val_9 = val_9 + 1;
                val_1.RemoveOptionContainer(container:  this._srOptions);
            }
            
            SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSupportedPlaneDeliverer.remove_PlaneAddedEvent(value:  new IxHorizontalSupportedPlaneDeliverer.Add(object:  this, method:  System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IllumixSupportedHorizontalPlaneVisualizer::AddPlane(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixHorizontalSupportedPlane plane)));
            SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSupportedPlaneDeliverer.remove_PlanePointsUpdatedEvent(value:  new IxHorizontalSupportedPlaneDeliverer.PointsUpdate(object:  this, method:  System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IllumixSupportedHorizontalPlaneVisualizer::AddNewPoints(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixHorizontalSupportedPlane plane, System.Collections.Generic.List<UnityEngine.Vector2> newPoints)));
            SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSupportedPlaneDeliverer.remove_PlaneSignificantlyUpdatedEvent(value:  new IxHorizontalSupportedPlaneDeliverer.SignificantUpdate(object:  this, method:  System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IllumixSupportedHorizontalPlaneVisualizer::SignificantUpdate(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixHorizontalSupportedPlane plane)));
            SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSupportedPlaneDeliverer.remove_PlaneBoundaryUpdatedEvent(value:  new IxHorizontalSupportedPlaneDeliverer.BoundaryUpdate(object:  this, method:  System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IllumixSupportedHorizontalPlaneVisualizer::UpdateBoundary(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixHorizontalSupportedPlane plane)));
            SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSupportedPlaneDeliverer.remove_PlaneTileAddedEvent(value:  new IxHorizontalSupportedPlaneDeliverer.TileUpdate(object:  this, method:  System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IllumixSupportedHorizontalPlaneVisualizer::AddTile(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixHorizontalSupportedPlane plane, UnityEngine.Vector2 center)));
            SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSupportedPlaneDeliverer.remove_PlaneRemovedEvent(value:  new IxHorizontalSupportedPlaneDeliverer.Remove(object:  this, method:  System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IllumixSupportedHorizontalPlaneVisualizer::RemovePlane(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixHorizontalSupportedPlane plane)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public IllumixSupportedHorizontalPlaneVisualizer()
        {
            this.showPlane = true;
            this.verticesBuffer = new UnityEngine.Vector3[4];
        }
    
    }

}
