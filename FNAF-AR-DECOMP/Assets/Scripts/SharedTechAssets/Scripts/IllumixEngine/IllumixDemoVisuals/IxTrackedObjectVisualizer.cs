using UnityEngine;

namespace SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class IxTrackedObjectVisualizer : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Camera _camera;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.TrackedObjectVisualization.IxSemanticVerticalPlaneSubvisualizer _verticalPlaneSubvisualizer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.TrackedObjectVisualization.IxSemanticHorizontalPlaneSubvisualizer _horizontalPlaneSubvisualizer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.TrackedObjectVisualization.IxSemanticVoxelSubvisualizer _voxelSubvisualizer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.GameObject tilePrefab;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.GameObject supportedPlanePrefab;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.GameObject cubePrefab;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Collections.Generic.List<UnityEngine.Color> colors;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int currIdx;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<int, int> objToColorIdx;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void TrackedObjectRemovedEvent(int objId)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void TrackedObjectUpdatedEvent(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxTrackedObject obj, SharedTechAssets.Scripts.ObjectPinner.ObjectTracking.ObjectGeometryUpdate update)
        {
            float val_4;
            float val_5;
            var val_25;
            UnityEngine.Color val_2 = this.colors.Item[this.objToColorIdx.Item[obj.id]];
            List.Enumerator<T> val_3 = update.horizontalTileUpdateInfo.GetEnumerator();
            label_10:
            if((1383229824 & 1) == 0)
            {
                goto label_4;
            }
            
            UnityEngine.XR.ARSubsystems.TrackableId val_6 = val_4.trackableId;
            if((val_6.m_SubId2 & 1095216660480) == 0)
            {
                goto label_10;
            }
            
            ulong val_9 = val_6.m_SubId1 >> 32;
            UnityEngine.GameObject val_10 = this._horizontalPlaneSubvisualizer.planeToTileTextObjects.Item[val_6.m_SubId1].Item[new UnityEngine.Vector2() {x = val_9, y = val_6.m_SubId2}];
            this._horizontalPlaneSubvisualizer.UpdateTextMesh(planeId:  val_6.m_SubId1, tileKey:  new UnityEngine.Vector2() {x = val_9, y = val_6.m_SubId2}, label:  obj.label, color:  new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a});
            goto label_10;
            label_4:
            long val_11 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523169945984});
            List.Enumerator<T> val_13 = update.verticalTileUpdateInfo.GetEnumerator();
            label_25:
            if((1383229824 & 1) == 0)
            {
                goto label_19;
            }
            
            UnityEngine.XR.ARSubsystems.TrackableId val_14 = val_4.trackableId;
            if((val_14.m_SubId2 & 1095216660480) == 0)
            {
                goto label_25;
            }
            
            ulong val_17 = val_14.m_SubId1 >> 32;
            UnityEngine.GameObject val_18 = this._verticalPlaneSubvisualizer._planeToTileTextObjects.Item[val_14.m_SubId1].Item[new UnityEngine.Vector2() {x = val_17, y = val_14.m_SubId2}];
            this._verticalPlaneSubvisualizer.UpdateTextMesh(planeId:  val_14.m_SubId1, tileKey:  new UnityEngine.Vector2() {x = val_17, y = val_14.m_SubId2}, label:  obj.label, color:  new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a});
            goto label_25;
            label_19:
            val_25 = 0;
            long val_19 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523169945984});
            if(((267 == 0) ? 267 : 267) == 267)
            {
                
            }
            else
            {
                    if( != 0)
            {
                    val_25 = 0;
            }
            
            }
            
            List.Enumerator<T> val_21 = update.voxelUpdateInfo.GetEnumerator();
            do
            {
                label_39:
                if((1383229792 & 1) == 0)
            {
                goto label_40;
            }
            
                UnityEngine.XR.ARSubsystems.TrackableId val_22 = val_4.trackableId;
            }
            while((val_22.m_SubId2 & 1095216660480) == 0);
            
            this._voxelSubvisualizer.UpdateTextMesh(worldCoord:  new UnityEngine.Vector3() {x = val_5, y = val_4, z = val_2.b}, label:  obj.label, color:  new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a});
            goto label_39;
            label_40:
            long val_24 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523169945952});
            if( == 0)
            {
                    return;
            }
            
            if(361 == 0)
            {
                    return;
            }
            
            if(361 == 361)
            {
                    return;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void TrackedObjectAddedEvent(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxTrackedObject obj)
        {
            float val_6;
            float val_7;
            var val_19;
            var val_20;
            UnityEngine.Color val_1 = this.colors.Item[this.currIdx];
            this.objToColorIdx.set_Item(key:  obj.id, value:  this.currIdx);
            int val_2 = this.colors.Count;
            int val_3 = this.currIdx + 1;
            val_3 = val_3 - ((val_3 / val_2) * val_2);
            this.currIdx = val_3;
            HashSet.Enumerator<T> val_5 = obj.horizontalTiles.GetEnumerator();
            label_10:
            if((1383528192 & 1) == 0)
            {
                goto label_5;
            }
            
            UnityEngine.GameObject val_9 = this._horizontalPlaneSubvisualizer.planeToTileTextObjects.Item[1383465184].Item[new UnityEngine.Vector2() {x = 2.651765E+11f, y = 2.524356E-29f}];
            this._horizontalPlaneSubvisualizer.UpdateTextMesh(planeId:  1383465184, tileKey:  new UnityEngine.Vector2() {x = 2.651765E+11f, y = 2.524356E-29f}, label:  obj.label, color:  new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a});
            goto label_10;
            label_5:
            val_19 = 1152921523170179296;
            long val_10 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523170244352});
            HashSet.Enumerator<T> val_12 = obj.verticalTiles.GetEnumerator();
            label_24:
            if((1383528192 & 1) == 0)
            {
                goto label_19;
            }
            
            UnityEngine.GameObject val_14 = this._verticalPlaneSubvisualizer._planeToTileTextObjects.Item[1383465184].Item[new UnityEngine.Vector2() {x = 2.651765E+11f, y = 2.524356E-29f}];
            this._verticalPlaneSubvisualizer.UpdateTextMesh(planeId:  1383465184, tileKey:  new UnityEngine.Vector2() {x = 2.651765E+11f, y = 2.524356E-29f}, label:  obj.label, color:  new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a});
            goto label_24;
            label_19:
            val_20 = 0;
            long val_15 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523170244352});
            if(((289 == 0) ? 289 : 289) == 289)
            {
                
            }
            else
            {
                    if( != 0)
            {
                    val_20 = 0;
            }
            
            }
            
            HashSet.Enumerator<T> val_17 = obj.voxels.GetEnumerator();
            label_37:
            if((1383528160 & 1) == 0)
            {
                goto label_38;
            }
            
            this._voxelSubvisualizer.UpdateTextMesh(worldCoord:  new UnityEngine.Vector3() {x = val_7, y = val_6, z = val_1.b}, label:  obj.label, color:  new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a});
            goto label_37;
            label_38:
            long val_18 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523170244320});
            if( == 0)
            {
                    return;
            }
            
            if(369 == 0)
            {
                    return;
            }
            
            if(369 == 369)
            {
                    return;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Awake()
        {
            this.objToColorIdx = new System.Collections.Generic.Dictionary<System.Int32, System.Int32>();
            UnityEngine.Camera val_4 = this.GetComponentInParent<UnityEngine.XR.ARFoundation.ARSessionOrigin>().gameObject.GetComponentInChildren<UnityEngine.Camera>();
            this._camera = val_4;
            this._horizontalPlaneSubvisualizer = new SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.TrackedObjectVisualization.IxSemanticHorizontalPlaneSubvisualizer(camera:  val_4, tilePrefab:  this.tilePrefab, planePrefab:  this.supportedPlanePrefab);
            this._verticalPlaneSubvisualizer = new SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.TrackedObjectVisualization.IxSemanticVerticalPlaneSubvisualizer(camera:  this._camera, tilePrefab:  this.tilePrefab, planePrefab:  this.supportedPlanePrefab);
            this._voxelSubvisualizer = new SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.TrackedObjectVisualization.IxSemanticVoxelSubvisualizer(camera:  this._camera, cubePrefab:  this.cubePrefab);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnEnable()
        {
            this._horizontalPlaneSubvisualizer.OnEnable();
            this._verticalPlaneSubvisualizer.OnEnable();
            this._voxelSubvisualizer.OnEnable();
            SharedTechAssets.Scripts.IllumixEngine.IxTrackedObjectDeliverer.add_AddedEvent(value:  new IxTrackedObjectDeliverer.Add(object:  this, method:  System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IxTrackedObjectVisualizer::TrackedObjectAddedEvent(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxTrackedObject obj)));
            SharedTechAssets.Scripts.IllumixEngine.IxTrackedObjectDeliverer.add_UpdatedEvent(value:  new IxTrackedObjectDeliverer.Update(object:  this, method:  System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IxTrackedObjectVisualizer::TrackedObjectUpdatedEvent(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxTrackedObject obj, SharedTechAssets.Scripts.ObjectPinner.ObjectTracking.ObjectGeometryUpdate update)));
            SharedTechAssets.Scripts.IllumixEngine.IxTrackedObjectDeliverer.add_RemovedEvent(value:  new IxTrackedObjectDeliverer.Remove(object:  this, method:  System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IxTrackedObjectVisualizer::TrackedObjectRemovedEvent(int objId)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDisable()
        {
            this._horizontalPlaneSubvisualizer.OnDisable();
            this._verticalPlaneSubvisualizer.OnDisable();
            this._voxelSubvisualizer.OnDisable();
            SharedTechAssets.Scripts.IllumixEngine.IxTrackedObjectDeliverer.remove_AddedEvent(value:  new IxTrackedObjectDeliverer.Add(object:  this, method:  System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IxTrackedObjectVisualizer::TrackedObjectAddedEvent(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxTrackedObject obj)));
            SharedTechAssets.Scripts.IllumixEngine.IxTrackedObjectDeliverer.remove_UpdatedEvent(value:  new IxTrackedObjectDeliverer.Update(object:  this, method:  System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IxTrackedObjectVisualizer::TrackedObjectUpdatedEvent(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxTrackedObject obj, SharedTechAssets.Scripts.ObjectPinner.ObjectTracking.ObjectGeometryUpdate update)));
            SharedTechAssets.Scripts.IllumixEngine.IxTrackedObjectDeliverer.remove_RemovedEvent(value:  new IxTrackedObjectDeliverer.Remove(object:  this, method:  System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IxTrackedObjectVisualizer::TrackedObjectRemovedEvent(int objId)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public IxTrackedObjectVisualizer()
        {
            System.Collections.Generic.List<UnityEngine.Color> val_1 = new System.Collections.Generic.List<UnityEngine.Color>();
            UnityEngine.Color val_2 = UnityEngine.Color.red;
            val_1.Add(item:  new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a});
            UnityEngine.Color val_3 = UnityEngine.Color.blue;
            val_1.Add(item:  new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = val_3.a});
            UnityEngine.Color val_4 = UnityEngine.Color.cyan;
            val_1.Add(item:  new UnityEngine.Color() {r = val_4.r, g = val_4.g, b = val_4.b, a = val_4.a});
            UnityEngine.Color val_5 = UnityEngine.Color.green;
            val_1.Add(item:  new UnityEngine.Color() {r = val_5.r, g = val_5.g, b = val_5.b, a = val_5.a});
            UnityEngine.Color val_6 = UnityEngine.Color.gray;
            val_1.Add(item:  new UnityEngine.Color() {r = val_6.r, g = val_6.g, b = val_6.b, a = val_6.a});
            UnityEngine.Color val_7 = UnityEngine.Color.yellow;
            val_1.Add(item:  new UnityEngine.Color() {r = val_7.r, g = val_7.g, b = val_7.b, a = val_7.a});
            UnityEngine.Color val_8 = UnityEngine.Color.black;
            val_1.Add(item:  new UnityEngine.Color() {r = val_8.r, g = val_8.g, b = val_8.b, a = val_8.a});
            UnityEngine.Color val_9 = UnityEngine.Color.magenta;
            val_1.Add(item:  new UnityEngine.Color() {r = val_9.r, g = val_9.g, b = val_9.b, a = val_9.a});
            this.colors = val_1;
        }
    
    }

}
