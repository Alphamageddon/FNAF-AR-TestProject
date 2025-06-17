using System;
using System.Collections.Generic;
using System.Linq;

public class ModInventory
{
	public Dictionary<ModData, int> entries { get; set; }

	public ModInventory()
	{
		entries = new Dictionary<ModData, int>();
	}

	public bool ContainsMod(ModData modData)
	{
		foreach (ModData key in entries.Keys)
		{
			if (key == modData)
			{
				return true;
			}
		}
		return false;
	}

	public void AddMod(ModData key, int amount)
	{
		entries.Add(key, amount);
	}

	public void RemoveMod(ModData key, int amount)
	{
		ModData modData = null;
		foreach (ModData key2 in entries.Keys)
		{
			if (key2.Id == key.Id)
			{
				modData = key2;
			}
		}
		if (modData != null)
		{
			if (entries[modData] > amount)
			{
				entries[modData] -= amount;
			}
			else
			{
				entries.Remove(modData);
			}
		}
	}

	public Dictionary<ModData, int> GetMods()
	{
		Dictionary<ModData, int> dictionary = new Dictionary<ModData, int>();
		foreach (ModData key in entries.Keys)
		{
			dictionary.Add(key, entries[key]);
		}
		return dictionary;
	}

	public Dictionary<ModData, int> GetRandomItems()
	{
		Dictionary<ModData, int> dictionary = new Dictionary<ModData, int>();
		List<ModData> list = new List<ModData>();
		foreach (ModData key in entries.Keys)
		{
			list.Add(key);
		}
		Random rng = new Random();
		list.OrderBy((ModData _) => rng.Next()).ToList();
		foreach (ModData item in list)
		{
			dictionary.Add(item, entries[item]);
		}
		return dictionary;
	}

	public void UpdateFromLookup(ItemDefinitions itemDefinitions)
	{
		foreach (ModData key in entries.Keys)
		{
			ModData modById = itemDefinitions.GetModById(key.Id);
			key.Copy(modById);
		}
	}
}
