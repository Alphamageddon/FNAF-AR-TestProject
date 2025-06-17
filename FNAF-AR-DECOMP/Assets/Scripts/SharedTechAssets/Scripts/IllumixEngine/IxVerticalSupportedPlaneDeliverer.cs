using UnityEngine;

namespace SharedTechAssets.Scripts.IllumixEngine
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class IxVerticalSupportedPlaneDeliverer : IIxVerticalSupportedPlaneAccepter
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<int, SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalSupportedPlane> _planeStore;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static SharedTechAssets.Scripts.IllumixEngine.IxVerticalSupportedPlaneDeliverer.Add PlaneAddedEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static SharedTechAssets.Scripts.IllumixEngine.IxVerticalSupportedPlaneDeliverer.BoundaryUpdate PlaneBoundaryUpdatedEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static SharedTechAssets.Scripts.IllumixEngine.IxVerticalSupportedPlaneDeliverer.SignificantUpdate PlaneSignificantlyUpdatedEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static SharedTechAssets.Scripts.IllumixEngine.IxVerticalSupportedPlaneDeliverer.PointsUpdate PlanePointsUpdatedEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static SharedTechAssets.Scripts.IllumixEngine.IxVerticalSupportedPlaneDeliverer.TilesUpdate PlaneTilesUpdatedEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static SharedTechAssets.Scripts.IllumixEngine.IxVerticalSupportedPlaneDeliverer.Remove PlaneRemovedEvent;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public IxVerticalSupportedPlaneDeliverer()
        {
            this._planeStore = new System.Collections.Generic.Dictionary<System.Int32, SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalSupportedPlane>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void add_PlaneAddedEvent(SharedTechAssets.Scripts.IllumixEngine.IxVerticalSupportedPlaneDeliverer.Add value)
        {
            System.Delegate val_3 = System.Delegate.Combine(a:  SharedTechAssets.Scripts.IllumixEngine.IxVerticalSupportedPlaneDeliverer.PlaneAddedEvent, b:  value);
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
        public static void remove_PlaneAddedEvent(SharedTechAssets.Scripts.IllumixEngine.IxVerticalSupportedPlaneDeliverer.Add value)
        {
            System.Delegate val_3 = System.Delegate.Remove(source:  SharedTechAssets.Scripts.IllumixEngine.IxVerticalSupportedPlaneDeliverer.PlaneAddedEvent, value:  value);
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
        public static void add_PlaneBoundaryUpdatedEvent(SharedTechAssets.Scripts.IllumixEngine.IxVerticalSupportedPlaneDeliverer.BoundaryUpdate value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  SharedTechAssets.Scripts.IllumixEngine.IxVerticalSupportedPlaneDeliverer.PlaneBoundaryUpdatedEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(SharedTechAssets.Scripts.IllumixEngine.IxVerticalSupportedPlaneDeliverer.PlaneBoundaryUpdatedEvent != 1152921505158713352);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void remove_PlaneBoundaryUpdatedEvent(SharedTechAssets.Scripts.IllumixEngine.IxVerticalSupportedPlaneDeliverer.BoundaryUpdate value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  SharedTechAssets.Scripts.IllumixEngine.IxVerticalSupportedPlaneDeliverer.PlaneBoundaryUpdatedEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(SharedTechAssets.Scripts.IllumixEngine.IxVerticalSupportedPlaneDeliverer.PlaneBoundaryUpdatedEvent != 1152921505158713352);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void add_PlaneSignificantlyUpdatedEvent(SharedTechAssets.Scripts.IllumixEngine.IxVerticalSupportedPlaneDeliverer.SignificantUpdate value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  SharedTechAssets.Scripts.IllumixEngine.IxVerticalSupportedPlaneDeliverer.PlaneSignificantlyUpdatedEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(SharedTechAssets.Scripts.IllumixEngine.IxVerticalSupportedPlaneDeliverer.PlaneSignificantlyUpdatedEvent != 1152921505158713360);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void remove_PlaneSignificantlyUpdatedEvent(SharedTechAssets.Scripts.IllumixEngine.IxVerticalSupportedPlaneDeliverer.SignificantUpdate value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  SharedTechAssets.Scripts.IllumixEngine.IxVerticalSupportedPlaneDeliverer.PlaneSignificantlyUpdatedEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(SharedTechAssets.Scripts.IllumixEngine.IxVerticalSupportedPlaneDeliverer.PlaneSignificantlyUpdatedEvent != 1152921505158713360);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void add_PlanePointsUpdatedEvent(SharedTechAssets.Scripts.IllumixEngine.IxVerticalSupportedPlaneDeliverer.PointsUpdate value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  SharedTechAssets.Scripts.IllumixEngine.IxVerticalSupportedPlaneDeliverer.PlanePointsUpdatedEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(SharedTechAssets.Scripts.IllumixEngine.IxVerticalSupportedPlaneDeliverer.PlanePointsUpdatedEvent != 1152921505158713368);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void remove_PlanePointsUpdatedEvent(SharedTechAssets.Scripts.IllumixEngine.IxVerticalSupportedPlaneDeliverer.PointsUpdate value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  SharedTechAssets.Scripts.IllumixEngine.IxVerticalSupportedPlaneDeliverer.PlanePointsUpdatedEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(SharedTechAssets.Scripts.IllumixEngine.IxVerticalSupportedPlaneDeliverer.PlanePointsUpdatedEvent != 1152921505158713368);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void add_PlaneTilesUpdatedEvent(SharedTechAssets.Scripts.IllumixEngine.IxVerticalSupportedPlaneDeliverer.TilesUpdate value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  SharedTechAssets.Scripts.IllumixEngine.IxVerticalSupportedPlaneDeliverer.PlaneTilesUpdatedEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(SharedTechAssets.Scripts.IllumixEngine.IxVerticalSupportedPlaneDeliverer.PlaneTilesUpdatedEvent != 1152921505158713376);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void remove_PlaneTilesUpdatedEvent(SharedTechAssets.Scripts.IllumixEngine.IxVerticalSupportedPlaneDeliverer.TilesUpdate value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  SharedTechAssets.Scripts.IllumixEngine.IxVerticalSupportedPlaneDeliverer.PlaneTilesUpdatedEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(SharedTechAssets.Scripts.IllumixEngine.IxVerticalSupportedPlaneDeliverer.PlaneTilesUpdatedEvent != 1152921505158713376);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void add_PlaneRemovedEvent(SharedTechAssets.Scripts.IllumixEngine.IxVerticalSupportedPlaneDeliverer.Remove value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  SharedTechAssets.Scripts.IllumixEngine.IxVerticalSupportedPlaneDeliverer.PlaneRemovedEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(SharedTechAssets.Scripts.IllumixEngine.IxVerticalSupportedPlaneDeliverer.PlaneRemovedEvent != 1152921505158713384);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void remove_PlaneRemovedEvent(SharedTechAssets.Scripts.IllumixEngine.IxVerticalSupportedPlaneDeliverer.Remove value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  SharedTechAssets.Scripts.IllumixEngine.IxVerticalSupportedPlaneDeliverer.PlaneRemovedEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(SharedTechAssets.Scripts.IllumixEngine.IxVerticalSupportedPlaneDeliverer.PlaneRemovedEvent != 1152921505158713384);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnPlaneAddEvent(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalSupportedPlane plane)
        {
            this._planeStore.set_Item(key:  plane.Key, value:  plane);
            if(SharedTechAssets.Scripts.IllumixEngine.IxVerticalSupportedPlaneDeliverer.PlaneAddedEvent == null)
            {
                    return;
            }
            
            SharedTechAssets.Scripts.IllumixEngine.IxVerticalSupportedPlaneDeliverer.PlaneAddedEvent.Invoke(plane:  plane);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnBoundaryUpdateEvent(int key)
        {
            if(SharedTechAssets.Scripts.IllumixEngine.IxVerticalSupportedPlaneDeliverer.PlaneBoundaryUpdatedEvent == null)
            {
                    return;
            }
            
            SharedTechAssets.Scripts.IllumixEngine.IxVerticalSupportedPlaneDeliverer.PlaneBoundaryUpdatedEvent.Invoke(plane:  this._planeStore.Item[key]);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnSignificantUpdateEvent(int key)
        {
            if(SharedTechAssets.Scripts.IllumixEngine.IxVerticalSupportedPlaneDeliverer.PlaneSignificantlyUpdatedEvent == null)
            {
                    return;
            }
            
            SharedTechAssets.Scripts.IllumixEngine.IxVerticalSupportedPlaneDeliverer.PlaneSignificantlyUpdatedEvent.Invoke(plane:  this._planeStore.Item[key]);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnPointsUpdateEvent(int key, System.Collections.Generic.Dictionary<UnityEngine.Vector2, UnityEngine.Vector3> points)
        {
            if(SharedTechAssets.Scripts.IllumixEngine.IxVerticalSupportedPlaneDeliverer.PlanePointsUpdatedEvent == null)
            {
                    return;
            }
            
            SharedTechAssets.Scripts.IllumixEngine.IxVerticalSupportedPlaneDeliverer.PlanePointsUpdatedEvent.Invoke(plane:  this._planeStore.Item[key], points:  points);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnTileUpdateEvent(int key, UnityEngine.Vector2 planeSpaceCenter, UnityEngine.Vector3[] tileCoords)
        {
            if(SharedTechAssets.Scripts.IllumixEngine.IxVerticalSupportedPlaneDeliverer.PlaneTilesUpdatedEvent == null)
            {
                    return;
            }
            
            SharedTechAssets.Scripts.IllumixEngine.IxVerticalSupportedPlaneDeliverer.PlaneTilesUpdatedEvent.Invoke(plane:  this._planeStore.Item[key], key:  new UnityEngine.Vector2() {x = planeSpaceCenter.x, y = planeSpaceCenter.y}, tileCoords:  tileCoords);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnRemoveEvent(int key)
        {
            if(SharedTechAssets.Scripts.IllumixEngine.IxVerticalSupportedPlaneDeliverer.PlaneRemovedEvent != null)
            {
                    SharedTechAssets.Scripts.IllumixEngine.IxVerticalSupportedPlaneDeliverer.PlaneRemovedEvent.Invoke(plane:  this._planeStore.Item[key]);
            }
            
            bool val_2 = this._planeStore.Remove(key:  key);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalSupportedPlane GetPlane(int key)
        {
            if(this._planeStore != null)
            {
                    return this._planeStore.Item[key];
            }
            
            return this._planeStore.Item[key];
        }
    
    }

}
