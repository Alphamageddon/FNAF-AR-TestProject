using System.Collections.Generic;

public sealed class SCAVENGING_DATA
{
	public class Entry
	{
		public string Logical { get; set; }

		public Environment Environment { get; set; }
	}

	public class Environment
	{
		public string Bundle { get; set; }

		public string Asset { get; set; }
	}

	public class Root
	{
		public List<Entry> Entries { get; set; }
	}
}
