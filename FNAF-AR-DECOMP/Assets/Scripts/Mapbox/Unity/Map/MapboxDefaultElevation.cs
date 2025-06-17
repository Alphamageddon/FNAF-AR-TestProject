using UnityEngine;

namespace Mapbox.Unity.Map
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class MapboxDefaultElevation
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Mapbox.Unity.Map.Style GetParameters(Mapbox.Unity.Map.ElevationSourceType defaultElevation)
        {
            var val_4;
            Mapbox.Unity.Map.Style val_1 = null;
            val_4 = val_1;
            val_1 = new Mapbox.Unity.Map.Style();
            if(defaultElevation != 0)
            {
                    if(defaultElevation != 1)
            {
                    return (Mapbox.Unity.Map.Style)val_4;
            }
            
                System.Exception val_2 = new System.Exception(message:  "Invalid type : Custom");
            }
            
            Mapbox.Unity.Map.Style val_3 = null;
            val_4 = val_3;
            val_3 = new Mapbox.Unity.Map.Style();
            if(val_4 != null)
            {
                    .Id = "mapbox.terrain-rgb";
            }
            else
            {
                    mem[24] = "mapbox.terrain-rgb";
            }
            
            .Name = "Mapbox Terrain";
            return (Mapbox.Unity.Map.Style)val_4;
        }
    
    }

}
