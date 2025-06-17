using UnityEngine;

namespace Mapbox.Unity.Map
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class MapboxDefaultVector
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Mapbox.Unity.Map.Style GetParameters(Mapbox.Unity.Map.VectorSourceType defaultElevation)
        {
            var val_5;
            string val_6;
            Mapbox.Unity.Map.Style val_1 = null;
            val_5 = val_1;
            val_1 = new Mapbox.Unity.Map.Style();
            if(defaultElevation == 0)
            {
                goto label_1;
            }
            
            if(defaultElevation == 1)
            {
                goto label_2;
            }
            
            if(defaultElevation != 2)
            {
                    return (Mapbox.Unity.Map.Style)val_5;
            }
            
            System.Exception val_2 = new System.Exception(message:  "Invalid type : Custom");
            label_1:
            Mapbox.Unity.Map.Style val_3 = null;
            val_5 = val_3;
            val_3 = new Mapbox.Unity.Map.Style();
            if(val_5 == null)
            {
                goto label_4;
            }
            
            .Id = "mapbox.3d-buildings,mapbox.mapbox-streets-v7";
            goto label_5;
            label_2:
            Mapbox.Unity.Map.Style val_4 = null;
            val_5 = val_4;
            val_4 = new Mapbox.Unity.Map.Style();
            if(val_5 == null)
            {
                goto label_6;
            }
            
            .Id = "mapbox.mapbox-streets-v7";
            goto label_7;
            label_4:
            mem[24] = "mapbox.3d-buildings,mapbox.mapbox-streets-v7";
            label_5:
            val_6 = "Mapbox Streets With Building Ids";
            goto label_8;
            label_6:
            mem[24] = "mapbox.mapbox-streets-v7";
            label_7:
            val_6 = "Mapbox Streets";
            label_8:
            .Name = val_6;
            return (Mapbox.Unity.Map.Style)val_5;
        }
    
    }

}
