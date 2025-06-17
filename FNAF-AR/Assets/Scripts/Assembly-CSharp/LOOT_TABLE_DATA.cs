using System.Collections.Generic;

public sealed class LOOT_TABLE_DATA
{
	public class Entry
	{
		public string Logical { get; set; }

		public List<Item> Items { get; set; }
	}

	public class Item
	{
		public string ItemName { get; set; }

		public float Min { get; set; }

		public float Max { get; set; }

		public int Weight { get; set; }
	}

	public class Root
	{
		public List<Entry> Entries { get; set; }
	}
}
