using UnityEngine;

namespace SharedTechAssets.Scripts.IllumixEngine.IxStatTrackers
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class IxHSupportedPlaneTracker
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
        private System.Collections.Generic.Dictionary<int, SharedTechAssets.Scripts.IllumixEngine.IxStatTrackers.IxHSupportedPlaneTracker.PlaneData> _data;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SharedTechAssets.Scripts.IllumixEngine.IxStatTrackers.IxHSupportedPlaneTracker_SROptions _srOptions;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public IxHSupportedPlaneTracker()
        {
            this._data = new System.Collections.Generic.Dictionary<System.Int32, PlaneData>();
            ._tracker = this;
            this._srOptions = new SharedTechAssets.Scripts.IllumixEngine.IxStatTrackers.IxHSupportedPlaneTracker_SROptions();
            SRDebugger.Services.IDebugService val_3 = SRDebug.Instance;
            if(val_3 != null)
            {
                    var val_9 = 0;
                val_9 = val_9 + 1;
                val_3.AddOptionContainer(container:  this._srOptions);
            }
            
            SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSupportedPlaneDeliverer.add_PlaneAddedEvent(value:  new IxHorizontalSupportedPlaneDeliverer.Add(object:  this, method:  System.Void SharedTechAssets.Scripts.IllumixEngine.IxStatTrackers.IxHSupportedPlaneTracker::PlaneAddedEvent(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixHorizontalSupportedPlane plane)));
            SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSupportedPlaneDeliverer.add_PlanePointsUpdatedEvent(value:  new IxHorizontalSupportedPlaneDeliverer.PointsUpdate(object:  this, method:  System.Void SharedTechAssets.Scripts.IllumixEngine.IxStatTrackers.IxHSupportedPlaneTracker::PointsUpdatedEvent(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixHorizontalSupportedPlane plane, System.Collections.Generic.List<UnityEngine.Vector2> points)));
            SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSupportedPlaneDeliverer.add_PlaneTileAddedEvent(value:  new IxHorizontalSupportedPlaneDeliverer.TileUpdate(object:  this, method:  System.Void SharedTechAssets.Scripts.IllumixEngine.IxStatTrackers.IxHSupportedPlaneTracker::TileUpdate(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixHorizontalSupportedPlane plane, UnityEngine.Vector2 tilecenter)));
            SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSupportedPlaneDeliverer.add_PlaneRemovedEvent(value:  new IxHorizontalSupportedPlaneDeliverer.Remove(object:  this, method:  System.Void SharedTechAssets.Scripts.IllumixEngine.IxStatTrackers.IxHSupportedPlaneTracker::PlaneRemovedEvent(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixHorizontalSupportedPlane plane)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void PrintStats()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void PlaneRemovedEvent(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixHorizontalSupportedPlane plane)
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
        private void TileUpdate(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixHorizontalSupportedPlane plane, UnityEngine.Vector2 tilecenter)
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
        private void PointsUpdatedEvent(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixHorizontalSupportedPlane plane, System.Collections.Generic.List<UnityEngine.Vector2> points)
        {
            System.Collections.Generic.List<UnityEngine.Vector2> val_9 = points;
            this.numPoints = val_9.Count + this.numPoints;
            PlaneData val_4 = this._data.Item[plane.Key];
            val_9 = (val_4.numPoints & (-4294967296)) | (val_9.Count + val_4.numPoints);
            this._data.set_Item(key:  plane.Key, value:  new PlaneData() {numPoints = val_9, numTiles = val_9});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void PlaneAddedEvent(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixHorizontalSupportedPlane plane)
        {
            this._data.set_Item(key:  plane.Key, value:  new PlaneData());
            int val_2 = this.numPlanes;
            val_2 = val_2 + 1;
            this.numPlanes = val_2;
        }
    
    }

}
