using PlayFab.ClientModels;

public class IllumixItemInstance
{
	public string itemId;

	public int unitPrice;

	public string itemClass;

	public IllumixItemInstance(ItemInstance itemInstance)
	{
		itemId = itemInstance.ItemId;
		unitPrice = (int)itemInstance.UnitPrice;
		itemClass = itemInstance.ItemClass;
	}
}
