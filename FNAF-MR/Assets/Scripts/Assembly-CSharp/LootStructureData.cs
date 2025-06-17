using System.Collections.Generic;

public class LootStructureData
{
	public string Logical;

	public string CrateInfo;

	public LootStructurePackage[] LootPackages;

	public LootStructureData(LOOT_STRUCTURE_DATA.Entry entry)
	{
		if (entry != null)
		{
			if (entry.Logical != null)
			{
				Logical = entry.Logical;
			}
			if (entry.LootPackages != null)
			{
				LootPackages = LoadPackages(entry.LootPackages);
			}
		}
	}

	public LootStructurePackage[] LoadPackages(List<LOOT_STRUCTURE_DATA.lootPackage> rawLootPackages)
	{
		if (rawLootPackages == null)
		{
			return null;
		}
		if (rawLootPackages.Count < 1)
		{
			return new LootStructurePackage[0];
		}
		LootStructurePackage[] array = new LootStructurePackage[rawLootPackages.Count];
		foreach (LOOT_STRUCTURE_DATA.lootPackage rawLootPackage in rawLootPackages)
		{
			array[rawLootPackages.IndexOf(rawLootPackage)] = new LootStructurePackage(rawLootPackage);
		}
		return array;
	}
}
