using System;
using UnityEngine;

public class InventoryResponseHandler : EventResponseHandler
{
	private Action<PlayerInventory> InventoryUpdated;

	public void Setup(Action<PlayerInventory> callback)
	{
		InventoryUpdated = callback;
	}

	public void TryHandleResponse(ServerData data)
	{
		if (data.GetServerData("Inventory") != null)
		{
			InventoryUpdated(ConstructPlayerInventory(data.GetServerData("Inventory")));
		}
	}

	private static PlayerInventory ConstructPlayerInventory(ServerData data)
	{
		Debug.LogWarning("Constructing player inventory!");
		PlayerInventory playerInventory = new PlayerInventory();
		foreach (string key in data.Keys)
		{
			playerInventory.SetItem(key, ConstructAnimatronicInventory(data.GetServerData(key)));
		}
		return playerInventory;
	}

	private static PlayerAnimatronicInventory ConstructAnimatronicInventory(ServerData data)
	{
		PlayerAnimatronicInventory playerAnimatronicInventory = new PlayerAnimatronicInventory();
		foreach (string key in data.Keys)
		{
			Debug.LogWarning("OWNED SUIT " + data.ToString());
			playerAnimatronicInventory.AddItem(key, data.GetInt(key).Value);
		}
		return playerAnimatronicInventory;
	}
}
