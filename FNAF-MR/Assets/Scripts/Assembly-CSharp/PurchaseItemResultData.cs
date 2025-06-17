using System.Collections.Generic;
using PlayFab.ClientModels;

public class PurchaseItemResultData
{
	public List<IllumixItemInstance> items;

	public PurchaseItemResultData(PurchaseItemResult result)
	{
		items = new List<IllumixItemInstance>();
		if (result.Items.Count < 1)
		{
			return;
		}
		foreach (ItemInstance item in result.Items)
		{
			items.Add(new IllumixItemInstance(item));
		}
	}
}
