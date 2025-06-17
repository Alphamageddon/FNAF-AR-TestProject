using UnityEngine;

namespace Mapbox.Utils.JsonConverters
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class BboxToVector2dBoundsConverter : CustomCreationConverter<Mapbox.Utils.Vector2dBounds>
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
        public override Mapbox.Utils.Vector2dBounds Create(System.Type objectType)
        {
            System.NotImplementedException val_1 = new System.NotImplementedException();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Utils.Vector2dBounds Create(System.Type objectType, Mapbox.Json.Linq.JArray val)
        {
            Mapbox.Utils.Vector2dBounds val_0;
            double val_2 = Mapbox.Json.Linq.JToken.op_Explicit(value:  val.Item[0]);
            double val_4 = Mapbox.Json.Linq.JToken.op_Explicit(value:  val.Item[1]);
            double val_6 = Mapbox.Json.Linq.JToken.op_Explicit(value:  val.Item[2]);
            double val_8 = Mapbox.Json.Linq.JToken.op_Explicit(value:  val.Item[3]);
            return val_0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override object ReadJson(Mapbox.Json.JsonReader reader, System.Type objectType, object existingValue, Mapbox.Json.JsonSerializer serializer)
        {
            Mapbox.Json.Linq.JArray val_1 = Mapbox.Json.Linq.JArray.Load(reader:  reader);
            Mapbox.Utils.Vector2dBounds val_2 = val_1.Create(objectType:  0, val:  val_1);
            return (object)???;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void WriteJson(Mapbox.Json.JsonWriter writer, object value, Mapbox.Json.JsonSerializer serializer)
        {
            serializer.Serialize(jsonWriter:  writer, value:  null);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public BboxToVector2dBoundsConverter()
        {
        
        }
    
    }

}
