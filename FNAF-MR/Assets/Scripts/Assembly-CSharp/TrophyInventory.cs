using System.Collections.Generic;

public class TrophyInventory
{
	public Dictionary<string, int> entries { get; set; }

	public TrophyInventory()
	{
		entries = new Dictionary<string, int>();
	}

	public void Add(string key, int amount)
	{
		entries.Add(key, amount);
	}
}
