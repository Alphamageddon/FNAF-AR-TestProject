public class LootItemData
{
	public string Item;

	public string Type;

	public string Subtype;

	public string IconRef;

	public string Logical;

	public LootItemData(LOOT_ITEM_DATA.Entry entry)
	{
		if (entry != null)
		{
			if (entry.Item != null)
			{
				Item = entry.Item;
			}
			if (entry.Type != null)
			{
				Type = entry.Type;
			}
			if (entry.Subtype != null)
			{
				Subtype = entry.Subtype;
			}
			if (entry.IconRef != null)
			{
				IconRef = entry.IconRef;
			}
			if (entry.Logical != null)
			{
				Logical = entry.Logical;
			}
		}
	}

	public LootItemData(string logical, string type, string subtype)
	{
		Logical = logical;
		Item = logical;
		Type = type;
		Subtype = subtype;
		IconRef = "";
	}
}
