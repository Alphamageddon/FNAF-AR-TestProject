using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using UnityEngine;

namespace Newtonsoft.Json.Converters
{
	public class QuaternionConverter : JsonConverter
	{
		public override bool CanRead => true;

		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			Quaternion quaternion = (Quaternion)value;
			writer.WriteStartObject();
			writer.WritePropertyName("w");
			writer.WriteValue(quaternion.w);
			writer.WritePropertyName("x");
			writer.WriteValue(quaternion.x);
			writer.WritePropertyName("y");
			writer.WriteValue(quaternion.y);
			writer.WritePropertyName("z");
			writer.WriteValue(quaternion.z);
			writer.WritePropertyName("eulerAngles");
			writer.WriteStartObject();
			writer.WritePropertyName("x");
			writer.WriteValue(quaternion.eulerAngles.x);
			writer.WritePropertyName("y");
			writer.WriteValue(quaternion.eulerAngles.y);
			writer.WritePropertyName("z");
			writer.WriteValue(quaternion.eulerAngles.z);
			writer.WriteEndObject();
			writer.WriteEndObject();
		}

		public override bool CanConvert(Type objectType)
		{
			return (object)objectType == typeof(Quaternion);
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			JObject jObject = JObject.Load(reader);
			List<JProperty> source = jObject.Properties().ToList();
			Quaternion quaternion = default(Quaternion);
			if (source.Any((JProperty p) => p.Name == "w"))
			{
				quaternion.w = (float)jObject["w"];
			}
			if (source.Any((JProperty p) => p.Name == "x"))
			{
				quaternion.x = (float)jObject["x"];
			}
			if (source.Any((JProperty p) => p.Name == "y"))
			{
				quaternion.y = (float)jObject["y"];
			}
			if (source.Any((JProperty p) => p.Name == "z"))
			{
				quaternion.z = (float)jObject["z"];
			}
			if (source.Any((JProperty p) => p.Name == "eulerAngles"))
			{
				JToken jToken = jObject["eulerAngles"];
				quaternion.eulerAngles = new Vector3
				{
					x = (float)jToken["x"],
					y = (float)jToken["y"],
					z = (float)jToken["z"]
				};
			}
			return quaternion;
		}
	}
}
