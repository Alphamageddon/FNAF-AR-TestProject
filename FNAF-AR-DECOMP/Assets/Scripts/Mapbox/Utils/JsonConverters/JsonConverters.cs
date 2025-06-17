using UnityEngine;

namespace Mapbox.Utils.JsonConverters
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class JsonConverters
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static Mapbox.Json.JsonConverter[] converters;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Mapbox.Json.JsonConverter[] Converters { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Mapbox.Json.JsonConverter[] get_Converters()
        {
            null = null;
            return (Mapbox.Json.JsonConverter[])Mapbox.Utils.JsonConverters.JsonConverters.converters;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static JsonConverters()
        {
            Mapbox.Json.JsonConverter[] val_1 = new Mapbox.Json.JsonConverter[3];
            Mapbox.Utils.JsonConverters.LonLatToVector2dConverter val_2 = new Mapbox.Utils.JsonConverters.LonLatToVector2dConverter();
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(val_2 != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(val_2 == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = val_2;
            val_1[1] = new Mapbox.Utils.JsonConverters.BboxToVector2dBoundsConverter();
            val_1[2] = new Mapbox.Utils.JsonConverters.PolylineToVector2dListConverter();
            Mapbox.Utils.JsonConverters.JsonConverters.converters = val_1;
        }
    
    }

}
