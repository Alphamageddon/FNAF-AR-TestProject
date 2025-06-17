using UnityEngine;

namespace Mapbox.Unity.Map
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class MapScalingOptions
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.MapScalingType scalingType;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float unityTileSize;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.IMapScalingStrategy scalingStrategy;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapScalingOptions()
        {
            this.scalingType = 1;
        }
    
    }

}
