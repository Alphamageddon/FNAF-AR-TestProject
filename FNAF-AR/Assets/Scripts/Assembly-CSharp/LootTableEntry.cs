public class LootTableEntry
{
	public string ItemName;

	public int Min;

	public int Max;

	public int RollRange;

	public LootTableEntry(LOOT_TABLE_DATA.Item rawItemData, int rollRange)
	{
		if (rawItemData.ItemName != null)
		{
			ItemName = rawItemData.ItemName;
		}
		Min = (int)rawItemData.Min;
		Max = (int)rawItemData.Max;
		RollRange = rollRange;
	}
}
