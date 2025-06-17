using System.Collections.Generic;

public class PlayerAnimatronicInventory
{
	private Dictionary<string, int> inventory;

	public PlayerAnimatronicInventory()
	{
		inventory = new Dictionary<string, int>();
	}

	public void AddItem(string name, int amount)
	{
		if (inventory.ContainsKey(name))
		{
			inventory[name] += amount;
		}
		else
		{
			inventory.Add(name, amount);
		}
	}

	public Dictionary<string, int> GetInventory()
	{
		return inventory;
	}
}
