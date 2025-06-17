using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Bson
{
	[Preserve]
	internal class BsonValue : BsonToken
	{
		private readonly object _value;

		private readonly BsonType _type;

		public object Value => _value;

		public override BsonType Type => _type;

		public BsonValue(object value, BsonType type)
		{
			_value = value;
			_type = type;
		}
	}
}
