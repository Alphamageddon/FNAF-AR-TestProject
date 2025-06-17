using System.Collections.Generic;

public class CPUInventory
{
	public Dictionary<string, int> entries { get; set; }

	public CPUInventory()
	{
		entries = new Dictionary<string, int>();
	}

	public void Add(string key, int amount)
	{
		entries.Add(key, amount);
	}
}
