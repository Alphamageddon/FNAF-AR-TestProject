using System.Collections.Generic;

public class PlayerInventory
{
	private const string Auto = "Auto";

	private const string Common = "Common";

	private const string Uncommon = "Uncommon";

	private const string Rare = "Rare";

	private const string PlushSuitKey = "PlushSuit";

	private Dictionary<string, PlayerAnimatronicInventory> inventory;

	public PlayerInventory()
	{
		inventory = new Dictionary<string, PlayerAnimatronicInventory>();
	}

	public void AddItem(string animatronicId, RewardItem item)
	{
		if (!inventory.ContainsKey(animatronicId))
		{
			inventory.Add(animatronicId, new PlayerAnimatronicInventory());
		}
		inventory[animatronicId].AddItem(item.item, item.amount);
	}

	public void SetItem(string name, PlayerAnimatronicInventory item)
	{
		if (inventory.ContainsKey(name))
		{
			inventory.Remove(name);
		}
		inventory.Add(name, item);
	}

	public List<string> GetPlushSuits()
	{
		List<string> list = new List<string>();
		foreach (string key in inventory.Keys)
		{
			if (HasPlushSuit(key))
			{
				list.Add(key);
			}
		}
		return list;
	}

	private int GetItemCount(string animatronicId, string itemName)
	{
		if (!inventory.ContainsKey(animatronicId))
		{
			return 0;
		}
		PlayerAnimatronicInventory playerAnimatronicInventory = inventory[animatronicId];
		if (!playerAnimatronicInventory.GetInventory().ContainsKey(itemName))
		{
			return 0;
		}
		return playerAnimatronicInventory.GetInventory()[itemName];
	}

	private bool HasPlushSuit(string animatronicId)
	{
		return GetItemCount(animatronicId, "PlushSuit") > 0;
	}
}
