using System;
using Newtonsoft.Json.Linq;
using UnityEngine;

namespace Newtonsoft.Json.Converters
{
	public class ResolutionConverter : JsonConverter
	{
		public override bool CanRead => true;

		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			Resolution resolution = (Resolution)value;
			writer.WriteStartObject();
			writer.WritePropertyName("height");
			writer.WriteValue(resolution.height);
			writer.WritePropertyName("width");
			writer.WriteValue(resolution.width);
			writer.WritePropertyName("refreshRate");
			writer.WriteValue(resolution.refreshRate);
			writer.WriteEndObject();
		}

		public override bool CanConvert(Type objectType)
		{
			return (object)objectType == typeof(Resolution);
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			JObject jObject = JObject.Load(reader);
			return new Resolution
			{
				height = (int)jObject["height"],
				width = (int)jObject["width"],
				refreshRate = (int)jObject["refreshRate"]
			};
		}
	}
}
