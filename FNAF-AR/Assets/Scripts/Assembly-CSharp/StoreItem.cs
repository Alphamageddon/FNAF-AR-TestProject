public class StoreItem
{
	public string Id;

	public int Quantity;

	public string Type;

	public StoreItem(string id, string type, int quantity)
	{
		Id = id;
		Type = type;
		Quantity = quantity;
	}
}
