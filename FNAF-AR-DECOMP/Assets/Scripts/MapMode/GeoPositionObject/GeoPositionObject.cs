using UnityEngine;

namespace MapMode.GeoPositionObject
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract class GeoPositionObject : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string id;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract Mapbox.Utils.Vector2d geoPosition { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract Mapbox.Utils.Vector2d get_geoPosition(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void ToggleVisibility(bool show); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected GeoPositionObject()
        {
        
        }
    
    }

}
