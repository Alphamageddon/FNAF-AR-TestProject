using System.Collections.Generic;

public sealed class LOC_DATA
{
	public class Entry
	{
		public string ID { get; set; }

		public string English { get; set; }

		public string French { get; set; }

		public string Italian { get; set; }

		public string German { get; set; }

		public string Spanish_Spain { get; set; }

		public string Portuguese_Brazil { get; set; }

		public string Russian { get; set; }
	}

	public class Root
	{
		public List<Entry> Entries { get; set; }
	}
}
