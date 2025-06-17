public class LootTableData
{
	public string Logical;

	public LootTableEntry[] Items;

	public LootTableData(LOOT_TABLE_DATA.Entry entry)
	{
		if (entry.Logical != null)
		{
			Logical = entry.Logical;
		}
		if (entry.Items == null)
		{
			return;
		}
		Items = new LootTableEntry[entry.Items.Count];
		foreach (LOOT_TABLE_DATA.Item item in entry.Items)
		{
			Items[entry.Items.IndexOf(item)] = new LootTableEntry(item, item.Weight);
		}
	}
}
