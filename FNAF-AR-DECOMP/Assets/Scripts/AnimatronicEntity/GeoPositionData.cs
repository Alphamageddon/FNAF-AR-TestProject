using UnityEngine;

namespace AnimatronicEntity
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
            mem[1152921525018853592] = value.y;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GeoPositionData(AnimatronicEntity.GeoPositionData geoPositionData)
        {
            this.<geoPosition>k__BackingField = geoPositionData.<geoPosition>k__BackingField;
            mem[1152921525018969688] = ???;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GeoPositionData(Mapbox.Utils.Vector2d geoPosition)
        {
            this.<geoPosition>k__BackingField = geoPosition;
            mem[1152921525019085784] = geoPosition.y;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string ToString()
        {
            return (string);
        }
    
    }

}
