using UnityEngine;

namespace Mapbox.Unity.Map
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class MapPlacementOptions
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.MapPlacementType placementType;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool snapMapToZero;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.IMapPlacementStrategy placementStrategy;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapPlacementOptions()
        {
            this.placementType = 1;
        }
    
    }

}
