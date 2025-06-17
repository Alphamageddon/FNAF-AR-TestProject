using System.Collections.Generic;

public sealed class PROFILE_AVATAR_DATA
{
	public class Entry
	{
		public string Logical { get; set; }

		public string SpriteAtlas { get; set; }

		public string Avatar3DBundle { get; set; }

		public string ArtAssetId { get; set; }

		public string MapAssetId { get; set; }

		public string ConcreteItemID { get; set; }

		public string Name { get; set; }
	}

	public class Root
	{
		public List<Entry> Entries { get; set; }
	}
}
