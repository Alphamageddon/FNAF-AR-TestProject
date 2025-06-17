using UnityEngine;

namespace SharedTechAssets.Scripts.IllumixEngine.IxStatTrackers
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class IxVSupportedPlaneTracker
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int numPlanes;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int numPoints;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int numTiles;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private long lastOutputTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<int, SharedTechAssets.Scripts.IllumixEngine.IxStatTrackers.IxVSupportedPlaneTracker.PlaneData> _data;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SharedTechAssets.Scripts.IllumixEngine.IxStatTrackers.IxVSupportedPlaneTracker_SROptions _srOptions;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public IxVSupportedPlaneTracker()
        {
            this._data = new System.Collections.Generic.Dictionary<System.Int32, PlaneData>();
            ._tracker = this;
            this._srOptions = new SharedTechAssets.Scripts.IllumixEngine.IxStatTrackers.IxVSupportedPlaneTracker_SROptions();
            SRDebugger.Services.IDebugService val_3 = SRDebug.Instance;
            if(val_3 != null)
            {
                    var val_5 = 0;
                val_5 = val_5 + 1;
                val_3.AddOptionContainer(container:  this._srOptions);
            }
            
            mem[1152921523136883408] = this;
            mem[1152921523136883416] = System.Void SharedTechAssets.Scripts.IllumixEngine.IxStatTrackers.IxVSupportedPlaneTracker::PlaneAddedEvent(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalSupportedPlane plane);
            mem[1152921523136883392] = System.Void SharedTechAssets.Scripts.IllumixEngine.IxStatTrackers.IxVSupportedPlaneTracker::PlaneAddedEvent(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalSupportedPlane plane);
            SharedTechAssets.Scripts.IllumixEngine.IxVerticalSupportedPlaneDeliverer.add_PlaneAddedEvent(value:  new IxVerticalSupportedPlaneDeliverer.Add());
            mem[1152921523136887504] = this;
            mem[1152921523136887512] = System.Void SharedTechAssets.Scripts.IllumixEngine.IxStatTrackers.IxVSupportedPlaneTracker::PointsUpdatedEvent(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalSupportedPlane plane, System.Collections.Generic.Dictionary<UnityEngine.Vector2, UnityEngine.Vector3> points);
            mem[1152921523136887488] = System.Void SharedTechAssets.Scripts.IllumixEngine.IxStatTrackers.IxVSupportedPlaneTracker::PointsUpdatedEvent(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalSupportedPlane plane, System.Collections.Generic.Dictionary<UnityEngine.Vector2, UnityEngine.Vector3> points);
            SharedTechAssets.Scripts.IllumixEngine.IxVerticalSupportedPlaneDeliverer.add_PlanePointsUpdatedEvent(value:  new IxVerticalSupportedPlaneDeliverer.PointsUpdate());
            mem[1152921523136891600] = this;
            mem[1152921523136891608] = System.Void SharedTechAssets.Scripts.IllumixEngine.IxStatTrackers.IxVSupportedPlaneTracker::TileUpdate(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalSupportedPlane plane, UnityEngine.Vector2 tilecenter, UnityEngine.Vector3[] vertices);
            mem[1152921523136891584] = System.Void SharedTechAssets.Scripts.IllumixEngine.IxStatTrackers.IxVSupportedPlaneTracker::TileUpdate(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalSupportedPlane plane, UnityEngine.Vector2 tilecenter, UnityEngine.Vector3[] vertices);
            SharedTechAssets.Scripts.IllumixEngine.IxVerticalSupportedPlaneDeliverer.add_PlaneTilesUpdatedEvent(value:  new IxVerticalSupportedPlaneDeliverer.TilesUpdate());
            mem[1152921523136895696] = this;
            mem[1152921523136895704] = System.Void SharedTechAssets.Scripts.IllumixEngine.IxStatTrackers.IxVSupportedPlaneTracker::PlaneRemovedEvent(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalSupportedPlane plane);
            mem[1152921523136895680] = System.Void SharedTechAssets.Scripts.IllumixEngine.IxStatTrackers.IxVSupportedPlaneTracker::PlaneRemovedEvent(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalSupportedPlane plane);
            SharedTechAssets.Scripts.IllumixEngine.IxVerticalSupportedPlaneDeliverer.add_PlaneRemovedEvent(value:  new IxVerticalSupportedPlaneDeliverer.Remove());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void PrintStats()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void PlaneRemovedEvent(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalSupportedPlane plane)
        {
            PlaneData val_2 = this._data.Item[plane.Key];
            int val_4 = this.numPlanes;
            int val_6 = this.numPoints;
            int val_5 = this.numTiles;
            val_4 = val_4 - 1;
            val_5 = val_5 - (val_2.numPoints >> 32);
            val_6 = val_6 - val_2.numPoints;
            this.numPlanes = val_4;
            this.numPoints = val_6;
            this.numTiles = val_5;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void TileUpdate(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalSupportedPlane plane, UnityEngine.Vector2 tilecenter, UnityEngine.Vector3[] vertices)
        {
            int val_4 = this.numTiles;
            val_4 = val_4 + 1;
            this.numTiles = val_4;
            PlaneData val_2 = this._data.Item[plane.Key];
            int val_5 = val_2.numPoints;
            val_5 = val_5 + 4294967296;
            this._data.set_Item(key:  plane.Key, value:  new PlaneData() {numPoints = val_5, numTiles = val_5});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void PointsUpdatedEvent(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalSupportedPlane plane, System.Collections.Generic.Dictionary<UnityEngine.Vector2, UnityEngine.Vector3> points)
        {
            System.Collections.Generic.Dictionary<UnityEngine.Vector2, UnityEngine.Vector3> val_9 = points;
            this.numPoints = val_9.Count + this.numPoints;
            PlaneData val_4 = this._data.Item[plane.Key];
            val_9 = (val_4.numPoints & (-4294967296)) | (val_9.Count + val_4.numPoints);
            this._data.set_Item(key:  plane.Key, value:  new PlaneData() {numPoints = val_9, numTiles = val_9});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void PlaneAddedEvent(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalSupportedPlane plane)
        {
            this._data.set_Item(key:  plane.Key, value:  new PlaneData());
            int val_2 = this.numPlanes;
            val_2 = val_2 + 1;
            this.numPlanes = val_2;
        }
    
    }

}
