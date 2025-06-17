using System.Collections.Generic;

public sealed class LOOT_ITEM_DATA
{
	public class Entry
	{
		public string Item { get; set; }

		public string Logical { get; set; }

		public string Type { get; set; }

		public string Subtype { get; set; }

		public string IconRef { get; set; }
	}

	public class Root
	{
		public List<Entry> Entries { get; set; }
	}
}
