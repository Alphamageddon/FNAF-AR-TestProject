using UnityEngine;

namespace MapMode.GeoPositionObject
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Container
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<MapMode.GeoPositionObject.Container.GeoPositionObjectAddedRemovedArgs> OnGeoPositionObjectAddedEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<MapMode.GeoPositionObject.Container.GeoPositionObjectAddedRemovedArgs> OnGeoPositionObjectRemovedEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<MapMode.GeoPositionObject.Container.GeoPositionObjectsClearedArgs> OnGeoPositionObjectsClearedEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<MapMode.GeoPositionObject.GeoPositionObjectInfo> _geoPositionObjectInfos;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.IEnumerable<MapMode.GeoPositionObject.GeoPositionObjectInfo> GeoPositionObjectInfos { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGeoPositionObjectAddedEvent(System.Action<MapMode.GeoPositionObject.Container.GeoPositionObjectAddedRemovedArgs> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGeoPositionObjectAddedEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGeoPositionObjectAddedEvent != 1152921524631108720);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGeoPositionObjectAddedEvent(System.Action<MapMode.GeoPositionObject.Container.GeoPositionObjectAddedRemovedArgs> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGeoPositionObjectAddedEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGeoPositionObjectAddedEvent != 1152921524631245296);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGeoPositionObjectRemovedEvent(System.Action<MapMode.GeoPositionObject.Container.GeoPositionObjectAddedRemovedArgs> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGeoPositionObjectRemovedEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGeoPositionObjectRemovedEvent != 1152921524631381880);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGeoPositionObjectRemovedEvent(System.Action<MapMode.GeoPositionObject.Container.GeoPositionObjectAddedRemovedArgs> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGeoPositionObjectRemovedEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGeoPositionObjectRemovedEvent != 1152921524631518456);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGeoPositionObjectsClearedEvent(System.Action<MapMode.GeoPositionObject.Container.GeoPositionObjectsClearedArgs> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGeoPositionObjectsClearedEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGeoPositionObjectsClearedEvent != 1152921524631655040);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGeoPositionObjectsClearedEvent(System.Action<MapMode.GeoPositionObject.Container.GeoPositionObjectsClearedArgs> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGeoPositionObjectsClearedEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGeoPositionObjectsClearedEvent != 1152921524631791616);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.IEnumerable<MapMode.GeoPositionObject.GeoPositionObjectInfo> get_GeoPositionObjectInfos()
        {
            return (System.Collections.Generic.IEnumerable<MapMode.GeoPositionObject.GeoPositionObjectInfo>)this._geoPositionObjectInfos;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Add(MapMode.GeoPositionObject.EntityType entityType, MapMode.GeoPositionObject.GeoPositionObject geoPositionObject)
        {
            MapMode.GeoPositionObject.GeoPositionObjectInfo val_1 = new MapMode.GeoPositionObject.GeoPositionObjectInfo();
            if(val_1 != null)
            {
                    .entityType = entityType;
            }
            else
            {
                    mem[16] = entityType;
            }
            
            .geoPositionObject = geoPositionObject;
            this._geoPositionObjectInfos.Add(item:  val_1);
            if(this.OnGeoPositionObjectAddedEvent == null)
            {
                    return;
            }
            
            Container.GeoPositionObjectAddedRemovedArgs val_2 = new Container.GeoPositionObjectAddedRemovedArgs();
            if(val_2 != null)
            {
                    .entityType = entityType;
            }
            else
            {
                    mem[16] = entityType;
            }
            
            .geoPositionObject = geoPositionObject;
            this.OnGeoPositionObjectAddedEvent.Invoke(obj:  val_2);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapMode.GeoPositionObject.GeoPositionObject Remove(MapMode.GeoPositionObject.GeoPositionObject geoPositionObject)
        {
            System.Action<GeoPositionObjectAddedRemovedArgs> val_6;
            int val_7;
            MapMode.GeoPositionObject.GeoPositionObject val_8;
            MapMode.GeoPositionObject.GeoPositionObject val_9;
            val_6 = this;
            .geoPositionObject = geoPositionObject;
            val_7 = this._geoPositionObjectInfos.FindIndex(match:  new System.Predicate<MapMode.GeoPositionObject.GeoPositionObjectInfo>(object:  new Container.<>c__DisplayClass15_0(), method:  System.Boolean Container.<>c__DisplayClass15_0::<Remove>b__0(MapMode.GeoPositionObject.GeoPositionObjectInfo target)));
            if((val_7 & 2147483648) != 0)
            {
                goto label_3;
            }
            
            this._geoPositionObjectInfos.RemoveAt(index:  val_7);
            val_6 = this.OnGeoPositionObjectRemovedEvent;
            if(val_6 == null)
            {
                goto label_6;
            }
            
            Container.GeoPositionObjectAddedRemovedArgs val_5 = null;
            val_7 = val_5;
            val_5 = new Container.GeoPositionObjectAddedRemovedArgs();
            if(val_7 == null)
            {
                goto label_8;
            }
            
            .entityType = val_4.entityType;
            val_8 = val_4.geoPositionObject;
            goto label_9;
            label_3:
            ConsoleLogger.LogError(className:  "MapMode.GeoPositionObject.Container", functionName:  "Remove", logString:  "didn\'t find object to remove");
            val_9 = 0;
            return val_9;
            label_6:
            if(this._geoPositionObjectInfos.Item[val_7] != null)
            {
                goto label_14;
            }
            
            goto label_14;
            label_8:
            mem[16] = val_4.entityType;
            val_8 = val_4.geoPositionObject;
            label_9:
            .geoPositionObject = val_8;
            val_6.Invoke(obj:  val_5);
            label_14:
            val_9 = val_4.geoPositionObject;
            return val_9;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<MapMode.GeoPositionObject.GeoPositionObjectInfo> ClearAllOfType(MapMode.GeoPositionObject.EntityType entityType)
        {
            System.Collections.Generic.List<MapMode.GeoPositionObject.GeoPositionObjectInfo> val_6;
            .entityType = entityType;
            .objectsCleared = new System.Collections.Generic.List<MapMode.GeoPositionObject.GeoPositionObjectInfo>();
            val_6 = this._geoPositionObjectInfos;
            int val_4 = val_6.RemoveAll(match:  new System.Predicate<MapMode.GeoPositionObject.GeoPositionObjectInfo>(object:  new Container.<>c__DisplayClass16_0(), method:  System.Boolean Container.<>c__DisplayClass16_0::<ClearAllOfType>b__0(MapMode.GeoPositionObject.GeoPositionObjectInfo target)));
            if(this.OnGeoPositionObjectsClearedEvent == null)
            {
                    return (System.Collections.Generic.List<MapMode.GeoPositionObject.GeoPositionObjectInfo>)(Container.<>c__DisplayClass16_0)[1152921524632499184].objectsCleared;
            }
            
            Container.GeoPositionObjectsClearedArgs val_5 = null;
            val_6 = val_5;
            val_5 = new Container.GeoPositionObjectsClearedArgs();
            .objectsCleared = (Container.<>c__DisplayClass16_0)[1152921524632499184].objectsCleared;
            this.OnGeoPositionObjectsClearedEvent.Invoke(obj:  val_5);
            return (System.Collections.Generic.List<MapMode.GeoPositionObject.GeoPositionObjectInfo>)(Container.<>c__DisplayClass16_0)[1152921524632499184].objectsCleared;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapMode.GeoPositionObject.GeoPositionObject FindFirstOfType(MapMode.GeoPositionObject.EntityType entityType)
        {
            GameUI.ServerGameUIDataModel val_6;
            List.Enumerator<T> val_1 = this._geoPositionObjectInfos.GetEnumerator();
            label_4:
            if(((-1449054904) & 1) == 0)
            {
                goto label_2;
            }
            
            GameUI.EmailUIDataHandler val_2 = 0.emailUIDataHandler;
            if(val_2._masterDomain != entityType)
            {
                goto label_4;
            }
            
            val_6 = val_2._serverGameUIDataModel;
            long val_3 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921524632628552});
            return (MapMode.GeoPositionObject.GeoPositionObject)val_6;
            label_2:
            long val_4 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921524632628552});
            val_6 = 0;
            return (MapMode.GeoPositionObject.GeoPositionObject)val_6;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<MapMode.GeoPositionObject.GeoPositionObject> FindAllOfType(MapMode.GeoPositionObject.EntityType entityType)
        {
            System.Collections.Generic.List<MapMode.GeoPositionObject.GeoPositionObject> val_1 = new System.Collections.Generic.List<MapMode.GeoPositionObject.GeoPositionObject>();
            List.Enumerator<T> val_2 = this._geoPositionObjectInfos.GetEnumerator();
            label_6:
            if(((-1448887624) & 1) == 0)
            {
                goto label_2;
            }
            
            GameUI.EmailUIDataHandler val_3 = 0.emailUIDataHandler;
            if(val_3._masterDomain != entityType)
            {
                goto label_6;
            }
            
            val_1.Add(item:  val_3._serverGameUIDataModel);
            goto label_6;
            label_2:
            long val_4 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921524632795832});
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RegisterEntityAdded(System.Action<MapMode.GeoPositionObject.Container.GeoPositionObjectAddedRemovedArgs> callback)
        {
            this.OnGeoPositionObjectAddedEvent = callback;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Container()
        {
            this._geoPositionObjectInfos = new System.Collections.Generic.List<MapMode.GeoPositionObject.GeoPositionObjectInfo>();
        }
    
    }

}
