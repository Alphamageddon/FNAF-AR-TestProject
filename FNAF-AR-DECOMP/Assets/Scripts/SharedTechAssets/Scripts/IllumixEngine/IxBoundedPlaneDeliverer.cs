using UnityEngine;

namespace SharedTechAssets.Scripts.IllumixEngine
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class IxBoundedPlaneDeliverer : IIxBoundedPlaneAccepter
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<int, IllumixHorizontalBoundedPlane> _horizontalBoundedPlaneStore;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<int, SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalBoundedPlane> _verticalBoundedPlaneStore;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static SharedTechAssets.Scripts.IllumixEngine.IxBoundedPlaneDeliverer.HorizontalBoundedPlaneAdd HorizontalBoundedPlaneAddedEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static SharedTechAssets.Scripts.IllumixEngine.IxBoundedPlaneDeliverer.HorizontalBoundedPlaneUpdate HorizontalBoundedPlaneUpdatedEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static SharedTechAssets.Scripts.IllumixEngine.IxBoundedPlaneDeliverer.HorizontalBoundedPlaneRemove HorizontalBoundedPlaneRemovedEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static SharedTechAssets.Scripts.IllumixEngine.IxBoundedPlaneDeliverer.VerticalBoundedPlaneAdd VerticalBoundedPlaneAddedEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static SharedTechAssets.Scripts.IllumixEngine.IxBoundedPlaneDeliverer.VerticalBoundedPlaneUpdate VerticalBoundedPlaneUpdatedEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static SharedTechAssets.Scripts.IllumixEngine.IxBoundedPlaneDeliverer.VerticalBoundedPlaneRemove VerticalBoundedPlaneRemovedEvent;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public IxBoundedPlaneDeliverer()
        {
            this._horizontalBoundedPlaneStore = new System.Collections.Generic.Dictionary<System.Int32, IllumixHorizontalBoundedPlane>();
            this._verticalBoundedPlaneStore = new System.Collections.Generic.Dictionary<System.Int32, SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalBoundedPlane>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void add_HorizontalBoundedPlaneAddedEvent(SharedTechAssets.Scripts.IllumixEngine.IxBoundedPlaneDeliverer.HorizontalBoundedPlaneAdd value)
        {
            System.Delegate val_3 = System.Delegate.Combine(a:  SharedTechAssets.Scripts.IllumixEngine.IxBoundedPlaneDeliverer.HorizontalBoundedPlaneAddedEvent, b:  value);
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
        public static void remove_HorizontalBoundedPlaneAddedEvent(SharedTechAssets.Scripts.IllumixEngine.IxBoundedPlaneDeliverer.HorizontalBoundedPlaneAdd value)
        {
            System.Delegate val_3 = System.Delegate.Remove(source:  SharedTechAssets.Scripts.IllumixEngine.IxBoundedPlaneDeliverer.HorizontalBoundedPlaneAddedEvent, value:  value);
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
        public static void add_HorizontalBoundedPlaneUpdatedEvent(SharedTechAssets.Scripts.IllumixEngine.IxBoundedPlaneDeliverer.HorizontalBoundedPlaneUpdate value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  SharedTechAssets.Scripts.IllumixEngine.IxBoundedPlaneDeliverer.HorizontalBoundedPlaneUpdatedEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(SharedTechAssets.Scripts.IllumixEngine.IxBoundedPlaneDeliverer.HorizontalBoundedPlaneUpdatedEvent != 1152921505156104200);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void remove_HorizontalBoundedPlaneUpdatedEvent(SharedTechAssets.Scripts.IllumixEngine.IxBoundedPlaneDeliverer.HorizontalBoundedPlaneUpdate value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  SharedTechAssets.Scripts.IllumixEngine.IxBoundedPlaneDeliverer.HorizontalBoundedPlaneUpdatedEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(SharedTechAssets.Scripts.IllumixEngine.IxBoundedPlaneDeliverer.HorizontalBoundedPlaneUpdatedEvent != 1152921505156104200);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void add_HorizontalBoundedPlaneRemovedEvent(SharedTechAssets.Scripts.IllumixEngine.IxBoundedPlaneDeliverer.HorizontalBoundedPlaneRemove value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  SharedTechAssets.Scripts.IllumixEngine.IxBoundedPlaneDeliverer.HorizontalBoundedPlaneRemovedEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(SharedTechAssets.Scripts.IllumixEngine.IxBoundedPlaneDeliverer.HorizontalBoundedPlaneRemovedEvent != 1152921505156104208);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void remove_HorizontalBoundedPlaneRemovedEvent(SharedTechAssets.Scripts.IllumixEngine.IxBoundedPlaneDeliverer.HorizontalBoundedPlaneRemove value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  SharedTechAssets.Scripts.IllumixEngine.IxBoundedPlaneDeliverer.HorizontalBoundedPlaneRemovedEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(SharedTechAssets.Scripts.IllumixEngine.IxBoundedPlaneDeliverer.HorizontalBoundedPlaneRemovedEvent != 1152921505156104208);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void add_VerticalBoundedPlaneAddedEvent(SharedTechAssets.Scripts.IllumixEngine.IxBoundedPlaneDeliverer.VerticalBoundedPlaneAdd value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  SharedTechAssets.Scripts.IllumixEngine.IxBoundedPlaneDeliverer.VerticalBoundedPlaneAddedEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(SharedTechAssets.Scripts.IllumixEngine.IxBoundedPlaneDeliverer.VerticalBoundedPlaneAddedEvent != 1152921505156104216);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void remove_VerticalBoundedPlaneAddedEvent(SharedTechAssets.Scripts.IllumixEngine.IxBoundedPlaneDeliverer.VerticalBoundedPlaneAdd value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  SharedTechAssets.Scripts.IllumixEngine.IxBoundedPlaneDeliverer.VerticalBoundedPlaneAddedEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(SharedTechAssets.Scripts.IllumixEngine.IxBoundedPlaneDeliverer.VerticalBoundedPlaneAddedEvent != 1152921505156104216);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void add_VerticalBoundedPlaneUpdatedEvent(SharedTechAssets.Scripts.IllumixEngine.IxBoundedPlaneDeliverer.VerticalBoundedPlaneUpdate value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  SharedTechAssets.Scripts.IllumixEngine.IxBoundedPlaneDeliverer.VerticalBoundedPlaneUpdatedEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(SharedTechAssets.Scripts.IllumixEngine.IxBoundedPlaneDeliverer.VerticalBoundedPlaneUpdatedEvent != 1152921505156104224);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void remove_VerticalBoundedPlaneUpdatedEvent(SharedTechAssets.Scripts.IllumixEngine.IxBoundedPlaneDeliverer.VerticalBoundedPlaneUpdate value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  SharedTechAssets.Scripts.IllumixEngine.IxBoundedPlaneDeliverer.VerticalBoundedPlaneUpdatedEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(SharedTechAssets.Scripts.IllumixEngine.IxBoundedPlaneDeliverer.VerticalBoundedPlaneUpdatedEvent != 1152921505156104224);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void add_VerticalBoundedPlaneRemovedEvent(SharedTechAssets.Scripts.IllumixEngine.IxBoundedPlaneDeliverer.VerticalBoundedPlaneRemove value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  SharedTechAssets.Scripts.IllumixEngine.IxBoundedPlaneDeliverer.VerticalBoundedPlaneRemovedEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(SharedTechAssets.Scripts.IllumixEngine.IxBoundedPlaneDeliverer.VerticalBoundedPlaneRemovedEvent != 1152921505156104232);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void remove_VerticalBoundedPlaneRemovedEvent(SharedTechAssets.Scripts.IllumixEngine.IxBoundedPlaneDeliverer.VerticalBoundedPlaneRemove value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  SharedTechAssets.Scripts.IllumixEngine.IxBoundedPlaneDeliverer.VerticalBoundedPlaneRemovedEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(SharedTechAssets.Scripts.IllumixEngine.IxBoundedPlaneDeliverer.VerticalBoundedPlaneRemovedEvent != 1152921505156104232);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnHorizontalBoundedPlaneAddEvent(IllumixHorizontalBoundedPlane plane)
        {
            this._horizontalBoundedPlaneStore.set_Item(key:  plane.Key, value:  plane);
            if(SharedTechAssets.Scripts.IllumixEngine.IxBoundedPlaneDeliverer.HorizontalBoundedPlaneAddedEvent == null)
            {
                    return;
            }
            
            SharedTechAssets.Scripts.IllumixEngine.IxBoundedPlaneDeliverer.HorizontalBoundedPlaneAddedEvent.Invoke(plane:  plane);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnHorizontalBoundedPlaneUpdateEvent(int key)
        {
            if(SharedTechAssets.Scripts.IllumixEngine.IxBoundedPlaneDeliverer.HorizontalBoundedPlaneUpdatedEvent == null)
            {
                    return;
            }
            
            SharedTechAssets.Scripts.IllumixEngine.IxBoundedPlaneDeliverer.HorizontalBoundedPlaneUpdatedEvent.Invoke(plane:  this._horizontalBoundedPlaneStore.Item[key]);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnHorizontalBoundedPlaneRemoveEvent(int key)
        {
            if(SharedTechAssets.Scripts.IllumixEngine.IxBoundedPlaneDeliverer.HorizontalBoundedPlaneRemovedEvent != null)
            {
                    SharedTechAssets.Scripts.IllumixEngine.IxBoundedPlaneDeliverer.HorizontalBoundedPlaneRemovedEvent.Invoke(plane:  this._horizontalBoundedPlaneStore.Item[key]);
            }
            
            bool val_2 = this._horizontalBoundedPlaneStore.Remove(key:  key);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnVerticalBoundedPlaneAddEvent(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalBoundedPlane plane)
        {
            this._verticalBoundedPlaneStore.set_Item(key:  plane.<Key>k__BackingField, value:  plane);
            if(SharedTechAssets.Scripts.IllumixEngine.IxBoundedPlaneDeliverer.VerticalBoundedPlaneAddedEvent == null)
            {
                    return;
            }
            
            SharedTechAssets.Scripts.IllumixEngine.IxBoundedPlaneDeliverer.VerticalBoundedPlaneAddedEvent.Invoke(plane:  plane);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnVerticalBoundedPlaneUpdateEvent(int key)
        {
            if(SharedTechAssets.Scripts.IllumixEngine.IxBoundedPlaneDeliverer.VerticalBoundedPlaneUpdatedEvent == null)
            {
                    return;
            }
            
            SharedTechAssets.Scripts.IllumixEngine.IxBoundedPlaneDeliverer.VerticalBoundedPlaneUpdatedEvent.Invoke(plane:  this._verticalBoundedPlaneStore.Item[key]);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnVerticalBoundedPlaneRemoveEvent(int key)
        {
            if(SharedTechAssets.Scripts.IllumixEngine.IxBoundedPlaneDeliverer.VerticalBoundedPlaneRemovedEvent != null)
            {
                    SharedTechAssets.Scripts.IllumixEngine.IxBoundedPlaneDeliverer.VerticalBoundedPlaneRemovedEvent.Invoke(plane:  this._verticalBoundedPlaneStore.Item[key]);
            }
            
            bool val_2 = this._verticalBoundedPlaneStore.Remove(key:  key);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public IllumixHorizontalBoundedPlane GetHorizontalBoundedPlane(int key)
        {
            if(this._horizontalBoundedPlaneStore != null)
            {
                    return this._horizontalBoundedPlaneStore.Item[key];
            }
            
            return this._horizontalBoundedPlaneStore.Item[key];
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalBoundedPlane GetVerticalBoundedPlane(int key)
        {
            if(this._verticalBoundedPlaneStore != null)
            {
                    return this._verticalBoundedPlaneStore.Item[key];
            }
            
            return this._verticalBoundedPlaneStore.Item[key];
        }
    
    }

}
