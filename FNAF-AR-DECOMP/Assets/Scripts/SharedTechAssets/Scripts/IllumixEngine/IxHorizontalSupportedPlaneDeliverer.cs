using UnityEngine;

namespace SharedTechAssets.Scripts.IllumixEngine
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class IxHorizontalSupportedPlaneDeliverer : IIxHorizontalSupportedPlaneAccepter
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<int, SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixHorizontalSupportedPlane> _planeStore;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSupportedPlaneDeliverer.Add PlaneAddedEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSupportedPlaneDeliverer.BoundaryUpdate PlaneBoundaryUpdatedEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSupportedPlaneDeliverer.SignificantUpdate PlaneSignificantlyUpdatedEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSupportedPlaneDeliverer.PointsUpdate PlanePointsUpdatedEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSupportedPlaneDeliverer.TileUpdate PlaneTileAddedEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSupportedPlaneDeliverer.Remove PlaneRemovedEvent;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public IxHorizontalSupportedPlaneDeliverer()
        {
            this._planeStore = new System.Collections.Generic.Dictionary<System.Int32, SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixHorizontalSupportedPlane>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void add_PlaneAddedEvent(SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSupportedPlaneDeliverer.Add value)
        {
            System.Delegate val_3 = System.Delegate.Combine(a:  SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSupportedPlaneDeliverer.PlaneAddedEvent, b:  value);
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
        public static void remove_PlaneAddedEvent(SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSupportedPlaneDeliverer.Add value)
        {
            System.Delegate val_3 = System.Delegate.Remove(source:  SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSupportedPlaneDeliverer.PlaneAddedEvent, value:  value);
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
        public static void add_PlaneBoundaryUpdatedEvent(SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSupportedPlaneDeliverer.BoundaryUpdate value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSupportedPlaneDeliverer.PlaneBoundaryUpdatedEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSupportedPlaneDeliverer.PlaneBoundaryUpdatedEvent != 1152921505157009416);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void remove_PlaneBoundaryUpdatedEvent(SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSupportedPlaneDeliverer.BoundaryUpdate value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSupportedPlaneDeliverer.PlaneBoundaryUpdatedEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSupportedPlaneDeliverer.PlaneBoundaryUpdatedEvent != 1152921505157009416);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void add_PlaneSignificantlyUpdatedEvent(SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSupportedPlaneDeliverer.SignificantUpdate value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSupportedPlaneDeliverer.PlaneSignificantlyUpdatedEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSupportedPlaneDeliverer.PlaneSignificantlyUpdatedEvent != 1152921505157009424);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void remove_PlaneSignificantlyUpdatedEvent(SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSupportedPlaneDeliverer.SignificantUpdate value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSupportedPlaneDeliverer.PlaneSignificantlyUpdatedEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSupportedPlaneDeliverer.PlaneSignificantlyUpdatedEvent != 1152921505157009424);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void add_PlanePointsUpdatedEvent(SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSupportedPlaneDeliverer.PointsUpdate value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSupportedPlaneDeliverer.PlanePointsUpdatedEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSupportedPlaneDeliverer.PlanePointsUpdatedEvent != 1152921505157009432);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void remove_PlanePointsUpdatedEvent(SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSupportedPlaneDeliverer.PointsUpdate value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSupportedPlaneDeliverer.PlanePointsUpdatedEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSupportedPlaneDeliverer.PlanePointsUpdatedEvent != 1152921505157009432);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void add_PlaneTileAddedEvent(SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSupportedPlaneDeliverer.TileUpdate value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSupportedPlaneDeliverer.PlaneTileAddedEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSupportedPlaneDeliverer.PlaneTileAddedEvent != 1152921505157009440);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void remove_PlaneTileAddedEvent(SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSupportedPlaneDeliverer.TileUpdate value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSupportedPlaneDeliverer.PlaneTileAddedEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSupportedPlaneDeliverer.PlaneTileAddedEvent != 1152921505157009440);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void add_PlaneRemovedEvent(SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSupportedPlaneDeliverer.Remove value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSupportedPlaneDeliverer.PlaneRemovedEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSupportedPlaneDeliverer.PlaneRemovedEvent != 1152921505157009448);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void remove_PlaneRemovedEvent(SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSupportedPlaneDeliverer.Remove value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSupportedPlaneDeliverer.PlaneRemovedEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSupportedPlaneDeliverer.PlaneRemovedEvent != 1152921505157009448);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnPlaneAddEvent(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixHorizontalSupportedPlane plane)
        {
            this._planeStore.set_Item(key:  plane.Key, value:  plane);
            if(SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSupportedPlaneDeliverer.PlaneAddedEvent == null)
            {
                    return;
            }
            
            SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSupportedPlaneDeliverer.PlaneAddedEvent.Invoke(plane:  plane);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnBoundaryUpdateEvent(int key)
        {
            if(SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSupportedPlaneDeliverer.PlaneBoundaryUpdatedEvent == null)
            {
                    return;
            }
            
            SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSupportedPlaneDeliverer.PlaneBoundaryUpdatedEvent.Invoke(plane:  this._planeStore.Item[key]);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnSignificantUpdateEvent(int key)
        {
            if(SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSupportedPlaneDeliverer.PlaneSignificantlyUpdatedEvent == null)
            {
                    return;
            }
            
            SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSupportedPlaneDeliverer.PlaneSignificantlyUpdatedEvent.Invoke(plane:  this._planeStore.Item[key]);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnPointsUpdateEvent(int key, System.Collections.Generic.List<UnityEngine.Vector2> points)
        {
            if(SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSupportedPlaneDeliverer.PlanePointsUpdatedEvent == null)
            {
                    return;
            }
            
            SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSupportedPlaneDeliverer.PlanePointsUpdatedEvent.Invoke(plane:  this._planeStore.Item[key], points:  points);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnTileUpdateEvent(int key, UnityEngine.Vector2 tileCenter)
        {
            if(SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSupportedPlaneDeliverer.PlaneTileAddedEvent == null)
            {
                    return;
            }
            
            SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSupportedPlaneDeliverer.PlaneTileAddedEvent.Invoke(plane:  this._planeStore.Item[key], tileCenter:  new UnityEngine.Vector2() {x = tileCenter.x, y = tileCenter.y});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnPlaneRemoveEvent(int key)
        {
            if(SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSupportedPlaneDeliverer.PlaneRemovedEvent != null)
            {
                    SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSupportedPlaneDeliverer.PlaneRemovedEvent.Invoke(plane:  this._planeStore.Item[key]);
            }
            
            bool val_2 = this._planeStore.Remove(key:  key);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixHorizontalSupportedPlane GetPlane(int key)
        {
            if(this._planeStore != null)
            {
                    return this._planeStore.Item[key];
            }
            
            return this._planeStore.Item[key];
        }
    
    }

}
