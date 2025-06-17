using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Bson
{
	[Preserve]
	internal class BsonRegex : BsonToken
	{
		public BsonString Pattern { get; set; }

		public BsonString Options { get; set; }

		public override BsonType Type => BsonType.Regex;

		public BsonRegex(string pattern, string options)
		{
			Pattern = new BsonString(pattern, includeLength: false);
			Options = new BsonString(options, includeLength: false);
		}
	}
}
