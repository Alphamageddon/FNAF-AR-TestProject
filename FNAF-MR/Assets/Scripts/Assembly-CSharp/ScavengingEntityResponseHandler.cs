using System;
using System.Collections.Generic;

public class ScavengingEntityResponseHandler : EventResponseHandler
{
	private Func<ServerData, ScavengingEntitySynchronizeableState> loader;

	private Action<List<ScavengingEntitySynchronizeableState>> playerScavengingEntityDataLoaded;

	public void Setup(Func<ServerData, ScavengingEntitySynchronizeableState> entityLoader, Action<List<ScavengingEntitySynchronizeableState>> callback)
	{
		loader = entityLoader;
		playerScavengingEntityDataLoaded = callback;
	}

	public void TryHandleResponse(ServerData data)
	{
		if (data.GetServerData("ScavengingEntities") != null)
		{
			HandleResponse(data.GetServerData("ScavengingEntities"));
		}
	}

	private void HandleResponse(ServerData data)
	{
		playerScavengingEntityDataLoaded(ConstructMapEntities(data));
	}

	private List<ScavengingEntitySynchronizeableState> ConstructMapEntities(ServerData data)
	{
		List<ScavengingEntitySynchronizeableState> list = new List<ScavengingEntitySynchronizeableState>();
		foreach (string key in data.Keys)
		{
			list.Add(loader(data.GetServerData(key.ToString())));
		}
		return list;
	}
}
