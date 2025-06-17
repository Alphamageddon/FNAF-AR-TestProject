using System.Collections.Generic;

public sealed class LOOT_STRUCTURE_DATA
{
	public class Eligibility
	{
		public string LimitId { get; set; }

		public string Operator { get; set; }

		public int NumberValue { get; set; }

		public int RangeMin { get; set; }

		public int RangeMax { get; set; }

		public string StringValue { get; set; }
	}

	public class Entry
	{
		public string Logical { get; set; }

		public List<lootPackage> LootPackages { get; set; }
	}

	public class lootPackage
	{
		public Eligibility Eligibility { get; set; }

		public string LootPackage { get; set; }
	}

	public class Root
	{
		public List<Entry> Entries { get; set; }
	}
}
