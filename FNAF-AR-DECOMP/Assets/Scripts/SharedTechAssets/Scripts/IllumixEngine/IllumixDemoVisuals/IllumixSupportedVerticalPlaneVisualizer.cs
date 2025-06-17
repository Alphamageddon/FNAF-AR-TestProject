using UnityEngine;

namespace SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class IllumixSupportedVerticalPlaneVisualizer : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.GameObject tilePrefab;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.GameObject supportedPlanePrefab;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<UnityEngine.GameObject>> _planeToTiles;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<int, System.Collections.Generic.Dictionary<UnityEngine.Vector2, UnityEngine.Vector3>> _planeToGridPoints;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<int, UnityEngine.GameObject> _planeToGameObjects;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IxSupportedVerticalPlaneVisualizer_SROptions _srOptions;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool showPoints;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool showPlane;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AddPlane(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalSupportedPlane plane)
        {
            UnityEngine.GameObject val_1 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.supportedPlanePrefab);
            if(this.showPlane != false)
            {
                    val_1.GetComponent<SimpleConvexMesh>().InitializeMesh(orderedConvexVertices:  plane.Boundary.ToArray());
            }
            
            this._planeToGameObjects.set_Item(key:  plane.Key, value:  val_1);
            this._planeToGridPoints.set_Item(key:  plane.Key, value:  new System.Collections.Generic.Dictionary<UnityEngine.Vector2, UnityEngine.Vector3>());
            this._planeToTiles.set_Item(key:  plane.Key, value:  new System.Collections.Generic.List<UnityEngine.GameObject>());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SignificantUpdate(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalSupportedPlane plane)
        {
            this.UpdateBoundary(plane:  plane);
            this.UpdateAllTiles(plane:  plane);
            this.UpdateAllPoints(plane:  plane);
            this.UpdateParticleSystem(plane:  plane);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateBoundary(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalSupportedPlane plane)
        {
            if(this.showPlane == false)
            {
                    return;
            }
            
            this._planeToGameObjects.Item[plane.Key].GetComponent<SimpleConvexMesh>().UpdateMesh(convexVertices:  plane.Boundary.ToArray());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AddNewPoints(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalSupportedPlane plane, System.Collections.Generic.Dictionary<UnityEngine.Vector2, UnityEngine.Vector3> points)
        {
            float val_6;
            if(this.showPoints == false)
            {
                    return;
            }
            
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_4 = points.Keys.GetEnumerator();
            label_9:
            if((1364712480 & 1) == 0)
            {
                goto label_6;
            }
            
            UnityEngine.Vector3 val_7 = points.Item[new UnityEngine.Vector2() {x = val_6, y = V1.16B}];
            this._planeToGridPoints.Item[plane.Key].set_Item(key:  new UnityEngine.Vector2() {x = val_6, y = V1.16B}, value:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
            goto label_9;
            label_6:
            long val_8 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523151428640});
            this.UpdateParticleSystem(plane:  plane);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateAllPoints(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalSupportedPlane plane)
        {
            int val_3;
            if(plane != null)
            {
                    val_3 = plane.Key;
            }
            else
            {
                    val_3 = 0.Key;
            }
            
            this._planeToGridPoints.set_Item(key:  val_3, value:  plane.ProjectedPoints);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateParticleSystem(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalSupportedPlane plane)
        {
            var val_10;
            var val_18;
            var val_19 = this;
            if(this.showPoints == false)
            {
                    return;
            }
            
            val_18 = this._planeToGameObjects.Item[plane.Key].GetComponent<UnityEngine.ParticleSystem>();
            val_18.Clear();
            System.Collections.Generic.Dictionary<UnityEngine.Vector2, UnityEngine.Vector3> val_5 = this._planeToGridPoints.Item[plane.Key];
            int val_6 = val_5.Count;
            Particle[] val_7 = new Particle[0];
            Dictionary.ValueCollection.Enumerator<TKey, TValue> val_9 = val_5.Values.GetEnumerator();
            val_19 = 0;
            goto label_11;
            label_14:
            UnityEngine.Vector3 val_12 = val_10.position;
            UnityEngine.Color32 val_13 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f});
            byte val_14 = val_13.r & 4294967295;
            long val_18 = 0;
            val_18 = val_7 + (val_18 * 124);
            var val_15 = val_18 + 32;
            val_19 = 1;
            label_11:
            if((1365022512 & 1) != 0)
            {
                goto label_14;
            }
            
            if(val_7 != null)
            {
                goto label_15;
            }
            
            goto label_23;
            label_15:
            label_26:
            val_18.SetParticles(particles:  val_7, size:  val_7.Length);
            return;
            label_23:
            if(val_18 != null)
            {
                goto label_26;
            }
            
            goto label_26;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AddTile(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalSupportedPlane plane, UnityEngine.Vector2 key, UnityEngine.Vector3[] tileCoords)
        {
            UnityEngine.GameObject val_3 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.tilePrefab);
            val_3.GetComponent<SimpleConvexMesh>().InitializeMesh(orderedConvexVertices:  tileCoords);
            this._planeToTiles.Item[plane.Key].Add(item:  val_3);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateAllTiles(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalSupportedPlane plane)
        {
            int val_10;
            var val_11;
            val_10 = plane.Key;
            val_11 = this._planeToTiles.Item[val_10];
            Dictionary.ValueCollection.Enumerator<TKey, TValue> val_4 = plane.TileCoords.Values.GetEnumerator();
            goto label_6;
            label_10:
            val_10 = 0.emailUIDataHandler;
            val_11.Item[0].GetComponent<SimpleConvexMesh>().UpdateMesh(convexVertices:  val_10);
            label_6:
            if((1365443160 & 1) != 0)
            {
                goto label_10;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void RemovePlane(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalSupportedPlane plane)
        {
            var val_13;
            UnityEngine.Object val_14;
            UnityEngine.GameObject val_2 = this._planeToGameObjects.Item[plane.Key];
            val_2.SetActive(value:  false);
            UnityEngine.Object.Destroy(obj:  val_2);
            bool val_4 = this._planeToGameObjects.Remove(key:  plane.Key);
            System.Collections.Generic.List<UnityEngine.GameObject> val_6 = this._planeToTiles.Item[plane.Key];
            val_13 = 0;
            goto label_10;
            label_16:
            val_14 = val_6.Count;
            if(val_13 >= val_14)
            {
                goto label_11;
            }
            
            label_17:
            val_6.Item[0].SetActive(value:  false);
            val_14 = val_6.Item[0];
            UnityEngine.Object.Destroy(obj:  val_14);
            val_13 = 1;
            label_10:
            if(val_6 == null)
            {
                goto label_16;
            }
            
            if(val_13 < val_6.Count)
            {
                goto label_17;
            }
            
            label_11:
            val_6.Clear();
            bool val_12 = this._planeToTiles.Remove(key:  plane.Key);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Awake()
        {
            this._srOptions = new SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IxSupportedVerticalPlaneVisualizer_SROptions(viz:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            this._planeToGameObjects = new System.Collections.Generic.Dictionary<System.Int32, UnityEngine.GameObject>();
            this._planeToGridPoints = new System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.Dictionary<UnityEngine.Vector2, UnityEngine.Vector3>>();
            this._planeToTiles = new System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.List<UnityEngine.GameObject>>();
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
            
            SharedTechAssets.Scripts.IllumixEngine.IxVerticalSupportedPlaneDeliverer.add_PlaneAddedEvent(value:  new IxVerticalSupportedPlaneDeliverer.Add(object:  this, method:  System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IllumixSupportedVerticalPlaneVisualizer::AddPlane(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalSupportedPlane plane)));
            SharedTechAssets.Scripts.IllumixEngine.IxVerticalSupportedPlaneDeliverer.add_PlaneBoundaryUpdatedEvent(value:  new IxVerticalSupportedPlaneDeliverer.BoundaryUpdate(object:  this, method:  System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IllumixSupportedVerticalPlaneVisualizer::UpdateBoundary(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalSupportedPlane plane)));
            SharedTechAssets.Scripts.IllumixEngine.IxVerticalSupportedPlaneDeliverer.add_PlanePointsUpdatedEvent(value:  new IxVerticalSupportedPlaneDeliverer.PointsUpdate(object:  this, method:  System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IllumixSupportedVerticalPlaneVisualizer::AddNewPoints(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalSupportedPlane plane, System.Collections.Generic.Dictionary<UnityEngine.Vector2, UnityEngine.Vector3> points)));
            SharedTechAssets.Scripts.IllumixEngine.IxVerticalSupportedPlaneDeliverer.add_PlaneRemovedEvent(value:  new IxVerticalSupportedPlaneDeliverer.Remove(object:  this, method:  System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IllumixSupportedVerticalPlaneVisualizer::RemovePlane(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalSupportedPlane plane)));
            SharedTechAssets.Scripts.IllumixEngine.IxVerticalSupportedPlaneDeliverer.add_PlaneSignificantlyUpdatedEvent(value:  new IxVerticalSupportedPlaneDeliverer.SignificantUpdate(object:  this, method:  System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IllumixSupportedVerticalPlaneVisualizer::SignificantUpdate(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalSupportedPlane plane)));
            SharedTechAssets.Scripts.IllumixEngine.IxVerticalSupportedPlaneDeliverer.add_PlaneTilesUpdatedEvent(value:  new IxVerticalSupportedPlaneDeliverer.TilesUpdate(object:  this, method:  System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IllumixSupportedVerticalPlaneVisualizer::AddTile(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalSupportedPlane plane, UnityEngine.Vector2 key, UnityEngine.Vector3[] tileCoords)));
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
            
            SharedTechAssets.Scripts.IllumixEngine.IxVerticalSupportedPlaneDeliverer.remove_PlaneTilesUpdatedEvent(value:  new IxVerticalSupportedPlaneDeliverer.TilesUpdate(object:  this, method:  System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IllumixSupportedVerticalPlaneVisualizer::AddTile(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalSupportedPlane plane, UnityEngine.Vector2 key, UnityEngine.Vector3[] tileCoords)));
            SharedTechAssets.Scripts.IllumixEngine.IxVerticalSupportedPlaneDeliverer.remove_PlaneAddedEvent(value:  new IxVerticalSupportedPlaneDeliverer.Add(object:  this, method:  System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IllumixSupportedVerticalPlaneVisualizer::AddPlane(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalSupportedPlane plane)));
            SharedTechAssets.Scripts.IllumixEngine.IxVerticalSupportedPlaneDeliverer.remove_PlaneBoundaryUpdatedEvent(value:  new IxVerticalSupportedPlaneDeliverer.BoundaryUpdate(object:  this, method:  System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IllumixSupportedVerticalPlaneVisualizer::UpdateBoundary(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalSupportedPlane plane)));
            SharedTechAssets.Scripts.IllumixEngine.IxVerticalSupportedPlaneDeliverer.remove_PlanePointsUpdatedEvent(value:  new IxVerticalSupportedPlaneDeliverer.PointsUpdate(object:  this, method:  System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IllumixSupportedVerticalPlaneVisualizer::AddNewPoints(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalSupportedPlane plane, System.Collections.Generic.Dictionary<UnityEngine.Vector2, UnityEngine.Vector3> points)));
            SharedTechAssets.Scripts.IllumixEngine.IxVerticalSupportedPlaneDeliverer.remove_PlaneRemovedEvent(value:  new IxVerticalSupportedPlaneDeliverer.Remove(object:  this, method:  System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IllumixSupportedVerticalPlaneVisualizer::RemovePlane(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalSupportedPlane plane)));
            SharedTechAssets.Scripts.IllumixEngine.IxVerticalSupportedPlaneDeliverer.remove_PlaneSignificantlyUpdatedEvent(value:  new IxVerticalSupportedPlaneDeliverer.SignificantUpdate(object:  this, method:  System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IllumixSupportedVerticalPlaneVisualizer::SignificantUpdate(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalSupportedPlane plane)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public IllumixSupportedVerticalPlaneVisualizer()
        {
            this.showPoints = true;
            this.showPlane = true;
        }
    
    }

}
