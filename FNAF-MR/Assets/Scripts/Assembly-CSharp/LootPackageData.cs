using System.Collections.Generic;

public class LootPackageData
{
	public string Logical;

	public string CrateInfo;

	public LootPackageTable[] Tables;

	public LootPackageData(LOOT_PACKAGE_DATA.Entry entry)
	{
		if (entry != null)
		{
			if (entry.Logical != null)
			{
				Logical = entry.Logical;
			}
			if (entry.CrateInfo != null)
			{
				CrateInfo = entry.CrateInfo;
			}
			Tables = LoadTables(entry.Tables);
		}
	}

	public LootPackageTable[] LoadTables(List<LOOT_PACKAGE_DATA.table> rawTables)
	{
		if (rawTables == null)
		{
			return null;
		}
		if (rawTables.Count < 1)
		{
			return new LootPackageTable[0];
		}
		LootPackageTable[] array = new LootPackageTable[rawTables.Count];
		foreach (LOOT_PACKAGE_DATA.table rawTable in rawTables)
		{
			array[rawTables.IndexOf(rawTable)] = new LootPackageTable(rawTable);
		}
		return array;
	}
}
