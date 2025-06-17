using UnityEngine;

namespace Mapbox.Unity.Location
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface ILocationProvider
    {
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract Mapbox.Unity.Location.Location CurrentLocation { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void add_OnLocationUpdated(System.Action<Mapbox.Unity.Location.Location> value); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void remove_OnLocationUpdated(System.Action<Mapbox.Unity.Location.Location> value); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract Mapbox.Unity.Location.Location get_CurrentLocation(); // 0
    
    }

}
