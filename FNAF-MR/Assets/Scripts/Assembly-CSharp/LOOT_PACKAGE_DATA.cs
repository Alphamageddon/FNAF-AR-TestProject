using System.Collections.Generic;

public sealed class LOOT_PACKAGE_DATA
{
	public class Entry
	{
		public string Logical { get; set; }

		public string CrateInfo { get; set; }

		public List<table> Tables { get; set; }
	}

	public class Root
	{
		public List<Entry> Entries { get; set; }
	}

	public class table
	{
		public string Table { get; set; }

		public double ProcRate { get; set; }

		public int Rolls { get; set; }
	}
}
