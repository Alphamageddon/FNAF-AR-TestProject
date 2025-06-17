using UnityEngine;

namespace MapMode.GeoPositionObject
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class GeocodeResultObject : GeoPositionObject
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private MapMode.GeoPositionObject.GeoPositionData <geoPositionData>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject _content;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.TextMesh _text;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override Mapbox.Utils.Vector2d geoPosition { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapMode.GeoPositionObject.GeoPositionData geoPositionData { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override Mapbox.Utils.Vector2d get_geoPosition()
        {
            if((this.<geoPositionData>k__BackingField) != null)
            {
                    return new Mapbox.Utils.Vector2d() {x = this.<geoPositionData>k__BackingField.<geoPosition>k__BackingField};
            }
            
            return new Mapbox.Utils.Vector2d() {x = this.<geoPositionData>k__BackingField.<geoPosition>k__BackingField};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapMode.GeoPositionObject.GeoPositionData get_geoPositionData()
        {
            return (MapMode.GeoPositionObject.GeoPositionData)this.<geoPositionData>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_geoPositionData(MapMode.GeoPositionObject.GeoPositionData value)
        {
            this.<geoPositionData>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetGeoPositionData(MapMode.GeoPositionObject.GeoPositionData geoPositionData)
        {
            this.<geoPositionData>k__BackingField = new MapMode.GeoPositionObject.GeoPositionData(geoPositionData:  geoPositionData);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void ToggleVisibility(bool show)
        {
            show = show;
            this._content.SetActive(value:  show);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetText(string text)
        {
            this._text.text = text;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GeocodeResultObject()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
