using UnityEngine;

namespace Mapbox.Unity.Location
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class EditorLocationProvider : AbstractEditorLocationProvider
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _latitudeLongitude;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Transform _targetTransform;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.Map.AbstractMap _map;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _mapInitialized;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Utils.Vector2d LatitudeLongitude { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Map_OnInitialized()
        {
            remove_OnInitialized(value:  new System.Action(object:  this, method:  System.Void Mapbox.Unity.Location.EditorLocationProvider::Map_OnInitialized()));
            this._mapInitialized = true;
            this._map = Mapbox.Unity.Location.LocationProviderFactory._instance.mapManager;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Utils.Vector2d get_LatitudeLongitude()
        {
            Mapbox.Unity.Map.AbstractMap val_6;
            Mapbox.Unity.Map.AbstractMap val_7;
            Mapbox.Utils.Vector2d val_1 = Mapbox.Unity.Utilities.Conversions.StringToLatLon(s:  this._latitudeLongitude);
            if(this._mapInitialized == false)
            {
                    return new Mapbox.Utils.Vector2d() {x = val_1.x, y = val_1.y};
            }
            
            val_6 = this._map;
            if(this._map != null)
            {
                goto label_2;
            }
            
            val_6 = this._map;
            if(val_6 == null)
            {
                goto label_8;
            }
            
            label_2:
            Mapbox.Utils.Vector2d val_2 = Mapbox.Unity.Utilities.Conversions.GeoToWorldPosition(latLong:  new Mapbox.Utils.Vector2d() {x = val_1.x, y = val_1.y}, refPoint:  new Mapbox.Utils.Vector2d() {x = this._map._centerMercator}, scale:  this._map._worldRelativeScale);
            UnityEngine.Vector3 val_3 = Mapbox.Unity.Utilities.VectorExtensions.ToVector3xz(v:  new Mapbox.Utils.Vector2d() {x = val_2.x, y = val_2.y});
            UnityEngine.Vector3 val_4 = this._targetTransform.position;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            val_7 = this._map;
            if(this._map != null)
            {
                    return Mapbox.Unity.Utilities.VectorExtensions.GetGeoPosition(position:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, refPoint:  new Mapbox.Utils.Vector2d() {x = this._map._centerMercator, y = val_4.y}, scale:  this._map._worldRelativeScale);
            }
            
            val_7 = this._map;
            if(val_7 != null)
            {
                    return Mapbox.Unity.Utilities.VectorExtensions.GetGeoPosition(position:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, refPoint:  new Mapbox.Utils.Vector2d() {x = this._map._centerMercator, y = val_4.y}, scale:  this._map._worldRelativeScale);
            }
            
            label_8:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void SetLocation()
        {
            UnityEngine.Vector3 val_1 = this._targetTransform.eulerAngles;
            mem[1152921519785199368] = val_1.y;
            Mapbox.Utils.Vector2d val_2 = this.LatitudeLongitude;
            mem[1152921519785199352] = val_2.x;
            mem[1152921519785199360] = val_2.y;
            mem[1152921519785199392] = (float)val_1.z;
            System.DateTime val_3 = System.DateTime.UtcNow;
            mem[1152921519785199376] = Mapbox.Utils.UnixTimestampUtils.To(date:  new System.DateTime() {dateData = val_3.dateData});
            mem[1152921519785199448] = 1;
            mem[1152921519785199397] = 257;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public EditorLocationProvider()
        {
        
        }
    
    }

}
