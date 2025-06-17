using UnityEngine;

namespace MapMode.GeoPositionObject
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class RefreshGeoPositions
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private MapMode.GeoPositionObject.GeoPositionObjectDomain _geoPositionObjectDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.Location.ILocationProvider _locationProvider;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.Location.ILocationProvider LocationProvider { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.Location.ILocationProvider get_LocationProvider()
        {
            if(this._locationProvider != null)
            {
                    return val_2;
            }
            
            Mapbox.Unity.Location.ILocationProvider val_2 = Mapbox.Unity.Location.LocationProviderFactory.Instance.DefaultLocationProvider;
            this._locationProvider = val_2;
            return val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public RefreshGeoPositions(MapMode.GeoPositionObject.GeoPositionObjectDomain geoPositionObjectDomain)
        {
            this._geoPositionObjectDomain = geoPositionObjectDomain;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Map_OnUpdated()
        {
            this.UpdateGeoPositions();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EventExposer_OnGeoPositionObjectAddedEvent(MapMode.GeoPositionObject.Container.GeoPositionObjectAddedRemovedArgs e)
        {
            this.UpdateGeoPosition(geoPositionObject:  e.geoPositionObject);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateGeoPositions()
        {
            var val_13;
            var val_16;
            var val_17;
            var val_15 = 0;
            val_15 = val_15 + 1;
            val_13 = this._geoPositionObjectDomain.<container>k__BackingField._geoPositionObjectInfos.GetEnumerator();
            label_20:
            var val_16 = 0;
            val_16 = val_16 + 1;
            if(val_13.MoveNext() == false)
            {
                goto label_13;
            }
            
            var val_17 = 0;
            val_17 = val_17 + 1;
            T val_6 = val_13.Current;
            this.UpdateGeoPosition(geoPositionObject:  val_6 + 24);
            goto label_20;
            label_13:
            val_16 = 0;
            val_17 = 63;
            if(val_13 == null)
            {
                
            }
            else
            {
                    var val_18 = 0;
                val_18 = val_18 + 1;
                val_13.Dispose();
            }
            
            if( == 63)
            {
                    return;
            }
            
            if( == false)
            {
                    return;
            }
            
            val_13 = ???;
            val_17 = ???;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateGeoPosition(MapMode.GeoPositionObject.GeoPositionObject geoPositionObject)
        {
            bool val_1 = this._geoPositionObjectDomain._map.isInitialized;
            UnityEngine.GameObject val_2 = geoPositionObject.gameObject;
            if(val_2 == null)
            {
                goto label_3;
            }
            
            if(val_1 == false)
            {
                goto label_4;
            }
            
            label_10:
            val_2.SetActive(value:  true);
            geoPositionObject.transform.localPosition = new UnityEngine.Vector3() {x = V0.16B, y = V1.16B, z = V2.16B};
            return;
            label_3:
            if(val_1 == true)
            {
                goto label_10;
            }
            
            label_4:
            val_2.SetActive(value:  false);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Broker_OnLoadedEvent(AnimatronicEntity.Loader.LoadedArgs e)
        {
            this.UpdateGeoPositions();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnEnable()
        {
            this._geoPositionObjectDomain._map.add_OnUpdated(value:  new System.Action(object:  this, method:  System.Void MapMode.GeoPositionObject.RefreshGeoPositions::Map_OnUpdated()));
            this._geoPositionObjectDomain.<container>k__BackingField.OnGeoPositionObjectAddedEvent = new System.Action<GeoPositionObjectAddedRemovedArgs>(object:  this, method:  System.Void MapMode.GeoPositionObject.RefreshGeoPositions::EventExposer_OnGeoPositionObjectAddedEvent(MapMode.GeoPositionObject.Container.GeoPositionObjectAddedRemovedArgs e));
            this._geoPositionObjectDomain._animatronicEntityDomain.eventExposer.add_LoadedEvent(value:  new System.Action<LoadedArgs>(object:  this, method:  System.Void MapMode.GeoPositionObject.RefreshGeoPositions::Broker_OnLoadedEvent(AnimatronicEntity.Loader.LoadedArgs e)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update()
        {
            this.UpdateGeoPositions();
        }
    
    }

}
