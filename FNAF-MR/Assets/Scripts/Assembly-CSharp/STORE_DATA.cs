using System.Collections.Generic;

public sealed class STORE_DATA
{
	public class Badge
	{
		public string BadgeArtRef { get; set; }

		public string BadgeLocRef { get; set; }
	}

	public class Contents
	{
		public Item Item1 { get; set; }

		public Item Item2 { get; set; }

		public Item Item3 { get; set; }

		public Item Item4 { get; set; }

		public Item Item5 { get; set; }

		public Item Item6 { get; set; }
	}

	public class Cost
	{
		public int HardCurrency { get; set; }

		public int SoftCurrency { get; set; }
	}

	public class Entry
	{
		public string PurchasableLogical { get; set; }

		public string PurchasableName { get; set; }

		public string PurchasableNameRef { get; set; }

		public string LiveState { get; set; }

		public string Description { get; set; }

		public string DescriptionRef { get; set; }

		public string StoreSection { get; set; }

		public int Order { get; set; }

		public string DialogArtRef { get; set; }

		public string ArtRef { get; set; }

		public string Repeatable { get; set; }

		public string Subscription { get; set; }

		public Contents Contents { get; set; }

		public Cost Cost { get; set; }

		public Badge Badge { get; set; }

		public string ButtonLocOverride { get; set; }
	}

	public class Item
	{
		public string Logical { get; set; }

		public string Type { get; set; }

		public int Qty { get; set; }
	}

	public class Root
	{
		public List<Entry> Entries { get; set; }
	}
}
