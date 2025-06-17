using UnityEngine;

namespace MapMode.GeoPositionObject
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class GeoPositionData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Utils.Vector2d <geoPosition>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Utils.Vector2d geoPosition { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Utils.Vector2d get_geoPosition()
        {
            return new Mapbox.Utils.Vector2d() {x = this.<geoPosition>k__BackingField};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_geoPosition(Mapbox.Utils.Vector2d value)
        {
            this.<geoPosition>k__BackingField = value;
            mem[1152921524637810744] = value.y;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GeoPositionData(MapMode.GeoPositionObject.GeoPositionData geoPositionData)
        {
            this.<geoPosition>k__BackingField = geoPositionData.<geoPosition>k__BackingField;
            mem[1152921524637926840] = ???;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GeoPositionData(Mapbox.Utils.Vector2d geoPosition)
        {
            this.<geoPosition>k__BackingField = geoPosition;
            mem[1152921524638042936] = geoPosition.y;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string ToString()
        {
            return (string);
        }
    
    }

}
