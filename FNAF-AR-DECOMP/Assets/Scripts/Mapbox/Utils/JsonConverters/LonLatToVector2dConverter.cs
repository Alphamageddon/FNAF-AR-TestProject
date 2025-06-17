using UnityEngine;

namespace Mapbox.Utils.JsonConverters
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class LonLatToVector2dConverter : CustomCreationConverter<Mapbox.Utils.Vector2d>
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
        public override Mapbox.Utils.Vector2d Create(System.Type objectType)
        {
            System.NotImplementedException val_1 = new System.NotImplementedException();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Utils.Vector2d Create(System.Type objectType, Mapbox.Json.Linq.JArray val)
        {
            return new Mapbox.Utils.Vector2d() {x = Mapbox.Json.Linq.JToken.op_Explicit(value:  val.Item[1]), y = Mapbox.Json.Linq.JToken.op_Explicit(value:  val.Item[0])};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void WriteJson(Mapbox.Json.JsonWriter writer, object value, Mapbox.Json.JsonSerializer serializer)
        {
            System.Array.Reverse(array:  null);
            serializer.Serialize(jsonWriter:  writer, value:  null);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override object ReadJson(Mapbox.Json.JsonReader reader, System.Type objectType, object existingValue, Mapbox.Json.JsonSerializer serializer)
        {
            Mapbox.Json.Linq.JArray val_1 = Mapbox.Json.Linq.JArray.Load(reader:  reader);
            Mapbox.Utils.Vector2d val_2 = val_1.Create(objectType:  0, val:  val_1);
            return (object)val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LonLatToVector2dConverter()
        {
        
        }
    
    }

}
