using System;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;

namespace DiscordRPC.Converters
{
	internal class EnumSnakeCaseConverter : JsonConverter
	{
		public override bool CanConvert(Type objectType)
		{
			return objectType.IsEnum;
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			if (reader.Value == null)
			{
				return null;
			}
			object obj = null;
			if (TryParseEnum(objectType, (string)reader.Value, out obj))
			{
				return obj;
			}
			return existingValue;
		}

		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			Type type = value.GetType();
			string value2 = Enum.GetName(type, value);
			MemberInfo[] members = type.GetMembers(BindingFlags.Static | BindingFlags.Public);
			foreach (MemberInfo memberInfo in members)
			{
				if (memberInfo.Name.Equals(value2))
				{
					object[] customAttributes = memberInfo.GetCustomAttributes(typeof(EnumValueAttribute), inherit: true);
					if (customAttributes.Length != 0)
					{
						value2 = ((EnumValueAttribute)customAttributes[0]).Value;
					}
				}
			}
			writer.WriteValue(value2);
		}

		public bool TryParseEnum(Type enumType, string str, out object obj)
		{
			if (str == null)
			{
				obj = null;
				return false;
			}
			Type type = enumType;
			if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>))
			{
				type = type.GetGenericArguments().First();
			}
			if (!type.IsEnum)
			{
				obj = null;
				return false;
			}
			MemberInfo[] members = type.GetMembers(BindingFlags.Static | BindingFlags.Public);
			foreach (MemberInfo memberInfo in members)
			{
				object[] customAttributes = memberInfo.GetCustomAttributes(typeof(EnumValueAttribute), inherit: true);
				for (int j = 0; j < customAttributes.Length; j++)
				{
					EnumValueAttribute enumValueAttribute = (EnumValueAttribute)customAttributes[j];
					if (str.Equals(enumValueAttribute.Value))
					{
						obj = Enum.Parse(type, memberInfo.Name, ignoreCase: true);
						return true;
					}
				}
			}
			obj = null;
			return false;
		}
	}
}
