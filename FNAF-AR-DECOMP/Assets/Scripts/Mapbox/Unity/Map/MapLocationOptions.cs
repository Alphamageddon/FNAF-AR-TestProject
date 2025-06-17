using UnityEngine;

namespace Mapbox.Unity.Map
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class MapLocationOptions
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string latitudeLongitude;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float zoom;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.MapCoordinateSystemType coordinateSystemType;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapLocationOptions()
        {
            this.zoom = 4f;
            this.latitudeLongitude = "0,0";
        }
    
    }

}
