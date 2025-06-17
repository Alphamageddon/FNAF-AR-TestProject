using System;

public class CPUInventoryResponseHandler : EventResponseHandler
{
	private Action<CPUInventory> CPUInventoryUpdated;

	public void Setup(Action<CPUInventory> callback)
	{
		CPUInventoryUpdated = callback;
	}

	public void TryHandleResponse(ServerData data)
	{
		if (data.GetServerData("CPUInventory") != null)
		{
			HandleResponse(data.GetServerData("CPUInventory"));
		}
	}

	private void HandleResponse(ServerData data)
	{
		CPUInventory cPUInventory = new CPUInventory();
		foreach (string key in data.Keys)
		{
			cPUInventory.Add(key, data.GetInt(key).Value);
		}
		CPUInventoryUpdated(cPUInventory);
	}
}
