using UnityEngine;

namespace Mapbox.Utils.JsonConverters
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PolylineToVector2dListConverter : CustomCreationConverter<System.Collections.Generic.List<Mapbox.Utils.Vector2d>>
    {
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override bool CanWrite { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override bool get_CanWrite()
        {
            return true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override System.Collections.Generic.List<Mapbox.Utils.Vector2d> Create(System.Type objectType)
        {
            System.NotImplementedException val_1 = new System.NotImplementedException();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Mapbox.Utils.Vector2d> Create(System.Type objectType, string polyLine)
        {
            return Mapbox.Utils.PolylineUtils.Decode(encodedPath:  polyLine, precision:  5);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void WriteJson(Mapbox.Json.JsonWriter writer, object value, Mapbox.Json.JsonSerializer serializer)
        {
            object val_4 = value;
            if(val_4 != null)
            {
                    val_4 = 0;
            }
            
            serializer.Serialize(jsonWriter:  writer, value:  Mapbox.Utils.PolylineUtils.Encode(path:  val_4, precision:  5));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override object ReadJson(Mapbox.Json.JsonReader reader, System.Type objectType, object existingValue, Mapbox.Json.JsonSerializer serializer)
        {
            return Mapbox.Utils.PolylineUtils.Decode(encodedPath:  Mapbox.Json.Linq.JToken.op_Explicit(value:  Mapbox.Json.Linq.JToken.Load(reader:  reader)), precision:  5);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PolylineToVector2dListConverter()
        {
        
        }
    
    }

}
