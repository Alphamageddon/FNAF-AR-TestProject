using System.Collections.Generic;

public sealed class MODCATEGORIES_DATA
{
	public class Entry
	{
		public string ModCatLogical { get; set; }

		public string ModCatName { get; set; }

		public string ModCatRef { get; set; }

		public string ModCatDesc { get; set; }

		public string ModCatDescRef { get; set; }

		public string LiveState { get; set; }

		public int Order { get; set; }
	}

	public class Root
	{
		public List<Entry> Entries { get; set; }
	}
}
