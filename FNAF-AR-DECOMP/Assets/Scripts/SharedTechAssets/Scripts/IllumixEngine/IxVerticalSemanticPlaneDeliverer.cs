using UnityEngine;

namespace SharedTechAssets.Scripts.IllumixEngine
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class IxVerticalSemanticPlaneDeliverer : IIxSemanticVerticalPlaneAccepter
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<int, SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticVerticalPlane> _planeStore;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.Add PlaneAddedEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.BoundaryUpdate PlaneBoundaryUpdatedEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.SignificantUpdate PlaneSignificantlyUpdatedEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.PointsUpdate PlanePointsUpdatedEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.TilesUpdate PlaneTilesUpdatedEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.Remove PlaneRemovedEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.TileLabel PlaneTileLabeledEvent;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public IxVerticalSemanticPlaneDeliverer()
        {
            this._planeStore = new System.Collections.Generic.Dictionary<System.Int32, SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticVerticalPlane>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void add_PlaneAddedEvent(SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.Add value)
        {
            System.Delegate val_3 = System.Delegate.Combine(a:  SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.PlaneAddedEvent, b:  value);
            if(val_3 == null)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
            
            val_3 = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void remove_PlaneAddedEvent(SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.Add value)
        {
            System.Delegate val_3 = System.Delegate.Remove(source:  SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.PlaneAddedEvent, value:  value);
            if(val_3 == null)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
            
            val_3 = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void add_PlaneBoundaryUpdatedEvent(SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.BoundaryUpdate value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.PlaneBoundaryUpdatedEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.PlaneBoundaryUpdatedEvent != 1152921505158287368);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void remove_PlaneBoundaryUpdatedEvent(SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.BoundaryUpdate value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.PlaneBoundaryUpdatedEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.PlaneBoundaryUpdatedEvent != 1152921505158287368);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void add_PlaneSignificantlyUpdatedEvent(SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.SignificantUpdate value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.PlaneSignificantlyUpdatedEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.PlaneSignificantlyUpdatedEvent != 1152921505158287376);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void remove_PlaneSignificantlyUpdatedEvent(SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.SignificantUpdate value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.PlaneSignificantlyUpdatedEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.PlaneSignificantlyUpdatedEvent != 1152921505158287376);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void add_PlanePointsUpdatedEvent(SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.PointsUpdate value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.PlanePointsUpdatedEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.PlanePointsUpdatedEvent != 1152921505158287384);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void remove_PlanePointsUpdatedEvent(SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.PointsUpdate value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.PlanePointsUpdatedEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.PlanePointsUpdatedEvent != 1152921505158287384);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void add_PlaneTilesUpdatedEvent(SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.TilesUpdate value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.PlaneTilesUpdatedEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.PlaneTilesUpdatedEvent != 1152921505158287392);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void remove_PlaneTilesUpdatedEvent(SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.TilesUpdate value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.PlaneTilesUpdatedEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.PlaneTilesUpdatedEvent != 1152921505158287392);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void add_PlaneRemovedEvent(SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.Remove value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.PlaneRemovedEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.PlaneRemovedEvent != 1152921505158287400);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void remove_PlaneRemovedEvent(SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.Remove value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.PlaneRemovedEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.PlaneRemovedEvent != 1152921505158287400);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void add_PlaneTileLabeledEvent(SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.TileLabel value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.PlaneTileLabeledEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.PlaneTileLabeledEvent != 1152921505158287408);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void remove_PlaneTileLabeledEvent(SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.TileLabel value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.PlaneTileLabeledEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.PlaneTileLabeledEvent != 1152921505158287408);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnPlaneAddEvent(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticVerticalPlane plane)
        {
            this._planeStore.set_Item(key:  plane.Key, value:  plane);
            if(SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.PlaneAddedEvent == null)
            {
                    return;
            }
            
            SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.PlaneAddedEvent.Invoke(plane:  plane);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnBoundaryUpdateEvent(int key)
        {
            if(SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.PlaneBoundaryUpdatedEvent == null)
            {
                    return;
            }
            
            SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.PlaneBoundaryUpdatedEvent.Invoke(plane:  this._planeStore.Item[key]);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnSignificantUpdateEvent(int key)
        {
            if(SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.PlaneSignificantlyUpdatedEvent == null)
            {
                    return;
            }
            
            SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.PlaneSignificantlyUpdatedEvent.Invoke(plane:  this._planeStore.Item[key]);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnPointsUpdateEvent(int key, System.Collections.Generic.Dictionary<UnityEngine.Vector2, UnityEngine.Vector3> points)
        {
            if(SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.PlanePointsUpdatedEvent == null)
            {
                    return;
            }
            
            SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.PlanePointsUpdatedEvent.Invoke(plane:  this._planeStore.Item[key], points:  points);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnTileUpdateEvent(int key, UnityEngine.Vector2 planeSpaceCenter, UnityEngine.Vector3[] tileCoords)
        {
            if(SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.PlaneTilesUpdatedEvent == null)
            {
                    return;
            }
            
            SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.PlaneTilesUpdatedEvent.Invoke(plane:  this._planeStore.Item[key], key:  new UnityEngine.Vector2() {x = planeSpaceCenter.x, y = planeSpaceCenter.y}, tileCoords:  tileCoords);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnRemoveEvent(int key)
        {
            if(SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.PlaneRemovedEvent != null)
            {
                    SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.PlaneRemovedEvent.Invoke(plane:  this._planeStore.Item[key]);
            }
            
            bool val_2 = this._planeStore.Remove(key:  key);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnTileLabelEvent(int key, UnityEngine.Vector2 tileKey, string label, float confidence)
        {
            if(SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.PlaneTileLabeledEvent == null)
            {
                    return;
            }
            
            SharedTechAssets.Scripts.IllumixEngine.IxVerticalSemanticPlaneDeliverer.PlaneTileLabeledEvent.Invoke(plane:  this._planeStore.Item[key], key:  new UnityEngine.Vector2() {x = tileKey.x, y = tileKey.y}, label:  label, confidence:  confidence);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticVerticalPlane GetPlane(int key)
        {
            if(this._planeStore != null)
            {
                    return this._planeStore.Item[key];
            }
            
            return this._planeStore.Item[key];
        }
    
    }

}
