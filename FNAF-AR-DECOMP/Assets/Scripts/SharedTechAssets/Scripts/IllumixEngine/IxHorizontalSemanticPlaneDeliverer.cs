using UnityEngine;

namespace SharedTechAssets.Scripts.IllumixEngine
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class IxHorizontalSemanticPlaneDeliverer : IIxSemanticHorizontalPlaneAccepter
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<int, SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticHorizontalPlane> _planeStore;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSemanticPlaneDeliverer.Add PlaneAddedEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSemanticPlaneDeliverer.BoundaryUpdate PlaneBoundaryUpdatedEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSemanticPlaneDeliverer.SignificantUpdate PlaneSignificantlyUpdatedEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSemanticPlaneDeliverer.PointsUpdate PlanePointsUpdatedEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSemanticPlaneDeliverer.TileUpdate PlaneTileAddedEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSemanticPlaneDeliverer.Remove PlaneRemovedEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSemanticPlaneDeliverer.TileLabel PlaneTileLabeledEvent;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public IxHorizontalSemanticPlaneDeliverer()
        {
            this._planeStore = new System.Collections.Generic.Dictionary<System.Int32, SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticHorizontalPlane>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void add_PlaneAddedEvent(SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSemanticPlaneDeliverer.Add value)
        {
            System.Delegate val_3 = System.Delegate.Combine(a:  SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSemanticPlaneDeliverer.PlaneAddedEvent, b:  value);
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
        public static void remove_PlaneAddedEvent(SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSemanticPlaneDeliverer.Add value)
        {
            System.Delegate val_3 = System.Delegate.Remove(source:  SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSemanticPlaneDeliverer.PlaneAddedEvent, value:  value);
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
        public static void add_PlaneBoundaryUpdatedEvent(SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSemanticPlaneDeliverer.BoundaryUpdate value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSemanticPlaneDeliverer.PlaneBoundaryUpdatedEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSemanticPlaneDeliverer.PlaneBoundaryUpdatedEvent != 1152921505156583432);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void remove_PlaneBoundaryUpdatedEvent(SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSemanticPlaneDeliverer.BoundaryUpdate value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSemanticPlaneDeliverer.PlaneBoundaryUpdatedEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSemanticPlaneDeliverer.PlaneBoundaryUpdatedEvent != 1152921505156583432);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void add_PlaneSignificantlyUpdatedEvent(SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSemanticPlaneDeliverer.SignificantUpdate value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSemanticPlaneDeliverer.PlaneSignificantlyUpdatedEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSemanticPlaneDeliverer.PlaneSignificantlyUpdatedEvent != 1152921505156583440);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void remove_PlaneSignificantlyUpdatedEvent(SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSemanticPlaneDeliverer.SignificantUpdate value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSemanticPlaneDeliverer.PlaneSignificantlyUpdatedEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSemanticPlaneDeliverer.PlaneSignificantlyUpdatedEvent != 1152921505156583440);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void add_PlanePointsUpdatedEvent(SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSemanticPlaneDeliverer.PointsUpdate value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSemanticPlaneDeliverer.PlanePointsUpdatedEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSemanticPlaneDeliverer.PlanePointsUpdatedEvent != 1152921505156583448);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void remove_PlanePointsUpdatedEvent(SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSemanticPlaneDeliverer.PointsUpdate value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSemanticPlaneDeliverer.PlanePointsUpdatedEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSemanticPlaneDeliverer.PlanePointsUpdatedEvent != 1152921505156583448);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void add_PlaneTileAddedEvent(SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSemanticPlaneDeliverer.TileUpdate value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSemanticPlaneDeliverer.PlaneTileAddedEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSemanticPlaneDeliverer.PlaneTileAddedEvent != 1152921505156583456);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void remove_PlaneTileAddedEvent(SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSemanticPlaneDeliverer.TileUpdate value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSemanticPlaneDeliverer.PlaneTileAddedEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSemanticPlaneDeliverer.PlaneTileAddedEvent != 1152921505156583456);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void add_PlaneRemovedEvent(SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSemanticPlaneDeliverer.Remove value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSemanticPlaneDeliverer.PlaneRemovedEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSemanticPlaneDeliverer.PlaneRemovedEvent != 1152921505156583464);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void remove_PlaneRemovedEvent(SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSemanticPlaneDeliverer.Remove value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSemanticPlaneDeliverer.PlaneRemovedEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSemanticPlaneDeliverer.PlaneRemovedEvent != 1152921505156583464);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void add_PlaneTileLabeledEvent(SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSemanticPlaneDeliverer.TileLabel value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSemanticPlaneDeliverer.PlaneTileLabeledEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSemanticPlaneDeliverer.PlaneTileLabeledEvent != 1152921505156583472);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void remove_PlaneTileLabeledEvent(SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSemanticPlaneDeliverer.TileLabel value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSemanticPlaneDeliverer.PlaneTileLabeledEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSemanticPlaneDeliverer.PlaneTileLabeledEvent != 1152921505156583472);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnPlaneAddEvent(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticHorizontalPlane plane)
        {
            this._planeStore.set_Item(key:  plane.Key, value:  plane);
            if(SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSemanticPlaneDeliverer.PlaneAddedEvent == null)
            {
                    return;
            }
            
            SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSemanticPlaneDeliverer.PlaneAddedEvent.Invoke(plane:  plane);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnBoundaryUpdateEvent(int key)
        {
            if(SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSemanticPlaneDeliverer.PlaneBoundaryUpdatedEvent == null)
            {
                    return;
            }
            
            SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSemanticPlaneDeliverer.PlaneBoundaryUpdatedEvent.Invoke(plane:  this._planeStore.Item[key]);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnSignificantUpdateEvent(int key)
        {
            if(SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSemanticPlaneDeliverer.PlaneSignificantlyUpdatedEvent == null)
            {
                    return;
            }
            
            SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSemanticPlaneDeliverer.PlaneSignificantlyUpdatedEvent.Invoke(plane:  this._planeStore.Item[key]);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnPointsUpdateEvent(int key, System.Collections.Generic.List<UnityEngine.Vector2> points)
        {
            if(SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSemanticPlaneDeliverer.PlanePointsUpdatedEvent == null)
            {
                    return;
            }
            
            SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSemanticPlaneDeliverer.PlanePointsUpdatedEvent.Invoke(plane:  this._planeStore.Item[key], points:  points);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnTileUpdateEvent(int key, UnityEngine.Vector2 tileCenter)
        {
            if(SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSemanticPlaneDeliverer.PlaneTileAddedEvent == null)
            {
                    return;
            }
            
            SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSemanticPlaneDeliverer.PlaneTileAddedEvent.Invoke(plane:  this._planeStore.Item[key], tileCenter:  new UnityEngine.Vector2() {x = tileCenter.x, y = tileCenter.y});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnPlaneRemoveEvent(int key)
        {
            if(SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSemanticPlaneDeliverer.PlaneRemovedEvent != null)
            {
                    SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSemanticPlaneDeliverer.PlaneRemovedEvent.Invoke(plane:  this._planeStore.Item[key]);
            }
            
            bool val_2 = this._planeStore.Remove(key:  key);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnTileLabelEvent(int key, UnityEngine.Vector2 tileKey, string label, float confidence)
        {
            if(SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSemanticPlaneDeliverer.PlaneTileLabeledEvent == null)
            {
                    return;
            }
            
            SharedTechAssets.Scripts.IllumixEngine.IxHorizontalSemanticPlaneDeliverer.PlaneTileLabeledEvent.Invoke(plane:  this._planeStore.Item[key], key:  new UnityEngine.Vector2() {x = tileKey.x, y = tileKey.y}, label:  label, confidence:  confidence);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticHorizontalPlane GetPlane(int key)
        {
            if(this._planeStore != null)
            {
                    return this._planeStore.Item[key];
            }
            
            return this._planeStore.Item[key];
        }
    
    }

}
